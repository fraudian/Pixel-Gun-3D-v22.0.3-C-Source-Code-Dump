using UnityEngine;

namespace Subscription20
{
    internal sealed class 万丞且丐世丙丄丄丌 : IDisposable
    {
        // Fields
        private static System.Action 丈且丟丏丈丁不专丙;
        private static Subscription20.万丞且丐世丙丄丄丌 丝业丆丁业三丈丟东;
        private Subscription20.丄丞业丟专丑万与丒 <丅丄丒丟丙丂世丝丁>k__BackingField;
        private System.Collections.Generic.List<Subscription20.丘丛不东丒丆丁丑丁> 丂丆不三世丂业万不;
        private System.Collections.Generic.List<string> 丘世七世上世丑丛丄;
        private UnityEngine.Coroutine 不丑上三丁丌丛丘丗;
        private UnityEngine.Coroutine 专七专丏专丑丂不丌;
        
        // Properties
        internal static Subscription20.万丞且丐世丙丄丄丌 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.DataObjects.丄丄丞不七丅丆丞与 一七且丗不丑丝且三 { get; }
        internal PGCompany.丘与丈世不丕丕丅丑 丂丙且业丙七丛万东 { get; }
        internal Subscription20.丄丞业丟专丑万与丒 丏且丁丘丙七且丙与 { get; set; }
        internal System.Collections.Generic.List<string> 丆下七丗丝丁丟丘丈 { get; }
        
        // Methods
        internal static void 丆丘丞丏丈上丏丗丌(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Subscription20.万丞且丐世丙丄丄丌.丈且丟丏丈丁不专丙, b:  丙业与丙丗丝不丈东);
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
        internal static void 丅丈丂东上不丛下丆(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Subscription20.万丞且丐世丙丄丄丌.丈且丟丏丈丁不专丙, value:  丙业与丙丗丝不丈东);
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
        internal static Subscription20.万丞且丐世丙丄丄丌 丑七不且上丗丁一世()
        {
            Subscription20.万丞且丐世丙丄丄丌 val_2 = Subscription20.万丞且丐世丙丄丄丌.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            Subscription20.万丞且丐世丙丄丄丌 val_1 = null;
            val_2 = val_1;
            val_1 = new Subscription20.万丞且丐世丙丄丄丌();
            Subscription20.万丞且丐世丙丄丄丌.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal static bool 丆下丝丟丛不三丟丟()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                goto label_15;
            }
            
            val_19 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
            if(val_19 == null)
            {
                    return (bool)val_20;
            }
            
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_6 = val_19.且丌丌丝丅丂丛丏下(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑(), 且丒丛与丞世丙丕丌:  2);
            val_20 = val_6;
            if(val_20.Count == 0)
            {
                    return (bool)val_20;
            }
            
            Subscription20.丒丗业丑丛东上下一 val_10 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  System.Linq.Enumerable.FirstOrDefault<PGCompany.StorePromotionConfig>(source:  val_6).Identificator);
            if(val_10 == 3)
            {
                goto label_13;
            }
            
            if(val_10 == 2)
            {
                    return val_19.业丆七丙丝丌丁万丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑());
            }
            
            if(val_10 != 1)
            {
                goto label_15;
            }
            
            if(val_4.七丄丞丄万且丝东丗 == null)
            {
                goto label_16;
            }
            
            val_21 = (long)val_4.七丄丞丄万且丝东丗.LobbyPopupCooldown;
            goto label_17;
            label_15:
            val_20 = 0;
            return (bool)val_20;
            label_13:
            if(val_4.七丄丞丄万且丝东丗 != null)
            {
                    val_22 = (long)val_4.七丄丞丄万且丝东丗.LobbyPopupCooldown;
            }
            else
            {
                    val_22 = 0;
            }
            
            if((val_22 + val_19.丁丛丝丄丙世东丙丏()) >= PixelTime.丝丗专上三不丄丑丑())
            {
                    return val_19.丛丙丈丏丁与丝丒东();
            }
            
            return (bool)val_20;
            label_16:
            val_21 = 0;
            label_17:
            var val_18 = ((val_21 + val_19.丁丛丝丄丙世东丙丏()) < PixelTime.丝丗专上三不丄丑丑()) ? 1 : 0;
            return (bool)val_20;
        }
        internal PGCompany.DataObjects.丄丄丞不七丅丆丞与 世丈丁业丛上丘丗丐()
        {
            return PGCompany.业专丐丐丘丌丕世丅<PGCompany.DataObjects.丄丄丞不七丅丆丞与>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  139);
        }
        internal PGCompany.丘与丈世不丕丕丅丑 丑七丅丅三下丒万丈()
        {
            return PGCompany.业专丐丐丘丌丕世丅<PGCompany.丘与丈世不丕丕丅丑>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  91);
        }
        internal Subscription20.丄丞业丟专丑万与丒 丑丏业丙世不丅丂且()
        {
            return (Subscription20.丄丞业丟专丑万与丒)this.<丅丄丒丟丙丂世丝丁>k__BackingField;
        }
        private void 丑丂丘世三丘万丏不(Subscription20.丄丞业丟专丑万与丒 丙业与丙丗丝不丈东)
        {
            this.<丅丄丒丟丙丂世丝丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private 万丞且丐世丙丄丄丌()
        {
            this.丂丆不三世丂业万不 = new System.Collections.Generic.List<Subscription20.丘丛不东丒丆丁丑丁>();
            this.丘世七世上世丑丛丄 = new System.Collections.Generic.List<System.String>();
            this.<丅丄丒丟丙丂世丝丁>k__BackingField = Subscription20.丄丞业丟专丑万与丒.丑七不且上丗丁一世();
            this.丘下与丝丟丄东且丘();
        }
        internal System.Collections.Generic.List<string> 丄丞丕丁上不上丞丆()
        {
            return (System.Collections.Generic.List<System.String>)this.丘世七世上世丑丛丄;
        }
        internal Subscription20.丘丛不东丒丆丁丑丁 不专丈不丞上丌丟丏(long 丝丙一丝丈丂不丙一)
        {
            object val_6;
            var val_7;
            System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Int32> val_9;
            万丞且丐世丙丄丄丌.丒业丛丟专丛丒与东 val_1 = null;
            val_6 = val_1;
            val_1 = new 万丞且丐世丙丄丄丌.丒业丛丟专丛丒与东();
            .丝丙一丝丈丂不丙一 = 丝丙一丝丈丂不丙一;
            val_7 = null;
            val_7 = null;
            val_9 = 万丞且丐世丙丄丄丌.<>c.<>9__20_1;
            if(val_9 != null)
            {
                    return System.Linq.Enumerable.FirstOrDefault<Subscription20.丘丛不东丒丆丁丑丁>(source:  System.Linq.Enumerable.ThenByDescending<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(source:  this.丂丆不三世丂业万不, keySelector:  new System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(object:  val_1, method:  System.Int32 万丞且丐世丙丄丄丌.丒业丛丟专丛丒与东::且丛且丈下丏专丗业(Subscription20.丘丛不东丒丆丁丑丁 丒丒丈丘专丛一专丈))), keySelector:  System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Int32> val_4 = null));
            }
            
            val_9 = val_4;
            val_4 = new System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(object:  万丞且丐世丙丄丄丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 万丞且丐世丙丄丄丌.<>c::且上丆与东上东三丅(Subscription20.丘丛不东丒丆丁丑丁 丒丒丈丘专丛一专丈));
            万丞且丐世丙丄丄丌.<>c.<>9__20_1 = val_9;
            return System.Linq.Enumerable.FirstOrDefault<Subscription20.丘丛不东丒丆丁丑丁>(source:  System.Linq.Enumerable.ThenByDescending<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(source:  System.Linq.Enumerable.OrderByDescending<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(source:  this.丂丆不三世丂业万不, keySelector:  new System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Int32>(object:  val_1, method:  System.Int32 万丞且丐世丙丄丄丌.丒业丛丟专丛丒与东::且丛且丈下丏专丗业(Subscription20.丘丛不东丒丆丁丑丁 丒丒丈丘专丛一专丈))), keySelector:  val_4));
        }
        internal Subscription20.丘丛不东丒丆丁丑丁 专三丞丄丕丐丟丝丏(int 丞世不丒下上上丝丑)
        {
            .丞世不丒下上上丝丑 = 丞世不丒下上上丝丑;
            return System.Linq.Enumerable.FirstOrDefault<Subscription20.丘丛不东丒丆丁丑丁>(source:  this.丂丆不三世丂业万不, predicate:  new System.Func<Subscription20.丘丛不东丒丆丁丑丁, System.Boolean>(object:  new 万丞且丐世丙丄丄丌.丈业丗丞丁七下一不(), method:  System.Boolean 万丞且丐世丙丄丄丌.丈业丗丞丁七下一不::丁丌不东专丞专丁丛(Subscription20.丘丛不东丒丆丁丑丁 丒丒丈丘专丛一专丈)));
        }
        private void 丘下与丝丟丄东且丘()
        {
            var val_10;
            this.世丝丐七丕世丈丒丌();
            PGCompany.DataObjects.丄丄丞不七丅丆丞与 val_1 = this.世丈丁业丛上丘丗丐();
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.丑七丅丅三下丒万丈() == null)
            {
                    return;
            }
            
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return;
            }
            
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世().丄丙丙丑丝专世上丌() == false)
            {
                    return;
            }
            
            bool val_6 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.subscription20");
            if(val_6 == false)
            {
                    return;
            }
            
            PGCompany.DataObjects.丄丄丞不七丅丆丞与 val_7 = val_6.世丈丁业丛上丘丗丐();
            List.Enumerator<T> val_8 = val_7.SubscriptionSettings.GetEnumerator();
            label_21:
            if((1862985296 & 1) == 0)
            {
                goto label_11;
            }
            
            new 万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌() = new System.Object();
            .丞丈丛丛丙丑业丗专 = val_10.丐丏七丌丕丗业且上();
            PGCompany.DataObjects.丄丄丞不七丅丆丞与 val_13 = this.世丈丁业丛上丘丗丐();
            System.Func<PGCompany.DataObjects.丘与上丂不与丌万与, System.Boolean> val_14 = new System.Func<PGCompany.DataObjects.丘与上丂不与丌万与, System.Boolean>(object:  new 万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌(), method:  System.Boolean 万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌::一东专丒专丄丌丈丝(PGCompany.DataObjects.丘与上丂不与丌万与 与不丕丆丈不丙丟丛));
            PGCompany.DataObjects.丘与上丂不与丌万与 val_15 = System.Linq.Enumerable.FirstOrDefault<PGCompany.DataObjects.丘与上丂不与丌万与>(source:  val_13.SubscriptionGuiSettings, predicate:  null);
            PGCompany.丘与丈世不丕丕丅丑 val_16 = val_15.丑七丅丅三下丒万丈();
            System.Func<PGCompany.与丅与丛丗七丞七丛, System.Boolean> val_17 = new System.Func<PGCompany.与丅与丛丗七丞七丛, System.Boolean>(object:  new 万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌(), method:  System.Boolean 万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌::东丘世丗丈丌专与丌(PGCompany.与丅与丛丗七丞七丛 丙丒七丄上与丏丙丙));
            PGCompany.与丅与丛丗七丞七丛 val_18 = System.Linq.Enumerable.FirstOrDefault<PGCompany.与丅与丛丗七丞七丛>(source:  val_16.PriceTierSettings, predicate:  null);
            if((val_15 == null) || (val_18 == null))
            {
                goto label_21;
            }
            
            new Subscription20.丘丛不东丒丆丁丑丁() = new System.Object();
            .七丄丞丄万且丝东丗 = (万丞且丐世丙丄丄丌.丌丐丝丐下上三丛丌)[1152921540829635248].丞丈丛丛丙丑业丗专;
            .丌丂丝七丛与业七不 = val_15;
            .丁丝丌业一丐一丗丘 = val_18;
            this.丂丆不三世丂业万不.Add(item:  new Subscription20.丘丛不东丒丆丁丑丁());
            if((this.丘世七世上世丑丛丄.Contains(item:  new Subscription20.丘丛不东丒丆丁丑丁().丗业丈丙丒丈世丐丟())) == true)
            {
                goto label_21;
            }
            
            this.丘世七世上世丑丛丄.Add(item:  new Subscription20.丘丛不东丒丆丁丑丁().丗业丈丙丒丈世丐丟());
            goto label_21;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.上丑丗丞丘丝七与下();
            this.丒丙一专世丌丒一下();
            if(Subscription20.万丞且丐世丙丄丄丌.丈且丟丏丈丁不专丙 == null)
            {
                    return;
            }
            
            Subscription20.万丞且丐世丙丄丄丌.丈且丟丏丈丁不专丙.Invoke();
        }
        private void 世丝丐七丕世丈丒丌()
        {
            this.一丟万丌丙丞丈不丐();
            this.东丏丅一丏丐一丐丒();
            this.丂丆不三世丂业万不.Clear();
            this.丘世七世上世丑丛丄.Clear();
        }
        private void 丌丂丂且丅七一不丕(PGCompany.DataObjects.丄丄丞不七丅丆丞与 万且万且丑丗且丌丆)
        {
            this.丘下与丝丟丄东且丘();
        }
        private void 丌丂丂且丅七一不丕(PGCompany.丘与丈世不丕丕丅丑 万且万且丑丗且丌丆)
        {
            this.丘下与丝丟丄东且丘();
        }
        internal void 下丌业业丐丘丐丘三()
        {
            System.Action val_15;
            this.万不丒上丕丗丂丘丒();
            PGCompany.业专丐丐丘丌丕世丅<PGCompany.DataObjects.丄丄丞不七丅丆丞与>.丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.Action<PGCompany.DataObjects.丄丄丞不七丅丆丞与>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丌丂丂且丅七一不丕(PGCompany.DataObjects.丄丄丞不七丅丆丞与 万且万且丑丗且丌丆)));
            PGCompany.业专丐丐丘丌丕世丅<PGCompany.丘与丈世不丕丕丅丑>.丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丘与丈世不丕丕丅丑>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丌丂丂且丅七一不丕(PGCompany.丘与丈世不丕丕丅丑 万且万且丑丗且丌丆)));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丘下与丝丟丄东且丘()));
            val_15 = System.Delegate.Combine(a:  val_4.不丝七丕丐与与上丕, b:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丘下与丝丟丄东且丘()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_2;
            }
            
            if(val_15 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_15 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_15 = 0;
            }
            
            label_6:
            val_4.不丝七丕丐与与上丕 = val_15;
            PGCompany.丌与丛丕业丈不丐世.且东丞三丄丕丑世丐(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::万与丟下丄丌丆一丙(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::不东丄一世世世丏专()));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::不东丄一世世世丏专()));
            Subscription20.丘丛不东丒丆丁丑丁.丂世且万丁七丕万丅(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丒丙一专世丌丒一下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.丂业业丐上七丁下丁(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丒丙一专世丌丒一下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.丂世且万丁七丕万丅(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::上丑丗丞丘丝七与下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.丂业业丐上七丁下丁(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::上丑丗丞丘丝七与下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
        }
        private void 万不丒上丕丗丂丘丒()
        {
            System.Action val_15;
            PGCompany.业专丐丐丘丌丕世丅<PGCompany.DataObjects.丄丄丞不七丅丆丞与>.丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.DataObjects.丄丄丞不七丅丆丞与>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丌丂丂且丅七一不丕(PGCompany.DataObjects.丄丄丞不七丅丆丞与 万且万且丑丗且丌丆)));
            PGCompany.业专丐丐丘丌丕世丅<PGCompany.丘与丈世不丕丕丅丑>.丛丌丌且下丌丌丂丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丘与丈世不丕丕丅丑>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丌丂丂且丅七一不丕(PGCompany.丘与丈世不丕丕丅丑 万且万且丑丗且丌丆)));
            AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丘下与丝丟丄东且丘()));
            val_15 = System.Delegate.Remove(source:  val_4.不丝七丕丐与与上丕, value:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丘下与丝丟丄东且丘()));
            if(PGCompany.丝业丈丈丙世丞上丒.丑七不且上丗丁一世() == null)
            {
                goto label_2;
            }
            
            if(val_15 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_15 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_15 = 0;
            }
            
            label_6:
            val_4.不丝七丕丐与与上丕 = val_15;
            PGCompany.丌与丛丕业丈不丐世.丕上世丗业丆丟丕丏(丙业与丙丗丝不丈东:  new System.Action<InappRememberedBonus>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::万与丟下丄丌丆一丙(InappRememberedBonus 丂丈丗丄不丅丅丙丒)));
            ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::不东丄一世世世丏专()));
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::不东丄一世世世丏专()));
            Subscription20.丘丛不东丒丆丁丑丁.下丆丏丌不丗不丙丟(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丒丙一专世丌丒一下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.世丌丈世丕丈东专上(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::丒丙一专世丌丒一下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.下丆丏丌不丗不丙丟(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::上丑丗丞丘丝七与下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
            Subscription20.丘丛不东丒丆丁丑丁.世丌丈世丕丈东专上(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.万丞且丐世丙丄丄丌::上丑丗丞丘丝七与下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)));
        }
        private void 万与丟下丄丌丆一丙(InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            PGCompany.丙一丟与且丞丏丈一 val_11;
            if(丂丈丗丄不丅丅丙丒.StorePromotion == null)
            {
                    return;
            }
            
            if(丂丈丗丄不丅丅丙丒.StorePromotion.不业丙丒丂丞下丆丙() != 27)
            {
                    return;
            }
            
            val_11 = 丂丈丗丄不丅丅丙丒.StorePromotion.七丈丒丒下下且万与();
            if(val_11 != null)
            {
                    val_11 = 0;
            }
            
            Subscription20.丘丛不东丒丆丁丑丁 val_9 = this.专三丞丄丕丐丟丝丏(丞世不丒下上上丝丑:  Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  val_11));
            if(val_9 == null)
            {
                    return;
            }
            
            Subscription20.丒丗业丑丛东上下一 val_10 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  val_11);
            if(val_10 != 3)
            {
                    if(val_10 != 1)
            {
                    return;
            }
            
                val_9.下丌业业丐丘丐丘三(丝丙一丝丈丂不丙一:  丂丈丗丄不丅丅丙丒.ServerTime);
                return;
            }
            
            val_9.丄东下世丂丌东丈七(丝丙一丝丈丂不丙一:  丂丈丗丄不丅丅丙丒.ServerTime);
        }
        private void 丒丙一专世丌丒一下()
        {
            this.丒丙一专世丌丒一下(丅丘与三丆丝丑上业:  this.不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑()));
        }
        private void 丒丙一专世丌丒一下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            this.东丏丅一丏丐一丐丒();
            if(丅丘与三丆丝丑上业 == null)
            {
                    return;
            }
            
            Subscription20.专不万丏丝下丗万万 val_2 = 丅丘与三丆丝丑上业.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
            if(val_2 != 2)
            {
                    return;
            }
            
            this.不丑上三丁丌丛丘丗 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_2.丗丝丗丁丆丑丙丛东(丅丘与三丆丝丑上业:  丅丘与三丆丝丑上业));
        }
        private void 东丏丅一丏丐一丐丒()
        {
            if(this.不丑上三丁丌丛丘丗 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.不丑上三丁丌丛丘丗);
        }
        private System.Collections.IEnumerator 丗丝丗丁丆丑丙丛东(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丅丘与三丆丝丑上业 = 丅丘与三丆丝丑上业;
            return (System.Collections.IEnumerator)new 万丞且丐世丙丄丄丌.丙丑业不世业丒丝业();
        }
        private void 上丑丗丞丘丝七与下()
        {
            this.上丑丗丞丘丝七与下(丅丘与三丆丝丑上业:  this.不专丈不丞上丌丟丏(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑()));
        }
        private void 上丑丗丞丘丝七与下(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            this.一丟万丌丙丞丈不丐();
            if(丅丘与三丆丝丑上业 == null)
            {
                    return;
            }
            
            Subscription20.专不万丏丝下丗万万 val_2 = 丅丘与三丆丝丑上业.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丙丅丅业丟丁世丁丗());
            if(val_2 != 2)
            {
                    return;
            }
            
            this.专七专丏专丑丂不丌 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  val_2.丒丟丆三丒丌专丙万(丅丘与三丆丝丑上业:  丅丘与三丆丝丑上业));
        }
        private void 一丟万丌丙丞丈不丐()
        {
            if(this.专七专丏专丑丂不丌 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.专七专丏专丑丂不丌);
        }
        private System.Collections.IEnumerator 丒丟丆三丒丌专丙万(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丅丘与三丆丝丑上业 = 丅丘与三丆丝丑上业;
            return (System.Collections.IEnumerator)new 万丞且丐世丙丄丄丌.专丞丐丘丐丟三万丙();
        }
        private void 不东丄一世世世丏专()
        {
            if(this.丂丆不三世丂业万不.Count != 0)
            {
                    return;
            }
            
            this.丘下与丝丟丄东且丘();
        }
        public void Dispose()
        {
            this.万不丒上丕丗丂丘丒();
        }
    
    }

}
