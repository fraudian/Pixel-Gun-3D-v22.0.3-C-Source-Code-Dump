using UnityEngine;
private sealed class VIPRecommendationView.丕且丕不丛丙丁且丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.VIPRecommendationView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丞三丑丏丕三业丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VIPRecommendationView.丕且丕不丛丙丁且丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        UnityEngine.WaitForSecondsRealtime val_7;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丞三丑丏丕三业丘万 = 0;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        label_8:
        if(this.丝且与丝丒丟万丁专 == 0)
        {
            goto label_6;
        }
        
        if(this.丝且与丝丒丟万丁专.isActiveAndEnabled == false)
        {
            goto label_8;
        }
        
        int val_4 = Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        this.丝且与丝丒丟万丁专.与丕丞一丐七专丗下(丂三丟丂丈丐丆丗丟:  val_4);
        goto label_11;
        label_6:
        val_6 = 0;
        return (bool)val_6;
        label_10:
        0.与丕丞一丐七专丗下(丂三丟丂丈丐丆丗丟:  val_4);
        label_11:
        this.丝且与丝丒丟万丁专.丈下且丅丞下丙七丘();
        val_7 = this.丞三丑丏丕三业丘万;
        if(val_7 == null)
        {
                UnityEngine.WaitForSecondsRealtime val_5 = null;
            val_7 = val_5;
            val_5 = new UnityEngine.WaitForSecondsRealtime(time:  0.2f);
            this.丞三丑丏丕三业丘万 = val_7;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_6;
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
