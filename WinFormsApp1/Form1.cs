using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text += "0";
        }

        private void btn_punkt_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list.Any() && list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && !list.Last().Contains(","))
            {
                textBox_eingabe.Text += ",";
            }
        }

        private void btn_negativ_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();


            if (!list.Any())
            {
                textBox_eingabe.Text += "-";

            }
            else if ((list.Last() == "+" || list.Last() == "-" || list.Last() == "*" || list.Last() == "/") && textBox_eingabe.Text.Last() == ' ')
            {

                textBox_eingabe.Text += "-";
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list.Any() && list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && textBox_eingabe.Text.Last() != ',')
            {
                textBox_eingabe.Text += " + ";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list.Any() && list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && textBox_eingabe.Text.Last() != ',')
            {
                textBox_eingabe.Text += " - ";
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list.Any() && list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && textBox_eingabe.Text.Last() != ',')
            {
                textBox_eingabe.Text += " * ";
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (list.Any() && list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && textBox_eingabe.Text.Last() != ',')
            {
                textBox_eingabe.Text += " / ";
            }
        }
        private void Löschen_Click(object sender, EventArgs e)
        {
            textBox_eingabe.Text = "";
        }
        private void btn_gleich_Click(object sender, EventArgs e)
        {
            if (textBox_eingabe.Text.Contains('='))
            {
                textBox_eingabe.Text = textBox_eingabe.Text.Split('=').Last().Trim();
            }

            List<string> list = textBox_eingabe.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            char lasChar = textBox_eingabe.Text.Last();
            if (list.Last() != "+" && list.Last() != "-" && list.Last() != "*" && list.Last() != "/" && textBox_eingabe.Text.Last() != ',')
            {
                for (int i = 1; i < list.Count; i++)
                {
                    switch (list[i])
                    {
                        case "*":
                            double result = double.Parse(list[i - 1]) * double.Parse(list[i + 1]);
                            list[i - 1] = result.ToString();
                            list.RemoveAt(i);
                            list.RemoveAt(i);
                            i--;
                            break;
                        case "/":
                            double result1 = double.Parse(list[i - 1]) / double.Parse(list[i + 1]);
                            list[i - 1] = result1.ToString();
                            list.RemoveAt(i);
                            list.RemoveAt(i);
                            i--;
                            break;
                    }
                }
                
                
                    double totalResult = double.Parse(list[0]);
                    for (int i = 1; i < list.Count; i += 2)
                    {
                        string operand = list[i];
                        double zahl = double.Parse(list[i + 1]);
                        switch (operand)
                        {
                            case "+":
                                totalResult += zahl;
                                break;
                            case "-":
                                totalResult -= zahl;
                                break;
                        }
                    }
                    textBox_eingabe.Text = textBox_eingabe.Text + " = " + Math.Round( totalResult ,2).ToString();
                }
            }
        }
    }


