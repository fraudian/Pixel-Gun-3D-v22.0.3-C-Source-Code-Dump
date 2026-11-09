using UnityEngine;
public class UILabelCoords : MonoBehaviour
{
    // Fields
    public string format;
    private UILabel 七丐丞丑丑丕世丙七;
    private string 丌世业丗与丛上一万;
    
    // Methods
    private void Awake()
    {
        this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
    }
    private void Update()
    {
        string val_13;
        object val_14;
        string val_15;
        val_13 = this;
        val_14 = 1152921504848912384;
        if(UIMiniMap.instance == 0)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  UIMiniMap.instance)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = UIMiniMap.instance.position;
        NJGMap val_7 = NJGMap.instance;
        UnityEngine.Vector3 val_9 = UIMiniMap.instance.position;
        val_14 = (int)val_6.x;
        val_15 = System.String.Format(format:  this.format, arg0:  (int)val_6.x, arg1:  (int)(val_14 == 0) ? val_9.z : val_9.y);
        this.丌世业丗与丛上一万 = val_15;
        if(this.七丐丞丑丑丕世丙七 == null)
        {
                val_15 = this.丌世业丗与丛上一万;
        }
        
        if((System.String.op_Inequality(a:  this.七丐丞丑丑丕世丙七.mText, b:  val_15)) == false)
        {
                return;
        }
        
        val_13 = this.丌世业丗与丛上一万;
        this.七丐丞丑丑丕世丙七.text = val_13;
    }
    public UILabelCoords()
    {
        this.format = "X:{0},Y:{1}";
    }

}
