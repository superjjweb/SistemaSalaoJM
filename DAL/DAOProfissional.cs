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
    public class DAOProfissional
    {
        private DAOConexao conexao;
        public DAOProfissional(DAOConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProfissional modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into profissional (nome_prof, cpf_prof, login_prof, senha_prof, cod_perfil, sal_prof, comiss_prof, nasc_prof, sexo_prof, end_prof, cep_prof, cidade_prof, uf_prof, tel_prof, cel_prof, email_prof, foto_prof, obs_prof, cat_cod) " +
            "values (@nome,@cpf,@login,@senha,@codperf,@salario,@comiss,@nasc,@sexo,@end,@cep,@cidade,@uf,@tel,@cel,@email,@foto,@obs,@catcod); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@cpf", modelo.ProCpf);
            cmd.Parameters.AddWithValue("@login", modelo.ProLogin);
            cmd.Parameters.AddWithValue("@senha", modelo.ProSenha);
            cmd.Parameters.AddWithValue("@codperf", modelo.ProPerfil);
            cmd.Parameters.AddWithValue("@salario", modelo.ProSalario);
            cmd.Parameters.AddWithValue("@comiss", modelo.ProComiss);
            cmd.Parameters.AddWithValue("@nasc", modelo.ProNasc);
            cmd.Parameters.AddWithValue("@sexo", modelo.ProSexo);
            cmd.Parameters.AddWithValue("@end", modelo.ProEnd);
            cmd.Parameters.AddWithValue("@cep", modelo.ProCep);
            cmd.Parameters.AddWithValue("@cidade", modelo.ProCidade);
            cmd.Parameters.AddWithValue("@uf", modelo.ProUF);
            cmd.Parameters.AddWithValue("@tel", modelo.ProTel);
            cmd.Parameters.AddWithValue("@cel", modelo.ProCel);
            cmd.Parameters.AddWithValue("@email", modelo.ProEmail);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto_prof", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto_prof", modelo.foto_prof);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@obs", modelo.ProObs);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            conexao.Conectar();
            modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloProfissional modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE profissional SET nome_prof = (@nome), cpf_prof = (@cpf), " +
                "login_prof = (@login), senha_prof = (@senha), cod_perfil = (@codperf), " +
                "sal_prof = (@salario), comiss_prof = (@comiss), nasc_prof = (@nasc), " +
                "sexo_prof = (@sexo), end_prof = (@end), cep_prof = (@cep), " +
                "cidade_prof = (@cidade), uf_prof = (@uf), tel_prof = (@tel), " +
                "cel_prof = (@cel), email_prof = (@email), foto_prof = (@foto), " +
                "obs_prof = (@obs), " +
                "cat_cod = (@catcod) WHERE pro_cod = (@codigo) ";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@cpf", modelo.ProCpf);
            cmd.Parameters.AddWithValue("@login", modelo.ProLogin);
            cmd.Parameters.AddWithValue("@senha", modelo.ProSenha);
            cmd.Parameters.AddWithValue("@codperf", modelo.ProPerfil);
            cmd.Parameters.AddWithValue("@salario", modelo.ProSalario);
            cmd.Parameters.AddWithValue("@comiss", modelo.ProComiss);
            cmd.Parameters.AddWithValue("@nasc", modelo.ProNasc);
            cmd.Parameters.AddWithValue("@sexo", modelo.ProSexo);
            cmd.Parameters.AddWithValue("@end", modelo.ProEnd);
            cmd.Parameters.AddWithValue("@cep", modelo.ProCep);
            cmd.Parameters.AddWithValue("@cidade", modelo.ProCidade);
            cmd.Parameters.AddWithValue("@uf", modelo.ProUF);
            cmd.Parameters.AddWithValue("@tel", modelo.ProTel);
            cmd.Parameters.AddWithValue("@cel", modelo.ProCel);
            cmd.Parameters.AddWithValue("@email", modelo.ProEmail);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                //cmd.Parameters.AddWithValue("@foto_prof", DBNull.Value);
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@foto_prof", modelo.foto_prof);
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@obs", modelo.ProObs);
            cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ProCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from profissional where cod_prof = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from profissional where nome_prof like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProfissional CarregaModeloProfissional(int codigo)
        {
            ModeloProfissional modelo = new ModeloProfissional();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from profissional where cod_prof = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();

                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProCpf = Convert.ToString(registro["cpf_prof"]);
                modelo.ProLogin = Convert.ToString(registro["login_prof"]);
                modelo.ProSenha = Convert.ToString(registro["senha_prof"]);
                modelo.ProPerfil = Convert.ToInt32(registro["cod_perfil"]);
                modelo.ProSalario = Convert.ToDouble(registro["sal_prof"]);
                modelo.ProComiss = Convert.ToInt32(registro["comiss_prof"]);
                modelo.ProNasc = Convert.ToString(registro["nasc_prof"]);
                modelo.ProSexo = Convert.ToString(registro["sexo_prof"]);
                modelo.ProEnd = Convert.ToString(registro["end_prof"]);
                modelo.ProCep = Convert.ToString(registro["cep_prof"]);
                modelo.ProCidade = Convert.ToString(registro["cidade_prof"]);
                modelo.ProUF = Convert.ToString(registro["uf_prof"]);
                modelo.ProTel = Convert.ToString(registro["tel_prof"]);
                modelo.ProCel = Convert.ToString(registro["cel_prof"]);
                modelo.ProEmail = Convert.ToString(registro["email_prof"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["foto_prof"];

                }
                catch { }
                modelo.ProObs = Convert.ToString(registro["obs_prof"]);
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                conexao.Desconectar();
                return modelo;
            }
        }
    }
