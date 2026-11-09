using UnityEngine;
public class SingularityHole : MonoBehaviour
{
    // Fields
    internal Player_move_c owner;
    public float outRadius;
    public float inRadius;
    public float maxForce;
    public float minForce;
    public float maxDPS;
    public float minDPS;
    public float damageRadius;
    public float hitTime;
    private float 丕业丁丛且丒丟三丛;
    private string 丝三丛且丘不丌丙下;
    private float 且丝一丈丟下丞丅与;
    private WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世;
    private Player_move_c.世不丟丂上丟与丌下 与丑丕一丝下三丆丈;
    private Player_move_c 丕不丘下七丑上丏丏;
    
    // Methods
    private void OnEnable()
    {
        null = null;
        Initializer.丂丈丗与丕三不丑七.Add(item:  this);
    }
    private void 丑东丐一与丝东丈下()
    {
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
    }
    private void OnDisable()
    {
        var val_2;
        this.丝三丛且丘不丌丙下 = System.String.alignConst;
        val_2 = null;
        val_2 = null;
        bool val_1 = Initializer.丂丈丗与丕三不丑七.Remove(item:  this);
    }
    public float GetForce(float 丌七丒世丄上丞丞丁)
    {
        float val_1 = this.outRadius * this.outRadius;
        float val_2 = this.inRadius * this.inRadius;
        if((val_1 <= 丌七丒世丄上丞丞丁) || (val_2 >= 0))
        {
                return (float)(val_2 <= 丌七丒世丄上丞丞丁) ? 0f : -1f;
        }
        
        float val_3 = 丌七丒世丄上丞丞丁 / val_1;
        float val_4 = this.maxForce - this.minForce;
        val_3 = 1f - val_3;
        val_4 = val_3 * val_4;
        val_4 = this.minForce + val_4;
        return UnityEngine.Mathf.Clamp(value:  val_4, min:  this.minForce, max:  this.maxForce);
    }
    private void Update()
    {
        if(this.丕业丁丛且丒丟三丛 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.time;
        if(this.且丝一丈丟下丞丅与 >= 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + this.hitTime;
        this.且丝一丈丟下丞丅与 = val_2;
        this.丐丑且丈丝东丏一丑();
    }
    internal void 丂丈七丙丆丞丐丑丄(float 丕业丁丛且丒丟三丛, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, Player_move_c 丘世丛丈丅世丑丙丂)
    {
        this.丕业丁丛且丒丟三丛 = 丕业丁丛且丒丟三丛;
        this.丝三丛且丘不丌丙下 = 丝三丛且丘不丌丙下;
        this.东丏业丞丞业下丄世 = 东丏业丞丞业下丄世;
        this.与丑丕一丝下三丆丈 = 丅业下不东丗丄与三;
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
    }
    private void 丐丑且丈丝东丏一丑()
    {
        Player_move_c val_22;
        var val_23;
        bool val_24;
        var val_28;
        var val_29;
        val_22 = this.丕不丘下七丑上丏丏;
        if(val_22 == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_2 = null;
        val_24 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        val_2 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this.丕不丘下七丑上丏丏, 不丙丗丞丌丈且丄丟:  val_24, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
        val_22 = val_2.世且一丄且上丄不一();
        label_35:
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_24 = 0;
        if(val_22.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_24 = 0;
        T val_7 = val_22.Current;
        UnityEngine.Vector3 val_8 = val_7.position;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_24 = 4;
        var val_16 = (val_11.x < 0) ? 1 : 0;
        val_16 = val_16 & (丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_7).IsEnemyTo(专丞上七七且丝七丗:  this.丕不丘下七丑上丏丏));
        if(val_16 == false)
        {
            goto label_35;
        }
        
        float val_17 = val_11.x / (this.damageRadius * this.damageRadius);
        float val_18 = this.maxDPS - this.minDPS;
        val_17 = 1f - val_17;
        val_18 = val_17 * val_18;
        val_18 = this.minDPS + val_18;
        UnityEngine.Vector3 val_22 = this.transform.position;
        float val_23 = (UnityEngine.Mathf.Clamp(value:  val_18, min:  this.minDPS, max:  this.maxDPS)) * 0.01f;
        val_23 = val_23 * this.丕业丁丛且丒丟三丛;
        val_23 = val_23 * this.hitTime;
        this.丕不丘下七丑上丏丏.丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  val_7.gameObject, 丞丈专下丈专业三丞:  val_23, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, 丝三丛且丘不丌丙下:  this.丝三丛且丘不丌丙下, 东丏业丞丞业下丄世:  this.东丏业丞丞业下丄世, 丐丟丘世丁三丕专专:  this.与丑丕一丝下三丆丈);
        goto label_35;
        label_12:
        val_28 = 0;
        val_29 = 0;
        if(val_22 == null)
        {
            
        }
        else
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_22.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public SingularityHole()
    {
        this.outRadius = ;
        this.inRadius = ;
        this.maxForce = 10f;
        this.minForce = 1f;
        this.maxDPS = ;
        this.minDPS = ;
        this.damageRadius = 5f;
        this.hitTime = 1.2f;
        this.东丏业丞丞业下丄世 = 3;
    }

}
