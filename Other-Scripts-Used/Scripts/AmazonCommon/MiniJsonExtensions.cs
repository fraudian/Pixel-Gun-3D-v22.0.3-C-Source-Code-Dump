using UnityEngine;

namespace AmazonCommon
{
    public static class MiniJsonExtensions
    {
        // Methods
        public static string toJson(System.Collections.Hashtable obj)
        {
            return AmazonCommon.MiniJSON.jsonEncode(json:  obj);
        }
        public static string toJson(System.Collections.Generic.Dictionary<string, string> obj)
        {
            return AmazonCommon.MiniJSON.jsonEncode(json:  obj);
        }
        public static string toJson(System.Collections.Generic.Dictionary<string, double> obj)
        {
            return AmazonCommon.MiniJSON.jsonEncode(json:  obj);
        }
        public static System.Collections.ArrayList arrayListFromJson(string json)
        {
            var val_3;
            if((AmazonCommon.MiniJSON.jsonDecode(json:  json)) == null)
            {
                    return (System.Collections.ArrayList);
            }
            
            val_3 = 0;
            return (System.Collections.ArrayList);
        }
        public static System.Collections.Hashtable hashtableFromJson(string json)
        {
            var val_3;
            if((AmazonCommon.MiniJSON.jsonDecode(json:  json)) == null)
            {
                    return (System.Collections.Hashtable);
            }
            
            val_3 = 0;
            return (System.Collections.Hashtable);
        }
    
    }

}
