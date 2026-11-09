using UnityEngine;
internal sealed class 丕丑丙丑丙东丌丘丕
{
    // Fields
    internal static readonly int 丞丁丏且与丒丐业下;
    private static readonly 丕丑丙丑丙东丌丘丕 七丒世丒且丟东丕丟;
    private static readonly 丕丑丙丑丙东丌丘丕 一东丐丒丏丙不不丅;
    private static readonly 丕丑丙丑丙东丌丘丕 丗专丑丙万不三丟丛;
    private static readonly 丕丑丙丑丙东丌丘丕 丌丛丂万丘丝下丈业;
    private static readonly 丕丑丙丑丙东丌丘丕 丙业丝不东下万一丒;
    private static readonly 丕丑丙丑丙东丌丘丕 丟东三丆丙丟丙专专;
    private Rilisoft.丝丑丂丛万丐丈丘且 丈丘丝一丗下丈丐不;
    private ItemRarity 丈下丑丆上丏丗丈专;
    
    // Properties
    internal int 万丄丅丛下丐丒丞上 { get; }
    internal ItemRarity 且丐丟专丛丗丏上丙 { get; }
    internal float 世丆东丝丒丒丘丗丐 { get; }
    internal bool 丂一东专丘七丄丝丆 { get; }
    
    // Methods
    internal int 丈一下下丞世三丑丄()
    {
    
    }
    internal ItemRarity 七东与丄丕丁丛世三()
    {
        return (ItemRarity)this.丈下丑丆上丏丗丈专;
    }
    internal 丕丑丙丑丙东丌丘丕()
    {
    
    }
    internal 丕丑丙丑丙东丌丘丕(string 丌且专不丙丕专丅万)
    {
        object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌且专不丙丕专丅万);
    }
    internal 丕丑丙丑丙东丌丘丕(object 丌且专不丙丕专丅万)
    {
        System.IFormatProvider val_10;
        object val_1 = 0;
        object val_6 = 0;
        if((0.TryGetValue(key:  "l", value: out  val_1)) == false)
        {
            goto label_4;
        }
        
        val_10 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        int val_5 = System.Convert.ToInt32(value:  val_1, provider:  System.Globalization.CultureInfo.InvariantCulture);
        this.丈丘丝一丗下丈丐不 = 0;
        mem[1152921539649370136] = 0;
        if(1 != 0)
        {
            goto label_9;
        }
        
        goto label_13;
        label_4:
        UnityEngine.Debug.LogError(message:  "WeaponUpgradeV9: ErrorParse Percent");
        if(1 == 0)
        {
            goto label_13;
        }
        
        label_9:
        label_13:
        if((0.TryGetValue(key:  "r", value: out  val_6)) != false)
        {
                val_10 = System.Globalization.CultureInfo.InvariantCulture;
            this.丈下丑丆上丏丗丈专 = System.Convert.ToInt32(value:  val_6, provider:  val_10);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "WeaponUpgradeV9: ErrorParse Rarity");
    }
    internal 丕丑丙丑丙东丌丘丕(int 丘丈不不下丙万丌专, ItemRarity 丏丆丐丑专与丄丘丞)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.丈下丑丆上丏丗丈专 = 丏丆丐丑专与丄丘丞;
        this.丈丘丝一丗下丈丐不 = 0;
        mem[1152921539649498520] = 0;
    }
    internal static 丕丑丙丑丙东丌丘丕 丕丝丑一丕上丒不丟(ItemRarity 丈下丑丆上丏丗丈专)
    {
        丕丑丙丑丙东丌丘丕 val_3;
        if(丈下丑丆上丏丗丈专 <= 5)
        {
                var val_2 = 106014460 + (丈下丑丆上丏丗丈专) << 2;
            val_2 = val_2 + 106014460;
        }
        else
        {
                丕丑丙丑丙东丌丘丕 val_1 = null;
            val_3 = val_1;
            val_1 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  丈下丑丆上丏丗丈专);
            return (丕丑丙丑丙东丌丘丕);
        }
    
    }
    public override string ToString()
    {
        return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丁丕上三丕丌丟丗丙());
    }
    internal System.Collections.Generic.Dictionary<string, int> 丁丕上三丕丌丟丗丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        val_1.set_Item(key:  "l", value:  this.丈丘丝一丗下丈丐不);
        val_1.set_Item(key:  "r", value:  this.丈下丑丆上丏丗丈专);
        return val_1;
    }
    internal float 专丒东业丐东下丝丅()
    {
        null = null;
        float val_1 = (float)丕丑丙丑丙东丌丘丕.丞丁丏且与丒丐业下;
        val_1 = (float)this.丈丘丝一丗下丈丐不 / val_1;
        return (float)val_1;
    }
    internal bool 丈专七丐上一业世丕()
    {
        return (bool)(this.丈丘丝一丗下丈丐不 > 64) ? 1 : 0;
    }
    private static 丕丑丙丑丙东丌丘丕()
    {
        丕丑丙丑丙东丌丘丕.丞丁丏且与丒丐业下 = 99;
        丕丑丙丑丙东丌丘丕.七丒世丒且丟东丕丟 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  0);
        丕丑丙丑丙东丌丘丕.一东丐丒丏丙不不丅 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  1);
        丕丑丙丑丙东丌丘丕.丗专丑丙万不三丟丛 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  2);
        丕丑丙丑丙东丌丘丕.丌丛丂万丘丝下丈业 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  3);
        丕丑丙丑丙东丌丘丕.丙业丝不东下万一丒 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  4);
        丕丑丙丑丙东丌丘丕.丟东三丆丙丟丙专专 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  5);
    }

}
