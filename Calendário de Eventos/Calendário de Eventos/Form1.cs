using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendário_de_Eventos
{
    public partial class Form1 : Form
    {
        private Dictionary<DateTime, List<string>> eventos = new Dictionary<DateTime, List<string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calendário de Eventos";
            monthCalendar1.MaxSelectionCount = 1; //Permite selecionar apenas um dia no calendário
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizarListaDeEventos(e.Start);
        }

        private void btnAdicionarEvento_Click(object sender, EventArgs e)
        {
            DateTime data_selecionada = monthCalendar1.SelectionStart;
            string novoEvento = txtNovoEvento.Text.Trim();
            if (!string.IsNullOrEmpty(novoEvento))
            {
                if (eventos.ContainsKey(data_selecionada))
                {
                    eventos[data_selecionada].Add(novoEvento);
                }
                else
                {
                    eventos[data_selecionada] = new List<string> { novoEvento };
                }
                AtualizarListaDeEventos(data_selecionada);
                txtNovoEvento.Text = string.Empty;
            }
        }

        private void btnEditarEvento_Click(object sender, EventArgs e)
        {
            DateTime data_selecionada = monthCalendar1.SelectionStart;
            int index = lstEventos.SelectedIndex;
            if(index != -1)
            {
                string evento_atualizado = txtNovoEvento.Text.Trim();
                if (!string.IsNullOrEmpty(evento_atualizado))
                {
                    eventos[data_selecionada][index] = evento_atualizado;
                    AtualizarListaDeEventos(data_selecionada);
                    txtNovoEvento.Text = string.Empty;
                }
            }
        }

        private void btnExcluirEvento_Click(object sender, EventArgs e)
        {
            DateTime data_selecionada = monthCalendar1.SelectionStart;
            int index = lstEventos.SelectedIndex;
            if(index != -1)
            {
                eventos[data_selecionada].RemoveAt(index);
                AtualizarListaDeEventos(data_selecionada);
            }
        }

        private void AtualizarListaDeEventos(DateTime data_selecionada)
        {
            lstEventos.Items.Clear();
            if (eventos.ContainsKey(data_selecionada))
            {
                foreach(string evento in eventos[data_selecionada])
                {
                    lstEventos.Items.Add(evento);
                }
            }
        }
    }
}
