using UnityEngine;
public class BattleRoyaleUIContainer : MonoBehaviour
{
    // Fields
    public UILabel timerLabel;
    public UILabel alivePlayerCount;
    public UILabel deadPlayerCount;
    public UISprite timerIcon;
    private const string 世七丈业不丁丝丈丏 = "Royal_parachute";
    private const string 万丛下丄丑丁丙一丛 = "Royal_time";
    private const string 丑丒丞丝万丛丁丌丂 = "Royal_storm";
    
    // Methods
    private void Awake()
    {
    
    }
    private void Update()
    {
        UILabel val_23;
        var val_24;
        float val_25;
        UISprite val_26;
        string val_27;
        var val_28;
        var val_29;
        var val_30;
        val_23 = this;
        val_24 = 1152921505039699968;
        if(BattleRoyaleController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
        double val_5 = BattleRoyaleController.丄专丕丞丟七丐丞世();
        BattleRoyaleController val_6 = BattleRoyaleController.丑七不且上丗丁一世();
        val_5 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - val_5;
        float val_23 = (float)val_5;
        val_23 = val_3.timeFlyShutle - val_23;
        float val_7 = UnityEngine.Mathf.Clamp(value:  val_23, min:  0f, max:  val_6.timeFlyShutle);
        if((val_7 > 0f) && (val_1.isStartGame != false))
        {
                val_25 = UnityEngine.Mathf.Max(a:  0f, b:  val_7);
            this.timerLabel.text = Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  val_25);
            val_26 = this.timerIcon;
            val_27 = "Royal_parachute";
        }
        else
        {
                if(val_1.safeZones.zoneNextTimer > 0f)
        {
                val_25 = UnityEngine.Mathf.Max(a:  0f, b:  val_1.safeZones.zoneNextTimer);
            this.timerLabel.text = Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  val_25);
            val_26 = this.timerIcon;
            val_27 = "Royal_time";
        }
        else
        {
                val_25 = UnityEngine.Mathf.Max(a:  0f, b:  val_1.safeZones.zoneMoveTimer);
            this.timerLabel.text = Player_move_c.丅世丏丐丘丁丌丂丕(丞丘丑丗丑专且丕丘:  val_25);
            val_26 = this.timerIcon;
            val_27 = "Royal_storm";
        }
        
        }
        
        val_26.spriteName = val_27;
        this.alivePlayerCount.text = val_26.GetAlivePlayerCount().ToString();
        val_24 = 1152921505286238208;
        val_28 = null;
        val_28 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_29 = null;
            val_29 = null;
            val_30 = 0;
            int val_21 = UnityEngine.Mathf.Max(a:  0, b:  丑丛丆三丆丄七丐万());
        }
        else
        {
                val_30 = 0;
        }
        
        val_23 = this.deadPlayerCount;
        val_23.text = val_30.ToString();
    }
    public BattleRoyaleUIContainer()
    {
    
    }

}
