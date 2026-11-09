using UnityEngine;
private sealed class ProgressRoadView.丝丒丂丂丅丄专丟丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ProgressRoadView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProgressRoadView.丝丒丂丂丅丄专丟丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ProgressRoadView val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_9;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = this.丝且与丝丒丟万丁专;
        if((ShopNGUIController.丛世丛与丌不丈丐丐() == true) || (ProgressRoadView.丘丄丆不丛丗上三上 == false))
        {
            goto label_6;
        }
        
        if(val_3 != 0)
        {
                val_3.一东上丂丟丙与七一();
        }
        
        label_9:
        val_4 = 0;
        return (bool)val_4;
        label_6:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
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
