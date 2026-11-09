using UnityEngine;
public class UILabelFPSCounter : MonoBehaviour
{
    // Fields
    public float updateInterval;
    private UILabel 七丐丞丑丑丕世丙七;
    private float 上业世专丆东业丙丗;
    private float 丙丁与丈上与且丏丝;
    private float 丂万丞丝上丏丕丐丒;
    private float 丄丌世丛一与上下专;
    private double 一丗七丕丞上下丛丝;
    private float 丌七上丁丌且丒专万;
    
    // Methods
    private void Start()
    {
        this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
        this.丂万丞丝上丏丕丐丒 = this.updateInterval;
        this.一丗七丕丞上下丛丝 = (double)UnityEngine.Time.realtimeSinceStartup;
    }
    public float GetFPS()
    {
        return (float)this.丄丌世丛一与上下专;
    }
    public bool HasFPS()
    {
        return (bool)(this.丌七上丁丌且丒专万 > 2f) ? 1 : 0;
    }
    private void Update()
    {
        float val_8;
        UILabel val_9;
        float val_8 = this.丙丁与丈上与且丏丝;
        val_8 = val_8 + 1f;
        this.丙丁与丈上与且丏丝 = val_8;
        double val_10 = this.一丗七丕丞上下丛丝;
        double val_9 = (double)UnityEngine.Time.realtimeSinceStartup;
        this.一丗七丕丞上下丛丝 = val_9;
        val_9 = val_9 - val_10;
        float val_11 = (float)val_9;
        val_10 = this.丂万丞丝上丏丕丐丒 - val_11;
        val_11 = 1f / val_11;
        val_11 = val_11 + this.上业世专丆东业丙丗;
        this.丂万丞丝上丏丕丐丒 = val_10;
        this.上业世专丆东业丙丗 = val_11;
        if(val_10 > 0f)
        {
                return;
        }
        
        val_11 = val_11 / this.丙丁与丈上与且丏丝;
        this.丄丌世丛一与上下专 = val_11;
        if((UnityEngine.Object.op_Implicit(exists:  this.七丐丞丑丑丕世丙七)) != false)
        {
                this.七丐丞丑丑丕世丙七.text = this.丄丌世丛一与上下专.ToString(format:  "f2");
        }
        
        float val_12 = this.丌七上丁丌且丒专万;
        this.上业世专丆东业丙丗 = 0f;
        this.丙丁与丈上与且丏丝 = 0f;
        val_12 = val_12 + 1f;
        this.丂万丞丝上丏丕丐丒 = this.updateInterval;
        this.丌七上丁丌且丒专万 = val_12;
        if((UnityEngine.Object.op_Implicit(exists:  this.七丐丞丑丑丕世丙七)) == false)
        {
                return;
        }
        
        val_8 = 30f;
        if(this.丄丌世丛一与上下专 < 0)
        {
                val_9 = this.七丐丞丑丑丕世丙七;
            UnityEngine.Color val_5 = UnityEngine.Color.yellow;
        }
        else
        {
                val_9 = this.七丐丞丑丑丕世丙七;
            val_8 = 10f;
            if(this.丄丌世丛一与上下专 < 0)
        {
                UnityEngine.Color val_6 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_7 = UnityEngine.Color.green;
        }
        
        }
        
        val_9.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
    }
    public UILabelFPSCounter()
    {
        this.updateInterval = 1f;
        this.丄丌世丛一与上下专 = 15f;
    }

}
