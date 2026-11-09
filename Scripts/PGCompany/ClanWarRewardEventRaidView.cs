using UnityEngine;

namespace PGCompany
{
    public class ClanWarRewardEventRaidView : ClanWarRewardItemViewBase
    {
        // Fields
        private UILabel[] _titleLabels;
        private PGCompany.ClanWarSquadEventFortView MyClanView;
        private PGCompany.ClanWarSquadEventFortView RivalClanView;
        private UnityEngine.GameObject rewardContainer;
        private UISprite frame;
        private const string 丟丝七丛专丄丑丆丈 = "Key_8476";
        private const string 丂不丛一丐万丕万丘 = "Key_8526";
        private const string 丂丛丟七丌下丛丂业 = "Key_8527";
        
        // Methods
        internal void 上丛丌丆丑上七世三(PGCompany.丛丝丏丂东丏专三丁 丗七丟丈三不丕一三)
        {
            丞丂丘丒丟丞丑下丄 val_34;
            string val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            UISprite val_42;
            int val_47;
            PGCompany.ClanWarSquadEventFortView val_48;
            val_34 = this;
            PGCompany.丟与丞丗丌丂万丕丝 val_1 = 丗七丟丈三不丕一三.业三上丈丙万丂丗丐();
            if(val_1 == null)
            {
                    return;
            }
            
            PGCompany.ClanWarEventConfig val_2 = val_1.世丈丁业丛上丘丗丐();
            PGCompany.丟与丞丗丌丂万丕丝 val_3 = 丗七丟丈三不丕一三.业三上丈丙万丂丗丐();
            if(val_3 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            int val_4 = val_3.丑七丐万丘丁丝丆下();
            val_35 = val_3.世万丙丘丂上丗与三();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rewardContainer, 丏业丟一东丂东丘丛:  (val_4 > val_35) ? 1 : 0);
            if(val_4 > val_35)
            {
                    UnityEngine.Color val_7 = UnityEngine.Color.green;
                val_36 = val_7.b;
                val_37 = val_7.g;
                val_38 = val_36;
                val_39 = val_7.a;
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.frame, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_37, b = val_38, a = val_39});
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.frame, 丕丗丘丑丛与丑业丒:  丗七丟丈三不丕一三.丁丘丕丈丄世丞丁丆().ToString());
                int val_10 = 丗七丟丈三不丕一三.丛且丁上业万丟丒丈();
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.frame, 丕丗丘丑丛与丑业丒:  val_10.ToString());
                val_40 = 丗七丟丈三不丕一三.丒丝丄丆东丘三上丝();
                val_41 = val_40 * 100f;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.frame, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8156"), arg0:  UnityEngine.Mathf.RoundToInt(f:  val_41)(UnityEngine.Mathf.RoundToInt(f:  val_41)) + " %"(" %")));
            }
            else
            {
                    if(val_4 < val_35)
            {
                    val_42 = this.frame;
                UnityEngine.Color val_17 = UnityEngine.Color.red;
            }
            else
            {
                    val_42 = this.frame;
                UnityEngine.Color val_18 = UnityEngine.Color.gray;
            }
            
                val_40 = val_18.r;
                val_36 = val_18.b;
                val_41 = val_40;
                val_37 = val_18.g;
                val_38 = val_36;
                val_39 = val_18.a;
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_42, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_41, g = val_37, b = val_38, a = val_39});
            }
            
            val_47 = 0;
            goto label_23;
            label_30:
            val_35 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8527");
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabels[val_10], 丕丗丘丑丛与丑业丒:  val_35);
            val_47 = val_10 + 1;
            label_23:
            if(val_47 < this._titleLabels.Length)
            {
                goto label_30;
            }
            
            if(this.MyClanView != 0)
            {
                    UnityEngine.Color val_21 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
                val_40 = val_21.r;
                val_36 = val_21.b;
                val_35 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
                val_41 = val_40;
                val_37 = val_21.g;
                val_38 = val_36;
                val_39 = val_21.a;
                this.MyClanView.丈且东丑丂且万丒丅(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_41, g = val_37, b = val_38, a = val_39}, 万且丒下丕丝专丟上:  val_3.丑七丐万丘丁丝丆下(), 且丟丅丄丒丑丂丁世:  val_35);
            }
            
            val_48 = this.RivalClanView;
            if(val_48 == 0)
            {
                    return;
            }
            
            val_48 = this.RivalClanView;
            val_34 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  val_3.丂丅丏丘世且丅丗三());
            UnityEngine.Color val_31 = PGCompany.丂丘丞丂丏七丁丄不.丗丛世丌丕专丝丘丙(丄丝丏上丄丛丘丟丆:  val_3.专东丏与万下丑丂丅());
            val_40 = val_31.r;
            val_36 = val_31.b;
            val_48.丈且东丑丂且万丒丅(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_40, g = val_31.g, b = val_36, a = val_31.a}, 万且丒下丕丝专丟上:  val_3.世万丙丘丂上丗与三(), 且丟丅丄丒丑丂丁世:  val_34);
        }
        public ClanWarRewardEventRaidView()
        {
            val_1 = new PGBehaviour();
        }
    
    }

}
