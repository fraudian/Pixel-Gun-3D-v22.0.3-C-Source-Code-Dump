using UnityEngine;
internal sealed class 丂三且丛一丕丈丅下
{
    // Fields
    internal static readonly int 丞丁丏且与丒丐业下;
    private static readonly 丂三且丛一丕丈丅下 七丒世丒且丟东丕丟;
    private static readonly 丂三且丛一丕丈丅下 一东丐丒丏丙不不丅;
    private static readonly 丂三且丛一丕丈丅下 丗专丑丙万不三丟丛;
    private static readonly 丂三且丛一丕丈丅下 丌丛丂万丘丝下丈业;
    private static readonly 丂三且丛一丕丈丅下 丙业丝不东下万一丒;
    private static readonly 丂三且丛一丕丈丅下 丟东三丆丙丟丙专专;
    private Rilisoft.丝丑丂丛万丐丈丘且 业万上丆丐丞且丒七;
    private Rilisoft.丝丑丂丛万丐丈丘且 丈丘丝一丗下丈丐不;
    private ItemRarity 丈下丑丆上丏丗丈专;
    
    // Properties
    internal int 丌丄丕丌丑东丆丏丆 { get; }
    internal int 万丄丅丛下丐丒丞上 { get; }
    internal ItemRarity 且丐丟专丛丗丏上丙 { get; }
    internal float 世丆东丝丒丒丘丗丐 { get; }
    internal bool 丂一东专丘七丄丝丆 { get; }
    
    // Methods
    internal int 丒东万丘丙世一丕丝()
    {
    
    }
    internal int 丈一下下丞世三丑丄()
    {
    
    }
    internal ItemRarity 七东与丄丕丁丛世三()
    {
        return (ItemRarity)this.丈下丑丆上丏丗丈专;
    }
    internal 丕丑丙丑丙东丌丘丕 丛丂三丁世万世上七(int 下丛丐七七丐上丌丂 = 2147483647)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_9 = null;
        val_9 = null;
        System.Int32[] val_1 = ExpController.LevelsForTiers + (((long)(int)(this.业万上丆丐丞且丒七)) << 2);
        if(this.业万上丆丐丞且丒七 <= 5)
        {
                val_10 = null;
            val_10 = null;
            System.Int32[] val_2 = ExpController.LevelsForTiers + (((long)(int)(W9)) << 2);
            val_11 = ((ExpController.LevelsForTiers + ((long)(int)(W9)) << 2) + 32) - 1;
        }
        else
        {
                val_11 = 45;
        }
        
        val_12 = null;
        val_12 = null;
        float val_8 = (float)this.丈丘丝一丗下丈丐不;
        val_8 = val_8 / (float)丂三且丛一丕丈丅下.丞丁丏且与丒丐业下;
        float val_9 = (float)(ExpController.LevelsForTiers + ((long)(int)(this.业万上丆丐丞且丒七)) << 2) + 32;
        val_8 = val_8 * ((float)45 - ((ExpController.LevelsForTiers + ((long)(int)(this.业万上丆丐丞且丒七)) << 2) + 32));
        val_9 = val_8 + val_9;
        return (丕丑丙丑丙东丌丘丕)new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.RoundToInt(f:  val_9), b:  下丛丐七七丐上丌丂), 丏丆丐丑专与丄丘丞:  (this.丈下丑丆上丏丗丈专 == 1) ? 2 : this.丈下丑丆上丏丗丈专);
    }
    internal 丂三且丛一丕丈丅下()
    {
    
    }
    internal 丂三且丛一丕丈丅下(string 丌且专不丙丕专丅万)
    {
        object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
    }
    internal 丂三且丛一丕丈丅下(object 丌且专不丙丕专丅万)
    {
        System.IFormatProvider val_15;
        System.IFormatProvider val_16;
        object val_1 = 0;
        object val_11 = 0;
        object val_6 = 0;
        if((0.TryGetValue(key:  "t", value: out  val_1)) == false)
        {
            goto label_4;
        }
        
        val_15 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        val_16 = System.Globalization.CultureInfo.InvariantCulture;
        int val_5 = System.Convert.ToInt32(value:  val_1, provider:  val_16);
        this.业万上丆丐丞且丒七 = 0;
        mem[1152921539647754104] = 0;
        if(1 != 0)
        {
            goto label_9;
        }
        
        goto label_13;
        label_4:
        UnityEngine.Debug.LogError(message:  "WeaponUpgradeV8: ErrorParse Tier");
        if(1 == 0)
        {
            goto label_13;
        }
        
        label_9:
        label_13:
        if((0.TryGetValue(key:  "l", value: out  val_6)) == false)
        {
            goto label_14;
        }
        
        val_15 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        val_16 = System.Globalization.CultureInfo.InvariantCulture;
        int val_10 = System.Convert.ToInt32(value:  val_6, provider:  val_16);
        this.丈丘丝一丗下丈丐不 = 0;
        mem[1152921539647754120] = 0;
        if(1 != 0)
        {
            goto label_19;
        }
        
        goto label_23;
        label_14:
        UnityEngine.Debug.LogError(message:  "WeaponUpgradeV8: ErrorParse Percent");
        if(1 == 0)
        {
            goto label_23;
        }
        
        label_19:
        label_23:
        if((0.TryGetValue(key:  "r", value: out  val_11)) != false)
        {
                val_15 = System.Globalization.CultureInfo.InvariantCulture;
            this.丈下丑丆上丏丗丈专 = System.Convert.ToInt32(value:  val_11, provider:  val_15);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "WeaponUpgradeV8: ErrorParse Rarity");
    }
    internal 丂三且丛一丕丈丅下(int 丘丈不不下丙万丌专, ItemRarity 丏丆丐丑专与丄丘丞)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.业万上丆丐丞且丒七 = 0;
        mem[1152921539647886584] = 0;
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丈下丑丆上丏丗丈专 = 丏丆丐丑专与丄丘丞;
        this.丈丘丝一丗下丈丐不 = 0;
        mem[1152921539647886600] = 0;
    }
    internal 丂三且丛一丕丈丅下(int 丅丝丝世丗丏丅丌丄, int 丘丈不不下丙万丌专, ItemRarity 丏丆丐丑专与丄丘丞)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.业万上丆丐丞且丒七 = 0;
        mem[1152921539648006776] = 0;
        int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丈下丑丆上丏丗丈专 = 丏丆丐丑专与丄丘丞;
        this.丈丘丝一丗下丈丐不 = 0;
        mem[1152921539648006792] = 0;
    }
    internal static 丂三且丛一丕丈丅下 丕丝丑一丕上丒不丟(ItemRarity 丈下丑丆上丏丗丈专)
    {
        丂三且丛一丕丈丅下 val_3;
        if(丈下丑丆上丏丗丈专 <= 5)
        {
                var val_2 = 106018312 + (丈下丑丆上丏丗丈专) << 2;
            val_2 = val_2 + 106018312;
        }
        else
        {
                丂三且丛一丕丈丅下 val_1 = null;
            val_3 = val_1;
            val_1 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  丈下丑丆上丏丗丈专);
            return (丂三且丛一丕丈丅下);
        }
    
    }
    public override string ToString()
    {
        return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丁丕上三丕丌丟丗丙());
    }
    internal System.Collections.Generic.Dictionary<string, int> 丁丕上三丕丌丟丗丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        val_1.set_Item(key:  "t", value:  this.业万上丆丐丞且丒七);
        val_1.set_Item(key:  "l", value:  this.丈丘丝一丗下丈丐不);
        val_1.set_Item(key:  "r", value:  this.丈下丑丆上丏丗丈专);
        return val_1;
    }
    internal float 专丒东业丐东下丝丅()
    {
        null = null;
        float val_1 = (float)丂三且丛一丕丈丅下.丞丁丏且与丒丐业下;
        val_1 = (float)this.丈丘丝一丗下丈丐不 / val_1;
        return (float)val_1;
    }
    internal bool 丈专七丐上一业世丕()
    {
        return (bool)(this.丈丘丝一丗下丈丐不 > 64) ? 1 : 0;
    }
    private static 丂三且丛一丕丈丅下()
    {
        丂三且丛一丕丈丅下.丞丁丏且与丒丐业下 = 99;
        丂三且丛一丕丈丅下.七丒世丒且丟东丕丟 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  0);
        丂三且丛一丕丈丅下.一东丐丒丏丙不不丅 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  1);
        丂三且丛一丕丈丅下.丗专丑丙万不三丟丛 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  2);
        丂三且丛一丕丈丅下.丌丛丂万丘丝下丈业 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  3);
        丂三且丛一丕丈丅下.丙业丝不东下万一丒 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  4);
        丂三且丛一丕丈丅下.丟东三丆丙丟丙专专 = new 丂三且丛一丕丈丅下(丅丝丝世丗丏丅丌丄:  0, 丘丈不不下丙万丌专:  0, 丏丆丐丑专与丄丘丞:  5);
    }

}
