using UnityEngine;
internal class 不丈丐丞丄丕丏丂丄
{
    // Fields
    private static 不丈丐丞丄丕丏丂丄 世丒丞七专三与万丕;
    private System.Collections.Generic.Dictionary<int, 不丈丐丞丄丕丏丂丄.不万与丆东上丟丞丐> 丟七东丌丞丝与丏丙;
    private static System.Action 丛专万丄三不与丛上;
    
    // Properties
    internal static 不丈丐丞丄丕丏丂丄 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal 不丈丐丞丄丕丏丂丄()
    {
        this.丟七东丌丞丝与丏丙 = new System.Collections.Generic.Dictionary<System.Int32, 不万与丆东上丟丞丐>();
        this.丒丝丒与丄丕三丁丒();
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 不丈丐丞丄丕丏丂丄::下丅东丏与丛与三丌()));
    }
    internal static 不丈丐丞丄丕丏丂丄 丑七不且上丗丁一世()
    {
        不丈丐丞丄丕丏丂丄 val_2;
        不丈丐丞丄丕丏丂丄 val_3 = 不丈丐丞丄丕丏丂丄.世丒丞七专三与万丕;
        if(val_3 != null)
        {
                return val_3;
        }
        
        不丈丐丞丄丕丏丂丄 val_1 = null;
        val_2 = val_1;
        val_1 = new 不丈丐丞丄丕丏丂丄();
        不丈丐丞丄丕丏丂丄.世丒丞七专三与万丕 = val_2;
        val_3 = 不丈丐丞丄丕丏丂丄.世丒丞七专三与万丕;
        return val_3;
    }
    internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上 != 1152921505180438536);
    
    }
    internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上 != 1152921505180438536);
    
    }
    internal void 丂丞丏丒万丟丁且七(string 下丅丑不丛与丝不丌, 不丈丐丞丄丕丏丂丄.不万与丆东上丟丞丐 业丏丈世世世丞丒世)
    {
        string val_5 = 下丅丑不丛与丝不丌;
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_3.set_Item(key:  "rejectee_id", value:  val_5 = 下丅丑不丛与丝不丌);
        val_5 = val_3.丑不专丑不丌丁丙东(一丐丗丁丞丆丅丟丄:  val_3);
        if(val_5 == 1)
        {
                return;
        }
        
        this.丟七东丌丞丝与丏丙.set_Item(key:  val_5, value:  业丏丈世世世丞丒世);
    }
    internal static char[] 丁丕丈丑丙上专七万(string 三丗丘万三东七三专)
    {
        int val_31;
        int val_32;
        var val_33;
        var val_34;
        System.Int32[][] val_5 = new System.Int32[][4];
        val_5[0] = new int[16];
        val_5[1] = new int[16];
        val_5[2] = new int[16];
        val_5[3] = new int[16];
        var val_38 = 0;
        label_27:
        var val_8 = (1 < 0) ? (val_38 + 4) : (val_38 + 1);
        val_8 = val_8 & 4294967292;
        val_8 = 1 - val_8;
        if(val_8 >= 1)
        {
            goto label_14;
        }
        
        var val_11 = (val_38 < 0) ? (val_38 + 63) : (val_38);
        var val_12 = val_11 >> 6;
        System.Int32[] val_37 = val_5[(long)(val_11 >> 6) & 67108863];
        if(val_38 < 三丗丘万三东七三专.Length)
        {
            goto label_18;
        }
        
        var val_14 = (val_38 < 0) ? (val_38 + 3) : (val_38);
        val_14 = val_14 >> 2;
        var val_16 = (val_14 < 0) ? (val_14 + 15) : (val_14);
        val_16 = val_16 & 4294967280;
        val_14 = val_14 - val_16;
        val_37[((long)(int)(((0 < 0x0 ? (0 + 3) : 0 >> 2) - (val_14 < 0x0 ? ((0 < 0x0 ? (0 + 3) : 0 >> 2) + 15) : (0 < 0x0 ? (0 + 3) : 0 >> 2) & 4294967280)))) << 2] = 15;
        label_14:
        if(1 <= 255)
        {
            goto label_27;
        }
        
        goto label_22;
        label_18:
        if(三丗丘万三东七三专 != null)
        {
                val_31 = 三丗丘万三东七三专.Chars[0];
        }
        else
        {
                val_31 = 0.Chars[0];
        }
        
        var val_21 = (val_38 < 0) ? (val_38 + 3) : (val_38);
        val_21 = val_21 >> 2;
        var val_26 = val_21 - (((val_21 < 0) ? (val_21 + 15) : (val_21)) & 4294967280);
        val_38 = val_38 + 1;
        val_31 = (val_31 & 65535) - (((三丗丘万三东七三专.Chars[0] & 65535) < (':')) ? 48 : 87);
        val_37[((long)(int)(((0 < 0x0 ? (0 + 3) : 0 >> 2) - (val_21 < 0x0 ? ((0 < 0x0 ? (0 + 3) : 0 >> 2) + 15) : (0 < 0x0 ? (0 + 3) : 0 >> 2) & 4294967280)))) << 2] = val_31;
        if(val_38 <= 255)
        {
            goto label_27;
        }
        
        label_22:
        byte[] val_29 = new byte[64];
        label_43:
        var val_40 = 0;
        var val_31 = (val_40 < 0) ? (val_40 + 15) : (val_40);
        val_31 = val_31 & 4294967280;
        val_40 = val_40 - val_31;
        var val_32 = (long)val_40 | 1;
        var val_33 = (val_5[0x3] + 32) + (((long)(int)(((long)(int)((0 - (0 < 0x0 ? (0 + 15) : 0 & 4294967280))) | 1))) << 2);
        val_32 = ((val_5[0x3] + 32 + ((long)(int)(((long)(int)((0 - (0 < 0x0 ? (0 + 15) : 0 & 4294967280))) | 1))) << 2) + 32) + (val_5[3][((long)(int)((0 - (0 < 0x0 ? (0 + 15) : 0 & 4294967280)))) << 2]);
        new int[32][124] = val_32;
        if(31 >= val_6.Length)
        {
                val_32 = mem[val_6[0x7C] + 32];
            val_32 = val_6[0x7C] + 32;
        }
        
        val_33 = 0;
        goto label_38;
        label_41:
        val_32 = val_32 >> 3;
        val_33 = 1;
        val_29[0] = val_32 & 7;
        label_38:
        if(val_32 > 7)
        {
            goto label_41;
        }
        
        val_34 = 31 - 1;
        var val_35 = val_33 + 1;
        val_29[1] = val_32;
        if(31 > 0)
        {
            goto label_43;
        }
        
        char[] val_36 = new char[0];
        if(val_35 < 1)
        {
                return (System.Char[])val_36;
        }
        
        var val_43 = 0;
        do
        {
            long val_44 = 1;
            val_32 = val_29[val_44] + 48;
            mem2[0] = val_32;
            val_43 = val_43 + 1;
            val_44 = val_44 - 1;
        }
        while(val_35 != val_43);
        
        return (System.Char[])val_36;
    }
    private void 丒丝丒与丄丕三丁丒()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.万与丒丏东东丌丑丒, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 不丈丐丞丄丕丏丂丄::丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 下丅东丏与丛与三丌()
    {
        this.丟七东丌丞丝与丏丙.Clear();
    }
    private void 丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((this.世丂丁与不丁丈专上(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟)) != 0)
        {
                return;
        }
        
        if(不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上 == null)
        {
                return;
        }
        
        不丈丐丞丄丕丏丂丄.丛专万丄三不与丛上.Invoke();
    }
    private uint 世丂丁与不丁丈专上(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟)
    {
        object val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_17 = 东丞丒丙世丏三下丟;
        if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "err_code")) != false)
        {
                val_17 = 一丐丗丁丞丆丅丟丄.Item["err_code"];
            uint val_3 = System.Convert.ToUInt32(value:  val_17);
        }
        else
        {
                val_17 = 0;
        }
        
        var val_4 = (val_17 == 0) ? 1401 : (val_17);
        object val_5 = val_17.Item["rejectee_id"];
        if(val_5 == null)
        {
            goto label_8;
        }
        
        val_17 = (null == null) ? (val_5) : 0;
        if(一丐丗丁丞丆丅丟丄 != null)
        {
            goto label_33;
        }
        
        label_34:
        label_33:
        int val_7 = System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["req_id"]);
        if((this.丟七东丌丞丝与丏丙.ContainsKey(key:  val_7)) == false)
        {
            goto label_13;
        }
        
        val_18 = this.丟七东丌丞丝与丏丙.Item[val_7];
        bool val_10 = this.丟七东丌丞丝与丏丙.Remove(key:  val_7);
        if(val_4 == 0)
        {
            goto label_16;
        }
        
        label_19:
        if(val_18 == null)
        {
                return (uint)val_4;
        }
        
        val_19 = 0;
        goto label_18;
        label_13:
        val_18 = 0;
        if(val_4 != 0)
        {
            goto label_19;
        }
        
        label_16:
        丌且下丛三丟三业丑 val_11 = 丌且下丛三丟三业丑.丑七不且上丗丁一世();
        if((val_11.<万东三丐丑丄与丝世>k__BackingField.Contains(item:  val_17)) != false)
        {
                丌且下丛三丟三业丑 val_13 = 丌且下丛三丟三业丑.丑七不且上丗丁一世();
            bool val_14 = val_13.<万东三丐丑丄与丝世>k__BackingField.Remove(item:  val_17);
            FriendsWindowController.丆丕丝丒不丙且丐丗.下不世丞丞丝丟不丒();
        }
        
        丌丟丄专丂丒丁丛三 val_15 = 丌丟丄专丂丒丁丛三.丑七不且上丗丁一世();
        bool val_16 = val_15.<丙丒世专丞丄丛丏丕>k__BackingField.Remove(item:  val_17);
        if(val_18 == 0)
        {
                return (uint)val_4;
        }
        
        val_19 = 1;
        label_18:
        val_18.Invoke(东丏丂丙丑丁丞丞万:  true);
        return (uint)val_4;
        label_8:
        if(一丐丗丁丞丆丅丟丄 != null)
        {
            goto label_33;
        }
        
        goto label_34;
    }
    private int 丑不专丑不丌丁丙东(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_2;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return 0;
        }
        
        Rilisoft.WebSocket.WebSocketManager val_1 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_2 = null;
        val_2 = null;
        if(val_1 != null)
        {
                return val_1.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.万与丒丏东东丌丑丒, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        }
        
        return val_1.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.万与丒丏东东丌丑丒, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }

}
