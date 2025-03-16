using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolicIntegration.FormsBuuton;


namespace SymbolicIntegration
{
    public partial class InputFunction : Form
    {
        
        private Color backColor=new Color();
        private Color richTextBoxColor=new Color();
        private Color buttonColor = new Color();
        private string function;
        private string gapFunction;
        private List<string> integral=new List<string>();
        private List<string> stepIntegral=new List<string>();
        private List<string> stepFunction=new List<string>();
        private List<int> position = new List<int>();
        public InputFunction()
        {
            InitializeComponent();
            backColor = BackColor;
            richTextBoxColor = richTextBox.BackColor;
            buttonColor=divisionButton.BackColor;
            divisionButton.Text = "( )"+Environment.NewLine+(char)0x2015+Environment.NewLine+"( )";
            degreeButton.Text = "( )" + (char)0x207D +" "+ (char)0x207E;
            logButton.Text = "log" + (char)0x208D+" "+(char)0x208E+"( )";
        }
        private void switchTheme_Click(object sender, EventArgs e)
        {

            if (switchTheme.Checked)
            {
                BackColor = Color.White;
                label1.ForeColor = Color.Black;
                themeText.ForeColor = Color.Black;
                startIntegration.ForeColor = Color.Black;
                divisionButton.ForeColor = Color.Black;
                degreeButton.ForeColor = Color.Black;
                lnButton.ForeColor = Color.Black;
                logButton.ForeColor = Color.Black;
                cosButton.ForeColor = Color.Black;
                sinButton.ForeColor = Color.Black;
                tgButton.ForeColor = Color.Black;
                ctgButton.ForeColor = Color.Black;
                richTextBox.ForeColor = Color.Black;
                richTextBox.BackColor = Color.White;
                divisionButton.BackColor= Color.White;
                degreeButton.BackColor= Color.White;
                lnButton.BackColor= Color.White;
                logButton.BackColor= Color.White;
                cosButton.BackColor= Color.White;
                sinButton.BackColor= Color.White;
                tgButton.BackColor= Color.White;
                ctgButton.BackColor= Color.White;
                startIntegration.BackColor= Color.White;
                divisionButton.colorPen = Color.Black;
                degreeButton.colorPen = Color.Black;
                lnButton.colorPen = Color.Black;
                logButton.colorPen = Color.Black;
                cosButton.colorPen = Color.Black;
                sinButton.colorPen = Color.Black;
                tgButton.colorPen= Color.Black;
                ctgButton.colorPen=Color.Black;
                startIntegration.colorPen = Color.Black;
                themeText.Text = "Светлая тема";
            }
            else
            {
                BackColor = backColor;
                label1.ForeColor = Color.White;
                themeText.ForeColor = Color.White;
                startIntegration.ForeColor = Color.White;
                divisionButton.ForeColor = Color.White;
                degreeButton.ForeColor = Color.White;
                lnButton.ForeColor = Color.White;
                logButton.ForeColor = Color.White;
                cosButton.ForeColor = Color.White;
                sinButton.ForeColor = Color.White;
                tgButton.ForeColor = Color.White;
                ctgButton.ForeColor = Color.White;
                richTextBox.ForeColor = Color.White;
                richTextBox.BackColor = richTextBoxColor;
                divisionButton.BackColor = buttonColor;
                degreeButton.BackColor = buttonColor;
                lnButton.BackColor = buttonColor;
                logButton.BackColor = buttonColor;
                cosButton.BackColor = buttonColor;
                sinButton.BackColor = buttonColor;
                tgButton.BackColor = buttonColor;
                ctgButton.BackColor = buttonColor;
                startIntegration.BackColor = buttonColor;
                divisionButton.colorPen = Color.White;
                degreeButton.colorPen = Color.White;
                lnButton.colorPen = Color.White;
                logButton.colorPen = Color.White;
                cosButton.colorPen = Color.White;
                sinButton.colorPen = Color.White;
                tgButton.colorPen = Color.White;
                ctgButton.colorPen = Color.White;
                startIntegration.colorPen = Color.White;
                themeText.Text = "Темная тема";
            }
            Data.SwitchTheme = switchTheme.Checked;
        }

        private void startIntegration_Click(object sender, EventArgs e)
        {
            try
            {
                gapFunction = richTextBox.Text;
                stepFunction.Add(gapFunction);
                function = stepFunction[0];
                for (int i = 1; i < stepFunction.Count; i++)
                {
                    for (int j = position[i - 1]; j < stepFunction[i].Length; j++)
                    {
                        function = function + stepFunction[i][j];
                    }
                }
                Data.Function = richTextBox.Text;
                Integration Integral = new Integration(function);
                Integral.integral(ref integral, ref stepIntegral);
                Data.StepInteger = stepIntegral;
                Data.Integral = integral;
                Form output = new OutputFunction();
                this.Hide();
                output.Show();
            }
            catch {
                MessageBox.Show("Ошибка! Не удалось вычислить интеграл.");
                Application.Exit();
            }
        }
        private void divisionButton_Click(object sender, EventArgs e)
        {
            Form division = new division();
            division.ShowDialog();
            if (Data.Choice)
            {
                gapFunction=richTextBox.Text;
                if (Data.MainElement.Contains("x"))
                {
                    
                    gapFunction = gapFunction + "1/"+Data.SecondaryElement+ "[1(" + Data.MainElement + ";1)]";
                }
                else if (Data.SecondaryElement.Contains("x"))
                {
                    gapFunction = gapFunction + Data.MainElement+"[1(" + Data.SecondaryElement + ";-1)]";
                }
                else
                {
                    float number=float.Parse(Data.MainElement)/float.Parse(Data.SecondaryElement);
                    gapFunction = gapFunction + number.ToString();
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectionCharOffset = 10;
                richTextBox.SelectedText = Data.MainElement;
                richTextBox.SelectionCharOffset = -5;
                richTextBox.SelectedText = ""+(char) 0x2044;
                richTextBox.SelectionCharOffset = -10;
                richTextBox.SelectedText = Data.SecondaryElement;
                richTextBox.SelectionCharOffset = 0;
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }
        private void degreeButton_Click(object sender, EventArgs e)
        {
            Form degree = new degree();
            degree.ShowDialog();
            if (Data.Choice)
            {
                gapFunction = richTextBox.Text;
                if ((Data.MainElement.Contains("x") || Data.SecondaryElement.Contains("x")))
                {
                    gapFunction = gapFunction + "[1(" + Data.MainElement + ";" + Data.SecondaryElement + ")]";
                }
                else
                {
                    double number = Math.Pow(double.Parse(Data.MainElement), double.Parse(Data.SecondaryElement));
                    gapFunction = gapFunction + number.ToString();
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText= Data.MainElement;
                richTextBox.SelectionCharOffset= 10;
                richTextBox.SelectedText = Data.SecondaryElement;
                richTextBox.SelectionCharOffset = 0;
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            Form log=new log();
            log.ShowDialog();
            if (Data.Choice) {
                gapFunction=richTextBox.Text;
                gapFunction = gapFunction + "[2(" + Data.MainElement + ";" + Data.SecondaryElement + ")]";
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "log ";
                richTextBox.SelectionCharOffset = -10;
                richTextBox.SelectedText=Data.SecondaryElement;
                richTextBox.SelectionCharOffset = 0;
                richTextBox.SelectedText = Data.MainElement;
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);                
            }
        }

        private void lnButton_Click(object sender, EventArgs e)
        {
            Form ln=new ln();
            ln.ShowDialog();
            if (Data.Choice) {
                gapFunction=richTextBox.Text;
                gapFunction = gapFunction + "[3(" + Data.MainElement + ";1)]";
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "ln " + Data.MainElement;
                Data.Choice=false;
                position.Add(richTextBox.Text.Length);
            }
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            Form cos=new cos();
            cos.ShowDialog();
            if (Data.Choice)
            {
                gapFunction = richTextBox.Text;
                if (Data.MainElement.Contains("x"))
                {
                    gapFunction = gapFunction + "[4(" + Data.MainElement + ";1)]";
                }
                else
                {
                    gapFunction = gapFunction + "cos(" + Data.MainElement + ")";
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "cos(" + Data.MainElement + ")";
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            Form sin=new sin();
            sin.ShowDialog();
            if (Data.Choice)
            {
                gapFunction = richTextBox.Text;
                if (Data.MainElement.Contains("x"))
                {
                    gapFunction = gapFunction + "[5(" + Data.MainElement + ";1)]";
                }
                else
                {
                    gapFunction = gapFunction + "sin(" + Data.MainElement + ")";
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "sin(" + Data.MainElement + ")";
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }

        private void tgButton_Click(object sender, EventArgs e)
        {
            Form tg=new tg();
            tg.ShowDialog();
            if (Data.Choice)
            {
                gapFunction = richTextBox.Text;
                if (Data.MainElement.Contains("x"))
                {
                    gapFunction = gapFunction + "[6(" + Data.MainElement + ";1)]";
                }
                else
                {
                    gapFunction = gapFunction + "sin(" + Data.MainElement + ")";
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "tg(" + Data.MainElement+")";
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }

        private void ctgButton_Click(object sender, EventArgs e)
        {
            Form ctg=new ctg();
            ctg.ShowDialog();
            if (Data.Choice)
            {
                gapFunction = richTextBox.Text;
                if (Data.MainElement.Contains("x"))
                {
                    gapFunction = gapFunction + "[7(" + Data.MainElement + ";1)]";
                }
                else
                {
                    gapFunction = gapFunction + "sin(" + Data.MainElement + ")";
                }
                stepFunction.Add(gapFunction);
                richTextBox.SelectedText = "ctg(" + Data.MainElement+")";
                Data.Choice = false;
                position.Add(richTextBox.Text.Length);
            }
        }
    }
}
