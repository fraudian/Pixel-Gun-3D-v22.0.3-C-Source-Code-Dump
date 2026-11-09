using UnityEngine;
internal class SquareFieldPhysicsCell : SquareFieldCell
{
    // Fields
    internal SquareFieldObjectType Flag;
    private System.Collections.Generic.List<SquareFieldObjectType> _ignoredFlags;
    protected System.Collections.Generic.List<SquareFieldPhysicsCell> _triggered;
    
    // Properties
    internal bool 万丑不东一丂不万万 { get; }
    
    // Methods
    internal bool 世万丆三一丌且丟一()
    {
        var val_5 = null;
        if((SquareFieldPhysicsCell.<>c.<>9__4_0) == null)
        {
            goto label_3;
        }
        
        label_9:
        int val_1 = this._triggered.RemoveAll(match:  SquareFieldPhysicsCell.<>c.<>9__4_0);
        return (bool)(this._triggered.Count > 0) ? 1 : 0;
        label_3:
        SquareFieldPhysicsCell.<>c.<>9__4_0 = new System.Predicate<SquareFieldPhysicsCell>(object:  SquareFieldPhysicsCell.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SquareFieldPhysicsCell.<>c::丑专三专丝上三与世(SquareFieldPhysicsCell 三丟东丕丄丄下下丑));
        if(this._triggered != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        System.Collections.Generic.List<SquareFieldPhysicsCell> val_7;
        UnityEngine.Object val_8;
        val_7 = 1152921504848912384;
        if(丘丛丏丘丝七世七丅 == 0)
        {
                return;
        }
        
        SquareFieldPhysicsCell val_3 = 丘丛丏丘丝七世七丅.gameObject.GetComponent<SquareFieldPhysicsCell>();
        val_8 = 0;
        if(val_3 != val_8)
        {
                val_7 = this._triggered;
            val_8 = val_3;
            if((val_7.Contains(item:  val_8)) != true)
        {
                val_7 = this._ignoredFlags;
            val_8 = val_3.Flag;
            if((val_7.Contains(item:  val_8)) != true)
        {
                val_7 = this._triggered;
            val_8 = val_3;
            val_7.Add(item:  val_8);
        }
        
        }
        
        }
    
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_7;
        if(丘丛丏丘丝七世七丅 == 0)
        {
                return;
        }
        
        SquareFieldPhysicsCell val_3 = 丘丛丏丘丝七世七丅.gameObject.GetComponent<SquareFieldPhysicsCell>();
        val_7 = 0;
        if(val_3 != val_7)
        {
                val_7 = val_3;
            if((this._triggered.Contains(item:  val_7)) != false)
        {
                val_7 = val_3;
            bool val_6 = this._triggered.Remove(item:  val_7);
        }
        
        }
    
    }
    internal override void 丕丕业七丙七丅丈丄()
    {
    
    }
    internal override void 丌且丄七丈与丕丆不()
    {
        if(mem[137134148] == 1)
        {
                return;
        }
        
        if(mem[137134185] == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        FortFieldTurretPlatformController.instance.与丛丕丒丛不丆丙与(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丈下丑丆上丏丗丈专:  this.ItemRarity);
    }
    internal void 丙且七丛一上丆下丁()
    {
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        FortFieldTurretPlatformController.instance.丅丒丘丗上不世丆丐(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    internal SquareFieldPhysicsCell 三不丂与万丝业与丌()
    {
        System.Collections.Generic.List<SquareFieldPhysicsCell> val_3;
        var val_4;
        val_3 = this;
        if(this._triggered.Count >= 1)
        {
                val_3 = this._triggered;
            SquareFieldPhysicsCell val_2 = val_3.Item[0];
            return (SquareFieldPhysicsCell)val_4;
        }
        
        val_4 = 0;
        return (SquareFieldPhysicsCell)val_4;
    }
    public SquareFieldPhysicsCell()
    {
        this._ignoredFlags = new System.Collections.Generic.List<SquareFieldObjectType>();
        this._triggered = new System.Collections.Generic.List<SquareFieldPhysicsCell>();
        mem[1152921539198574384] = 1;
        mem[1152921539198574404] = 1056964608;
        this = new PGBehaviour();
    }

}
