using UnityEngine;
internal class 丗丑一一丛丁上丏丆 : 丄世丕丈一丈东丆丐
{
    // Fields
    private System.Collections.Generic.Dictionary<int, int[]> 世万丆七七丅三丑丙;
    private int 丝丌丆业丝七丌丄丟;
    
    // Methods
    public 丗丑一一丛丁上丏丆(System.Collections.Generic.Dictionary<string, object> 丒丐丈下丛丛丒丈丏, 与七丙丌丈丅上丝不 丈丞丏三丒丁丗丘东)
    {
        this.世万丆七七丅三丑丙 = 丈丞丏三丒丁丗丘东.且专东丞丗丟丂且丞(丒丐丈下丛丛丒丈丏:  丒丐丈下丛丛丒丈丏);
        this.专与丐万七丞丐三丁();
    }
    internal override int 三七世丝不丑丅丈丆()
    {
        return (int)this.丝丌丆业丝七丌丄丟;
    }
    internal override int 丈丏一丌丗丂业丟丕(int 丈丘丝一丗下丈丐不, int 专世专丟丝丌与丘上)
    {
        var val_10;
        int val_11;
        val_10 = this;
        不七且丌丄丑世七丙[] val_3 = this.且丘丝丈业丞七丄丟();
        int val_4 = (this.丛丕丐丏丒一业专世(丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不)) + 1;
        int val_5 = UnityEngine.Mathf.Clamp(value:  专世专丟丝丌与丘上 + 1, min:  1, max:  val_3.Length);
        if((this.世万丆七七丅三丑丙.ContainsKey(key:  val_4)) == false)
        {
            goto label_5;
        }
        
        System.Int32[] val_7 = this.世万丆七七丅三丑丙.Item[val_4];
        if(val_5 <= val_7.Length)
        {
            goto label_8;
        }
        
        label_5:
        val_11 = 0;
        return val_11;
        label_8:
        val_10 = this.世万丆七七丅三丑丙.Item[val_4];
        int val_9 = val_5 - 1;
        val_11 = val_10[((long)(int)((val_5 - 1))) << 2];
        return val_11;
    }
    private void 专与丐万七丞丐三丁()
    {
        int val_4;
        var val_5;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32[]> val_9;
        var val_10;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_9 = this.世万丆七七丅三丑丙;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_9.GetEnumerator();
        goto label_2;
        label_10:
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        val_9;
        val_10 = 0;
        goto label_3;
        label_9:
        if((val_1.Contains(item:  val_4)) != true)
        {
                val_1.Add(item:  val_4);
        }
        
        val_10 = 1;
        label_3:
        if(val_10 < val_5)
        {
            goto label_9;
        }
        
        label_2:
        if(((-642753760) & 1) != 0)
        {
            goto label_10;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝丌丆业丝七丌丄丟 = val_1.Count;
    }

}
