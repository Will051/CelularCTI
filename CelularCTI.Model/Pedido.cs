using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;
        private string observacao;

        public long Id_pedido { get => id_pedido; set => id_pedido = value; }
        public Aparelho Aparelho { get => aparelho; set => aparelho = value; }
        public DateTime Datahorapedido { get => datahorapedido; set => datahorapedido = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
