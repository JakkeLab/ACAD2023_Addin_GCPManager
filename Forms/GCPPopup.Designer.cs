namespace GCPManager
{
    partial class GCPPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smiNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLoadCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.smiSaveCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.좌표계변환ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvGCP = new System.Windows.Forms.DataGridView();
            this.clGCPLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNorthing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEasting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clElevation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbGCPTable = new System.Windows.Forms.Label();
            this.gbEditTable = new System.Windows.Forms.GroupBox();
            this.btnAddtoDWG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeleteGCP = new System.Windows.Forms.Button();
            this.btAddGCP = new System.Windows.Forms.Button();
            this.btChangeUnit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.mStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCP)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbEditTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(464, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiNewFile,
            this.smiLoadCSV,
            this.smiSaveCSV});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // smiNewFile
            // 
            this.smiNewFile.Name = "smiNewFile";
            this.smiNewFile.Size = new System.Drawing.Size(180, 22);
            this.smiNewFile.Text = "새 파일";
            this.smiNewFile.Click += new System.EventHandler(this.stmNewFile_ToolStripMenuItem_Click);
            // 
            // smiLoadCSV
            // 
            this.smiLoadCSV.Name = "smiLoadCSV";
            this.smiLoadCSV.Size = new System.Drawing.Size(180, 22);
            this.smiLoadCSV.Text = "불러오기 (.csv)";
            this.smiLoadCSV.Click += new System.EventHandler(this.smiLoadCSV_Click);
            // 
            // smiSaveCSV
            // 
            this.smiSaveCSV.Name = "smiSaveCSV";
            this.smiSaveCSV.Size = new System.Drawing.Size(180, 22);
            this.smiSaveCSV.Text = "내보내기 (.csv)";
            this.smiSaveCSV.Click += new System.EventHandler(this.smiSaveCSV_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.좌표계변환ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 좌표계변환ToolStripMenuItem
            // 
            this.좌표계변환ToolStripMenuItem.Name = "좌표계변환ToolStripMenuItem";
            this.좌표계변환ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.좌표계변환ToolStripMenuItem.Text = "좌표계 변환";
            // 
            // dgvGCP
            // 
            this.dgvGCP.AllowUserToAddRows = false;
            this.dgvGCP.AllowUserToDeleteRows = false;
            this.dgvGCP.AllowUserToResizeColumns = false;
            this.dgvGCP.AllowUserToResizeRows = false;
            this.dgvGCP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGCP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGCPLabel,
            this.clNorthing,
            this.clEasting,
            this.clElevation});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvGCP, 2);
            this.dgvGCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGCP.Location = new System.Drawing.Point(3, 24);
            this.dgvGCP.Name = "dgvGCP";
            this.dgvGCP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGCP.RowHeadersVisible = false;
            this.dgvGCP.RowTemplate.Height = 23;
            this.dgvGCP.Size = new System.Drawing.Size(458, 473);
            this.dgvGCP.TabIndex = 1;
            this.dgvGCP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGCP_CellEndEdit);
            this.dgvGCP.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvGCP_EditingControlShowing);
            this.dgvGCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvGCP_KeyPress);
            // 
            // clGCPLabel
            // 
            this.clGCPLabel.FillWeight = 50F;
            this.clGCPLabel.HeaderText = "GCP Label";
            this.clGCPLabel.Name = "clGCPLabel";
            this.clGCPLabel.ReadOnly = true;
            this.clGCPLabel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clGCPLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clGCPLabel.Width = 91;
            // 
            // clNorthing
            // 
            this.clNorthing.HeaderText = "Northing";
            this.clNorthing.Name = "clNorthing";
            this.clNorthing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clNorthing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clNorthing.Width = 121;
            // 
            // clEasting
            // 
            this.clEasting.HeaderText = "Easting";
            this.clEasting.Name = "clEasting";
            this.clEasting.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clEasting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clEasting.Width = 121;
            // 
            // clElevation
            // 
            this.clElevation.HeaderText = "Elevation";
            this.clElevation.Name = "clElevation";
            this.clElevation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clElevation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clElevation.Width = 121;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvGCP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbGCPTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbEditTable, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.259635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.74036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 577);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbGCPTable
            // 
            this.lbGCPTable.AutoSize = true;
            this.lbGCPTable.Location = new System.Drawing.Point(3, 3);
            this.lbGCPTable.Margin = new System.Windows.Forms.Padding(3);
            this.lbGCPTable.Name = "lbGCPTable";
            this.lbGCPTable.Size = new System.Drawing.Size(67, 12);
            this.lbGCPTable.TabIndex = 2;
            this.lbGCPTable.Text = "GCP Table";
            this.lbGCPTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbEditTable
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gbEditTable, 2);
            this.gbEditTable.Controls.Add(this.btnAddtoDWG);
            this.gbEditTable.Controls.Add(this.label1);
            this.gbEditTable.Controls.Add(this.btDeleteGCP);
            this.gbEditTable.Controls.Add(this.btAddGCP);
            this.gbEditTable.Controls.Add(this.btChangeUnit);
            this.gbEditTable.Controls.Add(this.comboBox1);
            this.gbEditTable.Controls.Add(this.lbUnit);
            this.gbEditTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEditTable.Location = new System.Drawing.Point(3, 503);
            this.gbEditTable.Name = "gbEditTable";
            this.gbEditTable.Size = new System.Drawing.Size(458, 71);
            this.gbEditTable.TabIndex = 3;
            this.gbEditTable.TabStop = false;
            this.gbEditTable.Text = "Table Properties";
            // 
            // btnAddtoDWG
            // 
            this.btnAddtoDWG.Location = new System.Drawing.Point(349, 41);
            this.btnAddtoDWG.Name = "btnAddtoDWG";
            this.btnAddtoDWG.Size = new System.Drawing.Size(100, 23);
            this.btnAddtoDWG.TabIndex = 8;
            this.btnAddtoDWG.Text = "Add to DWG";
            this.btnAddtoDWG.UseVisualStyleBackColor = true;
            this.btnAddtoDWG.Click += new System.EventHandler(this.btnAddtoDWG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "GCP";
            // 
            // btDeleteGCP
            // 
            this.btDeleteGCP.Location = new System.Drawing.Point(400, 12);
            this.btDeleteGCP.Name = "btDeleteGCP";
            this.btDeleteGCP.Size = new System.Drawing.Size(50, 23);
            this.btDeleteGCP.TabIndex = 5;
            this.btDeleteGCP.Text = "Delete";
            this.btDeleteGCP.UseVisualStyleBackColor = true;
            this.btDeleteGCP.Click += new System.EventHandler(this.btDeleteGCP_Click);
            // 
            // btAddGCP
            // 
            this.btAddGCP.Location = new System.Drawing.Point(349, 12);
            this.btAddGCP.Name = "btAddGCP";
            this.btAddGCP.Size = new System.Drawing.Size(50, 23);
            this.btAddGCP.TabIndex = 4;
            this.btAddGCP.Text = "Add";
            this.btAddGCP.UseVisualStyleBackColor = true;
            this.btAddGCP.Click += new System.EventHandler(this.btAddGCP_Click);
            // 
            // btChangeUnit
            // 
            this.btChangeUnit.Location = new System.Drawing.Point(178, 11);
            this.btChangeUnit.Name = "btChangeUnit";
            this.btChangeUnit.Size = new System.Drawing.Size(60, 23);
            this.btChangeUnit.TabIndex = 3;
            this.btChangeUnit.Text = "Change";
            this.btChangeUnit.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m"});
            this.comboBox1.Location = new System.Drawing.Point(102, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(9, 17);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(87, 12);
            this.lbUnit.TabIndex = 0;
            this.lbUnit.Text = "Unit(Elevation)";
            // 
            // GCPPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mStrip);
            this.MainMenuStrip = this.mStrip;
            this.Name = "GCPPopup";
            this.Text = "GCP Edit";
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGCP)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbEditTable.ResumeLayout(false);
            this.gbEditTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smiNewFile;
        private System.Windows.Forms.ToolStripMenuItem smiLoadCSV;
        private System.Windows.Forms.ToolStripMenuItem smiSaveCSV;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 좌표계변환ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvGCP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbGCPTable;
        private System.Windows.Forms.GroupBox gbEditTable;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.Button btChangeUnit;
        private System.Windows.Forms.Button btDeleteGCP;
        private System.Windows.Forms.Button btAddGCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGCPLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNorthing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEasting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clElevation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddtoDWG;
    }
}