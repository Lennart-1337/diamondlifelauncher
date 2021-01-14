using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_DiamondLifeRP.FileSystem
{
    public static class FileHandler
    {
        public static string log = AppDomain.CurrentDomain.BaseDirectory + "log.txt";
        public static string modules = AppDomain.CurrentDomain.BaseDirectory + "modules.txt";

        public static void CreateFiles()
        {

            if (!File.Exists(log))
            {
                try
                {
                    File.Create(log);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            if(!File.Exists(modules))
            {
                try
                {
                    File.Create(modules);

                }
                catch (Exception e)
                {

                    throw e;
                }
            }

        }

        public static void WriteToLog(string message)
        {
            if (!File.Exists(log))
            {
                try
                {
                    File.Create(log);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            File.AppendAllText(log, DateTime.Now + " " + message + Environment.NewLine);

        }

        public static void WriteToModules(string module)
        {
            if (!File.Exists(modules))
            {
                try
                {
                    File.Create(modules);

                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            File.AppendAllText(modules, DateTime.Now + " " + module + Environment.NewLine);
        }
    }
}
