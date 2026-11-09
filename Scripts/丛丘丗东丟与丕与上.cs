using UnityEngine;
private sealed class HelicopterView.丛丘丗东丟与丕与上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public HelicopterView 丝且与丝丒丟万丁专;
    private float 丅丁丕丏上丐东丕丆;
    private UnityEngine.Transform 丐不且专丆一丌七不;
    private UnityEngine.Vector3 丗上丛丒东世且丟丝;
    private UnityEngine.Vector3 丌不七丗丑不丈与丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HelicopterView.丛丘丗东丟与丕与上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        HelicopterDeadView val_11;
        var val_12;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        float val_17;
        int val_18;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_11 = this.丝且与丝丒丟万丁专.<三三三丅万业丆丕丅>k__BackingField.deadView;
        val_12 = 0;
        goto label_5;
        label_11:
        this.丝且与丝丒丟万丁专.<三三三丅万业丆丕丅>k__BackingField.deadView.renderers[0].sharedMaterial = this.丝且与丝丒丟万丁专;
        val_12 = 1;
        label_5:
        if(val_12 < (this.丝且与丝丒丟万丁专.<三三三丅万业丆丕丅>k__BackingField.deadView.renderers.Length))
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_11.gameObject, 丏业丟一东丂东丘丛:  true);
        val_13 = 0;
        goto label_14;
        label_21:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.renderers[0].gameObject, 丏业丟一东丂东丘丛:  false);
        val_13 = 1;
        label_14:
        if(val_13 < this.丝且与丝丒丟万丁专.renderers.Length)
        {
            goto label_21;
        }
        
        val_14 = this;
        this.丅丁丕丏上丐东丕丆 = 0f;
        UnityEngine.Transform val_3 = val_11.丌丟丄业且三丛丕丄();
        this.丐不且专丆一丌七不 = val_3;
        UnityEngine.Vector3 val_4 = val_3.localPosition;
        this.丗上丛丒东世且丟丝 = val_4;
        mem[1152921539396701180] = val_4.y;
        mem[1152921539396701184] = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
        val_15 = val_5.x;
        val_16 = val_5.z;
        UnityEngine.Vector3 val_6 = this.丐不且专丆一丌七不.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_15, y = val_5.y, z = val_16});
        this.丌不七丗丑不丈与丙 = val_6;
        mem[1152921539396701192] = val_6.y;
        mem[1152921539396701196] = val_6.z;
        goto label_27;
        label_1:
        val_14 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_7 = UnityEngine.Time.deltaTime;
        val_11 = this.丐不且专丆一丌七不;
        val_7 = val_7 * 1.3f;
        val_17 = this.丅丁丕丏上丐东丕丆 + val_7;
        this.丅丁丕丏上丐东丕丆 = val_17;
        if(this.丝且与丝丒丟万丁专 == null)
        {
                val_17 = this.丅丁丕丏上丐东丕丆;
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.丌不七丗丑不丈与丙, y = mem[1152921539396701192], z = mem[1152921539396701196]}, d:  this.丝且与丝丒丟万丁专.Evaluate(time:  val_17));
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丗上丛丒东世且丟丝, y = mem[1152921539396701180], z = mem[1152921539396701184]}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        val_15 = val_10.x;
        val_16 = val_10.z;
        val_11.localPosition = new UnityEngine.Vector3() {x = val_15, y = val_10.y, z = val_16};
        label_27:
        if(this.丅丁丕丏上丐东丕丆 < 0)
        {
            goto label_33;
        }
        
        label_2:
        val_18 = 0;
        return (bool)val_18;
        label_33:
        val_18 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_18;
        return (bool)val_18;
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
