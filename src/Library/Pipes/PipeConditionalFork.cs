using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;


namespace CompAndDel.Pipes
{
    public class PipeConditionalFork : IPipe
    {
        IPipe FalsePipe;
        IPipe TruePipe;
        IFilterBool Filter;
        
        /// <summary>
        /// La cañería recibe una imagen, aplica el filtro booleano y en base a eso decide por que pipe continuar.
        /// </summary>
        /// <param name="tipoFiltro">Tipo de filtro que se debe aplicar sobre la imagen. Se crea un nuevo filtro con los parametros por defecto</param>
        /// <param name="TruePipe">Siguiente cañeria con filtro</param>
        /// <param name="FalsePipe">Siguiente cañeria sin filtro</param>
        public PipeConditionalFork(IPipe truePipe, IPipe falsePipe,IFilterBool filter) 
        {
            this.FalsePipe = falsePipe;
            this.TruePipe = truePipe;          
            this.Filter =filter;

        }
        
        /// <summary>
        /// La cañería recibe una imagen, construye un duplicado de la misma, 
        /// y envía la original por una cañería y el duplicado por otra.
        /// </summary>
        /// <param name="picture">imagen a filtrar y enviar a las siguientes cañerías</param>
        public IPicture Send(IPicture picture)
        {
            if (Filter.Condition(picture))
            {
                return this.TruePipe.Send(picture);
            }
            else
            {
                return this.FalsePipe.Send(picture);
            }
            
            
        }
    }
}
