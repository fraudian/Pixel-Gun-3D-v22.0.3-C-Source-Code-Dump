using UnityEngine;
private sealed class SatelliteController.丅丅不丑丂上丟丌万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SatelliteController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SatelliteController.丅丅不丑丂上丟丌万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_15;
        int val_16;
        float val_17;
        float val_18;
        val_15 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_16 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.rayFromTower.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = X22.position;
        val_17 = val_2.z;
        this.丝且与丝丒丟万丁专.rayToTarget.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_17};
        val_16 = 1;
        this.丝且与丝丒丟万丁专.rayToTarget.SetActive(value:  true);
        val_18 = this.丝且与丝丒丟万丁专.delayBeetwinRayToTargetAndExplosion;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_18);
        this.丗丏丅丕丆世丁专丟 = val_16;
        return (bool)val_16;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = this.丝且与丝丒丟万丁专.explosionSatellite;
        val_15.SetActive(value:  false);
        val_16 = 0;
        return (bool)val_16;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.rayFromTower.SetActive(value:  false);
        UnityEngine.Transform val_5 = this.丝且与丝丒丟万丁专.rayToTarget.transform;
        UnityEngine.Vector3 val_6 = val_5.position;
        val_17 = val_6.z;
        this.丝且与丝丒丟万丁专.explosionSatellite.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_17};
        this.丝且与丝丒丟万丁专.rayToTarget.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.explosionSatellite.SetActive(value:  true);
        丅丙上七上一丐不下 val_7 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专.explosionSatellite);
        if((val_7 != null) && ((this.丝且与丝丒丟万丁专.丗丝丒丈与三丁东丟(丂丈丙且丈丗三丆丕:  val_7)) != false))
        {
                UnityEngine.Vector3 val_9 = val_5.position;
            val_17 = val_9.z;
            UnityEngine.Vector3 val_11 = this.丝且与丝丒丟万丁专.explosionSatellite.transform.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_17}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            float val_15 = this.丝且与丝丒丟万丁专.radiusExplosion;
            val_15 = val_15 * val_15;
            if(val_12.x < 0)
        {
                bool val_13 = this.丝且与丝丒丟万丁专.三且丆丙丂丘丗丕丙(丂丈丙且丈丗三丆丕:  val_7);
        }
        
        }
        
        val_18 = this.丝且与丝丒丟万丁专.delayExplosion;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_18);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_16 = 1;
        return (bool)val_16;
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
