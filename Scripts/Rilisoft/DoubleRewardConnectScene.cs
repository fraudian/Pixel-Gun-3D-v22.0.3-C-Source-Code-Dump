using UnityEngine;

namespace Rilisoft
{
    public sealed class DoubleRewardConnectScene : MonoBehaviour
    {
        // Fields
        private UILabel[] _doubleRewardLabels;
        private UnityEngine.GameObject _doubleRewardPanel;
        private System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 下丁上丟业一三丒东;
        private bool 丅丈专三一丄丞丐丅;
        
        // Methods
        internal void 丗与丄丑一丈丙不丛(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌)
        {
            if(this.下丁上丟业一三丒东.丙东专丂世丈丏丁丂() == 上且丗一丏丏万丅丌)
            {
                    if(((-711714568) & 1) != 0)
            {
                    return;
            }
            
            }
            
            this.下丁上丟业一三丒东 = 0;
            this.下三丗世东丐丒丑丗();
        }
        private void 下三丗世东丐丒丑丗()
        {
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = 1152921504848912384;
            if(this._doubleRewardPanel == 0)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy != true)
            {
                    this.gameObject.SetActive(value:  true);
            }
            
            if((this.下丁上丟业一三丒东 & 1) == 0)
            {
                goto label_15;
            }
            
            val_14 = null;
            val_14 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                goto label_15;
            }
            
            val_15 = static_value_081DACA8;
            val_15 = static_value_081DACA8;
            val_13 = mem[static_value_081DACA8 + 184 + 16];
            val_13 = static_value_081DACA8 + 184 + 16;
            if(val_13 == 0)
            {
                goto label_15;
            }
            
            val_16 = static_value_081DACA8;
            val_16 = static_value_081DACA8;
            val_13 = mem[static_value_081DACA8 + 184 + 16];
            val_13 = static_value_081DACA8 + 184 + 16;
            if(val_13.世丞不丈丕丝东丞上() == false)
            {
                goto label_19;
            }
            
            label_15:
            label_33:
            this._doubleRewardPanel.gameObject.SetActive(value:  false);
            return;
            label_19:
            val_17 = static_value_081DACA8;
            val_17 = static_value_081DACA8;
            System.Nullable<Rilisoft.七丕丟丏三丈一丄世> val_13 = this.下丁上丟业一三丒东;
            val_13 = (static_value_081DACA8 + 184 + 16.且东丝丑丑丛世丈下(丞丁丑丏丄丏七丂不:  static_value_081DACA8 + 184 + 16 + 48 + 136, 下下丁一下丒业丄业:  true)) & (Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().东不丗丆丗丛丈丑丅(上且丗一丏丏万丅丌:  val_13));
            if((val_13 != false) && (this.丅丈专三一丄丞丐丅 != true))
            {
                    this.世下专世丐丑七专丂();
            }
            
            UnityEngine.GameObject val_11 = this._doubleRewardPanel.gameObject;
            bool val_12 = val_13;
            goto label_33;
        }
        private void Start()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.DoubleRewardConnectScene::丙丁与丝东丞丐丐且()));
        }
        private void OnDestroy()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.DoubleRewardConnectScene::丙丁与丝东丞丐丐且()));
        }
        private void OnEnable()
        {
            this.下三丗世东丐丒丑丗();
        }
        private void 丙丁与丝东丞丐丐且()
        {
            this.丅丈专三一丄丞丐丅 = false;
        }
        private void 世下专世丐丑七专丂()
        {
            System.IFormatProvider val_5;
            var val_6;
            if(this._doubleRewardLabels == null)
            {
                    return;
            }
            
            val_5 = System.Globalization.CultureInfo.InvariantCulture;
            val_6 = 0;
            goto label_7;
            label_11:
            val_5 = this._doubleRewardLabels[0];
            val_5.text = System.String.Format(provider:  val_5, format:  "{0}x", arg0:  Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丞业不丅丑丙与不不());
            val_6 = 1;
            label_7:
            if(val_6 < this._doubleRewardLabels.Length)
            {
                goto label_11;
            }
            
            this.丅丈专三一丄丞丐丅 = true;
        }
        public DoubleRewardConnectScene()
        {
        
        }
    
    }

}
