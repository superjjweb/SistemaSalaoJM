using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProfissional
    {
        public ModeloProfissional()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProCpf = "";
            this.ProLogin = "";
            this.ProSenha = "";
            this.ProPerfil = 0;
            this.ProSalario = 0;
            this.ProComiss = 0;
            this.ProNasc = "";
            this.ProSexo = "";
            this.ProEnd = "";
            this.ProCep = "";
            this.ProCidade = "";
            this.ProUF = "";
            this.ProTel = "";
            this.ProCel = "";
            this.ProEmail = "";
            this.ProFoto = "";
            this.ProObs = "";
            this.CatCod = 0;
        }

        public ModeloProfissional(int pro_cod, String pro_nome, String cpf_prof, String login_prof, String senha_prof, int cod_perfil, Double sal_prof, int comiss_prof,
			String nasc_prof, String sexo_prof, String end_prof, String cep_prof, String cidade_prof, String uf_prof, String tel_prof, String cel_prof, String email_prof,
			Byte[] foto_prof, String obs_prof, int cat_cod)
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProCpf = cpf_prof;
            this.ProLogin = login_prof;
            this.ProSenha = senha_prof;
            this.ProPerfil = cod_perfil;
            this.ProSalario = sal_prof;
            this.ProComiss = comiss_prof;
            this.ProNasc = nasc_prof;
            this.ProSexo = sexo_prof;
            this.ProEnd = end_prof;
            this.ProCep = cep_prof;
            this.ProCidade = cidade_prof;
            this.ProUF = uf_prof;
            this.ProTel = tel_prof;
            this.ProCel = cel_prof;
            this.ProEmail = email_prof;
            this.ProFoto = foto_prof;
            this.ProObs = obs_prof;
            this.CatCod = cat_cod;
        }

        private int pro_cod;
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }
        private String pro_nome;
        public String ProNome
        {
            get { return this.pro_nome; }
            set { this.pro_nome = value; }

        private String cpf_prof;
        public String ProCpf
        {
            get { return this.cpf_prof; }
            set { this.cpf_prof = value; }
        }
        private String login_prof;
        public String ProLogin
        {
            get { return this.login_prof; }
            set { this.login_prof = value; }

        private String senha_prof;
        public String ProSenha
        {
            get { return this.senha_prof; }
            set { this.senha_prof = value; }
        }
        private int cod_perfil;
        public int ProPerfil
        {
            get { return this.cod_perfil; }
            set { this.cod_perfil = value; }

        private Double sal_prof;
        public Double ProSalario
        {
            get { return this.sal_prof; }
            set { this.sal_prof = value; }
        }
        private int comiss_prof;
        public int ProComiss
        {
            get { return this.comiss_prof; }
            set { this.comiss_prof = value; }

        private String nasc_prof;
        public String ProNasc
        {
            get { return this.nasc_prof; }
            set { this.nasc_prof = value; }
        }
        private String sexo_prof;
        public String ProSexo
        {
            get { return this.sexo_prof; }
            set { this.sexo_prof = value; }

        private String end_prof;
        public String ProEnd
        {
            get { return this.end_prof; }
            set { this.end_prof = value; }
        }
        private String cep_prof;
        public String ProCep
        {
            get { return this.cep_prof; }
            set { this.cep_prof = value; }

        private String cidade_prof;
        public String ProCidade
        {
            get { return this.cidade_prof; }
            set { this.cidade_prof = value; }
        }
        private String uf_prof;
        public String ProUF
        {
            get { return this.uf_prof; }
            set { this.uf_prof = value; }

        private String tel_prof;
        public String ProTel
        {
            get { return this.tel_prof; }
            set { this.tel_prof = value; }
        }
        private String cel_prof;
        public String ProCel
        {
            get { return this.cel_prof; }
            set { this.cel_prof = value; }

        private String email_prof;
        public String ProEmail
        {
            get { return this.email_prof; }
            set { this.email_prof = value; }
        }

        private byte[] foto_prof;
        public byte[] ProFoto
        {
            get { return this.foto_prof; }
            set { this.foto_prof = value; }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        private String obs_prof;
        public String ProObs
        {
            get { return this.obs_prof; }
            set { this.obs_prof = value; }
        }

        private int cat_cod;
        public object ProSexo;

        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        public string ProCpf { get; private set; }
        public string ProLogin { get; private set; }
        public string ProSenha { get; private set; }
        public object ProSalario { get; set; }
        public object ProNasc { get; set; }
        public object ProEnd { get; set; }
        public object ProCep { get; set; }
        public object ProCidade { get; set; }
        public object ProUF { get; set; }
        public object ProTel { get; set; }
        public object ProCel { get; set; }
        public object ProEmail { get; set; }
    }
    }
}

