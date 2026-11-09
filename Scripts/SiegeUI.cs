using UnityEngine;
public class SiegeUI : MonoBehaviour
{
    // Fields
    public UILabel[] team1Label;
    public UILabel[] team1Clan;
    public UILabel[] team2Label;
    public UILabel[] team2Clan;
    public UILabel[] waitPlayersLabel;
    public UITexture team1Icon;
    public UITexture team2Icon;
    public UILabel[] startTimerLabel;
    public UILabel castleDefinition;
    public UnityEngine.GameObject battleTimerLabel;
    public UnityEngine.GameObject battleBeginsLabel;
    public UILabel fightClanLabel;
    public UILabel tipLabel;
    public UnityEngine.GameObject backButton;
    public UnityEngine.GameObject restartButton;
    public UnityEngine.AudioClip fortChangeClip;
    public UnityEngine.AudioClip fortSelectedClip;
    private string[] 不七丟丈东丆丕东丑;
    private float 丕丂专丄丟丁丕万上;
    private float 且丅丄丛万丟丁丄丛;
    private int 下不丈下业世丝丟业;
    private string 上丛丌丐丝七丁丟丆;
    private string 丏丘丗丟丁不丅丂不;
    
    // Methods
    public void ShowStartInterface()
    {
        this.gameObject.SetActive(value:  true);
        this.waitPlayersLabel[0].gameObject.SetActive(value:  false);
        this.battleTimerLabel.SetActive(value:  false);
    }
    internal void 丒丆且丑业世丅三上()
    {
        this.gameObject.SetActive(value:  false);
    }
    internal void 丝丂丕东专世丅丝丁(bool 丛丅丘一丏丙且丌上, int 三丐东三丒丛丗丅三, bool 丟丗丕不丏与丂丂丌)
    {
        UILabel val_14;
        bool val_15;
        UnityEngine.GameObject val_16;
        int val_14 = 三丐东三丒丛丗丅三;
        val_14 = this;
        bool val_3 = (丛丅丘一丏丙且丌上 | 丟丗丕不丏与丂丂丌) ^ 1;
        this.waitPlayersLabel[0].gameObject.SetActive(value:  val_3);
        this.castleDefinition.gameObject.SetActive(value:  丟丗丕不丏与丂丂丌 & (~丛丅丘一丏丙且丌上));
        val_15 = ((val_14 > 0) ? 1 : 0) & 丛丅丘一丏丙且丌上;
        this.battleTimerLabel.SetActive(value:  val_15);
        val_14 = ((val_14 < 1) ? 1 : 0) & 丛丅丘一丏丙且丌上;
        this.battleBeginsLabel.SetActive(value:  val_14);
        val_16 = this.backButton;
        val_16.SetActive(value:  val_3);
        if(丛丅丘一丏丙且丌上 == false)
        {
                return;
        }
        
        val_15 = 1152921505072021504;
        val_16 = 0;
        goto label_11;
        label_19:
        val_14 = this.startTimerLabel[0];
        if(val_14 >= 1)
        {
                string val_11 = val_14.ToString();
        }
        
        val_14.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4627");
        val_16 = 1;
        label_11:
        if(val_16 < this.startTimerLabel.Length)
        {
            goto label_19;
        }
    
    }
    private void 丁丘丝丁丈专丆业丂()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        string val_32;
        var val_33;
        if(this.tipLabel == 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null;
        if(丘丑丅三丆丑丌且丝() == 1)
        {
                val_24 = null;
            val_25 = SiegeController.三三万丆下一丗万丛 + 232;
        }
        else
        {
                val_26 = null;
            val_25 = SiegeController.三三万丆下一丗万丛 + 240;
        }
        
        val_27 = null;
        val_27 = null;
        if((SiegeController.三三万丆下一丗万丛 + 248) != 0)
        {
                if( != 0)
        {
                if(System == null)
        {
            goto label_26;
        }
        
        }
        
            val_28 = null;
            val_28 = null;
            if(丘丑丅三丆丑丌且丝() >= 1)
        {
                val_29 = null;
            val_29 = null;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丟东丙且世七一丕丙)) != false)
        {
                val_30 = null;
            val_30 = null;
            object val_9 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟东丙且世七一丕丙];
        }
        
            val_31 = null;
            val_31 = null;
            val_32 = GameConnect.丏丁丅丏一世世丙丏;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_32)) != false)
        {
                val_33 = null;
            val_33 = null;
            val_32 = GameConnect.丏丁丅丏一世世丙丏;
            object val_15 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[val_32];
        }
        
            this.tipLabel.gameObject.SetActive(value:  true);
            this.tipLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (null != 0) ? "Key_5929" : "Key_5928");
            return;
        }
        
        }
        
        label_26:
        this.tipLabel.gameObject.SetActive(value:  false);
    }
    internal void 丑丁不万丈丟万且业()
    {
        UILabel val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        UILabel[] val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_11 = this;
        this.丁丘丝丁丈专丆业丂();
        val_12 = null;
        val_12 = null;
        bool val_1 = SiegeController.三三万丆下一丗万丛.inAttackTeam;
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4626");
        string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4625");
        val_13 = 0;
        goto label_6;
        label_10:
        this.team1Label[0].text = (val_1 != true) ? (val_3) : (val_2);
        val_13 = 1;
        label_6:
        if(val_13 < this.team1Label.Length)
        {
            goto label_10;
        }
        
        val_14 = 0;
        goto label_11;
        label_15:
        this.team2Label[0].text = (val_1 != true) ? (val_2) : (val_3);
        val_14 = 1;
        label_11:
        if(val_14 < this.team2Label.Length)
        {
            goto label_15;
        }
        
        val_15 = null;
        val_15 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal != 1)
        {
            goto label_19;
        }
        
        val_16 = this.waitPlayersLabel;
        val_17 = 0;
        goto label_22;
        label_26:
        val_11 = val_16[0];
        val_11.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4628");
        val_17 = 1;
        label_22:
        if(val_17 < this.waitPlayersLabel.Length)
        {
            goto label_26;
        }
        
        return;
        label_19:
        val_18 = null;
        val_18 = null;
        if(SiegeController.三三万丆下一丗万丛.roomStatusGlobal != 1)
        {
            goto label_31;
        }
        
        val_16 = this.waitPlayersLabel;
        val_19 = 0;
        goto label_34;
        label_38:
        val_11 = val_16[0];
        val_11.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4629");
        val_19 = 1;
        label_34:
        if(val_19 < this.waitPlayersLabel.Length)
        {
            goto label_38;
        }
        
        return;
        label_31:
        val_16 = this.waitPlayersLabel;
        val_20 = 0;
        goto label_42;
        label_46:
        val_11 = val_16[0];
        val_11.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4630");
        val_20 = 1;
        label_42:
        if(val_20 < this.waitPlayersLabel.Length)
        {
            goto label_46;
        }
    
    }
    internal void 且专丕丙丈丐下丘丛(string 专下不丘丘丝丅七三)
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  专下不丘丘丝丅七三);
        this.fightClanLabel.gameObject.SetActive(value:  val_1 ^ 1);
        if(val_1 != false)
        {
                return;
        }
        
        this.fightClanLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4730"), arg0:  专下不丘丘丝丅七三);
    }
    public SiegeUI()
    {
        string[] val_1 = new string[1];
        val_1[0] = "Key_8239";
        this.不七丟丈东丆丕东丑 = val_1;
        this.丕丂专丄丟丁丕万上 = 10f;
        this.下不丈下业世丝丟业 = 0;
    }

}
