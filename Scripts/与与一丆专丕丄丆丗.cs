using UnityEngine;
internal class 与与一丆专丕丄丆丗
{
    // Fields
    private const int 丗丐上丘丐业业丕丐 = 1520;
    private static 与与一丆专丕丄丆丗 世丒丞七专三与万丕;
    private System.Collections.Generic.List<与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且> 不丈丐万丞丞丅丁丂;
    private 丐丁丑丑丈丁上丘丆 不丒丞丒丄上三七丂;
    private System.Collections.Generic.HashSet<string> 与丝丛丝丆上丞丑丌;
    private System.Collections.Generic.List<string> 丛一丘丐丐丌丞丑丑;
    private static System.Action 丛专万丄三不与丛上;
    private static System.Action<string, bool, int> 丂且丑丞丌东与万丒;
    private static System.Action<string, bool> 专不与三与丐上丑丟;
    
    // Properties
    internal static 与与一丆专丕丄丆丗 丆丕丝丒不丙且丐丗 { get; }
    public System.Collections.Generic.List<与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且> 上丅万万丝一丙东丙 { get; set; }
    internal System.Collections.Generic.HashSet<string> 丛专丗东丅丂丗丙丈 { get; set; }
    internal 丐丁丑丑丈丁上丘丆 丂且且万下丂丗丅丛 { get; set; }
    
    // Methods
    internal 与与一丆专丕丄丆丗()
    {
        this.丛一丘丐丐丌丞丑丑 = new System.Collections.Generic.List<System.String>();
        this.丒丝丒与丄丕三丁丒();
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 与与一丆专丕丄丆丗::下丅东丏与丛与三丌()));
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        this.下丅东丏与丛与三丌();
    }
    internal static 与与一丆专丕丄丆丗 丑七不且上丗丁一世()
    {
        与与一丆专丕丄丆丗 val_2;
        与与一丆专丕丄丆丗 val_3 = 与与一丆专丕丄丆丗.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        与与一丆专丕丄丆丗 val_1 = null;
        val_2 = val_1;
        val_1 = new 与与一丆专丕丄丆丗();
        与与一丆专丕丄丆丗.世丒丞七专三与万丕 = val_2;
        val_3 = 与与一丆专丕丄丆丗.世丒丞七专三与万丕;
        return val_3;
    }
    public System.Collections.Generic.List<与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且> 丁下丒丌下丅世丝丈()
    {
        System.Collections.Generic.List<丕丘上丞丌丞下丈且> val_5 = this.不丈丐万丞丞丅丁丂;
        if(val_5 != null)
        {
                return val_5;
        }
        
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  val_1.丒丞与下丕业业丐专(), 丞丌丑丛上丕丙丕下:  "[]");
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = val_1;
        this.不丈丐万丞丞丅丁丂 = val_5;
        return val_5;
    }
    public void 丐丝一丙丛世丑丂丛(System.Collections.Generic.List<与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且> 丙业与丙丗丝不丈东)
    {
        this.不丈丐万丞丞丅丁丂 = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.HashSet<string> 不一不下世丝丝丅丒()
    {
        return (System.Collections.Generic.HashSet<System.String>)this.与丝丛丝丆上丞丑丌;
    }
    internal void 丆丌丈七丙上丆万一(System.Collections.Generic.HashSet<string> 丙业与丙丗丝不丈东)
    {
        this.与丝丛丝丆上丞丑丌 = 丙业与丙丗丝不丈东;
    }
    internal 丐丁丑丑丈丁上丘丆 丛东且丘丂专丐丈丛()
    {
        return (丐丁丑丑丈丁上丘丆)this.不丒丞丒丄上三七丂;
    }
    private void 丒东丑丞不上丏东丛(丐丁丑丑丈丁上丘丆 丙业与丙丗丝不丈东)
    {
        this.不丒丞丒丄上三七丂 = 丙业与丙丗丝不丈东;
    }
    internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  与与一丆专丕丄丆丗.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.丛专万丄三不与丛上 != 1152921505227563016);
    
    }
    internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  与与一丆专丕丄丆丗.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.丛专万丄三不与丛上 != 1152921505227563016);
    
    }
    public static void 丙丘三一东丝万下丗(System.Action<string, bool, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  与与一丆专丕丄丆丗.丂且丑丞丌东与万丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.丂且丑丞丌东与万丒 != 1152921505227563024);
    
    }
    public static void 不业万专丝丟丘丙专(System.Action<string, bool, int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  与与一丆专丕丄丆丗.丂且丑丞丌东与万丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.丂且丑丞丌东与万丒 != 1152921505227563024);
    
    }
    public static void 丄丈丂丐丈世丙丟丕(System.Action<string, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  与与一丆专丕丄丆丗.专不与三与丐上丑丟, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.专不与三与丐上丑丟 != 1152921505227563032);
    
    }
    public static void 丞丛三与丞一丟丂丂(System.Action<string, bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  与与一丆专丕丄丆丗.专不与三与丐上丑丟, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(与与一丆专丕丄丆丗.专不与三与丐上丑丟 != 1152921505227563032);
    
    }
    private void 丒丝丒与丄丕三丁丒()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丛万丛丞且一不不东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 与与一丆专丕丄丆丗::丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.上丛三丁丕丒丐专丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 与与一丆专丕丄丆丗::万丕不下丗丑丑丏丞(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 上丂丛万丁七三丙丌()
    {
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  val_1.且丛业丑七丟丆丕丂(), 丞丌丑丛上丕丙丕下:  "{}");
        var val_6 = 0;
        val_6 = val_6 + 1;
        if(val_1 == null)
        {
            goto label_10;
        }
        
        label_13:
        this.不丒丞丒丄上三七丂 = val_1;
        return;
        label_10:
        丐丁丑丑丈丁上丘丆 val_5 = new 丐丁丑丑丈丁上丘丆();
        if(this != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    private void 万世一丅万丁丘丈万()
    {
        DataSystem.丈且丈上不下且丝丒 val_1 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        string val_3 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  val_1.一丒丅一世丅丆丆丅(), 丞丌丑丛上丕丙丕下:  "[]");
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.与丝丛丝丆上丞丑丌 = val_1;
    }
    internal void 丆丏丏业丅与三丁丏()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.且丛业丑七丟丆丕丂(), 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.不丒丞丒丄上三七丂));
    }
    internal void 丕丗三丒上丑上丕丆()
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.一丒丅一世丅丆丆丅(), 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.与丝丛丝丆上丞丑丌));
    }
    internal uint 与丛丆专东丐一且丅(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_8;
        string val_22;
        var val_23;
        var val_24;
        var val_25;
        string val_26;
        val_23 = 1;
        int val_1 = 0;
        string val_10 = 0;
        string val_12 = 0;
        if(丏丂万业丙专丏丒丒 == null)
        {
                return (uint)val_23;
        }
        
        if(this.不丒丞丒丄上三七丂 == null)
        {
                return (uint)val_23;
        }
        
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "lobby_likes", 丙业与丙丗丝不丈东: out  val_1)) != false)
        {
                val_24 = val_1;
            this.不丒丞丒丄上三七丂.Count = 0;
        }
        
        val_22 = this.丁下丒丌下丅世丝丈();
        val_22.Clear();
        if((丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.List<System.Object>>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "lobby_last_like", 丙业与丙丗丝不丈东: out  0)) == false)
        {
            goto label_10;
        }
        
        List.Enumerator<T> val_6 = val_4.GetEnumerator();
        val_24 = 1152921516789140576;
        label_21:
        if(((-696490144) & 1) == 0)
        {
            goto label_12;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if(val_9 == null)
        {
            goto label_21;
        }
        
        bool val_11 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_9, 下上丐丆丝丟丝丒不:  "id", 丙业与丙丗丝不丈东: out  val_10);
        bool val_13 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_9, 下上丐丆丝丟丝丒不:  "name", 丙业与丙丗丝不丈东: out  val_12);
        new 与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且() = new System.Object();
        if(new 与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且() != null)
        {
                .<上世与丏专丟七丅不>k__BackingField = val_10;
            val_26 = val_12;
        }
        else
        {
                mem[16] = val_10;
            val_26 = val_12;
        }
        
        .<七世专丙丝丒丒丟丁>k__BackingField = val_26;
        this.丁下丒丌下丅世丝丈().Add(item:  new 与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且());
        goto label_21;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_25 = 0;
        val_22 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丁下丒丌下丅世丝丈());
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_8.丒丞与下丕业业丐专(), 下下丏一丙不丘丌丞:  val_22);
        this.丏丂丕丒上丆丕丈一(丝丏丞丅三与丏丏丑:  this.丁下丒丌下丅世丝丈());
        label_10:
        val_23 = 0;
        return (uint)val_23;
    }
    private void 丏丂丕丒上丆丕丈一(System.Collections.Generic.List<与与一丆专丕丄丆丗.丕丘上丞丌丞下丈且> 丝丏丞丅三与丏丏丑)
    {
        this.不丒丞丒丄上三七丂.LastPlayerThatLiked = System.String.alignConst;
        if((System.Linq.Enumerable.LastOrDefault<丕丘上丞丌丞下丈且>(source:  丝丏丞丅三与丏丏丑)) == null)
        {
                return;
        }
        
        this = this.不丒丞丒丄上三七丂;
        this.不丒丞丒丄上三七丂.LastPlayerThatLiked = val_1.<七世专丙丝丒丒丟丁>k__BackingField;
    }
    private void 丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((this.与丛丆专东丐一且丅(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗)) != 0)
        {
                return;
        }
        
        if(与与一丆专丕丄丆丗.丛专万丄三不与丛上 == null)
        {
                return;
        }
        
        与与一丆专丕丄丆丗.丛专万丄三不与丛上.Invoke();
    }
    private void 万丕不下丗丑丑丏丞(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        uint val_1 = this.丕丝丁三一东丑专丈(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  丁不七丙下七丐与不);
    }
    private uint 丕丝丁三一东丑专丈(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        int val_26;
        object val_27;
        var val_28;
        val_27 = 丑与丂丌世丕丆一丗;
        object val_12 = 0;
        if(val_27 == null)
        {
            goto label_21;
        }
        
        val_28 = 1;
        if(东丞丒丙世丏三下丟 == null)
        {
                return (uint)val_28;
        }
        
        if(val_27.Count == 0)
        {
                return (uint)val_28;
        }
        
        val_26 = System.String.alignConst;
        if((东丞丒丙世丏三下丟.ContainsKey(key:  "player_id")) != false)
        {
                object val_3 = 东丞丒丙世丏三下丟.Item["player_id"];
            if(val_3 != null)
        {
                var val_4 = (null == null) ? (val_3) : 0;
        }
        else
        {
                val_26 = 0;
        }
        
        }
        
        if((东丞丒丙世丏三下丟.ContainsKey(key:  "like")) != false)
        {
                bool val_9 = 丞东丑专丛丆丄丝世.且丕丄丈丈丏丈世丝(业三丝丌七丑三丏丛:  System.Convert.ToInt32(value:  东丞丒丙世丏三下丟.Item["like"]));
        }
        
        if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_26)) == true) || (((-695847396) & 1) == 0))
        {
            goto label_21;
        }
        
        bool val_11 = this.丛一丘丐丐丌丞丑丑.Remove(item:  val_26);
        if((val_27.TryGetValue(key:  "err_code", value: out  val_12)) == false)
        {
            goto label_17;
        }
        
        if(与与一丆专丕丄丆丗.专不与三与丐上丑丟 != null)
        {
                与与一丆专丕丄丆丗.专不与三与丐上丑丟.Invoke(arg1:  val_26, arg2:  false);
        }
        
        val_27 = val_12;
        if((System.Convert.ToInt32(value:  val_27)) == 1520)
        {
                bool val_15 = this.与丝丛丝丆上丞丑丌.Add(item:  val_26);
        }
        
        label_21:
        val_28 = 1;
        return (uint)val_28;
        label_17:
        if((val_27.ContainsKey(key:  "players_lobby")) != false)
        {
                if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_27.Item["players_lobby"], 丙业与丙丗丝不丈东: out  0)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_21 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丙丈丅丕丐一且丟丄();
            val_21.丒七世丏丑丄一丄且(丄丒且丙三丆丟与丏:  val_26, 业丟丙丕上七丝丆东:  0, 丏丂万业丙专丏丒丒:  val_21);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_23 = 丂与专万与丐丌丏不.丑七不且上丗丁一世().丘丅丐万七业丘丏丁();
            val_23.丒七世丏丑丄一丄且(丄丒且丙三丆丟与丏:  val_26, 业丟丙丕上七丝丆东:  0, 丏丂万业丙专丏丒丒:  val_23);
        }
        
        }
        
        if(( & 1) != 0)
        {
                bool val_24 = this.与丝丛丝丆上丞丑丌.Add(item:  val_26);
        }
        else
        {
                bool val_25 = this.与丝丛丝丆上丞丑丌.Remove(item:  val_26);
        }
        
        if(与与一丆专丕丄丆丗.丂且丑丞丌东与万丒 == null)
        {
                return (uint)val_28;
        }
        
        与与一丆专丕丄丆丗.丂且丑丞丌东与万丒.Invoke(arg1:  val_26, arg2:  false, arg3:  0);
        return (uint)val_28;
    }
    private void 下丅东丏与丛与三丌()
    {
        this.上丂丛万丁七三丙丌();
        this.万世一丅万丁丘丈万();
        this.丈且丑万丌专丗世世();
    }
    private void 丈且丑万丌专丗世世()
    {
        var val_2 = null;
        Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丛万丛丞且一不不东);
    }
    internal void 丄且三丗下业丟万上(string 丄丒且丙三丆丟与丏)
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = this.丝不丈与丅丐丘丏且(万不世丌专丞世丘丟:  丄丒且丙三丆丟与丏, 七世下丐丑东专世丕:  true);
        val_3.丂万丌丝上一万丒丞(一丐丗丁丞丆丅丟丄:  val_3);
        PGCompany.Analytics.一业丗丆世世上丁且.且丁专业丙丌丌丝七(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丄丒且丙三丆丟与丏:  丄丒且丙三丆丟与丏);
    }
    internal void 丘且业丄专丆东东万(string 丄丒且丙三丆丟与丏)
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = this.丝不丈与丅丐丘丏且(万不世丌专丞世丘丟:  丄丒且丙三丆丟与丏, 七世下丐丑东专世丕:  false);
        val_3.丂万丌丝上一万丒丞(一丐丗丁丞丆丅丟丄:  val_3);
    }
    private System.Collections.Generic.Dictionary<object, object> 丝不丈与丅丐丘丏且(string 万不世丌专丞世丘丟, bool 七世下丐丑东专世丕)
    {
        string val_5;
        System.Collections.Generic.List<System.String> val_6;
        var val_7;
        val_5 = 万不世丌专丞世丘丟;
        val_6 = this;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = null;
        val_7 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) != false)
        {
                val_5 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "SendLikeLobbyCoroutine idLobbyPlayer.IsNullOrEmpty()", args:  val_5);
            val_7 = 0;
            return (System.Collections.Generic.Dictionary<System.Object, System.Object>)val_7;
        }
        
        object val_4 = ((七世下丐丑东专世丕 & true) != 0) ? (-1) : 1;
        if(val_7 != null)
        {
                val_1.set_Item(key:  "like", value:  val_4);
        }
        else
        {
                val_1.set_Item(key:  "like", value:  val_4);
        }
        
        val_1.set_Item(key:  "player_id", value:  val_5);
        val_6 = this.丛一丘丐丐丌丞丑丑;
        val_6.Add(item:  val_5);
        return (System.Collections.Generic.Dictionary<System.Object, System.Object>)val_7;
    }
    internal bool 不专七丄专丝丂下上(string 丄丒且丙三丆丟与丏)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丒且丙三丆丟与丏)) != false)
        {
                return false;
        }
        
        if(this.丛一丘丐丐丌丞丑丑 != null)
        {
                return this.丛一丘丐丐丌丞丑丑.Contains(item:  丄丒且丙三丆丟与丏);
        }
        
        return this.丛一丘丐丐丌丞丑丑.Contains(item:  丄丒且丙三丆丟与丏);
    }
    private void 丒七世丏丑丄一丄且(string 丄丒且丙三丆丟与丏, int 业丟丙丕上七丝丆东, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> 丏丂万业丙专丏丒丒)
    {
        int val_6;
        string val_7;
        var val_8;
        val_6 = 业丟丙丕上七丝丆东;
        val_7 = 丄丒且丙三丆丟与丏;
        if((丏丂万业丙专丏丒丒.ContainsKey(key:  val_7)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = 丏丂万业丙专丏丒丒.Item[val_7];
        val_7 = "player";
        if((val_2.ContainsKey(key:  "player")) == false)
        {
                return;
        }
        
        object val_4 = val_2.Item["player"];
        val_6 = val_6;
        if(val_4 != null)
        {
                val_7 = 1152921504689381376;
            val_8 = null;
            val_8 = null;
            var val_5 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_8) ? (val_4) : 0;
        }
        
        0.set_Item(key:  "lobby_likes", value:  val_6);
    }
    private void 丂万丌丝上一万丒丞(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_3;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        int val_2 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.上丛三丁丕丒丐专丑, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }
    private string 且丛业丑七丟丆丕丂()
    {
        return "OUR_LOBBY_LIKES_KEY-"("OUR_LOBBY_LIKES_KEY-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    private string 一丒丅一世丅丆丆丅()
    {
        return "LOBBY_LIKES_SEND_KEY-"("LOBBY_LIKES_SEND_KEY-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }
    private string 丒丞与下丕业业丐专()
    {
        return "LAST_LIKED_PLAYERS_KEY-"("LAST_LIKED_PLAYERS_KEY-") + 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
    }

}
