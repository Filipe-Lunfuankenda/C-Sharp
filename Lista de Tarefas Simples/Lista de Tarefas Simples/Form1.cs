using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Tarefas_Simples
{
    public partial class Form1 : Form
    {
        private List<string> tarefas = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Menu de Tarefas";
        }

        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            string nova_tarefa = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(nova_tarefa))
            {
                tarefas.Add(nova_tarefa);
                AtualizarListaDeTarefas();
                textBox1.Text = string.Empty;
            }
        }

        private void btnMarcarConcluído_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                tarefas.RemoveAt(index);
                AtualizarListaDeTarefas();
            }
        }

        private void AtualizarListaDeTarefas()
        {
            listBox1.Items.Clear();
            foreach(string tarefa in tarefas)
            {
                listBox1.Items.Add(tarefa);
            }
        }
    }
}
