using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSharpenConvolution: FilterConvolution
    {
        /// <summary>
        /// Al heredar de FilterConvolution, FilterSharpenConvolution tiene todos los métodos
        /// declarados en la superclase, cambiando los parámetros de la matriz, complemento y divisor.
        /// </summary>
        public FilterSharpenConvolution()
        {
            this.matrizParametros = new int[3, 3];
            this.complemento = 0;
            this.divisor = 1;
            matrizParametros[0,1] = -1;
            matrizParametros[1,0] = -1;
            matrizParametros[2,1] = -1;
            matrizParametros[1,2] = -1;
            matrizParametros[1,1] = 5;
        }
    }
}