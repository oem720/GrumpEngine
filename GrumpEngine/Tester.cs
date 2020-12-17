using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace GrumpEngine
{
    class Tester
    {
        [STAThread]
        static void Main()
        {
            File.Create(Directory.GetCurrentDirectory() + "\\Config.cfg");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TopLayerShell());
            
        }
    }
}
