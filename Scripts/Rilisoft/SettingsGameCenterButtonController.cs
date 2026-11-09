using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class SettingsGameCenterButtonController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _buttonsHolder;
        private UnityEngine.GameObject _rateGameAndroidButton;
        private UnityEngine.GameObject _rateGameIosButton;
        private UnityEngine.GameObject _signOutButton;
        
        // Methods
        private SettingsGameCenterButtonController()
        {
        
        }
        private void OnEnable()
        {
            Rilisoft.SettingsGameCenterButtonController.万丝与丂丈下丏丄且(七与丅万下丂业东丌:  this._rateGameAndroidButton);
            Rilisoft.SettingsGameCenterButtonController.丐丈丂丐丌下七丁丘(丏与丂丐专丂丘丞丒:  this._rateGameIosButton);
            Rilisoft.SettingsGameCenterButtonController.东丆三丘一世上下一(下三上丈丏业丁丙东:  this._buttonsHolder);
            Rilisoft.SettingsGameCenterButtonController.丑丁丞且丙丅丆三丟(丏丟七丘丛丈丙丘且:  this._signOutButton);
        }
        private static void 万丝与丂丈下丏丄且(UnityEngine.GameObject 七与丅万下丂业东丌)
        {
            var val_4;
            if(七与丅万下丂业东丌 == 0)
            {
                    return;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_4;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                goto label_10;
            }
            
            val_4 = 1;
            goto label_9;
            label_4:
            label_10:
            val_4 = 0;
            label_9:
            七与丅万下丂业东丌.SetActive(value:  false);
        }
        private static void 丐丈丂丐丌下七丁丘(UnityEngine.GameObject 丏与丂丐专丂丘丞丒)
        {
            var val_3;
            if(丏与丂丐专丂丘丞丒 == 0)
            {
                    return;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
            {
                    val_3 = 1;
            }
            else
            {
                    val_3 = 0;
            }
            
            丏与丂丐专丂丘丞丒.SetActive(value:  false);
        }
        private static void 东丆三丘一世上下一(UnityEngine.GameObject 下三上丈丏业丁丙东)
        {
            bool val_8;
            if(下三上丈丏业丁丙东 == 0)
            {
                    return;
            }
            
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
            {
                goto label_8;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_5;
            }
            
            val_8 = 1;
            goto label_7;
            label_5:
            if(UnityEngine.Social.localUser == null)
            {
                goto label_8;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            goto label_13;
            label_8:
            val_8 = 0;
            goto label_15;
            label_13:
            val_8 = UnityEngine.Social.localUser.authenticated;
            label_7:
            label_15:
            下三上丈丏业丁丙东.SetActive(value:  val_8);
        }
        private static void 丑丁丞且丙丅丆三丟(UnityEngine.GameObject 丏丟七丘丛丈丙丘且)
        {
            if(丏丟七丘丛丈丙丘且 == 0)
            {
                    return;
            }
            
            丏丟七丘丛丈丙丘且.SetActive(value:  false);
        }
        public void HandleGameCenterButton()
        {
            var val_15;
            IntPtr val_17;
            var val_19;
            System.Action<System.Boolean, System.String> val_21;
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(UnityEngine.Application.isEditor != false)
            {
                    UnityEngine.Debug.Log(message:  "[Game Center] pressed.");
                return;
            }
            
            UnityEngine.RuntimePlatform val_2 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            if(val_2 == 8)
            {
                goto label_5;
            }
            
            if(val_2 != 11)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
            {
                    return;
            }
            
            val_15 = GameCircleSocial.Instance;
            if(val_15.localUser == null)
            {
                goto label_39;
            }
            
            val_15 = GameCircleSocial.Instance.localUser;
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_21;
            label_5:
            if(UnityEngine.Application.isEditor != false)
            {
                    return;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_17 = 3;
            if(UnityEngine.Social.localUser.authenticated != false)
            {
                    UnityEngine.Social.ShowLeaderboardUI();
                return;
            }
            
            val_19 = null;
            val_19 = null;
            val_21 = SettingsGameCenterButtonController.<>c.<>9__10_0;
            if(val_21 == null)
            {
                    System.Action<System.Boolean, System.String> val_13 = null;
                val_21 = val_13;
                val_17 = System.Void SettingsGameCenterButtonController.<>c::丙七丛下丌上丐丂丏(bool 东且丁丆丛丁丏丘且, string 丂七东不不丈一丐不);
                val_13 = new System.Action<System.Boolean, System.String>(object:  SettingsGameCenterButtonController.<>c.__il2cppRuntimeField_static_fields, method:  val_17);
                SettingsGameCenterButtonController.<>c.<>9__10_0 = val_21;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_17 = 1;
            goto label_38;
            label_21:
            if(val_15.authenticated != false)
            {
                    AGSAchievementsClient.ShowAchievementsOverlay();
                return;
            }
            
            label_39:
            AGSClient.ShowSignInPage();
            return;
            label_38:
            UnityEngine.Social.localUser.Authenticate(callback:  val_13);
        }
        public void HandleSignOutGameCenterButton()
        {
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  "[Sign Out] pressed.");
        }
    
    }

}
