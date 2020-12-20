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
        EncounterEditor mEE;
        
        public EncounterSelectionButton(ref EncounterType et)
        {
            internButton = new Button();
            mEE = new EncounterEditor(ref et);

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
                mEE.Hide();
            }
            else
            {
                mEE.Show();
            }
        }
    }
}
