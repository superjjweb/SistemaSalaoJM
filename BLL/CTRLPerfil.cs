using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTRLPerfil
    {
        private DAOConexao conexao;
        public CTRLPerfil(DAOConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPerfil modelo)
        {
            if (modelo.PerfNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Perfil é obrigatório");
            }

            DAOPerfil DALobj = new DAOPerfil(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloPerfil modelo)
        {
            if (modelo.PerfCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório");
            }
            if (modelo.PerfNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Perfil é obrigatório");
            }
            //modelo.CatNome = modelo.CatNome.ToUpper();

            DAOPerfil DALobj = new DAOPerfil(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DAOPerfil DALobj = new DAOPerfil(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DAOPerfil DALobj = new DAOPerfil(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloPerfil CarregaModeloPerfil(int codigo)
        {
            DAOPerfil DALobj = new DAOPerfil(conexao);
            return DALobj.CarregaModeloPerfil(codigo);
        }
    }
}
