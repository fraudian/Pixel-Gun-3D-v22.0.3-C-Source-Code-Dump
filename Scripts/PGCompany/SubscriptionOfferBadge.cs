using UnityEngine;

namespace PGCompany
{
    internal class SubscriptionOfferBadge : PGBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.List<PGCompany.SubscriptionOfferBadge> 丒丛专丙丏下丘且丝;
        private UnityEngine.GameObject _badgeBody;
        private bool _autoUpdate;
        private UnityEngine.WaitForSeconds 丙三丝且下不丌丄丄;
        
        // Methods
        internal static void 丆丘丑丒丒丗丐上且()
        {
            var val_3;
            System.Collections.Generic.List<PGCompany.SubscriptionOfferBadge> val_4;
            val_3 = null;
            val_3 = null;
            val_4 = PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝;
            List.Enumerator<T> val_1 = val_4.GetEnumerator();
            label_6:
            if(((-630997144) & 1) == 0)
            {
                goto label_4;
            }
            
            0.丐丏七丌丕丗业且上().丝一丅丆三东丂丞七();
            goto label_6;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void OnEnable()
        {
            var val_3;
            this.丝一丅丆三东丂丞七();
            if(this._autoUpdate != false)
            {
                    UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌丞世丝专一丗且丞());
            }
            
            val_3 = null;
            val_3 = null;
            PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝.Add(item:  this);
        }
        private void OnDisable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝.Contains(item:  this)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            bool val_2 = PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝.Remove(item:  this);
        }
        private void OnDestroy()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝.Contains(item:  this)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            bool val_2 = PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝.Remove(item:  this);
        }
        internal void 丝一丅丆三东丂丞七()
        {
            var val_6;
            if(this._badgeBody == 0)
            {
                    return;
            }
            
            if(Rilisoft.Offers.东丝万业丘丙丄丁与.上丈丘丙丞三丟丝丞() != false)
            {
                    val_6 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._badgeBody, 丏业丟一东丂东丘丛:  (ExperienceController.丞丞丘业东丙丏七丌() >= BalanceController.丌与东一专丌且上丒()) ? 1 : 0);
        }
        private System.Collections.IEnumerator 丌丞世丝专一丗且丞()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new SubscriptionOfferBadge.丐丘七下上与上丏丑();
        }
        public SubscriptionOfferBadge()
        {
            this.丙三丝且下不丌丄丄 = new UnityEngine.WaitForSeconds(seconds:  1f);
        }
        private static SubscriptionOfferBadge()
        {
            PGCompany.SubscriptionOfferBadge.丒丛专丙丏下丘且丝 = new System.Collections.Generic.List<PGCompany.SubscriptionOfferBadge>();
        }
    
    }

}
