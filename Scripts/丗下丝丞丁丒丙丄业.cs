using UnityEngine;
private class BonusBankViewItem.丗下丝丞丁丒丙丄业 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    public BonusBankViewItem.丗下丝丞丁丒丙丄业()
    {
    
    }
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        var val_5;
        七世丌专丙三万七丘 val_7;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.weapon, 丏业丟一东丂东丘丛:  true);
        val_5 = null;
        val_5 = null;
        if((BonusBankViewItem.丗下丝丞丁丒丙丄业.<>c.<>9__1_0) == null)
        {
            goto label_6;
        }
        
        label_20:
        丑一丞且专世丆丈丛.descriptionLabels.ForEach(action:  BonusBankViewItem.丗下丝丞丁丒丙丄业.<>c.<>9__1_0);
        System.Collections.Generic.List<System.String> val_2 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Collections.Generic.List<System.String>>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Wears");
        if((val_2 != null) && (val_2.Count > 1))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._moreLabel, 丏业丟一东丂东丘丛:  true);
            val_7 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
            val_7 = 0;
        }
        
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  val_7);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  true);
        return;
        label_6:
        BonusBankViewItem.丗下丝丞丁丒丙丄业.<>c.<>9__1_0 = new System.Action<UILabel>(object:  BonusBankViewItem.丗下丝丞丁丒丙丄业.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丗下丝丞丁丒丙丄业.<>c::丒丕与下且且丐上丈(UILabel 七丐丞丑丑丕世丙七));
        if(丑一丞且专世丆丈丛.descriptionLabels != null)
        {
            goto label_20;
        }
        
        goto label_20;
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.丕丐下七丂丆下七丐().gameObject, 丏业丟一东丂东丘丛:  true);
        string val_5 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Collections.Generic.List<System.String>>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Wears").Item[0];
        UnityEngine.Texture val_7 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_5, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_5), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(丑一丞且专世丆丈丛.丕丐下七丂丆下七丐() != null)
        {
                return;
        }
    
    }
    protected override void 丒一丏丄丝且丑万丏(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_7;
        if(丑一丞且专世丆丈丛.InappBonusParameters == null)
        {
                return;
        }
        
        if((丑一丞且专世丆丈丛.InappBonusParameters.ContainsKey(key:  "action")) == false)
        {
                return;
        }
        
        object val_5 = 丑一丞且专世丆丈丛.InappBonusParameters.Item["action"];
        if(val_5 != null)
        {
                val_5 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.bonusViewHeader, 丕丗丘丑丛与丑业丒:  Rilisoft.Offers.丁且丕专万丈丒丏丗.丈七下丗万七不不一(丗丟丁丐与下丙丕丛:  val_7, 丐丁不丆丘丂丐丈丆:  0));
    }

}
