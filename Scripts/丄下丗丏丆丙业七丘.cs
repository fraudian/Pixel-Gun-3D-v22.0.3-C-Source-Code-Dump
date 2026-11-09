using UnityEngine;
private sealed class DirectionPointer.丄下丗丏丆丙业七丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.DirectionPointer 丝且与丝丒丟万丁专;
    private float 丗丌与丌与丙东与且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DirectionPointer.丄下丗丏丆丙业七丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_13;
        var val_14;
        float val_15;
        Rilisoft.DirectionViewerTarget val_16;
        int val_17;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_14 = val_13;
        this.丗丌与丌与丙东与且 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = 0f;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        val_14 = val_13;
        val_15 = this.丗丌与丌与丙东与且;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(val_15 <= this.丝且与丝丒丟万丁专._hideTime)
        {
                val_16 = this.丝且与丝丒丟万丁专.<专东三丅业丄丈七丈>k__BackingField;
            if(val_16 == 0)
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.丗丌与丌与丙东与且 + val_2;
            this.丗丌与丌与丙东与且 = val_2;
            val_16 = this.丝且与丝丒丟万丁专.与丂业丈丘丐丅丄业();
            float val_5 = UnityEngine.Mathf.Lerp(a:  1f, b:  0.1f, t:  this.丗丌与丌与丙东与且 / this.丝且与丝丒丟万丁专._hideTime);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  UnityEngine.Mathf.Lerp(a:  1f, b:  2f, t:  this.丗丌与丌与丙东与且 / this.丝且与丝丒丟万丁专._hideTime));
            val_15 = val_11.x;
            this.丝且与丝丒丟万丁专.与丂业丈丘丐丅丄业().transform.localScale = new UnityEngine.Vector3() {x = val_15, y = val_11.y, z = val_11.z};
            val_17 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_17;
            return (bool)val_17;
        }
        
        }
        
        val_13 = this.丝且与丝丒丟万丁专.gameObject;
        val_13.SetActive(value:  false);
        label_2:
        val_17 = 0;
        return (bool)val_17;
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
