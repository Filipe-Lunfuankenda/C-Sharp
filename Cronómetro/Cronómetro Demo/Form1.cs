using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronómetro_Demo
{
    public partial class Form1 : Form
    {
        private TimeSpan tempoDecorrido;
        private bool emExecucao;
        private DateTime horaInicio;
        public Form1()
        {
            InitializeComponent();
            emExecucao = false;
            tempoDecorrido = TimeSpan.Zero;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(!emExecucao)
            {
                horaInicio = DateTime.Now - tempoDecorrido;
                emExecucao = true;
                timer1.Start();
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if(emExecucao)
            {
                timer1.Stop();
                tempoDecorrido = DateTime.Now - horaInicio;
                emExecucao = false;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if(!emExecucao)
            {
                horaInicio = DateTime.Now - tempoDecorrido;
                emExecucao = true;
                timer1.Start();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if( emExecucao)
            {
                timer1.Stop();
                tempoDecorrido = TimeSpan.Zero;
                emExecucao = false;
                lblTempoDecorrido.Text = "00:00:00";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tempoPassado = DateTime.Now - horaInicio;
            lblTempoDecorrido.Text = tempoPassado.ToString(@"hh\:mm\:ss");
        }
    }
}
