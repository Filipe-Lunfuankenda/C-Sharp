namespace Cronómetro_Demo
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
            this.components = new System.ComponentModel.Container();
            this.lblTempoDecorrido = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempoDecorrido
            // 
            this.lblTempoDecorrido.AutoSize = true;
            this.lblTempoDecorrido.Font = new System.Drawing.Font("DS-Digital", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoDecorrido.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTempoDecorrido.Location = new System.Drawing.Point(186, 89);
            this.lblTempoDecorrido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTempoDecorrido.Name = "lblTempoDecorrido";
            this.lblTempoDecorrido.Size = new System.Drawing.Size(364, 95);
            this.lblTempoDecorrido.TabIndex = 0;
            this.lblTempoDecorrido.Text = "00:00:00";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(552, 226);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(162, 41);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(202, 226);
            this.btnPausar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(162, 41);
            this.btnPausar.TabIndex = 0;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(377, 226);
            this.btnContinuar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(162, 41);
            this.btnContinuar.TabIndex = 0;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(26, 226);
            this.btnParar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(162, 41);
            this.btnParar.TabIndex = 0;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRONÓMETRO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTempoDecorrido);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempoDecorrido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

