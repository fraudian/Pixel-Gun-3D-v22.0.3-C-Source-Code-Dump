using UnityEngine;
public class NewCenterOnChild : MonoBehaviour
{
    // Fields
    private System.Action 且丛业七丈丐丞世丞;
    public bool excludeInactive;
    private UnityEngine.GameObject mCenteredObject;
    private UIScrollView 丛且世三丆丝丞丗丈;
    public float nextPageThreshold;
    public SpringPanel.上丄丂丛专下丟万下 onFinished;
    public float springStrength;
    
    // Properties
    internal UnityEngine.GameObject 上不三丝丏且丐丛与 { get; }
    public UnityEngine.GameObject 下且专丒下丙丈丈丒 { get; }
    
    // Methods
    internal void 丞东丘丐丈丗丄丕世(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.且丛业七丈丐丞世丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丛业七丈丐丞世丞 != 1152921538548786056);
    
    }
    internal void 专丆丈业丒世不丞三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.且丛业七丈丐丞世丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.且丛业七丈丐丞世丞 != 1152921538548922632);
    
    }
    internal UnityEngine.GameObject 一丑丕丄丐专丛丗丘()
    {
        return (UnityEngine.GameObject)this.mCenteredObject;
    }
    public UnityEngine.GameObject get_centeredObject()
    {
        return (UnityEngine.GameObject)this.mCenteredObject;
    }
    private void OnEnable()
    {
        this.Recenter();
    }
    private void OnPress(bool 万东丂丒且丅丛丑丕)
    {
        if(万东丂丒且丅丛丑丕 != false)
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
        IntPtr val_36;
        float val_41;
        float val_42;
        UnityEngine.GameObject val_43;
        var val_44;
        var val_45;
        float val_46;
        var val_47;
        float val_48;
        var val_49;
        var val_50;
        int val_51;
        if(this.丛且世三丆丝丞丗丈 == 0)
        {
                UIScrollView val_3 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIScrollView>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丛且世三丆丝丞丗丈 = val_3;
            if(val_3 == 0)
        {
                val_36 = null;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "{0} requires {1} on a parent object in order to work", arg0:  this.GetType(), arg1:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_36})), context:  this);
            this.enabled = false;
            return;
        }
        
            val_36 = this.丛且世三丆丝丞丗丈;
            this.丛且世三丆丝丞丗丈.七丐专与丗与不丂与 = new System.Action<System.Boolean>(object:  this, method:  System.Void NewCenterOnChild::OnPress(bool 万东丂丒且丅丛丑丕));
        }
        
        if(this.丛且世三丆丝丞丗丈.panel == 0)
        {
                return;
        }
        
        UIPanel val_11 = this.丛且世三丆丝丞丗丈.panel;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, d:  0.5f);
        UnityEngine.Vector3 val_14 = this.丛且世三丆丝丞丗丈.currentMomentum;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.丛且世三丆丝丞丗丈.momentumAmount * 0.1f);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        val_41 = val_18.x;
        val_42 = val_18.z;
        this.丛且世三丆丝丞丗丈.currentMomentum = new UnityEngine.Vector3() {x = val_41, y = val_18.y, z = val_42};
        System.Collections.Generic.List<UnityEngine.Transform> val_20 = this.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform);
        val_43 = val_20.Count;
        if(val_43 >= 1)
        {
                var val_36 = 0;
            do
        {
            val_44 = val_20.Item[0];
            UnityEngine.Vector3 val_23 = val_44.position;
            val_41 = val_23.x;
            val_42 = val_23.z;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_41, y = val_23.y, z = val_42}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            float val_25 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            var val_26 = (val_25 < 0) ? (val_36) : 0;
            val_36 = val_36 + 1;
            var val_27 = (val_25 < 0) ? (val_44) : 0;
            var val_28 = (val_25 < 0) ? (val_25) : 3.402823E+38f;
        }
        while(val_43 != val_36);
        
        }
        else
        {
                val_45 = 0;
            val_36 = 0;
        }
        
        val_46 = this.nextPageThreshold;
        if(val_46 <= 0f)
        {
            goto label_37;
        }
        
        val_47 = null;
        val_48 = val_13.z;
        goto label_41;
        label_37:
        val_48 = val_13.z;
        goto label_65;
        label_41:
        if(UICamera.currentTouch == null)
        {
            goto label_65;
        }
        
        val_43 = this.mCenteredObject;
        if(val_43 == 0)
        {
            goto label_65;
        }
        
        val_43 = this.mCenteredObject.transform;
        val_44 = 1152921519067103504;
        if(val_43 != val_20.Item[0])
        {
            goto label_65;
        }
        
        val_49 = null;
        val_49 = null;
        val_43 = mem[UICamera.currentTouch + 44 + 4];
        val_43 = UICamera.currentTouch + 44 + 4;
        if(this.丛且世三丆丝丞丗丈.movement == 0)
        {
            goto label_55;
        }
        
        if(this.丛且世三丆丝丞丗丈.movement != 1)
        {
            goto label_56;
        }
        
        val_46 = val_43;
        goto label_58;
        label_55:
        val_46 = 3.263296E-30f;
        goto label_58;
        label_56:
        label_58:
        if(val_46 <= this.nextPageThreshold)
        {
            goto label_59;
        }
        
        val_45 = val_45 - 1;
        if(val_46 < this.nextPageThreshold)
        {
            goto label_65;
        }
        
        val_50 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
        val_51 = val_45;
        goto label_62;
        label_59:
        if((val_46 >= 0) || (val_45 >= (val_20.Count - 1)))
        {
            goto label_65;
        }
        
        val_50 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
        val_51 = val_45 + 1;
        label_62:
        val_36 = val_20.Item[val_51];
        label_65:
        this.丑下下丂业丑东丝丒(丞下万上三丘上与专:  val_36, 丁丈丏下丅业且丗东:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y});
    }
    public void Slide()
    {
        var val_1;
        丞上且下专丞东专世 val_2;
        float val_3;
        val_1 = null;
        val_1 = null;
        val_2 = UICamera.currentTouch;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = UICamera.currentTouch;
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if(this.丛且世三丆丝丞丗丈.movement == 0)
        {
            goto label_8;
        }
        
        if(this.丛且世三丆丝丞丗丈.movement != 1)
        {
            goto label_9;
        }
        
        val_3 = UICamera.currentTouch + 44 + 4;
        goto label_11;
        label_8:
        val_3 = 3.263296E-30f;
        goto label_11;
        label_9:
        val_3 = V0.16B;
        label_11:
        if(System.Math.Abs(val_3) <= this.nextPageThreshold)
        {
            goto label_14;
        }
        
        if(val_3 <= 0f)
        {
            goto label_15;
        }
        
        this.Prev();
        return;
        label_14:
        this.Curr();
        return;
        label_15:
        this.Next();
        return;
        label_6:
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
        
        this.mCenteredObject = 丞下万上三丘上与专.gameObject;
        goto label_14;
        label_10:
        this.mCenteredObject = 0;
        label_28:
        if(this.且丛业七丈丐丞世丞 == null)
        {
                return;
        }
        
        this.且丛业七丈丐丞世丞.Invoke();
        return;
        label_13:
        this.mCenteredObject = 0.gameObject;
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
    public void Next()
    {
        int val_10;
        var val_11;
        if(this.mCenteredObject == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = this.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform);
        UnityEngine.Transform val_4 = this.mCenteredObject.transform;
        if(val_3 != null)
        {
                val_10 = val_3.LastIndexOf(item:  val_4);
            val_11 = val_3;
        }
        else
        {
                val_10 = 0.LastIndexOf(item:  val_4);
            val_11 = 0;
        }
        
        if(val_11.Count < 1)
        {
                return;
        }
        
        val_10 = val_10 + 1;
        if(val_10 >= val_11.Count)
        {
                return;
        }
        
        this.CenterOn(丞下万上三丘上与专:  val_11.Item[val_10]);
    }
    public void Prev()
    {
        int val_9;
        var val_10;
        if(this.mCenteredObject == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Transform> val_3 = this.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform);
        UnityEngine.Transform val_4 = this.mCenteredObject.transform;
        if(val_3 != null)
        {
                val_9 = val_3.LastIndexOf(item:  val_4);
            val_10 = val_3;
        }
        else
        {
                val_9 = 0.LastIndexOf(item:  val_4);
            val_10 = 0;
        }
        
        if(val_10.Count < 1)
        {
                return;
        }
        
        val_9 = val_9 - 1;
        if((val_9 & 2147483648) != 0)
        {
                return;
        }
        
        this.CenterOn(丞下万上三丘上与专:  val_10.Item[val_9]);
    }
    public void Curr()
    {
        if(this.mCenteredObject == 0)
        {
                return;
        }
        
        this.CenterOn(丞下万上三丘上与专:  this.mCenteredObject.transform);
    }
    private System.Collections.Generic.List<UnityEngine.Transform> 专丏三丘丟丑与业丗(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        bool val_8;
        var val_9;
        val_8 = this.excludeInactive;
        System.Collections.Generic.List<UnityEngine.Transform> val_2 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  (val_8 == true) ? 1 : 0);
        if(this.excludeInactive == false)
        {
                return val_2;
        }
        
        val_9 = 0;
        goto label_4;
        label_14:
        val_8 = val_2.Item[0].GetComponent<UIWidget>();
        if(val_8 != 0)
        {
                if(val_8.enabled != true)
        {
                val_2.RemoveAt(index:  0);
        }
        
        }
        
        val_9 = 1;
        label_4:
        if(val_9 < val_2.Count)
        {
            goto label_14;
        }
        
        return val_2;
    }
    public NewCenterOnChild()
    {
        this.springStrength = 8f;
    }

}
