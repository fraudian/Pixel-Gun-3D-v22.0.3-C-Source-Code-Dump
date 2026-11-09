using UnityEngine;
public class AnimateSpark : MonoBehaviour
{
    // Fields
    public UIBasicSprite barCur;
    public UIBasicSprite barUp;
    public float timer;
    private float 丄一丒丛丄丙丞一上;
    private UnityEngine.Vector3 七丝丑丐东丅丒丁丂;
    private UnityEngine.Vector3 丂七丅一一丒且万丕;
    private UIWidget 不七丘丘丒万七丄丒;
    
    // Methods
    private void Start()
    {
        this.不七丘丘丒万七丄丒 = this.transform.GetChild(index:  0).GetComponent<UIWidget>();
    }
    private void Update()
    {
        var val_45;
        float val_46;
        float val_47;
        val_45 = this;
        val_46 = this.barCur.fillAmount;
        if((val_46 < this.barUp.fillAmount) && (this.barUp.gameObject.activeInHierarchy != false))
        {
                this.不七丘丘丒万七丄丒.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_7 = this.barCur.transform.localPosition;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  (float)this.barCur.width);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this.barCur.fillAmount);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            this.七丝丑丐东丅丒丁丂 = val_13;
            mem[1152921524369624148] = val_13.y;
            mem[1152921524369624152] = val_13.z;
            UnityEngine.Vector3 val_15 = this.barUp.transform.localPosition;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  (float)this.barUp.width);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.barUp.fillAmount);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_47 = this.丄一丒丛丄丙丞一上;
            this.丂七丅一一丒且万丕 = val_21;
            mem[1152921524369624160] = val_21.y;
            mem[1152921524369624164] = val_21.z;
            if(val_47 < 0)
        {
                val_47 = this.timer;
            this.丄一丒丛丄丙丞一上 = this.timer;
        }
        
            float val_22 = UnityEngine.Time.unscaledDeltaTime;
            val_22 = val_47 - val_22;
            this.丄一丒丛丄丙丞一上 = val_22;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.七丝丑丐东丅丒丁丂, y = val_15.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = this.丂七丅一一丒且万丕, y = val_18.x, z = val_15.z}, t:  1f - (this.丄一丒丛丄丙丞一上 / this.timer));
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            float val_30 = UnityEngine.Mathf.Clamp01(value:  UnityEngine.Mathf.Lerp(a:  2f, b:  0f, t:  1f - (this.丄一丒丛丄丙丞一上 / this.timer)));
            val_45 = ???;
            val_46 = ???;
        }
        else
        {
                val_45 + 72.gameObject.SetActive(value:  false);
        }
    
    }
    public AnimateSpark()
    {
        this.timer = 0.5f;
    }

}
