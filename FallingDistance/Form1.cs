namespace FallingDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double FallingDistance(double time)
        {
            const double GRAVITY = 9.8;
            return 0.5 * GRAVITY * time * time;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtInput.Text, out double time) && time >0)
            {
                double distance = FallingDistance(time);
                lblOutput.Text = $"The object will fall {distance:F2} meters in {time} seconds.";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for time.");
            }

        }
    }
}
