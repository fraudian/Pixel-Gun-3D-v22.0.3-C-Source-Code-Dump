using UnityEngine;
[Serializable]
internal class DailyTierProgress.DailyTierOffersSettingKey : IEquatable<Progress.DailyTierProgress.DailyTierOffersSettingKey>
{
    // Fields
    private const char SEPARATOR = '\x5f';
    private Rilisoft.丝丑丂丛万丐丈丘且 _costContainer;
    private Rilisoft.丝丑丂丛万丐丈丘且 _indexContainer;
    private string <Raw>k__BackingField;
    
    // Properties
    internal int Cost { get; set; }
    internal int Index { get; set; }
    internal string Raw { get; set; }
    
    // Methods
    internal int get_Cost()
    {
    
    }
    private void set_Cost(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this._costContainer = val_1;
        mem[1152921541064380120] = val_1.上万三丆专丏丒丗业;
    }
    internal int get_Index()
    {
    
    }
    private void set_Index(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this._indexContainer = val_1;
        mem[1152921541064604136] = val_1.上万三丆专丏丒丗业;
    }
    internal string get_Raw()
    {
        return (string)this.<Raw>k__BackingField;
    }
    private void set_Raw(string 丙业与丙丗丝不丈东)
    {
        this.<Raw>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal DailyTierProgress.DailyTierOffersSettingKey()
    {
    
    }
    internal DailyTierProgress.DailyTierOffersSettingKey(string 丞丕丒专一下丙业上)
    {
        string val_8;
        int val_3 = 0;
        char[] val_1 = new char[1];
        val_1[0] = '_';
        val_8 = 丞丕丒专一下丙业上.Split(separator:  val_1);
        if(val_2.Length < 2)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8[0], 丙业与丙丗丝不丈东: out  val_3)) != false)
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_5 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            this._costContainer = val_5;
            mem[1152921541065121768] = val_5.上万三丆专丏丒丗业;
        }
        
        val_8 = val_8[1];
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8, 丙业与丙丗丝不丈东: out  val_3)) != false)
        {
                Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
            this._indexContainer = val_7;
            mem[1152921541065121784] = val_7.上万三丆专丏丒丗业;
        }
        
        this.<Raw>k__BackingField = 丞丕丒专一下丙业上;
    }
    internal DailyTierProgress.DailyTierOffersSettingKey(int 丗下一不丘丑丅业且, int 丞世不丒下上上丝丑)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丗下一不丘丑丅业且);
        this._costContainer = val_1;
        mem[1152921541065303432] = val_1.上万三丆专丏丒丗业;
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
        this._indexContainer = val_2;
        mem[1152921541065303448] = val_2.上万三丆专丏丒丗业;
        string[] val_3 = new string[2];
        val_3[0] = this._costContainer.ToString();
        val_3[1] = this._indexContainer.ToString();
        this.<Raw>k__BackingField = System.String.Join(separator:  95, value:  val_3);
    }
    public override string ToString()
    {
        return (string)this.<Raw>k__BackingField;
    }
    public bool Equals(Progress.DailyTierProgress.DailyTierOffersSettingKey 丘丛丏丘丝七世七丅)
    {
        var val_2;
        if(丘丛丏丘丝七世七丅 == null)
        {
            goto label_2;
        }
        
        if(this == 丘丛丏丘丝七世七丅)
        {
            goto label_1;
        }
        
        if(this._costContainer == 丘丛丏丘丝七世七丅._costContainer)
        {
                var val_1 = (this._indexContainer == 丘丛丏丘丝七世七丅._indexContainer) ? 1 : 0;
            return (bool)val_2;
        }
        
        label_2:
        val_2 = 0;
        return (bool)val_2;
        label_1:
        val_2 = 1;
        return (bool)val_2;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        System.Type val_8;
        DailyTierOffersSettingKey val_9;
        var val_10;
        val_9 = 万且万且丑丗且丌丆;
        if(val_9 == null)
        {
            goto label_1;
        }
        
        if(this == val_9)
        {
            goto label_2;
        }
        
        val_8 = val_9.GetType();
        if((System.Type.op_Inequality(left:  val_8, right:  this.GetType())) == false)
        {
            goto label_5;
        }
        
        label_1:
        val_10 = 0;
        return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9 = 0);
        label_2:
        val_10 = 1;
        return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9);
        label_5:
        val_10 = this;
        return (bool)this.Equals(丘丛丏丘丝七世七丅:  val_9);
    }
    public override int GetHashCode()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_2 = this._indexContainer;
        val_2 = (this._costContainer * 397) ^ val_2;
        return (int)val_2;
    }

}
