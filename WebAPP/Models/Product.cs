using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAPP.Models
{
    
    public class Product
    {
        [Key]
        public int Cod_Produto  { get; set; }
        public string NomeProduto { get; set; }
        public int Preco { get; set; }
        public int TaxaIVA { get; set; }
        public int Quantidade { get; set; }
        public string Sexo { get; set; }
        public string Tamanho { get; set; }
        public string Tipo { get; set; }
    }
}
