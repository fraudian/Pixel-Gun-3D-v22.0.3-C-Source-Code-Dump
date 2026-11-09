using UnityEngine;
internal sealed class WaveSettingsConttroller : VTableHolder
{
    // Fields
    public System.Collections.Generic.List<float> listTimeDelayWave;
    public float timeToStartGame;
    public int countWave;
    public float damagePercent;
    public float healthPercent;
    private FortMobWavesController 丏丝与丒丏丐丗世业;
    private System.Collections.Generic.List<SettingsSpawnMobWave> _listPointSpawn;
    private bool 丈丁丒业丝丗且丐丝;
    private System.Collections.Generic.List<WaveSettingsConttroller.WaveSettingsMob> 丆丂三丐丕三丌丑万;
    private bool 丆世不丄业丘丆且丒;
    
    // Properties
    internal System.Collections.Generic.List<WaveSettingsConttroller.WaveSettingsMob> 丄丟丒一丗丂七下丗 { get; }
    
    // Methods
    public int GetCountMobsInWave(int 三丗丄丒下丕丛丅丈)
    {
        int val_3;
        int val_4;
        val_3 = 三丗丄丒下丕丛丅丈;
        if(this.丆丂三丐丕三丌丑万.Count > val_3)
        {
                val_3 = this.丆丂三丐丕三丌丑万.Item[val_3];
            val_4 = val_2.countMob;
            return (int)val_4;
        }
        
        val_4 = 0;
        return (int)val_4;
    }
    public int GetLastWave()
    {
        int val_1 = this.丆丂三丐丕三丌丑万.Count;
        val_1 = val_1 - 1;
        return (int)val_1;
    }
    public int GetCountMobs()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.丆丂三丐丕三丌丑万.GetEnumerator();
        val_3 = 0;
        goto label_2;
        label_4:
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_3 = val_2.m_stringLength + val_3;
        label_2:
        if((1179792184 & 1) != 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_3;
    }
    public void Initialize(FortMobWavesController 丏丈三与丝丝丁且丛)
    {
        this.丏丝与丒丏丐丗世业 = 丏丈三与丝丝丁且丛;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        GameModeController.add_OnConnectionMode(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void WaveSettingsConttroller::丄不专丞丏丌丒丄丞(bool 丂丘下万丈丘丅一丄)));
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        GameModeController.remove_OnConnectionMode(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void WaveSettingsConttroller::丄不专丞丏丌丒丄丞(bool 丂丘下万丈丘丅一丄)));
    }
    public void SetPointSpawn(System.Collections.Generic.List<SettingsSpawnMobWave> 丅专与丒丈丗丒丘丌)
    {
        var val_4;
        System.Func<SettingsSpawnMobWave, System.Int32> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = WaveSettingsConttroller.<>c.<>9__14_0;
        if(val_6 == null)
        {
                System.Func<SettingsSpawnMobWave, System.Int32> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<SettingsSpawnMobWave, System.Int32>(object:  WaveSettingsConttroller.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 WaveSettingsConttroller.<>c::丙七专不丈丕三东丕(SettingsSpawnMobWave 三丟东丕丄丄下下丑));
            WaveSettingsConttroller.<>c.<>9__14_0 = val_6;
        }
        
        this._listPointSpawn = System.Linq.Enumerable.ToList<SettingsSpawnMobWave>(source:  System.Linq.Enumerable.OrderBy<SettingsSpawnMobWave, System.Int32>(source:  丅专与丒丈丗丒丘丌, keySelector:  val_1));
    }
    private void 丄不专丞丏丌丒丄丞(bool 丂丘下万丈丘丅一丄)
    {
        this.丈丁丒业丝丗且丐丝 = true;
    }
    internal System.Collections.Generic.List<WaveSettingsConttroller.WaveSettingsMob> 丐丁且丞丐丞丟下丝()
    {
        return (System.Collections.Generic.List<WaveSettingsMob>)this.丆丂三丐丕三丌丑万;
    }
    public void Parse(System.Collections.Generic.Dictionary<string, object> 丁丘丄丕下专东七不)
    {
        var val_4;
        float val_26;
        System.IFormatProvider val_27;
        object val_1 = 丁丘丄丕下专东七不.Item["t"];
        if(val_1 == null)
        {
            goto label_18;
        }
        
        List.Enumerator<T> val_2 = val_1.GetEnumerator();
        label_11:
        if((1180604400 & 1) == 0)
        {
            goto label_5;
        }
        
        this.listTimeDelayWave.Add(item:  System.Convert.ToSingle(value:  val_4.丐丏七丌丕丗业且上(), provider:  System.Globalization.CultureInfo.InvariantCulture));
        goto label_11;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(丁丘丄丕下专东七不 != null)
        {
            goto label_19;
        }
        
        goto label_13;
        label_18:
        if(丁丘丄丕下专东七不 != null)
        {
            goto label_19;
        }
        
        label_13:
        label_19:
        this.countWave = System.Convert.ToInt32(value:  丁丘丄丕下专东七不.Item["c"], provider:  System.Globalization.CultureInfo.InvariantCulture);
        if(丁丘丄丕下专东七不 != null)
        {
                val_26 = (float)System.Convert.ToInt32(value:  丁丘丄丕下专东七不.Item["f"], provider:  System.Globalization.CultureInfo.InvariantCulture);
            this.timeToStartGame = val_26;
        }
        else
        {
                val_26 = (float)System.Convert.ToInt32(value:  丁丘丄丕下专东七不.Item["f"], provider:  System.Globalization.CultureInfo.InvariantCulture);
            this.timeToStartGame = val_26;
        }
        
        if((丁丘丄丕下专东七不.ContainsKey(key:  "d")) != false)
        {
                this.damagePercent = System.Convert.ToSingle(value:  丁丘丄丕下专东七不.Item["d"], provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        
        val_27 = "h";
        if((丁丘丄丕下专东七不.ContainsKey(key:  "h")) == false)
        {
                return;
        }
        
        val_27 = System.Globalization.CultureInfo.InvariantCulture;
        this.healthPercent = System.Convert.ToSingle(value:  丁丘丄丕下专东七不.Item["h"], provider:  val_27);
    }
    internal int 丘万丆丂丄万丐下丕(int 丞丌丌丕丆世七一丏)
    {
        if((丞丌丌丕丆世七一丏 & 2147483648) != 0)
        {
                return 0;
        }
        
        if(this.丆丂三丐丕三丌丑万.Count <= 丞丌丌丕丆世七一丏)
        {
                return 0;
        }
        
        WaveSettingsMob val_2 = this.丆丂三丐丕三丌丑万.Item[丞丌丌丕丆世七一丏];
        if(val_2.listMobSettings != null)
        {
                return val_2.listMobSettings.Count;
        }
        
        return val_2.listMobSettings.Count;
    }
    internal void 丟丕丏专专丙专丂丗(int 丞丌丌丕丆世七一丏, int 一丝丁一下不丑七丆)
    {
        if(this.丆丂三丐丕三丌丑万.Count <= 丞丌丌丕丆世七一丏)
        {
                return;
        }
        
        WaveSettingsMob val_2 = this.丆丂三丐丕三丌丑万.Item[丞丌丌丕丆世七一丏];
        if(val_2.listMobSettings.Count <= 一丝丁一下不丑七丆)
        {
                return;
        }
        
        SettingsMob val_4 = val_2.listMobSettings.Item[一丝丁一下不丑七丆];
        SettingsMob val_7 = val_2.listMobSettings.Item[一丝丁一下不丑七丆];
        this._listPointSpawn.Item[val_4.delaySpawnMob >> 32].丟丕丏专专丙专丂丗(丗丙丒一且丝丂丒世:  val_7.name, 丞丌丌丕丆世七一丏:  丞丌丌丕丆世七一丏);
    }
    internal float 丁专丕丈下且与且与(int 丞丌丌丕丆世七一丏, int 一丝丁一下不丑七丆)
    {
        System.Collections.Generic.List<SettingsMob> val_5;
        var val_6;
        val_5 = this;
        val_6 = 0f;
        if(this.丆丂三丐丕三丌丑万.Count <= 丞丌丌丕丆世七一丏)
        {
                return (float)val_6;
        }
        
        WaveSettingsMob val_2 = this.丆丂三丐丕三丌丑万.Item[丞丌丌丕丆世七一丏];
        val_5 = val_2.listMobSettings;
        if(val_5.Count <= 一丝丁一下不丑七丆)
        {
                return (float)val_6;
        }
        
        SettingsMob val_4 = val_2.listMobSettings.Item[一丝丁一下不丑七丆];
        val_6 = val_4.delaySpawnMob;
        return (float)val_6;
    }
    public void ConvertWaveSettings(System.Collections.Generic.List<WaveSettings.东万上世专万上与丐> 与不丕丆丈不丙丟丛)
    {
        var val_3;
        var val_10;
        float val_11;
        var val_12;
        var val_17;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_35;
        var val_38;
        List.Enumerator<T> val_1 = 与不丕丆丈不丙丟丛.GetEnumerator();
        val_26 = 0;
        val_27 = 0;
        label_39:
        if((1181292944 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_4 = val_3.GetAwaiter();
        new WaveSettingsConttroller.WaveSettingsMob() = new System.Object();
        System.Collections.Generic.List<SettingsMob> val_6 = new System.Collections.Generic.List<SettingsMob>();
        .listMobSettings = null;
        List.Enumerator<T> val_7 = val_4._value._token.GetEnumerator();
        label_26:
        if((1181292896 & 1) == 0)
        {
            goto label_5;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_9 = val_3.RemoteEndpoint;
        val_28 = val_10;
        float val_26 = val_11;
        if(val_28 == 1)
        {
                val_28 = UnityEngine.Random.Range(min:  0, max:  mem[1152921540147890536].Count);
        }
        
        List.Enumerator<T> val_15 = val_12.GetEnumerator();
        val_26 = val_26 + val_4._value._obj;
        goto label_9;
        label_16:
        ConfiguredValueTaskAwaiter val_19 = val_17.GetAwaiter();
        if(val_28 >= 1)
        {
                var val_27 = 0;
            do
        {
            val_29 = val_4._value._obj;
            (WaveSettingsConttroller.WaveSettingsMob)[1152921540147926560].listMobSettings.Add(item:  new SettingsMob() {delaySpawnMob = (val_28 << 32) | ((0 == (val_12.Count - 1)) ? (val_26) : val_4._value._obj), numberPoint = (val_28 << 32) | ((0 == (val_12.Count - 1)) ? (val_26) : val_4._value._obj), name = val_19._value._obj});
            int val_28 = (WaveSettingsConttroller.WaveSettingsMob)[1152921540147926560].countMob;
            val_27 = val_27 + 1;
            val_28 = val_28 + 1;
            .countMob = val_28;
        }
        while(val_27 < val_19._value._token);
        
        }
        
        label_9:
        if((1181292864 & 1) != 0)
        {
            goto label_16;
        }
        
        val_30 = val_27;
        val_31 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (val_25 != 306))
        {
            goto label_23;
        }
        
        var val_29 = 0;
        val_29 = val_29 ^ 0;
         =  + val_29;
        goto label_26;
        label_23:
        if( == 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_5:
        val_35 = 0 + 1;
        mem2[0] = 334;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_35 != 1) && ((1181292720 + ((0 + 1)) << 2) == 334))
        {
                var val_30 = 0;
            val_30 = val_30 ^ (val_35 >> 31);
            val_35 = val_35 + val_30;
        }
        else
        {
                if( != 0)
        {
            
        }
        
        }
        
        mem[1152921540147890552].Add(item:  new WaveSettingsConttroller.WaveSettingsMob());
        goto label_39;
        label_2:
        val_38 = 0 + 1;
        mem2[0] = 374;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_38 == 1)
        {
            goto label_49;
        }
        
        if(( == 0) || ((1181292720 + ((0 + 1)) << 2) == 374))
        {
            goto label_53;
        }
        
        label_52:
        label_53:
        mem[1152921540147890560] = 1;
        return;
        label_49:
        if( != 0)
        {
            goto label_52;
        }
        
        goto label_53;
    }
    public WaveSettingsConttroller()
    {
        this.listTimeDelayWave = new System.Collections.Generic.List<System.Single>();
        this.damagePercent = 1f;
        this.healthPercent = 1f;
        this._listPointSpawn = new System.Collections.Generic.List<SettingsSpawnMobWave>();
        this.丆丂三丐丕三丌丑万 = new System.Collections.Generic.List<WaveSettingsMob>();
    }

}
