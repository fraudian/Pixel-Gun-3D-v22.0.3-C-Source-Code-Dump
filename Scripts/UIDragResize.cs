using UnityEngine;
public class UIDragResize : MonoBehaviour
{
    // Fields
    public UIWidget target;
    public UIWidget.七丐与七丌不丂丞且 pivot;
    public int minWidth;
    public int minHeight;
    public int maxWidth;
    public int maxHeight;
    public bool updateAnchors;
    private UnityEngine.Plane 丑丞丗专丁丕丂丁丅;
    private UnityEngine.Vector3 不不下世丞三丆丑丞;
    private UnityEngine.Vector3 丟丁丘丏七丒丁三万;
    private int 业丆世丄丏丕丕七不;
    private int 丙万且丝丐世下世且;
    private bool 上丁东丕丁丙业丛丞;
    
    // Methods
    private void OnDragStart()
    {
        var val_4;
        if(this.target == 0)
        {
                return;
        }
        
        this.丑丞丗专丁丕丂丁丅 = 0;
        mem[1152921531089165356] = 0;
        mem[1152921531089165364] = 0;
        UnityEngine.Ray val_2 = UICamera.currentRay;
        if((this.丑丞丗专丁丕丂丁丅 & 1) == 0)
        {
                return;
        }
        
        this.不不下世丞三丆丑丞 = 0;
        mem[1152921531089165372] = val_4;
        mem[1152921531089165376] = V10.16B;
        UnityEngine.Vector3 val_6 = this.target.cachedTransform.localPosition;
        this.丟丁丘丏七丒丁三万 = val_6;
        mem[1152921531089165384] = val_6.y;
        mem[1152921531089165388] = val_6.z;
        this.业丆世丄丏丕丕七不 = this.target.width;
        this.丙万且丝丐世下世且 = this.target.height;
        this.上丁东丕丁丙业丛丞 = true;
    }
    private void OnDrag(UnityEngine.Vector2 delta)
    {
        UIWidget val_15;
        float val_16;
        float val_17;
        float val_18;
        val_15 = this;
        if(this.上丁东丕丁丙业丛丞 == false)
        {
                return;
        }
        
        if(this.target == 0)
        {
                return;
        }
        
        UnityEngine.Ray val_2 = UICamera.currentRay;
        if((this.丑丞丗专丁丕丂丁丅 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_5 = this.target.cachedTransform;
        val_5.localPosition = new UnityEngine.Vector3() {x = this.丟丁丘丏七丒丁三万, y = V9.16B, z = V10.16B};
        this.target.width = this.业丆世丄丏丕丕七不;
        this.target.height = this.丙万且丝丐世下世且;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = this.不不下世丞三丆丑丞, y = V11.16B, z = V10.16B});
        UnityEngine.Vector3 val_7 = val_5.position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if(val_5 != null)
        {
                val_16 = val_8.x;
            val_17 = val_8.y;
            val_18 = val_8.z;
            val_5.position = new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18};
        }
        else
        {
                val_16 = val_8.x;
            val_17 = val_8.y;
            val_18 = val_8.z;
            0.position = new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18};
        }
        
        UnityEngine.Quaternion val_9 = val_5.localRotation;
        UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
        UnityEngine.Vector3 val_11 = val_5.localPosition;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = this.丟丁丘丏七丒丁三万, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, point:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_5.localPosition = new UnityEngine.Vector3() {x = this.丟丁丘丏七丒丁三万, y = val_10.w, z = this.不不下世丞三丆丑丞};
        万丗丅且丄丑世专与.丈丂丄一丂世丘且一(与丘东下丈东丛丂万:  this.target, 不丌丕不七丗丞万万:  this.pivot, 三丟东丕丄丄下下丑:  val_13.x, 丒丒丄丁且丄丆丂丌:  val_13.y, 上专上丛丈丆丗丒丟:  this.minWidth, 丐丆丏丂上丒丗丌丁:  this.minHeight, 七丏丄丄丆与丁丂丈:  this.maxWidth, 丄七丗丌丂一丞丆下:  this.maxHeight);
        if(this.updateAnchors == false)
        {
                return;
        }
        
        val_15 = this.target;
        val_15.BroadcastMessage(methodName:  "UpdateAnchors");
    }
    private void OnDragEnd()
    {
        this.上丁东丕丁丙业丛丞 = false;
    }
    public UIDragResize()
    {
        this.pivot = ;
        this.maxHeight = 100000;
    }

}
