using UnityEngine;

namespace Rilisoft
{
    public class LeprechauntLobbyView : MonoBehaviour
    {
        // Fields
        private const string 丂世丘丏丘丏丙与丌 = "RewardAvailable";
        private const string 丁与不一丂丏丘丌丄 = "GetReward";
        private const string 不丛一丟丑丁东东丛 = "Tap";
        internal static Rilisoft.LeprechauntLobbyView 丆丕丝丒不丙且丐丗;
        private UnityEngine.Animator _animator;
        private Rilisoft.LeprechauntLobbyHeader _header;
        private UnityEngine.GameObject _model;
        private UnityEngine.Vector3 丌丁丝丗丁丅东丗丘;
        private float 丈丑丛与丐东丙丞一;
        private bool 丑丁丘一上下丑专丌;
        
        // Methods
        public bool CanShow()
        {
            UnityEngine.Object val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            val_32 = Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance;
            if(val_32 != 0)
            {
                    System.Nullable<System.Int64> val_4 = Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.CurrentTime;
                if(( & 1) == 0)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_32 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if((val_32.丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
            {
                    return (bool)0 & 1;
            }
            
            if(ExperienceController.丞丞丘业东丙丏七丌() < 2)
            {
                    return (bool)0 & 1;
            }
            
            if(Rilisoft.AbstractGameEventGui.InterfaceEnabled == true)
            {
                    return (bool)0 & 1;
            }
            
            if(BattlePassRootUI.丑七不且上丗丁一世() != 0)
            {
                    val_32 = BattlePassRootUI.丑七不且上丗丁一世().gameObject;
                if(val_32.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_33 = null;
            val_33 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_34 = null;
                val_34 = null;
                val_32 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 40];
                val_32 = MainMenuController.丄丞丁丈与业上丞丟 + 40;
                if(val_32.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
                val_35 = null;
                val_35 = null;
                val_32 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
                val_32 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
                if(val_32.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
                val_36 = null;
                val_36 = null;
                val_32 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_32.一丑丟世丛丌丁下不() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(FeedbackMenuController.丑七不且上丗丁一世() != 0)
            {
                    val_32 = FeedbackMenuController.丑七不且上丗丁一世().gameObject;
                if(val_32.activeInHierarchy == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            val_37 = null;
            val_37 = null;
            val_32 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
            if(val_32 != 0)
            {
                    val_38 = null;
                val_38 = null;
                val_32 = Rilisoft.FortCraftController.丆丕丝丒不丙且丐丗;
                if(val_32.上丙丆不丂丂丄一丂() == true)
            {
                    return (bool)0 & 1;
            }
            
            }
            
            if(ConnectScene.丈丘丂丙不丛业丟三() != true)
            {
                    if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                goto label_61;
            }
            
            }
            
            return (bool)0 & 1;
            label_61:
            if(BankController.丑七不且上丗丁一世() == 0)
            {
                    return (bool)0 & 1;
            }
            
            bool val_32 = BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() ^ 1;
            return (bool)0 & 1;
        }
        private void Awake()
        {
            Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗 = this;
            Rilisoft.LeprechauntManager.丅丘世专与丞丟丏丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LeprechauntLobbyView::与东不丗丁且上万丟()));
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            this.丑丁丘一上下丑专丌 = false;
        }
        private void OnDestroy()
        {
            this.丑丁丘一上下丑专丌 = false;
            Rilisoft.LeprechauntLobbyView.丆丕丝丒不丙且丐丗 = 0;
            Rilisoft.LeprechauntManager.东丐且上丞万丌丒丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.LeprechauntLobbyView::与东不丗丁且上万丟()));
        }
        private void OnEnable()
        {
            this.丑丁丘一上下丑专丌 = false;
            this._model.SetActive(value:  ((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) > 0) ? 1 : 0);
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) < 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丕世丆丞三丞丒丏万());
        }
        private void Update()
        {
            if(this._animator.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            if(((this._animator.GetBool(name:  "RewardAvailable")) ^ (Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardIsReadyToDrop)) == false)
            {
                    return;
            }
            
            this._animator.SetBool(name:  "RewardAvailable", value:  Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardIsReadyToDrop);
        }
        private void 与东不丗丁且上万丟()
        {
            this._model.SetActive(value:  ((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) > 0) ? 1 : 0);
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) < 1)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丕世丆丞三丞丒丏万());
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  this.丕世丆丞三丞丒丏万());
        }
        private System.Collections.IEnumerator 丕世丆丞三丞丒丏万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LeprechauntLobbyView.丏丂丘下丏丑世丈丏();
        }
        private void 上丁丆三丗丛丝丐万(bool 下下东且万业丞丅丒)
        {
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            UnityEngine.Vector3 val_2 = this._model.transform.localPosition;
            if(下下东且万业丞丅丒 != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) == true)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_11 = val_6.x;
                val_12 = val_6.z;
                this._model.transform.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_6.y, z = val_12};
                val_13 = this._model.GetComponent<UnityEngine.Animator>();
                val_14 = 1;
            }
            else
            {
                    if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = this.丌丁丝丗丁丅东丗丘, y = V11.16B, z = V12.16B})) != false)
            {
                    return;
            }
            
                val_11 = this.丌丁丝丗丁丅东丗丘;
                this._model.transform.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_2.y, z = val_2.x};
                val_13 = this._model.GetComponent<UnityEngine.Animator>();
                val_14 = 0;
            }
            
            val_13.enabled = false;
        }
        private void 丑专三丄丟七丐世丘()
        {
            var val_26;
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.一与丘一不一不丟丁()) >= 1)
            {
                    if(this.丑丁丘一上下丑专丌 == false)
            {
                goto label_3;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.DaysLeft.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.RewardTimeLeft.gameObject, 丏业丟一东丂东丘丛:  false);
            label_42:
            label_56:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.GemsRewardAvailableGO, 丏业丟一东丂东丘丛:  false);
            return;
            label_3:
            System.Nullable<System.Int32> val_6 = Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.LeprechauntLifeTimeLeft;
            if(((-239132808) & 1) != 0)
            {
                    丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.DaysLeft.gameObject, 丏业丟一东丂东丘丛:  true);
                System.Nullable<System.Int32> val_9 = Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.LeprechauntLifeTimeLeft;
                this._header.DaysLeft.Text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2913"), arg0:  -3647);
            }
            
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardIsReadyToDrop) == false)
            {
                goto label_24;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.GemsRewardAvailableGO, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.RewardTimeLeft.gameObject, 丏业丟一东丂东丘丛:  false);
            this._header.GemsRewardAvailable.Text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2914"), arg0:  Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardReadyToDrop);
            val_26 = null;
            val_26 = null;
            if((System.String.op_Equality(a:  Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.专丑一丝丘丂东下丄(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_38;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.GemsIcon, 丏业丟一东丂东丘丛:  true);
            if(this._header != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_24:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.GemsRewardAvailableGO, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.RewardTimeLeft.gameObject, 丏业丟一东丂东丘丛:  true);
            System.Nullable<System.Single> val_24 = Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardDropSecsLeft;
            this._header.RewardTimeLeft.Text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  (int)V0.16B, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            return;
            label_38:
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.GemsIcon, 丏业丟一东丂东丘丛:  false);
            if(this._header != null)
            {
                goto label_56;
            }
            
            goto label_56;
        }
        private void 丌丌丈专丝世丏三上()
        {
            if(this._header.gameObject.activeSelf == true)
            {
                    return;
            }
            
            if(this.丈丑丛与丐东丙丞一 < 0)
            {
                    this.丈丑丛与丐东丙丞一 = UnityEngine.Time.realtimeSinceStartup;
            }
            
            float val_6 = this.丈丑丛与丐东丙丞一;
            val_6 = val_6 + 1f;
            if(UnityEngine.Time.realtimeSinceStartup <= val_6)
            {
                    return;
            }
            
            this._header.gameObject.SetActive(value:  true);
            this.丈丑丛与丐东丙丞一 = -1f;
        }
        private void 一上与丙专丒与丟丞()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void Tap()
        {
            UnityEngine.Animator val_6;
            string val_7;
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 != 0)
            {
                    if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂() == true)
            {
                    return;
            }
            
            }
            
            if(this.丑丁丘一上下丑专丌 != false)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.RewardIsReadyToDrop) != false)
            {
                    this.丑丁丘一上下丑专丌 = true;
                this.StopCoroutine(methodName:  "MainLoopCoroutine");
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._header.gameObject, 丏业丟一东丂东丘丛:  false);
                val_6 = this._animator;
                val_7 = "GetReward";
            }
            else
            {
                    val_6 = this._animator;
                val_7 = "Tap";
            }
            
            val_6.SetTrigger(name:  val_7);
        }
        public void OnAnimatorStateExit(string 丕丆丂丛丐三丙丐万)
        {
            if((System.String.op_Equality(a:  丕丆丂丛丐三丙丐万, b:  "Close")) == false)
            {
                    return;
            }
            
            this.丑丁丘一上下丑专丌 = false;
            this._animator.SetBool(name:  "RewardAvailable", value:  false);
            Rilisoft.Singleton<Rilisoft.LeprechauntManager>.Instance.DropReward();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丕世丆丞三丞丒丏万());
        }
        public LeprechauntLobbyView()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  10000f);
            this.丌丁丝丗丁丅东丗丘 = val_2;
            mem[1152921543023311556] = val_2.y;
            mem[1152921543023311560] = val_2.z;
            this.丈丑丛与丐东丙丞一 = -1f;
        }
    
    }

}
