using UnityEngine;
internal sealed class 七丑丕丆世丘丆丈丄<<ItemID>j__TPar, <Discount>j__TPar>
{
    // Fields
    private readonly <ItemID>j__TPar 丙丒丒世丒世三丛且;
    private readonly <Discount>j__TPar 丘不一且丄丆丄七丙;
    
    // Properties
    public <ItemID>j__TPar 世七丘丐一且下三丘 { get; }
    public <Discount>j__TPar 丒业业丞丄丑与丗丒 { get; }
    
    // Methods
    public <ItemID>j__TPar 丗丄丟丛丄与丙丅七()
    {
        return (object)this;
    }
    public <Discount>j__TPar 丌业业业丞丆与丐丆()
    {
        return (int)this;
    }
    public 七丑丕丆世丘丆丈丄<<ItemID>j__TPar, <Discount>j__TPar>(<ItemID>j__TPar 世七丘丐一且下三丘, <Discount>j__TPar 丒业业丞丄丑与丗丒)
    {
        mem[1152921524272895856] = 世七丘丐一且下三丘;
        mem[1152921524272895864] = 丒业业丞丄丑与丗丒;
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
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 4188227339;
        return (int)val_2;
    }
    public override string ToString()
    {
        object val_5;
        object[] val_1 = new object[2];
        object val_2 = (1152921505719563712 == 0) ? 0 : -1808438936;
        if(null == 0)
        {
            goto label_1;
        }
        
        val_5 = mem[1152921505719563712 == 0x0 ? 0 : 1152921524273244520];
        val_5 = val_2;
        if(val_5 == 0)
        {
                val_5 = mem[1152921505719563712 == 0x0 ? 0 : 1152921524273244520];
            val_5 = val_2;
        }
        
        if(val_1 != null)
        {
            goto label_10;
        }
        
        label_11:
        label_10:
        val_1[0] = val_5;
        val_1[1] = val_1.Length.ToString();
        return (string)System.String.Format(provider:  0, format:  "{{ ItemID = {0}, Discount = {1} }}", args:  val_1);
        label_1:
        if(val_1 != null)
        {
            goto label_10;
        }
        
        goto label_11;
    }

}
