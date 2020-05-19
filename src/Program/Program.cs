using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Ejercicio 4

            
            IFilter Greyscale = new FilterGreyscale();
            IFilter Negative = new FilterNegative();
            IFilter Twitter = new FilterTwitter();
            IFilterBool HasFace = new FilterFace();


            IPipe Pipe5 = new PipeNull();
            IPipe Pipe4 = new PipeSerial(Negative,Pipe5);
            IPipe Pipe3 = new PipeSerial(Twitter, Pipe5);
            
            IPipe Pipe2 = new PipeConditionalFork(Pipe3,Pipe4,HasFace );   
                      
            IPipe Pipe1 = new PipeSerial (Greyscale, Pipe2);
            
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\Images\\image.jpg");

            Pipe1.Send(pic);
            */

            IFilter Sharpen = new FilterSharpenConvolution();
            IFilter Save = new FilterSave();

            IPipe Pipe3 = new PipeNull();
            IPipe Pipe2 = new PipeSerial (Save, Pipe3);
            IPipe Pipe1 = new PipeSerial (Sharpen, Pipe2);

            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\Images\\image.jpg");

            Pipe1.Send(pic);

        }
    }
}
