using System.Security.Cryptography.X509Certificates;

namespace Elevator
{
    public partial class Asansor : Form
    {
        public int degisim;

        public int hedefkat;
        public int asansorbottom;
        public int bombastic;

        public int a;



        public Asansor()
        {
            InitializeComponent();


        }

        public void Asansor_Load(object sender, EventArgs e)
        {



        }

        private void k1buton_Click(object sender, EventArgs e)
        {
            hedefkat = kat1.Top;
            timer1.Enabled = true;

        }

        private void k0buton_Click(object sender, EventArgs e)
        {
            hedefkat = zemin.Top;
            timer1.Enabled = true;
        }

        private void kat2buton_Click(object sender, EventArgs e)
        {
            hedefkat = kat2.Top;
            timer1.Enabled = true;
        }

        private void kat3buton_Click(object sender, EventArgs e)
        {
            hedefkat = kat3.Top;
            timer1.Enabled = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            asansorbottom = Elevator.Top - 107;


            if (asansorbottom < hedefkat)
            {
                degisim = 1;
            }

            else if (asansorbottom > hedefkat)
            {


                degisim = 0;

            }




            switch (degisim)
            {
                case 0:
                    while (asansorbottom != hedefkat)
                    {

                        asansorbottom--;

                        Elevator.Top = asansorbottom - 107;

                        await Task.Delay(10);


                    }
                    break;

                case 1:

                    while (asansorbottom != hedefkat)
                    {

                        asansorbottom++;
                        Elevator.Top = asansorbottom - 107;
                        await Task.Delay(10);
                    }
                    break;



            }
            timer1.Enabled = false;

        }
    }
}