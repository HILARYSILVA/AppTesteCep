using System;
using System.Collections.Generic;
using System.Text;

namespace AppTesteCep.Model
{
    public class Cep
    {
        public int cep { get; set; }
        public int Id_Logradouro { get; set; }
        public string tipo { get; set; }

        public string descricao { get; set; }


        public string descricao_Cidade { get; set; }

        public string uf { get; set; }

        public string descricao_Bairro { get; set; }

        public int codigo_Cidade_ibge { get; set; }

        public int descricao_sem_numero { get; set; }

        public string complemento { get; set; }

        public int id_Cidade { get; set; }
    }
}
