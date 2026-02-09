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
    public partial class FrmPrincipal : Form
    {
        private Livro livro;
        public FrmPrincipal(Livro livro)
        {
            InitializeComponent();
            this.livro = livro;
        }

        private void pict1_Click(object sender, EventArgs e)
        {
            Livro agatha = new Livro();
            
            agatha.nome = "E Não Sobrou Nenhum";
            agatha.autor = "Agatha Christie";
            agatha.genero = "Suspense / Policial";
            agatha.editora = "Globo Livros";
            agatha.ano = 1939;
            agatha.pagina = 400;
            agatha.sinopse = "Dez desconhecidos são isolados em uma ilha particular. Uma gravação os acusa de crimes impunes e, um a um, eles começam a morrer conforme os versos de uma cantiga infantil. Não tem como fugir, não tem sinal de celular e o pânico cresce: o assassino só pode ser um deles.";
            agatha.foto = Properties.Resources.livro_agatha;

            FrmDetalhes frmPrinciapal= new FrmDetalhes(agatha);
            frmPrinciapal.ShowDialog();
        }

        private void pict2_Click(object sender, EventArgs e)
        {
            Livro algernon = new Livro();

            algernon.nome = "Flores para Algernon";
            algernon.autor = "Daniel Keyes";
            algernon.genero = "Ficção Científica";
            algernon.editora = "Aleph";
            algernon.ano = 2018;
            algernon.pagina = 288;
            algernon.sinopse = "Charlie, um homem com deficiência intelectual, passa por uma cirurgia experimental para triplicar seu QI. Ele se torna um gênio absoluto, superando até os cientistas que o criaram, mas ao ver o rato Algernon regredir ao mesmo teste, Charlie percebe que a mudança é temporária.";
            algernon.foto = Properties.Resources.livro_algernon;

            FrmDetalhes frmPrinciapal = new FrmDetalhes(algernon);
            frmPrinciapal.ShowDialog();
        }

        private void pict3_Click(object sender, EventArgs e)
        {
            Livro cincopassos = new Livro();

            cincopassos.nome = "A cinco passos de você";
            cincopassos.autor = "Rachael Lippincott, Mikki Daughtry, Tobias Iaconis";
            cincopassos.genero = "Romance, Ficção";
            cincopassos.editora = "Globo Alt";
            cincopassos.ano = 2019;
            cincopassos.pagina = 288;
            cincopassos.sinopse = "Stella e Will são dois adolescentes com fibrose cística que se apaixonam, mas enfrentam uma regra cruel: para não transmitirem bactérias fatais um ao outro, eles precisam manter uma distância minima de 2 metros. OBSERVAÇÃO: A obra possui uma adaptação cinematográfica!";
            cincopassos.foto = Properties.Resources.livro_cincopassos;

            FrmDetalhes frmPrinciapal = new FrmDetalhes(cincopassos);
            frmPrinciapal.ShowDialog();
        }

        private void pict4_Click(object sender, EventArgs e)
        {
            Livro tododia = new Livro();

            tododia.nome = "Todo dia";
            tododia.autor = "David Levithan";
            tododia.genero = "Romance, Ficção";
            tododia.editora = "Galera Record";
            tododia.ano = 2013;
            tododia.pagina = 280;
            tododia.sinopse = "Toda manhã, A acorda em um corpo diferente, em uma vida diferente. Não há qualquer aviso sobre quem será ou onde estará em seguida. Já se acostumou com isso e até criou algumas regras para si. Tudo muda quando se apaixona por Rhiannon, passando a lutar para manter uma conexão real com ela.";
            tododia.foto = Properties.Resources.livro_tododia;

            FrmDetalhes frmPrinciapal = new FrmDetalhes(tododia);
            frmPrinciapal.ShowDialog();
        }
    }
}
