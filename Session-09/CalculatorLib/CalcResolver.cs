using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorLib {
    public class CalcResolver {

        private Calculate _calculation { get; set; }

        public string Execute(string input) {

            string result;

            string pattern = "([+]|[-]|[%]|[x]|[√]|[\\^])";

            string[] substrings = Regex.Split(input, pattern);

            if (substrings.Length == 3) {
                result = FindSwitch(substrings[0], substrings[1], substrings[2]);
            } else {
                result = FindSwitchSub(substrings[2], substrings[3], substrings[4]);
            }


            return result.ToString();


        }

        public string FindSwitch(string left, string symbol, string right) {

            string result;
            decimal leftNumber = Convert.ToDecimal(left);
            decimal rightNumber = Convert.ToDecimal(right);
            switch (symbol) {
                case "+":
                    _calculation = new Sum();
                    break;
                case "-":
                    _calculation = new Sub();
                    break;
                case "%":
                    _calculation = new Div();
                    break;
                case "x":
                    _calculation = new Multi();
                    break;
                case "^":
                    _calculation = new Power();
                    break;
                case "√":
                    _calculation = new Sqrt();
                    break;
            }

            result = _calculation.Do(leftNumber, rightNumber);

            return result;
        }


        public string FindSwitchSub(string left, string symbol, string right) {

            string result;
            decimal leftNumber = Convert.ToDecimal(left);
            decimal rightNumber = Convert.ToDecimal(right);
            if (symbol != "√") {
                switch (symbol) {
                    case "+":
                        _calculation = new Sum();
                        break;
                    case "-":
                        _calculation = new Sub();
                        break;
                    case "%":
                        _calculation = new Div();
                        break;
                    case "x":
                        _calculation = new Multi();
                        break;
                    case "^":
                        _calculation = new Power();
                        break;
                }
                result = _calculation.Do(-leftNumber, rightNumber).ToString();
            } else {
                result = "Error";
            }
            return result;
        }

    }




}

