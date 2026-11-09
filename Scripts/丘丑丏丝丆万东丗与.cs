using UnityEngine;
private sealed class 丕丝下丁七东丄三丑.丘丑丏丝丆万东丗与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Action 七丐丅专且专七三丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丕丝下丁七东丄三丑.丘丑丏丝丆万东丗与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丕丝下丁七东丄三丑.世丞丒丅一专丌丐丏 val_1 = new 丕丝下丁七东丄三丑.世丞丒丅一专丌丐丏();
        .世丘世世丅下七万下 = false;
        MainMenuController.三丟丗七三丛丅丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void 丕丝下丁七东丄三丑.世丞丒丅一专丌丐丏::与丑下丗丏三丙业丌()));
        val_5 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean 丕丝下丁七东丄三丑.世丞丒丅一专丌丐丏::丌丕业七丑丗丗不三()));
        this.丗丏丅丕丆世丁专丟 = val_5;
        return (bool)val_5;
        label_1:
        val_5 = this.七丐丅专且专七三丆;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_5 == null)
        {
                return (bool)val_5;
        }
        
        val_5.Invoke();
        label_2:
        val_5 = 0;
        return (bool)val_5;
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
