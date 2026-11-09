using UnityEngine;

namespace PGCompany
{
    internal class LobbyEventStoreDelegate : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _body;
        private UnityEngine.Collider _collider;
        private TextMeshBounds _timeLeft;
        private static PGCompany.LobbyEventStoreDelegate <不丁丄七丛不丆丁丕>k__BackingField;
        private UnityEngine.WaitForSeconds 专七丛丟丟丄丝上丛;
        
        // Properties
        public static PGCompany.LobbyEventStoreDelegate 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        public static PGCompany.LobbyEventStoreDelegate get_Instance()
        {
            return (PGCompany.LobbyEventStoreDelegate)PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.LobbyEventStoreDelegate 丙业与丙丗丝不丈东)
        {
            PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField = this;
        }
        private void OnDestroy()
        {
            PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
        }
        private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyEventStoreDelegate.不东丟业上丄且丄世();
        }
        public static void UpdateState()
        {
            if((PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField.丘丁丟业丁三丐丗丑();
            PGCompany.LobbyEventStoreDelegate.<不丁丄七丛不丆丁丕>k__BackingField.丏丌不下丘丞丆七丞();
        }
        private void 丘丁丟业丁三丐丗丑()
        {
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            if(((FriendsController.丝丗专上三不丄丑丑() < 1) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)) || ((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且丟丌丑丘丕七专三(丁丅丈丌丟世丗丗丟:  40)) == false))
            {
                goto label_39;
            }
            
            val_23 = null;
            val_23 = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 == false)
            {
                goto label_13;
            }
            
            label_39:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  false);
            return;
            label_13:
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
            {
                goto label_39;
            }
            
            }
            
            val_24 = null;
            val_24 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_25;
            }
            
            val_25 = null;
            val_25 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 40.activeInHierarchy) == true)
            {
                goto label_39;
            }
            
            val_26 = null;
            val_26 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟 + 24.activeInHierarchy) == true)
            {
                goto label_39;
            }
            
            val_27 = null;
            val_27 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
            {
                goto label_39;
            }
            
            label_25:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._body, 丏业丟一东丂东丘丛:  true);
            System.TimeSpan val_11 = System.TimeSpan.FromSeconds(value:  0);
            System.Collections.Generic.List<TSource> val_14 = System.Linq.Enumerable.ToList<Rilisoft.业丙丘丆东丈丕丂丄>(source:  Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().丙丈丈东丟丟丒丄三(丁丅丈丌丟世丗丗丟:  40));
            val_28 = 0;
            goto label_47;
            label_53:
            System.Nullable<System.TimeSpan> val_16 = val_14.Item[0].丙世丑丅丒丑业与不();
            if(((-1872736096) & 1) != 0)
            {
                    double val_17 = val_16.HasValue.TotalSeconds;
                double val_18 = val_11._ticks.TotalSeconds;
            }
            
            val_28 = 1;
            label_47:
            if(val_28 < val_14.Count)
            {
                goto label_53;
            }
            
            string val_20 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_16.HasValue}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            if((System.String.op_Inequality(a:  this._timeLeft.Text, b:  val_20)) == false)
            {
                    return;
            }
            
            this._timeLeft.Text = val_20;
        }
        private void 丏丌不下丘丞丆七丞()
        {
            var val_11;
            var val_12;
            var val_13;
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                goto label_32;
            }
            
            val_11 = null;
            val_11 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_32;
            }
            
            val_12 = null;
            val_12 = null;
            if(activeInHierarchy == false)
            {
                goto label_32;
            }
            
            val_13 = null;
            val_13 = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 == false)
            {
                goto label_16;
            }
            
            label_32:
            if(this._collider == 0)
            {
                    return;
            }
            
            label_37:
            this._collider.enabled = false;
            return;
            label_16:
            if(BannerWindowController.与丅与丒丅专丙丐丗() != 0)
            {
                    if(BannerWindowController.与丅与丒丅专丙丐丗().丄丄丁丗且丐丘丟丅() == true)
            {
                goto label_32;
            }
            
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
            {
                goto label_32;
            }
            
            if(this._collider == 0)
            {
                    return;
            }
            
            if(this._collider != null)
            {
                goto label_37;
            }
            
            goto label_37;
        }
        public void U_Clicked()
        {
            var val_7;
            var val_8;
            if(BankController.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            .丛丟丌丝丈丞上丕丈 = 0;
            .丛丟丌丝丈丞上丕丈 = new System.EventHandler(object:  new LobbyEventStoreDelegate.丌丟丘丏丕丅七万丕(), method:  System.Void LobbyEventStoreDelegate.丌丟丘丏丕丅七万丕::万一专丂七东丆下万(object 丟业丏且丟七丞一丆, System.EventArgs 业丝丑丆上丆丌丙业));
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  (LobbyEventStoreDelegate.丌丟丘丏丕丅七万丕)[1152921554274110448].丛丟丌丝丈丞上丕丈);
            val_7 = null;
            val_7 = null;
            val_8 = null;
            val_8 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丟专丈丐万丁丌丆世;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  "EventStore", 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丟专丈丐万丁丌丆世);
            Rilisoft.一丟专且三万丞丁丂.一丞三丟丘专业丁东(丐业丝业万丞与一一:  "Lobby");
        }
        public LobbyEventStoreDelegate()
        {
        
        }
    
    }

}
