using System;
using System.Windows.Forms;

namespace GrumpMapEditor
{
    class World
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TopLevelUI());
        }
    }
}
