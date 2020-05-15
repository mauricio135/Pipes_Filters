using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSave : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la guarda
        /// </summary>
        /// <param name="image">Imagen a la cual se le va aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        private static int contador = 0;
        public IPicture Filter (IPicture image)
        {
           
            PictureProvider p = new PictureProvider ();
            p.SavePicture (image,$"..\\Images\\PictureFiltrada{contador}.jpg");
            contador += 1;
            return image;
            

        }
    }
}