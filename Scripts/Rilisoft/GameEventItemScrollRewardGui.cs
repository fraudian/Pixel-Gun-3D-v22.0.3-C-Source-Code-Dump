using UnityEngine;

namespace Rilisoft
{
    public class GameEventItemScrollRewardGui : GameEventItemGui
    {
        // Fields
        private UnityEngine.Vector3 东丏不丞专丗丆专丒;
        private UnityEngine.GameObject _curencyObject;
        private UnityEngine.GameObject _itemNameObject;
        private UILabel _currencyCountLabel;
        private UnityEngine.GameObject _coinsObj;
        private UnityEngine.GameObject _gemsObj;
        private UnityEngine.GameObject _eventObj;
        private UnityEngine.GameObject _partsObj;
        private UnityEngine.GameObject _petsObj;
        public bool HideItemNameIfPossible;
        
        // Methods
        public override void FillItem(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            Rilisoft.GameEventItemData val_60;
            UnityEngine.Color val_61;
            UnityEngine.Vector3 val_62;
            UnityEngine.Color val_63;
            int val_64;
            string val_65;
            var val_66;
            var val_67;
            UnityEngine.Color val_68;
            var val_69;
            UnityEngine.GameObject val_70;
            val_60 = 一丐丗丁丞丆丅丟丄;
            this.FillItem(一丐丗丁丞丆丅丟丄:  val_60);
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.东丏不丞专丗丆专丒, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) != false)
            {
                    UnityEngine.Vector3 val_3 = this._currencyCountLabel.transform.localPosition;
                this.东丏不丞专丗丆专丒 = val_3;
                mem[1152921542837533836] = val_3.y;
                mem[1152921542837533840] = val_3.z;
            }
            
            val_62 = this.东丏不丞专丗丆专丒;
            this._currencyCountLabel.transform.localPosition = new UnityEngine.Vector3() {x = val_62, y = V9.16B, z = V10.16B};
            if(val_60 != null)
            {
                    val_64 = val_60.Count;
            }
            else
            {
                    val_64 = 0.Count;
            }
            
            if((((val_60.Type != 500) && (val_60.Type != 800)) && (val_60.Type != 1600)) && (val_60.Type != 900))
            {
                    if(val_60.Type != 1400)
            {
                    if(val_60.Type != 300)
            {
                goto label_22;
            }
            
            }
            
            }
            
            if(val_60.Count < 1)
            {
                goto label_22;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._curencyObject, 丏业丟一东丂东丘丛:  true);
            if(this.HideItemNameIfPossible != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemNameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            val_65 = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  val_60.Count);
            this._currencyCountLabel.text = val_65;
            if(val_60.Type == 1400)
            {
                    this._currencyCountLabel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_65 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2002");
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._currencyCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_65, arg0:  val_64));
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gemsObj, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.ItemParams.业东丅东丌上丗丑不() == 2015) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coinsObj, 丏业丟一东丂东丘丛:  (一丐丗丁丞丆丅丟丄.ItemParams.业东丅东丌上丗丑不() == 1015) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventObj, 丏业丟一东丂东丘丛:  Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_60.Id));
            if(val_60.Type != 800)
            {
                goto label_45;
            }
            
            val_66 = 1;
            goto label_46;
            label_22:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._curencyObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemNameObject, 丏业丟一东丂东丘丛:  true);
            goto label_94;
            label_45:
            label_46:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsObj, 丏业丟一东丂东丘丛:  (val_60.Type == 1600) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petsObj, 丏业丟一东丂东丘丛:  (val_60.Type == 300) ? 1 : 0);
            if((val_60.Type == 800) && (this._partsObj != 0))
            {
                    UISprite val_34 = this._partsObj.GetComponent<UISprite>();
                if(val_34 != 0)
            {
                    三丅丁丗丗丝丂万且 val_37 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_60.Id);
                if(val_37 != null)
            {
                    val_67 = val_37;
            }
            else
            {
                    val_67 = 5;
            }
            
                val_65 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                val_62 = val_65[5];
                val_61 = val_65[5];
                val_63 = val_65[5];
                val_68 = val_65[5];
                val_34.color = new UnityEngine.Color() {r = val_62, g = val_61, b = val_63, a = val_68};
            }
            
            }
            
            if((val_60.Type == 1600) && (this._partsObj != 0))
            {
                    UISprite val_41 = this._partsObj.GetComponent<UISprite>();
                if(val_41 != 0)
            {
                    PGCompany.七丟丘不下万丙丄下 val_45 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七丟丘不下万丙丄下>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_60.Id);
                if((val_45 != null) && (val_45.不一丆丑业且丆丙三() != null))
            {
                    val_69 = val_45.不一丆丑业且丆丙三();
            }
            else
            {
                    val_69 = 5;
            }
            
                val_65 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                val_62 = val_65[5];
                val_61 = val_65[5];
                val_63 = val_65[5];
                val_68 = val_65[5];
                val_41.color = new UnityEngine.Color() {r = val_62, g = val_61, b = val_63, a = val_68};
            }
            
            }
            
            if((val_60.Type == 300) && (this._petsObj != 0))
            {
                    UISprite val_51 = this._petsObj.GetComponent<UISprite>();
                if(val_51 != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_60.Id)) != null)
            {
                    val_65 = val_55.Rarity;
            }
            else
            {
                    val_65 = 5;
            }
            
                val_62 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
                val_63 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
                val_51.color = new UnityEngine.Color() {r = val_62, g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], b = val_63, a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5]};
            }
            
            }
            
            label_94:
            if(val_51 == 0)
            {
                    return;
            }
            
            val_70 = this._itemNameObject;
            if(val_70.activeSelf == false)
            {
                    return;
            }
            
            val_60 = val_60.不丑万世且丗不东丄();
            this.text = val_60;
        }
        public GameEventItemScrollRewardGui()
        {
            this.东丏不丞专丗丆专丒 = 0;
            mem[1152921542838002192] = 0;
            this.HideItemNameIfPossible = true;
        }
    
    }

}
