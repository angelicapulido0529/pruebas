namespace camaleon
{
    public partial class Form1 : Form
    {
        private int energia;
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            IniciarEnergy();

        }
        private void IniciarEnergy()
        {
            int baseAleatoria = rnd.Next(0, 11);
            energia = baseAleatoria * 10;
            Energy.Value = energia;
        }

        private void Comer_Click(object sender, EventArgs e)
        {
            if (Energy.Value == Energy.Maximum)
            {
                MessageBox.Show("Ya no tiene hambre :3");
                Comer.Enabled = false;
                Jugar.Enabled = true;
                Dormir.Enabled = false;
                Fiesta.Enabled = true;
            }
            if (Energy.Value < Energy.Maximum)
            {

                Energy.PerformStep();
                Jugar.Enabled = true;
                Fiesta.Enabled = true;
            }

        }

        private void Jugar_Click(object sender, EventArgs e)
        {

            if (Energy.Value == Energy.Minimum)
            {
                MessageBox.Show("Ya esta cansado");
                Fiesta.Enabled = false;
                Comer.Enabled = true;
                Jugar.Enabled = false;
                Dormir.Enabled = true;
            }
            else
            {
                if (Energy.Value > 0)
                {

                    Energy.Value -= 10;
                    Dormir.Enabled = true;
                    Comer.Enabled = true;
                }
            }
        }

        private void Dormir_Click(object sender, EventArgs e)
        {
            if (Energy.Value == Energy.Maximum)
            {
                MessageBox.Show("Ya no tiene sueño :3");
                Comer.Enabled = false;
                Jugar.Enabled = true;
                Dormir.Enabled = false;
                Fiesta.Enabled = true;
            }
            if (Energy.Value < Energy.Maximum)
            {

                Energy.PerformStep();
                Jugar.Enabled = true;
                Fiesta.Enabled = true;
            }
        }

        private void Fiesta_Click(object sender, EventArgs e)
        {
            if (Energy.Value == Energy.Minimum)
            {
                MessageBox.Show("Ya esta cansado");
                Fiesta.Enabled = false;
                Comer.Enabled = true;
                Jugar.Enabled = false;
                Dormir.Enabled = true;

            }
            else
            {
                if (Energy.Value > 0)
                {

                    Energy.Value -= 10;
                    Dormir.Enabled = true;
                    Comer.Enabled = true;
                }
            }
        }

        private void Energy_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
