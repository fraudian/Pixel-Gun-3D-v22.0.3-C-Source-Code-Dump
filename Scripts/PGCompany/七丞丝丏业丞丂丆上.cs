using UnityEngine;

namespace PGCompany
{
    internal static class 七丞丝丏业丞丂丆上
    {
        // Methods
        internal static void 一丐丛专下丞七丌万()
        {
            Firebase.FirebaseApp val_1 = Firebase.FirebaseApp.DefaultInstance;
            if(val_1 != null)
            {
                    val_1.Dispose();
            }
            
            UnityEngine.Application.Quit();
        }
    
    }

}
