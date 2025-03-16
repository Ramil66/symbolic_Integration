using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolicIntegration
{
    //Статический класс для передачи данных между формами
    static class Data
    {
        public static string MainElement;
        public static string SecondaryElement;
        public static bool SwitchTheme;
        public static bool Choice = false;
        public static string Function;
        public static List<string> Integral;
        public static List<string> StepInteger; 
    }
}
