using UnityEngine;
private sealed class WindowBackgroundAnimation.一丗丕丂丗三丂丞一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.WindowBackgroundAnimation 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WindowBackgroundAnimation.一丗丕丂丗三丂丞一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject[] val_25;
        var val_26;
        var val_27;
        var val_28;
        int val_29;
        UnityEngine.Object val_30;
        int val_31;
        float val_32;
        var val_33;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟 != null)
        {
            goto label_6;
        }
        
        UnityEngine.GameObject val_25 = this.丝且与丝丒丟万丁专.Arrows[0];
        val_25 = new UnityEngine.GameObject[8];
        this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟 = val_25;
        val_26 = 0;
        goto label_7;
        label_21:
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_25);
        val_2.transform.parent = val_25.transform.parent;
        if(this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟 == null)
        {
            goto label_14;
        }
        
        if(val_2 != null)
        {
            goto label_15;
        }
        
        goto label_18;
        label_14:
        if(val_2 == null)
        {
            goto label_18;
        }
        
        label_15:
        label_18:
        this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟[0] = val_2;
        val_25 = this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟;
        val_26 = 1;
        label_7:
        if(val_26 < this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟.Length)
        {
            goto label_21;
        }
        
        label_6:
        val_27 = 0;
        goto label_22;
        label_27:
        this.丝且与丝丒丟万丁专.Arrows[0].SetActive(value:  false);
        val_27 = 1;
        label_22:
        if(val_27 < this.丝且与丝丒丟万丁专.Arrows.Length)
        {
            goto label_27;
        }
        
        val_28 = 0;
        this.丝且与丝丒丟万丁专.世丗上丟丅丂丈丌世 = 0;
        goto label_30;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_29;
        }
        
        val_28 = 0;
        goto label_30;
        label_2:
        val_29 = 0;
        return (bool)val_29;
        label_29:
        val_28 = 1;
        label_30:
        val_30 = this.丝且与丝丒丟万丁专.世丟世丁世丙丄丌丌();
        if(val_30 == 0)
        {
            goto label_38;
        }
        
        val_30 = this.丝且与丝丒丟万丁专.世丟世丁世丙丄丌丌().gameObject;
        if(val_30.activeInHierarchy == false)
        {
            goto label_38;
        }
        
        val_26 = 1152921504838316032;
        val_31 = 0;
        goto label_39;
        label_57:
        UnityEngine.GameObject val_27 = this.丝且与丝丒丟万丁专.ShineNodes[0];
        if((val_27 != 0) && (val_27.activeInHierarchy != false))
        {
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.forward;
            val_32 = val_14.x;
            val_27.transform.Rotate(axis:  new UnityEngine.Vector3() {x = val_32, y = val_14.y, z = val_14.z}, angle:  UnityEngine.Time.deltaTime * 10f, relativeTo:  1);
            if(val_31 != this.丝且与丝丒丟万丁专.世丗上丟丅丂丈丌世)
        {
                this.丝且与丝丒丟万丁专.世丗上丟丅丂丈丌世 = val_31;
            this.丝且与丝丒丟万丁专.丏丄上丒丅丅不业丌(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专.Arrows[0].transform);
        }
        
        }
        
        val_31 = 1;
        label_39:
        if(val_31 < this.丝且与丝丒丟万丁专.ShineNodes.Length)
        {
            goto label_57;
        }
        
        val_28 = 0;
        goto label_58;
        label_72:
        if(this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟[0] != 0)
        {
                UnityEngine.Transform val_19 = this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟[0].transform;
            UnityEngine.Vector3 val_20 = val_19.localPosition;
            float val_31 = val_20.y;
            float val_21 = UnityEngine.Time.deltaTime;
            val_21 = val_21 * 60f;
            val_21 = val_31 + val_21;
            val_20.y = val_21 + (-880f);
            val_31 = (val_21 > 474f) ? (val_20.y) : (val_21);
            if(val_19 != null)
        {
                UnityEngine.Vector3 val_22 = val_19.localPosition;
            val_33 = val_22.x;
        }
        else
        {
                UnityEngine.Vector3 val_23 = 0.localPosition;
            val_33 = val_23.x;
        }
        
            UnityEngine.Vector3 val_24 = val_19.localPosition;
            val_19.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        val_28 = 1;
        label_58:
        val_30 = this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟;
        if(val_28 < this.丝且与丝丒丟万丁专.丅丒东丕丂且专专丟.Length)
        {
            goto label_72;
        }
        
        label_38:
        val_29 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_29;
        return (bool)val_29;
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
