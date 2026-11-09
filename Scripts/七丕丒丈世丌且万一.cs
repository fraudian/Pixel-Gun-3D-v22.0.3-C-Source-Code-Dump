using UnityEngine;
internal sealed class 七丕丒丈世丌且万一<<Index>j__TPar, <Active>j__TPar>
{
    // Fields
    private readonly <Index>j__TPar 丘下丞世丁上丏世丆;
    private readonly <Active>j__TPar 且丌与丗丏丆丄丌一;
    
    // Properties
    public <Index>j__TPar 丐丒且丝丛丁丕丟丅 { get; }
    public <Active>j__TPar 丞专丗丞世丂丝丈丒 { get; }
    
    // Methods
    public <Index>j__TPar 业东丅东丌上丗丑不()
    {
        return (int)this;
    }
    public <Active>j__TPar 丁不与丕丐七丝丛丟()
    {
        return (bool)this;
    }
    public 七丕丒丈世丌且万一<<Index>j__TPar, <Active>j__TPar>(<Index>j__TPar 丐丒且丝丛丁丕丟丅, <Active>j__TPar 丞专丗丞世丂丝丈丒)
    {
        mem[1152921524276457408] = 丐丒且丝丛丁丕丟丅;
        mem[1152921524276457412] = 丞专丗丞世丂丝丈丒;
    }
    public override bool Equals(object 丙业与丙丗丝不丈东)
    {
        var val_11;
        var val_12;
        var val_13;
        val_11 = this;
        val_12 = 丙业与丙丗丝不丈东;
        if(val_12 == null)
        {
                return false;
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 8) & 1) == 0)
        {
                return false;
        }
        
        var val_1 = (val_12 != 0) ? 1 : 0;
        val_11 = ???;
        val_12 = ???;
        var val_2 = (__RuntimeMethodHiddenParam != 0) ? 1 : 0;
        val_13 = ???;
        goto __RuntimeMethodHiddenParam + 24 + 192 + 32 + 424;
    }
    public override int GetHashCode()
    {
        var val_1 = (W21 != 0) ? 1 : 0;
        var val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 32;
        val_3 = (val_3 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 835903696;
        return (int)val_3;
    }
    public override string ToString()
    {
        object[] val_1 = new object[2];
        string val_2 = 1152921505719563712.ToString();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_2 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_2 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_2;
        val_1[1] = val_1.Length.ToString();
        return (string)System.String.Format(provider:  0, format:  "{{ Index = {0}, Active = {1} }}", args:  val_1);
    }

}
