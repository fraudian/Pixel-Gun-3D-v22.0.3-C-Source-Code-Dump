using UnityEngine;
private sealed class WeaponSwipeController.与一丏世丐丅丂丂丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponSwipeController 丝且与丝丒丟万丁专;
    public float 七且丆丞丌丘下世丑;
    private int 丙且丑上丑三丌三东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponSwipeController.与一丏世丐丅丂丂丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        MyCenterOnChild val_23;
        int val_24;
        bool val_25;
        var val_28;
        val_23 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_61;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丑七丅丄与丅上丄丂 == 0)
        {
            goto label_61;
        }
        
        val_24 = this.丙且丑上丑三丌三东;
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  this.丝且与丝丒丟万丁专.丑七丅丄与丅上丄丂.centeredObject.name.Replace(oldValue:  "preview_", newValue:  System.String.alignConst), 丙业与丙丗丝不丈东: out  val_24)) == false)
        {
            goto label_61;
        }
        
        val_25 = true;
        this.丝且与丝丒丟万丁专.丐东丄专万业丄丈丞 = val_25;
        UnityEngine.WaitForSeconds val_7 = null;
        val_24 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  this.七且丆丞丌丘下世丑);
        this.丒上七丌业七丟与丐 = val_24;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                this.丝且与丝丒丟万丁专.丐东丄专万业丄丈丞 = false;
        }
        else
        {
                mem[56] = 0;
        }
        
        val_24 = "preview_" + this.丙且丑上丑三丌三东;
        if((this.丝且与丝丒丟万丁专.丑七丅丄与丅上丄丂.centeredObject.name.Equals(value:  val_24)) == true)
        {
            goto label_61;
        }
        
        System.Collections.IEnumerator val_13 = this.丝且与丝丒丟万丁专.丑七丅丄与丅上丄丂.transform.GetEnumerator();
        label_38:
        var val_25 = 0;
        val_25 = val_25 + 1;
        if(val_13.MoveNext() == false)
        {
            goto label_27;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_24 = val_13.Current;
        val_24 = 0;
        if((val_24.gameObject.name.Equals(value:  "preview_" + this.丙且丑上丑三丌三东)) == false)
        {
            goto label_38;
        }
        
        val_28 = 0;
        val_23 = 0;
        goto label_40;
        label_27:
        val_28 = 0;
        val_23 = 0;
        val_24 = 0;
        label_40:
        if(val_13 != null)
        {
                var val_27 = 0;
            val_27 = val_27 + 1;
            val_13.Dispose();
        }
        
        if( == 1)
        {
            goto label_56;
        }
        
        if(( == false) || (294 == 294))
        {
            goto label_65;
        }
        
        label_64:
        label_65:
        if( != 0)
        {
                val_23 = this.丝且与丝丒丟万丁专.丑七丅丄与丅上丄丂;
            val_23.CenterOn(丞下万上三丘上与专:  null);
        }
        
        label_61:
        val_25 = 0;
        return (bool)val_25;
        label_56:
        if( == true)
        {
            goto label_64;
        }
        
        goto label_65;
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
