using carrental;

namespace CarRental
{
    public partial class Splash : Form
    {

        public Splash()
        {

            InitializeComponent();
        }
        int startpoint = 0;
        private void timerl_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Myprogress.Value = startpoint;
            Percentage.Text = "" + startpoint;
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log - Show();
                this.Hide();

            }
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
