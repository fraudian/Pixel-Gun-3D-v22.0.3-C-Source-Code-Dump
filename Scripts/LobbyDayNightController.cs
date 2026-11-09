using UnityEngine;
public class LobbyDayNightController : MonoBehaviour
{
    // Fields
    public LobbyDayNightController.MaterialToChange[] matToChange;
    private float 丌丑丞丛丝丘丂上与;
    private float 丄万丏不且丄七丙丝;
    private float 丕丐丅上丅丆丗丞丂;
    
    // Methods
    private void Start()
    {
        System.DateTime val_1 = System.DateTime.Now;
        var val_8 = 60;
        float val_10 = this.丕丐丅上丅丆丗丞丂;
        val_8 = val_1.dateData.Minute * val_8;
        float val_9 = (float)val_1.dateData.Hour * 3600;
        val_9 = this.丕丐丅上丅丆丗丞丂 - val_9;
        val_9 = val_9 + (float)val_8;
        val_10 = val_10 / 6f;
        val_9 = val_9 + (float)val_1.dateData.Second;
        this.丌丑丞丛丝丘丂上与 = val_10;
        this.丄万丏不且丄七丙丝 = val_9;
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丝不丄专丐东丞丄上());
    }
    private void Update()
    {
        float val_10;
        var val_11;
        UnityEngine.Color[] val_12;
        UnityEngine.Color val_13;
        val_10 = this.丄万丏不且丄七丙丝;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_10 - val_1;
        this.丄万丏不且丄七丙丝 = val_1;
        if(val_1 < 0)
        {
                this.丄万丏不且丄七丙丝 = this.丕丐丅上丅丆丗丞丂;
        }
        
        val_11 = 0;
        goto label_2;
        label_26:
        MaterialToChange val_10 = this.matToChange[0];
        float val_12 = this.丕丐丅上丅丆丗丞丂;
        float val_2 = this.丄万丏不且丄七丙丝 / val_12;
        val_2 = val_2 * 6f;
        int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_2);
        var val_4 = (val_3 == 6) ? 0 : (val_3);
        float val_11 = (float)val_4;
        val_11 = this.丌丑丞丛丝丘丂上与 * val_11;
        var val_6 = ((val_4 + 1) >= 6) ? 0 : (val_4 + 1);
        val_12 = this.丄万丏不且丄七丙丝 - val_11;
        val_10 = val_12 / this.丌丑丞丛丝丘丂上与;
        if(this.matToChange[0x0][0].changecolor != false)
        {
                val_12 = this.matToChange[0x0][0].cicleColors;
            val_13 = this.matToChange[0x0][0].cicleColors[(long)val_4];
            UnityEngine.Color val_7 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.matToChange[0x0][0].cicleColors[(long)val_4], g = this.matToChange[0x0][0].cicleColors[(long)val_4], b = val_13, a = this.matToChange[0x0][0].cicleColors[(long)val_4]}, b:  new UnityEngine.Color() {r = val_12[(long)val_6], g = val_12[(long)val_6], b = val_12[(long)val_6], a = val_12[(long)val_6]}, t:  val_10);
            this.matToChange[0x0][0].currentColor = val_7;
            mem2[0] = val_7.g;
            mem2[0] = val_7.b;
            mem2[0] = val_7.a;
        }
        
        if(this.matToChange[0x0][0].changeLM != false)
        {
                val_12 = this.matToChange[0x0][0].cicleLerp;
            val_13 = val_12[(long)val_6];
            this.matToChange[0x0][0].currentLerp = UnityEngine.Mathf.Lerp(a:  this.matToChange[0x0][0].cicleLerp[(long)val_4], b:  val_13, t:  val_10);
        }
        
        if(this.matToChange[0x0][0].objectsToOnAtNight == null)
        {
            goto label_24;
        }
        
        if(val_4 != 5)
        {
                if(val_4 != 0)
        {
            goto label_22;
        }
        
        }
        
        if(this.matToChange[0x0][0].objectsIsActive != true)
        {
                this.专丝下丐丐丙专且业(丝三丁东丈丒世丅业:  this.matToChange[0x0][0].objectsToOnAtNight, 丛丅丘一丏丙且丌上:  true);
            this.matToChange[0x0][0].objectsIsActive = true;
        }
        
        label_22:
        if(((val_4 - 1) <= 3) && (this.matToChange[0x0][0].objectsIsActive != false))
        {
                this.专丝下丐丐丙专且业(丝三丁东丈丒世丅业:  this.matToChange[0x0][0].objectsToOnAtNight, 丛丅丘一丏丙且丌上:  false);
            this.matToChange[0x0][0].objectsIsActive = false;
        }
        
        label_24:
        val_11 = 1;
        label_2:
        if(val_11 < this.matToChange.Length)
        {
            goto label_26;
        }
    
    }
    private void 专丝下丐丐丙专且业(UnityEngine.GameObject[] 丝三丁东丈丒世丅业, bool 丛丅丘一丏丙且丌上)
    {
        goto label_0;
        label_4:
        丝三丁东丈丒世丅业[0].SetActive(value:  丛丅丘一丏丙且丌上);
        0 = 1;
        label_0:
        if(0 < 丝三丁东丈丒世丅业.Length)
        {
            goto label_4;
        }
    
    }
    private System.Collections.IEnumerator 丝不丄专丐东丞丄上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LobbyDayNightController.丄丑丟不丌丁且丒一();
    }
    public LobbyDayNightController()
    {
        this.丕丐丅上丅丆丗丞丂 = 86400f;
    }

}
