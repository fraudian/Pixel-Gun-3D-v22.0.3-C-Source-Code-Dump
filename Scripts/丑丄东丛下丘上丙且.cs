using UnityEngine;
private sealed class ItemCurrencyUI.丑丄东丛下丘上丙且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PGCompany.ItemCurrencyUI 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ItemCurrencyUI.丑丄东丛下丘上丙且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_5;
        UIBasicSprite val_6;
        float val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专._blinkBG == 0)
        {
            goto label_7;
        }
        
        val_5 = 0;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.丙不丅丌丗上丂丕一 = 0;
        goto label_11;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_9;
        }
        
        val_6 = this.丝且与丝丒丟万丁专._blinkBG;
        goto label_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = -3;
        val_5 = this.丙不丅丌丗上丂丕一 + 1;
        this.丙不丅丌丗上丂丕一 = val_5;
        label_11:
        if(val_5 < this.丝且与丝丒丟万丁专._blinkIteration)
        {
                this.丝且与丝丒丟万丁专._blinkBG.color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.不世丑业上丒丒丁七, g = V9.16B, b = V10.16B, a = V11.16B};
            val_8 = this.丝且与丝丒丟万丁专._blinkTime;
            new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  val_8);
            val_9 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.下丏丝丒丝与万丂丆;
        this.丝且与丝丒丟万丁专._blinkBG.color = new UnityEngine.Color() {r = val_8, g = V9.16B, b = V10.16B, a = V11.16B};
        this.一世丕丕业且且丅丌();
        label_7:
        val_9 = 0;
        return (bool)val_9;
        label_9:
        val_6 = 2;
        label_10:
        val_6.color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.下丏丝丒丝与万丂丆, g = V9.16B, b = V10.16B, a = V11.16B};
        val_8 = this.丝且与丝丒丟万丁专._blinkTime;
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  val_8);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_9 = 1;
        return (bool)val_9;
    }
    private void 一世丕丕业且且丅丌()
    {
        UIBasicSprite val_1;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_1 = this.丝且与丝丒丟万丁专._blinkBG;
        }
        else
        {
                val_1 = 2;
        }
        
        val_1.color = new UnityEngine.Color() {r = this.丝且与丝丒丟万丁专.下丏丝丒丝与万丂丆, g = V9.16B, b = V10.16B, a = V11.16B};
        this.丝且与丝丒丟万丁专.丗且三一一三丅丒丟 = 0;
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
