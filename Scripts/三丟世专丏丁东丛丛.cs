using UnityEngine;
internal class 且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛
{
    // Fields
    internal int 丌丗丏丝丈丒一一丞;
    internal int 一丘丁丒丂丁不万世;
    internal Rilisoft.Offers.LobbyOfferParameters 且万丑丌与七与业与;
    internal System.Collections.Generic.List<string> 丕且一丛专丆丈三丆;
    private System.Collections.Generic.List<string> 丁丁三七下丞上丏丛;
    private string 丏世丑万世一七丟丞;
    
    // Properties
    private System.Collections.Generic.List<string> 丐丂东丟丘丏丏一丝 { get; }
    internal string 下丄丈不与世丐业专 { get; }
    
    // Methods
    private System.Collections.Generic.List<string> 万一丗丗丄三丏丏世()
    {
        if(this.丁丁三七下丞上丏丛 != null)
        {
                return val_1;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.一丄丞丁丘丆丙丆上();
        this.丁丁三七下丞上丏丛 = val_1;
        return val_1;
    }
    internal string 业上丙丞丐丄丆丅七()
    {
        string val_3;
        if((System.String.IsNullOrEmpty(value:  this.丏世丑万世一七丟丞)) != false)
        {
                this.丏世丑万世一七丟丞 = this.丁丝三世丌三丆丟七();
            return val_3;
        }
        
        val_3 = this.丏世丑万世一七丟丞;
        return val_3;
    }
    internal 且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛(int 世不下丟世一丝丐丗, int 丑丅世丐丒丏丐三丅, Rilisoft.Offers.LobbyOfferParameters 上丙业丝丝丄专东丄, System.Collections.Generic.List<string> 丙丛丐七丗丂丛丒丁)
    {
        this.丕且一丛专丆丈三丆 = new System.Collections.Generic.List<System.String>();
        val_2 = new System.Object();
        this.丌丗丏丝丈丒一一丞 = 世不下丟世一丝丐丗;
        this.一丘丁丒丂丁不万世 = 丑丅世丐丒丏丐三丅;
        this.且万丑丌与七与业与 = val_2;
        this.丕且一丛专丆丈三丆 = 丙丛丐七丗丂丛丒丁;
    }
    private string 丁丝三世丌三丆丟七()
    {
        System.Collections.Generic.List<System.String> val_5;
        var val_6;
        System.Func<System.String, System.String, System.String> val_8;
        val_5 = this.丁丁三七下丞上丏丛;
        if(val_5 == null)
        {
                val_5 = this.一丄丞丁丘丆丙丆上();
            this.丁丁三七下丞上丏丛 = val_5;
        }
        
        val_6 = null;
        val_6 = null;
        val_8 = 且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛.<>c.<>9__11_0;
        if(val_8 != null)
        {
                return (string)System.String.Format(format:  "lb_{0}_{1}_[{2}]", arg0:  this.丌丗丏丝丈丒一一丞, arg1:  this.且万丑丌与七与业与.Price, arg2:  System.Linq.Enumerable.Aggregate<System.String>(source:  val_5, func:  System.Func<System.String, System.String, System.String> val_2 = null));
        }
        
        val_8 = val_2;
        val_2 = new System.Func<System.String, System.String, System.String>(object:  且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛.<>c.__il2cppRuntimeField_static_fields, method:  System.String 且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛.<>c::七与丁丄一丂与上世(string 与丕丁三万专世不丅, string 丏丛与丅丛丌万专丌));
        且丙丙丈丙丄丌丌不.三丟世专丏丁东丛丛.<>c.<>9__11_0 = val_8;
        return (string)System.String.Format(format:  "lb_{0}_{1}_[{2}]", arg0:  this.丌丗丏丝丈丒一一丞, arg1:  this.且万丑丌与七与业与.Price, arg2:  System.Linq.Enumerable.Aggregate<System.String>(source:  val_5, func:  val_2));
    }
    private System.Collections.Generic.List<string> 一丄丞丁丘丆丙丆上()
    {
        var val_4;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_2 = this.丕且一丛专丆丈三丆.GetEnumerator();
        label_4:
        if(((-474451720) & 1) == 0)
        {
            goto label_2;
        }
        
        val_1.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_4 = null;
        val_4 = null;
        val_1.Add(item:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄);
        val_1.Add(item:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
        return val_1;
    }

}
