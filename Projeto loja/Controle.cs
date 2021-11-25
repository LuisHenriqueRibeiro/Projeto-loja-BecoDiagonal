using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_loja
{
    internal class Controle
    {
        private static bool seELeSaiuNoLogin = true;
        private static int idDele = 0;
        public void setSeEleSaiuNoLogin(bool valor)
        {
           seELeSaiuNoLogin = valor;
        }
        public bool getSeEleSaiuNoLogin()
        {
            return seELeSaiuNoLogin;
        }
        public void setIdDele(int novoId)
        {
            idDele = novoId;
        }
        public int getIdDele()
        {
            return idDele;
        }

    }
}
