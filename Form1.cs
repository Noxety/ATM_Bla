using System.Security.Principal;

namespace ATM
{
    public partial class Form1 : Form
    {
        Person person = new Person();
        public Form1()
        {
            InitializeComponent();
            person.Pin = "1122";
            person.Balance = 10000.40;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "6";


            }
            else
            {
                textP.Text = "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "4";


            }
            else
            {
                textP.Text = "4";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "9";


            }
            else
            {
                textP.Text = "9";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "3";


            }
            else
            {
                textP.Text = "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "7";


            }
            else
            {
                textP.Text = "7";
            }
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "8";


            }
            else
            {
                textP.Text = "8";
            }
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "5";


            }
            else
            {
                textP.Text = "5";
            }
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {


                textP.Text = textP.Text + "2";


            }
            else
            {
                textP.Text = "2";
            }
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "1";


            }
            else
            {
                textP.Text = "1";
            }
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            if (textP.Text != "")
            {

                textP.Text = textP.Text + "0";


            }
            else
            {
                textP.Text = "0";
            }
        }

        private void buttC_Click(object sender, EventArgs e)
        {
            textP.Text = "";
        }

        private void buttA_Click(object sender, EventArgs e)
        {
            textP.Text = textP.Text.Remove(textP.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (person.Con_Pin == person.Pin)
            {
                labPer.Text = Convert.ToString(person.Balance);
            }
            else
            {
                labPer.Text = "Enter your pin to Log In";
            }



        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (person.Con_Pin == person.Pin)
            {
                if (textP.Text == "")
                {
                    MessageBox.Show("Enter Your amount to withdraw.");
                }
                else
                {
                    if (person.Balance > Convert.ToDouble(textP.Text))
                    {
                        person.Balance = person.Balance - Convert.ToDouble(textP.Text);
                        labPer.Text = $"Your Now Balance is {person.Balance} and you withdraw {textP.Text}";
                        textP.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Your amount is lower than your withdraw amount!!!");
                        textP.Text = "";
                    }

                }
            }
            else
            {
                labPer.Text = "Enter your pin to Log In";
            }



        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (person.Con_Pin == person.Pin)
            {
                MessageBox.Show($"Your balance is {person.Balance}. ");
            }
            else
            {
                labPer.Text = "Enter your pin to Log In";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            person.Con_Pin = "";
            labPer.Text = "Enter Yout pin to log in";
            buttC.Visible = true;
            buttA.Visible = true;
            MessageBox.Show("Account have been log out");
        }

        private void button16_Click(object sender, EventArgs e)
        {

            if (textP.Text == person.Pin)
            {
                /*                MessageBox.Show("Your PIN is correct");*/
                labPer.Text = "Welcome";
                person.Con_Pin = textP.Text;
                textP.Text = "";
                /*      butt0.Visible = false;
                      butt1.Visible = false;
                      butt2.Visible = false;
                      butt3.Visible = false;
                      butt4.Visible = false;
                      butt5.Visible = false;
                      butt6.Visible = false;
                      butt7.Visible = false;
                      butt8.Visible = false;
                      butt9.Visible = false; */
                buttA.Visible = false;
                buttC.Visible = false;

            }
            else
            {
                MessageBox.Show("Your PIN is Wrong try again!!!");
                textP.Text = "";
            }
        }
    }
}
