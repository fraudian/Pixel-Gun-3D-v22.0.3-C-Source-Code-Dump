using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal class 丙丙与东一丐丂丐上
    {
        // Fields
        private static PGCompany.GameModeHub.丙丙与东一丐丂丐上 丝业丆丁业三丈丟东;
        private ConnectPanel 下丆下且丟业万丁且;
        private 丝下且丙丑丈丟丂一 世丒丁丛丙丁世丟丄;
        private System.IDisposable 与丈丘下一七丒东丁;
        
        // Properties
        internal static PGCompany.GameModeHub.丙丙与东一丐丂丐上 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.GameModeHub.丙丙与东一丐丂丐上 丑七不且上丗丁一世()
        {
            PGCompany.GameModeHub.丙丙与东一丐丂丐上 val_2 = PGCompany.GameModeHub.丙丙与东一丐丂丐上.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.GameModeHub.丙丙与东一丐丂丐上 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.GameModeHub.丙丙与东一丐丂丐上();
            PGCompany.GameModeHub.丙丙与东一丐丂丐上.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal static Rilisoft.七丕丟丏三丈一丄世 丐丐丟三丑丁东丐丕()
        {
            var val_4;
            PGCompany.GameModeHub.丕业丞七丄七丒万东 val_5;
            if((PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 != null) && (PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟() != null))
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            if((34919224 & 1) != 0)
            {
                    int val_2 = val_4.丙东专丂世丈丏丁丂();
                return (Rilisoft.七丕丟丏三丈一丄世)PGCompany.GameModeHub.丙丙与东一丐丂丐上.丅与丌丅丘与丁丕且(一丐丛丏与丗七丂丐:  val_5 = 0);
            }
            
            return (Rilisoft.七丕丟丏三丈一丄世)PGCompany.GameModeHub.丙丙与东一丐丂丐上.丅与丌丅丘与丁丕且(一丐丛丏与丗七丂丐:  val_5);
        }
        internal static Rilisoft.七丕丟丏三丈一丄世 丅与丌丅丘与丁丕且(PGCompany.GameModeHub.丕业丞七丄七丒万东 一丐丛丏与丗七丂丐)
        {
            PGCompany.GameModeHub.丕业丞七丄七丒万东 val_8;
            var val_9;
            var val_10;
            val_8 = 一丐丛丏与丗七丂丐;
            if(val_8 != 0)
            {
                    val_9 = val_8;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_8.ToString())) != false)
            {
                    val_9 = null;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_8 = null;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  null.ToString()));
                return 100;
            }
            
                val_8 = System.String.Format(format:  "Can\'t find game mode. Check enum name {0}", arg0:  null);
                UnityEngine.Debug.LogWarning(message:  val_8);
            }
            
            val_10 = 100;
            return 100;
        }
        internal void 丝丛丅专上业与丞七(bool 丟丄下上丈丗丙丞世)
        {
            UnityEngine.Debug.LogError(message:  "Failed room connection!");
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.failInternetLabel == 0)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.failInternetLabel.SetActive(value:  true);
        }
        internal void 丂与丁东业上丄丛一(int 丗丟上上丒丐丗丞丙)
        {
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.failInternetLabel.SetActive(value:  true);
        }
        internal void 丒丁七万丌一与丞丂(string 丂七东不不丈一丐不)
        {
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.failInternetLabel.SetActive(value:  true);
        }
        private void 丑丂丒上东丙丟丕三()
        {
            if(this.与丈丘下一七丒东丁 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.与丈丘下一七丒东丁.Dispose();
            this.与丈丘下一七丒东丁 = 0;
        }
        internal void 丘不丁丘万丑丈丞世()
        {
            this.丑丂丒上东丙丟丕三();
            if(this.下丆下且丟业万丁且 != 0)
            {
                    if(this.下丆下且丟业万丁且.failInternetLabel != 0)
            {
                    this.下丆下且丟业万丁且.failInternetLabel.SetActive(value:  false);
            }
            
            }
            
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.gameObject == 0)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.gameObject.SetActive(value:  false);
        }
        internal void 丄上一丌专丞且丗世()
        {
            if(this.世丒丁丛丙丁世丟丄 != null)
            {
                    this.世丒丁丛丙丁世丟丄.丄上一丌专丞且丗世();
            }
            
            this.丘不丁丘万丑丈丞世();
        }
        internal void 丂丐与丞丗丒丘丑上()
        {
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            if(this.下丆下且丟业万丁且.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.failInternetLabel.SetActive(value:  true);
        }
        internal void 世一丛丞世丁专丘丐()
        {
            if(this.下丆下且丟业万丁且 == 0)
            {
                    return;
            }
            
            this.下丆下且丟业万丁且.cancelButton.ClearEvents();
            this.下丆下且丟业万丁且.cancelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  public System.Void PGCompany.GameModeHub.丙丙与东一丐丂丐上::丄上一丌专丞且丗世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            if(this.下丆下且丟业万丁且.connectWindow != 0)
            {
                    this.下丆下且丟业万丁且.connectWindow.SetActive(value:  true);
            }
            
            if(this.下丆下且丟业万丁且.banWindow != 0)
            {
                    this.下丆下且丟业万丁且.banWindow.SetActive(value:  false);
            }
            
            this.与丈丘下一七丒东丁 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.丙丙与东一丐丂丐上::丄上一丌专丞且丗世()), 与且专丈不万东一万:  "Connect to Photon panel");
            this.下丆下且丟业万丁且.gameObject.SetActive(value:  true);
        }
        internal void 丛丛业丈下下丐丟丒(PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不, PGCompany.GameModeHub.丞不七丗丒且业丁丛 丄丄丅丙专下上丄丒)
        {
            PGCompany.GameModeHub.丞不七丗丒且业丁丛 val_5;
            bool val_6;
            var val_7;
            val_5 = 丄丄丅丙专下上丄丒;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "start play on map {0}. playType: {1}", arg0:  丞丁丑丏丄丏七丂不.丝丏丘丁丝上丅丆下, arg1:  val_5));
            if(val_5 == 2)
            {
                    var val_2 = (丞丁丑丏丄丏七丂不.一丗丟丛丈专丙三丌 == 20) ? 1 : 0;
            }
            else
            {
                    val_6 = false;
            }
            
            val_7 = null;
            val_7 = null;
            GameConnect.丙丙东七丙丞专丛不 = val_6;
            if(val_5 != 1)
            {
                    val_7 = null;
                if(GameConnect.丙丙东七丙丞专丛不 == false)
            {
                    return;
            }
            
            }
            
            if(this.世丒丁丛丙丁世丟丄 != null)
            {
                    this.世丒丁丛丙丁世丟丄.世业丒万丘丆专丘丐();
            }
            
            丄丝丛丑丂丘一丈丁 val_4 = null;
            val_5 = val_4;
            val_4 = new 丄丝丛丑丂丘一丈丁(丅丟七丅丛丑丌丁世:  this, 东丐一业丆下丑丂丅:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.丙丙与东一丐丂丐上::且上万东世丏丐丝七()), 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
            this.世丒丁丛丙丁世丟丄 = val_5;
            val_4.三丑丛丄万丟丄丞丁();
        }
        private void 七丐丑丕万三三丏三()
        {
        
        }
        internal void 丐丝丅与上丒与丐世()
        {
            var val_4;
            System.Action val_6;
            if(this.世丒丁丛丙丁世丟丄 != null)
            {
                    this.世丒丁丛丙丁世丟丄.世业丒万丘丆专丘丐();
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = 丙丙与东一丐丂丐上.<>c.<>9__18_0;
            if(val_6 == null)
            {
                    System.Action val_1 = null;
                val_6 = val_1;
                val_1 = new System.Action(object:  丙丙与东一丐丂丐上.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 丙丙与东一丐丂丐上.<>c::一丛丗丗丆丞与下业());
                丙丙与东一丐丂丐上.<>c.<>9__18_0 = val_6;
            }
            
            this.世丒丁丛丙丁世丟丄 = new 丛丑丕丕丈丐丗丒丟(丅丟七丅丛丑丌丁世:  this, 东丐一业丆下丑丂丅:  val_1);
            System.Nullable<System.Boolean> val_3 = TrainingController.万丑万专丑三专丏丟();
            if((36894316 & 1) != 0)
            {
                    TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
            }
            
            this.世丒丁丛丙丁世丟丄.三丑丛丄万丟丄丞丁();
        }
        internal void 丂丐不上专丘丏丄丁(ConnectPanel 丛丘下丗业丂一且业)
        {
            this.下丆下且丟业万丁且 = 丛丘下丗业丂一且业;
        }
        public void 丄上一丌专丞且丗世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丄上一丌专丞且丗世();
        }
        public 丙丙与东一丐丂丐上()
        {
        
        }
        private void 且上万东世丏丐丝七()
        {
        
        }
        private void 丁丗丘丁下丕东万丟(bool 丟丟东丏世三一三丟)
        {
            if(丟丟东丏世三一三丟 == false)
            {
                    return;
            }
            
            PGCompany.GameModeLowDeviceWarningBanner.丕丂万与与丛丈丆丈 = true;
        }
        internal static void 丂丁专一业七且万丑(bool 丟丟东丏世三一三丟)
        {
            CustomPanelConnectScene.丑七不且上丗丁一世().且丝丌与丗丝丈一丟();
            if(丟丟东丏世三一三丟 == false)
            {
                    return;
            }
            
            PGCompany.GameModeLowDeviceWarningBanner.丕丂万与与丛丈丆丈 = true;
        }
    
    }

}
