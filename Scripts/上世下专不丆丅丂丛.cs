using UnityEngine;
private sealed class ProfileView.上世下专不丆丅丂丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ProfileView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProfileView.上世下专不丆丅丂丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UIButton val_8;
        int val_9;
        val_8 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_16;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.丝且与丝丒丟万丁专.copyIdButton)) == false)
        {
            goto label_9;
        }
        
        this.丝且与丝丒丟万丁专.copyIdButton.gameObject.SetActive(value:  false);
        goto label_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_19;
        }
        
        label_9:
        label_19:
        if((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                val_9 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  1f);
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.copyIdButton;
        if((UnityEngine.Object.op_Implicit(exists:  val_8)) != false)
        {
                val_8 = this.丝且与丝丒丟万丁专.copyIdButton.gameObject;
            val_8.SetActive(value:  true);
        }
        
        label_16:
        val_9 = 0;
        return (bool)val_9;
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
