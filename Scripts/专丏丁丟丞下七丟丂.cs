using UnityEngine;
private sealed class SkinName.专丏丁丟丞下七丟丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SkinName 丝且与丝丒丟万丁专;
    public string 丈丐丕业下丟业丛一;
    public UnityEngine.Texture 下万东丕丏丟丟丝丗;
    private 丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 丅丒丑丄丞丑下丈丕;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkinName.专丏丁丟丞下七丟丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Texture val_14;
        var val_15;
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_16;
        string val_17;
        UnityEngine.Object val_18;
        int val_19;
        val_14 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = null;
        val_15 = null;
        if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 == true)
        {
            goto label_5;
        }
        
        val_16 = 丌丆丒七丑丞东三丛.丐下下丅与上东丙丑(丛丄业丕且丗下一万:  "Capes/"("Capes/") + this.丈丐丕业下丟业丛一, 不丌丞专丈丙丛东丏:  false);
        val_17 = val_14;
        this.丅丒丑丄丞丑下丈丕 = val_16;
        if(val_16 != null)
        {
            goto label_10;
        }
        
        goto label_9;
        label_1:
        val_17 = val_14;
        val_16 = this.丅丒丑丄丞丑下丈丕;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_16 != null)
        {
            goto label_10;
        }
        
        label_9:
        label_10:
        if(val_16.下丑万三且丟丒丌丕() == false)
        {
            goto label_11;
        }
        
        丌丆丒七丑丞东三丛.东丕与不丟丈与丄丟 val_14 = this.丅丒丑丄丞丑下丈丕;
        UnityEngine.Object val_4 = val_14.丂丑且与丐七丟丝下();
        if(val_4 == null)
        {
            goto label_13;
        }
        
        val_14 = (null == null) ? (val_4) : 0;
        goto label_14;
        label_2:
        val_19 = 0;
        return (bool)val_19;
        label_11:
        val_19 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
        label_13:
        val_18 = 0;
        label_14:
        val_17 = 1152921504848912384;
        if(val_18 != 0)
        {
            goto label_19;
        }
        
        label_5:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_35;
        }
        
        goto label_35;
        label_19:
        UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_18);
        UnityEngine.Transform val_7 = val_6.transform;
        val_7.parent = this.丝且与丝丒丟万丁专.capesPoint.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_7.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
        val_7.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
        val_17 = this.丈丐丕业下丟业丛一;
        if((val_17.Equals(value:  "cape_Custom")) != false)
        {
                CustomCapePicker val_12 = val_6.GetComponent<CustomCapePicker>();
            val_12.shouldLoadTexture = false;
            val_14 = this.下万东丕丏丟丟丝丗;
            UnityEngine.GameObject[] val_13 = new UnityEngine.GameObject[0];
            val_17 = val_13;
            Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_6, 丐丅丁丂丐下丘世丄:  val_14, 丕丂丝丗丈三与东专:  val_13);
        }
        
        label_35:
        val_19 = 0;
        this.丝且与丝丒丟万丁专.丙三与丏七一丘专丒 = 0;
        return (bool)val_19;
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
