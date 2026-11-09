using UnityEngine;
private sealed class ImposterVoteResultUi.丝丆丘专丐丄业丕且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UILabel 七丐丞丑丑丕世丙七;
    public string 丕丗丘丑丛与丑业丒;
    public float 丟丞一专丕三东丗一;
    public ImposterVoteResultUi 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSecondsRealtime 且业世上三且丟丄专;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImposterVoteResultUi.丝丆丘专丐丄业丕且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        var val_12;
        int val_13;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_25;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.七丐丞丑丑丕世丙七 == 0)
        {
            goto label_25;
        }
        
        val_11 = System.String.alignConst;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.七丐丞丑丑丕世丙七, 丕丗丘丑丛与丑业丒:  val_11);
        val_12 = this;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丕丗丘丑丛与丑业丒)) == true)
        {
            goto label_25;
        }
        
        float val_3 = UnityEngine.Mathf.Clamp(value:  this.丟丞一专丕三东丗一, min:  0f, max:  1f);
        this.丟丞一专丕三东丗一 = val_3;
        val_11 = 0;
        this.且业世上三且丟丄专 = new UnityEngine.WaitForSecondsRealtime(time:  val_3);
        this.丈丌丝且业丏丈丂丁 = 0;
        goto label_11;
        label_1:
        val_12 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.七丐丞丑丑丕世丙七, 丕丗丘丑丛与丑业丒:  this.丕丗丘丑丛与丑业丒.Substring(startIndex:  0, length:  1));
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丝且与丝丒丟万丁专.resultSound != 0)
        {
                UnityEngine.AudioSource val_8 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专.resultSound);
        }
        
        }
        
        val_11 = this.丈丌丝且业丏丈丂丁 + 1;
        this.丈丌丝且业丏丈丂丁 = val_11;
        label_11:
        if(val_11 < this.丕丗丘丑丛与丑业丒.Length)
        {
                this.且业世上三且丟丄专.Reset();
            val_13 = 1;
            this.丗丏丅丕丆世丁专丟 = val_13;
            this.丒上七丌业七丟与丐 = this.且业世上三且丟丄专;
            return (bool)val_13;
        }
        
        label_25:
        val_13 = 0;
        return (bool)val_13;
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
