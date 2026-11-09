using UnityEngine;

namespace PGCompany
{
    public class ClanWarSquadTaskView : ClanWarMapItemViewBase
    {
        // Fields
        private UILabel TaskDescriptionLabel;
        private UILabel MapNumberLabel;
        private UITexture MapPreviewTexture;
        private UILabel MapNameLabel;
        private UILabel ModeNameLabel;
        private UILabel RewardCountLabel;
        private PGCompany.ProgressBarView ClanProgressBar;
        private UISprite MyContributionProgressBar;
        private ModulesTableUI DungeonModulesPanel;
        private UnityEngine.GameObject moduleTables;
        private ModulesTableUI monstersTable;
        private ModulesTableUI bossesTable;
        private UILabel RivalClanNameLabel;
        private UILabel RivalClanTanlPowerLabel;
        private UILabel RivalClanFortPowerLabel;
        
        // Methods
        internal void 丞丝丈丅丅丅丆丕丝(PGCompany.丁下丒丕丆下丂丆丌 丌丝万上丅丒一丈丘)
        {
            UISprite val_95;
            UILabel val_96;
            string val_97;
            string val_98;
            UnityEngine.GameObject val_99;
            var val_100;
            var val_101;
            var val_102;
            var val_103;
            string val_104;
            object val_105;
            string val_106;
            var val_107;
            var val_108;
            UILabel val_109;
            string val_110;
            UnityEngine.MonoBehaviour val_111;
            var val_112;
            if((丌丝万上丅丒一丈丘 == null) || (丌丝万上丅丒一丈丘.下三下东业丘且丟业() == null))
            {
                goto label_2;
            }
            
            mem[1152921554245960664] = 丌丝万上丅丒一丈丘;
            PGCompany.GameTaskActionSettings val_4 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            if(this.TaskDescriptionLabel == 0)
            {
                goto label_23;
            }
            
            if(val_4.Type != 52)
            {
                goto label_9;
            }
            
            PGCompany.GameTaskActionSettings val_8 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            if(val_8.GameMode == 26)
            {
                    PGCompany.世丐下丕专东丘丏且 val_10 = X23.下三下东业丘且丟业();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.TaskDescriptionLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8976"), arg0:  val_10.东且丟万下万世丟东().ToString()));
            }
            
            PGCompany.GameTaskActionSettings val_16 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            if(val_16.GameMode != 27)
            {
                goto label_23;
            }
            
            val_96 = this.TaskDescriptionLabel;
            string val_21 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8979"), arg0:  val_10.下三下东业丘且丟业().东且丟万下万世丟东().ToString());
            goto label_28;
            label_2:
            mem[1152921554245960664] = 0;
            return;
            label_9:
            val_96 = this.TaskDescriptionLabel;
            val_97 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业();
            label_28:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_96, 丕丗丘丑丛与丑业丒:  val_97);
            label_23:
            if(this.MapNumberLabel != 0)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.MapNumberLabel, 丕丗丘丑丛与丑业丒:  丌丝万上丅丒一丈丘.下三下东业丘且丟业());
            }
            
            PGCompany.GameTaskActionSettings val_27 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            val_98 = val_27.Map;
            PGCompany.GameTaskActionSettings val_30 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            this.DungeonModulesPanel.gameObject.SetActive(value:  false);
            val_99 = this.moduleTables;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_99, 丏业丟一东丂东丘丛:  false);
            if((System.String.IsNullOrEmpty(value:  val_98)) != true)
            {
                    val_100 = static_value_081DACA8;
                val_100 = static_value_081DACA8;
                if((static_value_081DACA8 + 184 + 16) != 0)
            {
                    if((val_4.Type != 52) && (this.MapPreviewTexture != 0))
            {
                    val_101 = static_value_081DACA8;
                val_101 = static_value_081DACA8;
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.MapPreviewTexture, 与万丆丛丒万丝丙丑:  static_value_081DACA8 + 184 + 16.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_98));
            }
            
            }
            
                val_102 = null;
                val_102 = null;
                val_99 = 0;
                if(SceneInfoController.丄丘七三上丕世丞业 != 0)
            {
                    val_103 = null;
                val_103 = null;
                val_99 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_98);
            }
            
                if(this.MapNameLabel != 0)
            {
                    if(val_99 != 0)
            {
                    val_98 = val_99.七丛一丛专七丈丅专();
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.MapNameLabel, 丕丗丘丑丛与丑业丒:  val_98);
            }
            
                if(val_30.GameMode == 22)
            {
                    this.DungeonModulesPanel.gameObject.SetActive(value:  true);
                val_99 = val_37.indexMap;
                this.DungeonModulesPanel.UpdateModules(丞丒丌丄丄丏下下专:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕(), 下丞七丒业丂丈丘下:  val_99);
            }
            
                PGCompany.GameTaskActionSettings val_46 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
                if(val_46.Type == 52)
            {
                    PGCompany.GameTaskActionSettings val_49 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moduleTables, 丏业丟一东丂东丘丛:  (val_49.GameMode == 26) ? 1 : 0);
                this.monstersTable.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  false);
                this.bossesTable.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  true);
                val_104 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.下丁丙一丄丈不不丁());
                if(val_104 != null)
            {
                    val_105 = val_104.东丙上东业丆不丟丘();
            }
            else
            {
                    val_105 = 0;
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RivalClanNameLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8981"), arg0:  val_105));
                if(val_104 != null)
            {
                    val_106 = val_104.三丒三丕不七丁丅丈().ToString();
            }
            else
            {
                    val_106 = 0;
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RivalClanTanlPowerLabel, 丕丗丘丑丛与丑业丒:  val_106);
                val_99 = this.RivalClanFortPowerLabel;
                if(val_104 != null)
            {
                    val_104 = val_104.上上三七丟丝与丆与().ToString();
            }
            
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_99, 丕丗丘丑丛与丑业丒:  val_104);
            }
            
            }
            
            val_107 = 0;
            if(this.ModeNameLabel == 0)
            {
                goto label_115;
            }
            
            if(val_30.GameMode == 100)
            {
                goto label_116;
            }
            
            if(val_30.GameMode != 22)
            {
                goto label_117;
            }
            
            val_108 = null;
            val_108 = null;
            val_99 = GameConnect.丗丗丈一不丂丛丞丒;
            int val_66 = UnityEngine.Mathf.Clamp(value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕(), min:  0, max:  GameConnect.丗丗丈一不丂丛丞丒.Length - 1);
            System.String[] val_67 = val_99 + (((long)(int)(val_66)) << 3);
            val_109 = this.ModeNameLabel;
            val_110 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (GameConnect.丗丗丈一不丂丛丞丒 + ((long)(int)(val_66)) << 3) + 32);
            goto label_130;
            label_116:
            val_111 = this.ModeNameLabel;
            val_112 = 0;
            goto label_133;
            label_117:
            val_99 = GameConnect.丛丛丏专丏下三与七();
            var val_95 = 0;
            val_95 = val_95 + 1;
            val_107 = 0;
            val_109 = this.ModeNameLabel;
            val_110 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_99.Item[null]);
            label_130:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_109, 丕丗丘丑丛与丑业丒:  val_110);
            val_112 = 1;
            val_111 = this.ModeNameLabel;
            label_133:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_111, 丏业丟一东丂东丘丛:  true);
            label_115:
            if((this.RewardCountLabel != 0) && (丌丝万上丅丒一丈丘.下三下东业丘且丟业().丈丏丁东上与东丙丕().Count >= 2))
            {
                    val_99 = 1152921526212668928;
                if(丌丝万上丅丒一丈丘.下三下东业丘且丟业().丈丏丁东上与东丙丕().Item[1] != null)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.RewardCountLabel, 丕丗丘丑丛与丑业丒:  丌丝万上丅丒一丈丘.下三下东业丘且丟业().丈丏丁东上与东丙丕().Item[1].丂丁丏一丙丛业且丌().ToString());
            }
            
            }
            
            if(this.ClanProgressBar != 0)
            {
                    val_99 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
                UnityEngine.Color val_90 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
                this.ClanProgressBar.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  (float)丌丝万上丅丒一丈丘.下三下东业丘且丟业().且丆丟业丞丕丑上且(), 七丝东丛东丝且丆不:  (float)val_99, 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  0);
            }
            
            val_95 = this.MyContributionProgressBar;
            if(val_95 != 0)
            {
                    val_95 = this.MyContributionProgressBar;
                val_95.fillAmount = 丌丝万上丅丒一丈丘.下丕丘丟三丞丘上万();
            }
            
            if(丌丝万上丅丒一丈丘 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  丌丝万上丅丒一丈丘);
            }
            
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadTaskView).__il2cppRuntimeField_170);
            mem[1152921554245960672] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action());
        }
        protected override void 丙丗世不三丕丄上丂()
        {
            var val_7;
            mem[1152921554246523248] = 0;
            if(17547 == 0)
            {
                goto label_7;
            }
            
            val_7 = 0;
            if(17547.下三下东业丘且丟业() == null)
            {
                goto label_2;
            }
            
            val_7 = 0;
            bool val_3 = 下三下东业丘且丟业().丈丐丞丐上丑且丕万();
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_2:
            if(val_3 != false)
            {
                    val_7 = 0;
                if(val_3.下三下东业丘且丟业() != null)
            {
                    mem[1152921554246523248] = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  5f, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  typeof(PGCompany.ClanWarSquadTaskView).__il2cppRuntimeField_170));
                return;
            }
            
            }
            
            label_7:
            mem[1152921554246523240] = 0;
        }
        protected override void 丘丛不丕不专丈三世()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(this.gameObject == 0)
            {
                    return;
            }
            
            val_5 = this.gameObject;
            if(val_5.activeInHierarchy == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            SquadPanelGUI.丄丘七三上丕世丞业.丞丆丕丞丝丝丌丆丗(丕丗丘丑丛与丑业丒:  "Task no longer available");
        }
        public ClanWarSquadTaskView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
