using UnityEngine;
public class 一一丘丆丗下丗下七
{
    // Fields
    public bool 丕丒丏丅丐丙丏业世;
    public static int 三丂丏一丙丑一丅丁;
    public static bool 专丝东丄丒丂上丝丈;
    public static int 丟丘一东丑丈七丅业;
    private const string 且丁丐不三下丘丅丅 = "wss://";
    private int 丒上与丟万与丏丈业;
    
    // Properties
    public 丟丟且且丙丌下丅丗 丝专丈丞丘丙丄丗丘 { get; }
    public bool 万丛与丄东丈万专丌 { get; }
    
    // Methods
    public 丟丟且且丙丌下丅丗 丘业丈丕万丆丗丒丁()
    {
        var val_5;
        var val_6;
        val_5 = static_value_081D9CF0;
        val_5 = static_value_081D9CF0;
        List.Enumerator<T> val_2 = static_value_081D9CF0 + 184 + 16.丁七且万业下丗丐丕().GetEnumerator();
        val_6 = 0;
        goto label_10;
        label_11:
        string val_3 = 0.丐丏七丌丕丗业且上();
        UnityEngine.Debug.Log(message:  "BestRegion checks region: "("BestRegion checks region: ") + val_3);
        val_6 = val_3;
        label_10:
        if((910296216 & 1) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丟丟且且丙丌下丅丗)val_6;
    }
    public bool 丏且丂丒丗丂且与丐()
    {
        return (bool)(this.丒上与丟万与丏丈业 == 0) ? 1 : 0;
    }
    public System.Collections.IEnumerator 东且丙丘不世丟丛业(丟丟且且丙丌下丅丗 万丅丝丈上丅丘丈丘)
    {
        一一丘丆丗下丗下七.上丆丐丂丑世东丘丒 val_1 = new 一一丘丆丗下丗下七.上丆丐丂丑世东丘丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .万丅丝丈上丅丘丈丘 = 万丅丝丈上丅丘丈丘;
        return (System.Collections.IEnumerator)val_1;
    }
    public static string 不丐世丛万丒丐丕东(string 且万丙世东丆下丅丘)
    {
        int val_5;
        var val_6;
        string val_7;
        val_5 = System.String.alignConst;
        val_6 = 0;
        System.Net.IPAddress[] val_1 = System.Net.Dns.GetHostAddresses(hostNameOrAddress:  且万丙世东丆下丅丘);
        if(val_1.Length == 1)
        {
                label_15:
            val_5 = val_1[0];
            return (string)val_5;
        }
        
        if(val_1.Length < 1)
        {
                return (string)val_5;
        }
        
        label_13:
        if(0 >= val_1.Length)
        {
                val_6 = 0;
        }
        
        System.Net.IPAddress val_6 = val_1[0];
        if(val_6 == null)
        {
            goto label_12;
        }
        
        if((val_6.Contains(value:  ":")) == true)
        {
            goto label_15;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_5)) != false)
        {
                val_5 = val_1;
        }
        
        label_12:
        val_7 = 0 + 1;
        if(val_7 < val_1.Length)
        {
            goto label_13;
        }
        
        return (string)val_5;
    }
    public 一一丘丆丗下丗下七()
    {
    
    }
    private static 一一丘丆丗下丗下七()
    {
        一一丘丆丗下丗下七.且丁丐不三下丘丅丅 = null;
        一一丘丆丗下丗下七.专丝东丄丒丂上丝丈 = true;
        一一丘丆丗下丗下七.丟丘一东丑丈七丅业 = 800;
    }

}
