using System;
using CognitiveCoreUCU;
using System.Drawing;

namespace CompAndDel.Filters
{
    public class FilterFace:IFilterBool
    {
        /// <summary>
        /// Procesa la imagen pasada por parametro y se valida si cumple con determinada condicion, en este caso si la imagen tieen un Rostro.
        /// </summary>
        /// <param name="image">La imagen a procesar</param>
        /// <returns>La misma imagen o una nueva imagen creada por el filtro</returns>
      
       static string path = "..\\Images\\CognitivePictureTemp.jpg";
        static string cognitiveKey = "620e818a46524ceb92628cde08068242";
        CognitiveFace cog = new CognitiveFace (cognitiveKey, true, Color.GreenYellow);

        public IPicture FilterBool(IPicture image)
        {
            return image;
        }
        public IPicture Filter(IPicture image)
        {
            return image;
        }
        public bool Condition(IPicture image)
        {
            PictureProvider p = new PictureProvider ();

            p.SavePicture (image,path);
            cog.Recognize (path);
            return (cog.FaceFound);
            
            

        }

        
   
    }
}