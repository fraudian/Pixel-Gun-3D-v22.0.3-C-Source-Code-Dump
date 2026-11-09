using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal sealed class TrophyRoadSlotCell : PGBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView _slotItemView;
        private UITexture _rankTexture;
        private UILabel _rankLabel;
        private UILabel _combatTokensLabel;
        private UILabel _rewardPointsLabel;
        private UIWidget _widget;
        
        // Properties
        internal UIWidget 丕丟丟丝丝丞七且下 { get; }
        
        // Methods
        internal UIWidget 丁丏世七三丗与丏与()
        {
            return (UIWidget)this._widget;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.TrophyRoad.丑与丅下丂丑丌业专 上丙丙丒丏下世与丂)
        {
            UILabel val_2;
            if(上丙丙丒丏下世与丂 == null)
            {
                    return;
            }
            
            if(this._slotItemView != 0)
            {
                    this._slotItemView.Setup(丈丄不七三万丄丁不:  上丙丙丒丏下世与丂.七七一七丗丆一丙丟);
            }
            
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._rankTexture, 与万丆丛丒万丝丙丑:  上丙丙丒丏下世与丂.与上丗丅丟世世丈三);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rankLabel, 丕丗丘丑丛与丑业丒:  上丙丙丒丏下世与丂.三专丞丄东丂丟七与);
            val_2 = this._combatTokensLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_2, 丕丗丘丑丛与丑业丒:  上丙丙丒丏下世与丂.丄东丟丐丂丝丕丌丅);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rewardPointsLabel, 丕丗丘丑丛与丑业丒:  上丙丙丒丏下世与丂.丁下下三丐三丄下丘);
        }
        public TrophyRoadSlotCell()
        {
        
        }
    
    }

}
