using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassLobbyButton : MonoBehaviour
    {
        // Fields
        private static PGCompany.BattlePass.BattlePassLobbyButton <不丁丄七丛不丆丁丕>k__BackingField;
        private static Rilisoft.且丈丞一丞丟与上七 丂丘丆丛万丏与丑丛;
        internal string 三丘三丁丟七丞丈丐;
        private PGCompany.BattlePass.上丕丁专三丗丝万丆 世丝丌下且世与丞丈;
        private System.Action 万且丆丈万下不东七;
        private System.Collections.Generic.List<UILabel> _timerLabels;
        private UILabel _levelFreeLabel;
        private UILabel _levelPaidLabel;
        private UILabel _progressLabel;
        private UISprite _progressSprite;
        private UIGrid _gridBadges;
        private UnityEngine.GameObject _freeObject;
        private UnityEngine.GameObject _paidObject;
        private UnityEngine.GameObject _hasBpRewardsObject;
        private UnityEngine.GameObject _hasChallengeRewardsObject;
        private UnityEngine.GameObject _tutorialObject;
        private UnityEngine.GameObject _hint;
        private UnityEngine.GameObject _isNewMark;
        private UnityEngine.GameObject _blockPanel;
        private UnityEngine.GameObject _reminderWidget;
        
        // Properties
        internal static PGCompany.BattlePass.BattlePassLobbyButton 丆丕丝丒不丙且丐丗 { get; set; }
        internal static bool 东丆不丒丒丑与丙专 { get; }
        internal static bool 丐丒丁上万丕不丟世 { get; }
        
        // Methods
        internal static PGCompany.BattlePass.BattlePassLobbyButton 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.BattlePass.BattlePassLobbyButton)PGCompany.BattlePass.BattlePassLobbyButton.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BattlePassLobbyButton 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.BattlePass.BattlePassLobbyButton.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丘丌世丆与且丏世丒()
        {
            null = null;
            if(PGCompany.BattlePass.BattlePassLobbyButton.丂丘丆丛万丏与丑丛.世三丞丅丑丌丈丈一() != 0)
            {
                    return false;
            }
            
            if(HintController.下一丌专专丐下不丕() != false)
            {
                    return false;
            }
            
            BattlePassController val_3 = Rilisoft.Singleton<BattlePassController>.Instance;
            if(val_3 != null)
            {
                    return val_3.专丁丟丏丁丏不丗三();
            }
            
            return val_3.专丁丟丏丁丏不丗三();
        }
        public void add_OnClick(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.万且丆丈万下不东七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万且丆丈万下不东七 != 1152921560091797144);
        
        }
        public void remove_OnClick(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.万且丆丈万下不东七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.万且丆丈万下不东七 != 1152921560091933720);
        
        }
        internal static bool 下丛丞丈业东七丟丙()
        {
            UnityEngine.Object val_6;
            var val_7;
            val_6 = PGCompany.BattlePass.BattlePassLobbyButton.丑七不且上丗丁一世();
            if(val_6 == 0)
            {
                goto label_5;
            }
            
            PGCompany.BattlePass.BattlePassLobbyButton val_3 = PGCompany.BattlePass.BattlePassLobbyButton.丑七不且上丗丁一世();
            val_6 = val_3._hint;
            if(val_6.activeSelf == false)
            {
                goto label_10;
            }
            
            val_7 = 1;
            return (bool)val_7;
            label_5:
            val_7 = 0;
            return (bool)val_7;
            label_10:
            PGCompany.BattlePass.BattlePassLobbyButton val_5 = PGCompany.BattlePass.BattlePassLobbyButton.丑七不且上丗丁一世();
            if(val_5._tutorialObject != null)
            {
                    return val_5._tutorialObject.activeSelf;
            }
            
            return val_5._tutorialObject.activeSelf;
        }
        private void Start()
        {
            BattlePassController.丙七一丄下专丏不丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::上且万专一东东东不()));
            PGCompany.BattlePass.BattlePassLobbyButton.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        }
        private void OnEnable()
        {
            var val_20;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_22;
            var val_23;
            var val_24;
            var val_25;
            PGCompany.BattlePass.上丕丁专三丗丝万丆.丛丒丂世且不丂丝丐(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
            if(BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂().Count < 1)
            {
                goto label_20;
            }
            
            val_20 = null;
            val_20 = null;
            val_22 = BattlePassLobbyButton.<>c.<>9__15_0;
            if(val_22 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_9 = null;
                val_22 = val_9;
                val_9 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassLobbyButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassLobbyButton.<>c::七丟丈七上与万丐丕(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassLobbyButton.<>c.<>9__15_0 = val_22;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_10 = System.Linq.Enumerable.First<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  BPChallengesController.丑七不且上丗丁一世().丄丄丆东丑三丝专丂(), predicate:  val_9);
            if((val_10 == null) || (val_10.丄上丝丌上下丒上丙().业丑丁丆丕丆丂丅万().世丑丐丅丆丂丘不丁() == false))
            {
                goto label_20;
            }
            
            val_23 = null;
            if(PGCompany.BattlePass.BattlePassLobbyButton.丘丌世丆与且丏世丒() == false)
            {
                goto label_20;
            }
            
            val_24 = null;
            val_24 = null;
            val_25 = 1;
            PGCompany.BattlePass.BattlePassLobbyButton.丂丘丆丛万丏与丑丛.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  1);
            goto label_24;
            label_20:
            val_25 = 0;
            label_24:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hint, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialObject, 丏业丟一东丂东丘丛:  false);
            if(this._isNewMark != 0)
            {
                    PGCompany.BattlePass.三丛上丁丗丌丆丌东.下丏且丞丈丐丅不东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与下丐东丙丟丘丑丕()));
                BPChallengesController.下专丒丌与丙不一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与下丐东丙丟丘丑丕()));
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.万专丆且七丈业丅丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::下东东上丟丒丒丌丁()));
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丈丗丐丗丛丝丕丙一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::丁丈不东丟东丌万与()));
        }
        private void 与下丐东丙丟丘丑丕()
        {
            var val_15;
            var val_16;
            val_15 = this;
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            if(PGCompany.BattlePass.万丈上下三丅丘丛丒.丈丟丒丏丝东丕三下().Count <= 0)
            {
                goto label_5;
            }
            
            val_16 = 1;
            if(this._isNewMark != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            this._isNewMark.SetActive(value:  true);
            if(this._gridBadges == 0)
            {
                    return;
            }
            
            val_15 = ???;
            val_16 = ???;
            goto typeof(UIGrid).__il2cppRuntimeField_1A8;
            label_5:
            var val_14 = (PGCompany.BattlePass.万丈上下三丅丘丛丒.上专丘世丘丂丝上丐().Count > 0) ? 1 : 0;
            if(this._isNewMark != null)
            {
                goto label_12;
            }
            
            goto label_13;
        }
        private void 丝丞丒万丅丑一丂丆()
        {
            PGCompany.BattlePass.BPTutorialController.丙丌下丈下丅丕不丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::丝丞丒万丅丑一丂丆()));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tutorialObject, 丏业丟一东丂东丘丛:  false);
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BattlePassLobbyButton.丛丙上丒丗丒丕丒丕();
        }
        private void 丘丟万丌丄三丏丈业()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_19 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(this.世丝丌下且世与丞丈 != val_19)
            {
                    this.世丝丌下且世与丞丈 = val_19;
                this.丙且丛丘业丑丛丙丄();
            }
            
            if(val_19 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hasBpRewardsObject, 丏业丟一东丂东丘丛:  val_19.东东丒不下丆世业不());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hasChallengeRewardsObject, 丏业丟一东丂东丘丛:  BPChallengesController.丑七不且上丗丁一世().丄三丞丟丝东业业丌());
            bool val_8 = UnityEngine.Object.op_Inequality(x:  this._gridBadges, y:  0);
            if(this._timerLabels == null)
            {
                    return;
            }
            
            if(val_19.丗丄上丑丑丅丐丒丌() != false)
            {
                    if(val_19.丌丈一丘上丕丏东丛() == false)
            {
                goto label_15;
            }
            
            }
            
            System.Nullable<System.TimeSpan> val_11 = val_19.丙世丑丅丒丑业与不();
            if(( & 1) == 0)
            {
                goto label_16;
            }
            
            string val_12 = 专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
            goto label_19;
            label_15:
            label_19:
            label_16:
            val_19 = 0;
            goto label_22;
            label_32:
            UILabel val_14 = this._timerLabels.Item[0];
            if(val_14 != 0)
            {
                    if(val_14.gameObject.activeSelf != false)
            {
                    val_14.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2168");
            }
            
            }
            
            val_19 = 1;
            label_22:
            if(val_19 < this._timerLabels.Count)
            {
                goto label_32;
            }
        
        }
        private void 上且万专一东东东不()
        {
            this.丘丟万丌丄三丏丈业();
        }
        private void 与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)
        {
            this.丙且丛丘业丑丛丙丄();
        }
        private void 丙且丛丘业丑丛丙丄()
        {
            UISprite val_12;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            this.上不丕下丙丁丁业丆(丈丘丝一丗下丈丐不:  val_2.业丈丅丂且丁与丄丂());
            int val_4 = val_2.丞专三世丑丗丘专丐();
            int val_5 = val_2.一不丁丏万丂丑三不();
            if(this._progressLabel != 0)
            {
                    this._progressLabel.text = System.String.Format(format:  "{0}/{1}", arg0:  val_4, arg1:  val_5);
            }
            
            val_12 = this._progressSprite;
            if(val_12 != 0)
            {
                    val_12 = this._progressSprite;
                float val_12 = (float)val_4;
                val_12 = val_12 / (float)val_5;
                val_12 = 1f - val_12;
                val_12.fillAmount = val_12;
            }
            
            PlayerPaymentState val_9 = val_2.专丟专一丒且丘与丌();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeObject, 丏业丟一东丂东丘丛:  (val_9 != 100) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._paidObject, 丏业丟一东丂东丘丛:  (val_9 == 100) ? 1 : 0);
        }
        private void 上不丕下丙丁丁业丆(int 丈丘丝一丗下丈丐不)
        {
            if(this._levelFreeLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._levelFreeLabel, 丕丗丘丑丛与丑业丒:  丈丘丝一丗下丈丐不.ToString());
            }
            
            if(this._levelPaidLabel == 0)
            {
                    return;
            }
            
            this = this._levelPaidLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  丈丘丝一丗下丈丐不.ToString());
        }
        private void OnDisable()
        {
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
            if(this._isNewMark != 0)
            {
                    PGCompany.BattlePass.三丛上丁丗丌丆丌东.下且丅丟且丄丌业丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与下丐东丙丟丘丑丕()));
                BPChallengesController.与万丟不丝丗丒东丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与下丐东丙丟丘丑丕()));
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丟丑丟丑丂丄丕丆丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::下东东上丟丒丒丌丁()));
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::丁丈不东丟东丌万与()));
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BattlePassLobbyButton.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
            BattlePassController.业丏专与丝不东丁一(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::上且万专一东东东不()));
            PGCompany.BattlePass.上丕丁专三丗丝万丆.专且丈丕丄且丂丒业(丙业与丙丗丝不丈东:  new System.Action<丘丂丐世专丂下丞丈, System.Object>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassLobbyButton::与与与丏万丌万业丄(PGCompany.BattlePass.上丕丁专三丗丝万丆.丘丂丐世专丂下丞丈 世丁丙世丄一万丆三, object 万且万且丑丗且丌丆)));
        }
        private void 下东东上丟丒丒丌丁()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blockPanel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reminderWidget, 丏业丟一东丂东丘丛:  true);
        }
        private void 丁丈不东丟东丌万与()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._blockPanel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._reminderWidget, 丏业丟一东丂东丘丛:  false);
        }
        public BattlePassLobbyButton()
        {
        
        }
        private static BattlePassLobbyButton()
        {
            PGCompany.BattlePass.BattlePassLobbyButton.丂丘丆丛万丏与丑丛 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "BattlePassLobbyButton-_hitViewed");
        }
    
    }

}
