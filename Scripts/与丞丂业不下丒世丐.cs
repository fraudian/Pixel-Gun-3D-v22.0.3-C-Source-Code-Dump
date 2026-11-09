using UnityEngine;
private sealed class FreePlayTaskController.与丞丂业不下丒世丐
{
    // Fields
    public System.Collections.Generic.List<丐丆丑丝世丕世不世> 世七丘万专丐专丙万;
    public int 丛丝东东专丕业丑丂;
    public FreePlayTaskController 丝且与丝丒丟万丁专;
    
    // Methods
    public FreePlayTaskController.与丞丂业不下丒世丐()
    {
    
    }
    internal int 丕丈万丟丙丙七丟丂(System.Collections.Generic.KeyValuePair<丐丆丑丝世丕世不世, int> 三丟东丕丄丄下下丑)
    {
        var val_3;
        if((this.世七丘万专丐专丙万.Contains(item:  三丟东丕丄丄下下丑.Value.GetHashCode())) != false)
        {
                return (int)val_3;
        }
        
        val_3 = 0;
        return (int)val_3;
    }
    internal bool 丝世世下丌东丞上丆(PGCompany.世丐下丕专东丘丏且 三丟东丕丄丄下下丑)
    {
        FreePlayTaskController.丆丗丒下七一不丁丝 val_1 = new FreePlayTaskController.丆丗丒下七一不丁丝();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑;
        if(三丟东丕丄丄下下丑 != null)
        {
            goto label_6;
        }
        
        label_7:
        label_6:
        PGCompany.丟丒丅丐万丈七且万 val_2 = 三丟东丕丄丄下下丑.世丈丁业丛上丘丗丐();
        if(val_2.丅丁丙世且丛丕丅且 != this.丛丝东东专丕业丑丂)
        {
                return false;
        }
        
        return System.Linq.Enumerable.All<PGCompany.世丐下丕专东丘丏且>(source:  this.丝且与丝丒丟万丁专.不丆丘不丑业下丗与(), predicate:  new System.Func<PGCompany.世丐下丕专东丘丏且, System.Boolean>(object:  val_1, method:  System.Boolean FreePlayTaskController.丆丗丒下七一不丁丝::丞丏丄世丘七丞丄三(PGCompany.世丐下丕专东丘丏且 丒丒丄丁且丄丆丂丌)));
        label_1:
        mem[16] = 三丟东丕丄丄下下丑;
        if(mem[16] != 0)
        {
            goto label_6;
        }
        
        goto label_7;
    }

}
