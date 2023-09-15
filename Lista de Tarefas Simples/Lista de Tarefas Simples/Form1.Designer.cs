namespace Lista_de_Tarefas_Simples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdicionarTarefa = new System.Windows.Forms.Button();
            this.btnMarcarConcluído = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(757, 169);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(653, 196);
            this.listBox1.TabIndex = 1;
            // 
            // btnAdicionarTarefa
            // 
            this.btnAdicionarTarefa.BackColor = System.Drawing.Color.Cornsilk;
            this.btnAdicionarTarefa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTarefa.Location = new System.Drawing.Point(671, 187);
            this.btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            this.btnAdicionarTarefa.Size = new System.Drawing.Size(98, 54);
            this.btnAdicionarTarefa.TabIndex = 2;
            this.btnAdicionarTarefa.Text = "Adicionar Tarefa";
            this.btnAdicionarTarefa.UseVisualStyleBackColor = false;
            this.btnAdicionarTarefa.Click += new System.EventHandler(this.btnAdicionarTarefa_Click);
            // 
            // btnMarcarConcluído
            // 
            this.btnMarcarConcluído.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMarcarConcluído.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarConcluído.Location = new System.Drawing.Point(671, 329);
            this.btnMarcarConcluído.Name = "btnMarcarConcluído";
            this.btnMarcarConcluído.Size = new System.Drawing.Size(98, 54);
            this.btnMarcarConcluído.TabIndex = 3;
            this.btnMarcarConcluído.Text = "Marcar Tarefa Como Concluída";
            this.btnMarcarConcluído.UseVisualStyleBackColor = false;
            this.btnMarcarConcluído.Click += new System.EventHandler(this.btnMarcarConcluído_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(781, 395);
            this.Controls.Add(this.btnMarcarConcluído);
            this.Controls.Add(this.btnAdicionarTarefa);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdicionarTarefa;
        private System.Windows.Forms.Button btnMarcarConcluído;
    }
}

