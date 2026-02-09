using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meus_livros
{
    public partial class FrmDetalhes : Form
    {
        public Livro livro;
        public Livro LivroSelecionado { get; set; }

        public FrmDetalhes(Livro livro)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.LivroSelecionado = livro;

            lblNome.Text = livro.nome;
            lblAutor.Text = livro.autor;
            lblGenero.Text = livro.genero;
            lblEditora.Text = livro.editora;
            lblAno.Text = livro.ano.ToString();
            lblPagina.Text = livro.pagina.ToString();
            lblSinopse.Text = livro.sinopse;

            picLivroSelecionado.Image = livro.foto;
            picLivroSelecionado.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
