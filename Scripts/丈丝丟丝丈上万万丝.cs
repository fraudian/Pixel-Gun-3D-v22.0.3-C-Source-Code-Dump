using UnityEngine;
private abstract class BonusBankViewItem.丈丝丟丝丈上万万丝
{
    // Methods
    protected BonusBankViewItem.丈丝丟丝丈上万万丝()
    {
    
    }
    public void 上东与丛丞下丈专丈(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        UnityEngine.Object val_33;
        object val_34;
        var val_35;
        System.Action<T> val_36;
        System.Action<UILabel> val_37;
        var val_38;
        var val_40;
        var val_42;
        System.Action<UnityEngine.GameObject> val_44;
        var val_45;
        var val_46;
        System.Action<UILabel> val_48;
        var val_49;
        var val_50;
        System.Action<UILabel> val_52;
        var val_53;
        var val_54;
        System.Collections.Generic.List<UILabel> val_55;
        System.Action<UILabel> val_57;
        var val_58;
        var val_59;
        var val_61;
        var val_62;
        var val_64;
        System.Action<UILabel> val_66;
        var val_67;
        val_33 = 丑一丞且专世丆丈丛;
        object val_8 = 0;
        BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄 val_1 = null;
        val_34 = val_1;
        val_1 = new BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄();
        val_35 = 1152921504848912384;
        if(val_33 == 0)
        {
                val_33 = System.Array.Empty<System.Object>();
            UnityEngine.Debug.LogErrorFormat(format:  "CurrencyBonusUIFiller.Fill bonusBankViewItem == null", args:  val_33);
            return;
        }
        
        .且一专万丑丟丒且业 = 一下丛与丛丛万万丏.丑七不且上丗丁一世().三丌丑丏一丏丙一丒(丄上下丟与不丈丏丄:  val_33.InappBonusParameters);
        val_36 = 1;
        if(val_8 != 0)
        {
                if(((val_33.InappBonusParameters.TryGetValue(key:  "isGems", value: out  val_8)) ^ 1) != true)
        {
                val_36 = System.Convert.ToBoolean(value:  val_8);
        }
        
        }
        
        val_37 = val_33.InappBonusParameters;
        if(val_33 == null)
        {
                val_37 = 0;
        }
        
        if((val_37.ContainsKey(key:  "offer-id")) == false)
        {
            goto label_21;
        }
        
        val_38 = null;
        val_38 = null;
        if((BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_0) == null)
        {
            goto label_24;
        }
        
        label_56:
        丑一丞且专世丆丈丛.coinsQuantityLabels.ForEach(action:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_0);
        val_40 = null;
        val_40 = null;
        if((BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_1) == null)
        {
            goto label_28;
        }
        
        label_60:
        丑一丞且专世丆丈丛.gemsQuantityLabels.ForEach(action:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_1);
        val_42 = null;
        val_42 = null;
        val_44 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_2;
        if(val_44 == null)
        {
                System.Action<UnityEngine.GameObject> val_14 = null;
            val_44 = val_14;
            val_14 = new System.Action<UnityEngine.GameObject>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丅丐丐丛丑且三万上(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_2 = val_44;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  丑一丞且专世丆丈丛.plus, 七丐丅专且专七三丆:  val_14);
        goto label_83;
        label_21:
        if(val_36 == false)
        {
            goto label_38;
        }
        
        val_37 = new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::丏且丛三丏且与七丑(UILabel 七丐丞丑丑丕世丙七));
        val_45 = 1152921525860791328;
        丑一丞且专世丆丈丛.coinsQuantityLabels.ForEach(action:  val_37);
        丑一丞且专世丆丈丛.gemsQuantityLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::上上丆丝丆丕与万世(UILabel 七丐丞丑丑丕世丙七)));
        val_46 = null;
        val_46 = null;
        val_48 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_5;
        if(val_48 != null)
        {
            goto label_43;
        }
        
        val_49 = 1152921525851386144;
        goto label_61;
        label_38:
        val_37 = new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::世丞东不丝丆丌丄丐(UILabel 七丐丞丑丑丕世丙七));
        val_45 = 1152921525860791328;
        丑一丞且专世丆丈丛.coinsQuantityLabels.ForEach(action:  val_37);
        丑一丞且专世丆丈丛.gemsQuantityLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::世丕专丐丟上丆丗丑(UILabel 七丐丞丑丑丕世丙七)));
        val_50 = null;
        val_50 = null;
        val_52 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_9;
        if(val_52 != null)
        {
            goto label_50;
        }
        
        val_53 = 1152921525851386144;
        goto label_68;
        label_24:
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_0 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::一下丙丙丟业丕一三(UILabel 三丟东丕丄丄下下丑));
        if(丑一丞且专世丆丈丛.coinsQuantityLabels != null)
        {
            goto label_56;
        }
        
        goto label_56;
        label_28:
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_1 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丆三上世丕三业世丑(UILabel 三丟东丕丄丄下下丑));
        if(丑一丞且专世丆丈丛.gemsQuantityLabels != null)
        {
            goto label_60;
        }
        
        goto label_60;
        label_61:
        System.Action<UILabel> val_21 = null;
        val_48 = val_21;
        val_21 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::七丟三业专丌丐丂丒(UILabel 三丟东丕丄丄下下丑));
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_5 = val_48;
        label_43:
        丑一丞且专世丆丈丛.gemsQuantityLabels.ForEach(action:  val_21);
        val_54 = null;
        val_55 = 丑一丞且专世丆丈丛.coinsQuantityLabels;
        val_54 = null;
        val_57 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_6;
        if(val_57 != null)
        {
            goto label_72;
        }
        
        val_58 = 1152921525851386144;
        goto label_75;
        label_68:
        System.Action<UILabel> val_22 = null;
        val_52 = val_22;
        val_22 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::七一丅丈上且三丘东(UILabel 三丟东丕丄丄下下丑));
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_9 = val_52;
        label_50:
        丑一丞且专世丆丈丛.coinsQuantityLabels.ForEach(action:  val_22);
        val_59 = null;
        val_55 = 丑一丞且专世丆丈丛.gemsQuantityLabels;
        val_59 = null;
        val_57 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_10;
        if(val_57 != null)
        {
            goto label_72;
        }
        
        val_61 = 1152921525851386144;
        goto label_111;
        label_75:
        System.Action<UILabel> val_23 = null;
        val_57 = val_23;
        val_23 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丕丙丕东下业丄丟三(UILabel 三丟东丕丄丄下下丑));
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_6 = val_57;
        label_72:
        if(val_55 != null)
        {
            goto label_112;
        }
        
        label_113:
        label_112:
        val_55.ForEach(action:  val_23);
        丑一丞且专世丆丈丛.coinsQuantityLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::不世丑丁丟丌丏且东(UILabel 三丟东丕丄丄下下丑)));
        丑一丞且专世丆丈丛.gemsQuantityLabels.ForEach(action:  new System.Action<UILabel>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::下丑丝下万丟下上丙(UILabel 三丟东丕丄丄下下丑)));
        System.Action<UnityEngine.GameObject> val_26 = null;
        val_36 = val_26;
        val_26 = new System.Action<UnityEngine.GameObject>(object:  val_1, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丝丂下丂丐丄丁丑丄::丈下丈丘丕与丏丈丛(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  丑一丞且专世丆丈丛.plus, 七丐丅专且专七三丆:  val_26);
        if(丑一丞且专世丆丈丛.quantitiesTable != 0)
        {
                丑一丞且专世丆丈丛.quantitiesTable.repositionNow = true;
        }
        
        label_83:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currence, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.pets, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.weapon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.gadget, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.leprechaun, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.offerPack, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.details, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._tierBundleObj, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsSmall, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛.currencyObjectsBig, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丑一丞且专世丆丈丛._moreLabel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛._contentLabel, 丏业丟一东丂东丘丛:  false);
        val_35 = 1152921505212063744;
        val_62 = null;
        val_62 = null;
        if((BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_14) == null)
        {
            goto label_90;
        }
        
        label_106:
        丑一丞且专世丆丈丛.descriptionLabels.ForEach(action:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_14);
        val_64 = null;
        val_64 = null;
        val_66 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_15;
        if(val_66 == null)
        {
                System.Action<UILabel> val_28 = null;
            val_66 = val_28;
            val_28 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丌丛丈丑丆丒三上丆(UILabel 三丟东丕丄丄下下丑));
            BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_15 = val_66;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  丑一丞且专世丆丈丛.bonusViewHeader, 七丐丅专且专七三丆:  val_28);
        val_67 = null;
        val_34 = 丑一丞且专世丆丈丛.profitObjects;
        val_67 = null;
        if((BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_16) == null)
        {
            goto label_101;
        }
        
        label_110:
        val_34.ForEach(action:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_16);
        return;
        label_90:
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_14 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丐与与丆七七且业万(UILabel 三丟东丕丄丄下下丑));
        if(丑一丞且专世丆丈丛.descriptionLabels != null)
        {
            goto label_106;
        }
        
        goto label_106;
        label_101:
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_16 = new System.Action<UnityEngine.GameObject>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丗万丐丑丛专下丙丝(UnityEngine.GameObject 丄三丅七丆丛与与上));
        if(val_34 != null)
        {
            goto label_110;
        }
        
        goto label_110;
        label_111:
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__1_10 = new System.Action<UILabel>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丈丙丗东东丅业下丞(UILabel 三丟东丕丄丄下下丑));
        if(val_55 != null)
        {
            goto label_112;
        }
        
        goto label_113;
    }
    public void 丞业与下丛万丁下丙(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        if(丑一丞且专世丆丈丛 == 0)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "CurrencyBonusUIFiller.SetIcon bonusBankViewItem == null", args:  System.Array.Empty<System.Object>());
        }
    
    }
    protected abstract void 丏丒丅丆丙丆丛丌丁(BonusBankViewItem 丑一丞且专世丆丈丛); // 0
    protected abstract void 丑专丕丕丁丅丞丟丟(BonusBankViewItem 丑一丞且专世丆丈丛); // 0
    protected virtual void 业专丙世东丈丙七世(BonusBankViewItem 丑一丞且专世丆丈丛)
    {
        int val_25;
        int val_26;
        string val_27;
        int val_28;
        var val_29;
        var val_31;
        System.Action<UnityEngine.GameObject> val_33;
        new BonusBankViewItem.丈丝丟丝丈上万万丝.丞丂万丅不丒丘丟丗() = new System.Object();
        .七丂世丆丒丆万且专 = System.String.alignConst;
        if((丑一丞且专世丆丈丛.InappBonusParameters.ContainsKey(key:  "offer-id")) != false)
        {
                Rilisoft.业丙丘丆东丈丕丂丄 val_7 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().上丑下专丄下丟丏丆(丗丟丁丐与下丙丕丛:  丑一丞且专世丆丈丛.InappBonusParameters.Item["offer-id"]);
            if(val_7 == null)
        {
            goto label_42;
        }
        
            decimal val_8 = val_7.丐丁丒世丟世丘丌丅();
            val_25 = val_8.flags;
            val_26 = val_8.lo;
            val_27 = Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal() {flags = val_25, hi = val_8.hi, lo = val_26, mid = val_8.mid}, 丅丟丏丐丅三不丗东:  true);
        }
        else
        {
                decimal val_13 = System.Convert.ToDecimal(value:  丑一丞且专世丆丈丛.InappBonusParameters.Item["Profit"], provider:  System.Globalization.CultureInfo.InvariantCulture);
            val_25 = val_13.flags;
            val_26 = val_13.lo;
            val_27 = Rilisoft.业丙丘丆东丈丕丂丄.丌丕七与与万业丂丁(丐丌一丈丒一丕丐丙:  new System.Decimal() {flags = val_25, hi = val_13.hi, lo = val_26, mid = val_13.mid}, 丅丟丏丐丅三不丗东:  true);
        }
        
        .七丂世丆丒丆万且专 = val_27;
        label_42:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_27)) == false)
        {
            goto label_25;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.oldPriceLabel, 丏业丟一东丂东丘丛:  false);
        val_28 = 1152921505212063744;
        val_29 = null;
        val_29 = null;
        val_25 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__5_0;
        if(val_25 == null)
        {
            goto label_31;
        }
        
        if(丑一丞且专世丆丈丛.profitObjects != null)
        {
            goto label_45;
        }
        
        goto label_33;
        label_25:
        .七丂世丆丒丆万且专 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5570"), arg0:  (BonusBankViewItem.丈丝丟丝丈上万万丝.丞丂万丅不丒丘丟丗)[1152921537981680528].七丂世丆丒丆万且专);
        val_31 = null;
        val_31 = null;
        val_33 = BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__5_1;
        if(val_33 == null)
        {
            goto label_39;
        }
        
        if(丑一丞且专世丆丈丛.profitObjects != null)
        {
            goto label_49;
        }
        
        goto label_41;
        label_31:
        val_25 = null;
        val_25 = new System.Action<UnityEngine.GameObject>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::丅东丗丄丈三与不丗(UnityEngine.GameObject 丄三丅七丆丛与与上));
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__5_0 = val_25;
        if(丑一丞且专世丆丈丛.profitObjects != null)
        {
            goto label_45;
        }
        
        label_33:
        label_45:
        丑一丞且专世丆丈丛.profitObjects.ForEach(action:  null);
        return;
        label_39:
        val_33 = null;
        val_33 = new System.Action<UnityEngine.GameObject>(object:  BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.<>c::东七一不一丛七丂丁(UnityEngine.GameObject 丄三丅七丆丛与与上));
        BonusBankViewItem.丈丝丟丝丈上万万丝.<>c.<>9__5_1 = val_33;
        if(丑一丞且专世丆丈丛.profitObjects != null)
        {
            goto label_49;
        }
        
        label_41:
        label_49:
        丑一丞且专世丆丈丛.profitObjects.ForEach(action:  null);
        System.Action<UILabel> val_20 = new System.Action<UILabel>(object:  new BonusBankViewItem.丈丝丟丝丈上万万丝.丞丂万丅不丒丘丟丗(), method:  System.Void BonusBankViewItem.丈丝丟丝丈上万万丝.丞丂万丅不丒丘丟丗::丁丞业世上上丐世一(UILabel 七丐丞丑丑丕世丙七));
        丑一丞且专世丆丈丛.profitLabels.ForEach(action:  null);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丑一丞且专世丆丈丛.oldPriceLabel, 丏业丟一东丂东丘丛:  true);
        var val_26 = 0;
        val_26 = val_26 + 1;
        decimal val_23 = 丑一丞且专世丆丈丛.丄丑且丆上丛丁且七().丈业且丆七三丛丙丙();
        val_28 = val_23.flags;
        decimal val_24 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = val_28, hi = val_23.hi, lo = val_23.lo, mid = val_23.mid}, d2:  new System.Decimal() {flags = val_25, hi = val_13.hi, lo = val_26, mid = val_13.mid});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  丑一丞且专世丆丈丛.oldPriceLabel, 丕丗丘丑丛与丑业丒:  BonusBankViewItem.丑丈丒丅丝丕世丞丗(丙业与丙丗丝不丈东:  new System.Decimal() {flags = val_24.flags, hi = val_24.hi, lo = val_24.lo, mid = val_24.mid}, 七丏丂丈世万丈上丕:  "F0"));
    }
    protected abstract void 丒一丏丄丝且丑万丏(BonusBankViewItem 丑一丞且专世丆丈丛); // 0

}
