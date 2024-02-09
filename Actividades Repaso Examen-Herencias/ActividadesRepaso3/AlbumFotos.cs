using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesRepaso3
{
    public class AlbumFotos
    {
        protected int numPaginas;
        public AlbumFotos()
        {
            numPaginas = 16;
        }
        public AlbumFotos(int numPaginas)

        {
            this.numPaginas = numPaginas;
        }
        public int GetNumberPages()
        {
            return numPaginas;
        }
    }
}