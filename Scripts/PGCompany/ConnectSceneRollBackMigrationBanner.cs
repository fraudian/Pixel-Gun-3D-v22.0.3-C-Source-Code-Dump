using UnityEngine;

namespace PGCompany
{
    internal sealed class ConnectSceneRollBackMigrationBanner : BannerWindow
    {
        // Fields
        private System.Collections.Generic.Dictionary<PGCompany.ConnectSceneRollBackMigrationBanner.丟丕丘丄一丞丂且丛, int> 丘七丟丐丂丂丈丛丏;
        private SlidesScrollController slidesScroll;
        private int seconds;
        private PGCompany.TimerUI timer;
        private UIButton nextBtn;
        private UIButton convertBtn;
        private UnityEngine.GameObject dev;
        private UnityEngine.GameObject rewardBtn;
        private PGCompany.ConnectSceneRollBackMigrationBanner.BaseSlideProps baseSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.ConnectSceneSlideProps connectSceneSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.LeaguesSlideProps leaguesSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.LeaguesRewardSlideProps leaguesRewardSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.ChestsSlideProps chestsSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.ChestsRewardSlideProps chestsRewardSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.BoosterSlideProps boosterSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.BoosterRewardSlideProps boosterRewardSlideProps;
        private PGCompany.ConnectSceneRollBackMigrationBanner.GiftSlideProps giftSlideProps;
        private int 一丅丅丘且丏丐丙东;
        private System.IDisposable 专丏业专不丂一丂丛;
        
        // Properties
        private static bool 丙丏东且丌丆丌丒三 { get; }
        internal static bool 丕世一与业丅万专丑 { get; }
        
        // Methods
        internal static bool 丑丒丌丘丝七与丂丞()
        {
            var val_3;
            var val_4;
            if(PGCompany.ConnectSceneRollBackMigrationBanner.丌七丘七丗下丐七丞() != false)
            {
                    val_3 = BannerWindowController.与丅与丒丅专丙丐丗();
                val_3.ForceShowBanner(丌丅丕一丛丛丄一万:  2, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
                val_4 = 1;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private static bool 七丙东七丅东专丈世()
        {
            Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  58);
            }
            
            return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  58);
        }
        internal static bool 丌七丘七丗下丐七丞()
        {
            var val_10;
            var val_11;
            if((与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true) && (PGCompany.ConnectSceneRollBackMigrationBanner.七丙东七丅东专丈世() != false))
            {
                    val_10 = PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世();
                if(val_10.丆丝万丐且业丂丐丟() != false)
            {
                    if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  125)) == false)
            {
                    return (bool)val_11;
            }
            
                val_10 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
                var val_9 = ((val_10.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  125)) != 1) ? 1 : 0;
                return (bool)val_11;
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        public override void Show()
        {
            var val_17;
            UnityEngine.GameObject val_18;
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  125)) != false)
            {
                    val_17 = 1;
            }
            else
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  11);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  125, 丙业与丙丗丝不丈东:  0);
                PGCompany.三东丏不丗世丅丌丄 val_5 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  151002);
                if(val_5.丕丐一丙专丛丒丑万() != false)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_7 = val_5.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  1);
                PGCompany.丗丟丄丈东丝丕丄世 val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_5, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            }
            
                val_17 = 0;
            }
            
            int val_11 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  125);
            this.一丅丅丘且丏丐丙东 = val_11;
            this.slidesScroll.丂丂七丗丘丏丏东丁 = val_11;
            this.slidesScroll.丝丘下业丟丌七丈丌(丙业与丙丗丝不丈东:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.ConnectSceneRollBackMigrationBanner::不专业丛专丛丐丟上()));
            this.baseSlideProps.丈且东丑丂且万丒丅();
            this.leaguesSlideProps.丈且东丑丂且万丒丅();
            this.leaguesRewardSlideProps.丈且东丑丂且万丒丅();
            this.chestsSlideProps.丈且东丑丂且万丒丅();
            this.chestsRewardSlideProps.丈且东丑丂且万丒丅();
            this.boosterRewardSlideProps.丈且东丑丂且万丒丅();
            System.Action val_13 = new System.Action(object:  this, method:  System.Void PGCompany.ConnectSceneRollBackMigrationBanner::丅丘丅丒业三且丏丁());
            this.boosterSlideProps.丈且东丑丂且万丒丅(丑丗丂丈丐丅丁下丝:  val_13);
            this.giftSlideProps.丈且东丑丂且万丒丅(丈丁丅丈丌三丕七丗:  val_13);
            this.七丄专一世丁丆世丐();
            this.下东七丝世丟丌与七();
            this.不专业丛专丛丐丟上();
            this.Show();
            this.一万丕丑世丆七丟世();
            val_18 = this.dev;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  false);
            if((val_17 & 1) != 0)
            {
                    return;
            }
            
            PGCompany.丗丅与不丛专丏丙丗.丑七不且上丗丁一世().下丕世且不丄丂且丏().世丙丝业丁三丏丗三();
            val_18 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_18.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public override void Hide()
        {
            this.丁丅丟丆丂丗专丕丄();
            this.Hide();
        }
        public void End()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  125, 丙业与丙丗丝不丈东:  0);
        }
        public void OnNextSlide()
        {
            int val_2 = this.一丅丅丘且丏丐丙东;
            val_2 = val_2 + 1;
            this.一丅丅丘且丏丐丙东 = val_2;
            this.七丄专一世丁丆世丐();
            this.下东七丝世丟丌与七();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  125, 丙业与丙丗丝不丈东:  this.一丅丅丘且丏丐丙东);
        }
        public void U_Convert()
        {
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  2)) != false)
            {
                    this.leaguesSlideProps.一丏丕丅丐丑且丏丐(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  4)) != false)
            {
                    this.chestsSlideProps.一丏丕丅丐丑且丏丐(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  6)) == false)
            {
                    return;
            }
            
            this.boosterSlideProps.一丏丕丅丐丑且丏丐(丈丁丅丈丌三丕七丗:  this);
        }
        private void 下东七丝世丟丌与七()
        {
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  0)) != false)
            {
                    0.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  1)) != false)
            {
                    0.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  2)) != false)
            {
                    this.leaguesSlideProps.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  3)) != false)
            {
                    this.leaguesRewardSlideProps.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  4)) != false)
            {
                    0.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  5)) != false)
            {
                    this.chestsRewardSlideProps.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  6)) != false)
            {
                    0.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  7)) != false)
            {
                    this.boosterRewardSlideProps.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
            }
            
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  8)) == false)
            {
                    return;
            }
            
            this.giftSlideProps.业丏丑丌一丛丞丌与(丈丁丅丈丌三丕七丗:  this);
        }
        private void 不专业丛专丛丐丟上()
        {
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  0)) != false)
            {
                    this.baseSlideProps.丟丗丟业丝一一丑与();
            }
            
            bool val_2 = this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  1);
            bool val_3 = this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  2);
            bool val_4 = this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  3);
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  4)) != false)
            {
                    this.chestsSlideProps.丟丗丟业丝一一丑与();
            }
            
            bool val_6 = this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  5);
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  6)) != false)
            {
                    this.boosterSlideProps.丟丗丟业丝一一丑与();
            }
            
            bool val_8 = this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  7);
            if((this.一丆业东下丈丙一丂(丏丛与丅丛丌万专丌:  8)) == false)
            {
                    return;
            }
            
            this.giftSlideProps.丟丗丟业丝一一丑与();
        }
        private bool 一丆业东下丈丙一丂(PGCompany.ConnectSceneRollBackMigrationBanner.丟丕丘丄一丞丂且丛 丏丛与丅丛丌万专丌)
        {
            var val_4;
            if((this.丘七丟丐丂丂丈丛丏.TryGetValue(key:  丏丛与丅丛丌万专丌, value: out  0)) != false)
            {
                    var val_3 = (0 == this.一丅丅丘且丏丐丙东) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private void 一丘丗丕丞业且且丞()
        {
            this.七丄专一世丁丆世丐();
        }
        private void 七丄专一世丁丆世丐()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timer, 丏业丟一东丂东丘丛:  false);
        }
        private void 丒不一丟业丗丑世丁()
        {
            this.slidesScroll.NextSlide();
            this.OnNextSlide();
        }
        private void 丑世丐三丞且且丝业()
        {
            this.OnNextSlide();
            this.slidesScroll.CenterOnByIndex(丞世不丒下上上丝丑:  this.一丅丅丘且丏丐丙东, 丌丝丌丁下丐丞丆一:  true);
            this.不专业丛专丛丐丟上();
        }
        private static System.Collections.IEnumerator 丒三丐丈丏丄丝一丂(float 丂三丟丂丈丐丆丗丟, System.Action 丟丕丞丂一丙不丅丝)
        {
            ConnectSceneRollBackMigrationBanner.与一丞丆与丌丁东丏 val_1 = new ConnectSceneRollBackMigrationBanner.与一丞丆与丌丁东丏();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
            }
            else
            {
                    mem[32] = 丂三丟丂丈丐丆丗丟;
            }
            
            .丟丕丞丂一丙不丅丝 = 丟丕丞丂一丙不丅丝;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 一万丕丑世丆七丟世()
        {
            this.丁丅丟丆丂丗专丕丄();
            this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "ConnectSceneRollBackMigrationBanner");
        }
        private void 丁丅丟丆丂丗专丕丄()
        {
            if(this.专丏业专不丂一丂丛 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        public ConnectSceneRollBackMigrationBanner()
        {
            System.Collections.Generic.Dictionary<丟丕丘丄一丞丂且丛, System.Int32> val_1 = new System.Collections.Generic.Dictionary<丟丕丘丄一丞丂且丛, System.Int32>();
            if(val_1 != null)
            {
                    val_1.Add(key:  0, value:  0);
                val_1.Add(key:  1, value:  1);
                val_1.Add(key:  2, value:  2);
                val_1.Add(key:  3, value:  3);
                val_1.Add(key:  4, value:  4);
                val_1.Add(key:  5, value:  5);
                val_1.Add(key:  6, value:  6);
                val_1.Add(key:  7, value:  7);
            }
            else
            {
                    val_1.Add(key:  0, value:  0);
                val_1.Add(key:  1, value:  1);
                val_1.Add(key:  2, value:  2);
                val_1.Add(key:  3, value:  3);
                val_1.Add(key:  4, value:  4);
                val_1.Add(key:  5, value:  5);
                val_1.Add(key:  6, value:  6);
                val_1.Add(key:  7, value:  7);
            }
            
            val_1.Add(key:  8, value:  8);
            this.丘七丟丐丂丂丈丛丏 = val_1;
            this.seconds = 5;
        }
        private void 丅丘丅丒业三且丏丁()
        {
            var val_6;
            bool val_1 = this.丘七丟丐丂丂丈丛丏.Remove(key:  6);
            bool val_2 = this.丘七丟丐丂丂丈丛丏.Remove(key:  7);
            if(this.丘七丟丐丂丂丈丛丏 != null)
            {
                    val_6 = this.丘七丟丐丂丂丈丛丏.Item[8];
            }
            else
            {
                    val_6 = 0.Item[8];
            }
            
            this.丘七丟丐丂丂丈丛丏.set_Item(key:  8, value:  val_6 - 2);
        }
    
    }

}
