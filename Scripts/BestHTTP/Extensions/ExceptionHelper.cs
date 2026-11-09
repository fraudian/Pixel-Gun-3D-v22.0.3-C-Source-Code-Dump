using UnityEngine;

namespace BestHTTP.Extensions
{
    public static class ExceptionHelper
    {
        // Methods
        public static System.Exception ServerClosedTCPStream()
        {
            return (System.Exception)new System.Exception(message:  "TCP Stream closed unexpectedly by the remote server");
        }
    
    }

}
