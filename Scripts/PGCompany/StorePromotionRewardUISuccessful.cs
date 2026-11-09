using UnityEngine;

namespace PGCompany
{
    internal sealed class StorePromotionRewardUISuccessful : StorePromotionRewardUIAbstract
    {
        // Fields
        private float _timePurchaseSuccessfulShown;
        private UnityEngine.Coroutine 丝下且丙七丆丘丈丑;
        
        // Methods
        protected override void OnEnable()
        {
            if(this.丝下且丙七丆丘丈丑 != null)
            {
                    this.StopCoroutine(routine:  this.丝下且丙七丆丘丈丑);
            }
            
            this.丝下且丙七丆丘丈丑 = 0;
            this.丝下且丙七丆丘丈丑 = this.StartCoroutine(routine:  this.丈丒不下且丌世丑丘());
        }
        protected override void OnDisable()
        {
            if(this.丝下且丙七丆丘丈丑 != null)
            {
                    this.StopCoroutine(routine:  this.丝下且丙七丆丘丈丑);
            }
            
            this.丝下且丙七丆丘丈丑 = 0;
        }
        protected override void 丝一丅丆三东丂丞七()
        {
        
        }
        private System.Collections.IEnumerator 丈丒不下且丌世丑丘()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new StorePromotionRewardUISuccessful.丂丌七丏丟丂上丕丝();
        }
        private void 丌丞专丂世丑专丟丅()
        {
            if(this.丝下且丙七丆丘丈丑 != null)
            {
                    this.StopCoroutine(routine:  this.丝下且丙七丆丘丈丑);
            }
            
            this.丝下且丙七丆丘丈丑 = 0;
        }
        public void U_Hide()
        {
            if(this.丝下且丙七丆丘丈丑 != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public StorePromotionRewardUISuccessful()
        {
            this._timePurchaseSuccessfulShown = 2f;
            val_1 = new PGBehaviour();
        }
    
    }

}
