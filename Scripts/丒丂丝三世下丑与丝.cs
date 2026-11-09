using UnityEngine;
internal sealed class 丒丂丝三世下丑与丝<<Key>j__TPar, <Values>j__TPar>
{
    // Fields
    private readonly <Key>j__TPar 丄万一与丁丆不丛七;
    private readonly <Values>j__TPar 丞丗世三丕丒业一丛;
    
    // Properties
    public <Key>j__TPar 万丄七三丕丛丗丆丆 { get; }
    public <Values>j__TPar 丂丘且上丕三东丕丒 { get; }
    
    // Methods
    public <Key>j__TPar 七万丅丆且丁世丏丈()
    {
        return (int)this;
    }
    public <Values>j__TPar 且丆丒丏丂丄丗专不()
    {
        return (System.Linq.IOrderedEnumerable<PGCompany.丟丝世万东万丆丟上>)this;
    }
    public 丒丂丝三世下丑与丝<<Key>j__TPar, <Values>j__TPar>(<Key>j__TPar 万丄七三丕丛丗丆丆, <Values>j__TPar 丂丘且上丕三东丕丒)
    {
        mem[1152921524274322144] = 万丄七三丕丛丗丆丆;
        mem[1152921524274322152] = 丂丘且上丕三东丕丒;
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
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 1322480885;
        return (int)val_2;
    }
    public override string ToString()
    {
        var val_5;
        var val_6;
        object val_7;
        object[] val_1 = new object[2];
        val_5 = 0;
        string val_2 = 1152921505719563712.ToString();
        if((val_2 != null) && (val_2 == null))
        {
                val_5 = 0;
        }
        
        if(val_1.Length == 0)
        {
                val_5 = 0;
        }
        
        val_1[0] = val_2;
        var val_3 = (val_1.Length == 0) ? 0 : ();
        if(val_1.Length == 0)
        {
            goto label_5;
        }
        
        val_6 = mem[val_1.Length == 0 ? 0 : ];
        val_6 = val_3;
        if(val_6 == 0)
        {
                val_6 = mem[val_1.Length == 0 ? 0 : ];
            val_6 = val_3;
        }
        
        val_7 = val_6;
        if((val_7 == 0) || (val_7 != 0))
        {
            goto label_9;
        }
        
        goto label_9;
        label_5:
        val_7 = 0;
        label_9:
        val_1[1] = val_7;
        return (string)System.String.Format(provider:  0, format:  "{{ Key = {0}, Values = {1} }}", args:  val_1);
    }

}
