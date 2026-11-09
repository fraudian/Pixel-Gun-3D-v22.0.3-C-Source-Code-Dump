using UnityEngine;

namespace PGCompany
{
    public class ClanWarRewardItemViewBase : PGBehaviour, IComparable<PGCompany.ClanWarRewardItemViewBase>
    {
        // Fields
        protected UITextureMasked MapPreviewTexture;
        protected UILabel RewardSilverCountLabel;
        protected UILabel RewardValorCountLabel;
        protected UILabel ImpactLabel;
        protected const string 丕且丘业丄世丛丌万 = "Key_8156";
        private UIWidget 丑不丂丟下与丂丏下;
        protected int 丅丗丆下丗东下丁丟;
        
        // Properties
        internal UIWidget 下世丛丟万丐一丛丟 { get; }
        
        // Methods
        internal UIWidget 专丘丝丅丝丟万丅与()
        {
            UIWidget val_3;
            if(this.丑不丂丟下与丂丏下 == 0)
            {
                    this.丑不丂丟下与丂丏下 = this.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.丑不丂丟下与丂丏下;
            return val_3;
        }
        private void OnEnable()
        {
            if(this.MapPreviewTexture == 0)
            {
                    return;
            }
            
            this = this.MapPreviewTexture;
            this.MapPreviewTexture.isOfferTexture = false;
        }
        public int CompareTo(PGCompany.ClanWarRewardItemViewBase 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 == 0)
            {
                    return 1;
            }
        
        }
        public ClanWarRewardItemViewBase()
        {
        
        }
    
    }

}
