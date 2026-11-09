using UnityEngine;

namespace GadgetsMigrationToCombatLevels
{
    internal class 丈丛丛丗丝丝东丏下
    {
        // Fields
        private const string 不丟上丗丏与下丏丘 = "GadgetsInfo.FIRST_COMBAT_LEVELS_GADGETS_KEY";
        internal const string 丁丙丟三下丐丏丌丗 = "GadgetsInfo.GADGETS_LEVELS_V5_KEY";
        private const string 丗下丞丏下丟世万丁 = "GadgetsInfo.FirstForOurTier";
        internal static System.Collections.Generic.Dictionary<string, Rilisoft.丝丑丂丛万丐丈丘且> 丞业丕专丆七丛丑丗;
        internal static System.Collections.Generic.Dictionary<string, int> 下万丐丒丂丘且丕丛;
        private static System.Collections.Generic.Dictionary<string, string> 东丆丌丈丌丕丆丂丅;
        private static bool 上上丏世丁丂七一东;
        private static System.Collections.Generic.Dictionary<string, string> 业丕丆且丁丗下丄专;
        
        // Methods
        private static void 丕丒丌丙丝业七一万()
        {
            System.Collections.Generic.Dictionary<TKey, TElement> val_9;
            var val_10;
            var val_11;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_13;
            var val_14;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且> val_16;
            var val_17;
            val_10 = null;
            val_10 = null;
            if(GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.丞业丕专丆七丛丑丗 != null)
            {
                    return;
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "GadgetsInfo.FIRST_COMBAT_LEVELS_GADGETS_KEY")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "GadgetsInfo.FIRST_COMBAT_LEVELS_GADGETS_KEY", 下下丏一丙不丘丌丞:  "{}");
            }
            
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "GadgetsInfo.FIRST_COMBAT_LEVELS_GADGETS_KEY"));
            val_11 = null;
            val_11 = null;
            val_13 = 丈丛丛丗丝丝东丏下.<>c.<>9__8_0;
            val_14 = 0;
            if(val_13 != null)
            {
                    val_14 = 0;
            }
            else
            {
                    val_13 = null;
                val_13 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  丈丛丛丗丝丝东丏下.<>c.__il2cppRuntimeField_static_fields, method:  System.String 丈丛丛丗丝丝东丏下.<>c::专丌丑丒一不丗丕丄(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
                val_11 = null;
                丈丛丛丗丝丝东丏下.<>c.<>9__8_0 = val_13;
            }
            
            val_11 = null;
            val_16 = 丈丛丛丗丝丝东丏下.<>c.<>9__8_1;
            if(val_16 == null)
            {
                    val_16 = null;
                val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, Rilisoft.丝丑丂丛万丐丈丘且>(object:  丈丛丛丗丝丝东丏下.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.丝丑丂丛万丐丈丘且 丈丛丛丗丝丝东丏下.<>c::丐丌一业丅万丟丗丂(System.Collections.Generic.KeyValuePair<string, object> 丈丏万丄丒业丅丒一));
                丈丛丛丗丝丝东丏下.<>c.<>9__8_1 = val_16;
            }
            
            val_9 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String, Rilisoft.丝丑丂丛万丐丈丘且>(source:  null, keySelector:  val_13, elementSelector:  null);
            val_17 = null;
            val_17 = null;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.丞业丕专丆七丛丑丗 = val_9;
        }
        private static void 丘丄丟一丅丕丕三丗()
        {
            var val_8;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下 val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_15 = null;
            val_15 = null;
            if(GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.下万丐丒丂丘且丕丛 != null)
            {
                    return;
            }
            
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "GadgetsInfo.GADGETS_LEVELS_V5_KEY")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "GadgetsInfo.GADGETS_LEVELS_V5_KEY", 下下丏一丙不丘丌丞:  "{}");
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            val_16 = null;
            val_16 = null;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.下万丐丒丂丘且丕丛 = null;
            Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
            label_25:
            if((1928304464 & 1) == 0)
            {
                goto label_19;
            }
            
            ConfiguredValueTaskAwaiter val_10 = val_8.GetAwaiter();
            val_17 = null;
            val_17 = null;
            null.set_Item(key:  val_10._value._obj.丐丏七丌丕丗业且上(), value:  System.Convert.ToInt32(value:  val_10._value._obj));
            goto label_25;
            label_19:
            val_18 = 1928304384;
            val_19 = 0;
            val_14 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if( != 139)
            {
                    return;
            }
            
                return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        internal static void 与丞一丟丈丈且丑丑()
        {
            object val_4;
            var val_15;
            var val_16;
            string val_17;
            var val_18;
            object val_20;
            var val_21;
            var val_22;
            var val_23;
            val_15 = null;
            val_15 = null;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.东丆丌丈丌丕丆丂丅.Keys.GetEnumerator();
            label_13:
            if((1928478160 & 1) == 0)
            {
                goto label_5;
            }
            
            if((丌丝世丞世丛丆丅丟.丑丆丙丌三丁丑专丄(丌丘不丆丈丈世万上:  val_4.丐丏七丌丕丗业且上())) == false)
            {
                goto label_13;
            }
            
            val_16 = null;
            val_16 = null;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 下下丏一丙不丘丌丞:  (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) + 175, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            goto label_13;
            label_5:
            val_17 = 0;
            val_18 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_21;
            }
            
            if( == 0)
            {
                goto label_25;
            }
            
            if(88 != 88)
            {
                goto label_23;
            }
            
            goto label_25;
            label_21:
            if( == 0)
            {
                goto label_25;
            }
            
            label_23:
            label_25:
            val_20 = new GadgetCategory[3];
            val_21 = 0;
            goto label_26;
            label_43:
            GadgetCategory val_15 = val_20[0];
            val_17 = 丁下万丟且丟丛下业.与丞丑丙上丙丅丈丑(七丆丒与丗丌丄且丂:  val_15, 专丆丌丛东一不丑丙:  0);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17)) != true)
            {
                    val_22 = null;
                val_22 = null;
                if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.东丆丌丈丌丕丆丂丅.ContainsKey(key:  val_17)) != false)
            {
                    val_23 = null;
                val_23 = null;
                val_17 = GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.东丆丌丈丌丕丆丂丅.Item[val_17];
                丆丟七丌丞东丆丕丌.丏下丕丏丘丅与丂丐(丗丑丐丕丟丝且下丕:  val_17, 七丆丒与丗丌丄且丂:  val_15, 专丆丌丛东一不丑丙:  0, 且丙丄且丐上与丈丆:  false);
            }
            
            }
            
            val_21 = 1;
            label_26:
            if(val_21 < val_9.Length)
            {
                goto label_43;
            }
            
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.丁专丐丙丅丁丕丙业();
        }
        private static void 丁专丐丙丅丁丕丙业()
        {
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            System.Collections.Generic.Dictionary<System.String, System.String> val_47;
            var val_48;
            var val_49;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.丕专丌丛不丄丛丄下();
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_singularity")) == false)
            {
                goto label_8;
            }
            
            val_25 = null;
            val_25 = null;
            if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_singularity"], b:  "gadget_singularity_up1")) == false)
            {
                goto label_8;
            }
            
            val_26 = null;
            val_26 = null;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_singularity", value:  "gadget_singularity");
            val_27 = 1;
            goto label_12;
            label_8:
            val_27 = 0;
            label_12:
            val_28 = null;
            val_28 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_timewatch")) != false)
            {
                    val_29 = null;
                val_29 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_timewatch"], b:  "gadget_timewatch_up1")) != false)
            {
                    val_30 = null;
                val_30 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_timewatch", value:  "gadget_timewatch");
                val_27 = 1;
            }
            
            }
            
            val_31 = null;
            val_31 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_reflector")) != false)
            {
                    val_32 = null;
                val_32 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_reflector"], b:  "gadget_reflector_up1")) != false)
            {
                    val_33 = null;
                val_33 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_reflector", value:  "gadget_reflector");
                val_27 = 1;
            }
            
            }
            
            val_34 = null;
            val_34 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_fakebonus")) != false)
            {
                    val_35 = null;
                val_35 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_fakebonus"], b:  "gadget_fakebonus_up2")) != false)
            {
                    val_36 = null;
                val_36 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_fakebonus", value:  "gadget_fakebonus_up1");
                val_27 = 1;
            }
            
            }
            
            val_37 = null;
            val_37 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_medicalstation")) != false)
            {
                    val_38 = null;
                val_38 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_medicalstation"], b:  "gadget_medicalstation_up2")) != false)
            {
                    val_39 = null;
                val_39 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_medicalstation", value:  "gadget_medicalstation_up1");
                val_27 = 1;
            }
            
            }
            
            val_40 = null;
            val_40 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_pandorabox")) != false)
            {
                    val_41 = null;
                val_41 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_pandorabox"], b:  "gadget_pandorabox_up2")) != false)
            {
                    val_42 = null;
                val_42 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_pandorabox", value:  "gadget_pandorabox_up1");
                val_27 = 1;
            }
            
            }
            
            val_43 = null;
            val_43 = null;
            if((GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.ContainsKey(key:  "gadget_snowman")) != false)
            {
                    val_44 = null;
                val_44 = null;
                if((System.String.op_Equality(a:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Item["gadget_snowman"], b:  "gadget_snowman_up2")) != false)
            {
                    val_45 = null;
                val_45 = null;
                GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.set_Item(key:  "gadget_snowman", value:  "gadget_snowman_up1");
                val_27 = 1;
            }
            
            }
            
            val_46 = null;
            val_46 = null;
            val_47 = GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专;
            if((val_47.ContainsKey(key:  "gadget_ninjashurickens")) == false)
            {
                goto label_86;
            }
            
            val_48 = null;
            val_48 = null;
            val_47 = GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专;
            if((System.String.op_Equality(a:  val_47.Item["gadget_ninjashurickens"], b:  "gadget_ninjashurickens_up2")) == false)
            {
                goto label_86;
            }
            
            val_49 = null;
            val_49 = null;
            val_47 = GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专;
            val_47.set_Item(key:  "gadget_ninjashurickens", value:  "gadget_ninjashurickens_up1");
            goto label_90;
            label_86:
            if(val_27 == 0)
            {
                    return;
            }
            
            label_90:
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.万三丂丞一丘且东丅();
        }
        internal static void 丕专丌丛不丄丛丄下()
        {
            var val_7;
            var val_12;
            var val_13;
            var val_15;
            string val_16;
            var val_17;
            val_13 = null;
            val_13 = null;
            if(GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.上上丏世丁丂七一东 == true)
            {
                    return;
            }
            
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.上上丏世丁丂七一东 = true;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "GadgetsInfo.FirstForOurTier")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "GadgetsInfo.FirstForOurTier", 下下丏一丙不丘丌丞:  "{}");
            }
            
            object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "GadgetsInfo.FirstForOurTier"));
            Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
            label_25:
            if((1928810336 & 1) == 0)
            {
                goto label_19;
            }
            
            ConfiguredValueTaskAwaiter val_9 = val_7.GetAwaiter();
            val_15 = null;
            val_15 = null;
            val_16;
            if((val_9._value._obj != 0) && (val_9._value._obj != null))
            {
                    val_16 = 0;
            }
            
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专.Add(key:  val_9._value._obj.丐丏七丌丕丗业且上(), value:  val_16);
            goto label_25;
            label_19:
            val_17 = 0;
            val_12 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if(null == null)
            {
                    return;
            }
            
                if(133 != 133)
            {
                    return;
            }
            
                return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        private static void 万三丂丞一丘且东丅()
        {
            null = null;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "GadgetsInfo.FirstForOurTier", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专));
        }
        public 丈丛丛丗丝丝东丏下()
        {
        
        }
        private static 丈丛丛丗丝丝东丏下()
        {
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.丞业丕专丆七丛丑丗 = 0;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.下万丐丒丂丘且丕丛 = 0;
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(val_1 != null)
            {
                    val_1.Add(key:  "gadget_fakebonus_up2", value:  "gadget_fakebonus_up1");
            }
            else
            {
                    val_1.Add(key:  "gadget_fakebonus_up2", value:  "gadget_fakebonus_up1");
            }
            
            val_1.Add(key:  "gadget_medicalstation_up2", value:  "gadget_medicalstation_up1");
            if(val_1 != null)
            {
                    val_1.Add(key:  "gadget_pandorabox_up2", value:  "gadget_pandorabox_up1");
            }
            else
            {
                    val_1.Add(key:  "gadget_pandorabox_up2", value:  "gadget_pandorabox_up1");
            }
            
            val_1.Add(key:  "gadget_singularity_up1", value:  "gadget_singularity");
            if(val_1 != null)
            {
                    val_1.Add(key:  "gadget_reflector_up1", value:  "gadget_reflector");
            }
            else
            {
                    val_1.Add(key:  "gadget_reflector_up1", value:  "gadget_reflector");
            }
            
            val_1.Add(key:  "gadget_timewatch_up1", value:  "gadget_timewatch");
            if(val_1 != null)
            {
                    val_1.Add(key:  "gadget_snowman_up2", value:  "gadget_snowman_up1");
            }
            else
            {
                    val_1.Add(key:  "gadget_snowman_up2", value:  "gadget_snowman_up1");
            }
            
            val_1.Add(key:  "gadget_ninjashurickens_up2", value:  "gadget_ninjashurickens_up1");
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.东丆丌丈丌丕丆丂丅 = val_1;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.上上丏世丁丂七一东 = false;
            GadgetsMigrationToCombatLevels.丈丛丛丗丝丝东丏下.业丕丆且丁丗下丄专 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
