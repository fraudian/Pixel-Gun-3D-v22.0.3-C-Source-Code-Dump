using UnityEngine;
public class 不丕世与不丞丗丝丛
{
    // Fields
    public int 不丝三丛世东万且丏;
    public string 与丗一万丗三丟丕丗;
    public int 丈丘丝一丗下丈丐不;
    public int 专丂世丑丁东三丞一;
    public long 丒丐丛与东丅丒丛丁;
    public double 不上一丏丟上且丒丟;
    public string 丙与丌丐专丄丆丏丟;
    public System.Collections.Generic.Dictionary<string, string> 丘与丗丝业丌丑丗丙;
    
    // Methods
    public 不丕世与不丞丗丝丛()
    {
        this.丘与丗丝业丌丑丗丙 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        this.不丝三丛世东万且丏 = 0;
        this.丈丘丝一丗下丈丐不 = 0;
        this.专丂世丑丁东三丞一 = 0;
        this.丒丐丛与东丅丒丛丁 = 0;
        this.不上一丏丟上且丒丟 = 0;
    }
    public void 丛丟丟业丁丑三丑万(string 下上丐丆丝丟丝丒不, string 丙业与丙丗丝不丈东)
    {
        this.丘与丗丝业丌丑丗丙.Add(key:  下上丐丆丝丟丝丒不, value:  丙业与丙丗丝不丈东);
    }
    public System.Collections.Generic.Dictionary<string, string> 丞且一与专上丟丂丝()
    {
        var val_15;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_17;
        var val_18;
        System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String> val_20;
        System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String> val_22;
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(this.不丝三丛世东万且丏 != 1)
        {
                val_1.Add(key:  "age", value:  +this.不丝三丛世东万且丏);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.与丗一万丗三丟丕丗)) != true)
        {
                val_1.Add(key:  "gender", value:  this.与丗一万丗三丟丕丗);
        }
        
        if(this.丈丘丝一丗下丈丐不 != 1)
        {
                val_1.Add(key:  "level", value:  +this.丈丘丝一丗下丈丐不);
        }
        
        if(this.专丂世丑丁东三丞一 <= 1)
        {
                val_1.Add(key:  "isPaying", value:  +this.专丂世丑丁东三丞一);
        }
        
        if(this.丒丐丛与东丅丒丛丁 != 1)
        {
                val_1.Add(key:  "userCreationDate", value:  +this.丒丐丛与东丅丒丛丁);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.丙与丌丐专丄丆丏丟)) != true)
        {
                val_1.Add(key:  "segmentName", value:  this.丙与丌丐专丄丆丏丟);
        }
        
        if(this.不上一丏丟上且丒丟 > 0f)
        {
                val_1.Add(key:  "iapt", value:  +this.不上一丏丟上且丒丟);
        }
        
        val_15 = null;
        val_15 = null;
        val_17 = 不丕世与不丞丗丝丛.<>c.<>9__10_0;
        if(val_17 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_10 = null;
            val_17 = val_10;
            val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  不丕世与不丞丗丝丛.<>c.__il2cppRuntimeField_static_fields, method:  System.String 不丕世与不丞丗丝丛.<>c::丞一万丘丐专三世丝(System.Collections.Generic.KeyValuePair<string, string> 丐丆丂丒丁万丈丛丅));
            不丕世与不丞丗丝丛.<>c.<>9__10_0 = val_17;
        }
        
        val_18 = null;
        val_18 = null;
        val_20 = 不丕世与不丞丗丝丛.<>c.<>9__10_1;
        if(val_20 == null)
        {
                System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String> val_12 = null;
            val_20 = val_12;
            val_12 = new System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String>(object:  不丕世与不丞丗丝丛.<>c.__il2cppRuntimeField_static_fields, method:  System.String 不丕世与不丞丗丝丛.<>c::丆丕丘丌且丘丏丟丘(System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>> 丐丆丂丒丁万丈丛丅));
            val_18 = null;
            不丕世与不丞丗丝丛.<>c.<>9__10_1 = val_20;
        }
        
        val_18 = null;
        val_22 = 不丕世与不丞丗丝丛.<>c.<>9__10_2;
        if(val_22 != null)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.String>)System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String, System.String>(source:  System.Linq.Enumerable.GroupBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Concat<System.Collections.Generic.KeyValuePair<System.String, System.String>>(first:  val_1, second:  this.丘与丗丝业丌丑丗丙), keySelector:  val_10), keySelector:  val_12, elementSelector:  System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String> val_13 = null);
        }
        
        val_22 = val_13;
        val_13 = new System.Func<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String>(object:  不丕世与不丞丗丝丛.<>c.__il2cppRuntimeField_static_fields, method:  System.String 不丕世与不丞丗丝丛.<>c::万丐丙丌且下丘七丆(System.Linq.IGrouping<string, System.Collections.Generic.KeyValuePair<string, string>> 丐丆丂丒丁万丈丛丅));
        不丕世与不丞丗丝丛.<>c.<>9__10_2 = val_22;
        return (System.Collections.Generic.Dictionary<System.String, System.String>)System.Linq.Enumerable.ToDictionary<System.Linq.IGrouping<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>>, System.String, System.String>(source:  System.Linq.Enumerable.GroupBy<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(source:  System.Linq.Enumerable.Concat<System.Collections.Generic.KeyValuePair<System.String, System.String>>(first:  val_1, second:  this.丘与丗丝业丌丑丗丙), keySelector:  val_10), keySelector:  val_12, elementSelector:  val_13);
    }

}
