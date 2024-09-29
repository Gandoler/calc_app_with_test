namespace calc_app
{
    public partial class Form1 : Form
    {

        public const int MAXSIZE = 10;
        private readonly ICalculatorView view;

        Calculator calc_class = new Calculator();


        int operation = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_0_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length > 0) && (displaychik.Text.Length <= MAXSIZE) && (displaychik.Text != "-"))
            {
                displaychik.Text = displaychik.Text + Button_0.Text;
            }
        }

        private void Button_1_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_1.Text;
            }
        }

        
        

        private void Button_2_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_2.Text;
            }
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_3.Text;
            }
        }

        private void Button_4_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_4.Text;
            }
        }

        private void Button_5_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_5.Text;
            }
        }

        private void Button_6_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_6.Text;
            }
        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_7.Text;
            }
        }

        private void Button_8_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_8.Text;
            }
        }

        private void Button_9_Click(object sender, EventArgs e)
        {
            if ((displaychik.Text.Length <= MAXSIZE))
            {
                displaychik.Text = displaychik.Text + Button_9.Text;
            }
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            calc_class.Put_A(float.Parse(displaychik.Text));
            displaychik.Text = "";

            operation = 1;
        }

        private void Button_minus_Click(object sender, EventArgs e)
        {
            if (displaychik.Text.Length == 0)
            {
                displaychik.Text = "-";
            }
            else
            {
                if (displaychik.Text == "-")
                {
                    displaychik.Text = "";

                }
                else
                {
                    calc_class.Put_A(float.Parse(displaychik.Text));
                    displaychik.Text = "";
                    operation = 2;
                }

            }
        }

        private void Button_multiply_Click(object sender, EventArgs e)
        {
            if (displaychik.Text == "")
            {
                calc_class.Put_A(0);
            }
            else
            {
                calc_class.Put_A(float.Parse(displaychik.Text));
            }
            displaychik.Text = "";
            operation = 3;
        }

        private void Button_divide_Click(object sender, EventArgs e)
        {
            if (displaychik.Text == "")
            {
                calc_class.Put_A(0);
            }
            else
            {
                calc_class.Put_A(float.Parse(displaychik.Text));
            }
            displaychik.Text = "";
            operation = 4;
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            displaychik.Text = "";
            operation = 0;
        }

        private void Button_equal_Click(object sender, EventArgs e)
        {
            double local_tmp = 0;
            switch (operation)
            {
                case 0:
                    break;
                case 1:
                    if (displaychik.Text == "")
                    {
                        calc_class.Clear_B();
                    }
                    else
                    {
                        local_tmp = float.Parse(displaychik.Text);
                    }
                    calc_class.plus(local_tmp);

                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 2:
                    if (displaychik.Text == "")
                    {
                        calc_class.Clear_B();
                    }
                    else
                    {
                        local_tmp = float.Parse(displaychik.Text);
                    }

                    calc_class.minus(local_tmp);
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 3:
                    if (displaychik.Text == "")
                    {
                        calc_class.Clear_B();
                    }
                    else
                    {
                        local_tmp = float.Parse(displaychik.Text);
                    }
                    calc_class.multiple(local_tmp);
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;
                case 4:
                    if (displaychik.Text == "")
                    {
                        calc_class.Clear_B();
                    }
                    else
                    {
                        local_tmp = float.Parse(displaychik.Text);
                    }
                    try
                    {
                        calc_class.divide(local_tmp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка деления\n\t\tПодробности:\n" + ex);
                        calc_class.Clear_A();
                        calc_class.Clear_B();
                        operation = 0;
                    }
                    check_type_float_or_void_and_print();
                    operation = 0;
                    break;

            }
        }


        private void check_type_float_or_void_and_print()
        {
            if (calc_class.Get_A() % 1 == 0)
            {
                try
                {
                    displaychik.Text = (checked((int)calc_class.Get_A())).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка переполнения\n\t\tПодробности:\n" + ex);
                    calc_class.Clear_A();
                    calc_class.Clear_B();
                    operation = 0;
                }
            }
            else
            {
                displaychik.Text = calc_class.Get_A().ToString();
                view.DisplayText = calc_class.Get_A().ToString();
            }
        }

        
    }
}
