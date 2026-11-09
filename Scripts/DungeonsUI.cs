using UnityEngine;
public class DungeonsUI : MonoBehaviour
{
    // Fields
    public UILabel[] waitPlayersLabel;
    public UILabel[] mapNameLabel;
    public UILabel[] startTimerLabel;
    public UnityEngine.GameObject battleTimerLabel;
    public UnityEngine.GameObject battleBeginsLabel;
    public UILabel tipLabel;
    public UnityEngine.GameObject backButton;
    public UnityEngine.GameObject restartButton;
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
        UILabel val_11;
        bool val_12;
        UnityEngine.GameObject val_13;
        int val_11 = 三丐东三丒丛丗丅三;
        val_11 = this;
        bool val_3 = (丛丅丘一丏丙且丌上 | 丟丗丕不丏与丂丂丌) ^ 1;
        this.waitPlayersLabel[0].gameObject.SetActive(value:  val_3);
        val_12 = ((val_11 > 0) ? 1 : 0) & 丛丅丘一丏丙且丌上;
        this.battleTimerLabel.SetActive(value:  val_12);
        val_11 = ((val_11 < 1) ? 1 : 0) & 丛丅丘一丏丙且丌上;
        this.battleBeginsLabel.SetActive(value:  val_11);
        val_13 = this.backButton;
        val_13.SetActive(value:  val_3);
        if(丛丅丘一丏丙且丌上 == false)
        {
                return;
        }
        
        val_12 = 1152921505072021504;
        val_13 = 0;
        goto label_9;
        label_17:
        val_11 = this.startTimerLabel[0];
        if(val_11 >= 1)
        {
                string val_8 = val_11.ToString();
        }
        
        val_11.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4627");
        val_13 = 1;
        label_9:
        if(val_13 < this.startTimerLabel.Length)
        {
            goto label_17;
        }
    
    }
    private void 丁丘丝丁丈专丆业丂()
    {
        int val_5;
        if(this.tipLabel == 0)
        {
                return;
        }
        
        if(this.且丅丄丛万丟丁丄丛 > 0f)
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.且丅丄丛万丟丁丄丛 - val_2;
            this.且丅丄丛万丟丁丄丛 = val_2;
            return;
        }
        
        int val_3 = this.下不丈下业世丝丟业 + 1;
        this.下不丈下业世丝丟业 = val_3;
        if(val_3 < this.不七丟丈东丆丕东丑.Length)
        {
                val_5 = this.下不丈下业世丝丟业;
        }
        else
        {
                val_5 = 0;
            this.下不丈下业世丝丟业 = 0;
        }
        
        this.且丅丄丛万丟丁丄丛 = this.丕丂专丄丟丁丕万上;
        this.tipLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.不七丟丈东丆丕东丑[0]);
    }
    internal void 丑丁不万丈丟万且业()
    {
        UILabel val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = this;
        this.丁丘丝丁丈专丆业丂();
        val_4 = 0;
        goto label_3;
        label_7:
        this.waitPlayersLabel[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4630");
        val_4 = 1;
        label_3:
        if(val_4 < this.waitPlayersLabel.Length)
        {
            goto label_7;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = 0;
        goto label_12;
        label_16:
        val_3 = this.mapNameLabel[0];
        val_3.text = 上丘丙丒一丈丕丈世();
        val_6 = 1;
        label_12:
        if(val_6 < this.mapNameLabel.Length)
        {
            goto label_16;
        }
    
    }
    public DungeonsUI()
    {
        string[] val_1 = new string[3];
        val_1[0] = "Key_7043";
        val_1[1] = "Key_7046";
        val_1[2] = "Key_7047";
        this.不七丟丈东丆丕东丑 = val_1;
        this.丕丂专丄丟丁丕万上 = 10f;
        this.下不丈下业世丝丟业 = 0;
    }

}
