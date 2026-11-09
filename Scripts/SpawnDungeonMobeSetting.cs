using UnityEngine;
internal class SpawnDungeonMobeSetting : MonoBehaviour
{
    // Fields
    internal static SpawnDungeonMobeSetting 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings> _listSpawnZone;
    private System.Collections.Generic.List<SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings> _allSettingsListSpawnZone;
    internal static readonly string 专世丟丂业世丟丐丐;
    internal ControllerChangePhotonOwnerAndActivateBotMesh 丟下丝一丈东万且丛;
    private static int 丏丂下丂丐业万七丕;
    private System.Collections.Generic.List<SpawnDungeonMobeSetting.七丂丅丘丒三丅丂丈> 三上上丌丞丂丐下业;
    private UnityEngine.Coroutine 专世与丗专上下七不;
    
    // Methods
    private void Awake()
    {
        null = null;
        SpawnDungeonMobeSetting.丄丘七三上丕世丞业 = this;
        SpawnDungeonMobeSetting.丏丂下丂丐业万七丕 = 0;
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SpawnDungeonMobeSetting::与丈丌万专丐业东七(RilisoftBot.BotAiController 业丘东且七丕丞东不)));
        FlasksDungeonObject.东专上万且专丏专上(丙业与丙丗丝不丈东:  new System.Action<FlasksDungeonObject>(object:  this, method:  System.Void SpawnDungeonMobeSetting::丗一一丛丝丛丑下专(FlasksDungeonObject 丄七丌下不丐且丐丏)));
        SpawnMobBaseDungeon.丆一上丗丆丟不专业(丙业与丙丗丝不丈东:  new System.Action<SpawnMobBaseDungeon>(object:  this, method:  System.Void SpawnDungeonMobeSetting::上丌专上丅丏丙东丘(SpawnMobBaseDungeon 丈丞丑丅万丞丅丙业)));
        AltarePoint.与一丕丞丈丆七丑丞(丙业与丙丗丝不丈东:  new System.Action<AltarePoint>(object:  this, method:  System.Void SpawnDungeonMobeSetting::万上丐三丅丒七丂丅(AltarePoint 丈丕与丂丅与丏业丗)));
        if(this.丟下丝一丈东万且丛 != 0)
        {
                return;
        }
        
        this.丟下丝一丈东万且丛 = this.gameObject.AddComponent<ControllerChangePhotonOwnerAndActivateBotMesh>();
    }
    private void OnDestroy()
    {
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void SpawnDungeonMobeSetting::与丈丌万专丐业东七(RilisoftBot.BotAiController 业丘东且七丕丞东不)));
        FlasksDungeonObject.业丞世专上东丅业丏(丙业与丙丗丝不丈东:  new System.Action<FlasksDungeonObject>(object:  this, method:  System.Void SpawnDungeonMobeSetting::丗一一丛丝丛丑下专(FlasksDungeonObject 丄七丌下不丐且丐丏)));
        SpawnMobBaseDungeon.丛丙丏丞东丁丆丟世(丙业与丙丗丝不丈东:  new System.Action<SpawnMobBaseDungeon>(object:  this, method:  System.Void SpawnDungeonMobeSetting::上丌专上丅丏丙东丘(SpawnMobBaseDungeon 丈丞丑丅万丞丅丙业)));
        AltarePoint.丒下丏丙万世不世丁(丙业与丙丗丝不丈东:  new System.Action<AltarePoint>(object:  this, method:  System.Void SpawnDungeonMobeSetting::万上丐三丅丒七丂丅(AltarePoint 丈丕与丂丅与丏业丗)));
    }
    internal void 丞万不丟丙下丕丕且()
    {
        this.丘丈一丌七业丝万丒(丛丝上丗丘业丌七丗:  this._listSpawnZone, 丞丒且丅丝丝专丟上:  null, 丑且世业下且丟丅丂:  0);
    }
    internal void 丒且业丈丛丗丈东丂(int 丌丒丝东丌下丕丁丅)
    {
        null = null;
        SpawnDungeonMobeSetting.丏丂下丂丐业万七丕 = 丌丒丝东丌下丕丁丅;
    }
    private void 与丈丌万专丐业东七(RilisoftBot.BotAiController 业丘东且七丕丞东不)
    {
        UnityEngine.Object val_44;
        var val_45;
        var val_46;
        var val_48;
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_49;
        val_44 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        if(val_44 == 0)
        {
                return;
        }
        
        val_44 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        if(val_3.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_4 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        val_44 = val_4.丞丁丝丕世丏丌丞丁;
        if(val_4.丞丁丝丕世丏丌丞丁.Length < 4)
        {
                return;
        }
        
        PhotonView val_5 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        object val_45 = val_5.丞丁丝丕世丏丌丞丁[0];
        val_45 = 1152921504622075904;
        PhotonView val_6 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        object val_46 = val_6.丞丁丝丕世丏丌丞丁[1];
        PhotonView val_7 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        object val_47 = val_7.丞丁丝丕世丏丌丞丁[2];
        PhotonView val_8 = 业丘东且七丕丞东不.丛丘丟业下丐专丕丑();
        object val_48 = val_8.丞丁丝丕世丏丌丞丁[3];
        if(null == 1)
        {
                return;
        }
        
        int val_9 = this._allSettingsListSpawnZone.Count;
        if(val_9 <= null)
        {
                return;
        }
        
        val_45 = 1152921540064063824;
        if(this._allSettingsListSpawnZone.Item[21884928] == null)
        {
                return;
        }
        
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_11 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        object val_12 = 1152921504628731904 - 1;
        if(val_9 < null)
        {
            goto label_33;
        }
        
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_13 = null;
        val_48 = val_13;
        val_13 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        ScenarioZoneSettings val_14 = Item[val_12];
        if(val_48 == null)
        {
            goto label_37;
        }
        
        val_13.Add(item:  val_14.上丞丟丏万丝且丆下);
        goto label_38;
        label_33:
        if(null != null)
        {
                return;
        }
        
        ListZoneSpawnDungeonSettings val_15 = this._allSettingsListSpawnZone.Item[0];
        val_49 = val_15.listZoneSpawn;
        if(val_49.Count <= null)
        {
                return;
        }
        
        val_45 = 1152921540055548016;
        if(val_49.Item[21884928] == null)
        {
                return;
        }
        
        ZoneSpawnDungeonSettings val_18 = val_49.Item[21884928];
        if(val_18.listPointSpawnDungeonMob.Count <= null)
        {
                return;
        }
        
        ZoneSpawnDungeonSettings val_20 = val_49.Item[21884928];
        if(val_20.listPointSpawnDungeonMob.Item[21884928] != null)
        {
            goto label_53;
        }
        
        return;
        label_37:
        val_13.Add(item:  val_14.上丞丟丏万丝且丆下);
        label_38:
        if(val_13.Count >= 1)
        {
                ZoneSpawnDungeonSettings val_23 = val_13.Item[0];
            if(val_23.listPointSpawnDungeonMob.Count > null)
        {
                ZoneSpawnDungeonSettings val_25 = val_13.Item[0];
            PointSpawnDungeonSettings val_26 = val_25.listPointSpawnDungeonMob.Item[21884928];
            if(val_26.typeSpawnDungeonTask == 4)
        {
                Item[val_12].丕丕丌丄丑丗丝上丐(与丝丈丑丝丕丘丏丅:  业丘东且七丕丞东不.七与世丄丞丒一七三());
        }
        
        }
        
        }
        
        val_46 = 0;
        label_53:
        if(业丘东且七丕丞东不 != null)
        {
                业丘东且七丕丞东不.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  false);
            业丘东且七丕丞东不.丁业下丞万且丒丂下(世丁万下丗专世万丅:  false);
        }
        else
        {
                0.丕业丞不丒不丗丛世(世丁万下丗专世万丅:  false);
            0.丁业下丞万且丒丂下(世丁万下丗专世万丅:  false);
        }
        
        PatrolModifierControllerDungeonMobs val_30 = 业丘东且七丕丞东不.gameObject.AddComponent<PatrolModifierControllerDungeonMobs>();
        ZoneSpawnDungeonSettings val_31 = val_13.Item[0];
        PointSpawnDungeonSettings val_32 = val_31.listPointSpawnDungeonMob.Item[21884928];
        ZoneSpawnDungeonSettings val_33 = val_13.Item[0];
        PointSpawnDungeonSettings val_34 = val_33.listPointSpawnDungeonMob.Item[21884928];
        ZoneSpawnDungeonSettings val_35 = val_13.Item[0];
        PointSpawnDungeonSettings val_36 = val_35.listPointSpawnDungeonMob.Item[21884928];
        val_30.丌丆万丕丗丄丛丄丐(丗上下丂万丑上与丌:  new UnityEngine.Vector3() {x = val_32.centerPoint, y = V9.16B, z = V10.16B}, 丛丆丄丌丗丌万上专:  val_34.patrolListArea, 丙上丈专丈丌丘丑万:  (val_36.checkWeight == true) ? 1 : 0);
        if(业丘东且七丕丞东不 != null)
        {
                业丘东且七丕丞东不.丌万丁七丈业丈丗东 = val_30;
        }
        else
        {
                mem[96] = val_30;
        }
        
        ChasingAreaModifierControllerDungeon val_39 = 业丘东且七丕丞东不.gameObject.AddComponent<ChasingAreaModifierControllerDungeon>();
        ZoneSpawnDungeonSettings val_40 = val_13.Item[0];
        PointSpawnDungeonSettings val_41 = val_40.listPointSpawnDungeonMob.Item[21884928];
        ZoneSpawnDungeonSettings val_42 = val_13.Item[0];
        PointSpawnDungeonSettings val_43 = val_42.listPointSpawnDungeonMob.Item[21884928];
        val_39.丑丁丂与三丙上丏丁(丛丆丄丌丗丌万上专:  val_41.chaseListArea, 丙上丈专丈丌丘丑万:  (val_43.checkWeight == true) ? 1 : 0);
        if(业丘东且七丕丞东不 != null)
        {
                业丘东且七丕丞东不.东万三丈万丗专业专 = val_39;
        }
        else
        {
                mem[104] = val_39;
        }
        
        业丘东且七丕丞东不.不七三下业丁专与下 = 21884928;
        this.丟下丝一丈东万且丛.不丅上丆万上丘丙东(丛世丕丘七东下丌丄:  业丘东且七丕丞东不);
    }
    private void 丗一一丛丝丛丑下专(FlasksDungeonObject 丄七丌下不丐且丐丏)
    {
        UnityEngine.Object val_7;
        System.Object[] val_8;
        val_7 = 丄七丌下不丐且丐丏.丛丘丟业下丐专丕丑();
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = 丄七丌下不丐且丐丏.丛丘丟业下丐专丕丑();
        if(val_3.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_4 = 丄七丌下不丐且丐丏.丛丘丟业下丐专丕丑();
        val_7 = val_4.丞丁丝丕世丏丌丞丁;
        if(val_4.丞丁丝丕世丏丌丞丁.Length < 1)
        {
                return;
        }
        
        PhotonView val_5 = 丄七丌下不丐且丐丏.丛丘丟业下丐专丕丑();
        val_8 = val_5.丞丁丝丕世丏丌丞丁;
        object val_8 = val_8[0];
        if((null & 2147483648) == 0)
        {
                val_8 = Item[1152921504628731904 - 1];
            val_8.丈丛且丗下万与丒丟(丄七丌下不丐且丐丏:  丄七丌下不丐且丐丏);
        }
        
        this.丟下丝一丈东万且丛.丈丛且丗下万与丒丟(丄七丌下不丐且丐丏:  丄七丌下不丐且丐丏);
    }
    private void 上丌专上丅丏丙东丘(SpawnMobBaseDungeon 丈丞丑丅万丞丅丙业)
    {
        UnityEngine.Object val_7;
        var val_8;
        val_7 = 丈丞丑丅万丞丅丙业.丛丘丟业下丐专丕丑();
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = 丈丞丑丅万丞丅丙业.丛丘丟业下丐专丕丑();
        if(val_3.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        PhotonView val_4 = 丈丞丑丅万丞丅丙业.丛丘丟业下丐专丕丑();
        val_7 = val_4.丞丁丝丕世丏丌丞丁;
        if(val_4.丞丁丝丕世丏丌丞丁.Length < 3)
        {
                return;
        }
        
        PhotonView val_5 = 丈丞丑丅万丞丅丙业.丛丘丟业下丐专丕丑();
        object val_7 = val_5.丞丁丝丕世丏丌丞丁[2];
        val_8 = 1152921504628731903;
        if(val_5.丞丁丝丕世丏丌丞丁.Length >= 2)
        {
                val_8 = Item[21884927];
            val_8.业万丗丂丁丆世不丞(丈东丝丐业专丈且丘:  丈丞丑丅万丞丅丙业);
        }
        
        this.丟下丝一丈东万且丛.丗三上七丂三业世丈(下世丈丗丟业丙与丒:  丈丞丑丅万丞丅丙业);
    }
    private void 万上丐三丅丒七丂丅(AltarePoint 丈丕与丂丅与丏业丗)
    {
        PhotonView val_3;
        var val_4;
        val_3 = 丈丕与丂丅与丏业丗.丄丈丑丐丆丞丘与丗;
        if(val_3 == 0)
        {
                return;
        }
        
        val_3 = 丈丕与丂丅与丏业丗.丄丈丑丐丆丞丘与丗;
        if(丈丕与丂丅与丏业丗.丄丈丑丐丆丞丘与丗.丞丁丝丕世丏丌丞丁 == null)
        {
                return;
        }
        
        object val_3 = 丈丕与丂丅与丏业丗.丄丈丑丐丆丞丘与丗.丞丁丝丕世丏丌丞丁[0];
        val_4 = 1152921504628731903;
        if()
        {
                val_4 = Item[21884927];
            val_4.丏万丂业丐世丐丞上(丏丄丝丞上丒丏丄下:  丈丕与丂丅与丏业丗);
        }
        
        this.丟下丝一丈东万且丛.世丒三丙丌世专与业(丏丄丝丞上丒丏丄下:  丈丕与丂丅与丏业丗);
    }
    internal void 丘丈一丌七业丝万丒(System.Collections.Generic.List<SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings> 丛丝上丗丘业丌七丗, ControllerChangePhotonOwnerAndActivateBotMesh 丞丒且丅丝丝专丟上, int 丑且世业下且丟丅丂 = -1)
    {
        int val_5;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        int val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_36;
        val_18 = 丛丝上丗丘业丌七丗;
        val_20 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌() == 14)
        {
                return;
        }
        
        List.Enumerator<T> val_3 = val_18.GetEnumerator();
        val_18 = 0;
        val_21 = 0;
        val_20 = 0;
        val_22 = 0;
        goto label_8;
        label_109:
        List.Enumerator<T> val_7 = val_5.丐丏七丌丕丗业且上().GetEnumerator();
        val_24 = 1152921540055766512;
        goto label_17;
        label_69:
        val_25 = null;
        val_25 = null;
        val_24 = 1152921540055766512;
        if(val_6.m_firstChar <= DungeonsController.丄丘七三上丕世丞业.dungeonDifficulty)
        {
            goto label_16;
        }
        
        goto label_17;
        label_16:
        int val_17 = val_6.m_stringLength;
        val_17 = val_17 - 1;
        if(val_17 > 4)
        {
            goto label_43;
        }
        
        var val_18 = 106033952 + ((val_6.m_stringLength - 1)) << 2;
        val_18 = val_18 + 106033952;
        goto (106033952 + ((val_6.m_stringLength - 1)) << 2 + 106033952);
        label_43:
        val_26 = 0;
        label_17:
        if((1099475440 & 1) == 0)
        {
            goto label_54;
        }
        
        val_23 = val_5.丐丏七丌丕丗业且上();
        val_27 = null;
        val_27 = null;
        val_29 = SpawnDungeonMobeSetting.丏丂下丂丐业万七丕;
        if(val_29 < 1)
        {
            goto label_57;
        }
        
        val_29 = SpawnDungeonMobeSetting.丏丂下丂丐业万七丕;
        val_29 = val_29 - 1;
        SpawnDungeonMobeSetting.丏丂下丂丐业万七丕 = val_29;
        goto label_17;
        label_57:
        val_30 = null;
        val_30 = null;
        if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
            goto label_65;
        }
        
        val_31 = null;
        val_31 = null;
        if(DungeonsController.丄丘七三上丕世丞业.dungeonDifficulty != 0)
        {
            goto label_69;
        }
        
        label_65:
        val_19 = 1099475344;
        val_32 = 1;
        val_33 = 472;
        goto label_70;
        label_54:
        val_19 = 1099475344;
        val_32 = 1;
        val_33 = 440;
        label_70:
        val_20 = val_20;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_32 == 1)
        {
            goto label_103;
        }
        
        if(440 == 440)
        {
            goto label_104;
        }
        
        if(440 == 472)
        {
            goto label_105;
        }
        
        label_103:
        if( == 0)
        {
            goto label_106;
        }
        
        val_18 = 0;
        val_21 = 0;
        goto label_108;
        label_104:
        var val_26 = 0;
        val_26 = val_26 ^ 0;
        val_22 = val_32 + val_26;
        goto label_108;
        label_106:
        val_18 = 0;
        label_108:
        val_20 =  + 1;
        label_8:
        if((1099475472 & 1) != 0)
        {
            goto label_109;
        }
        
        val_36 = val_32 + 1;
        mem2[0] = 472;
        goto label_110;
        label_105:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_110:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_32 != 1)
        {
                if(440 == 472)
        {
                return;
        }
        
        }
        
        if( == 0)
        {
                return;
        }
    
    }
    internal void 丁世万七业丛丘丕丈(string 丂丙丅下丘丅三丘丙, SpawnDungeonMobeSetting.PointSpawnDungeonSettings 丅专与丒丈丗丒丘丌, object[] 一丐丗丁丞丆丅丟丄)
    {
        SpawnDungeonMobeSetting.七丂丅丘丒三丅丂丈 val_1 = new SpawnDungeonMobeSetting.七丂丅丘丒三丅丂丈();
        if(val_1 != null)
        {
                .丒丘丏上丙丟丑丕丈 = 丂丙丅下丘丅三丘丙;
            .丅专与丒丈丗丒丘丌 = 丅专与丒丈丗丒丘丌;
        }
        else
        {
                mem[16] = 丂丙丅下丘丅三丘丙;
            mem[24] = 丅专与丒丈丗丒丘丌;
        }
        
        .一丐丗丁丞丆丅丟丄 = 一丐丗丁丞丆丅丟丄;
        this.三上上丌丞丂丐下业.Add(item:  val_1);
        if(this.专世与丗专上下七不 != null)
        {
                return;
        }
        
        this.专世与丗专上下七不 = this.StartCoroutine(routine:  this.万与丑专万丟三三三());
    }
    internal System.Collections.IEnumerator 万与丑专万丟三三三()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SpawnDungeonMobeSetting.丁丛丙业丁丝丙丆丏(丗丏丅丕丆世丁专丟:  0);
    }
    internal void 丛丞丘丞万丆丞丛丄(string 丒丘丏上丙丟丑丕丈, int 丛不丒与七丗丆丏且, int 上丅丌丛且丕且丑丆, ControllerChangePhotonOwnerAndActivateBotMesh 丞丒且丅丝丝专丟上, int 丟丆且不七丈丐丂专, int 上东丟三丒丛丁不且 = -1)
    {
        object val_10;
        var val_11;
        val_10 = 丛不丒与七丗丆丏且;
        if(上东丟三丒丛丁不且 == 0)
        {
                return;
        }
        
        int val_1 = this._allSettingsListSpawnZone.Count;
        if(val_1 <= 上东丟三丒丛丁不且)
        {
                return;
        }
        
        if(this._allSettingsListSpawnZone.Item[上东丟三丒丛丁不且] == null)
        {
                return;
        }
        
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_3 = null;
        val_11 = val_3;
        val_3 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        if(val_1 >= 上东丟三丒丛丁不且)
        {
                System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_5 = null;
            val_11 = val_5;
            val_5 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
            ScenarioZoneSettings val_6 = Item[上东丟三丒丛丁不且 - 1];
            val_5.Add(item:  val_6.上丞丟丏万丝且丆下);
            val_10 = 0;
        }
        
        object[] val_7 = new object[5];
        val_7[0] = val_10;
        val_7[1] = 上丅丌丛且丕且丑丆;
        val_7[2] = 上东丟三丒丛丁不且;
        val_7[3] = 0;
        val_7[4] = 丟丆且不七丈丐丂专;
        ZoneSpawnDungeonSettings val_8 = val_5.Item[0];
        this.丁世万七业丛丘丕丈(丂丙丅下丘丅三丘丙:  丒丘丏上丙丟丑丕丈, 丅专与丒丈丗丒丘丌:  val_8.listPointSpawnDungeonMob.Item[上丅丌丛且丕且丑丆], 一丐丗丁丞丆丅丟丄:  val_7);
    }
    private void 丈上一七丆丒丂丕丐()
    {
        SpawnDungeonMobeSetting.丒丞专丞世丈丅丏丙(丛丝上丗丘业丌七丗:  this._listSpawnZone, 丄上七丟不丗丕下丟:  this.transform);
    }
    private void 丝丁丝且丒丂七丕丂()
    {
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_1 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_3 = SpawnDungeonMobeSetting.丘丁一丏上丆丑丏东(丝三丁东丈丒世丅业:  this.gameObject);
        if(val_3 == null)
        {
                return;
        }
        
        if(val_3.Count == 0)
        {
                return;
        }
        
        this._listSpawnZone.Clear();
        this._listSpawnZone = val_3;
    }
    private void 丒丝丐丂丘三且且丈()
    {
        var val_6;
        var val_10;
        var val_11;
        var val_12;
        val_10 = this;
        this._allSettingsListSpawnZone.Clear();
        SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings val_1 = new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings();
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_2 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        if(val_1 != null)
        {
                val_11 = val_1;
            .listZoneSpawn = val_2;
        }
        else
        {
                val_11 = 16;
            mem[16] = val_2;
        }
        
        val_2.AddRange(collection:  this._listSpawnZone);
        this._allSettingsListSpawnZone.Add(item:  val_1);
        ScenarioController val_3 = UnityEngine.Object.FindObjectOfType<ScenarioController>();
        List.Enumerator<T> val_4 = val_3.listZones.GetEnumerator();
        label_16:
        if((1100646352 & 1) == 0)
        {
            goto label_10;
        }
        
        new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings() = new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings();
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_9 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        if(new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings() != null)
        {
                val_12 = new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings();
            .listZoneSpawn = null;
        }
        else
        {
                mem[16] = null;
            val_12 = 16;
        }
        
        null.AddRange(collection:  val_6.丐丏七丌丕丗业且上());
        this._allSettingsListSpawnZone.Add(item:  new SpawnDungeonMobeSetting.ListZoneSpawnDungeonSettings());
        goto label_16;
        label_10:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static System.Collections.Generic.List<SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings> 丘丁一丏上丆丑丏东(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_8;
        var val_16;
        var val_24;
        UnityEngine.Object val_36;
        System.Collections.Generic.List<T> val_37;
        T[] val_38;
        var val_40;
        var val_41;
        var val_42;
        var val_47;
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_1 = null;
        val_37 = val_1;
        val_1 = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        val_38 = 丝三丁东丈丒世丅业.GetComponentsInChildren<ZoneSpawnDungeonMobSettings>();
        val_40 = 0;
        val_41 = 0;
        val_42 = 0;
        goto label_103;
        label_107:
        T val_35 = val_38[0];
        SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings val_3 = new SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings();
        UnityEngine.Vector3 val_5 = val_35.transform.position;
        .centerPoint = val_5;
        mem[1152921540067598796] = val_5.y;
        mem[1152921540067598800] = val_5.z;
        if(val_35 != 0)
        {
                .nameZone = val_2[0x0][0] + 24;
            .typeSpawn = val_2[0x0][0] + 32;
            .maxSpawnFlask = val_2[0x0][0] + 36;
        }
        else
        {
                .nameZone = 28563616;
            .typeSpawn = 64;
            .maxSpawnFlask = 0;
        }
        
        List.Enumerator<T> val_6 = val_2[0x0][0] + 40.GetEnumerator();
        label_73:
        if((1100924208 & 1) == 0)
        {
            goto label_10;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        new SpawnDungeonMobeSetting.PointSpawnDungeonSettings() = new SpawnDungeonMobeSetting.PointSpawnDungeonSettings();
        if(val_9 == null)
        {
            goto label_60;
        }
        
        .nameMob = val_2[0x0][0] + 40;
        UnityEngine.Vector3 val_13 = val_9.transform.position;
        .centerPoint = val_13;
        mem[1152921540067611124] = val_13.y;
        mem[1152921540067611128] = val_13.z;
        .typeComplaexity = null;
        .typeSpawnDungeonTask = null;
        .checkWeight = null;
        List.Enumerator<T> val_14 = val_2[0x0][0] + 40.GetEnumerator();
        label_23:
        if((1100924176 & 1) == 0)
        {
            goto label_17;
        }
        
        string val_17 = val_16.丐丏七丌丕丗业且上();
        new SpawnDungeonMobeSetting.AreaInfo() = new SpawnDungeonMobeSetting.AreaInfo();
        UnityEngine.Vector3 val_20 = val_17.transform.position;
        .centerArea = val_20;
        mem[1152921540067623364] = val_20.y;
        mem[1152921540067623368] = val_20.z;
        UnityEngine.Vector3 val_21 = val_17.size;
        .sizeArea = val_21;
        mem[1152921540067623376] = val_21.y;
        mem[1152921540067623380] = val_21.z;
        (SpawnDungeonMobeSetting.PointSpawnDungeonSettings)[1152921540067611056].chaseListArea.Add(item:  new SpawnDungeonMobeSetting.AreaInfo());
        goto label_23;
        label_17:
        var val_36 = val_42;
        val_36 = val_36 + 1;
        mem2[0] = 322;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_38 = val_36;
        if((val_38 != 1) && ((1100924064 + ((val_42 + 1)) << 2) == 322))
        {
                var val_37 = 0;
            val_37 = val_37 ^ (val_38 >> 31);
            val_38 = val_38 + val_37;
        }
        else
        {
                if( != 0)
        {
                val_47 = 0;
        }
        
        }
        
        List.Enumerator<T> val_22 = val_2[0x0][0] + 40.GetEnumerator();
        label_44:
        if((1100924176 & 1) == 0)
        {
            goto label_39;
        }
        
        string val_25 = val_24.丐丏七丌丕丗业且上();
        new SpawnDungeonMobeSetting.AreaInfo() = new SpawnDungeonMobeSetting.AreaInfo();
        UnityEngine.Vector3 val_27 = val_25.center;
        .centerArea = val_27;
        mem[1152921540067639748] = val_27.y;
        mem[1152921540067639752] = val_27.z;
        UnityEngine.Vector3 val_28 = val_25.size;
        .sizeArea = val_28;
        mem[1152921540067639760] = val_28.y;
        mem[1152921540067639764] = val_28.z;
        (SpawnDungeonMobeSetting.PointSpawnDungeonSettings)[1152921540067611056].patrolListArea.Add(item:  new SpawnDungeonMobeSetting.AreaInfo());
        goto label_44;
        label_39:
        var val_39 = val_38;
        val_39 = val_39 + 1;
        mem2[0] = 527;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_41 = val_39;
        if((val_41 == 1) || ((1100924064 + ((((val_42 + 1) + (0 ^ ((int)(val_42 + 1)) >> 31)) + 1)) << 2) != 527))
        {
            goto label_54;
        }
        
        var val_40 = 0;
        val_40 = val_40 ^ (val_41 >> 31);
        val_41 = val_41 + val_40;
        if(val_3 != null)
        {
            goto label_63;
        }
        
        goto label_63;
        label_54:
        label_60:
        label_63:
        (SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings)[1152921540067598768].listPointSpawnDungeonMob.Add(item:  new SpawnDungeonMobeSetting.PointSpawnDungeonSettings());
        goto label_73;
        label_10:
        val_42 = val_41 + 1;
        mem2[0] = 569;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || ((1100924064 + (((((val_42 + 1) + (0 ^ ((int)(val_42 + 1)) >> 31)) + 1) + (0 ^ ((int)(((val_42 + 1) + (0 ^ ((int)(val_42 + 1)) >> 31)) + 1)) >> 31))) << 2) != 569))
        {
            goto label_95;
        }
        
        var val_42 = 0;
        val_42 = val_42 ^ ( >> 31);
        val_42 =  + val_42;
        if(val_37 != null)
        {
            goto label_104;
        }
        
        goto label_105;
        label_95:
        if( == 0)
        {
            goto label_98;
        }
        
        val_40 = 0;
        if(val_37 != null)
        {
            goto label_104;
        }
        
        label_105:
        label_104:
        val_1.Add(item:  val_3);
        val_36 = val_35.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  val_36);
        val_38 = val_38;
        val_41 = 1;
        goto label_103;
        label_98:
        if(val_37 != null)
        {
            goto label_104;
        }
        
        goto label_105;
        label_103:
        if(val_41 < val_2.Length)
        {
            goto label_107;
        }
        
        return (System.Collections.Generic.List<ZoneSpawnDungeonSettings>)val_37;
    }
    internal static void 丒丞专丞世丈丅丏丙(System.Collections.Generic.List<SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings> 丛丝上丗丘业丌七丗, UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        var val_3;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_29;
        List.Enumerator<T> val_1 = 丛丝上丗丘业丌七丗.GetEnumerator();
        val_22 = 1152921540065945424;
        val_23 = 1152921504834002944;
        val_24 = 0;
        val_25 = 0;
        label_74:
        if((1101234256 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Collections.Generic.List<UnityEngine.BoxCollider> val_5 = new System.Collections.Generic.List<UnityEngine.BoxCollider>();
        new UnityEngine.GameObject() = new UnityEngine.GameObject();
        new UnityEngine.GameObject().transform.SetParent(p:  丄上七丟不丗丕下丟);
        ZoneSpawnDungeonMobSettings val_8 = new UnityEngine.GameObject().AddComponent<ZoneSpawnDungeonMobSettings>();
        if(val_8 != null)
        {
                val_8.nameZone = val_4.m_stringLength;
        }
        else
        {
                mem[24] = val_4.m_stringLength;
        }
        
        UnityEngine.Transform val_9 = val_8.transform;
        val_9.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
        val_8.maxSpawnFlask = val_9;
        new UnityEngine.GameObject().name = val_4.m_stringLength;
        val_8.typeSpawn = 24;
        List.Enumerator<T> val_10 = val_3.丐丏七丌丕丗业且上().GetEnumerator();
        label_42:
        if((1101234224 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_11 = val_3.丐丏七丌丕丗业且上();
        new UnityEngine.GameObject() = new UnityEngine.GameObject();
        new UnityEngine.GameObject().transform.SetParent(p:  new UnityEngine.GameObject().transform);
        new UnityEngine.GameObject().transform.position = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
        int val_22 = val_11.m_stringLength;
        val_22 = val_22 - 1;
        if(val_22 > 4)
        {
            goto label_42;
        }
        
        var val_23 = 106033972 + ((val_11.m_stringLength - 1)) << 2;
        val_23 = val_23 + 106033972;
        goto (106033972 + ((val_11.m_stringLength - 1)) << 2 + 106033972);
        label_13:
        val_26 = 0 + 1;
        mem2[0] = 454;
        val_27 = val_25;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(( == 1) || (val_21 != 454))
        {
            goto label_71;
        }
        
        var val_24 = 0;
        val_24 = val_24 ^ 0;
         =  + val_24;
        goto label_74;
        label_71:
        if( == 0)
        {
            goto label_74;
        }
        
        goto label_74;
        label_2:
        val_29 = 0 + 1;
        mem2[0] = 482;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(val_21 == 482)
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
    private static void 三丗丈丆丝一不丐丒(ZoneSpawnDungeonMobSettings 业丌丛丂丑丛丟丁丄, UnityEngine.GameObject 丅专与丒丈丗丒丘丌, SpawnDungeonMobeSetting.PointSpawnDungeonSettings 丟业丙丌世丝与丄且, System.Collections.Generic.List<UnityEngine.BoxCollider> 丐东业丄万七丅业世)
    {
        int val_5;
        var val_23;
        UnityEngine.Object val_25;
        val_23 = 丐东业丄万七丅业世;
        业丌丛丂丑丛丟丁丄.listPointSpawn.Add(item:  丅专与丒丈丗丒丘丌.AddComponent<PointSpawnDungeonMobSettings>());
        val_1.nameMob = 丟业丙丌世丝与丄且.nameMob;
        val_1.patrolListArea = new System.Collections.Generic.List<UnityEngine.BoxCollider>();
        List.Enumerator<T> val_3 = 丟业丙丌世丝与丄且.patrolListArea.GetEnumerator();
        label_14:
        if((1101557296 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        UnityEngine.BoxCollider val_7 = 丅专与丒丈丗丒丘丌.AddComponent<UnityEngine.BoxCollider>();
        val_1.patrolListArea.Add(item:  val_7);
        val_7.center = new UnityEngine.Vector3() {x = val_6.m_stringLength, y = val_6.m_firstChar, z = V10.16B};
        val_7.size = new UnityEngine.Vector3() {x = val_6.m_stringLength, y = val_6.m_firstChar, z = V10.16B};
        goto label_14;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(丟业丙丌世丝与丄且 != null)
        {
            goto label_15;
        }
        
        goto label_24;
        label_15:
        val_1.checkWeight = 丟业丙丌世丝与丄且.checkWeight;
        val_1.typeSpawnDungeonTask = 丟业丙丌世丝与丄且.typeSpawnDungeonTask;
        goto label_25;
        label_24:
        val_1.checkWeight = false;
        val_1.typeSpawnDungeonTask = 11993091;
        label_25:
        val_1.typeComplexyty = 丟业丙丌世丝与丄且.typeComplaexity;
        val_1.chaseListArea = new System.Collections.Generic.List<UnityEngine.BoxCollider>();
        List.Enumerator<T> val_9 = 丟业丙丌世丝与丄且.chaseListArea.GetEnumerator();
        label_47:
        if((1101557296 & 1) == 0)
        {
            goto label_28;
        }
        
        new SpawnDungeonMobeSetting.三丕业丁丗东丂七丝() = new SpawnDungeonMobeSetting.三丕业丁丗东丂七丝();
        .下万丕下万丙丑上业 = val_5.丐丏七丌丕丗业且上();
        System.Predicate<UnityEngine.BoxCollider> val_12 = new System.Predicate<UnityEngine.BoxCollider>(object:  new SpawnDungeonMobeSetting.三丕业丁丗东丂七丝(), method:  System.Boolean SpawnDungeonMobeSetting.三丕业丁丗东丂七丝::丛丒丐丝不丐丘丐专(UnityEngine.BoxCollider 三丟东丕丄丄下下丑));
        val_25 = val_23.Find(match:  null);
        if(val_25 == 0)
        {
                new UnityEngine.GameObject() = new UnityEngine.GameObject();
            new UnityEngine.GameObject().transform.SetParent(p:  业丌丛丂丑丛丟丁丄.transform);
            val_5 = val_23.Count + 1;
            new UnityEngine.GameObject().name = "chaseAreas_" + val_5;
            val_25 = new UnityEngine.GameObject().AddComponent<UnityEngine.BoxCollider>();
            new UnityEngine.GameObject().transform.position = new UnityEngine.Vector3() {x = (SpawnDungeonMobeSetting.三丕业丁丗东丂七丝)[1152921540068252336].下万丕下万丙丑上业.centerArea, y = V9.16B, z = V10.16B};
            val_25.size = new UnityEngine.Vector3() {x = (SpawnDungeonMobeSetting.三丕业丁丗东丂七丝)[1152921540068252336].下万丕下万丙丑上业.sizeArea, y = V9.16B, z = V10.16B};
            val_23.Add(item:  val_25);
        }
        
        val_1.chaseListArea.Add(item:  val_25);
        goto label_47;
        label_28:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public SpawnDungeonMobeSetting()
    {
        this._listSpawnZone = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        this._allSettingsListSpawnZone = new System.Collections.Generic.List<ListZoneSpawnDungeonSettings>();
        this.三上上丌丞丂丐下业 = new System.Collections.Generic.List<七丂丅丘丒三丅丂丈>();
    }
    private static SpawnDungeonMobeSetting()
    {
        SpawnDungeonMobeSetting.专世丟丂业世丟丐丐 = "DungeonMobs/";
        SpawnDungeonMobeSetting.丏丂下丂丐业万七丕 = 0;
    }

}
