using System;
using System.Windows.Forms;

namespace GrumpMapEditor
{
    class World
    {
        [STAThread]
        static void Main()
        {
            //var result = MessageBox.Show("Hi", "Help", MessageBoxButtons.YesNo);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TopLevelUI());
        }
    }
}
