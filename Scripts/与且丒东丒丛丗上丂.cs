using UnityEngine;
private sealed class BankController.与且丒东丒丛丗上丂 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public string 丏丂不专上丘丂不丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BankController.与且丒东丒丛丗上丂(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_13;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = null;
        val_3 = null;
        if(BankController.丂七上业下丆丄东丄 == false)
        {
            goto label_4;
        }
        
        if((System.String.op_Equality(a:  this.丏丂不专上丘丂不丅, b:  "EventCurrency")) == false)
        {
            goto label_5;
        }
        
        BankController.丂上三丄丞下业丌世(丌丒丝东丌下丕丁丅:  0);
        goto label_13;
        label_4:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
        label_5:
        if((System.String.op_Equality(a:  this.丏丂不专上丘丂不丅, b:  "BattlePassCurrency")) != false)
        {
                BankController.丒丙东不上丟丑业丏(丌丒丝东丌下丕丁丅:  0, 丕丕世且下一与丝与:  0f);
        }
        else
        {
                CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  this.丏丂不专上丘丂不丅, 丌丒丝东丌下丕丁丅:  2);
        }
        
        label_13:
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
