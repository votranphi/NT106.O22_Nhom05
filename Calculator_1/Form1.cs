using System.Reflection.Metadata;

namespace Calculator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string option = "";
        double result = 0;
        bool check = false;


        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
           
            txtDisplay.Text = txtDisplay.Text + btn7.Text;

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn9.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn6.Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn1.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn3.Text;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || check)
                txtDisplay.Clear();
            check = false;
            txtDisplay.Text = txtDisplay.Text + btn0.Text;

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";

            //if (result != 0)
            //{
            //    btnEql.PerformClick();
            //    check = true;
            //    label1.Text = result + " " + option;
            //}
            //else
            //{
            //    result = double.Parse(txtDisplay.Text);
            //    label1.Text = result + " " + option;
            //    check = true;

            //}
            result = double.Parse(txtDisplay.Text);
            label1.Text = result + " " + option;
            check = true;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";

            //if (result != 0)
            //{
            //    btnEql.PerformClick();
            //    check = true;
            //    label1.Text = result + " " + option;
            //}
            //else
            //{
            //    result = double.Parse(txtDisplay.Text);
            //    label1.Text = result + " " + option;
            //    check = true;

            //}
            result = double.Parse(txtDisplay.Text);
            label1.Text = result + " " + option;
            check = true;

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";

            //if (result != 0)
            //{
            //    btnEql.PerformClick();
            //    check = true;
            //    label1.Text = result + " " + option;
            //}
            //else
            //{
            //    result = double.Parse(txtDisplay.Text);
            //    label1.Text = result + " " + option;
            //    check = true;

            //}
            result = double.Parse(txtDisplay.Text);
            label1.Text = result + " " + option;
            check = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";

            //if (result != 0)
            //{
            //    btnEql.PerformClick();
            //    check = true;
            //    label1.Text = result + " " + option;
            //}
            //else
            //{
            //    result = double.Parse(txtDisplay.Text);
            //    label1.Text = result + " " + option;
            //    check = true;

            //}
            result = double.Parse(txtDisplay.Text);
            label1.Text = result + " " + option;
            check = true;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {

            if (option == "+")
            {
                result = result + double.Parse(txtDisplay.Text);
                txtDisplay.Text = result.ToString();

            }
            else if (option == "-")
            {
                result = result - double.Parse(txtDisplay.Text);
                txtDisplay.Text = result.ToString();

            }
            else if (option == "*")
            {
                result = result * double.Parse(txtDisplay.Text);
                txtDisplay.Text = result.ToString();

            }
            else if (option == "/")
            {
                result = result / double.Parse(txtDisplay.Text);
                txtDisplay.Text = result.ToString();

            }
            //result = Int32.Parse(txtDisplay.Text);

            label1.Text = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains(".")) 
            { 
                txtDisplay.Text = txtDisplay.Text + btnDot.Text;

            }
        }
    }
}