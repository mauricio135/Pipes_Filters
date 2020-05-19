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
            IFilter Edge = new FilterEdgeConvolution();
            IFilter Save = new FilterSave();

            IPipe Pipe4 = new PipeNull();
            IPipe PipeSave3 = new PipeSerial(Save, Pipe4);
            IPipe Pipe3 = new PipeSerial(Negative, PipeSave3);
            IPipe PipeSave2 = new PipeSerial(Save,Pipe3);
            IPipe Pipe2 = new PipeSerial(Greyscale, PipeSave2);            
            IPipe PipeSave1 = new PipeSerial(Save,Pipe2);
            IPipe Pipe1 = new PipeSerial (Edge, PipeSave1);
            
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\Images\\dog.jpg");

            Pipe1.Send(pic);
        }
    }
}
