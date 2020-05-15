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
            IPipe Pipe3 = new PipeNull();
            IPipe Pipe2 = new PipeSerial(Negative, Pipe3);
            IPipe Pipe1 = new PipeSerial (Greyscale, Pipe2);
            
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\picture.jpg");

            Pipe1.Send(pic);
        }
    }
}
