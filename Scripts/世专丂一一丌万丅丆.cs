using UnityEngine;
internal sealed class 世专丂一一丌万丅丆
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 丘东丛丏丂与丌万三;
    private System.Nullable<int> 丏丆丟七丄丘丌丐丗;
    
    // Properties
    internal int 丄与丏丐丝丏业丗丞 { get; set; }
    internal System.Nullable<int> 丌丛不丝丗丑丟专丌 { get; }
    
    // Methods
    internal int 与丏东丂丂丄丒丙丁()
    {
    
    }
    internal void 七丘丞丂丛丐丛东丄(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        int val_2 = UnityEngine.Mathf.Max(a:  0, b:  丙业与丙丗丝不丈东);
        this.丘东丛丏丂与丌万三 = 0;
        mem[1152921539653223368] = 0;
    }
    internal System.Nullable<int> 丁丅丏丌业丑丟丟专()
    {
        return (System.Nullable<System.Int32>)this.丏丆丟七丄丘丌丐丗;
    }
    internal 世专丂一一丌万丅丆()
    {
    
    }
    internal 世专丂一一丌万丅丆(string 丌且专不丙丕专丅万)
    {
        object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
    }
    internal 世专丂一一丌万丅丆(object 丌且专不丙丕专丅万)
    {
        System.IFormatProvider val_10;
        object val_1 = 0;
        object val_6 = 0;
        if((0.TryGetValue(key:  "m", value: out  val_1)) == false)
        {
            goto label_4;
        }
        
        val_10 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        int val_5 = System.Convert.ToInt32(value:  val_1, provider:  System.Globalization.CultureInfo.InvariantCulture);
        this.丘东丛丏丂与丌万三 = 0;
        mem[1152921539653700344] = 0;
        if(1 != 0)
        {
            goto label_9;
        }
        
        goto label_13;
        label_4:
        UnityEngine.Debug.LogError(message:  "TryGu_nInfo: ErrorParse count_Matches");
        if(1 == 0)
        {
            goto label_13;
        }
        
        label_9:
        label_13:
        if((0.TryGetValue(key:  "b", value: out  val_6)) != false)
        {
                val_10 = System.Globalization.CultureInfo.InvariantCulture;
            int val_9 = System.Convert.ToInt32(value:  val_6, provider:  val_10);
            this.丏丆丟七丄丘丌丐丗 = 0;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "TryGu_nInfo: ErrorParse equipped_BeforeIndex");
    }
    internal 世专丂一一丌万丅丆(int 丑丘一三丗丂东一专, System.Nullable<int> 专丙专丈三丗东丞丘)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丏丆丟七丄丘丌丐丗 = 专丙专丈三丗东丞丘.HasValue;
        this.丘东丛丏丂与丌万三 = 0;
        mem[1152921539653824632] = 0;
    }
    public override string ToString()
    {
        return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丁丕上三丕丌丟丗丙());
    }
    internal System.Collections.Generic.Dictionary<string, int> 丁丕上三丕丌丟丗丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        val_1.set_Item(key:  "m", value:  this.丘东丛丏丂与丌万三);
        if((687463496 & 1) == 0)
        {
                return val_1;
        }
        
        val_1.set_Item(key:  "b", value:  687463496);
        return val_1;
    }

}
