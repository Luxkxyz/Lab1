using System.Drawing.Text;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "CIS KKU";
        }

        private void buttonClear(object sender, EventArgs e)
        {

            textBoxinput.Text = string.Empty;
            string number1 = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "5";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string userinput = textBoxinput.Text;
            textBoxinput.Text = userinput + "9";
        }

        string number1 = string.Empty;
        string number2 = string.Empty;
        string operation = string.Empty;
        
        private void Plus(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "+";
        }

        private void Minus(object sender, EventArgs e)
        {
            number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "-";
        }
        
        private void equal(object sender, EventArgs e)
        {
            string number2 = textBoxinput.Text;
            
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);
            float output = 0;
            if (operation == "+")
            { 
                output = num1 + num2;
            }
            if (operation == "-")
            {
                output = num1 - num2;
            }
            if (operation == "x")
            {

                output = num1 * num2;
            }
            if (operation == "/")
            {

                output = num1 / num2;
            }
            output.ToString();

            textBoxinput.Text = output.ToString();
        }

        private void Divide(object sender, EventArgs e)
        {
             number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
             operation = "/";
        }

        private void Multiply(object sender, EventArgs e)
        {
             number1 = textBoxinput.Text;
            textBoxinput.Text = string.Empty;
            operation = "x";
        }
    }
}
