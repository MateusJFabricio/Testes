using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IPessoa
    {
        bool Falar(string mensagem);

        bool Andar(int x, int y);
    }


}
