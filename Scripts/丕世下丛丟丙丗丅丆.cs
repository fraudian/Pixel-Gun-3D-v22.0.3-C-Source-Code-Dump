using UnityEngine;
private sealed class HelicopterController.丕世下丛丟丙丗丅丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public HelicopterController 丝且与丝丒丟万丁专;
    public string 丂东丄丏丕丕丅上一;
    private UnityEngine.ResourceRequest 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HelicopterController.丕世下丛丟丙丗丅丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        HelicopterController val_18;
        string val_19;
        int val_20;
        float val_21;
        float val_22;
        var val_23;
        val_18 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_19 = this.丂东丄丏丕丕丅上一;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_18 == null)
        {
            goto label_3;
        }
        
        mem2[0] = val_19;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅丒丑丄丞丑下丈丕.isDone == false)
        {
            goto label_6;
        }
        
        UnityEngine.Object val_2 = this.丅丒丑丄丞丑下丈丕.asset;
        if(val_2 != 0)
        {
            goto label_10;
        }
        
        label_6:
        object[] val_4 = new object[1];
        val_4[0] = val_2;
        UnityEngine.Debug.LogErrorFormat(format:  "Can\'t load vehicle: {0}", args:  val_4);
        goto label_18;
        label_2:
        val_20 = 0;
        return (bool)val_20;
        label_3:
        val_18 = 144;
        mem[144] = val_19;
        val_19 = mem[144];
        label_4:
        UnityEngine.ResourceRequest val_6 = UnityEngine.Resources.LoadAsync(path:  "VehicleBattleRoyale/Helicopter_prefabs/Views/"("VehicleBattleRoyale/Helicopter_prefabs/Views/") + val_19);
        this.丅丒丑丄丞丑下丈丕 = val_6;
        this.丒上七丌业七丟与丐 = val_6;
        val_20 = 1;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_10:
        if(this.丝且与丝丒丟万丁专.view != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专.view.gameObject);
        }
        
        val_19 = this.丝且与丝丒丟万丁专.engine.body;
        UnityEngine.Object val_10 = UnityEngine.Object.Instantiate(original:  this.丅丒丑丄丞丑下丈丕.asset, parent:  val_19);
        if(val_10 != null)
        {
                val_19 = 1152921504834002944;
            var val_11 = (null == null) ? (val_10) : 0;
        }
        
        HelicopterView val_12 = 0.GetComponent<HelicopterView>();
        this.丝且与丝丒丟万丁专.view = val_12;
        val_12.丅丙丙丘万上丟丝丌(丙业与丙丗丝不丈东:  val_18);
        UnityEngine.Transform val_13 = this.丝且与丝丒丟万丁专.view.丌丟丄业且三丛丕丄();
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        val_13.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
        val_21 = val_15.x;
        val_22 = val_15.z;
        val_13.localRotation = new UnityEngine.Quaternion() {x = val_21, y = val_15.y, z = val_22, w = val_15.w};
        val_23 = 0;
        val_18.世丆丅丗丗不丙世下();
        label_18:
        val_20 = 0;
        mem2[0] = 0;
        return (bool)val_20;
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
