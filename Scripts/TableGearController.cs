using UnityEngine;
public class TableGearController : MonoBehaviour
{
    // Fields
    internal static TableGearController 丄丞丁丈与业上丞丟;
    public TimePotionUpdate[] potionLables;
    public UITable table;
    public UILabel activatePotionLabel;
    private string[] 丆东丘丑业丂上丘丘;
    private string[] 东下一丅东丛业且七;
    private float 业丂不丂上丁丙丁丆;
    
    // Methods
    private void Start()
    {
        null = null;
        TableGearController.丄丞丁丈与业上丞丟 = this;
    }
    private void OnDestroy()
    {
        null = null;
        TableGearController.丄丞丁丈与业上丞丟 = 0;
    }
    private void Update()
    {
        float val_18;
        var val_19;
        var val_20;
        string val_21;
        TimePotionUpdate val_22;
        float val_23;
        val_18 = this.业丂不丂上丁丙丁丆;
        if(val_18 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_18 - val_1;
            this.业丂不丂上丁丙丁丆 = val_1;
            if(val_1 < 0)
        {
                this.activatePotionLabel.gameObject.SetActive(value:  false);
        }
        
        }
        
        val_19 = 0;
        goto label_71;
        label_75:
        val_20 = null;
        val_20 = null;
        TimePotionUpdate val_18 = this.potionLables[0];
        val_21 = this.potionLables[0].gameObject;
        bool val_5 = val_21.activeSelf;
        if((PotionsController.丄丞丁丈与业上丞丟.PotionIsActive(丛丄万三丂东丙丑东:  this.potionLables[0x0][0].myPotionName)) == false)
        {
            goto label_16;
        }
        
        if(val_5 == true)
        {
            goto label_17;
        }
        
        this.potionLables[0].transform.GetChild(index:  0).GetComponent<TweenScale>().enabled = true;
        this.potionLables[0].gameObject.SetActive(value:  true);
        this.且东丕丌丆一丌丏上();
        TimePotionUpdate val_22 = this.potionLables[0];
        object val_11 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  this.potionLables[0x0][0].myPotionName);
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_38;
        }
        
        if(this.东下一丅东丛业且七 != null)
        {
            goto label_72;
        }
        
        label_73:
        label_72:
        val_21 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.东下一丅东丛业且七[null]);
        this.activatePotionLabel.text = val_21;
        this.activatePotionLabel.gameObject.SetActive(value:  true);
        this.业丂不丂上丁丙丁丆 = 2f;
        label_17:
        val_22 = this.potionLables[0];
        if(val_22 == null)
        {
            goto label_48;
        }
        
        val_23 = this.potionLables[0x0][0].timerUpdate;
        val_18 = UnityEngine.Time.deltaTime;
        goto label_49;
        label_16:
        if(val_5 == false)
        {
            goto label_64;
        }
        
        this.potionLables[0].gameObject.SetActive(value:  false);
        TimePotionUpdate val_25 = this.potionLables[0];
        val_21 = this.potionLables[0x0][0].myLabel;
        val_21.text = System.String.alignConst;
        if(this.table != null)
        {
            goto label_64;
        }
        
        goto label_64;
        label_48:
        val_23 = 0f;
        float val_17 = UnityEngine.Time.deltaTime;
        val_18 = val_17;
        val_22 = 48;
        label_49:
        val_17 = val_23 - val_18;
        mem[48] = val_17;
        TimePotionUpdate val_26 = this.potionLables[0];
        if(this.potionLables[0x0][0].timerUpdate < 0)
        {
                TimePotionUpdate val_27 = this.potionLables[0];
            this.potionLables[0x0][0].timerUpdate = 0.25f;
            this.potionLables[0].UpdateTime();
        }
        
        label_64:
        val_19 = 1;
        goto label_71;
        label_38:
        if(this.丆东丘丑业丂上丘丘 != null)
        {
            goto label_72;
        }
        
        goto label_73;
        label_71:
        if(val_19 < this.potionLables.Length)
        {
            goto label_75;
        }
    
    }
    private void 且东丕丌丆一丌丏上()
    {
        int val_1;
        var val_8;
        var val_9;
        var val_10;
        val_8 = 0;
        goto label_1;
        label_17:
        val_9 = null;
        val_9 = null;
        object val_4 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  Item[val_1]);
        this.potionLables[null].name = ToString();
        val_8 = val_1 + 1;
        label_1:
        val_10 = null;
        val_1 = val_8;
        val_10 = null;
        if(val_8 < Count)
        {
            goto label_17;
        }
    
    }
    public void ReactivatePotion(string 丕且丙丙且下丛丟丒)
    {
        object val_2 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  丕且丙丙且下丛丟丒);
        this.potionLables[null].transform.GetChild(index:  0).GetComponent<TweenScale>().enabled = true;
        this.且东丕丌丆一丌丏上();
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_14;
        }
        
        if(this.东下一丅东丛业且七 != null)
        {
            goto label_22;
        }
        
        label_23:
        label_22:
        this.activatePotionLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.东下一丅东丛业且七[null]);
        this.activatePotionLabel.gameObject.SetActive(value:  true);
        this.业丂不丂上丁丙丁丆 = 2f;
        return;
        label_14:
        if(this.丆东丘丑业丂上丘丘 != null)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    public TableGearController()
    {
        string[] val_1 = new string[4];
        val_1[0] = "Key_1813";
        val_1[1] = "Key_1810";
        val_1[2] = "Key_1812";
        val_1[3] = "Key_1811";
        this.丆东丘丑业丂上丘丘 = val_1;
        string[] val_2 = new string[4];
        val_2[0] = "Key_1853";
        val_2[1] = "Key_1851";
        val_2[2] = "Key_1854";
        val_2[3] = "Key_1852";
        this.东下一丅东丛业且七 = val_2;
        this.业丂不丂上丁丙丁丆 = -1f;
    }
    private static TableGearController()
    {
    
    }

}
