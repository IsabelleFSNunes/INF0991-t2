using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Stock : Asset   // Classe filha que herda de Asset
    {
        public long SharesOwned;
    }
}