using UnityEngine;
private sealed class InGameGUI.丈三下丅丘丁丏与丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UITexture 与丄丈丘丟丕丏丐丁;
    public float 丏上万丅丏一不不丕;
    public InGameGUI 丝且与丝丒丟万丁专;
    public System.Action 丟丘丙丄丅万丏与丗;
    private float 丐丑丑丘不丙丏不一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InGameGUI.丈三下丅丘丁丏与丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UITexture val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_8;
        }
        
        val_8 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        this.与丄丈丘丟丕丏丐丁.fillAmount = 0f;
        if(this.与丄丈丘丟丕丏丐丁 == 0)
        {
            goto label_8;
        }
        
        float val_8 = this.丏上万丅丏一不不丕;
        if(val_8 == 0f)
        {
            goto label_8;
        }
        
        val_8 = 1f / val_8;
        this.丐丑丑丘不丙丏不一 = val_8;
        goto label_9;
        label_8:
        val_9 = 0;
        return (bool)val_9;
        label_1:
        val_8 = this.与丄丈丘丟丕丏丐丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        if(mem[this.与丄丈丘丟丕丏丐丁].fillAmount < 0)
        {
            goto label_12;
        }
        
        mem[this.与丄丈丘丟丕丏丐丁].fillAmount = 0f;
        if(this.丟丘丙丄丅万丏与丗 != null)
        {
                this.丟丘丙丄丅万丏与丗.Invoke();
        }
        
        label_25:
        val_9 = 0;
        this.丝且与丝丒丟万丁专.一与丛丑下不丘七丘 = 0;
        return (bool)val_9;
        label_12:
        mem[this.与丄丈丘丟丕丏丐丁].fillAmount = UnityEngine.Mathf.MoveTowards(current:  mem[this.与丄丈丘丟丕丏丐丁].fillAmount, target:  1f, maxDelta:  UnityEngine.Time.deltaTime * this.丐丑丑丘不丙丏不一);
        if(mem[this.与丄丈丘丟丕丏丐丁].enabled != false)
        {
                val_9 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
        mem[this.与丄丈丘丟丕丏丐丁].fillAmount = 0f;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_25;
        }
        
        goto label_25;
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
