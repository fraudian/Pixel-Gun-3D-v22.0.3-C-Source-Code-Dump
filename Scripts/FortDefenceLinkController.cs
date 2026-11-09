using UnityEngine;
internal sealed class FortDefenceLinkController : PGBehaviour
{
    // Fields
    internal static FortDefenceLinkController 丄丘七三上丕世丞业;
    public DamageableObject damageDoor;
    public DamageableObject damageChest;
    private System.Collections.Generic.List<DamageableObject> _listTargets;
    private System.Collections.Generic.List<TargetSettigsType> _listTargetSettings;
    public System.Collections.Generic.List<SettingsSpawnMobWave> listPointSpawn;
    public float timeForShowNextWaveLable;
    public float damageBotFromTurretsCoeff;
    public FortDamageableGenerator baseGenerator;
    private System.Collections.Generic.List<FortPortalForPlayerController> _listTeleports;
    public AltarePoint point;
    private int 丞世不丒下上上丝丑;
    public DamageableObjectTopRoundInfo damageableTopRoundInfo;
    public WaveTopRoundInfo waveTopRoundInfo;
    public ScoreTopRoundInfo scoreTopRoundInfo;
    public PlaceTopRoundInfo placeTopRoundInfo;
    public string icon_chest;
    public string icon_door;
    public string key_chest;
    public string key_doors;
    public string key_Start_Wave;
    public string key_Start_Game;
    public string key_Start_Next_Wave;
    private System.Collections.Generic.List<float> 七丌丁丒万专万七丟;
    private System.Collections.Generic.List<HitBox> 丁丈丅业丞丘七丑下;
    private System.Collections.Generic.List<BonuseWithWeight> _listBonuseWithWeight;
    internal System.Collections.Generic.Dictionary<Rilisoft.专与丏丞三与不不丆, float> 丛万三丟丅丈业丕丘;
    public float lifeTimeBonuse;
    public float percentSpawnBonuse;
    
    // Methods
    public FortPortalForPlayerController GetTeleport()
    {
        var val_4;
        if(this._listTeleports.Count > this.丞世不丒下上上丝丑)
        {
                this.丞世不丒下上上丝丑 = this.丞世不丒下上上丝丑 + 1;
            FortPortalForPlayerController val_3 = this._listTeleports.Item[this.丞世不丒下上上丝丑];
            return (FortPortalForPlayerController)val_4;
        }
        
        val_4 = 0;
        return (FortPortalForPlayerController)val_4;
    }
    private void Awake()
    {
        FortDefenceLinkController.丄丘七三上丕世丞业 = this;
        this.丛丞丞一丆上丛丒丅();
        if(this.point == 0)
        {
                return;
        }
        
        this.point.丞丑丌下丛丙丄丁七(丑七丐丈下世丆丞丟:  世丐丟三丑一万丌一.丑七不且上丗丁一世().丘且丏万不东丂不丟());
    }
    private void 丛丞丞一丆上丛丒丅()
    {
        var val_44;
        var val_45;
        System.Collections.Generic.List<System.Single> val_46;
        var val_47;
        var val_48;
        var val_50;
        float val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        float val_56;
        float val_57;
        float val_58;
        val_44 = 1152921505145503744;
        if(FortGameFieldController.丄丘七三上丕世丞业 != 0)
        {
            goto label_3;
        }
        
        val_45 = 1152921526036169632;
        this.七丌丁丒万专万七丟.Add(item:  10f);
        this.七丌丁丒万专万七丟.Add(item:  10f);
        val_46 = this.七丌丁丒万专万七丟;
        val_47 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        goto label_7;
        label_3:
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() != null) && (val_3.HPGenerator != null))
        {
                int val_4 = val_3.HPGenerator.Count;
            val_48 = 0;
        }
        else
        {
                val_48 = 0;
        }
        
        if((((-1487876328) & 1) == 0) || (val_48.丙东专丂世丈丏丁丂() == 0))
        {
            goto label_15;
        }
        
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() == null) || (val_7.HPGenerator == null))
        {
            goto label_86;
        }
        
        一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 val_10 = PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆();
        float val_14 = val_7.HPGenerator.Item[UnityEngine.Mathf.Min(a:  FortGameFieldController.丄丘七三上丕世丞业.丌丛业东七丑丐丞专(), b:  val_10.HPGenerator.Count - 1)];
        val_50 = 1152921516341966432;
        goto label_29;
        label_15:
        val_50 = 1152921516341966432;
        val_51 = 10f;
        label_29:
        label_86:
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() != null) && (val_16.HPFortGateObject != null))
        {
                int val_17 = val_16.HPFortGateObject.Count;
            val_52 = 0;
        }
        else
        {
                val_52 = 0;
        }
        
        if((((-1487876328) & 1) == 0) || (val_52.丙东专丂世丈丏丁丂() == 0))
        {
            goto label_37;
        }
        
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() == null) || (val_20.HPFortGateObject == null))
        {
            goto label_87;
        }
        
        一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 val_23 = PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆();
        float val_27 = val_20.HPFortGateObject.Item[UnityEngine.Mathf.Min(a:  FortGameFieldController.丄丘七三上丕世丞业.丌丛业东七丑丐丞专(), b:  val_23.HPFortGateObject.Count - 1)];
        val_53 = 1152921516341966432;
        goto label_51;
        label_37:
        val_53 = 1152921516341966432;
        val_51 = 10f;
        label_51:
        label_87:
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() != null) && (val_29.HPFortChestObject != null))
        {
                int val_30 = val_29.HPFortChestObject.Count;
            val_54 = 0;
        }
        else
        {
                val_54 = 0;
        }
        
        if((((-1487876328) & 1) == 0) || (val_54.丙东专丂世丈丏丁丂() == 0))
        {
            goto label_59;
        }
        
        if((PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆() == null) || (val_33.HPFortChestObject == null))
        {
            goto label_88;
        }
        
        一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 val_36 = PGCompany.丘丞丞丟丗丐世丅丈.丑七不且上丗丁一世().丑丗三丛丛丆丟丌丆();
        float val_40 = val_33.HPFortChestObject.Item[UnityEngine.Mathf.Min(a:  FortGameFieldController.丄丘七三上丕世丞业.丌丛业东七丑丐丞专(), b:  val_36.HPFortChestObject.Count - 1)];
        val_55 = 1152921516341966432;
        goto label_73;
        label_59:
        val_55 = 1152921516341966432;
        val_51 = 10f;
        label_73:
        val_45 = 0;
        label_88:
        if(((-1487876336) & 1) == 0)
        {
            goto label_74;
        }
        
        val_56 = 0.x;
        if(this.七丌丁丒万专万七丟 != null)
        {
            goto label_77;
        }
        
        goto label_76;
        label_74:
        val_56 = 10f;
        if(this.七丌丁丒万专万七丟 != null)
        {
            goto label_77;
        }
        
        label_76:
        label_77:
        val_44 = 1152921526036169632;
        this.七丌丁丒万专万七丟.Add(item:  val_56);
        if(((-1487876336) & 1) == 0)
        {
            goto label_78;
        }
        
        val_57 = 0.x;
        if(this.七丌丁丒万专万七丟 != null)
        {
            goto label_81;
        }
        
        goto label_80;
        label_78:
        val_57 = 10f;
        if(this.七丌丁丒万专万七丟 != null)
        {
            goto label_81;
        }
        
        label_80:
        label_81:
        this.七丌丁丒万专万七丟.Add(item:  val_57);
        val_46 = this.七丌丁丒万专万七丟;
        if(((-1487876336) & 1) == 0)
        {
            goto label_82;
        }
        
        val_58 = val_45.x;
        if(val_46 != null)
        {
            goto label_85;
        }
        
        goto label_84;
        label_82:
        val_58 = 10f;
        if(val_46 != null)
        {
            goto label_85;
        }
        
        label_84:
        label_85:
        val_47 = public System.Void System.Collections.Generic.List<System.Single>::Add(System.Single item);
        label_7:
        val_46.Add(item:  val_58);
    }
    internal 丅丙上七上一丐不下 丅上世世丁下上不与()
    {
        var val_4;
        List.Enumerator<T> val_1 = this._listTargets.GetEnumerator();
        label_4:
        if(((-1487616840) & 1) == 0)
        {
            goto label_2;
        }
        
        val_4 = 0.丐丏七丌丕丗业且上();
        if(val_4.IsDead() == true)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_4 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (丅丙上七上一丐不下);
    }
    internal HitBox 下不一万丟上一丐丙()
    {
        System.Collections.Generic.List<HitBox> val_5;
        var val_6;
        val_5 = this;
        if(this.丁丈丅业丞丘七丑下.Count >= 1)
        {
                val_5 = this.丁丈丅业丞丘七丑下;
            HitBox val_4 = val_5.Item[UnityEngine.Random.Range(min:  0, max:  val_5.Count)];
            return (HitBox)val_6;
        }
        
        val_6 = 0;
        return (HitBox)val_6;
    }
    private void Update()
    {
        bool val_8;
        bool val_9;
        List.Enumerator<T> val_1 = this.listPointSpawn.GetEnumerator();
        label_4:
        if(((-1487332424) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上().三丄丈丏丟丐业世丄() == false)
        {
            goto label_4;
        }
        
        val_8 = 0;
        goto label_5;
        label_2:
        val_8 = 1;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
         =  & ((this.listPointSpawn.Count < 1) ? 1 : 0);
        if(GameConnect.丅丟下专不丁一丈七() != false)
        {
                this.damageDoor.isImmortal = ;
        }
        
        if(( & 1) == 0)
        {
            goto label_15;
        }
        
        val_9 = 1;
        if(this.damageChest != null)
        {
            goto label_19;
        }
        
        goto label_17;
        label_15:
        val_9 = (~this.damageDoor.IsDead()) & 1;
        if(this.damageChest != null)
        {
            goto label_19;
        }
        
        label_17:
        label_19:
        this.damageChest.isImmortal = val_9;
    }
    private System.Collections.IEnumerator Start()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortDefenceLinkController.丄丟下业丕三丘丞三(丗丏丅丕丆世丁专丟:  0);
    }
    internal System.Collections.Generic.List<且业且丙上三与东丕> 丅七丂丆三业丘丌世(且丝丈东丂丁且丘七 且三丕三丕丈下丕丝)
    {
        var val_2;
        var val_6;
        var val_7;
        val_6 = 且三丕三丕丈下丕丝;
        List.Enumerator<T> val_1 = this._listTargetSettings.GetEnumerator();
        label_3:
        if(((-1487057232) & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_4 = val_2.GetAwaiter();
        val_7 = val_4._value._token;
        if(val_4._value._obj != val_6)
        {
            goto label_3;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (System.Collections.Generic.List<且业且丙上三与东丕>)val_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<且业且丙上三与东丕> val_5 = null;
        val_7 = val_5;
        val_5 = new System.Collections.Generic.List<且业且丙上三与东丕>();
        val_5.Add(item:  0);
        return (System.Collections.Generic.List<且业且丙上三与东丕>)val_7;
    }
    internal void 丆世丄丑丕丒上丙世(DamageableObject 丅丞万丒不专丈专丕)
    {
        this.damageDoor = 丅丞万丒不专丈专丕;
        this._listTargets.Insert(index:  0, item:  丅丞万丒不专丈专丕);
    }
    public FortDefenceLinkController()
    {
        this._listTargets = new System.Collections.Generic.List<DamageableObject>();
        this._listTargetSettings = new System.Collections.Generic.List<TargetSettigsType>();
        this.listPointSpawn = new System.Collections.Generic.List<SettingsSpawnMobWave>();
        this.timeForShowNextWaveLable = 5f;
        this.damageBotFromTurretsCoeff = 5.510186E-41f;
        this._listTeleports = new System.Collections.Generic.List<FortPortalForPlayerController>();
        this.icon_chest = "";
        this.icon_door = "Siege_Doors";
        this.key_chest = "";
        this.key_Start_Game = "";
        this.key_Start_Next_Wave = "";
        this.key_doors = "Key_7965";
        this.key_Start_Wave = "";
        this.七丌丁丒万专万七丟 = new System.Collections.Generic.List<System.Single>();
        this.丁丈丅业丞丘七丑下 = new System.Collections.Generic.List<HitBox>();
        this._listBonuseWithWeight = new System.Collections.Generic.List<BonuseWithWeight>();
        this.丛万三丟丅丈业丕丘 = new System.Collections.Generic.Dictionary<Rilisoft.专与丏丞三与不不丆, System.Single>();
        this.lifeTimeBonuse = 5f;
        this.percentSpawnBonuse = 7.346868E-41f;
    }

}
