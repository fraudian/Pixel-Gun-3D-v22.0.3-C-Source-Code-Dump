using UnityEngine;

namespace PGCompany
{
    public class ClanWarSquadEventRaidView : ClanWarMapItemViewBase
    {
        // Fields
        protected const string 丕且丘业丄世丛丌万 = "Key_8156";
        private PGCompany.TimerUI TimerLabel;
        private UITexture MapPreviewTexture;
        private UILabel RewardCountLabel;
        private UnityEngine.GameObject rewardPanel1;
        private UnityEngine.GameObject rewardPanel2;
        private UILabel InpactCountLabel;
        private UILabel CalculatedRewardCountLabel;
        private UILabel RewardEachMemberCountLabel;
        private PGCompany.ClanWarSquadEventFortView MyClanView;
        private PGCompany.ClanWarSquadEventFortView RivalClanView;
        private UnityEngine.GameObject moduleTables;
        
        // Methods
        internal void 世丈丕丌万丌丗丐丈(PGCompany.一丏不三且丆专东东 丐丘丌三丏与丙且东)
        {
            object val_46;
            丞丂丘丒丟丞丑下丄 val_47;
            UnityEngine.GameObject val_48;
            float val_50;
            float val_51;
            float val_52;
            val_46 = this;
            val_47 = 1152921505284374528;
            val_48 = this.moduleTables;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_48, 丏业丟一东丂东丘丛:  false);
            mem[1152921554243794232] = 丐丘丌三丏与丙且东;
            if(丐丘丌三丏与丙且东 == null)
            {
                goto label_3;
            }
            
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.MapPreviewTexture, y:  0);
            if(val_1 != false)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.MapPreviewTexture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_1));
            }
            
            if(this.RewardCountLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RewardCountLabel, 丕丗丘丑丛与丑业丒:  丐丘丌三丏与丙且东.三丄丝上丙丅丐丆丌().丂丁丏一丙丛业且丌().ToString());
            }
            
            if(丐丘丌三丏与丙且东.下丕丘丟三丞丘上万() <= 0f)
            {
                goto label_15;
            }
            
            if(this.InpactCountLabel != 0)
            {
                    val_50 = 丐丘丌三丏与丙且东.下丕丘丟三丞丘上万();
                val_51 = val_50 * 100f;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.InpactCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8156"), arg0:  UnityEngine.Mathf.CeilToInt(f:  val_51).ToString()(UnityEngine.Mathf.CeilToInt(f:  val_51).ToString()) + " %"(" %")));
            }
            
            if(this.CalculatedRewardCountLabel == 0)
            {
                goto label_33;
            }
            
            val_50 = 丐丘丌三丏与丙且东.下丕丘丟三丞丘上万();
            val_51 = val_50 * (float)丐丘丌三丏与丙且东.三丄丝上丙丅丐丆丌().丂丁丏一丙丛业且丌();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.CalculatedRewardCountLabel, 丕丗丘丑丛与丑业丒:  UnityEngine.Mathf.CeilToInt(f:  val_51).ToString());
            goto label_33;
            label_3:
            val_46 = System.String.Format(format:  "Event Type is not {0}", arg0:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            UnityEngine.Debug.LogError(message:  val_46);
            return;
            label_15:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardPanel1, 丏业丟一东丂东丘丛:  false);
            label_33:
            if((丐丘丌三丏与丙且东.丈且丑丛东丄三丕一() == null) || (丐丘丌三丏与丙且东.丈且丑丛东丄三丕一().丂丁丏一丙丛业且丌() < 1))
            {
                goto label_43;
            }
            
            if(this.RewardEachMemberCountLabel == 0)
            {
                goto label_50;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RewardEachMemberCountLabel, 丕丗丘丑丛与丑业丒:  丐丘丌三丏与丙且东.丈且丑丛东丄三丕一().丂丁丏一丙丛业且丌());
            goto label_50;
            label_43:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardPanel2, 丏业丟一东丂东丘丛:  false);
            label_50:
            if(this.TimerLabel != 0)
            {
                    val_51 = 0f;
                this.TimerLabel.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  丐丘丌三丏与丙且东.丘丒不不丌丘下丒一(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  val_51, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            }
            
            if(this.MyClanView != 0)
            {
                    UnityEngine.Color val_32 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
                val_50 = val_32.r;
                val_52 = val_32.b;
                val_47 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
                val_51 = val_50;
                this.MyClanView.丈且东丑丂且万丒丅(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_51, g = val_32.g, b = val_52, a = val_32.a}, 万且丒下丕丝专丟上:  丐丘丌三丏与丙且东.丑七丐万丘丁丝丆下(), 且丟丅丄丒丑丂丁世:  val_47);
            }
            
            val_48 = this.RivalClanView;
            if(val_48 != 0)
            {
                    val_48 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  丐丘丌三丏与丙且东.丂丅丏丘世且丅丗三());
                val_47 = 丐丘丌三丏与丙且东.专东丏与万下丑丂丅();
                UnityEngine.Color val_42 = PGCompany.丂丘丞丂丏七丁丄不.丗丛世丌丕专丝丘丙(丄丝丏上丄丛丘丟丆:  val_47);
                val_50 = val_42.r;
                val_52 = val_42.b;
                int val_43 = 丐丘丌三丏与丙且东.世万丙丘丂上丗与三();
                this.RivalClanView.丈且东丑丂且万丒丅(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_50, g = val_42.g, b = val_52, a = val_42.a}, 万且丒下丕丝专丟上:  val_43, 且丟丅丄丒丑丂丁世:  val_48);
            }
            
            if(val_43 != 0)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  val_43);
            }
            
            mem[1152921554243794256] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadEventRaidView).__il2cppRuntimeField_170));
        }
        protected override void 丙丗世不三丕丄上丂()
        {
            mem[1152921554244090576] = 0;
            if(((17542 != 0) && ((17542 & 1) != 0)) && (1379926026 != 0))
            {
                    mem[1152921554244090576] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadEventRaidView).__il2cppRuntimeField_170));
                return;
            }
            
            mem[1152921554244090552] = 0;
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
            SquadPanelGUI.丄丘七三上丕世丞业.丞丆丕丞丝丝丌丆丗(丕丗丘丑丛与丑业丒:  "Raid no longer available");
        }
        public ClanWarSquadEventRaidView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
