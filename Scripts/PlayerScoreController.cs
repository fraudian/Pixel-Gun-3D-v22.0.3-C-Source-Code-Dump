using UnityEngine;
internal class PlayerScoreController : MonoBehaviour
{
    // Fields
    internal string[] 世丙丆丁与丐丅丏业;
    internal int 丆丌专丄丂世丛三丂;
    internal float[] 七东丙与万丒丗丕丅;
    internal float 世丞丗丄丐丒上丁丌;
    internal float 下丗丘不丌世世丏丒;
    internal float 丕丑丘万且丙丞丁东;
    internal string 丛丐丌丙丈七丛丛东;
    internal string 丄丙下丝丛丒七丂丘;
    private float 丟七丄下丈丝且丌丗;
    private System.Collections.Generic.List<string> 与丁丝丄丈丞丅丐丟;
    private float 丁业丁丞七丐丘丅丕;
    private float 丆丒丝丌一丅不业且;
    private System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> 丘丘专丘一与三丂丅;
    private UnityEngine.Color <丅丟万丝丗不丟丗丈>k__BackingField;
    private UnityEngine.Color <丘丟业业一丛丑丏丕>k__BackingField;
    private bool <下丏不上丈丝丂下专>k__BackingField;
    private UILabel.东丗一且与丑与丈且 <丂不专七丕丙上丝上>k__BackingField;
    private UnityEngine.Vector2 <丗七丈且七丄下且万>k__BackingField;
    private UnityEngine.Color <丗丌丁丝丗丙一丞丈>k__BackingField;
    
    // Properties
    internal UnityEngine.Color 且丛丟丒且丛丌七丄 { get; set; }
    internal UnityEngine.Color 丞万丟且丑丏不丂七 { get; set; }
    internal bool 丆丑且丗丘丝丙一丙 { get; set; }
    internal UILabel.东丗一且与丑与丈且 丛丈丙丅七丁丏万丄 { get; set; }
    internal UnityEngine.Vector2 丈丄丞三丄丛丘丛东 { get; set; }
    internal UnityEngine.Color 上下与丞丅世丛且丕 { get; set; }
    
    // Methods
    private void Start()
    {
        var val_10;
        var val_11;
        var val_13;
        UnityEngine.Object val_14;
        val_10 = this;
        val_11 = null;
        val_11 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                if((this.GetComponent<PhotonView>().isMine) == false)
        {
            goto label_8;
        }
        
        }
        
        val_13 = null;
        val_13 = null;
        Dictionary.Enumerator<TKey, TValue> val_3 = 丌丐丄下丒丆丂丝丛.丝丅丄三七丙丁丆东.GetEnumerator();
        label_19:
        if((1267527656 & 1) == 0)
        {
            goto label_12;
        }
        
        ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
        UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  "ScoreEventSounds/"("ScoreEventSounds/") + val_4._value._obj);
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_14 = 0;
        }
        
        if(val_14 == 0)
        {
            goto label_19;
        }
        
        this.丘丘专丘一与三丂丅.Add(key:  val_4._value._obj.丐丏七丌丕丗业且上(), value:  val_14);
        goto label_19;
        label_8:
        this.enabled = false;
        return;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丆世丐丞丅且丏丙且(string 丛丐丌丙丈七丛丛东, string 丄丙下丝丛丒七丂丘)
    {
        string val_6;
        System.Collections.Generic.List<System.String> val_7;
        var val_8;
        val_6 = 丛丐丌丙丈七丛丛东;
        val_7 = this;
        if(丄丙下丝丛丒七丂丘 == null)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_6)) == true)
        {
                return;
        }
        
        this.丛丐丌丙丈七丛丛东 = val_6;
        this.丄丙下丝丛丒七丂丘 = 丄丙下丝丛丒七丂丘;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_4 = 丌丐丄下丒丆丂丝丛.丒丙一不丏丈七丙上.Item[109.ToString()];
        val_6 = this.与丁丝丄丈丞丅丐丟;
        if((val_6.Contains(item:  val_4)) == true)
        {
                return;
        }
        
        val_7 = this.与丁丝丄丈丞丅丐丟;
        val_7.Add(item:  val_4);
    }
    internal static int 丄丈丏丒万丝丐上丘(丅世一丈七丆业丝丘 丐丘丌三丏与丙且东, float 专上丝且丂世丛丝丒 = 1)
    {
        null = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        float val_3 = (float)丌丐丄下丒丆丂丝丛.三丌与世丙上东丒世.Item[丐丘丌三丏与丙且东.ToString()];
        val_3 = val_3 * 专上丝且丂世丛丝丒;
        return (int)(int)val_3;
    }
    internal void 一东三丗丛不与丈丂(丅世一丈七丆业丝丘 丐丘丌三丏与丙且东, float 专上丝且丂世丛丝丒 = 1)
    {
        丅世一丈七丆业丝丘 val_49;
        System.Collections.Generic.List<System.String> val_50;
        InGameGUI val_51;
        var val_52;
        var val_53;
        float val_54;
        int val_55;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        int val_62;
        var val_65;
        OnlineModeController val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        string val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        val_49 = 丐丘丌三丏与丙且东;
        val_50 = this;
        val_51 = 1152921505066536960;
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_52 = null;
            val_52 = null;
            var val_50 = 0;
            do
        {
            if(val_50 >= MutationController.MutationScoreEvents.Length)
        {
                return;
        }
        
            val_50 = val_50 + 1;
        }
        while((MutationController.MutationScoreEvents.Length + 32) != val_49);
        
        }
        
        if(GameConnect.丆丕丒与丂七与下上() == true)
        {
                return;
        }
        
        if(GameConnect.丙丌丒丈东七丒上丌() == true)
        {
                return;
        }
        
        if(val_49 == 10)
        {
                float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - this.丟七丄下丈丝且丌丗;
            if(val_4 < 0)
        {
                val_53 = 13;
        }
        else
        {
                val_53 = 10;
        }
        
        }
        
        val_54 = 专上丝且丂世丛丝丒;
        val_55 = PlayerScoreController.丄丈丏丒万丝丐上丘(丐丘丌三丏与丙且东:  10, 专上丝且丂世丛丝丒:  val_54);
        UnityEngine.Color val_6 = UnityEngine.Color.white;
        if(val_55 == 0)
        {
            goto label_19;
        }
        
        val_57 = null;
        val_57 = null;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 != true)
        {
                val_58 = null;
            val_58 = null;
            if((typeof(Player_move_c).__il2cppRuntimeField_628.IsSetEquipped(丂万丏专丒下丈丂丟:  262144)) != false)
        {
                if(GameConnect.丘不万丏万万丘丐专() != true)
        {
                float val_51 = (float)val_55;
            val_51 = val_51 * 0.1f;
            val_54 = 5f;
            val_55 = (UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Max(a:  val_54, b:  val_51))) + val_55;
        }
        
        }
        
        }
        
        val_59 = null;
        val_59 = null;
        if((不丌丁丁与上丘丌丈().丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  16)) != false)
        {
                if(GameConnect.丘不万丏万万丘丐专() != true)
        {
                val_60 = null;
            val_60 = null;
            val_51 = (不丌丁丁与上丘丌丈().丛万丟丕丗丒七不丄(丂丑丑与与丘丁与丙:  16)) * (float)val_55;
            val_55 = (UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Max(a:  5f, b:  val_51))) + val_55;
        }
        
        }
        
        val_61 = null;
        val_61 = null;
        WeaponSounds val_18 = 丙不丅丕三丂业东丕();
        if(val_18.isBuffPoints == false)
        {
            goto label_55;
        }
        
        if((10 - 9) > 8)
        {
            goto label_56;
        }
        
        var val_52 = 106025592 + ((10 - 9)) << 2;
        val_52 = val_52 + 106025592;
        goto (106025592 + ((10 - 9)) << 2 + 106025592);
        label_66:
        val_51 = val_18.buffPointsOther * (float)val_55;
        val_55 = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Mathf.Max(a:  5f, b:  val_51));
        label_55:
        this.丘丌丂丞万专与丟万(丝丅东丟七丐丂与丐:  0);
        goto label_65;
        label_19:
        val_62 = 0;
        goto label_117;
        label_56:
        if((10 - 44) <= 7)
        {
            goto label_65;
        }
        
        goto label_66;
        label_65:
        val_65 = null;
        val_65 = null;
        val_66 = GameController.onlineMode;
        if((val_66 == null) || (null != null))
        {
            goto label_86;
        }
        
        val_66 = GameController.onlineMode;
        if(val_66 == null)
        {
            goto label_164;
        }
        
        val_67 = val_66;
        if(null != null)
        {
            
        }
        else
        {
                val_67 = val_66;
            if(val_66 == null)
        {
            goto label_84;
        }
        
        }
        
        label_84:
        label_164:
        if(((null == null) ? (val_67) : 0.万东七丁世万丟专且()) == false)
        {
            goto label_86;
        }
        
        val_55 = 0;
        goto label_88;
        label_86:
        if( >= 1)
        {
                Rilisoft.丞丛七上丕专丏丌丈.丁丈丁丙丑世丂七丑(丛丛丆丛丏丟业万上:  null);
        }
        
        label_88:
        val_68 = null;
        val_68 = null;
        val_62 = UnityEngine.Mathf.Max(a:  0, b:  丝丈丅一丆丗丝丝丘() +);
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_69 = null;
            val_69 = null;
            DungeonsController.丄丘七三上丕世丞业.丑东丂与与丌丙丟丄(丗丂丁丂丗丄七丏下:  (float));
        }
        
        if(GameConnect.业丗与丈丁东下一丛() == false)
        {
            goto label_105;
        }
        
        val_70 = null;
        val_70 = null;
        if(GameController.mode == null)
        {
            goto label_108;
        }
        
        var val_32 = (null == null) ? GameController.mode : 0;
        goto label_110;
        label_105:
        val_72 = 0;
        goto label_111;
        label_108:
        val_71 = 0;
        label_110:
        val_72 = val_71.万东七丁世万丟专且();
        label_111:
        val_73 = null;
        val_73 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_35 = 丌丐丄下丒丆丂丝丛.丆丟丛丅丟丆丟世丒.Item[13.ToString()];
        if((System.String.IsNullOrEmpty(value:  val_35)) != true)
        {
                if(val_72 != false)
        {
                string val_37 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_35);
            var val_38 = (val_37 == null) ? "" : (val_37);
        }
        else
        {
                val_74 = ( > 0) ? "+" : ""(( > 0) ? "+" : "") + AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  null)(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  null)) + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_35)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_35));
        }
        
            this.与丒丅七世丞丏万丒(下丘与业丗丙且业丑:  val_74, 上业丁三与下丙丄上:  null);
        }
        
        label_117:
        val_75 = null;
        val_75 = null;
        val_51 = null;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        string val_44 = 丌丐丄下丒丆丂丝丛.丒丙一不丏丈七丙上.Item[null.ToString()];
        if((System.String.IsNullOrEmpty(value:  val_44)) != true)
        {
                val_51 = InGameGUI.丙丞专丌丁丞与不丐;
            if(val_51 != 0)
        {
                if((val_44.Equals(value:  "OneKill")) != false)
        {
                val_72 = 1152921505286238208;
            val_76 = null;
            val_76 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_77 = null;
            val_77 = null;
            val_51 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_51 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        }
        
            val_51 = this.与丁丝丄丈丞丅丐丟;
            if((val_51.Contains(item:  val_44)) != true)
        {
                val_50 = this.与丁丝丄丈丞丅丐丟;
            val_50.Add(item:  val_44);
        }
        
        }
        
        }
        
        if( == 0)
        {
                return;
        }
        
        val_50 = 1152921505171275776;
        val_78 = null;
        val_78 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_79 = null;
        val_79 = null;
        GameController.mode.一丟丌万东专丐丂丆(丙业与丙丗丝不丈东:  val_62);
        val_80 = null;
        val_80 = null;
        东且世丈丒丄世三丈(丙业与丙丗丝不丈东:  val_62);
        val_50 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_50 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        丆丂东丏与不与不丟();
    }
    internal UnityEngine.Color 丁且万万丅丒丅三且()
    {
        return new UnityEngine.Color() {r = this.<丅丟万丝丗不丟丗丈>k__BackingField};
    }
    private void 丞且丝丘丕丌丄丌且(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.<丅丟万丝丗不丟丗丈>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921535939951428] = 丙业与丙丗丝不丈东.g;
        mem[1152921535939951432] = 丙业与丙丗丝不丈东.b;
        mem[1152921535939951436] = 丙业与丙丗丝不丈东.a;
    }
    internal UnityEngine.Color 下且与丌丂丒上丘东()
    {
        return new UnityEngine.Color() {r = this.<丘丟业业一丛丑丏丕>k__BackingField};
    }
    private void 东且与东且丄丁世丒(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.<丘丟业业一丛丑丏丕>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921535940175444] = 丙业与丙丗丝不丈东.g;
        mem[1152921535940175448] = 丙业与丙丗丝不丈东.b;
        mem[1152921535940175452] = 丙业与丙丗丝不丈东.a;
    }
    internal bool 且三丂丕丘与丆业丆()
    {
        return (bool)this.<下丏不上丈丝丂下专>k__BackingField;
    }
    private void 下丄下专不且且丞丞(bool 丙业与丙丗丝不丈东)
    {
        this.<下丏不上丈丝丂下专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UILabel.东丗一且与丑与丈且 丈丕丏丂丌不东丈专()
    {
        return (东丗一且与丑与丈且)this.<丂不专七丕丙上丝上>k__BackingField;
    }
    private void 丐丞丌万上丏丞丞且(UILabel.东丗一且与丑与丈且 丙业与丙丗丝不丈东)
    {
        this.<丂不专七丕丙上丝上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Vector2 下丝丟丞不丒丆专丛()
    {
        return new UnityEngine.Vector2() {x = this.<丗七丈且七丄下且万>k__BackingField};
    }
    private void 三丕丝丗丌丗业且丆(UnityEngine.Vector2 丙业与丙丗丝不丈东)
    {
        this.<丗七丈且七丄下且万>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921535940863852] = 丙业与丙丗丝不丈东.y;
    }
    internal UnityEngine.Color 丄丝丐七万丕丝业丆()
    {
        return new UnityEngine.Color() {r = this.<丗丌丁丝丗丙一丞丈>k__BackingField};
    }
    private void 专三三丑且丄丈与丙(UnityEngine.Color 丙业与丙丗丝不丈东)
    {
        this.<丗丌丁丝丗丙一丞丈>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921535941087860] = 丙业与丙丗丝不丈东.g;
        mem[1152921535941087864] = 丙业与丙丗丝不丈东.b;
        mem[1152921535941087868] = 丙业与丙丗丝不丈东.a;
    }
    internal void 丒丄丟东丑不三七世()
    {
        this.丘丌丂丞万专与丟万(丝丅东丟七丐丂与丐:  0);
    }
    private void 丘丌丂丞万专与丟万(UILabel 丝丅东丟七丐丂与丐)
    {
        if(丝丅东丟七丐丂与丐 == 0)
        {
                this.<下丏不上丈丝丂下专>k__BackingField = false;
            this.<丂不专七丕丙上丝上>k__BackingField = 0;
            this.<丅丟万丝丗不丟丗丈>k__BackingField = 0;
            mem[1152921535941324100] = 0;
            mem[1152921535941324104] = 0;
            mem[1152921535941324108] = 0;
            this.<丘丟业业一丛丑丏丕>k__BackingField = 0;
            mem[1152921535941324116] = 0;
            mem[1152921535941324120] = 0;
            mem[1152921535941324124] = 0;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.<丗七丈且七丄下且万>k__BackingField = val_2;
            mem[1152921535941324140] = val_2.y;
        }
        else
        {
                UnityEngine.Color val_3 = 丝丅东丟七丐丂与丐.gradientTop;
            this.<丅丟万丝丗不丟丗丈>k__BackingField = val_3;
            mem[1152921535941324100] = val_3.g;
            mem[1152921535941324104] = val_3.b;
            mem[1152921535941324108] = val_3.a;
            UnityEngine.Color val_4 = 丝丅东丟七丐丂与丐.gradientBottom;
            this.<丘丟业业一丛丑丏丕>k__BackingField = val_4;
            mem[1152921535941324116] = val_4.g;
            mem[1152921535941324120] = val_4.b;
            mem[1152921535941324124] = val_4.a;
            this.<下丏不上丈丝丂下专>k__BackingField = true;
            if(丝丅东丟七丐丂与丐 != null)
        {
                this.<丂不专七丕丙上丝上>k__BackingField = 丝丅东丟七丐丂与丐.effectStyle;
        }
        else
        {
                this.<丂不专七丕丙上丝上>k__BackingField = 0.effectStyle;
        }
        
            UnityEngine.Vector2 val_7 = 丝丅东丟七丐丂与丐.effectDistance;
            this.<丗七丈且七丄下且万>k__BackingField = val_7;
            mem[1152921535941324140] = val_7.y;
            UnityEngine.Color val_8 = 丝丅东丟七丐丂与丐.effectColor;
        }
        
        this.<丗丌丁丝丗丙一丞丈>k__BackingField = val_8;
        mem[1152921535941324148] = val_8.g;
        mem[1152921535941324152] = val_8.b;
        mem[1152921535941324156] = val_8.a;
    }
    private void 与丒丅七世丞丏万丒(string 下丘与业丗丙且业丑, int 上业丁三与下丙丄上)
    {
        int val_8;
        string val_9;
        float val_10;
        var val_11;
        var val_12;
        int val_13;
        val_8 = 上业丁三与下丙丄上;
        val_9 = 下丘与业丗丙且业丑;
        val_10 = this;
        if(PlantTheBombController.BlockScoreAndKillStreak == true)
        {
                return;
        }
        
        this.世丙丆丁与丐丅丏业[2] = this.世丙丆丁与丐丅丏业[1];
        this.世丙丆丁与丐丅丏业[1] = val_9;
        if(this.七东丙与万丒丗丕丅[0] > 0f)
        {
                val_8 = this.丆丌专丄丂世丛三丂 + val_8;
        }
        
        this.丆丌专丄丂世丛三丂 = val_8;
        val_9 = 1152921505066536960;
        if(GameConnect.业丗与丈丁东下一丛() == false)
        {
            goto label_16;
        }
        
        val_11 = null;
        val_11 = null;
        if(GameController.mode != null)
        {
                var val_3 = (null == null) ? GameController.mode : 0;
        }
        else
        {
                val_12 = 0;
        }
        
        if(val_12.万东七丁世万丟专且() == true)
        {
            goto label_22;
        }
        
        label_16:
        this.世丙丆丁与丐丅丏业[0] = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  this.丆丌专丄丂世丛三丂);
        label_22:
        val_13 = this.七东丙与万丒丗丕丅.Length;
        if(val_13 <= 1)
        {
                val_13 = this.七东丙与万丒丗丕丅.Length;
        }
        
        this.七东丙与万丒丗丕丅[2] = this.七东丙与万丒丗丕丅[1];
        this.七东丙与万丒丗丕丅[1] = this.世丞丗丄丐丒上丁丌;
        val_10 = mem[val_6 != true ? this.丕丑丘万且丙丞丁东 : this.下丗丘不丌世世丏丒];
        val_10 = (GameConnect.且丞丁东丝丗上丈业() != true) ? this.丕丑丘万且丙丞丁东 : this.下丗丘不丌世世丏丒;
        this.七东丙与万丒丗丕丅[0] = val_10;
    }
    public void StopKillStreak()
    {
        this.丁业丁丞七丐丘丅丕 = 0f;
        this.与丁丝丄丈丞丅丐丟.Clear();
    }
    private void Update()
    {
        var val_19;
        var val_20;
        float val_21;
        System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip> val_22;
        val_19 = this;
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = (GameConnect.且丞丁东丝丗上丈业() != true) ? (val_2 + val_2) : (val_2);
        val_2 = this.丁业丁丞七丐丘丅丕 + val_2;
        this.丁业丁丞七丐丘丅丕 = val_2;
        if((val_2 > this.丆丒丝丌一丅不业且) && (this.与丁丝丄丈丞丅丐丟.Count >= 1))
        {
                string val_5 = this.与丁丝丄丈丞丅丐丟.Item[0];
            this.丁业丁丞七丐丘丅丕 = 0f;
            val_20 = null;
            if(InGameGUI.丙丞专丌丁丞与不丐 != null)
        {
                val_21 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 1132];
            val_21 = InGameGUI.丙丞专丌丁丞与不丐.maxTimerShowScorePict;
        }
        else
        {
                val_21 = 0f;
            val_20 = null;
        }
        
            InGameGUI.丙丞专丌丁丞与不丐.timerShowScorePict = val_21;
            if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                val_20 = null;
        }
        
            InGameGUI.丙丞专丌丁丞与不丐.scorePictName = val_5;
            if(InGameGUI.丙丞专丌丁丞与不丐 == null)
        {
                val_20 = null;
        }
        
            InGameGUI.丙丞专丌丁丞与不丐.scoreIconName = this.丛丐丌丙丈七丛丛东;
            InGameGUI.丙丞专丌丁丞与不丐.scoreMessage = this.丄丙下丝丛丒七丂丘;
            val_22 = this.丘丘专丘一与三丂丅;
            if((val_22.ContainsKey(key:  val_5)) != false)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_22 = this.丘丘专丘一与三丂丅;
            UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_22.Item[val_5]);
        }
        
        }
        
            this.与丁丝丄丈丞丅丐丟.RemoveAt(index:  0);
        }
        
        if(this.七东丙与万丒丗丕丅[2] > 0f)
        {
                val_22 = this.七东丙与万丒丗丕丅;
            float val_11 = UnityEngine.Time.deltaTime;
            val_11 = (GameConnect.且丞丁东丝丗上丈业() != true) ? (val_11 + val_11) : (val_11);
            val_11 = val_22[2] - val_11;
            val_22[2] = val_11;
        }
        
        if(this.七东丙与万丒丗丕丅[1] > 0f)
        {
                val_22 = this.七东丙与万丒丗丕丅;
            float val_14 = UnityEngine.Time.deltaTime;
            val_14 = (GameConnect.且丞丁东丝丗上丈业() != true) ? (val_14 + val_14) : (val_14);
            val_14 = val_22[1] - val_14;
            val_22[1] = val_14;
        }
        
        if(this.七东丙与万丒丗丕丅[0] <= 0f)
        {
                return;
        }
        
        val_19 = GameConnect.且丞丁东丝丗上丈业();
        float val_17 = UnityEngine.Time.deltaTime;
        val_17 = (val_19 != true) ? (val_17 + val_17) : (val_17);
        val_17 = this.七东丙与万丒丗丕丅[0] - val_17;
        this.七东丙与万丒丗丕丅[0] = val_17;
    }
    public PlayerScoreController()
    {
        string[] val_1 = new string[3];
        val_1[0] = "";
        val_1[1] = "";
        val_1[2] = "";
        this.世丙丆丁与丐丅丏业 = val_1;
        this.七东丙与万丒丗丕丅 = new float[3];
        this.世丞丗丄丐丒上丁丌 = 2f;
        this.下丗丘不丌世世丏丒 = 4f;
        this.丕丑丘万且丙丞丁东 = 3f;
        this.与丁丝丄丈丞丅丐丟 = new System.Collections.Generic.List<System.String>();
        this.丆丒丝丌一丅不业且 = 1f;
        this.丘丘专丘一与三丂丅 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.AudioClip>();
    }

}
