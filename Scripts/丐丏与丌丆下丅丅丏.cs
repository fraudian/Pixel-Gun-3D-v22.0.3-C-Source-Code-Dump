using UnityEngine;
private sealed class GameEventPlayerGot.丐丏与丌丆下丅丅丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GameEventPlayerGot 丝且与丝丒丟万丁专;
    private TweenScale 丈世世丏世丁不丐七;
    private UnityEngine.WaitForSeconds 业一下丝丗丌与丙丘;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventPlayerGot.丐丏与丌丆下丅丅丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.GameObject val_3;
        int val_4;
        UnityEngine.WaitForSeconds val_5;
        val_3 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.与三不丁丈东三七丙 = true;
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丝且与丝丒丟万丁专.container;
        val_3.SetActive(value:  false);
        val_4 = 0;
        this.丝且与丝丒丟万丁专.与三不丁丈东三七丙 = false;
        return (bool)val_4;
        label_2:
        int val_3 = this.丟丗丒丟丝丘丞丝丏;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = val_3 + 1;
        this.丟丗丒丟丝丘丞丝丏 = val_3;
        if(val_3 < 6)
        {
            goto label_9;
        }
        
        this.丈世世丏世丁不丐七.PlayReverse();
        val_5 = this.业一下丝丗丌与丙丘;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_4 = 1;
        goto label_11;
        label_3:
        val_4 = 0;
        return (bool)val_4;
        label_4:
        mem[88] = 1;
        label_5:
        this.丝且与丝丒丟万丁专.container.SetActive(value:  true);
        TweenScale val_1 = this.丝且与丝丒丟万丁专.container.GetComponent<TweenScale>();
        this.丈世世丏世丁不丐七 = val_1;
        val_1.PlayForward();
        this.业一下丝丗丌与丙丘 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        this.丟丗丒丟丝丘丞丝丏 = 0;
        label_9:
        val_5 = this.业一下丝丗丌与丙丘;
        val_4 = 1;
        this.丗丏丅丕丆世丁专丟 = val_4;
        label_11:
        this.丒上七丌业七丟与丐 = val_5;
        return (bool)val_4;
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
