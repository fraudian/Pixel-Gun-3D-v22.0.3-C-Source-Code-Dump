using UnityEngine;
private sealed class NewGameBalancePageCurrencyCalculation.专丑且七丄丑丛七与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NewGameBalancePageCurrencyCalculation 丝且与丝丒丟万丁专;
    private float 丘丌丕一上丛下丙上;
    private int 一与丏与丟丙丑丙丘;
    private int 丁专丗不世世丝丞丝;
    private int 三与丘丗与丆丆专一;
    private int 三丅丆丌丑丛丐下东;
    private int 上不丛不丟业专万丁;
    private int 不丌丟丌丞万丝上丁;
    private int 丙丅三丗丗丕业丘丞;
    private int 丈丛丞专下三丁丄不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NewGameBalancePageCurrencyCalculation.专丑且七丄丑丛七与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        float val_14;
        var val_15;
        int val_16;
        int val_17;
        val_13 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丝且与丝丒丟万丁专._alphaTween.enabled = false;
        this.丝且与丝丒丟万丁专._alphaTween.ResetToBeginning();
        val_14 = val_13;
        this.丘丌丕一上丛下丙上 = 0;
        val_15 = null;
        this.一与丏与丟丙丑丙丘 = NewGameBalance12_5WindowController.万丆丙万丏七丒丅丅();
        int val_2 = NewGameBalance12_5WindowController.专丕丙不万世丞丌丛();
        this.丁专丗不世世丝丞丝 = val_2;
        this.三与丘丗与丆丆专一 = 0;
        this.三丅丆丌丑丛丐下东 = 0;
        if(this.一与丏与丟丙丑丙丘 == 0)
        {
            goto label_8;
        }
        
        if(val_2 == 0)
        {
            goto label_9;
        }
        
        label_22:
        this.上不丛不丟业专万丁 = 0;
        this.不丌丟丌丞万丝上丁 = 0;
        this.丙丅三丗丗丕业丘丞 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且();
        this.丈丛丞专下三丁丄不 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌();
        this.丝且与丝丒丟万丁专.与专七不丐丂上七且(丏七丗丏且丕三丘丞:  this.一与丏与丟丙丑丙丘, 世东世丙万丞丐七丌:  this.丁专丗不世世丝丞丝, 丞丝丅丏万丛丞丁且:  this.三与丘丗与丆丆专一, 丄世丑一丗专丒丟丂:  this.三丅丆丌丑丛丐下东);
        goto label_14;
        label_1:
        val_14 = this.丘丌丕一上丛下丙上;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_14:
        float val_13 = val_14;
        if(val_13 > 0f)
        {
            goto label_15;
        }
        
        val_16 = this.丙丅三丗丗丕业丘丞;
        val_13 = this.丈丛丞专下三丁丄不;
        this.丝且与丝丒丟万丁专.与专七不丐丂上七且(丏七丗丏且丕三丘丞:  0, 世东世丙万丞丐七丌:  0, 丞丝丅丏万丛丞丁且:  val_16, 丄世丑一丗专丒丟丂:  val_13);
        label_2:
        val_17 = 0;
        return (bool)val_17;
        label_15:
        val_13 = 1f - (val_13 / S0);
        val_16 = (int)UnityEngine.Mathf.Lerp(a:  (float)this.一与丏与丟丙丑丙丘, b:  (float)this.上不丛不丟业专万丁, t:  val_13);
        this.丝且与丝丒丟万丁专.与专七不丐丂上七且(丏七丗丏且丕三丘丞:  val_16, 世东世丙万丞丐七丌:  (int)UnityEngine.Mathf.Lerp(a:  (float)this.丁专丗不世世丝丞丝, b:  (float)this.不丌丟丌丞万丝上丁, t:  val_13), 丞丝丅丏万丛丞丁且:  (int)UnityEngine.Mathf.Lerp(a:  (float)this.三与丘丗与丆丆专一, b:  (float)this.丙丅三丗丗丕业丘丞, t:  val_13), 丄世丑一丗专丒丟丂:  (int)UnityEngine.Mathf.Lerp(a:  (float)this.三丅丆丌丑丛丐下东, b:  (float)this.丈丛丞专下三丁丄不, t:  val_13));
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = this.丘丌丕一上丛下丙上 - val_12;
        val_17 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丘丌丕一上丛下丙上 = val_12;
        this.丗丏丅丕丆世丁专丟 = val_17;
        return (bool)val_17;
        label_8:
        this.一与丏与丟丙丑丙丘 = 0;
        if(val_2 != 0)
        {
            goto label_22;
        }
        
        label_9:
        this.丁专丗不世世丝丞丝 = 0;
        goto label_22;
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
