using UnityEngine;
internal abstract class 丄世丕丈一丈东丆丐
{
    // Fields
    protected 丏丝丘丘丑丂专丐丆[] 丗世上丘东下丘丑世;
    private int[] 丁丝丌业一丐一丗丘;
    private 不七且丌丄丑世七丙[] 三丌下世丞且三丌丝;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int[]>> 下且丙不丌丏丛丆丅;
    
    // Properties
    internal int[] 丑专丝东丆且丒东丙 { get; set; }
    internal 不七且丌丄丑世七丙[] 专丂上业世东东丑万 { get; set; }
    internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int[]>> 世丕世丐三丝丑不丘 { get; set; }
    
    // Methods
    internal int[] 下丅专丁万东丏丞丌()
    {
        return (System.Int32[])this.丁丝丌业一丐一丗丘;
    }
    private void 丄一丑丙丌丗万丑丆(int[] 丙业与丙丗丝不丈东)
    {
        this.丁丝丌业一丐一丗丘 = 丙业与丙丗丝不丈东;
    }
    internal 不七且丌丄丑世七丙[] 且丘丝丈业丞七丄丟()
    {
        return (不七且丌丄丑世七丙[])this.三丌下世丞且三丌丝;
    }
    private void 丞丞一下丂丑丈丟业(不七且丌丄丑世七丙[] 丙业与丙丗丝不丈东)
    {
        this.三丌下世丞且三丌丝 = 丙业与丙丗丝不丈东;
    }
    internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int[]>> 丄专丙丝万丌业丑丘()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32[]>>)this.下且丙不丌丏丛丆丅;
    }
    private void 丄丈丁丂下丒丟东专(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int[]>> 丙业与丙丗丝不丈东)
    {
        this.下且丙不丌丏丛丆丅 = 丙业与丙丗丝不丈东;
    }
    internal abstract int 丈丏一丌丗丂业丟丕(int 业万上丆丐丞且丒七, int 专世专丟丝丌与丘上); // 0
    internal abstract int 三七世丝不丑丅丈丆(); // 0
    public 丄世丕丈一丈东丆丐(System.Collections.Generic.Dictionary<string, object> 丒丐丈下丛丛丒丈丏, 与七丙丌丈丅上丝不 丈丞丏三丒丁丗丘东)
    {
        val_1 = new System.Object();
        if(val_1 != null)
        {
                this.三丌下世丞且三丌丝 = val_1.业不丟东东丟丟一丏(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
            this.丁丝丌业一丐一丗丘 = val_1.万业丄丕与万丆丆丟(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
            this.下且丙不丌丏丛丆丅 = val_1.万三下三丌丛丒丆丑(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
        }
        else
        {
                this.三丌下世丞且三丌丝 = 0.业不丟东东丟丟一丏(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
            this.丁丝丌业一丐一丗丘 = 0.万业丄丕与万丆丆丟(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
            this.下且丙不丌丏丛丆丅 = 0.万三下三丌丛丒丆丑(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
        }
        
        this.丗世上丘东下丘丑世 = val_1.专万专丂一七丙丅世(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
    }
    internal int 丛丕丐丏丒一业专世(int 丈丘丝一丗下丈丐不)
    {
        var val_1;
        System.Int32[] val_2;
        var val_3;
        val_1 = 1;
        goto label_0;
        label_10:
        if(val_1 >= this.丁丝丌业一丐一丗丘.Length)
        {
            goto label_2;
        }
        
        if(this.丁丝丌业一丐一丗丘[(long)(long)(int)(W23)] <= 丈丘丝一丗下丈丐不)
        {
                val_2 = this.丁丝丌业一丐一丗丘;
            if(val_2[1] > 丈丘丝一丗下丈丐不)
        {
                return (int)val_3;
        }
        
        }
        
        val_1 = 2;
        label_0:
        val_2 = val_1 - 1;
        if(val_2 < this.丁丝丌业一丐一丗丘.Length)
        {
            goto label_10;
        }
        
        val_3 = 0;
        return (int)val_3;
        label_2:
        val_3 = W23;
        return (int)val_3;
    }
    internal int 业三丕丏不丅七丁三(int 丈丘丝一丗下丈丐不)
    {
        丏丝丘丘丑丂专丐丆[] val_1;
        var val_2;
        丏丝丘丘丑丂专丐丆[] val_3;
        var val_4;
        val_1 = this;
        val_2 = 0;
        goto label_0;
        label_8:
        val_3 = 0;
        if(0 > 丈丘丝一丗下丈丐不)
        {
            goto label_3;
        }
        
        var val_1 = this.丗世上丘东下丘丑世 + (val_3 * 12);
        if(((val_3 * 12) + this.丗世上丘东下丘丑世 + 40) >= 丈丘丝一丗下丈丐不)
        {
            goto label_6;
        }
        
        label_3:
        val_2 = 1;
        label_0:
        val_3 = this.丗世上丘东下丘丑世;
        if(val_2 < this.丗世上丘东下丘丑世.Length)
        {
            goto label_8;
        }
        
        val_4 = 0;
        return (int)val_4;
        label_6:
        val_1 = this.丗世上丘东下丘丑世;
        var val_2 = 12;
        val_2 = val_1 + (val_3 * val_2);
        val_4 = mem[(val_3 * 12) + this.丗世上丘东下丘丑世 + 32];
        val_4 = (val_3 * 12) + this.丗世上丘东下丘丑世 + 32;
        return (int)val_4;
    }

}
