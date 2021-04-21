using System;
using System.Collections.Generic;
using System.Diagnostics;
using Launcher_DiamondLifeRP.FileSystem;

namespace Launcher_DiamondLifeRP
{
    public static class AntiCheat
    {
        static string[] trustedModules = new string[] { "bink2w64.dll", "d3dcompiler_46.dll", "d3dcsx_46.dll" };

        static bool gtaRunning = false;

        static Process process_gta;

        public static void startAntiCheat()
        {
           while(!gtaRunning)
            {
                Process[] proccessList = Process.GetProcessesByName("GTAV");

                if(proccessList.Length != 0)
                {
                    gtaRunning = true;
                    process_gta = proccessList[0];
                    break;
                }

            }

            getModules(process_gta);

        }

        private static void getModules(Process proccess)
        {
            List<String> modules = new List<String>();

            foreach(ProcessModule m in proccess.Modules)
            {
                modules.Add(m.FileName);
            }

            foreach(string m in modules)
            {
                FileHandler.WriteToModules(m);
            }
        }
    }
}
