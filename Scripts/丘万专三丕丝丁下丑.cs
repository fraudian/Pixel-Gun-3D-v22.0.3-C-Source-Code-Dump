using UnityEngine;
private sealed class MainMenuController.丘万专三丕丝丁下丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    public System.Threading.CancellationToken 三七丈丟一丐世与丈;
    public UnityEngine.GameObject 丑上一丁丐一丞丅丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丘万专三丕丝丁下丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_5;
        int val_6;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_14;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.丏丅与七丞丐丒与丌 = false;
        val_6 = 0;
        if((this.三七丈丟一丐世与丈 & 1) != 0)
        {
                return (bool)val_6;
        }
        
        if(this.丑上一丁丐一丞丅丂 != 0)
        {
                this.丑上一丁丐一丞丅丂.SetActive(value:  false);
        }
        
        this.丝且与丝丒丟万丁专.rotateCamera.gameObject.SetActive(value:  false);
        val_5 = this.丝且与丝丒丟万丁专.mainPanel;
        if(val_5 != 0)
        {
                val_5 = this.丝且与丝丒丟万丁专.mainPanel.gameObject;
            val_5.SetActive(value:  false);
        }
        
        label_14:
        val_6 = 0;
        return (bool)val_6;
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
