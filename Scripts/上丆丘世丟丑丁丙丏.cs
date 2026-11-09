using UnityEngine;
internal sealed class 上丆丘世丟丑丁丙丏<<c>j__TPar, <index>j__TPar>
{
    // Fields
    private readonly <c>j__TPar 丌丅丘丕丈不七丙与;
    private readonly <index>j__TPar 丅丁与丕丐七丐丌专;
    
    // Properties
    public <c>j__TPar 丁丂专业丁丅丅丈丙 { get; }
    public <index>j__TPar 丞世不丒下上上丝丑 { get; }
    
    // Methods
    public <c>j__TPar 上丁丕下且丘丝丄丟()
    {
        return (CategoryNames)this;
    }
    public <index>j__TPar 丑丘专丌丄丕东与丝()
    {
        return (int)this;
    }
    public 上丆丘世丟丑丁丙丏<<c>j__TPar, <index>j__TPar>(<c>j__TPar 丁丂专业丁丅丅丈丙, <index>j__TPar 丞世不丒下上上丝丑)
    {
        mem[1152921524275035264] = 丁丂专业丁丅丅丈丙;
        mem[1152921524275035268] = 丞世不丒下上上丝丑;
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
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 3441175167;
        return (int)val_2;
    }
    public override string ToString()
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if((__RuntimeMethodHiddenParam + 24 + 192 + 72) != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 72) == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = ;
        val_1[1] = val_1.Length.ToString();
        return (string)System.String.Format(provider:  0, format:  "{{ c = {0}, index = {1} }}", args:  val_1);
    }

}
