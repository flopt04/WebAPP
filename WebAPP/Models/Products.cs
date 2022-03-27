using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace WebAPP.Models
{
    public class Products
    {
        public int cod_Produto { get; set; }  //Primary key
        public string nomeProduto { get; set; }
        public int preco { get; set; }
        public int taxaIVA { get; set; }
        public int quantidade { get; set; }
        public string sexo { get; set; }
        public string tamanho { get; set; }
        public string tipo { get; set; }
    }
}
