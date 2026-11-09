using UnityEngine;
private sealed class WeaponManager.不且丄丅丈上丈丆专
{
    // Fields
    public 三丅丁丗丗丝丂万且 丞丙七丙丐丁丕丙七;
    public string 不且丗万业丞丞七七;
    public WeaponManager 丝且与丝丒丟万丁专;
    public System.Func<string, bool> 丟丕丁与丝丝丂下丕;
    public System.Predicate<三丈丟与丏丘丈丐万> 丟业万丄业丘丘丈丟;
    
    // Methods
    public WeaponManager.不且丄丅丈上丈丆专()
    {
    
    }
    internal bool 丒丁丈下丐丝丘丕丐(System.Collections.Generic.KeyValuePair<string, string[]> 丈丏万丄丒业丅丒一)
    {
        System.Func<System.String, System.Boolean> val_4;
        val_4 = this.丟丕丁与丝丝丂下丕;
        if(val_4 != null)
        {
                return (bool)System.Linq.Enumerable.Any<System.String>(source:  丈丏万丄丒业丅丒一.Value, predicate:  System.Func<System.String, System.Boolean> val_1 = null);
        }
        
        val_4 = val_1;
        val_1 = new System.Func<System.String, System.Boolean>(object:  this, method:  System.Boolean WeaponManager.不且丄丅丈上丈丆专::世丞丒丏下丙丐丏丁(string 三丟东丕丄丄下下丑));
        this.丟丕丁与丝丝丂下丕 = val_4;
        return (bool)System.Linq.Enumerable.Any<System.String>(source:  丈丏万丄丒业丅丒一.Value, predicate:  val_1);
    }
    internal bool 世丞丒丏下丙丐丏丁(string 三丟东丕丄丄下下丑)
    {
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑, b:  this.丞丙七丙丐丁丕丙七.三与丛丑且丐丈业丌());
    }
    internal void 丌丁丌丐与世丙丏丐()
    {
        System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_1 = this.丝且与丝丒丟万丁专.下上丏丁东丝丑世与();
        if(this.丟业万丄业丘丘丈丟 == null)
        {
            goto label_2;
        }
        
        label_9:
        int val_2 = val_1.RemoveAll(match:  this.丟业万丄业丘丘丈丟);
        this.丝且与丝丒丟万丁专.下上丏丁东丝丑世与().Sort(comparison:  new System.Comparison<三丈丟与丏丘丈丐万>(object:  0, method:  static System.Int32 丒丈一与东一丝丙丏::丂丆世世丕丅丕丅上(object 三丟东丕丄丄下下丑, object 丒丒丄丁且丄丆丂丌)));
        this.丝且与丝丒丟万丁专.下上丏丁东丝丑世与().Reverse();
        return;
        label_2:
        this.丟业万丄业丘丘丈丟 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  this, method:  System.Boolean WeaponManager.不且丄丅丈上丈丆专::下丘万丄丌丐世七丛(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑));
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    internal bool 下丘万丄丌丐世七丛(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑)
    {
        return (bool)(三丟东丕丄丄下下丑.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == this.丞丙七丙丐丁丕丙七.丒万丕七专不丏丞丌()) ? 1 : 0;
    }
    internal bool 丄丞丆丛丆且丌丑丐(三丈丟与丏丘丈丐万 三丟东丕丄丄下下丑)
    {
        return System.String.op_Equality(a:  三丟东丕丄丄下下丑.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌(), b:  this.不且丗万业丞丞七七);
    }

}
