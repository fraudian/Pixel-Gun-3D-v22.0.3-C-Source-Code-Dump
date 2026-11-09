using UnityEngine;
public class ExecuteOnEnableOnce : MonoBehaviour
{
    // Fields
    public UnityEngine.Events.UnityEvent onEnable;
    public UnityEngine.GameObject[] activateOnEnable;
    private float 丗丏三与丁一丑丗上;
    private float 一丞丕丈丐丒丗丐上;
    private bool 丈丗且万丟业丂丁丗;
    
    // Properties
    public bool 且不三东且七万丌丌 { get; set; }
    
    // Methods
    public ExecuteOnEnableOnce()
    {
        this.一丞丕丈丐丒丗丐上 = 0.5f;
        this.丈丗且万丟业丂丁丗 = true;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_3 = System.DateTime.Now;
        System.DateTime val_5 = System.DateTime.Now;
        int val_7 = val_1.dateData.Hour * 3600;
        val_7 = val_7 + (val_3.dateData.Minute * 60);
        val_7 = val_7 + val_5.dateData.Second;
        this.一丞丕丈丐丒丗丐上 = 0.5f;
        this.丗丏三与丁一丑丗上 = (float)val_7;
        this.丈丗且万丟业丂丁丗 = true;
    }
    public bool get_NeedPlay()
    {
        return (bool)this.丈丗且万丟业丂丁丗;
    }
    public void set_NeedPlay(bool 丙业与丙丗丝不丈东)
    {
        var val_9;
        if(丙业与丙丗丝不丈东 != false)
        {
                System.DateTime val_1 = System.DateTime.Now;
            val_9 = val_1.dateData.Hour;
            System.DateTime val_3 = System.DateTime.Now;
            System.DateTime val_5 = System.DateTime.Now;
            int val_7 = val_9 * 3600;
            val_7 = val_7 + (val_3.dateData.Minute * 60);
            val_7 = val_7 + val_5.dateData.Second;
            this.丗丏三与丁一丑丗上 = (float)val_7;
        }
        
        this.丈丗且万丟业丂丁丗 = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        UnityEngine.GameObject[] val_8;
        var val_9;
        var val_10;
        if(this.丈丗且万丟业丂丁丗 == false)
        {
                return;
        }
        
        System.DateTime val_1 = System.DateTime.Now;
        var val_8 = val_1.dateData.Hour;
        System.DateTime val_3 = System.DateTime.Now;
        System.DateTime val_5 = System.DateTime.Now;
        int val_7 = val_8 * 3600;
        val_7 = val_7 + (val_3.dateData.Minute * 60);
        val_8 = val_7 + val_5.dateData.Second;
        float val_9 = (float)val_8;
        val_9 = this.丗丏三与丁一丑丗上 - val_9;
        if(System.Math.Abs(val_9) <= this.一丞丕丈丐丒丗丐上)
        {
            goto label_6;
        }
        
        this.onEnable.Invoke();
        val_8 = this.activateOnEnable;
        val_9 = 0;
        goto label_8;
        label_12:
        val_8[0].SetActive(value:  true);
        val_9 = 1;
        label_8:
        if(val_9 < this.activateOnEnable.Length)
        {
            goto label_12;
        }
        
        goto label_13;
        label_6:
        val_8 = this.activateOnEnable;
        val_10 = 0;
        goto label_14;
        label_18:
        val_8[0].SetActive(value:  false);
        val_10 = 1;
        label_14:
        if(val_10 < this.activateOnEnable.Length)
        {
            goto label_18;
        }
        
        label_13:
        this.丈丗且万丟业丂丁丗 = false;
    }
    private void OnDisable()
    {
        goto label_0;
        label_4:
        this.activateOnEnable[0].SetActive(value:  false);
        0 = 1;
        label_0:
        if(0 < this.activateOnEnable.Length)
        {
            goto label_4;
        }
    
    }

}
