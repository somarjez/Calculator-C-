namespace calculator_project
{
    public partial class Form1 : Form
    {
        private double valueFirst = 0.0;
        private double valueSecond = 0.0;
        private double Result = 0.0;
        private string operators = "";
        private string c = "";
        private string d = "";
        private string mixedNumber = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SeventBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "-";
            operators = "-";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "+";
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "÷";
            operators = "/";
        }



        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "x";
            operators = "*";
        }

        private void EXPBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "E";
            operators = "exp";
        }

        private void PowBtn_Click(object sender, EventArgs e)
        {
            valueFirst = double.Parse(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "^";
            operators = "^";
        }

        private void ModulusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "%";
            TxtBox.Text = valueFirst.ToString();
            operators = "%";
        }

        private void FactBtn_Click(object sender, EventArgs e)
        {
            valueFirst = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "!";
            TxtBox.Text = valueFirst.ToString();
            operators = "!";
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            double logl;
            logl = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = "log (";
            operators = "log";

        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            double sqrt;
            sqrt = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = "√"; ;
            operators = "sqrt";
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            valueFirst = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "²";
            TxtBox.Text = valueFirst.ToString();
            operators = "x2";

        }

        private void x3Btn_Click(object sender, EventArgs e)
        {
            valueFirst = (double.Parse(TxtBox.Text));
            TxtBox.Clear();
            TxtBox1.Text = valueFirst.ToString() + "³";
            TxtBox.Text = valueFirst.ToString();
            operators = "x3";

        }

        private void sinhBtn_Click(object sender, EventArgs e)
        {
            double sh;
            sh = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "sinh(";
            operators = "sh";
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {

            double sin;
            sin = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "sin(";
            operators = "sin";

        }

        private void coshBtn_Click(object sender, EventArgs e)
        {

            double ch;
            ch = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "cosh(";
            operators = "cosh";
        }

        private void cosBtn_Click(object sender, EventArgs e)
        {
            double cos;
            cos = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "cos(";
            operators = "cos";
        }

        private void tanhBtn_Click(object sender, EventArgs e)
        {
            double tanh;
            tanh = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "tanh(";
            operators = "tanh";
        }

        private void tanBtn_Click(object sender, EventArgs e)
        {
            double tanh;
            tanh = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "tan(";
            operators = "tan";

        }

        private void x1Btn_Click(object sender, EventArgs e)
        {
            TxtBox1.Text = "1/";
            operators = "x1";
        }

        private void InxBtn_Click(object sender, EventArgs e)
        {
            double Inx;
            Inx = Convert.ToDouble(TxtBox.Text);
            TxtBox.Clear();
            TxtBox1.Text = "In(";
            operators = "Inx";
        }

        private void FracBtn_Click(object sender, EventArgs e)
        {
            Decimal first = decimal.Parse(TxtBox.Text);
            Decimal wholePart = Math.Floor(first);
            Decimal fractionalPart = first - wholePart;

            Double times = 0;

            while (fractionalPart % 1 != 0)
            {
                fractionalPart = fractionalPart * 10;
                times++;
            }

            int denominator = Convert.ToInt32(Math.Pow(10, times));
            int numerator = Convert.ToInt32(fractionalPart);
            int divisor = 2;

            while (numerator >= divisor && denominator >= divisor)
            {
                if (numerator % divisor == 0 && denominator % divisor == 0)
                {
                    numerator = numerator / divisor;
                    denominator = denominator / divisor;
                }
                else
                {
                    divisor = divisor + 1;
                }
            }

            string mixedNumber = $"{wholePart} {numerator}/{denominator}";
            TxtBox2.Text = mixedNumber;


        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = double.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox1.Text = valueFirst.ToString() + "-" + valueSecond.ToString();
                    TxtBox2.Text = c;
                    TxtBox.Text = Result.ToString();
                    break;

                case "+":

                    valueSecond = double.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox1.Text = valueFirst.ToString() + "+" + valueSecond.ToString();
                    TxtBox.Text = Result.ToString();
                    break;


                case "*":
                    valueSecond = double.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox1.Text = valueFirst.ToString() + "x" + valueSecond.ToString();
                    TxtBox2.Text = c;
                    TxtBox.Text = Result.ToString();
                    break;

                case "/":
                    valueSecond = double.Parse(TxtBox.Text);
                    if (valueSecond == 0)
                    {
                        TxtBox.Text = "Error";
                        return;
                    }
                    Result = valueFirst / valueSecond;
                    TxtBox1.Text = valueFirst.ToString() + "÷" + valueSecond.ToString();
                    TxtBox2.Text = c;
                    TxtBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = double.Parse(TxtBox.Text);
                    Result = (valueFirst / 100);
                    TxtBox1.Text = valueFirst.ToString() + "%";
                    TxtBox.Text = Result.ToString();
                    break;

                case "!":
                    double a, fact = 1;
                    for (a = 1; a <= valueFirst; a++)
                    {
                        fact = fact * a;
                    }
                    TxtBox.Text = fact.ToString();
                    break;

                case "exp":

                    valueSecond = double.Parse(TxtBox.Text);
                    TxtBox1.Text = valueFirst.ToString() + "E" + valueSecond.ToString();
                    double y = 10;
                    Result = valueFirst * Math.Pow(y, valueSecond);

                    TxtBox.Text = Result.ToString();
                    break;

                case "^":
                    valueSecond = double.Parse(TxtBox.Text);
                    Result = Math.Pow(valueFirst, valueSecond);
                    TxtBox1.Text = valueFirst.ToString() + "^" + valueSecond.ToString();
                    TxtBox.Text = Convert.ToString(Result);
                    break;

                case "log":
                    double logl;
                    logl = (double.Parse(TxtBox.Text));
                    TxtBox1.Text = "log (" + logl + ")".ToString();
                    logl = Math.Log10(logl);
                    TxtBox.Text = Convert.ToString(logl);
                    break;

                case "sqrt":

                    double sqrt = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "√" + sqrt.ToString();
                    sqrt = Math.Sqrt(sqrt);
                    TxtBox.Text = Convert.ToString(sqrt);
                    break;

                case "x2":
                    TxtBox1.Text = valueFirst.ToString() + "²";
                    Result = valueFirst * valueFirst;
                    TxtBox.Text = Result.ToString();
                    break;

                case "x3":
                    TxtBox1.Text = valueFirst.ToString() + "³";
                    Result = valueFirst * valueFirst * valueFirst;
                    TxtBox.Text = Result.ToString();
                    break;

                case "sh":
                    double angleInDegreesSh = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "sinh(" + angleInDegreesSh.ToString() + "°)";

                    double angleInRadiansSh = angleInDegreesSh * Math.PI / 180.0;

                    double sinhValue = Math.Sinh(angleInRadiansSh);

                    double roundedSinhValue = Math.Round(sinhValue, 2);

                    TxtBox.Text = Convert.ToString(roundedSinhValue);
                    break;

                case "sin":
                    double angleInDegrees = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "sin(" + angleInDegrees.ToString() + "°)";

                    double angleInRadians = angleInDegrees * Math.PI / 180.0;

                    double sineValue = Math.Sin(angleInRadians);

                    double roundedSineValue = Math.Round(sineValue, 13);

                    TxtBox.Text = Convert.ToString(roundedSineValue);
                    break;

                case "cosh":
                    double angleInDegreesCosh = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "cosh(" + angleInDegreesCosh.ToString() + "°)";

                    double angleInRadiansCosh = angleInDegreesCosh * Math.PI / 180.0;

                    double coshValue = Math.Cosh(angleInRadiansCosh);

                    double roundedCoshValue = Math.Round(coshValue, 13);

                    TxtBox.Text = Convert.ToString(roundedCoshValue);
                    break;

                case "cos":
                    double angleInDegreesCos = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = $"cos({angleInDegreesCos}°)";

                    double angleInRadiansCos = angleInDegreesCos * Math.PI / 180.0;

                    double cosValue = Math.Cos(angleInRadiansCos);
                   
                    cosValue = Math.Round(cosValue, 13);

                    TxtBox.Text = cosValue.ToString();
                    break;

                case "tanh":
                    double angleInDegreesTanh = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "tanh(" + angleInDegreesTanh.ToString() + "°)";

                    double angleInRadiansTanh = angleInDegreesTanh * Math.PI / 180.0;

                    double tanhValue = Math.Tanh(angleInRadiansTanh);

                    double roundedTanhValue = Math.Round(tanhValue, 13);

                    TxtBox.Text = Convert.ToString(roundedTanhValue);
                    break;

                case "tan":
                    double angleInDegreesTan = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "tan(" + angleInDegreesTan.ToString() + "°)";

                    double angleInRadiansTan = angleInDegreesTan * Math.PI / 180.0;

                    double tangentValue = Math.Tan(angleInRadiansTan);

                    double roundedTangentValue = Math.Round(tangentValue, 13);

                    TxtBox.Text = Convert.ToString(roundedTangentValue);
                    break;


                case "x1":

                    valueFirst = double.Parse(TxtBox.Text);
                    TxtBox1.Text = valueFirst.ToString();
                    TxtBox1.Text = "1/" + valueFirst.ToString();
                    Result = 1.0 / valueFirst;
                    TxtBox.Text = Result.ToString();
                    break;

                case "Inx":
                    double Inx = Convert.ToDouble(TxtBox.Text);
                    TxtBox1.Text = "ln(" + Inx.ToString() + ")";
                    Inx = Math.Log(Inx);
                    TxtBox.Text = Convert.ToString(Inx);
                    break;

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0;
            valueSecond = 0.0;
            TxtBox.Text = "0";
            TxtBox1.Text = "";
            TxtBox2.Text = "";
        }

        private void PlusMinusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int x = TxtBox.Text.Length - 1;
            TxtBox.Text = TxtBox.Text.Substring(0, x);
            if (TxtBox.Text.Length == 0)
            {
                TxtBox.Text = "0";
            }
        }


        private void ZeroZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "00";
            }
            else
            {
                TxtBox.Text += "00";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 395;
            TxtBox.Width = 350;
            TxtBox1.Width = 350;
            TxtBox2.Width = 350;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 710;
            TxtBox.Width = 660;
            TxtBox1.Width = 660;
            TxtBox2.Width = 660;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 395;
            TxtBox.Width = 350;
            TxtBox1.Width = 350;
            TxtBox2.Width = 350;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit calculator?", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void PiBtn_Click(object sender, EventArgs e)
        {
            double pi = 3.1415926535897;
            TxtBox1.Text = pi.ToString();
            TxtBox.Text = pi.ToString();

        }


        private void DecBtn_Click(object sender, EventArgs e)
        {
            double dec = double.Parse(TxtBox.Text);
            TxtBox1.Text = dec.ToString();
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            TxtBox.Text = Convert.ToString(i2);
        }

        private void BinBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox1.Text = a.ToString();
            TxtBox.Text = Convert.ToString(a, 2);
        }

        private void OctBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox1.Text = a.ToString();
            TxtBox.Text = Convert.ToString(a, 8);
        }

        private void HexBtn_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TxtBox.Text);
            TxtBox1.Text = a.ToString();
            TxtBox.Text = Convert.ToString(a, 16).ToUpper();
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FracRes_Click(object sender, EventArgs e)
        {
            Decimal first = decimal.Parse(TxtBox.Text);
            Decimal wholePart = Math.Floor(first);
            Decimal fractionalPart = first - wholePart;

            Double times = 0;

            while (fractionalPart % 1 != 0)
            {
                fractionalPart = fractionalPart * 10;
                times++;
            }

            int denominator = Convert.ToInt32(Math.Pow(10, times));
            int numerator = Convert.ToInt32(fractionalPart);
            int divisor = 2;

            while (numerator >= divisor && denominator >= divisor)
            {
                if (numerator % divisor == 0 && denominator % divisor == 0)
                {
                    numerator = numerator / divisor;
                    denominator = denominator / divisor;
                }
                else
                {
                    divisor = divisor + 1;
                }
            }

            d = $"{wholePart} {numerator}/{denominator}";
            TxtBox.Text = d;
            TxtBox1.Clear();
            TxtBox2.Clear();



        }
    }

}
