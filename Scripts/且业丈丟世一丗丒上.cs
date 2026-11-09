using UnityEngine;
private class BonusBankViewItem.且业丈丟世一丗丒上 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        string val_15;
        object val_16;
        object val_17;
        object val_18;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5576"));
        InappRememberedBonus val_4 = 一下丛与丛丛万万丏.丑七不且上丗丁一世().三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  丑一丞且专世丆丈丛.InappBonusParameters);
        System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  (double)val_4.VipSeconds);
        if(val_5._ticks.Hours >= 1)
        {
                val_15 = "{0}{1}{2}";
            val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3155");
            val_17 = (int)val_5._ticks.TotalHours;
            val_18 = System.Environment.NewLine;
        }
        else
        {
                val_15 = "{0}{1}{2}";
            val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ((int)val_5._ticks.TotalDays > (4.94065645841247E-324)) ? "Key_4474" : "Key_4473");
            val_17 = (int)val_5._ticks.TotalDays;
            val_18 = System.Environment.NewLine;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.VipDaysLabels, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_15, arg0:  (int)val_5._ticks.TotalDays, arg1:  val_18, arg2:  val_16));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.vip, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.vip, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.vip, 丏业丟一东丂东丘丛:  false);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsSmall, 丏业丟一东丂东丘丛:  true);
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
    public BonusBankViewItem.且业丈丟世一丗丒上()
    {
    
    }

}
