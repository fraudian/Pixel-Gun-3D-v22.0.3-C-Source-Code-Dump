using UnityEngine;
public class FortCameraAnimator : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera animCamera;
    public float animTime;
    public bool isAnimated;
    public System.Collections.Generic.List<FortCameraAnimator.LookPoint> LookPoints;
    private float 下丗业三丑上丗业专;
    private UnityEngine.Vector3 丆丙丂丈一万与东与;
    private UnityEngine.Quaternion 丟丕丕专丁一丝万丒;
    private UnityEngine.Vector3 丕丒丒丏专丙业且丌;
    private UnityEngine.Quaternion 三丘不丐丈丑七丄丏;
    public UnityEngine.AnimationCurve moveSpeed;
    public UnityEngine.AnimationCurve moveY;
    
    // Methods
    public void OnCenter()
    {
    
    }
    public void GoTo(Rilisoft.FortItemGroupType 与丄不丌一世东丁丙, string 丟下丟丈万一丙东丄 = "")
    {
        if((this.上与下丄专专丂丘七(与丄不丌一世东丁丙:  与丄不丌一世东丁丙, 丟下丟丈万一丙东丄:  丟下丟丈万一丙东丄)) == null)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = this.animCamera.transform.localPosition;
        this.丆丙丂丈一万与东与 = val_3;
        mem[1152921537213690856] = val_3.y;
        mem[1152921537213690860] = val_3.z;
        UnityEngine.Quaternion val_5 = this.animCamera.transform.localRotation;
        this.丟丕丕专丁一丝万丒 = val_5;
        mem[1152921537213690868] = val_5.y;
        mem[1152921537213690872] = val_5.z;
        mem[1152921537213690876] = val_5.w;
        this.丕丒丒丏专丙业且丌 = val_1.pos;
        mem[1152921537213690888] = ???;
        this.下丗业三丑上丗业专 = this.animTime;
        this.三丘不丐丈丑七丄丏 = val_1.rot;
        mem[1152921537213690896] = ???;
        mem[1152921537213690904] = ???;
        this.isAnimated = true;
    }
    private void Update()
    {
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if(this.isAnimated != false)
        {
                this.专三丙丂丏不丑丅且();
            return;
        }
        
        this.animCamera.transform.localPosition = new UnityEngine.Vector3() {x = this.丕丒丒丏专丙业且丌, y = V9.16B, z = V10.16B};
        this.animCamera.transform.localRotation = new UnityEngine.Quaternion() {x = this.三丘不丐丈丑七丄丏, y = V9.16B, z = V10.16B, w = V11.16B};
    }
    private FortCameraAnimator.LookPoint 上与下丄专专丂丘七(Rilisoft.FortItemGroupType 与丄不丌一世东丁丙, string 丟下丟丈万一丙东丄 = "")
    {
        string val_8;
        var val_9;
        var val_10;
        val_8 = 丟下丟丈万一丙东丄;
        val_9 = 0;
        val_10 = 0;
        goto label_1;
        label_11:
        LookPoint val_1 = this.LookPoints.Item[0];
        if(val_1.slot == 与丄不丌一世东丁丙)
        {
                val_10 = this.LookPoints.Item[0];
        }
        
        if((System.String.op_Equality(a:  val_8, b:  System.String.alignConst)) == true)
        {
            goto label_6;
        }
        
        LookPoint val_4 = this.LookPoints.Item[0];
        if((System.String.op_Equality(a:  val_4.overrideItemName, b:  val_8)) == true)
        {
            goto label_9;
        }
        
        label_6:
        val_9 = 1;
        label_1:
        if(val_9 < this.LookPoints.Count)
        {
            goto label_11;
        }
        
        return (LookPoint)val_10;
        label_9:
        val_8 = this.LookPoints;
        val_10 = val_8.Item[0];
        return (LookPoint)val_10;
    }
    private void 专三丙丂丏不丑丅且()
    {
        float val_9 = this.下丗业三丑上丗业专;
        float val_1 = UnityEngine.Time.unscaledDeltaTime;
        val_1 = val_9 - val_1;
        this.下丗业三丑上丗业专 = val_1;
        val_1 = val_1 / this.animTime;
        val_9 = 1f - val_1;
        float val_2 = this.moveSpeed.Evaluate(time:  val_9);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.丆丙丂丈一万与东与, y = V10.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.丕丒丒丏专丙业且丌, y = val_9, z = V11.16B}, t:  val_2);
        float val_4 = this.moveY.Evaluate(time:  val_2);
        float val_5 = UnityEngine.Mathf.Lerp(a:  V11.16B, b:  this.丕丒丒丏专丙业且丌, t:  val_4);
        this.animCamera.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_5, z = val_3.z};
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = this.丟丕丕专丁一丝万丒, y = val_3.z, z = val_4, w = V15.16B}, b:  new UnityEngine.Quaternion() {x = this.三丘不丐丈丑七丄丏, y = this.丕丒丒丏专丙业且丌, z = V13.16B, w = val_5}, t:  val_2);
        this.animCamera.transform.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        if(this.下丗业三丑上丗业专 > 0f)
        {
                return;
        }
        
        this.isAnimated = false;
    }
    public FortCameraAnimator()
    {
        this.animTime = 0.2f;
        this.下丗业三丑上丗业专 = 0.2f;
    }

}
