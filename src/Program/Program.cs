using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            IFilter Greyscale = new FilterGreyscale();
            IFilter Negative = new FilterNegative();
            IFilter Save = new FilterSave();

            IPipe Pipe3 = new PipeNull();
            IPipe PipeSave2 = new PipeSerial(Save,Pipe3);
            IPipe Pipe2 = new PipeSerial(Negative, PipeSave2);            
            IPipe PipeSave1 = new PipeSerial(Save,Pipe2);
            IPipe Pipe1 = new PipeSerial (Greyscale, PipeSave1);
            
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\Images\\picture.jpg");

            Pipe1.Send(pic);
        }
    }
}
