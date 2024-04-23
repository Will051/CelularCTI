using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Cliente
    {
        private Int64 id_Cliente;
        private string nome;
        private string email;

        public Int64 Id_Cliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
