using UnityEngine;
private sealed class BankView.丏丝丛丁丅丒丒与专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public BankView 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BankView.丏丝丛丁丅丒丒与专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.3f);
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        long val_2 = FriendsController.丝丗专上三不丄丑丑();
        if((val_2 >= 1) && (this.丝且与丝丒丟万丁专.下且丏丈上丌东世丆 != true))
        {
                this.丝且与丝丒丟万丁专.下七丘三丏丐七丄专(丙业与丙丗丝不丈东:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40));
            if(this.丝且与丝丒丟万丁专.GetEnabledTab() == 5)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.noOffersIndicator, 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.下且丏丈上丌东世丆 = (val_2 > 0) ? 1 : 0;
        this.丝且与丝丒丟万丁专.上东丆丛丗丁丌丟专();
        val_8 = 1;
        this.丗丏丅丕丆世丁专丟 = val_8;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_8;
        label_2:
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
