using UnityEngine;

namespace Rilisoft
{
    public class GameEventOpenChestButtonsView : MonoBehaviour
    {
        // Fields
        private static Rilisoft.七丒丛丑丙丑丞丁丘 丝不丛丑上丏与丁丄;
        private bool 业世丟丏丂丌丒丆丏;
        private Rilisoft.丛且世丐丆上七业丁 且丞丂丐不丐不丂丒;
        private UnityEngine.Vector3 丆世丕丕下丑丘不丗;
        private int 一三丏丄丙不上丙丙;
        private int 三丁不东丟丁业丑丕;
        private Rilisoft.GameEventOpenChestView _leftButton;
        private Rilisoft.GameEventOpenChestView _rightButton;
        private UnityEngine.Vector3 _oneButtonPosition;
        private UILabel[] _chestNameLabel;
        private UnityEngine.GameObject _hint;
        private float _hintsShowDelayInSeconds;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_3 = this._leftButton.gameObject.transform.localPosition;
            this.丆世丕丕下丑丘不丗 = val_3;
            mem[1152921542839741116] = val_3.y;
            mem[1152921542839741120] = val_3.z;
        }
        private void OnEnable()
        {
            Rilisoft.七丒丛丑丙丑丞丁丘 val_7;
            var val_8;
            var val_9;
            bool val_10;
            if(this.且丞丂丐不丐不丂丒 == null)
            {
                    return;
            }
            
            val_7 = 1152921505457217536;
            val_8 = null;
            val_8 = null;
            if(Rilisoft.GameEventOpenChestButtonsView.丝不丛丑上丏与丁丄.世三丞丅丑丌丈丈一() >= 1)
            {
                    val_9 = null;
                val_9 = null;
                val_7 = Rilisoft.GameEventOpenChestButtonsView.丝不丛丑上丏与丁丄;
                float val_7 = this._hintsShowDelayInSeconds;
                val_7 = val_7 + (float)val_7.世三丞丅丑丌丈丈一();
                var val_4 = (val_7 <= (float)专七专下且专三一且.上且一丈丐三丄一丆()) ? 1 : 0;
            }
            else
            {
                    val_10 = true;
            }
            
            this.业世丟丏丂丌丒丆丏 = val_10;
            this.丝一丅丆三东丂丞七();
            CoinsMessage.下丗丑且专丝丈丁三(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.GameEventOpenChestButtonsView::丝三丝丙世世上丅三(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
            BankController.丕丝丌丅七丌三万丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventOpenChestButtonsView::丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)));
        }
        private void OnDisable()
        {
            CoinsMessage.丐上丈丆专不不丑丟(丙业与丙丗丝不丈东:  new CoinsMessage.一丞专丂丏丟丑七与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.GameEventOpenChestButtonsView::丝三丝丙世世上丅三(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)));
            BankController.丘与丗丆专丘丞丂丞(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventOpenChestButtonsView::丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)));
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            this.且丞丂丐不丐不丂丒 = 丅东专与不三丂丁丝;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_37;
            string val_38;
            UnityEngine.GameObject val_39;
            Rilisoft.上专业三丟丁丞专下 val_40;
            var val_41;
            var val_42;
            if(((this.且丞丂丐不丐不丂丒 == null) || (this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世() == null)) || (this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丟丂丞不专丆万丒世() < 1))
            {
                goto label_6;
            }
            
            val_37 = this;
            UnityEngine.GameObject val_6 = this._leftButton.gameObject;
            val_38 = 1152921505284374528;
            if((this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().业不丕丐丐不专丏且(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) == false)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
            UnityEngine.GameObject val_7 = this._rightButton.gameObject;
            goto label_14;
            label_6:
            val_37 = this;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._leftButton.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._rightButton.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_19;
            label_10:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
            this._leftButton.Set(丏专丒丙丟且丈万七:  this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丟丂丞不专丆万丒世(), 丏丂不专上丘丂不丅:  this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().东与三丌丅三丒丏业(), 下丅三丈世丐丕丌丑:  1);
            if(this.且丞丂丐不丐不丂丒 != null)
            {
                    val_40 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世();
            }
            else
            {
                    val_40 = 0.且丌三丙丙与与丝世();
            }
            
            val_41 = this.且丞丂丐不丐不丂丒;
            int val_16 = val_41.丛丞上业东且与丗丁(丐下丝丘丑丟丟丗丌:  val_40);
            this.一三丏丄丙不上丙丙 = val_16;
            if(val_16 == 0)
            {
                    if(this.且丞丂丐不丐不丂丒.下一三万丝丟丐丒丆() != false)
            {
                    float val_37 = (float)this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丂丙丐丆丝上万业世();
                val_37 = val_37 - (float)this.且丞丂丐不丐不丂丒.丂世上东丞且丏丝丗();
                val_37 = val_37 / (float)this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丁丒丝世下丟丑七丐();
                val_42 = UnityEngine.Mathf.CeilToInt(f:  val_37);
            }
            else
            {
                    val_42 = 0;
            }
            
                val_41 = val_42;
                int val_24 = UnityEngine.Mathf.Min(a:  0, b:  10);
                this.一三丏丄丙不上丙丙 = val_24;
            }
            
            if(val_24 >= 2)
            {
                goto label_44;
            }
            
            val_39 = this._rightButton.gameObject;
            label_14:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  false);
            goto label_48;
            label_44:
            int val_38 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丟丂丞不专丆万丒世();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._rightButton.gameObject, 丏业丟一东丂东丘丛:  true);
            val_38 = this.一三丏丄丙不上丙丙 * val_38;
            val_38 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().东与三丌丅三丒丏业();
            this._rightButton.Set(丏专丒丙丟且丈万七:  val_38, 丏丂不专上丘丂不丅:  val_38, 下丅三丈世丐丕丌丑:  this.一三丏丄丙不上丙丙);
            label_48:
            this.万三丛丛丒丏丅七丅();
            label_19:
            bool val_33 = this._rightButton.gameObject.activeSelf;
            this._leftButton.transform.localPosition = new UnityEngine.Vector3() {x = (val_33 != true) ? this.丆世丕丕下丑丘不丗 : this._oneButtonPosition, y = (val_33 != true) ? 1152921542840424636 : 1152921542840424676, z = (val_33 != true) ? 1152921542840424640 : 1152921542840424680};
            this.专丗丏丁下丑丑丈专();
        }
        private void 专丗丏丁下丑丑丈专()
        {
            var val_13;
            if(((this.业世丟丏丂丌丒丆丏 != false) && (this._rightButton.gameObject.activeSelf != false)) && ((this._hint != 0) && (this.且丞丂丐不丐不丂丒 != null)))
            {
                    if(this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世() != null)
            {
                    if(this.且丞丂丐不丐不丂丒.下一三万丝丟丐丒丆() == false)
            {
                goto label_11;
            }
            
            }
            
            }
            
            label_28:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hint, 丏业丟一东丂东丘丛:  false);
            return;
            label_11:
            int val_13 = this.且丞丂丐不丐不丂丒.丂世上东丞且丏丝丗();
            val_13 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丂丙丐丆丝上万业世() - val_13;
            Rilisoft.GameEventChestData val_10 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丁专丗万三上丟三丆();
            int val_14 = val_10.ToSuperChestPoints;
            val_14 = val_14 * this.一三丏丄丙不上丙丙;
            var val_11 = (val_14 >= val_13) ? 1 : 0;
            if(val_14 < val_13)
            {
                goto label_28;
            }
            
            val_13 = null;
            val_13 = null;
            Rilisoft.GameEventOpenChestButtonsView.丝不丛丑上丏与丁丄.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  专七专下且专三一且.上且一丈丐三丄一丆());
            goto label_28;
        }
        private void 万三丛丛丒丏丅七丅()
        {
            var val_6;
            if(this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛() == false)
            {
                goto label_3;
            }
            
            label_25:
            label_16:
            val_6 = 0;
            goto label_6;
            label_11:
            this._chestNameLabel[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3310");
            val_6 = 1;
            label_6:
            if(val_6 < this._chestNameLabel.Length)
            {
                goto label_11;
            }
            
            return;
            label_3:
            int val_5 = this.且丞丂丐不丐不丂丒.且丌三丙丙与与丝世().业上丙丞丐丄丆丅七();
            if((val_5 == 3) || (val_5 == 2))
            {
                goto label_25;
            }
            
            if(val_5 != 1)
            {
                goto label_16;
            }
            
            goto label_25;
        }
        private void 丈丝世丗丝与丞丗丅(int 万且万且丑丗且丌丆)
        {
            if(this.且丞丂丐不丐不丂丒 == null)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        private void 丝三丝丙世世上丅三(string 丏丂不专上丘丂不丅, int 丌丒丝东丌下丕丁丅)
        {
            if(this.且丞丂丐不丐不丂丒 == null)
            {
                    return;
            }
            
            this.丝一丅丆三东丂丞七();
        }
        public GameEventOpenChestButtonsView()
        {
            this.业世丟丏丂丌丒丆丏 = true;
            this._hintsShowDelayInSeconds = 300f;
        }
        private static GameEventOpenChestButtonsView()
        {
            Rilisoft.GameEventOpenChestButtonsView.丝不丛丑上丏与丁丄 = new Rilisoft.七丒丛丑丙丑丞丁丘(丟东丟丑丕丄丂丟丙:  "game-event-one-chest-hint-last-show-time");
        }
    
    }

}
