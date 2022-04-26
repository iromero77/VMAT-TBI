using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace VMS.TPS
{
    public class Script
    {
        public void Execute(ScriptContext context)
        {
            try
            {
                string path = AppExePath();
                if (!string.IsNullOrEmpty(path))
                {
                    ProcessStartInfo p = new ProcessStartInfo(path);
                    string configFile = "";
                    if (File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configuration\\VMAT_TBI_config.ini")) configFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\configuration\\VMAT_TBI_config.ini";
                    if (context.Patient != null) p.Arguments = String.Format("{0} {1} {2}",context.Patient.Id,context.StructureSet.Id,configFile);
                    Process.Start(p);
                }
                else MessageBox.Show("Error! VMATTBIAutoPlan executable NOT found!");
            }
            catch (Exception e) { MessageBox.Show(e.Message); };
        }
        private string AppExePath()
        {
            return FirstExePathIn(AssemblyDirectory());
        }

        private string FirstExePathIn(string dir)
        {
            return Directory.GetFiles(dir, "*.exe").FirstOrDefault(x => x.Contains("VMATTBIAutoPlanMT"));
        }

        private string AssemblyDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}
