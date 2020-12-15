using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GrumpEngine
{
    public partial class TopLayerShell : Form
    {
        public TopLayerShell()
        {
            InitializeComponent();
        }

        public void SetTextBox(string input)
        {
            textBox2.AppendText(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            string text = "In the beginning. There was a Grump. A BIG Grump!! Owen didn't know how to encounter this problem because he was too smooth brain. So he woke up with an idea! He grabbed his boots and ran out the door. Hopped on his bike and rode off a cliff. Now Owen is no longer smooth brain.";
            TypeTextToWindow(text);
        }

        private void TypeTextToWindow(string text)
        {
            foreach (char c in text)
            {
                SetTextBox(c.ToString());
                Thread.Sleep(2);
            }
        }
    }
}
