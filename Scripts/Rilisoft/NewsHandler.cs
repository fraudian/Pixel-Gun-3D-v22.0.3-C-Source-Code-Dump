using UnityEngine;

namespace Rilisoft
{
    public class NewsHandler : ScriptableObject
    {
        // Fields
        private static Rilisoft.NewsHandler _instance;
        public System.Collections.Generic.List<string> ExistsIds;
        
        // Properties
        internal static System.Collections.Generic.List<string> News { get; }
        
        // Methods
        internal static System.Collections.Generic.List<string> get_News()
        {
            Rilisoft.NewsHandler val_4;
            System.Collections.Generic.List<System.String> val_5;
            if(Rilisoft.NewsHandler._instance == 0)
            {
                    Rilisoft.NewsHandler._instance = UnityEngine.Resources.Load<Rilisoft.NewsHandler>(path:  "news_handler");
            }
            
            val_4 = Rilisoft.NewsHandler._instance;
            val_5 = 0;
            if(val_4 == 0)
            {
                    return val_5;
            }
            
            val_4 = Rilisoft.NewsHandler._instance;
            val_5 = mem[val_2 + 24];
            val_5 = val_2.ExistsIds;
            return val_5;
        }
        public NewsHandler()
        {
            this.ExistsIds = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
