using UnityEngine;
private class BonusBankViewItem.丅东丑丅上丗丆不丂 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    public BonusBankViewItem.丅东丑丅上丗丆不丂()
    {
        val_1 = new System.Object();
    }
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_12;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.eventCurrency, 丏业丟一东丂东丘丛:  true);
        Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丁丅丈丌丟世丗丗丟:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<Rilisoft.GameEventType>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "EventType"));
        if(val_6 != null)
        {
                val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6.丟万丏且上业丐丈一());
        }
        else
        {
                val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3411");
        }
        
        string val_11 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Int32>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "EventCurrency"))(AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Int32>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "EventCurrency"))) + " " + val_12;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  val_11);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_11, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_11, 丏业丟一东丂东丘丛:  false);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  true);
    }
    protected override void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_12;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.丕丁丑丐丌丐丆下丌().gameObject, 丏业丟一东丂东丘丛:  true);
        Rilisoft.丛且世丐丆上七业丁 val_6 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丁丅丈丌丟世丗丗丟:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<Rilisoft.GameEventType>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "EventType"));
        if(val_6 != null)
        {
                string val_9 = val_6.丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  Rilisoft.BonusData.七丅丆上丁丞丕业丐<System.Int32>(丈丗与丞一上且上上:  丑一丞且专世丆丈丛.InappBonusParameters, 丂丐丄丁丆与丈丂上:  "EventCurrency"));
        }
        else
        {
                val_12 = "Textures/Bank/Event/Event_Currency_1";
        }
        
        UnityEngine.Texture val_10 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_12);
        if(丑一丞且专世丆丈丛.丕丁丑丐丌丐丆下丌() != null)
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
