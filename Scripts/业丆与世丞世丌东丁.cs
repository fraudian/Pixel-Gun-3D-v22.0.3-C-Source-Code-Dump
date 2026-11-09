using UnityEngine;
internal class 业丆与世丞世丌东丁 : 一上不上一丅专专丐
{
    // Methods
    internal override void 丆丌丙万与丛万丝世()
    {
        this.且下一七丒丝与世不();
    }
    protected override void 丁丟丁世丐丅上丄万()
    {
        this.丁丟丁世丐丅上丄万();
        goto typeof(业丆与世丞世丌东丁).__il2cppRuntimeField_198;
    }
    protected override void 丙丝丞一丏专丘丐丄()
    {
        this.丌丐万丛三上一与东(丏万下业丘七业丙专:  this);
        DisableWithDelay val_1 = ParticleObject;
        if(val_1 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = val_1.ParticleObject.gameObject;
        val_4.SetActive(value:  true);
        val_4.ParticleObject.下三与丙丒一丞丐丒(丕丕世且下一与丝与:  V8.16B);
    }
    protected override System.Collections.Generic.List<丅丙上七上一丐不下> 丑不专丈丄专下世丒()
    {
        var val_4;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<丅丙上七上一丐不下> val_1 = new System.Collections.Generic.List<丅丙上七上一丐不下>();
        val_20 = null;
        val_20 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_9:
        if((912678000 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if((this.丂丌专丙丒丗丗丒丆(上东丆丈业世七丈丁:  val_5.transform)) == false)
        {
            goto label_9;
        }
        
        val_1.Add(item:  val_5);
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_21 = null;
        val_21 = null;
        List.Enumerator<T> val_8 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.GetEnumerator();
        label_28:
        if((912677968 & 1) == 0)
        {
            goto label_20;
        }
        
        string val_9 = val_4.丐丏七丌丕丗业且上();
        if((this.丂丌专丙丒丗丗丒丆(上东丆丈业世七丈丁:  val_9.transform)) == false)
        {
            goto label_28;
        }
        
        丅丙上七上一丐不下 val_13 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_9.transform);
        if(val_13 == null)
        {
            goto label_28;
        }
        
        val_1.Add(item:  val_13);
        goto label_28;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_22 = null;
        val_22 = null;
        List.Enumerator<T> val_14 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.GetEnumerator();
        label_48:
        if((912677968 & 1) == 0)
        {
            goto label_40;
        }
        
        string val_15 = val_4.丐丏七丌丕丗业且上();
        if((this.丂丌专丙丒丗丗丒丆(上东丆丈业世七丈丁:  val_15.transform)) == false)
        {
            goto label_48;
        }
        
        丅丙上七上一丐不下 val_19 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_15.transform);
        if(val_19 == null)
        {
            goto label_48;
        }
        
        val_1.Add(item:  val_19);
        goto label_48;
        label_40:
        val_23 = 0;
        val_24 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return val_1;
        }
        
            if(254 == 254)
        {
                return val_1;
        }
        
            return val_1;
        }
        
        if( != 0)
        {
                return val_1;
        }
        
        return val_1;
    }
    private bool 丂丌专丙丒丗丗丒丆(UnityEngine.Transform 上东丆丈业世七丈丁)
    {
        UnityEngine.Vector3 val_1 = 上东丆丈业世七丈丁.position;
        UnityEngine.Vector3 val_3 = 上东丆丈业世七丈丁.transform.position;
        return (bool)((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0) ? 1 : 0;
    }
    public 业丆与世丞世丌东丁()
    {
    
    }

}
