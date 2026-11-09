using UnityEngine;
private class BonusBankViewItem.丗丞世丒丏三世一丟 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.details, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.detailsCountLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5581"), arg0:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Int32>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "DetailsCount")));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.descriptionLabels, 丏业丟一东丂东丘丛:  false);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  true);
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_15;
        var val_16;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.丕丐下七丂丆下七丐().gameObject, 丏业丟一东丂东丘丛:  true);
        string val_4 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.String>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "DetailsItemId");
        if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_4)) == false)
        {
            goto label_8;
        }
        
        val_15 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  val_4);
        if(val_15 == null)
        {
            goto label_10;
        }
        
        val_16 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_15.丙三专万丛丟万丝丘());
        val_15 = val_15.东丙上东业丆不丟丘();
        goto label_11;
        label_8:
        int val_11 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_4);
        val_16 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_4, 七丆丒与丗丌丄且丂:  val_11, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        val_15 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_4, 七丆丒与丗丌丄且丂:  val_11);
        label_11:
        if(丑一丞且专世丆丈丛 != null)
        {
            goto label_15;
        }
        
        goto label_15;
        label_10:
        val_16 = 0;
        label_15:
        UIBasicSprite val_14 = 丑一丞且专世丆丈丛.不丅丈丙丏业丘世丅();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.detailsItemName, 丕丗丘丑丛与丑业丒:  val_15);
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
    public BonusBankViewItem.丗丞世丒丏三世一丟()
    {
    
    }

}
