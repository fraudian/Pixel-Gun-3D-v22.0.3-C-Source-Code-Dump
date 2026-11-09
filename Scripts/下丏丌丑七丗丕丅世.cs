using UnityEngine;
private sealed class PetsManager.下丏丌丑七丗丕丅世
{
    // Fields
    public System.Collections.Generic.List<string> 东一丞丌丏三丞丑七;
    public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛>> 丏丒丌丛丙万三丑丁;
    
    // Methods
    public PetsManager.下丏丌丑七丗丕丅世()
    {
    
    }
    internal bool 丙与上专丛丗丁且与(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 不下丗丙七丈丐丘万)
    {
        return (bool)this.东一丞丌丏三丞丑七.Contains(item:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[不下丗丙七丈丐丘万.Value.丙东专丂世丈丏丁丂()]);
    }
    internal int 三上丂丘万下不丌不(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 不下丗丙七丈丐丘万)
    {
        return (int)this.东一丞丌丏三丞丑七.IndexOf(item:  丟下七丘下下丙丗丅.与丐专丒丆业丏上丗().Item[不下丗丙七丈丐丘万.Value.丙东专丂世丈丏丁丂()]);
    }
    internal bool 下东丂丞一七丝万东(string 七丏丄丅丌业与且丙)
    {
        .七丏丄丅丌业与且丙 = 七丏丄丅丌业与且丙;
        return System.Linq.Enumerable.All<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>>(source:  this.丏丒丌丛丙万三丑丁, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, 七下下业三丞专丈丛>, System.Boolean>(object:  new PetsManager.丞丌丐丝三万三丐丁(), method:  System.Boolean PetsManager.丞丌丐丝三万三丐丁::丆丆丛专丌丕丗丕丑(System.Collections.Generic.KeyValuePair<int, 七下下业三丞专丈丛> 不下丗丙七丈丐丘万)));
    }

}
