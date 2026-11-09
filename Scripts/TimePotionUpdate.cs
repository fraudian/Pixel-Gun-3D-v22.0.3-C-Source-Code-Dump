using UnityEngine;
public class TimePotionUpdate : MonoBehaviour
{
    // Fields
    public UILabel myLabel;
    public UnityEngine.GameObject mySpriteObj;
    public string myPotionName;
    public float timerUpdate;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(this.myLabel.enabled == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.timerUpdate - val_2;
        this.timerUpdate = val_2;
        if(val_2 >= 0)
        {
                return;
        }
        
        this.timerUpdate = 0.25f;
        this.且丒丟丕丝丒三专丂();
    }
    private void 且丒丟丕丝丒三专丂()
    {
        UILabel val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        val_11 = this;
        val_12 = null;
        val_12 = null;
        val_13 = this.myPotionName;
        if((PotionsController.丄丞丁丈与业上丞丟.PotionIsActive(丛丄万三丂东丙丑东:  val_13)) == false)
        {
            goto label_4;
        }
        
        if(this.mySpriteObj != 0)
        {
                if(this.mySpriteObj.activeSelf != true)
        {
                this.mySpriteObj.SetActive(value:  true);
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        float val_4 = PotionsController.丄丞丁丈与业上丞丟.RemainDuratioForPotion(丄万丗专专丐丁丘丄:  this.myPotionName);
        System.TimeSpan val_5 = System.TimeSpan.FromSeconds(value:  (double)val_4);
        val_13 = System.String.Format(format:  "{0:D2}:{1:D2}", arg0:  val_5._ticks.Minutes, arg1:  val_5._ticks.Seconds);
        this.myLabel.text = val_13;
        val_11 = this.myLabel;
        if(val_4 <= 5f)
        {
            goto label_17;
        }
        
        val_15 = 1f;
        goto label_18;
        label_4:
        if(this.mySpriteObj == 0)
        {
                return;
        }
        
        if(this.mySpriteObj.activeSelf == false)
        {
                return;
        }
        
        this.mySpriteObj.SetActive(value:  false);
        val_11 = System.String.alignConst;
        this.myLabel.text = val_11;
        return;
        label_17:
        val_15 = 0f;
        label_18:
        val_11.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public void UpdateTime()
    {
        var val_6;
        var val_7;
        val_6 = null;
        val_6 = null;
        float val_1 = PotionsController.丄丞丁丈与业上丞丟.RemainDuratioForPotion(丄万丗专专丐丁丘丄:  this.myPotionName);
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)val_1);
        this.myLabel.text = System.String.Format(format:  "{0:D2}:{1:D2}", arg0:  val_2._ticks.Minutes, arg1:  val_2._ticks.Seconds);
        if(val_1 > 5f)
        {
                val_7 = 1f;
        }
        else
        {
                val_7 = 0f;
        }
        
        this.myLabel.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public TimePotionUpdate()
    {
        this.timerUpdate = -1f;
    }

}
