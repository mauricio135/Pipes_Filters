using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main (string[] args)
        {
            IFilter Greyscale = new FilterGreyscale ();
            IFilter Negative = new FilterNegative ();
            IFilter Twitter = new FilterTwitter ();
            IFilter Save = new FilterSave ();
            IFilter Sharpen = new FilterSharpenConvolution ();
            IFilterBool HasFace = new FilterFace ();
            PictureProvider p = new PictureProvider ();
            IPicture pic = p.GetPicture ("..\\Images\\image.jpg");

            /// <summary>
            /// Las clases Pipe que aplican algún filtro a la imagen delegan la responsabilidad de modificar
            /// la imagen a la clase Filter que la compone.
            /// </summary>
            /// <returns></returns>

            #region Ejercicio 1

            IPipe Pipe1_3 = new PipeNull ();
            IPipe Pipe1_2 = new PipeSerial (Negative, Pipe1_3);
            IPipe Pipe1_1 = new PipeSerial (Greyscale, Pipe1_2);
            Pipe1_1.Send (pic);

            #endregion

            #region Ejercicio 2

            IPipe Pipe2_5 = new PipeNull ();
            IPipe Pipe2_4 = new PipeSerial (Save, Pipe2_5);
            IPipe Pipe2_3 = new PipeSerial (Negative, Pipe2_4);
            IPipe Pipe2_2 = new PipeSerial (Save, Pipe2_3);
            IPipe Pipe2_1 = new PipeSerial (Greyscale, Pipe2_2);
            Pipe2_1.Send (pic);

            #endregion

            #region Ejercicio 3

            IPipe Pipe3_5 = new PipeNull ();
            IPipe Pipe3_4 = new PipeSerial (Twitter, Pipe2_5);
            IPipe Pipe3_3 = new PipeSerial (Negative, Pipe2_4);
            IPipe Pipe3_2 = new PipeSerial (Twitter, Pipe2_3);
            IPipe Pipe3_1 = new PipeSerial (Greyscale, Pipe2_2);
            Pipe3_1.Send (pic);

            #endregion

            #region Ejercicio 4

            IPipe Pipe4_5 = new PipeNull ();
            IPipe Pipe4_4 = new PipeSerial (Negative, Pipe4_5);
            IPipe Pipe4_3 = new PipeSerial (Twitter, Pipe4_5);
            IPipe Pipe4_2 = new PipeConditionalFork (Pipe4_3, Pipe4_4, HasFace);
            IPipe Pipe4_1 = new PipeSerial (Greyscale, Pipe4_2);
            Pipe4_1.Send (pic);

            #endregion

            #region Ejercicio Bonus

            IPipe PipeBonus_3 = new PipeNull ();
            IPipe PipeBonus_2 = new PipeSerial (Save, PipeBonus_3);
            IPipe PipeBonus_1 = new PipeSerial (Sharpen, PipeBonus_2);
            PipeBonus_1.Send (pic);

            #endregion

        }
    }
}