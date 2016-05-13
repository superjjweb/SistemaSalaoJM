using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPerfil
    {
        public ModeloPerfil()
        {
            this.PerfCod = 0;
            this.PerfNome = "";
        }

        public ModeloPerfil(int perfcod, String nome)
        {
            this.PerfCod = perfcod;
            this.PerfNome = nome;
        }

        private int cod_perfil;
        public int PerfCod
        {
            get { return this.cod_perfil; }
            set { this.cod_perfil = value; }
        }
        private String nome_perfil;
        public String PerfNome
        {
            get { return this.nome_perfil; }
            set { this.nome_perfil = value; }
        }
    }
}

