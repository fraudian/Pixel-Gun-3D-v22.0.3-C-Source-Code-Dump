using UnityEngine;
internal class 三丈丟与丏丘丈丐万
{
    // Fields
    private Rilisoft.丝丑丂丛万丐丈丘且 七丏丑上三世丈上丙;
    private Rilisoft.丝丑丂丛万丐丈丘且 世不东丌东丌丏东业;
    internal 三丅丁丗丗丝丂万且 三丐三丞丘丕不丒专;
    internal 丕丈丏丝丗下丟丅丂 丙丗丕丟七丟上丈丌;
    private int 一丒不三丁丗万专东;
    internal int[] 万丅丈东丙丑丆丑丅;
    internal bool 万丒丟业丗业丑丝七;
    private bool <丒七与丄与丝丕丄丐>k__BackingField;
    
    // Properties
    internal bool 丐丙东丏丂业与业丂 { get; }
    internal string 丞不丞下丒丗丛丗丐 { get; }
    internal int 下丌丒丑丆丘七万丌 { get; set; }
    internal int 丕丒丅丈丌丆丝丝丛 { get; set; }
    internal bool 与三七上不丆丁专丐 { get; set; }
    
    // Methods
    internal bool 七丝丈东丈丕丐与丗()
    {
        return (bool)(this.丙丗丕丟七丟上丈丌 != 0) ? 1 : 0;
    }
    internal string 丈专世七丗三丙丝下()
    {
        string val_1;
        if(this.丙丗丕丟七丟上丈丌 != null)
        {
                return this.丙丗丕丟七丟上丈丌.业上丙丞丐丄丆丅七();
        }
        
        if(this.三丐三丞丘丕不丒专 != null)
        {
                val_1 = this.三丐三丞丘丕不丒专.<丗丐下三上世丂丅三>k__BackingField;
            return (string)val_1;
        }
        
        val_1 = "";
        return (string)val_1;
    }
    internal int 东东丄丅丐一丙一业()
    {
    
    }
    internal void 上丕丅丛不七业丙丘(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.七丏丑上三世丈上丙 = 0;
        mem[1152921539674276840] = 0;
    }
    internal int 下世万丆丛专丒丑丙()
    {
    
    }
    internal void 业丑丝丐丟丞丟且上(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        this.世不东丌东丌丏东业 = 0;
        mem[1152921539674500856] = 0;
    }
    internal void 丏丛丝丄丟丒不一不()
    {
        var val_2;
        int val_3;
        if(this.万丒丟业丗业丑丝七 == false)
        {
                return;
        }
        
        val_2 = 0;
        goto label_1;
        label_11:
        var val_4 = 1;
        val_3 = this.万丅丈东丙丑丆丑丅.Length;
        if((UnityEngine.Random.Range(min:  1, max:  this.万丅丈东丙丑丆丑丅.Length)) >= val_3)
        {
                val_3 = this.万丅丈东丙丑丆丑丅.Length;
        }
        
        val_4 = val_4 - 1;
        this.万丅丈东丙丑丆丑丅[0] = this.万丅丈东丙丑丆丑丅[((long)(int)(val_1)) << 2];
        val_2 = val_4 + 1;
        this.万丅丈东丙丑丆丑丅[((long)(int)(val_1)) << 2] = this.万丅丈东丙丑丆丑丅[0];
        label_1:
        int val_5 = this.万丅丈东丙丑丆丑丅.Length;
        val_5 = val_5 - 1;
        if(val_2 < val_5)
        {
            goto label_11;
        }
        
        this.一丒不三丁丗万专东 = 0;
    }
    internal int 且三丌丝丄专下丌丘()
    {
        int val_2;
        int val_1 = this.一丒不三丁丗万专东 + 1;
        this.一丒不三丁丗万专东 = val_1;
        int val_2 = this.万丅丈东丙丑丆丑丅.Length;
        val_2 = val_2 - 1;
        if(val_1 > val_2)
        {
                this.丏丛丝丄丟丒不一不();
            val_2 = 0;
            this.一丒不三丁丗万专东 = 0;
        }
        else
        {
                val_2 = this.一丒不三丁丗万专东;
        }
        
        return (int)this.万丅丈东丙丑丆丑丅[((long)(int)(this.一丒不三丁丗万专东)) << 2];
    }
    internal bool 丄万上丈下丘丑丁丒()
    {
        return (bool)this.<丒七与丄与丝丕丄丐>k__BackingField;
    }
    internal void 上东万丒丁丑丄丈与(bool 丙业与丙丗丝不丈东)
    {
        this.<丒七与丄与丝丕丄丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public override string ToString()
    {
        三丅丁丗丗丝丂万且 val_3;
        var val_4;
        string val_5;
        val_3 = this.三丐三丞丘丕不丒专;
        if(val_3 != null)
        {
                val_3 = this.三丐三丞丘丕不丒专.<丙丝万丈丟丕丛丑丗>k__BackingField;
            val_4 = "unknown";
            var val_1 = ((this.三丐三丞丘丕不丒专.<丗丐下三上世丂丅三>k__BackingField) == null) ? (val_4) : this.三丐三丞丘丕不丒专.<丗丐下三上世丂丅三>k__BackingField;
            return val_5 + " " + (val_3 == 0) ? (val_4) : (val_3)((val_3 == 0) ? (val_4) : (val_3));
        }
        
        val_5 = "unknown";
        val_4 = val_5;
        return val_5 + " " + (val_3 == 0) ? (val_4) : (val_3)((val_3 == 0) ? (val_4) : (val_3));
    }
    public 三丈丟与丏丘丈丐万()
    {
        this.一丒不三丁丗万专东 = 0;
        this.万丒丟业丗业丑丝七 = true;
    }

}
