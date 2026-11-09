using UnityEngine;
private sealed class LoadingTipsView.丂丁丏丕丏丂丕丞丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LoadingTipsView 丝且与丝丒丟万丁专;
    public string 下上丐丆丝丟丝丒不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingTipsView.丂丁丏丕丏丂丕丞丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UILabel val_3;
        var val_4;
        var val_5;
        string val_6;
        int val_7;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.TipText.text = System.String.alignConst;
        val_4 = val_3;
        val_5 = 1152921505072021504;
        val_6 = this.下上丐丆丝丟丝丒不;
        goto label_5;
        label_1:
        val_4 = val_3;
        val_6 = this.下上丐丆丝丟丝丒不;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 1152921505072021504;
        label_5:
        string val_1 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
        if((val_6.Equals(value:  val_1)) != false)
        {
                val_7 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_7;
            return (bool)val_7;
        }
        
        val_3 = this.丝且与丝丒丟万丁专.TipText;
        val_3.text = val_1;
        label_2:
        val_7 = 0;
        return (bool)val_7;
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
