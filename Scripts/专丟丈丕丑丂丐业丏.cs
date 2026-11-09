using UnityEngine;
private sealed class NurseryGuiController.专丟丈丕丑丂丐业丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NurseryGuiController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NurseryGuiController.专丟丈丕丑丂丐业丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        object val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = 0;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = val_6;
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
            goto label_4;
        }
        
        if(this.丝且与丝丒丟万丁专.loadingDataIndication != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.loadingDataIndication, 丏业丟一东丂东丘丛:  false);
        }
        
        this.丝且与丝丒丟万丁专.UpdateIncubators();
        this.丝且与丝丒丟万丁专.fifthEggController.UpdateEgg();
        val_7 = 0;
        val_6 = 2;
        goto label_12;
        label_1:
        val_8 = 0;
        val_9 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_13;
        }
        
        return (bool)val_9;
        label_4:
        val_10 = null;
        if(NurseryGuiController.丛世丛与丌不丈丐丐() != false)
        {
                if(this.丝且与丝丒丟万丁专.loadingDataIndication != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.loadingDataIndication, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        UnityEngine.WaitForSeconds val_5 = null;
        val_7 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_6 = 1;
        label_12:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        label_13:
        val_9 = val_8;
        this.丗丏丅丕丆世丁专丟 = val_6;
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
