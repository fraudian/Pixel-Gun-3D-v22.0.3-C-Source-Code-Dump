using UnityEngine;
private sealed class Player_move_c.丈丕丑万丌专三丝丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 下上万丂丅不丑丒丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private float 丞三丄丑丅丘东丌丗;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丈丕丑万丌专三丝丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        int val_5;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_0;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_1;
        }
        
        val_4 = 0f;
        this.丞三丄丑丅丘东丌丗 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_0:
        val_4 = this.丞三丄丑丅丘东丌丗;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_4 <= 1f)
        {
            goto label_3;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_4;
        }
        
        this.丝且与丝丒丟万丁专.丘丕丄丄丟不丒丙专(丞下万上三丘上与专:  this.丝且与丝丒丟万丁专.丕与丘上万不丂丒七(), 丑丒业丘丑东丕世丅:  false);
        this.丝且与丝丒丟万丁专.丁丌丑东丟不丁丟丆(丙业与丙丗丝不丈东:  0);
        goto label_5;
        label_3:
        float val_2 = UnityEngine.Time.deltaTime;
        val_5 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_5;
        val_2 = val_2 / this.下上万丂丅不丑丒丐;
        val_2 = val_4 + val_2;
        this.丞三丄丑丅丘东丌丗 = val_2;
        return (bool)val_5;
        label_1:
        val_5 = 0;
        return (bool)val_5;
        label_4:
        0.丘丕丄丄丟不丒丙专(丞下万上三丘上与专:  0.丕与丘上万不丂丒七(), 丑丒业丘丑东丕世丅:  false);
        0.丁丌丑东丟不丁丟丆(丙业与丙丗丝不丈东:  0);
        label_5:
        val_5 = 0;
        this.丝且与丝丒丟万丁专.丏丐世丐丗下世丆丕 = 0;
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
