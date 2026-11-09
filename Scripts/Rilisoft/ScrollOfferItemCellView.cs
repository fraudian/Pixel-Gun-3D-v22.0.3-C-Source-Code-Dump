using UnityEngine;

namespace Rilisoft
{
    public class ScrollOfferItemCellView : BaseOfferItemCellView
    {
        // Fields
        private UILabel _nameLabel;
        private UILabel _partsCountLabel;
        private UnityEngine.GameObject _partsIndicator;
        private UnityEngine.GameObject[] _showIfSelected;
        private UIBasicSprite _texture;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        protected override Rilisoft.ButtonHandler 东丐业丘丝丙丆丛丁 { get; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        protected override Rilisoft.ButtonHandler 丗一丂丏业丅丟丟丞()
        {
            UnityEngine.GameObject val_2 = this.丆下世世丟七专丞丒().gameObject;
            if(val_2 != null)
            {
                    return val_2.GetComponent<Rilisoft.ButtonHandler>();
            }
            
            return val_2.GetComponent<Rilisoft.ButtonHandler>();
        }
        public override void Set(Rilisoft.OfferItem 下丅丙一丂丗丅丝七, System.Action<Rilisoft.BaseOfferItemCellView> 万且丆丈万下不东七)
        {
            Rilisoft.OfferItem val_13;
            UnityEngine.GameObject val_14;
            val_13 = 下丅丙一丂丗丅丝七;
            this.Set(下丅丙一丂丗丅丝七:  val_13, 万且丆丈万下不东七:  万且丆丈万下不东七);
            if(this._nameLabel != 0)
            {
                    this._nameLabel.text = val_13.Name;
            }
            
            if(this.丆下世世丟七专丞丒() != 0)
            {
                    UIBasicSprite val_5 = this.丆下世世丟七专丞丒();
                UnityEngine.Texture val_6 = val_13.Texture;
            }
            
            val_14 = this._partsIndicator;
            if(val_14 == 0)
            {
                    return;
            }
            
            val_14 = this._partsIndicator.gameObject;
            if(val_13.Type == 1070)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  true);
                val_14 = this._partsCountLabel;
                if(val_14 == 0)
            {
                    return;
            }
            
                val_13 = val_13.Count.ToString();
                this._partsCountLabel.text = val_13;
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  false);
        }
        public override void SetSelected(bool 丞丈丌且东丆丅丗万)
        {
            丞丈丌且东丆丅丗万 = 丞丈丌且东丆丅丗万;
            this.SetSelected(丞丈丌且东丆丅丗万:  丞丈丌且东丆丅丗万);
            if(this._showIfSelected == null)
            {
                    return;
            }
            
            if(this._showIfSelected.Length < 1)
            {
                    return;
            }
            
            do
            {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._showIfSelected[0], 丏业丟一东丂东丘丛:  丞丈丌且东丆丅丗万);
            }
            while((0 + 1) < this._showIfSelected.Length);
        
        }
        public ScrollOfferItemCellView()
        {
        
        }
    
    }

}
