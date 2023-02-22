using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acadApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace GCPManager
{
    public class Command
    {
        [CommandMethod("TEST")]
        public void Test()
        {
            var doc = acadApp.DocumentManager.MdiActiveDocument;
            var db = doc.Database;
            var ed = doc.Editor;
            using (var tr = db.TransactionManager.StartTransaction())
            {
                tr.Commit();
            }
        }

        [CommandMethod("GCPEdit")]
        public void GCPEdit()
        {
            GCPPopup gcpPopup = new GCPPopup();
            gcpPopup.ShowDialog();
        }
    }
}
