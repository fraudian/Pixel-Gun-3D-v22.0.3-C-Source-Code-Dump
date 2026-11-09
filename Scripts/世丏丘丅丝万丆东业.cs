using UnityEngine;
internal sealed class 世丏丘丅丝万丆东业<<w>j__TPar, <rec>j__TPar>
{
    // Fields
    private readonly <w>j__TPar 丆丌丗且万丛丒不七;
    private readonly <rec>j__TPar 丅上上丒业丘丒下三;
    
    // Properties
    public <w>j__TPar 与丘东下丈东丛丂万 { get; }
    public <rec>j__TPar 丆丐七世世且丏丐业 { get; }
    
    // Methods
    public <w>j__TPar 丆丗丑丞丐丈专上丆()
    {
        return (object)this;
    }
    public <rec>j__TPar 上丏世丌七丟万专丄()
    {
        return (object)this;
    }
    public 世丏丘丅丝万丆东业<<w>j__TPar, <rec>j__TPar>(<w>j__TPar 与丘东下丈东丛丂万, <rec>j__TPar 丆丐七世世且丏丐业)
    {
        val_1 = new System.Object();
        mem[1152921524272186832] = 与丘东下丈东丛丂万;
        mem[1152921524272186840] = val_1;
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
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 2935076745;
        return (int)val_2;
    }
    public override string ToString()
    {
        object val_5;
        var val_6;
        var val_7;
        object val_8;
        object[] val_1 = new object[2];
        object val_2 = (1152921505719563712 == 0) ? 0 : -1809147976;
        if(null == 0)
        {
            goto label_1;
        }
        
        val_5 = mem[1152921505719563712 == 0x0 ? 0 : 1152921524272535480];
        val_5 = val_2;
        if(val_5 == 0)
        {
                val_5 = mem[1152921505719563712 == 0x0 ? 0 : 1152921524272535480];
            val_5 = val_2;
        }
        
        val_6 = mem[1152921505719563712 == 0x0 ? 0 : 1152921524272535480 + 344 + 8];
        val_6 = 1152921505719563712 == 0x0 ? 0 : 1152921524272535480 + 344 + 8;
        if(val_1 != null)
        {
            goto label_12;
        }
        
        label_13:
        label_12:
        if((val_5 != 0) && (val_5 == 0))
        {
                val_6 = 0;
        }
        
        if(val_1.Length == 0)
        {
                val_6 = 0;
        }
        
        val_1[0] = val_5;
        var val_3 = (val_1.Length == 0) ? 0 : ();
        if(val_1.Length == 0)
        {
            goto label_7;
        }
        
        val_7 = mem[val_1.Length == 0 ? 0 : ];
        val_7 = val_3;
        if(val_7 == 0)
        {
                val_7 = mem[val_1.Length == 0 ? 0 : ];
            val_7 = val_3;
        }
        
        val_8 = val_7;
        if((val_8 == 0) || (val_8 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        if(val_1 != null)
        {
            goto label_12;
        }
        
        goto label_13;
        label_7:
        val_8 = 0;
        label_11:
        val_1[1] = val_8;
        return (string)System.String.Format(provider:  0, format:  "{{ w = {0}, rec = {1} }}", args:  val_1);
    }

}
