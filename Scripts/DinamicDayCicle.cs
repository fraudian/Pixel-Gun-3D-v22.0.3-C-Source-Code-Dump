using UnityEngine;
public class DinamicDayCicle : MonoBehaviour
{
    // Fields
    public MaterialToChange[] matToChange;
    public float lerpFactor;
    private int 下不三与丕世东丆丈;
    private float 丌丑丞丛丝丘丂上与;
    public int currentCicle;
    private float 丛丙专一七上下三丐;
    private float 丄万丏不且丄七丙丝;
    
    // Methods
    private void Start()
    {
        this.不丐丁丞丆丟丈七丑();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝不丄专丐东丞丄上());
    }
    private void Update()
    {
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        float val_24;
        var val_25;
        if((TimeGameController.丄丞丁丈与业上丞丟 == 0) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_26;
        }
        
        val_20 = null;
        val_20 = null;
        if((System.String.IsNullOrEmpty(value:  GameConnect.丟下丗丙丕丁丞丞丛)) == false)
        {
            goto label_9;
        }
        
        label_26:
        this.不丐丁丞丆丟丈七丑();
        return;
        label_9:
        val_21 = null;
        val_21 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  GameConnect.丟下丗丙丕丁丞丞丛)) == false)
        {
                return;
        }
        
        int val_10 = 0;
        val_22 = null;
        val_22 = null;
        bool val_11 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丟下丗丙丕丁丞丞丛], 丙业与丙丗丝不丈东: out  val_10);
        if((val_10 & 2147483648) != 0)
        {
            goto label_26;
        }
        
        val_23 = 0f * 60f;
        this.丛丙专一七上下三丐 = val_23;
        if(TimeGameController.丄丞丁丈与业上丞丟 == null)
        {
                val_23 = this.丛丙专一七上下三丐;
        }
        
        if(val_23 <= (float)TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞)
        {
                return;
        }
        
        val_24 = val_23;
        if(TimeGameController.丄丞丁丈与业上丞丟 == null)
        {
                val_24 = this.丛丙专一七上下三丐;
        }
        
        float val_19 = (float)TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞;
        val_19 = val_23 - val_19;
        this.丄万丏不且丄七丙丝 = val_19;
        if(val_24 == val_19)
        {
                return;
        }
        
        val_25 = 0;
        goto label_31;
        label_58:
        MaterialToChange val_20 = this.matToChange[0];
        float val_21 = (float)this.matToChange[0x0][0].cicleColors.Length;
        val_21 = this.丛丙专一七上下三丐 / val_21;
        this.丌丑丞丛丝丘丂上与 = val_21;
        float val_22 = (float)this.matToChange[0x0][0].cicleColors.Length;
        val_22 = (this.丄万丏不且丄七丙丝 / this.丛丙专一七上下三丐) * val_22;
        int val_13 = UnityEngine.Mathf.FloorToInt(f:  val_22);
        this.currentCicle = val_13;
        float val_25 = this.丌丑丞丛丝丘丂上与;
        float val_24 = this.丄万丏不且丄七丙丝;
        this.下不三与丕世东丆丈 = UnityEngine.Mathf.Min(a:  val_13 + 1, b:  this.matToChange[0x0][0].cicleColors.Length - 1);
        float val_23 = (float)this.currentCicle;
        val_23 = val_25 * val_23;
        val_24 = val_24 - val_23;
        val_25 = val_24 / val_25;
        this.lerpFactor = val_25;
        if((this.matToChange[0x0][0].changecolor != false) && (this.currentCicle < this.matToChange[0x0][0].cicleColors.Length))
        {
                UnityEngine.Color val_17 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.matToChange[0x0][0].cicleColors[this.currentCicle], g = this.matToChange[0x0][0].cicleColors[this.currentCicle], b = this.matToChange[0x0][0].cicleColors[this.currentCicle], a = this.matToChange[0x0][0].cicleColors[this.currentCicle]}, b:  new UnityEngine.Color() {r = this.matToChange[0x0][0].cicleColors[this.下不三与丕世东丆丈], g = this.matToChange[0x0][0].cicleColors[this.下不三与丕世东丆丈], b = this.matToChange[0x0][0].cicleColors[this.下不三与丕世东丆丈], a = this.matToChange[0x0][0].cicleColors[this.下不三与丕世东丆丈]}, t:  this.lerpFactor);
            this.matToChange[0x0][0].currentColor = val_17;
            mem2[0] = val_17.g;
            mem2[0] = val_17.b;
            mem2[0] = val_17.a;
        }
        
        if(((this.matToChange[0x0][0].cicleLerp != null) && (this.matToChange[0x0][0].cicleLerp.Length == this.matToChange[0x0][0].cicleColors.Length)) && (this.currentCicle < this.matToChange[0x0][0].cicleColors.Length))
        {
                this.matToChange[0x0][0].currentLerp = UnityEngine.Mathf.Lerp(a:  this.matToChange[0x0][0].cicleLerp[this.currentCicle], b:  this.matToChange[0x0][0].cicleLerp[this.下不三与丕世东丆丈], t:  this.lerpFactor);
        }
        
        val_25 = 1;
        label_31:
        if(val_25 < this.matToChange.Length)
        {
            goto label_58;
        }
    
    }
    private void 不丐丁丞丆丟丈七丑()
    {
        goto label_0;
        label_12:
        MaterialToChange val_1 = this.matToChange[0];
        if(this.matToChange[0x0][0].changecolor != false)
        {
                this.matToChange[0x0][0].currentColor = this.matToChange[0x0][0].cicleColors[0];
            mem2[0] = this.matToChange[0x0][0].cicleColors[0];
            mem2[0] = this.matToChange[0x0][0].cicleColors[0];
        }
        
        if((this.matToChange[0x0][0].cicleLerp != null) && (this.matToChange[0x0][0].cicleLerp.Length == this.matToChange[0x0][0].cicleColors.Length))
        {
                this.matToChange[0x0][0].currentLerp = this.matToChange[0x0][0].cicleLerp[0];
        }
        
        0 = 1;
        label_0:
        if(0 < this.matToChange.Length)
        {
            goto label_12;
        }
    
    }
    private System.Collections.IEnumerator 丝不丄专丐东丞丄上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DinamicDayCicle.上与东丘丈专丅丌三();
    }
    public DinamicDayCicle()
    {
    
    }

}
