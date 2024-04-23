using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CelularCTI.Model.Entidades;
using CelularCTI.Model;

namespace CelularCTI.Desktop
{
    public partial class frmNovo : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public frmNovo()
        {
            InitializeComponent();
        }

        private void frmNovo_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.BuscarFabricante();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.DisplayMember = "Nome";
            cmbFabricante.ValueMember = "id_fabricante";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Testes de consistencia de dados - Validacoes/Regras de Negocios
                if(cmbFabricante.SelectedIndex == -1)
                {
                    MessageBox.Show("Você deve selecionar um fabricante da lista!!!",
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }
                Aparelho ap = new Aparelho();
                ap.Modelo = txtModelo.Text;
                ap.Fabricante = fabricantes[cmbFabricante.SelectedIndex];
                ap.Largura = Convert.ToDouble(numLargura.Value);
                ap.Altura = Convert.ToDouble(numAltura.Value);
                ap.Espessura = Convert.ToDouble(numEspessura.Value);
                ap.Peso = Convert.ToDouble(numPeso.Value);
                ap.Quantidade = Convert.ToDouble(numQuantidade.Value);
                ap.Preco = numPreco.Value;
                ap.Desconto = numDesconto.Value;

                Servico.Salvar(ap);

                MessageBox.Show("O aparelho " + txtModelo.Text +
                                " foi cadastrado com sucesso!!!",
                                this.Text, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o aparelho." +
                                "\n\nMais detalhes: " + ex.Message,
                                this.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente cancelar o cadastro?",
                                        this.Text,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }
    }
}
