using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.model
{
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }
        //[ForeignKey("produto")]
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        //[ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Observacao { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
