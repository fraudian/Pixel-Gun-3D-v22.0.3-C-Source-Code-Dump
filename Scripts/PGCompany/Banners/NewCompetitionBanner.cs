using UnityEngine;

namespace PGCompany.Banners
{
    public sealed class NewCompetitionBanner : BannerWindow
    {
        // Fields
        private static bool <且丆丅丑丁万丁且丌>k__BackingField;
        private UnityEngine.GameObject _migrationSlide;
        private UIButton _claimButton;
        private UIButton _continueButton;
        private SlidesScrollController _slidesScrollController;
        private System.Collections.Generic.List<PGCompany.InventoryItemView> _itemViews;
        private FrameResizer[] _frameResizers;
        private System.Nullable<bool> 三丝上丁丆丒丌与且;
        
        // Properties
        internal static bool 丞不丗丄丞丘丛丙东 { get; }
        internal static bool 世丑丗上丘丟丐丂丕 { get; set; }
        
        // Methods
        internal static bool 丁七下丌丏丄丟上三()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(TournamentController.丌万丘丙万世丗丈丏() != false)
            {
                    val_16 = TournamentController.丅业东万丌丕上丌丄();
            }
            else
            {
                    val_16 = 0;
            }
            
            val_17 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  78);
            if(NewLobbyBanner.丐丄丞丏丈丆丆丏丁() != false)
            {
                    val_18 = (~NewLobbyBanner.丕世一与业丅万专丑()) & 1;
            }
            else
            {
                    val_18 = 0;
            }
            
            if(PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世().丐丄丞丏丈丆丆丏丁() != false)
            {
                    val_17 = PGCompany.丑世丁三不丘丛一丑.丑七不且上丗丁一世();
                val_19 = (~val_17.丆下丝丟丛不三丟丟()) & 1;
            }
            else
            {
                    val_19 = 0;
            }
            
            bool val_12 = val_16 & val_17 ^ 1;
            val_12 = val_12 & val_18;
            return (bool)val_12 & val_19;
        }
        internal static bool 七三丂丕丕世丙上不()
        {
            return (bool)PGCompany.Banners.NewCompetitionBanner.<且丆丅丑丁万丁且丌>k__BackingField;
        }
        private static void 丅丄丅万丂丗丘丕丘(bool 丙业与丙丗丝不丈东)
        {
            PGCompany.Banners.NewCompetitionBanner.<且丆丅丑丁万丁且丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override void Show()
        {
            ExperienceController val_8;
            var val_9;
            var val_10;
            val_8 = this;
            this.Show();
            if((Rilisoft.Singleton<TournamentController>.Instance.丅万丞三丏丒丅丝丁()) != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._migrationSlide, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._continueButton, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._claimButton, 丏业丟一东丂东丘丛:  true);
                this.三专丄丅丘丈东丌丞(丗七丟丈三不丕一三:  Rilisoft.Singleton<TournamentController>.Instance.丅万丞三丏丒丅丝丁());
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._migrationSlide, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._continueButton, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._claimButton, 丏业丟一东丂东丘丛:  false);
            }
            
            PGCompany.Banners.NewCompetitionBanner.<且丆丅丑丁万丁且丌>k__BackingField = true;
            val_9 = null;
            val_9 = null;
            if(ExperienceController.sharedController == 0)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            bool val_7 = ExperienceController.sharedController.下一丝丗丁上世丐上();
            this.三丝上丁丆丒丌与且 = 0;
            val_8 = ExperienceController.sharedController;
            val_8.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  false);
        }
        public override void Hide()
        {
            var val_7;
            var val_8;
            this.Hide();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  161);
            this.丏丅与丂下丙万下丙();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            .Type = 8;
            PGCompany.丕万丅丗丏三丙丈丁 val_4 = PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
            PGCompany.Banners.NewCompetitionBanner.<且丆丅丑丁万丁且丌>k__BackingField = false;
            if((this.三丝上丁丆丒丌与且 & 1) == 0)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if(ExperienceController.sharedController != 0)
            {
                    val_8 = null;
                val_8 = null;
                ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  this.三丝上丁丆丒丌与且 & 1);
            }
            
            mem2[0] = 0;
        }
        private void 丕丒专丑三丗丌万三()
        {
            int val_9 = TournamentController.丏上丈上丐丅丌七业(丙丑七万丆万丆且丌:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
            if((val_9 & 2147483648) != 0)
            {
                    val_9 = RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丞丆丙丆丝世与丘万(上丗业丂丑三丏上丏:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏(), 丆丞下七丛上丐世丌:  val_9);
        }
        public void U_Claim()
        {
            this.丏丅与丂下丙万下丙();
            this.万丐不丛上丄世丐丕();
        }
        private void 丛丆世丏丒丕丅丁东(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6 = 上业丟世三与七七三;
            if(val_6 == null)
            {
                    return;
            }
            
            if(val_6.Count == 0)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  160);
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_6 = 上业丟世三与七七三, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  15, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
            val_6 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_6.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 丏丅与丂下丙万下丙()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  161);
            bool val_3 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  78);
            if(val_3 != true)
            {
                    val_3.与下丆与与丆丑上下();
                val_3.丕丒专丑三丗丌万三();
                val_3.丝丆专丕世且丛七丗();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 与下丆与与丆丑上下()
        {
            if((Rilisoft.Singleton<TournamentController>.Instance.丅万丞三丏丒丅丝丁()) == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = Rilisoft.Singleton<TournamentController>.Instance.丅万丞三丏丒丅丝丁().且业上丞丄丁专不丙();
            val_5.丛丆世丏丒丕丅丁东(上业丟世三与七七三:  val_5);
            Rilisoft.Singleton<TournamentController>.Instance.上万丅丈丟丁丗上丙(丙业与丙丗丝不丈东:  0);
        }
        private void 下丘丕丌东三丘丝丝()
        {
            this.丕丒专丑三丗丌万三();
        }
        private void 丝丆专丕世且丛七丗()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  78);
        }
        private void 万丐不丛上丄世丐丕()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._migrationSlide, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._continueButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._claimButton, 丏业丟一东丂东丘丛:  false);
            this._slidesScrollController.丘上丐世丆丑且丞丒();
        }
        private void 三专丄丅丘丈东丌丞(TournamentController.七丗三上丗下丄三丛 丗七丟丈三不丕一三)
        {
            var val_9;
            var val_10;
            System.Action<FrameResizer> val_12;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<PGCompany.InventoryItemView>(不丗上三丛丒上东丑:  this._itemViews, 丏业丟一东丂东丘丛:  false);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = 丗七丟丈三不丕一三.且业上丞丄丁专不丙();
            val_9 = 0;
            goto label_4;
            label_16:
            if(val_1.Count > val_9)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemViews.Item[0], 丏业丟一东丂东丘丛:  true);
                this._itemViews.Item[0].Setup(与且专丈不万东一万:  PGCompany.丁丑上丞业丞丟丛上.丞丆三丙业丅丙丕丘(不丕三丌万丈丟丆世:  val_1.Item[0]));
            }
            
            val_9 = 1;
            label_4:
            if(val_9 < this._itemViews.Count)
            {
                goto label_16;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = NewCompetitionBanner.<>c.<>9__23_0;
            if(val_12 == null)
            {
                    System.Action<FrameResizer> val_8 = null;
                val_12 = val_8;
                val_8 = new System.Action<FrameResizer>(object:  NewCompetitionBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NewCompetitionBanner.<>c::三丁世丆丙七丐不丛(FrameResizer 三丟东丕丄丄下下丑));
                NewCompetitionBanner.<>c.<>9__23_0 = val_12;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<FrameResizer>(丌丛丏业世丄丞三丌:  this._frameResizers, 七丐丅专且专七三丆:  val_8);
        }
        public NewCompetitionBanner()
        {
        
        }
    
    }

}
