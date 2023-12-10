namespace Exercice2
{
    public partial class FormExercice2 : Form
    {
        const int max = 10;
        int div = max;

        public FormExercice2()
        {
            InitializeComponent();
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if(buttonRun.Text == "Start")
            {
                buttonRun.Text = "Stop";
                timerCounter.Enabled = true;
            } else
            {
                buttonRun.Text = "Start";
                timerCounter.Enabled = false;

            }
        }

         private void timerCounter_Tick(object sender, EventArgs e)
        {
            if (div != 0)
            {
                double result = (double)max / div;
                labelCounter.Text = string.Format("{0:N2}", result);
                div--;
            }
            else
            {
                labelCounter.Text = "Invalid value"; 
                timerCounter.Enabled = false; 
            }

            labelCounter.Update();
        }
    }
    
}