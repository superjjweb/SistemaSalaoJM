using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmCadastroPerfil : Form
    {
        public String operacao;
    
        public frmCadastroPerfil()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            
        }

        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            pnlCadastro.Enabled = false;
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnInserir.Enabled = true;
                btnLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnlCadastro.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void frmModeloParaCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloPerfil modelo = new ModeloPerfil();
                modelo.PerfNome = txtNomePerfil.Text;
                //obj para gravar os dados no banco
                DAOConexao cx = new DAOConexao(DadosDaConexao.StringDeConexao);
                CTRLPerfil bll = new CTRLPerfil(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar um peril
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.PerfCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.PerfCod = Convert.ToInt32(txtCodPerfil.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmCadastroPerfil_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }
}
