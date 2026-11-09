using UnityEngine;
internal class WorldPosIndicationItem : MonoBehaviour
{
    // Fields
    protected UITexture iconTexture;
    protected UITexture directionArrowTexture;
    private UnityEngine.Transform directionArrowTransform;
    private float indicationRadius;
    private float indicationPivotOffset;
    private UnityEngine.GameObject visualizePoint;
    private PGTweenerAlpha _tweenerAlpha;
    protected UnityEngine.Transform 丒丛丟丟三万且万丌;
    private bool 七上丟不一丁丈七七;
    private UnityEngine.Vector3 丘与一丒丕丑上万丈;
    public bool clampOnScreen;
    private static float 丄丞丘丌万上丘三丒;
    private static float 丄丘丈世丁丂东丁丙;
    private static float 且七七丆不不专业丆;
    private static float 与丂与万不丈且世与;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    
    // Methods
    internal void 万三丗丆下万丅上丈(UnityEngine.Transform 丞下万上三丘上与专, float 丒专丌万丄一丒万丏 = 0)
    {
        this.丒丛丟丟三万且万丌 = 丞下万上三丘上与专;
        this.七上丟不一丁丈七七 = true;
        this.丘与一丒丕丑上万丈 = 0;
        mem[1152921539697182012] = 0;
    }
    internal void 与一丆业七丞丈专上()
    {
        this.丒丛丟丟三万且万丌 = 0;
        this.七上丟不一丁丈七七 = false;
    }
    internal void 丙丈东丑丒丙上与丞(UnityEngine.Texture 与万丆丛丒万丝丙丑, UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        if(this.iconTexture == 与万丆丛丒万丝丙丑)
        {
                UnityEngine.Color val_2 = this.iconTexture.color;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, rhs:  new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a})) != false)
        {
                return;
        }
        
        }
        
        this.iconTexture.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    internal void 丙丈东丑丒丙上与丞(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  与万丆丛丒万丝丙丑, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
    }
    internal void 丝东不丄且不丏业丘(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_50;
        float val_51;
        UnityEngine.Transform val_52;
        UnityEngine.Transform val_53;
        var val_54;
        var val_55;
        float val_56;
        float val_57;
        var val_58;
        float val_59;
        float val_60;
        val_50 = 业丒丝丗与丐丛丟丏.z;
        val_51 = 业丒丝丗与丐丛丟丏.x;
        val_52 = this;
        val_53 = 1152921505207164928;
        val_54 = null;
        val_54 = null;
        if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.visualizePoint, 丏业丟一东丂东丘丛:  true);
        val_55 = null;
        val_55 = null;
        UnityEngine.Vector3 val_2 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_51, y = 业丒丝丗与丐丛丟丏.y, z = val_50});
        val_56 = val_2.x;
        val_57 = val_2.y;
        if(val_2.z >= 0)
        {
            goto label_17;
        }
        
        if(this.clampOnScreen == false)
        {
            goto label_12;
        }
        
        int val_3 = UnityEngine.Screen.width;
        var val_4 = (val_3 < 0) ? (val_3 + 1) : (val_3);
        val_4 = val_4 >> 1;
        if(val_56 >= 0)
        {
            goto label_13;
        }
        
        val_58 = 0;
        int val_5 = UnityEngine.Screen.width;
        goto label_14;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.visualizePoint, 丏业丟一东丂东丘丛:  false);
        goto label_17;
        label_13:
        val_58 = 0;
        label_14:
        val_56 = 0f;
        int val_6 = UnityEngine.Screen.height;
        var val_7 = (val_6 < 0) ? (val_6 + 1) : (val_6);
        val_7 = val_7 >> 1;
        val_57 = (float)val_7;
        label_17:
        val_53 = InGameGUI.丙丞专丌丁丞与不丐.丝丙与东丈不丙三丟();
        UnityEngine.Vector3 val_9 = val_53.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = val_56, y = val_57, z = 0f});
        val_50 = val_9.x;
        val_51 = val_9.z;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = val_50, y = val_9.y, z = val_51};
        if(this.clampOnScreen != false)
        {
                UnityEngine.Vector3 val_10 = this.万东万丆专丌丕丐丗.localPosition;
            val_51 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            val_59 = this.indicationRadius;
            val_60 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_50 = (float)UnityEngine.Screen.height;
            float val_51 = (float)-UnityEngine.Screen.width;
            val_50 = val_50 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_52 = (float)-UnityEngine.Screen.height;
            val_51 = val_51 * 0.5f;
            val_52 = val_52 * 0.5f;
            float val_53 = (float)UnityEngine.Screen.width;
            float val_54 = -2f;
            val_53 = val_53 / val_60;
            val_54 = this.indicationRadius * val_54;
            val_53 = val_53 + val_54;
            float val_21 = (val_51 / val_51) + this.indicationRadius;
            float val_24 = this.indicationPivotOffset + (val_59 + (val_52 / 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专()));
            float val_25 = val_50 - (this.indicationRadius + this.indicationRadius);
            val_50 = val_10.x;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_50, y:  val_10.y);
            val_53 = this.directionArrowTransform;
            if(val_53 != 0)
        {
                val_53 = this.directionArrowTransform.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_53, 丏业丟一东丂东丘丛:  true);
        }
        
            if(( & 1) != 0)
        {
                return;
        }
        
            val_50 = System.Math.Abs(val_50 + val_50);
            float val_56 = (float)UnityEngine.Screen.height;
            float val_57 = (float)UnityEngine.Screen.width;
            val_56 = val_56 / val_57;
            val_57 = val_50 * val_56;
            UnityEngine.Vector3 val_34 = this.万东万丆专丌丕丐丗.localPosition;
            val_59 = val_34.z;
            UnityEngine.Vector3 val_35 = this.万东万丆专丌丕丐丗.localPosition;
            float val_58 = 768f;
            val_58 = (UnityEngine.Mathf.Max(a:  System.Math.Abs(val_10.y + val_10.y), b:  val_57)) / val_58;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_59}, maxLength:  val_35.x / val_58);
            float val_38 = 0.x;
            float val_39 = UnityEngine.Mathf.Clamp(value:  val_37.x, min:  val_38, max:  val_38);
            val_60 = val_39;
            val_51 = val_39;
            float val_40 = UnityEngine.Mathf.Clamp(value:  val_37.y, min:  val_51, max:  val_39);
            this.万东万丆专丌丕丐丗.localPosition = new UnityEngine.Vector3() {x = val_60, y = val_40, z = val_37.z};
            if(this.directionArrowTransform == 0)
        {
                return;
        }
        
            val_53 = this.万东万丆专丌丕丐丗;
            UnityEngine.Vector3 val_42 = val_53.right;
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z});
            val_59 = val_43.x;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_60, y = val_40, z = val_37.z});
            val_52 = this.万东万丆专丌丕丐丗;
            UnityEngine.Vector3 val_45 = val_52.forward;
            UnityEngine.Quaternion val_47 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  CompasController.东东丂七专丁丆丛丁(一不丝丟世业丑丙一:  new UnityEngine.Vector3() {x = val_59, y = val_43.y, z = val_43.z}, 丘丑丛丕下丈世下丂:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z}, 丏丟万且丝丒丝丅东:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.z}));
            val_50 = val_47.x;
            val_51 = val_47.z;
            this.directionArrowTransform.localRotation = new UnityEngine.Quaternion() {x = val_50, y = val_47.y, z = val_51, w = val_47.w};
            return;
        }
        
        if(this.directionArrowTransform == 0)
        {
                return;
        }
        
        val_52 = this.directionArrowTransform.gameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_52, 丏业丟一东丂东丘丛:  false);
    }
    protected virtual void Awake()
    {
        this.万东万丆专丌丕丐丗 = this.transform;
        if(this.directionArrowTransform == 0)
        {
                return;
        }
        
        this.directionArrowTransform.gameObject.SetActive(value:  false);
    }
    protected virtual void LateUpdate()
    {
        if(this.七上丟不一丁丈七七 == false)
        {
                return;
        }
        
        if(this.丒丛丟丟三万且万丌 != 0)
        {
                UnityEngine.Vector3 val_2 = this.丒丛丟丟三万且万丌.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.丘与一丒丕丑上万丈, y = V11.16B, z = V10.16B});
            this.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.visualizePoint, 丏业丟一东丂东丘丛:  false);
    }
    internal virtual void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
    {
        this.directionArrowTexture.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
    }
    internal void 丙丘与丒七丒丞丗丈(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, float 丂七上与上不丘丐丛)
    {
        if(this._tweenerAlpha == 0)
        {
                PGTweenerAlpha val_3 = this.gameObject.AddComponent<PGTweenerAlpha>();
            this._tweenerAlpha = val_3;
            val_3.丁世丁丈丒丗丙丌不(世丌丌丙丞丟下东丞:  this.iconTexture);
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丞丒丅上丅与丙丅世(丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丂七上与上不丘丐丛:  丂七上与上不丘丐丛));
    }
    private System.Collections.IEnumerator 丞丒丅上丅与丙丅世(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, float 丂七上与上不丘丐丛)
    {
        WorldPosIndicationItem.丙下丘丅丌上丁上丈 val_1 = new WorldPosIndicationItem.丙下丘丅丌上丁上丈();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丈丗与丞一上且上上 = 丈丗与丞一上且上上;
            .专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
            .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        }
        else
        {
                mem[40] = this;
            mem[48] = 丈丗与丞一上且上上;
            .专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
            mem[56] = 丂三丟丂丈丐丆丗丟;
        }
        
        .丂七上与上不丘丐丛 = 丂七上与上不丘丐丛;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 上丄丐丅三丄三丈丘(bool 丛与丙丒丒下丌丟且)
    {
        丛与丙丒丒下丌丟且 = 丛与丙丒丒下丌丟且;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.iconTexture, 丏业丟一东丂东丘丛:  丛与丙丒丒下丌丟且);
    }
    public WorldPosIndicationItem()
    {
        this.indicationRadius = 60f;
        this.indicationPivotOffset = -30f;
        this.clampOnScreen = true;
    }
    private static WorldPosIndicationItem()
    {
    
    }

}
