using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassReminderGiveRewardsUI : BannerWindow
    {
        // Fields
        internal static PGCompany.BattlePass.BattlePassReminderGiveRewardsUI 丄丘七三上丕世丞业;
        private static System.Action 业丙丘丈七不下下丐;
        private static System.Action 丛丄业丘不丆丄三丞;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UILabel _expLabel;
        private UILabel _currentLevelLabel;
        private UILabel _gettingLevelLabel;
        private UILabel _gettingLevelTextLabel;
        
        // Methods
        internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐 != 1152921505683578888);
        
        }
        internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐 != 1152921505683578888);
        
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞 != 1152921505683578896);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞 != 1152921505683578896);
        
        }
        private void Awake()
        {
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丄丘七三上丕世丞业 = this;
        }
        private void 丌专丏专业丌不丂丝()
        {
            int val_14;
            int val_15;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            val_14 = PGCompany.BattlePass.万丈上下三丅丘丛丒.丂不丄与丅丑万丏业();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._expLabel, 丕丗丘丑丛与丑业丒:  val_14);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._currentLevelLabel, 丕丗丘丑丛与丑业丒:  val_2.业丈丅丂且丁与丄丂());
            val_15 = val_2.业丈丅丂且丁与丄丂() - 1;
            label_6:
            int val_6 = val_15 + 2;
            if(val_6 > val_2.丄且东且丕丛与丆丒())
            {
                goto label_5;
            }
            
            val_15 = val_15 + 1;
            if((val_2.丞丆丝七丛世且丒专(丈丘丝一丗下丈丐不:  val_6)) <= val_14)
            {
                goto label_6;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gettingLevelLabel, 丕丗丘丑丛与丑业丒:  val_15);
            val_14 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6805");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gettingLevelTextLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_14, arg0:  val_15));
            label_5:
            UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  this._gettingLevelTextLabel.丟丛丛丝丑丛业三万());
        }
        private System.Collections.IEnumerator 丟丛丛丝丑丛业三万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new BattlePassReminderGiveRewardsUI.丕丄丈丒丁七丞业世();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.丌专丏专业丌不丂丝();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.BattlePass.BattlePassReminderGiveRewardsUI::U_Hide()), 与且专丈不万东一万:  0);
            if(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.业丙丘丈七不下下丐.Invoke();
        }
        protected override void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.OnDisable();
            if(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丛丄业丘不丆丄三丞.Invoke();
        }
        public override void HideSelf()
        {
            this.HideSelf();
        }
        public void U_Hide()
        {
            goto typeof(PGCompany.BattlePass.BattlePassReminderGiveRewardsUI).__il2cppRuntimeField_208;
        }
        private void OnDestroy()
        {
            PGCompany.BattlePass.BattlePassReminderGiveRewardsUI.丄丘七三上丕世丞业 = 0;
        }
        public BattlePassReminderGiveRewardsUI()
        {
        
        }
    
    }

}
