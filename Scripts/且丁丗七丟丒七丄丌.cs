using UnityEngine;
private class BonusBankViewItem.且丁丗七丟丒七丄丌 : BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    protected override void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        int val_8;
        string val_69;
        var val_70;
        string val_71;
        var val_72;
        var val_74;
        var val_75;
        var val_76;
        UnityEngine.Object val_77;
        var val_78;
        var val_79;
        UnityEngine.GameObject val_80;
        var val_81;
        UnityEngine.GameObject val_82;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.offerPack, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.offerPack, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.offerPack, 丏业丟一东丂东丘丛:  true);
        丑一丞且专世丆丈丛.SetSaleBackground(丁丅丈丌丟世丗丗丟:  2);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._mainBody, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._starterPackBody, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._noviceBody1, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._noviceBody2, 丏业丟一东丂东丘丛:  false);
        if(丑一丞且专世丆丈丛._noviceBody3 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._noviceBody3, 丏业丟一东丂东丘丛:  false);
        }
        
        if(丑一丞且专世丆丈丛._noviceBody4 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._noviceBody4, 丏业丟一东丂东丘丛:  false);
        }
        
        if(丑一丞且专世丆丈丛._noviceBody5 != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._noviceBody5, 丏业丟一东丂东丘丛:  false);
        }
        
        val_69 = 丑一丞且专世丆丈丛.InappBonusParameters;
        if(val_69 == null)
        {
            goto label_150;
        }
        
        if((val_69.ContainsKey(key:  "offer-module")) == false)
        {
            goto label_147;
        }
        
        val_70 = 1152921505476546560;
        Rilisoft.丗下丙丅且丐丞丙世 val_6 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世();
        val_71 = val_69.Item["offer-id"];
        if(val_6 == null)
        {
            goto label_23;
        }
        
        if(val_71 != null)
        {
            goto label_24;
        }
        
        goto label_27;
        label_23:
        if(val_71 == null)
        {
            goto label_27;
        }
        
        label_24:
        if(null != null)
        {
                val_71 = 0;
        }
        
        label_27:
        Rilisoft.业丙丘丆东丈丕丂丄 val_9 = val_6.上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  val_71);
        if(val_9 == null)
        {
            goto label_147;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._moreLabel, 丏业丟一东丂东丘丛:  (val_9.丑且一丐东三不丈丝() != 120) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛._contentLabel, 丏业丟一东丂东丘丛:  (val_9.丑且一丐东三不丈丝() == 120) ? 1 : 0);
        if(val_9.丑且一丐东三不丈丝() != 150)
        {
            goto label_31;
        }
        
        Rilisoft.七丈业与与不七丈丟 val_15 = val_9.丁专丗万三上丟三丆();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15.丒上一丁丆丛东专丙.三丁丟丈丙上一丕三));
        val_72 = null;
        val_72 = null;
        Rilisoft.七丈业与与不七丈丟 val_18 = val_9.丁专丗万三上丟三丆();
        val_8 = val_18.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业.Count;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  丑一丞且专世丆丈丛._contentLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  且丙丙丈丙丄丌丌不.且丑专丌丌一世专七), arg0:  val_8));
        val_69 = 0;
        if(丑一丞且专世丆丈丛._offerTexture == 0)
        {
            goto label_150;
        }
        
        UnityEngine.Texture val_22 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Constructable/temp");
        if(丑一丞且专世丆丈丛._offerTexture != null)
        {
            goto label_147;
        }
        
        goto label_147;
        label_31:
        if(val_9.丑且一丐东三不丈丝() != 90)
        {
            goto label_48;
        }
        
        if(丑一丞且专世丆丈丛._offerColorizer != 0)
        {
                丑一丞且专世丆丈丛._offerColorizer.丈且东丑丂且万丒丅(世丈三丐丞一丒丛不:  val_9.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世());
        }
        
        val_69 = 0;
        if(丑一丞且专世丆丈丛._offerTexture == 0)
        {
            goto label_150;
        }
        
        val_70 = 1152921505272713216;
        val_74 = 0;
        goto label_57;
        label_67:
        val_75 = null;
        val_75 = null;
        if((StoreKitEventListener.丝不东丅丅丂三且丑.Length + 32) == val_9.丟丂丞不专丆万丒世().丟丂丞不专丆万丒世())
        {
            goto label_63;
        }
        
        val_74 = 1;
        label_57:
        val_76 = null;
        val_76 = null;
        if(val_74 < StoreKitEventListener.丝不东丅丅丂三且丑.Length)
        {
            goto label_67;
        }
        
        label_63:
        val_8 = 0 + 1;
        val_77 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons\\offer_tier_{0}", arg0:  val_8));
        if(val_77 == 0)
        {
                val_77 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons\\offer_tier_1");
        }
        
        if(丑一丞且专世丆丈丛._offerTexture != null)
        {
            goto label_147;
        }
        
        goto label_147;
        label_48:
        if(val_9.丑且一丐东三不丈丝() != 100)
        {
            goto label_74;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._mainBody, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._starterPackBody, 丏业丟一东丂东丘丛:  true);
        label_147:
        val_69 = 0;
        label_150:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_69)) != false)
        {
                val_69 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5584");
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  val_69);
        return;
        label_74:
        if(val_9.丑且一丐东三不丈丝() != 120)
        {
            goto label_84;
        }
        
        Rilisoft.七丈业与与不七丈丟 val_39 = val_9.丁专丗万三上丟三丆();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丑一丞且专世丆丈丛.descriptionLabels, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_39.丒上一丁丆丛东专丙.三丁丟丈丙上一丕三));
        val_78 = null;
        val_78 = null;
        Rilisoft.七丈业与与不七丈丟 val_42 = val_9.丁专丗万三上丟三丆();
        val_8 = val_42.丒上一丁丆丛东专丙.且东丌丏丐丝丕万业.Count - 2;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  丑一丞且专世丆丈丛._contentLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  且丙丙丈丙丄丌丌不.且丑专丌丌一世专七), arg0:  val_8));
        if(丑一丞且专世丆丈丛._offerTexture == 0)
        {
            goto label_150;
        }
        
        Rilisoft.七丈业与与不七丈丟 val_47 = val_9.丁专丗万三上丟三丆();
        UnityEngine.Texture val_49 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Lobby/{0}", arg0:  val_47.丒上一丁丆丛东专丙.下丄丈不与世丐业专));
        if(丑一丞且专世丆丈丛._offerTexture != null)
        {
            goto label_147;
        }
        
        goto label_147;
        label_84:
        if(val_9.丑且一丐东三不丈丝() != 130)
        {
            goto label_103;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._mainBody, 丏业丟一东丂东丘丛:  false);
        if((val_9.丏不丁丛丕丒丏丆丂() != 5) || (丑一丞且专世丆丈丛._noviceBody5 == 0))
        {
            goto label_109;
        }
        
        val_79 = null;
        val_80 = 丑一丞且专世丆丈丛._noviceBody5;
        goto label_142;
        label_103:
        if(val_9.丑且一丐东三不丈丝() != 140)
        {
            goto label_150;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._mainBody, 丏业丟一东丂东丘丛:  false);
        if(val_9.丏不丁丛丕丒丏丆丂() != 2)
        {
            goto label_115;
        }
        
        val_81 = null;
        val_82 = 丑一丞且专世丆丈丛._noviceBody2;
        goto label_134;
        label_109:
        if((val_9.丏不丁丛丕丒丏丆丂() != 4) || (丑一丞且专世丆丈丛._noviceBody4 == 0))
        {
            goto label_121;
        }
        
        val_79 = null;
        val_80 = 丑一丞且专世丆丈丛._noviceBody4;
        goto label_142;
        label_121:
        if((val_9.丏不丁丛丕丒丏丆丂() != 3) || (丑一丞且专世丆丈丛._noviceBody3 == 0))
        {
            goto label_127;
        }
        
        val_79 = null;
        val_80 = 丑一丞且专世丆丈丛._noviceBody3;
        goto label_142;
        label_127:
        if(val_9.丏不丁丛丕丒丏丆丂() != 2)
        {
            goto label_130;
        }
        
        val_79 = null;
        val_80 = 丑一丞且专世丆丈丛._noviceBody2;
        goto label_142;
        label_115:
        val_81 = null;
        val_82 = 丑一丞且专世丆丈丛._noviceBody1;
        label_134:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_82, 丏业丟一东丂东丘丛:  true);
        Rilisoft.Offers.丑与不丞丕丟世世丗 val_61 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丑与不丞丕丟世世丗>(丗与丟上上丑专世丗:  140);
        if(val_61 == null)
        {
            goto label_150;
        }
        
        if((val_61.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  val_9.丏不丁丛丕丒丏丆丂())) != null)
        {
            goto label_139;
        }
        
        goto label_147;
        label_130:
        val_79 = null;
        val_80 = 丑一丞且专世丆丈丛._noviceBody1;
        label_142:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_80, 丏业丟一东丂东丘丛:  true);
        Rilisoft.Offers.丆不丛丈丒丁专丂丅 val_65 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().下不丛上丏且东一丏<Rilisoft.Offers.丆不丛丈丒丁专丂丅>(丗与丟上上丑专世丗:  130);
        if(val_65 == null)
        {
            goto label_150;
        }
        
        PGCompany.丒丌业一丕丘丐世专 val_67 = val_65.丅专上东下丕丄丗丅(丞丅上丏丂且下丅与:  val_9.丏不丁丛丕丒丏丆丂());
        if(val_67 == null)
        {
            goto label_147;
        }
        
        label_139:
        string val_69 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_67.下丘丐丞丗丂丛丗东());
        goto label_150;
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
    public BonusBankViewItem.且丁丗七丟丒七丄丌()
    {
    
    }

}
