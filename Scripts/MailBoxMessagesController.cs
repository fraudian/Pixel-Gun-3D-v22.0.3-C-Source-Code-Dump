using UnityEngine;
internal sealed class MailBoxMessagesController : PGBehaviour
{
    // Fields
    private static System.Action<int> 丞丂上丙与丟下丂上;
    internal static MailBoxMessagesController 丄丞丁丈与业上丞丟;
    private System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 不丑丆七丙丏丑丐世;
    private string 丅丂丝丑丁丌丟丂丞;
    private bool 丑上不专七且业丑与;
    private bool 丌世三丗丏丝丂丒万;
    private int <世丂上业上丗丛与丞>k__BackingField;
    
    // Properties
    internal System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 下丝下丕丐丂丁丌丏 { get; set; }
    internal int 丕万七世丞专世丏丗 { get; set; }
    
    // Methods
    internal static void 丗下东丝丛丞丑丗丕(System.Action<int> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  MailBoxMessagesController.丞丂上丙与丟下丂上, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丈丈丒万下上专丟万(System.Action<int> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  MailBoxMessagesController.丞丂上丙与丟下丂上, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 业丗与世东丗丒世专()
    {
        return (System.Collections.Generic.List<丏不一丏丗丗丗丈丞>)this.不丑丆七丙丏丑丐世;
    }
    internal void 不丝丟一丛丒业东丁(System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东.Sort(comparer:  new PGCompany.万丝与丏一三丄丒丞());
        this.不丑丆七丙丏丑丐世 = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        MailBoxMessagesController.丄丞丁丈与业上丞丟 = this;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() != false)
        {
                this.丘丏丅业不业丙丏一();
        }
        
        业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxMessagesController::丈与丄下且万丙丗丌()));
        I2.Loc.丗丈下丕丟丟丙七丞.丒一且丕七丅世与下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxMessagesController::丆丛丆丟丆丒丝万不()));
    }
    private void OnDestroy()
    {
        MailBoxMessagesController.丄丞丁丈与业上丞丟 = 0;
        业丞丝东丅丞丐丌专.丛丂不丗丙丘丝丘丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxMessagesController::丈与丄下且万丙丗丌()));
        I2.Loc.丗丈下丕丟丟丙七丞.丂丂专三下丘丁丐丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MailBoxMessagesController::丆丛丆丟丆丒丝万不()));
    }
    private void 丆丛丆丟丆丒丝万不()
    {
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_1 = this.且丈丌不丐且丆丁专();
    }
    private void 丘丏丅业不业丙丏一()
    {
        object val_13;
        object val_14;
        var val_15;
        val_13 = this;
        if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
        {
                return;
        }
        
        val_14 = ProtocolListGetter.丅三专丐丗丅与丆丑();
        if(val_14 <= 3)
        {
                if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
            goto label_8;
        }
        
        }
        
        val_14 = 0;
        label_8:
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_5 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_5.Add(key:  "platform", value:  val_14);
        val_15 = null;
        val_15 = null;
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.三东且丘业世丝业上, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MailBoxMessagesController::专上下丝世世丅丐且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丒不丅世丁上下丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MailBoxMessagesController::丂东不世丂丟且丂丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丕三下上丙丒七丒且, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MailBoxMessagesController::丞一不丗丌丁世丁丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        this.丑上不专七且业丑与 = true;
        this.丌世三丗丏丝丂丒万 = true;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.三东且丘业世丝业上, 一丐丗丁丞丆丅丟丄:  val_5);
        val_13 = Rilisoft.WebSocket.业丛世业世不丄丐三.丕三下上丙丒七丒且;
        System.Threading.Tasks.Task<Rilisoft.WebSocket.下七专丌且丛丘且丐> val_12 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.不丈一丅丆丌丞一丐(丈丂丒丄丘丕丌上与:  val_13, 一丐丗丁丞丆丅丟丄:  val_5);
    }
    private void 丈与丄下且万丙丗丌()
    {
        this.丘丏丅业不业丙丏一();
    }
    private void 专上下丝世世丅丐且(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        this.丈丕专丗丏丆万三丅(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 丅丂东丛丟万与丒丟:  false);
    }
    private void 丞一不丗丌丁世丁丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        this.丈丕专丗丏丆万三丅(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗, 丅丂东丛丟万与丒丟:  true);
    }
    private void 丂东不世丂丟且丂丝(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
    {
        if((丑与丂丌世丕丆一丗.ContainsKey(key:  "news")) == false)
        {
                return;
        }
        
        if(丑与丂丌世丕丆一丗.Item["news"] == null)
        {
                return;
        }
    
    }
    internal void 丕世不七万丑丛东丏(System.Collections.Generic.Dictionary<string, object> 丅丑世不世万丟丕三)
    {
        var val_5;
        var val_15;
        var val_16;
        MailBoxMessagesController val_17;
        var val_18;
        UnityEngine.Object val_19;
        var val_20;
        var val_21;
        val_16 = 丅丑世不世万丟丕三;
        this.不丑丆七丙丏丑丐世.Clear();
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_1 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        if(val_16 == null)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_2 = val_16.GetEnumerator();
        label_9:
        if(((-682994304) & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        new 丏不一丏丗丗丗丈丞() = new 丏不一丏丗丗丗丈丞(丄丙下丝丛丒七丂丘:  val_6._value._obj, 丏三丐丙与丝丁丄丑:  System.Convert.ToInt32(value:  val_6._value._obj.丐丏七丌丕丗业且上()));
        if((new 丏不一丏丗丗丗丈丞() == null) || ((丏不一丏丗丗丗丈丞)[1152921538283651568].TypeNews == 0))
        {
            goto label_9;
        }
        
        val_1.Add(item:  new 丏不一丏丗丗丗丈丞());
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_17 = this;
        this.丙专万丟专下丅丌业(三丝万与丘世丑丟丆:  this.三丄专东世世丟且丕(丛与丑业丟丂丙丒丘:  val_1));
        val_15 = 1152921505566695424;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟 != val_19)
        {
                val_20 = null;
            val_20 = null;
            val_19 = 0;
            if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丅与丌专丟一丝业三().activeSelf != false)
        {
                val_21 = null;
            val_21 = null;
            val_19 = 1;
            PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丛丘丗丟世丂一东一(七三丞丘丟下丛丛不:  true);
        }
        
        }
        
        this.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  val_19);
    }
    private System.Collections.Generic.Dictionary<int, int> 丄下专七丘专一丕上(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
    {
        var val_7;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_3 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        Dictionary.Enumerator<TKey, TValue> val_4 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
        val_21 = 0;
        val_22 = 0;
        val_23 = 0;
        goto label_38;
        label_41:
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        List.Enumerator<T> val_9 = this.且丈丌不丐且丆丁专().GetEnumerator();
        label_8:
        if(((-682812720) & 1) == 0)
        {
            goto label_4;
        }
        
        val_24 = val_7.丐丏七丌丕丗业且上();
        if(val_10.m_stringLength != (System.Convert.ToInt32(value:  val_8._value._obj.丐丏七丌丕丗业且上())))
        {
            goto label_8;
        }
        
        goto label_9;
        label_4:
        val_24 = 0;
        label_9:
        val_23 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_23 == 1) || (114 != 114))
        {
            goto label_16;
        }
        
        var val_20 = 0;
        val_20 = val_20 ^ 0;
        val_23 = val_23 + val_20;
        if( != 0)
        {
            goto label_39;
        }
        
        label_40:
        val_24 = System.Convert.ToInt32(value:  val_8._value._obj.丐丏七丌丕丗业且上());
        val_2.Add(key:  val_24, value:  0);
        goto label_38;
        label_16:
        if( == 0)
        {
            goto label_22;
        }
        
        val_21 = 0;
        val_22 = 0;
        if( == 0)
        {
            goto label_40;
        }
        
        label_39:
        int val_15 = System.Convert.ToInt32(value:  val_8._value._obj);
        if(((丞东丑专丛丆丄丝世.丒丕丅丄丗丝专丑且(丞丅上丏丂且下丅与:  val_15)) == false) || (val_15 <= 0))
        {
            goto label_29;
        }
        
        val_24 = System.Convert.ToInt32(value:  val_8._value._obj.丐丏七丌丕丗业且上());
        val_2.Add(key:  val_24, value:  1);
        goto label_38;
        label_29:
        if((丞东丑专丛丆丄丝世.丂七丗丐世业丘丏不(丞丅上丏丂且下丅与:  val_15)) == false)
        {
            goto label_38;
        }
        
        val_3.Add(item:  null);
        goto label_38;
        label_22:
        if( != 0)
        {
            goto label_39;
        }
        
        goto label_40;
        label_38:
        if(((-682812672) & 1) != 0)
        {
            goto label_41;
        }
        
        val_23 = val_23 + 1;
        mem2[0] = 239;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_23 == 1)
        {
            goto label_56;
        }
        
        if(( == 0) || (114 == 239))
        {
            goto label_60;
        }
        
        label_59:
        label_60:
        this.丘三丁七丁丐世七丈(七与丐上专世世丏丘:  val_3);
        return val_2;
        label_56:
        if( != 0)
        {
            goto label_59;
        }
        
        goto label_60;
    }
    private void 丝丛丄丆与万丘丕世(System.Collections.Generic.List<int> 丏丑且丒丈丅丞丙与)
    {
        var val_5;
        if(丏丑且丒丈丅丞丙与.Count < 1)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        val_2.Add(key:  "ids", value:  丏丑且丒丈丅丞丙与);
        val_5 = null;
        val_5 = null;
        int val_4 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丈丒不丅世丁上下丑, 一丐丗丁丞丆丅丟丄:  val_2);
    }
    private void 丈丕专丗丏丆万三丅(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, bool 丅丂东丛丟万与丒丟)
    {
        if((this.丑上不专七且业丑与 != false) && (丅丂东丛丟万与丒丟 != false))
        {
                this.上丄三万东丐丝丄丞(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丅丂东丛丟万与丒丟:  true);
            this.丑上不专七且业丑与 = false;
        }
        
        if((this.丌世三丗丏丝丂丒万 != false) && (丅丂东丛丟万与丒丟 != true))
        {
                this.上丄三万东丐丝丄丞(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄, 丅丂东丛丟万与丒丟:  false);
            this.丌世三丗丏丝丂丒万 = false;
        }
        
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Int32>(source:  this.丄下专七丘专一丕上(一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄).Keys);
        val_3.丝丛丄丆与万丘丕世(丏丑且丒丈丅丞丙与:  val_3);
    }
    private void 上丄三万东丐丝丄丞(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄, bool 丅丂东丛丟万与丒丟)
    {
        var val_5;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_2 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        List.Enumerator<T> val_3 = this.且丈丌不丐且丆丁专().GetEnumerator();
        val_14 = 0;
        val_15 = 0;
        var val_15 = 0;
        label_31:
        if(((-682365040) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        Dictionary.Enumerator<TKey, TValue> val_7 = 一丐丗丁丞丆丅丟丄.GetEnumerator();
        label_8:
        if(((-682365088) & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_9 = val_5.GetAwaiter();
        if(val_6.m_stringLength != (System.Convert.ToInt32(value:  val_9._value._obj.丐丏七丌丕丗业且上())))
        {
            goto label_8;
        }
        
        val_16 = val_15 + 1;
        val_17 = 1;
        mem2[0] = 102;
        goto label_10;
        label_4:
        val_16 = val_15 + 1;
        val_17 = 0;
        mem2[0] = 102;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_16 == 1) || ((-682365200 + ((0 + 1)) << 2) != 102))
        {
            goto label_16;
        }
        
        var val_14 = 0;
        val_14 = val_14 ^ (val_16 >> 31);
        val_16 = val_16 + val_14;
        if(( & 1) != 0)
        {
            goto label_31;
        }
        
        goto label_21;
        label_16:
        if( == 0)
        {
            goto label_19;
        }
        
        if(( & 1) != 0)
        {
            goto label_31;
        }
        
        goto label_21;
        label_19:
        if(( & 1) != 0)
        {
            goto label_31;
        }
        
        label_21:
        if(丅丂东丛丟万与丒丟 == false)
        {
            goto label_23;
        }
        
        if(val_6.七下业丈业丙丆上丌() == false)
        {
            goto label_31;
        }
        
        val_2.Add(item:  val_6);
        goto label_31;
        label_23:
        if(val_6.七下业丈业丙丆上丌() == true)
        {
            goto label_31;
        }
        
        val_2.Add(item:  val_6);
        goto label_31;
        label_2:
        val_15 = val_15 + 1;
        mem2[0] = 176;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_16 == 1)
        {
            goto label_40;
        }
        
        if(( == 0) || ((-682365200 + ((0 + 1)) << 2) == 176))
        {
            goto label_44;
        }
        
        label_43:
        label_44:
        this.丘三丁七丁丐世七丈(七与丐上专世世丏丘:  val_2);
        return;
        label_40:
        if( != 0)
        {
            goto label_43;
        }
        
        goto label_44;
    }
    private System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 三丄专东世世丟且丕(System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 丛与丑业丟丂丙丒丘)
    {
        var val_4;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        丏不一丏丗丗丗丈丞 val_17;
        var val_19;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_1 = this.丆万丟丌且七与万上();
        List.Enumerator<T> val_2 = 丛与丑业丟丂丙丒丘.GetEnumerator();
        val_12 = 0;
        val_13 = 0;
        label_42:
        if(((-682206960) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        List.Enumerator<T> val_6 = val_1.GetEnumerator();
        val_14 = 0;
        val_15 = 0;
        goto label_4;
        label_13:
        label_17:
        if(((X24 + 16) != val_5.m_stringLength) || ((System.String.op_Equality(a:  X24 + 72, b:  public List.Enumerator<T> System.Collections.Generic.List<丏不一丏丗丗丗丈丞>::GetEnumerator())) == false))
        {
            goto label_18;
        }
        
        if((X24 + 16) > (X24 + 100))
        {
            goto label_8;
        }
        
        val_15 = 1;
        label_18:
        val_14 = 1;
        label_4:
        if(((-682206992) & 1) == 0)
        {
            goto label_9;
        }
        
        string val_8 = val_4.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X25)) == false)
        {
            goto label_13;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X25)) == false)
        {
            goto label_17;
        }
        
        if(val_8.m_stringLength != val_5.m_stringLength)
        {
            goto label_18;
        }
        
        if(val_8.m_stringLength <= val_5.m_stringLength)
        {
            goto label_19;
        }
        
        label_8:
        var val_12 = 0;
        val_16 = 1;
        val_12 = val_12 + 1;
        val_17 = val_5;
        mem2[0] = 221;
        val_15 = 1;
        goto label_21;
        label_19:
        val_15 = 1;
        label_9:
        var val_13 = val_12;
        val_17 = 0;
        val_13 = val_13 + 1;
        val_16 = 0;
        mem2[0] = 221;
        label_21:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_13 != 1) && ((-682207056 + (((0 + 1) + 1)) << 2) == 221))
        {
                var val_14 = 0;
            val_14 = val_14 ^ (val_13 >> 31);
            val_19 = val_13 + val_14;
        }
        else
        {
                if( != false)
        {
                val_19 = val_13;
        }
        
        }
        
        if((val_15 & 1) == 0)
        {
            goto label_34;
        }
        
        if( == 0)
        {
            goto label_42;
        }
        
        丏不一丏丗丗丗丈丞 val_11 = val_1.Item[1];
        mem[96] = val_11.isReaded;
        val_1.set_Item(index:  1, value:  null);
        goto label_42;
        label_34:
        val_1.Add(item:  val_5);
        goto label_42;
        label_2:
        var val_15 = val_13;
        val_15 = val_15 + 1;
        mem2[0] = 295;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_15 != 1)
        {
                if( == false)
        {
                return val_1;
        }
        
            if((-682207056 + ((((0 + 1) + 1) + 1)) << 2) == 295)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if( == true)
        {
                return val_1;
        }
        
        return val_1;
    }
    internal void 三丛丁丆东世丁丏三(System.Collections.Generic.List<Rilisoft.OfferItem> 上业丟世三与七七三, int 不丝丛丄世东七丒一)
    {
        var val_7;
        var val_15;
        int val_16 = 不丝丛丄世东七丒一;
        if((丞东丑专丛丆丄丝世.丂七丗丐世业丘丏不(丞丅上丏丂且下丅与:  val_16 = 不丝丛丄世东七丒一)) == true)
        {
                return;
        }
        
        val_15 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        if((val_15.万万丞丄丗丐丄丄三(三丐三丞丘丕不丒专:  val_16)) == true)
        {
                return;
        }
        
        val_15 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_15.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  220);
        List.Enumerator<T> val_5 = 上业丟世三与七七三.GetEnumerator();
        label_16:
        if(((-682037584) & 1) == 0)
        {
            goto label_12;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        if((MailBoxMessagesController.不一丅丂上丁丈三下(丏且丕丄丁丟丆丏丁:  val_8)) == false)
        {
            goto label_16;
        }
        
        丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_8, 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  false, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  62, 不丐丅丁丂七丐丘丛:  16, 丁七丐丁丙丄丙不东:  false);
        PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().一丗丙丝丒丂丗三丁(丟不丄一丄丅一世丗:  7, 不且丐一丆丛丙丙丒:  val_8.与丒上与丄丒丝三七());
        goto label_16;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  7, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().三七丟丗下丟三与专(三丐三丞丘丕不丒专:  val_16);
        val_16 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_16.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    internal static bool 不一丅丂上丁丈三下(Rilisoft.OfferItem 丏且丕丄丁丟丆丏丁)
    {
        var val_4;
        if(丏且丕丄丁丟丆丏丁.Type == 1050)
        {
                val_4 = 1;
        }
        else
        {
                bool val_2 = 丏且丕丄丁丟丆丏丁.IsExists;
            val_4 = val_2 ^ 1;
        }
        
        val_2 = val_4;
        return (bool)val_2;
    }
    internal void 下丌东三丆丙且丌丕(丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
    {
        var val_4;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_11;
        string val_12;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_13;
        if(丑丑丞专丒丙丒东不 == null)
        {
            goto label_1;
        }
        
        val_11 = this.丆万丟丌且七与万上();
        List.Enumerator<T> val_2 = val_11.GetEnumerator();
        label_14:
        if(((-681743856) & 1) == 0)
        {
            goto label_3;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        bool val_6 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  X23);
        if(val_6 == false)
        {
            goto label_10;
        }
        
        val_12 = 丑丑丞专丒丙丒东不.toId;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_12)) == false)
        {
            goto label_10;
        }
        
        if(val_5.m_stringLength != 丑丑丞专丒丙丒东不.id)
        {
            goto label_14;
        }
        
        goto label_12;
        label_10:
        if((val_5.m_stringLength != 丑丑丞专丒丙丒东不.id) || ((System.String.op_Equality(a:  val_6, b:  丑丑丞专丒丙丒东不.toId)) == false))
        {
            goto label_14;
        }
        
        label_12:
        mem2[0] = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_13 = val_11;
        this.丙专万丟专下丅丌业(三丝万与丘世丑丟丆:  val_13);
        goto label_28;
        label_1:
        if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "MailBoxMessage is null.");
        return;
        label_3:
        val_13 = public System.Void List.Enumerator<丏不一丏丗丗丗丈丞>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_28:
        this.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  val_13 = 0);
    }
    internal System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 丆万丟丌且七与万上()
    {
        var val_8;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.丅丂丝丑丁丌丟丂丞);
        var val_3 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true) ? "[]" : (val_1);
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_8 != null)
        {
                return (System.Collections.Generic.List<丏不一丏丗丗丗丈丞>)val_8;
        }
        
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_6 = null;
        val_8 = val_6;
        val_6 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        return (System.Collections.Generic.List<丏不一丏丗丗丗丈丞>)val_8;
    }
    internal System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 且丈丌不丐且丆丁专()
    {
        var val_9;
        var val_10;
        var val_21;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.丅丂丝丑丁丌丟丂丞);
        var val_3 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true) ? "[]" : (val_1);
        var val_20 = 0;
        val_20 = val_20 + 1;
        val_21 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        if(val_21 == null)
        {
                System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_6 = null;
            val_21 = val_6;
            val_6 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        }
        
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_7 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        List.Enumerator<T> val_8 = val_6.GetEnumerator();
        label_34:
        if(((-681432816) & 1) == 0)
        {
            goto label_14;
        }
        
        string val_11 = val_10.丐丏七丌丕丗业且上();
        if(val_9 == 0)
        {
            goto label_34;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  public System.Collections.Generic.List<丏不一丏丗丗丗丈丞> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<丏不一丏丗丗丗丈丞>>(string 丞丕丒专一下丙业上))) == false)
        {
            goto label_19;
        }
        
        if((this.丞丆丈丙专三丝丏丆(丑丑丞专丒丙丒东不:  val_11)) == false)
        {
            goto label_34;
        }
        
        val_7.Add(item:  val_11);
        goto label_34;
        label_19:
        if((Equals(value:  FriendsController.不丝丕丒丂丆丘丙丙())) == false)
        {
            goto label_34;
        }
        
        if((val_11.七下业丈业丙丆上丌() == true) || ((this.丞丆丈丙专三丝丏丆(丑丑丞专丒丙丒东不:  val_11)) == false))
        {
            goto label_28;
        }
        
        val_7.Add(item:  val_11);
        goto label_34;
        label_28:
        bool val_18 = val_11.七下业丈业丙丆上丌();
        if((val_18 == false) || ((val_18.一不下丒与业三丗丝(丄丙下丝丛丒七丂丘:  val_11)) == false))
        {
            goto label_34;
        }
        
        val_7.Add(item:  val_11);
        goto label_34;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.不丝丟一丛丒业东丁(丙业与丙丗丝不丈东:  val_7);
        return (System.Collections.Generic.List<丏不一丏丗丗丗丈丞>)this.不丑丆七丙丏丑丐世;
    }
    private bool 丞丆丈丙专三丝丏丆(丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
    {
        bool val_1 = this.三一专丝丏丑丞东专(丑丑丞专丒丙丒东不:  丑丑丞专丒丙丒东不);
        if(val_1 == false)
        {
                return false;
        }
        
        return val_1.一不下丒与业三丗丝(丄丙下丝丛丒七丂丘:  丑丑丞专丒丙丒东不);
    }
    private bool 一不下丒与业三丗丝(丏不一丏丗丗丗丈丞 丄丙下丝丛丒七丂丘)
    {
        var val_3;
        if(丄丙下丝丛丒七丂丘.isBigRewardMessage == false)
        {
            goto label_2;
        }
        
        double val_1 = 业丂丏与世一丏业不.万丕且不与且丛丌丅();
        if(val_1 <= 0f)
        {
            goto label_5;
        }
        
        var val_2 = (val_1 < 0) ? 1 : 0;
        return (bool)val_3;
        label_2:
        val_3 = 1;
        return (bool)val_3;
        label_5:
        val_3 = 0;
        return (bool)val_3;
    }
    private bool 三一专丝丏丑丞东专(丏不一丏丗丗丗丈丞 丑丑丞专丒丙丒东不)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
        string val_17;
        object val_5 = 0;
        object val_9 = 0;
        object val_7 = 0;
        string val_4 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业())) != true) ? "English" : I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业();
        bool val_6 = 丑丑丞专丒丙丒东不.Header.TryGetValue(key:  val_4, value: out  val_5);
        val_15 = 丑丑丞专丒丙丒东不.HeaderPreview;
        bool val_8 = val_15.TryGetValue(key:  val_4, value: out  val_7);
        val_16 = 丑丑丞专丒丙丒东不.ShortDescription;
        bool val_10 = val_16.TryGetValue(key:  val_4, value: out  val_9);
        val_17 = 0;
        if(((val_5 != 0) && (val_7 != 0)) && (val_9 != 0))
        {
                val_15 = val_5;
            val_16 = val_9;
            if(((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_15)) != false) && ((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_7)) != false))
        {
                val_17 = val_16;
        }
        else
        {
                val_17 = 0;
        }
        
        }
        
        val_17 = val_17 & 1;
        return (bool)val_17;
    }
    private void 丙专万丟专下丅丌业(System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 三丝万与丘世丑丟丆)
    {
        var val_5 = 0;
        val_5 = val_5 + 1;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.丅丂丝丑丁丌丟丂丞, 下下丏一丙不丘丌丞:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  三丝万与丘世丑丟丆));
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_4 = this.且丈丌不丐且丆丁专();
    }
    internal bool 专丗万丆世丂万下丛(int 丞丅上丏丂且下丅与, string 丏丄世丛丆丂丗丅丅)
    {
        var val_4;
        string val_11;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_12;
        var val_13;
        var val_14;
        val_11 = 丏丄世丛丆丂丗丅丅;
        val_12 = this.不丑丆七丙丏丑丐世;
        if((val_12 == null) || (val_12.Count < 1))
        {
            goto label_21;
        }
        
        List.Enumerator<T> val_2 = val_12.GetEnumerator();
        label_13:
        if(((-680724288) & 1) == 0)
        {
            goto label_3;
        }
        
        val_12 = val_4.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  137105408)) != false)
        {
                bool val_7 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_11);
            if(val_7 != false)
        {
                if(val_5.m_stringLength == 丞丅上丏丂且下丅与)
        {
            goto label_11;
        }
        
        }
        
        }
        
        if((val_5.m_stringLength != 丞丅上丏丂且下丅与) || ((System.String.op_Equality(a:  val_7, b:  val_11)) == false))
        {
            goto label_13;
        }
        
        label_11:
        val_11 = 1;
        var val_9 = (val_5.m_stringLength != 0) ? 1 : 0;
        goto label_14;
        label_3:
        val_11 = 0;
        val_13 = 0;
        label_14:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_14 = val_11 & val_13;
        return (bool)val_14;
        label_21:
        val_14 = 0;
        return (bool)val_14;
    }
    internal int 专丕丐丆丁丅丆丗丈()
    {
        return (int)this.<世丂上业上丗丛与丞>k__BackingField;
    }
    private void 与丐丅业丙丘丁丂丒(int 丙业与丙丗丝不丈东)
    {
        this.<世丂上业上丗丛与丞>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丛丑不三丂东下专丌(string 三万专丛丟上丏丅下 = "")
    {
        int val_6;
        var val_7;
        this.<世丂上业上丗丛与丞>k__BackingField = 0;
        val_6 = this.不丑丆七丙丏丑丐世.Count;
        val_7 = null;
        val_7 = null;
        int val_4 = System.Math.Min(val1:  val_6, val2:  PGCompany.NewsLobbyController.MaxShowElements + this.下一丅专丌上且且下());
        if(val_4 >= 1)
        {
                do
        {
            丏不一丏丗丗丗丈丞 val_5 = this.不丑丆七丙丏丑丐世.Item[0];
            if((val_5.丂丄万业丝丆丐丆丂 != false) && (val_5.isReaded != true))
        {
                int val_6 = this.<世丂上业上丗丛与丞>k__BackingField;
            val_6 = val_6 + 1;
            this.<世丂上业上丗丛与丞>k__BackingField = val_6;
        }
        
            val_6 = 0 + 1;
        }
        while(val_4 != val_6);
        
        }
        
        this.丄丛丅丞与万下丘丟();
    }
    private void 丄丛丅丞与万下丘丟()
    {
        if(MailBoxMessagesController.丞丂上丙与丟下丂上 == null)
        {
                return;
        }
        
        MailBoxMessagesController.丞丂上丙与丟下丂上.Invoke(obj:  this.<世丂上业上丗丛与丞>k__BackingField);
    }
    internal void 丘三丁七丁丐世七丈(System.Collections.Generic.List<丏不一丏丗丗丗丈丞> 七与丐上专世世丏丘)
    {
        var val_7;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_22;
        var val_23;
        var val_24;
        UnityEngine.Object val_25;
        var val_26;
        var val_27;
        val_19 = 七与丐上专世世丏丘;
        System.Collections.Generic.List<丏不一丏丗丗丗丈丞> val_1 = this.丆万丟丌且七与万上();
        int val_3 = val_1.Count - 1;
        if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
        val_18 = 1152921538283740336;
        val_20 = 0;
        label_42:
        丏不一丏丗丗丗丈丞 val_4 = val_1.Item[val_3];
        List.Enumerator<T> val_5 = val_19.GetEnumerator();
        label_22:
        if(((-680081360) & 1) == 0)
        {
            goto label_5;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.toId)) != false)
        {
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4.toId)) != false)
        {
                if(val_4.id == val_8.m_stringLength)
        {
            goto label_14;
        }
        
        }
        
            val_21 = val_4.id;
        }
        else
        {
                val_21 = val_4.id;
        }
        
        if(((val_21 != val_8.m_stringLength) || ((System.String.op_Equality(a:  val_4.toId, b:  0)) == false)) || ((FriendsController.不丝丕丒丂丆丘丙丙().Equals(value:  val_4.toId)) == false))
        {
            goto label_22;
        }
        
        val_22 = val_1;
        val_22.RemoveAt(index:  val_3);
        goto label_24;
        label_5:
        val_23 = 0 + 1;
        val_19 = val_19;
        val_22 = val_1;
        mem2[0] = 195;
        goto label_27;
        label_14:
        val_22 = val_1;
        val_22.RemoveAt(index:  val_3);
        label_24:
        val_23 = 0 + 1;
        val_19 = val_19;
        mem2[0] = 195;
        label_27:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_23 != 1) && ((-680081424 + ((0 + 1)) << 2) == 195))
        {
                var val_17 = 0;
            val_17 = val_17 ^ (val_23 >> 31);
            val_23 = val_23 + val_17;
        }
        else
        {
                if(null != null)
        {
                val_20 = 0;
        }
        
        }
        
        val_3 = val_3 - 1;
        if((val_3 & 2147483648) == 0)
        {
            goto label_42;
        }
        
        if((1 & 1) == 0)
        {
                return;
        }
        
        this.丙专万丟专下丅丌业(三丝万与丘世丑丟丆:  null);
        val_18 = 1152921505566695424;
        val_24 = null;
        val_24 = null;
        val_25 = 0;
        if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟 != val_25)
        {
                val_26 = null;
            val_26 = null;
            val_25 = 0;
            if(PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丅与丌专丟一丝业三().activeSelf != false)
        {
                val_27 = null;
            val_27 = null;
            val_25 = 1;
            PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丛丘丗丟世丂一东一(七三丞丘丟下丛丛不:  true);
        }
        
        }
        
        this.丛丑不三丂东下专丌(三万专丛丟上丏丅下:  val_25);
    }
    internal int 下一丅专丌上且且下()
    {
        var val_5;
        System.Func<丏不一丏丗丗丗丈丞, System.Boolean> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = MailBoxMessagesController.<>c.<>9__42_0;
        if(val_7 == null)
        {
                System.Func<丏不一丏丗丗丗丈丞, System.Boolean> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<丏不一丏丗丗丗丈丞, System.Boolean>(object:  MailBoxMessagesController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MailBoxMessagesController.<>c::丟丆丅丙丑丄不万丕(丏不一丏丗丗丗丈丞 东丝丄丝丙专丘三丏));
            MailBoxMessagesController.<>c.<>9__42_0 = val_7;
        }
        
        int val_2 = System.Linq.Enumerable.Count<丏不一丏丗丗丗丈丞>(source:  this.不丑丆七丙丏丑丐世, predicate:  val_1);
        return (int)(val_2 != this.不丑丆七丙丏丑丐世.Count) ? (val_2) : 0;
    }
    public MailBoxMessagesController()
    {
        this.不丑丆七丙丏丑丐世 = new System.Collections.Generic.List<丏不一丏丗丗丗丈丞>();
        this.丑上不专七且业丑与 = true;
        this.丌世三丗丏丝丂丒万 = true;
        this.丅丂丝丑丁丌丟丂丞 = "MailBoxMessages";
    }

}
