using UnityEngine;
internal class FortMobWavesController : VTableHolder
{
    // Fields
    private WaveSettingsConttroller _waveSettings;
    private float 丞上丘丐丑不业世丏;
    private float 三下专与丌且丌与专;
    private float 丆三丞丞三丛丏丏且;
    private KillAllMobConditionEndRound 丐与丙一且丌丙下丟;
    private float 丘丅丆业世丂丝丝丐;
    private int 业丌专丁上丁丛世丗;
    private int 东万丏且三七丆丄丐;
    private int 专三丈东业丌万世丟;
    internal bool 一丆丕丕丏丏丞丈丗;
    private System.Action<int> 丘丅一七丞丞丐丒丘;
    private UnityEngine.Coroutine 一世丏丏与丐丈与丆;
    private int 七三一丘与丘丕一不;
    
    // Properties
    internal WaveSettingsConttroller 下七丙丝下丆东三东 { get; }
    internal int 丒丝丌丘七业丁业世 { get; }
    internal int 丁丌丆丈不上丂丁专 { get; }
    internal int 丗下与上东万上下世 { get; }
    
    // Methods
    internal FortMobWavesController()
    {
        this.丞上丘丐丑不业世丏 = 15f;
        this.三下专与丌且丌与专 = 15f;
        this.丆三丞丞三丛丏丏且 = 3f;
        this.业丌专丁上丁丛世丗 = 0;
        this.七三一丘与丘丕一不 = 3;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.丑业丆三上东丆七丒 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FortMobWavesController::OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    internal WaveSettingsConttroller 丝不丙丘专业丌丟上()
    {
        return (WaveSettingsConttroller)this._waveSettings;
    }
    internal int 丒业丈不丈丘丛丘东()
    {
        return (int)this.业丌专丁上丁丛世丗;
    }
    internal int 且丒丆业一丑丒丕一()
    {
        if(this._waveSettings != null)
        {
                return (int)this._waveSettings.countWave;
        }
        
        return (int)this._waveSettings.countWave;
    }
    internal int 万上丌丙丌七丗丞丙()
    {
        int val_1 = this._waveSettings.丘万丆丂丄万丐下丕(丞丌丌丕丆世七一丏:  this.业丌专丁上丁丛世丗);
        val_1 = val_1 - this.东万丏且三七丆丄丐;
        return (int)val_1;
    }
    public void add_OnStartWave(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丘丅一七丞丞丐丒丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丅一七丞丞丐丒丘 != 1152921526059451120);
    
    }
    public void remove_OnStartWave(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丘丅一七丞丞丐丒丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘丅一七丞丞丐丒丘 != 1152921526059587696);
    
    }
    internal void 上丛丌丆丑上七世三()
    {
        FortMobWavesController val_18;
        var val_19;
        string val_20;
        var val_21;
        string val_22;
        var val_23;
        val_18 = this;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_10;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = GameConnect.丄与丄上丅一下丘一;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_20)) == false)
        {
            goto label_10;
        }
        
        val_21 = null;
        val_21 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丄与丄上丅一下丘一] != null) && (null != null))
        {
                val_22 = 0;
        }
        
        object val_9 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_22);
        val_23 = 0;
        goto label_21;
        label_10:
        UnityEngine.Debug.LogError(message:  "Нету в настройках комнаты такого конфига");
        goto label_24;
        label_21:
        WaveSettingsConttroller val_12 = this.gameObject.AddComponent<WaveSettingsConttroller>();
        this._waveSettings = val_12;
        val_12.Initialize(丏丈三与丝丝丁且丛:  this);
        this._waveSettings.SetPointSpawn(丅专与丒丈丗丒丘丌:  FortDefenceLinkController.丄丘七三上丕世丞业.listPointSpawn);
        this._waveSettings.ConvertWaveSettings(与不丕丆丈不丙丟丛:  WaveSettings.与丂世丘丅丈丁三丘(丁丘丄丕下专东七不:  null));
        val_20 = this._waveSettings;
        val_20.Parse(丁丘丄丕下专东七不:  null);
        if(this.丘丅一七丞丞丐丒丘 != null)
        {
                this.丘丅一七丞丞丐丒丘.Invoke(obj:  0);
        }
        
        this.一丆丕丕丏丏丞丈丗 = true;
        label_24:
        if(this.丐与丙一且丌丙下丟 != 0)
        {
                return;
        }
        
        KillAllMobConditionEndRound val_16 = this.gameObject.AddComponent<KillAllMobConditionEndRound>();
        this.丐与丙一且丌丙下丟 = val_16;
        System.Action<BaseConditionEndRound> val_17 = null;
        val_20 = val_17;
        val_17 = new System.Action<BaseConditionEndRound>(object:  this, method:  System.Void FortMobWavesController::丒七下丂丒丛万一丁(BaseConditionEndRound 丅丈丌丅专丐丈丞东));
        val_16.丈专丙丆与丙丟世丈(丙业与丙丗丝不丈东:  val_17);
        val_18 = this.丐与丙一且丌丙下丟;
    }
    internal void 丞丞下丒丅丅丛世丕()
    {
        this.丈业业一丘东与丌业();
        if(this.业丌专丁上丁丛世丗 != 1)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
            下丝且丐丞丘一丁丂().丛丒且丑东丟丅丁丕(丂三丟丂丈丐丆丗丟:  0f);
            return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丑不丒丝与丆丈丟丆());
    }
    internal void 三丘丒万丑三丘丌丅()
    {
        if(this.丐与丙一且丌丙下丟 == 0)
        {
                return;
        }
        
        this.丐与丙一且丌丙下丟.丏丘丗丝丂丛丟丐丝(丙业与丙丗丝不丈东:  new System.Action<BaseConditionEndRound>(object:  this, method:  System.Void FortMobWavesController::丒七下丂丒丛万一丁(BaseConditionEndRound 丅丈丌丅专丐丈丞东)));
    }
    private void Update()
    {
        this.丛丆七不不丅丏且世();
    }
    private void 丛丆七不不丅丏且世()
    {
        int val_20;
        int val_21;
        var val_22;
        var val_23;
        string val_24;
        var val_25;
        var val_26;
        var val_27;
        int val_28;
        object val_29;
        var val_30;
        var val_31;
        int val_32;
        if(this.业丌专丁上丁丛世丗 == 1)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丘丅丆业世丂丝丝丐 - val_2;
        this.丘丅丆业世丂丝丝丐 = val_2;
        if(val_2 > 0f)
        {
                return;
        }
        
        val_21 = this.业丌专丁上丁丛世丗;
        val_20 = this.东万丏且三七丆丄丐;
        if(val_20 >= (this._waveSettings.丘万丆丂丄万丐下丕(丞丌丌丕丆世七一丏:  val_21)))
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_10;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_20;
        }
        
        val_22 = 1152921505066536960;
        val_23 = null;
        val_23 = null;
        val_24 = GameConnect.丈且世丂三万丞下丏;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_24)) == false)
        {
            goto label_20;
        }
        
        val_25 = null;
        val_25 = null;
        val_24 = GameConnect.丈且世丂三万丞下丏;
        object val_11 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_24];
        goto label_27;
        label_20:
        val_26 = 0;
        label_27:
        if(val_26 != this.专三丈东业丌万世丟)
        {
            goto label_28;
        }
        
        this._waveSettings.丟丕丏专专丙专丂丗(丞丌丌丕丆世七一丏:  this.业丌专丁上丁丛世丗, 一丝丁一下不丑七丆:  this.东万丏且三七丆丄丐);
        ExitGames.Client.Photon.Hashtable val_12 = new ExitGames.Client.Photon.Hashtable();
        ExitGames.Client.Photon.Hashtable val_13 = new ExitGames.Client.Photon.Hashtable();
        val_27 = null;
        val_27 = null;
        val_28 = this.专三丈东业丌万世丟;
        val_12.Add(key:  GameConnect.丈且世丂三万丞下丏, value:  val_28 + 1);
        val_29 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        if((val_29.ContainsKey(key:  GameConnect.丈且世丂三万丞下丏)) != false)
        {
                val_30 = null;
            val_30 = null;
            val_28 = this.专三丈东业丌万世丟;
            val_29 = val_28;
            val_13.set_Item(key:  GameConnect.丈且世丂三万丞下丏, value:  val_28);
        }
        
        val_31 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_31.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_12, 丒不一专上专丌丈东:  val_13, 丅丞丏丈且专丆不丟:  false);
        label_10:
        val_32 = this.业丌专丁上丁丛世丗;
        int val_20 = this.东万丏且三七丆丄丐;
        int val_21 = this.专三丈东业丌万世丟;
        this.丘丅丆业世丂丝丝丐 = this._waveSettings.丁专丕丈下且与且与(丞丌丌丕丆世七一丏:  val_32, 一丝丁一下不丑七丆:  this.东万丏且三七丆丄丐);
        val_20 = val_20 + 1;
        val_21 = val_21 + 1;
        this.东万丏且三七丆丄丐 = val_20;
        this.专三丈东业丌万世丟 = val_21;
        return;
        label_28:
        UnityEngine.Debug.LogError(message:  "currentMobRoomValue != _currentMob. Updating state from room settings");
        this.丈业业一丘东与丌业();
    }
    private System.Collections.IEnumerator 丑不丒丝与丆丈丟丆()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortMobWavesController.丅丄丕与丛丆专下丕(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丒七下丂丒丛万一丁(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(GameController.丆丘丂丈世丏丟丑丏 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        if(GameController.丆丘丂丈世丏丟丑丏.丞不丄丐丗不上专丞 != false)
        {
                return;
        }
        
        this.丘丑丛下业丂丈世专();
    }
    private void 丘丑丛下业丂丈世专()
    {
        if(this.一世丏丏与丐丈与丆 != null)
        {
                this.StopCoroutine(routine:  this.一世丏丏与丐丈与丆);
        }
        
        this.一世丏丏与丐丈与丆 = this.StartCoroutine(routine:  this.世下业丛丏丕丝丐丏());
    }
    private System.Collections.IEnumerator 世下业丛丏丕丝丐丏()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortMobWavesController.丝丝万丈丈与三丗万(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 上丛丑世不丅丟下丄(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄, bool 世与下丑丌一丕丞丒 = False)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        且丕万丑下业丙丂丗().WithQuaue = 世与下丑丌一丕丞丒;
        且丕万丑下业丙丂丗().Show(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    internal void 丑不与一丞丛丌上东(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟, UnityEngine.Color 丑丞丈丗丄丙丟万丄, bool 世与下丑丌一丕丞丒 = False)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        丙三丛不丌丙三七丞().WithQuaue = 世与下丑丌一丕丞丒;
        丙三丛不丌丙三七丞().Show(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a});
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.丈业业一丘东与丌业();
    }
    internal void 丈丛丌且丗与丑不丏(int 三丗丄丒下丕丛丅丈)
    {
        this.不丄三丁七丗丕万丕(三丗丄丒下丕丛丅丈:  三丗丄丒下丕丛丅丈, 丅丆上世丛丏丌专丆:  0);
    }
    internal void 不丄三丁七丗丕万丕(int 三丗丄丒下丕丛丅丈, int 丅丆上世丛丏丌专丆)
    {
        var val_6;
        int val_7;
        var val_8;
        if(this.业丌专丁上丁丛世丗 == 三丗丄丒下丕丛丅丈)
        {
                var val_1 = (this.东万丏且三七丆丄丐 != 丅丆上世丛丏丌专丆) ? 0 : 4;
        }
        else
        {
                val_6 = 0;
        }
        
        this.业丌专丁上丁丛世丗 = 三丗丄丒下丕丛丅丈;
        this.东万丏且三七丆丄丐 = 丅丆上世丛丏丌专丆;
        val_7 = new object[1];
        if((this.业丌专丁上丁丛世丗 != 0) && (this.业丌专丁上丁丛世丗 == 0))
        {
                val_8 = 0;
        }
        
        if(val_2.Length == 0)
        {
                val_8 = 0;
        }
        
        val_7[0] = this.业丌专丁上丁丛世丗;
        if((val_6 & 7) != 0)
        {
                return;
        }
        
        val_7 = this.业丌专丁上丁丛世丗;
        if(val_7 >= this._waveSettings.listTimeDelayWave.Count)
        {
                return;
        }
        
        val_7 = this.东万丏且三七丆丄丐;
        if(val_7 != 0)
        {
                float val_5 = this._waveSettings.丁专丕丈下且与且与(丞丌丌丕丆世七一丏:  this.业丌专丁上丁丛世丗, 一丝丁一下不丑七丆:  val_7);
        }
        else
        {
                val_7 = this.业丌专丁上丁丛世丗;
        }
        
        this.丘丅丆业世丂丝丝丐 = this._waveSettings.listTimeDelayWave.Item[val_7];
    }
    private void 丈业业一丘东与丌业()
    {
        var val_16;
        var val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_16 = 1152921505066536960;
        val_17 = null;
        val_17 = null;
        val_18 = GameConnect.丈且世丂三万丞下丏;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_18)) == false)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丈且世丂三万丞下丏];
        val_20 = 0;
        goto label_17;
        label_24:
        val_18 = this._waveSettings.丐丁且丞丐丞丟下丝().Item[0];
        int val_16 = val_9.countMob;
        val_16 = val_16 + 0;
        if(null <= val_16)
        {
            goto label_21;
        }
        
        val_20 = 1;
        label_17:
        val_18 = this._waveSettings.丐丁且丞丐丞丟下丝();
        if(val_20 < val_18.Count)
        {
            goto label_24;
        }
        
        goto label_26;
        label_21:
        if(val_20 == 1)
        {
            goto label_26;
        }
        
        val_18 = 1152921504628731904;
        WaveSettingsMob val_13 = this._waveSettings.丐丁且丞丐丞丟下丝().Item[0];
        if(val_18 < val_13.countMob)
        {
            goto label_38;
        }
        
        val_21 = null;
        val_21 = null;
        HashSet.Enumerator<T> val_14 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.GetEnumerator();
        label_37:
        if(((-19819304) & 1) == 0)
        {
            goto label_34;
        }
        
        string val_15 = 0.丐丏七丌丕丗业且上();
        if((-19819304) != val_20)
        {
            goto label_37;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_38;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_18 = 0;
        label_38:
        this.不丄三丁七丗丕万丕(三丗丄丒下丕丛丅丈:  1, 丅丆上世丛丏丌专丆:  0);
        label_26:
        this.专三丈东业丌万世丟 = null;
    }

}
