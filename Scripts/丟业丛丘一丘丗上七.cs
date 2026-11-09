using UnityEngine;
internal class 丛专下与丟丑与丐丁.丟业丛丘一丘丗上七 : ICloneable, IEquatable<PGCompany.BM.丛专下与丟丑与丐丁.丟业丛丘一丘丗上七>
{
    // Fields
    internal int CellId;
    internal bool Opened;
    internal PGCompany.三东丏不丗世丅丌丄 Reward;
    internal PGCompany.三东丏不丗世丅丌丄 BuildReward;
    internal PGCompany.三东丏不丗世丅丌丄 Price;
    
    // Methods
    internal 丛专下与丟丑与丐丁.丟业丛丘一丘丗上七()
    {
    
    }
    internal 丛专下与丟丑与丐丁.丟业丛丘一丘丗上七(int 丝丌不东丕丒与丒丅, PGCompany.三东丏不丗世丅丌丄 丗七丟丈三不丕一三, PGCompany.三东丏不丗世丅丌丄 丂丄丟七丂丟丛丒三, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
    {
        val_1 = new System.Object();
        this.CellId = 丝丌不东丕丒与丒丅;
        this.Reward = val_1;
        this.BuildReward = 丂丄丟七丂丟丛丒三;
        this.Price = 丒世丘丘上丆丝东丞;
    }
    public object Clone()
    {
        PGCompany.三东丏不丗世丅丌丄 val_5;
        PGCompany.三东丏不丗世丅丌丄 val_6;
        PGCompany.三东丏不丗世丅丌丄 val_7;
        if(this.Reward != null)
        {
                val_5 = this.Reward.与下不与丐丈丁丈万();
        }
        else
        {
                val_5 = 0;
        }
        
        if(this.BuildReward != null)
        {
                val_6 = this.BuildReward.与下不与丐丈丁丈万();
        }
        else
        {
                val_6 = 0;
        }
        
        if(this.Price != null)
        {
                val_7 = this.Price.与下不与丐丈丁丈万();
        }
        else
        {
                val_7 = 0;
        }
        
        .CellId = this.CellId;
        .Reward = val_5;
        .BuildReward = val_6;
        .Price = val_7;
        .Opened = this.Opened;
        return (object)new 丛专下与丟丑与丐丁.丟业丛丘一丘丗上七();
    }
    public bool Equals(PGCompany.BM.丛专下与丟丑与丐丁.丟业丛丘一丘丗上七 丘丛丏丘丝七世七丅)
    {
        var val_5;
        if(丘丛丏丘丝七世七丅 == null)
        {
            goto label_5;
        }
        
        if(this == 丘丛丏丘丝七世七丅)
        {
            goto label_1;
        }
        
        if(this.CellId == 丘丛丏丘丝七世七丅.CellId)
        {
                var val_1 = (this.Opened == true) ? 1 : 0;
            val_1 = val_1 ^ ((丘丛丏丘丝七世七丅.Opened == true) ? 1 : 0);
            if(((val_1 & 1) == 0) && ((System.Object.Equals(objA:  this.Price, objB:  丘丛丏丘丝七世七丅.Price)) != false))
        {
                if((System.Object.Equals(objA:  this.Reward, objB:  丘丛丏丘丝七世七丅.Reward)) != false)
        {
                return System.Object.Equals(objA:  this.BuildReward, objB:  丘丛丏丘丝七世七丅.BuildReward);
        }
        
        }
        
        }
        
        label_5:
        val_5 = 0;
        return (bool)val_5;
        label_1:
        val_5 = 1;
        return (bool)val_5;
    }
    public override bool Equals(object 万且万且丑丗且丌丆)
    {
        System.Type val_8;
        丟业丛丘一丘丗上七 val_9;
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
        var val_8;
        var val_9;
        var val_10;
        int val_9 = this.CellId;
        val_8 = 0;
        int val_8 = this.Opened.GetHashCode();
        val_8 = (val_9 * 397) ^ val_8;
        val_9 = val_8 * 397;
        if(this.Price != null)
        {
                val_8 = public System.Int32 System.Object::GetHashCode();
            val_9 = this.Price.GetHashCode();
        }
        else
        {
                val_9 = 0;
        }
        
        val_9 = val_9 ^ val_9;
        if(this.Reward != null)
        {
                val_8 = public System.Int32 System.Object::GetHashCode();
            val_10 = this.Reward.GetHashCode();
        }
        else
        {
                val_10 = 0;
        }
        
        val_10 = val_10 ^ (val_9 * 397);
        if(this.BuildReward != null)
        {
                int val_7 = this.BuildReward.GetHashCode();
        }
        
        val_7 = val_7 ^ (val_10 * 397);
        return (int)val_7;
    }
    internal System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "i", value:  this.CellId.ToString());
        val_1.Add(key:  "o", value:  this.Opened);
        if(this.Reward == null)
        {
            goto label_3;
        }
        
        if(val_1 != null)
        {
            goto label_15;
        }
        
        label_16:
        label_15:
        val_1.Add(key:  "r", value:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  this.Reward));
        if(this.BuildReward == null)
        {
            goto label_7;
        }
        
        if(val_1 != null)
        {
            goto label_17;
        }
        
        label_18:
        label_17:
        val_1.Add(key:  "br", value:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  this.BuildReward));
        if(this.Price == null)
        {
            goto label_11;
        }
        
        if(val_1 != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        val_1.Add(key:  "p", value:  PGCompany.万丞丘与丕丞下万丌.丙业不丝丗丌丗世下(丈丄不七三万丄丁不:  this.Price));
        return val_1;
        label_3:
        if(val_1 != null)
        {
            goto label_15;
        }
        
        goto label_16;
        label_7:
        if(val_1 != null)
        {
            goto label_17;
        }
        
        goto label_18;
        label_11:
        if(val_1 != null)
        {
            goto label_19;
        }
        
        goto label_20;
    }

}
