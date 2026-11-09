using UnityEngine;
private sealed class GiftHUDItem.丁丛丞东丕一丆丈七 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    public GiftHUDItem 丝且与丝丒丟万丁专;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    private float 世东不与七丗丒业一;
    public float 丁丘一上丝丑丟业丒;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftHUDItem.丁丛丞东丕一丆丈七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SlotInfo val_7;
        int val_8;
        int val_9;
        int val_10;
        val_7 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.IconCountLabel != 0)
        {
                val_8 = this.丝且与丝丒丟万丁专.业且万业丘丄丗丁与;
            this.丝且与丝丒丟万丁专.IconCountLabel.上不与丞丛不丏专丙(丂丐丏下万万丒三上:  val_8, 丕丂丐丌丆丝且万丗:  "");
        }
        
        val_9 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        this.丗丏丅丕丆世丁专丟 = val_9;
        return (bool)val_9;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_9;
        }
        
        val_8 = this.丝且与丝丒丟万丁专.业且万业丘丄丗丁与;
        val_10 = this.丝且与丝丒丟万丁专.业且万业丘丄丗丁与;
        goto label_10;
        label_2:
        val_9 = 0;
        return (bool)val_9;
        label_9:
        val_10 = 328;
        val_8 = 152;
        label_10:
        if(152 < this.丝且与丝丒丟万丁专._slotInfo.CountGift)
        {
                this.丝且与丝丒丟万丁专.IconCountLabel.且丟丘专丕丗丟专下(与丈业丛丝丒丙一丏:  this.世东不与七丗丒业一);
            GiftCategory val_4 = this.丝且与丝丒丟万丁专._slotInfo.category;
            if(val_4.Type != 8)
        {
                val_8 = this.丝且与丝丒丟万丁专._slotInfo.CountGift;
            this.丝且与丝丒丟万丁专.IconCountLabel.丒丙丐丑丘不丅业下(丆一万东丒丗一丝不:  152, 上丘专万丐丐丗丕丈:  val_8, 丟丞一专丕三东丗一:  0.05f, 丕丂丐丌丆丝且万丗:  "");
            this.丝且与丝丒丟万丁专.IconCountLabel.丄丄丛万丁丐丐与丏();
        }
        
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.UpgradeCellAnimationParticles, 丏业丟一东丂东丘丛:  true);
        }
        
        val_7 = this.丝且与丝丒丟万丁专._slotInfo;
        val_9 = 0;
        mem[328] = val_7.CountGift;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                GiftHUDItem.丁丛丞东丕一丆丈七 val_2 = null;
            val_4 = val_2;
            val_2 = new GiftHUDItem.丁丛丞东丕一丆丈七();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        .世东不与七丗丒业一 = this.丁丘一上丝丑丟业丒;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
