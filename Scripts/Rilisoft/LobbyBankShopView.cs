using UnityEngine;

namespace Rilisoft
{
    public class LobbyBankShopView : MonoBehaviour
    {
        // Fields
        private TweenColor _colorBlinkForX3;
        private UnityEngine.GameObject _normalStyle;
        private Rilisoft.TextGroup _timerTextGroup;
        private float _updateX3Delay;
        private UnityEngine.GameObject _X3TimeLabel;
        private UnityEngine.GameObject _animationHolder;
        private System.Collections.Generic.List<BankView.BankViewTab> _availableTabs;
        private UnityEngine.Coroutine 丛丄丙下丟专东与丑;
        private string 丆万丐不丝上下不丙;
        private UnityEngine.GameObject 丅丒七与上东不丛丒;
        
        // Methods
        private void Start()
        {
            X10Manager.丄专丂专丑一丂丙丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyBankShopView::丛丞万上世丙世与一()));
            丅且东丙业丏丛东丛.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyBankShopView::丛丞万上世丙世与一()));
            this.丛丞万上世丙世与一();
        }
        private static bool 丑丞且丌东世丒下七()
        {
            丅且东丙业丏丛东丛 val_1 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            丅且东丙业丏丛东丛 val_2 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
            if(val_2 != null)
            {
                    return val_2.丐且丘业丙丅丛丝丛();
            }
            
            return val_2.丐且丘业丙丅丛丝丛();
        }
        private static bool 世且丁业三丟丆丟一()
        {
            丅且东丙业丏丛东丛 val_1 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            丅且东丙业丏丛东丛 val_2 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世();
            if(val_2 != null)
            {
                    return val_2.丙专丘丄丝一丗丌丌();
            }
            
            return val_2.丙专丘丄丝一丗丌丌();
        }
        private static bool 且丌不丟世万与与丞()
        {
            if(Rilisoft.LobbyBankShopView.丑丞且丌东世丒下七() == false)
            {
                    return Rilisoft.LobbyBankShopView.世且丁业三丟丆丟一();
            }
            
            return true;
        }
        private void OnEnable()
        {
            var val_8;
            var val_9;
            val_8 = this;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._animationHolder, 丏业丟一东丂东丘丛:  false);
            val_8 = this.GetComponents<UIButton>();
            val_9 = 0;
            goto label_6;
            label_10:
            T val_8 = val_8[0];
            val_9 = 1;
            label_6:
            if(val_9 < val_2.Length)
            {
                goto label_10;
            }
            
            return;
            label_3:
            if(Rilisoft.LobbyBankShopView.丑丞且丌东世丒下七() != true)
            {
                    if(Rilisoft.LobbyBankShopView.世且丁业三丟丆丟一() == false)
            {
                goto label_13;
            }
            
            }
            
            if(this.丛丄丙下丟专东与丑 != null)
            {
                    this.StopCoroutine(routine:  this.丛丄丙下丟专东与丑);
            }
            
            this.丛丄丙下丟专东与丑 = this.StartCoroutine(routine:  this.且丝不丒丐丛丝万丅());
            return;
            label_13:
            if(this._timerTextGroup == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerTextGroup, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDestroy()
        {
            X10Manager.东丑三丐业业业丄业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyBankShopView::丛丞万上世丙世与一()));
            丅且东丙业丏丛东丛.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LobbyBankShopView::丛丞万上世丙世与一()));
        }
        private System.Collections.IEnumerator 且丝不丒丐丛丝万丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyBankShopView.丕丞丙丑丙丆丛上且();
        }
        private void 丝一丁丞丐业万丛东()
        {
            TweenColor val_19;
            var val_20;
            Rilisoft.TextGroup val_21;
            val_19 = this;
            if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛() == false)
            {
                goto label_4;
            }
            
            val_20 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().东不丟丁业丈不丟丆();
            if(val_20 != 0)
            {
                goto label_8;
            }
            
            label_4:
            if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌() == false)
            {
                goto label_16;
            }
            
            val_20 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().三三世丕丂专下丆世();
            label_8:
            if(val_20 >= 1)
            {
                    System.TimeSpan val_9 = System.TimeSpan.FromSeconds(value:  (double)val_20);
                val_21 = this._timerTextGroup;
                if(val_21 != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._timerTextGroup, 丏业丟一东丂东丘丛:  true);
                val_21 = this._timerTextGroup;
                val_21.Text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_9._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            }
            
                if(this._colorBlinkForX3 == 0)
            {
                    return;
            }
            
                if(this._colorBlinkForX3.enabled == true)
            {
                    return;
            }
            
                if(丅且东丙业丏丛东丛.丑七不且上丗丁一世().丐且丘业丙丅丛丝丛() != true)
            {
                    int val_17 = 与丂丏丛丞丞丒丟丄.上上东丑一与丙丆丒();
                if(val_9._ticks.TotalHours >= 0)
            {
                    return;
            }
            
            }
            
                val_19 = this._colorBlinkForX3;
                val_19.enabled = true;
                return;
            }
            
            label_16:
            if(this._timerTextGroup == 0)
            {
                    return;
            }
            
            val_19 = this._timerTextGroup;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_19, 丏业丟一东丂东丘丛:  false);
        }
        private void 丛丞万上世丙世与一()
        {
            var val_20;
            Rilisoft.TextGroup val_21;
            bool val_1 = Rilisoft.LobbyBankShopView.世且丁业三丟丆丟一();
            if(Rilisoft.LobbyBankShopView.丑丞且丌东世丒下七() != false)
            {
                    val_20 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            }
            else
            {
                    val_20 = 0;
            }
            
            if(val_20 == 0)
            {
                goto label_5;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._normalStyle, 丏业丟一东丂东丘丛:  false);
            string val_5 = X10Manager.丑七不且上丗丁一世().与丑丏丅下丁丏丟丛();
            if((this.丆万丐不丝上下不丙 != null) && ((System.String.op_Inequality(a:  this.丆万丐不丝上下不丙, b:  val_5)) != false))
            {
                    if(this.丅丒七与上东不丛丒 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.丅丒七与上东不丛丒);
                this.丅丒七与上东不丛丒 = 0;
            }
            
                this.丆万丐不丝上下不丙 = 0;
            }
            
            this.丆万丐不丝上下不丙 = val_5;
            if(this.丅丒七与上东不丛丒 != 0)
            {
                goto label_24;
            }
            
            this.丅丒七与上东不丛丒 = this.丒丂丗上一丆丞丗丑(丏东丆丆丛丄丕丈丞:  val_5);
            goto label_24;
            label_5:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._normalStyle, 丏业丟一东丂东丘丛:  true);
            this.丆万丐不丝上下不丙 = 0;
            if(this.丅丒七与上东不丛丒 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.丅丒七与上东不丛丒);
                this.丅丒七与上东不丛丒 = 0;
            }
            
            label_24:
            bool val_11 = val_1;
            val_11 = val_20 | val_11;
            if(val_11 == false)
            {
                goto label_27;
            }
            
            val_21 = this.gameObject;
            if(val_21.activeInHierarchy == false)
            {
                goto label_34;
            }
            
            if(this.丛丄丙下丟专东与丑 != null)
            {
                    this.StopCoroutine(routine:  this.丛丄丙下丟专东与丑);
            }
            
            this.丛丄丙下丟专东与丑 = this.StartCoroutine(routine:  this.且丝不丒丐丛丝万丅());
            goto label_34;
            label_27:
            val_21 = this._timerTextGroup;
            if(val_21 != 0)
            {
                    val_21 = this._timerTextGroup;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_21, 丏业丟一东丂东丘丛:  false);
            }
            
            label_34:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._X3TimeLabel, 丏业丟一东丂东丘丛:  val_1 & ((val_20 == 0) ? 1 : 0));
        }
        private void OnClick()
        {
            System.Collections.Generic.List<BankViewTab> val_15;
            string val_16;
            var val_17;
            var val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_15 = this;
            val_16 = 1152921504848912384;
            if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance) != 0)
            {
                    if((Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丄丆丑世东丏丐上丒()) == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if(ClanWarUI.丈丐丞丐上丑且丕万() == true)
            {
                goto label_18;
            }
            
            val_17 = null;
            val_17 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
            {
                goto label_13;
            }
            
            val_18 = null;
            val_18 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
            {
                goto label_18;
            }
            
            label_13:
            if((System.String.op_Equality(a:  val_5.m_Handle.name, b:  "FortFieldBuild")) == true)
            {
                goto label_18;
            }
            
            val_19 = 0;
            if((System.String.op_Equality(a:  val_5.m_Handle.name, b:  "ClanTankBuild")) == false)
            {
                goto label_19;
            }
            
            label_18:
            val_19 = "ClanSilver";
            label_19:
            val_20 = null;
            val_20 = null;
            val_16 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丑丛与丝丌业东丁下;
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丆丟丟七丗丂丏丒丐 != false)
            {
                    val_21 = null;
                val_21 = null;
                val_16 = PGCompany.Analytics.丂与丏丕一丒与丁丙.一下与下下不丁丂丄;
            }
            
            if(Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐() != false)
            {
                    val_22 = null;
                val_22 = null;
                val_16 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丕丕世世下上丌丞丘;
            }
            
            val_23 = null;
            val_23 = null;
            BankView.丗一专业丘丙丟丄万 = val_16;
            val_24 = null;
            val_24 = null;
            if((System.Linq.Enumerable.Any<BankViewTab>(source:  this._availableTabs)) == false)
            {
                goto label_33;
            }
            
            val_15 = this._availableTabs;
            if(MainMenuController.丄丞丁丈与业上丞丟 != null)
            {
                goto label_36;
            }
            
            goto label_35;
            label_33:
            val_15 = 0;
            if(MainMenuController.丄丞丁丈与业上丞丟 != null)
            {
                goto label_36;
            }
            
            label_35:
            label_36:
            MainMenuController.丄丞丁丈与业上丞丟.上世与丗丁丕丌丘上(丞丕东丒丝不下上丙:  true, 丆丟七丝丏业丅上丄:  val_19, 世丁丙世丄一万丆三:  val_16, 丐万丂丞万丌丐丞世:  val_15, 丁丕丈丏且丕丒丞丏:  false, 上不丗业一丛丈丞且:  0);
        }
        private UnityEngine.GameObject 丒丂丗上一丆丞丗丑(string 丏东丆丆丛丄丕丈丞)
        {
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            val_13 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/{0}", arg0:  System.String.Format(format:  "lobbyBank_x10_{0}", arg0:  丏东丆丆丛丄丕丈丞.ToLower())));
            if(val_13 == 0)
            {
                    val_13 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  System.String.Format(format:  "NguiWindows/CustomGui/lobbyBank_x10_{0}", arg0:  "basic"));
            }
            
            val_14 = 0;
            if(val_13 != 0)
            {
                    int val_10 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                val_14 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_13, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            if(val_14 != 0)
            {
                    return val_14;
            }
            
            val_14 = this._normalStyle;
            return val_14;
        }
        public LobbyBankShopView()
        {
            this._updateX3Delay = 0.5f;
            this._availableTabs = new System.Collections.Generic.List<BankViewTab>();
        }
    
    }

}
