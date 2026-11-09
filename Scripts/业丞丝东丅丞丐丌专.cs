using UnityEngine;
internal sealed class 业丞丝东丅丞丐丌专
{
    // Fields
    private const int 丞丅七丌业三丌且东 = 1419;
    private const int 一与丄与丐丟丑专丅 = 1402;
    private const int 丆上丙不丒上七丒丅 = 3000;
    private const int 上丐丏丁丟丘丄丟世 = 6000;
    private const int 与业专七丁丂丛上一 = 4000;
    private int 丘上东丝丕丈丆丐丕;
    private const int 丐丄丗丙丅东丗东丅 = 2;
    private const float 丂丞丛丅丅且上下三 = 20;
    private static float 丆丞丌丈丛三上丞与;
    private const float 丐丄丅丌丙丅丂丅与 = 1;
    private float 丐丅丛下世丂丛丐丙;
    private static 业丞丝东丅丞丐丌专 世丒丞七专三与万丕;
    private UnityEngine.Coroutine 丙丄丌丆丁丘丙丐丅;
    private BestHTTP.HTTPRequest 丒丘丗世三上丙丙丂;
    private 下丘且东丅万丗丞丞 业丈丙丕丙丐万丝丑;
    private string <万专丝丕丞丞丝丛丐>k__BackingField;
    private string 下丅不上丝丈不世专;
    private string 万三丅丈不丄丈且丏;
    private AuthorizationStates 世不丛丐东与丞万与;
    private string <丒下丏丑丞万丂三七>k__BackingField;
    private string <一丞专丐万专七丛丟>k__BackingField;
    private string <东丝万丗且丅专世丈>k__BackingField;
    private int <丗上一世万上丗丛七>k__BackingField;
    private float <与丒丐东丒万丌三三>k__BackingField;
    private bool <与不上丛丁丛丟一丟>k__BackingField;
    private Rilisoft.丝丑丂丛万丐丈丘且 <丙且丂丝丙丅丅丌丛>k__BackingField;
    private bool <丗丏丛丘丝下丂丕丛>k__BackingField;
    private static System.Action 丆三丁丂三丙七丐一;
    private static System.Action 丛丕丁下丒丞丗上丌;
    private static System.Action 丛万七专丁不丁丅丞;
    private static System.Action 丝丆一且不丟七丏丙;
    private static System.Action 下业不专下丛万丘七;
    private static System.Action<string> 丝丒上丒丅一一万不;
    private static System.Action 专一丕丌一丂丈丅与;
    private int 丂丝与一三丒丙丒上;
    
    // Properties
    private static string 一业丌丁上丌不一七 { get; }
    internal string 上丑丑下丛丟丅丆丁 { get; set; }
    internal static string 专上与丘丛丝丗丄世 { get; }
    internal static string 一丌与且不丟东丌丘 { get; }
    internal string 丁世丄东万丄东丆丘 { get; set; }
    internal string 丁丆且丄丁七丞万与 { get; set; }
    internal static 业丞丝东丅丞丐丌专 丆丕丝丒不丙且丐丗 { get; }
    internal bool 专专丘世丘上丑丘业 { get; }
    internal AuthorizationStates 丕万丏丈世丌丏世丐 { get; set; }
    internal string 丈一且丟东上不世东 { get; set; }
    internal string 下丑丘与丅丞丗专丞 { get; set; }
    internal string 丑丛丌丗且丒丟丌东 { get; set; }
    internal int 丙丌世丞丘丐丆丈专 { get; set; }
    internal float 上丈一丘丘一不且丄 { get; set; }
    internal bool 丅与七丙丂下丁丄业 { get; set; }
    internal Rilisoft.丝丑丂丛万丐丈丘且 丘丙丏丄东丌且丒下 { get; set; }
    internal bool 丞丅丅丂丞丝与下专 { get; set; }
    
    // Methods
    private static string 七世丐丅下东丆丟丐()
    {
        return "https://server-v2.pixelgunserver.com/auth_v2/";
    }
    internal string 丗丕丟丞专丄丂万东()
    {
        return (string)this.<万专丝丕丞丞丝丛丐>k__BackingField;
    }
    private void 丁丈万丒七丟丟一丁(string 丙业与丙丗丝不丈东)
    {
        this.<万专丝丕丞丞丝丛丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static string 丙业专丗丝专丑丗且()
    {
        return "terceShtuA";
    }
    internal static string 丒丛丗三丂丁丅七丘()
    {
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  PGCompany.丄丝东丌丛业丂业丛.丈丌与东丞丏丑丘丂())) == false)
        {
                return "https://server-v2.pixelgunserver.com/auth_v2/";
        }
        
        return PGCompany.丄丝东丌丛业丂业丛.丈丌与东丞丏丑丘丂();
    }
    internal string 丁世下丌丒且七不丈()
    {
        if(this.下丅不上丝丈不世专 != null)
        {
                return val_1;
        }
        
        string val_1 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        this.下丅不上丝丈不世专 = val_1;
        return val_1;
    }
    internal void 丏丗一丄丛丑丐丛丒(string 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_1;
        }
        
        label_5:
        this.下丅不上丝丈不世专 = 丙业与丙丗丝不丈东;
        return;
        label_1:
        if(this != null)
        {
            goto label_5;
        }
        
        goto label_5;
    }
    internal string 丌且上三丅万丗丐丄()
    {
        string val_3;
        int val_4;
        val_3 = this.万三丅丈不丄丈且丏;
        if(val_3 != null)
        {
                return (string)val_3;
        }
        
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "terceShtuA")) != false)
        {
                string val_2 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "terceShtuA");
        }
        else
        {
                val_4 = System.String.alignConst;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "terceShtuA", 下下丏一丙不丘丌丞:  val_4);
            val_3 = System.String.alignConst;
        }
        
        this.万三丅丈不丄丈且丏 = val_3;
        return (string)val_3;
    }
    internal void 丕丕丐丝丐下丞丅丕(string 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == null)
        {
            goto label_1;
        }
        
        label_10:
        this.万三丅丈不丄丈且丏 = 丙业与丙丗丝不丈东;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "terceShtuA", 下下丏一丙不丘丌丞:  this.万三丅丈不丄丈且丏);
        return;
        label_1:
        if(this != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    internal 业丞丝东丅丞丐丌专()
    {
        var val_4;
        this.丘上东丝丕丈丆丐丕 = 2;
        this.业丈丙丕丙丐万丝丑 = new 下丘且东丅万丗丞丞();
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  0);
        val_4 = null;
        val_4 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.一丈丒一不丗上东专, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 业丞丝东丅丞丐丌专::丛世丝丕丅丒丐下丈(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丒丈下下丈与丏丅丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 业丞丝东丅丞丐丌专::丙三丑一丄下上丝丐(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    internal static 业丞丝东丅丞丐丌专 丑七不且上丗丁一世()
    {
        业丞丝东丅丞丐丌专 val_2;
        var val_3 = null;
        if(业丞丝东丅丞丐丌专.世丒丞七专三与万丕 == null)
        {
                业丞丝东丅丞丐丌专 val_1 = null;
            val_2 = val_1;
            val_1 = new 业丞丝东丅丞丐丌专();
            val_3 = null;
            val_3 = null;
            业丞丝东丅丞丐丌专.世丒丞七专三与万丕 = val_2;
        }
        
        val_3 = null;
        return (业丞丝东丅丞丐丌专)业丞丝东丅丞丐丌专.世丒丞七专三与万丕;
    }
    internal bool 下不丙丌丙丞丞万上()
    {
        return (bool)(this.世不丛丐东与丞万与 == 1) ? 1 : 0;
    }
    internal AuthorizationStates 丌丞东丅上丁不丗丄()
    {
        return (AuthorizationStates)this.世不丛丐东与丞万与;
    }
    private void 丆丛与上七丏丝丅丘(AuthorizationStates 丙业与丙丗丝不丈东)
    {
        AuthorizationStates val_1;
        var val_2;
        System.Action val_3;
        val_1 = 丙业与丙丗丝不丈东;
        this.世不丛丐东与丞万与 = val_1;
        if(val_1 == 1)
        {
                return;
        }
        
        if(this.世不丛丐东与丞万与 != 1)
        {
                return;
        }
        
        val_1 = 1152921505130487808;
        val_2 = null;
        val_2 = null;
        val_3 = 业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌;
        if(val_3 == null)
        {
                return;
        }
        
        val_3 = 业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌;
        if(val_3 == null)
        {
                val_3 = 0;
        }
        
        val_3.Invoke();
    }
    internal string 万丕丌丞丏丞丑专一()
    {
        return (string)this.<丒下丏丑丞万丂三七>k__BackingField;
    }
    private void 丂与七上丕丝丑丐丄(string 丙业与丙丗丝不丈东)
    {
        this.<丒下丏丑丞万丂三七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丒丐世三三上七专丘()
    {
        return (string)this.<一丞专丐万专七丛丟>k__BackingField;
    }
    internal void 下丝丛丆丝且丁丞丁(string 丙业与丙丗丝不丈东)
    {
        this.<一丞专丐万专七丛丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 东与七丟丝万丗丈丝()
    {
        return (string)this.<东丝万丗且丅专世丈>k__BackingField;
    }
    private void 丛世丞丆丟丒丈丙一(string 丙业与丙丗丝不丈东)
    {
        this.<东丝万丗且丅专世丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 专丕丟业万丁万丆丕()
    {
        return (int)this.<丗上一世万上丗丛七>k__BackingField;
    }
    private void 上丒丙且丐丈一且丒(int 丙业与丙丗丝不丈东)
    {
        this.<丗上一世万上丗丛七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal float 东一丁丞丙丛业丈下()
    {
        return (float)this.<与丒丐东丒万丌三三>k__BackingField;
    }
    private void 丆丗专丄丘万丂丟且(float 丙业与丙丗丝不丈东)
    {
        this.<与丒丐东丒万丌三三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丂下丆丌丗丕万万丑()
    {
        return (bool)this.<与不上丛丁丛丟一丟>k__BackingField;
    }
    private void 世丅丘万丕下万丗三(bool 丙业与丙丗丝不丈东)
    {
        this.<与不上丛丁丛丟一丟>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal Rilisoft.丝丑丂丛万丐丈丘且 丘丛丈上丄一七一丄()
    {
        return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = this.<丙且丂丝丙丅丅丌丛>k__BackingField, 丑丒丄下丁丐专丄丞 = this.<丙且丂丝丙丅丅丌丛>k__BackingField};
    }
    private void 三丟专与丂丐专丐一(Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东)
    {
        this.<丙且丂丝丙丅丅丌丛>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921536219215840] = 丙业与丙丗丝不丈东.上万三丆专丏丒丗业;
    }
    internal bool 丟世丌业且一丁丑万()
    {
        return (bool)this.<丗丏丛丘丝下丂丕丛>k__BackingField;
    }
    private void 万丞一七丁丅世丘与(bool 丙业与丙丗丝不丈东)
    {
        this.<丗丏丛丘丝下丂丕丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static void 丘丒丟丙业丗上与专(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一 != 1152921505130491920);
    
    }
    internal static void 丛丂不丗丙丘丝丘丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一 != 1152921505130491920);
    
    }
    internal static void 上三专七丗丗世丟丏(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌 != 1152921505130491928);
    
    }
    internal static void 丌三三丑丗丟丒且丘(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丛丕丁下丒丞丗上丌 != 1152921505130491928);
    
    }
    internal static void 丛丁专专一一丒丑丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞 != 1152921505130491936);
    
    }
    internal static void 东且业丛丂业丅世业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞 != 1152921505130491936);
    
    }
    internal static void 专丗丕且丞上丁丐丞(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙 != 1152921505130491944);
    
    }
    internal static void 不业丏丘丏丐丙丙七(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙 != 1152921505130491944);
    
    }
    internal static void 专丁丂与丘丈丅不丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.下业不专下丛万丘七, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.下业不专下丛万丘七 != 1152921505130491952);
    
    }
    internal static void 七丙三业且与七专不(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.下业不专下丛万丘七, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.下业不专下丛万丘七 != 1152921505130491952);
    
    }
    internal static void 丞丅丄一丙丈万三七(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.丝丒上丒丅一一万不, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丝丒上丒丅一一万不 != 1152921505130491960);
    
    }
    internal static void 三丛东丌与且丈一丐(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.丝丒上丒丅一一万不, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.丝丒上丒丅一一万不 != 1152921505130491960);
    
    }
    internal static void 丈丕丐丄专丐丑东丕(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与 != 1152921505130491968);
    
    }
    internal static void 丙专下丞丈业且丈丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与 != 1152921505130491968);
    
    }
    internal void 专丂丙丘世万下三且()
    {
        if(this.世不丛丐东与丞万与 == 8)
        {
                this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  2);
        }
        
        if(this.丙丄丌丆丁丘丙丐丅 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丙丄丌丆丁丘丙丐丅);
        }
        
        this.<与丒丐东丒万丌三三>k__BackingField = -1f;
        this.丙丄丌丆丁丘丙丐丅 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丛与丙丁丑专万丛丌());
        丒下丄与丏三世丘丝 val_5 = new 丒下丄与丏三世丘丝();
    }
    internal void 丏丂丙一丛万与丅丞()
    {
        if(this.世不丛丐东与丞万与 != 8)
        {
                return;
        }
        
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  9);
        this.专丂丙丘世万下三且();
    }
    private System.Collections.IEnumerator 丛与丙丁丑专万丛丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new 业丞丝东丅丞丐丌专.丒七三丗一一业丑且();
    }
    private void 丛丏不且上丆丘丝丆(float 丆丐七丅丆丗丛上与)
    {
        if(this.世不丛丐东与丞万与 == 7)
        {
                Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
            return;
        }
        
        this.<与丒丐东丒万丌三三>k__BackingField = 丆丐七丅丆丗丛上与;
        if(this.世不丛丐东与丞万与 == 9)
        {
                return;
        }
        
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  2);
    }
    private void 一专上下丈丛上丑丘()
    {
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  System.String.alignConst);
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  System.String.alignConst);
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  5);
    }
    internal void 不一丁丙丘不与丟丛()
    {
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  System.String.alignConst);
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  System.String.alignConst);
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  8);
    }
    internal void 丄三丒丟丄丅丅东丈()
    {
        this.<丒下丏丑丞万丂三七>k__BackingField = System.String.alignConst;
    }
    private void 丅丌丆三丈丕丆丅丂()
    {
        var val_14;
        var val_15;
        System.Action val_16;
        val_14 = this;
        if(this.世不丛丐东与丞万与 != 9)
        {
            goto label_1;
        }
        
        if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.<丒下丏丑丞万丂三七>k__BackingField)) == false) || ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.<一丞专丐万专七丛丟>k__BackingField)) == false))
        {
            goto label_7;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.七丆丘丘下丝丞丒丁())) == false)
        {
            goto label_11;
        }
        
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  this.<一丞专丐万专七丛丟>k__BackingField);
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丌万丗与七丄丕不丁();
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  this.<东丝万丗且丅专世丈>k__BackingField);
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丌万丗与七丄丕不丁();
        return;
        label_1:
        if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.<丒下丏丑丞万丂三七>k__BackingField)) == false) || ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.<一丞专丐万专七丛丟>k__BackingField)) == false))
        {
            goto label_21;
        }
        
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  4);
        label_11:
        this.丕三丒上丕丏丅丁丟();
        return;
        label_7:
        this.不一丁丙丘不与丟丛();
        val_14 = 1152921505130487808;
        val_15 = null;
        val_15 = null;
        val_16 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
        if(val_16 == null)
        {
                return;
        }
        
        val_16 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
        if(val_16 == null)
        {
                val_16 = 0;
        }
        
        val_16.Invoke();
        return;
        label_21:
        if(this.丒丘丗世三上丙丙丂 != null)
        {
                if(this.丒丘丗世三上丙丙丂.State == 2)
        {
                return;
        }
        
            if(this.丒丘丗世三上丙丙丂.State == 1)
        {
                return;
        }
        
        }
        
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  3);
        this.与丛丛丗一七不与世();
    }
    private void 与丛丛丗一七不与世()
    {
        string val_66;
        System.String[] val_67;
        object val_68;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        string val_75;
        System.Collections.Generic.IEnumerable<T> val_78;
        System.String[] val_79;
        var val_80;
        val_66 = this.下丅不上丝丈不世专;
        if(val_66 == null)
        {
                val_66 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            this.下丅不上丝丈不世专 = val_66;
        }
        
        val_67 = this.丌且上三丅万丗丐丄();
        val_68 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) >= 2)
        {
                val_68 = System.String.Format(format:  "{0}{1}", arg0:  "RT4E-", arg1:  val_68);
        }
        
        BestHTTP.HTTPRequest val_10 = new BestHTTP.HTTPRequest(uri:  new System.Uri(uriString:  业丞丝东丅丞丐丌专.丒丛丗三丂丁丅七丘()), methodType:  2, callback:  new BestHTTP.OnRequestFinishedDelegate(object:  this, method:  System.Void 业丞丝东丅丞丐丌专::丅丆万丒丙一丒一丈(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟, BestHTTP.HTTPResponse 丑与丂丌世丕丆一丗)));
        this.丒丘丗世三上丙丙丂 = val_10;
        val_10.FormUsage = 3;
        System.TimeSpan val_11 = System.TimeSpan.FromSeconds(value:  40);
        this.丒丘丗世三上丙丙丂.ConnectTimeout = new System.TimeSpan() {_ticks = val_11._ticks};
        System.TimeSpan val_12 = System.TimeSpan.FromSeconds(value:  60);
        this.丒丘丗世三上丙丙丂.Timeout = new System.TimeSpan() {_ticks = val_12._ticks};
        .丕丟一三且丛专丂丙 = 丏下三丗一不专丞丝.丟万丕丗丐一东且丛();
        if(PGCompany.AuthorizationScene.AfterBanSceneController.丒一丅丄不丒专丅丅() != false)
        {
                .丕丟一三且丛专丂丙 = true;
            丏下三丗一不专丞丝.东专不丌丙三业世丌(丙业与丙丗丝不丈东:  丏下三丗一不专丞丝.丒丁丐上丂丛丝三三());
            丏下三丗一不专丞丝.世丅下且丗丕与丈与(丙业与丙丗丝不丈东:  丏下三丗一不专丞丝.丘专丙丑世下丌丕下());
        }
        
        if((业丞丝东丅丞丐丌专.丟丗东丛丘丂丌七丑)[1152921536222836960].丕丟一三且丛专丂丙 != false)
        {
                业丂丏与世一丏业不.丛丁丈上与业丒丗丗(丘丘丕丄丑丗丕一世:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
            if((业丞丝东丅丞丐丌专.丟丗东丛丘丂丌七丑)[1152921536222836960].丕丟一三且丛专丂丙 != false)
        {
                string val_21 = 丏下三丗一不专丞丝.丒丁丐上丂丛丝三三();
            if((业丞丝东丅丞丐丌专.丟丗东丛丘丂丌七丑)[1152921536222836960].丕丟一三且丛专丂丙 != false)
        {
                string val_23 = 丏下三丗一不专丞丝.丘专丙丑世下丌丕下();
            string val_24 = (val_23 == null) ? (val_67) : (val_23);
        }
        
        }
        
        }
        
        val_71 = 1152921505630220288;
        val_72 = 1152921525827968608;
        PGCompany.七丑一上且三世丝三<K, V> val_25 = PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不();
        val_73 = 1152921516746584832;
        val_25.set_Item(key:  "uniq_id", value:  (val_21 == null) ? (val_66) : (val_21));
        if(val_25 != null)
        {
                val_25.set_Item(key:  "hash", value:  val_24);
        }
        else
        {
                val_25.set_Item(key:  "hash", value:  val_24);
        }
        
        val_25.set_Item(key:  "device_id", value:  val_68);
        val_25.set_Item(key:  "device_model", value:  UnityEngine.SystemInfo.deviceModel);
        val_25.set_Item(key:  "cpu_model", value:  UnityEngine.SystemInfo.processorType);
        val_25.set_Item(key:  "cpu_frequency", value:  UnityEngine.SystemInfo.processorFrequency.ToString());
        val_25.set_Item(key:  "cpu_cores", value:  UnityEngine.SystemInfo.processorCount.ToString());
        val_25.set_Item(key:  "ram", value:  UnityEngine.SystemInfo.systemMemorySize.ToString());
        val_25.set_Item(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑().ToString());
        val_74 = null;
        val_74 = null;
        val_25.set_Item(key:  "version", value:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
        丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.String, System.String>(丏丂万业丙专丏丒丒:  val_25, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  new 业丞丝东丅丞丐丌专.丟丗东丛丘丂丌七丑(), method:  System.Boolean 业丞丝东丅丞丐丌专.丟丗东丛丘丂丌七丑::丌丙业东丝业丅下万()), 下上丐丆丝丟丝丒不:  "new_id_v3", 丙业与丙丗丝不丈东:  "1");
        System.DateTime val_37 = System.DateTime.Now;
        val_25.set_Item(key:  "id_seed", value:  new System.Random(Seed:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_37.dateData})).ToString());
        this.丒丘丗世三上丙丙丂.RawData = val_25.丐不丘丟与丙丛与七(丗丟上上丒丐丗丞丙:  val_25).ToArray();
        if(LogController.AnyLogEnabled != false)
        {
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                val_75 = "</color>";
            string val_46 = "<color=yellow>Send HTTP authorization on URL "("<color=yellow>Send HTTP authorization on URL ") + 业丞丝东丅丞丐丌专.丒丛丗三丂丁丅七丘() + val_75;
        }
        else
        {
                val_75 = 0;
        }
        
            var val_67 = 0;
            val_67 = val_67 + 1;
            val_75 = 0;
            string val_51 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_25);
            val_78 = this.丒丘丗世三上丙丙丂.RawData;
            if(val_78 == null)
        {
                byte[] val_53 = new byte[0];
            val_78 = val_53;
        }
        
            string val_54 = System.String.Join<System.Byte>(separator:  ",", values:  val_53);
            val_73 = 1152921505724518352;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                val_79 = new string[7];
            val_79[0] = "<color=yellow>Send Http Auth: ";
            val_71 = val_71;
            val_79[1] = val_51;
            val_72 = val_72;
            val_79[2] = "</color>";
            val_79[3] = System.Environment.NewLine;
            val_79[4] = "Encrypted: [";
            val_79[5] = val_54;
            val_80 = "]";
        }
        else
        {
                string[] val_58 = new string[6];
            val_79 = val_58;
            val_79[0] = "Send Http Auth: ";
            val_71 = val_71;
            val_79[1] = val_51;
            val_72 = val_72;
            val_79[2] = System.Environment.NewLine;
            val_79[3] = "Encrypted: [";
            val_79[4] = val_54;
            val_80 = "]";
        }
        
            mem2[0] = val_80;
            string[] val_62 = new string[1];
            val_62[0] = "Send HTTP authorization on URL " + 业丞丝东丅丞丐丌专.丒丛丗三丂丁丅七丘();
            LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  0, 丛专丛丕一与丅丝丁:  val_62);
            string[] val_64 = new string[1];
            val_67 = val_64;
            val_67[0] = +val_58;
            LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  0, 丛专丛丕一与丅丝丁:  val_64);
        }
        
        this.丒丘丗世三上丙丙丂.IsKeepAlive = false;
        this.丒丘丗世三上丙丙丂.DisableCache = true;
        BestHTTP.HTTPRequest val_65 = this.丒丘丗世三上丙丙丂.Send();
        if((PGCompany.七丑一上且三世丝三<System.String, System.String>.万世丅七一专丕丞不()) != null)
        {
                return;
        }
    
    }
    private void 丕三丒上丕丏丅丁丟()
    {
        var val_18;
        string val_19;
        AuthorizationStates val_20;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕上业丐七丂且不丁()) == false)
        {
            goto label_2;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if(this.下丅不上丝丈不世专 == null)
        {
            goto label_3;
        }
        
        label_35:
        val_3.set_Item(key:  "uniq_id", value:  this.下丅不上丝丈不世专);
        val_3.set_Item(key:  "hash", value:  this.丌且上三丅万丗丐丄());
        val_3.set_Item(key:  "device", value:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
        val_3.set_Item(key:  "token", value:  this.<丒下丏丑丞万丂三七>k__BackingField);
        val_3.set_Item(key:  "return", value:  0.CreateString(val:  不丈丐丞丄丕丏丂丄.丁丕丈丑丙上专七万(三丗丘万三东七三专:  this.<丒下丏丑丞万丂三七>k__BackingField)));
        val_3.set_Item(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑().ToString());
        val_3.set_Item(key:  "device_model", value:  UnityEngine.SystemInfo.deviceModel);
        val_18 = null;
        val_18 = null;
        val_3.set_Item(key:  "type_device", value:  (东丗上丁下业一丂丂.丆丒一专且业七丟丈 == false) ? (1 + 1) : 1);
        val_3.set_Item(key:  "abuse_method", value:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  "gfts", 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        val_3.set_Item(key:  "block_param", value:  1);
        val_19 = this.下丅不上丝丈不世专;
        if(val_19 == null)
        {
                val_19 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            this.下丅不上丝丈不世专 = val_19;
        }
        
        if((业丂丏与世一丏业不.丙世丟丛丕丁丑丈丁(丄丒且丙三丆丟与丏:  val_19)) != true)
        {
                val_19 = 1;
            val_3.set_Item(key:  "get_reg_ver", value:  1);
        }
        
        if(与丂丏丛丞丞丒丟丄.丕下下丕丗丝丛丒且() != true)
        {
                val_19 = 1;
            val_3.set_Item(key:  "get_country", value:  1);
        }
        
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
        {
                val_19 = 1;
            val_3.set_Item(key:  "dev", value:  1);
        }
        
        val_3.世不一丛万下丐丏丝(一丐丗丁丞丆丅丟丄:  val_3);
        if(this.世不丛丐东与丞万与 != 9)
        {
            goto label_31;
        }
        
        val_20 = 10;
        goto label_32;
        label_2:
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  0.5f);
        return;
        label_31:
        val_20 = 6;
        label_32:
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  val_20);
        return;
        label_3:
        this.下丅不上丝丈不世专 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_3 != null)
        {
            goto label_35;
        }
        
        goto label_35;
    }
    private void 丅丆万丒丙一丒一丈(BestHTTP.HTTPRequest 东丞丒丙世丏三下丟, BestHTTP.HTTPResponse 丑与丂丌世丕丆一丗)
    {
        int val_52;
        string val_54;
        var val_55;
        var val_57;
        int val_58;
        var val_59;
        int val_60;
        var val_61;
        System.Action val_62;
        object val_23 = 0;
        string val_27 = 0;
        string val_25 = 0;
        string val_37 = 0;
        string val_35 = 0;
        string val_39 = 0;
        AuthorizationStates val_53 = this.世不丛丐东与丞万与;
        if(val_53 > 8)
        {
            goto label_2;
        }
        
        val_53 = 1 << val_53;
        val_53 = val_53 & 338;
        if(val_53 == 0)
        {
            goto label_2;
        }
        
        if(丑与丂丌世丕丆一丗 == null)
        {
                return;
        }
        
        label_103:
        丑与丂丌世丕丆一丗.Dispose();
        return;
        label_2:
        if(丑与丂丌世丕丆一丗 == null)
        {
            goto label_4;
        }
        
        if(东丞丒丙世丏三下丟.State != 3)
        {
            goto label_78;
        }
        
        val_52 = System.String.alignConst;
        if(LogController.AnyLogEnabled == false)
        {
            goto label_9;
        }
        
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
        {
            goto label_10;
        }
        
        val_54 = "<color=cyan>Receive Http Auth {0}</color>: ";
        goto label_11;
        label_4:
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  1f);
        return;
        label_10:
        val_54 = "Receive Http Auth {0}: ";
        label_11:
        val_55 = 0;
        val_52 = System.String.Format(format:  val_54, arg0:  丑与丂丌世丕丆一丗.StatusCode);
        label_9:
        if(丑与丂丌世丕丆一丗.IsSuccess == false)
        {
            goto label_13;
        }
        
        System.Byte[] val_7 = 丑与丂丌世丕丆一丗.Data;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = val_7.丟丟丁丄丅丝万丌丙(一丐丗丁丞丆丅丟丄:  val_7);
        if(LogController.AnyLogEnabled == false)
        {
            goto label_16;
        }
        
        string[] val_11 = new string[3];
        if((val_52 != null) && (val_52 == null))
        {
                val_55 = 0;
        }
        
        if(val_11.Length == 0)
        {
                val_55 = 0;
        }
        
        val_11[0] = val_52;
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_55 = 0;
        goto label_29;
        label_13:
        this.且丈三与丗下丛丗与(丝业与丐丂世丄万丁:  0);
        丑与丂丌世丕丆一丗.Dispose();
        if(LogController.AnyLogEnabled == false)
        {
                return;
        }
        
        string[] val_15 = new string[2];
        val_15[0] = val_52;
        val_15[1] = 丑与丂丌世丕丆一丗.DataAsText;
        LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  0, 丛专丛丕一与丅丝丁:  val_15);
        return;
        label_29:
        val_11[1] = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_8);
        val_11[2] = System.Environment.NewLine + "Encrypted: "("Encrypted: ") + System.String.Join<System.Byte>(separator:  ",", values:  丑与丂丌世丕丆一丗.Data)(System.String.Join<System.Byte>(separator:  ",", values:  丑与丂丌世丕丆一丗.Data));
        LogController.Instance.AddMessage(丝东丗丕丛丞丝且丕:  0, 丛专丛丕一与丅丝丁:  val_11);
        label_16:
        if(val_8 == null)
        {
            goto label_78;
        }
        
        if((val_8.TryGetValue(key:  "server_time", value: out  val_23)) != false)
        {
                val_57 = null;
            val_57 = null;
            if(业丞丝东丅丞丐丌专.丝丒上丒丅一一万不 != null)
        {
                业丞丝东丅丞丐丌专.丝丒上丒丅一一万不.Invoke(obj:  val_23);
        }
        
        }
        
        bool val_26 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "player_id", 丙业与丙丗丝不丈东: out  val_25);
        bool val_28 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "hash", 丙业与丙丗丝不丈东: out  val_27);
        bool val_30 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "create_to", 丙业与丙丗丝不丈东: out  0);
        丏下三丗一不专丞丝.东专不丌丙三业世丌(丙业与丙丗丝不丈东:  val_25);
        丏下三丗一不专丞丝.世丅下且丗丕与丈与(丙业与丙丗丝不丈东:  val_27);
        this.<与不上丛丁丛丟一丟>k__BackingField = false;
        Rilisoft.丝丑丂丛万丐丈丘且 val_31 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
        this.<丙且丂丝丙丅丅丌丛>k__BackingField = val_31;
        mem[1152921536223747648] = val_31.上万三丆专丏丒丗业;
        this.<丗丏丛丘丝下丂丕丛>k__BackingField = false;
        if((val_8.ContainsKey(key:  "err_code")) == false)
        {
            goto label_60;
        }
        
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "easy", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        int val_34 = System.Convert.ToInt32(value:  val_8.Item["err_code"]);
        if(val_34 <= 3000)
        {
            goto label_65;
        }
        
        if(val_34 == 4000)
        {
            goto label_66;
        }
        
        if(val_34 != 6000)
        {
            goto label_78;
        }
        
        this.与丙三丒丗丙与丄丒(丝业与丐丂世丄万丁:  val_8);
        goto label_103;
        label_60:
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "easy", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        bool val_36 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "url", 丙业与丙丗丝不丈东: out  val_35);
        bool val_38 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "mm_url", 丙业与丙丗丝不丈东: out  val_37);
        bool val_40 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_8, 下上丐丆丝丟丝丒不:  "token", 丙业与丙丗丝不丈东: out  val_39);
        if((val_8.ContainsKey(key:  "wait")) == false)
        {
            goto label_73;
        }
        
        val_58 = System.Convert.ToInt32(value:  val_8.Item["wait"]);
        goto label_76;
        label_65:
        if(val_34 == 1402)
        {
            goto label_77;
        }
        
        if(val_34 != 3000)
        {
            goto label_78;
        }
        
        this.且丈三与丗下丛丗与(丝业与丐丂世丄万丁:  val_8);
        goto label_103;
        label_78:
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  1f);
        goto label_103;
        label_73:
        val_58 = 0;
        label_76:
        if((val_8.ContainsKey(key:  "debug")) != false)
        {
                var val_47 = ((System.Convert.ToInt32(value:  val_8.Item["debug"])) == 1) ? 1 : 0;
        }
        else
        {
                val_59 = 0;
        }
        
        this.<丒下丏丑丞万丂三七>k__BackingField = val_39;
        this.<一丞专丐万专七丛丟>k__BackingField = val_35;
        val_60 = val_37;
        if(val_60 == 0)
        {
                val_60 = System.String.alignConst;
        }
        
        this.<东丝万丗且丅专世丈>k__BackingField = val_60;
        this.<丗上一世万上丗丛七>k__BackingField = val_58;
        万业丈丕丙丐丕一丒.丏丐丝上三丁丞丝丕(丙业与丙丗丝不丈东:  false);
        this.业丈丙丕丙丐万丝丑.三丑丛丄万丟丄丞丁();
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  this.<一丞专丐万专七丛丟>k__BackingField);
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丌万丗与七丄丕不丁();
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丑丛丁丁万丄七丟丑(丙业与丙丗丝不丈东:  this.<东丝万丗且丅专世丈>k__BackingField);
        Rilisoft.Singleton<Rilisoft.WebSocket.MatchmakingSocketManager>.Instance.丌万丗与七丄丕不丁();
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  0f);
        this.丘上东丝丕丈丆丐丕 = 2;
        goto label_103;
        label_66:
        this.丏丏丏丁不专丛丞丅();
        goto label_103;
        label_77:
        this.不一丁丙丘不与丟丛();
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "easy", 下下丏一丙不丘丌丞:  3, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        this.<与不上丛丁丛丟一丟>k__BackingField = true;
        Rilisoft.丝丑丂丛万丐丈丘且 val_52 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
        this.<丙且丂丝丙丅丅丌丛>k__BackingField = val_52;
        mem[1152921536223747648] = val_52.上万三丆专丏丒丗业;
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  14);
        val_61 = null;
        val_61 = null;
        val_62 = 业丞丝东丅丞丐丌专.下业不专下丛万丘七;
        if(val_62 == null)
        {
            goto label_103;
        }
        
        val_62 = 业丞丝东丅丞丐丌专.下业不专下丛万丘七;
        if(val_62 == null)
        {
                val_62 = 0;
        }
        
        val_62.Invoke();
        goto label_103;
    }
    private void 丏丏丏丁不专丛丞丅()
    {
        if(this.丘上东丝丕丈丆丐丕 != 0)
        {
                this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  20f);
            int val_1 = this.丘上东丝丕丈丆丐丕;
            val_1 = val_1 - 1;
            this.丘上东丝丕丈丆丐丕 = val_1;
            return;
        }
        
        this.且丈三与丗下丛丗与(丝业与丐丂世丄万丁:  0);
    }
    internal void 东丘丆丂丞丏丛丂一(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
    {
        if(this.世不丛丐东与丞万与 != 5)
        {
                this.不一丁丙丘不与丟丛();
        }
        
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
    }
    internal void 不一业丆丛丛丁丞丂(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
    {
        if(this.世不丛丐东与丞万与 == 5)
        {
                return;
        }
        
        if(this.世不丛丐东与丞万与 == 8)
        {
                return;
        }
        
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  1f);
    }
    internal void 丟三丕丆一万七丅丏(BestHTTP.SocketIO.Socket 丝东丗丕丛丞丝且丕, BestHTTP.SocketIO.Packet 丙丁丌丛业不丄丝丈, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        System.Action val_3;
        AuthorizationStates val_2 = this.世不丛丐东与丞万与;
        val_2 = val_2 - 9;
        if(val_2 <= 1)
        {
                this.丐丅丛下世丂丛丐丙 = 1f;
            this.不一丁丙丘不与丟丛();
            val_2 = null;
            val_2 = null;
            val_3 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
            if(val_3 != null)
        {
                val_3 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
            if(val_3 == null)
        {
                val_3 = 0;
        }
        
            val_3.Invoke();
        }
        
        }
        
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丗丟万丂丘丈专丄丂();
    }
    private void 丙三丑一丄下上丝丐(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "reason")) != false)
        {
                if((System.Convert.ToInt32(value:  丑与丂丌世丕丆一丗.Item["reason"])) == 1)
        {
                this.不一丁丙丘不与丟丛();
            return;
        }
        
        }
        
        this.一专上下丈丛上丑丘();
    }
    private void 丛世丝丕丅丒丐下丈(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        var val_2;
        var val_3;
        System.Action val_4;
        var val_5;
        System.Action val_6;
        var val_7;
        AuthorizationStates val_8;
        val_2 = this;
        uint val_1 = this.业丞万丘丘上下丈与(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗);
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        if(val_1 != 1419)
        {
            goto label_2;
        }
        
        this.<丒下丏丑丞万丂三七>k__BackingField = System.String.alignConst;
        if(this.世不丛丐东与丞万与 != 10)
        {
            goto label_3;
        }
        
        this.不一丁丙丘不与丟丛();
        val_2 = 1152921505130487808;
        val_3 = null;
        val_3 = null;
        val_4 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
        if(val_4 == null)
        {
                return;
        }
        
        val_4 = 业丞丝东丅丞丐丌专.丝丆一且不丟七丏丙;
        if(val_4 == null)
        {
                val_4 = 0;
        }
        
        val_4.Invoke();
        return;
        label_1:
        if(this.世不丛丐东与丞万与 == 10)
        {
                val_5 = null;
            val_5 = null;
            val_6 = 业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞;
            if(val_6 != null)
        {
                val_6 = 业丞丝东丅丞丐丌专.丛万七专丁不丁丅丞;
            if(val_6 == null)
        {
                val_6 = 0;
        }
        
            val_6.Invoke();
        }
        
        }
        
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  1);
        val_7 = null;
        val_7 = null;
        if(业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一 != null)
        {
                业丞丝东丅丞丐丌专.丆三丁丂三丙七丐一.Invoke();
        }
        
        this.丒丘丗世三上丙丙丂 = 0;
        return;
        label_2:
        val_8 = 2;
        goto label_20;
        label_3:
        val_8 = 7;
        label_20:
        this.丆丛与上七丏丝丅丘(丙业与丙丗丝不丈东:  val_8);
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  1f);
    }
    private uint 业丞万丘丘上下丈与(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗)
    {
        var val_37;
        object val_38;
        object val_39;
        var val_40;
        var val_41;
        System.Action<System.String> val_42;
        val_38 = 丑与丂丌世丕丆一丗;
        object val_10 = 0;
        object val_14 = 0;
        object val_12 = 0;
        object val_16 = 0;
        if(val_38 == null)
        {
            goto label_1;
        }
        
        val_37 = "err_code";
        if((val_38.ContainsKey(key:  "err_code")) == false)
        {
            goto label_2;
        }
        
        val_38 = val_38.Item["err_code"];
        val_39 = val_38;
        uint val_3 = System.Convert.ToUInt32(value:  val_39);
        return (uint)val_39;
        label_1:
        val_39 = 1;
        return (uint)val_39;
        label_2:
        int val_4 = System.String.alignConst;
        bool val_23 = false;
        int val_6 = System.String.alignConst;
        int val_8 = System.String.alignConst;
        bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_38, 下上丐丆丝丟丝丒不:  "secret", 丙业与丙丗丝不丈东: out  val_4);
        bool val_7 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_38, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_6);
        bool val_9 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_38, 下上丐丆丝丟丝丒不:  "char_key", 丙业与丙丗丝不丈东: out  val_8);
        bool val_11 = val_38.TryGetValue(key:  "reg_ver", value: out  val_10);
        bool val_13 = val_38.TryGetValue(key:  "reg_time", value: out  val_12);
        bool val_15 = val_38.TryGetValue(key:  "country", value: out  val_14);
        bool val_17 = val_38.TryGetValue(key:  "continent", value: out  val_16);
        if((val_38.ContainsKey(key:  "block_value")) != false)
        {
                val_40 = System.Convert.ToInt32(value:  val_38.Item["block_value"]);
        }
        else
        {
                val_40 = 0;
        }
        
        if((val_38.ContainsKey(key:  "new_player")) != false)
        {
                bool val_24 = System.Boolean.TryParse(value:  val_38.Item["new_player"], result: out  val_23);
        }
        
        if((val_38.ContainsKey(key:  "developer")) != false)
        {
                bool val_27 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  val_38, 下上丐丆丝丟丝丒不:  "developer", 丙业与丙丗丝不丈东: out  0);
        }
        
        专丈专业丆且且业下.丗丈一三不万且丟丕(丙业与丙丗丝不丈东:  val_6);
        PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世().丂丛业丒丏丞丝丅丑(丙业与丙丗丝不丈东:  0);
        业丂丏与世一丏业不.丙业丅丐与丕与三丗(丘丙且三不丏丕业下:  val_10, 丘丏丘丈且丌三丟丌:  val_12);
        与丂丏丛丞丞丒丟丄.丒丛一丄丐丘与丈下(丘丞与万丕丞丌且丝:  val_14, 一东丐一东丄一万丙:  val_16);
        this.丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  val_6);
        this.丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  val_4);
        if(val_40 >= 1)
        {
                丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "TableViewKey", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        
        专丈专业丆且且业下.与三东丙丐丈不丈上(丙业与丙丗丝不丈东:  false);
        if(val_23 == 0)
        {
            goto label_30;
        }
        
        丑丝丞丒丅丄万丒三.丄万丐丛与丌丈丆丅(丞丅上丏丂且下丅与:  val_6);
        this.<万专丝丕丞丞丝丛丐>k__BackingField = val_8;
        if(val_23 == 0)
        {
            goto label_38;
        }
        
        Progress.七七世万专丕丁上业.丌丄且与专一七丗丏();
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "OldPurchased", 下下丏一丙不丘丌丞:  System.String.alignConst);
        goto label_38;
        label_30:
        this.<万专丝丕丞丞丝丛丐>k__BackingField = val_8;
        label_38:
        val_37 = "time";
        if((val_38.ContainsKey(key:  "time")) != false)
        {
                val_41 = null;
            val_41 = null;
            val_42 = 业丞丝东丅丞丐丌专.丝丒上丒丅一一万不;
            if(val_42 != null)
        {
                val_42 = 业丞丝东丅丞丐丌专.丝丒上丒丅一一万不;
            val_42.Invoke(obj:  val_38.Item["time"]);
        }
        
        }
        
        val_38 = 1152921505283682304;
        if(val_23 == 0)
        {
            goto label_47;
        }
        
        if((System.String.IsNullOrEmpty(value:  丈丆丅丄与万丌世丂.丁下丙丞且丟且三丂())) == false)
        {
            goto label_56;
        }
        
        val_38 = val_6;
        丈丆丅丄与万丌世丂.世业下一丝上与下业(丙业与丙丗丝不丈东:  val_38);
        goto label_59;
        label_47:
        if((System.String.IsNullOrEmpty(value:  丈丆丅丄与万丌世丂.丁下丙丞且丟且三丂())) != true)
        {
                if((System.String.op_Inequality(a:  丈丆丅丄与万丌世丂.丁下丙丞且丟且三丂(), b:  val_6)) == false)
        {
            goto label_59;
        }
        
        }
        
        label_56:
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  42);
        label_59:
        val_39 = 0;
        return (uint)val_39;
    }
    private void 世不一丛万下丐丏丝(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_3;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        int val_2 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.一丈丒一不丗上东专, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }
    private void 且丈三与丗下丛丗与(System.Collections.Generic.Dictionary<string, object> 丝业与丐丂世丄万丁)
    {
        this.一专上下丈丛上丑丘();
        三丅丙三丟与丗丞一.丑七不且上丗丁一世().丅专下万丕丑丆丅丝(七七丗丘丑丟丝丄丅:  丝业与丐丂世丄万丁);
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "easy", 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    private void 与丙三丒丗丙与丄丒(System.Collections.Generic.Dictionary<string, object> 丝业与丐丂世丄万丁)
    {
        var val_6;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Action val_19;
        val_16 = this;
        object val_1 = 0;
        string val_9 = 0;
        string val_11 = 0;
        if((丝业与丐丂世丄万丁.TryGetValue(key:  "ids", value: out  val_1)) != false)
        {
                if(val_1 == 0)
        {
            goto label_8;
        }
        
        }
        else
        {
                this.且丈三与丗下丛丗与(丝业与丐丂世丄万丁:  0);
            return;
        }
        
        label_8:
        List.Enumerator<T> val_4 = GetEnumerator();
        val_15 = 1152921516789140576;
        label_19:
        if((1553930464 & 1) == 0)
        {
            goto label_10;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_17 = 0;
        bool val_10 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_9);
        bool val_12 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  null, 下上丐丆丝丟丝丒不:  "hash", 丙业与丙丗丝不丈东: out  val_11);
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == true) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11)) == true))
        {
            goto label_19;
        }
        
        专丈专业丆且且业下.丗丈一三不万且丟丕(丙业与丙丗丝不丈东:  val_9);
        this.丏丗一丄丛丑丐丛丒(丙业与丙丗丝不丈东:  val_9);
        this.丕丕丐丝丐下丞丅丕(丙业与丙丗丝不丈东:  val_11);
        this.丛丏不且上丆丘丝丆(丆丐七丅丆丗丛上与:  1f);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.且丈三与丗下丛丗与(丝业与丐丂世丄万丁:  0);
        this.<丗丏丛丘丝下丂丕丛>k__BackingField = true;
        val_16 = 1152921505130487808;
        val_18 = null;
        val_18 = null;
        val_19 = 业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与;
        if(val_19 == null)
        {
                return;
        }
        
        val_19 = 业丞丝东丅丞丐丌专.专一丕丌一丂丈丅与;
        if(val_19 == null)
        {
                val_19 = 0;
        }
        
        val_19.Invoke();
    }
    private System.Collections.Generic.List<byte> 丐不丘丟与丙丛与七(System.Collections.Generic.Dictionary<string, string> 丗丟上上丒丐丗丞丙)
    {
        System.Random val_25;
        var val_26;
        var val_27;
        var val_28;
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
        System.DateTime val_2 = System.DateTime.Now;
        System.Collections.Generic.IEnumerable<T> val_5 = 丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<System.Collections.Generic.KeyValuePair<System.String, System.String>>(丅东丗丒丄东丛业丄:  丗丟上上丒丐丗丞丙, 丂丆且一丛丙丑七丒:  new System.Random(Seed:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_2.dateData})));
        System.DateTime val_6 = System.DateTime.UtcNow;
        System.Random val_8 = new System.Random(Seed:  丞东丑专丛丆丄丝世.丛世不上丒专七业世(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_6.dateData}));
        System.Random val_10 = val_8 & 255;
        var val_26 = 0;
        val_26 = val_26 + 1;
        System.Collections.Generic.IEnumerator<T> val_12 = val_5.GetEnumerator();
        label_34:
        var val_27 = 0;
        val_27 = val_27 + 1;
        if(val_12.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_28 = 0;
        val_28 = val_28 + 1;
        T val_16 = val_12.Current;
        System.Char[] val_18 = 丞东丑专丛丆丄丝世.丗丒万丌一丆丛丆丛(丏丛与丅丛丌万专丌:  val_16.丐丏七丌丕丗业且上(), 上七不丈下下丛丘与:  val_10);
        System.Char[] val_19 = 丞东丑专丛丆丄丝世.丗丒万丌一丆丛丆丛(丏丛与丅丛丌万专丌:  val_16, 上七不丈下下丛丘与:  val_10);
        int val_29 = System.Linq.Enumerable.Count<System.Collections.Generic.KeyValuePair<System.String, System.String>>(source:  val_5);
        val_29 = val_29 - 1;
        val_1.Add(item:  val_20.dataItem);
        val_1.Add(item:  0);
        val_1.Add(item:  ((((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) == null) ? 1 : 0) << 1) + val_21.dataItem);
        val_1.Add(item:  0);
        val_1.AddRange(collection:  System.Text.Encoding.Unicode);
        val_1.AddRange(collection:  System.Text.Encoding.Unicode);
        goto label_34;
        label_16:
        val_25 = val_8;
        val_26 = 1152921516286868352;
        val_27 = 0;
        val_28 = 0;
        if(val_12 == null)
        {
            
        }
        else
        {
                var val_30 = 0;
            val_30 = val_30 + 1;
            val_12.Dispose();
        }
        
        if(val_1 != null)
        {
                val_1.Add(item:  0);
        }
        else
        {
                val_1.Add(item:  0);
        }
        
        val_1.Add(item:  0);
        return val_1;
    }
    private System.Collections.Generic.Dictionary<string, object> 丟丟丁丄丅丝万丌丙(byte[] 一丐丗丁丞丆丅丟丄)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return val_1;
        }
        
        if(一丐丗丁丞丆丅丟丄.Length == 0)
        {
                return val_1;
        }
        
        var val_17 = -8589934592;
        val_17 = val_17 + ((一丐丗丁丞丆丅丟丄.Length) << 32);
        var val_19 = 0;
        do
        {
            short val_5 = System.BitConverter.ToInt16(value:  一丐丗丁丞丆丅丟丄, startIndex:  val_19 + 2);
            val_19 = (val_19 + 4) + (System.BitConverter.ToInt16(value:  一丐丗丁丞丆丅丟丄, startIndex:  0));
            val_19 = (((val_19 + val_5) < 一丐丗丁丞丆丅丟丄.Length) ? ((int)val_5 & 65535) : (((int)val_5 & 65535) - 2)) + val_19;
            val_1.set_Item(key:  0.CreateString(val:  丞东丑专丛丆丄丝世.丗丒万丌一丆丛丆丛(丏丛与丅丛丌万专丌:  System.Text.Encoding.Unicode, 上七不丈下下丛丘与:  -(一丐丗丁丞丆丅丟丄[val_17 >> 32]))), value:  0.CreateString(val:  丞东丑专丛丆丄丝世.丗丒万丌一丆丛丆丛(丏丛与丅丛丌万专丌:  System.Text.Encoding.Unicode, 上七不丈下下丛丘与:  -(一丐丗丁丞丆丅丟丄[val_17 >> 32]))));
        }
        while((val_19 + 2) < 一丐丗丁丞丆丅丟丄.Length);
        
        return val_1;
    }
    private static 业丞丝东丅丞丐丌专()
    {
        业丞丝东丅丞丐丌专.丐丄丅丌丙丅丂丅与 = 1f;
    }

}
