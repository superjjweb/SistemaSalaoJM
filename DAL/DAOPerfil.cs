using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAOPerfil
    {
        private DAOConexao conexao;
        public DAOPerfil(DAOConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloPerfil modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into perfil(nome_perfil) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.PerfNome);
            conexao.Conectar();
            modelo.PerfCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloPerfil modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update perfil set nome_perfil = @nome where cod_perfil = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.PerfNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.PerfCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from perfil where cod_perfil = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from perfil where nome_perfil like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPerfil CarregaModeloPerfil(int codigo)
        {
            ModeloPerfil modelo = new ModeloPerfil();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from perfil where cod_perfil = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PerfCod = Convert.ToInt32(registro["cod_perfil"]);
                modelo.PerfNome = Convert.ToString(registro["nome_perfil"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
