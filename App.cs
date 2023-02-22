using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.Windows;
using GCPManager;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using acadApp = Autodesk.AutoCAD.ApplicationServices.Application;

namespace MyPlugin
{
    public class App : IExtensionApplication
    {
        //Tab will appear when starting up by Initialize()
        public void Initialize()
        {
            //Set Command class
            //Create RibbonTab
            Autodesk.Windows.RibbonControl ribbonControl = Autodesk.Windows.ComponentManager.Ribbon;
            RibbonTab tab = new RibbonTab();
            tab.Title = "JakkeLab";
            tab.Id = "App_TAB_ID";

            ribbonControl.Tabs.Add(tab);

            //Create Ribbon Panels
            Autodesk.Windows.RibbonPanelSource panel1Panel = new RibbonPanelSource();
            panel1Panel.Title = "Panel1";
            RibbonPanel Panel1 = new RibbonPanel();
            Panel1.Source = panel1Panel;
            tab.Panels.Add(Panel1);

            //Create Ribbon button
            RibbonButton pan1button = new RibbonButton();
            pan1button.Text = "Button1";
            pan1button.ShowText = true;
            pan1button.ShowImage = false;
            pan1button.Orientation = System.Windows.Controls.Orientation.Vertical;
            pan1button.Size = RibbonItemSize.Large;
            pan1button.Id = "ClickMe_1";
            pan1button.CommandHandler = new ButtonCommandHandler();
            pan1button.CommandParameter = "_GCPEdit ";                         //Place a space or semicolon at the end of command
            panel1Panel.Items.Add(pan1button);

            //Set button event
        }

        public void Terminate() { }

        //EventHandler for ribbonbuttons
        public class ButtonCommandHandler : System.Windows.Input.ICommand
        {
            public event EventHandler CanExecuteChanged;
            public bool CanExecute(object parameter)
            {
                return true;
            }
            public void Execute(object parameter)
            {
                Document doc = acadApp.DocumentManager.MdiActiveDocument;
                RibbonButton btn = parameter as RibbonButton;
                if (btn != null)
                {
                    doc.SendStringToExecute(
                        (string)btn.CommandParameter, true, false, true);   //btn.CommandParameter = Command (ex. "_Line ")
                }
            }


        }
        public class Images
        {
            public static BitmapImage getBitmap(Bitmap image)
            {
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Png);
                BitmapImage bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.StreamSource = stream;
                bmp.EndInit();

                return bmp;
            }
        }

    }
}

