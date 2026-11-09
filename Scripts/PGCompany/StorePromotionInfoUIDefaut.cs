using UnityEngine;

namespace PGCompany
{
    internal class StorePromotionInfoUIDefaut : StorePromotionInfoUIAbstract
    {
        // Fields
        private Rilisoft.ItemViewer 丅专丗丒与丏丘东丐;
        
        // Methods
        protected override void 丝一丅丆三东丂丞七()
        {
            var val_8;
            var val_35;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_37;
            var val_38;
            PGCompany.三东丏不丗世丅丌丄 val_39;
            int val_40;
            string val_41;
            var val_42;
            ItemRarity val_43;
            var val_44;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_46;
            System.Collections.Generic.IEnumerable<TSource> val_47;
            var val_48;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_50;
            if(Count < 1)
            {
                goto label_39;
            }
            
            val_35 = null;
            val_35 = null;
            val_37 = StorePromotionInfoUIDefaut.<>c.<>9__1_0;
            if(val_37 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_2 = null;
                val_37 = val_2;
                val_2 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StorePromotionInfoUIDefaut.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIDefaut.<>c::东丞丟丙不丕不丑丁(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                StorePromotionInfoUIDefaut.<>c.<>9__1_0 = val_37;
            }
            
            val_38 = 1152921539224055120;
            PGCompany.三东丏不丗世丅丌丄 val_3 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  static_value_082CA000, predicate:  val_2);
            if(val_3 == null)
            {
                goto label_10;
            }
            
            val_39 = val_3;
            goto label_13;
            label_10:
            PGCompany.三东丏不丗世丅丌丄 val_4 = val_3.Item[0];
            val_37 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_4);
            if(val_37 == null)
            {
                goto label_39;
            }
            
            List.Enumerator<T> val_6 = val_4.GetEnumerator();
            val_40 = 0;
            goto label_23;
            label_25:
            string val_9 = val_8.丐丏七丌丕丗业且上();
            val_41 = val_37.业上丙丞丐丄丆丅七();
            if((System.String.op_Equality(a:  val_41, b:  val_9.业上丙丞丐丄丆丅七())) != false)
            {
                    val_40 = val_9.丂丁丏一丙丛业且丌() + val_40;
            }
            
            label_23:
            if(((-151748016) & 1) != 0)
            {
                goto label_25;
            }
            
            val_42 = public System.Void List.Enumerator<PGCompany.三东丏不丗世丅丌丄>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_38 = 1152921539224055120;
            val_37 = val_8.Item[0].与下不与丐丈丁丈万();
            val_37.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_40);
            val_39 = val_37;
            label_13:
            val_43 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_39);
            if(val_43 == null)
            {
                goto label_39;
            }
            
            if(this.丅专丗丒与丏丘东丐 != 0)
            {
                    this.丅专丗丒与丏丘东丐.remove_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StorePromotionInfoUIDefaut::三不丄丂不专丙一丄()));
                this.丅专丗丒与丏丘东丐 = 0;
            }
            
            if((this.丅专丗丒与丏丘东丐 == null) || ((System.String.op_Equality(a:  this.丅专丗丒与丏丘东丐.丝丒丙一丙丄不三丞(), b:  "event")) == false))
            {
                goto label_47;
            }
            
            val_44 = null;
            val_44 = null;
            val_46 = StorePromotionInfoUIDefaut.<>c.<>9__1_1;
            if(val_46 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_21 = null;
                val_46 = val_21;
                val_21 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StorePromotionInfoUIDefaut.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIDefaut.<>c::与丛不丆丂上业丟三(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                StorePromotionInfoUIDefaut.<>c.<>9__1_1 = val_46;
            }
            
            val_47 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  this.丅专丗丒与丏丘东丐, predicate:  val_21);
            if(val_47 != null)
            {
                goto label_54;
            }
            
            val_48 = null;
            val_48 = null;
            val_50 = StorePromotionInfoUIDefaut.<>c.<>9__1_2;
            if(val_50 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_23 = null;
                val_50 = val_23;
                val_23 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  StorePromotionInfoUIDefaut.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIDefaut.<>c::且东不不丙七丑一丅(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                StorePromotionInfoUIDefaut.<>c.<>9__1_2 = val_50;
            }
            
            val_47 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_47, predicate:  val_23);
            if(val_47 == null)
            {
                goto label_61;
            }
            
            label_54:
            val_43 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  val_47);
            label_61:
            val_37 = this.丘业丗丝专丒丅丄丏(且丘丏丁丑与丙与丁:  0);
            goto label_69;
            label_39:
            UnityEngine.Debug.LogError(message:  "promotion in null or promotion products is nulled or empty");
            this.丆世与丑丆丅丐万且();
            return;
            label_47:
            if(null != null)
            {
                    val_37 = 0;
            }
            else
            {
                    int val_27 = ExperienceController.丞丞丘业东丙丏七丌();
                ItemViewer.丕丈丏丑丌丂且万不 val_28 = null;
                val_37 = val_28;
                val_28 = new ItemViewer.丕丈丏丑丌丂且万不();
                丕丑丙丑丙东丌丘丕 val_29 = null;
                val_41 = val_29;
                val_29 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_27, 丏丆丐丑专与丄丘丞:  val_43);
                if(val_37 != null)
            {
                    .丅万丗上三不丙丆丒 = val_41;
            }
            else
            {
                    mem[16] = val_41;
            }
            
                .万丄丅丛下丐丒丞上 = val_27;
            }
            
            label_69:
            Rilisoft.ItemViewer val_31 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  this.丌丟丄业且三丛丕丄(), 下丅丙一丂丗丅丝七:  val_43, 丗丟上上丒丐丗丞丙:  val_28, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 丒不业且丄丅世世下:  false);
            this.丅专丗丒与丏丘东丐 = val_31;
            if(val_31 == 0)
            {
                    return;
            }
            
            System.Action val_33 = null;
            val_37 = val_33;
            val_33 = new System.Action(object:  this, method:  System.Void PGCompany.StorePromotionInfoUIDefaut::三不丄丂不专丙一丄());
            this.丅专丗丒与丏丘东丐.add_OnHide(丙业与丙丗丝不丈东:  val_33);
        }
        private void 三不丄丂不专丙一丄()
        {
            this.丅专丗丒与丏丘东丐.remove_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StorePromotionInfoUIDefaut::三不丄丂不专丙一丄()));
            this.丆世与丑丆丅丐万且();
        }
        private System.Collections.Generic.List<Rilisoft.OfferItem> 丌世万下丛三丈且丈(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一丏七丐丏丐丞丏丙)
        {
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            List.Enumerator<T> val_2 = 一丏七丐丏丐丞丏丙.GetEnumerator();
            label_9:
            if(((-151376536) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_3 = 0.丐丏七丌丕丗业且上();
            val_1.Add(item:  Rilisoft.OfferItem.丂丈世不七丆一丛下(丁丅丈丌丟世丗丗丟:  val_3.不业丙丒丂丞下丆丙(), 丞丅上丏丂且下丅与:  val_3.业上丙丞丐丄丆丅七(), 丌丒丝东丌下丕丁丅:  val_3.丂丁丏一丙丛业且丌()));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        private void 七丐丝万丟丛丅丕丑(System.Collections.Generic.List<Rilisoft.OfferItem> 丞丑丘丂不不丝丈丞)
        {
            List.Enumerator<T> val_1 = 丞丑丘丂不不丝丈丞.GetEnumerator();
            label_5:
            if(((-151231736) & 1) == 0)
            {
                goto label_2;
            }
            
            Rilisoft.OfferItem.丁丟丞丗丆七丙丐丌(下丅丙一丂丗丅丝七:  0.丐丏七丌丕丗业且上());
            goto label_5;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private Rilisoft.ItemViewer.丕丈丏丑丌丂且万不 丘业丗丝专丒丅丄丏(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
        {
            var val_11;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_13;
            var val_14;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_16;
            var val_17;
            var val_18;
            PGCompany.三东丏不丗世丅丌丄 val_19;
            System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = 且丘丏丁丑与丙与丁.丌世万下丛三丈且丈(一丏七丐丏丐丞丏丙:  且丘丏丁丑与丙与丁);
            if((val_1 == null) || ((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_1)) == false))
            {
                goto label_15;
            }
            
            val_11 = null;
            val_11 = null;
            val_13 = StorePromotionInfoUIDefaut.<>c.<>9__5_0;
            if(val_13 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_3 = null;
                val_13 = val_3;
                val_3 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  StorePromotionInfoUIDefaut.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIDefaut.<>c::丁下丞丞丒丝丝丈丒(Rilisoft.OfferItem 东七上世万下丗丄丛));
                StorePromotionInfoUIDefaut.<>c.<>9__5_0 = val_13;
            }
            
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  val_1, predicate:  val_3)) == false)
            {
                goto label_9;
            }
            
            val_14 = null;
            val_14 = null;
            val_16 = StorePromotionInfoUIDefaut.<>c.<>9__5_1;
            if(val_16 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_5 = null;
                val_16 = val_5;
                val_5 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  StorePromotionInfoUIDefaut.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean StorePromotionInfoUIDefaut.<>c::丅东上丂专丗上七且(Rilisoft.OfferItem 东七上世万下丗丄丛));
                StorePromotionInfoUIDefaut.<>c.<>9__5_1 = val_16;
            }
            
            Rilisoft.OfferItem val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_1, predicate:  val_5);
            val_17 = val_6;
            if(val_6 == null)
            {
                goto label_15;
            }
            
            label_20:
            ItemViewer.丕丈丏丑丌丂且万不 val_7 = null;
            val_18 = val_7;
            val_7 = new ItemViewer.丕丈丏丑丌丂且万不();
            .丅万丗上三不丙丆丒 = Rilisoft.Offers.上一丈丏三丒三丙不.丙丈一丒三丁七丝一(丟专丑丈七与上七丞:  val_1);
            this.七丐丝万丟丛丅丕丑(丞丑丘丂不不丝丈丞:  val_1);
            if(val_18 == null)
            {
                    return (丕丈丏丑丌丂且万不)val_18;
            }
            
            if(val_17 == null)
            {
                goto label_18;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_9 = val_17.ItemParams;
            goto label_19;
            label_9:
            Rilisoft.OfferItem val_10 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_1);
            val_17 = 0;
            if(val_10 != null)
            {
                goto label_20;
            }
            
            label_15:
            val_10.七丐丝万丟丛丅丕丑(丞丑丘丂不不丝丈丞:  val_1);
            val_18 = 0;
            return (丕丈丏丑丌丂且万不)val_18;
            label_18:
            val_19 = 0;
            label_19:
            .七丐丝东丛丂万丄丆 = val_19;
            return (丕丈丏丑丌丂且万不)val_18;
        }
        public StorePromotionInfoUIDefaut()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
