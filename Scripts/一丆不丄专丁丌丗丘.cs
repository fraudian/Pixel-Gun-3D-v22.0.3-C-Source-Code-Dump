using UnityEngine;
internal class 一丆不丄专丁丌丗丘 : BaseTriggerAlternativeAttack
{
    // Methods
    internal override void 上专丄丑专丑丘业丌()
    {
        var val_3;
        var val_13;
        var val_14;
        float val_15;
        var val_16;
        float val_17;
        val_13 = null;
        val_13 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_14 = 0;
        goto label_13;
        label_14:
        UnityEngine.Transform val_5 = val_3.丐丏七丌丕丗业且上().transform;
        UnityEngine.Vector3 val_6 = val_5.position;
        UnityEngine.Vector3 val_9 = val_5.七与世丄丞丒一七三().transform.position;
        val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        if(val_15 < 0)
        {
                val_14 = 1;
        }
        
        label_13:
        if((919671456 & 1) != 0)
        {
            goto label_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_14 < (val_3 + 20))
        {
                val_16 = this;
            mem[1152921539886268976] = val_3 + 32;
            val_17 = val_3 + 32;
        }
        else
        {
                val_16 = this;
            val_17 = val_15 - UnityEngine.Time.deltaTime;
            mem[1152921539886268976] = val_17;
        }
        
        if(val_17 > 0f)
        {
                return;
        }
        
        if(val_3.与上丂丗万上丄丙丅() == true)
        {
                return;
        }
        
        mem[1152921539886268976] = val_3 + 32;
        this.丕丙丂丆丒与与东丑();
    }
    public 一丆不丄专丁丌丗丘()
    {
    
    }

}
