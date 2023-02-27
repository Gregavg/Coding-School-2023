using CalculatorLib;
using System;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Session_09 {
    public partial class Form1 : Form {

        private bool? _left { get; set; }
        private bool? _right { get; set; }
        private bool? _symbol { get; set; }
        private string? _input { get; set; }



        public Form1() {
            InitializeComponent();
            Reseter();

        }

        private void Reseter() {
            _left = false;
            _right = false;
            _symbol = false;
            _input = "";
        }

        private void Form1_Load(object sender, EventArgs e) {
        }


        private void ButtonEquals_Click(object sender, EventArgs e) {
            if (_left == true && _symbol == true && _right == true) {
                Calculate();
                Reseter();
            }
        }

        //Number Buttons
        private void BtnZero_Click(object sender, EventArgs e) {
            AddNumber("0");
        }
        private void BtnOne_Click(object sender, EventArgs e) {
            AddNumber("1");
        }
        private void BtnTwo_Click(object sender, EventArgs e) {
            AddNumber("2");
        }
        private void BtnThree_Click(object sender, EventArgs e) {
            AddNumber("3");
        }
        private void BtnFour_Click(object sender, EventArgs e) {
            AddNumber("4");
        }
        private void BtnFive_Click(object sender, EventArgs e) {
            AddNumber("5");
        }
        private void BtnSix_Click(object sender, EventArgs e) {
            AddNumber("6");
        }
        private void BtnSeven_Click(object sender, EventArgs e) {
            AddNumber("7");
        }
        private void BtnEight_Click(object sender, EventArgs e) {
            AddNumber("8");
        }
        private void BtnNine_Click(object sender, EventArgs e) {
            AddNumber("9");
        }

        //SYMBOL BUTTONS
        private void BtnSum_Click(object sender, EventArgs e) {
            AddSymbol("+");
        }
        private void BtnSub_Click(object sender, EventArgs e) {
            AddSymbol("-");
        }
        private void BtnMulti_Click(object sender, EventArgs e) {
            AddSymbol("x");
        }
        private void BtnDiv_Click(object sender, EventArgs e) {
            AddSymbol("%");
        }

        //OPERATION BUTTONS
        private void BtnClear_Click(object sender, EventArgs e) {
            Reseter();
            ShowInInput();
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            try {

            }
            catch (Exception ex) {

            }
        }

        private void BtnPower_Click(object sender, EventArgs e) {
            AddSymbol("^");
        }

        private void BtnSqrt_Click(object sender, EventArgs e) {

            if (_symbol == false && !_input.Contains('-') && _input.Length != 0) {
                var temp = _input;
                Reseter();
                ShowInInput();
                AddNumber("2");
                AddSymbol("√");
                AddNumber(temp);
                Calculate();
                Reseter();

            }
        }


        private void Calculate() {
            CalcResolver calcResolver = new CalcResolver();
            string output = calcResolver.Execute(_input);

            ShowInInput(output);

        }


        //add number
        private void AddNumber(string input) {

            StringBuilder? sb = new StringBuilder();

            if (_left == false) { //if left empty
                _left = true;
            } else if (_symbol == true) { //if right empty
                _right = true;
            }

            sb.Append(input);
            _input += sb.ToString();
            ShowInInput();
        }

        //add sumbol
        private void AddSymbol(string input) {
            StringBuilder? sb = new StringBuilder();

            if (_left == false && input != "-" && _input.Length == 0) { //is empty
                input = "";
            } else if (_left == true && _symbol == true && _right == false) { //symbol change
                _input = _input.Remove(_input.Length - 1);
            } else if (_left == true && _symbol == true && _right == true) { //extra symbol
                input = "";
            } else if (_left == true && _symbol == false) {
                _symbol = true;
            }

            sb.Append(input);
            _input += sb.ToString();
            ShowInInput();

        }

        //show number to textbox
        public void ShowInInput() {
            ctrlDisplay.Text = "";
            foreach (var s in _input) {
                if (!Char.IsNumber(s))
                    ctrlDisplay.Text += $" {s} ";
                else ctrlDisplay.Text += s;
            }
        }

        public void ShowInInput(string input) {
            ctrlDisplay.Text += " = " + input;
        }
    }
}