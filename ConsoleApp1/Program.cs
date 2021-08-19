using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var enumerator = QuestionClass.NamesList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            var answer = TESTModule("1");
        }

        private static string TESTModule(string val)
        {
            //var decisepa = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            int intval = 0;
            bool isString = false;
            if (int.TryParse(val, out intval))
            {
                isString = false;
            }
            else
            {
                isString = true;
            }

            switch (val)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    return (int.Parse(val) * 2).ToString();

                case "1.0f":
                case "2.0f":
                    return "3.0f";

                default:
                    if (isString)
                    {
                        bool isDigitPresent = val.Any(c => char.IsDigit(c));
                        if (isDigitPresent)
                        {
                            return val;
                        }
                        else
                        {
                            return val.ToUpper();
                        }
                    }
                    else
                    {
                        if (intval > 4)
                        {
                            return (intval * 3).ToString();
                        }
                        if (intval < 1)
                        {
                            throw new Exception("Invalid input.");
                        }
                        else
                        {
                            return val;
                        }
                    }
            }
        }

    }
}
