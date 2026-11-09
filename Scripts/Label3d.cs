using UnityEngine;
public class Label3d : MonoBehaviour
{
    // Fields
    public bool apply;
    public UnityEngine.Color shadedColor;
    public float offset;
    
    // Methods
    private void 七丌丞丌丒丆丙丁万()
    {
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.gameObject);
        if(val_2 != null)
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_2.GetComponent<Label3d>());
            val_31 = val_2.GetComponent<UILabel>();
        }
        else
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_2.GetComponent<Label3d>());
            val_31 = val_2.GetComponent<UILabel>();
        }
        
        val_31.depth = val_2.GetComponent<UILabel>().depth;
        UnityEngine.GameObject val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.gameObject);
        if(val_10 != null)
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_10.GetComponent<Label3d>());
        }
        else
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_10.GetComponent<Label3d>());
        }
        
        val_10.transform.parent = this.transform;
        UILabel val_15 = val_10.GetComponent<UILabel>();
        if(val_15 != null)
        {
                val_32 = val_15.depth;
            val_33 = val_15;
        }
        else
        {
                val_32 = 0.depth;
            val_33 = 0;
        }
        
        val_33.depth = val_32 + 1;
        val_10.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_10.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_33.color = new UnityEngine.Color() {r = this.shadedColor, g = V9.16B, b = V10.16B, a = V11.16B};
        val_2.transform.parent = this.transform;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UILabel val_26 = this.gameObject.GetComponent<UILabel>();
        if(val_26 != null)
        {
                val_26.effectStyle = 0;
            val_34 = val_26.depth;
        }
        else
        {
                val_26.effectStyle = 0;
            val_34 = 0.depth;
        }
        
        val_26.depth = val_34 + 2;
        this.gameObject.SetActive(value:  false);
        this.与世且七丝世丁万丝();
    }
    private void Update()
    {
        if(this.apply == false)
        {
                return;
        }
        
        this.apply = false;
        this.七丌丞丌丒丆丙丁万();
    }
    private void 与世且七丝世丁万丝()
    {
        this.gameObject.SetActive(value:  true);
        UnityEngine.Object.DestroyImmediate(obj:  this.gameObject.GetComponent<Label3d>());
    }
    public Label3d()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.gray;
        this.shadedColor = val_1;
        mem[1152921530790472224] = val_1.g;
        mem[1152921530790472228] = val_1.b;
        mem[1152921530790472232] = val_1.a;
        this.offset = -3f;
    }

}
