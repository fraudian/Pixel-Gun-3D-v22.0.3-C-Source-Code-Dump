using UnityEngine;
internal sealed class PlayerEffectContainer : PGBehaviour
{
    // Fields
    internal static bool 丗上与丈丕丁且七世;
    private System.Collections.Generic.List<PlayerEffectSettings> _listPlayerEffects;
    private System.Collections.Generic.Dictionary<丑丄丏丐丅丛丐丆丒, 丏丙丘丒上丝丒丁且> 丘专丈一丗下丗上丘;
    internal Player_move_c 丗丁丒三丐丞丏万下;
    internal SkinName 丞丗丄丂丆业丈丑业;
    private System.Collections.Generic.List<string> 不丞丅丌专丝丐丈东;
    private System.Collections.Generic.List<int> 丝丂上丂七丙丁丈丕;
    private System.Collections.Generic.List<float> 下丁东上下丗丄丒丑;
    private System.Collections.Generic.List<float> 万丑上丌三三专七丐;
    private System.Collections.Generic.List<int[]> 一丟丙丕丗丒东专丒;
    private PlayerEffectSettings _playerSettings;
    
    // Methods
    internal bool 丙七丛丆丏丅且一东(丑丄丏丐丅丛丐丆丒 丂丑丑与与丘丁与丙)
    {
        null = null;
        if(PlayerEffectContainer.丗上与丈丕丁且七世 == false)
        {
                return false;
        }
        
        if(GameConnect.丘不万丏万万丘丐专() == true)
        {
                return false;
        }
        
        if((this.丗丁丒三丐丞丏万下 != 0) && (this.丗丁丒三丐丞丏万下.丅下万丏丘东丄丌万 != false))
        {
                return false;
        }
        
        if(this.丘专丈一丗下丗上丘 != null)
        {
                return this.丘专丈一丗下丗上丘.ContainsKey(key:  丂丑丑与与丘丁与丙);
        }
        
        return this.丘专丈一丗下丗上丘.ContainsKey(key:  丂丑丑与与丘丁与丙);
    }
    internal float 丛万丟丕丗丒七不丄(丑丄丏丐丅丛丐丆丒 丂丑丑与与丘丁与丙)
    {
        丑丄丏丐丅丛丐丆丒 val_3 = 丂丑丑与与丘丁与丙;
        if((this.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  val_3 = 丂丑丑与与丘丁与丙)) == false)
        {
                return 0f;
        }
        
        val_3 = this.丘专丈一丗下丗上丘.Item[val_3];
        return 0f;
    }
    internal float 七丐下东丂丅丝不丕(丑丄丏丐丅丛丐丆丒 丂丑丑与与丘丁与丙)
    {
        丑丄丏丐丅丛丐丆丒 val_3 = 丂丑丑与与丘丁与丙;
        if((this.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  val_3 = 丂丑丑与与丘丁与丙)) == false)
        {
                return 0f;
        }
        
        val_3 = this.丘专丈一丗下丗上丘.Item[val_3];
        return 0f;
    }
    internal string 万丙丏丞一上丒丆一(丑丄丏丐丅丛丐丆丒 丂丑丑与与丘丁与丙)
    {
        丑丄丏丐丅丛丐丆丒 val_3;
        PlayerEffectSettings val_4;
        val_3 = 丂丑丑与与丘丁与丙;
        if((this.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  val_3)) != false)
        {
                val_3 = this.丘专丈一丗下丗上丘.Item[val_3];
            val_4 = val_2.上丝丝且三三世丝与;
            return (string)val_4;
        }
        
        val_4 = "";
        return (string)val_4;
    }
    internal int[] 丑丕专丙丟丙万丟丏(丑丄丏丐丅丛丐丆丒 丂丑丑与与丘丁与丙)
    {
        丑丄丏丐丅丛丐丆丒 val_4 = 丂丑丑与与丘丁与丙;
        if((this.丙七丛丆丏丅且一东(丂丑丑与与丘丁与丙:  val_4 = 丂丑丑与与丘丁与丙)) != false)
        {
                val_4 = this.丘专丈一丗下丗上丘.Item[val_4];
            if(val_4 != null)
        {
                return (System.Int32[])new int[0];
        }
        
            return (System.Int32[])new int[0];
        }
        
        return (System.Int32[])new int[0];
    }
    internal void 七一丏丛丅丂上丝下(PlayerEffectSettings 世丙丒上一与丝丁三)
    {
        this._listPlayerEffects.Add(item:  new PlayerEffectSettings() {idEffect = 世丙丒上一与丝丁三.idEffect, playerEffects = 世丙丒上一与丝丁三.idEffect, factor = 世丙丒上一与丝丁三.factor});
        this.且万丂丁丞万丐丟丁();
    }
    internal void 万不下丒丛一丒万丘(System.Collections.Generic.List<PlayerEffectSettings> 丒下丅下丁丕丝且丆)
    {
        float val_2;
        string val_4;
        string val_5;
        float val_6;
        List.Enumerator<T> val_1 = 丒下丅下丁丕丝且丆.GetEnumerator();
        label_4:
        if((1264385264 & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = val_5;
        val_2 = val_6;
        this._listPlayerEffects.Add(item:  new PlayerEffectSettings() {idEffect = val_4, playerEffects = val_4, factor = val_2, additionalFactor = val_2, arrayId = val_2});
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.且万丂丁丞万丐丟丁();
    }
    internal void 业业丏丂丄丄丞万东()
    {
        this._listPlayerEffects.Clear();
    }
    internal void 丄丂下丒与且不下且(PlayerEffectSettings 世丙丒上一与丝丁三)
    {
        string val_4;
        System.Int32[] val_5;
        丑丄丏丐丅丛丐丆丒 val_6;
        string val_7;
        System.Collections.Generic.List<PlayerEffectSettings> val_10 = this._listPlayerEffects;
        List.Enumerator<T> val_1 = val_10.GetEnumerator();
        label_3:
        if((1264683968 & 1) == 0)
        {
            goto label_2;
        }
        
        val_10 = val_7;
        if((System.String.op_Equality(a:  val_10, b:  世丙丒上一与丝丁三.idEffect)) == false)
        {
            goto label_3;
        }
        
        val_7 = val_6;
        val_4 = val_10;
        bool val_9 = this._listPlayerEffects.Remove(item:  new PlayerEffectSettings() {idEffect = val_4, playerEffects = val_7, factor = val_7, additionalFactor = val_7, arrayId = val_5});
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.且万丂丁丞万丐丟丁();
    }
    private void 且万丂丁丞万丐丟丁()
    {
        float val_2;
        float val_4;
        var val_5;
        float val_6;
        PlayerEffectSettings val_7;
        丑丄丏丐丅丛丐丆丒 val_8;
        float val_9;
        float val_10;
        丑丄丏丐丅丛丐丆丒 val_35;
        float val_36;
        var val_37;
        float val_38;
        float val_39;
        var val_41;
        var val_42;
        SkinName val_43;
        string val_44;
        SkinName val_45;
        this.丘专丈一丗下丗上丘.Clear();
        List.Enumerator<T> val_1 = this._listPlayerEffects.GetEnumerator();
        goto label_23;
        label_28:
        val_35 = val_8;
        val_36 = val_9;
        if((this.丘专丈一丗下丗上丘.ContainsKey(key:  val_35)) == false)
        {
            goto label_5;
        }
        
        丏丙丘丒上丝丒丁且 val_12 = this.丘专丈一丗下丗上丘.Item[val_35];
        mem2[0] = this.丅东上不上丐七丏一(丒一丈丆下丂不业丕:  this.业上业专东东丕丏下(万丈丛上丞丄丕丑丄:  val_35), 丙业与丙丗丝不丈东:  val_36, 丕业丘世专丐丞丞丙:  val_2);
        if((val_5 - 10) >= 2)
        {
            goto label_9;
        }
        
        val_37 = 3;
        goto label_10;
        label_5:
        new 丏丙丘丒上丝丒丁且() = new 丏丙丘丒上丝丒丁且();
        val_4 = val_6;
        .上丝丝且三三世丝与 = val_7;
        mem[1152921540231593336] = val_35;
        mem[1152921540231593340] = val_36;
        mem[1152921540231593344] = val_10;
        mem[1152921540231593356] = val_5;
        mem[1152921540231593348] = val_4;
        var val_17 = val_35 & 4294967294;
        if(val_17 == 10)
        {
                mem[1152921540231593344] = val_17;
        }
        
        丗丟丝不丄丅万与丞 val_18 = this.业上业专东东丕丏下(万丈丛上丞丄丕丑丄:  val_35);
        if(val_18 == 3)
        {
            goto label_14;
        }
        
        if(val_18 != 2)
        {
            goto label_15;
        }
        
        val_38 = 1f - val_4;
        goto label_16;
        label_9:
        if(val_5 != 6)
        {
            goto label_17;
        }
        
        val_37 = 2;
        goto label_27;
        label_14:
        val_38 = 1f / val_4;
        label_16:
        mem[1152921540231593340] = val_38;
        label_15:
        if(val_35 != 6)
        {
            goto label_19;
        }
        
        label_24:
        val_39 = 1f - val_38;
        goto label_20;
        label_19:
        if((val_35 & 4294967294) != 10)
        {
            goto label_21;
        }
        
        val_39 = 1f / val_38;
        label_20:
        mem[1152921540231593344] = val_39;
        label_25:
        this.丘专丈一丗下丗上丘.Add(key:  val_35, value:  new 丏丙丘丒上丝丒丁且());
        goto label_23;
        label_21:
        if(val_35 == 24)
        {
            goto label_24;
        }
        
        goto label_25;
        label_17:
        if((val_5 & 4294967294) == 10)
        {
                val_37 = 3;
        }
        
        label_27:
        val_36 = val_10;
        label_10:
        mem2[0] = this.丅东上不上丐七丏一(丒一丈丆下丂不业丕:  (val_5 == 24) ? (1 + 1) : 1, 丙业与丙丗丝不丈东:  val_36, 丕业丘世专丐丞丞丙:  val_2);
        label_23:
        if((1264939200 & 1) != 0)
        {
            goto label_28;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        Dictionary.Enumerator<TKey, TValue> val_23 = this.丘专丈一丗下丗上丘.GetEnumerator();
        goto label_44;
        label_67:
        ConfiguredValueTaskAwaiter val_24 = val_4.GetAwaiter();
        int val_25 = val_24._value._obj.丙东专丂世丈丏丁丂();
        if((val_25.业上业专东东丕丏下(万丈丛上丞丄丕丑丄:  val_25)) == 2)
        {
                float val_35 = val_4;
            val_35 = 1f - val_35;
        }
        
        int val_27 = val_24._value._obj.丙东专丂世丈丏丁丂();
        if(val_27 == 6)
        {
            goto label_47;
        }
        
        if((val_27 & 4294967294) != 10)
        {
            goto label_48;
        }
        
        if(val_24._value._obj == 0)
        {
            goto label_49;
        }
        
        val_41 = ;
        val_36 = val_2;
        goto label_50;
        label_48:
        if(val_27 != 24)
        {
            goto label_53;
        }
        
        label_47:
        float val_36 = val_2;
        val_36 = 1f - val_36;
        goto label_53;
        label_49:
        val_36 = 8.96831E-44f;
        val_41 = 32;
        label_50:
        float val_37 = val_35;
        val_37 = val_36 * val_37;
        mem[32] = val_37;
        label_53:
        int val_29 = val_24._value._obj.丙东专丂世丈丏丁丂();
        if(val_29 > 13)
        {
            goto label_54;
        }
        
        if(val_29 > 13)
        {
            goto label_59;
        }
        
        int val_30 = 1 << val_29;
        val_30 = val_30 & 11264;
        if(val_30 != 0)
        {
            goto label_58;
        }
        
        goto label_59;
        label_54:
        if(val_29 != 23)
        {
                if(val_29 != 26)
        {
            goto label_59;
        }
        
        }
        
        label_58:
        val_36 = val_35;
        int val_31 = val_24._value._obj.丙东专丂世丈丏丁丂();
        val_42 = 4f;
        if((val_31 & 4294967294) != 10)
        {
                val_42 = 8f;
        }
        
        float val_34 = UnityEngine.Mathf.Clamp(value:  val_36, min:  0f, max:  (val_31 != 26) ? 1f : 8f);
        label_59:
        val_2 = val_36;
        val_4 = val_4;
        label_44:
        if((1264939136 & 1) != 0)
        {
            goto label_67;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_43 = this.丞丗丄丂丆业丈丑业;
        if(val_43 == null)
        {
            goto label_85;
        }
        
        val_44 = this.丞丗丄丂丆业丈丑业.丌专专万丟业与丂东;
        val_45 = val_43;
        goto label_88;
        label_85:
        val_45 = this.丞丗丄丂丆业丈丑业;
        val_44 = this.丞丗丄丂丆业丈丑业.丌专专万丟业与丂东;
        if(val_45 == null)
        {
            goto label_87;
        }
        
        val_43 = val_45;
        goto label_88;
        label_87:
        val_43 = this.丞丗丄丂丆业丈丑业;
        if(val_43 == null)
        {
            goto label_89;
        }
        
        label_88:
        this.丗丁丒三丐丞丏万下.丒丝丛丗丁三丅一与(丌专专万丟业与丂东:  val_44, 与丁丝七丕业业丄且:  this.丞丗丄丂丆业丈丑业.与丁丝七丕业业丄且, 丁丅上丟丑三且且丆:  this.丞丗丄丂丆业丈丑业.丁丅上丟丑三且且丆);
        this.下丈丛与上业丙下丒(专丞上七七且丝七丗:  0);
        return;
        label_89:
    }
    private 丗丟丝不丄丅万与丞 业上业专东东丕丏下(丑丄丏丐丅丛丐丆丒 万丈丛上丞丄丕丑丄)
    {
        if((万丈丛上丞丄丕丑丄 - 5) > 21)
        {
                return 1;
        }
        
        return (丗丟丝不丄丅万与丞)106025760 + ((万丈丛上丞丄丕丑丄 - 5)) << 2;
    }
    private 丗丟丝不丄丅万与丞 丐丕丁丈丄且丁丐丛(丑丄丏丐丅丛丐丆丒 万丈丛上丞丄丕丑丄)
    {
        if(万丈丛上丞丄丕丑丄 == 6)
        {
                return 2;
        }
        
        if((万丈丛上丞丄丕丑丄 & 4294967294) != 10)
        {
                return (丗丟丝不丄丅万与丞)(万丈丛上丞丄丕丑丄 == 24) ? (1 + 1) : 1;
        }
        
        return 3;
    }
    private float 丅东上不上丐七丏一(丗丟丝不丄丅万与丞 丒一丈丆下丂不业丕, float 丙业与丙丗丝不丈东, float 丕业丘世专丐丞丞丙)
    {
        float val_2 = 丙业与丙丗丝不丈东;
        if((丒一丈丆下丂不业丕 - 1) > 4)
        {
                return (float);
        }
        
        var val_2 = 106025692 + ((丒一丈丆下丂不业丕 - 1)) << 2;
        val_2 = val_2 + 106025692;
        goto (106025692 + ((丒一丈丆下丂不业丕 - 1)) << 2 + 106025692);
    }
    internal void 下丈丛与上业丙下丒(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        System.Int32[] val_3;
        string val_4;
        System.Int32[] val_13;
        var val_14;
        this.不丞丅丌专丝丐丈东.Clear();
        this.丝丂上丂七丙丁丈丕.Clear();
        val_13 = 1152921526036164512;
        this.下丁东上下丗丄丒丑.Clear();
        this.万丑上丌三三专七丐.Clear();
        this.一丟丙丕丗丒东专丒.Clear();
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丘专丈一丗下丗上丘.GetEnumerator();
        goto label_28;
        label_30:
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        var val_13 = val_4;
        if(val_13 > 5)
        {
            goto label_9;
        }
        
        if(val_13 > 5)
        {
            goto label_28;
        }
        
        val_13 = 1 << val_13;
        val_13 = val_13 & 46;
        if(val_13 == 0)
        {
            goto label_28;
        }
        
        goto label_12;
        label_9:
        if(val_13 > 35)
        {
            goto label_28;
        }
        
        var val_14 = val_13;
        val_14 = 1 << val_14;
        val_14 = val_14 & 34410201088;
        if(val_14 == 0)
        {
            goto label_28;
        }
        
        label_12:
        var val_15 = val_4;
        if(val_15 <= 25)
        {
                val_15 = 1 << val_15;
            val_14 = "";
            if((val_15 & 50331712) != 0)
        {
            
        }
        
        }
        
        this.不丞丅丌专丝丐丈东.Add(item:  val_4);
        this.丝丂上丂七丙丁丈丕.Add(item:  val_4);
        this.下丁东上下丗丄丒丑.Add(item:  val_4);
        this.万丑上丌三三专七丐.Add(item:  val_3);
        val_13 = val_3;
        this.一丟丙丕丗丒东专丒.Add(item:  val_13);
        label_28:
        if((1265753824 & 1) != 0)
        {
            goto label_30;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.一丟丙丕丗丒东专丒.Count == 0)
        {
            goto label_57;
        }
        
        if(this.丞丗丄丂丆业丈丑业 != null)
        {
            goto label_60;
        }
        
        label_61:
        label_60:
        this.丞丗丄丂丆业丈丑业.丕丌丏丞丐丕上丗丕(专丞上七七且丝七丗:  专丞上七七且丝七丗, 丕七七丄万丄丘丂丑:  this.不丞丅丌专丝丐丈东.ToArray(), 丏世丅丘专丕丛世上:  this.丝丂上丂七丙丁丈丕.ToArray(), 丁万世世丒丈世丙丛:  this.下丁东上下丗丄丒丑.ToArray(), 下丄丙丄一丒一业世:  this.万丑上丌三三专七丐.ToArray(), 专丞丁世丈下且丁丑:  this.一丟丙丕丗丒东专丒.ToArray());
        return;
        label_57:
        if(this.丞丗丄丂丆业丈丑业 != null)
        {
            goto label_60;
        }
        
        goto label_61;
    }
    internal void 丑万丕与丅丏丄万上(string[] 丕七七丄万丄丘丂丑, int[] 丏世丅丘专丕丛世上, float[] 丁万世世丒丈世丙丛, float[] 下丄丙丄一丒一业世, int[][] 专丞丁世丈下且丁丑)
    {
        System.Int32[] val_4;
        System.Collections.Generic.Dictionary<丑丄丏丐丅丛丐丆丒, 丏丙丘丒上丝丒丁且> val_5;
        System.Single[] val_6;
        var val_7;
        System.Int32[] val_8;
        val_4 = 丏世丅丘专丕丛世上;
        val_5 = this.丘专丈一丗下丗上丘;
        val_5.Clear();
        val_6 = 下丄丙丄一丒一业世;
        val_7 = 0;
        goto label_2;
        label_17:
        val_5 = val_4[0];
        System.Single[] val_1 = 丁万世世丒丈世丙丛 + 0;
        System.Single[] val_2 = val_6 + 0;
        if(val_7 < 专丞丁世丈下且丁丑.Length)
        {
                val_8 = 专丞丁世丈下且丁丑[0];
        }
        else
        {
                val_8 = 0;
        }
        
        .上丝丝且三三世丝与 = 丕七七丄万丄丘丂丑[0];
        mem[1152921540233224440] = val_5;
        mem[1152921540233224444] = (丁万世世丒丈世丙丛 + 0) + 32;
        mem[1152921540233224448] = (下丄丙丄一丒一业世 + 0) + 32;
        mem[1152921540233224452] = 0;
        mem[1152921540233224456] = val_8;
        this.丘专丈一丗下丗上丘.Add(key:  val_5, value:  new 丏丙丘丒上丝丒丁且());
        val_6 = 下丄丙丄一丒一业世;
        val_4 = val_4;
        val_7 = 1;
        label_2:
        if(val_7 < 丕七七丄万丄丘丂丑.Length)
        {
            goto label_17;
        }
    
    }
    private void 丛万业一三丝丌专丘(string[] 丕七七丄万丄丘丂丑, int[] 丏世丅丘专丕丛世上, float[] 丁万世世丒丈世丙丛, float[] 下丙丆丙下丟丝一丅)
    {
        var val_4;
        string val_5;
        val_4 = 0;
        val_5 = "Player Effect \n";
        goto label_1;
        label_26:
        object[] val_1 = new object[4];
        string val_4 = 丕七七丄万丄丘丂丑[0];
        if(val_1 == null)
        {
            goto label_4;
        }
        
        if(val_4 != null)
        {
            goto label_5;
        }
        
        goto label_8;
        label_4:
        if(val_4 == null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_1[0] = val_4;
        val_1[1] = 丏世丅丘专丕丛世上[0];
        val_1[2] = 丁万世世丒丈世丙丛[0];
        val_1[3] = 下丙丆丙下丟丝一丅[0];
        val_5 = val_5 + System.String.Format(format:  "effectName  {0} effectType {1} Factor {2} Additional Factor {3}\n", args:  val_1)(System.String.Format(format:  "effectName  {0} effectType {1} Factor {2} Additional Factor {3}\n", args:  val_1));
        val_4 = 1;
        label_1:
        if(val_4 < 丕七七丄万丄丘丂丑.Length)
        {
            goto label_26;
        }
        
        UnityEngine.Debug.LogError(message:  val_5);
    }
    private void 丛万业一三丝丌专丘()
    {
        var val_3;
        string val_4;
        Dictionary.Enumerator<TKey, TValue> val_1 = this.丘专丈一丗下丗上丘.GetEnumerator();
        label_39:
        if((1267208992 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_5 = val_4.GetAwaiter();
        string[] val_6 = new string[10];
        val_6[0] = "Player Effect \n";
        val_6[1] = "effectName  ";
        val_6[2] = val_4;
        val_6[3] = " effectType ";
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_6[4] = val_4.ToString();
        val_6[5] = " Factor ";
        val_6[6] = val_4.ToString();
        val_6[7] = " additional factor ";
        val_6[8] = val_3.ToString();
        val_6[9] = " \n";
        string val_10 = +val_6;
        goto label_39;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.Debug.LogError(message:  "Player Effect \n");
    }
    private void 丈丆世丟东一三丈丈()
    {
        this.七一丏丛丅丂上丝下(世丙丒上一与丝丁三:  new PlayerEffectSettings() {idEffect = this._playerSettings, playerEffects = this._playerSettings, factor = ???, additionalFactor = ???, arrayId = ???});
    }
    private void 专万世丂不丅丏世七()
    {
        this.丄丂下丒与且不下且(世丙丒上一与丝丁三:  new PlayerEffectSettings() {idEffect = this._playerSettings, playerEffects = this._playerSettings, factor = ???, additionalFactor = ???, arrayId = ???});
    }
    private void 丁丏丘丘一七丈上丈()
    {
        UnityEngine.Debug.LogError(message:  "Count " + 丅丄丕不丏丛三丑一.丏专丄专丙丑丈丗丕().Count);
    }
    private bool 三丙丌万丘与一丙丝(丑丄丏丐丅丛丐丆丒 丏丟丌丙丏丏丒三丆)
    {
        var val_4;
        var val_5;
        if(丏丟丌丙丏丏丒三丆 <= 5)
        {
                丑丄丏丐丅丛丐丆丒 val_1 = 丏丟丌丙丏丏丒三丆 - 1;
            if(val_1 >= 5)
        {
                return false;
        }
        
            val_4 = val_1 & 31;
            val_5 = 23;
        }
        else
        {
                丑丄丏丐丅丛丐丆丒 val_2 = 丏丟丌丙丏丏丒三丆 - 17;
            if(val_2 >= 19)
        {
                return false;
        }
        
            val_4 = val_2 & 524287;
            val_5 = 262144;
            val_5 = 4;
        }
        
        val_4 = 262529 >> val_4;
        return (bool)val_4 & 1;
    }
    private bool 丏丟三上丂上丝丒丐(丑丄丏丐丅丛丐丆丒 丏丟丌丙丏丏丒三丆)
    {
        if(丏丟丌丙丏丏丒三丆 != 6)
        {
                return (bool)((丏丟丌丙丏丏丒三丆 & 4294967294) == 24) ? 1 : 0;
        }
        
        return true;
    }
    private bool 丏丝与下丝丌丅下丏(丑丄丏丐丅丛丐丆丒 丏丟丌丙丏丏丒三丆)
    {
        if(丏丟丌丙丏丏丒三丆 <= 13)
        {
                丑丄丏丐丅丛丐丆丒 val_1 = 丏丟丌丙丏丏丒三丆 - 10;
            if(val_1 >= 4)
        {
                return false;
        }
        
            val_1 = val_1 & 15;
            val_1 = 11 >> val_1;
            return (bool)val_1 & 1;
        }
        
        if(丏丟丌丙丏丏丒三丆 == 23)
        {
                return true;
        }
        
        if(丏丟丌丙丏丏丒三丆 != 26)
        {
                return false;
        }
        
        return true;
    }
    private float 一东东一专丆丙业丗(丑丄丏丐丅丛丐丆丒 丏丟丌丙丏丏丒三丆)
    {
        if((丏丟丌丙丏丏丒三丆 & 4294967294) == 10)
        {
                return 4f;
        }
        
        if(丏丟丌丙丏丏丒三丆 != 23)
        {
                return (float)(丏丟丌丙丏丏丒三丆 != 26) ? 1f : 8f;
        }
        
        return 8f;
    }
    public PlayerEffectContainer()
    {
        this._listPlayerEffects = new System.Collections.Generic.List<PlayerEffectSettings>();
        this.丘专丈一丗下丗上丘 = new System.Collections.Generic.Dictionary<丑丄丏丐丅丛丐丆丒, 丏丙丘丒上丝丒丁且>();
        this.不丞丅丌专丝丐丈东 = new System.Collections.Generic.List<System.String>();
        this.丝丂上丂七丙丁丈丕 = new System.Collections.Generic.List<System.Int32>();
        this.下丁东上下丗丄丒丑 = new System.Collections.Generic.List<System.Single>();
        this.万丑上丌三三专七丐 = new System.Collections.Generic.List<System.Single>();
        this.一丟丙丕丗丒东专丒 = new System.Collections.Generic.List<System.Int32[]>();
    }
    private static PlayerEffectContainer()
    {
        PlayerEffectContainer.丗上与丈丕丁且七世 = true;
    }

}
