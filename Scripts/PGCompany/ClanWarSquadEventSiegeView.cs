using UnityEngine;

namespace PGCompany
{
    public class ClanWarSquadEventSiegeView : ClanWarMapItemViewBase
    {
        // Fields
        private UILabel TaskDescriptionLabel;
        private PGCompany.TimerUI TimerLabel;
        private UITexture MapPreviewTexture;
        private UILabel TitleLabel;
        private UILabel RewardCountLabel;
        private PGCompany.ProgressBarView ClanProgressBar;
        private UISprite MyContributionProgressBar;
        private UILabel vandalsDicription;
        private ModulesTableUI bossesTable;
        private ModulesTableUI monstersTable;
        private UnityEngine.GameObject moduleTables;
        
        // Methods
        internal void 世丈丕丌万丌丗丐丈(PGCompany.与丐业一丂丗与七丟 丐丘丌三丏与丙且东)
        {
            var val_7;
            string val_39;
            object val_40;
            var val_41;
            object val_43;
            val_40 = this;
            mem[1152921554244750464] = 丐丘丌三丏与丙且东;
            if(丐丘丌三丏与丙且东 == null)
            {
                goto label_1;
            }
            
            if(this.TaskDescriptionLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.TaskDescriptionLabel, 丕丗丘丑丛与丑业丒:  丐丘丌三丏与丙且东.下三下东业丘且丟业());
            }
            
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.MapPreviewTexture, y:  0);
            if(val_3 != false)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.MapPreviewTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_3));
            }
            
            if(this.RewardCountLabel != 0)
            {
                    PGCompany.ClanWarEventConfig val_6 = 丐丘丌三丏与丙且东.世丈丁业丛上丘丗丐();
                if(val_7.Count >= 2)
            {
                    PGCompany.ClanWarEventConfig val_9 = 丐丘丌三丏与丙且东.世丈丁业丛上丘丗丐();
                val_41 = 1152921526212668928;
                if(val_7.Item[1].丂丁丏一丙丛业且丌() >= 1)
            {
                    PGCompany.ClanWarEventConfig val_12 = 丐丘丌三丏与丙且东.世丈丁业丛上丘丗丐();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RewardCountLabel, 丕丗丘丑丛与丑业丒:  val_7.Item[1].丂丁丏一丙丛业且丌().ToString());
            }
            
            }
            
            }
            
            if(this.ClanProgressBar != 0)
            {
                    val_41 = 丐丘丌三丏与丙且东.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
                UnityEngine.Color val_21 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
                this.ClanProgressBar.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)丐丘丌三丏与丙且东.下三下东业丘且丟业().且丆丟业丞丕丑上且(), 七丝东丛东丝且丆不:  (float)val_41, 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
            }
            
            if(this.MyContributionProgressBar != 0)
            {
                    this.MyContributionProgressBar.fillAmount = 丐丘丌三丏与丙且东.下丕丘丟三丞丘上万();
            }
            
            if(this.TimerLabel != 0)
            {
                    this.TimerLabel.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  丐丘丌三丏与丙且东.丘丒不不丌丘下丒一(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            if(this.TimerLabel != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.TimerLabel);
            }
            
            mem[1152921554244750480] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadEventSiegeView).__il2cppRuntimeField_170));
            if(丐丘丌三丏与丙且东.下三下东业丘且丟业() == null)
            {
                goto label_46;
            }
            
            val_43 = 丐丘丌三丏与丙且东.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
            goto label_48;
            label_1:
            val_40 = System.String.Format(format:  "Event Type is not {0}", arg0:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            UnityEngine.Debug.LogError(message:  val_40);
            return;
            label_46:
            val_43 = 1;
            label_48:
            val_39 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8463"), arg0:  val_43);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.vandalsDicription, 丕丗丘丑丛与丑业丒:  val_39);
            if(this.moduleTables == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleTables, 丏业丟一东丂东丘丛:  true);
            if(this.bossesTable != 0)
            {
                    this.bossesTable.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  true);
            }
            
            if(this.monstersTable == 0)
            {
                    return;
            }
            
            val_40 = this.monstersTable;
            val_40.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  false);
        }
        protected override void 丙丗世不三丕丄上丂()
        {
            mem[1152921554245153488] = 0;
            if(((17545 != 0) && ((17545 & 1) != 0)) && (112722 != 0))
            {
                    mem[1152921554245153488] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadEventSiegeView).__il2cppRuntimeField_170));
                return;
            }
            
            mem[1152921554245153472] = 0;
        }
        protected override void 丘丛不丕不专丈三世()
        {
            var val_8;
            var val_9;
            val_8 = this;
            if(this.gameObject == 0)
            {
                    return;
            }
            
            val_8 = this.gameObject;
            if(val_8.activeInHierarchy == false)
            {
                    return;
            }
            
            if(ClanWarUI.丑七不且上丗丁一世() != 0)
            {
                    ClanWarUI.丑七不且上丗丁一世().丌世七万丘万世丐不();
            }
            
            val_9 = null;
            val_9 = null;
            SquadPanelGUI.丄丘七三上丕世丞业.丞丆丕丞丝丝丌丆丗(丕丗丘丑丛与丑业丒:  "Siege no longer available");
        }
        public ClanWarSquadEventSiegeView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
