using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class Form1 : Form
    {
        private Luzes s;
        public Form1()
        {
            InitializeComponent();
            s = new Luzes();
            atualizaInterface();
        }

        private void atualizaInterface()
        {
            lbl3.Text = Convert.ToString(s.getEstado(),2);
            pic1.Image = (s.getEstado(1) == 1) ? Semaforo.Properties.Resources.GREEN :
               ( s.getEstado(1) == 2) ? Semaforo.Properties.Resources.YELLOW : 
                Semaforo.Properties.Resources.RED;

            pic2.Image = (s.getEstado(2) == 1) ? Semaforo.Properties.Resources.GREEN :
                (s.getEstado(2) == 2) ? Semaforo.Properties.Resources.YELLOW :
                Semaforo.Properties.Resources.RED;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           s.setVerde(rad1.Checked ? 1 : 2);
            atualizaInterface();
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            s.setAmarelo(rad1.Checked ? 1 : 2);
            atualizaInterface();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            s.setVermelho(rad1.Checked ? 1 : 2);
            atualizaInterface();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Text = (btnA.Text == "LIGA") ? "DESLIGA" : "LIGA";
                timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s.getEstado(1) == 1)
            {
                s.setAmarelo(1);
            }
            else
            {
                if (s.getEstado(1) == 2)
                {
                    s.setVermelho(1);
                    s.setVerde(2);
                }
                else
                    if (s.getEstado(2)==1)
                {
                    s.setAmarelo(2);
                }
                else
                    if (s.getEstado(2) == 2)
                {
                    s.setVermelho(2);
                    s.setVerde(1);
                }
            }

           
            
            atualizaInterface();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
