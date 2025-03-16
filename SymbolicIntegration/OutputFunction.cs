using SymbolicIntegration.FormsBuuton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SymbolicIntegration
{
    public partial class OutputFunction : Form
    {
        Color backColor;
        Color buttonColor;
        Color richTextBoxColor;
        public OutputFunction()
        {
            InitializeComponent();
            this.backColor = BackColor;
            this.buttonColor = backButton.BackColor;
            this.richTextBoxColor=richTextBox.BackColor;
        }

        private void OutputFunction_Load(object sender, EventArgs e)
        {
            if (Data.SwitchTheme)
            {
                BackColor = Color.White;
                richTextBox.BackColor = Color.White;
                IntegralRichTextBox.BackColor = Color.White;
                functionRichTextBox.BackColor = Color.White;
                backButton.BackColor = Color.White;
                exitButton.BackColor = Color.White;
                richTextBox.ForeColor = Color.Black;
                IntegralRichTextBox.ForeColor = Color.Black;
                functionRichTextBox.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                backButton.ForeColor = Color.Black;
                exitButton.ForeColor = Color.Black;
                backButton.colorPen=Color.Black;
                exitButton.colorPen=Color.Black;
            }
            else 
            { 
                BackColor = backColor;
                richTextBox.BackColor = richTextBoxColor;
                functionRichTextBox.BackColor= backColor;
                IntegralRichTextBox.BackColor = backColor;
                backButton.BackColor = buttonColor;
                exitButton.BackColor = buttonColor;
                richTextBox.ForeColor = Color.White;
                functionRichTextBox.ForeColor= Color.White;
                IntegralRichTextBox.ForeColor=Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                backButton.ForeColor = Color.White;
                exitButton.ForeColor = Color.White;
                backButton.colorPen = Color.White;
                exitButton.colorPen = Color.White;
            }
            functionRichTextBox.Text = Data.Function;
            string element;
            int indexNC;
            int indexFistBkt;
            int n;
            int indexLastBkt;
            for (int i = 0; i < Data.Integral.Count; i++) {
                element = Data.Integral[i];
                IntegralRichTextBox.SelectionCharOffset = 0;
                if (element[0]=='+')
                { 
                    IntegralRichTextBox.SelectedText =""+ element[0];
                }
                else if (element[0]=='-')
                {
                    IntegralRichTextBox.SelectedText = ""+element[0];
                }
                if (element.IndexOf("x") != (element.Length - 1))
                {
                    if (element.Contains('('))
                    {
                        string number = "";
                        for (int j = 0; j > element.IndexOf("/") && j < element.IndexOf("("); j++)
                        {
                            number = "" + element[j];
                        }
                        if (number != "1")
                        {
                            IntegralRichTextBox.SelectedText = number;
                        }
                        indexNC = element.IndexOf(";");
                        indexFistBkt = element.IndexOf("(");
                        indexLastBkt = element.IndexOf(")");
                        string coefficient = "";
                        if (indexFistBkt != 0)
                        {
                            for (int j = 0; j < indexFistBkt; j++)
                            {
                                coefficient = coefficient + element[j];
                            }
                        }
                        n = element[indexFistBkt + 1] - '0';
                        int counter = 0;
                        for (int j = 0; j < element.Length; j++)
                        {
                            if (element[j] == '(')
                            {
                                counter++;
                            }
                        }
                        if (counter >= 5)
                        {
                            n = 2;
                        }
                        int shet = 0;
                        for (int j = 0; j < element.Length; j++)
                        {
                            if (element[j] == ';')
                            {
                                shet++;
                            }
                        }
                        if (element.Contains("/"))
                        {
                            IntegralRichTextBox.SelectionCharOffset = 10;
                        }
                        if (n == 1)
                        {
                            if (shet == 1)
                            {
                                for (int j = indexFistBkt + 3; j < indexNC; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                                if (element.Contains("/"))
                                {
                                    IntegralRichTextBox.SelectionCharOffset = 20;
                                }
                                else
                                {
                                    IntegralRichTextBox.SelectionCharOffset = 10;
                                }
                                for (int j = indexNC + 1; j < indexLastBkt; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                                if (element.Contains("/"))
                                {
                                    int count = 0;
                                    for (int j = 0; j < element.Length; j++)
                                    {
                                        if (element[j] == '/')
                                        {
                                            count++;
                                        }
                                    }
                                    IntegralRichTextBox.SelectionCharOffset = -10;
                                    if (count == 1)
                                    {
                                        if (element.IndexOf("/") < indexFistBkt)
                                        {
                                            for (int j = element.IndexOf("/"); j < indexFistBkt; j++)
                                            {
                                                IntegralRichTextBox.SelectedText = "" + element[j];
                                            }
                                        }
                                        else
                                        {
                                            for (int j = element.IndexOf("/"); j < element.Length; j++)
                                            {
                                                IntegralRichTextBox.SelectedText = "" + element[j];
                                            }

                                        }
                                    }
                                    else if (count == 2)
                                    {
                                        string number1 = "";
                                        string number2 = "";
                                        for (int j = element.IndexOf("/") + 1; j < indexFistBkt; j++)
                                        {
                                            number1 = number1 + element[j];
                                        }

                                        for (int j = indexLastBkt + 3; j < element.Length; j++)
                                        {
                                            number2 = number2 + element[j];
                                        }
                                        float equal = Math.Abs(float.Parse(number1) * float.Parse(number2));
                                        IntegralRichTextBox.SelectedText = "/" + equal.ToString();
                                    }


                                }
                            }
                            else
                            {
                                int indexNC2;
                                for (int j = 0; j < element.Length; j++)
                                {
                                    if (element[j] == ';')
                                    {
                                        indexNC2 = j;
                                    }
                                }
                                IntegralRichTextBox.SelectionCharOffset = 10;
                                if (coefficient != "1")
                                {
                                    IntegralRichTextBox.SelectedText = coefficient;
                                }
                                string baseDegree = "";
                                for (int j = indexNC - 1; element[j] != '('; j--)
                                {
                                    baseDegree = baseDegree + element[j];
                                }
                                string reverse = baseDegree;
                                baseDegree = new string(reverse.Reverse().ToArray());
                                string baseLn = "";
                                for (int j = indexNC - 1; element[j] != '('; j--)
                                {
                                    baseLn = baseLn + element[j];
                                }
                                reverse = baseLn;
                                baseLn = new string(reverse.Reverse().ToArray());
                                IntegralRichTextBox.SelectedText = baseDegree;
                                IntegralRichTextBox.SelectionCharOffset = 20;
                                for (int j = indexNC + 1; element[j] != ')'; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                                IntegralRichTextBox.SelectionCharOffset = 0;
                                IntegralRichTextBox.SelectedText = "/";
                                IntegralRichTextBox.SelectionCharOffset = -10;
                                counter = 0;
                                for (int j = 0; j < element.Length; j++)
                                {
                                    if (element[j] == ('/'))
                                    {
                                        counter++;
                                        shet = j;
                                    }
                                }
                                if (counter == 2)
                                {
                                    for (int j = shet + 1; j < element.Length; j++)
                                    {
                                        IntegralRichTextBox.SelectedText = "" + element[j];
                                    }
                                }
                                IntegralRichTextBox.SelectedText = "ln (" + baseLn + ")";

                            }
                        }
                        else if (n == 2)
                        {


                        }
                        else if (n == 3)
                        {
                            int way;
                            way = element[indexFistBkt + 3] - '0';
                            if (coefficient != "1" && coefficient != "-1*" && coefficient != "+1*" && coefficient != "1*")
                            {
                                if (element[0] == '-' || element[0] == '+')
                                {
                                    string gapK = "";
                                    for (int j = 1; j < coefficient.Length; j++)
                                    {
                                        gapK = gapK + coefficient[j];
                                    }
                                    IntegralRichTextBox.SelectedText = gapK;
                                }
                                else
                                {
                                    IntegralRichTextBox.SelectedText = coefficient;
                                }
                            }
                            if (element.Contains("/"))
                            {
                                IntegralRichTextBox.SelectionCharOffset = 10;
                            }
                            IntegralRichTextBox.SelectedText = "ln (";
                            string baseLn = "";
                            for (int j = indexNC - 1; element[j] != '('; j--)
                            {
                                baseLn = baseLn + element[j];
                            }
                            string reverse = baseLn;
                            baseLn = new string(reverse.Reverse().ToArray());
                            if (way == 4)
                            {

                                IntegralRichTextBox.SelectedText = "cos(" + baseLn + ")";
                            }
                            else if (way == 5)
                            {
                                IntegralRichTextBox.SelectedText = "sin(" + baseLn + ")";
                            }
                            else
                            {
                                IntegralRichTextBox.SelectedText = baseLn;
                            }
                            IntegralRichTextBox.SelectedText = ")";
                            if (element.Contains("/"))
                            {
                                IntegralRichTextBox.SelectionCharOffset = 0;
                                IntegralRichTextBox.SelectedText = "/";
                                IntegralRichTextBox.SelectionCharOffset = -10;
                                for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                            }

                        }
                        else if (n == 4)
                        {
                            string baseCos = "";
                            for (int j = indexNC - 1; element[j] != '('; j--)
                            {
                                baseCos = baseCos + element[j];
                            }
                            string reverse = baseCos;
                            baseCos = new string(reverse.Reverse().ToArray());
                            IntegralRichTextBox.SelectedText = "cos (" + baseCos + ")";
                            if (element.Contains("/"))
                            {
                                IntegralRichTextBox.SelectionCharOffset = 0;
                                IntegralRichTextBox.SelectedText = "/";
                                IntegralRichTextBox.SelectionCharOffset = -10;
                                for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                            }
                        }
                        else if (n == 5)
                        {
                            string baseCos = "";
                            for (int j = indexNC - 1; element[j] != '('; j--)
                            {
                                baseCos = baseCos + element[j];
                            }
                            string reverse = baseCos;
                            baseCos = new string(reverse.Reverse().ToArray());
                            IntegralRichTextBox.SelectedText = "sin (" + baseCos + ")";
                            if (element.Contains("/"))
                            {
                                IntegralRichTextBox.SelectionCharOffset = 0;
                                IntegralRichTextBox.SelectedText = "/";
                                IntegralRichTextBox.SelectionCharOffset = -10;
                                for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                {
                                    IntegralRichTextBox.SelectedText = "" + element[j];
                                }
                            }
                        }
                        else if (n == 6)
                        {

                        }
                        else if (n == 7)
                        {

                        }
                    }

                    else
                    {
                        IntegralRichTextBox.SelectedText = element;
                    }
                }
                else
                {
                    IntegralRichTextBox.SelectedText = element;
                }
                IntegralRichTextBox.SelectedText = " ";
            }
            int enuminator=0;
            for (int i = 0; i < Data.StepInteger.Count; i++)
            {
                if ((i % 3) != 0)
                {
                    
                    if ((i % 3) == 1)
                    {
                        richTextBox.SelectionCharOffset = 0;
                        richTextBox.SelectedText = "\t\t\t\t\t\t" + (char)0x222B;
                    }
                    else {

                        richTextBox.SelectionCharOffset= 0;
                        richTextBox.SelectedText = "dx = ";
                    }
                    element = Data.StepInteger[i];
                    richTextBox.SelectionCharOffset = 0;
                    if (element[0] == '+')
                    {
                        richTextBox.SelectedText = "" + element[0];
                    }
                    else if (element[0] == '-')
                    {
                        richTextBox.SelectedText = "" + element[0];
                    }
                    if (element.IndexOf("x") != (element.Length - 1))
                    {
                        if (element.Contains('('))
                        {
                            string number = "";
                            for (int j = 0; j > element.IndexOf("/") && j < element.IndexOf("("); j++)
                            {
                                number = "" + element[j];
                            }
                            if (number != "1")
                            {
                                richTextBox.SelectedText = number;
                            }
                            indexNC = element.IndexOf(";");
                            indexFistBkt = element.IndexOf("(");
                            indexLastBkt = element.IndexOf(")");
                            string coefficient = "";
                            if (indexFistBkt != 0)
                            {
                                for (int j = 0; j < indexFistBkt; j++)
                                {
                                    coefficient = coefficient + element[j];
                                }
                            }
                            n = element[indexFistBkt + 1] - '0';
                            int counter = 0;
                            for (int j = 0; j < element.Length; j++)
                            {
                                if (element[j] == '(')
                                {
                                    counter++;
                                }
                            }
                            if (counter >= 5)
                            {
                                n = 2;
                            }
                            int shet = 0;
                            for (int j = 0; j < element.Length; j++)
                            {
                                if (element[j] == ';')
                                {
                                    shet++;
                                }
                            }
                            if (element.Contains("/"))
                            {
                                richTextBox.SelectionCharOffset = 10;
                            }
                            if (n == 1)
                            {
                                if (shet == 1)
                                {
                                    for (int j = indexFistBkt + 3; j < indexNC; j++)
                                    {
                                        richTextBox.SelectedText = "" + element[j];
                                    }
                                    if (element.Contains("/"))
                                    {
                                        richTextBox.SelectionCharOffset = 20;
                                    }
                                    else
                                    {
                                        richTextBox.SelectionCharOffset = 10;
                                    }
                                    for (int j = indexNC + 1; j < indexLastBkt; j++)
                                    {
                                        richTextBox.SelectedText = "" + element[j];
                                    }
                                    if (element.Contains("/"))
                                    {
                                        int count = 0;
                                        for (int j = 0; j < element.Length; j++)
                                        {
                                            if (element[j] == '/')
                                            {
                                                count++;
                                            }
                                        }
                                        richTextBox.SelectionCharOffset = -10;
                                        if (count == 1)
                                        {
                                            if (element.IndexOf("/") < indexFistBkt)
                                            {
                                                for (int j = element.IndexOf("/"); j < indexFistBkt; j++)
                                                {
                                                    richTextBox.SelectedText = "" + element[j];
                                                }
                                            }
                                            else
                                            {
                                                for (int j = element.IndexOf("/"); j < element.Length; j++)
                                                {
                                                    richTextBox.SelectedText = "" + element[j];
                                                }

                                            }
                                        }
                                        else if (count == 2)
                                        {
                                            string number1 = "";
                                            string number2 = "";
                                            for (int j = element.IndexOf("/") + 1; j < indexFistBkt; j++)
                                            {
                                                number1 = number1 + element[j];
                                            }

                                            for (int j = indexLastBkt + 3; j < element.Length; j++)
                                            {
                                                number2 = number2 + element[j];
                                            }
                                            float equal = Math.Abs(float.Parse(number1) * float.Parse(number2));
                                            richTextBox.SelectedText = "/" + equal.ToString();
                                        }


                                    }
                                }
                                else
                                {
                                    int indexNC2;
                                    for (int j = 0; j < element.Length; j++)
                                    {
                                        if (element[j] == ';')
                                        {
                                            indexNC2 = j;
                                        }
                                    }
                                    richTextBox.SelectionCharOffset = 10;
                                    if (coefficient != "1")
                                    {
                                        richTextBox.SelectedText = coefficient;
                                    }
                                    string baseDegree = "";
                                    for (int j = indexNC - 1; element[j] != '('; j--)
                                    {
                                        baseDegree = baseDegree + element[j];
                                    }
                                    string reverse = baseDegree;
                                    baseDegree = new string(reverse.Reverse().ToArray());
                                    string baseLn = "";
                                    for (int j = indexNC - 1; element[j] != '('; j--)
                                    {
                                        baseLn = baseLn + element[j];
                                    }
                                    reverse = baseLn;
                                    baseLn = new string(reverse.Reverse().ToArray());
                                    richTextBox.SelectedText = baseDegree;
                                    richTextBox.SelectionCharOffset = 20;
                                    for (int j = indexNC + 1; element[j] != ')'; j++)
                                    {
                                        IntegralRichTextBox.SelectedText = "" + element[j];
                                    }
                                    richTextBox.SelectionCharOffset = 0;
                                    richTextBox.SelectedText = "/";
                                    richTextBox.SelectionCharOffset = -10;
                                    counter = 0;
                                    for (int j = 0; j < element.Length; j++)
                                    {
                                        if (element[j] == ('/'))
                                        {
                                            counter++;
                                            shet = j;
                                        }
                                    }
                                    if (counter == 2)
                                    {
                                        for (int j = shet + 1; j < element.Length; j++)
                                        {
                                            richTextBox.SelectedText = "" + element[j];
                                        }
                                    }
                                    richTextBox.SelectedText = "ln (" + baseLn + ")";

                                }
                            }
                            else if (n == 2)
                            {


                            }
                            else if (n == 3)
                            {
                                int way;
                                way = element[indexFistBkt + 3] - '0';
                                if (coefficient != "1" && coefficient != "-1*" && coefficient != "+1*" && coefficient != "1*")
                                {
                                    if (element[0] == '-' || element[0] == '+')
                                    {
                                        string gapK = "";
                                        for (int j = 1; j < coefficient.Length; j++)
                                        {
                                            gapK = gapK + coefficient[j];
                                        }
                                        richTextBox.SelectedText = gapK;
                                    }
                                    else
                                    {
                                        richTextBox.SelectedText = coefficient;
                                    }
                                }
                                if (element.Contains("/"))
                                {
                                    richTextBox.SelectionCharOffset = 10;
                                }
                                richTextBox.SelectedText = "ln (";
                                string baseLn = "";
                                for (int j = indexNC - 1; element[j] != '('; j--)
                                {
                                    baseLn = baseLn + element[j];
                                }
                                string reverse = baseLn;
                                baseLn = new string(reverse.Reverse().ToArray());
                                if (way == 4)
                                {

                                    richTextBox.SelectedText = "cos(" + baseLn + ")";
                                }
                                else if (way == 5)
                                {
                                    richTextBox.SelectedText = "sin(" + baseLn + ")";
                                }
                                else
                                {
                                    richTextBox.SelectedText = baseLn;
                                }
                                richTextBox.SelectedText = ")";
                                if (element.Contains("/"))
                                {
                                    richTextBox.SelectionCharOffset = 0;
                                    richTextBox.SelectedText = "/";
                                    richTextBox.SelectionCharOffset = -10;
                                    for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                    {
                                        richTextBox.SelectedText = "" + element[j];
                                    }
                                }

                            }
                            else if (n == 4)
                            {
                                string baseCos = "";
                                for (int j = indexNC - 1; element[j] != '('; j--)
                                {
                                    baseCos = baseCos + element[j];
                                }
                                string reverse = baseCos;
                                baseCos = new string(reverse.Reverse().ToArray());
                                richTextBox.SelectedText = "cos (" + baseCos + ")";
                                if (element.Contains("/"))
                                {
                                    richTextBox.SelectionCharOffset = 0;
                                    richTextBox.SelectedText = "/";
                                    richTextBox.SelectionCharOffset = -10;
                                    for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                    {
                                        richTextBox.SelectedText = "" + element[j];
                                    }
                                }
                            }
                            else if (n == 5)
                            {
                                string baseCos = "";
                                for (int j = indexNC - 1; element[j] != '('; j--)
                                {
                                    baseCos = baseCos + element[j];
                                }
                                string reverse = baseCos;
                                baseCos = new string(reverse.Reverse().ToArray());
                                richTextBox.SelectedText = "sin (" + baseCos + ")";
                                if (element.Contains("/"))
                                {
                                    richTextBox.SelectionCharOffset = 0;
                                    richTextBox.SelectedText = "/";
                                    richTextBox.SelectionCharOffset = -10;
                                    for (int j = element.IndexOf("/") + 1; j < element.Length; j++)
                                    {
                                        richTextBox.SelectedText = "" + element[j];
                                    }
                                }
                            }
                            else if (n == 6)
                            {

                            }
                            else if (n == 7)
                            {

                            }
                        }
                        else
                        {
                            richTextBox.SelectedText = element;
                        }

                    }
                    else
                    {
                        richTextBox.SelectedText = element;
                    }
                    if ((i % 3) == 2)
                    {
                        richTextBox.SelectionCharOffset = 0;
                        richTextBox.SelectedText = " +  C";
                    }
                }
                else
                {
                    if (i != 0)
                    {
                        richTextBox.SelectedText = Environment.NewLine;
                    }
                    enuminator++;
                    richTextBox.SelectionCharOffset = 0;
                    richTextBox.SelectedText = enuminator.ToString() + ". " + Data.StepInteger[i] + Environment.NewLine;
                }
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }
    }
}
