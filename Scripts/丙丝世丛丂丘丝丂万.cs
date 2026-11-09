using UnityEngine;
internal sealed class 丙丝世丛丂丘丝丂万<<Slot>j__TPar, <Id>j__TPar>
{
    // Fields
    private readonly <Slot>j__TPar 丐丂丟丄丑上丘世不;
    private readonly <Id>j__TPar 丂东世丂世七七一一;
    
    // Properties
    public <Slot>j__TPar 丙丕丈一一丝丑七丈 { get; }
    public <Id>j__TPar 下丄丈不与世丐业专 { get; }
    
    // Methods
    public <Slot>j__TPar 丘专上世与丟丝丟丛()
    {
        return (System.Int32Enum)this;
    }
    public <Id>j__TPar 业上丙丞丐丄丆丅七()
    {
        return (object)this;
    }
    public 丙丝世丛丂丘丝丂万<<Slot>j__TPar, <Id>j__TPar>(<Slot>j__TPar 丙丕丈一一丝丑七丈, <Id>j__TPar 下丄丈不与世丐业专)
    {
        val_1 = new System.Object();
        mem[1152921524271473712] = 丙丕丈一一丝丑七丈;
        mem[1152921524271473720] = val_1;
    }
    public override bool Equals(object 丙业与丙丗丝不丈东)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = this;
        val_10 = 丙业与丙丗丝不丈东;
        if(val_10 == null)
        {
                return false;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8) & 1) == 0)
        {
                return false;
        }
        
        val_9 = ???;
        val_10 = ???;
        val_11 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 32 + 424;
    }
    public override int GetHashCode()
    {
        var val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 2129351883;
        return (int)val_2;
    }
    public override string ToString()
    {
        var val_4;
        var val_5;
        object val_6;
        object[] val_1 = new object[2];
        val_4 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72 + 344 + 8];
        val_4 = __RuntimeMethodHiddenParam + 24 + 192 + 72 + 344 + 8;
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 72) != 0) && ((__RuntimeMethodHiddenParam + 24 + 192 + 72) == 0))
        {
                val_4 = 0;
        }
        
        if(val_1.Length == 0)
        {
                val_4 = 0;
        }
        
        val_1[0] = ;
        var val_2 = (val_1.Length == 0) ? 0 : -1809861096;
        if(val_1.Length == 0)
        {
            goto label_6;
        }
        
        val_5 = mem[val_1.Length == 0 ? 0 : 1152921524271822360];
        val_5 = val_2;
        if(val_5 == 0)
        {
                val_5 = mem[val_1.Length == 0 ? 0 : 1152921524271822360];
            val_5 = val_2;
        }
        
        val_6 = val_5;
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_10;
        }
        
        goto label_10;
        label_6:
        val_6 = 0;
        label_10:
        val_1[1] = val_6;
        return (string)System.String.Format(provider:  0, format:  "{{ Slot = {0}, Id = {1} }}", args:  val_1);
    }

}
