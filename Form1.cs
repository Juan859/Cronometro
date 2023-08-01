using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRONOMETRO
{
    public partial class Form1 : Form
    {

        int hh, mm, ss;
        String m, s, mostrado;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Tcronometro.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Tcronometro.Stop();
        }

        private void Tcronometro_Tick(object sender, EventArgs e)
        {
            ss += 1;
            m = Convert.ToString(mm);
            s = Convert.ToString(ss);

            if  (mm < 10)
            {
                m = Convert.ToString("0" + mm);
            }

             if (ss < 10)
            {
                s = Convert.ToString("0" +ss);
            }

            lblrecorrido.Text = Convert.ToString(hh + ":" + m + ":" + s);
            

            if (ss > 59)
            {
                hh += 1;
                ss = 0;

                if (mm >=59)
                {
                    hh += 1;
                    mm = 0;
                }

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void  reiniciar()
        {
            hh = 0;
            mm = 0;
            ss = 0;
            lblrecorrido.Text = "00:00:00";
            Tcronometro.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           lblrecorrido.Text = "00:00:00";

        }
    }
}
