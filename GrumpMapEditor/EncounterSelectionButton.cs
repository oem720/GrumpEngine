using System;
using System.Windows.Forms;
using GrumpEngine;

namespace GrumpMapEditor
{
    public class EncounterSelectionButton
    {
#pragma warning disable IDE0044 // Add readonly modifier
        private Button internButton;
#pragma warning restore IDE0044 // Add readonly modifier
        private EncounterEditor mEE;
#pragma warning disable IDE0044 // Add readonly modifier
        private Tile internTile;
#pragma warning restore IDE0044 // Add readonly modifier
#pragma warning disable IDE0044 // Add readonly modifier
        private ReturnedTileValueEventArgs args;
#pragma warning restore IDE0044 // Add readonly modifier

        public EncounterSelectionButton()
        {
            internButton = new Button();
            internTile = new Tile();
            mEE = new EncounterEditor(this);

            if(internTile != null)
            {
                internButton.Text = internTile.OutwardValue.ToString();
            }
            else
            {
                internButton.Text = "-1";
            }

            args = new ReturnedTileValueEventArgs { EditedTile = internTile };

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
                mEE = new EncounterEditor(this);
                mEE.Show();
            }
        }

        public void EncounterEditor_Closing(object sender, FormClosingEventArgs e)
        {
            mEE.EditorClosing(sender, args);
            internButton.Text = args.EditedTile.OutwardValue.ToString();
        }

        public EncounterEditor EditorUserInterface
        {
            get { return mEE; }
        }

        public Tile EditedTile
        {
            get { return internTile; }
        }
    }

    public class ReturnedTileValueEventArgs : EventArgs
    {
        public Tile EditedTile{ get; set; }
    }
    //test
}
