namespace meus_livros
{
    partial class FrmDetalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picLivroSelecionado = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttVoltar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.lblSinopse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLivroSelecionado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLivroSelecionado
            // 
            this.picLivroSelecionado.Location = new System.Drawing.Point(40, 37);
            this.picLivroSelecionado.Name = "picLivroSelecionado";
            this.picLivroSelecionado.Size = new System.Drawing.Size(204, 243);
            this.picLivroSelecionado.TabIndex = 0;
            this.picLivroSelecionado.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.bttVoltar);
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 58);
            this.panel1.TabIndex = 1;
            // 
            // bttVoltar
            // 
            this.bttVoltar.BackColor = System.Drawing.SystemColors.Info;
            this.bttVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttVoltar.Location = new System.Drawing.Point(330, 12);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(148, 29);
            this.bttVoltar.TabIndex = 0;
            this.bttVoltar.Text = "Voltar";
            this.bttVoltar.UseVisualStyleBackColor = false;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(369, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(29, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "AUTOR(A):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "GÊNERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "EDITORA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "ANO DE LANÇAMENTO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "N° DE PÁGINAS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "DESCRIÇÃO:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(410, 71);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(29, 17);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "xxx";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(396, 103);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(29, 17);
            this.lblGenero.TabIndex = 10;
            this.lblGenero.Text = "xxx";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(396, 135);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(29, 17);
            this.lblEditora.TabIndex = 11;
            this.lblEditora.Text = "xxx";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(528, 167);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 17);
            this.lblAno.TabIndex = 12;
            this.lblAno.Text = "xxx";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(459, 201);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(29, 17);
            this.lblPagina.TabIndex = 13;
            this.lblPagina.Text = "xxx";
            // 
            // lblSinopse
            // 
            this.lblSinopse.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinopse.Location = new System.Drawing.Point(286, 260);
            this.lblSinopse.Name = "lblSinopse";
            this.lblSinopse.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblSinopse.Size = new System.Drawing.Size(482, 114);
            this.lblSinopse.TabIndex = 14;
            this.lblSinopse.Text = "xxx";
            // 
            // FrmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSinopse);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picLivroSelecionado);
            this.Name = "FrmDetalhes";
            this.Text = "Detalhes";
            ((System.ComponentModel.ISupportInitialize)(this.picLivroSelecionado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLivroSelecionado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label lblSinopse;
        private System.Windows.Forms.Button bttVoltar;
    }
}