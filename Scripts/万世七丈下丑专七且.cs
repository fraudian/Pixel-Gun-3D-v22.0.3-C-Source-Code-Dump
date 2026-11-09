using UnityEngine;
private class BonusBankViewItem.万世七丈下丑专七且 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        UnityEngine.Object val_21;
        var val_22;
        string val_23;
        UnityEngine.GameObject val_24;
        PGCompany.三东丏不丗世丅丌丄 val_25;
        val_21 = 丑一丞且专世丆丈丛;
        val_22 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._onlyBuyOnceBadge, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._tierBundleObj, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._tierBundlesTwoItems, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._tierBundlesThreeItems, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._tierBundlesFourItems, 丏业丟一东丂东丘丛:  false);
        val_23 = val_21.InappBonusParameters;
        if(val_23 == null)
        {
                return;
        }
        
        if((val_23.ContainsKey(key:  "offer-module")) == false)
        {
                return;
        }
        
        Rilisoft.丗下丙丅且丐丞丙世 val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        val_23 = val_23.Item["offer-id"];
        if(val_3 == null)
        {
            goto label_8;
        }
        
        if(val_23 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_23 == null)
        {
            goto label_12;
        }
        
        label_9:
        if(null != null)
        {
                val_23 = 0;
        }
        
        label_12:
        Rilisoft.业丙丘丆东丈丕丂丄 val_6 = val_3.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_23);
        if(val_6 == null)
        {
                return;
        }
        
        val_23 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        PGCompany.丒丌业一丕丘丐世专 val_10 = val_23.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  val_6.丏不丁丛丕丒丏丆丂());
        if(val_10 == null)
        {
                return;
        }
        
        val_24 = 丑一丞且专世丆丈丛._tierBundlesTwoItems;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  val_10);
        val_23 = val_10;
        if(val_23.Count != 2)
        {
                val_24 = 丑一丞且专世丆丈丛._tierBundlesThreeItems;
            val_23 = val_10;
            if(val_23.Count != 3)
        {
                val_24 = 丑一丞且专世丆丈丛._tierBundlesFourItems;
            if(val_10.Count != 4)
        {
            goto label_41;
        }
        
        }
        
        }
        
        val_21 = mem[丑一丞且专世丆丈丛._tierBundlesFourItems];
        label_41:
        if(val_21 == 0)
        {
                return;
        }
        
        val_25 = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  true);
        val_24 = 1152921526212668928;
        val_23 = 0;
        goto label_32;
        label_40:
        val_22 = val_21.transform.GetChild(index:  0).gameObject.GetComponent<PGCompany.InventoryItemView>();
        val_25 = val_10.Item[0];
        val_22.Setup(丈丄不七三万丄丁不:  val_25);
        val_23 = 1;
        label_32:
        if(val_23 < val_10.Count)
        {
            goto label_40;
        }
    
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
    
    }
    protected override void 丒一丏丄丝且丑万丏(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_7;
        if(丑一丞且专世丆丈丛.InappBonusParameters == null)
        {
                return;
        }
        
        if((丑一丞且专世丆丈丛.InappBonusParameters.ContainsKey(key:  "Key")) == false)
        {
                return;
        }
        
        object val_5 = 丑一丞且专世丆丈丛.InappBonusParameters.Item["Key"];
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
    public BonusBankViewItem.万世七丈下丑专七且()
    {
        val_1 = new System.Object();
    }

}
