using UnityEngine;
private sealed class CraftNewItemWindowController.下丟丌与下三丂万世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CraftNewItemWindowController.下丟丌与下三丂万世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        int val_3;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_2 = this.丕丕世且下一与丝与;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_2 <= 0f)
        {
                val_2 = 0.5f;
            this.丕丕世且下一与丝与 = 0.5f;
        }
        
        val_3 = 1;
        this.丒上七丌业七丟与丐 = new 不丆三丕与与丂丐一(丆丐七丅丆丗丛上与:  val_2);
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        ArmoryInfoScreenController.丌世丒万丈丒且丙一();
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
