using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterEdgeConvolution: FilterBlurConvolution
    {
        public FilterEdgeConvolution()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = 50;
            this.divisor = 1;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrizParametros[x, y] = -1;
                }
            }
            this.matrizParametros[1,1] = 8;
        }
    }
}