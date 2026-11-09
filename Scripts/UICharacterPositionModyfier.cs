using UnityEngine;
internal sealed class UICharacterPositionModyfier : PGBehaviour
{
    // Fields
    private float lerpParam;
    private UnityEngine.Transform basePoint;
    private System.Collections.Generic.List<UICharacterPositionModyfier.PositionDescription> _positions;
    private UnityEngine.Vector3 丙丌丛丘丗与一专丁;
    private UnityEngine.Quaternion 丆一丛丙丙丂三丑丂;
    private UnityEngine.Vector3 丈丅上上三丑丝丅丑;
    
    // Methods
    public void SetPosition(System.Nullable<CategoryNames> 业丈世与下丘丛丐且, string 丞一丁业丄一一业且)
    {
        object val_14;
        System.Func<TSource, System.Boolean> val_15;
        float val_16;
        float val_17;
        float val_18;
        UnityEngine.Transform val_19;
        UICharacterPositionModyfier.上丌专丄丘丂东且丒 val_1 = null;
        val_14 = val_1;
        val_1 = new UICharacterPositionModyfier.上丌专丄丘丂东且丒();
        val_15 = val_14;
        .业丈世与下丘丛丐且 = 业丈世与下丘丛丐且;
        if(this.basePoint == 0)
        {
                return;
        }
        
        if((1152921539455828272 & 1) == 0)
        {
            goto label_9;
        }
        
        System.Func<PositionDescription, System.Boolean> val_3 = null;
        val_15 = val_3;
        val_3 = new System.Func<PositionDescription, System.Boolean>(object:  val_1, method:  System.Boolean UICharacterPositionModyfier.上丌专丄丘丂东且丒::丁东一丂七丑丁丝丘(UICharacterPositionModyfier.PositionDescription 丁丂专业丁丅丅丈丙));
        val_14 = System.Linq.Enumerable.FirstOrDefault<PositionDescription>(source:  this._positions, predicate:  val_3);
        if((val_14 == null) || (val_4.Trans == 0))
        {
            goto label_9;
        }
        
        UnityEngine.Vector3 val_6 = val_4.Trans.localPosition;
        val_16 = val_6.x;
        val_17 = val_6.y;
        val_18 = val_6.z;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) != true)
        {
                if((PGCompany.BattlePass.BPCharacterPositions.丐丅丟丙一且丟丗丝(丞一丁业丄一一业且:  丞一丁业丄一一业且)) != null)
        {
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18}, b:  new UnityEngine.Vector3() {x = val_8.Position, y = V11.16B, z = V12.16B});
            val_16 = val_9.x;
            val_17 = val_9.y;
            val_18 = val_9.z;
        }
        
        }
        
        UnityEngine.Quaternion val_10 = val_4.Trans.localRotation;
        val_19 = val_4.Trans;
        goto label_18;
        label_9:
        UnityEngine.Vector3 val_11 = this.basePoint.localPosition;
        val_16 = val_11.x;
        val_17 = val_11.y;
        val_18 = val_11.z;
        UnityEngine.Quaternion val_12 = this.basePoint.localRotation;
        val_19 = this.basePoint;
        label_18:
        UnityEngine.Vector3 val_13 = 0.localScale;
        this.丙丌丛丘丗与一专丁 = val_11;
        mem[1152921539455792260] = val_17;
        mem[1152921539455792264] = val_18;
        this.丆一丛丙丙丂三丑丂 = val_12;
        mem[1152921539455792272] = val_12.y;
        mem[1152921539455792276] = val_12.z;
        mem[1152921539455792280] = val_12.w;
        this.丈丅上上三丑丝丅丑 = val_13;
        mem[1152921539455792288] = val_13.y;
        mem[1152921539455792292] = val_13.z;
    }
    private void 下丏且一三丐一丐不(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, UnityEngine.Vector3 丝丕丁丏丏上丅丏且)
    {
        var val_1;
        this.丙丌丛丘丗与一专丁 = 下业丕七东丌丝下且;
        mem[1152921539455961604] = 下业丕七东丌丝下且.y;
        mem[1152921539455961608] = 下业丕七东丌丝下且.z;
        this.丆一丛丙丙丂三丑丂 = 丙丆与丅丈丑一且丏;
        mem[1152921539455961616] = 丙丆与丅丈丑一且丏.y;
        mem[1152921539455961620] = 丙丆与丅丈丑一且丏.z;
        mem[1152921539455961624] = 丙丆与丅丈丑一且丏.w;
        this.丈丅上上三丑丝丅丑 = 丝丕丁丏丏上丅丏且;
        mem[1152921539455961632] = val_1;
        mem[1152921539455961636] = 丝丕丁丏丏上丅丏且.y;
    }
    private void OnEnable()
    {
        UnityEngine.Vector3 val_1 = this.basePoint.localPosition;
        UnityEngine.Quaternion val_2 = this.basePoint.localRotation;
        UnityEngine.Vector3 val_3 = this.basePoint.localScale;
        this.丙丌丛丘丗与一专丁 = val_1;
        mem[1152921539456085892] = val_1.y;
        mem[1152921539456085896] = val_1.z;
        this.丆一丛丙丙丂三丑丂 = val_2;
        mem[1152921539456085904] = val_2.y;
        mem[1152921539456085908] = val_2.z;
        mem[1152921539456085912] = val_2.w;
        this.丈丅上上三丑丝丅丑 = val_3;
        mem[1152921539456085920] = val_3.y;
        mem[1152921539456085924] = val_3.z;
    }
    private void Update()
    {
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        float val_4 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = this.丙丌丛丘丗与一专丁, y = V11.16B, z = V12.16B}, t:  this.lerpParam * val_4);
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_9 = this.transform.localRotation;
        float val_10 = UnityEngine.Time.deltaTime;
        val_10 = this.lerpParam * val_10;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, b:  new UnityEngine.Quaternion() {x = this.丆一丛丙丙丂三丑丂, y = V12.16B, z = val_3.z, w = val_4}, t:  val_10);
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        UnityEngine.Vector3 val_14 = this.transform.localScale;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = this.丈丅上上三丑丝丅丑, y = val_11.w, z = V12.16B}, t:  this.lerpParam * UnityEngine.Time.deltaTime);
        this.transform.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
    }
    public UICharacterPositionModyfier()
    {
        this.lerpParam = 6f;
    }

}
