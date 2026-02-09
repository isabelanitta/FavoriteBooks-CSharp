namespace meus_livros
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pict4 = new System.Windows.Forms.PictureBox();
            this.pict3 = new System.Windows.Forms.PictureBox();
            this.pict2 = new System.Windows.Forms.PictureBox();
            this.pict1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(142, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "MINHA ESTANTE DE FAVORITOS!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clique em uma capa de livro e veja mais informações";
            // 
            // pict4
            // 
            this.pict4.ErrorImage = global::meus_livros.Properties.Resources.livro_tododia;
            this.pict4.Image = global::meus_livros.Properties.Resources.livro_tododia;
            this.pict4.Location = new System.Drawing.Point(595, 159);
            this.pict4.Name = "pict4";
            this.pict4.Size = new System.Drawing.Size(144, 205);
            this.pict4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict4.TabIndex = 5;
            this.pict4.TabStop = false;
            this.pict4.Click += new System.EventHandler(this.pict4_Click);
            // 
            // pict3
            // 
            this.pict3.ErrorImage = global::meus_livros.Properties.Resources.livro_cincopassos;
            this.pict3.Image = global::meus_livros.Properties.Resources.livro_cincopassos;
            this.pict3.Location = new System.Drawing.Point(414, 159);
            this.pict3.Name = "pict3";
            this.pict3.Size = new System.Drawing.Size(143, 205);
            this.pict3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict3.TabIndex = 4;
            this.pict3.TabStop = false;
            this.pict3.Click += new System.EventHandler(this.pict3_Click);
            // 
            // pict2
            // 
            this.pict2.ErrorImage = global::meus_livros.Properties.Resources.livro_algernon;
            this.pict2.Image = global::meus_livros.Properties.Resources.livro_algernon;
            this.pict2.Location = new System.Drawing.Point(240, 159);
            this.pict2.Name = "pict2";
            this.pict2.Size = new System.Drawing.Size(137, 205);
            this.pict2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict2.TabIndex = 3;
            this.pict2.TabStop = false;
            this.pict2.Click += new System.EventHandler(this.pict2_Click);
            // 
            // pict1
            // 
            this.pict1.ErrorImage = global::meus_livros.Properties.Resources.livro_agatha;
            this.pict1.Image = global::meus_livros.Properties.Resources.livro_agatha;
            this.pict1.Location = new System.Drawing.Point(70, 159);
            this.pict1.Name = "pict1";
            this.pict1.Size = new System.Drawing.Size(137, 205);
            this.pict1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict1.TabIndex = 2;
            this.pict1.TabStop = false;
            this.pict1.Click += new System.EventHandler(this.pict1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 122);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 58);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "\"A leitura é uma porta aberta para um mundo infinito de possibilidades.\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label4.Location = new System.Drawing.Point(668, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "BY: Isabela Nitta";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pict1);
            this.Controls.Add(this.pict4);
            this.Controls.Add(this.pict3);
            this.Controls.Add(this.pict2);
            this.Name = "FrmPrincipal";
            this.Text = "Estante";
            ((System.ComponentModel.ISupportInitialize)(this.pict4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pict1;
        private System.Windows.Forms.PictureBox pict2;
        private System.Windows.Forms.PictureBox pict3;
        private System.Windows.Forms.PictureBox pict4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

