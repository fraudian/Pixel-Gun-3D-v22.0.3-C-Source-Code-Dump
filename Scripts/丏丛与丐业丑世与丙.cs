using UnityEngine;
private class BonusBankViewItem.丏丛与丐业丑世与丙 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    public BonusBankViewItem.丏丛与丐业丑世与丙()
    {
    
    }
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.pets, 丏业丟一东丂东丘丛:  true);
        BonusBankViewItem.丏丛与丐业丑世与丙.三丟一丏丐丄丏七专(丑一丞且专世丆丈丛:  丑一丞且专世丆丈丛);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛, 丏业丟一东丂东丘丛:  false);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  true);
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.世丗且丈丁丝丑一三().gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Texture val_5 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.String>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Pet"), 七丆丒与丗丌丄且丂:  168, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(丑一丞且专世丆丈丛.世丗且丈丁丝丑一三() != null)
        {
                return;
        }
    
    }
    private static void 三丟一丏丐丄丏七专(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        object val_26;
        PetInfo val_13 = 0;
        if((Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Int32>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Quantity")) == 0)
        {
            goto label_2;
        }
        
        string val_4 = Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.String>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Pet");
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == false)
        {
            goto label_6;
        }
        
        object[] val_6 = new object[1];
        val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丑一丞且专世丆丈丛.InappBonusParameters);
        val_6[0] = val_26;
        UnityEngine.Debug.LogErrorFormat(format:  "PetBonusUIFiller.FillCore: no petId.IsNullOrEmpty() in parameters: {0}", args:  val_6);
        return;
        label_2:
        object[] val_9 = new object[1];
        val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丑一丞且专世丆丈丛.InappBonusParameters);
        val_9[0] = val_26;
        UnityEngine.Debug.LogErrorFormat(format:  "PetBonusUIFiller.FillCore: no quantity in parameters: {0}", args:  val_9);
        return;
        label_6:
        if((val_13 == 0) || (((丟下七丘下下丙丗丅.一三专丞丒丅上业上().TryGetValue(key:  val_4, value: out  val_13)) ^ 1) == true))
        {
            goto label_27;
        }
        
        string val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  123438416);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) == false)
        {
            goto label_32;
        }
        
        object[] val_18 = new object[1];
        val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丑一丞且专世丆丈丛.InappBonusParameters);
        val_18[0] = val_26;
        UnityEngine.Debug.LogErrorFormat(format:  "PetBonusUIFiller.FillCore: no petName.IsNullOrEmpty() in parameters: {0}", args:  val_18);
        return;
        label_27:
        object[] val_21 = new object[2];
        val_21[0] = val_4;
        val_26 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丑一丞且专世丆丈丛.InappBonusParameters);
        val_21[1] = val_26;
        UnityEngine.Debug.LogErrorFormat(format:  "PetBonusUIFiller.FillCore: no such pet {0}, parameters of action = {1}", args:  val_21);
        return;
        label_32:
        val_26 = 丑一丞且专世丆丈丛.descriptionLabels;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_26, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5577"), arg0:  val_16));
    }
    protected override void 丒一丏丄丝且丑万丏(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_10;
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
                var val_8 = (null == null) ? (val_5) : 0;
        }
        else
        {
                val_10 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.bonusViewHeader, 丕丗丘丑丛与丑业丒:  Rilisoft.Offers.丁且丕专万丈丒丏丗.丈七下丗万七不不一(丗丟丁丐与下丙丕丛:  val_10, 丐丁不丆丘丂丐丈丆:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.String>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "Pet")));
    }

}
