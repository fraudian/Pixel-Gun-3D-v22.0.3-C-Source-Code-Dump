using UnityEngine;
internal class 丄三万丑丑东且丁丙
{
    // Fields
    private static 丄三万丑丑东且丁丙 世丒丞七专三与万丕;
    private readonly System.Collections.Generic.HashSet<string> 与丆丌丙且丏丛丆七;
    private static System.Action 丛专万丄三不与丛上;
    
    // Properties
    internal static 丄三万丑丑东且丁丙 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal 丄三万丑丑东且丁丙()
    {
        this.与丆丌丙且丏丛丆七 = new System.Collections.Generic.HashSet<System.String>();
        this.丒丝丒与丄丕三丁丒();
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丄三万丑丑东且丁丙::下丅东丏与丛与三丌()));
        ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丄三万丑丑东且丁丙::丕业丞丗丝上丕丘上()));
        丌且下丛三丟三业丑.丑丑不下丗丛上七三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void 丄三万丑丑东且丁丙::七丂与东不上丛上丕()));
    }
    private void 七丂与东不上丛上丕()
    {
        this.业且下丅丂丅东丆七();
    }
    internal static void 丙丌专东丌丏东丗丕()
    {
        丄三万丑丑东且丁丙 val_2;
        if(丄三万丑丑东且丁丙.世丒丞七专三与万丕 != null)
        {
                return;
        }
        
        丄三万丑丑东且丁丙 val_1 = null;
        val_2 = val_1;
        val_1 = new 丄三万丑丑东且丁丙();
        丄三万丑丑东且丁丙.世丒丞七专三与万丕 = val_2;
    }
    internal static 丄三万丑丑东且丁丙 丑七不且上丗丁一世()
    {
        丄三万丑丑东且丁丙.丙丌专东丌丏东丗丕();
        return (丄三万丑丑东且丁丙)丄三万丑丑东且丁丙.世丒丞七专三与万丕;
    }
    internal static void 丑丑不下丗丛上七三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  丄三万丑丑东且丁丙.丛专万丄三不与丛上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丄三万丑丑东且丁丙.丛专万丄三不与丛上 != 1152921505247850504);
    
    }
    internal static void 丑七七丌东不下上丁(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  丄三万丑丑东且丁丙.丛专万丄三不与丛上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(丄三万丑丑东且丁丙.丛专万丄三不与丛上 != 1152921505247850504);
    
    }
    internal void 丆丘丟且一丕丏世丒(object 专丂丕丗丗东世丞下, object 丕丗丘丑丛与丑业丒, object 丄丆万一丙丂丕不丐, bool 万丛丛专世丕世丙万)
    {
        var val_2;
        var val_3;
        double val_4;
        var val_5;
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        if(val_1 != null)
        {
                val_1.set_Item(key:  "to", value:  专丂丕丗丗东世丞下);
            val_1.set_Item(key:  "text", value:  丕丗丘丑丛与丑业丒);
        }
        else
        {
                val_1.set_Item(key:  "to", value:  专丂丕丗丗东世丞下);
            val_1.set_Item(key:  "text", value:  丕丗丘丑丛与丑业丒);
        }
        
        val_1.set_Item(key:  "timeStamp", value:  丄丆万一丙丂丕不丐);
        val_2 = null;
        if(万丛丛专世丕世丙万 != false)
        {
                val_3 = null;
            val_4 = 1152921505047212040;
        }
        else
        {
                val_5 = null;
            val_4 = 1152921505047212048;
        }
        
        val_1.set_Item(key:  "last_timeStamp", value:  val_4);
        object val_2 = ~万丛丛专世丕世丙万;
        val_2 = val_2 & 1;
        val_1.set_Item(key:  "clan", value:  val_2);
        val_1.丒丑丆丝一丒丘丅丕(一丐丗丁丞丆丅丟丄:  val_1);
    }
    private void 丂丌丌丁丈丐专丒与(System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟)
    {
        object val_8;
        var val_9;
        val_8 = 东丞丒丙世丏三下丟;
        if(val_8 == null)
        {
                return;
        }
        
        if((val_8.ContainsKey(key:  "clan")) != false)
        {
                val_8 = val_8.Item["clan"];
            val_9 = (System.Convert.ToBoolean(value:  val_8)) ^ 1;
        }
        else
        {
                val_9 = 1;
        }
        
        this.丆丘丟且一丕丏世丒(专丂丕丗丗东世丞下:  val_8.Item["to"], 丕丗丘丑丛与丑业丒:  val_8.Item["text"], 丄丆万一丙丂丕不丐:  val_8.Item["timeStamp"], 万丛丛专世丕世丙万:  val_9 & 1);
    }
    private void 丒丝丒与丄丕三丁丒()
    {
        null = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.七三丝业丛丗丐业东, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丄三万丑丑东且丁丙::丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丌且下丅丒东丗丆丕, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void 丄三万丑丑东且丁丙::丑丟与下丈业丝丒丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
    }
    private void 下丅东丏与丛与三丌()
    {
        int val_4;
        var val_8;
        var val_17;
        var val_18;
        int val_19;
        object val_20;
        var val_21;
        var val_22;
        var val_23;
        object val_24;
        int val_25;
        val_17 = null;
        val_17 = null;
        Dictionary.Enumerator<TKey, TValue> val_1 = ChatController.上上丅丏丙且专丙丆.GetEnumerator();
        val_18 = 0;
        val_19 = 0;
        var val_17 = 0;
        label_21:
        if(((-240615616) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        List.Enumerator<T> val_6 = val_5._value._obj.GetEnumerator();
        label_9:
        if(((-240615664) & 1) == 0)
        {
            goto label_6;
        }
        
        if(val_8.丐丏七丌丕丗业且上() != null)
        {
            
        }
        else
        {
                val_20 = 64;
        }
        
        val_4 = val_9.m_stringLength;
        this.丆丘丟且一丕丏世丒(专丂丕丗丗东世丞下:  val_5._value._obj.丐丏七丌丕丗业且上(), 丕丗丘丑丛与丑业丒:  val_20, 丄丆万一丙丂丕不丐:  val_4, 万丛丛专世丕世丙万:  true);
        goto label_9;
        label_6:
        val_17 = val_17 + 1;
        val_21 = val_19;
        mem2[0] = 100;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_17 == 1) || ((-240615776 + ((0 + 1)) << 2) != 100))
        {
            goto label_18;
        }
        
        var val_18 = 0;
        val_18 = val_18 ^ (val_17 >> 31);
        val_17 = val_17 + val_18;
        goto label_21;
        label_18:
        if( == 0)
        {
            goto label_21;
        }
        
        goto label_21;
        label_4:
        val_22 = val_17 + 1;
        mem2[0] = 125;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_17 != 1) && ((-240615776 + ((0 + 1)) << 2) == 125))
        {
                var val_19 = 0;
            val_19 = val_19 ^ (val_17 >> 31);
            val_22 = val_17 + val_19;
        }
        else
        {
                if( != 0)
        {
                val_19 = 0;
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        Dictionary.Enumerator<TKey, TValue> val_11 = ChatController.丕东丝丘丗丏不业七.GetEnumerator();
        label_51:
        if(((-240615616) & 1) == 0)
        {
            goto label_34;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_4.GetAwaiter();
        List.Enumerator<T> val_13 = val_12._value._obj.GetEnumerator();
        label_39:
        if(((-240615664) & 1) == 0)
        {
            goto label_36;
        }
        
        if(val_4.丐丏七丌丕丗业且上() != null)
        {
            
        }
        else
        {
                val_24 = 64;
        }
        
        val_4 = val_14.m_stringLength;
        this.丆丘丟且一丕丏世丒(专丂丕丗丗东世丞下:  val_12._value._obj.丐丏七丌丕丗业且上(), 丕丗丘丑丛与丑业丒:  val_24, 丄丆万一丙丂丕不丐:  val_4, 万丛丛专世丕世丙万:  false);
        goto label_39;
        label_36:
        val_17 = val_17 + 1;
        val_25 = val_19;
        mem2[0] = 229;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_17 == 1) || ((-240615776 + (((0 + 1) + 1)) << 2) != 229))
        {
            goto label_48;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ (val_17 >> 31);
        val_17 = val_17 + val_20;
        goto label_51;
        label_48:
        if( == 0)
        {
            goto label_51;
        }
        
        goto label_51;
        label_34:
        val_17 = val_17 + 1;
        mem2[0] = 254;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_17 == 1)
        {
            goto label_57;
        }
        
        if(( == 0) || ((-240615776 + (((0 + 1) + 1)) << 2) == 254))
        {
            goto label_64;
        }
        
        label_63:
        label_64:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                return;
        }
        
        this.丛丗丁万丟丏丘三丏();
        return;
        label_57:
        if( != 0)
        {
            goto label_63;
        }
        
        goto label_64;
    }
    private void 丕业丞丗丝上丕丘上()
    {
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        this.丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丌丂丑上七丄一且());
    }
    private void 丛丗丁万丟丏丘三丏()
    {
        if(this.与丆丌丙且丏丛丆七.Count == 0)
        {
                return;
        }
        
        this.与丆丌丙且丏丛丆七.Clear();
        this.丈且丑万丌专丗世世(丅下丏丙丞东丒丕丁:  System.Linq.Enumerable.ToList<System.String>(source:  this.与丆丌丙且丏丛丆七));
    }
    private void 丕丛丒丛世东丑丗不(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        this.丕上东七丐丒东东丞(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗);
    }
    private void 丕上东七丐丒东东丞(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        var val_6;
        PrivateClanChatController val_35;
        var val_36;
        var val_37;
        var val_38;
        string val_39;
        string val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        val_35 = 丏丂万业丙专丏丒丒;
        if(val_35 == null)
        {
                return;
        }
        
        if((val_35.ContainsKey(key:  "messages")) == false)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        val_36 = 0;
        val_37 = 0;
        var val_35 = 0;
        label_65:
        if(((-239999568) & 1) == 0)
        {
            goto label_9;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7 != null)
        {
                val_38 = null;
        }
        
        if(val_7 != null)
        {
                val_38 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_9 = GetEnumerator();
        goto label_41;
        label_43:
        ConfiguredValueTaskAwaiter val_11 = val_6.GetAwaiter();
        object val_12 = 0.Item["from"];
        if(val_12 == null)
        {
            goto label_20;
        }
        
        var val_13 = (null == null) ? (val_12) : 0;
        if(1 != 0)
        {
            goto label_21;
        }
        
        goto label_23;
        label_20:
        val_39 = 0;
        if(1 == 0)
        {
            goto label_23;
        }
        
        label_21:
        label_23:
        object val_14 = 0.Item["text"];
        if(val_14 != null)
        {
                var val_15 = (null == null) ? (val_14) : 0;
        }
        else
        {
                val_40 = 0;
        }
        
        if((System.Double.TryParse(s:  val_11._value._obj.丐丏七丌丕丗业且上(), style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_19 = 1.2882395136819E-231)) != true)
        {
                UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Could not parse message body key {0};    full response: {1}", arg0:  val_11._value._obj.丐丏七丌丕丗业且上(), arg1:  "(See code)"));
        }
        
        bool val_23 = 0.ContainsKey(key:  "clan");
        if(val_23 != false)
        {
                val_41 = (~(System.Convert.ToBoolean(value:  0.Item["clan"]))) & 1;
        }
        else
        {
                val_41 = 1;
        }
        
        val_23.东丌与丅丟丐丂丘丕(一丏一世丘丐丁丄丟:  (double)专七专下且专三一且.上且一丈丐三丄一丆(), 万丛丛专世丕世丙万:  true);
        val_23.丏且丒丙不丌丕七世(丑下专丞丛丈下丏业:  val_39, 丄丙下丝丛丒七丂丘:  val_40, 丟且丝丕一下丅丘不:  (double)专七专下且专三一且.上且一丈丐三丄一丆(), 万丛丛专世丕世丙万:  true);
        val_23.世丏东丛与专世丕且(丘丞七丌丑东丘丏丝:  1, 万丛丛专世丕世丙万:  true);
        var val_33 = 0;
        val_33 = val_33 | ((val_41 == 0) ? 1 : 0);
        var val_34 = 0;
        val_34 = val_34 | ((val_41 != 0) ? 1 : 0);
        label_41:
        if(((-239999616) & 1) != 0)
        {
            goto label_43;
        }
        
        val_35 = val_35 + 1;
        val_42 = val_37;
        mem2[0] = 301;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_35 == 1) || ((-239999712 + ((0 + 1)) << 2) != 301))
        {
            goto label_62;
        }
        
        var val_36 = 0;
        val_36 = val_36 ^ (val_35 >> 31);
        val_35 = val_35 + val_36;
        goto label_65;
        label_62:
        if( == 0)
        {
            goto label_65;
        }
        
        goto label_65;
        label_9:
        val_35 = val_35 + 1;
        mem2[0] = 329;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_35 == 1)
        {
            goto label_71;
        }
        
        if(( == 0) || ((-239999712 + ((0 + 1)) << 2) == 329))
        {
            goto label_96;
        }
        
        label_95:
        label_96:
        下上丂丆丌一东丏东();
        if(PrivateChatController.丄丞丁丈与业上丞丟 != 0)
        {
                val_43 = PrivateChatController.丄丞丁丈与业上丞丟.东丒丝丘万一丆世专();
        }
        else
        {
                val_43 = 0;
        }
        
        val_43 = val_43 & val_34;
        if(val_43 != 0)
        {
                ChatController.七三丒丅业业丄与一();
            PrivateChatController.丄丞丁丈与业上丞丟.UpdateFriendItemsInfoAndSort();
            PrivateChatController.丄丞丁丈与业上丞丟.UpdateMessageForSelectedUsers(丗丆丄世世万丛丆丈:  false);
        }
        
        val_35 = PrivateClanChatController.丆丕丝丒不丙且丐丗;
        if(val_35 != 0)
        {
                val_35 = PrivateClanChatController.丆丕丝丒不丙且丐丗;
            val_44 = val_35.东丒丝丘万一丆世专();
        }
        else
        {
                val_44 = 0;
        }
        
        val_44 = val_44 & val_33;
        if(val_44 != 0)
        {
                ChatController.丁一三丙丁丝丕丄丗();
            val_35 = PrivateClanChatController.丆丕丝丒不丙且丐丗;
            val_35.UpdateFriendItemsInfoAndSort();
        }
        
        if(((val_33 | val_34) & 1) == 0)
        {
                return;
        }
        
        if(丄三万丑丑东且丁丙.丛专万丄三不与丛上 == null)
        {
                return;
        }
        
        丄三万丑丑东且丁丙.丛专万丄三不与丛上.Invoke();
        return;
        label_71:
        if( != 0)
        {
            goto label_95;
        }
        
        goto label_96;
    }
    private void 业且下丅丂丅东丆七()
    {
        var val_5;
        string val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>> val_21;
        var val_22;
        var val_23;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_19 = null;
        val_19 = null;
        if(ChatController.丝丞不丘丞丐丌丅东 == null)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_1 = null;
        val_18 = val_1;
        val_1 = new System.Collections.Generic.List<System.String>();
        val_20 = null;
        val_20 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = ChatController.丝丞不丘丞丐丌丅东.GetEnumerator();
        val_21 = 0;
        val_22 = 0;
        var val_18 = 0;
        label_29:
        if(((-239816928) & 1) == 0)
        {
            goto label_7;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if((丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上().Contains(item:  val_6._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_29;
        }
        
        List.Enumerator<T> val_11 = val_6._value._obj.GetEnumerator();
        goto label_16;
        label_19:
        string val_12 = val_5.丐丏七丌丕丗业且上();
        if((public 业丙丅世丘东丛丄丕 List.Enumerator<业丙丅世丘东丛丄丕>::get_Current()) == 0)
        {
                val_23 = null;
            val_23 = null;
            int val_17 = ChatController.丑万丂世丛丙万丝丛;
            val_17 = val_17 - 1;
            ChatController.丑万丂世丛丙万丝丛 = val_17;
        }
        
        label_16:
        if(((-239816976) & 1) != 0)
        {
            goto label_19;
        }
        
        val_18 = val_18 + 1;
        mem2[0] = 126;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_18 != 1) && ((-239817072 + ((0 + 1)) << 2) == 126))
        {
                var val_19 = 0;
            val_19 = val_19 ^ (val_18 >> 31);
            val_18 = val_18 + val_19;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_1.Add(item:  val_6._value._obj.丐丏七丌丕丗业且上());
        goto label_29;
        label_7:
        val_27 = -239817072;
        val_28 = val_18 + 1;
        mem2[0] = 164;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_28 == 1) || ((val_27 + ((0 + 1)) << 2) != 164))
        {
            goto label_42;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ (val_28 >> 31);
        val_28 = val_28 + val_20;
        if(val_18 != null)
        {
            goto label_46;
        }
        
        goto label_44;
        label_42:
        if( != 0)
        {
                val_29 = 0;
        }
        
        if(val_18 != null)
        {
            goto label_46;
        }
        
        label_44:
        label_46:
        List.Enumerator<T> val_14 = val_1.GetEnumerator();
        val_30 = 0;
        goto label_47;
        label_51:
        val_18 = 0.丐丏七丌丕丗业且上();
        val_31 = null;
        val_31 = null;
        val_21 = ChatController.丝丞不丘丞丐丌丅东;
        val_30 = val_30 | (val_21.Remove(key:  val_18));
        label_47:
        if(((-239817000) & 1) != 0)
        {
            goto label_51;
        }
        
        val_28 = val_28 + 1;
        mem2[0] = 225;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_28 == 1)
        {
            goto label_56;
        }
        
        if(( == 0) || ((val_27 + (((0 + 1) + 1)) << 2) == 225))
        {
            goto label_63;
        }
        
        label_62:
        label_63:
        if(val_30 == false)
        {
                return;
        }
        
        ChatController.七三丒丅业业丄与一();
        return;
        label_56:
        if( != 0)
        {
            goto label_62;
        }
        
        goto label_63;
    }
    internal void 下上丂丆丌一东丏东()
    {
        var val_11;
        var val_24;
        System.Collections.Generic.List<T> val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_33;
        var val_34;
        var val_35;
        val_24 = 1152921524404748272;
        val_25 = Rilisoft.Singleton<ClansController>.Instance;
        if(val_25.丞丗丑丈一丅丗丌丟() == null)
        {
                return;
        }
        
        val_25 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丂丄丏下七与一丌();
        if(val_25.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
        val_26 = null;
        val_26 = null;
        Dictionary.Enumerator<TKey, TValue> val_8 = ChatController.丝三下丙七丈七丏丙.GetEnumerator();
        val_27 = 0;
        val_28 = 0;
        var val_24 = 0;
        label_30:
        if(((-239627104) & 1) == 0)
        {
            goto label_10;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_11.GetAwaiter();
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丕一下丒丝世下丘万(丞丅上丏丂且下丅与:  val_12._value._obj.丐丏七丌丕丗业且上())) == true)
        {
            goto label_30;
        }
        
        List.Enumerator<T> val_17 = val_12._value._obj.GetEnumerator();
        goto label_17;
        label_20:
        string val_18 = val_11.丐丏七丌丕丗业且上();
        if((public 业丙丅世丘东丛丄丕 List.Enumerator<业丙丅世丘东丛丄丕>::get_Current()) == 0)
        {
                val_29 = null;
            val_29 = null;
            int val_23 = ChatController.丑万丂世丛丙万丝丛;
            val_23 = val_23 - 1;
            ChatController.丑万丂世丛丙万丝丛 = val_23;
        }
        
        label_17:
        if(((-239627152) & 1) != 0)
        {
            goto label_20;
        }
        
        val_24 = val_24 + 1;
        mem2[0] = 152;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_24 != 1) && ((1152921538726958096 + ((0 + 1)) << 2) == 152))
        {
                var val_25 = 0;
            val_25 = val_25 ^ (val_24 >> 31);
            val_24 = val_24 + val_25;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_7.Add(item:  val_12._value._obj.丐丏七丌丕丗业且上());
        goto label_30;
        label_10:
        val_33 = val_24 + 1;
        mem2[0] = 190;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_33 != 1) && ((1152921538726958096 + ((0 + 1)) << 2) == 190))
        {
                var val_26 = 0;
            val_26 = val_26 ^ (val_33 >> 31);
            val_33 = val_33 + val_26;
        }
        else
        {
                if( != 0)
        {
                val_34 = 0;
        }
        
        }
        
        val_25 = val_7;
        List.Enumerator<T> val_20 = val_7.GetEnumerator();
        val_24 = 1152921538726751440;
        label_51:
        if(((-239627176) & 1) == 0)
        {
            goto label_47;
        }
        
        val_35 = null;
        val_35 = null;
        bool val_22 = ChatController.丝三下丙七丈七丏丙.Remove(key:  0.丐丏七丌丕丗业且上());
        goto label_51;
        label_47:
        val_33 = val_33 + 1;
        mem2[0] = 247;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_33 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921538726958096 + (((0 + 1) + 1)) << 2) == 247)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    private void 丏且丒丙不丌丕七世(string 丑下专丞丛丈下丏业, string 丄丙下丝丛丒七丂丘, double 丟且丝丕一下丅丘不, bool 万丛丛专世丕世丙万)
    {
        ChatController.业丙丅世丘东丛丄丕 val_1 = new ChatController.业丙丅世丘东丛丄丕(专丙上丏世一丛世世:  丑下专丞丛丈下丏业, 下丘与业丗丙且业丑:  丄丙下丝丛丒七丂丘, 专丐三丒下东丕世丟:  丟且丝丕一下丅丘不, 丄丘下丕丘丁丁三丕:  true, 丗下上丆一丕丂三丑:  false);
        if(万丛丛专世丕世丙万 != false)
        {
                ChatController.丕丙东丙丄业丅丆丕(丒丘不丌丂下丙丂丏:  丑下专丞丛丈下丏业, 下丘与业丗丙且业丑:  val_1);
            return;
        }
        
        ChatController.三丘与丈丌丑七丆业(丒丘不丌丂下丙丂丏:  丑下专丞丛丈下丏业, 下丘与业丗丙且业丑:  val_1);
    }
    private void 东丌与丅丟丐丂丘丕(double 一丏一世丘丐丁丄丟, bool 万丛丛专世丕世丙万)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        if(万丛丛专世丕世丙万 != false)
        {
                val_4 = null;
            ChatController.七世丙三丆与丞丑一 = System.Math.Max(val1:  一丏一世丘丐丁丄丟, val2:  ChatController.七世丙三丆与丞丑一);
            return;
        }
        
        val_5 = null;
        ChatController.丆东与丄业且丗丑世 = System.Math.Max(val1:  一丏一世丘丐丁丄丟, val2:  ChatController.丆东与丄业且丗丑世);
    }
    private void 世丏东丛与专世丕且(int 丘丞七丌丑东丘丏丝, bool 万丛丛专世丕世丙万)
    {
        if(万丛丛专世丕世丙万 != false)
        {
                null = null;
            int val_2 = ChatController.丑万丂世丛丙万丝丛;
            val_2 = val_2 + 丘丞七丌丑东丘丏丝;
            ChatController.丑万丂世丛丙万丝丛 = val_2;
            return;
        }
        
        int val_1 = ChatController.丂丐丛丁丆丞七丛丂();
        val_1 = val_1 + 丘丞七丌丑东丘丏丝;
        ChatController.丅丐丙丂丆东万丕下(丙业与丙丗丝不丈东:  val_1);
    }
    private void 丑丟与下丈业丝丒丕(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((this.丕丌东专丌丌专丞丆(丑与丂丌世丕丆一丗:  丑与丂丌世丕丆一丗, 东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟, 丁不七丙下七丐与不:  丁不七丙下七丐与不)) != 10)
        {
                return;
        }
        
        this.丂丌丌丁丈丐专丒与(东丞丒丙世丏三下丟:  东丞丒丙世丏三下丟);
    }
    private uint 丕丌东专丌丌专丞丆(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        object val_28;
        object val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_29 = 东丞丒丙世丏三下丟;
        if(丑与丂丌世丕丆一丗 == null)
        {
            goto label_6;
        }
        
        val_30 = 1;
        if(val_29 == null)
        {
                return (uint)val_30;
        }
        
        if(丑与丂丌世丕丆一丗.Count == 0)
        {
                return (uint)val_30;
        }
        
        if((丑与丂丌世丕丆一丗.TryGetValue(key:  "err_code", value: out  0)) != false)
        {
                val_30 = 10;
            return (uint)val_30;
        }
        
        val_28 = "timeStamp";
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "timeStamp")) == false)
        {
            goto label_6;
        }
        
        object val_5 = 丑与丂丌世丕丆一丗.Item["timeStamp"];
        object val_6 = val_29.Item["timeStamp"];
        if((System.Double.TryParse(s:  val_6, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_8 = 1.28823951399061E-231)) == false)
        {
            goto label_13;
        }
        
        val_31 = null;
        val_31 = null;
        bool val_13 = 丌且下丅丒东丗丆丕(丄丌丗丐丞丈业专丐:  0, 上万上下丏世上三丆:  val_5, 丐丂东丈一丁世上丕:  new System.Action<System.String, 业丙丅世丘东丛丄丕>(object:  0, method:  static System.Void ChatController::丕丙东丙丄业丅丆丕(string 丒丘不丌丂下丙丂丏, ChatController.业丙丅世丘东丛丄丕 下丘与业丗丙且业丑)), 丅丛丌不丗丏丞丝丌: ref  1152921505047212104, 丄不且丐丄专丛一丙: ref  1152921505047212040);
        System.Action<System.String, 业丙丅世丘东丛丄丕> val_14 = new System.Action<System.String, 业丙丅世丘东丛丄丕>(object:  0, method:  static System.Void ChatController::三丘与丈丌丑七丆业(string 丒丘不丌丂下丙丂丏, ChatController.业丙丅世丘东丛丄丕 下丘与业丗丙且业丑));
        bool val_17 = val_14.丌且下丅丒东丗丆丕(丄丌丗丐丞丈业专丐:  0, 上万上下丏世上三丆:  val_5, 丐丂东丈一丁世上丕:  val_14, 丅丛丌不丗丏丞丝丌: ref  1152921505047212120, 丄不且丐丄专丛一丙: ref  1152921505047212048);
        if(PrivateChatController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_18;
        }
        
        val_32 = PrivateChatController.丄丞丁丈与业上丞丟.东丒丝丘万一丆世专();
        goto label_20;
        label_13:
        val_28 = System.Globalization.CultureInfo.CurrentUICulture;
        val_29 = System.String.Format(format:  "Could not parse timestamp {0}    Current culture: {1}, current UI culture: {2}", arg0:  val_6, arg1:  System.Globalization.CultureInfo.CurrentCulture, arg2:  val_28);
        UnityEngine.Debug.LogWarning(message:  val_29);
        label_6:
        val_30 = 1;
        return (uint)val_30;
        label_18:
        val_32 = 0;
        label_20:
        val_32 = val_32 & val_13;
        if(val_32 != false)
        {
                ChatController.七三丒丅业业丄与一();
            PrivateChatController.丄丞丁丈与业上丞丟.UpdateMessageForSelectedUsers(丗丆丄世世万丛丆丈:  false);
        }
        
        if(PrivateClanChatController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_33 = PrivateClanChatController.丆丕丝丒不丙且丐丗.东丒丝丘万一丆世专();
        }
        else
        {
                val_33 = 0;
        }
        
        val_33 = val_33 & val_17;
        if(val_33 != false)
        {
                ChatController.丁一三丙丁丝丕丄丗();
        }
        
        if((val_13 | val_17) == false)
        {
                return (uint)val_30;
        }
        
        if(丄三万丑丑东且丁丙.丛专万丄三不与丛上 == null)
        {
                return (uint)val_30;
        }
        
        丄三万丑丑东且丁丙.丛专万丄三不与丛上.Invoke();
        return (uint)val_30;
    }
    private bool 丌且下丅丒东丗丆丕(double 丄丌丗丐丞丈业专丐, string 上万上下丏世上三丆, System.Action<string, ChatController.业丙丅世丘东丛丄丕> 丐丂东丈一丁世上丕, ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<ChatController.业丙丅世丘东丛丄丕>> 丅丛丌不丗丏丞丝丌, ref double 丄不且丐丄专丛一丙)
    {
        var val_4;
        double val_17;
        object val_18;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<业丙丅世丘东丛丄丕>> val_19;
        System.Predicate<业丙丅世丘东丛丄丕> val_20;
        double val_21;
        var val_22;
        string val_23;
        val_17 = 丄丌丗丐丞丈业专丐;
        丄三万丑丑东且丁丙.丄丆丌丌丕丈丆丆业 val_1 = null;
        val_18 = val_1;
        val_1 = new 丄三万丑丑东且丁丙.丄丆丌丌丕丈丆丆业();
        .丄丌丗丐丞丈业专丐 = val_17;
        val_19 = 丅丛丌不丗丏丞丝丌;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_19.GetEnumerator();
        label_8:
        if(((-238708208) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_4.GetAwaiter();
        val_20 = (丄三万丑丑东且丁丙.丄丆丌丌丕丈丆丆业)[1152921538727937584].上丌丘丑一且丆且丏;
        if(val_20 == null)
        {
            goto label_4;
        }
        
        if(val_6._value._obj != 0)
        {
            goto label_7;
        }
        
        goto label_6;
        label_4:
        val_20 = null;
        val_20 = new System.Predicate<业丙丅世丘东丛丄丕>(object:  val_1, method:  System.Boolean 丄三万丑丑东且丁丙.丄丆丌丌丕丈丆丆业::丐丈丝丘一丆且丄丂(ChatController.业丙丅世丘东丛丄丕 三丟东丕丄丄下下丑));
        .上丌丘丑一且丆且丏 = val_20;
        if(val_6._value._obj != 0)
        {
            goto label_7;
        }
        
        label_6:
        label_7:
        val_19 = val_6._value._obj.FindIndex(match:  null);
        if(val_19 == 1)
        {
            goto label_8;
        }
        
        业丙丅世丘东丛丄丕 val_9 = val_6._value._obj.Item[val_19];
        if((System.Double.TryParse(s:  上万上下丏世上三丆, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  double val_11 = 1.2882395140513E-231)) == false)
        {
            goto label_14;
        }
        
        if(val_9 == null)
        {
            goto label_15;
        }
        
        val_21 = 0;
        goto label_16;
        label_3:
        val_22 = 0;
        goto label_17;
        label_15:
        val_21 = 0;
        label_16:
        mem2[0] = 0;
        mem2[0] = System.Math.Max(val1:  val_21, val2:  丄不且丐丄专丛一丙);
        label_14:
        if(val_9 != null)
        {
                val_23 = val_9.丄丙下丝丛丒七丂丘;
        }
        else
        {
                val_23 = 64;
        }
        
        val_18 = new ChatController.业丙丅世丘东丛丄丕();
        val_18 = new ChatController.业丙丅世丘东丛丄丕(专丙上丏世一丛世世:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 下丘与业丗丙且业丑:  val_23, 专丐三丒下东丕世丟:  val_21, 丄丘下丕丘丁丁三丕:  true, 丗下上丆一丕丂三丑:  true);
        if(丐丂东丈一丁世上丕 != 0)
        {
                丐丂东丈一丁世上丕.Invoke(arg1:  val_6._value._obj.丐丏七丌丕丗业且上(), arg2:  new ChatController.业丙丅世丘东丛丄丕());
        }
        
        val_6._value._obj.RemoveAt(index:  val_19);
        val_22 = 1;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_22;
    }
    private void 丒丑丆丝一丒丘丅丕(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_3;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        int val_2 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丌且下丅丒东丗丆丕, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
    }
    internal void 丈且丑万丌专丗世世(System.Collections.Generic.List<string> 丅下丏丙丞东丒丕丁)
    {
        object val_15;
        string val_16;
        System.Collections.Generic.HashSet<System.String> val_17;
        var val_18;
        var val_19;
        val_16 = this;
        if(丅下丏丙丞东丒丕丁 == null)
        {
                return;
        }
        
        if(丅下丏丙丞东丒丕丁.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_2 = null;
        val_15 = val_2;
        val_2 = new System.Collections.Generic.List<System.String>();
        if(丅下丏丙丞东丒丕丁.Count >= 1)
        {
                var val_15 = 0;
            do
        {
            val_17 = this.与丆丌丙且丏丛丆七;
            if((val_17.Contains(item:  丅下丏丙丞东丒丕丁.Item[0])) != true)
        {
                bool val_7 = this.与丆丌丙且丏丛丆七.Add(item:  丅下丏丙丞东丒丕丁.Item[0]);
            val_17 = 丅下丏丙丞东丒丕丁.Item[0];
            val_2.Add(item:  val_17);
        }
        
            val_15 = val_15 + 1;
        }
        while(val_15 < 丅下丏丙丞东丒丕丁.Count);
        
        }
        
        if(val_2.Count == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_11 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_11.set_Item(key:  "list", value:  val_2);
        val_18 = null;
        val_18 = null;
        val_11.set_Item(key:  "last_timeStamp", value:  System.Math.Max(val1:  ChatController.七世丙三丆与丞丑一, val2:  ChatController.丆东与丄业且丗丑世));
        val_15 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        val_19 = null;
        val_19 = null;
        val_16 = Rilisoft.WebSocket.业丛世业世不丄丐三.七三丝业丛丗丐业东;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_14 = val_15.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  val_16, 一丐丗丁丞丆丅丟丄:  val_11);
    }
    internal void 丅丌丁专专东世丌丕(System.Collections.Generic.List<string> 丅下丏丙丞东丒丕丁)
    {
        var val_9;
        if(丅下丏丙丞东丒丕丁 == null)
        {
                return;
        }
        
        if(丅下丏丙丞东丒丕丁.Count == 0)
        {
                return;
        }
        
        if(丅下丏丙丞东丒丕丁.Count >= 1)
        {
                var val_9 = 0;
            do
        {
            bool val_4 = this.与丆丌丙且丏丛丆七.Remove(item:  丅下丏丙丞东丒丕丁.Item[0]);
            val_9 = val_9 + 1;
        }
        while(val_9 < 丅下丏丙丞东丒丕丁.Count);
        
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_6 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_6.set_Item(key:  "list", value:  丅下丏丙丞东丒丕丁);
        val_9 = null;
        val_9 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_8 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.七三丝业丛丗丐业东, 一丐丗丁丞丆丅丟丄:  val_6);
    }
    internal void 丝丑丛万丟丝三上世()
    {
        var val_5;
        this.与丆丌丙且丏丛丆七.Clear();
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        System.Collections.Generic.List<System.Object> val_2 = new System.Collections.Generic.List<System.Object>();
        val_2.Add(item:  "-1");
        val_1.set_Item(key:  "list", value:  val_2);
        val_5 = null;
        val_5 = null;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_4 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丆丞丅三丛丞东专丁(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.七三丝业丛丗丐业东, 一丐丗丁丞丆丅丟丄:  val_1);
    }

}
