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
    public class CRTLProfissional
    {
        private DAOConexao conexao;
        public CRTLProfissional(DAOConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProfissional modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Profissional é obrigatório");
            }

            DAOProfissional DALobj = new DAOProfissional(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloProfissional modelo)
        {
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do Profissional é obrigatório");
            }
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Profissional é obrigatório");
            }

            DAOProfissional DALobj = new DAOProfissional(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DAOProfissional DALobj = new DAOProfissional(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DAOProfissional DALobj = new DAOProfissional(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloProfissional CarregaModeloProfissional(int codigo)
        {
            DAOProfissional DALobj = new DAOProfissional(conexao);
            return DALobj.CarregaModeloProfissional(codigo);
        }
    }
}
