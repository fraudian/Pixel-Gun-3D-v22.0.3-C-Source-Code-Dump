using UnityEngine;

namespace Competition
{
    internal sealed class CompetitionGroupPlayersCell : EndlessScrollCellDynamic
    {
        // Fields
        private UIGrid _revardGrid;
        private UIGrid _playerCellsGrid;
        private Competition.CompetitionCell _prefabCompetitionCell;
        private PGCompany.InventoryItemView _prefabReward;
        private UILabel _placesLabel;
        private UIWidget _rewardContainerWidget;
        private System.Collections.Generic.List<UIWidget> _rewardBackgroundWidgets;
        private UIWidget _playerScoresContainerWidget;
        private int _heightAddition;
        private UISprite _rewardBorderSprite;
        private UISprite _rewardGradientOpaqueSprite;
        private UISprite _rewardGradientTransparencySprite;
        private System.Collections.Generic.List<Competition.CompetitionCell> 丗业专一丝丂丕丄且;
        private System.Collections.Generic.List<PGCompany.InventoryItemView> 丑丘七丄万丐三下世;
        private Competition.东丟丕与丁不丐丕丐 专业丘丅一与丙七丂;
        
        // Properties
        internal Competition.东丟丕与丁不丐丕丐 丌丈丛世丁丑一丁丁 { get; }
        internal UIWidget 丐下丕丐丝一丗七丟 { get; }
        internal System.Collections.Generic.List<UIWidget> 丂丛丕丁丁丙丅丕丒 { get; }
        
        // Methods
        internal Competition.东丟丕与丁不丐丕丐 丕丏丆丏丏丗且丅专()
        {
            return (Competition.东丟丕与丁不丐丕丐)this.专业丘丅一与丙七丂;
        }
        internal UIWidget 三与不丆丁丝业丆丆()
        {
            return (UIWidget)this._rewardContainerWidget;
        }
        internal System.Collections.Generic.List<UIWidget> 不丅丑丕丂丘东丌丑()
        {
            System.Collections.Generic.List<UIWidget> val_2 = this._rewardBackgroundWidgets;
            if(val_2 != null)
            {
                    return (System.Collections.Generic.List<UIWidget>)val_2;
            }
            
            System.Collections.Generic.List<UIWidget> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<UIWidget>();
            return (System.Collections.Generic.List<UIWidget>)val_2;
        }
        private void 丗东丂东丈丌丑丈丆(int 东丅专丒丙下丟丛丁, int 万丅丅丂一丗丗丗下)
        {
            this.丗东丂东丈丌丑丈丆<PGCompany.InventoryItemView>(丌丒丝东丌下丕丁丅:  东丅专丒丙下丟丛丁, 丈丆丕与丒丌丘丕且:  this.丑丘七丄万丐三下世, 丑且不丕与专丄业丙:  this._prefabReward, 丈东丘丏与丌东东下:  this._revardGrid.transform);
            this.丗东丂东丈丌丑丈丆<Competition.CompetitionCell>(丌丒丝东丌下丕丁丅:  万丅丅丂一丗丗丗下, 丈丆丕与丒丌丘丕且:  this.丗业专一丝丂丕丄且, 丑且不丕与专丄业丙:  this._prefabCompetitionCell, 丈东丘丏与丌东东下:  this._playerCellsGrid.transform);
        }
        private void 丗东丂东丈丌丑丈丆<T>(int 丌丒丝东丌下丕丁丅, System.Collections.Generic.List<T> 丈丆丕与丒丌丘丕且, T 丑且不丕与专丄业丙, UnityEngine.Transform 丈东丘丏与丌东东下)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = 丈东丘丏与丌东东下;
            val_8 = 丌丒丝东丌下丕丁丅;
            if(丈丆丕与丒丌丘丕且 > val_8)
            {
                goto label_2;
            }
            
            if(丈丆丕与丒丌丘丕且 >= val_8)
            {
                    return;
            }
            
            val_9 = val_8 - 丈丆丕与丒丌丘丕且;
            if(val_9 < 1)
            {
                    return;
            }
            
            do
            {
                val_8 = 丑且不丕与专丄业丙;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                val_8.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
                val_8.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
                val_9 = val_9 - 1;
            }
            while(val_9 != 0);
            
            return;
            label_24:
            val_7 = 丈丆丕与丒丌丘丕且.gameObject;
            val_7.SetActive(value:  false);
            val_8 = val_8 + 1;
            label_2:
            if(val_8 < 丈丆丕与丒丌丘丕且)
            {
                goto label_24;
            }
        
        }
        internal void 丈且东丑丂且万丒丅(Competition.东丟丕与丁不丐丕丐 丙丁丅丆万丟上东三)
        {
            this.专业丘丅一与丙七丂 = 丙丁丅丆万丟上东三;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(丙丁丅丆万丟上东三 == null)
            {
                goto label_2;
            }
            
            label_14:
            val_1.SetActive(value:  true);
            this.丗东丂东丈丌丑丈丆(东丅专丒丙下丟丛丁:  丙丁丅丆万丟上东三.下丐丐丁与丂下世七.Count, 万丅丅丂一丗丗丗下:  丙丁丅丆万丟上东三.丏丕丏万丂丅丒丁丆.Count);
            UnityEngine.GameObject val_4 = this._revardGrid.gameObject;
            val_4.SetActive(value:  (丙丁丅丆万丟上东三.下丐丐丁与丂下世七.Count != 0) ? 1 : 0);
            this.东丆丞东一丕丒东东(丈丄不七三万丄丁不:  丙丁丅丆万丟上东三.下丐丐丁与丂下世七);
            this.丘丈专丏丒丏丈下丐(丆丝丑丝上丂丛不下:  丙丁丅丆万丟上东三.丏丕丏万丂丅丒丁丆);
            this.一下丈丄丆世七丘丄(丙丁丅丆万丟上东三:  丙丁丅丆万丟上东三);
            this.丈且丐丌丁丝东丒上(且丒丛与丞世丙丕丌:  丙丁丅丆万丟上东三.不丛丐丂丛不丗丝丄 + 1);
            int val_11 = this._rewardContainerWidget.height + (丙丁丅丆万丟上东三.丏丕丏万丂丅丒丁丆.Count * this._playerScoresContainerWidget.height);
            val_11 = val_11 + this._heightAddition;
            val_4.height = UnityEngine.Mathf.CeilToInt(f:  (float)val_11);
            this.UpdateRects();
            return;
            label_1:
            if(丙丁丅丆万丟上东三 != null)
            {
                goto label_14;
            }
            
            label_2:
            val_1.SetActive(value:  false);
        }
        private void 丈且丐丌丁丝东丒上(int 且丒丛与丞世丙丕丌)
        {
            float val_10;
            float val_11;
            UISprite val_12;
            string val_13;
            if(且丒丛与丞世丙丕丌 == 2)
            {
                goto label_1;
            }
            
            if(且丒丛与丞世丙丕丌 != 1)
            {
                goto label_2;
            }
            
            UnityEngine.Color val_1 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_01_gold_bord");
            val_10 = val_1.r;
            val_11 = val_1.b;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardBorderSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10, g = val_1.g, b = val_11, a = val_1.a});
            UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_01_gold_opact");
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardGradientOpaqueSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            val_12 = this._rewardGradientTransparencySprite;
            val_13 = "CompetitionLeaderboards/place_01_gold_transp";
            goto label_12;
            label_1:
            UnityEngine.Color val_3 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_02_silver_bord");
            val_10 = val_3.r;
            val_11 = val_3.b;
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardBorderSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10, g = val_3.g, b = val_11, a = val_3.a});
            UnityEngine.Color val_4 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_02_silver_opact");
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardGradientOpaqueSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            val_12 = this._rewardGradientTransparencySprite;
            val_13 = "CompetitionLeaderboards/place_02_silver_transp";
            goto label_12;
            label_2:
            if(且丒丛与丞世丙丕丌 == 3)
            {
                    UnityEngine.Color val_5 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_03_bronze_bord");
                val_10 = val_5.r;
                val_11 = val_5.b;
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardBorderSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10, g = val_5.g, b = val_11, a = val_5.a});
                UnityEngine.Color val_6 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_03_bronze_opact");
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardGradientOpaqueSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
                val_12 = this._rewardGradientTransparencySprite;
                val_13 = "CompetitionLeaderboards/place_03_bronze_transp";
            }
            else
            {
                    UnityEngine.Color val_7 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_default_bord");
                val_10 = val_7.r;
                val_11 = val_7.b;
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardBorderSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_10, g = val_7.g, b = val_11, a = val_7.a});
                UnityEngine.Color val_8 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CompetitionLeaderboards/place_default_opact");
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._rewardGradientOpaqueSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
                val_12 = this._rewardGradientTransparencySprite;
                val_13 = "CompetitionLeaderboards/place_default_transp";
            }
            
            label_12:
            UnityEngine.Color val_9 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  val_13);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_12, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
        }
        private void 一下丈丄丆世七丘丄(Competition.东丟丕与丁不丐丕丐 丙丁丅丆万丟上东三)
        {
            int val_6;
            UILabel val_7;
            string val_8;
            val_6 = 丙丁丅丆万丟上东三.不丛丐丂丛不丗丝丄 + 1;
            if(丙丁丅丆万丟上东三.不丛丐丂丛不丗丝丄 <= 2)
            {
                    val_7 = this._placesLabel;
                val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11604");
            }
            else
            {
                    val_7 = this._placesLabel;
                val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11604");
                val_6 = val_6;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_7, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_8, arg0:  System.String.Format(format:  "{0}-{1}", arg0:  val_6, arg1:  丙丁丅丆万丟上东三.丏丈三丗丕丞丟丌东)));
        }
        private void 东丆丞东一丕丒东东(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丈丄不七三万丄丁不)
        {
            goto label_1;
            label_9:
            this.丑丘七丄万丐三下世.Item[0].gameObject.SetActive(value:  true);
            this.丑丘七丄万丐三下世.Item[0].Setup(丈丄不七三万丄丁不:  丈丄不七三万丄丁不.Item[0]);
            0 = 1;
            label_1:
            if(0 < 丈丄不七三万丄丁不.Count)
            {
                goto label_9;
            }
            
            if(this._revardGrid == null)
            {
                
            }
        
        }
        private void 丘丈专丏丒丏丈下丐(System.Collections.Generic.List<Competition.丛丌丒丌世三业丞与> 丆丝丑丝上丂丛不下)
        {
            var val_13;
            var val_14;
            RatingLeague val_15;
            var val_16;
            Competition.CompetitionLeagueChangeCell val_17;
            val_13 = 1152921540917797680;
            val_14 = 1152921540917798704;
            val_15 = 1152921505352638464;
            val_16 = 0;
            goto label_1;
            label_35:
            this.丗业专一丝丂丕丄且.Item[0].gameObject.SetActive(value:  true);
            Competition.丛丌丒丌世三业丞与 val_3 = 丆丝丑丝上丂丛不下.Item[0];
            if(val_3 != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            Competition.丛丌丒丌世三业丞与 val_4 = 丆丝丑丝上丂丛不下.Item[0];
            if((val_4 == null) || (null != null))
            {
                goto label_31;
            }
            
            this.丗业专一丝丂丕丄且.Item[0].SetAsLeague();
            Competition.CompetitionCell val_6 = this.丗业专一丝丂丕丄且.Item[0];
            val_17 = val_6.competitionLeagueChangeCell;
            val_17.丈且东丑丂且万丒丅(丞丄丕专三丁丙一上:  W24, 丘下下万丙丙丐万丁:  val_15, 丝不一丘与丞东丏丛:  val_4);
            val_15 = 1152921505352638464;
            goto label_31;
            label_7:
            Competition.CompetitionCell val_7 = this.丗业专一丝丂丕丄且.Item[0];
            if(val_7 == null)
            {
                goto label_18;
            }
            
            if(W24 == 0)
            {
                goto label_19;
            }
            
            label_24:
            val_7.SetUpdatingData();
            Competition.CompetitionCell val_8 = this.丗业专一丝丂丕丄且.Item[0];
            val_17 = val_8.competitionUpdatingDataCell;
            val_17.丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  val_3);
            goto label_23;
            label_18:
            if(W24 != 0)
            {
                goto label_24;
            }
            
            label_19:
            val_7.SetAsPlayer();
            Competition.CompetitionCell val_9 = this.丗业专一丝丂丕丄且.Item[0];
            val_17 = val_9.competitionPlayerCell;
            val_17.丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  1152921540917797680, 丞丅上丏丂且下丅与:  val_15, 不丆业丏上丐与丌业:  val_3, 万且丒下丕丝专丟上:  W24);
            val_13 = val_13;
            val_14 = 1152921540917798704;
            val_15 = 1152921505352638464;
            label_23:
            Competition.CompetitionCell val_10 = this.丗业专一丝丂丕丄且.Item[0];
            if(val_10.competitionPlayerCell.上世丄不丐丁丟丅丒 != false)
            {
                    val_17 = Competition.CompetitionPanel.丆丕丝丒不丙且丐丗;
                Competition.CompetitionPanel.丆丕丝丒不丙且丐丗.丞丌一丂专丒丄万丐 = this.丗业专一丝丂丕丄且.Item[0];
            }
            
            label_31:
            val_16 = 1;
            label_1:
            if(val_16 < 丆丝丑丝上丂丛不下.Count)
            {
                goto label_35;
            }
            
            if(this._playerCellsGrid == null)
            {
                
            }
        
        }
        public CompetitionGroupPlayersCell()
        {
            this.丗业专一丝丂丕丄且 = new System.Collections.Generic.List<Competition.CompetitionCell>();
            this.丑丘七丄万丐三下世 = new System.Collections.Generic.List<PGCompany.InventoryItemView>();
        }
    
    }

}
