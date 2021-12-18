using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeOOP
{
    class Decisao
    {
        public int valorDecisao;

        public override string ToString()
        {
            return " Deseja fazer uma alteração?\n\n" +
                " Digite 0 Para sair do programa:\n" +
                " Adicionar produto digite 1:\n" +
                " Remover produto Digite 2:\n" +
                " Alterar valor do produto digite 3:";
        }
    }
}
