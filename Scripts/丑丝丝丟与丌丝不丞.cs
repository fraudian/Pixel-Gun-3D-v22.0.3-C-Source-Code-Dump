using UnityEngine;
internal sealed class 丑丝丝丟与丌丝不丞<<AmmoInClip>j__TPar, <AmmoInBackpack>j__TPar>
{
    // Fields
    private readonly <AmmoInClip>j__TPar 丌丁专一丁东不东丟;
    private readonly <AmmoInBackpack>j__TPar 丂丝丏与与丙丐丅丕;
    
    // Properties
    public <AmmoInClip>j__TPar 上丂下丅丂丗上丈丌 { get; }
    public <AmmoInBackpack>j__TPar 丘丟丛不东世一丏丙 { get; }
    
    // Methods
    public <AmmoInClip>j__TPar 下世下丂丂丌丑丝世()
    {
        return (int)this;
    }
    public <AmmoInBackpack>j__TPar 万丙丟丁丄丄丛下丈()
    {
        return (int)this;
    }
    public 丑丝丝丟与丌丝不丞<<AmmoInClip>j__TPar, <AmmoInBackpack>j__TPar>(<AmmoInClip>j__TPar 上丂下丅丂丗上丈丌, <AmmoInBackpack>j__TPar 丘丟丛不东世一丏丙)
    {
        mem[1152921524273604896] = 上丂下丅丂丗上丈丌;
        mem[1152921524273604900] = 丘丟丛不东世一丏丙;
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
        val_2 = (val_2 + ((__RuntimeMethodHiddenParam + 24 + 192 + 8) * 2773833001)) + 58077994;
        return (int)val_2;
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
        return (string)System.String.Format(provider:  0, format:  "{{ AmmoInClip = {0}, AmmoInBackpack = {1} }}", args:  val_1);
    }

}
