using UnityEngine;

namespace PGCompany
{
    public class ClanWarRewardEventSiegeView : ClanWarRewardItemViewBase
    {
        // Fields
        protected UILabel DescriptionLabel;
        protected UnityEngine.GameObject Rewards;
        protected UnityEngine.GameObject Tribute;
        
        // Methods
        internal void 上丛丌丆丑上七世三(PGCompany.丛丝丏丂东丏专三丁 丗七丟丈三不丕一三)
        {
            PGCompany.丟与丞丗丌丂万丕丝 val_1 = 丗七丟丈三不丕一三.业三上丈丙万丂丗丐();
            if(val_1 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            if(val_1.下三下东业丘且丟业() == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.DescriptionLabel, 丕丗丘丑丛与丑业丒:  val_1.下三下东业丘且丟业());
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.DescriptionLabel, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_1.丗下与丏丒不丙丞丈));
            bool val_16 = val_1.世丁丅丗世丄丅丁三();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Rewards, 丏业丟一东丂东丘丛:  val_16);
            val_16 = (~val_16) & 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Tribute, 丏业丟一东丂东丘丛:  val_16);
            if((val_16 & 1) != 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_16, 丕丗丘丑丛与丑业丒:  丗七丟丈三不丕一三.丁丘丕丈丄世丞丁丆().ToString());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_16, 丕丗丘丑丛与丑业丒:  丗七丟丈三不丕一三.丛且丁上业万丟丒丈().ToString());
            float val_17 = 100f;
            val_17 = 丗七丟丈三不丕一三.丒丝丄丆东丘三上丝() * val_17;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8156"), arg0:  UnityEngine.Mathf.RoundToInt(f:  val_17)(UnityEngine.Mathf.RoundToInt(f:  val_17)) + " %"(" %")));
        }
        public ClanWarRewardEventSiegeView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
