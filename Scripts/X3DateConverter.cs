using UnityEngine;
public class X3DateConverter : MonoBehaviour
{
    // Fields
    public UIInput dateStartInput;
    public UIInput timeStartInput;
    public UIInput durationInput;
    public UILabel statusLabel;
    
    // Methods
    private double 丛丁丂且丄万丄丆上(System.DateTime 丑丙万一丏丅丁专丏)
    {
        System.DateTime val_1 = System.DateTime.SpecifyKind(value:  new System.DateTime() {dateData = 丑丙万一丏丅丁专丏.dateData}, kind:  1);
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
        return (double)val_2._ticks.TotalSeconds;
    }
    public void CalculateAndCopyClick()
    {
        string val_16;
        UILabel val_17;
        string val_18;
        if((System.DateTime.TryParse(s:  System.String.Format(format:  "{0}T{1}", arg0:  this.dateStartInput.value, arg1:  this.timeStartInput.value), result: out  new System.DateTime())) == false)
        {
            goto label_5;
        }
        
        if((System.Single.TryParse(s:  this.durationInput.value, result: out  float val_6 = -5.251969E-27f)) != true)
        {
                this.statusLabel.text = "Incorrect duration format!";
        }
        
        System.Text.StringBuilder val_8 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_11 = val_8.AppendFormat(format:  "\t\"start\": {0}\n", arg0:  val_8.AppendLine(value:  "{").丛丁丂且丄万丄丆上(丑丙万一丏丅丁专丏:  new System.DateTime()));
        float val_16 = 0f;
        val_16 = val_16 * 360f;
        if(val_8 == null)
        {
            goto label_11;
        }
        
        System.Text.StringBuilder val_12 = val_8.AppendFormat(format:  "\t\"duration\": {0}\n", arg0:  val_16);
        val_16 = "}";
        System.Text.StringBuilder val_13 = val_8.AppendLine(value:  val_16);
        goto label_12;
        label_5:
        val_17 = this.statusLabel;
        val_18 = "Incorrect date or time format!";
        goto label_14;
        label_11:
        System.Text.StringBuilder val_14 = val_8.AppendFormat(format:  "\t\"duration\": {0}\n", arg0:  val_16);
        val_16 = "}";
        System.Text.StringBuilder val_15 = val_8.AppendLine(value:  val_16);
        label_12:
        EditorListBuilder.专且丝下丝丘丑且不(丕丗丘丑丛与丑业丒:  val_8);
        val_17 = this.statusLabel;
        val_18 = "Converted complete!";
        label_14:
        val_17.text = val_18;
    }
    public X3DateConverter()
    {
    
    }

}
