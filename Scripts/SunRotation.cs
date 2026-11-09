using UnityEngine;
public class SunRotation : PGBehaviour
{
    // Fields
    public UnityEngine.AnimationCurve xRotation;
    public UnityEngine.AnimationCurve yRotation;
    public UnityEngine.Transform sun;
    public UnityEngine.Transform yAxis;
    private float 丛丙专一七上下三丐;
    private float 东丘且丐且业且丂东;
    
    // Methods
    private void LateUpdate()
    {
        UnityEngine.Transform val_22;
        var val_23;
        var val_24;
        string val_25;
        var val_26;
        float val_27;
        val_22 = this;
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        if((System.String.IsNullOrEmpty(value:  GameConnect.丟下丗丙丕丁丞丞丛)) == true)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        val_25 = GameConnect.丟下丗丙丕丁丞丞丛;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  val_25)) == false)
        {
                return;
        }
        
        int val_10 = 0;
        val_26 = null;
        val_26 = null;
        val_25 = GameConnect.丟下丗丙丕丁丞丞丛;
        bool val_11 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_25], 丙业与丙丗丝不丈东: out  val_10);
        if((val_10 & 2147483648) != 0)
        {
                return;
        }
        
        val_27 = 0f * 60f;
        this.丛丙专一七上下三丐 = val_27;
        if(TimeGameController.丄丞丁丈与业上丞丟 == null)
        {
                val_27 = this.丛丙专一七上下三丐;
        }
        
        if(val_27 <= (float)TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞)
        {
                return;
        }
        
        float val_21 = (float)TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞;
        val_21 = val_27 - val_21;
        this.东丘且丐且业且丂东 = val_21;
        if((UnityEngine.Object.op_Implicit(exists:  UnityEngine.Camera.main)) != false)
        {
                val_25 = UnityEngine.Camera.main.transform;
            this.sun.LookAt(target:  val_25);
        }
        
        float val_17 = this.xRotation.Evaluate(time:  this.东丘且丐且业且丂东 / this.丛丙专一七上下三丐);
        this.丌丟丄业且三丛丕丄().localRotation = new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f};
        float val_20 = this.yRotation.Evaluate(time:  this.东丘且丐且业且丂东 / this.丛丙专一七上下三丐);
        val_22 = this.yAxis;
        val_27 = 0f;
        val_22.localRotation = new UnityEngine.Quaternion() {x = val_27, y = 0f, z = 0f, w = 0f};
    }
    public SunRotation()
    {
    
    }

}
