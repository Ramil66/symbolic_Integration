using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymbolicIntegration.FormsBuuton
{
    public partial class tg : Form
    {
        private Color buttonColor;
        private Color richTextBoxColor;
        private Color backColor;
        public tg()
        {
            InitializeComponent();
            buttonColor = roundButton1.BackColor;
            richTextBoxColor = numenator.BackColor;
            backColor = BackColor;
        }

        private void tg_Load(object sender, EventArgs e)
        {
            if (Data.SwitchTheme)
            {
                BackColor = Color.White;
                roundButton1.BackColor = Color.White;
                roundButton2.BackColor = Color.White;
                roundButton1.colorPen = Color.Black;
                roundButton2.colorPen = Color.Black;
                numenator.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                roundButton1.ForeColor = Color.Black;
                roundButton2.ForeColor = Color.Black;
                numenator.ForeColor = Color.Black;
            }
            else
            {
                BackColor = backColor;
                roundButton1.BackColor = buttonColor;
                roundButton2.BackColor = buttonColor;
                roundButton1.colorPen = Color.White;
                roundButton2.colorPen = Color.White;
                numenator.BackColor = richTextBoxColor;;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                roundButton1.ForeColor = Color.White;
                roundButton2.ForeColor = Color.White;
                numenator.ForeColor = Color.White;
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Data.MainElement = numenator.Text;
            Data.Choice = true;
            this.Close();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            Data.Choice = false;
            this.Close();
        }
    }
}
