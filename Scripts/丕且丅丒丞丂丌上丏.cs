using UnityEngine;
private sealed class InfoWindowController.丕且丅丒丞丂丌上丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public InfoWindowController.不丌丅丗丁丟丅丐一 丛丄丌三丁丝丈且七;
    public InfoWindowController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public InfoWindowController.丕且丅丒丞丂丌上丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        InfoWindowController val_3;
        int val_4;
        var val_5;
        var val_6;
        if(this.丗丏丅丕丆世丁专丟 < 2)
        {
                val_3 = this.丝且与丝丒丟万丁专;
            this.丗丏丅丕丆世丁专丟 = 0;
            if((this.丛丄丌三丁丝丈且七.<丄业与丅丌丙丆丈上>k__BackingField.isOpened) != false)
        {
                val_4 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_4;
            return (bool)val_4;
        }
        
            this.丛丄丌三丁丝丈且七.<下丏专丌世丅东上丁>k__BackingField = false;
            val_5 = null;
            val_5 = null;
            if(InfoWindowController.东万下丅下东七一万.Count >= 1)
        {
                val_6 = null;
            val_6 = null;
            不丌丅丗丁丟丅丐一 val_2 = InfoWindowController.东万下丅下东七一万.Dequeue();
        }
        
            val_3.丁上东丟丅丅一丆三();
        }
        
        val_4 = 0;
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
