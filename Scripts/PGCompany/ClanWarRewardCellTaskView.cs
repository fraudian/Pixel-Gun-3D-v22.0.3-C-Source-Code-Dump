using UnityEngine;

namespace PGCompany
{
    public class ClanWarRewardCellTaskView : ClanWarRewardItemViewBase
    {
        // Fields
        protected UILabel DescriptionLabel;
        protected UILabel TaskIDLabel;
        
        // Methods
        internal void 上丛丌丆丑上七世三(PGCompany.丛丝丏丂东丏专三丁 丗七丟丈三不丕一三)
        {
            UILabel val_32;
            string val_33;
            System.String[] val_34;
            var val_35;
            var val_36;
            val_33 = 丗七丟丈三不丕一三;
            PGCompany.丁下丒丕丆下丂丆丌 val_1 = val_33.三专丞万丙丈丂丟且();
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.下三下东业丘且丟业() == null)
            {
                    return;
            }
            
            PGCompany.GameTaskActionSettings val_6 = val_33.三专丞万丙丈丂丟且().下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            PGCompany.GameTaskActionSettings val_10 = val_33.三专丞万丙丈丂丟且().下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            val_34 = 1152921505052479488;
            val_35 = static_value_081DACA8;
            val_35 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16) != 0)
            {
                    if((System.String.IsNullOrEmpty(value:  val_6.Map)) != true)
            {
                    string[] val_13 = new string[5];
                val_34 = val_13;
                val_34[0] = "LevelLoadingsPreview";
                val_34[1] = (东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != true) ? "/Hi" : "";
                val_34[2] = "/Loading_";
                val_34[3] = (val_10.Type == 52) ? "Mine_" : "";
                val_34[4] = val_6.Map;
                UnityEngine.Object val_18 = UnityEngine.Resources.Load(path:  +val_13);
                val_36 = 0;
                丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  static_value_081DACA8 + 184 + 16, 与万丆丛丒万丝丙丑:  null);
            }
            
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  val_33.丁丘丕丈丄世丞丁丆().ToString());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  val_33.丛且丁上业万丟丒丈().ToString());
            float val_32 = 100f;
            val_32 = val_33.丒丝丄丆东丘三上丝() * val_32;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8156"), arg0:  UnityEngine.Mathf.RoundToInt(f:  val_32)(UnityEngine.Mathf.RoundToInt(f:  val_32)) + " %"(" %")));
            val_32 = this.DescriptionLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_32, 丕丗丘丑丛与丑业丒:  val_33.丒丗丝不丕丈世丏丞());
            val_33 = val_33.三专丞万丙丈丂丟且().下三下东业丘且丟业();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.TaskIDLabel, 丕丗丘丑丛与丑业丒:  val_33);
        }
        public ClanWarRewardCellTaskView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
