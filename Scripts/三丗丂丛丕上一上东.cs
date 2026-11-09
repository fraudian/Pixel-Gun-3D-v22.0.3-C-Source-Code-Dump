using UnityEngine;
private class BonusBankViewItem.三丗丂丛丕上一上东 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    public BonusBankViewItem.三丗丂丛丕上一上东()
    {
    
    }
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        var val_2;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.weapon, 丏业丟一东丂东丘丛:  true);
        val_2 = null;
        val_2 = null;
        if((BonusBankViewItem.三丗丂丛丕上一上东.<>c.<>9__1_0) == null)
        {
            goto label_6;
        }
        
        label_13:
        丑一丞且专世丆丈丛.descriptionLabels.ForEach(action:  BonusBankViewItem.三丗丂丛丕上一上东.<>c.<>9__1_0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  true);
        return;
        label_6:
        BonusBankViewItem.三丗丂丛丕上一上东.<>c.<>9__1_0 = new System.Action<UILabel>(object:  BonusBankViewItem.三丗丂丛丕上一上东.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.三丗丂丛丕上一上东.<>c::丒丕与下且且丐上丈(UILabel 七丐丞丑丑丕世丙七));
        if(丑一丞且专世丆丈丛.descriptionLabels != null)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        var val_12;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.丕丐下七丂丆下七丐().gameObject, 丏业丟一东丂东丘丛:  true);
        string val_4 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.String>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Weapon");
        bool val_5 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4);
        string val_6 = (val_5 != true) ? 0 : (val_4);
        if(val_5 != true)
        {
                UnityEngine.Texture val_8 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_6, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_6), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            if(丑一丞且专世丆丈丛.丕丐下七丂丆下七丐() != null)
        {
                return;
        }
        
            return;
        }
        
        new System.Exception() = new System.Exception(message:  "weapon not found in bonus parameters");
        val_12 = new System.Exception();
        if(0 == 1)
        {
                if((null & 1) != 0)
        {
                object[] val_11 = new object[1];
            val_11[0] = null;
            UnityEngine.Debug.LogErrorFormat(format:  "Exception in RedWeaponBonusUIFiller.SetIconCore: {0}", args:  val_11);
            return;
        }
        
            mem[8] = null;
            val_12 = 8;
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
