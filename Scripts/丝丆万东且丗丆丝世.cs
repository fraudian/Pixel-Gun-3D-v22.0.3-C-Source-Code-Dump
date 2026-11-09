using UnityEngine;
private sealed class SquadController.丝丆万东且丗丆丝世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丙世不不一丏业三且;
    public string 丐下丘丈丁丄丌专丕;
    public string 丑三丅丒丕丗三丏丁;
    private UnityEngine.WWW 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SquadController.丝丆万东且丗丆丝世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_26;
        string val_27;
        int val_28;
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_30;
        }
        
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丙世不不一丏业三且 == false)
        {
            goto label_4;
        }
        
        label_35:
        string val_2 = 专且丁丐世万丝丈世.丗且万东丗世丕丟丞(万丝一丁与不丟丟丝:  ProfileController.丆三丂丂丆上丆丕专());
        UnityEngine.WWWForm val_3 = new UnityEngine.WWWForm();
        val_26 = null;
        val_26 = null;
        val_3.AddField(fieldName:  "app_version", value:  System.String.Format(format:  "{0}:{1}", arg0:  ProtocolListGetter.丅三专丐丗丅与丆丑(), arg1:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒));
        string val_6 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if(val_6 == null)
        {
            goto label_12;
        }
        
        label_38:
        val_3.AddField(fieldName:  "player", value:  val_6);
        if(val_2 == null)
        {
            goto label_14;
        }
        
        label_40:
        val_3.AddField(fieldName:  "nickname", value:  val_2);
        val_27 = this.丑三丅丒丕丗三丏丁;
        if(val_27 == null)
        {
            goto label_16;
        }
        
        if(val_3 == null)
        {
            goto label_17;
        }
        
        label_41:
        val_3.AddField(fieldName:  "friend", value:  val_27);
        goto label_18;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  this.丅丒丑丄丞丑下丈丕.error)) == true)
        {
            goto label_30;
        }
        
        val_28 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  10f);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_28;
        label_4:
        val_29 = 1152921505323884544;
        val_30 = null;
        val_30 = null;
        if(SquadController.丄丘七三上丕世丞业 == 0)
        {
            goto label_30;
        }
        
        val_31 = null;
        val_31 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == false)
        {
            goto label_30;
        }
        
        val_32 = null;
        val_32 = null;
        val_29 = this.丐下丘丈丁丄丌专丕;
        if((Equals(value:  val_29)) == true)
        {
            goto label_35;
        }
        
        label_30:
        val_28 = 0;
        return (bool)val_28;
        label_12:
        if(val_3 != null)
        {
            goto label_38;
        }
        
        goto label_38;
        label_14:
        if(val_3 != null)
        {
            goto label_40;
        }
        
        goto label_40;
        label_16:
        val_27 = System.String.alignConst;
        if(val_3 != null)
        {
            goto label_41;
        }
        
        label_17:
        val_3.AddField(fieldName:  "friend", value:  val_27);
        label_18:
        val_3.AddField(fieldName:  "invite_type", value:  "squad");
        val_3.AddField(fieldName:  "room_name", value:  this.丐下丘丈丁丄丌专丕);
        val_33 = null;
        val_33 = null;
        val_3.AddField(fieldName:  "clanwar_mode", i:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  SquadController.丄丘七三上丕世丞业.IsClanWarSquad));
        if(this.丙世不不一丏业三且 == false)
        {
            goto label_49;
        }
        
        if(val_3 != null)
        {
            goto label_66;
        }
        
        label_67:
        label_66:
        val_3.AddField(fieldName:  "siege_mode", i:  1);
        val_34 = null;
        val_34 = null;
        val_3.AddField(fieldName:  "test_mode", i:  丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  SquadController.丄丘七三上丕世丞业.IsTestingSquad));
        System.Collections.Generic.Dictionary<System.String, System.String> val_19 = null;
        val_29 = val_19;
        val_19 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_19.Add(key:  "Authorization", value:  FriendsController.三丕丝丘丘丕三丅且(且专丝丙丝不丈七丑:  val_3.data));
        val_28 = 1;
        UnityEngine.WWW val_22 = Rilisoft.与丄丁丄丙丞下下丙.万丛七不丆丅世下丄(丞三丕世业三丒丅三:  true, 七丙不丅丛丘丗万与:  "https://secure.pixelgunserver.com/invite_service", 丛丁且丏丁丄上上丄:  val_3, 丐丆丐七一上专三丑:  "FriendPreviewItem.HandleCallSquad()", 一丞不一不一与世丙:  val_19, 丝丌丝不丟丞丑丑丗:  true);
        this.丅丒丑丄丞丑下丈丕 = val_22;
        this.丒上七丌业七丟与丐 = val_22;
        this.丗丏丅丕丆世丁专丟 = val_28;
        return (bool)val_28;
        label_49:
        val_35 = null;
        val_35 = null;
        int val_25 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  SquadController.丄丘七三上丕世丞业.IsClanSquad);
        if(val_3 != null)
        {
            goto label_66;
        }
        
        goto label_67;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
