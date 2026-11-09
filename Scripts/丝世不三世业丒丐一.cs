using UnityEngine;
private sealed class 丕丝下丁七东丄三丑.丝世不三世业丒丐一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 丕丝下丁七东丄三丑.丝世不三世业丒丐一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        PGCompany.丌不丞丐世丞三丘丌 val_7;
        int val_8;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        丕丝下丁七东丄三丑.上丌专丄丘丂东且丒 val_1 = new 丕丝下丁七东丄三丑.上丌专丄丘丂东且丒();
        .世丘世世丅下七万下 = false;
        MainMenuController.三丟丗七三丛丅丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void 丕丝下丁七东丄三丑.上丌专丄丘丂东且丒::丗世不世丑丈丅七东()));
        val_8 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean 丕丝下丁七东丄三丑.上丌专丄丘丂东且丒::丏丕丞丁丌丙上丒七()));
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.丌不丞丐世丞三丘丌 val_5 = null;
        val_7 = val_5;
        val_5 = new PGCompany.丌不丞丐世丞三丘丌();
        if(val_7 != null)
        {
                .Type = 11;
        }
        else
        {
                mem[16] = 11;
        }
        
        .GameMode = 2;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_5)) == null)
        {
                return (bool)val_8;
        }
        
        label_2:
        val_8 = 0;
        return (bool)val_8;
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
