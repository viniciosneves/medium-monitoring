using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace guerreirosapi.Modelos
{

    public class Guerreiro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Guerreiro()
        {

        }

        public Guerreiro(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
