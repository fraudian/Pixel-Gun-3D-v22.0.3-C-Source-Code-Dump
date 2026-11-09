using UnityEngine;

namespace Rilisoft
{
    public class RollbackEggsAndTournamentBannerWindow : BannerWindow
    {
        // Fields
        private UnityEngine.GameObject _tournamentWithReward;
        private UILabel _tournamentWithRewardText;
        private UITable _tournamentWithRewardTable;
        private UILabel _tournamentWithRewardGems;
        private UILabel _tournamentWithRewardCoins;
        private UIBasicSprite _eggTexture;
        private UnityEngine.GameObject _tournamentWithoutReward;
        private UILabel _tournamentWithoutRewardText;
        private UnityEngine.GameObject _pets;
        private UILabel _petsText;
        private Rilisoft.EggsMigrationView _eggsMigrationView;
        private static Rilisoft.RollbackEggsAndTournamentBannerWindow 丝业丆丁业三丈丟东;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private static Rilisoft.且丈丞一丞丟与上七 丐与丒丌业专专丛上;
        private static Rilisoft.RollbackEggsAndTournamentBannerWindow.丂与丈丄丄丐丆世丛 丅丄业丁丐丒丂丏三;
        private static System.Version 世业专上与万一丂一;
        private UnityEngine.Coroutine 专世下东东丛丁上丙;
        
        // Properties
        internal static bool 业丗丝万专万丞丟上 { get; }
        
        // Methods
        protected override void Awake()
        {
            var val_1;
            this.Awake();
            val_1 = null;
            val_1 = null;
            Rilisoft.RollbackEggsAndTournamentBannerWindow.丝业丆丁业三丈丟东 = this;
        }
        protected override void OnDestroy()
        {
            var val_2 = null;
            Rilisoft.RollbackEggsAndTournamentBannerWindow.丝业丆丁业三丈丟东 = 0;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.OnDestroy();
        }
        protected override void OnEnable()
        {
            var val_6;
            this.OnEnable();
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            Rilisoft.BackSystem val_2 = Rilisoft.BackSystem.丑七不且上丗丁一世();
            val_6 = null;
            val_6 = null;
            if((RollbackEggsAndTournamentBannerWindow.<>c.<>9__15_0) == null)
            {
                goto label_10;
            }
            
            label_16:
            this.丐丆七且丞丏下三丙 = val_2.Register(业丏丈世世世丞丒世:  RollbackEggsAndTournamentBannerWindow.<>c.<>9__15_0, 与且专丈不万东一万:  0);
            return;
            label_10:
            RollbackEggsAndTournamentBannerWindow.<>c.<>9__15_0 = new System.Action(object:  RollbackEggsAndTournamentBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void RollbackEggsAndTournamentBannerWindow.<>c::七丟丈七上与万丐丕());
            if(val_2 != null)
            {
                goto label_16;
            }
            
            goto label_16;
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
        }
        internal static bool 丂丙上且不丟业丛丒()
        {
            return false;
        }
        internal static void 丂丑丑丛丏丛丒丈丁()
        {
            null = null;
            int val_1 = Rilisoft.RollbackEggsAndTournamentBannerWindow.丐与丒丌业专专丛上.世三丞丅丑丌丈丈一();
            Rilisoft.RollbackEggsAndTournamentBannerWindow.丅丄业丁丐丒丂丏三 = 30;
        }
        private static Rilisoft.RollbackEggsAndTournamentBannerWindow.丂与丈丄丄丐丆世丛 上不丑不丅且丙东丗()
        {
            return 30;
        }
        public override void Show()
        {
            this.Show();
            if(this.专世下东东丛丁上丙 != null)
            {
                    this.StopCoroutine(routine:  this.专世下东东丛丁上丙);
            }
            
            this.专世下东东丛丁上丙 = this.StartCoroutine(routine:  this.丄与丞丈丁东丂下专());
        }
        private System.Collections.IEnumerator 丄与丞丈丁东丂下专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new RollbackEggsAndTournamentBannerWindow.东专一丄七丕丙且丆();
        }
        protected override void 万万丄丌与丐丘东三(BannerWindowType 世丌丒丌上丗丛丈丒)
        {
            null = null;
            Rilisoft.RollbackEggsAndTournamentBannerWindow.丐与丒丌业专专丛上.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  1);
            this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  世丌丒丌上丗丛丈丒);
        }
        public void U_HideTornament()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tournamentWithReward, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tournamentWithoutReward, 丏业丟一东丂东丘丛:  false);
        }
        public void U_HidePets()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._pets, 丏业丟一东丂东丘丛:  false);
        }
        public void U_HidePetsMigration()
        {
            if(this._eggsMigrationView == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._eggsMigrationView, 丏业丟一东丂东丘丛:  false);
        }
        public RollbackEggsAndTournamentBannerWindow()
        {
        
        }
        private static RollbackEggsAndTournamentBannerWindow()
        {
            Rilisoft.RollbackEggsAndTournamentBannerWindow.丐与丒丌业专专丛上 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "TournamentMigrateBannerWindow_ToV1-viewed");
            Rilisoft.RollbackEggsAndTournamentBannerWindow.世业专上与万一丂一 = new System.Version(version:  "14.1.2");
        }
    
    }

}
