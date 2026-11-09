using UnityEngine;
public class MyCenterOnChild : MonoBehaviour
{
    // Fields
    public bool endlessScroll;
    private UnityEngine.GameObject 世丑丁丛万丌丈丂丒;
    private UIScrollView 丛且世三丆丝丞丗丈;
    public float nextPageThreshold;
    public SpringPanel.上丄丂丛专下丟万下 onFinished;
    public float springStrength;
    
    // Properties
    public UnityEngine.GameObject 下且专丒下丙丈丈丒 { get; }
    
    // Methods
    public UnityEngine.GameObject get_centeredObject()
    {
        return (UnityEngine.GameObject)this.世丑丁丛万丌丈丂丒;
    }
    private void OnEnable()
    {
        this.Recenter();
    }
    private void 丒丗丝专丝下且业与()
    {
        if(this.enabled == false)
        {
                return;
        }
        
        this.Recenter();
    }
    private void OnValidate()
    {
        this.nextPageThreshold = System.Math.Abs(this.nextPageThreshold);
    }
    public void Recenter()
    {
        IntPtr val_44;
        float val_49;
        float val_50;
        UnityEngine.GameObject val_51;
        UIScrollView val_52;
        var val_53;
        float val_54;
        var val_55;
        float val_56;
        var val_57;
        int val_58;
        var val_59;
        if(this.丛且世三丆丝丞丗丈 == 0)
        {
                UIScrollView val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丛且世三丆丝丞丗丈 = val_3;
            if(val_3 == 0)
        {
                val_44 = null;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} requires {1} on a parent object in order to work", arg0:  this.GetType(), arg1:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_44})), context:  this);
            this.enabled = false;
            return;
        }
        
            UIScrollView.七丁丌丒万丄专三三 val_8 = null;
            val_44 = 1152921538409769648;
            val_8 = new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MyCenterOnChild::丒丗丝专丝下且业与());
            this.丛且世三丆丝丞丗丈.onDragFinished = val_8;
            if(this.丛且世三丆丝丞丗丈.horizontalScrollBar != 0)
        {
                this.丛且世三丆丝丞丗丈.horizontalScrollBar.onDragFinished = new UIProgressBar.丒丗丝专丝下且业与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MyCenterOnChild::丒丗丝专丝下且业与());
        }
        
            if(this.丛且世三丆丝丞丗丈.verticalScrollBar != 0)
        {
                this.丛且世三丆丝丞丗丈.verticalScrollBar.onDragFinished = new UIProgressBar.丒丗丝专丝下且业与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void MyCenterOnChild::丒丗丝专丝下且业与());
        }
        
        }
        
        if(this.丛且世三丆丝丞丗丈.panel == 0)
        {
                return;
        }
        
        UIPanel val_15 = this.丛且世三丆丝丞丗丈.panel;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  0.5f);
        UnityEngine.Vector3 val_18 = this.丛且世三丆丝丞丗丈.currentMomentum;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.丛且世三丆丝丞丗丈.momentumAmount * 0.1f);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.zero;
        val_49 = val_22.x;
        val_50 = val_22.z;
        this.丛且世三丆丝丞丗丈.currentMomentum = new UnityEngine.Vector3() {x = val_49, y = val_22.y, z = val_50};
        UnityEngine.Transform val_23 = this.transform;
        val_51 = val_23.childCount;
        if(val_51 >= 1)
        {
                var val_43 = 0;
            do
        {
            val_52 = val_23.GetChild(index:  0);
            UnityEngine.Vector3 val_26 = val_52.position;
            val_49 = val_26.x;
            val_50 = val_26.z;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_49, y = val_26.y, z = val_50}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            float val_28 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            var val_29 = (val_28 < 0) ? (val_43) : 0;
            val_43 = val_43 + 1;
            var val_30 = (val_28 < 0) ? (val_52) : 0;
            var val_31 = (val_28 < 0) ? (val_28) : 3.402823E+38f;
        }
        while(val_51 != val_43);
        
        }
        else
        {
                val_53 = 0;
            val_44 = 0;
        }
        
        val_54 = this.nextPageThreshold;
        if(val_54 <= 0f)
        {
            goto label_49;
        }
        
        val_52 = 1152921505096622080;
        val_55 = null;
        val_56 = val_17.z;
        goto label_53;
        label_49:
        val_56 = val_17.z;
        goto label_88;
        label_53:
        if(UICamera.currentTouch == null)
        {
            goto label_88;
        }
        
        val_51 = this.世丑丁丛万丌丈丂丒;
        if(val_51 == 0)
        {
            goto label_88;
        }
        
        val_51 = this.世丑丁丛万丌丈丂丒.transform;
        if(val_51 != (val_23.GetChild(index:  0)))
        {
            goto label_88;
        }
        
        val_57 = null;
        val_57 = null;
        val_51 = mem[UICamera.currentTouch + 44 + 4];
        val_51 = UICamera.currentTouch + 44 + 4;
        val_52 = this.丛且世三丆丝丞丗丈;
        if(this.丛且世三丆丝丞丗丈.movement == 0)
        {
            goto label_67;
        }
        
        if(this.丛且世三丆丝丞丗丈.movement != 1)
        {
            goto label_68;
        }
        
        val_54 = val_51;
        goto label_70;
        label_67:
        val_54 = 3.263296E-30f;
        goto label_70;
        label_68:
        label_70:
        if(val_54 <= this.nextPageThreshold)
        {
            goto label_71;
        }
        
        val_51 = val_53 - 1;
        if(val_54 < this.nextPageThreshold)
        {
            goto label_72;
        }
        
        val_58 = val_51;
        goto label_90;
        label_71:
        if(val_54 >= 0)
        {
            goto label_88;
        }
        
        if(val_53 >= (val_23.childCount - 1))
        {
            goto label_77;
        }
        
        val_58 = val_53 + 1;
        goto label_79;
        label_72:
        if((this.endlessScroll == false) || ((val_53 != 0) || (val_23.childCount < 1)))
        {
            goto label_88;
        }
        
        if(val_23 == null)
        {
            goto label_84;
        }
        
        val_59 = val_23.childCount;
        goto label_85;
        label_77:
        if((this.endlessScroll == false) || (val_23.childCount < 1))
        {
            goto label_88;
        }
        
        val_58 = 0;
        goto label_90;
        label_84:
        val_59 = 0.childCount;
        label_85:
        val_58 = val_59 - 1;
        label_79:
        label_90:
        val_44 = val_23.GetChild(index:  val_58);
        label_88:
        this.丑下下丂业丑东丝丒(丞下万上三丘上与专:  val_44, 丁丈丏下丅业且丗东:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y});
    }
    private void 丑下下丂业丑东丝丒(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 丁丈丏下丅业且丗东)
    {
        if(((丞下万上三丘上与专 == 0) || (this.丛且世三丆丝丞丗丈 == 0)) || (this.丛且世三丆丝丞丗丈.panel == 0))
        {
            goto label_10;
        }
        
        UnityEngine.Transform val_6 = this.丛且世三丆丝丞丗丈.panel.cachedTransform;
        if(丞下万上三丘上与专 == null)
        {
            goto label_13;
        }
        
        this.世丑丁丛万丌丈丂丒 = 丞下万上三丘上与专.gameObject;
        goto label_14;
        label_10:
        this.世丑丁丛万丌丈丂丒 = 0;
        return;
        label_13:
        this.世丑丁丛万丌丈丂丒 = 0.gameObject;
        label_14:
        UnityEngine.Vector3 val_9 = 丞下万上三丘上与专.position;
        UnityEngine.Vector3 val_10 = val_6.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = val_6.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丁丈丏下丅业且丗东.x, y = 丁丈丏下丅业且丗东.y, z = 丁丈丏下丅业且丗东.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_19 = val_6.localPosition;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = (this.丛且世三丆丝丞丗丈.canMoveHorizontally != true) ? val_12.x : 0f, y = (this.丛且世三丆丝丞丗丈.canMoveVertically != true) ? val_12.y : 0f, z = 0f});
        SpringPanel val_21 = SpringPanel.Begin(丝三丁东丈丒世丅业:  this.丛且世三丆丝丞丗丈.panel.cachedGameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, 丛上丟丌丄丗丁世与:  this.springStrength);
        val_21.onFinished = this.onFinished;
    }
    public void CenterOn(UnityEngine.Transform 丞下万上三丘上与专)
    {
        UIScrollView val_7 = this.丛且世三丆丝丞丗丈;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = this.丛且世三丆丝丞丗丈.panel;
        if(val_7 == 0)
        {
                return;
        }
        
        UIPanel val_4 = this.丛且世三丆丝丞丗丈.panel;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.5f);
        this.丑下下丂业丑东丝丒(丞下万上三丘上与专:  丞下万上三丘上与专, 丁丈丏下丅业且丗东:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }
    public MyCenterOnChild()
    {
        this.springStrength = 8f;
    }

}
