namespace PrimeNumber
{
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
        }

        public bool isNumValid(string input)
        {
            int num = 0;
            if (input == null)
            {
                MessageBox.Show("Number Input is Empty!!","Number Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (input == "0")
            {
                MessageBox.Show("0 is not a valid number for a prime number", "Number Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (input == "1")
            {
                MessageBox.Show("1 is not a valid number for a prime number", "Number Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(input, out num) )
            {
                MessageBox.Show("Number must be numerical", "Number Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public string PrimeOrNot(string input)
        {
            string prime;
            //var num = int.Parse(input);
            int num = Convert.ToInt32(input);
            int count = 2;

            do
            {
                count++;
            } while (num % count != 0);
            if (count == num)
            {
                prime = num + " is a prime number";
            }
            else
            {
                prime = num + " is not a prime number as it is divisible by " + count; 
            }
            return prime;
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            do
            {
                txtNum.Text = "";
            } while (isNumValid(txtNum.Text));
            txtPrime.Text = PrimeOrNot(txtNum.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtPrime.Text = "";
        }

    }
}