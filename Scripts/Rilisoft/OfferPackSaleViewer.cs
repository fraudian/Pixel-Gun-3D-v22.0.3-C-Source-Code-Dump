using UnityEngine;

namespace Rilisoft
{
    public class OfferPackSaleViewer : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _saleLabels;
        
        // Methods
        public void SetSale(string 丗丅上丁丂丘丏业丐)
        {
            var val_4;
            if(this._saleLabels == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this._saleLabels.GetEnumerator();
            val_4 = 1152921526277220416;
            label_7:
            if((33632088 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.text = 丗丅上丁丂丘丏业丐;
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public OfferPackSaleViewer()
        {
        
        }
    
    }

}
