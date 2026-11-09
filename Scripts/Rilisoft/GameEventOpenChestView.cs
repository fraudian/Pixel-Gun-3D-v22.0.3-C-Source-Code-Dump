using UnityEngine;

namespace Rilisoft
{
    public class GameEventOpenChestView : MonoBehaviour
    {
        // Fields
        private int 三丁不东丟丁业丑丕;
        private UILabel _headerLabel;
        private UILabel _countLabel;
        private UnityEngine.GameObject _eventCurrency;
        private UnityEngine.GameObject _gems;
        private UnityEngine.GameObject _coins;
        
        // Methods
        public void Set(int 丏专丒丙丟且丈万七, string 丏丂不专上丘丂不丅, int 下丅三丈世丐丕丌丑 = 1)
        {
            UnityEngine.GameObject val_8;
            UnityEngine.GameObject val_10;
            var val_11;
            var val_12;
            var val_13;
            val_8 = this;
            this.三丁不东丟丁业丑丕 = 下丅三丈世丐丕丌丑;
            this._countLabel.text = 丏专丒丙丟且丈万七.ToString();
            if(下丅三丈世丐丕丌丑 < 2)
            {
                    string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3904");
            }
            
            this._headerLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3929"), arg0:  下丅三丈世丐丕丌丑);
            val_10 = this._eventCurrency;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gems, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coins, 丏业丟一东丂东丘丛:  false);
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  丏丂不专上丘丂不丅)) != false)
            {
                    val_11 = null;
                val_8 = this._eventCurrency;
            }
            else
            {
                    val_10 = 1152921505171275776;
                val_12 = null;
                val_12 = null;
                if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_11 = null;
                val_8 = this._gems;
            }
            else
            {
                    val_13 = null;
                val_13 = null;
                if((System.String.op_Equality(a:  丏丂不专上丘丂不丅, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) == false)
            {
                    return;
            }
            
                val_11 = null;
                val_8 = this._coins;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        }
        private void OnClick()
        {
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null)
            {
                
            }
        
        }
        public GameEventOpenChestView()
        {
        
        }
    
    }

}
