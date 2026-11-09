using UnityEngine;
private class BonusBankViewItem.丄丐七且专下丙东业 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    public BonusBankViewItem.丄丐七且专下丙东业()
    {
        val_1 = new System.Object();
    }
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        七世丌专丙三万七丘 val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.gadget, 丏业丟一东丂东丘丛:  true);
        InappRememberedBonus val_3 = 一下丛与丛丛万万丏.丑七不且上丗丁一世().三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  丑一丞且专世丆丈丛.InappBonusParameters);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5583"));
        System.Collections.Generic.List<System.String> val_6 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Collections.Generic.List<System.String>>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Royale");
        if((val_6 != null) && (val_6.Count > 1))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._moreLabel, 丏业丟一东丂东丘丛:  true);
            val_8 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
            val_8 = 0;
        }
        
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  val_8);
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_39;
        string val_40;
        System.Object[] val_41;
        System.Collections.Generic.List<System.String> val_2 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Collections.Generic.List<System.String>>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Royale");
        val_39 = 1152921516934571616;
        int val_3 = val_2.Count;
        if(val_3 == 1)
        {
            goto label_3;
        }
        
        if(val_3 == 2)
        {
            goto label_4;
        }
        
        if(val_3 != 3)
        {
            goto label_5;
        }
        
        UIBasicSprite val_4 = 丑一丞且专世丆丈丛.丌一丕丏丟丑丟东且();
        val_40 = val_2.Item[0];
        UnityEngine.Texture val_8 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_2.Item[0], 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_40), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        UIBasicSprite val_9 = 丑一丞且专世丆丈丛.下下下丛与上丘丗世();
        UnityEngine.Texture val_13 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_2.Item[1], 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_2.Item[1]), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_41 = 丑一丞且专世丆丈丛.下与丏丆丝丁丙丟专();
        val_39 = val_2.Item[2];
        UnityEngine.Texture val_18 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_39, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_2.Item[2]), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_41 != null)
        {
                return;
        }
        
        return;
        label_4:
        UIBasicSprite val_19 = 丑一丞且专世丆丈丛.丌一丕丏丟丑丟东且();
        val_40 = val_2.Item[0];
        UnityEngine.Texture val_23 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_2.Item[0], 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_40), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        UIBasicSprite val_24 = 丑一丞且专世丆丈丛.下下下丛与上丘丗世();
        val_41 = 丑一丞且专世丆丈丛.下与丏丆丝丁丙丟专();
        val_39 = val_2.Item[1];
        UnityEngine.Texture val_29 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_39, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_2.Item[1]), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_41 != null)
        {
                return;
        }
        
        return;
        label_3:
        UIBasicSprite val_30 = 丑一丞且专世丆丈丛.丌一丕丏丟丑丟东且();
        val_39 = 丑一丞且专世丆丈丛.下下下丛与上丘丗世();
        val_40 = 1152921516223708000;
        UnityEngine.Texture val_35 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_2.Item[0], 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_2.Item[0]), 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_41 = 丑一丞且专世丆丈丛.下与丏丆丝丁丙丟专();
        if(val_41 != null)
        {
                return;
        }
        
        return;
        label_5:
        object[] val_37 = new object[1];
        val_41 = val_37;
        val_41[0] = val_2.Count;
        UnityEngine.Debug.LogErrorFormat(format:  "RoyaleBonusUIFiller.FillCore: unsupported number of royale items {0}", args:  val_37);
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
