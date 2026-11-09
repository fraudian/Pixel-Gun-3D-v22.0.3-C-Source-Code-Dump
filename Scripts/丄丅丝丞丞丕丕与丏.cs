using UnityEngine;
private sealed class TournamentController.丄丅丝丞丞丕丕与丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TournamentController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TournamentController.丄丅丝丞丞丕丕与丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        int val_8;
        var val_9;
        if((this.丗丏丅丕丆世丁专丟 - 2) < 2)
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
        
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丌丘丕丟丄丙丛丕丄 == 3)
        {
                if(this.丝且与丝丒丟万丁专.丂与丐下一丟丆丌与() <= 0)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 0;
        val_8 = 3;
        goto label_9;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专.东丙丗万下丌不下丏();
        UnityEngine.WaitForSeconds val_4 = null;
        float val_7 = (float)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  20);
        val_7 = val_7 + 20f;
        val_7 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  val_7);
        val_8 = 2;
        goto label_9;
        label_3:
        val_9 = 0;
        return (bool)val_9;
        label_6:
        UnityEngine.WaitForSeconds val_6 = null;
        float val_8 = (float)Rilisoft.与丄丁丄丙丞下下丙.一丄丑丛丕丟万三丞(丗丙丆世丆丕万下丒:  10);
        val_8 = val_8 + 10f;
        val_7 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  val_8);
        val_8 = 1;
        label_9:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_8;
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
