using UnityEngine;

namespace PGCompany.BattlePass
{
    internal sealed class BPOfferListExpView : PGBehaviour
    {
        // Fields
        private System.Collections.Generic.List<PGCompany.BattlePass.BPOfferListExpView.ExpViewSetting> _views;
        private Rilisoft.OfferItem <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        set; }
        public System.Action<PGCompany.BattlePass.BPOfferItemView> 专与丌丝丞下丌丗专 { set; }
        public Rilisoft.OfferItem 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public void set_HasUndroppedRewards(bool 丙业与丙丗丝不丈东)
        {
            .丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            this._views.ForEach(action:  new System.Action<ExpViewSetting>(object:  new BPOfferListExpView.丛与丒丞丁丛上丄丆(), method:  System.Void BPOfferListExpView.丛与丒丞丁丛上丄丆::丞七丟万三丅丌且三(PGCompany.BattlePass.BPOfferListExpView.ExpViewSetting 丁世丛业丟下丕三丟)));
        }
        public void set_OnClickAction(System.Action<PGCompany.BattlePass.BPOfferItemView> 丙业与丙丗丝不丈东)
        {
            .丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            this._views.ForEach(action:  new System.Action<ExpViewSetting>(object:  new BPOfferListExpView.世丞丒丅一专丌丐丏(), method:  System.Void BPOfferListExpView.世丞丒丅一专丌丐丏::丑与丂下下与万三丘(PGCompany.BattlePass.BPOfferListExpView.ExpViewSetting 丁世丛业丟下丕三丟)));
        }
        public Rilisoft.OfferItem get_Context()
        {
            return (Rilisoft.OfferItem)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.OfferItem 与且专丈不万东一万)
        {
            var val_2;
            var val_10;
            System.Collections.Generic.List<ExpViewSetting> val_11;
            UnityEngine.MonoBehaviour val_13;
            val_10 = this;
            val_11 = this._views;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            List.Enumerator<T> val_1 = val_11.GetEnumerator();
            label_6:
            if(((-303460784) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_4 = val_2.GetAwaiter();
            mem2[0] = 与且专丈不万东一万;
            val_4._value._token.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_4._value._token, 丏业丟一东丂东丘丛:  false);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) < 1)
            {
                goto label_13;
            }
            
            List.Enumerator<T> val_6 = this._views.GetEnumerator();
            val_13 = 0;
            goto label_15;
            label_17:
            ConfiguredValueTaskAwaiter val_7 = val_2.GetAwaiter();
            val_11 = val_7._value._token;
            var val_9 = ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.Count) < val_7._value._obj) ? (val_13) : (val_11);
            label_15:
            if(((-303460784) & 1) != 0)
            {
                goto label_17;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_22;
            label_13:
            val_13 = 0;
            label_22:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_13, 丏业丟一东丂东丘丛:  true);
        }
        public BPOfferListExpView()
        {
        
        }
    
    }

}
