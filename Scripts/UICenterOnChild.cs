using UnityEngine;
public class UICenterOnChild : MonoBehaviour
{
    // Fields
    public float springStrength;
    public float nextPageThreshold;
    public SpringPanel.上丄丂丛专下丟万下 onFinished;
    public UICenterOnChild.且丐丁世专丝丕丆丁 onCenter;
    private UIScrollView 丛且世三丆丝丞丗丈;
    private UnityEngine.GameObject 世丑丁丛万丌丈丂丒;
    
    // Properties
    public UnityEngine.GameObject 下且专丒下丙丈丈丒 { get; }
    
    // Methods
    public UnityEngine.GameObject get_centeredObject()
    {
        return (UnityEngine.GameObject)this.世丑丁丛万丌丈丂丒;
    }
    private void Start()
    {
        this.Recenter();
    }
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丛且世三丆丝丞丗丈)) == false)
        {
                return;
        }
        
        this.丛且世三丆丝丞丗丈.centerOnChild = this;
        this.Recenter();
    }
    private void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.丛且世三丆丝丞丗丈)) == false)
        {
                return;
        }
        
        this = this.丛且世三丆丝丞丗丈;
        this.丛且世三丆丝丞丗丈.centerOnChild = 0;
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
        var val_74;
        IntPtr val_75;
        UnityEngine.Transform val_76;
        七丁丌丒万丄专三三 val_77;
        丒丗丝专丝下且业与 val_78;
        丒丗丝专丝下且业与 val_79;
        float val_81;
        float val_82;
        float val_86;
        var val_87;
        float val_88;
        float val_89;
        var val_90;
        var val_91;
        float val_92;
        float val_93;
        var val_94;
        var val_96;
        float val_97;
        var val_98;
        var val_99;
        var val_100;
        int val_101;
        val_74 = 1152921504848912384;
        if(this.丛且世三丆丝丞丗丈 == 0)
        {
                UIScrollView val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丛且世三丆丝丞丗丈 = val_3;
            if(val_3 == 0)
        {
                val_75 = null;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} requires {1} on a parent object in order to work", arg0:  this.GetType(), arg1:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_75})), context:  this);
            this.enabled = false;
            return;
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.丛且世三丆丝丞丗丈)) != false)
        {
                this.丛且世三丆丝丞丗丈.centerOnChild = this;
            val_76 = 1152921505091350528;
            UIScrollView.七丁丌丒万丄专三三 val_9 = null;
            val_75 = val_9;
            val_9 = new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UICenterOnChild::丒丗丝专丝下且业与());
            val_77 = System.Delegate.Combine(a:  this.丛且世三丆丝丞丗丈.onDragFinished, b:  val_9);
            if((val_77 != null) && (null != null))
        {
                val_77 = 0;
        }
        
            this.丛且世三丆丝丞丗丈.onDragFinished = val_77;
        }
        
            if(this.丛且世三丆丝丞丗丈.horizontalScrollBar != 0)
        {
                val_76 = 1152921505090924544;
            UIProgressBar.丒丗丝专丝下且业与 val_13 = null;
            val_75 = val_13;
            val_13 = new UIProgressBar.丒丗丝专丝下且业与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UICenterOnChild::丒丗丝专丝下且业与());
            val_78 = System.Delegate.Combine(a:  this.丛且世三丆丝丞丗丈.horizontalScrollBar.onDragFinished, b:  val_13);
            if((val_78 != null) && (null != null))
        {
                val_78 = 0;
        }
        
            this.丛且世三丆丝丞丗丈.horizontalScrollBar.onDragFinished = val_78;
        }
        
            if(this.丛且世三丆丝丞丗丈.verticalScrollBar != 0)
        {
                val_76 = 1152921505090924544;
            UIProgressBar.丒丗丝专丝下且业与 val_16 = null;
            val_75 = val_16;
            val_16 = new UIProgressBar.丒丗丝专丝下且业与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UICenterOnChild::丒丗丝专丝下且业与());
            val_79 = System.Delegate.Combine(a:  this.丛且世三丆丝丞丗丈.verticalScrollBar.onDragFinished, b:  val_16);
            if((val_79 != null) && (null != null))
        {
                val_79 = 0;
        }
        
            this.丛且世三丆丝丞丗丈.verticalScrollBar.onDragFinished = val_79;
        }
        
        }
        
        if(this.丛且世三丆丝丞丗丈.panel == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_20 = this.transform;
        if(val_20.childCount == 0)
        {
                return;
        }
        
        UIPanel val_22 = this.丛且世三丆丝丞丗丈.panel;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  0.5f);
        UnityEngine.Vector3 val_25 = this.丛且世三丆丝丞丗丈.currentMomentum;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  this.丛且世三丆丝丞丗丈.momentumAmount);
        UnityEngine.Vector3 val_27 = 万丗丅且丄丑世专与.丆上专万丌万世丕丙(丏丄业丆业丅且丏丗: ref  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, 丛上丟丌丄丗丁世与:  9f, 丑丗丘与丈不七东丛:  2f);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  0.01f);
        val_81 = val_24.z;
        val_82 = val_28.x;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_81}, b:  new UnityEngine.Vector3() {x = val_82, y = val_28.y, z = val_28.z});
        val_86 = val_29.y;
        val_75 = this.GetComponent<UIGrid>();
        if(val_75 == 0)
        {
            goto label_57;
        }
        
        val_87 = val_75.GetChildList();
        int val_33 = val_87.Count;
        if(val_33 < 1)
        {
            goto label_60;
        }
        
        val_76 = 0;
        val_75 = 0;
        do
        {
            UnityEngine.Transform val_34 = val_87.Item[0];
            if(val_34.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_37 = val_34.position;
            val_88 = val_37.x;
            val_89 = val_37.y;
            val_81 = val_37.z;
            val_82 = val_29.x;
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_88, y = val_89, z = val_81}, b:  new UnityEngine.Vector3() {x = val_82, y = val_86, z = val_29.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z})) < 0)
        {
                val_76 = val_34;
        }
        
            val_75 = val_75 + 1;
        }
        
            val_90 = 0 + 1;
        }
        while(val_33 != val_90);
        
        val_74 = 1152921504848912384;
        val_91 = val_75;
        goto label_82;
        label_57:
        int val_40 = val_20.childCount;
        if(val_40 < 1)
        {
            goto label_72;
        }
        
        val_76 = 0;
        val_91 = 0;
        var val_72 = 0;
        val_75 = 0;
        do
        {
            val_90 = val_20.GetChild(index:  0);
            if(val_90.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_44 = val_90.position;
            val_88 = val_44.x;
            val_89 = val_44.y;
            val_81 = val_44.z;
            val_82 = val_29.x;
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_88, y = val_89, z = val_81}, b:  new UnityEngine.Vector3() {x = val_82, y = val_86, z = val_29.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z})) < 0)
        {
                val_91 = val_75;
            val_76 = val_90;
        }
        
            val_75 = val_75 + 1;
        }
        
            val_72 = val_72 + 1;
        }
        while(val_40 != val_72);
        
        val_87 = 0;
        goto label_82;
        label_72:
        val_87 = 0;
        label_60:
        val_91 = 0;
        val_76 = 0;
        label_82:
        val_92 = val_24.x;
        val_93 = val_24.y;
        if(this.nextPageThreshold <= 0f)
        {
            goto label_121;
        }
        
        val_75 = 1152921505096622080;
        val_94 = null;
        val_94 = null;
        if((UICamera.currentTouch == null) || (this.世丑丁丛万丌丈丂丒 == 0))
        {
            goto label_121;
        }
        
        val_90 = val_76;
        if(val_87 != 0)
        {
                UnityEngine.Transform val_49 = val_87.Item[0];
        }
        
        if(this.世丑丁丛万丌丈丂丒.transform != (val_20.GetChild(index:  0)))
        {
            goto label_96;
        }
        
        val_96 = null;
        val_96 = null;
        UnityEngine.Vector3 val_52 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = UICamera.currentTouch.东丞不不丙丁丄下且, y = UICamera.currentTouch + 44 + 4});
        UnityEngine.Quaternion val_54 = this.transform.rotation;
        val_88 = val_52.z;
        val_86 = val_54.y;
        UnityEngine.Vector3 val_55 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_54.x, y = val_86, z = val_54.z, w = val_54.w}, point:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_88});
        val_75 = this.丛且世三丆丝丞丗丈;
        val_76 = val_90;
        val_92 = val_24.x;
        val_93 = val_24.y;
        if(this.丛且世三丆丝丞丗丈.movement == 1)
        {
            goto label_106;
        }
        
        if(this.丛且世三丆丝丞丗丈.movement != 0)
        {
            goto label_107;
        }
        
        val_97 = val_55.x;
        goto label_110;
        label_96:
        val_76 = val_90;
        goto label_121;
        label_106:
        val_97 = val_55.y;
        goto label_110;
        label_107:
        val_97 = val_55.x;
        label_110:
        if(System.Math.Abs(val_97) <= this.nextPageThreshold)
        {
            goto label_121;
        }
        
        if(val_97 <= this.nextPageThreshold)
        {
            goto label_114;
        }
        
        if(val_87 == 0)
        {
            goto label_115;
        }
        
        val_98 = val_91 - 1;
        if(val_97 >= this.nextPageThreshold)
        {
            goto label_135;
        }
        
        if((this.GetComponent<UIWrapContent>()) == 0)
        {
            goto label_134;
        }
        
        val_99 = public System.Int32 System.Collections.Generic.List<UnityEngine.Transform>::get_Count();
        goto label_120;
        label_114:
        if(val_97 >= 0)
        {
            goto label_121;
        }
        
        if(val_87 == 0)
        {
            goto label_122;
        }
        
        val_75 = 1152921519067102480;
        if(val_91 >= (val_87.Count - 1))
        {
            goto label_123;
        }
        
        val_100 = 1152921519067103504;
        val_98 = val_91 + 1;
        goto label_124;
        label_115:
        val_75 = val_91 - 1;
        if(val_97 < this.nextPageThreshold)
        {
            goto label_125;
        }
        
        val_101 = val_75;
        goto label_127;
        label_122:
        if(val_91 >= (val_20.childCount - 1))
        {
            goto label_129;
        }
        
        val_101 = val_91 + 1;
        goto label_141;
        label_123:
        if((this.GetComponent<UIWrapContent>()) != 0)
        {
            goto label_134;
        }
        
        val_99 = public System.Int32 System.Collections.Generic.List<UnityEngine.Transform>::get_Count();
        label_120:
        val_98 = val_87.Count - 1;
        goto label_135;
        label_134:
        val_98 = 0;
        label_135:
        val_100 = 1152921519067103504;
        label_124:
        UnityEngine.Transform val_65 = val_87.Item[0];
        goto label_136;
        label_125:
        val_75 = UnityEngine.Object.op_Equality(x:  this.GetComponent<UIWrapContent>(), y:  0);
        if(val_75 == false)
        {
            goto label_140;
        }
        
        label_145:
        val_101 = 0;
        goto label_141;
        label_129:
        if((this.GetComponent<UIWrapContent>()) != 0)
        {
            goto label_145;
        }
        
        label_140:
        val_75 = val_20.childCount;
        val_101 = val_75 - 1;
        label_141:
        label_127:
        label_136:
        val_76 = val_20.GetChild(index:  val_101);
        label_121:
        this.丑下下丂业丑东丝丒(丞下万上三丘上与专:  val_76, 丁丈丏下丅业且丗东:  new UnityEngine.Vector3() {x = val_92, y = val_93, z = val_24.z});
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
        label_28:
        if(this.onCenter == null)
        {
                return;
        }
        
        this.onCenter.Invoke(下且专丒下丙丈丈丒:  this.世丑丁丛万丌丈丂丒);
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
        goto label_28;
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
    private void 三丏丏丘丏丈丘东丁(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Vector3 丁丈丏下丅业且丗东)
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
        label_36:
        if(this.onCenter == null)
        {
                return;
        }
        
        this.onCenter.Invoke(下且专丒下丙丈丈丒:  this.世丑丁丛万丌丈丂丒);
        return;
        label_13:
        this.世丑丁丛万丌丈丂丒 = 0.gameObject;
        label_14:
        UnityEngine.Vector3 val_9 = 丞下万上三丘上与专.position;
        UnityEngine.Vector3 val_10 = val_6.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_11 = val_6.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 丁丈丏下丅业且丗东.x, y = 丁丈丏下丅业且丗东.y, z = 丁丈丏下丅业且丗东.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        float val_14 = (this.丛且世三丆丝丞丗丈.canMoveHorizontally != true) ? val_12.x : 0f;
        float val_16 = (this.丛且世三丆丝丞丗丈.canMoveVertically != true) ? val_12.y : 0f;
        UnityEngine.Vector3 val_17 = val_6.localPosition;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_14, y = val_16, z = 0f});
        val_6.localPosition = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
        UnityEngine.Vector2 val_20 = this.丛且世三丆丝丞丗丈.panel.clipOffset;
        UnityEngine.Vector4 val_21 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
        UnityEngine.Vector2 val_25 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_14 + val_21.x, y = val_16 + val_21.y, z = val_21.z, w = val_21.w});
        this.丛且世三丆丝丞丗丈.panel.clipOffset = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        UnityEngine.Vector3 val_28 = val_6.localPosition;
        SpringPanel val_29 = SpringPanel.Begin(丝三丁东丈丒世丅业:  this.丛且世三丆丝丞丗丈.panel.cachedGameObject, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, 丛上丟丌丄丗丁世与:  this.springStrength);
        val_29.onFinished = this.onFinished;
        goto label_36;
    }
    public void CenterOnInstant(UnityEngine.Transform 丞下万上三丘上与专)
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
        this.三丏丏丘丏丈丘东丁(丞下万上三丘上与专:  丞下万上三丘上与专, 丁丈丏下丅业且丗东:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
    }
    public UICenterOnChild()
    {
        this.springStrength = 8f;
    }

}
