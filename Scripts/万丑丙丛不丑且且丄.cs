using UnityEngine;
public class 万丑丙丛不丑且且丄
{
    // Fields
    internal static readonly int 丑丒丆与丘下丛上业;
    private static System.Collections.Generic.Dictionary<string, 丕专丟上与丄丈三丏> 专丙丄丗丟丑一丅与;
    private static System.Collections.Generic.Dictionary<string, int> 丝业丑丈且东丐丐三;
    private static PGCompany.且丟一七万东丁三上<string> 丟丒丝丁丛丙一丆三;
    
    // Properties
    internal static System.Collections.Generic.Dictionary<string, 丕专丟上与丄丈三丏> 东一丁世丑丞业丄丐 { get; }
    internal static PGCompany.且丟一七万东丁三上<string> 丒丑丆一丞丗丅七丆 { get; }
    
    // Methods
    internal static System.Collections.Generic.Dictionary<string, 丕专丟上与丄丈三丏> 一三专丞丒丅上业上()
    {
        null = null;
        return (System.Collections.Generic.Dictionary<System.String, 丕专丟上与丄丈三丏>)万丑丙丛不丑且且丄.专丙丄丗丟丑一丅与;
    }
    internal static PGCompany.且丟一七万东丁三上<string> 丗丑丁专丏丕上丞丕()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        if(万丑丙丛不丑且且丄.丟丒丝丁丛丙一丆三 != null)
        {
            goto label_18;
        }
        
        PGCompany.且丟一七万东丁三上<System.String> val_1 = new PGCompany.且丟一七万东丁三上<System.String>();
        val_7 = null;
        val_7 = null;
        万丑丙丛不丑且且丄.丟丒丝丁丛丙一丆三 = val_1;
        val_5 = 万丑丙丛不丑且且丄.丝业丑丈且东丐丐三;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_5.GetEnumerator();
        label_11:
        if(((-706217208) & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
        val_8 = null;
        val_8 = null;
        val_1.set_Item(下上丐丆丝丟丝丒不:  -706217224, 丙业与丙丗丝不丈东:  val_3._value._obj.丐丏七丌丕丗业且上());
        goto label_11;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_18:
        val_9 = null;
        val_9 = null;
        return (PGCompany.且丟一七万东丁三上<System.String>)万丑丙丛不丑且且丄.丟丒丝丁丛丙一丆三;
    }
    internal static int 丗丁七与万丘三与丅(string 丞丅上丏丂且下丅与)
    {
        var val_4;
        var val_5;
        var val_6;
        if((System.String.IsNullOrEmpty(value:  丞丅上丏丂且下丅与)) != true)
        {
                val_4 = null;
            val_4 = null;
            if((万丑丙丛不丑且且丄.丝业丑丈且东丐丐三.ContainsKey(key:  丞丅上丏丂且下丅与)) != false)
        {
                val_5 = null;
            val_5 = null;
            if(万丑丙丛不丑且且丄.丝业丑丈且东丐丐三 != null)
        {
                return 万丑丙丛不丑且且丄.丝业丑丈且东丐丐三.Item[丞丅上丏丂且下丅与];
        }
        
            return 万丑丙丛不丑且且丄.丝业丑丈且东丐丐三.Item[丞丅上丏丂且下丅与];
        }
        
        }
        
        object[] val_3 = new object[1];
        val_3[0] = 丞丅上丏丂且下丅与;
        UnityEngine.Debug.LogErrorFormat(format:  "ERROR!!!!!!! Нет серверной айдишки для lobby Item {0}", args:  val_3);
        val_6 = null;
        val_6 = null;
        return (int)万丑丙丛不丑且且丄.丑丒丆与丘下丛上业;
    }
    internal static string 专一上不三丒上七丏(int 上丛丛丞且东且丄丘)
    {
        int val_6;
        var val_7;
        val_6 = 上丛丛丞且东且丄丘;
        if((万丑丙丛不丑且且丄.丗丑丁专丏丕上丞丕().ContainsKey(下上丐丆丝丟丝丒不:  val_6)) != false)
        {
                string val_4 = 万丑丙丛不丑且且丄.丗丑丁专丏丕上丞丕().Item[val_6];
            return (string)val_7;
        }
        
        object[] val_5 = new object[1];
        val_6 = val_6;
        val_5[0] = val_6;
        UnityEngine.Debug.LogErrorFormat(format:  "ERROR!!!!!!! В конверторе нет такой серверной айдишки {0}", args:  val_5);
        val_7 = 0;
        return (string)val_7;
    }
    private static 万丑丙丛不丑且且丄()
    {
        万丑丙丛不丑且且丄.丑丒丆与丘下丛上业 = 9998;
        万丑丙丛不丑且且丄.专丙丄丗丟丑一丅与 = new System.Collections.Generic.Dictionary<System.String, 丕专丟上与丄丈三丏>();
        万丑丙丛不丑且且丄.丝业丑丈且东丐丐三 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        System.Collections.Generic.Dictionary<System.String, 丕专丟上与丄丈三丏> val_3 = new System.Collections.Generic.Dictionary<System.String, 丕专丟上与丄丈三丏>();
    }
    public 万丑丙丛不丑且且丄()
    {
    
    }

}
