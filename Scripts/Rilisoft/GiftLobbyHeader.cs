using UnityEngine;

namespace Rilisoft
{
    public class GiftLobbyHeader : MonoBehaviour
    {
        // Fields
        private string _freeOpenLocalizationKey;
        private TextMeshBounds _headerText;
        private UnityEngine.Vector3 _labelPos;
        private UnityEngine.Vector3 _labelPosWithoutTimer;
        private string _paidOpenLocalizationKey;
        private UnityEngine.GameObject _timerObject;
        private TextMeshBounds _timerText;
        
        // Methods
        private void OnEnable()
        {
            this.丝业丅丕丌世不不东();
        }
        private void Update()
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = null;
            val_8 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            if(GiftController.丆丕丝丒不丙且丐丗 == 0)
            {
                goto label_14;
            }
            
            val_10 = null;
            val_10 = null;
            if(GiftController.丆丕丝丒不丙且丐丗.ActiveGift == false)
            {
                goto label_14;
            }
            
            val_11 = null;
            val_11 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
            {
                goto label_24;
            }
            
            val_12 = null;
            val_12 = null;
            if(GiftBannerWindow.丄丘七三上丕世丞业.gameObject.activeInHierarchy == false)
            {
                goto label_24;
            }
            
            label_14:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._headerText.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerObject, 丏业丟一东丂东丘丛:  false);
            return;
            label_24:
            this.丝业丅丕丌世不不东();
        }
        private void 丝业丅丕丌世不不东()
        {
            var val_16;
            var val_17;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._headerText.gameObject, 丏业丟一东丂东丘丛:  true);
            val_16 = null;
            val_16 = null;
            UnityEngine.Transform val_4 = this._headerText.gameObject.transform;
            if(GiftController.丆丕丝丒不丙且丐丗.CanGetGift != false)
            {
                    val_4.localPosition = new UnityEngine.Vector3() {x = this._labelPosWithoutTimer, y = V9.16B, z = V10.16B};
                this._headerText.LocalizationKey = this._freeOpenLocalizationKey;
                this._headerText.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._headerText.LocalizationKey);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerObject, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            val_4.localPosition = new UnityEngine.Vector3() {x = this._labelPos, y = V9.16B, z = V10.16B};
            this._headerText.LocalizationKey = this._paidOpenLocalizationKey;
            this._headerText.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._headerText.LocalizationKey);
            val_17 = null;
            val_17 = null;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)GiftController.丆丕丝丒不丙且丐丗.TimeLeft, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0))) == false)
            {
                goto label_31;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerObject, 丏业丟一东丂东丘丛:  false);
            this._headerText.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = this._labelPosWithoutTimer, y = V9.16B, z = V10.16B};
            this._headerText.LocalizationKey = this._freeOpenLocalizationKey;
            if(this._headerText != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            this._headerText.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._headerText.LocalizationKey);
            return;
            label_31:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._timerObject, 丏业丟一东丂东丘丛:  true);
            if(this._timerText != null)
            {
                goto label_44;
            }
            
            goto label_45;
        }
        public GiftLobbyHeader()
        {
            this._freeOpenLocalizationKey = "Key_2467";
            this._paidOpenLocalizationKey = "Key_2200";
        }
    
    }

}
