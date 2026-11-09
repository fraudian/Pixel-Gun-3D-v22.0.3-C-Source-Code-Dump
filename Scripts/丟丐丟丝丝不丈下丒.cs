using UnityEngine;
private sealed class LevelCompleteScript.丟丐丟丝丝不丈下丒
{
    // Fields
    public System.Collections.Generic.Dictionary<string, 丑丝丝丟与丌丝不丞<int, int>> 一上三丟上丒七七丑;
    
    // Methods
    public LevelCompleteScript.丟丐丟丝丝不丈下丒()
    {
    
    }
    internal void 丈丁丐与丈下世与丘()
    {
        var val_5;
        var val_12;
        System.Collections.Generic.IEnumerable<TSource> val_13;
        val_12 = null;
        val_12 = null;
        val_13 = WeaponManager.丟丗丄业丘丗业丗七.丅下三且万丟东不下();
        Dictionary.Enumerator<TKey, TValue> val_2 = this.一上三丟上丒七七丑.GetEnumerator();
        label_10:
        if(((-216752976) & 1) == 0)
        {
            goto label_5;
        }
        
        new LevelCompleteScript.专且丑丌下丗上丄专() = new System.Object();
        ConfiguredValueTaskAwaiter val_7 = val_5.GetAwaiter();
        .丈丏万丄丒业丅丒一 = val_7._value._obj;
        mem[1152921543044852024] = val_7._value._token;
        mem[1152921543044852026] = val_7._value._continueOnCapturedContext;
        System.Func<三丈丟与丏丘丈丐万, System.Boolean> val_8 = new System.Func<三丈丟与丏丘丈丐万, System.Boolean>(object:  new LevelCompleteScript.专且丑丌下丗上丄专(), method:  System.Boolean LevelCompleteScript.专且丑丌下丗上丄专::不专丈丙丈业丑丙丁(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        三丈丟与丏丘丈丐万 val_9 = System.Linq.Enumerable.FirstOrDefault<三丈丟与丏丘丈丐万>(source:  val_13, predicate:  null);
        if(val_9 == null)
        {
            goto label_10;
        }
        
        val_9.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  .丈丏万丄丒业丅丒一.下世下丂丂丌丑丝世());
        val_9.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  .丈丏万丄丒业丅丒一.Value);
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }

}
