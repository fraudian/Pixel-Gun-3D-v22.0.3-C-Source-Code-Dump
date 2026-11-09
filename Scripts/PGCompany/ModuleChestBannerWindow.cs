using UnityEngine;

namespace PGCompany
{
    internal class ModuleChestBannerWindow : BannerWindow
    {
        // Fields
        private PGCompany.ModuleChestViewer _moduleChestViewer;
        private UILabel _priceLabel;
        private PGCompany.丘丒下东丗丏丁丅业 丏丕三丐下东丕一丝;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.丘丒下东丗丏丁丅业 东丈丏东丑丟不不丞)
        {
            string val_8;
            this.丏丕三丐下东丕一丝 = 东丈丏东丑丟不不丞;
            Rilisoft.OfferItem val_1 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  东丈丏东丑丟不不丞.Items);
            val_8 = 东丈丏东丑丟不不丞.丈世下下丅丕丐丗丁();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._priceLabel, 丕丗丘丑丛与丑业丒:  val_8);
            if(val_1 == null)
            {
                    return;
            }
            
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_6 = val_8.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  val_1.Type, 丞丅上丏丂且下丅与:  val_1.Id);
            if(val_6 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            this._moduleChestViewer.Setup(与且专丈不万东一万:  val_6);
        }
        public void U_BuyProduct()
        {
            this._moduleChestViewer.丆世与丑丆丅丐万且();
            PGCompany.丙丄丄丑丛丕丈丂丌.丙三丆丕丅丁丂与丏(东丈丏东丑丟不不丞:  this.丏丕三丐下东丕一丝, 丄东三丕丟丅不丌丄:  0, 丟世且丕丂丁万丒万:  0, 丟丆丌丄丑丁业丝七:  0);
        }
        public ModuleChestBannerWindow()
        {
        
        }
    
    }

}
