namespace Proje_Surec_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1_Tick(sender, e, progressBar1);
        }

        private void timer1_Tick(object sender, EventArgs e, ProgressBar progressBar1)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value % 20 == 20)
            {
                label1.BackColor = Color.White;

            }

            if (progressBar1.Value == 100)
            {


                timer1.Stop();
                timer2.Start();


            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Red;

            }
            if (progressBar2.Value % 10 == 5)
            {

                label2.BackColor = Color.White;

            }

            if (progressBar2.Value == 100)
            {

                timer2.Stop();
                timer3.Start();
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 40 == 0)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 40 == 20)
            {
                label3.BackColor = Color.Red;
            }

            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }





        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 1;
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Red;
            }
            if (progressBar4.Value % 2 == 1)
            {
                label4.BackColor = Color.White;
            }
            if (progressBar4.Value==100)
            {

                timer4.Stop();
                MessageBox.Show("Ýþlem Tamamlandý");

            }

        }
    }
}