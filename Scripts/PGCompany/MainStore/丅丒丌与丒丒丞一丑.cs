using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 丅丒丌与丒丒丞一丑 : 丙丝丛丘丂世丒丄丒
    {
        // Fields
        private UnityEngine.Coroutine 丕且丌丒三丞丂世专;
        
        // Properties
        internal override string 丐丞七下万丆丄丈业 { get; }
        protected override bool 专专世与上七丄丅与 { get; }
        protected override bool 丐丟且下丘丛丕丞且 { get; }
        internal override bool 丑丆丕业世一世一专 { get; }
        
        // Methods
        internal override string 与丕丝丒丞丗万丆丞()
        {
            return "source.pixelpass";
        }
        protected override bool 丆丑丟丙上丄丁一丕()
        {
            return false;
        }
        protected override bool 丗丘上丌下丌丗一万()
        {
            return true;
        }
        internal override bool 丗且丒且万丄丕东丟()
        {
            return false;
        }
        public 丅丒丌与丒丒丞一丑()
        {
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.东丄与丘丏专七世与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丆丏丄上三且且丘丛(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
        }
        public override void Dispose()
        {
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丛丈丟丟世世上丞七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
            PGCompany.PixelPass.丘丏丅丆丑下业丙七.丐丝一七丄丂丞东专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.丙丟下万丅一与丑不::丗丄丐万丏业丏丑万()));
        }
        protected override void 专且丗丁东丆丝与丞()
        {
            var val_13;
            object val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            val_30 = this;
            this.丟丕东丆上专七业丛();
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().与丌下丙丄丑丁业一() == false)
            {
                    return;
            }
            
            val_31 = PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丅丂业丈三丟丞万丏(丈丂七世丟丞丂丗丒:  PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙()).FindAll(match:  new System.Predicate<PGCompany.PixelPass.东丄三下丄丈三丌丅>(object:  this, method:  System.Boolean PGCompany.MainStore.丅丒丌与丒丒丞一丑::丒七丏一丝且丝丈与(PGCompany.PixelPass.东丄三下丄丈三丌丅 丙业丞丑七丗下丟丌)));
            if(val_31.Count == 0)
            {
                    return;
            }
            
            val_32 = 1152921505630273536;
            val_33 = 1152921537159741584;
            PGCompany.东丑丒丗一丞下丙丙<T> val_9 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
            int val_10 = val_31.Count;
            List.Enumerator<T> val_11 = val_31.GetEnumerator();
            val_34 = 1152921559800078864;
            label_15:
            if(((-641300272) & 1) == 0)
            {
                goto label_12;
            }
            
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_15 = this.丝与丘丘丅业一业丘(丗丗丆丐丆万丑丒七:  val_13.丐丏七丌丕丗业且上());
            if(val_15 == null)
            {
                goto label_15;
            }
            
            val_9.Add(item:  val_15);
            goto label_15;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.Linq.Enumerable.Any<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>(source:  val_9)) == false)
            {
                goto label_21;
            }
            
            if(val_9 != null)
            {
                    val_35 = 0;
                val_36 = val_9.Item[0];
            }
            else
            {
                    val_35 = 0;
                val_36 = 0.Item[0];
            }
            
            List.Enumerator<T> val_19 = 0.GetEnumerator();
            val_34 = 0;
            goto label_24;
            label_30:
            string val_20 = val_13.丐丏七丌丕丗业且上();
            decimal val_21 = Rilisoft.Offers.丁且丕专万丈丒丏丗.业丟丘丆七丌丕丌丅(丈丄不七三万丄丁不:  val_20, 世丈三丐丞一丒丛不:  1);
            bool val_22 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_21.flags, hi = val_21.hi, lo = val_21.lo, mid = val_21.mid}, d2:  new System.Decimal());
            var val_23 = (val_22 != true) ? val_21.flags : 0;
            var val_24 = (val_22 != true) ? val_21.lo : (val_34);
            label_24:
            if(((-641300304) & 1) != 0)
            {
                goto label_30;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_32 = 1152921505630273536;
            val_33 = 1152921537159741584;
            val_31 = (val_22 != true) ? (val_20) : (val_36).与不丞丑七丘丁丂丛();
            bool val_27 = val_31.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "best-value");
            label_21:
            this.万丌丌丛万万丆一丗(七丄丆丘丒与丐丘丅:  val_9);
            val_30 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.MainStore.下丐丒丙丂丁丗丘丘>.万世丅七一专丕丞不();
        }
        private PGCompany.MainStore.下丐丒丙丂丁丗丘丘 丝与丘丘丅业一业丘(PGCompany.PixelPass.东丄三下丄丈三丌丅 丗丗丆丐丆万丑丒七)
        {
            var val_9;
            var val_26;
            PGCompany.丙一丟与且丞丏丈一 val_28;
            PGCompany.StorePromotionConfig val_1 = 丗丗丆丐丆万丑丒七.丛下丆且丟丙与万丗();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_3 = this.不世丈丏丈上与东且();
            .丄丑丘专丄七不专丆 = val_3.Section;
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_4 = this.不世丈丏丈上与东且();
            .丘丏丐丞丈专三且世 = val_4.Season;
            .下丐丐丁与丂下世七 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
            PGCompany.StorePromotionSettings val_6 = val_1.Settings;
            List.Enumerator<T> val_7 = val_6.ItemsParams.GetEnumerator();
            label_20:
            if(((-641036720) & 1) == 0)
            {
                goto label_8;
            }
            
            string val_10 = val_9.丐丏七丌丕丗业且上();
            if(val_10 == null)
            {
                goto label_20;
            }
            
            new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_10);
            if((PGCompany.万丞丘与丕丞下万丌.丞丒丟丒且丑丏且业(丁丅丈丌丟世丗丗丟:  val_10.不业丙丒丂丞下丆丙())) != false)
            {
                    bool val_14 = (PGCompany.丄与丘丑业专丞七丅)[1152921559800474288].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-currency");
            }
            else
            {
                    bool val_15 = (PGCompany.丄与丘丑业专丞七丅)[1152921559800474288].Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "reward-main");
            }
            
            (PGCompany.DataObjects.专丅一丄上丗且丑一)[1152921559800437424].下丐丐丁与丂下世七.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
            goto label_20;
            label_2:
            val_26 = 0;
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_26;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.StorePromotionSettings val_16 = val_1.Settings;
            bool val_17 = val_16.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.disable-info-if-purchased");
            if(val_1.Identificator != null)
            {
                    val_28 = 0;
            }
            
            string val_20 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.丄三东丟丒三万世丄(一丗与一专丙丙丅丄:  val_28);
            if(丗丗丆丐丆万丑丒七.丆丑一丑丄丌且丑丗() != true)
            {
                    PGCompany.StorePromotionSettings val_22 = val_1.Settings;
                bool val_23 = val_22.Tag.业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.purchased");
            }
            
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘 val_24 = null;
            val_26 = val_24;
            val_24 = new PGCompany.MainStore.下丐丒丙丂丁丗丘丘(上世丏丁世丟世丆业:  val_1, 且万丄丏专丄丛丌丗:  new PGCompany.DataObjects.专丅一丄上丗且丑一());
            return (PGCompany.MainStore.下丐丒丙丂丁丗丘丘)val_26;
        }
        protected override void 丌丑丁上丞万丅丒丌(PGCompany.MainStore.下丐丒丙丂丁丗丘丘 且丘丏丁丑与丙与丁)
        {
            object val_16;
            PGCompany.丙一丟与且丞丏丈一 val_17;
            PGCompany.StorePromotionConfig val_18;
            丅丒丌与丒丒丞一丑.世东丒与丞七不不东 val_1 = null;
            val_16 = val_1;
            val_1 = new 丅丒丌与丒丒丞一丑.世东丒与丞七不不东();
            if(且丘丏丁丑与丙与丁.七丈丒丒下下且万与() != null)
            {
                    val_17 = 0;
            }
            
            .丞世不丒下上上丝丑 = PGCompany.PixelPass.丁且七丅丞丐丌丌世.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_17);
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_7 = PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙();
            if(val_7 != null)
            {
                    PGCompany.PixelPass.东丄三下丄丈三丌丅 val_10 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.东丄三下丄丈三丌丅>(source:  val_7.三丐上丐一丕上下不(), predicate:  new System.Func<PGCompany.PixelPass.东丄三下丄丈三丌丅, System.Boolean>(object:  val_1, method:  System.Boolean 丅丒丌与丒丒丞一丑.世东丒与丞七不不东::丂丑丟丞且七专丞丐(PGCompany.PixelPass.东丄三下丄丈三丌丅 丙业丞丑七丗下丟丌)));
                if((val_10 != null) && (val_10.丆丑一丑丄丌且丑丗() != true))
            {
                    if(且丘丏丁丑与丙与丁 != null)
            {
                    val_16 = 且丘丏丁丑与丙与丁.丗专丄丑下丄丘丁与;
                val_18 = 且丘丏丁丑与丙与丁.丘丑下丆上业丛一丄();
            }
            else
            {
                    val_18 = 且丘丏丁丑与丙与丁.丘丑下丆上业丛一丄();
                val_16 = 123372880;
            }
            
                bool val_15 = 且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().业丏丗丐丂业东丂丗(丆万一不丌且东丐丐:  "state.purchased");
                if(且丘丏丁丑与丙与丁 != null)
            {
                    且丘丏丁丑与丙与丁.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_18);
                且丘丏丁丑与丙与丁.丙丛东七丛一世一丕(且万丄丏专丄丛丌丗:  val_16);
            }
            else
            {
                    且丘丏丁丑与丙与丁.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_18);
                0.丙丛东七丛一世一丕(且万丄丏专丄丛丌丗:  val_16);
            }
            
                且丘丏丁丑与丙与丁.专不丗丈丒丄三三丙();
            }
            
            }
            
            this.丗丄丐万丏业丏丑万();
        }
        private bool 丒七丏一丝且丝丈与(PGCompany.PixelPass.东丄三下丄丈三丌丅 丙业丞丑七丗下丟丌)
        {
            string val_1 = 丙业丞丑七丗下丟丌.一丁丛下丏丅丟不三();
            PGCompany.DataObjects.丙七丘三丛丕丙丒丒 val_2 = this.不世丈丏丈上与东且();
            if(val_1 != null)
            {
                    return val_1.Equals(value:  val_2.Section);
            }
            
            return val_1.Equals(value:  val_2.Section);
        }
    
    }

}
