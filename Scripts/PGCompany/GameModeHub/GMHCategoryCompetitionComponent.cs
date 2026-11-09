using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHCategoryCompetitionComponent : ViewComponentGMHEntityBase
    {
        // Fields
        private PGCompany.TimerUI endTimer;
        private UIBasicSprite currentLeagueTexture;
        private UILabel placeLabel;
        private UILabel scoreLabel;
        private System.Collections.Generic.List<WidgetLayout> layouts;
        private UILabel registrationClosedMessage;
        private UnityEngine.GameObject enabledState;
        private UnityEngine.GameObject registrationClosedState;
        private UnityEngine.GameObject disabledState;
        private UnityEngine.GameObject disableIfLockedByXP;
        
        // Methods
        private void OnEnable()
        {
            TournamentController.业业三与丌下且与不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryCompetitionComponent::丝一丅丆三东丂丞七()));
        }
        private void OnDisable()
        {
            TournamentController.丝东丁丁丌丄丅且丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryCompetitionComponent::丝一丅丆三东丂丞七()));
        }
        public override void Setup(PGCompany.GameModeHub.三丙专上下万七丛东 不丕三丌万丈丟丆世)
        {
            mem[1152921560509399672] = 不丕三丌万丈丟丆世;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            UnityEngine.Object val_32;
            bool val_33;
            UnityEngine.GameObject val_34;
            var val_35;
            UnityEngine.GameObject val_36;
            var val_37;
            var val_38;
            var val_39;
            UnityEngine.GameObject val_40;
            var val_41;
            int val_42;
            PGCompany.TimerUI val_43;
            var val_44;
            UnityEngine.MonoBehaviour val_45;
            val_32 = this;
            if(this == 0)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32, b:  "Category08")) != false)
            {
                    val_33 = 1;
            }
            else
            {
                    val_33 = System.String.op_Equality(a:  static_value_082C9020, b:  "Competition");
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  val_33);
            if(val_33 != false)
            {
                    if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 2)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enabledState, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.registrationClosedState, 丏业丟一东丂东丘丛:  false);
                val_34 = this.disabledState;
                val_35 = 1;
            }
            else
            {
                    if((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 3)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enabledState, 丏业丟一东丂东丘丛:  false);
                val_36 = this.registrationClosedState;
                val_37 = 1;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enabledState, 丏业丟一东丂东丘丛:  true);
                val_36 = this.registrationClosedState;
                val_37 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_36, 丏业丟一东丂东丘丛:  false);
                val_34 = this.disabledState;
                val_35 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_34, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.currentLeagueTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "Competition/cup{0}_1", arg0:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏() + 1)));
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.placeLabel, 丕丗丘丑丛与丑业丒:  Rilisoft.Singleton<TournamentController>.Instance.下丐丕东七丞丅丙丝());
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.scoreLabel, 丕丗丘丑丛与丑业丒:  RatingSystem.与一丅丝不丈业与丙().万与一丂丗丞一世丅());
                Rilisoft.丝丑丂丛万丐丈丘且 val_19 = Rilisoft.Singleton<TournamentController>.Instance.丞丁下丛丒一丈丌丑();
                System.TimeSpan val_20 = System.TimeSpan.FromSeconds(value:  1.15292150460685E+18);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.registrationClosedMessage, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12516"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_20._ticks}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
                if(null != 0)
            {
                    if(!=0)
            {
                    string val_31 = "locked.exp";
                val_31 = 丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  val_31, 丟且丒专下丈七丗丕:  4);
                val_38 = 0;
            }
            else
            {
                    val_38 = 0;
            }
            
            }
            
                if((68229356 & 1) != 0)
            {
                    val_39 = val_38.GetValueOrDefault();
            }
            else
            {
                    val_39 = 0;
            }
            
                if((val_39 & 1) != 0)
            {
                    val_40 = this.disableIfLockedByXP;
                val_41 = 0;
            }
            else
            {
                    val_41 = 1;
                val_40 = this.disableIfLockedByXP;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_40, 丏业丟一东丂东丘丛:  true);
            }
            
            val_42 = 1152921525797342656;
            val_43 = this.endTimer;
            if((Rilisoft.Singleton<TournamentController>.Instance.丂与丐下一丟丆丌与()) >= 1)
            {
                    if(val_43 != null)
            {
                    val_42 = Rilisoft.Singleton<TournamentController>.Instance.丂与丐下一丟丆丌与();
                val_43.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_42, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHCategoryCompetitionComponent::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
                val_43 = this.endTimer;
            }
            
                val_44 = 1;
                val_45 = val_43;
            }
            else
            {
                    val_45 = val_43;
                val_44 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_45, 丏业丟一东丂东丘丛:  false);
            val_32 = this.layouts;
            丞东丑专丛丆丄丝世.丁下丏丙一丗下丈七(下丛丅丕业丁业丁东:  val_32);
        }
        public GMHCategoryCompetitionComponent()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
