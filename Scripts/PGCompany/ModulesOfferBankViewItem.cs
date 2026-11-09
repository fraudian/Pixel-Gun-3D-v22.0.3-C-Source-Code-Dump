using UnityEngine;

namespace PGCompany
{
    internal class ModulesOfferBankViewItem : EventStoreBankViewItem
    {
        // Fields
        private System.Collections.Generic.List<UITexture> _modulesTextures;
        private UILabel _craftCurrencyLabel;
        private UILabel _offerDescription;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
        }
        protected override void OnDisable()
        {
            this.OnDisable();
        }
        protected override void 丞业与下丛万丁下丙()
        {
            this.丞业与下丛万丁下丙();
        }
        public override void Setup(Rilisoft.与丗丌丑专业丝丛丏 东丈丏东丑丟不不丞, 丘丝丑丐丆丑七不丙 上业一丄三与丂丄丏, 不东丌丈丞丗丏丝丅 丆不丁且丙丅丂专丟, System.Collections.Generic.Dictionary<string, object> 七一丂丟东丟万丙丘, Rilisoft.业丙丘丆东丈丕丂丄 丙业丞丑七丗下丟丌, PGCompany.丘丒下东丗丏丁丅业 丕东不丐世丕丐万上, System.EventHandler 丄丆丘丏万三丞丐丏, System.EventHandler 丛与世且丑丅丟下丛)
        {
            this.Setup(东丈丏东丑丟不不丞:  东丈丏东丑丟不不丞, 上业一丄三与丂丄丏:  上业一丄三与丂丄丏, 丆不丁且丙丅丂专丟:  丆不丁且丙丅丂专丟, 七一丂丟东丟万丙丘:  七一丂丟东丟万丙丘, 丙业丞丑七丗下丟丌:  丙业丞丑七丗下丟丌, 丕东不丐世丕丐万上:  丕东不丐世丕丐万上, 丄丆丘丏万三丞丐丏:  丄丆丘丏万三丞丐丏, 丛与世且丑丅丟下丛:  丛与世且丑丅丟下丛);
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            UILabel val_25;
            UIBasicSprite val_26;
            var val_27;
            int val_29;
            val_25 = this;
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  this.Offer.丏与丅专三丙与丘丒());
            val_26 = 1152921505607856128;
            val_27 = null;
            val_27 = null;
            if((ModulesOfferBankViewItem.<>c.<>9__4_0) == null)
            {
                goto label_4;
            }
            
            label_32:
            Rilisoft.OfferItem val_4 = val_3.Find(match:  ModulesOfferBankViewItem.<>c.<>9__4_0);
            if(val_4 != null)
            {
                    bool val_5 = val_3.Remove(item:  val_4);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._craftCurrencyLabel, 丕丗丘丑丛与丑业丒:  val_4.Count.ToString());
            }
            
            val_29 = UnityEngine.Mathf.Min(a:  val_3.Count, b:  this._modulesTextures.Count);
            if(val_29 >= 1)
            {
                    var val_25 = 0;
                do
            {
                val_26 = this._modulesTextures.Item[0];
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_26, 与万丆丛丒万丝丙丑:  val_3.Item[0].Texture);
                val_25 = val_25 + 1;
            }
            while(val_29 != val_25);
            
            }
            
            Rilisoft.OfferItem val_14 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  val_3);
            if(val_14 == null)
            {
                    return;
            }
            
            if(val_14.Type != 1150)
            {
                    return;
            }
            
            val_25 = this._offerDescription;
            val_29 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丏丂一丗丙世丏丐三>(丁丅丈丌丟世丗丗丟:  val_14.Type, 丞丅上丏丂且下丅与:  val_14.Id).丑业世丞上丂丄丟丞();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_25, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7210"), arg0:  PGCompany.丑丐丁万专东丝三世.丄世丌一丝丕丒丅丑(丑丅世丐丒丏丐三丅:  val_29)));
            return;
            label_4:
            ModulesOfferBankViewItem.<>c.<>9__4_0 = new System.Predicate<Rilisoft.OfferItem>(object:  ModulesOfferBankViewItem.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModulesOfferBankViewItem.<>c::三丁丒三丗三七东丛(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            if(val_3 != null)
            {
                goto label_32;
            }
            
            goto label_32;
        }
        public ModulesOfferBankViewItem()
        {
            this._modulesTextures = new System.Collections.Generic.List<UITexture>();
        }
    
    }

}
