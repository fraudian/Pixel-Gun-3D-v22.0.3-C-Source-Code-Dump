using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemButtonPurchase : ItemButtonAbstract
    {
        // Fields
        private static System.Action<PGCompany.丟丁且丝丁三丏丙且, PGCompany.三东丏不丗世丅丌丄> 丏不不一丒丁七丒丂;
        
        // Methods
        internal static void 丐丞万丂不丆下丌七(System.Action<PGCompany.丟丁且丝丁三丏丙且, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ItemButtonPurchase.丏不不一丒丁七丒丂, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 一专丐丁东东且丌丟(System.Action<PGCompany.丟丁且丝丁三丏丙且, PGCompany.三东丏不丗世丅丌丄> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ItemButtonPurchase.丏不不一丒丁七丒丂, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        protected override void 丞丙东丌一三专丏不()
        {
            string val_42;
            int val_43;
            string val_44;
            if(与丈丟东丆丅丅丝丁() == false)
            {
                    return;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_2 = 下丆丄与世丂丞丂七();
            val_42 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            bool val_4 = val_42.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_2, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_4 == false)
            {
                goto label_5;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  25);
            PGCompany.StoreItemSettings val_7 = X22.丏丘下丞丘不丑万丏();
            PGCompany.丗丟丄丈东丝丕丄世 val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙世丕丒世丞丌丆下(七不丅丄业丞丂专三:  val_2, 丌丄不丒丐丆且丌与:  val_7.ItemParams, 东丆下丌业上丙下七:  new PGCompany.世世丘丝丞业三世一() {丁丞丌与丘丝丕丈丂 = 191, 且丝丕丆不丅丏丛东 = new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, 丁丁丒丆不丒下丟三 = 113, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false}, 丁东丑丏丐丏丄一丒 = new PGCompany.丆丈丘东丆丕三丞东()});
            val_43 = 1152921505690124288;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_10 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            PGCompany.StoreItemSettings val_11 = X23.丏丘下丞丘不丑万丏();
            val_10.Add(item:  val_11.ItemParams);
            val_44 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().丒万世且丟丒丅东丞(下丅丙一丂丗丅丝七:  val_11.ItemParams);
            PGCompany.Analytics.一业丗丆世世上丁且.三与丆丏下丐不丆丄(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丅丘丌且丈丘丄丗丄:  val_10, 丒世丘丘上丆丝东丞:  val_2, 丐丅丒专丛丏上与业:  val_44);
            丙丏丂丌丅丕丆三且 val_14 = 丙丏丂丌丅丕丆三且.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_15 = val_10.丒丅丙丄丞丟下丏业();
            val_14.丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_15);
            PGCompany.StoreItemSettings val_16 = val_14.丏丘下丞丘不丑万丏();
            if(val_16.ItemParams.不业丙丒丂丞下丆丙() == 1080)
            {
                goto label_27;
            }
            
            PGCompany.StoreItemSettings val_18 = val_16.ItemParams.丏丘下丞丘不丑万丏();
            if(val_18.ItemParams.不业丙丒丂丞下丆丙() != 20)
            {
                goto label_31;
            }
            
            label_27:
            PGCompany.StoreItemSettings val_21 = val_15.丏丘下丞丘不丑万丏();
            PGCompany.StoreItemSettings val_24 = val_44.丏丘下丞丘不丑万丏();
            val_44 = val_24.ItemParams.业上丙丞丐丄丆丅七();
            val_43 = val_2.丂丁丏一丙丛业且丌();
            new 丈丞丕丘丕丗与上一() = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  val_43, 丏丂不专上丘丂不丅:  val_2.业上丙丞丐丄丆丅七());
            PGCompany.Analytics.一业丗丆世世上丁且.一丁七丂且丁丗万丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丆丒与丗丌丄且丂:  (val_21.ItemParams.不业丙丒丂丞下丆丙() == 1080) ? 190000 : 7, 丞一丁业丄一一业且:  val_44, 七丐丅专且专七三丆:  "buy", 万丐丏丐丒万不丟三:  new 丈丞丕丘丕丗与上一(), 与上世丗丞丐万东丌:  "clan shop", 与丙丆世丘丑丒丌丄:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丞业丛世丛丘丝不丌:  false, 丈丄不七三万丄丁不:  0);
            label_31:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(PGCompany.ClanStoreMainUI.丑七不且上丗丁一世() != 0)
            {
                    PGCompany.StoreListItemView val_33 = PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().丛且专丑业丆东东丝();
                val_33.丏丛不丄丑上专丐丝();
            }
            
            val_42 = val_33.丒丅丙丄丞丟下丏业();
            if(val_42.不业丙丒丂丞下丆丙() != 1080)
            {
                goto label_58;
            }
            
            Rilisoft.OfferItemType val_36 = val_2.不业丙丒丂丞下丆丙();
            System.Globalization.CultureInfo val_37 = System.Globalization.CultureInfo.InvariantCulture;
            if(val_36 == 0)
            {
                goto label_62;
            }
            
            val_42 = val_36.ToString(provider:  val_37);
            goto label_63;
            label_5:
            val_4.万丞丌七丈丄丙东万(丒世丘丘上丆丝东丞:  val_2);
            return;
            label_62:
            val_42 = val_36.ToString(provider:  val_37);
            label_63:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            int val_40 = val_2.丂丁丏一丙丛业且丌();
            Rilisoft.一丟专且三万丞丁丂.丁丝三三丌丏丑一七(丏丂不专上丘丂不丅:  val_42, 丌丒丝东丌下丕丁丅:  val_40);
            label_58:
            if(PGCompany.ItemButtonPurchase.丏不不一丒丁七丒丂 == null)
            {
                    return;
            }
            
            PGCompany.ItemButtonPurchase.丏不不一丒丁七丒丂.Invoke(arg1:  val_40, arg2:  val_2);
        }
        public ItemButtonPurchase()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
