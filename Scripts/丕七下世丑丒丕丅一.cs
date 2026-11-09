using UnityEngine;
private sealed class FortEquipmentController.丕七下世丑丒丕丅一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public System.Collections.Generic.List<string> 丑七不与丛丆一丂丞;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FortEquipmentController.丕七下世丑丒丕丅一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Object[] val_5;
        System.Collections.Generic.List<System.String> val_6;
        int val_7;
        int val_8;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        val_6 = this.丑七不与丛丆一丂丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_7 = 0;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.一丟专且三万丞丁丂.与丐丗丟专丘七丑丁(丂丐丄丁丆与丈丂上:  "Fort Item Popularity", 下下丏一丙不丘丌丞:  this.丑七不与丛丆一丂丞.Item[this.丙不丅丌丗上丂丕一]);
        val_6 = this.丑七不与丛丆一丂丞;
        val_7 = this.丙不丅丌丗上丂丕一 + 1;
        this.丙不丅丌丗上丂丕一 = val_7;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        label_8:
        if(val_7 >= val_6.Count)
        {
            goto label_9;
        }
        
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_3:
        val_5 = System.Array.Empty<System.Object>();
        UnityEngine.Debug.LogErrorFormat(format:  "SendFortItemsPopularityAnalytics items == null", args:  val_5);
        label_9:
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
