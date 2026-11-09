using UnityEngine;
private sealed class ClanMembersHeaderViewItem.丙丟丒丅世丏丒与上 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ClanMembersHeaderViewItem 丝且与丝丒丟万丁专;
    private int 丙不丅丌丗上丂丕一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ClanMembersHeaderViewItem.丙丟丒丅世丏丒与上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 6)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 113;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        int val_12;
        if(this.丗丏丅丕丆世丁专丟 <= 3)
        {
                var val_6 = 106034016 + (this.丗丏丅丕丆世丁专丟) << 2;
            val_6 = val_6 + 106034016;
        }
        else
        {
                val_12 = 0;
            return (bool);
        }
    
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
                val_1 = 0;
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
