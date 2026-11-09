using UnityEngine;
private sealed class EggsManager.七丐下丌丄一东丝丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.EggsManager 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 丞三丑丏丕三业丘万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EggsManager.七丐下丌丄一东丝丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSecondsRealtime val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitForSecondsRealtime val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
        this.丞三丑丏丕三业丘万 = val_8;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
            goto label_24;
        }
        
        val_8 = Progress.七七世万专丕丁上业.三上上七丂丛丘且丑().丐丙丛丏专世丛不丄();
        List.Enumerator<T> val_5 = val_8.GetEnumerator();
        label_17:
        if(((-695918968) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_6 = 0.丐丏七丌丕丗业且上();
        if((0 != 0) || ((this.丝且与丝丒丟万丁专.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_6)) == false))
        {
            goto label_17;
        }
        
        0.世丄丟三丟丅丒丄丏(上丕丈丞丌丘丅不与:  val_6);
        goto label_17;
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_24:
        val_9 = 1;
        this.丗丏丅丕丆世丁专丟 = val_9;
        this.丒上七丌业七丟与丐 = this.丞三丑丏丕三业丘万;
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
