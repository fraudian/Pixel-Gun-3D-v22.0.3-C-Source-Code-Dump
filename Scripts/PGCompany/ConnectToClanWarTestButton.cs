using UnityEngine;

namespace PGCompany
{
    internal sealed class ConnectToClanWarTestButton : MonoBehaviour
    {
        // Fields
        public Rilisoft.ButtonHandler connectBtn;
        public Rilisoft.ButtonHandler cancelBtn;
        public UILabel labelNickFull;
        public UILabel labelNick;
        public AchieveBox achieveBox;
        public UISprite timeoutProgress;
        private UIButton 上丗上丅丂丝丟世丂;
        private string 丁世且东丒丕万丟下;
        private float 丆丏丏丟丙丑丙丗丕;
        private string 丅一丞万丑专丅丅与;
        
        // Methods
        private void Update()
        {
            this.东丞丝且丐丄业丄丏();
        }
        internal void 业东三丒丝丐丏丐且(string 不丆业丏上丐与丌业, string 丅一丞万丑专丅丅与)
        {
            this.丁世且东丒丕万丟下 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5697"), arg0:  System.String.Format(format:  "[FFFF01]{0}[-]", arg0:  不丆业丏上丐与丌业));
            this.上丗上丅丂丝丟世丂 = this.connectBtn.GetComponent<UIButton>();
            this.丅一丞万丑专丅丅与 = 丅一丞万丑专丅丅与;
            this.丆丏丏丟丙丑丙丗丕 = 10f;
            this.东丞丝且丐丄业丄丏();
        }
        internal void 业东三丒丝丐丏丐且()
        {
            this.丁世且东丒丕万丟下 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4723");
            this.上丗上丅丂丝丟世丂 = this.connectBtn.GetComponent<UIButton>();
            this.丆丏丏丟丙丑丙丗丕 = 10f;
            this.东丞丝且丐丄业丄丏();
        }
        private void 东丞丝且丐丄业丄丏()
        {
            bool val_1 = PGCompany.ConnectToClanWarTestButton.专丈业丑万丆丟世丗();
            this.connectBtn.gameObject.SetActive(value:  val_1);
            this.cancelBtn.gameObject.SetActive(value:  val_1);
            bool val_7 = PGCompany.ConnectToClanWarTestButton.丟东七丕专丙丈丘丂();
            this.labelNick.gameObject.SetActive(value:  val_1);
            this.labelNickFull.gameObject.SetActive(value:  (~val_1) & 1);
            this.labelNickFull.text = this.丁世且东丒丕万丟下;
            this.labelNick.text = this.丁世且东丒丕万丟下;
            if(((val_1 & this.labelNick.丟丄与丆三丅万丟丅()) != false) && ((this.上丗上丅丂丝丟世丂 & 1) != 0))
            {
                    this.achieveBox.丁丛丝丆丘丞丕丈三();
            }
            
            float val_15 = 10f;
            val_15 = this.丆丏丏丟丙丑丙丗丕 / val_15;
            this.timeoutProgress.fillAmount = val_15;
            float val_14 = UnityEngine.Time.deltaTime;
            val_14 = this.丆丏丏丟丙丑丙丗丕 - val_14;
            this.丆丏丏丟丙丑丙丗丕 = val_14;
        }
        private bool 丟丄与丆三丅万丟丅()
        {
            string val_12;
            var val_13;
            val_12 = Rilisoft.PushNotifications.PushNotificationHandler.丑七不且上丗丁一世();
            if(val_12.Active == false)
            {
                goto label_13;
            }
            
            val_12 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_12.丞丗丑丈一丅丗丌丟() == null)
            {
                goto label_4;
            }
            
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.东专世且丈下下丒丘() == false)
            {
                goto label_13;
            }
            
            val_12 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
            bool val_10 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  0);
            if((val_9.Equals(value:  val_12)) == false)
            {
                goto label_13;
            }
            
            label_4:
            val_13 = 1;
            return (bool)val_13;
            label_13:
            val_13 = 0;
            return (bool)val_13;
        }
        private void OnClick()
        {
            this.achieveBox.丁丛丝丆丘丞丕丈三();
            if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  new System.Action(object:  this, method:  System.Void PGCompany.ConnectToClanWarTestButton::丝丙东不七三且丘丘()))) != false)
            {
                    return;
            }
            
            this.丝丙东不七三且丘丘();
        }
        private void 丝丙东不七三且丘丘()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_5 = null;
            val_5 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_6 = null;
                val_6 = null;
                if(activeInHierarchy != false)
            {
                    val_7 = null;
                val_7 = null;
                SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  this.丅一丞万丑专丅丅与);
                val_8 = null;
                val_8 = null;
                MainMenuController.丄丞丁丈与业上丞丟.EnterClanWarTestMode();
                return;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_11 = null;
            val_11 = null;
            SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  this.丅一丞万丑专丅丅与);
            val_12 = null;
            val_12 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.EnterClanWarTestMode();
        }
        private void 丞东丝万三丆丕丁下()
        {
            this.achieveBox.丁丛丝丆丘丞丕丈三();
        }
        private void Awake()
        {
            this.connectBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ConnectToClanWarTestButton::东七七上上三丟与专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            this.cancelBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ConnectToClanWarTestButton::上且业丙丅丞专丛丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        internal static bool 专丈业丑万丆丟世丗()
        {
            FriendProfileView val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            val_30 = 业丈不上丟万一丕丏.丑七不且上丗丁一世();
            if(val_30.丌丗丑业丁上丆万七() == true)
            {
                    return (bool)0 & 1;
            }
            
            val_31 = null;
            val_31 = null;
            val_30 = FriendProfileView.丐丕丝上丅丈丐丞专;
            if(val_30 != 0)
            {
                    return (bool)0 & 1;
            }
            
            if(GiftBannerWindow.丛世丛与丌不丈丐丐() != true)
            {
                    if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                goto label_13;
            }
            
            }
            
            return (bool)0 & 1;
            label_13:
            if(BankController.丑七不且上丗丁一世() != 0)
            {
                    if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            InfoWindowController val_11 = InfoWindowController.丑七不且上丗丁一世();
            if(val_11.restoreWindowPanel != 0)
            {
                    InfoWindowController val_13 = InfoWindowController.丑七不且上丗丁一世();
                if(val_13.restoreWindowPanel.activeSelf == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_32 = null;
            val_32 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_38;
            }
            
            val_33 = null;
            val_33 = null;
            if(activeInHierarchy == true)
            {
                goto label_54;
            }
            
            label_38:
            val_34 = null;
            val_34 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_35 = null;
                val_35 = null;
                if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled != false)
            {
                    if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
            {
                goto label_54;
            }
            
            }
            
            }
            
            if(ClanWarUI.丈丐丞丐上丑且丕万() == false)
            {
                    return (bool)0 & 1;
            }
            
            label_54:
            if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() == true)
            {
                    return (bool)0 & 1;
            }
            
            val_36 = null;
            val_36 = null;
            if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_37 = null;
                val_37 = null;
                if(SquadController.丄丘七三上丕世丞业.IsClanSquad == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(LeaderboardsGui.丑丙丗世丏丞万世丒() == true)
            {
                    return (bool)0 & 1;
            }
            
            if(LeaderboardsClans.丑丙丗世丏丞万世丒() == true)
            {
                    return (bool)0 & 1;
            }
            
            if(NurseryGuiController.丛世丛与丌不丈丐丐() == true)
            {
                    return (bool)0 & 1;
            }
            
            bool val_30 = Rilisoft.ClansLobbyGui.OpenChestProcessing ^ 1;
            return (bool)0 & 1;
        }
        internal static bool 丟东七丕专丙丈丘丂()
        {
            bool val_1 = MainMenuController.丏丗丙丙丞丆万丘丅(丈丈不丒丗与丝不丗:  false);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public ConnectToClanWarTestButton()
        {
            this.丁世且东丒丕万丟下 = "";
            this.丅一丞万丑专丅丅与 = System.String.alignConst;
        }
        private void 东七七上上三丟与专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.OnClick();
        }
        private void 上且业丙丅丞专丛丄(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丞东丝万三丆丕丁下();
        }
    
    }

}
