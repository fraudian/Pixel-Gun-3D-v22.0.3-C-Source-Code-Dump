using UnityEngine;
public class SunWay : MonoBehaviour
{
    // Fields
    public float waterLevel;
    public UnityEngine.Transform sun;
    private UnityEngine.Vector3 丒丗丗丕丘丙世七下;
    private float 丌七丒世丄上丞丞丁;
    private float 丙三世东东丙上丂世;
    private float 七下下丑丁丘万丟世;
    private float 七上下丁万专丂七业;
    public float multiplier;
    private float 与专丌丅丙上丌一丄;
    
    // Methods
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.不世丘丏与丞丐世不());
        UnityEngine.Vector3 val_5 = this.transform.GetChild(index:  0).localScale;
        this.七上下丁万专丂七业 = val_5.x;
    }
    private void Update()
    {
        var val_55;
        var val_56;
        var val_57;
        float val_58;
        float val_59;
        var val_60;
        float val_61;
        var val_62;
        val_55 = this;
        val_56 = null;
        val_56 = null;
        if((UnityEngine.Object.op_Implicit(exists:  丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专)) == false)
        {
                return;
        }
        
        if(this.丙三世东东丙上丂世 <= 0f)
        {
                return;
        }
        
        val_57 = null;
        val_57 = null;
        UnityEngine.Vector3 val_3 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector3 val_5 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3.x, y:  val_5.z);
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_8.x, y:  val_10.z);
        this.丌七丒世丄上丞丞丁 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
        UnityEngine.Vector3 val_14 = this.sun.position;
        UnityEngine.Vector3 val_15 = this.sun.position;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_17 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
        UnityEngine.Vector3 val_19 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.forward;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  -0.5f);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_23 = this.transform.position;
        this.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_21.x, y = val_23.y, z = val_21.z});
        val_58 = this.七上下丁万专丂七业;
        UnityEngine.Vector3 val_28 = this.sun.transform.position;
        float val_55 = this.丌七丒世丄上丞丞丁;
        val_55 = val_55 / this.丙三世东东丙上丂世;
        val_59 = val_55;
        val_60 = this.transform.GetChild(index:  0);
        UnityEngine.Vector3 val_33 = val_60.localScale;
        val_61 = 1f;
        float val_34 = (UnityEngine.Mathf.Clamp(value:  val_28.y / 100f, min:  0f, max:  0.3f)) + val_61;
        val_34 = val_58 * val_34;
        float val_35 = this.七下下丑丁丘万丟世 * val_59;
        this.transform.GetChild(index:  0).localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector3 val_36 = this.sun.position;
        float val_56 = 120f;
        val_56 = val_36.y + val_56;
        if(val_56 > this.waterLevel)
        {
                val_62 = null;
            val_58 = this.waterLevel;
            val_62 = null;
            UnityEngine.Vector3 val_42 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.position;
            val_60 = this.sun.transform;
            UnityEngine.Vector3 val_44 = val_60.position;
            val_59 = val_44.y;
            float val_45 = val_58 + val_42.y;
            val_44.y = val_59 / 100f;
            val_45 = val_45 + val_44.y;
            val_45 = val_45 / (this.waterLevel + 20f);
            float val_48 = val_61 - (UnityEngine.Mathf.Clamp01(value:  val_45));
            this.transform.GetChild(index:  0).GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this.与专丌丅丙上丌一丄 = 1f;
            return;
        }
        
        float val_49 = UnityEngine.Time.deltaTime;
        val_49 = this.与专丌丅丙上丌一丄 - val_49;
        this.与专丌丅丙上丌一丄 = val_49;
        val_61 = this.与专丌丅丙上丌一丄;
        val_55 = this.transform.GetChild(index:  0).GetComponent<UnityEngine.Renderer>().material;
        float val_54 = UnityEngine.Mathf.Clamp01(value:  val_61);
        val_55.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private System.Collections.IEnumerator 不世丘丏与丞丐世不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SunWay.专且丐丅丑丘丝丛丟();
    }
    public SunWay()
    {
        this.multiplier = 1f;
        this.与专丌丅丙上丌一丄 = 1f;
    }

}
