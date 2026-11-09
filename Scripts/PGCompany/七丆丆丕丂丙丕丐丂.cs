using UnityEngine;

namespace PGCompany
{
    internal static class 七丆丆丕丂丙丕丐丂
    {
        // Methods
        internal static PGCompany.ModuleData.ModuleCategory 丌丐丐丑丈一丛丗丕(CategoryNames 七丆丒与丗丌丄且丂)
        {
            if(七丆丒与丗丌丄且丂 > 5)
            {
                    return 0;
            }
            
            七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂 + 1;
            return (ModuleCategory)七丆丒与丗丌丄且丂;
        }
        internal static CategoryNames 七七七丌世丟丟丐且(PGCompany.ModuleData.ModuleCategory 七丆丒与丗丌丄且丂)
        {
            if((七丆丒与丗丌丄且丂 - 2) > 5)
            {
                    return 0;
            }
            
            var val_3 = 106025948;
            ModuleCategory val_2 = 七丆丒与丗丌丄且丂 - 1;
            val_3 = (106025948 + ((七丆丒与丗丌丄且丂 - 2)) << 2) + val_3;
            goto (106025948 + ((七丆丒与丗丌丄且丂 - 2)) << 2 + 106025948);
        }
        internal static ItemRarity 上丒一上丙丌丝上丐(PGCompany.ModuleData.ModuleRarity 丛丞丈丞丂三丐丂丐)
        {
            if((丛丞丈丞丂三丐丂丐 - 2) > 4)
            {
                    return 0;
            }
            
            var val_3 = 106025972;
            ModuleData.ModuleRarity val_2 = 丛丞丈丞丂三丐丂丐 - 1;
            val_3 = (106025972 + ((丛丞丈丞丂三丐丂丐 - 2)) << 2) + val_3;
            goto (106025972 + ((丛丞丈丞丂三丐丂丐 - 2)) << 2 + 106025972);
        }
        internal static PGCompany.ModuleData.ModuleRarity 丁丄丝业丘且下业丌(ItemRarity 丛丞丈丞丂三丐丂丐)
        {
            if((丛丞丈丞丂三丐丂丐 - 1) > 4)
            {
                    return 1;
            }
            
            丛丞丈丞丂三丐丂丐 = 丛丞丈丞丂三丐丂丐 + 1;
            return (ModuleData.ModuleRarity)丛丞丈丞丂三丐丂丐;
        }
        internal static bool 丒丅与丛业与丒丑业(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            var val_8;
            var val_9;
            val_8 = 世丝七与丝丒丐业下;
            val_9 = 0;
            if(val_8 == null)
            {
                    return (bool)val_9;
            }
            
            if(丕上业丕丘上丘七一 == null)
            {
                    return (bool)val_9;
            }
            
            if((val_8.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  丕上业丕丘上丘七一)) != false)
            {
                    val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                var val_6 = ((val_8.上丟丘下世七与丁世(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  丕上业丕丘上丘七一.业上丙丞丐丄丆丅七()), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != 0) ? 1 : 0;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        internal static bool 七东丆丙东丂三世三(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            var val_6;
            var val_7;
            if(丕上业丕丘上丘七一.丙丅丗丏丆丆世世丙() == false)
            {
                goto label_1;
            }
            
            if(丕上业丕丘上丘七一 == null)
            {
                goto label_2;
            }
            
            val_6 = 丕上业丕丘上丘七一.且丆丟业丞丕丑上且();
            return (bool)(val_6 >= 丕上业丕丘上丘七一.丏丈丁专专丘丒丂丂()) ? 1 : 0;
            label_1:
            val_7 = 0;
            return (bool)(val_6 >= 丕上业丕丘上丘七一.丏丈丁专专丘丒丂丂()) ? 1 : 0;
            label_2:
            val_6 = 0.且丆丟业丞丕丑上且();
            return (bool)(val_6 >= 丕上业丕丘上丘七一.丏丈丁专专丘丒丂丂()) ? 1 : 0;
        }
        internal static void 丑丌万三丄丞专三丝(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, UnityEngine.GameObject 丁七丏丝专丞丄丄丈)
        {
            UnityEngine.GameObject val_6;
            var val_7;
            System.Action val_9;
            ShopNGUIController val_10;
            var val_11;
            val_6 = 丁七丏丝专丞丄丄丈;
            七丆丆丕丂丙丕丐丂.丘丞上世丗丘丏丐东 val_1 = new 七丆丆丕丂丙丕丐丂.丘丞上世丗丘丏丐东();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丕上业丕丘上丘七一 = 丕上业丕丘上丘七一;
            if(丕上业丕丘上丘七一 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            .丒世丘丘上丆丝东丞 = 丕上业丕丘上丘七一.且与丏三不丟丂丙丏();
            System.Action val_3 = new System.Action(object:  val_1, method:  System.Void 七丆丆丕丂丙丕丐丂.丘丞上世丗丘丏丐东::丆业丂与丌丗与丅丕());
            val_7 = null;
            val_7 = null;
            val_9 = 七丆丆丕丂丙丕丐丂.<>c.<>9__6_1;
            if(val_9 == null)
            {
                    System.Action val_4 = null;
                val_9 = val_4;
                val_4 = new System.Action(object:  七丆丆丕丂丙丕丐丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 七丆丆丕丂丙丕丐丂.<>c::下下丄丅三且一专丒());
                七丆丆丕丂丙丕丐丂.<>c.<>9__6_1 = val_9;
            }
            
            val_10 = 1152921505261211648;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_11 = null;
                val_11 = null;
                val_10 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
                val_10.丆且上丁世专丛专丞(丒世丘丘上丆丝东丞:  (七丆丆丕丂丙丕丐丂.丘丞上世丗丘丏丐东)[1152921555817866960].丒世丘丘上丆丝东丞, 七丁上丁丒专丈七丙:  val_6, 丞一丁业丄一一业且:  "", 七丒上且丝业业下七:  val_3, 丘丅丌丄丐丟丑丈丘:  val_4, 丐丈上丂与上丂丒丏:  72, 丅丑丗丐丛丂丕丏丌:  0);
                return;
            }
            
            val_6 = (七丆丆丕丂丙丕丐丂.丘丞上世丗丘丏丐东)[1152921555817866960].丒世丘丘上丆丝东丞;
            上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  0, 丒世丘丘上丆丝东丞:  val_6, 七丒上且丝业业下七:  val_3, 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  0, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  72);
            return;
            label_1:
            mem[16] = 丕上业丕丘上丘七一;
            if(mem[16] != 0)
            {
                goto label_18;
            }
            
            goto label_19;
        }
        internal static bool 丏丘丅丂丟万丂丛专(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            if(世丝七与丝丒丐业下 == null)
            {
                    return (bool)世丝七与丝丒丐业下;
            }
            
            return 世丝七与丝丒丐业下.专丙七丞丆丝丆与丗(丕上业丕丘上丘七一:  丕上业丕丘上丘七一);
        }
        internal static void 东上七七丟丟与下上(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            丕上业丕丘上丘七一.且且丛世丟丈世丄丄(丙业与丙丗丝不丈东:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  62);
            世丝七与丝丒丐业下.丆专丆世专丐丈七专(丕上业丕丘上丘七一:  丕上业丕丘上丘七一);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal static void 丕丗世丐丗三业三丅(PGCompany.丗丟丅七东丄丙丟上 世丝七与丝丒丐业下, PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  63);
            世丝七与丝丒丐业下.丙专万丗丏丙丒上丂(丕上业丕丘上丘七一:  丕上业丕丘上丘七一, 七丆丟丗世丟且丒丆:  false);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal static string 世丗丘丙丘丛丛一丟(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, UIAtlas 不丗丐丘业专丂丝上)
        {
            string val_2 = System.String.Format(format:  "{0}_{1}", arg0:  "shop_stats", arg1:  丕上业丕丘上丘七一.与丝丅丘且丐上丅世());
            return (string)((不丗丐丘业专丂丝上.GetSprite(丒丘丏上丙丟丑丕丈:  val_2)) == 0) ? "shop_stats_ModDefault" : (val_2);
        }
        internal static string 丙丟丁丒七下丝七一(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, UIAtlas 不丗丐丘业专丂丝上)
        {
            string val_2 = System.String.Format(format:  "{0}_{1}", arg0:  "ModuleIcon", arg1:  丕上业丕丘上丘七一.与丝丅丘且丐上丅世());
            return (string)((不丗丐丘业专丂丝上.GetSprite(丒丘丏上丙丟丑丕丈:  val_2)) == 0) ? "ModuleIcon_ModDefault" : (val_2);
        }
        internal static System.Collections.Generic.List<丙且上东下丏丏丟下> 业且丆东丝下丗东丞()
        {
            var val_7;
            var val_22;
            PGCompany.丏丂一丗丙世丏丐三 val_23;
            var val_24;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_26;
            var val_27;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_29;
            var val_30;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_32;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_4 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>(capacity:  val_2.Count);
            List.Enumerator<T> val_5 = val_2.GetEnumerator();
            val_22 = 1152921536474029712;
            label_8:
            if(((-327688016) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_8 = val_7.丐丏七丌丕丗业且上();
            if(val_8 != null)
            {
                    var val_9 = (null == null) ? (val_8) : 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_4.Add(item:  val_23);
            goto label_8;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_24 = null;
            val_24 = null;
            val_26 = 七丆丆丕丂丙丕丐丂.<>c.<>9__12_0;
            if(val_26 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_10 = null;
                val_26 = val_10;
                val_10 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(object:  七丆丆丕丂丙丕丐丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 七丆丆丕丂丙丕丐丂.<>c::丞丗丄丟专丝一专丒(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                七丆丆丕丂丙丕丐丂.<>c.<>9__12_0 = val_26;
            }
            
            val_27 = null;
            val_27 = null;
            val_29 = 七丆丆丕丂丙丕丐丂.<>c.<>9__12_1;
            if(val_29 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_12 = null;
                val_29 = val_12;
                val_12 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(object:  七丆丆丕丂丙丕丐丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 七丆丆丕丂丙丕丐丂.<>c::丒七丞丌丑业丄上下(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                七丆丆丕丂丙丕丐丂.<>c.<>9__12_1 = val_29;
            }
            
            val_30 = null;
            val_30 = null;
            val_32 = 七丆丆丕丂丙丕丐丂.<>c.<>9__12_2;
            if(val_32 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_14 = null;
                val_32 = val_14;
                val_14 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(object:  七丆丆丕丂丙丕丐丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 七丆丆丕丂丙丕丐丂.<>c::不丘丈丁世丅专丂世(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                七丆丆丕丂丙丕丐丂.<>c.<>9__12_2 = val_32;
            }
            
            System.Collections.Generic.List<丙且上东下丏丏丟下> val_17 = new System.Collections.Generic.List<丙且上东下丏丏丟下>();
            List.Enumerator<T> val_18 = System.Linq.Enumerable.ToList<PGCompany.丏丂一丗丙世丏丐三>(source:  System.Linq.Enumerable.ThenBy<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(source:  System.Linq.Enumerable.ThenBy<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(source:  System.Linq.Enumerable.OrderBy<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(source:  val_4, keySelector:  val_10), keySelector:  val_12), keySelector:  val_14)).GetEnumerator();
            label_33:
            if(((-327688040) & 1) == 0)
            {
                goto label_29;
            }
            
            string val_19 = 0.丐丏七丌丕丗业且上();
            if(val_19 < 1)
            {
                goto label_33;
            }
            
            new 丙且上东下丏丏丟下() = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_19.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  96);
            val_17.Add(item:  new 丙且上东下丏丏丟下());
            goto label_33;
            label_29:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_17;
        }
        internal static 丙且上东下丏丏丟下 丆丒上丗一丙一三丕()
        {
            var val_27;
            Rilisoft.OfferItemType val_28;
            var val_29;
            var val_30;
            int val_31;
            var val_32;
            var val_33;
            var val_34;
            val_27 = null;
            val_27 = null;
            PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.万丞丘与丕丞下万丌.与丒上与丄丒丝三七(丑丝丏丂且不下一东:  ShopNGUIController.丏丙丅丕一丑丕丑丑.东丂丈与丄丛万丞丑());
            if(val_2 != null)
            {
                    val_28 = val_2.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_28 = 0.不业丙丒丂丞下丆丙();
            }
            
            val_29 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_28, 丞丅上丏丂且下丅与:  val_2.业上丙丞丐丄丆丅七());
            if(val_29 == null)
            {
                goto label_9;
            }
            
            if(null == null)
            {
                goto label_12;
            }
            
            val_29 = 0;
            goto label_12;
            label_9:
            label_12:
            ModuleCategory val_9 = val_29.万丕丅下上丄丗万丞();
            if((val_9 - 2) > 5)
            {
                goto label_38;
            }
            
            var val_27 = 106025992;
            ModuleCategory val_11 = val_9 - 1;
            val_27 = (106025992 + ((val_9 - 2)) << 2) + val_27;
            goto (106025992 + ((val_9 - 2)) << 2 + 106025992);
            label_38:
            val_30 = null;
            val_30 = null;
            System.Collections.Generic.List<三丈丟与丏丘丈丐万> val_12 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
            val_31 = System.String.alignConst;
            if(val_11 != 7)
            {
                goto label_17;
            }
            
            if(((Rilisoft.Singleton<PGCompany.ModulesController>.Instance.下丗且丆七丛丕与丕()) == null) || ((Rilisoft.Singleton<PGCompany.ModulesController>.Instance.与丁上丌丝丟丑一丏()) == false))
            {
                goto label_35;
            }
            
            val_32 = "Armor_Army_1";
            goto label_22;
            label_17:
            val_33 = 0;
            goto label_23;
            label_29:
            三丈丟与丏丘丈丐万 val_17 = val_12.Item[0];
            if(val_17.三丐三丞丘丕不丒专 != null)
            {
                    if(val_17.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == val_11)
            {
                goto label_27;
            }
            
            }
            
            val_33 = 1;
            label_23:
            if(val_33 < val_12.Count)
            {
                goto label_29;
            }
            
            goto label_35;
            label_27:
            val_31 = val_17.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丈一丂丏下东丑丂丘().ContainsKey(key:  val_17.三丐三丞丘丕不丒专.业东丅东丌上丗丑不())) == false)
            {
                goto label_35;
            }
            
            label_22:
            label_35:
            val_34 = 0;
            if((System.String.op_Inequality(a:  System.String.__il2cppRuntimeField_static_fields, b:  System.String.alignConst)) == false)
            {
                    return (丙且上东下丏丏丟下)val_34;
            }
            
            丙且上东下丏丏丟下 val_26 = null;
            val_34 = val_26;
            val_26 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  System.String.__il2cppRuntimeField_static_fields, 七丆丒与丗丌丄且丂:  val_11);
            return (丙且上东下丏丏丟下)val_34;
        }
        internal static PGCompany.ModuleData.ModuleType 丄丛专丝丐丞且丏丒(int 丆专且丕专丗与一丏)
        {
            int val_6;
            var val_7;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_9;
            val_6 = 丆专且丕专丗与一丏;
            PGCompany.丗丟丅七东丄丙丟上 val_2 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丞世不丒下上上丝丑:  val_6);
            if(val_2 == null)
            {
                    return 0;
            }
            
            val_6 = val_2.丆丟且丗丒不丄七丌();
            val_7 = null;
            val_7 = null;
            val_9 = 七丆丆丕丂丙丕丐丂.<>c.<>9__14_0;
            if(val_9 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_4 = null;
                val_9 = val_4;
                val_4 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  七丆丆丕丂丙丕丐丂.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 七丆丆丕丂丙丕丐丂.<>c::万且七丅丆丌专丂丟(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                七丆丆丕丂丙丕丐丂.<>c.<>9__14_0 = val_9;
            }
            
            PGCompany.丏丂一丗丙世丏丐三 val_5 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丏丂一丗丙世丏丐三>(source:  val_6, predicate:  val_4);
            if(val_5 == null)
            {
                    return 0;
            }
            
            return val_5.与丝丅丘且丐上丅世();
        }
        internal static bool 下丒丌丁丈三丆丑丁(int 丆专且丕专丗与一丏, PGCompany.ModuleData.ModuleType 丁丅丈丌丟世丗丗丟)
        {
            .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
            PGCompany.丗丟丅七东丄丙丟上 val_3 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.七丗丒丆一丛丞丁丌(丞世不丒下上上丝丑:  丆专且丕专丗与一丏);
            if(val_3 == null)
            {
                    return (bool)val_3;
            }
            
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_4 = val_3.丆丟且丗丒不丄七丌();
            if(val_4 != null)
            {
                    return val_4.Exists(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  new 七丆丆丕丂丙丕丐丂.丕丛业丁丏下一七丘(), method:  System.Boolean 七丆丆丕丂丙丕丐丂.丕丛业丁丏下一七丘::丒七上丙不丐丑上丂(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)));
            }
            
            return val_4.Exists(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  new 七丆丆丕丂丙丕丐丂.丕丛业丁丏下一七丘(), method:  System.Boolean 七丆丆丕丂丙丕丐丂.丕丛业丁丏下一七丘::丒七上丙不丐丑上丂(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)));
        }
    
    }

}
