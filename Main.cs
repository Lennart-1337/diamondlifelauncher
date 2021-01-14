using Launcher_DiamondLifeRP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Threading;
using Launcher_DiamondLifeRP.FileSystem;


namespace Launcher_DiamondLifeRP
{
    public partial class Main : Form
    {
        const string arg = "__Your Server URL___";

        public Main()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (Debugger.IsAttached) Settings.Default.Reset();


            if (Settings.Default.Pfad == "")
            {
                SelectFile();
            }



            if (File.Exists(Settings.Default.Pfad))
            {
                updateProgressbar();

                try
                {
                    Process process = new Process { StartInfo = new ProcessStartInfo
                    {
                        FileName = Settings.Default.Pfad,
                        Arguments = arg
                        
                    } };

                    FileHandler.WriteToLog("Starting AltV.exe...(Path: " + Settings.Default.Pfad + ")");
                    process.Start();
                    process.WaitForInputIdle();

                    FileHandler.WriteToLog("Starting Anti-Cheat...");
                    AntiCheat.startAntiCheat();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten!", "DiamondLife Launcher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FileHandler.WriteToLog(ex.ToString());
                    Settings.Default.Reset();
                    Thread.Sleep(100);
                    this.Close();
                    
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Die Datei die du ausgewählt hast existiert nicht\n" +
                    "Möchtest du eine neue Datei auswählen? ", "DiamondLife Launcher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                {
                    SelectFile();
                } 
                else if(result == DialogResult.No)
                {
                    this.Close();
                }

            }

        }

        private void updateProgressbar()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                progbar_connect.PerformStep();
            }
            Thread.Sleep(3000);
            progbar_connect.Value = 0;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

           
        }

        private void SelectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.Pfad = dialog.FileName;
                Settings.Default.Save();
                MessageBox.Show("Der Pfad zu deiner Datei wurde erfolgreich gespeichert.", "DiamondLife Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {

            FileHandler.CreateFiles();
        }
    }
}
