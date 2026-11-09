using UnityEngine;

namespace PGCompany
{
    internal sealed class ChangeLogView : PGBehaviour
    {
        // Fields
        private UILabel _titleLabel;
        private UILabel _bodyLabel;
        private UILabel _rewardLabel;
        private UIBasicSprite _texture;
        private ItemListUI _itemListUI;
        private UnityEngine.GameObject _rewardContainer;
        private UILabel _buttonLabel;
        private PGCompany.丌丄丈丏丘东丛且下 丌丂下丗丈上不丝丗;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(PGCompany.丌丄丈丏丘东丛且下 丅丆一丂丒丗且丐丗)
        {
            this.丌丂下丗丈上不丝丗 = 丅丆一丂丒丗且丐丗;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丌丂下丗丈上不丝丗.丘丟七丄三上业万丐()));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._bodyLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丌丂下丗丈上不丝丗.丟丂不丟世丟丄丑丄()));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rewardLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.丌丂下丗丈上不丝丗.丏万丙丒丅业丆丙丑()));
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  this.丌丂下丗丈上不丝丗.丆下世世丟七专丞丒());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardContainer, 丏业丟一东丂东丘丛:  this.丌丂下丗丈上不丝丗.丙丄与世丁丛丞业不());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._buttonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (this.丌丂下丗丈上不丝丗.丂丝丕东东世三丅与() != true) ? "Key_1714" : "Key_0012"));
            if(this._itemListUI == 0)
            {
                    return;
            }
            
            this._itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丌丂下丗丈上不丝丗.丈丏丁东上与东丙丕());
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<PGCompany.ChangeLogCollectUI>(丌丛丏业世丄丞三丌:  this._itemListUI.GetComponentsInChildren<PGCompany.ChangeLogCollectUI>(includeInactive:  true), 七丐丅专且专七三丆:  new System.Action<PGCompany.ChangeLogCollectUI>(object:  this, method:  System.Void PGCompany.ChangeLogView::与上不丒丞丑丏丈丞(PGCompany.ChangeLogCollectUI 丞丘世丕丝与专丗七)));
        }
        public ChangeLogView()
        {
        
        }
        private void 与上不丒丞丑丏丈丞(PGCompany.ChangeLogCollectUI 丞丘世丕丝与专丗七)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丞丘世丕丝与专丗七.gameObject, 丏业丟一东丂东丘丛:  this.丌丂下丗丈上不丝丗.丙丞专丝万七一东丆());
        }
    
    }

}
