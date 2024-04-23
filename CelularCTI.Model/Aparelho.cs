using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Aparelho
    {
        private Int64 id_aparelho;
        private string modelo;
        private Fabricante fabricante;
        private double espessura;
        private double largura;
        private double altura;
        private double peso;
        private double quantidade;
        private decimal preco;
        private decimal desconto;

        public Int64 Id_Aparelho { get; set; }
        public string Modelo { get; set; }
        public Fabricante Fabricante { get; set; }
        public double Espessura { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Quantidade
        {
            get
            { return quantidade; }
            set
            {
                if (value > 0)
                    quantidade = value;
                else
                    Console.WriteLine("O campo Quantidade deve ser maior que zero !!!");  //onde tá throw new exception vc muda pra Console.WriteLine("");
            }
        }
        public decimal Preco
        {   get 
                { return preco; }
            set 
                {
                if (value > 0)
                    preco = value;
                else
                    Console.WriteLine("O campo Preço do Produto deve ser maior que zero !!!");
            }  
        }
        public decimal Desconto { get; set;}

        // Sobrescrever o método ToString() para retornar uma 
        // string com os dados que eu desejo apresentar de aparelho
        public override String ToString()
        {
            // veremos o uso deste método em breve.
            return  Fabricante.Nome.PadRight(12) + " " + 
                    Modelo.PadRight(25) + "  " + 
                    Preco.ToString("#,##0.00").PadLeft(20) +
                    "      (" + Quantidade + " em estoque)";
        }

    }
}
