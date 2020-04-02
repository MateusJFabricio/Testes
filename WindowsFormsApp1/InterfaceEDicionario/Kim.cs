using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Kim : IPessoa
    {
        public bool Andar(int x, int y)
        {
            MessageBox.Show("Andei");
            return true;
        }

        public bool Falar(string mensagem)
        {
            MessageBox.Show(mensagem);
            return true;
        }
    }

    class Mateus : IPessoa
    {
        public bool Andar(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool Falar(string mensagem)
        {
            throw new NotImplementedException();
        }
    }

}
