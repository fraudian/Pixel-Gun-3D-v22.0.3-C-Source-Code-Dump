using UnityEngine;
private sealed class ScenarioZoneSettings.丄丟丟丆下丈丕七东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ScenarioZoneSettings 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScenarioZoneSettings.丄丟丟丆下丈丕七东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TriggerObject val_25;
        int val_26;
        UnityEngine.Transform val_27;
        var val_28;
        var val_29;
        UnityEngine.Transform val_30;
        UnityEngine.Transform val_31;
        var val_32;
        float val_33;
        float val_34;
        val_25 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_66;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
            goto label_7;
        }
        
        }
        
        val_26 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_7:
        val_25 = this.丝且与丝丒丟万丁专._triggerObject;
        if(val_25 == 0)
        {
            goto label_66;
        }
        
        val_27 = 1152921505286238208;
        val_28 = null;
        val_28 = null;
        val_25 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_25 == 0)
        {
            goto label_66;
        }
        
        val_29 = null;
        val_29 = null;
        val_25 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_25 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if(val_25 == 0)
        {
            goto label_66;
        }
        
        WorldPosIndicationItem_Distanced val_6 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 = val_6;
        if(val_6 != 0)
        {
                if(this.丝且与丝丒丟万丁专._targetDoor == 0)
        {
                val_30 = this.丝且与丝丒丟万丁专._triggerObject.transform;
        }
        else
        {
                val_30 = this.丝且与丝丒丟万丁专._targetDoor;
        }
        
            this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  val_30, 丒专丌万丄一丒万丏:  this.丝且与丝丒丟万丁专._triggerObject.indicationOffset);
            this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  ScenarioController.丄丘七三上丕世丞业.iconDoor));
            if(this.丝且与丝丒丟万丁专._targetDoor == 0)
        {
                val_31 = this.丝且与丝丒丟万丁专._triggerObject.transform;
        }
        else
        {
                val_31 = this.丝且与丝丒丟万丁专._targetDoor;
        }
        
            val_32 = null;
            val_32 = null;
            val_27 = transform;
            this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_31, 丙七丟丏丅丘丈丁丄:  val_27);
            UnityEngine.Color val_14 = UnityEngine.Color.blue;
            val_33 = val_14.r;
            val_34 = val_14.b;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
            goto label_52;
        }
        
        if(this.丝且与丝丒丟万丁专._targetDoor != 0)
        {
            goto label_56;
        }
        
        if(this.丝且与丝丒丟万丁专._triggerObject != null)
        {
            goto label_72;
        }
        
        label_73:
        label_72:
        NJGMapItem val_18 = AddMiniMapIcon(业丟丏上丛与不一丝:  this.丝且与丝丒丟万丁专._triggerObject.gameObject, 下丗丁丒丘东丂不丑:  15);
        label_52:
        val_25 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_25 != 0)
        {
                val_25 = 丐七丆丐丏丁东丅专();
            if(val_25 != 0)
        {
                val_25 = 丐七丆丐丏丁东丅专();
            UnityEngine.Color val_23 = UnityEngine.Color.white;
            val_33 = val_23.r;
            val_34 = val_23.b;
            val_25.丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  0f, 上丕丈丞丌丘丅不与:  "", 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_33, g = val_23.g, b = val_34, a = val_23.a}, 丘丏丑丁专上世丄不:  false, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丝且与丝丒丟万丁专._keyEnterTheDoor), 三世丏且丑下专丟丟:  "");
        }
        
        }
        
        label_66:
        val_26 = 0;
        return (bool)val_26;
        label_56:
        if(this.丝且与丝丒丟万丁专._targetDoor != null)
        {
            goto label_72;
        }
        
        goto label_73;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
