using UnityEngine;
[Serializable]
internal sealed class WaveSettings
{
    // Fields
    public System.Collections.Generic.List<float> listTimeDelayWave;
    public System.Collections.Generic.List<float> listTimeWave;
    public float timeToStartGame;
    public int countWave;
    public System.Collections.Generic.List<FortPointSpawnInfo> listFortPointInfo;
    public float damagePercent;
    public float healthPercent;
    
    // Methods
    public int 丐丗世丈丏丏丗丁上(int 三丗丄丒下丕丛丅丈)
    {
        var val_2;
        var val_7;
        var val_8;
        List.Enumerator<T> val_1 = this.listFortPointInfo.GetEnumerator();
        val_8 = 0;
        goto label_4;
        label_6:
        ConfiguredValueTaskAwaiter val_4 = val_2.GetAwaiter();
        val_7 = val_4._value._token;
        if(val_7.Count > 三丗丄丒下丕丛丅丈)
        {
                FortWaveSpawnInfo val_6 = val_7.Item[三丗丄丒下丕丛丅丈];
        }
        
        label_4:
        if((1178611984 & 1) != 0)
        {
            goto label_6;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int);
    }
    public int 专与专且丅丆丝上丁()
    {
        var val_3;
        var val_7;
        var val_8;
        var val_9;
        List.Enumerator<T> val_1 = this.listFortPointInfo.GetEnumerator();
        val_7 = 0;
        val_8 = 0;
        var val_7 = 0;
        label_13:
        if((1178736256 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_4 = val_3.GetAwaiter();
        List.Enumerator<T> val_5 = val_4._value._token.GetEnumerator();
        goto label_4;
        label_5:
        ConfiguredValueTaskAwaiter val_6 = val_3.GetAwaiter();
        label_4:
        if((1178736224 & 1) != 0)
        {
            goto label_5;
        }
        
        val_7 = val_7 + 1;
        mem2[0] = 79;
        val_9 = val_8;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_7 == 1) || ((1152921540145321504 + ((0 + 1)) << 2) != 79))
        {
            goto label_10;
        }
        
        var val_8 = 0;
        val_8 = val_8 ^ (val_7 >> 31);
        val_7 = val_7 + val_8;
        goto label_13;
        label_10:
        if( == 0)
        {
            goto label_13;
        }
        
        goto label_13;
        label_2:
        val_7 = val_7 + 1;
        mem2[0] = 104;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_7 == 1)
        {
            goto label_18;
        }
        
        if(( == 0) || ((1152921540145321504 + ((0 + 1)) << 2) == 104))
        {
            goto label_22;
        }
        
        label_21:
        label_22:
        return (int);
        label_18:
        if( != 0)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    public static System.Collections.Generic.List<WaveSettings.东万上世专万上与丐> 与丂世丘丅丈丁三丘(System.Collections.Generic.Dictionary<string, object> 丁丘丄丕下专东七不)
    {
        var val_11;
        var val_21;
        var val_22;
        int val_23;
        int val_24;
        System.Collections.Generic.List<丘且丌上不丅且七丙> val_25;
        var val_39;
        var val_49;
        float val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        object val_55;
        var val_56;
        var val_59;
        var val_60;
        var val_61;
        if((丁丘丄丕下专东七不.ContainsKey(key:  "w")) == false)
        {
                return 0;
        }
        
        if((丁丘丄丕下专东七不.ContainsKey(key:  "t")) == false)
        {
                return 0;
        }
        
        if((丁丘丄丕下专东七不.ContainsKey(key:  "c")) == false)
        {
                return 0;
        }
        
        if((丁丘丄丕下专东七不.ContainsKey(key:  "f")) == false)
        {
                return 0;
        }
        
        if((丁丘丄丕下专东七不.ContainsKey(key:  "w")) != false)
        {
                object val_6 = 丁丘丄丕下专东七不.Item["w"];
        }
        
        return 0;
        label_116:
        string val_12 = val_11.丐丏七丌丕丗业且上();
        System.Collections.Generic.List<下专丛丄下丛丅丆丐> val_13 = new System.Collections.Generic.List<下专丛丄下丛丅丆丐>();
        if((0.ContainsKey(key:  "t")) == false)
        {
            goto label_20;
        }
        
        val_49 = 1152921516789140576;
        val_50 = System.Convert.ToSingle(value:  0.Item["t"]);
        if((1 & 1) != 0)
        {
            goto label_24;
        }
        
        goto label_26;
        label_20:
        val_50 = 0;
        if((1 & 1) == 0)
        {
            goto label_26;
        }
        
        label_24:
        val_51 = 0;
        if( != null)
        {
            goto label_33;
        }
        
        goto label_28;
        label_26:
        if((0.ContainsKey(key:  "s")) != false)
        {
                object val_18 = 0.Item["s"];
        }
        
        val_51 = 0;
        label_115:
        val_50 = val_50;
        if( != null)
        {
            goto label_33;
        }
        
        label_28:
        val_50 = val_50;
        label_33:
        Add(item:  new 东万上世专万上与丐() {丞不丏丘业丅丌与世 = val_50});
        goto label_34;
        label_90:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((0 != 1) && (val_22 == 574))
        {
            
        }
        
         = val_23 + ;
        null.Add(item:  new 下专丛丄下丛丅丆丐() {不丘丅丏东丘下专丒 = ???, 丏丐丐丅业上丁丈丏 = val_23, 不下丟丁丟丑丅且丐 = val_24, 东不七丄丙丄七专业 = val_25});
        val_52 = 1152921516789140576;
        label_57:
        if((1178919872 & 1) == 0)
        {
            goto label_42;
        }
        
        string val_26 = val_21.丐丏七丌丕丗业且上();
        System.Collections.Generic.List<丘且丌上不丅且七丙> val_27 = null;
        val_25 = val_27;
        val_27 = new System.Collections.Generic.List<丘且丌上不丅且七丙>();
        val_23 = 1;
        if((0.ContainsKey(key:  "t")) != false)
        {
                float val_30 = System.Convert.ToSingle(value:  0.Item["t"]);
        }
        
        if((0.ContainsKey(key:  "sl")) != false)
        {
                val_24 = System.Convert.ToInt32(value:  0.Item["sl"]);
        }
        else
        {
                val_24 = 0;
        }
        
        if((0.ContainsKey(key:  "m")) == false)
        {
            goto label_57;
        }
        
        object val_35 = 0.Item["m"];
        if(val_35 != null)
        {
                val_53 = null;
        }
        
        if(val_35 != null)
        {
                val_53 = null;
        }
        
        List.Enumerator<T> val_37 = GetEnumerator();
        val_23 = 0;
        label_89:
        if((1178919840 & 1) == 0)
        {
            goto label_66;
        }
        
        string val_40 = val_39.丐丏七丌丕丗业且上();
        if(val_40 != null)
        {
                val_54 = null;
        }
        
        if(val_40 != null)
        {
                val_54 = null;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_42 = GetEnumerator();
        label_77:
        if((1178919792 & 1) == 0)
        {
            goto label_73;
        }
        
        ConfiguredValueTaskAwaiter val_44 = val_11.GetAwaiter();
        val_55 = ;
        int val_47 = System.Convert.ToInt32(value:  val_44._value._obj);
        int val_49 = val_23;
        val_49 = val_47 + val_49;
        val_23 = val_49;
        if(val_25 == 0)
        {
                val_55 = val_47;
        }
        
        val_27.Add(item:  new 丘且丌上不丅且七丙() {丌不丏丟万丛丕与丟 = "Enemy" + val_44._value._obj.丐丏七丌丕丗业且上() + "_go", 丌丒丝东丌下丕丁丅 = val_55});
        goto label_77;
        label_73:
        var val_50 = 0;
        val_56 = 0;
        val_50 = val_50 + 1;
        mem2[0] = 546;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_50 == 1) || ((1152921540145504960 + ((0 + 1)) << 2) != 546))
        {
            goto label_86;
        }
        
        var val_52 = val_50;
        var val_51 = 0;
        val_51 = val_51 ^ (val_52 >> 31);
        val_52 = val_52 + val_51;
        goto label_89;
        label_86:
        if( == 0)
        {
            goto label_89;
        }
        
        goto label_89;
        label_66:
        var val_53 = val_52;
        val_53 = val_53 + 1;
        mem2[0] = 574;
        goto label_90;
        label_42:
        var val_54 = val_53;
        val_54 = val_54 + 1;
        mem2[0] = 633;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_56 = val_54;
        if((val_56 == 1) || ((1152921540145504960 + (((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + 1)) << 2) != 633))
        {
            goto label_112;
        }
        
        var val_55 = 0;
        val_55 = val_55 ^ (val_56 >> 31);
        val_56 = val_56 + val_55;
        goto label_115;
        label_112:
        if(val_21 == 0)
        {
            goto label_115;
        }
        
        goto label_115;
        label_34:
        if((1178919904 & 1) != 0)
        {
            goto label_116;
        }
        
        val_59 = 0;
        val_60 = 0;
        val_61 = val_56 + 1;
        mem2[0] = 668;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return 0;
        }
        
            if((1152921540145504960 + ((((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + 1) + (0 ^ ((int)((((0 + 1) + (0 ^ ((int)(0 + 1)) >> 31)) + 1) + 1)) >> 31))) << 2) != 668)
        {
                return 0;
        }
        
            return 0;
        }
        
        if( == 0)
        {
                return 0;
        }
        
        return 0;
    }
    public static WaveSettings 丌丝丑三不丄丆丕丙(WaveSettings 丐丗三丂丙丘万且丛, System.Collections.Generic.List<WaveSettings.东万上世专万上与丐> 丑丛丘丆丝丄丐丙且, int 丂丛丛丘丆与丏丈丘)
    {
        var val_5;
        var val_10;
        float val_20;
        var val_21;
        var val_22;
        var val_25;
        var val_35;
        short val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        float val_47;
        var val_48;
        var val_49;
        int val_50;
        var val_51;
        var val_52;
        var val_54;
        float val_55;
        var val_56;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(丂丛丛丘丆与丏丈丘 >= 1)
        {
                val_41 = 1152921516995548064;
            var val_41 = 0;
            do
        {
            val_1.Add(item:  0);
            丐丗三丂丙丘万且丛.listFortPointInfo.Add(item:  new FortPointSpawnInfo() {listWaveFort = new System.Collections.Generic.List<FortWaveSpawnInfo>()});
            val_41 = val_41 + 1;
        }
        while(丂丛丛丘丆与丏丈丘 != val_41);
        
        }
        
        List.Enumerator<T> val_3 = 丑丛丘丆丝丄丐丙且.GetEnumerator();
        val_43 = 1152921540145690400;
        val_44 = 0;
        val_45 = 0;
        val_46 = 0;
        goto label_7;
        label_104:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        val_41 = val_6._value._token;
        val_47 = 0f;
        if(丐丗三丂丙丘万且丛.listTimeDelayWave.Count > 0)
        {
                val_47 = 丐丗三丂丙丘万且丛.listTimeDelayWave.Item[0];
        }
        
        List.Enumerator<T> val_9 = 丐丗三丂丙丘万且丛.listFortPointInfo.GetEnumerator();
        val_47 = val_47 + 0f;
        label_18:
        if((1179195632 & 1) == 0)
        {
            goto label_13;
        }
        
        ConfiguredValueTaskAwaiter val_12 = val_10.GetAwaiter();
        System.Collections.Generic.List<FortSubWaveSpawnInfo> val_13 = new System.Collections.Generic.List<FortSubWaveSpawnInfo>();
        val_12._value._token.Add(item:  new FortWaveSpawnInfo() {delayWave = 丐丗三丂丙丘万且丛.listTimeDelayWave.Item[0]});
        goto label_18;
        label_13:
        val_48 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_48 == 1) || (272 != 272))
        {
            goto label_27;
        }
        
        var val_42 = 0;
        val_42 = val_42 ^ 0;
        val_48 = val_48 + val_42;
        if(val_41 != 0)
        {
            goto label_33;
        }
        
        goto label_32;
        label_27:
        if( == 0)
        {
            goto label_30;
        }
        
        val_44 = 0;
        val_49 = 0;
        if(val_41 != 0)
        {
            goto label_33;
        }
        
        goto label_32;
        label_30:
        val_44 = 0;
        if(val_41 != 0)
        {
            goto label_33;
        }
        
        label_32:
        label_33:
        List.Enumerator<T> val_16 = val_41.GetEnumerator();
        float val_47 = 0f;
        label_74:
        if((1179195568 & 1) == 0)
        {
            goto label_34;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_19 = val_5.RemoteEndpoint;
        val_50 = val_21;
        System.Collections.Generic.List<MobSettings> val_23 = new System.Collections.Generic.List<MobSettings>();
        List.Enumerator<T> val_24 = val_22.GetEnumerator();
        label_40:
        label_37:
        if((1179195536 & 1) == 0)
        {
            goto label_36;
        }
        
        ConfiguredValueTaskAwaiter val_27 = val_25.GetAwaiter();
        if(val_27._value._token < 1)
        {
            goto label_37;
        }
        
        var val_43 = 0;
        do
        {
            val_47 = val_47 + val_6._value._obj;
            null.Add(item:  new MobSettings() {nameBot = val_27._value._obj});
            val_43 = val_43 + 1;
        }
        while(val_43 < val_27._value._token);
        
        goto label_40;
        label_36:
        val_51 = val_48 + 1;
        mem2[0] = 438;
        val_52 = 1152921540145747680;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && (272 == 438))
        {
                var val_44 = 0;
            val_44 = val_44 ^ 0;
            val_51 =  + val_44;
        }
        else
        {
                if( != 0)
        {
                val_54 = 0;
        }
        
        }
        
        if(val_50 == 1)
        {
            goto label_49;
        }
        
        if(丐丗三丂丙丘万且丛 != null)
        {
            goto label_57;
        }
        
        goto label_51;
        label_49:
        if(0 != 1)
        {
                val_1.Add(item:  0);
        }
        
        val_50 = val_1.Item[UnityEngine.Random.Range(min:  0, max:  val_1.Count)];
        bool val_31 = val_1.Remove(item:  val_50);
        if(丐丗三丂丙丘万且丛 != null)
        {
            goto label_57;
        }
        
        label_51:
        label_57:
        FortPointSpawnInfo val_32 = 丐丗三丂丙丘万且丛.listFortPointInfo.Item[val_50];
        FortWaveSpawnInfo val_33 = val_32.listWaveFort.Item[0];
        List.Enumerator<T> val_34 = val_33.subWaveSpawnInfo.GetEnumerator();
        val_55 = 0f;
        goto label_61;
        label_62:
        ConfiguredValueTaskAwaiter val_37 = val_35.GetAwaiter();
        float val_46 = val_37._value._token >> 32;
        val_55 = val_55 + val_46;
        label_61:
        if((1179195504 & 1) != 0)
        {
            goto label_62;
        }
        
         =  + 1;
        mem2[0] = 599;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( != 1) && ((1179195264 + ((val_53 + 1)) << 2) == 599))
        {
                var val_45 = 0;
            val_45 = val_45 ^ ( >> 31);
             =  + val_45;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        val_47 = val_20 + val_47;
        FortPointSpawnInfo val_39 = 丐丗三丂丙丘万且丛.listFortPointInfo.Item[val_50];
        FortWaveSpawnInfo val_40 = val_39.listWaveFort.Item[0];
        val_46 = val_47 - val_55;
        val_47 = val_47 + val_20;
        val_40.subWaveSpawnInfo.Add(item:  new FortSubWaveSpawnInfo() {delaySpawnMob = val_6._value._obj & 4294967295, delaySubWave = val_46});
        goto label_74;
        label_34:
        val_46 = val_48 + 1;
        mem2[0] = 711;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (272 != 711))
        {
            goto label_96;
        }
        
        var val_48 = 0;
        val_48 = val_48 ^ 0;
        val_46 =  + val_48;
        if(丐丗三丂丙丘万且丛 != null)
        {
            goto label_102;
        }
        
        goto label_101;
        label_96:
        if( == 0)
        {
            goto label_99;
        }
        
        val_44 = 0;
        val_45 = 0;
        if(丐丗三丂丙丘万且丛 != null)
        {
            goto label_102;
        }
        
        goto label_101;
        label_99:
        val_44 = 0;
        if(丐丗三丂丙丘万且丛 != null)
        {
            goto label_102;
        }
        
        label_101:
        label_102:
        丐丗三丂丙丘万且丛.listTimeWave.Add(item:  val_47);
        val_43 = 1152921540145690400;
        label_7:
        if((1179195664 & 1) != 0)
        {
            goto label_104;
        }
        
        val_56 =  + 1;
        mem2[0] = 755;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_48 != 1)
        {
                if( == 0)
        {
                return (WaveSettings)丐丗三丂丙丘万且丛;
        }
        
            if(272 == 755)
        {
                return (WaveSettings)丐丗三丂丙丘万且丛;
        }
        
            return (WaveSettings)丐丗三丂丙丘万且丛;
        }
        
        if( != 0)
        {
                return (WaveSettings)丐丗三丂丙丘万且丛;
        }
        
        return (WaveSettings)丐丗三丂丙丘万且丛;
    }
    public WaveSettings()
    {
        this.listTimeDelayWave = new System.Collections.Generic.List<System.Single>();
        this.listTimeWave = new System.Collections.Generic.List<System.Single>();
        this.listFortPointInfo = new System.Collections.Generic.List<FortPointSpawnInfo>();
        this.damagePercent = 1f;
        this.healthPercent = 1f;
    }

}
