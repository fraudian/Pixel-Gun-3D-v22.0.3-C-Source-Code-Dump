using UnityEngine;
internal sealed class 世丑万丝丒与丄不且 : 东上丛丂丅下丄七丝
{
    // Methods
    internal override void 下丌业业丐丘丐丘三()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().业不丗丙丄丗下与丌(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void 世丑万丝丒与丄不且::丌丁丞丅丒丂丒丘三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丌丁丞丅丒丂丒丘三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丑与七丑丒不丏下专(丅专与丒丈丗丒丘丌:  1);
    }
    internal override void 不与丞下业丑丒丙万()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().七丙丆丐业丝与丙丌(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void 世丑万丝丒与丄不且::丌丁丞丅丒丂丒丘三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal override bool 丑上上丟丂丈丛丏丑()
    {
        var val_5;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与() == null)
        {
            goto label_4;
        }
        
        val_16 = null;
        val_16 = null;
        List.Enumerator<T> val_3 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
        val_17 = 0;
        goto label_9;
        label_18:
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(((val_6 != null) && (val_6 != null)) && (val_6.七丑丌专丒上丒丙七() != null))
        {
                丕丑丙丑丙东丌丘丕 val_8 = val_6.七丑丌专丒上丒丙七();
            var val_10 = (val_8.丈丘丝一丗下丈丐不 >= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
        }
        else
        {
                val_18 = 1;
        }
        
        val_17 = val_17 + val_18;
        label_9:
        if(((-1202536464) & 1) != 0)
        {
            goto label_18;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_26;
        label_4:
        val_17 = 0;
        label_26:
        val_19 = null;
        val_19 = null;
        return (bool)(val_17 >= WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count) ? 1 : 0;
    }
    public 世丑万丝丒与丄不且()
    {
    
    }

}
