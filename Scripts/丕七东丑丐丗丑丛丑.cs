using UnityEngine;
private sealed class ChestBatleRoyale.丕七东丑丐丗丑丛丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ChestBatleRoyale 丝且与丝丒丟万丁专;
    private UnityEngine.ResourceRequest 不且丐丝丞七专下东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ChestBatleRoyale.丕七东丑丐丗丑丛丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        var val_7;
        UnityEngine.ResourceRequest val_8;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_0;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  this.丝且与丝丒丟万丁专.weaponBonusName)) == false)
        {
            goto label_2;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_0:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_13;
        }
        
        val_7 = this;
        val_8 = this.不且丐丝丞七专下东;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        val_8 = 0;
        goto label_6;
        label_2:
        string val_2 = this.丝且与丝丒丟万丁专.丘不丗丁丛丘东丛一();
        if((System.String.IsNullOrEmpty(value:  val_2)) == true)
        {
            goto label_13;
        }
        
        UnityEngine.ResourceRequest val_4 = UnityEngine.Resources.LoadAsync(path:  val_2);
        val_7 = this;
        this.不且丐丝丞七专下东 = val_4;
        if(val_4 == null)
        {
                return (bool)val_6;
        }
        
        label_6:
        if(val_4.isDone == false)
        {
            goto label_9;
        }
        
        if(this.丝且与丝丒丟万丁专.万丁丕七丞丞丂与丟 == 2)
        {
            goto label_11;
        }
        
        if(this.丝且与丝丒丟万丁专.万丁丕七丞丞丂与丟 != 1)
        {
            goto label_13;
        }
        
        this.丝且与丝丒丟万丁专.上丂业丟七丕丂丒东(与上丏下万丛世丑且:  this.不且丐丝丞七专下东);
        goto label_13;
        label_9:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_6 = 1;
        return (bool)val_6;
        label_11:
        this.丝且与丝丒丟万丁专.三丗丏业丞丛丑下与(与上丏下万丛世丑且:  this.不且丐丝丞七专下东);
        label_13:
        val_6 = 0;
        return (bool)val_6;
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
