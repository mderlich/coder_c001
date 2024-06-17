using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006
{
    public interface IJugador
    {
        void correr();
        void regatear();
        void defender();
        void rematar();
        void colocarPase();
        void soportarEmbate();
    }
}
