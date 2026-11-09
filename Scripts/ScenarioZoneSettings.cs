using UnityEngine;
internal class ScenarioZoneSettings : MonoBehaviour
{
    // Fields
    internal static ScenarioZoneSettings 丄丘七三上丕世丞业;
    public System.Collections.Generic.List<SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings> listRulesForZone;
    private TriggerObject _triggerObject;
    public bool activateScenario;
    internal SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings 上丞丟丏万丝且丆下;
    internal int 上东丟三丒丛丁不且;
    private UnityEngine.Vector3 positionSpawnKey;
    private string _nameKey;
    public bool uniqueChallenge;
    private string _keyEnterTheDoor;
    private System.Collections.Generic.List<RilisoftBot.BaseBot> 业丁与丆丁丄与七丘;
    private System.Collections.Generic.List<FlasksDungeonObject> 三丆丅丛专丒丂专丆;
    private System.Collections.Generic.List<SpawnMobBaseDungeon> 丂不业丂丅且不业业;
    internal System.Collections.Generic.List<AltarePoint> 丗丂丄丕丞丁下东丌;
    private TriggerOpenDungeonDoor 丌丌专丂丞七丛丄业;
    private bool 丁丄东下下丟丘丛丈;
    private UnityEngine.Transform _targetDoor;
    private System.Action 业丙世七丘丁且丘且;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    private UnityEngine.Coroutine 丅上丝丗上丆且丂一;
    private UnityEngine.Coroutine 丌三丏丏丏丂丄丈丟;
    private float _distanceForActivateIndicator;
    private UnityEngine.Transform pointForCalculateDistance;
    
    // Properties
    internal TriggerOpenDungeonDoor 上东丞丗且丅丌丐丐 { get; }
    
    // Methods
    internal TriggerOpenDungeonDoor 万世丞上三丙丘丂一()
    {
        TriggerOpenDungeonDoor val_2;
        if(this.丁丄东下下丟丘丛丈 != false)
        {
                val_2 = this.丌丌专丂丞七丛丄业;
            return val_1;
        }
        
        TriggerOpenDungeonDoor val_1 = this._triggerObject.GetComponent<TriggerOpenDungeonDoor>();
        this.丌丌专丂丞七丛丄业 = val_1;
        this.丁丄东下下丟丘丛丈 = true;
        return val_1;
    }
    internal void 专丗丌丛万丌专丈丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.业丙世七丘丁且丘且, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丙世七丘丁且丘且 != 1152921540054729160);
    
    }
    internal void 丌七丂不丂丌丕上丟(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.业丙世七丘丁且丘且, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丙世七丘丁且丘且 != 1152921540054865736);
    
    }
    private void 丈上一七丆丒丂丕丐()
    {
        SpawnDungeonMobeSetting.丒丞专丞世丈丅丏丙(丛丝上丗丘业丌七丗:  this.listRulesForZone, 丄上七丟不丗丕下丟:  this.transform);
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
        
        this.listRulesForZone.Clear();
        this.listRulesForZone = val_3;
    }
    private void Awake()
    {
        ScenarioZoneSettings.丄丘七三上丕世丞业 = this;
        if(this._triggerObject == 0)
        {
                return;
        }
        
        this._triggerObject.专三丅且丌丏万丕丆(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ScenarioZoneSettings::一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)));
    }
    private void OnDestroy()
    {
        if(this._triggerObject != 0)
        {
                this._triggerObject.三丛丐丄丑丗丏丞上(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ScenarioZoneSettings::一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)));
        }
        
        if(this.丌三丏丏丏丂丄丈丟 != null)
        {
                this.StopCoroutine(routine:  this.丌三丏丏丏丂丄丈丟);
            this.丌三丏丏丏丂丄丈丟 = 0;
        }
        
        if(this.东丄与丛丂丘丝三丝 == 0)
        {
                return;
        }
        
        this = WorldPosIndicationsController.丄丘七三上丕世丞业;
        this.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
    }
    internal void 丏东丙丕丏丏丆业丝(System.Random 丂丆且一丛丙丑七丒)
    {
        int val_1 = this.listRulesForZone.Count;
        ZoneSpawnDungeonSettings val_2 = this.listRulesForZone.Item[丂丆且一丛丙丑七丒];
        this.业与丟业专丌丘丈世(丂丆且一丛丙丑七丒:  丂丆且一丛丙丑七丒, 丗丏丅丕万丕丘三丘:  val_2.typeSpawn);
    }
    internal void 业与丟业专丌丘丈世(System.Random 丂丆且一丛丙丑七丒, 丙丟七丁世丌上丟丏 丗丏丅丕万丕丘三丘)
    {
        var val_11;
        System.Collections.Generic.List<ZoneSpawnDungeonSettings> val_17;
        System.Predicate<T> val_18;
        ZoneSpawnDungeonSettings val_19;
        .丗丏丅丕万丕丘三丘 = 丗丏丅丕万丕丘三丘;
        val_17 = this.listRulesForZone;
        System.Predicate<ZoneSpawnDungeonSettings> val_2 = null;
        val_18 = val_2;
        val_2 = new System.Predicate<ZoneSpawnDungeonSettings>(object:  new ScenarioZoneSettings.丘丞三且东万丕丙丂(), method:  System.Boolean ScenarioZoneSettings.丘丞三且东万丕丙丂::丌专业丄一丄丂丏业(SpawnDungeonMobeSetting.ZoneSpawnDungeonSettings 三丟东丕丄丄下下丑));
        ZoneSpawnDungeonSettings val_3 = val_17.Find(match:  val_2);
        this.上丞丟丏万丝且丆下 = val_3;
        if(val_3 == null)
        {
                return;
        }
        
        val_18 = 1152921540055106544;
        var val_16 = 0;
        label_7:
        if(val_16 >= this.listRulesForZone.Count)
        {
            goto label_5;
        }
        
        val_19 = this.上丞丟丏万丝且丆下;
        val_16 = val_16 + 1;
        if(val_19 != this.listRulesForZone.Item[0])
        {
            goto label_7;
        }
        
        int val_17 = this.上东丟三丒丛丁不且;
        val_17 = val_17 + 1;
        this.上东丟三丒丛丁不且 = val_17;
        label_5:
        val_17 = this.上丞丟丏万丝且丆下;
        if(this.上丞丟丏万丝且丆下.typeSpawn != 3)
        {
                return;
        }
        
        System.Collections.Generic.List<PointSpawnDungeonSettings> val_7 = null;
        val_17 = val_7;
        val_7 = new System.Collections.Generic.List<PointSpawnDungeonSettings>();
        System.Collections.Generic.List<PointSpawnDungeonSettings> val_8 = null;
        val_18 = val_8;
        val_8 = new System.Collections.Generic.List<PointSpawnDungeonSettings>();
        this.上丞丟丏万丝且丆下.listPointSpawnDungeonMob = val_18;
        List.Enumerator<T> val_9 = System.Linq.Enumerable.ToList<PointSpawnDungeonSettings>(source:  this.上丞丟丏万丝且丆下.listPointSpawnDungeonMob).GetEnumerator();
        label_20:
        if((1089227856 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_12 = val_11.丐丏七丌丕丗业且上();
        if(val_12.m_stringLength != 3)
        {
            goto label_15;
        }
        
        val_7.Add(item:  val_12);
        goto label_20;
        label_15:
        this.上丞丟丏万丝且丆下.listPointSpawnDungeonMob.Add(item:  val_12);
        goto label_20;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_19 = 0;
        goto label_28;
        label_36:
        int val_13 = val_7.Count;
        PointSpawnDungeonSettings val_14 = val_7.Item[丂丆且一丛丙丑七丒];
        val_18 = this.上丞丟丏万丝且丆下.listPointSpawnDungeonMob;
        val_18.Add(item:  val_14);
        bool val_15 = val_7.Remove(item:  val_14);
        val_19 = 1;
        label_28:
        if(this.上丞丟丏万丝且丆下.maxSpawnFlask > val_19)
        {
            goto label_36;
        }
    
    }
    private void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)
    {
        ScenarioController.丄丘七三上丕世丞业.与丕三万丗一丂丆丂(丏业丟一东丂东丘丛:  2);
    }
    internal void 上丕丂丆丘专丆丘业()
    {
        int val_3;
        object val_29;
        System.Action val_31;
        System.Collections.Generic.List<RilisoftBot.BaseBot> val_33;
        var val_34;
        var val_36;
        UnityEngine.Object val_37;
        val_29 = this;
        this.activateScenario = true;
        this.世七丒丙丟万丁不丌();
        丙丟七丁世丌上丟丏 val_28 = this.上丞丟丏万丝且丆下.typeSpawn;
        val_28 = val_28 - 2;
        if(val_28 > 3)
        {
                return;
        }
        
        var val_29 = 106042696 + ((this.上丞丟丏万丝且丆下.typeSpawn - 2)) << 2;
        val_29 = val_29 + 106042696;
        goto (106042696 + ((this.上丞丟丏万丝且丆下.typeSpawn - 2)) << 2 + 106042696);
        label_49:
        if((1089704816 & 1) == 0)
        {
            goto label_44;
        }
        
        string val_18 = val_3.丐丏七丌丕丗业且上();
        if(val_18 == 0)
        {
            goto label_49;
        }
        
        val_18.丐丌丗丐丐丟丈上一();
        goto label_49;
        label_44:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_58:
        if((1089704816 & 1) == 0)
        {
            goto label_56;
        }
        
        val_3.丐丏七丌丕丗业且上().丐丌丗丐丐丟丈上一();
        goto label_58;
        label_56:
        val_31 = 0;
        val_36 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_62;
        }
        
        if(( == 0) || (499 == 499))
        {
            goto label_80;
        }
        
        label_79:
        label_80:
        if(this.丗丂丄丕丞丁下东丌.Count >= 1)
        {
                val_33 = this.丗丂丄丕丞丁下东丌;
            val_34 = 1152921540056252688;
            val_37 = val_33.Item[0];
        }
        else
        {
                val_37 = 0;
        }
        
        if(val_37 == 0)
        {
                return;
        }
        
        val_31 = this.上丞丟丏万丝且丆下.typeSpawn;
        object[] val_26 = new object[1];
        val_29 = val_26;
        val_29[0] = val_37;
        丆丘丆丞丙下丆丟丅 val_27 = 丌且万一上丄丒丑七.下丙丗丟丂下丏不丟(丕丛不一丛三下丄下:  val_31, 丟丘丙丄丅万丏与丗:  new System.Action(object:  this, method:  System.Void ScenarioZoneSettings::七丒丈丗与丟不丐东()), 专丒丌丆下丐丞丟丞:  val_26);
        return;
        label_62:
        if( != 0)
        {
            goto label_79;
        }
        
        goto label_80;
    }
    internal void 世七丒丙丟万丁不丌()
    {
        var val_3;
        var val_10;
        var val_11;
        var val_12;
        var val_14;
        val_10 = this;
        if(this.上丞丟丏万丝且丆下.typeSpawn == 2)
        {
            goto label_12;
        }
        
        if(this.上丞丟丏万丝且丆下.typeSpawn == 5)
        {
            goto label_22;
        }
        
        if(this.上丞丟丏万丝且丆下.typeSpawn != 4)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.业丁与丆丁丄与七丘.GetEnumerator();
        val_11 = 1152921537228165392;
        goto label_6;
        label_8:
        string val_4 = val_3.丐丏七丌丕丗业且上();
        mem2[0] = 1;
        label_6:
        if((1090001232 & 1) != 0)
        {
            goto label_8;
        }
        
        val_12 = 1152921537228170512;
        goto label_9;
        label_12:
        List.Enumerator<T> val_5 = this.丂不业丂丅且不业业.GetEnumerator();
        val_11 = 1152921540045197312;
        goto label_14;
        label_17:
        string val_6 = val_3.丐丏七丌丕丗业且上();
        mem2[0] = 0;
        label_14:
        if((1090001200 & 1) != 0)
        {
            goto label_17;
        }
        
        val_12 = 1152921540045212672;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_22:
        List.Enumerator<T> val_7 = this.丗丂丄丕丞丁下东丌.GetEnumerator();
        label_26:
        if((1090001176 & 1) == 0)
        {
            goto label_24;
        }
        
        0.丐丏七丌丕丗业且上().ActivateScenario = true;
        goto label_26;
        label_24:
        val_14 = 0;
        val_10 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(198 == 198)
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
    internal void 丏丘丁丐丆丟丝丑与()
    {
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        }
        
        if(this.丅上丝丗上丆且丂一 != null)
        {
                this.StopCoroutine(routine:  this.丅上丝丗上丆且丂一);
            this.丅上丝丗上丆且丂一 = 0;
        }
        
        this.丅上丝丗上丆且丂一 = this.StartCoroutine(routine:  this.三三丏丛一丟下业丁());
        this._triggerObject.ActivateTrigger(世丁万下丗专世万丅:  true);
    }
    private System.Collections.IEnumerator 三三丏丛一丟下业丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ScenarioZoneSettings.丄丟丟丆下丈丕七东();
    }
    private System.Collections.IEnumerator 三上丒丌丅丂丞七丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ScenarioZoneSettings.丏丐丁下丟丙上丑丟();
    }
    internal void 丅丟丄万丑丄丕七丞()
    {
        UnityEngine.GameObject val_6;
        if(this.丅上丝丗上丆且丂一 != null)
        {
                this.StopCoroutine(routine:  this.丅上丝丗上丆且丂一);
            this.丅上丝丗上丆且丂一 = 0;
        }
        
        val_6 = 1152921504848912384;
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_8;
        }
        
        if(this._targetDoor != 0)
        {
            goto label_12;
        }
        
        if(this._triggerObject != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        val_6 = this._triggerObject.gameObject;
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  val_6);
        label_8:
        this._triggerObject.ActivateTrigger(世丁万下丗专世万丅:  false);
        return;
        label_12:
        if(this._targetDoor != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }
    internal void 七丒丈丗与丟不丐东()
    {
        if(this.丌三丏丏丏丂丄丈丟 != null)
        {
                this.StopCoroutine(routine:  this.丌三丏丏丏丂丄丈丟);
            this.丌三丏丏丏丂丄丈丟 = 0;
        }
        
        if(this.东丄与丛丂丘丝三丝 != 0)
        {
                WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
        }
        
        if(this.业丙世七丘丁且丘且 == null)
        {
                return;
        }
        
        this.业丙世七丘丁且丘且.Invoke();
    }
    internal void 丈丛且丗下万与丒丟(FlasksDungeonObject 丄七丌下不丐且丐丏)
    {
        if(丄七丌下不丐且丐丏 == 0)
        {
                return;
        }
        
        this.三丆丅丛专丒丂专丆.Add(item:  丄七丌下不丐且丐丏);
    }
    internal void 丕丕丌丄丑丗丝上丐(RilisoftBot.BaseBot 与丝丈丑丝丕丘丏丅)
    {
        if(与丝丈丑丝丕丘丏丅 == 0)
        {
                return;
        }
        
        与丝丈丑丝丕丘丏丅.丞上丈丕丑万丕万一 = this.activateScenario;
        this.业丁与丆丁丄与七丘.Add(item:  与丝丈丑丝丕丘丏丅);
    }
    internal void 业万丗丂丁丆世不丞(SpawnMobBaseDungeon 丈东丝丐业专丈且丘)
    {
        if(丈东丝丐业专丈且丘 == 0)
        {
                return;
        }
        
        丈东丝丐业专丈且丘._damagebleObject.isImmortal = this.activateScenario ^ 1;
        this.丂不业丂丅且不业业.Add(item:  丈东丝丐业专丈且丘);
    }
    internal void 丏万丂业丐世丐丞上(AltarePoint 丏丄丝丞上丒丏丄下)
    {
        if(丏丄丝丞上丒丏丄下 == 0)
        {
                return;
        }
        
        丏丄丝丞上丒丏丄下.ActivateScenario = (this.activateScenario == true) ? 1 : 0;
        this.丗丂丄丕丞丁下东丌.Add(item:  丏丄丝丞上丒丏丄下);
    }
    internal UnityEngine.Vector3 东丕丛专丛万丒七丐()
    {
        return new UnityEngine.Vector3() {x = this.positionSpawnKey};
    }
    internal string 丝丗且下世丗三丙丁()
    {
        return (string)this._nameKey;
    }
    public ScenarioZoneSettings()
    {
        this.listRulesForZone = new System.Collections.Generic.List<ZoneSpawnDungeonSettings>();
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.positionSpawnKey = val_2;
        mem[1152921540058241840] = val_2.y;
        mem[1152921540058241844] = val_2.z;
        this._nameKey = "";
        this._keyEnterTheDoor = "Key_7100";
        this.业丁与丆丁丄与七丘 = new System.Collections.Generic.List<RilisoftBot.BaseBot>();
        this.三丆丅丛专丒丂专丆 = new System.Collections.Generic.List<FlasksDungeonObject>();
        this.丂不业丂丅且不业业 = new System.Collections.Generic.List<SpawnMobBaseDungeon>();
        this.丗丂丄丕丞丁下东丌 = new System.Collections.Generic.List<AltarePoint>();
        this._distanceForActivateIndicator = 60f;
    }

}
