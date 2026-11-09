using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class MainMenuGooglePlayGamesButtonController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _buttonsHolder;
        private bool _runningAuthentication;
        private UnityEngine.GameObject _signOutButton;
        private bool _wasAuthenticated;
        public UnityEngine.Events.UnityEvent onHide;
        public UnityEngine.Events.UnityEvent onShow;
        
        // Properties
        private static System.Globalization.CultureInfo F { get; }
        
        // Methods
        private MainMenuGooglePlayGamesButtonController()
        {
        
        }
        private static System.Globalization.CultureInfo get_F()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private void Start()
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    CoroutineRunner.与万且丗丆下丁且丂(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::OnApplicationPause(bool 丁与丟万丄丒丗专丌)));
            }
            
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丅且三丂东世丒丛上(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::丆业丄万丆丟丈业丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丙专专丈且专丟丑下(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丏丐丞上七七丝世丝>(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::丅世丂丂丂丁业丛丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丏丐丞上七七丝世丝 丗丛不丁丑专专丂且)));
        }
        private void OnDestroy()
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    CoroutineRunner.丕丑不丗上丁丝丕专(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::OnApplicationPause(bool 丁与丟万丄丒丗专丌)));
            }
            
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().业丒东丆丞东七下专(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::丆业丄万丆丟丈业丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().世不丂且丑丐丆世丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丏丐丞上七七丝世丝>(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::丅世丂丂丂丁业丛丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丏丐丞上七七丝世丝 丗丛不丁丑专专丂且)));
        }
        private void OnEnable()
        {
            this.三与丒丑丄世专丑一();
            this.丑丁丞且丙丅丆三丟();
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            bool val_6 = 丁与丟万丄丒丗专丌;
            bool val_2 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅();
            if(val_6 != true)
            {
                    var val_3 = (this._wasAuthenticated == false) ? 1 : 0;
                val_3 = val_2 | val_3;
                if(val_3 != true)
            {
                    val_6 = Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世();
                val_6.丒上丏且丘丕丅丄丕();
            }
            
            }
            
            this._wasAuthenticated = val_2;
        }
        private void 三与丒丑丄世专丑一()
        {
            UnityEngine.GameObject val_5;
            var val_6;
            if(this._buttonsHolder == 0)
            {
                    this.onHide.Invoke();
                return;
            }
            
            if(((Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11) && (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)) && (与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 2))
            {
                    this.onShow.Invoke();
                val_5 = this._buttonsHolder;
                val_6 = 1;
            }
            else
            {
                    this.onHide.Invoke();
                val_5 = this._buttonsHolder;
                val_6 = 0;
            }
            
            val_5.SetActive(value:  false);
        }
        private void 丑丁丞且丙丅丆三丟(bool 世丁丐与下下丄东且)
        {
            bool val_4;
            if(this._signOutButton == 0)
            {
                    return;
            }
            
            bool val_2 = UnityEngine.Application.isEditor;
            if(this._signOutButton == null)
            {
                goto label_4;
            }
            
            if(val_2 == false)
            {
                goto label_5;
            }
            
            label_7:
            val_4 = 1;
            goto label_6;
            label_4:
            if(val_2 == true)
            {
                goto label_7;
            }
            
            label_5:
            val_4 = 世丁丐与下下丄东且;
            label_6:
            this._signOutButton.SetActive(value:  val_4);
        }
        private void 丑丁丞且丙丅丆三丟()
        {
            this.丑丁丞且丙丅丆三丟(世丁丐与下下丄东且:  Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅());
        }
        private void 丆业丄万丆丟丈业丟(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[MainMenuGooglePlayGamesButtonController.HandleSignOut] isAuthenticated: "("[MainMenuGooglePlayGamesButtonController.HandleSignOut] isAuthenticated: ") + Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅().ToString(provider:  Rilisoft.MainMenuGooglePlayGamesButtonController.F)(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅().ToString(provider:  Rilisoft.MainMenuGooglePlayGamesButtonController.F)));
            }
            
            this.丑丁丞且丙丅丆三丟(世丁丐与下下丄东且:  false);
        }
        private void 丅世丂丂丂丁业丛丕(object 不丟丗丏丛丕不丁丌, Rilisoft.丏丐丞上七七丝世丝 丗丛不丁丑专专丂且)
        {
            this.丑丁丞且丙丅丆三丟();
        }
        public void HandlePlayGamesButton()
        {
            object val_15 = this;
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                    return;
            }
            
            System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
            if(((-56481364) & 1) != 0)
            {
                    TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
            }
            
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            if((Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() != false) && (this._signOutButton != 0))
            {
                    if(this._signOutButton.activeInHierarchy != false)
            {
                    Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丒上丏且丘丕丅丄丕();
                string val_9 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2103");
                InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  (val_9 == null) ? "Signed out." : (val_9));
                return;
            }
            
            }
            
            if(this._runningAuthentication != false)
            {
                    UnityEngine.Debug.Log(message:  "Ignoring Play Games button since authentication is currently running.");
                return;
            }
            
            this.丑丁丞且丙丅丆三丟();
            if(Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().下丏丗与七丑丅与丅() != false)
            {
                    UnityEngine.Social.ShowAchievementsUI();
                return;
            }
            
            this._runningAuthentication = true;
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丟丕丕丌丈业丝丅丅(业丏丈世世世丞丒世:  new System.Action<System.Boolean>(object:  this, method:  System.Void Rilisoft.MainMenuGooglePlayGamesButtonController::丑下丏丄不上丂七东(bool 丞且万不与业下丂丆)), 与且专丏丅世丐丐丑:  false);
        }
        public void HandleSignOutGooglePlayGamesButton()
        {
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 2)
            {
                    return;
            }
            
            ButtonClickSound.丁业上丏不丕三丗不();
            Rilisoft.丑丞丑丟东丁七丒下.丑七不且上丗丁一世().丒上丏且丘丕丅丄丕();
            string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2103");
            InfoWindowController.丟丛业且丁丂上丑丝(丕丗丘丑丛与丑业丒:  (val_4 == null) ? "Signed out." : (val_4));
        }
        private void 丑下丏丄不上丂七东(bool 丞且万不与业下丂丆)
        {
            if(丞且万不与业下丂丆 != false)
            {
                    UnityEngine.Social.ShowAchievementsUI();
            }
            
            this._runningAuthentication = false;
        }
    
    }

}
