using UnityEngine;
private sealed class CrateOpenWindowController.东且丙丞丝世丘丂丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public CrateOpenWindowController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CrateOpenWindowController.东且丙丞丝世丘丂丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        bool val_3;
        val_2 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_2;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            val_3 = true;
            this.丝且与丝丒丟万丁专.丒上丏丏丅丕丗丛丞 = val_3;
            val_2 = 1;
            this.丒上七丌业七丟与丐 = new 不丆三丕与与丂丐一(丆丐七丅丆丗丛上与:  1f);
        }
        else
        {
                val_3 = 0;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_2;
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
