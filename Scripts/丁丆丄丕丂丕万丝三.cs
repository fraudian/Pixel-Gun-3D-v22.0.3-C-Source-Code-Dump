using UnityEngine;
internal static class 丁丆丄丕丂丕万丝三
{
    // Methods
    internal static void 不丘七丂丂丆丝与丕(string 丗丑丐丕丟丝且下丕, PropertiesArmoryItemContainer 且丑丝丟丁与上三丅, bool 东丈丒三丞与业世一, int 丂丄丆丁丘丝丞丐不)
    {
        string val_53;
        string val_61;
        int val_70;
        System.Collections.Generic.List<GadgetPropertyItem> val_71;
        一丁丒与丁丂丈七丆 val_72;
        bool val_73;
        int val_74;
        var val_75;
        var val_77;
        int val_78;
        var val_79;
        var val_80;
        UITable val_81;
        var val_82;
        val_70 = 丂丄丆丁丘丝丞丐不;
        丕丈丏丝丗下丟丅丂 val_2 = 0;
        bool val_3 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  丗丑丐丕丟丝且下丕, value: out  val_2);
        if(val_70 <= 0)
        {
            goto label_4;
        }
        
        label_123:
        val_71 = 且丑丝丟丁与上三丅.gadgetsPropertiesList;
        if(val_71 == null)
        {
            goto label_6;
        }
        
        val_72 = 0;
        goto label_7;
        label_47:
        if(val_72 < 3)
        {
                val_73 = 0;
        }
        else
        {
                val_73 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丑丐丕丟丝且下丕].丘一一丆业丂丘丒世().Contains(item:  val_72);
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.gadgetsPropertiesList.Item[0].gameObject, 丏业丟一东丂东丘丛:  val_73);
        if(val_73 == false)
        {
            goto label_19;
        }
        
        val_74 = val_70;
        if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕)) != false)
        {
                val_74 = BalanceController.与丗万世丅下丈万丁(丞世不丒下上上丝丑:  丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕), 丈丘丝一丗下丈丐不:  val_70, 丐丏上业丈丂与万丞:  false);
        }
        
        if(val_72 == 3)
        {
            goto label_28;
        }
        
        if(val_72 != 4)
        {
            goto label_29;
        }
        
        val_75 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.丕与丝丗与三下丟丌(丗丑丐丕丟丝且下丕:  丗丑丐丕丟丝且下丕, 丂丄丆丁丘丝丞丐不:  val_70));
        float val_16 = BalanceController.丕与丝丗与三下丟丌(丗丑丐丕丟丝且下丕:  丗丑丐丕丟丝且下丕, 丂丄丆丁丘丝丞丐不:  val_74);
        goto label_34;
        label_28:
        val_75 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.业不一丒下丑丄万丏(丗丑丐丕丟丝且下丕:  丗丑丐丕丟丝且下丕, 丂丄丆丁丘丝丞丐不:  val_70));
        label_34:
        val_77 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.业不一丒下丑丄万丏(丗丑丐丕丟丝且下丕:  丗丑丐丕丟丝且下丕, 丂丄丆丁丘丝丞丐不:  val_74));
        goto label_39;
        label_29:
        val_77 = 0;
        val_75 = 0;
        label_39:
        GadgetPropertyItem val_21 = 且丑丝丟丁与上三丅.gadgetsPropertiesList.Item[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_21.propertyLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  0, 东丑丛上专上下丕丌:  0));
        label_19:
        val_71 = 且丑丝丟丁与上三丅.gadgetsPropertiesList;
        val_72 = 1;
        label_7:
        if(val_72 < val_71.Count)
        {
            goto label_47;
        }
        
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.miniGadgetInfoRarityContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miniGadgetInfoRarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  BalanceController.丘丛丄业丒一丝丆东(丞世不丒下上上丝丑:  丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕))));
        if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕)) != false)
        {
                val_70 = BalanceController.与丗万世丅下丈万丁(丞世不丒下上上丝丑:  丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕), 丈丘丝一丗下丈丐不:  val_70, 丐丏上业丈丂与万丞:  false);
        }
        
        val_78 = BalanceController.丂丛且丑丞丘丅不丅(丞世不丒下上上丝丑:  丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕), 丂丄丆丁丘丝丞丐不:  val_70);
        UnityEngine.Color val_35 = UnityEngine.Color.yellow;
        UnityEngine.Color32 val_36 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_35.r, g = val_35.g, b = val_35.b, a = val_35.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.gadgetEfficiency, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丏丅世东东丟丅丂与(丂丐丏下万万丒三上:  BalanceController.丂丛且丑丞丘丅不丅(丞世不丒下上上丝丑:  丁下万丟且丟丛下业.一丗上丄丆丞三东业(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕), 丂丄丆丁丘丝丞丐不:  val_70), 东丑丛上专上下丕丌:  val_78, 丝丌且丝丛丙万丅丙:  new UnityEngine.Color32() {r = val_36.r & 4294967295, g = val_36.r & 4294967295, b = val_36.r & 4294967295, a = val_36.r & 4294967295}));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.gadgetEfficiencyContainer, 丏业丟一东丂东丘丛:  true);
        bool val_39 = UnityEngine.Object.op_Implicit(exists:  且丑丝丟丁与上三丅.gadgetPropertyTable);
        val_79 = 0;
        goto label_76;
        label_108:
        int val_43 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丑丐丕丟丝且下丕].丑丐丗世业丙丗丘不().Count;
        val_78 = 且丑丝丟丁与上三丅.effectsLabels.Item[0].gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_78, 丏业丟一东丂东丘丛:  (val_79 < val_43) ? 1 : 0);
        if(val_79 < val_43)
        {
                val_80 = null;
            val_80 = null;
            System.ValueTuple<System.String, System.String, System.String> val_52 = WeaponSounds.三丘丒万丛丞与一不.Item[丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丑丐丕丟丝且下丕].丑丐丗世业丙丗丘不().Item[0]];
            且丑丝丟丁与上三丅.effectsLabels.Item[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_53);
            System.ValueTuple<System.String, System.String, System.String> val_60 = WeaponSounds.三丘丒万丛丞与一不.Item[丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[丗丑丐丕丟丝且下丕].丑丐丗世业丙丗丘不().Item[0]];
            val_78 = val_61;
            且丑丝丟丁与上三丅.effectsSprites.Item[0].spriteName = val_78;
            且丑丝丟丁与上三丅.effectsSprites.Item[0].ResetAndUpdateAnchors();
        }
        
        val_79 = 1;
        label_76:
        if(val_79 < 且丑丝丟丁与上三丅.effectsLabels.Count)
        {
            goto label_108;
        }
        
        val_81 = 且丑丝丟丁与上三丅.specialTable;
        if(val_81 != 0)
        {
                val_81 = 且丑丝丟丁与上三丅.specialTable;
        }
        
        丁丆丄丕丂丕万丝三.丝一下丄万丏丞丝东(且丑丝丟丁与上三丅:  且丑丝丟丁与上三丅, 丆万一不丌且东丐丐:  丗丑丐丕丟丝且下丕);
        return;
        label_4:
        if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕)) != false)
        {
                val_82 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒();
            int val_68 = val_82.三三三东丑丁且与万(丞丅上丏丂且下丅与:  丗丑丐丕丟丝且下丕);
        }
        else
        {
                val_82 = val_2;
            int val_69 = val_82.专丂丏世且丗丏丌丝();
        }
        
        if(且丑丝丟丁与上三丅 != null)
        {
            goto label_123;
        }
        
        goto label_123;
    }
    internal static void 丙丈丆丘丕丘丅世世(string 丙丄不丈专丕与万万, PropertiesArmoryItemContainer 且丑丝丟丁与上三丅, bool 东丈丒三丞与业世一, int 丈丘丝一丗下丈丐不)
    {
        int val_32;
        var val_33;
        UnityEngine.MonoBehaviour val_34;
        int val_35;
        var val_36;
        string val_37;
        string val_38;
        int val_1 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  丙丄不丈专丕与万万);
        int val_3 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  val_1);
        if(val_3 > 0)
        {
                val_32 = val_1;
            int val_4 = BalanceController.丞丆丈七上丙世丗丄(丞世不丒下上上丝丑:  val_32, 丕丒一丂丗万三七三:  val_3, 丐丏上业丈丂与万丞:  false);
        }
        else
        {
                val_32 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万();
            int val_6 = val_32.丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_1);
        }
        
        val_33 = 0;
        goto label_13;
        label_35:
        val_34 = 且丑丝丟丁与上三丅.armorPropertiesList.Item[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_34, 丏业丟一东丂东丘丛:  ((val_33 == 17) ? 1 : 0) | ((val_33 == 7) ? 1 : 0));
        if(val_33 != 17)
        {
                if(val_33 != 7)
        {
            goto label_18;
        }
        
        }
        
        if(val_33 != 7)
        {
            goto label_19;
        }
        
        val_35 = val_1;
        int val_11 = BalanceController.丒丏与丘三丒丝下丙(丞世不丒下上上丝丑:  val_35);
        goto label_22;
        label_19:
        if(val_33 != 17)
        {
            goto label_23;
        }
        
        val_35 = val_1;
        label_22:
        val_36 = BalanceController.且丄丝丟与不丏七与(丞世不丒下上上丝丑:  val_35);
        goto label_26;
        label_23:
        val_36 = 0;
        label_26:
        GadgetPropertyItem val_13 = 且丑丝丟丁与上三丅.armorPropertiesList.Item[0];
        val_34 = val_13.propertyLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_34, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  0, 东丑丛上专上下丕丌:  0));
        label_18:
        val_33 = 1;
        label_13:
        if(val_33 < 且丑丝丟丁与上三丅.armorPropertiesList.Count)
        {
            goto label_35;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.miniArmorInfoRarityContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miniArmorInfoRarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  BalanceController.丕且丄丑世丕丟丅七(丞世不丒下上上丝丑:  val_1)));
        UnityEngine.Color val_20 = UnityEngine.Color.yellow;
        UnityEngine.Color32 val_21 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.armorEfficiency, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丏丅世东东丟丅丂与(丂丐丏下万万丒三上:  BalanceController.专万丕丘丌下丌丌丏(丞世不丒下上上丝丑:  val_1, 下丑丞不一且业丆不:  val_6), 东丑丛上专上下丕丌:  BalanceController.专万丕丘丌下丌丌丏(丞世不丒下上上丝丑:  val_1, 下丑丞不一且业丆不:  val_6), 丝丌且丝丛丙万丅丙:  new UnityEngine.Color32() {r = val_21.r & 4294967295, g = val_21.r & 4294967295, b = val_21.r & 4294967295, a = val_21.r & 4294967295}));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.armorEfficiencyContainer, 丏业丟一东丂东丘丛:  true);
        bool val_24 = UnityEngine.Object.op_Inequality(x:  且丑丝丟丁与上三丅.armorPropertyTable, y:  0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.effectsLabels, 丏业丟一东丂东丘丛:  false);
        val_37 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丐万且丏丙万下专丑<PGCompany.且万丅丙丛丌丞与丈>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  丙丄不丈专丕与万万);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.armorEffectDescriptionLabel, 丏业丟一东丂东丘丛:  true);
        if(且丑丝丟丁与上三丅.armorEffectDescriptionLabel != null)
        {
                if(val_37.下丆丂丌上丑一三丆().Count > 0)
        {
                val_38 = val_37.下丆丘丆一丝七世专();
        }
        else
        {
                val_38 = "Key_8971";
        }
        
            val_37 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_38);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.armorEffectDescriptionLabel, 丕丗丘丑丛与丑业丒:  val_37);
        }
        
        bool val_31 = UnityEngine.Object.op_Inequality(x:  且丑丝丟丁与上三丅.specialTable, y:  0);
        丁丆丄丕丂丕万丝三.丂世丆丒丁丌丙丗一(且丑丝丟丁与上三丅:  且丑丝丟丁与上三丅, 且丂丟丈丈丑东丈丙:  val_1, 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不);
    }
    internal static void 丏丌上丁业丅丌七与(string 丙丂丒一丗下丘下丟, PropertiesArmoryItemContainer 且丑丝丟丁与上三丅)
    {
        PGCompany.丟丝世万东万丆丟上 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  丙丂丒一丗下丘下丟);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.miniMiscInfoRarityContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miniMiscInfoRarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_2));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.miscDescriptionLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miscDescriptionLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_2, arg0:  val_2.上专丗丏丛丁专丑丄().ItemWeapon));
    }
    internal static void 丒丄七丌专三丟丒丏(string 丕丄三丒且三丕东丙, PropertiesArmoryItemContainer 且丑丝丟丁与上三丅)
    {
        PGCompany.丘三丏丌丗丒万丏丈 val_2 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞丅上丏丂且下丅与:  丕丄三丒且三丕东丙);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.miniMiscInfoRarityContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miniMiscInfoRarity, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_2));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.miscDescriptionLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miscDescriptionLabel, 丕丗丘丑丛与丑业丒:  val_2);
    }
    internal static void 专业与丈业丂丙丟丐(string 世丐丗专丅三丝丑丆, PropertiesArmoryItemContainer 且丑丝丟丁与上三丅)
    {
        string val_37;
        string val_42;
        UITable val_46;
        int val_47;
        System.Collections.Generic.List<GadgetPropertyItem> val_48;
        一丁丒与丁丂丈七丆 val_49;
        bool val_50;
        var val_51;
        var val_53;
        System.Collections.Generic.List<GadgetPropertyItem> val_54;
        int val_55;
        int val_56;
        int val_57;
        var val_58;
        var val_59;
        val_46 = 且丑丝丟丁与上三丅;
        PetInfo val_2 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  世丐丗专丅三丝丑丆);
        if(val_2 != null)
        {
                val_47 = val_2.Index;
        }
        else
        {
                val_47 = 0.Index;
        }
        
        val_48 = 且丑丝丟丁与上三丅.gadgetsPropertiesList;
        if(val_48 == null)
        {
            goto label_56;
        }
        
        val_49 = 0;
        goto label_8;
        label_38:
        if((-5) < 2)
        {
                val_50 = 0;
        }
        else
        {
                val_50 = val_2.Parameters.Contains(item:  val_49);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.gadgetsPropertiesList.Item[0], 丏业丟一东丂东丘丛:  val_50);
        if(val_50 == false)
        {
            goto label_16;
        }
        
        if(val_49 == 8)
        {
            goto label_17;
        }
        
        if(val_49 != 7)
        {
            goto label_18;
        }
        
        val_51 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.丑一丌丟万丛丝丕丆(世丐丗专丅三丝丑丆:  val_2.Id));
        float val_11 = BalanceController.丑一丌丟万丛丝丕丆(世丐丗专丅三丝丑丆:  val_2.Id);
        goto label_24;
        label_17:
        val_51 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.丝一丄丙三且丞丞一(世丐丗专丅三丝丑丆:  val_2.Id));
        label_24:
        val_53 = UnityEngine.Mathf.RoundToInt(f:  BalanceController.丝一丄丙三且丞丞一(世丐丗专丅三丝丑丆:  val_2.Id));
        goto label_30;
        label_18:
        val_53 = 0;
        val_51 = 0;
        label_30:
        GadgetPropertyItem val_16 = 且丑丝丟丁与上三丅.gadgetsPropertiesList.Item[0];
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_16.propertyLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  0, 东丑丛上专上下丕丌:  0));
        label_16:
        val_54 = 且丑丝丟丁与上三丅.gadgetsPropertiesList;
        val_49 = 1;
        label_8:
        if(val_49 < val_54.Count)
        {
            goto label_38;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.miniGadgetInfoRarityContainer, 丏业丟一东丂东丘丛:  true);
        if(val_2 != null)
        {
                val_55 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_2.Rarity);
        }
        else
        {
                val_55 = System.String.alignConst;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.miniGadgetInfoRarity, 丕丗丘丑丛与丑业丒:  val_55);
        if(val_2 != null)
        {
                val_56 = val_2.Index;
        }
        else
        {
                val_56 = 0.Index;
        }
        
        val_57 = BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  val_2.Index, 丘三丟三丁丂丙丑丆:  BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  val_47, 且万丛丒丁丏七丅东:  val_2.CurrentLevel, 丐丏上业丈丂与万丞:  false), 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        UnityEngine.Color val_26 = UnityEngine.Color.yellow;
        UnityEngine.Color32 val_27 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a});
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.gadgetEfficiency, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.丏丅世东东丟丅丂与(丂丐丏下万万丒三上:  BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  val_56, 丘三丟三丁丂丙丑丆:  val_2.CurrentLevel, 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false}), 东丑丛上专上下丕丌:  val_57, 丝丌且丝丛丙万丅丙:  new UnityEngine.Color32() {r = val_27.r & 4294967295, g = val_27.r & 4294967295, b = val_27.r & 4294967295, a = val_27.r & 4294967295}));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  且丑丝丟丁与上三丅.gadgetEfficiencyContainer, 丏业丟一东丂东丘丛:  true);
        bool val_30 = UnityEngine.Object.op_Implicit(exists:  且丑丝丟丁与上三丅.gadgetPropertyTable);
        label_56:
        val_58 = 0;
        goto label_58;
        label_81:
        int val_31 = val_2.Effects.Count;
        val_57 = 且丑丝丟丁与上三丅.effectsLabels.Item[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_57, 丏业丟一东丂东丘丛:  (val_58 < val_31) ? 1 : 0);
        if(val_58 < val_31)
        {
                val_59 = null;
            val_59 = null;
            System.ValueTuple<System.String, System.String, System.String> val_36 = WeaponSounds.三丘丒万丛丞与一不.Item[val_2.Effects.Item[0]];
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  且丑丝丟丁与上三丅.effectsLabels.Item[0], 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_37));
            System.ValueTuple<System.String, System.String, System.String> val_41 = WeaponSounds.三丘丒万丛丞与一不.Item[val_2.Effects.Item[0]];
            val_57 = val_42;
            且丑丝丟丁与上三丅.effectsSprites.Item[0].spriteName = val_57;
            且丑丝丟丁与上三丅.effectsSprites.Item[0].ResetAndUpdateAnchors();
        }
        
        val_58 = 1;
        label_58:
        if(val_58 < 且丑丝丟丁与上三丅.effectsLabels.Count)
        {
            goto label_81;
        }
        
        if(且丑丝丟丁与上三丅.specialTable == 0)
        {
                return;
        }
        
        val_46 = 且丑丝丟丁与上三丅.specialTable;
    }
    internal static void 丞丐下丝专丈丄丞上(string 丆三丝丝一丕与丝丆, int 丙丅东业丟丂七丈业, int 丕丄上丘万业丙丄世, PropertiesArmoryItemContainer 丘丐丝丟业丘丏东专, bool 丐东丘丘下万业万东, bool 东丈丒三丞与业世一)
    {
        int val_27;
        System.Collections.Generic.List<GadgetPropertyItem> val_28;
        var val_29;
        int val_30;
        string val_31;
        UILabel val_32;
        val_27 = 丐东丘丘下万业万东;
        val_28 = 丘丐丝丟业丘丏东专.gadgetsPropertiesList;
        if(val_28 == null)
        {
            goto label_34;
        }
        
        val_29 = 0;
        var val_2 = (val_27 != true) ? (3 + 1) : 3;
        goto label_3;
        label_31:
        val_27 = ((val_27 != true) ? -9 : -13) + val_29;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丘丐丝丟业丘丏东专.gadgetsPropertiesList.Item[0].gameObject, 丏业丟一东丂东丘丛:  (val_27 < val_2) ? 1 : 0);
        if(val_27 >= val_2)
        {
            goto label_8;
        }
        
        if((-9) > 6)
        {
            goto label_9;
        }
        
        val_30 = BalanceController.东丞三万丂丅丑丏丆(丆万一不丌且东丐丐:  丆三丝丝一丕与丝丆, 丞丌东丟且丒丐丑丂:  丙丅东业丟丂七丈业);
        val_31 = 丆三丝丝一丕与丝丆;
        int val_7 = BalanceController.东丞三万丂丅丑丏丆(丆万一不丌且东丐丐:  val_31, 丞丌东丟且丒丐丑丂:  丕丄上丘万业丙丄世);
        goto label_22;
        label_9:
        val_27 = 0;
        val_30 = 0;
        goto label_16;
        label_22:
        val_27 = ;
        label_16:
        GadgetPropertyItem val_16 = 丘丐丝丟业丘丏东专.gadgetsPropertiesList.Item[0];
        val_16.propertyLabel.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  null, 东丑丛上专上下丕丌:  val_27);
        label_8:
        val_28 = 丘丐丝丟业丘丏东专.gadgetsPropertiesList;
        val_29 = 1;
        label_3:
        if(val_29 < val_28.Count)
        {
            goto label_31;
        }
        
        bool val_19 = UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.gadgetPropertyTable);
        label_34:
        val_32 = 丘丐丝丟业丘丏东专.weaponsRarityLabel;
        if(val_32 == 0)
        {
                return;
        }
        
        val_32 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
        if((val_32.ContainsKey(key:  丆三丝丝一丕与丝丆)) == false)
        {
                return;
        }
        
        丘丐丝丟业丘丏东专.weaponsRarityLabel.text = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[丆三丝丝一丕与丝丆].七东与丄丕丁丛世三());
    }
    internal static void 丄丂东丕一上丌七丘(string 丆三丝丝一丕与丝丆, PropertiesArmoryItemContainer 丘丐丝丟业丘丏东专, 三丅丁丗丗丝丂万且 丛丟三丘丛且业丈丏, 三丅丁丗丗丝丂万且 丄不丝三丈下丝丞专, bool 下丆下丝万三丒丗丛, ref bool 丆丞不且丑丈丄不丞, ref bool 上不专七丛不万丈丑, bool 丄丄丁丘世东丕东丗 = True, 丕丑丙丑丙东丌丘丕 丞丌东丟且丒丐丑丂, int 丄丄丒丘丏一丗丆与 = 0)
    {
        string val_110;
        string val_120;
        var val_121;
        ItemRarity val_122;
        PropertiesArmoryItemContainer val_123;
        string val_124;
        var val_125;
        bool val_126;
        丕丑丙丑丙东丌丘丕 val_127;
        bool val_128;
        丕丑丙丑丙东丌丘丕 val_129;
        float val_132;
        var val_133;
        var val_134;
        int val_135;
        float val_136;
        丕丑丙丑丙东丌丘丕 val_137;
        float val_138;
        var val_139;
        int val_140;
        int val_142;
        int val_143;
        UILabel val_144;
        int val_145;
        int val_146;
        int val_147;
        string val_148;
        int val_149;
        var val_150;
        var val_151;
        val_120 = 1152921539003093616;
        val_121 = 1152921539003089536;
        val_122 = 丛丟三丘丛且业丈丏;
        val_123 = 丘丐丝丟业丘丏东专;
        val_124 = 丆三丝丝一丕与丝丆;
        if(val_122 == null)
        {
                return;
        }
        
        bool val_1 = WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  val_124);
        val_125 = null;
        val_125 = null;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟, y:  0);
        bool val_3 = ProgressRoadView.IsActive;
        if(val_122.丐专丒丟丈丛丈丂业() == false)
        {
            goto label_8;
        }
        
        val_126 = 0;
        if(val_124 == null)
        {
            goto label_13;
        }
        
        if(val_122.不丅丟丞丏丒丌三丌() == true)
        {
            goto label_10;
        }
        
        goto label_13;
        label_8:
        if(val_124 == null)
        {
            goto label_12;
        }
        
        label_10:
        bool val_6 = val_2 | (~val_1);
        val_6 = val_3 | val_6;
        val_126 = val_6;
        goto label_13;
        label_12:
        val_126 = false;
        label_13:
        val_127 = 丞丌东丟且丒丐丑丂;
        丆丞不且丑丈丄不丞 = val_126;
        if(val_122.丐专丒丟丈丛丈丂业() == false)
        {
            goto label_14;
        }
        
        val_128 = 0;
        if((val_124 == null) || (val_122.不丅丟丞丏丒丌三丌() == true))
        {
            goto label_17;
        }
        
        bool val_9 = val_2 | (~val_1);
        val_9 = val_3 | val_9;
        val_128 = val_9;
        goto label_17;
        label_14:
        val_128 = false;
        label_17:
        ItemRarity val_10 = (丄不丝三丈下丝丞专 == 0) ? (val_122) : 丄不丝三丈下丝丞专;
        上不专七丛不万丈丑 = val_128;
        if(val_127 == null)
        {
            goto label_18;
        }
        
        bool val_11 = ArmoryInfoScreenController.丈丛丁丅丈三与专丈();
        goto label_19;
        label_18:
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                丕丑丙丑丙东丌丘丕 val_13 = null;
            val_127 = val_13;
            val_13 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  0);
        }
        else
        {
                val_127 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_122.业东丅东丌上丗丑不());
        }
        
        if(val_127 == null)
        {
            goto label_27;
        }
        
        label_19:
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
            goto label_30;
        }
        
        丕丑丙丑丙东丌丘丕 val_19 = null;
        val_129 = val_19;
        val_19 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  1, 丏丆丐丑专与丄丘丞:  0);
        goto label_34;
        label_30:
        val_129 = BalanceController.丌丛丄丙丘丈与下专(丞丌东丟且丒丐丑丂:  val_127, 丐丏上业丈丂与万丞:  false);
        goto label_34;
        label_27:
        if((ArmoryInfoScreenController.丈丛丁丅丈三与专丈() | (WeaponManager.丐上业丐丏丐万世丑().Contains(item:  val_124))) != false)
        {
                丕丑丙丑丙东丌丘丕 val_24 = WeaponManager.丝丒丂丂丏丞一与丆(丈下丑丆上丏丗丈专:  val_122);
        }
        
        val_129 = val_122.丐七丐丝与丒七丈丐();
        val_127 = val_129;
        label_34:
        val_132 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_127, 专东丑丑丁丞丛三丗:  true);
        if(ShopNGUIController.丛丐丛专丟丞万三七() < 100)
        {
            goto label_50;
        }
        
        三丅丁丗丗丝丂万且 val_29 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_122.三与丛丑且丐丈业丌());
        if(val_29 == null)
        {
            goto label_50;
        }
        
        float val_30 = val_29.丄一专世丌世不专丛();
        if(val_30 <= val_132)
        {
            goto label_50;
        }
        
        val_133 = ShopNGUIController.丐丅丒丞不丘专丗下(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_124, 七丆丒与丗丌丄且丂:  val_122.丒万丕七专不丏丞丌()));
        var val_34 = (val_133 != true) ? (val_30) : (val_132);
        if(val_123 != null)
        {
            goto label_55;
        }
        
        goto label_54;
        label_50:
        val_133 = 0;
        if(val_123 != null)
        {
            goto label_55;
        }
        
        label_54:
        label_55:
        if(丘丐丝丟业丘丏东专.damageUpForSettingsLabel != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  丘丐丝丟业丘丏东专.damageUpForSettingsLabel, 丏业丟一东丂东丘丛:  val_133 & 1);
        }
        
        if(丘丐丝丟业丘丏东专.damageUpForSettingsBackground != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  丘丐丝丟业丘丏东专.damageUpForSettingsBackground, 丏业丟一东丂东丘丛:  val_133 & 1);
        }
        
        int val_40 = BalanceController.不丟丏丟丙万下七业(丟丈一下东业一丝丆:  val_122.业东丅东丌上丗丑不());
        int val_42 = BalanceController.丈丗丙世不上不丄丟(丟丈一下东业一丝丆:  val_122.业东丅东丌上丗丑不());
        if(val_122.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_122.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_69;
        }
        
        }
        
        val_134 = new float[4];
        val_135 = val_47.Length;
        if(val_135 == 0)
        {
                val_135 = val_47.Length;
        }
        
        val_136 = (float)val_40;
        val_134[0] = val_132;
        if(val_135 <= 1)
        {
                val_135 = val_47.Length;
        }
        
        val_134[1] = val_136;
        if(val_135 <= 2)
        {
                val_135 = val_47.Length;
        }
        
        val_134[2] = (float)BalanceController.与丘东万丆丗丅丞专(丟丈一下东业一丝丆:  val_122.业东丅东丌上丗丑不());
        val_137 = val_127;
        val_138 = (float)val_42;
        val_134[3] = val_138;
        val_139 = new float[4];
        if(丄丄丁丘世东丕东丗 != false)
        {
                val_132 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_129, 专东丑丑丁丞丛三丗:  true);
        }
        
        val_140 = val_48.Length;
        if(val_140 == 0)
        {
                val_140 = val_48.Length;
        }
        
        val_139[0] = val_132;
        if(val_140 <= 1)
        {
                val_140 = val_48.Length;
        }
        
        val_139[1] = val_136;
        if(val_140 <= 2)
        {
                val_140 = val_48.Length;
        }
        
        val_139[2] = (float)BalanceController.与丘东万丆丗丅丞专(丟丈一下东业一丝丆:  val_122.业东丅东丌上丗丑不());
        goto label_85;
        label_69:
        val_134 = new float[3];
        val_142 = val_50.Length;
        if(val_142 == 0)
        {
                val_142 = val_50.Length;
        }
        
        val_136 = (float)val_40;
        val_134[0] = val_132;
        if(val_142 <= 1)
        {
                val_142 = val_50.Length;
        }
        
        val_138 = (float)val_42;
        val_134[1] = val_136;
        val_134[2] = val_138;
        val_137 = val_127;
        val_139 = new float[3];
        if(丄丄丁丘世东丕东丗 != false)
        {
                val_132 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_129, 专东丑丑丁丞丛三丗:  true);
        }
        
        val_143 = val_51.Length;
        if(val_143 == 0)
        {
                val_143 = val_51.Length;
        }
        
        val_139[0] = val_132;
        if(val_143 <= 1)
        {
                val_143 = val_51.Length;
        }
        
        val_139[1] = val_136;
        label_85:
        mem2[0] = val_138;
        if(val_122.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_122.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_98;
        }
        
        }
        
        丁丆丄丕丂丕万丝三.东丆丘丁丅丁且丏丘(丘丐丝丟业丘丏东专:  val_123, 丝丂丁丌丆三丆专且:  val_122, 丈丞丝下丞丏下丁三:  val_137);
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.damage)) != false)
        {
                val_132 = val_134[0];
            丘丐丝丟业丘丏东专.damage.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  val_132, 东丑丛上专上下丕丌:  val_139[0], 丂丞丅下丈丐丐一专:  val_133 & 1);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.fireRate)) != false)
        {
                val_132 = val_134[1];
            丘丐丝丟业丘丏东专.fireRate.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  UnityEngine.Mathf.RoundToInt(f:  val_132), 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  val_139[1]));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.capacity)) != false)
        {
                val_132 = val_134[2];
            丘丐丝丟业丘丏东专.capacity.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  UnityEngine.Mathf.RoundToInt(f:  val_132), 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  val_139[2]));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.mobility)) == false)
        {
            goto label_155;
        }
        
        val_144 = 丘丐丝丟业丘丏东专.mobility;
        val_132 = val_134[3];
        val_145 = UnityEngine.Mathf.RoundToInt(f:  val_132);
        float val_125 = val_139[3];
        goto label_134;
        label_98:
        丁丆丄丕丂丕万丝三.东丆丘丁丅丁且丏丘(丘丐丝丟业丘丏东专:  val_123, 丝丂丁丌丆三丆专且:  val_122, 丈丞丝下丞丏下丁三:  val_137);
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.damageMelee)) != false)
        {
                val_132 = val_134[0];
            丘丐丝丟业丘丏东专.damageMelee.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  val_132, 东丑丛上专上下丕丌:  val_139[0], 丂丞丅下丈丐丐一专:  val_133 & 1);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.fireRateMElee)) != false)
        {
                val_132 = val_134[1];
            丘丐丝丟业丘丏东专.fireRateMElee.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  UnityEngine.Mathf.RoundToInt(f:  val_132), 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  val_139[1]));
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  丘丐丝丟业丘丏东专.mobilityMelee)) == false)
        {
            goto label_155;
        }
        
        val_144 = 丘丐丝丟业丘丏东专.mobilityMelee;
        val_132 = val_134[2];
        val_145 = UnityEngine.Mathf.RoundToInt(f:  val_132);
        label_134:
        val_144.text = 上丑三丁丄丛丁万丑.丝不丈丅丝丁丙丆丂(丂丐丏下万万丒三上:  val_145, 东丑丛上专上下丕丌:  UnityEngine.Mathf.RoundToInt(f:  val_139[2]));
        label_155:
        if(丘丐丝丟业丘丏东专.efficiencyDamage != 0)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  丘丐丝丟业丘丏东专.efficiencyDamage, 丕丗丘丑丛与丑业丒:  System.String.alignConst);
        }
        
        val_146 = System.String.alignConst;
        val_147 = val_122.七丙丛与万且专三三();
        int val_82 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丗丝丄丐丗专丘业世(丈丘丝一丗下丈丐不:  val_147);
        val_122 = 1152921504848912384;
        if(val_82 < 1)
        {
            goto label_169;
        }
        
        val_148 = val_146;
        if(丘丐丝丟业丘丏东专.energy != null)
        {
                val_147 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7150");
            val_148 = System.String.Format(format:  "{0} {1}", arg0:  val_147, arg1:  val_82);
        }
        
        if(丘丐丝丟业丘丏东专.energyCount == null)
        {
            goto label_174;
        }
        
        val_147 = 0;
        val_146 = val_82.ToString();
        goto label_174;
        label_169:
        val_148 = val_146;
        label_174:
        if(丘丐丝丟业丘丏东专.energy != null)
        {
                val_147 = val_148;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丘丐丝丟业丘丏东专.energy, 丕丗丘丑丛与丑业丒:  val_147);
        }
        
        if(丘丐丝丟业丘丏东专.energyCount != null)
        {
                val_147 = val_146;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丘丐丝丟业丘丏东专.energyCount, 丕丗丘丑丛与丑业丒:  val_147);
        }
        
        if(丘丐丝丟业丘丏东专.efficiencyDamageFormatted != null)
        {
                val_147 = System.String.alignConst;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丘丐丝丟业丘丏东专.efficiencyDamageFormatted, 丕丗丘丑丛与丑业丒:  val_147);
        }
        
        val_120 = 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_10);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丘丐丝丟业丘丏东专.miniWeaponInfoRarity, 丕丗丘丑丛与丑业丒:  val_120);
        丁丆丄丕丂丕万丝三.丙丙丅不三业丕与丁(且丑丝丟丁与上三丅:  val_123, 丆万一不丌且东丐丐:  val_124, 且丙丙丁丅丐七丌丐:  val_127, 丄丄丒丘丏一丗丆与:  丄丄丒丘丏一丗丆与);
        bool val_129 = val_1;
        val_129 = val_2 | (~val_129);
        val_129 = val_3 | val_129;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丘丐丝丟业丘丏东专.specialParams, 丏业丟一东丂东丘丛:  val_129);
        if(丘丐丝丟业丘丏东专.weaponsRarityLabel != 0)
        {
                val_120 = val_10;
            丘丐丝丟业丘丏东专.weaponsRarityLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2393")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2393")) + ": "(": ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_120)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_120));
        }
        
        val_124 = 1152921524394922096;
        val_121 = 0;
        goto label_197;
        label_239:
        if(丘丐丝丟业丘丏东专.effectsLabels.Item[0] != 0)
        {
                val_120 = val_10.丞丁下丅上不且丐丄().Count;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丘丐丝丟业丘丏东专.effectsLabels.Item[0].gameObject, 丏业丟一东丂东丘丛:  (val_121 < val_120) ? 1 : 0);
            if(val_121 < val_10.丞丁下丅上不且丐丄().Count)
        {
                if(val_10.丞丁下丅上不且丐丄().Item[0] == 11)
        {
                val_149 = val_10.且三丁业下业七丅丘().ToString() + "X ";
        }
        else
        {
                val_149 = System.String.alignConst;
        }
        
            val_150 = null;
            val_150 = null;
            System.ValueTuple<System.String, System.String, System.String> val_109 = WeaponSounds.三丘丒万丛丞与一不.Item[val_10.丞丁下丅上不且丐丄().Item[0]];
            val_122 = 1152921504848912384;
            val_120 = val_149 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_110)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_110));
            丘丐丝丟业丘丏东专.effectsLabels.Item[0].text = val_120;
            if(丘丐丝丟业丘丏东专.effectsSprites.Item[0] != 0)
        {
                val_151 = null;
            val_151 = null;
            System.ValueTuple<System.String, System.String, System.String> val_118 = WeaponSounds.三丘丒万丛丞与一不.Item[val_10.丞丁下丅上不且丐丄().Item[0]];
            val_120 = val_82;
            丘丐丝丟业丘丏东专.effectsSprites.Item[0].spriteName = val_120;
            丘丐丝丟业丘丏东专.effectsSprites.Item[0].ResetAndUpdateAnchors();
        }
        
        }
        
        }
        
        val_121 = 1;
        label_197:
        if(val_121 < 丘丐丝丟业丘丏东专.effectsLabels.Count)
        {
            goto label_239;
        }
        
        if(丘丐丝丟业丘丏东专.specialTable == 0)
        {
                return;
        }
        
        val_123 = 丘丐丝丟业丘丏东专.specialTable;
    }
    private static void 丙丙丅不三业丕与丁(PropertiesArmoryItemContainer 且丑丝丟丁与上三丅, string 丆万一不丌且东丐丐, 丕丑丙丑丙东丌丘丕 且丙丙丁丅丐七丌丐, int 丄丄丒丘丏一丗丆与)
    {
        var val_15;
        var val_16;
        val_15 = 且丙丙丁丅丐七丌丐;
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丆万一不丌且东丐丐);
        if(val_1 != null)
        {
                if(val_1.东七与与不丅丙上上() == false)
        {
            goto label_4;
        }
        
        }
        
        val_16 = 1;
        if(val_15 != null)
        {
            goto label_7;
        }
        
        goto label_6;
        label_4:
        val_16 = 0;
        if(val_15 != null)
        {
            goto label_7;
        }
        
        label_6:
        val_15 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  丆万一不丌且东丐丐);
        if((val_16 & 1) == 0)
        {
                if((val_15 != null) || ((WeaponManager.丕下丘丆万丌丝丟丞(丒东业不丐丑丕丄丆:  丆万一不丌且东丐丐)) == false))
        {
            goto label_15;
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丏业丟一东丂东丘丛:  false);
        return;
        label_15:
        if(val_15 == null)
        {
            goto label_19;
        }
        
        label_7:
        int val_6 = val_15.丈一下下丞世三丑丄();
        label_29:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3655"), arg0:  UnityEngine.Mathf.Min(a:  val_15.丈一下下丞世三丑丄() + 丄丄丒丘丏一丗丆与, b:  65)));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丏业丟一东丂东丘丛:  true);
        return;
        label_19:
        int val_13 = val_1.丐七丐丝与丒七丈丐().丈一下下丞世三丑丄();
        ChestBatleRoyale.丝业丞丕丟万万丝丙 val_14 = 0;
        goto label_29;
    }
    private static void 丝一下丄万丏丞丝东(PropertiesArmoryItemContainer 且丑丝丟丁与上三丅, string 丆万一不丌且东丐丐)
    {
        string val_12;
        var val_13;
        丕丈丏丝丗下丟丅丂 val_2 = 0;
        val_12 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
        bool val_3 = val_12.TryGetValue(key:  丆万一不丌且东丐丐, value: out  val_2);
        if(val_2 == 0)
        {
            goto label_4;
        }
        
        if((Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().丞东丐丂丄业业丂万(丞丅上丏丂且下丅与:  丆万一不丌且东丐丐)) == false)
        {
            goto label_8;
        }
        
        val_13 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒();
        int val_7 = val_13.三三三东丑丁且与万(丞丅上丏丂且下丅与:  丆万一不丌且东丐丐);
        goto label_12;
        label_4:
        if(且丑丝丟丁与上三丅 != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_8:
        val_13 = val_2;
        label_12:
        val_12 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3655"), arg0:  val_13.专丂丏世且丗丏丌丝());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丕丗丘丑丛与丑业丒:  val_12);
        label_14:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丏业丟一东丂东丘丛:  (val_2 != 0) ? 1 : 0);
    }
    private static void 丂世丆丒丁丌丙丗一(PropertiesArmoryItemContainer 且丑丝丟丁与上三丅, int 且丂丟丈丈丑东丈丙, int 丈丘丝一丗下丈丐不 = 0)
    {
        int val_7 = 丈丘丝一丗下丈丐不;
        int val_2 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().三三三东丑丁且与万(丞世不丒下上上丝丑:  且丂丟丈丈丑东丈丙);
        if(val_7 > 0)
        {
            goto label_4;
        }
        
        val_7 = val_2;
        if(val_2 <= 0)
        {
            goto label_5;
        }
        
        label_4:
        if(且丑丝丟丁与上三丅 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3655"), arg0:  val_7));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<UILabel>(不丗上三丛丒上东丑:  且丑丝丟丁与上三丅.weaponCurrentLevel, 丏业丟一东丂东丘丛:  true);
        return;
        label_5:
        int val_6 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  且丂丟丈丈丑东丈丙);
        if(且丑丝丟丁与上三丅 != null)
        {
            goto label_14;
        }
        
        goto label_15;
    }
    private static void 东丆丘丁丅丁且丏丘(PropertiesArmoryItemContainer 丘丐丝丟业丘丏东专, 三丅丁丗丗丝丂万且 丝丂丁丌丆三丆专且, 丕丑丙丑丙东丌丘丕 丈丞丝下丞丏下丁三)
    {
        var val_28;
        var val_30;
        System.Collections.Generic.List<UnityEngine.GameObject> val_31;
        UnityEngine.Color val_33;
        float val_34;
        丕丑丙丑丙东丌丘丕 val_35;
        var val_36;
        var val_38;
        var val_39;
        var val_40;
        System.Action<UnityEngine.GameObject> val_42;
        var val_43;
        val_28 = null;
        val_28 = null;
        if((丁丆丄丕丂丕万丝三.<>c.<>9__10_0) == null)
        {
            goto label_4;
        }
        
        label_39:
        丘丐丝丟业丘丏东专.weaponEfficiencyArrowUp.ForEach(action:  丁丆丄丕丂丕万丝三.<>c.<>9__10_0);
        val_30 = null;
        val_31 = 丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown;
        val_30 = null;
        if((丁丆丄丕丂丕万丝三.<>c.<>9__10_1) == null)
        {
            goto label_8;
        }
        
        label_43:
        val_31.ForEach(action:  丁丆丄丕丂丕万丝三.<>c.<>9__10_1);
        UnityEngine.Color val_2 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "ArsenalEfficiencyCompare_Equals");
        val_33 = val_2.r;
        val_34 = val_2.b;
        .且丄丑丙丗下丆七丁 = val_2;
        mem[1152921539004325508] = val_2.g;
        mem[1152921539004325512] = val_34;
        mem[1152921539004325516] = val_2.a;
        if((丝丂丁丌丆三丆专且 == null) || (丈丞丝下丞丏下丁三 == null))
        {
            goto label_12;
        }
        
        int val_3 = BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  丈丞丝下丞丏下丁三);
        丕丑丙丑丙东丌丘丕 val_5 = 上丑三丁丄丛丁万丑.三下不丅世丑世丕上(七丆丒与丗丌丄且丂:  丝丂丁丌丆三丆专且.丒万丕七专不丏丞丌());
        if(val_5 != null)
        {
                val_35 = val_5;
            int val_6 = BalanceController.丄丄丑丒丂世丟丅下(丞丌东丟且丒丐丑丂:  val_35);
        }
        
        if(val_3 <= val_6)
        {
            goto label_20;
        }
        
        val_36 = null;
        val_36 = null;
        if((丁丆丄丕丂丕万丝三.<>c.<>9__10_3) == null)
        {
            goto label_23;
        }
        
        label_70:
        丘丐丝丟业丘丏东专.weaponEfficiencyArrowUp.ForEach(action:  丁丆丄丕丂丕万丝三.<>c.<>9__10_3);
        UnityEngine.Color val_7 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "ArsenalEfficiencyCompare_Green");
        .且丄丑丙丗下丆七丁 = val_7;
        mem[1152921539004325508] = val_7.g;
        mem[1152921539004325512] = val_7.b;
        mem[1152921539004325516] = val_7.a;
        val_31 = 1152921519068977584;
        val_38 = 1152921530949963856;
        val_39 = 0;
        goto label_25;
        label_34:
        UIBasicSprite val_9 = 丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown.Item[0].GetComponent<UIBasicSprite>();
        if((UnityEngine.Object.op_Implicit(exists:  val_9)) != false)
        {
                val_33 = (丁丆丄丕丂丕万丝三.下丌丛三下专丘丐丕)[1152921539004325488].且丄丑丙丗下丆七丁;
            val_9.color = new UnityEngine.Color() {r = val_33, g = val_2.g, b = val_34, a = val_2.a};
        }
        
        val_39 = 1;
        label_25:
        if(val_39 < 丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown.Count)
        {
            goto label_34;
        }
        
        goto label_44;
        label_4:
        丁丆丄丕丂丕万丝三.<>c.<>9__10_0 = new System.Action<UnityEngine.GameObject>(object:  丁丆丄丕丂丕万丝三.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丁丆丄丕丂丕万丝三.<>c::丑丈丟丑丕下丞丝丙(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(丘丐丝丟业丘丏东专.weaponEfficiencyArrowUp != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_8:
        丁丆丄丕丂丕万丝三.<>c.<>9__10_1 = new System.Action<UnityEngine.GameObject>(object:  丁丆丄丕丂丕万丝三.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丁丆丄丕丂丕万丝三.<>c::丘丝丝丅丄丁上丕丐(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(val_31 != null)
        {
            goto label_43;
        }
        
        goto label_43;
        label_20:
        if(val_3 >= val_6)
        {
            goto label_44;
        }
        
        val_40 = null;
        val_40 = null;
        val_42 = 丁丆丄丕丂丕万丝三.<>c.<>9__10_4;
        if(val_42 == null)
        {
                System.Action<UnityEngine.GameObject> val_14 = null;
            val_42 = val_14;
            val_14 = new System.Action<UnityEngine.GameObject>(object:  丁丆丄丕丂丕万丝三.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丁丆丄丕丂丕万丝三.<>c::丐下一丆丞三丂丆丅(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            丁丆丄丕丂丕万丝三.<>c.<>9__10_4 = val_42;
        }
        
        丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown.ForEach(action:  val_14);
        val_33 = (丁丆丄丕丂丕万丝三.下丌丛三下专丘丐丕)[1152921539004325488].且丄丑丙丗下丆七丁;
        UnityEngine.Color val_15 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "ArsenalEfficiencyCompare_Red");
        float val_28 = (float)UnityEngine.Mathf.Abs(value:  丈丞丝下丞丏下丁三.丈一下下丞世三丑丄() - val_5.丈一下下丞世三丑丄());
        val_28 = val_28 / 5f;
        UnityEngine.Color val_20 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = val_33, g = val_2.g, b = val_34, a = val_2.a}, b:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a}, t:  val_28);
        .且丄丑丙丗下丆七丁 = val_20;
        mem[1152921539004325508] = val_20.g;
        mem[1152921539004325512] = val_20.b;
        mem[1152921539004325516] = val_20.a;
        val_31 = 1152921519068977584;
        val_38 = 1152921530949963856;
        val_43 = 0;
        goto label_54;
        label_63:
        UIBasicSprite val_22 = 丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown.Item[0].GetComponent<UIBasicSprite>();
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) != false)
        {
                val_33 = (丁丆丄丕丂丕万丝三.下丌丛三下专丘丐丕)[1152921539004325488].且丄丑丙丗下丆七丁;
            val_22.color = new UnityEngine.Color() {r = val_33, g = val_2.g, b = val_34, a = val_2.a};
        }
        
        val_43 = 1;
        label_54:
        if(val_43 < 丘丐丝丟业丘丏东专.weaponEfficiencyArrowDown.Count)
        {
            goto label_63;
        }
        
        label_44:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  丘丐丝丟业丘丏东专.weaponEfficiency, 丕丗丘丑丛与丑业丒:  val_3.ToString());
        label_12:
        丘丐丝丟业丘丏东专.weaponEfficiencyColorRessivers.ForEach(action:  new System.Action<UIWidget>(object:  new 丁丆丄丕丂丕万丝三.下丌丛三下专丘丐丕(), method:  System.Void 丁丆丄丕丂丕万丝三.下丌丛三下专丘丐丕::丅丞下丛丞丆丌世丟(UIWidget 三丟东丕丄丄下下丑)));
        return;
        label_23:
        丁丆丄丕丂丕万丝三.<>c.<>9__10_3 = new System.Action<UnityEngine.GameObject>(object:  丁丆丄丕丂丕万丝三.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丁丆丄丕丂丕万丝三.<>c::万专丟不丙万丙三丂(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(丘丐丝丟业丘丏东专.weaponEfficiencyArrowUp != null)
        {
            goto label_70;
        }
        
        goto label_70;
    }

}
