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
    public partial class frmPrincipal : Form
    {
        private List<Aparelho> aparelhos = new List<Aparelho>();
        private List<Fabricante> fabricantes = new List<Fabricante>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fabricantes = Servico.BuscarFabricante();
            cmbFabricante.DataSource = fabricantes;
            cmbFabricante.DisplayMember = "Nome";
            cmbFabricante.ValueMember = "id_fabricante";
            cmbFabricante.SelectedIndex = -1;

            aparelhos = Servico.BuscarAparelho();
            lstCelulares.DataSource = aparelhos;
        }

        private void btnPesquisarModelo_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(txtModelo.Text);
            lstCelulares.DataSource= aparelhos;
        }

        private void btnPesquisarPreco_Click(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho(
                                numPrecoInicial.Value,
                                numPrecoFinal.Value);
            lstCelulares.DataSource = aparelhos;
        }

        private void btnPesquisarFabricante_Click(object sender, EventArgs e)
        {
            Fabricante fabricante = new Fabricante();
            fabricante = fabricantes[cmbFabricante.SelectedIndex];
            lstCelulares.DataSource = Servico.BuscarAparelho(fabricante); 
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            lstCelulares.DataSource = Servico.BuscarAparelho();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo cad = new frmNovo();
            cad.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente encerrar a aplicacao?",
                                        this.Text,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
                this.Close();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            aparelhos = Servico.BuscarAparelho();
            cmbFabricante.SelectedIndex = -1;
            lstCelulares.DataSource = aparelhos;
        }
    }
}
