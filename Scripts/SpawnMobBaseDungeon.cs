using UnityEngine;
internal class SpawnMobBaseDungeon : SpawnMobBase
{
    // Fields
    private static System.Action<SpawnMobBaseDungeon> 万丟丛专世下丕丄丈;
    private System.Action<SpawnMobBaseDungeon> 丛七丑丈丑万万三丌;
    public DamageableObject _damagebleObject;
    private UnityEngine.Transform pointForHealth;
    private DamageableObjectHealthUI 丏丆上丑专不丑丌丙;
    private string _loadHealthPath;
    private WorldPosIndicationItem_Distanced 东丄与丛丂丘丝三丝;
    private float indicationOffset;
    
    // Methods
    internal static void 丆一上丗丆丟不专业(System.Action<SpawnMobBaseDungeon> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  SpawnMobBaseDungeon.万丟丛专世下丕丄丈, b:  丙业与丙丗丝不丈东);
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
    internal static void 丛丙丏丞东丁丆丟世(System.Action<SpawnMobBaseDungeon> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  SpawnMobBaseDungeon.万丟丛专世下丕丄丈, value:  丙业与丙丗丝不丈东);
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
    internal void 下七丌丐业丙丌丟丆(System.Action<SpawnMobBaseDungeon> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛七丑丈丑万万三丌, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛七丑丈丑万万三丌 != 1152921540073661168);
    
    }
    internal void 丏丁专丑丟丛丟丒丝(System.Action<SpawnMobBaseDungeon> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛七丑丈丑万万三丌, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛七丑丈丑万万三丌 != 1152921540073797744);
    
    }
    protected override void Start()
    {
        this.Start();
        if(SpawnMobBaseDungeon.万丟丛专世下丕丄丈 != null)
        {
                SpawnMobBaseDungeon.万丟丛专世下丕丄丈.Invoke(obj:  this);
        }
        
        if(this._damagebleObject != 0)
        {
                this._damagebleObject.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpawnMobBaseDungeon::上专世丌丑与丕丛丕()));
            this._damagebleObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpawnMobBaseDungeon::丕丕丞不丆业东下丒()));
        }
        
        DamageableObjectHealthUI val_5 = UnityEngine.Object.Instantiate<DamageableObjectHealthUI>(original:  UnityEngine.Resources.Load<DamageableObjectHealthUI>(path:  this._loadHealthPath));
        this.丏丆上丑专不丑丌丙 = val_5;
        val_5.gameObject.SetActive(value:  true);
        this.丏丆上丑专不丑丌丙.transform.SetParent(p:  this.pointForHealth);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.丏丆上丑专不丑丌丙.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        this.丏丆上丑专不丑丌丙.不丒世下丝万丙丟丆(丘万丗丑丘丅丆丛万:  this._damagebleObject);
    }
    protected override void OnDestroy()
    {
        this.OnDestroy();
        if(this.丛七丑丈丑万万三丌 != null)
        {
                this.丛七丑丈丑万万三丌.Invoke(obj:  this);
        }
        
        if(this._damagebleObject == 0)
        {
                return;
        }
        
        this._damagebleObject.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpawnMobBaseDungeon::上专世丌丑与丕丛丕()));
        this._damagebleObject.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void SpawnMobBaseDungeon::丕丕丞不丆业东下丒()));
    }
    private void 上专世丌丑与丕丛丕()
    {
    
    }
    private void OnMasterClientSwitched(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this._damagebleObject.三丏丟不丆丅丞不丛() > 0f)
        {
                return;
        }
        
        if(this._damagebleObject.isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
    }
    private void 丕丕丞不丆业东下丒()
    {
        if(this.丛七丑丈丑万万三丌 != null)
        {
                this.丛七丑丈丑万万三丌.Invoke(obj:  this);
        }
        
        if(isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(不丈丘丟上丈丘丝丗:  this);
    }
    internal void 丛上丐丘丝丑丄丛业()
    {
        var val_11;
        WorldPosIndicationItem_Distanced val_1 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        this.东丄与丛丂丘丝三丝 = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        this.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  this.transform, 丒专丌万丄一丒万丏:  this.indicationOffset);
        this.东丄与丛丂丘丝三丝.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  4));
        UnityEngine.Color val_5 = UnityEngine.Color.green;
        val_11 = null;
        val_11 = null;
        this.东丄与丛丂丘丝三丝.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  this.transform, 丙七丟丏丅丘丈丁丄:  transform);
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        NJGMapItem val_10 = AddMiniMapIcon(业丟丏上丛与不一丝:  this.gameObject, 下丗丁丒丘东丂不丑:  17);
    }
    internal void 专东丗三丛丅丘世世()
    {
        WorldPosIndicationsController val_5;
        UnityEngine.GameObject val_6;
        val_5 = this;
        val_6 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                val_6 = this.gameObject;
            RemoveMiniMapIcon(业丟丏上丛与不一丝:  val_6);
        }
        
        if(this.东丄与丛丂丘丝三丝 == 0)
        {
                return;
        }
        
        val_5 = WorldPosIndicationsController.丄丘七三上丕世丞业;
        val_5.RemoveItem(下丅丙一丂丗丅丝七: ref  this.东丄与丛丂丘丝三丝);
    }
    public SpawnMobBaseDungeon()
    {
        this.indicationOffset = 0.5f;
        this._loadHealthPath = "HealthBarForDamageableObject";
    }

}
