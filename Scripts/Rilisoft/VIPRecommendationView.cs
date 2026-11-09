using UnityEngine;

namespace Rilisoft
{
    public class VIPRecommendationView : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _btnBuy;
        private UnityEngine.GameObject _btnRenew;
        private UILabel[] _description;
        private UILabel[] _header;
        private Rilisoft.InAppBonusLobbyScrollView 丗丁一丂丟七不下上;
        private UITexture _texture;
        private UILabel _timer;
        private UnityEngine.Coroutine 丑丝丟业丙与丄与丟;
        
        // Methods
        public void OnBuyButtonClicked()
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            MainMenuController.丄丞丁丈与业上丞丟.东丏且丑上丑专上不(世且不丏丒丞丙东丐:  "VipOffer");
            Rilisoft.一丟专且三万丞丁丂.万丝丟东丂不丅万七(丘上丟专丘丁丆万丌:  ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上()) > 0) ? 1 : 0);
            val_5 = null;
            val_5 = null;
            Rilisoft.VIPController.下丈丙丞专且丂丁不 = true;
        }
        public void OnRenewButtonClicked()
        {
            null = null;
            MainMenuController.丄丞丁丈与业上丞丟.东丏且丑上丑专上不(世且不丏丒丞丙东丐:  "VipOffer");
        }
        private void 三丛丆上丈丆丗丆专(string 丕丗丘丑丛与丑业丒)
        {
            int val_2;
            if(this._description == null)
            {
                    return;
            }
            
            if(this._description.Length < 1)
            {
                    return;
            }
            
            goto label_12;
            label_10:
            val_2 = System.String.alignConst;
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_12:
            UILabel val_3 = this._description[0];
            if(val_3 == 0)
            {
                goto label_9;
            }
            
            val_2 = 丕丗丘丑丛与丑业丒;
            if(丕丗丘丑丛与丑业丒 == null)
            {
                goto label_10;
            }
            
            label_5:
            val_3.text = val_2;
            label_9:
            if((0 + 1) < this._description.Length)
            {
                goto label_12;
            }
        
        }
        private void 丒一丏丄丝且丑万丏(string 丕丗丘丑丛与丑业丒)
        {
            int val_2;
            if(this._header == null)
            {
                    return;
            }
            
            if(this._header.Length < 1)
            {
                    return;
            }
            
            goto label_12;
            label_10:
            val_2 = System.String.alignConst;
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_12:
            UILabel val_3 = this._header[0];
            if(val_3 == 0)
            {
                goto label_9;
            }
            
            val_2 = 丕丗丘丑丛与丑业丒;
            if(丕丗丘丑丛与丑业丒 == null)
            {
                goto label_10;
            }
            
            label_5:
            val_3.text = val_2;
            label_9:
            if((0 + 1) < this._header.Length)
            {
                goto label_12;
            }
        
        }
        private void 与丕丞一丐七专丗下(int 丂三丟丂丈丐丆丗丟)
        {
            if(this._timer == 0)
            {
                    if(this.丗丁一丂丟七不下上 != 0)
            {
                    this._timer = this.丗丁一丂丟七不下上.丄上专专丂七丁三丗();
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this._timer)) == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._timer.gameObject, 丏业丟一东丂东丘丛:  true);
            this._timer.text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丂三丟丂丈丐丆丗丟, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
        private void 丈下且丅丞下丙七丘()
        {
            bool val_8;
            var val_9;
            if((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上()) > 0)
            {
                    val_8 = 0;
            }
            else
            {
                    val_9 = null;
                val_8 = Rilisoft.VIPController.丌丏丄专丘丕丑上且();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnBuy, 丏业丟一东丂东丘丛:  val_8);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._btnRenew, 丏业丟一东丂东丘丛:  ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.东且丅业七丂丌不上()) > 0) ? 1 : 0);
        }
        private void OnEnable()
        {
            this.丗丁一丂丟七不下上 = this.GetComponentInParent<Rilisoft.InAppBonusLobbyScrollView>();
            this.三丛丆上丈丆丗丆专(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4041"));
            this.丒一丏丄丝且丑万丏(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4036"));
            this.丅三丞丞业东七丘业();
            this.丑丝丟业丙与丄与丟 = CoroutineRunner.Instance.StartCoroutine(routine:  this.一丄丘万丕丄丅丅丁());
        }
        private void OnDisable()
        {
            this.丅三丞丞业东七丘业();
        }
        private void 丅三丞丞业东七丘业()
        {
            if(this.丑丝丟业丙与丄与丟 == null)
            {
                    return;
            }
            
            CoroutineRunner.Instance.StopCoroutine(routine:  this.丑丝丟业丙与丄与丟);
            this.丑丝丟业丙与丄与丟 = 0;
        }
        private System.Collections.IEnumerator 一丄丘万丕丄丅丅丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new VIPRecommendationView.丕且丕不丛丙丁且丒();
        }
        public VIPRecommendationView()
        {
        
        }
    
    }

}
