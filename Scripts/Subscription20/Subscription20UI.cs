using UnityEngine;

namespace Subscription20
{
    internal sealed class Subscription20UI : PGBehaviour
    {
        // Fields
        private System.Action 丛丄业丘不丆丄三丞;
        private UnityEngine.Transform loadedPromotionViewsHolder;
        private SubscriptionWarningDialog warningDialog;
        private PGCompany.MainStorePromotionInfoUI subscriptionInfo;
        private Subscription20.丒丗业丑丛东上下一 <业丟丝万丆丞丙丕丛>k__BackingField;
        private PromotionViewAbstract 丝丒上与丒一丆丏丂;
        private Subscription20.丘丛不东丒丆丁丑丁 丕丗丛丅丆丏业丕丅;
        private PGCompany.东丑丆丗丏丐丟下丄 与丐不业丑丗丌业下;
        private System.Collections.Generic.Dictionary<string, PromotionViewAbstract> 一丐七且世万七丝丕;
        
        // Properties
        internal Subscription20.丒丗业丑丛东上下一 专丏丒与不丌万上丞 { get; set; }
        internal Subscription20.丘丛不东丒丆丁丑丁 丛且丐下世与丘丆丗 { get; }
        internal PGCompany.东丑丆丗丏丐丟下丄 东丑丆丗丏丐丟下丄 { get; }
        
        // Methods
        internal void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921540848108888);
        
        }
        internal void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921540848245464);
        
        }
        internal Subscription20.丒丗业丑丛东上下一 丗专丅且丒丈丗与丈()
        {
            return (Subscription20.丒丗业丑丛东上下一)this.<业丟丝万丆丞丙丕丛>k__BackingField;
        }
        private void 不世业丅丌丞且丕专(Subscription20.丒丗业丑丛东上下一 丙业与丙丗丝不丈东)
        {
            this.<业丟丝万丆丞丙丕丛>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Subscription20.丘丛不东丒丆丁丑丁 丟一丈丌丞丕上丝丄()
        {
            return (Subscription20.丘丛不东丒丆丁丑丁)this.丕丗丛丅丆丏业丕丅;
        }
        internal PGCompany.东丑丆丗丏丐丟下丄 丂下丏且一丈与下三()
        {
            return (PGCompany.东丑丆丗丏丐丟下丄)this.与丐不业丑丗丌业下;
        }
        internal bool 一东与下三东丄三三(Subscription20.丘丛不东丒丆丁丑丁 丅丘与三丆丝丑上业)
        {
            Subscription20.丘丛不东丒丆丁丑丁 val_30;
            int val_31;
            val_30 = 丅丘与三丆丝丑上业;
            this.warningDialog.Hide();
            this.丝丒上与丒一丆丏丂 = 0;
            this.丕丗丛丅丆丏业丕丅 = val_30;
            this.与丐不业丑丗丌业下 = 0;
            this.不与丞下业丑丒丙万();
            this.三丁七丗丞丅丄世丈();
            System.Collections.Generic.List<PGCompany.StorePromotionConfig> val_2 = val_30.且丌丌丝丅丂丛丏下(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑(), 且丒丛与丞世丙丕丌:  2);
            if(val_2.Count == 0)
            {
                goto label_9;
            }
            
            PGCompany.StorePromotionConfig val_4 = System.Linq.Enumerable.FirstOrDefault<PGCompany.StorePromotionConfig>(source:  val_2);
            Subscription20.丒丗业丑丛东上下一 val_6 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  val_4.Identificator);
            this.<业丟丝万丆丞丙丕丛>k__BackingField = val_6;
            if(val_6 == 0)
            {
                goto label_9;
            }
            
            if(val_6 == 3)
            {
                goto label_10;
            }
            
            if(val_6 == 2)
            {
                goto label_11;
            }
            
            if(val_6 != 1)
            {
                goto label_12;
            }
            
            string val_7 = val_30.世丞丙下与丝不丆东();
            goto label_18;
            label_10:
            string val_8 = val_30.七丞专丒丑三丟丁丒();
            goto label_18;
            label_11:
            string val_9 = val_30.丑丝丕丕丈丂丅丕专();
            goto label_18;
            label_12:
            val_31 = System.String.alignConst;
            label_18:
            val_30 = UnityEngine.Resources.Load<PromotionViewAbstract>(path:  val_31);
            if(val_30 != 0)
            {
                goto label_21;
            }
            
            label_9:
            this.丆世与丑丆丅丐万且();
            return false;
            label_21:
            if((this.一丐七且世万七丝丕.ContainsKey(key:  val_30.name)) != false)
            {
                    this.丝丒上与丒一丆丏丂 = this.一丐七且世万七丝丕.Item[val_30.name];
            }
            else
            {
                    if(val_30 != 0)
            {
                    PromotionViewAbstract val_17 = UnityEngine.Object.Instantiate<PromotionViewAbstract>(original:  val_30, parent:  this.loadedPromotionViewsHolder);
                this.丝丒上与丒一丆丏丂 = val_17;
                val_17.gameObject.name = val_30.name;
                丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丝丒上与丒一丆丏丂.transform);
                int val_24 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.丝丒上与丒一丆丏丂.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
                this.一丐七且世万七丝丕.Add(key:  val_30.name, value:  this.丝丒上与丒一丆丏丂);
                UIWidget val_26 = this.丝丒上与丒一丆丏丂.GetComponent<UIWidget>();
                if(val_26 != null)
            {
                    int val_27 = val_26.width;
            }
            
                var val_30 = 1;
                val_30 = val_30 - val_27;
                var val_28 = ((-val_27) < 0) ? (val_30) : (-val_27);
                val_28 = val_28 >> 1;
                this.loadedPromotionViewsHolder.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            }
            
            this.与丐不业丑丗丌业下 = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  val_4);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝丒上与丒一丆丏丂, 丏业丟一东丂东丘丛:  true);
            this.下丌业业丐丘丐丘三();
            return false;
        }
        internal void 丆世与丑丆丅丐万且()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
            this.丝丒上与丒一丆丏丂 = 0;
            this.丕丗丛丅丆丏业丕丅 = 0;
            this.不与丞下业丑丒丙万();
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        internal void 三丁七丗丞丅丄世丈()
        {
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this.一丐七且世万七丝丕.Values.GetEnumerator();
            label_6:
            if((1882786280 & 1) == 0)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  0.丐丏七丌丕丗业且上(), 丏业丟一东丂东丘丛:  false);
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 下丌业业丐丘丐丘三()
        {
            System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_6;
            Subscription20.丘丛不东丒丆丁丑丁.丐丈丑丑丗丅万丕丁(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20UI::丈丝下丛专三丐丛且(Subscription20.丘丛不东丒丆丁丑丁 万且万且丑丗且丌丆)));
            Subscription20.万丞且丐世丙丄丄丌.丆丘丞丏丈上丏丗丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.Subscription20UI::丆世与丑丆丅丐万且()));
            if(((System.Delegate.Combine(a:  MainStorePromotionView.丄三三丄丙丟丟不丐, b:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void Subscription20.Subscription20UI::业七下丆丛丕丙丘丗(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)))) != null) && (null != null))
            {
                    val_6 = 0;
            }
            
            MainStorePromotionView.丄三三丄丙丟丟不丐 = val_6;
        }
        private void 不与丞下业丑丒丙万()
        {
            System.Action<PGCompany.东丑丆丗丏丐丟下丄> val_6;
            Subscription20.丘丛不东丒丆丁丑丁.丞与丞三上丙丙东丂(丙业与丙丗丝不丈东:  new System.Action<Subscription20.丘丛不东丒丆丁丑丁>(object:  this, method:  System.Void Subscription20.Subscription20UI::丈丝下丛专三丐丛且(Subscription20.丘丛不东丒丆丁丑丁 万且万且丑丗且丌丆)));
            Subscription20.万丞且丐世丙丄丄丌.丅丈丂东上不丛下丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Subscription20.Subscription20UI::丆世与丑丆丅丐万且()));
            if(((System.Delegate.Remove(source:  MainStorePromotionView.丄三三丄丙丟丟不丐, value:  new System.Action<PGCompany.东丑丆丗丏丐丟下丄>(object:  this, method:  System.Void Subscription20.Subscription20UI::业七下丆丛丕丙丘丗(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)))) != null) && (null != null))
            {
                    val_6 = 0;
            }
            
            MainStorePromotionView.丄三三丄丙丟丟不丐 = val_6;
        }
        private void 丈丝下丛专三丐丛且(Subscription20.丘丛不东丒丆丁丑丁 万且万且丑丗且丌丆)
        {
            this.丆世与丑丆丅丐万且();
        }
        public void U_ClickOnBackGround()
        {
            SubscriptionWarningDialog val_8;
            long val_9;
            val_8 = this;
            val_9 = 0;
            if(((this.gameObject.activeSelf == false) || (this.与丐不业丑丗丌业下 == null)) || (this.丕丗丛丅丆丏业丕丅 == null))
            {
                goto label_9;
            }
            
            val_9 = PixelTime.丙丅丅业丟丁世丁丗();
            if((this.丕丗丛丅丆丏业丕丅.业丆七丙丝丌丁万丏(丝丙一丝丈丂不丙一:  val_9)) == false)
            {
                goto label_9;
            }
            
            val_9 = 0;
            if((Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  this.与丐不业丑丗丌业下.七丈丒丒下下且万与())) != 2)
            {
                goto label_9;
            }
            
            if(this.丝丒上与丒一丆丏丂 == null)
            {
                    return;
            }
            
            goto label_11;
            label_9:
            if(this.丕丗丛丅丆丏业丕丅 == null)
            {
                    return;
            }
            
            if((this.<业丟丝万丆丞丙丕丛>k__BackingField) == 3)
            {
                goto label_13;
            }
            
            if((this.<业丟丝万丆丞丙丕丛>k__BackingField) == 1)
            {
                goto label_15;
            }
            
            return;
            label_13:
            if(this.丕丗丛丅丆丏业丕丅.丛丙丈丏丁与丝丒东() == false)
            {
                goto label_15;
            }
            
            val_8 = this.warningDialog;
            label_11:
            val_8.Show();
            return;
            label_15:
            this.丆世与丑丆丅丐万且();
        }
        public void U_WarningDialog_Resubscribe()
        {
            this.warningDialog.Hide();
        }
        public void U_WarningDialog_Cancel()
        {
            if((this.丕丗丛丅丆丏业丕丅.丄丆专丁丕丆丐丝丝(丝丙一丝丈丂不丙一:  PixelTime.丝丗专上三不丄丑丑())) == 3)
            {
                    this.丕丗丛丅丆丏业丕丅.Remove();
            }
            
            this.warningDialog.Hide();
            this.丆世与丑丆丅丐万且();
        }
        private void 业七下丆丛丕丙丘丗(PGCompany.东丑丆丗丏丐丟下丄 丐丆丝业丙丈下世丁)
        {
            if(丐丆丝业丙丈下世丁 == null)
            {
                    return;
            }
            
            if(丐丆丝业丙丈下世丁.不业丙丒丂丞下丆丙() != 27)
            {
                    return;
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_2 = this.丝丒上与丒一丆丏丂.与丞丆丑东东丟丆丌();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.subscriptionInfo, 丏业丟一东丂东丘丛:  true);
        }
        internal void 下丅丒丑七丞丙丒丏()
        {
            this.warningDialog.Show();
        }
        public Subscription20UI()
        {
            this.一丐七且世万七丝丕 = new System.Collections.Generic.Dictionary<System.String, PromotionViewAbstract>();
        }
    
    }

}
