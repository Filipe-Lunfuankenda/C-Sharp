namespace Calendário_de_Eventos
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.btnAdicionarEvento = new System.Windows.Forms.Button();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.btnExcluirEvento = new System.Windows.Forms.Button();
            this.txtNovoEvento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(90, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lstEventos
            // 
            this.lstEventos.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstEventos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEventos.ForeColor = System.Drawing.Color.Firebrick;
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 17;
            this.lstEventos.Location = new System.Drawing.Point(12, 350);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(600, 140);
            this.lstEventos.TabIndex = 1;
            // 
            // btnAdicionarEvento
            // 
            this.btnAdicionarEvento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdicionarEvento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEvento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAdicionarEvento.Location = new System.Drawing.Point(537, 18);
            this.btnAdicionarEvento.Name = "btnAdicionarEvento";
            this.btnAdicionarEvento.Size = new System.Drawing.Size(75, 48);
            this.btnAdicionarEvento.TabIndex = 2;
            this.btnAdicionarEvento.Text = "Adicionar Evento";
            this.btnAdicionarEvento.UseVisualStyleBackColor = false;
            this.btnAdicionarEvento.Click += new System.EventHandler(this.btnAdicionarEvento_Click);
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnEditarEvento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEditarEvento.Location = new System.Drawing.Point(537, 72);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(75, 48);
            this.btnEditarEvento.TabIndex = 3;
            this.btnEditarEvento.Text = "Editar Evento";
            this.btnEditarEvento.UseVisualStyleBackColor = false;
            this.btnEditarEvento.Click += new System.EventHandler(this.btnEditarEvento_Click);
            // 
            // btnExcluirEvento
            // 
            this.btnExcluirEvento.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExcluirEvento.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirEvento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnExcluirEvento.Location = new System.Drawing.Point(537, 126);
            this.btnExcluirEvento.Name = "btnExcluirEvento";
            this.btnExcluirEvento.Size = new System.Drawing.Size(75, 48);
            this.btnExcluirEvento.TabIndex = 4;
            this.btnExcluirEvento.Text = "Excluir Evento";
            this.btnExcluirEvento.UseVisualStyleBackColor = false;
            this.btnExcluirEvento.Click += new System.EventHandler(this.btnExcluirEvento_Click);
            // 
            // txtNovoEvento
            // 
            this.txtNovoEvento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoEvento.Location = new System.Drawing.Point(12, 192);
            this.txtNovoEvento.Multiline = true;
            this.txtNovoEvento.Name = "txtNovoEvento";
            this.txtNovoEvento.Size = new System.Drawing.Size(600, 152);
            this.txtNovoEvento.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(624, 497);
            this.Controls.Add(this.txtNovoEvento);
            this.Controls.Add(this.btnExcluirEvento);
            this.Controls.Add(this.btnEditarEvento);
            this.Controls.Add(this.btnAdicionarEvento);
            this.Controls.Add(this.lstEventos);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lstEventos;
        private System.Windows.Forms.Button btnAdicionarEvento;
        private System.Windows.Forms.Button btnEditarEvento;
        private System.Windows.Forms.Button btnExcluirEvento;
        private System.Windows.Forms.TextBox txtNovoEvento;
    }
}

