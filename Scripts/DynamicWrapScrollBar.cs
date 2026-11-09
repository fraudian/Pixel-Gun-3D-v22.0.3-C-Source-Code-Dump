using UnityEngine;
public class DynamicWrapScrollBar : MonoBehaviour
{
    // Fields
    internal PGCompany.DynamicStringWrapGrid 丙丈丟万丁丒丂与一;
    public UnityEngine.Transform start;
    public UnityEngine.Transform end;
    public UnityEngine.Transform thumb;
    public float _value;
    internal float 七与且一业一丄丁丁;
    internal bool 丒丅丛一业丘世不且;
    internal bool 丁丂不丅世丈专丌丂;
    internal DynamicMoverHandler moverHandler;
    internal UIPanel 专丐丆丝丒世丁丛丗;
    
    // Methods
    public void Init(PGCompany.DynamicStringWrapGrid 丙丈丟万丁丒丂与一)
    {
        this.丙丈丟万丁丒丂与一 = 丙丈丟万丁丒丂与一;
        this.专丐丆丝丒世丁丛丗 = 丙丈丟万丁丒丂与一.ScrollView.GetComponent<UIPanel>();
        UnityEngine.Vector3 val_4 = this.丅丗丐丂专世且丟丁();
        this.thumb.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.moverHandler.丙与七世丑丐七丗七 = this.end;
        this.moverHandler.世丙丝一丛三丞世丑 = this.start;
    }
    private void OnEnable()
    {
        this.moverHandler.丙与七世丑丐七丗七 = this.end;
        this.moverHandler.世丙丝一丛三丞世丑 = this.start;
        this.moverHandler.add_OnDragMove(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void DynamicWrapScrollBar::下丟专丄上丟业且丄(UnityEngine.Vector2 丞且丅三三东不丄且)));
        this.moverHandler.add_OnDragEnd(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DynamicWrapScrollBar::丝丑丂丒丟下丆万不()));
    }
    private void OnDisable()
    {
        this.moverHandler.remove_OnDragMove(丙业与丙丗丝不丈东:  new System.Action<UnityEngine.Vector2>(object:  this, method:  System.Void DynamicWrapScrollBar::下丟专丄上丟业且丄(UnityEngine.Vector2 丞且丅三三东不丄且)));
        this.moverHandler.remove_OnDragEnd(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DynamicWrapScrollBar::丝丑丂丒丟下丆万不()));
    }
    private void 下丟专丄上丟业且丄(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.丁丂不丅世丈专丌丂 == false)
        {
                return;
        }
        
        this.丒丅丛一业丘世不且 = true;
        UnityEngine.Vector3 val_1 = this.thumb.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = this.moverHandler.丏上丛丑丘丗与东丂(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.thumb.localPosition = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        this.OnScroll(丑丕与丗世与丂丂与:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private void 丝丑丂丒丟下丆万不()
    {
        this.丒丅丛一业丘世不且 = false;
    }
    internal void 丞丕丙上丄丄丆下丁()
    {
        this.moverHandler.丙与七世丑丐七丗七 = this.end;
        this.moverHandler.世丙丝一丛三丞世丑 = this.start;
    }
    internal void OnScroll(UnityEngine.Vector3 丑丕与丗世与丂丂与)
    {
        UnityEngine.Vector3 val_1 = this.start.localPosition;
        UnityEngine.Vector3 val_3 = this.start.localPosition;
        UnityEngine.Vector3 val_4 = this.end.localPosition;
        float val_5 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        val_5 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 丑丕与丗世与丂丂与.x, y = 丑丕与丗世与丂丂与.y, z = 丑丕与丗世与丂丂与.z})) / val_5;
        this._value = val_5;
        float val_6 = this.专丐丆丝丒世丁丛丗.height;
        val_6 = this.七与且一业一丄丁丁 - val_6;
        val_6 = val_6 * this._value;
        this.丙丈丟万丁丒丂与一.ScrollFromStart(丙业与丙丗丝不丈东:  val_6, 且丈丌丅业丅下万三:  false);
    }
    private UnityEngine.Vector3 丅丗丐丂专世且丟丁()
    {
        this._value = 0f;
        if(this.丙丈丟万丁丒丂与一 != 0)
        {
                float val_12 = this.专丐丆丝丒世丁丛丗.height;
            UnityEngine.Vector2 val_3 = this.专丐丆丝丒世丁丛丗.clipOffset;
            UnityEngine.Vector4 val_5 = this.专丐丆丝丒世丁丛丗.baseClipRegion;
            val_12 = this.七与且一业一丄丁丁 - val_12;
            UnityEngine.Vector2 val_6 = this.专丐丆丝丒世丁丛丗.clipSoftness;
            float val_16 = 0.5f;
            val_16 = val_5.y * val_16;
            val_16 = (this.专丐丆丝丒世丁丛丗.height * val_16) - val_16;
            val_16 = val_16 - (System.Math.Abs(S13) - System.Math.Abs(val_5.x));
            val_16 = val_16 - val_6.y;
            val_16 = System.Math.Abs(val_3.y) - val_16;
            float val_9 = UnityEngine.Mathf.Clamp(value:  val_16, min:  0f, max:  val_12);
            val_9 = val_9 / val_12;
            this._value = val_9;
        }
        
        UnityEngine.Vector3 val_10 = this.start.position;
        UnityEngine.Vector3 val_11 = this.end.position;
        return UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, t:  this._value);
    }
    private void LateUpdate()
    {
        if(this.丙丈丟万丁丒丂与一 == 0)
        {
                return;
        }
        
        UIWrapContent val_3 = this.丙丈丟万丁丒丂与一.wrapContent;
        int val_8 = val_3.itemSize;
        val_8 = val_8 * this.丙丈丟万丁丒丂与一.丟丟丁下丒业丅丄万();
        this.七与且一业一丄丁丁 = (float)val_8;
        this.丁丂不丅世丈专丌丂 = (this.专丐丆丝丒世丁丛丗.height < 0) ? 1 : 0;
        if(this.丒丅丛一业丘世不且 != false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.丅丗丐丂专世且丟丁();
        this.thumb.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public DynamicWrapScrollBar()
    {
    
    }

}
