using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterBlurConvolution: FilterConvolution
    {
        /// <summary>
        /// Al heredar de FilterConvolution, FilterBlurConvolution tiene todos los métodos
        /// declarados en la superclase, cambiando los parámetros de la matriz, complemento y divisor.
        /// </summary>
        public FilterBlurConvolution()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = 0;
            this.divisor = 9;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrizParametros[x, y] = 1;
                }
            }
        }
    }
}