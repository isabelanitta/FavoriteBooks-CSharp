using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace meus_livros
{
    public class Livro
    {
        public string nome { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string editora { get; set; }
        public int ano { get; set; }
        public int pagina { get; set; }
        public string sinopse { get; set; }
        public System.Drawing.Image foto { get; set; }

        public Livro()
        {
            this.nome = "";
            this.autor = "";
            this.genero = "";
            this.editora = "";
            this.ano = 0;
            this.pagina = 0;
            this.sinopse = "";
        }
    }
    
}
