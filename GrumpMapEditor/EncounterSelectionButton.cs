using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrumpEngine;

namespace GrumpMapEditor
{
    class EncounterSelectionButton
    {
        Button internButton;
        EncounterType mET;

        EncounterEditor mEE = new EncounterEditor();

        public EncounterSelectionButton(EncounterType et = null)
        {
            internButton = new Button();
            mET = et;

            if(et != null)
            {
                internButton.Text = et.OutwardValue.ToString();
            }
            else
            {
                internButton.Text = "-1";
            }            

            internButton.Click += new EventHandler(InternButton_Click);
        }

        public Button Button
        {
            get { return internButton; }
        }

        private void InternButton_Click(object sender, EventArgs e)
        {
            if (mEE.Visible)
            {
                mEE.Close();
            }
            else
            {
                mEE.Show();
            }
        }
    }
}
