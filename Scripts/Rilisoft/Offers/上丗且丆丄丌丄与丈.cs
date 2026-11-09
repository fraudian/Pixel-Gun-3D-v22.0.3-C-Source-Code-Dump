using UnityEngine;

namespace Rilisoft.Offers
{
    internal class 上丗且丆丄丌丄与丈 : 丌且丐丅丗七万丆丙
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 且丑不丛丏丏丐丄丐;
        private System.Collections.Generic.List<Rilisoft.OfferItem> 下丑与丆三丒与三东;
        
        // Methods
        public override System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> 东东丛一丄丅丌丗且()
        {
            return (System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>)this.且丑不丛丏丏丐丄丐;
        }
        public override void 七丞丐丝丈丁丝东三()
        {
            var val_17;
            var val_24;
            var val_25;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_27;
            var val_29;
            var val_30;
            var val_31;
            var val_34;
            var val_35;
            var val_36;
            var val_38;
            var val_39;
            var val_41;
            System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_43;
            this.且丑不丛丏丏丐丄丐.Clear();
            if(ExperienceController.丞丞丘业东丙丏七丌() < 3)
            {
                    return;
            }
            
            System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄> val_3 = Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().东东丛一丄丅丌丗且(世七七丟丑丁丂与丞:  40);
            if(val_3 == null)
            {
                    return;
            }
            
            if(val_3.Count == 0)
            {
                    return;
            }
            
            val_24 = 1152921505508761600;
            val_25 = null;
            val_25 = null;
            val_27 = 上丗且丆丄丌丄与丈.<>c.<>9__3_0;
            if(val_27 == null)
            {
                    System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean> val_5 = null;
                val_27 = val_5;
                val_5 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Boolean>(object:  上丗且丆丄丌丄与丈.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 上丗且丆丄丌丄与丈.<>c::丞丛业丑丆下丟三丑(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
                上丗且丆丄丌丄与丈.<>c.<>9__3_0 = val_27;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Where<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_3, predicate:  val_5);
            if((System.Linq.Enumerable.Any<Rilisoft.业丙丘丆东丈丕丂丄>(source:  val_6)) == false)
            {
                goto label_82;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            System.Collections.Generic.IEnumerator<T> val_9 = val_6.GetEnumerator();
            val_29 = 1152921504686346240;
            val_30 = 0;
            val_31 = 0;
            label_57:
            label_33:
            var val_29 = 0;
            val_29 = val_29 + 1;
            if(val_9.MoveNext() == false)
            {
                goto label_26;
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            T val_13 = val_9.Current;
            if(val_13 == 0)
            {
                goto label_33;
            }
            
            System.Collections.Generic.List<Rilisoft.OfferItem> val_14 = val_13.丈丏丙且丏一七丒一();
            if(val_14 == null)
            {
                goto label_33;
            }
            
            List.Enumerator<T> val_15 = val_14.GetEnumerator();
            label_39:
            if((564804544 & 1) == 0)
            {
                goto label_34;
            }
            
            new 上丗且丆丄丌丄与丈.上丌专丄丘丂东且丒() = new System.Object();
            string val_19 = val_17.丐丏七丌丕丗业且上();
            if(new 上丗且丆丄丌丄与丈.上丌专丄丘丂东且丒() != null)
            {
                    val_34 = new 上丗且丆丄丌丄与丈.上丌专丄丘丂东且丒();
                .下丅丙一丂丗丅丝七 = val_19;
            }
            else
            {
                    mem[16] = val_19;
                val_34 = 16;
            }
            
            if(val_34.IsEquipment == false)
            {
                goto label_39;
            }
            
            System.Func<Rilisoft.OfferItem, System.Boolean> val_21 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  new 上丗且丆丄丌丄与丈.上丌专丄丘丂东且丒(), method:  System.Boolean 上丗且丆丄丌丄与丈.上丌专丄丘丂东且丒::专丌丝丆丂丙业七丁(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
            val_31 = 0;
            if((System.Linq.Enumerable.Any<Rilisoft.OfferItem>(source:  this.下丑与丆三丒与三东, predicate:  null)) == false)
            {
                goto label_39;
            }
            
            val_35 = 1;
            val_36 = 1;
            goto label_41;
            label_34:
            val_36 = 0;
            val_35 = 0 + 1;
            mem2[0] = 236;
            label_41:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_35 == 1) || ((1152921543826357136 + ((0 + 1)) << 2) != 236))
            {
                goto label_51;
            }
            
            val_35 = val_35 + (val_31 ^ (val_35 >> 31));
            if(( & 1) != 0)
            {
                goto label_57;
            }
            
            goto label_53;
            label_51:
            if(( & 1) != 0)
            {
                goto label_57;
            }
            
            label_53:
            this.且丑不丛丏丏丐丄丐.Add(item:  val_13);
            goto label_57;
            label_26:
            val_38 = 0;
            val_39 = 0 + 1;
            mem2[0] = 275;
            if(val_9 == null)
            {
                
            }
            else
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                val_9.Dispose();
            }
            
            if(val_35 == 1)
            {
                goto label_72;
            }
            
            if(( == 0) || ((1152921543826357136 + ((0 + 1)) << 2) == 275))
            {
                goto label_82;
            }
            
            label_81:
            label_82:
            val_41 = null;
            val_43 = 上丗且丆丄丌丄与丈.<>c.<>9__3_1;
            if(val_43 == null)
            {
                    System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32> val_25 = null;
                val_43 = val_25;
                val_25 = new System.Func<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(object:  上丗且丆丄丌丄与丈.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 上丗且丆丄丌丄与丈.<>c::丗世东丌丟丈且丆与(Rilisoft.业丙丘丆东丈丕丂丄 丄三丅七丆丛与与上));
                上丗且丆丄丌丄与丈.<>c.<>9__3_1 = val_43;
            }
            
            this.且丑不丛丏丏丐丄丐 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.业丙丘丆东丈丕丂丄, System.Int32>(source:  this.且丑不丛丏丏丐丄丐, keySelector:  val_25));
            this.下丑与丆三丒与三东.Clear();
            return;
            label_72:
            if( != 0)
            {
                goto label_81;
            }
            
            goto label_82;
        }
        public override void 丝丈万一业丁三丙丛()
        {
            this.且丑不丛丏丏丐丄丐.Clear();
        }
        public override void 丁东丐丄丞丌丘业上()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.且丑不丛丏丏丐丄丐.GetEnumerator();
            val_3 = 1152921524493728448;
            label_4:
            if((565114696 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == null)
            {
                goto label_4;
            }
            
            val_2.丁东丐丄丞丌丘业上();
            goto label_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public 上丗且丆丄丌丄与丈()
        {
            this.且丑不丛丏丏丐丄丐 = new System.Collections.Generic.List<Rilisoft.业丙丘丆东丈丕丂丄>();
            this.下丑与丆三丒与三东 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
            this = new System.Object();
        }
    
    }

}
