using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPP.Models
{
    public class ShopCart
    {
        public int carrinho_ID { get; set; }
        public int cod_Produto { get; set; }
        public int numCli { get; set; }
        public string quantidade { get; set; }
    }
}
