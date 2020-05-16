using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using CompAndDel;                                                         
namespace CompAndDel.Filters
{
    public class FilterTwitter : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la guarda
        /// </summary>
        /// <param name="image">Imagen a la cual se le va aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        
        #region Credenciales
        string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
        string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
        

        #endregion
        
        public IPicture Filter (IPicture image)
        {
            

             
                var twitter = new TwitterImage (consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
                Console.WriteLine (twitter.PublishToTwitter (pasajero.ImprimeDatos (), pasajero.Foto));
                return image;
                

            
            

        }
    }
}