using UnityEngine;

namespace Rilisoft
{
    internal static class 下丐丒一丝丈丝三丞
    {
        // Fields
        internal const string 丘丑专且丏下专三不 = "WU_";
        internal static readonly Rilisoft.OfferItemType[] 不三业丁一丄业丁丅;
        internal static readonly Rilisoft.OfferItemType[] 丑下丟且丐丌丟丌万;
        internal static readonly Rilisoft.OfferItemType[] 东丕丏丟丞丏丑丟丘;
        
        // Methods
        internal static bool 下七与万与东丂且且(Rilisoft.OfferItemType 丙丒七丄上与丏丙丙)
        {
            null = null;
            return System.Linq.Enumerable.Contains<Rilisoft.OfferItemType>(source:  Rilisoft.下丐丒一丝丈丝三丞.不三业丁一丄业丁丅, value:  丙丒七丄上与丏丙丙);
        }
        internal static UnityEngine.Texture 上与且丌上一丂丕丕(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            string val_9;
            var val_10;
            string val_11;
            val_9 = 下丅丙一丂丗丅丝七;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  val_9.Type)) == false)
            {
                goto label_4;
            }
            
            val_9 = val_9.Id;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_9.Type, 丞丅上丏丂且下丅与:  val_9)) == null)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_11 = "OfferMiniIcons/event_currency");
            }
            
            val_9 = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_1D8;
            label_1:
            val_10 = 0;
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_11);
            label_4:
            Rilisoft.OfferItemType val_7 = val_9.Type;
            if(val_7 != 1050)
            {
                    if(val_7 != 1100)
            {
                    return Rilisoft.下丐丒一丝丈丝三丞.不上下丙下丞丗且下(下丅丙一丂丗丅丝七:  val_9, 丄丄丁专丂三三丁且:  false);
            }
            
                val_11 = "OfferMiniIcons/battle_pass_exp";
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_11);
            }
            
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_11);
        }
        internal static UnityEngine.Texture 丟丝丕上东丙丗丂与(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            string val_11;
            var val_12;
            if(下丅丙一丂丗丅丝七 == null)
            {
                goto label_1;
            }
            
            if(下丅丙一丂丗丅丝七.Type != 1000)
            {
                goto label_2;
            }
            
            T[] val_2 = System.Array.Empty<System.Object>();
            val_11 = "Textures/Bank/Coins_Shop_Gem_1";
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  val_11 = "Textures/Bank/Coins_Shop_2", args:  System.Array.Empty<System.Object>()));
            label_1:
            val_12 = 0;
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  val_11, args:  System.Array.Empty<System.Object>()));
            label_2:
            if(下丅丙一丂丗丅丝七.Type == 1010)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  val_11, args:  System.Array.Empty<System.Object>()));
            }
            
            if(下丅丙一丂丗丅丝七.Type != 1050)
            {
                    return Rilisoft.下丐丒一丝丈丝三丞.不上下丙下丞丗且下(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丄丄丁专丂三三丁且:  false);
            }
            
            if((System.String.op_Equality(a:  下丅丙一丂丗丅丝七.Id, b:  "EventCurrency")) == false)
            {
                    return Rilisoft.下丐丒一丝丈丝三丞.不上下丙下丞丗且下(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丄丄丁专丂三三丁且:  false);
            }
            
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  val_11, args:  System.Array.Empty<System.Object>()));
        }
        internal static UnityEngine.Texture 不上下丙下丞丗且下(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, bool 丄丄丁专丂三三丁且 = False)
        {
            Rilisoft.OfferItemType val_97;
            string val_98;
            var val_100;
            var val_101;
            string val_102;
            var val_103;
            val_98 = 下丅丙一丂丗丅丝七;
            if(val_98 == null)
            {
                goto label_88;
            }
            
            val_97 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_98.Id);
            Rilisoft.OfferItemType val_3 = val_98.Type;
            if(val_97 == false)
            {
                goto label_4;
            }
            
            if(val_3 != 1020)
            {
                goto label_88;
            }
            
            label_97:
            label_49:
            UnityEngine.Texture val_4 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/Leprechaun_icon_big");
            goto label_117;
            label_4:
            if(val_3 != 10)
            {
                    if(val_98.Type != 1310)
            {
                    if(val_98.Type != 1340)
            {
                goto label_9;
            }
            
            }
            
            }
            
            val_97 = 1152921505317388288;
            val_98 = val_98.Id;
            val_100 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_98);
            if(val_100 == null)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            val_98 = val_100.与不丞丑七丘丁丂丛();
            label_113:
            label_27:
            label_117:
            val_100 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_98, 七丆丒与丗丌丄且丂:  val_100.万上丄下业丛丌不丈() - 1, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            return (UnityEngine.Texture)val_100;
            label_9:
            if(val_98.Type != 20)
            {
                goto label_16;
            }
            
            string val_14 = val_98.Id;
            goto label_113;
            label_16:
            if(((val_98.Type != 30) && (val_98.Type != 60)) && (val_98.Type != 50))
            {
                    if(val_98.Type != 40)
            {
                    if(val_98.Type != 70)
            {
                goto label_24;
            }
            
            }
            
            }
            
            label_80:
            int val_21 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_98.Id);
            string val_22 = val_98.Id;
            goto label_27;
            label_24:
            if(val_98.Type != 85)
            {
                goto label_28;
            }
            
            val_98 = val_98.Id;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_26 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_98);
            if(val_26 == null)
            {
                goto label_88;
            }
            
            string val_27 = val_26.丙三专万丛丟万丝丘();
            goto label_49;
            label_28:
            if(val_98.Type != 1000)
            {
                goto label_32;
            }
            
            if(丄丄丁专丂三三丁且 == true)
            {
                goto label_119;
            }
            
            val_101 = null;
            val_101 = null;
            val_102 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_36;
            label_32:
            if(val_98.Type != 1010)
            {
                goto label_37;
            }
            
            if(丄丄丁专丂三三丁且 == false)
            {
                goto label_38;
            }
            
            label_119:
            val_97 = val_98.Type;
            val_98 = val_98.Id;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_97, 丞丅上丏丂且下丅与:  val_98)) == null)
            {
                goto label_88;
            }
            
            goto label_117;
            label_37:
            if(val_98.Type != 1050)
            {
                goto label_42;
            }
            
            if(丄丄丁专丂三三丁且 == false)
            {
                goto label_43;
            }
            
            goto label_97;
            label_38:
            val_103 = null;
            val_103 = null;
            val_102 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            label_36:
            int val_35 = val_98.Count;
            label_122:
            string val_36 = BankController.丙不丒丒且世丆下丐(丏丂不专上丘丂不丅:  val_102, 世与丂且丘丐万丗丞:  0);
            goto label_49;
            label_42:
            if(val_98.Type != 80)
            {
                goto label_50;
            }
            
            val_98 = val_98.Id;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_98)) == null)
            {
                goto label_88;
            }
            
            goto label_113;
            label_43:
            val_97 = val_98.Id;
            val_100 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  val_97);
            if(val_100 == null)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            string val_45 = val_100.丐丙丁一丅丞不丅丟(丑丏万丈丟丝丝丌丗:  val_98.Count);
            goto label_49;
            label_50:
            if(val_98.Type != 1030)
            {
                goto label_61;
            }
            
            val_98 = val_98.Id.Replace(oldValue:  "WU_", newValue:  System.String.alignConst);
            System.Nullable<T> val_49 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  val_98, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            val_100 = 0;
            if(((-20169288) & 1) == 0)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            UnityEngine.Texture val_50 = 上丑三丁丄丛丁万丑.且上丁丅七丟三丙一(丟丆丏且专不丕上专:  val_49.HasValue);
            goto label_117;
            label_61:
            if(val_98.Type != 1040)
            {
                goto label_69;
            }
            
            goto label_97;
            label_69:
            if(val_98.Type != 1060)
            {
                goto label_71;
            }
            
            goto label_97;
            label_71:
            if(val_98.Type != 1450)
            {
                goto label_73;
            }
            
            label_95:
            val_97 = val_98.Type;
            val_98 = val_98.Id;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_97, 丞丅上丏丂且下丅与:  val_98)) == null)
            {
                goto label_88;
            }
            
            goto label_117;
            label_73:
            if(val_98.Type != 1070)
            {
                goto label_77;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_98.Id)) == false)
            {
                goto label_80;
            }
            
            val_98 = val_98.Id;
            Rilisoft.东且东丒丐世丐丞丒 val_63 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  val_98);
            if(val_63 == null)
            {
                goto label_88;
            }
            
            string val_64 = val_63.丙三专万丛丟万丝丘();
            goto label_49;
            label_77:
            if(val_98.Type != 1080)
            {
                goto label_84;
            }
            
            val_97 = val_98.Id;
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_97)) == false)
            {
                goto label_88;
            }
            
            UnityEngine.Texture val_70 = 丛且丗丌丏下七下丈.三丗一丄不丆不丏三(丞一丁业丄一一业且:  val_98.Id);
            goto label_117;
            label_88:
            val_100 = 0;
            return (UnityEngine.Texture)val_100;
            label_84:
            if(val_98.Type != 1100)
            {
                goto label_92;
            }
            
            goto label_97;
            label_92:
            if((val_98.Type == 1110) || (val_98.Type == 1140))
            {
                goto label_95;
            }
            
            if(val_98.Type != 1090)
            {
                goto label_96;
            }
            
            goto label_97;
            label_96:
            if(val_98.Type != 1120)
            {
                goto label_98;
            }
            
            string val_76 = val_98.Id;
            goto label_113;
            label_98:
            if(val_98.Type != 83)
            {
                goto label_102;
            }
            
            if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_98.Id, 七丆丒与丗丌丄且丂:  48, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) != 0)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            if((Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  val_98.Id)) == null)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            string val_83 = System.String.Format(format:  "egg_{0}", arg0:  val_82.丝丗东与不丂业专丛);
            goto label_113;
            label_102:
            if(val_98.Type != 1130)
            {
                goto label_114;
            }
            
            UnityEngine.Texture val_86 = Rilisoft.上专业三丟丁丞专下.丑东丐下专丞丕丘世(且东与丞丗与与与专:  val_98.Id);
            goto label_117;
            label_114:
            if(val_98.Type != 1190)
            {
                goto label_118;
            }
            
            if(丄丄丁专丂三三丁且 == true)
            {
                goto label_119;
            }
            
            int val_88 = val_98.Count;
            goto label_122;
            label_118:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  val_98.Type, 丞丅上丏丂且下丅与:  val_98.Id)) == false)
            {
                    return (UnityEngine.Texture)val_100;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_98.Type, 丞丅上丏丂且下丅与:  val_98.Id)) != null)
            {
                goto label_117;
            }
            
            goto label_117;
        }
        internal static string 与丆业丅上丗七丆一(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            Rilisoft.OfferItem val_120;
            string val_121;
            Rilisoft.OfferItem val_122;
            var val_123;
            CategoryNames val_124;
            string val_125;
            string val_126;
            int val_127;
            string val_128;
            object val_129;
            object val_130;
            var val_131;
            var val_132;
            int val_133;
            var val_134;
            var val_135;
            val_120 = 下丅丙一丂丗丅丝七;
            下丐丒一丝丈丝三丞.业东下丕世丗丏万丏 val_1 = null;
            val_121 = val_1;
            val_1 = new 下丐丒一丝丈丝三丞.业东下丕世丗丏万丏();
            if(val_121 == null)
            {
                goto label_1;
            }
            
            .下丅丙一丂丗丅丝七 = val_120;
            if(val_120 == null)
            {
                goto label_50;
            }
            
            label_14:
            if(val_121 == null)
            {
                    val_120 = .下丅丙一丂丗丅丝七;
            }
            
            val_122 = .下丅丙一丂丗丅丝七.Type;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_120.Id)) == false)
            {
                goto label_9;
            }
            
            if(val_122 != 1020)
            {
                goto label_50;
            }
            
            label_235:
            label_82:
            string val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2900");
            return (string)val_123;
            label_1:
            mem[16] = val_120;
            if(mem[16] != 0)
            {
                goto label_14;
            }
            
            goto label_50;
            label_9:
            if(val_122 != 10)
            {
                goto label_18;
            }
            
            val_122 = 1152921505317388288;
            val_121 = .下丅丙一丂丗丅丝七.Id;
            三丅丁丗丗丝丂万且 val_7 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_121);
            if(val_7 == null)
            {
                    return (string)val_123;
            }
            
            val_121 = val_7.与不丞丑七丘丁丂丛();
            val_124 = val_7.万上丄下业丛丌不丈() - 1;
            goto label_280;
            label_18:
            val_122 = .下丅丙一丂丗丅丝七;
            if(.下丅丙一丂丗丅丝七.Type != 20)
            {
                goto label_27;
            }
            
            val_121 = val_122.Id;
            val_124 = 7;
            label_280:
            label_55:
            string val_12 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_121, 七丆丒与丗丌丄且丂:  val_124);
            return (string)val_123;
            label_27:
            if(((val_122.Type != 30) && (.下丅丙一丂丗丅丝七.Type != 60)) && (.下丅丙一丂丗丅丝七.Type != 50))
            {
                    if(.下丅丙一丂丗丅丝七.Type != 40)
            {
                    if(.下丅丙一丂丗丅丝七.Type != 70)
            {
                goto label_43;
            }
            
            }
            
            }
            
            val_122 = .下丅丙一丂丗丅丝七.Id;
            System.Nullable<CategoryNames> val_20 = Rilisoft.下丐丒一丝丈丝三丞.且东丈东丐七与丕丆(下丗丁丒丘东丂不丑:  .下丅丙一丂丗丅丝七.Type, 丕丁下丌不万丅丞丛:  val_122);
            if(((-19282616) & 1) == 0)
            {
                goto label_50;
            }
            
            string val_21 = .下丅丙一丂丗丅丝七.Id;
            goto label_55;
            label_50:
            val_123 = 0;
            return (string)val_123;
            label_43:
            if(.下丅丙一丂丗丅丝七.Type != 1000)
            {
                goto label_60;
            }
            
            val_125 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            val_126 = "Key_0951";
            goto label_65;
            label_60:
            if(.下丅丙一丂丗丅丝七.Type != 1010)
            {
                goto label_68;
            }
            
            val_125 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            val_126 = "Key_0275";
            label_65:
            string val_29 = val_125 + " " + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_126)(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_126));
            return (string)val_123;
            label_68:
            if(.下丅丙一丂丗丅丝七.Type != 85)
            {
                goto label_74;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_33 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            if(val_33 == null)
            {
                    return (string)val_123;
            }
            
            string val_35 = val_33.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐();
            goto label_82;
            label_74:
            if(.下丅丙一丂丗丅丝七.Type != 80)
            {
                goto label_85;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  .下丅丙一丂丗丅丝七.Id)) == null)
            {
                    return (string)val_123;
            }
            
            val_127 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_39.Lkey);
            if(.下丅丙一丂丗丅丝七.Count < 2)
            {
                    return (string)val_123;
            }
            
            val_128 = "{0} x{1}";
            val_129 = .下丅丙一丂丗丅丝七.Count;
            val_130 = val_127;
            goto label_114;
            label_85:
            if(.下丅丙一丂丗丅丝七.Type != 1030)
            {
                goto label_103;
            }
            
            System.Nullable<T> val_46 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  .下丅丙一丂丗丅丝七.Id.Replace(oldValue:  "WU_", newValue:  System.String.alignConst), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-19282632) & 1) == 0)
            {
                goto label_248;
            }
            
            val_128 = "{0} {1}";
            val_130 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            val_129 = 上丑三丁丄丛丁万丑.丝且丙东丄丒丗业丕(丟丆丏且专不丕上专:  val_46.HasValue);
            goto label_114;
            label_103:
            if(.下丅丙一丂丗丅丝七.Type != 1040)
            {
                goto label_115;
            }
            
            label_187:
            label_191:
            string val_53 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2196"), arg0:  .下丅丙一丂丗丅丝七.Count);
            return (string)val_123;
            label_115:
            if(.下丅丙一丂丗丅丝七.Type != 1050)
            {
                goto label_123;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_57 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  .下丅丙一丂丗丅丝七.Id);
            if(val_57 == null)
            {
                goto label_248;
            }
            
            int val_59 = .下丅丙一丂丗丅丝七.Count;
            val_128 = "{0} {1}";
            val_129 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_57.丟万丏且上业丐丈一());
            val_130 = val_59;
            label_114:
            string val_61 = System.String.Format(format:  val_128, arg0:  val_59, arg1:  val_129);
            return (string)val_123;
            label_123:
            if(.下丅丙一丂丗丅丝七.Type != 1060)
            {
                goto label_139;
            }
            
            if(.下丅丙一丂丗丅丝七.Count <= 0)
            {
                goto label_235;
            }
            
            System.TimeSpan val_65 = System.TimeSpan.FromSeconds(value:  (double).下丅丙一丂丗丅丝七.Count);
            if(val_65._ticks.Hours < 1)
            {
                goto label_145;
            }
            
            val_132 = "Key_4075";
            val_133 = (int)val_65._ticks.TotalHours;
            val_134 = null;
            val_135 = "Key_4074";
            goto label_146;
            label_139:
            if(.下丅丙一丂丗丅丝七.Type != 1070)
            {
                goto label_147;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_152;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_73 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            if(val_73 == null)
            {
                    return (string)val_123;
            }
            
            string val_74 = val_73.东丙上东业丆不丟丘();
            goto label_82;
            label_147:
            if(.下丅丙一丂丗丅丝七.Type != 1080)
            {
                goto label_160;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_248;
            }
            
            string val_80 = 丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  .下丅丙一丂丗丅丝七.Id);
            return (string)val_123;
            label_152:
            int val_82 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id);
            string val_83 = .下丅丙一丂丗丅丝七.Id;
            goto label_55;
            label_160:
            if(.下丅丙一丂丗丅丝七.Type != 1110)
            {
                goto label_184;
            }
            
            goto label_187;
            label_145:
            if(val_65._ticks.TotalDays <= 0f)
            {
                goto label_248;
            }
            
            val_132 = "Key_4077";
            val_133 = (int)val_65._ticks.TotalDays;
            val_134 = null;
            val_135 = "Key_4076";
            label_146:
            string val_88 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (val_133 > (4.94065645841247E-324)) ? (val_132) : (val_135));
            goto label_191;
            label_184:
            if(.下丅丙一丂丗丅丝七.Type != 1100)
            {
                goto label_194;
            }
            
            goto label_235;
            label_194:
            if(.下丅丙一丂丗丅丝七.Type != 1090)
            {
                goto label_201;
            }
            
            goto label_235;
            label_201:
            if(.下丅丙一丂丗丅丝七.Type != 1120)
            {
                goto label_209;
            }
            
            if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  .下丅丙一丂丗丅丝七.Id)) == null)
            {
                goto label_248;
            }
            
            goto label_82;
            label_209:
            if(.下丅丙一丂丗丅丝七.Type != 83)
            {
                goto label_216;
            }
            
            System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean> val_97 = new System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean>(object:  val_1, method:  System.Boolean 下丐丒一丝丈丝三丞.业东下丕世丗丏万丏::且丟丞丘丞丒丐专上(PGCompany.丑丝丟与丘丐丏上三 三万万丒丏丒不丐丙));
            PGCompany.丑丝丟与丘丐丏上三 val_98 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丑丝丟与丘丐丏上三>(source:  PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().Values, predicate:  null);
            if(val_98 == null)
            {
                goto label_220;
            }
            
            val_127 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_98.丄丁下丑丛丗丁不丛());
            goto label_223;
            label_216:
            if(.下丅丙一丂丗丅丝七.Type == 1130)
            {
                    string val_104 = Rilisoft.上专业三丟丁丞专下.丄丅三丛丙万丆业业(丐东业丕丕丂丗丅丙:  Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  .下丅丙一丂丗丅丝七.Id));
                return (string)val_123;
            }
            
            if(.下丅丙一丂丗丅丝七.Type != 1140)
            {
                goto label_232;
            }
            
            goto label_235;
            label_220:
            val_127 = System.String.alignConst;
            label_223:
            if(.下丅丙一丂丗丅丝七.Count <= 1)
            {
                    return (string)val_123;
            }
            
            string val_108 = System.String.Format(format:  "{0} x{1}", arg0:  val_127, arg1:  .下丅丙一丂丗丅丝七.Count);
            return (string)val_123;
            label_232:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) != false)
            {
                    if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) != null)
            {
                    return (string)val_123;
            }
            
                return (string)val_123;
            }
            
            label_248:
            val_131 = "not found";
            return (string)val_123;
        }
        internal static string 丛丐丏上丗不丘丕丕(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            Rilisoft.OfferItem val_124;
            string val_125;
            Rilisoft.OfferItem val_126;
            var val_127;
            CategoryNames val_128;
            object val_129;
            string val_130;
            int val_131;
            var val_132;
            int val_133;
            var val_134;
            var val_135;
            var val_136;
            val_124 = 下丅丙一丂丗丅丝七;
            下丐丒一丝丈丝三丞.丌万一一业丝丁丈丝 val_1 = null;
            val_125 = val_1;
            val_1 = new 下丐丒一丝丈丝三丞.丌万一一业丝丁丈丝();
            if(val_125 == null)
            {
                goto label_1;
            }
            
            .下丅丙一丂丗丅丝七 = val_124;
            if(val_124 == null)
            {
                goto label_50;
            }
            
            label_14:
            if(val_125 == null)
            {
                    val_124 = .下丅丙一丂丗丅丝七;
            }
            
            val_126 = .下丅丙一丂丗丅丝七.Type;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_124.Id)) == false)
            {
                goto label_9;
            }
            
            if(val_126 != 1020)
            {
                goto label_50;
            }
            
            label_255:
            label_82:
            string val_5 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_2900");
            return (string)val_127;
            label_1:
            mem[16] = val_124;
            if(mem[16] != 0)
            {
                goto label_14;
            }
            
            goto label_50;
            label_9:
            if(val_126 != 10)
            {
                goto label_18;
            }
            
            val_126 = 1152921505317388288;
            val_125 = .下丅丙一丂丗丅丝七.Id;
            三丅丁丗丗丝丂万且 val_7 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_125);
            if(val_7 == null)
            {
                    return (string)val_127;
            }
            
            val_125 = val_7.与不丞丑七丘丁丂丛();
            val_128 = val_7.万上丄下业丛丌不丈() - 1;
            goto label_293;
            label_18:
            val_126 = .下丅丙一丂丗丅丝七;
            if(.下丅丙一丂丗丅丝七.Type != 20)
            {
                goto label_27;
            }
            
            val_125 = val_126.Id;
            val_128 = 7;
            label_293:
            label_55:
            string val_12 = 丏丄丑上丛不丈且万.丛丐丏上丗不丘丕丕(丆万一不丌且东丐丐:  val_125, 七丆丒与丗丌丄且丂:  val_128);
            return (string)val_127;
            label_27:
            if(((val_126.Type != 30) && (.下丅丙一丂丗丅丝七.Type != 60)) && (.下丅丙一丂丗丅丝七.Type != 50))
            {
                    if(.下丅丙一丂丗丅丝七.Type != 40)
            {
                    if(.下丅丙一丂丗丅丝七.Type != 70)
            {
                goto label_43;
            }
            
            }
            
            }
            
            val_126 = .下丅丙一丂丗丅丝七.Id;
            System.Nullable<CategoryNames> val_20 = Rilisoft.下丐丒一丝丈丝三丞.且东丈东丐七与丕丆(下丗丁丒丘东丂不丑:  .下丅丙一丂丗丅丝七.Type, 丕丁下丌不万丅丞丛:  val_126);
            if(((-18333976) & 1) == 0)
            {
                goto label_50;
            }
            
            string val_21 = .下丅丙一丂丗丅丝七.Id;
            goto label_55;
            label_50:
            val_127 = 0;
            return (string)val_127;
            label_43:
            if(.下丅丙一丂丗丅丝七.Type != 1000)
            {
                goto label_60;
            }
            
            val_129 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            val_130 = "Key_0951";
            goto label_65;
            label_60:
            if(.下丅丙一丂丗丅丝七.Type != 1010)
            {
                goto label_68;
            }
            
            val_129 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            val_130 = "Key_0275";
            label_65:
            label_133:
            label_113:
            string val_29 = System.String.Format(format:  "{0} {1}", arg0:  val_129, arg1:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_130));
            return (string)val_127;
            label_68:
            if(.下丅丙一丂丗丅丝七.Type != 85)
            {
                goto label_74;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_33 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            if(val_33 == null)
            {
                    return (string)val_127;
            }
            
            string val_35 = val_33.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐();
            goto label_82;
            label_74:
            if(.下丅丙一丂丗丅丝七.Type != 80)
            {
                goto label_85;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  .下丅丙一丂丗丅丝七.Id)) == null)
            {
                    return (string)val_127;
            }
            
            val_131 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_39.Lkey);
            if(.下丅丙一丂丗丅丝七.Count < 2)
            {
                    return (string)val_127;
            }
            
            int val_42 = .下丅丙一丂丗丅丝七.Count;
            goto label_113;
            label_85:
            if(.下丅丙一丂丗丅丝七.Type != 1030)
            {
                goto label_102;
            }
            
            System.Nullable<T> val_46 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  .下丅丙一丂丗丅丝七.Id.Replace(oldValue:  "WU_", newValue:  System.String.alignConst), 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if(((-18333992) & 1) == 0)
            {
                goto label_261;
            }
            
            string val_47 = 上丑三丁丄丛丁万丑.万丄丟丘丕丐丕丆丂(丟丆丏且专不丕上专:  val_46.HasValue);
            string val_49 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  .下丅丙一丂丗丅丝七.Count);
            goto label_113;
            label_102:
            if(.下丅丙一丂丗丅丝七.Type != 1040)
            {
                goto label_114;
            }
            
            label_186:
            label_190:
            string val_53 = System.String.Format(format:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_2196"), arg0:  .下丅丙一丂丗丅丝七.Count);
            return (string)val_127;
            label_114:
            if(.下丅丙一丂丗丅丝七.Type != 1050)
            {
                goto label_122;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_57 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  .下丅丙一丂丗丅丝七.Id);
            if(val_57 == null)
            {
                goto label_261;
            }
            
            string val_58 = val_57.丟万丏且上业丐丈一();
            int val_59 = .下丅丙一丂丗丅丝七.Count;
            goto label_133;
            label_122:
            if(.下丅丙一丂丗丅丝七.Type != 1060)
            {
                goto label_138;
            }
            
            if(.下丅丙一丂丗丅丝七.Count <= 0)
            {
                goto label_255;
            }
            
            System.TimeSpan val_63 = System.TimeSpan.FromSeconds(value:  (double).下丅丙一丂丗丅丝七.Count);
            if(val_63._ticks.Hours < 1)
            {
                goto label_144;
            }
            
            val_132 = "Key_4075";
            val_133 = (int)val_63._ticks.TotalHours;
            val_134 = null;
            val_135 = "Key_4074";
            goto label_145;
            label_138:
            if(.下丅丙一丂丗丅丝七.Type != 1070)
            {
                goto label_146;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_151;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_71 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            if(val_71 == null)
            {
                    return (string)val_127;
            }
            
            string val_72 = val_71.东丙上东业丆不丟丘();
            goto label_82;
            label_146:
            if(.下丅丙一丂丗丅丝七.Type != 1080)
            {
                goto label_159;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_261;
            }
            
            string val_78 = 丛且丗丌丏下七下丈.丛七丕丌丌丕丗七丟(丞一丁业丄一一业且:  .下丅丙一丂丗丅丝七.Id);
            return (string)val_127;
            label_151:
            int val_80 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id);
            string val_81 = .下丅丙一丂丗丅丝七.Id;
            goto label_55;
            label_159:
            if(.下丅丙一丂丗丅丝七.Type != 1110)
            {
                goto label_183;
            }
            
            goto label_186;
            label_144:
            if(val_63._ticks.TotalDays <= 0f)
            {
                goto label_261;
            }
            
            val_132 = "Key_4077";
            val_133 = (int)val_63._ticks.TotalDays;
            val_134 = null;
            val_135 = "Key_4076";
            label_145:
            string val_86 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  (val_133 > (4.94065645841247E-324)) ? (val_132) : (val_135));
            goto label_190;
            label_183:
            if(.下丅丙一丂丗丅丝七.Type != 1100)
            {
                goto label_193;
            }
            
            goto label_255;
            label_193:
            if(.下丅丙一丂丗丅丝七.Type != 1090)
            {
                goto label_200;
            }
            
            goto label_255;
            label_200:
            if(.下丅丙一丂丗丅丝七.Type != 1120)
            {
                goto label_208;
            }
            
            if((Rilisoft.上丑业三丆丆丅丕三.丝七上上丝丄下丄七(且丘世丏丛丛万丟万:  .下丅丙一丂丗丅丝七.Id)) == null)
            {
                goto label_261;
            }
            
            goto label_82;
            label_208:
            if(.下丅丙一丂丗丅丝七.Type != 83)
            {
                goto label_215;
            }
            
            System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean> val_95 = new System.Func<PGCompany.丑丝丟与丘丐丏上三, System.Boolean>(object:  val_1, method:  System.Boolean 下丐丒一丝丈丝三丞.丌万一一业丝丁丈丝::专丟丂丁专丌丘东不(PGCompany.丑丝丟与丘丐丏上三 三万万丒丏丒不丐丙));
            PGCompany.丑丝丟与丘丐丏上三 val_96 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丑丝丟与丘丐丏上三>(source:  PGCompany.专一丄丆丈专丆丕丟.丙丕丞且丕不丘丙丑().Values, predicate:  null);
            if(val_96 == null)
            {
                goto label_219;
            }
            
            val_131 = 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  val_96.丄丁下丑丛丗丁不丛());
            goto label_222;
            label_215:
            if(.下丅丙一丂丗丅丝七.Type == 1130)
            {
                    string val_102 = Rilisoft.上专业三丟丁丞专下.专丙丛业东丌丈丛一(丐东业丕丕丂丗丅丙:  Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  .下丅丙一丂丗丅丝七.Id));
                return (string)val_127;
            }
            
            if(.下丅丙一丂丗丅丝七.Type != 1150)
            {
                    if(.下丅丙一丂丗丅丝七.Type != 1160)
            {
                goto label_234;
            }
            
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) == null)
            {
                    return (string)val_127;
            }
            
            return (string)val_127;
            label_219:
            val_131 = System.String.alignConst;
            label_222:
            if(.下丅丙一丂丗丅丝七.Count <= 1)
            {
                    return (string)val_127;
            }
            
            string val_111 = System.String.Format(format:  "{0} x{1}", arg0:  val_131, arg1:  .下丅丙一丂丗丅丝七.Count);
            return (string)val_127;
            label_234:
            if(.下丅丙一丂丗丅丝七.Type != 1140)
            {
                goto label_252;
            }
            
            goto label_255;
            label_252:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) != false)
            {
                    if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) != null)
            {
                    return (string)val_127;
            }
            
                return (string)val_127;
            }
            
            label_261:
            val_136 = "not found";
            return (string)val_127;
        }
        internal static bool 丄不丅七业不丌丞与(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            var val_20;
            var val_21;
            var val_22;
            val_20 = 下丅丙一丂丗丅丝七;
            if(val_20 == null)
            {
                goto label_16;
            }
            
            if(val_20.Record == null)
            {
                goto label_2;
            }
            
            val_20 = val_20.Record;
            label_31:
            var val_4 = (ExperienceController.丞丞丘业东丙丏七丌() >= val_20) ? 1 : 0;
            return (bool)val_21;
            label_2:
            if(val_20.Type == 70)
            {
                    return System.Linq.Enumerable.Contains<System.String>(source:  丁下万丟且丟丛下业.丁丐丄丝不丅丗丄与(丞丁丏且与丒丐业下:  ExperienceController.丞丞丘业东丙丏七丌()), value:  val_20.Id);
            }
            
            if(val_20.Type != 1080)
            {
                goto label_12;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_20.Id)) == false)
            {
                goto label_16;
            }
            
            val_22 = null;
            val_22 = null;
            if(ExperienceController.sharedController == 0)
            {
                goto label_21;
            }
            
            int val_14 = ExperienceController.丞丞丘业东丙丏七丌();
            goto label_24;
            label_16:
            val_21 = 0;
            return (bool)val_21;
            label_12:
            if(val_20.Type != 85)
            {
                    return (bool)val_21;
            }
            
            return 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.craft");
            label_21:
            label_24:
            int val_19 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[val_20.Id].丈丒丟下丂丒东与丑();
            goto label_31;
        }
        internal static string 丟世三不一下丕丒万(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            var val_49;
            string val_50;
            val_49 = 下丅丙一丂丗丅丝七;
            if(val_49 == null)
            {
                    return 0;
            }
            
            if(val_49.Type == 20)
            {
                    val_50 = "Key_0354";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50 = "Key_4054");
            }
            
            if(val_49.Type == 1000)
            {
                    val_50 = "Key_1836";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1010)
            {
                    val_50 = "Key_1835";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 80)
            {
                    val_50 = "Key_3811";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 85)
            {
                    val_50 = "Key_3398";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1020)
            {
                    val_50 = "Key_3810";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type != 1030)
            {
                goto label_26;
            }
            
            label_133:
            val_50 = "Key_3805";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            label_26:
            if(val_49.Type == 70)
            {
                    val_50 = "Key_2694";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1040)
            {
                    val_50 = "Key_2199";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1060)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if((七丌丞万七万丁丐丙.丗丗丗丐丏丟丅丛专(丝丒丞丙丐一一丅三:  val_49.Id)) != false)
            {
                    return 七丌丞万七万丁丐丙.丌丄三丆下丑丟三丑(丝丒丞丙丐一一丅三:  val_49.Id);
            }
            
            if(val_49.Type == 1050)
            {
                    Rilisoft.丛且世丐丆上七业丁 val_17 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  val_49.Id);
                if(val_17 == null)
            {
                    return 0;
            }
            
                string val_18 = val_17.不丅且万丐专丄丌丂();
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1070)
            {
                    if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_49.Id)) == false)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type != 1080)
            {
                goto label_61;
            }
            
            int val_24 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_49.Id);
            if((val_24 & 2147483648) != 0)
            {
                    return 0;
            }
            
            if(val_24 <= 180000)
            {
                goto label_65;
            }
            
            if(val_24 == 190000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_24 == 200000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_24 != 210000)
            {
                    return 0;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            label_61:
            if(val_49.Type == 1110)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type != 1100)
            {
                goto label_79;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            label_65:
            if(val_24 == 160000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_24 == 170000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_24 != 180000)
            {
                    return 0;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            label_79:
            if(val_49.Type == 1090)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1120)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 10)
            {
                    三丅丁丗丗丝丂万且 val_31 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_49.Id);
                if(val_31 == null)
            {
                    return 0;
            }
            
                if(val_31.东七与与不丅丙上上() == false)
            {
                    return 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  val_49.Id);
            }
            
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 83)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if(val_49.Type == 1130)
            {
                    return Rilisoft.上专业三丟丁丞专下.丞丙且丘三一万丄丁(丐东业丕丕丂丗丅丙:  Rilisoft.上专业三丟丁丞专下.丘丂丝与东下丘丆丄(且东与丞丗与与与专:  val_49.Id));
            }
            
            if(val_49.Type == 1140)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_50);
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  val_49.Type, 丞丅上丏丂且下丅与:  val_49.Id)) == false)
            {
                goto label_128;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_46 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_49.Type, 丞丅上丏丂且下丅与:  val_49.Id);
            val_49 = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_218;
            label_128:
            if(val_49.Type == 1310)
            {
                goto label_133;
            }
            
            if(val_49.Type != 1340)
            {
                    return 0;
            }
            
            goto label_133;
        }
        internal static string 三不丄不上丙且丅丄(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            int val_15;
            var val_16;
            var val_17;
            val_15 = 下丅丙一丂丗丅丝七;
            if(val_15 == null)
            {
                goto label_1;
            }
            
            val_15 = val_15.Count;
            if(val_15.Type != 1060)
            {
                goto label_2;
            }
            
            System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  (double)val_15);
            if((int)val_3._ticks.TotalHours != (4.94065645841247E-324))
            {
                goto label_5;
            }
            
            val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5876");
            val_16 = null;
            goto label_8;
            label_1:
            val_17 = 0;
            return (string)System.String.Format(format:  val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5877"), arg0:  (int)val_3._ticks.TotalHours);
            label_2:
            string val_6 = val_15.ToString();
            return (string)System.String.Format(format:  val_15, arg0:  (int)val_3._ticks.TotalHours);
            label_5:
            if(((int)val_3._ticks.TotalHours - 2) <= (1.03753785626662E-322))
            {
                goto label_11;
            }
            
            var val_8 = X9 >> 63;
            var val_9 = X9 >> 34;
            var val_10 = val_9 + val_8;
            val_10 = (int)val_3._ticks.TotalHours - (val_10 * 24);
            if(val_10 == 0)
            {
                goto label_12;
            }
            
            label_11:
            label_21:
            val_16 = null;
            label_8:
            return (string)System.String.Format(format:  val_15, arg0:  (int)val_3._ticks.TotalHours);
            label_12:
            var val_14 = val_9 + val_8;
            if(((int)val_3._ticks.TotalHours - 24) > (1.13635098543487E-322))
            {
                goto label_21;
            }
            
            goto label_21;
        }
        internal static bool 丌丆不不东丅丟万东(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            Rilisoft.OfferItem val_141;
            string val_142;
            var val_143;
            System.Func<TSource, System.Boolean> val_144;
            var val_145;
            var val_147;
            var val_148;
            string val_149;
            var val_150;
            var val_151;
            val_141 = 下丅丙一丂丗丅丝七;
            下丐丒一丝丈丝三丞.世东丒与丞七不不东 val_1 = null;
            val_142 = val_1;
            val_1 = new 下丐丒一丝丈丝三丞.世东丒与丞七不不东();
            if(val_142 == null)
            {
                goto label_1;
            }
            
            .下丅丙一丂丗丅丝七 = val_141;
            if(val_141 == null)
            {
                goto label_241;
            }
            
            label_12:
            if(val_142 == null)
            {
                    val_141 = .下丅丙一丂丗丅丝七;
            }
            
            if(val_141.Type != 10)
            {
                goto label_5;
            }
            
            val_142 = .下丅丙一丂丗丅丝七.Id;
            var val_6 = ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_142)) != 0) ? 1 : 0;
            goto label_242;
            label_1:
            mem[16] = val_141;
            if(mem[16] != 0)
            {
                goto label_12;
            }
            
            label_241:
            val_143 = 0;
            goto label_242;
            label_5:
            if(.下丅丙一丂丗丅丝七.Type != 85)
            {
                goto label_16;
            }
            
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_10 = null;
            val_144 = val_10;
            val_10 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean 下丐丒一丝丈丝三丞.世东丒与丞七不不东::与东丙丗丞业丏丑七(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            val_142 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_10);
            if(val_142 == null)
            {
                goto label_242;
            }
            
            if(val_142.丑丆丑三且丛上且丟() == true)
            {
                goto label_240;
            }
            
            val_143 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            bool val_14 = val_143.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  val_142);
            goto label_242;
            label_16:
            val_144 = .下丅丙一丂丗丅丝七;
            if(.下丅丙一丂丗丅丝七.Type != 1050)
            {
                goto label_26;
            }
            
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_144.Id)) == false)
            {
                goto label_240;
            }
            
            val_142 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if((val_142.丛丐丘与丂万丌专三(丁丅丈丌丟世丗丗丟:  100)) == false)
            {
                goto label_31;
            }
            
            label_240:
            val_143 = 1;
            label_242:
            val_143 = val_143 & 1;
            return (bool)val_143;
            label_26:
            if(val_144.Type != 70)
            {
                goto label_32;
            }
            
            丕丈丏丝丗下丟丅丂 val_24 = System.Linq.Enumerable.FirstOrDefault<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  val_1, method:  System.Boolean 下丐丒一丝丈丝三丞.世东丒与丞七不不东::丕丞丕丞万丁丌丈七(丕丈丏丝丗下丟丅丂 七丞丙丒三丕且丌丟)));
            if(val_24 == null)
            {
                goto label_242;
            }
            
            bool val_26 = 丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  val_24.业上丙丞丐丄丆丅七(), 丝丒上丑一三丑丐丛:  true);
            goto label_242;
            label_32:
            if(.下丅丙一丂丗丅丝七.Type != 1070)
            {
                goto label_44;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_47;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_32 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            if(val_32 == null)
            {
                goto label_242;
            }
            
            var val_35 = (val_32.丗三三丐丁东丘丌一() >= val_32.三丐丟丒业丞东三丕()) ? 1 : 0;
            goto label_242;
            label_31:
            bool val_37 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丛丐丘与丂万丌专三(丁丅丈丌丟世丗丗丟:  44);
            goto label_242;
            label_44:
            if(.下丅丙一丂丗丅丝七.Type != 1080)
            {
                goto label_57;
            }
            
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_241;
            }
            
            bool val_43 = 丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  .下丅丙一丂丗丅丝七.Id);
            goto label_242;
            label_47:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  .下丅丙一丂丗丅丝七.Id)) == true)
            {
                goto label_241;
            }
            
            val_145 = null;
            val_145 = null;
            if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_79;
            }
            
            三丅丁丗丗丝丂万且 val_49 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id);
            if(val_49 == null)
            {
                goto label_242;
            }
            
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_49.业东丅东丌上丗丑不())) != null)
            {
                goto label_240;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_57 = WeaponManager.万一丛七丙丑丄丆丑();
            var val_61 = ((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id)) >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_49.三与丛丑且丐丈业丌()))) ? 1 : 0;
            if((System.String.op_Equality(a:  val_57.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_49.与不丞丑七丘丁丂丛())) == true)
            {
                goto label_97;
            }
            
            val_147 = 1152921516734113248;
            val_148 = WeaponManager.七世丂丁丆丙丐丆丌();
            val_149 = val_49.与不丞丑七丘丁丂丛();
            goto label_101;
            label_57:
            if((.下丅丙一丂丗丅丝七.Type != 30) && (.下丅丙一丂丗丅丝七.Type != 40))
            {
                    if(.下丅丙一丂丗丅丝七.Type != 50)
            {
                    if(.下丅丙一丂丗丅丝七.Type != 60)
            {
                goto label_113;
            }
            
            }
            
            }
            
            bool val_70 = 七丌丞万七万丁丐丙.与不专丅三丈丄丈上().Contains(item:  .下丅丙一丂丗丅丝七.Id);
            goto label_242;
            label_79:
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_125;
            }
            
            if((丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  .下丅丙一丂丗丅丝七.Id)) == true)
            {
                goto label_240;
            }
            
            goto label_131;
            label_125:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_137;
            }
            
            if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  .下丅丙一丂丗丅丝七.Id)) == true)
            {
                goto label_240;
            }
            
            label_131:
            label_183:
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_85 = WeaponManager.万一丛七丙丑丄丆丑();
            if((System.String.op_Equality(a:  val_85.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_155;
            }
            
            label_97:
            val_150 = 1;
            goto label_156;
            label_113:
            if(.下丅丙一丂丗丅丝七.Type != 20)
            {
                goto label_159;
            }
            
            var val_94 = ((Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丂专下丌丈丙专丁东(丙丄不丈专丕与万万:  .下丅丙一丂丗丅丝七.Id)) > 0) ? 1 : 0;
            goto label_242;
            label_137:
            val_151 = null;
            val_151 = null;
            if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_241;
            }
            
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  .下丅丙一丂丗丅丝七.Id)) != null)
            {
                goto label_240;
            }
            
            三丅丁丗丗丝丂万且 val_101 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id);
            if(val_101 == null)
            {
                goto label_242;
            }
            
            string val_102 = val_101.三与丛丑且丐丈业丌();
            goto label_183;
            label_155:
            val_147 = 1152921516734113248;
            val_148 = WeaponManager.七世丂丁丆丙丐丆丌();
            val_149 = .下丅丙一丂丗丅丝七.Id;
            label_101:
            val_150 = val_148.Contains(item:  val_149);
            label_156:
            val_150 = val_150 | (((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id)) >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  .下丅丙一丂丗丅丝七.Id))) ? 1 : 0);
            var val_106 = (val_150 == true) ? 1 : 0;
            goto label_242;
            label_159:
            if(.下丅丙一丂丗丅丝七.Type != 1120)
            {
                goto label_194;
            }
            
            bool val_109 = 丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  .下丅丙一丂丗丅丝七.Id, 丝丒上丑一三丑丐丛:  true);
            goto label_242;
            label_194:
            if(.下丅丙一丂丗丅丝七.Type != 1310)
            {
                goto label_198;
            }
            
            丕丑丙丑丙东丌丘丕 val_113 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  .下丅丙一丂丗丅丝七.Id);
            if(val_113 == null)
            {
                goto label_242;
            }
            
            var val_116 = (val_113.丈一下下丞世三丑丄() >= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
            goto label_242;
            label_198:
            if(.下丅丙一丂丗丅丝七.Type != 1340)
            {
                goto label_210;
            }
            
            丕丑丙丑丙东丌丘丕 val_120 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  .下丅丙一丂丗丅丝七.Id);
            if((val_120 == null) || ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id)) == null))
            {
                goto label_242;
            }
            
            var val_128 = ((UnityEngine.Mathf.Min(a:  5, b:  .下丅丙一丂丗丅丝七.Count + val_120.七东与丄丕丁丛世三())) <= val_120.七东与丄丕丁丛世三()) ? 1 : 0;
            goto label_242;
            label_210:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_241;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  .下丅丙一丂丗丅丝七.Type, 丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == null)
            {
                goto label_242;
            }
            
            var val_139 = (((PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchy + (PGCompany.丅丄不丛东丝一七丞.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 1 : 0;
            goto label_242;
        }
        internal static int 业一一丗丛且丌丏丏(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            string val_31;
            var val_32;
            string val_33;
            var val_34;
            var val_35;
            string val_36;
            string val_37;
            var val_38;
            string val_39;
            var val_40;
            val_31 = 下丅丙一丂丗丅丝七;
            if(val_31 == null)
            {
                    return 0;
            }
            
            if(val_31.Type != 1070)
            {
                    return 0;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_31.Id)) != false)
            {
                    val_31 = val_31.Id;
                Rilisoft.东且东丒丐世丐丞丒 val_6 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  val_31);
                if(val_6 == null)
            {
                    return 0;
            }
            
                return val_6.丗三三丐丁东丘丌一();
            }
            
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  val_31.Id)) != false)
            {
                    return 0;
            }
            
            val_32 = null;
            val_32 = null;
            if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_31.Id)) == false)
            {
                goto label_14;
            }
            
            label_50:
            三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_31.Id);
            if(val_12 == null)
            {
                    return 0;
            }
            
            val_33 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
            if((val_33.专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_12.业东丅东丌上丗丑不())) == null)
            {
                goto label_21;
            }
            
            val_34 = val_12.三与丛丑且丐丈业丌();
            val_35 = null;
            return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_37 = val_31.Id);
            label_14:
            val_33 = val_31.Id;
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_33)) == false)
            {
                goto label_28;
            }
            
            val_36 = val_31.Id;
            bool val_21 = 丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  val_36);
            goto label_31;
            label_28:
            val_33 = val_31.Id;
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_33)) == false)
            {
                goto label_35;
            }
            
            val_36 = val_31.Id;
            label_31:
            if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  val_36)) != false)
            {
                    val_35 = null;
                return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_37);
            }
            
            val_38 = null;
            return Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_39 = val_31.Id);
            label_21:
            val_38 = null;
            return Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_39);
            label_35:
            val_40 = null;
            val_40 = null;
            if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_31.Id)) == false)
            {
                    return 0;
            }
            
            goto label_50;
        }
        internal static int 丌丙丐万丅丙丟下业(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            string val_23;
            var val_24;
            string val_25;
            var val_27;
            val_23 = 下丅丙一丂丗丅丝七;
            if(val_23 == null)
            {
                    return 0;
            }
            
            if(val_23.Type != 1070)
            {
                    return 0;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  val_23.Id)) != false)
            {
                    val_23 = val_23.Id;
                Rilisoft.东且东丒丐世丐丞丒 val_6 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  val_23);
                if(val_6 == null)
            {
                    return 0;
            }
            
                return val_6.三丐丟丒业丞东三丕();
            }
            
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  val_23.Id)) != false)
            {
                    return 0;
            }
            
            val_24 = null;
            val_24 = null;
            val_25 = val_23.Id;
            if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  val_25)) == false)
            {
                goto label_14;
            }
            
            label_33:
            三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_23.Id);
            if(val_12 == null)
            {
                    return 0;
            }
            
            string val_13 = val_12.三与丛丑且丐丈业丌();
            return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_23.Id);
            label_14:
            val_25 = val_23.Id;
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_25)) == true)
            {
                    return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_23.Id);
            }
            
            val_25 = val_23.Id;
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_25)) != false)
            {
                    return BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_23.Id);
            }
            
            val_27 = null;
            val_27 = null;
            if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  val_23.Id)) == false)
            {
                    return 0;
            }
            
            goto label_33;
        }
        internal static int 专与万丞不丄丕且七(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            var val_42;
            var val_43;
            var val_45;
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return 0;
            }
            
            if(下丅丙一丂丗丅丝七.Type != 1070)
            {
                    return 0;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_5;
            }
            
            Rilisoft.东且东丒丐世丐丞丒 val_6 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  下丅丙一丂丗丅丝七.Id);
            if(val_6 == null)
            {
                goto label_7;
            }
            
            val_42 = val_6.三丐丟丒业丞东三丕();
            return UnityEngine.Mathf.Clamp(value:  val_42 - val_6.丗三三丐丁东丘丌一(), min:  0, max:  2147483647);
            label_5:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  下丅丙一丂丗丅丝七.Id)) != false)
            {
                    return 0;
            }
            
            val_43 = null;
            val_43 = null;
            if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_15;
            }
            
            三丅丁丗丗丝丂万且 val_13 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.Id);
            if(val_13 == null)
            {
                    return 0;
            }
            
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_13.业东丅东丌上丗丑不())) != null)
            {
                    return 0;
            }
            
            label_56:
            string val_17 = val_13.三与丛丑且丐丈业丌();
            goto label_23;
            label_7:
            val_42 = 0.三丐丟丒业丞东三丕();
            return UnityEngine.Mathf.Clamp(value:  val_42 - val_6.丗三三丐丁东丘丌一(), min:  0, max:  2147483647);
            label_15:
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_29;
            }
            
            if((丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  下丅丙一丂丗丅丝七.Id)) == true)
            {
                    return 0;
            }
            
            goto label_33;
            label_29:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                goto label_37;
            }
            
            if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  下丅丙一丂丗丅丝七.Id)) == true)
            {
                    return 0;
            }
            
            label_33:
            label_23:
            int val_32 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  下丅丙一丂丗丅丝七.Id);
            int val_34 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.Id);
            return UnityEngine.Mathf.Clamp(value:  val_42 - val_6.丗三三丐丁东丘丌一(), min:  0, max:  2147483647);
            label_37:
            val_45 = null;
            val_45 = null;
            if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  下丅丙一丂丗丅丝七.Id)) == false)
            {
                    return 0;
            }
            
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  下丅丙一丂丗丅丝七.Id)) != null)
            {
                    return 0;
            }
            
            if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  下丅丙一丂丗丅丝七.Id)) != null)
            {
                goto label_56;
            }
            
            return 0;
        }
        internal static bool 专丁七丙丌万丝丈丈(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            string val_20;
            var val_21;
            var val_22;
            val_20 = 下丅丙一丂丗丅丝七;
            if(val_20 == null)
            {
                goto label_34;
            }
            
            if(val_20.Type != 10)
            {
                    if((val_20.Type != 1070) || ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_20.Id)) == null))
            {
                goto label_6;
            }
            
            }
            
            val_20 = val_20.Id;
            if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_20)) != null)
            {
                goto label_30;
            }
            
            label_34:
            val_21 = 0;
            return (bool)val_21;
            label_6:
            if((((val_20.Type != 60) && (val_20.Type != 1120)) && (val_20.Type != 30)) && (val_20.Type != 40))
            {
                    if(val_20.Type != 50)
            {
                    if(val_20.Type != 80)
            {
                goto label_16;
            }
            
            }
            
            }
            
            label_30:
            val_21 = 1;
            return (bool)val_21;
            label_16:
            if(val_20.Type != 1080)
            {
                    if(val_20.Type != 1070)
            {
                goto label_34;
            }
            
            }
            
            int val_16 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_20.Id);
            if((val_16 & 2147483648) != 0)
            {
                goto label_21;
            }
            
            if(val_16 > 189999)
            {
                goto label_22;
            }
            
            if(val_16 == 160000)
            {
                    return (bool)val_21;
            }
            
            if(val_16 == 170000)
            {
                    return (bool)val_21;
            }
            
            val_22 = 131072;
            val_22 = 2;
            goto label_25;
            label_21:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_20.Id)) == false)
            {
                goto label_34;
            }
            
            goto label_30;
            label_22:
            if(val_16 == 190000)
            {
                    return (bool)val_21;
            }
            
            if(val_16 == 200000)
            {
                    return (bool)val_21;
            }
            
            val_22 = 196608;
            val_22 = 3;
            label_25:
            if(val_16 == 210000)
            {
                    return (bool)val_21;
            }
            
            goto label_34;
        }
        internal static bool 东上万与丟丙丅丆不(Rilisoft.OfferItem 下丅丙一丂丗丅丝七)
        {
            Rilisoft.OfferItem val_33;
            string val_34;
            var val_35;
            System.Func<TSource, System.Boolean> val_36;
            val_33 = 下丅丙一丂丗丅丝七;
            下丐丒一丝丈丝三丞.与丟业一丈上丅上不 val_1 = null;
            val_34 = val_1;
            val_1 = new 下丐丒一丝丈丝三丞.与丟业一丈上丅上不();
            if(val_34 == null)
            {
                goto label_1;
            }
            
            .下丅丙一丂丗丅丝七 = val_33;
            if(val_33 == null)
            {
                goto label_47;
            }
            
            label_12:
            if(val_34 == null)
            {
                    val_33 = .下丅丙一丂丗丅丝七;
            }
            
            Rilisoft.OfferItemType val_2 = val_33.Type;
            if(val_2 <= 1030)
            {
                goto label_5;
            }
            
            if(val_2 <= 1100)
            {
                goto label_6;
            }
            
            if(val_2 <= 1140)
            {
                goto label_7;
            }
            
            if(val_2 <= 1200)
            {
                goto label_8;
            }
            
            if((val_2 == 1310) || (val_2 == 1340))
            {
                goto label_48;
            }
            
            goto label_77;
            label_1:
            mem[16] = val_33;
            if(mem[16] != 0)
            {
                goto label_12;
            }
            
            label_47:
            val_35 = 0;
            return (bool)val_35 & 1;
            label_5:
            if(val_2 <= 60)
            {
                goto label_14;
            }
            
            if(val_2 <= 85)
            {
                goto label_15;
            }
            
            if(val_2 <= 1010)
            {
                goto label_16;
            }
            
            if(val_2 == 1020)
            {
                goto label_50;
            }
            
            if(val_2 != 1030)
            {
                goto label_77;
            }
            
            val_34 = .下丅丙一丂丗丅丝七.Id.Replace(oldValue:  "WU_", newValue:  System.String.alignConst);
            System.Nullable<T> val_5 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  val_34, 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            val_35;
            return (bool)val_35 & 1;
            label_6:
            if(val_2 <= 1060)
            {
                goto label_25;
            }
            
            if(val_2 <= 1080)
            {
                goto label_26;
            }
            
            val_35 = 1;
            if((val_2 == 1090) || (val_2 == 1100))
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_14:
            if(val_2 <= 20)
            {
                goto label_30;
            }
            
            if(val_2 <= 40)
            {
                goto label_31;
            }
            
            if((val_2 == 50) || (val_2 == 60))
            {
                goto label_76;
            }
            
            goto label_77;
            label_7:
            if(val_2 <= 1120)
            {
                goto label_35;
            }
            
            val_35 = 1;
            if((val_2 == 1130) || (val_2 == 1140))
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_15:
            if(val_2 <= 80)
            {
                goto label_39;
            }
            
            if(val_2 == 83)
            {
                goto label_40;
            }
            
            if(val_2 != 85)
            {
                goto label_77;
            }
            
            System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean> val_8 = null;
            val_36 = val_8;
            val_8 = new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  val_1, method:  System.Boolean 下丐丒一丝丈丝三丞.与丟业一丈上丅上不::丆丁丕丂丕丘东丐丟(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟));
            val_35 = System.Linq.Enumerable.Any<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  val_8);
            return (bool)val_35 & 1;
            label_25:
            Rilisoft.OfferItemType val_10 = val_2 - 1040;
            if(val_10 > 20)
            {
                goto label_77;
            }
            
            val_35 = 1;
            val_10 = val_35 << val_10;
            val_10 = val_10 & 1049601;
            if(val_10 != 0)
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_30:
            if(val_2 == 0)
            {
                goto label_47;
            }
            
            if(val_2 == 10)
            {
                goto label_48;
            }
            
            if(val_2 != 20)
            {
                goto label_77;
            }
            
            goto label_50;
            label_48:
            val_34 = .下丅丙一丂丗丅丝七.Id;
            var val_13 = ((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_34)) != 0) ? 1 : 0;
            return (bool)val_35 & 1;
            label_8:
            val_35 = 1;
            if((val_2 == 1190) || (val_2 == 1200))
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_16:
            val_35 = 1;
            if((val_2 == 1000) || (val_2 == 1010))
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_26:
            if(val_2 == 1070)
            {
                goto label_62;
            }
            
            if(val_2 != 1080)
            {
                goto label_77;
            }
            
            val_34 = .下丅丙一丂丗丅丝七.Id;
            val_35 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_34);
            return (bool)val_35 & 1;
            label_31:
            if((val_2 == 30) || (val_2 == 40))
            {
                goto label_76;
            }
            
            goto label_77;
            label_35:
            val_35 = 1;
            if((val_2 == 1110) || (val_2 == 1120))
            {
                    return (bool)val_35 & 1;
            }
            
            goto label_77;
            label_39:
            if(val_2 == 70)
            {
                goto label_76;
            }
            
            if(val_2 == 80)
            {
                    val_34 = .下丅丙一丂丗丅丝七.Id;
                val_35 = Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  val_34);
                return (bool)val_35 & 1;
            }
            
            label_77:
            val_36 = .下丅丙一丂丗丅丝七.Id;
            val_34 = .下丅丙一丂丗丅丝七;
            Rilisoft.OfferItemType val_21 = val_34.Type;
            val_35 = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().且丄丑丆丝丐丕丕丗(丞一丁业丄一一业且:  val_36, 丁丅丈丌丟世丗丗丟:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false});
            return (bool)val_35 & 1;
            label_76:
            val_34 = .下丅丙一丂丗丅丝七.Id;
            val_35 = ((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_34)) >> 31) ^ 1;
            return (bool)val_35 & 1;
            label_40:
            val_34 = .下丅丙一丂丗丅丝七.Id;
            val_35 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丄丞丂丟丗三丗丙丝(丈丕丁丘七丙丞不丙:  val_34);
            return (bool)val_35 & 1;
            label_62:
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  .下丅丙一丂丗丅丝七.Id)) & 2147483648) != 0)
            {
                goto label_104;
            }
            
            label_50:
            val_35 = 1;
            return (bool)val_35 & 1;
            label_104:
            bool val_33 = Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  .下丅丙一丂丗丅丝七.Id);
            return (bool)val_35 & 1;
        }
        internal static 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丌丒丝东丌下丕丁丅 = 1)
        {
            int val_86;
            Rilisoft.OfferItemType val_87;
            var val_88;
            var val_89;
            string val_90;
            var val_91;
            int val_92;
            var val_93;
            var val_94;
            var val_95;
            System.Func<Rilisoft.GameCurrencyData, System.Int32> val_97;
            int val_98;
            int val_99;
            int val_100;
            int val_101;
            string val_102;
            var val_103;
            var val_104;
            int val_105;
            丕丑丙丑丙东丌丘丕 val_106;
            string val_107;
            var val_108;
            var val_109;
            var val_110;
            System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Boolean> val_112;
            var val_113;
            System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Int32> val_115;
            var val_116;
            var val_117;
            var val_118;
            var val_119;
            var val_120;
            System.Func<Rilisoft.GameCurrencyData, System.Int32> val_122;
            var val_123;
            丈丞丕丘丕丗与上一 val_124;
            var val_125;
            val_86 = 丌丒丝东丌下丕丁丅;
            val_87 = 丁丅丈丌丟世丗丗丟;
            if(val_87 > 1049)
            {
                goto label_1;
            }
            
            if(val_87 <= 84)
            {
                goto label_2;
            }
            
            if(val_87 > 1009)
            {
                goto label_3;
            }
            
            if(val_87 == 85)
            {
                goto label_4;
            }
            
            if(val_87 != 1000)
            {
                goto label_43;
            }
            
            val_88 = null;
            val_88 = null;
            val_89 = 1152921505317228544;
            val_90 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_8;
            label_1:
            if(val_87 <= 1139)
            {
                goto label_9;
            }
            
            if(val_87 > 1309)
            {
                goto label_10;
            }
            
            if(val_87 == 1140)
            {
                goto label_11;
            }
            
            if(val_87 != 1200)
            {
                goto label_43;
            }
            
            val_91 = new 丈丞丕丘丕丗与上一();
            val_92 = val_86;
            val_93 = 丞丅上丏丂且下丅与;
            goto label_144;
            label_2:
            if(val_87 == 10)
            {
                goto label_14;
            }
            
            if(val_87 == 20)
            {
                goto label_15;
            }
            
            if(val_87 != 80)
            {
                goto label_43;
            }
            
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  丞丅上丏丂且下丅与)) == null)
            {
                goto label_139;
            }
            
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_3 = BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  val_2.Id, 万业丁七与丟丁东与:  false);
            if((val_3 == null) || ((System.Linq.Enumerable.Any<Rilisoft.GameCurrencyData>(source:  val_3)) == false))
            {
                goto label_22;
            }
            
            val_94 = 1152921505476386816;
            val_95 = null;
            val_95 = null;
            val_97 = 下丐丒一丝丈丝三丞.<>c.<>9__19_1;
            if(val_97 == null)
            {
                    System.Func<Rilisoft.GameCurrencyData, System.Int32> val_5 = null;
                val_97 = val_5;
                val_5 = new System.Func<Rilisoft.GameCurrencyData, System.Int32>(object:  下丐丒一丝丈丝三丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 下丐丒一丝丈丝三丞.<>c::丆丂丗丈丐业专东丞(Rilisoft.GameCurrencyData 七丏丄丅丌业与且丙));
                下丐丒一丝丈丝三丞.<>c.<>9__19_1 = val_97;
            }
            
            Rilisoft.GameCurrencyData val_7 = System.Linq.Enumerable.First<Rilisoft.GameCurrencyData>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.GameCurrencyData, System.Int32>(source:  val_3, keySelector:  val_5));
            decimal val_9 = System.Decimal.op_Implicit(value:  val_7.RealPrice);
            decimal val_11 = System.Decimal.op_Implicit(value:  val_7.CurrencyCount);
            val_98 = val_11.flags;
            val_99 = val_11.lo;
            val_100 = val_9.flags;
            val_101 = val_9.lo;
            goto label_32;
            label_9:
            if(val_87 == 1050)
            {
                goto label_33;
            }
            
            if(val_87 == 1070)
            {
                goto label_34;
            }
            
            if(val_87 != 1110)
            {
                goto label_43;
            }
            
            val_102 = "BattlePassCurrency";
            val_91 = new 丈丞丕丘丕丗与上一();
            val_92 = val_86;
            goto label_36;
            label_3:
            if(val_87 == 1010)
            {
                goto label_37;
            }
            
            if(val_87 != 1030)
            {
                goto label_43;
            }
            
            val_103 = null;
            val_103 = null;
            val_104 = 1152921505317228544;
            val_90 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            goto label_41;
            label_10:
            if(val_87 == 1310)
            {
                goto label_42;
            }
            
            if(val_87 != 1340)
            {
                goto label_43;
            }
            
            三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丞丅上丏丂且下丅与);
            if(val_12 == null)
            {
                goto label_139;
            }
            
            val_105 = val_12.业东丅东丌上丗丑不();
            val_106 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_105);
            if(val_106 == null)
            {
                    val_106 = new 丕丑丙丑丙东丌丘丕();
                val_105 = ExperienceController.丞丞丘业东丙丏七丌();
                val_106 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_105, 丏丆丐丑专与丄丘丞:  val_12);
            }
            
            val_94 = UnityEngine.Mathf.Min(a:  5, b:  val_12 + val_86);
            三丅丁丗丗丝丂万且 val_85 = val_12;
            if(val_85 >= val_94)
            {
                goto label_55;
            }
            
            do
            {
                UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0} {1}", arg0:  val_12.业东丅东丌上丗丑不(), arg1:  val_85));
                new 丕丑丙丑丙东丌丘丕() = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  new 丕丑丙丑丙东丌丘丕().丈一下下丞世三丑丄(), 丏丆丐丑专与丄丘丞:  val_85);
                丈丞丕丘丕丗与上一 val_25 = BalanceController.丝丗丅丂丟万丑东丂(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(), 丝三丛且丘不丌丙下:  val_12.三与丛丑且丐丈业丌());
                val_107 = val_25.东与三丌丅三丒丏业();
                val_85 = val_85 + 1;
                val_108 = val_25.丟丂丞不专丆万丒世() + 0;
            }
            while(val_85 < val_94);
            
            goto label_64;
            label_4:
            Rilisoft.丏丘七丞丄丙丌丞丁 val_29 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
            if(val_29 == null)
            {
                goto label_139;
            }
            
            val_109 = val_29.丙丕丞且丕不丘丙丑().丞丅世丄业丗丄丄丈();
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            goto label_139;
            label_11:
            System.Collections.Generic.List<PGCompany.丘丒下东丗丏丁丅业> val_32 = 丐东不丅丂丂丅丙不.上且丕丝丙不七丄丈();
            if(val_32 == null)
            {
                goto label_139;
            }
            
            val_110 = null;
            val_110 = null;
            val_112 = 下丐丒一丝丈丝三丞.<>c.<>9__19_2;
            if(val_112 == null)
            {
                    System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Boolean> val_33 = null;
                val_112 = val_33;
                val_33 = new System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Boolean>(object:  下丐丒一丝丈丝三丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 下丐丒一丝丈丝三丞.<>c::丐丘丁东丁丙东且专(PGCompany.丘丒下东丗丏丁丅业 七丏丄丅丌业与且丙));
                下丐丒一丝丈丝三丞.<>c.<>9__19_2 = val_112;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_34 = System.Linq.Enumerable.Where<PGCompany.丘丒下东丗丏丁丅业>(source:  val_32, predicate:  val_33);
            val_90 = val_34;
            if((System.Linq.Enumerable.Any<PGCompany.丘丒下东丗丏丁丅业>(source:  val_34)) == false)
            {
                goto label_139;
            }
            
            val_113 = null;
            val_113 = null;
            val_115 = 下丐丒一丝丈丝三丞.<>c.<>9__19_3;
            if(val_115 == null)
            {
                    System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Int32> val_37 = null;
                val_115 = val_37;
                val_37 = new System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Int32>(object:  下丐丒一丝丈丝三丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 下丐丒一丝丈丝三丞.<>c::丄三丕丝与丁丐下丗(PGCompany.丘丒下东丗丏丁丅业 七丏丄丅丌业与且丙));
                下丐丒一丝丈丝三丞.<>c.<>9__19_3 = val_115;
            }
            
            .与上丁与下丟丆一丕 = System.Linq.Enumerable.Min<PGCompany.丘丒下东丗丏丁丅业>(source:  val_90, selector:  val_37);
            PGCompany.丘丒下东丗丏丁丅业 val_40 = System.Linq.Enumerable.First<PGCompany.丘丒下东丗丏丁丅业>(source:  val_90, predicate:  new System.Func<PGCompany.丘丒下东丗丏丁丅业, System.Boolean>(object:  new 下丐丒一丝丈丝三丞.业丂七丏丟丕丌丂世(), method:  System.Boolean 下丐丒一丝丈丝三丞.业丂七丏丟丕丌丂世::丆丁万专七丄且丏一(PGCompany.丘丒下东丗丏丁丅业 七丏丄丅丌业与且丙)));
            decimal val_41 = System.Decimal.op_Implicit(value:  (下丐丒一丝丈丝三丞.业丂七丏丟丕丌丂世)[1152921543247304624].与上丁与下丟丆一丕);
            decimal val_44 = System.Decimal.op_Implicit(value:  val_40.Items.Item[0].Count);
            val_98 = val_44.flags;
            val_99 = val_44.lo;
            val_100 = val_41.flags;
            val_101 = val_41.lo;
            label_32:
            decimal val_45 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_100, hi = val_41.hi, lo = val_101, mid = val_41.mid}, d2:  new System.Decimal() {flags = val_98, hi = val_44.hi, lo = val_99, mid = val_44.mid});
            val_116 = val_45.flags;
            val_117 = val_45.lo;
            goto label_149;
            label_37:
            val_118 = null;
            val_118 = null;
            val_89 = 1152921505317228544;
            val_90 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            label_8:
            val_91 = new 丈丞丕丘丕丗与上一();
            val_92 = val_86;
            goto label_94;
            label_42:
            System.Nullable<CategoryNames> val_46 = Rilisoft.下丐丒一丝丈丝三丞.且东丈东丐七与丕丆(下丗丁丒丘东丂不丑:  30, 丕丁下丌不万丅丞丛:  丞丅上丏丂且下丅与);
            if(((-14410912) & 1) == 0)
            {
                goto label_139;
            }
            
            val_109 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  -14410912, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  true, 丗业丕七且丝丆丝丘:  false);
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            goto label_139;
            label_14:
            System.Nullable<CategoryNames> val_48 = Rilisoft.下丐丒一丝丈丝三丞.且东丈东丐七与丕丆(下丗丁丒丘东丂不丑:  10, 丕丁下丌不万丅丞丛:  丞丅上丏丂且下丅与);
            if(((-14410904) & 1) == 0)
            {
                goto label_104;
            }
            
            val_90 = 1152921525530195616;
            val_109 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  -14410904, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            val_119 = ;
            goto label_110;
            label_33:
            val_109 = Rilisoft.三一丈七且丄与丝东.七丅三下丝丑三丝三(丑丏万丈丟丝丝丌丗:  val_86);
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            goto label_139;
            label_15:
            val_119 = 7;
            label_110:
            val_109 = 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  7, 丛丐且下丂丏丁专丌:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            goto label_139;
            label_34:
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_52 = BalanceController.丕丙丛且丏三上不丛(丆万一不丌且东丐丐:  丞丅上丏丂且下丅与, 万业丁七与丟丁东与:  false);
            if((val_52 == null) || (val_52.Count < 1))
            {
                goto label_139;
            }
            
            val_94 = 1152921505476386816;
            val_120 = null;
            val_120 = null;
            val_122 = 下丐丒一丝丈丝三丞.<>c.<>9__19_0;
            if(val_122 == null)
            {
                    System.Func<Rilisoft.GameCurrencyData, System.Int32> val_54 = null;
                val_122 = val_54;
                val_54 = new System.Func<Rilisoft.GameCurrencyData, System.Int32>(object:  下丐丒一丝丈丝三丞.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 下丐丒一丝丈丝三丞.<>c::东丙丏丅专专下与丆(Rilisoft.GameCurrencyData 七丞丙丒三丕且丌丟));
                下丐丒一丝丈丝三丞.<>c.<>9__19_0 = val_122;
            }
            
            Rilisoft.GameCurrencyData val_56 = System.Linq.Enumerable.First<Rilisoft.GameCurrencyData>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.GameCurrencyData, System.Int32>(source:  val_52, keySelector:  val_54));
            if(val_56.CurrencyCount < 1)
            {
                goto label_129;
            }
            
            decimal val_59 = System.Decimal.op_Implicit(value:  val_56.RealPrice);
            decimal val_61 = System.Decimal.op_Implicit(value:  val_56.CurrencyCount);
            decimal val_62 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = val_59.flags, hi = val_59.hi, lo = val_59.lo, mid = val_59.mid}, d2:  new System.Decimal() {flags = val_61.flags, hi = val_61.hi, lo = val_61.lo, mid = val_61.mid});
            val_116 = val_62.flags;
            val_117 = val_62.lo;
            goto label_134;
            label_43:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  val_87, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与)) == false)
            {
                goto label_139;
            }
            
            val_90 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  val_87, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
            PGCompany.丗丟丄丈东丝丕丄世 val_67 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_90);
            if(val_67 == null)
            {
                goto label_139;
            }
            
            val_90 = val_67.丟丂丞不专丆万丒世();
            val_91 = new 丈丞丕丘丕丗与上一();
            val_92 = val_90 * val_86;
            val_93 = val_67.东与三丌丅三丒丏业();
            goto label_144;
            label_104:
            val_109 = 0;
            return (丈丞丕丘丕丗与上一)val_109;
            label_22:
            val_123 = null;
            val_123 = null;
            val_104 = 1152921505317228544;
            val_90 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            label_41:
            val_91 = new 丈丞丕丘丕丗与上一();
            val_92 = 0;
            label_94:
            val_93 = val_90;
            goto label_144;
            label_55:
            val_107 = 0;
            val_108 = 0;
            label_64:
            val_90 = 上丑三丁丄丛丁万丑.丙不一上丂丗丌下专(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒世丘丘上丆丝东丞:  0);
            val_124 = new 丈丞丕丘丕丗与上一();
            val_124 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_90, 丏丂不专上丘丂不丅:  val_107);
            goto label_147;
            label_129:
            val_116 = 0;
            val_117 = 0;
            label_134:
            label_149:
            decimal val_72 = System.Decimal.op_Implicit(value:  val_86);
            decimal val_73 = System.Decimal.op_Multiply(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_72.flags, hi = val_72.hi, lo = val_72.lo, mid = val_72.mid});
            val_90 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_73.flags, hi = val_73.hi, lo = val_73.lo, mid = val_73.mid});
            丈丞丕丘丕丗与上一 val_75 = null;
            val_102 = "Real";
            val_91 = val_75;
            val_92 = val_90;
            label_36:
            label_144:
            val_75 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_92, 丏丂不专上丘丂不丅:  val_102);
            label_147:
            if(val_91 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            label_139:
            System.Nullable<CategoryNames> val_76 = Rilisoft.下丐丒一丝丈丝三丞.且东丈东丐七与丕丆(下丗丁丒丘东丂不丑:  val_87, 丕丁下丌不万丅丞丛:  丞丅上丏丂且下丅与);
            if(((-14410920) & 1) == 0)
            {
                goto label_159;
            }
            
            val_87 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  -14410920, 丞一丁业丄一一业且:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_87 != null)
            {
                goto label_156;
            }
            
            val_87 = 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  -14410920, 丛丐且下丂丏丁专丌:  丞丅上丏丂且下丅与, 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_87 == null)
            {
                goto label_159;
            }
            
            label_156:
            val_86 = System.Math.Max(val1:  val_87.丟丂丞不专丆万丒世() * val_86, val2:  0);
            丈丞丕丘丕丗与上一 val_83 = null;
            val_109 = val_83;
            val_83 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_86, 丏丂不专上丘丂不丅:  val_87.东与三丌丅三丒丏业());
            if(val_109 != null)
            {
                    return (丈丞丕丘丕丗与上一)val_109;
            }
            
            label_159:
            val_125 = null;
            val_125 = null;
            val_86 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            丈丞丕丘丕丗与上一 val_84 = null;
            val_109 = val_84;
            val_84 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_86);
            return (丈丞丕丘丕丗与上一)val_109;
        }
        internal static System.Collections.Generic.List<Rilisoft.OfferItem> 丝丅与丅丐专丁丌下(System.Collections.Generic.List<Rilisoft.OfferItem> 丑七不与丛丆一丂丞)
        {
            var val_4;
            Rilisoft.OfferItem val_16;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            List.Enumerator<T> val_2 = 丑七不与丛丆一丂丞.GetEnumerator();
            label_15:
            if(((-14017328) & 1) == 0)
            {
                goto label_2;
            }
            
            new 下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东() = new 下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东();
            .下丅丙一丂丗丅丝七 = val_4.丐丏七丌丕丗业且上();
            System.Predicate<Rilisoft.OfferItem> val_7 = new System.Predicate<Rilisoft.OfferItem>(object:  new 下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东(), method:  System.Boolean 下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东::丘丑专丁丕三丆丄一(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            Rilisoft.OfferItem val_8 = val_1.Find(match:  null);
            if((val_8 == null) || ((下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东)[1152921543247587632].下丅丙一丂丗丅丝七.IsStackable ^ 1 == true))
            {
                goto label_7;
            }
            
            val_8.Count = (下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东)[1152921543247587632].下丅丙一丂丗丅丝七.Count + val_8.Count;
            goto label_15;
            label_7:
            val_16 = (下丐丒一丝丈丝三丞.丒业丛丟专丛丒与东)[1152921543247587632].下丅丙一丂丗丅丝七.Clone();
            if(val_16 != null)
            {
                    val_16 = 0;
            }
            
            val_1.Add(item:  val_16);
            goto label_15;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static System.Nullable<CategoryNames> 且东丈东丐七与丕丆(Rilisoft.OfferItemType 下丗丁丒丘东丂不丑, string 丕丁下丌不万丅丞丛 = "")
        {
            var val_6;
            var val_7;
            if(下丗丁丒丘东丂不丑 <= 80)
            {
                goto label_1;
            }
            
            if(下丗丁丒丘东丂不丑 <= 1050)
            {
                goto label_2;
            }
            
            if(下丗丁丒丘东丂不丑 <= 1150)
            {
                goto label_3;
            }
            
            if(下丗丁丒丘东丂不丑 == 1160)
            {
                    return 0;
            }
            
            if(下丗丁丒丘东丂不丑 == 1310)
            {
                goto label_15;
            }
            
            if(下丗丁丒丘东丂不丑 != 1340)
            {
                    return 0;
            }
            
            goto label_15;
            label_1:
            if(下丗丁丒丘东丂不丑 <= 30)
            {
                goto label_8;
            }
            
            if(下丗丁丒丘东丂不丑 <= 50)
            {
                goto label_9;
            }
            
            if(下丗丁丒丘东丂不丑 == 60)
            {
                goto label_10;
            }
            
            if(下丗丁丒丘东丂不丑 == 70)
            {
                goto label_21;
            }
            
            if(下丗丁丒丘东丂不丑 != 80)
            {
                    return 0;
            }
            
            val_6 = 1152921524416091376;
            return 0;
            label_2:
            if(下丗丁丒丘东丂不丑 <= 1000)
            {
                goto label_14;
            }
            
            if(下丗丁丒丘东丂不丑 == 1030)
            {
                goto label_15;
            }
            
            return 0;
            label_8:
            if(下丗丁丒丘东丂不丑 <= 10)
            {
                goto label_17;
            }
            
            if(下丗丁丒丘东丂不丑 == 20)
            {
                goto label_18;
            }
            
            if(下丗丁丒丘东丂不丑 != 30)
            {
                    return 0;
            }
            
            val_6 = 1152921524416091376;
            return 0;
            label_3:
            if(下丗丁丒丘东丂不丑 == 1080)
            {
                goto label_21;
            }
            
            if(下丗丁丒丘东丂不丑 != 1150)
            {
                    return 0;
            }
            
            return 0;
            label_9:
            if(下丗丁丒丘东丂不丑 == 40)
            {
                goto label_24;
            }
            
            if(下丗丁丒丘东丂不丑 != 50)
            {
                    return 0;
            }
            
            val_6 = 1152921524416091376;
            return 0;
            label_14:
            if(下丗丁丒丘东丂不丑 != 83)
            {
                    return 0;
            }
            
            val_6 = 1152921524416091376;
            return 0;
            label_17:
            if(下丗丁丒丘东丂不丑 == 0)
            {
                    return 0;
            }
            
            if(下丗丁丒丘东丂不丑 != 10)
            {
                    return 0;
            }
            
            label_15:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丕丁下丌不万丅丞丛)) == true)
            {
                    return 0;
            }
            
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛);
            if(val_2 == null)
            {
                    return 0;
            }
            
            val_7 = 1152921524416091376;
            int val_4 = val_2.万上丄下业丛丌不丈() - 1;
            return 0;
            label_21:
            int val_5 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  丕丁下丌不万丅丞丛);
            val_7 = 1152921524416091376;
            return 0;
            label_18:
            val_6 = 1152921524416091376;
            return 0;
            label_24:
            val_6 = 1152921524416091376;
            return 0;
            label_10:
            val_6 = 1152921524416091376;
            return 0;
        }
        internal static Rilisoft.OfferItemType 且丆世丄世丆下下万(CategoryNames 七丆丒与丗丌丄且丂)
        {
            if((七丆丒与丗丌丄且丂 - 6) > 6)
            {
                    return 0;
            }
            
            return (Rilisoft.OfferItemType)106024384 + ((七丆丒与丗丌丄且丂 - 6)) << 2;
        }
        internal static int 丈丗三上不丏三万丛(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟)
        {
            var val_8 = 65536;
            val_8 = 1;
            if(丁丅丈丌丟世丗丗丟 <= 85)
            {
                goto label_0;
            }
            
            if(丁丅丈丌丟世丗丗丟 <= 1040)
            {
                goto label_1;
            }
            
            if(丁丅丈丌丟世丗丗丟 <= 1060)
            {
                goto label_2;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 1070)
            {
                    return 120;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1310)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 1340) ? 420 : 99999;
            }
            
            val_8 = 410;
            return 410;
            label_0:
            if(丁丅丈丌丟世丗丗丟 <= 40)
            {
                goto label_6;
            }
            
            if(丁丅丈丌丟世丗丗丟 <= 60)
            {
                goto label_7;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 70)
            {
                    return 110;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 80)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 1040) ? 130 : 99999;
            }
            
            return 120;
            label_1:
            if(丁丅丈丌丟世丗丗丟 <= 1010)
            {
                goto label_10;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 1020)
            {
                    return 100;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 1030)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 1040) ? 130 : 99999;
            }
            
            return 400;
            label_6:
            if(丁丅丈丌丟世丗丗丟 <= 10)
            {
                goto label_13;
            }
            
            if(丁丅丈丌丟世丗丗丟 == 20)
            {
                    return 200;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 30)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 40) ? 220 : 99999;
            }
            
            return 210;
            label_2:
            if(丁丅丈丌丟世丗丗丟 == 1050)
            {
                    return 410;
            }
            
            return (int)(丁丅丈丌丟世丗丗丟 == 1060) ? 110 : 99999;
            label_7:
            if(丁丅丈丌丟世丗丗丟 != 50)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 60) ? 240 : 99999;
            }
            
            return 230;
            label_10:
            if(丁丅丈丌丟世丗丗丟 != 1000)
            {
                    return (int)(丁丅丈丌丟世丗丗丟 == 1010) ? 20000 : 99999;
            }
            
            return 10000;
            label_13:
            if(丁丅丈丌丟世丗丗丟 == 0)
            {
                    return 410;
            }
            
            return (int)(丁丅丈丌丟世丗丗丟 == 10) ? 100 : 99999;
        }
        private static 下丐丒一丝丈丝三丞()
        {
            Rilisoft.下丐丒一丝丈丝三丞.不三业丁一丄业丁丅 = new Rilisoft.OfferItemType[10];
            Rilisoft.下丐丒一丝丈丝三丞.丑下丟且丐丌丟丌万 = new Rilisoft.OfferItemType[10];
            Rilisoft.下丐丒一丝丈丝三丞.东丕丏丟丞丏丑丟丘 = new Rilisoft.OfferItemType[4];
        }
    
    }

}
