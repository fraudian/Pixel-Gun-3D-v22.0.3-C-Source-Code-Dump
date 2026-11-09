using UnityEngine;
internal static class MiniJsonExtensions
{
    // Methods
    internal static string toJson(System.Collections.Hashtable obj)
    {
        return MiniJSON.jsonEncode(json:  obj);
    }
    internal static string toJson(System.Collections.Generic.Dictionary<string, string> obj)
    {
        return MiniJSON.jsonEncode(json:  obj);
    }
    internal static System.Collections.ArrayList arrayListFromJson(string json)
    {
        var val_3;
        if((MiniJSON.jsonDecode(json:  json)) == null)
        {
                return (System.Collections.ArrayList);
        }
        
        val_3 = 0;
        return (System.Collections.ArrayList);
    }
    internal static System.Collections.Hashtable hashtableFromJson(string json)
    {
        var val_3;
        if((MiniJSON.jsonDecode(json:  json)) == null)
        {
                return (System.Collections.Hashtable);
        }
        
        val_3 = 0;
        return (System.Collections.Hashtable);
    }

}
