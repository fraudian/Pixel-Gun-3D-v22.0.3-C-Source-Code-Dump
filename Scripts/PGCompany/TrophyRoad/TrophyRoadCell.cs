using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal class TrophyRoadCell : EndlessScrollCellDynamic
    {
        // Fields
        private static System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与> 丘世上丙与丆丝专丁;
        private UnityEngine.GameObject _holder;
        private UnityEngine.GameObject _simpleCheckpointGo;
        private UnityEngine.GameObject _currentCheckpointGo;
        private UnityEngine.GameObject _lockCheckpointGo;
        private UnityEngine.GameObject _unlockEffectsSmallGo;
        private UnityEngine.GameObject _unlockEffectsMiddleGo;
        private UnityEngine.GameObject _unlockEffectsBigGo;
        private UnityEngine.GameObject _tokensContainer;
        private UILabel _checkpointTokensLabel;
        private UnityEngine.GameObject _currentTokensContainer;
        private UILabel _currentTokensLabel;
        private UIWidget _progressBarWidget;
        private UISprite _progressBarSprite;
        private PGCompany.TrophyRoad.RewardView _generalRewardViewSmall;
        private PGCompany.TrophyRoad.RewardView _generalRewardViewMiddle;
        private PGCompany.TrophyRoad.RewardView _generalRewardViewBig;
        private PGCompany.TrophyRoad.RewardView _additionalRewardView;
        private PGCompany.TrophyRoad.丈专世丅丞万丌东丗 丘丑丆丗丝丙且丏世;
        private int 丅丒丕丒专丗丐丒下;
        private int 丝丝三与且业丝世丑;
        private PGCompany.TrophyRoad.TrophyRoadWindow 丒丅丕丒上与三七丌;
        private PGCompany.TrophyRoad.TrophyRoadCell.丏丞丌万上且丁丂万 万不丏丌业下东世丅;
        
        // Methods
        internal static void 丟与万丅且丕丞丈东(System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.TrophyRoad.TrophyRoadCell.丘世上丙与丆丝专丁, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丙丏丒三丞丂丞与世(System.Action<PGCompany.TrophyRoad.丆丅且丞丝丗与且与> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.TrophyRoad.TrophyRoadCell.丘世上丙与丆丝专丁, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        private void OnDisable()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsSmallGo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsMiddleGo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsBigGo, 丏业丟一东丂东丘丛:  false);
        }
        internal int 一三丕丄七丏丁专丗()
        {
            return (int)this.丝丝三与且业丝世丑 - this.丅丒丕丒专丗丐丒下;
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.TrophyRoad.TrophyRoadWindow 不丌不世且丄不三丝, PGCompany.TrophyRoad.丈专世丅丞万丌东丗 丗丟上上丒丐丗丞丙)
        {
            var val_7;
            this.丒丅丕丒上与三七丌 = 不丌不世且丄不三丝;
            this.丘丑丆丗丝丙且丏世 = 丗丟上上丒丐丗丞丙;
            if(丗丟上上丒丐丗丞丙 != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
                this.丅丒丕丒专丗丐丒下 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  this.丘丑丆丗丝丙且丏世.Level - 1);
                this.丝丝三与且业丝世丑 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().不丗丁不丛与万不业(丈丘丝一丗下丈丐不:  this.丘丑丆丗丝丙且丏世.Level);
                this.丁丟与且世万丝不丙();
                this.三丒丒三上丗丕不丐();
                this.且万丒丙丆丈丕丞丞();
                val_7 = this;
                this.丄不业丝丅下丅与丂();
                if(this.丒丅丕丒上与三七丌 == null)
            {
                    val_7 = 0;
            }
            
                int val_6 = val_7.丑上不万丐世丅丂一();
                this.丁丈万丛一业丞业不(丒丐丑世丁丕与七丙:  val_6);
                this.一世丑下丒专丒不丙(丒丐丑世丁丕与七丙:  val_6);
                this.UpdateRects();
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丘丑丅丈专世不业丁()
        {
            var val_3;
            丏丞丌万上且丁丂万 val_4;
            if(this.丘丑丆丗丝丙且丏世 == null)
            {
                    val_3 = 0;
            }
            
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世() == null)
            {
                    val_3 = 0;
            }
            
            if((val_3.丑三三丝下丙丌丄下(丈丘丝一丗下丈丐不:  this.丘丑丆丗丝丙且丏世.Level)) == true)
            {
                    return;
            }
            
            val_4 = this.万不丏丌业下东世丅;
            if(val_4 == 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsSmallGo, 丏业丟一东丂东丘丛:  true);
                val_4 = this.万不丏丌业下东世丅;
            }
            
            if(val_4 == 2)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsMiddleGo, 丏业丟一东丂东丘丛:  true);
                val_4 = this.万不丏丌业下东世丅;
            }
            
            if(val_4 != 3)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockEffectsBigGo, 丏业丟一东丂东丘丛:  true);
        }
        private void 丁丟与且世万丝不丙()
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_8 = this.丘丑丆丗丝丙且丏世.GeneralRewards;
            if(val_8 == null)
            {
                goto label_13;
            }
            
            if(this.丘丑丆丗丝丙且丏世.GeneralRewards.Count == 0)
            {
                goto label_8;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_2 = this.丘丑丆丗丝丙且丏世.GeneralRewards.Item[0];
            if(val_2 == null)
            {
                goto label_8;
            }
            
            if(val_2.不业丙丒丂丞下丆丙() != 1320)
            {
                    if(val_2.不业丙丒丂丞下丆丙() != 1000)
            {
                    if(val_2.不业丙丒丂丞下丆丙() != 1010)
            {
                goto label_11;
            }
            
            }
            
            }
            
            val_8 = 1;
            goto label_13;
            label_8:
            val_8 = 0;
            label_13:
            this.万不丏丌业下东世丅 = val_8;
            return;
            label_11:
            var val_7 = (val_2.不业丙丒丂丞下丆丙() != 1390) ? (2 + 1) : 2;
            goto label_13;
        }
        private void 上与丟丗一上丛丌专()
        {
            this.三丒丒三上丗丕不丐();
            this.且万丒丙丆丈丕丞丞();
        }
        private void 三丒丒三上丗丕不丐()
        {
            var val_16;
            PGCompany.TrophyRoad.RewardView val_17;
            var val_18;
            var val_19;
            bool val_20;
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_21;
            val_16 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._generalRewardViewSmall, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._generalRewardViewMiddle, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._generalRewardViewBig, 丏业丟一东丂东丘丛:  false);
            if(this.万不丏丌业下东世丅 == 1)
            {
                goto label_7;
            }
            
            if(this.万不丏丌业下东世丅 == 3)
            {
                goto label_4;
            }
            
            if(this.万不丏丌业下东世丅 != 2)
            {
                goto label_5;
            }
            
            val_17 = this._generalRewardViewMiddle;
            goto label_7;
            label_4:
            val_16 = 1152921559541675624;
            goto label_7;
            label_5:
            val_17 = 0;
            label_7:
            if(val_17 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_17, 丏业丟一东丂东丘丛:  true);
            if(this.丘丑丆丗丝丙且丏世 == null)
            {
                    val_18 = 0;
            }
            
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世() == null)
            {
                    val_18 = 0;
            }
            
            bool val_3 = val_18.丑三三丝下丙丌丄下(丈丘丝一丗下丈丐不:  this.丘丑丆丗丝丙且丏世.Level);
            if(val_3 != false)
            {
                    val_19 = 1;
            }
            else
            {
                    if(this.丒丅丕丒上与三七丌 == null)
            {
                    val_18 = 0;
            }
            
            }
            
            if((((val_18.丝丐上不世丄丌丑丟() >= this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0) & 1) != 0)
            {
                    val_20 = 0;
            }
            else
            {
                    if(this.丘丑丆丗丝丙且丏世.Level > PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丌丂丂丅业丁丞且下())
            {
                    var val_10 = (PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丈一下下丞世三丑丄() < this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0;
            }
            else
            {
                    val_20 = true;
            }
            
            }
            
            val_21 = this.丘丑丆丗丝丙且丏世;
            if(this.丘丑丆丗丝丙且丏世 != null)
            {
                goto label_27;
            }
            
            val_21 = this.丘丑丆丗丝丙且丏世;
            if(val_21 == null)
            {
                goto label_28;
            }
            
            label_27:
            .<上七东下丏不丕丐丑>k__BackingField = this.丘丑丆丗丝丙且丏世.Level;
            .三东丏不丗世丅丌丄 = this.丘丑丆丗丝丙且丏世.GeneralRewards.Item[0];
            .丏世丄丗丅丂业丅丌 = val_3;
            .业且万丝丛东丂丄丑 = val_20;
            val_17.Setup(三丏丑不业丏不丂丈:  new PGCompany.TrophyRoad.丆丅且丞丝丗与且与());
            val_17.丞丕丛丄丕世丂丟一(丙业与丙丗丝不丈东:  new System.Action<PGCompany.TrophyRoad.RewardView>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadCell::专业丘丄与不与且丆(PGCompany.TrophyRoad.RewardView 丌东丅上三丛丐丑丟)));
            val_17.且世万七丈丄丁丗丝(丙业与丙丗丝不丈东:  new System.Action<PGCompany.TrophyRoad.RewardView>(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadCell::专业丘丄与不与且丆(PGCompany.TrophyRoad.RewardView 丌东丅上三丛丐丑丟)));
            return;
            label_28:
        }
        private void 且万丒丙丆丈丕丞丞()
        {
            UnityEngine.MonoBehaviour val_10;
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_11;
            PGCompany.TrophyRoad.丈专世丅丞万丌东丗 val_12;
            if(((this.丘丑丆丗丝丙且丏世.丅丛三三且一上万丂 == null) || (this.丘丑丆丗丝丙且丏世.丅丛三三且一上万丂.Count == 0)) || (this._additionalRewardView == 0))
            {
                goto label_8;
            }
            
            val_10 = this._additionalRewardView;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
            if(this.丒丅丕丒上与三七丌 == null)
            {
                    val_10 = 0;
            }
            
            int val_3 = val_10.丝丐上不世丄丌丑丟();
            val_11 = this.丘丑丆丗丝丙且丏世;
            if(val_11 == null)
            {
                goto label_12;
            }
            
            val_12 = val_11;
            var val_4 = (val_3 >= this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0;
            var val_5 = (val_3 < this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0;
            goto label_17;
            label_8:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._additionalRewardView, 丏业丟一东丂东丘丛:  false);
            return;
            label_12:
            val_12 = this.丘丑丆丗丝丙且丏世;
            if(val_12 == null)
            {
                goto label_16;
            }
            
            val_11 = val_12;
            goto label_17;
            label_16:
            val_11 = this.丘丑丆丗丝丙且丏世;
            if(val_11 == null)
            {
                goto label_18;
            }
            
            label_17:
            .<上七东下丏不丕丐丑>k__BackingField = this.丘丑丆丗丝丙且丏世.Level;
            .三东丏不丗世丅丌丄 = this.丘丑丆丗丝丙且丏世.丅丛三三且一上万丂.Item[0];
            .丏世丄丗丅丂业丅丌 = (val_3 >= this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0;
            .业且万丝丛东丂丄丑 = (val_3 < this.丘丑丆丗丝丙且丏世.Level) ? 1 : 0;
            this._additionalRewardView.Setup(三丏丑不业丏不丂丈:  new PGCompany.TrophyRoad.丆丅且丞丝丗与且与());
            return;
            label_18:
        }
        private void 专业丘丄与不与且丆(PGCompany.TrophyRoad.RewardView 丌东丅上三丛丐丑丟)
        {
            PGCompany.TrophyRoad.丆丅且丞丝丗与且与 val_15;
            var val_16;
            var val_17;
            bool val_18;
            if(丌东丅上三丛丐丑丟 == 0)
            {
                    return;
            }
            
            if(丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与 == null)
            {
                    return;
            }
            
            if(丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.丏世丄丗丅丂业丅丌 != true)
            {
                    if(丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.业且万丝丛东丂丄丑 == false)
            {
                goto label_7;
            }
            
            }
            
            if(PGCompany.TrophyRoad.TrophyRoadCell.丘世上丙与丆丝专丁 == null)
            {
                    return;
            }
            
            PGCompany.TrophyRoad.TrophyRoadCell.丘世上丙与丆丝专丁.Invoke(obj:  丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与);
            return;
            label_7:
            bool val_3 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().三丛丁丆东世丁丏三(丈丘丝一丗下丈丐不:  丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.<上七东下丏不丕丐丑>k__BackingField);
            val_15 = 丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与;
            if(val_15 == null)
            {
                    val_16 = 0;
            }
            
            if(PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世() == null)
            {
                    val_16 = 0;
            }
            
            bool val_5 = val_16.丑三三丝下丙丌丄下(丈丘丝一丗下丈丐不:  丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.<上七东下丏不丕丐丑>k__BackingField);
            if(val_5 != false)
            {
                    val_17 = 1;
            }
            else
            {
                    if(this.丒丅丕丒上与三七丌 == null)
            {
                    val_16 = 0;
            }
            
            }
            
            if((((val_16.丝丐上不世丄丌丑丟() >= (丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.<上七东下丏不丕丐丑>k__BackingField)) ? 1 : 0) & 1) != 0)
            {
                    val_18 = 0;
            }
            else
            {
                    if((丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.<上七东下丏不丕丐丑>k__BackingField) > PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丌丂丂丅业丁丞且下())
            {
                    var val_12 = (PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丈一下下丞世三丑丄() < (丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.<上七东下丏不丕丐丑>k__BackingField)) ? 1 : 0;
            }
            else
            {
                    val_18 = true;
            }
            
            }
            
            丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.丏世丄丗丅丂业丅丌 = val_5;
            丌东丅上三丛丐丑丟.丆丅且丞丝丗与且与.业且万丝丛东丂丄丑 = val_18;
            丌东丅上三丛丐丑丟.Setup(三丏丑不业丏不丂丈:  val_15);
            if(this.丒丅丕丒上与三七丌 == 0)
            {
                    return;
            }
            
            if(this.丒丅丕丒上与三七丌 != null)
            {
                    return;
            }
        
        }
        private void 丁丈万丛一业丞业不(int 丒丐丑世丁丕与七丙)
        {
            UnityEngine.GameObject val_1;
            UILabel val_2;
            val_1 = this;
            if(this.丘丑丆丗丝丙且丏世.CombatTokens != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tokensContainer, 丏业丟一东丂东丘丛:  true);
                val_2 = this._checkpointTokensLabel;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_2, 丕丗丘丑丛与丑业丒:  this.丝丝三与且业丝世丑);
                if((this.丅丒丕丒专丗丐丒下 <= 丒丐丑世丁丕与七丙) && (this.丝丝三与且业丝世丑 > 丒丐丑世丁丕与七丙))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currentTokensContainer, 丏业丟一东丂东丘丛:  true);
                val_2 = this._currentTokensLabel;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_2, 丕丗丘丑丛与丑业丒:  丒丐丑世丁丕与七丙);
                this.丛丒丅丕丕丑丈丘丂(丒丐丑世丁丕与七丙:  丒丐丑世丁丕与七丙);
                return;
            }
            
                val_1 = this._currentTokensContainer;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._tokensContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currentTokensContainer, 丏业丟一东丂东丘丛:  false);
        }
        private void 丛丒丅丕丕丑丈丘丂(int 丒丐丑世丁丕与七丙)
        {
            var val_10;
            UIWidget val_11;
            val_10 = this;
            val_11 = this._progressBarWidget;
            if(val_11 == 0)
            {
                    return;
            }
            
            val_11 = this._currentTokensContainer;
            if(val_11 == 0)
            {
                    return;
            }
            
            int val_10 = this.丅丒丕丒专丗丐丒下;
            val_10 = this.丝丝三与且业丝世丑 - val_10;
            float val_11 = (float)丒丐丑世丁丕与七丙 - val_10;
            UnityEngine.Vector3 val_5 = this._currentTokensContainer.transform.localPosition;
            val_11 = val_11 / (float)val_10;
            val_11 = this._progressBarWidget;
            int val_7 = val_11.width;
            var val_8 = (val_7 < 0) ? (val_7 + 1) : (val_7);
            float val_12 = (float)this._progressBarWidget.width;
            val_8 = val_8 >> 1;
            val_12 = val_11 * val_12;
            val_11 = val_12 - (float)val_8;
            val_10 = this._currentTokensContainer.transform;
            val_10.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private void 一世丑下丒专丒不丙(int 丒丐丑世丁丕与七丙)
        {
            UISprite val_3;
            UISprite val_4;
            val_3 = 丒丐丑世丁丕与七丙;
            if(this.丅丒丕丒专丗丐丒下 >= val_3)
            {
                goto label_1;
            }
            
            if(this.丝丝三与且业丝世丑 <= val_3)
            {
                goto label_2;
            }
            
            float val_3 = (float)val_3 - this.丅丒丕丒专丗丐丒下;
            val_3 = val_3 / ((float)this.丝丝三与且业丝世丑 - this.丅丒丕丒专丗丐丒下);
            goto label_5;
            label_1:
            val_3 = this._progressBarSprite;
            val_4 = val_3;
            goto label_8;
            label_2:
            label_5:
            val_4 = this._progressBarSprite;
            label_8:
            丞东丑专丛丆丄丝世.且丞丛一专丗丐丂世(与丄丈丘丟丕丏丐丁:  val_4, 丙业与丙丗丝不丈东:  1f);
        }
        private void 丄不业丝丅下丅与丂()
        {
            UnityEngine.GameObject val_2;
            var val_3;
            UnityEngine.GameObject val_4;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._simpleCheckpointGo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._currentCheckpointGo, 丏业丟一东丂东丘丛:  false);
            val_2 = this._lockCheckpointGo;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
            if(this.丘丑丆丗丝丙且丏世 == null)
            {
                    val_2 = 0;
            }
            
            if(this.丘丑丆丗丝丙且丏世.Level == 0)
            {
                    return;
            }
            
            if(this.丘丑丆丗丝丙且丏世 == null)
            {
                    val_2 = 0;
            }
            
            if(this.丘丑丆丗丝丙且丏世.Level == 2147483647)
            {
                    return;
            }
            
            if(this.丒丅丕丒上与三七丌 == null)
            {
                    val_2 = 0;
            }
            
            int val_1 = val_2.丝丐上不世丄丌丑丟();
            if(val_1 < this.丘丑丆丗丝丙且丏世.Level)
            {
                    val_3 = null;
                val_4 = this._lockCheckpointGo;
            }
            else
            {
                    if(val_1 > this.丘丑丆丗丝丙且丏世.Level)
            {
                    val_3 = null;
                val_4 = this._simpleCheckpointGo;
            }
            else
            {
                    val_3 = null;
                val_4 = this._currentCheckpointGo;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_4, 丏业丟一东丂东丘丛:  true);
        }
        public TrophyRoadCell()
        {
        
        }
    
    }

}
