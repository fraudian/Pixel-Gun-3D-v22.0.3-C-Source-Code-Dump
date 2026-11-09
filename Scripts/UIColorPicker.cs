using UnityEngine;
public class UIColorPicker : MonoBehaviour
{
    // Fields
    public static UIColorPicker current;
    public UnityEngine.Color value;
    public UIWidget selectionWidget;
    public System.Collections.Generic.List<EventDelegate> onChange;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    private UITexture 一丐丛丒七丐一丂业;
    private UnityEngine.Texture2D 丅三专世业三丁七丆;
    private UICamera 丟丕东万丐丁丁专一;
    private UnityEngine.Vector2 丞丌上丂与业丆丅丅;
    private int 业丆世丄丏丕丕七不;
    private int 丙万且丝丐世下世且;
    private static UnityEngine.AnimationCurve 丈丛丁丗下丙三且且;
    private static UnityEngine.AnimationCurve 丞丈丅七丞丒丆不世;
    private static UnityEngine.AnimationCurve 上丛三丌且丟且丁与;
    
    // Methods
    private void Start()
    {
        int val_14;
        int val_15;
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.一丐丛丒七丐一丂业 = this.GetComponent<UITexture>();
        this.丟丕东万丐丁丁专一 = UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  this.gameObject.layer);
        this.业丆世丄丏丕丕七不 = this.一丐丛丒七丐一丂业.width;
        int val_7 = this.一丐丛丒七丐一丂业.height;
        this.丙万且丝丐世下世且 = val_7;
        int val_8 = this.业丆世丄丏丕丕七不 * val_7;
        UnityEngine.Color[] val_9 = new UnityEngine.Color[0];
        val_14 = this.丙万且丝丐世下世且;
        if(val_14 > 0)
        {
                val_15 = this.业丆世丄丏丕丕七不;
            var val_17 = 0;
            do
        {
            if(val_15 >= 1)
        {
                float val_14 = 0f;
            val_14 = val_14 + (-1f);
            var val_16 = 0;
            do
        {
            float val_15 = 0f;
            val_15 = val_15 + (-1f);
            val_15 = val_15 / (float)val_15;
            val_15 = val_16 + (val_17 * val_15);
            UnityEngine.Color val_11 = UIColorPicker.Sample(三丟东丕丄丄下下丑:  val_15, 丒丒丄丁且丄丆丂丌:  val_14 / (float)val_14);
            val_9[(long)val_15] = val_11;
            val_9[(long)val_15] = val_11.g;
            val_9[(long)val_15] = val_11.b;
            val_9[(long)val_15] = val_11.a;
            val_15 = this.业丆世丄丏丕丕七不;
            val_16 = val_16 + 1;
        }
        while(val_16 < val_15);
        
            val_14 = this.丙万且丝丐世下世且;
        }
        
            val_17 = val_17 + 1;
        }
        while(val_17 < val_14);
        
        }
        else
        {
                val_15 = this.业丆世丄丏丕丕七不;
        }
        
        UnityEngine.Texture2D val_12 = new UnityEngine.Texture2D(width:  val_15, height:  val_14, textureFormat:  3, mipChain:  false);
        this.丅三专世业三丁七丆 = val_12;
        val_12.SetPixels(colors:  val_9);
        this.丅三专世业三丁七丆.filterMode = 2;
        this.丅三专世业三丁七丆.wrapMode = 1;
        this.丅三专世业三丁七丆.Apply();
        UnityEngine.Vector2 val_13 = this.Select(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = this.value});
    }
    private void OnDestroy()
    {
        UnityEngine.Object.Destroy(obj:  this.丅三专世业三丁七丆);
        this.丅三专世业三丁七丆 = 0;
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if(万东丂丒且丅丛丑丕 == false)
        {
                return;
        }
        
        if(UICamera.currentScheme == 2)
        {
                return;
        }
        
        this.丕且下世丟丞丆丈丛();
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        this.丕且下世丟丞丆丈丛();
    }
    private void 丌七东丏万丑丄丏业(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        丞且丅三三东不丄且.x = 丞且丅三三东不丄且.x + this.丞丌上丂与业丆丅丅;
        this.丞丌上丂与业丆丅丅 = UnityEngine.Mathf.Clamp01(value:  丞且丅三三东不丄且.x);
        float val_4 = UnityEngine.Mathf.Clamp01(value:  丞且丅三三东不丄且.y + 丞且丅三三东不丄且.y);
        mem[1152921535309465836] = val_4;
        this.Select(业下丌下三丕丙丌下:  new UnityEngine.Vector2() {x = this.丞丌上丂与业丆丅丅, y = val_4});
    }
    private void 丕且下世丟丞丆丈丛()
    {
        float val_18;
        float val_20;
        int val_21;
        int val_22;
        UnityEngine.Vector3 val_23;
        float val_24;
        UIWidget val_26;
        int val_27;
        int val_28;
        UnityEngine.Vector2 val_1 = UICamera.lastEventPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
        UnityEngine.Vector3 val_4 = this.丟丕东万丐丁丁专一.cachedCamera.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_18 = val_4.z;
        UnityEngine.Vector3 val_5 = this.丐一丗丛丕世丘东丁.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_18});
        val_20 = val_5.z;
        UnityEngine.Vector3[] val_6 = this.一丐丛丒七丐一丂业.localCorners;
        val_21 = val_6.Length;
        if(val_21 == 0)
        {
                val_21 = val_6.Length;
        }
        
        if(val_21 <= 2)
        {
                val_21 = val_6.Length;
        }
        
        val_5.x = val_5.x - val_6[0];
        val_5.x = val_5.x / (val_6[3] - val_6[0]);
        this.丞丌上丂与业丆丅丅 = UnityEngine.Mathf.Clamp01(value:  val_5.x);
        val_22 = val_6.Length;
        if(val_22 == 0)
        {
                val_22 = val_6.Length;
        }
        
        val_23 = val_6[0];
        if(val_22 <= 2)
        {
                val_22 = val_6.Length;
        }
        
        UnityEngine.Vector3 val_21 = val_6[0];
        val_24 = val_5.y - val_23;
        val_21 = val_6[3] - val_21;
        val_21 = val_24 / val_21;
        mem[1152921535309659756] = UnityEngine.Mathf.Clamp01(value:  val_21);
        val_26 = this.selectionWidget;
        if(val_26 != 0)
        {
                val_27 = val_6.Length;
            if(val_27 == 0)
        {
                val_27 = val_6.Length;
        }
        
            val_28 = val_6.Length;
            if(val_28 == 0)
        {
                val_28 = val_6.Length;
        }
        
            UnityEngine.Vector3 val_13 = this.丐一丗丛丕世丘东丁.TransformPoint(position:  new UnityEngine.Vector3() {x = UnityEngine.Mathf.Lerp(a:  val_6[0], b:  val_6[3], t:  this.丞丌上丂与业丆丅丅), y = UnityEngine.Mathf.Lerp(a:  val_6[0], b:  val_6[3], t:  this.丞丌上丂与业丆丅丅), z = val_20});
            val_20 = val_13.x;
            val_23 = val_13.z;
            val_26 = this.丟丕东万丐丁丁专一;
            val_24 = val_13.y;
            val_18 = val_23;
            万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.selectionWidget.transform, 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_20, y = val_24, z = val_18}, 丑丑丘丄丅万丁丏不:  val_26.cachedCamera);
        }
        
        UnityEngine.Color val_16 = UIColorPicker.Sample(三丟东丕丄丄下下丑:  this.丞丌上丂与业丆丅丅, 丒丒丄丁且丄丆丂丌:  val_24);
        this.value = val_16;
        mem[1152921535309659692] = val_16.g;
        mem[1152921535309659696] = val_16.b;
        mem[1152921535309659700] = val_16.a;
        UIColorPicker.current = this;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onChange);
        UIColorPicker.current = 0;
    }
    public void Select(UnityEngine.Vector2 业下丌下三丕丙丌下)
    {
        float val_14;
        int val_16;
        int val_17;
        val_14 = 业下丌下三丕丙丌下.y;
        this.丞丌上丂与业丆丅丅 = UnityEngine.Mathf.Clamp01(value:  业下丌下三丕丙丌下.x);
        mem[1152921535309923308] = UnityEngine.Mathf.Clamp01(value:  val_14);
        if(this.selectionWidget != 0)
        {
                UnityEngine.Vector3[] val_4 = this.一丐丛丒七丐一丂业.localCorners;
            val_16 = val_4.Length;
            if(val_16 == 0)
        {
                val_16 = val_4.Length;
        }
        
            val_17 = val_4.Length;
            if(val_17 == 0)
        {
                val_17 = val_4.Length;
        }
        
            UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UnityEngine.Mathf.Lerp(a:  val_4[0], b:  val_4[3], t:  this.丞丌上丂与业丆丅丅), y = UnityEngine.Mathf.Lerp(a:  val_4[0], b:  val_4[3], t:  this.丞丌上丂与业丆丅丅)});
            UnityEngine.Vector3 val_8 = this.丐一丗丛丕世丘东丁.TransformPoint(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            val_14 = val_11.x;
            万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.selectionWidget.transform, 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_14, y = val_11.y, z = val_11.z}, 丑丑丘丄丅万丁丏不:  this.丟丕东万丐丁丁专一.cachedCamera);
        }
        
        UnityEngine.Color val_13 = UIColorPicker.Sample(三丟东丕丄丄下下丑:  this.丞丌上丂与业丆丅丅, 丒丒丄丁且丄丆丂丌:  val_11.y);
        this.value = val_13;
        mem[1152921535309923244] = val_13.g;
        mem[1152921535309923248] = val_13.b;
        mem[1152921535309923252] = val_13.a;
        UIColorPicker.current = this;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onChange);
        UIColorPicker.current = 0;
    }
    public UnityEngine.Vector2 Select(UnityEngine.Color 丁丂专业丁丅丅丈丙)
    {
        var val_13;
        int val_14;
        float val_15;
        float val_16;
        float val_19;
        int val_20;
        int val_21;
        val_13 = 1152921504848912384;
        if(this.一丐丛丒七丐一丂业 == 0)
        {
                this.value = 丁丂专业丁丅丅丈丙;
            mem[1152921535310178604] = 丁丂专业丁丅丅丈丙.g;
            mem[1152921535310178608] = 丁丂专业丁丅丅丈丙.b;
            mem[1152921535310178612] = 丁丂专业丁丅丅丈丙.a;
            return new UnityEngine.Vector2() {x = this.丞丌上丂与业丆丅丅, y = val_19};
        }
        
        val_14 = this.丙万且丝丐世下世且;
        if(val_14 >= 1)
        {
                var val_14 = 0;
            val_15 = -1f;
            do
        {
            if(this.业丆世丄丏丕丕七不 >= 1)
        {
                float val_11 = 0f;
            val_11 = val_11 + val_15;
            var val_13 = 0;
            val_16 = val_11 / (float)val_14;
            do
        {
            float val_12 = 0f;
            val_12 = val_12 + val_15;
            float val_2 = val_12 / (float)this.业丆世丄丏丕丕七不;
            UnityEngine.Color val_3 = UIColorPicker.Sample(三丟东丕丄丄下下丑:  val_2, 丒丒丄丁且丄丆丂丌:  val_16);
            val_3.r = val_3.r - 丁丂专业丁丅丅丈丙.r;
            val_3.g = val_3.g - 丁丂专业丁丅丅丈丙.g;
            val_3.b = val_3.b - 丁丂专业丁丅丅丈丙.b;
            val_3.r = val_3.r * val_3.r;
            val_3.g = val_3.g * val_3.g;
            val_3.r = val_3.r + val_3.g;
            val_19 = val_3.b * val_3.b;
            val_3.r = val_19 + val_3.r;
            if(val_3.r < 0)
        {
                this.丞丌上丂与业丆丅丅 = val_2;
            mem[1152921535310178668] = val_16;
        }
        
            val_13 = val_13 + 1;
        }
        while(val_13 < this.业丆世丄丏丕丕七不);
        
            val_14 = this.丙万且丝丐世下世且;
        }
        
            val_14 = val_14 + 1;
        }
        while(val_14 < val_14);
        
        }
        
        if(this.selectionWidget != 0)
        {
                UnityEngine.Vector3[] val_5 = this.一丐丛丒七丐一丂业.localCorners;
            val_20 = val_5.Length;
            if(val_20 == 0)
        {
                val_20 = val_5.Length;
        }
        
            val_21 = val_5.Length;
            if(val_21 == 0)
        {
                val_21 = val_5.Length;
        }
        
            UnityEngine.Vector3 val_8 = this.丐一丗丛丕世丘东丁.TransformPoint(position:  new UnityEngine.Vector3() {x = UnityEngine.Mathf.Lerp(a:  val_5[0], b:  val_5[3], t:  this.丞丌上丂与业丆丅丅), y = UnityEngine.Mathf.Lerp(a:  val_5[0], b:  val_5[3], t:  this.丞丌上丂与业丆丅丅), z = 0f});
            val_16 = val_8.x;
            val_15 = val_8.z;
            val_19 = val_8.y;
            万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.selectionWidget.transform, 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_16, y = val_19, z = val_15}, 丑丑丘丄丅万丁丏不:  this.丟丕东万丐丁丁专一.cachedCamera);
        }
        
        this.value = 丁丂专业丁丅丅丈丙;
        mem[1152921535310178604] = 丁丂专业丁丅丅丈丙.g;
        mem[1152921535310178608] = 丁丂专业丁丅丅丈丙.b;
        mem[1152921535310178612] = 丁丂专业丁丅丅丈丙.a;
        val_13 = 1152921505097900032;
        UIColorPicker.current = this;
        EventDelegate.丞丙东丌一三专丏不(丝丘丑业丛万丞丌丝:  this.onChange);
        UIColorPicker.current = 0;
        return new UnityEngine.Vector2() {x = this.丞丌上丂与业丆丅丅, y = val_19};
    }
    public static UnityEngine.Color Sample(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌)
    {
        float val_17;
        float val_19;
        var val_20;
        if(UIColorPicker.丈丛丁丗下丙三且且 == null)
        {
                UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[8];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            val_1[2] = 0;
            val_1[3] = 0;
            val_1[3] = 0;
            val_1[4] = 0;
            val_1[4] = 0;
            val_1[5] = 0;
            val_1[5] = 0;
            val_1[6] = 0;
            val_1[6] = 0;
            val_1[7] = 0;
            val_1[7] = 0;
            UIColorPicker.丈丛丁丗下丙三且且 = new UnityEngine.AnimationCurve(keys:  val_1);
            UnityEngine.Keyframe[] val_3 = new UnityEngine.Keyframe[8];
            val_3[0] = 0;
            val_3[0] = 0;
            val_3[1] = 0;
            val_3[1] = 0;
            val_3[2] = 0;
            val_3[2] = 0;
            val_3[3] = 0;
            val_3[3] = 0;
            val_3[4] = 0;
            val_3[4] = 0;
            val_3[5] = 0;
            val_3[5] = 0;
            val_3[6] = 0;
            val_3[6] = 0;
            val_3[7] = 0;
            val_3[7] = 0;
            UnityEngine.AnimationCurve val_4 = new UnityEngine.AnimationCurve(keys:  val_3);
            UIColorPicker.丞丈丅七丞丒丆不世 = val_4;
            UnityEngine.Keyframe[] val_5 = new UnityEngine.Keyframe[8];
            val_5[0] = 0;
            val_5[0] = 0;
            val_5[1] = 0;
            val_5[1] = 0;
            val_5[2] = 0;
            val_5[2] = 0;
            val_5[3] = 0;
            val_5[3] = 0;
            val_5[4] = 0;
            val_5[4] = 0;
            val_5[5] = 0;
            val_5[5] = 0;
            val_5[6] = 0;
            val_5[6] = 0;
            val_5[7] = 0;
            val_5[7] = 0;
            UnityEngine.AnimationCurve val_6 = new UnityEngine.AnimationCurve(keys:  val_5);
            UIColorPicker.上丛三丌且丟且丁与 = val_6;
        }
        
        val_17 = 0.Evaluate(time:  三丟东丕丄丄下下丑);
        float val_8 = val_4.Evaluate(time:  三丟东丕丄丄下下丑);
        float val_9 = val_6.Evaluate(time:  三丟东丕丄丄下下丑);
        if(丒丒丄丁且丄丆丂丌 < 0)
        {
                float val_15 = 0f;
            float val_10 = 丒丒丄丁且丄丆丂丌 + 丒丒丄丁且丄丆丂丌;
            val_15 = val_10 * val_15;
            val_19 = val_10 * 0f;
            val_20 = val_10 * 0f;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        val_17 = 0f;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        val_19 = val_19;
        val_20 = val_17;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_15, y = val_19, z = val_17}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, t:  (丒丒丄丁且丄丆丂丌 + 丒丒丄丁且丄丆丂丌) + (-1f));
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    public UIColorPicker()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.value = val_1;
        mem[1152921535310529964] = val_1.g;
        mem[1152921535310529968] = val_1.b;
        mem[1152921535310529972] = val_1.a;
        this.onChange = new System.Collections.Generic.List<EventDelegate>();
    }

}
