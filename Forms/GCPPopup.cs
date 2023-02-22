using Autodesk.AutoCAD.ApplicationServices;
using acap = Autodesk.AutoCAD.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;

namespace GCPManager
{
    public partial class GCPPopup : Form
    {
        public GCPPopup()
        {
            InitializeComponent();

            dgvGCP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btAddGCP_Click(object sender, EventArgs e)
        {
            int rCount = dgvGCP.Rows.Count;
            dgvGCP.Rows.Add(rCount + 1, "", "", "");
        }

        private void btDeleteGCP_Click(object sender, EventArgs e)
        {

            //Delete rows selected
            foreach (DataGridViewRow dgvRow in dgvGCP.SelectedRows)
            {
                dgvGCP.Rows.Remove(dgvRow);
            }
            //Renumbering GCP Numbers
            for (int i = 0; i < dgvGCP.Rows.Count; i++)
            {
                dgvGCP.Rows[i].Cells[0].Value = i + 1;
            }
        }

        //Load CSV
        private void smiLoadCSV_Click(object sender, EventArgs e)
        {
            PrintOnTable();
        }

        //Save CSV
        private void smiSaveCSV_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        //Editting control; Only decimal data
        private void dgvGCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar == 8 && e.KeyChar == '.')
                e.Handled = true;
        }

        private void dgvGCP_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.CellStyle.BackColor = Color.AliceBlue;
        }

        private void stmNewFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (dgvGCP.Rows.Count != 0)
            {
                if (MessageBox.Show("Do you create new GCP Table?\nExisting data will removed.",
                    "New File", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dgvGCP.Rows.Clear();
                }
                else
                {

                }
            }
        }

        private void btnAddtoDWG_Click(object sender, EventArgs e)
        {
            List<Point3d> points = CreatePointData();
            foreach(Point3d pt in points)
            {
                addingPoint(pt);
            }
        }
        /***Methods***/


        //1. Save CSV
        private void ExportCSV()
        {
            SaveFileDialog saveFileDialog = GetCsvSave();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSV(saveFileDialog.FileName, dgvGCP, true);
            }
        }

        //Set SaveFileDialog
        private SaveFileDialog GetCsvSave()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.CheckFileExists = false;
            saveDialog.AddExtension = true;
            saveDialog.ValidateNames = true;


            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string filepath = Path.GetDirectoryName(path);

            saveDialog.InitialDirectory = filepath;

            saveDialog.DefaultExt = ".csv";
            saveDialog.Filter = "CSV UTF-8 (*.csv) | *.csv";
            saveDialog.FileName = "GCPData".ToString();

            return saveDialog;
        }

        //Create CSV filestream
        private void SaveCSV(string filename, DataGridView dgview, bool header)
        {
            string delimiter = ",";     //Split texts by ","
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter csvExport = new StreamWriter(fs, Encoding.UTF8);               //Save as UTF-8 Encoding

            if (dgview.Rows.Count == 0) return;     //Return null if dgview has no row.

            //Write header if header is true;
            if (header)
            {
                for (int i = 0; i < dgview.Columns.Count; i++)
                {
                    //Write Header -> "," > Header -> "," ...
                    csvExport.Write(dgview.Columns[i].HeaderText);
                    if (i != dgview.Columns.Count - 1)
                    {
                        csvExport.Write(delimiter);
                    }
                    //Then string will be "header,header,header...,header"
                }
            }

            csvExport.Write(csvExport.NewLine);

            //Write data
            foreach (DataGridViewRow row in dgview.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dgview.Columns.Count; i++)
                    {
                        //Write value first
                        csvExport.Write(row.Cells[i].Value);

                        //Write delimiter after value
                        if (i != dgview.Columns.Count - 1)
                        {
                            csvExport.Write(delimiter);
                        }

                        //Then string would be "value1,value2,value3"
                    }
                    csvExport.Write(csvExport.NewLine);
                }
            }
            csvExport.Flush();
            csvExport.Close();
            fs.Close();

            MessageBox.Show("Exporting CSV completed");
        }

        private void dgvGCP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCell = dgvGCP.CurrentCell;
            bool IsConverted = Double.TryParse(selectedCell.Value.ToString(), out double convertedValue);
            if (IsConverted)
            {
                selectedCell.Value = convertedValue;
            }
            else
            {
                MessageBox.Show("Please enter only double data");
                selectedCell.Value = null;
            }
        }

        //2. Load CSV

        //Load string lines
        private List<string> LoadCSVData()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = ".csv files (*.csv)|*.csv";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            List<string> readLines = new List<string>();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);

                try
                {
                    while (!sr.EndOfStream)
                    {
                        readLines.Add(sr.ReadLine());
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid file");
                }
                finally
                {
                    sr.Close();
                }
                return readLines;
            }
            else
            {
                return null;
            }
        }

        //Print on table
        private void PrintOnTable()
        {
            List<string> lines = LoadCSVData();
            dgvGCP.Rows.Clear();
            try
            {
                foreach (string line in lines)
                {
                    string[] records = line.Split(',');
                    if (!records.Contains("GCP Label"))         //Skip header line
                    {
                        dgvGCP.Rows.Add(records[0], records[1], records[2], records[3]);
                    }
                }
            }
            catch
            {

            }
        }

        //Adding points to DWG
        private void addingPoint(Point3d pt)
        {
            Document doc = acap.Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor ed = doc.Editor;

            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(db.CurrentSpaceId, OpenMode.ForWrite);

                using (DBPoint dbPoint = new DBPoint(pt))
                {
                    btr.AppendEntity(dbPoint);
                    tr.AddNewlyCreatedDBObject(dbPoint, true);
                }
                tr.Commit();
            }
            ed.Regen();
        }

        private List<Point3d> CreatePointData()
        {
            List<Point3d> pts = new List<Point3d>();
            for(int i = 0; i<dgvGCP.RowCount; i++)
            {
                double ptX = Double.Parse(dgvGCP.Rows[i].Cells[2].Value.ToString());
                double ptY = Double.Parse(dgvGCP.Rows[i].Cells[1].Value.ToString());
                Point3d pt = new Point3d(ptX, ptY, 0);
                pts.Add(pt);
            }
            return pts;
        }
    }
}
