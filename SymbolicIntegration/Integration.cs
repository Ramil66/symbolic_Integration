using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolicIntegration
{
    internal class Integration
    {
        private List<string> newSplitLine = new List<string>();
        private List<string> function=new List<string>();
        private List<string> signs=new List<string>();
        public Integration(string inputLine) 
        {

            string line = "";
            List<bool> examElementSplitLine = new List<bool>();
            List<bool> examElementFunction = new List<bool>();
            //РАЗБИЕНИЕ СТРОКИ ФИНКЦИИ НА ЭЛЕМЕНТЫ
            for (int i = 0; i < inputLine.Length; i++)
            {
                if (!(inputLine[i] == '*'))
                {
                    line = line + inputLine[i];
                }
            }
            string[] gapLine = line.Split('[', ']');
            List<string> splitLine = gapLine.ToList();
            splitLine.Remove("");
            for (int i = 0; i < splitLine.Count; i++)
            {
                if (splitLine[i].Contains(";"))
                {
                    newSplitLine.Add(splitLine[i]);
                }
                else
                {
                    string element = "";
                    for (int j = 0; j < splitLine[i].Length; j++)
                    {
                        if (splitLine[i][j] == '+' || splitLine[i][j] == '-')
                        {
                            if (element != "")
                            {
                                newSplitLine.Add(element);
                            }
                            newSplitLine.Add(char.ToString(splitLine[i][j]));
                            element = "";
                        }
                        else
                        {
                            element += splitLine[i][j];
                        }
                    }
                    if (element != "")
                    {
                        newSplitLine.Add(element);
                    }

                }
            }
            for (int i = 0; i < newSplitLine.Count; i++)
            {
                if ((i % 2 == 1) && (!(newSplitLine[i] == "+" || (newSplitLine[i] == "-"))))
                {
                    newSplitLine[i - 1] = newSplitLine[i - 1] + "(" + newSplitLine[i] + ")";
                    newSplitLine.RemoveAt(i);
                    examElementSplitLine[examElementSplitLine.Count - 1] = true;
                    i--;
                }
                else
                {
                    examElementSplitLine.Add(false);
                }
            }
            //РАЗДЕЛЕНИЕ ЭЛЕМЕНТОВ НА ЭЛЕМЕНТЫ ФУНКЦИИ И НА ЗНАКИ
            for (int i = 0; i < newSplitLine.Count; i++)
            {
                if (i % 2 == 0)
                {
                    function.Add(newSplitLine[i]);
                    examElementFunction.Add(examElementSplitLine[i]);
                }
                else
                {
                    signs.Add(newSplitLine[i]);
                }
            }
            if (function.Count() == signs.Count())
            {
                signs.RemoveAt(signs.Count() - 1);
            }
            //ПРЕОБРАЗОВАНИЕ ЭЛЕМЕНТОВ ФУНКЦИИ В БОЛЕЕ УДОБНЫЙ ВИД ДЛЯ ОСУЩЕСТВЛЕНИЯ ИНТЕГРИРОВАНИЯ
            for (int i = 0; i < function.Count; i++)
            {
                if (function[i].Contains("x") && !(function[i].Contains("(")))
                {
                    function[i] = "1(1(" + function[i] + ";1))";
                }
                else if (function[i].Contains("x"))
                {
                    if (!examElementFunction[i])
                    {
                        function[i] = "1(" + function[i] + ")";
                    }
                }
            }
        }
        public void integral(ref List<string> integral, ref List<string> stepIntegral) 
        {
            //integral = "";
            bool[] changeSign = new bool[function.Count];
            for (int i = 0; i < function.Count(); i++)
            {
                changeSign[i] = false;
                if (function[i].Contains("("))
                {
                    if (function[i].Contains("x"))
                    {

                        string element;
                        string newElement = "";
                        element = function[i];
                        int indexFistBkt = element.IndexOf('(');
                        int indexNC = element.IndexOf(';');
                        int indexX = element.IndexOf('x');
                        string coefficient = "";
                        if (element[indexX - 1] != '-' && element[indexX - 1] != '+' && element[indexX - 1] != '(' && element[indexX - 1] != ';')
                        {
                            int j = indexX - 1;
                            while (element[j] != '-' && element[j] != '+' && element[j] != '(' && element[j] != ';')
                            {
                                coefficient = coefficient + element[j];
                                j--;
                            }
                        }
                        string reverse = coefficient;
                        coefficient = new string(reverse.Reverse().ToArray());
                        float numberCoefficient = 1;
                        if (coefficient != "")
                        {
                            numberCoefficient = float.Parse(coefficient);
                        }
                        if (numberCoefficient < 0)
                        {
                            changeSign[i] = true;
                        }
                        int n = element[indexFistBkt + 1] - '0';
                        switch (n)
                        {
                            case 1:
                                {
                                    if (element.IndexOf('x') < indexNC)
                                    {
                                        if (element[indexNC + 1] == '-' && element[indexNC + 2] == '1' && element[indexNC + 3] == ')')
                                        {
                                            if (element.Contains("+") || element.IndexOf('-') < indexNC)
                                            {
                                                for (int j = 0; j < element.Length; j++)
                                                {
                                                    if (j == indexFistBkt + 1)
                                                    {
                                                        newElement = newElement + "3";
                                                    }
                                                    else if (j == indexNC + 1)
                                                    {
                                                        newElement = newElement + "1";
                                                    }
                                                    else if (j != indexNC + 2)
                                                    {
                                                        newElement = newElement + element[j];
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                for (int j = 0; j < indexFistBkt; j++)
                                                {
                                                    newElement = newElement + element[j];
                                                }
                                                newElement = newElement + "(3(x;1))";
                                            }
                                            if (coefficient != "")
                                            {
                                                newElement = newElement + "/" + coefficient;
                                            }
                                            stepIntegral.Add("По таблице неопределенных интегралов следует:");
                                            stepIntegral.Add(element);
                                            stepIntegral.Add(newElement);
                                        }
                                        else
                                        {
                                            string stringNumber = "";
                                            if (element.Contains("/"))
                                            {

                                            }
                                            for (int j = 0; j < element.Length; j++)
                                            {
                                                if (j <= indexNC)
                                                {
                                                    newElement = newElement + element[j];
                                                }
                                                else if (j < element.IndexOf(')'))
                                                {
                                                    stringNumber = stringNumber + element[j];
                                                }
                                            }
                                            float number = float.Parse(stringNumber) + 1;
                                            if (number < 0 && changeSign[i])
                                            {
                                                changeSign[i] = false;
                                            }
                                            stringNumber = number.ToString();
                                            newElement = newElement + stringNumber + "))";
                                            if (coefficient != "")
                                            {
                                                float denominator = Math.Abs(number);
                                                newElement = newElement + "/" + denominator.ToString();
                                            }
                                            else
                                            {
                                                newElement = newElement + "/" + stringNumber;
                                            }
                                            stepIntegral.Add("По таблице неопределенных интегралов следует: ");
                                            stepIntegral.Add(element);
                                            stepIntegral.Add(newElement);
                                        }
                                    }
                                    else
                                    {
                                        if (element[indexNC - 1] == 'e')
                                        {
                                            newElement = element + "/" + coefficient;
                                            stepIntegral.Add("По таблице неопределенных интегралов следует:");
                                            stepIntegral.Add(element);
                                            stepIntegral.Add(newElement);
                                        }
                                        else
                                        {
                                            newElement = element + "/" + coefficient + "*3(";
                                            int j = indexNC - 1;
                                            while (element[j] != '(')
                                            {
                                                newElement = newElement + element[j];
                                                j--;
                                            }
                                            newElement = newElement + ";1)";
                                        }
                                        if (coefficient != "")
                                        {
                                            newElement = newElement + "/" + coefficient;
                                        }
                                        stepIntegral.Add("По таблице неопределенных интегралов следует:");
                                        stepIntegral.Add(element);
                                        stepIntegral.Add(newElement);
                                    }
                                    function[i] = newElement;
                                    break;
                                }
                            case 2:
                                {
                                    string number = "";
                                    for (int j = 0; j < indexFistBkt; j++)
                                    {
                                        newElement = newElement + element[i];
                                    }
                                    newElement = newElement + "(x(2(x;";
                                    int k = indexNC + 1;
                                    while (element[k] != ')')
                                    {
                                        number = number + element[k];
                                        k++;
                                    }
                                    newElement = newElement + number;
                                    newElement = newElement + "))" + "-x/3(" + number + ")";
                                    newElement = newElement + ")";
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "+";
                                        newElement = newElement + "x";
                                        for (int j = 0; j < element.Length; j++)
                                        {
                                            if (element[j] != 'x')
                                            {
                                                newElement = newElement + element[j];
                                            }
                                        }
                                    }
                                    function[i] = newElement;
                                    stepIntegral.Add("Используя метод интегрирования по частям: " + (char)0x222B + " udv= uv - " + (char)0x222B + " vdu. Получаем:");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                            case 3:
                                {
                                    for (int j = 0; j < indexFistBkt; j++)
                                    {
                                        newElement = newElement + element[i];
                                    }
                                    newElement = newElement + "(x3(x;1)-x";
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "+x3(" + coefficient + ";1)";
                                    }
                                    newElement = newElement + ")";
                                    function[i] = newElement;
                                    stepIntegral.Add("Используя метод интегрирования по частям: " + (char)0x222B + " udv= uv - " + (char)0x222B + " vdu. Получаем:");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                            case 4:
                                {
                                    for (int j = 0; j < element.Length; j++)
                                    {
                                        if (j == indexFistBkt + 1)
                                        {
                                            newElement = newElement + "5";
                                        }
                                        else
                                        {
                                            newElement = newElement + element[j];
                                        }
                                    }
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "/" + coefficient;
                                    }
                                    function[i] = newElement;
                                    stepIntegral.Add("По таблице неопределенных интегралов следует: ");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                            case 5:
                                {
                                    for (int j = 0; j < element.Length; j++)
                                    {
                                        if (j == indexFistBkt + 1)
                                        {
                                            newElement = newElement + "4";
                                        }
                                        else
                                        {
                                            newElement = newElement + element[j];
                                        }
                                    }
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "/" + coefficient;
                                    }
                                    function[i] = newElement;
                                    changeSign[i] = !changeSign[i];
                                    stepIntegral.Add("По таблице неопределенных интегралов следует: ");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                            case 6:
                                {
                                    for (int j = 0; j < indexFistBkt; j++)
                                    {
                                        newElement = newElement + element[j];
                                    }
                                    newElement = newElement + "*(3(4(";
                                    for (int j = indexFistBkt + 3; j < indexNC; j++)
                                    {
                                        newElement = newElement + element[j];
                                    }
                                    newElement = newElement + ";1)))";
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "/" + coefficient;
                                    }
                                    function[i] = newElement;
                                    changeSign[i] = !changeSign[i];
                                    stepIntegral.Add("Используя метод подведения под знак дифференциала получаем:");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                            case 7:
                                {
                                    for (int j = 0; j < indexFistBkt; j++)
                                    {
                                        newElement = newElement + element[j];
                                    }
                                    newElement = newElement + "*(3(5(";
                                    for (int j = indexFistBkt + 3; j < indexNC; j++)
                                    {
                                        newElement = newElement + element[j];
                                    }
                                    newElement = newElement + ";1)))";
                                    if (coefficient != "")
                                    {
                                        newElement = newElement + "/" + coefficient;
                                    }
                                    function[i] = newElement;
                                    stepIntegral.Add("Используя метод подведения под знак дифференциала получаем:");
                                    stepIntegral.Add(element);
                                    stepIntegral.Add(newElement);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        stepIntegral.Add("Используя таблицу неопределенных интегралов получаем :");
                        stepIntegral.Add(function[i]);
                        function[i] = function[i] + "x";
                        stepIntegral.Add(function[i]);
                    }
                }
                else
                {
                    stepIntegral.Add("Используя таблицу неопределенных интегралов получаем :");
                    stepIntegral.Add(function[i]);
                    function[i] = function[i] + "x";
                    stepIntegral.Add(function[i]);
                }
            }
            for (int i = 0; i < function.Count; i++)
            {
                if (changeSign[i])
                {
                    if (i == 0)
                    {
                        integral.Add("-" + function[i]);
                    }
                    else
                    {
                        if (signs[i - 1] == "+")
                        {
                            integral.Add("-" + function[i]);
                        }
                        else
                        {
                            integral.Add("+" + function[i]);
                        }
                    }
                }
                else
                {
                    if (i == 0)
                    {
                        integral.Add(function[i]);
                    }
                    else
                    {
                        integral.Add(signs[i - 1] + function[i]);
                    }
                }
            }
        }
    }
}
