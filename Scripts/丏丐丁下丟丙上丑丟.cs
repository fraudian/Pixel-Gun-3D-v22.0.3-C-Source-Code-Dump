using UnityEngine;
private sealed class ScenarioZoneSettings.丏丐丁下丟丙上丑丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ScenarioZoneSettings 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ScenarioZoneSettings.丏丐丁下丟丙上丑丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        var val_23;
        int val_24;
        var val_25;
        UnityEngine.Transform val_26;
        UnityEngine.Transform val_27;
        var val_28;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        goto label_66;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._triggerObject != 0)
        {
                val_22 = null;
            val_22 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_23 = null;
            val_23 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                if(this.丝且与丝丒丟万丁专.pointForCalculateDistance != 0)
        {
            goto label_21;
        }
        
        }
        
        }
        
        }
        
        label_66:
        val_24 = 1;
        this.丗丏丅丕丆世丁专丟 = val_24;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_24;
        label_2:
        val_24 = 0;
        return (bool)val_24;
        label_21:
        val_25 = null;
        val_25 = null;
        UnityEngine.Vector3 val_7 = transform.position;
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专.pointForCalculateDistance.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z})) <= this.丝且与丝丒丟万丁专._distanceForActivateIndicator)
        {
            goto label_31;
        }
        
        if(this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 != 0)
        {
            goto label_66;
        }
        
        WorldPosIndicationItem_Distanced val_11 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 = val_11;
        if(val_11 == 0)
        {
            goto label_66;
        }
        
        if(this.丝且与丝丒丟万丁专._targetDoor != 0)
        {
            goto label_41;
        }
        
        val_26 = this.丝且与丝丒丟万丁专._triggerObject.transform;
        goto label_43;
        label_31:
        if(this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 == 0)
        {
            goto label_66;
        }
        
        WorldPosIndicationsController.丄丘七三上丕世丞业.RemoveItem(下丅丙一丂丗丅丝七: ref  this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝);
        goto label_66;
        label_41:
        val_26 = this.丝且与丝丒丟万丁专._targetDoor;
        label_43:
        this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.万三丗丆下万丅上丈(丞下万上三丘上与专:  val_26, 丒专丌万丄一丒万丏:  this.丝且与丝丒丟万丁专._triggerObject.indicationOffset);
        this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  DungeonsController.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  ScenarioController.丄丘七三上丕世丞业.iconDoor));
        if(this.丝且与丝丒丟万丁专._targetDoor == 0)
        {
                val_27 = this.丝且与丝丒丟万丁专._triggerObject.transform;
        }
        else
        {
                val_27 = this.丝且与丝丒丟万丁专._targetDoor;
        }
        
        val_28 = null;
        val_28 = null;
        this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝.下上丐丌七丁丄丝丑(丑东与丅丐丅丂丞业:  val_27, 丙七丟丏丅丘丈丁丄:  transform);
        UnityEngine.Color val_21 = UnityEngine.Color.blue;
        if(this.丝且与丝丒丟万丁专.东丄与丛丂丘丝三丝 != null)
        {
            goto label_66;
        }
        
        goto label_66;
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
