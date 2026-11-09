using UnityEngine;
internal sealed class 丕丞丞且丄三丐丝丘 : 丞丘丟丝丗丒三丛丁
{
    // Methods
    internal override void 三丛丁丆东世丁丏三()
    {
        PGCompany.三东丏不丗世丅丌丄 val_1 = this.上万丈丒丅万丘丙一();
        if(val_1 == null)
        {
                return;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_1, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
    }
    internal override bool 丑丕丈丈不不且丑且()
    {
        var val_13;
        var val_14;
        val_13 = this;
        if(this.世丈丁业丛上丘丗丐() == null)
        {
                return (bool)val_14;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙().Equals(obj:  2)) == false)
        {
            goto label_5;
        }
        
        PGCompany.丛七世丟丐丒丁丕丆 val_5 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世();
        if(val_5 == null)
        {
                return (bool)val_14;
        }
        
        int val_6 = val_5.与丛一不东丟一业丙();
        goto label_9;
        label_5:
        PGCompany.东丕丐一与丏东丘下 val_8 = this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙();
        val_13 = val_8;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_8.Equals(obj:  3)) == false)
        {
            goto label_13;
        }
        
        PGCompany.丛七世丟丐丒丁丕丆 val_10 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世();
        if(val_10 == null)
        {
                return (bool)val_14;
        }
        
        label_9:
        var val_12 = (val_10.与丝专丑下丞丐丞丒() > 0) ? 1 : 0;
        return (bool)val_14;
        label_13:
        val_14 = 0;
        return (bool)val_14;
    }
    internal override string 丛丂丄下七东下七世()
    {
        var val_6;
        int val_7;
        val_6 = this;
        if((val_6 & 1) != 0)
        {
                val_6 = this.世丈丁业丛上丘丗丐();
            string val_5 = System.String.Format(format:  "{0}:{1}", arg0:  this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙(), arg1:  val_6.丏与丌丈丟万专丕丞());
            return (string)val_7;
        }
        
        val_7 = System.String.alignConst;
        return (string)val_7;
    }
    public override UnityEngine.Texture 丑东丐下专丞丕丘世()
    {
        return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/gears");
    }
    public override UnityEngine.Texture 三丗一丄不丆不丏三()
    {
        return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/gears");
    }
    public override string 七业丑不七丐业丟丂()
    {
        return "### надо или нет";
    }
    public override string 东且丏丆万与东丙万()
    {
        return "### надо или нет";
    }
    public override string 不丑不与丟丛丏丘丅()
    {
        return (string)this.世丈丁业丛上丘丗丐().丏与丌丈丟万专丕丞().ToString();
    }
    private PGCompany.三东丏不丗世丅丌丄 上万丈丒丅万丘丙一()
    {
        PGCompany.三东丏不丗世丅丌丄 val_18;
        var val_19;
        System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, System.Int32> val_20;
        var val_21;
        丟三丁与丞丘一东丄 val_22;
        val_18 = this;
        if(this.世丈丁业丛上丘丗丐() == null)
        {
                return (PGCompany.三东丏不丗世丅丌丄)val_19;
        }
        
        if(this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙() != 3)
        {
                val_19 = 0;
            if(this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙() != 2)
        {
                return (PGCompany.三东丏不丗世丅丌丄)val_19;
        }
        
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙().Equals(obj:  2)) == false)
        {
            goto label_9;
        }
        
        System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, System.Int32> val_9 = null;
        val_20 = val_9;
        val_9 = new System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, System.Int32>();
        val_21 = 1152921536594336608;
        val_22 = 5;
        goto label_11;
        label_9:
        PGCompany.东丕丐一与丏东丘下 val_11 = this.世丈丁业丛上丘丗丐().不业丙丒丂丞下丆丙();
        val_18 = val_11;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_11.Equals(obj:  3)) == false)
        {
            goto label_15;
        }
        
        System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, System.Int32> val_13 = null;
        val_20 = val_13;
        val_13 = new System.Collections.Generic.Dictionary<丟三丁与丞丘一东丄, System.Int32>();
        val_21 = 1152921536594336608;
        val_22 = 7;
        label_11:
        val_13.Add(key:  val_22, value:  1);
        val_18 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  PGCompany.专丆上世丏丅且丕丑.丆下丒万丙丅丘三丈(丑丁专世丛丏上丂不:  val_13));
        if(val_18 == null)
        {
                return (PGCompany.三东丏不丗世丅丌丄)val_19;
        }
        
        var val_17 = ((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  val_18)) != true) ? (val_18) : 0;
        return (PGCompany.三东丏不丗世丅丌丄)val_19;
        label_15:
        val_19 = 0;
        return (PGCompany.三东丏不丗世丅丌丄)val_19;
    }
    public 丕丞丞且丄三丐丝丘()
    {
    
    }

}
