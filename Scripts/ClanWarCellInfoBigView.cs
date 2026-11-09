using UnityEngine;
internal class ClanWarCellInfoBigView : PGBehaviour
{
    // Fields
    private UIPanel holder;
    private ClanWarCellInfoView cellInfoView;
    private float animationSpeed;
    private bool animateAlpha;
    private UnityEngine.Vector3 shownPosition;
    private UnityEngine.Vector3 hiddenPosition;
    private System.Collections.Generic.List<UIWidget> hideOnShow;
    private bool 一丆一丕世七丕上专;
    private bool 丟丛丕世三丙东丈丐;
    private float 上丛东丄丕丈不丌丅;
    
    // Properties
    internal bool 不丑下业专丟丘丄丗 { get; }
    
    // Methods
    internal bool 丞且一丅七东三一丗()
    {
        return (bool)this.丟丛丕世三丙东丈丐;
    }
    internal void 下与丞三丅丛丄七丕(不上丌世万丁丝丏丆 丞丘丈丝丑丟七丞不, bool 与丑丑丑丂丛一丝一, System.Nullable<bool> 丞丈丌且东丆丅丗万)
    {
        var val_14;
        UIPanel val_15;
        var val_16;
        UnityEngine.Vector3 val_18;
        val_14 = this;
        if(this.一丆一丕世七丕上专 != false)
        {
                this.世丛丗丛丂丌丒丑专();
        }
        
        if(丞丘丈丝丑丟七丞不 == null)
        {
            goto label_2;
        }
        
        丞丈丌且东丆丅丗万.HasValue = 丞丈丌且东丆丅丗万.HasValue & 65535;
        this.cellInfoView.业不丝丄丙丌丌丈丄(丟丏丄一世丛丌上七:  0, 且丝丑一丐丄丁一与:  丞丘丈丝丑丟七丞不, 丞丈丌且东丆丅丗万:  new System.Nullable<System.Boolean>() {HasValue = 丞丈丌且东丆丅丗万.HasValue});
        val_15 = this.holder;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_15, 丏业丟一东丂东丘丛:  true);
        this.丟丛丕世三丙东丈丐 = true;
        if(与丑丑丑丂丛一丝一 == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = ClanWarCellInfoBigView.<>c.<>9__11_0;
        if(val_15 == null)
        {
            goto label_9;
        }
        
        label_18:
        this.hideOnShow.ForEach(action:  val_15);
        val_18 = this.shownPosition;
        this.holder.transform.localPosition = new UnityEngine.Vector3() {x = val_18, y = V9.16B, z = V10.16B};
        if(this.animateAlpha == false)
        {
                return;
        }
        
        val_14 = ???;
        val_15 = ???;
        val_18 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
        label_2:
        this.丆世与丑丆丅丐万且(与丑丑丑丂丛一丝一:  与丑丑丑丂丛一丝一);
        return;
        label_9:
        ClanWarCellInfoBigView.<>c.<>9__11_0 = new System.Action<UIWidget>(object:  ClanWarCellInfoBigView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanWarCellInfoBigView.<>c::且丆丛丛东不且丂东(UIWidget 三丟东丕丄丄下下丑));
        if(this.hideOnShow != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    internal void 丆世与丑丆丅丐万且(bool 与丑丑丑丂丛一丝一)
    {
        System.Action<UIWidget> val_13;
        var val_14;
        var val_15;
        UnityEngine.Vector3 val_17;
        val_14 = this;
        if(this.一丆一丕世七丕上专 != false)
        {
                this.世丛丗丛丂丌丒丑专();
        }
        
        this.丟丛丕世三丙东丈丐 = false;
        if(与丑丑丑丂丛一丝一 == true)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_13 = ClanWarCellInfoBigView.<>c.<>9__12_0;
        if(val_13 == null)
        {
            goto label_5;
        }
        
        label_14:
        this.hideOnShow.ForEach(action:  val_13);
        val_17 = this.hiddenPosition;
        this.holder.transform.localPosition = new UnityEngine.Vector3() {x = val_17, y = V9.16B, z = V10.16B};
        if(this.animateAlpha == false)
        {
                return;
        }
        
        val_14 = ???;
        val_13 = ???;
        val_17 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
        label_5:
        ClanWarCellInfoBigView.<>c.<>9__12_0 = new System.Action<UIWidget>(object:  ClanWarCellInfoBigView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanWarCellInfoBigView.<>c::丘且丗丘三且丙上七(UIWidget 三丟东丕丄丄下下丑));
        if(this.hideOnShow != null)
        {
            goto label_14;
        }
        
        goto label_14;
    }
    private void Update()
    {
        object val_52;
        var val_53;
        float val_54;
        float val_55;
        float val_56;
        var val_57;
        UIPanel val_58;
        float val_59;
        float val_60;
        float val_61;
        float val_63;
        System.Collections.Generic.List<UIWidget> val_64;
        System.Action<UIWidget> val_65;
        float val_66;
        float val_67;
        object val_68;
        float val_69;
        float val_70;
        float val_71;
        val_52 = this;
        if(this.一丆一丕世七丕上专 == false)
        {
            goto label_1;
        }
        
        if(this.丟丛丕世三丙东丈丐 == false)
        {
                return;
        }
        
        .丏业丟一东丂东丘丛 = this.上丛东丄丕丈不丌丅 / this.hiddenPosition;
        this.hideOnShow.ForEach(action:  new System.Action<UIWidget>(object:  new ClanWarCellInfoBigView.世东丒与丞七不不东(), method:  System.Void ClanWarCellInfoBigView.世东丒与丞七不不东::一不上与下丅丅丁丘(UIWidget 三丟东丕丄丄下下丑)));
        val_53 = this.holder.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.hiddenPosition, y = V3.16B, z = val_5.z});
        val_54 = val_7.y;
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_54}, t:  (ClanWarCellInfoBigView.世东丒与丞七不不东)[1152921536806545392].丏业丟一东丂东丘丛);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
        val_55 = val_9.x;
        val_56 = val_9.z;
        val_57 = 0;
        val_53.localPosition = new UnityEngine.Vector3() {x = val_55, y = val_9.y, z = val_56};
        if(this.animateAlpha == false)
        {
                return;
        }
        
        val_58 = this.holder;
        val_59 = 0f;
        val_60 = (ClanWarCellInfoBigView.世东丒与丞七不不东)[1152921536806545392].丏业丟一东丂东丘丛;
        val_61 = UnityEngine.Mathf.Lerp(a:  1f, b:  val_59, t:  val_60);
        val_63 = val_61;
        goto label_15;
        label_1:
        val_64 = this.hideOnShow;
        val_65 = null;
        if(this.丟丛丕世三丙东丈丐 == false)
        {
            goto label_16;
        }
        
        val_65 = new System.Action<UIWidget>(object:  this, method:  System.Void ClanWarCellInfoBigView::丙不丙丛丑上丝专丞(UIWidget 三丟东丕丄丄下下丑));
        val_64.ForEach(action:  null);
        val_53 = this.holder.transform;
        UnityEngine.Vector3 val_14 = val_53.localPosition;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = this.shownPosition, y = V3.16B, z = val_14.z});
        val_54 = val_16.y;
        UnityEngine.Vector2 val_19 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_54}, t:  UnityEngine.Time.deltaTime * this.animationSpeed);
        UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
        val_55 = val_20.x;
        val_66 = val_20.z;
        this.holder.transform.localPosition = new UnityEngine.Vector3() {x = val_55, y = val_20.y, z = val_66};
        if(this.animateAlpha == false)
        {
                return;
        }
        
        val_61 = val_55;
        val_67 = this.animationSpeed;
        val_60 = UnityEngine.Time.deltaTime * val_67;
        val_59 = 1f;
        val_63 = val_61;
        float val_22 = UnityEngine.Mathf.Lerp(a:  val_63, b:  val_59, t:  val_60);
        label_15:
        val_64 = ???;
        val_68 = ???;
        val_65 = ???;
        goto typeof(UIPanel).__il2cppRuntimeField_1A8;
        label_16:
        val_65 = new System.Action<UIWidget>(object:  val_68, method:  System.Void ClanWarCellInfoBigView::丆业七丛丝丁丙丑东(UIWidget 三丟东丕丄丄下下丑));
        val_64.ForEach(action:  val_65);
        val_53 = val_68 + 72.transform;
        UnityEngine.Vector3 val_26 = val_53.localPosition;
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_68 + 108, y = val_68 + 108 + 4, z = val_68 + 116});
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y}, b:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, t:  UnityEngine.Time.deltaTime * (val_68 + 88));
        UnityEngine.Vector3 val_32 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y});
        val_69 = val_32.x;
        val_70 = val_32.y;
        val_71 = val_32.z;
        val_68 + 72.transform.localPosition = new UnityEngine.Vector3() {x = val_69, y = val_70, z = val_71};
        if((val_68 + 92) != 0)
        {
                val_71 = UnityEngine.Time.deltaTime * (val_68 + 88);
            val_70 = 0f;
            val_69 = val_69;
            float val_34 = UnityEngine.Mathf.Lerp(a:  val_69, b:  val_70, t:  val_71);
        }
        
        UnityEngine.Vector3 val_36 = val_68 + 72.transform.localPosition;
        val_66 = mem[val_68 + 116];
        val_66 = val_68 + 116;
        val_55 = val_36.x;
        if((万上丈专丐专丞丛丛.丙下且丒丑东丑丞丈(丞下万上三丘上与专:  new UnityEngine.Vector3() {x = val_55, y = val_36.y, z = val_36.z}, 丒丈丙丐丏丕丆万丗:  new UnityEngine.Vector3() {x = val_68 + 108, y = val_68 + 108 + 4, z = val_66}, 丞丞丙且丄不丈丌三:  0.01f)) == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_68 + 72, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丐且丞丕丞三丏丌丄()
    {
        this.一丆一丕世七丕上专 = true;
        this.上丛东丄丕丈不丌丅 = 0f;
    }
    internal void 世丛丗丛丂丌丒丑专()
    {
        UnityEngine.Vector3 val_2 = this.hiddenPosition;
        this.一丆一丕世七丕上专 = false;
        val_2 = val_2 * 0.5f;
        if(this.上丛东丄丕丈不丌丅 < val_2)
        {
                return;
        }
        
        ClanWarUI.丑七不且上丗丁一世().丂丘一丐七且丕世丅();
    }
    internal void 下丏且一三丐一丐不(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        丞且丅三三东不丄且.x = 丞且丅三三东不丄且.x + this.上丛东丄丕丈不丌丅;
        this.上丛东丄丕丈不丌丅 = 丞且丅三三东不丄且.x;
    }
    public ClanWarCellInfoBigView()
    {
        this.animationSpeed = 5f;
        this.animateAlpha = true;
        this.hideOnShow = new System.Collections.Generic.List<UIWidget>(capacity:  0);
    }
    private void 丙不丙丛丑上丝专丞(UIWidget 三丟东丕丄丄下下丑)
    {
        float val_3 = UnityEngine.Mathf.Lerp(a:  V0.16B, b:  0f, t:  UnityEngine.Time.deltaTime * this.animationSpeed);
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
    }
    private void 丆业七丛丝丁丙丑东(UIWidget 三丟东丕丄丄下下丑)
    {
        float val_3 = UnityEngine.Mathf.Lerp(a:  V0.16B, b:  1f, t:  UnityEngine.Time.deltaTime * this.animationSpeed);
        goto typeof(UIWidget).__il2cppRuntimeField_1A8;
    }

}
