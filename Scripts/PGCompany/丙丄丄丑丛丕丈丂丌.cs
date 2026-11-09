using UnityEngine;

namespace PGCompany
{
    internal class 丙丄丄丑丛丕丈丂丌
    {
        // Fields
        private static System.Action<PGCompany.丘丒下东丗丏丁丅业> 不丗三丂丐世丂丞丌;
        
        // Methods
        internal static void 丁丑丐丙下专业丒不(System.Action<PGCompany.丘丒下东丗丏丁丅业> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.丙丄丄丑丛丕丈丂丌.不丗三丂丐世丂丞丌, b:  丙业与丙丗丝不丈东);
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
        internal static void 丞丈丗丘丒上业下且(System.Action<PGCompany.丘丒下东丗丏丁丅业> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.丙丄丄丑丛丕丈丂丌.不丗三丂丐世丂丞丌, value:  丙业与丙丗丝不丈东);
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
        public static void 丙三丆丕丅丁丂与丏(PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞, Progress.下丁下丂七丆丙七一.丌丟丐丞三丘三丏丈 丄东三丕丟丅不丌丄 = 0, Progress.下丁下丂七丆丙七一.万丆且丁业且丕七丈 丟世且丕丂丁万丒万 = 0, Progress.下丁下丂七丆丙七一.七专丁丕世丏丁丘丛 丟丆丌丄丑丁业丝七 = 0)
        {
            万丆且丁业且丕七丈 val_20;
            var val_21;
            Rilisoft.OfferItem val_23;
            var val_24;
            var val_25;
            val_20 = 丟世且丕丂丁万丒万;
            if(东丈丏东丑丟不不丞 == null)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  40);
            val_21 = 0;
            if((System.String.op_Equality(a:  东丈丏东丑丟不不丞.Price.东与三丌丅三丒丏业(), b:  "Real")) == false)
            {
                goto label_6;
            }
            
            int val_4 = 东丈丏东丑丟不不丞.与丞丄丛东丕丈上且();
            if((val_4 & 2147483648) != 0)
            {
                goto label_38;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_21 = 0;
            goto label_14;
            label_6:
            val_23 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  东丈丏东丑丟不不丞.Price.东与三丌丅三丒丏业());
            if(val_23 < 东丈丏东丑丟不不丞.Price.丟丂丞不专丆万丒世())
            {
                goto label_38;
            }
            
            val_23 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_23.丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  173);
            bool val_11 = BankController.丈专丄丐专丗专与丙(丒世丘丘上丆丝东丞:  东丈丏东丑丟不不丞.Price, 不丐下上且万丈七丒:  true, 世丁丙世丄一万丆三:  val_20);
            val_20 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  东丈丏东丑丟不不丞.Items);
            val_24 = 0;
            goto label_26;
            label_33:
            val_23 = val_20.Item[0];
            if(val_23 != null)
            {
                    if((Rilisoft.下丐丒一丝丈丝三丞.丌丆不不东丅丟万东(下丅丙一丂丗丅丝七:  val_23)) != true)
            {
                    丐一且丝丂丟丞三丅.不业丁一与丏且丒丒(下丅丙一丂丗丅丝七:  val_23, 丁且丟不七下丆丒丟:  true, 丂丅丑七丌不丄上丞:  true, 丗东丗万丘丄丆丏东:  false, 丏丏七丘丈丌上且专:  true, 丄东三丕丟丅不丌丄:  丄东三丕丟丅不丌丄, 不丐丅丁丂七丐丘丛:  0, 丁七丐丁丙丄丙不东:  false);
            }
            
            }
            
            val_24 = 1;
            label_26:
            if(val_24 < val_20.Count)
            {
                goto label_33;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            if(PGCompany.丙丄丄丑丛丕丈丂丌.不丗三丂丐世丂丞丌 == null)
            {
                goto label_38;
            }
            
            PGCompany.丙丄丄丑丛丕丈丂丌.不丗三丂丐世丂丞丌.Invoke(obj:  东丈丏东丑丟不不丞);
            goto label_38;
            label_14:
            val_25 = null;
            val_25 = null;
            val_20 = coinsShop.专丆专上丗万世丒七;
            val_20.丌丆丙与丛专上东丌(一丒丆业丅七丛且丏:  AbstractBankView.丒丁丞丝世三与七东().Item[val_4], 丈上上丟丟丏万丐且:  PGCompany.丙丄丄丑丛丕丈丂丌.丐丂丅丞丆业丅七且(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞));
            label_38:
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丐丂丅丞丆业丅七且(PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞)
        {
            System.Collections.Generic.List<Rilisoft.OfferItem> val_9;
            var val_10;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_12;
            string val_14;
            var val_15;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_17;
            var val_18;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_20;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "isOffer", value:  true);
            string val_2 = 东丈丏东丑丟不不丞.丑丈丏业业丄丙丏且();
            if(val_1 != null)
            {
                    val_1.set_Item(key:  "ID", value:  val_2);
            }
            else
            {
                    val_1.set_Item(key:  "ID", value:  val_2);
            }
            
            val_1.set_Item(key:  "Type", value:  "product");
            val_1.set_Item(key:  "action", value:  "product");
            val_9 = 东丈丏东丑丟不不丞.Items;
            if(val_9 == null)
            {
                goto label_29;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = 丙丄丄丑丛丕丈丂丌.<>c.<>9__4_0;
            if(val_12 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_3 = null;
                val_12 = val_3;
                val_3 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙丄丄丑丛丕丈丂丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丄丄丑丛丕丈丂丌.<>c::丒世丞丑丌丏丑丛上(Rilisoft.OfferItem 七丏丄丅丌业与且丙));
                丙丄丄丑丛丕丈丂丌.<>c.<>9__4_0 = val_12;
            }
            
            if((System.Linq.Enumerable.All<Rilisoft.OfferItem>(source:  val_9, predicate:  val_3)) == false)
            {
                goto label_13;
            }
            
            val_9 = true;
            val_14 = "IsCraftCurrency";
            goto label_23;
            label_13:
            val_15 = null;
            val_15 = null;
            val_17 = 丙丄丄丑丛丕丈丂丌.<>c.<>9__4_1;
            if(val_17 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_5 = null;
                val_17 = val_5;
                val_5 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙丄丄丑丛丕丈丂丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丄丄丑丛丕丈丂丌.<>c::专丅丏与丛东世与丐(Rilisoft.OfferItem 七丏丄丅丌业与且丙));
                丙丄丄丑丛丕丈丂丌.<>c.<>9__4_1 = val_17;
            }
            
            if((System.Linq.Enumerable.All<Rilisoft.OfferItem>(source:  东丈丏东丑丟不不丞.Items, predicate:  val_5)) == false)
            {
                goto label_21;
            }
            
            val_9 = true;
            val_14 = "IsModuleChest";
            goto label_23;
            label_21:
            val_18 = null;
            val_9 = 东丈丏东丑丟不不丞.Items;
            val_18 = null;
            val_20 = 丙丄丄丑丛丕丈丂丌.<>c.<>9__4_2;
            if(val_20 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_7 = null;
                val_20 = val_7;
                val_7 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  丙丄丄丑丛丕丈丂丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丙丄丄丑丛丕丈丂丌.<>c::丆丛与丕世上丟丏业(Rilisoft.OfferItem 七丏丄丅丌业与且丙));
                丙丄丄丑丛丕丈丂丌.<>c.<>9__4_2 = val_20;
            }
            
            if((System.Linq.Enumerable.All<Rilisoft.OfferItem>(source:  val_9, predicate:  val_7)) == false)
            {
                goto label_29;
            }
            
            val_9 = true;
            val_14 = "IsClanSilver";
            label_23:
            val_1.Add(key:  val_14, value:  true);
            label_29:
            Rilisoft.Offers.丁且丕专万丈丒丏丗.丌丏丑专下丌丕丕丛(丈上上丟丟丏万丐且:  val_1, 丑七不与丛丆一丂丞:  东丈丏东丑丟不不丞.Items);
            return val_1;
        }
        public 丙丄丄丑丛丕丈丂丌()
        {
        
        }
    
    }

}
