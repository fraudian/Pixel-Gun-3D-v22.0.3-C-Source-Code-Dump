using UnityEngine;
private sealed class CharacterSelectionView.丐下丁与不与丞丘丛 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CharacterSelectionView 丝且与丝丒丟万丁专;
    private System.Threading.Tasks.Task<string> 一丑丂丟丟丞丙一万;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterSelectionView.丐下丁与不与丞丘丛(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_11;
        var val_12;
        int val_13;
        val_11 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_12 = null;
        val_12 = null;
        this.一丑丂丟丟丞丙一万 = EnterNameWindow.下与丞三丅丛丄七丕(丈东丘丏与丌东东下:  MainMenuController.丄丞丁丈与业上丞丟.七万三丈三一丕丙丆().transform).丛三一与丙万七丝不();
        this.丒上七丌业七丟与丐 = CoroutineRunner.Instance.不丕丕丗业丁下东丂(东且丘且丟万丘丛丅:  this.一丑丂丟丟丞丙一万);
        val_13 = 1;
        this.丗丏丅丕丆世丁专丟 = val_13;
        return (bool)val_13;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.一丑丂丟丟丞丙一万.IsCanceled != false)
        {
                val_13 = 0;
            this.丝且与丝丒丟万丁专.丛丟专丆专丁丄丏丘 = 0;
            return (bool)val_13;
        }
        
        丄丆三丕丝不丏与下 val_8 = new 丄丆三丕丝不丏与下();
        val_11 = this.一丑丂丟丟丞丙一万.Result;
        val_8.丟七万上东丗丟丘万(丒丘丏上丙丟丑丕丈:  val_11);
        if(与丂丏丛丞丞丒丟丄.世丑丅丆丒丆不上专() != false)
        {
                val_8.丐丆丆丒丆一丕丟丕();
        }
        
        丑丝丞丒丅丄万丒三.丝丅与丒东世丒丁丕(丌丝丌三一业丑业与:  val_8);
        label_2:
        val_13 = 0;
        return (bool)val_13;
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
