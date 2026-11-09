using UnityEngine;
public class RilisoftRotator : MonoBehaviour
{
    // Fields
    public float rate;
    private UnityEngine.Transform 上丛丂三上与丂丕丑;
    
    // Properties
    internal static float 丕丁丝上丙丒丁七与 { get; }
    
    // Methods
    internal static void 丒丌丄丛丟丏丒世丄(UnityEngine.Transform 世丟丈丏丕万丝丆万, float 丄七丛丝丏丈丒丝业, UnityEngine.Rect 丕丏丘七丗丘万丟丛, ref float 丑丗丘丞丗丌三丈丆, ref float 三丕丂且一丝丈三一, System.Func<bool> 丝丛业丑专业一丁上)
    {
        float val_20;
        float val_21;
        float val_22;
        val_20 = 丄七丛丝丏丈丒丝业;
        if(丝丛业丑专业一丁上 != null)
        {
                if(丝丛业丑专业一丁上.Invoke() == false)
        {
            goto label_13;
        }
        
        }
        
        if(世丟丈丏丕万丝丆万.gameObject.activeInHierarchy != false)
        {
                if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
            if((专三三与三且一且一() == 1) && ((1422716128 & 1) != 0))
        {
                丑丗丘丞丗丌三丈丆 = UnityEngine.Time.realtimeSinceStartup;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            val_21 = val_8.y;
            UnityEngine.Vector2 val_9 = position;
            float val_11 = val_9.x * val_20;
            val_11 = val_11 * 0.5f;
            val_22 = val_8.x;
            世丟丈丏丕万丝丆万.Rotate(axis:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_8.z}, angle:  val_11 * (UnityEngine.Time.realtimeSinceStartup - 三丕丂且一丝丈三一));
        }
        
        }
        
            if(UnityEngine.Application.isEditor != false)
        {
                float val_20 = 10f;
            val_20 = (UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel")) * val_20;
            val_20 = val_20 * val_20;
            val_22 = UnityEngine.Time.realtimeSinceStartup - 三丕丂且一丝丈三一;
            val_20 = val_20 * val_22;
            if(val_20 != 0f)
        {
                丑丗丘丞丗丌三丈丆 = UnityEngine.Time.realtimeSinceStartup;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.up;
            val_21 = val_18.y;
            val_22 = val_18.x;
            世丟丈丏丕万丝丆万.Rotate(axis:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_18.z}, angle:  val_20);
        }
        
        }
        
        }
        
        label_13:
        三丕丂且一丝丈三一 = UnityEngine.Time.realtimeSinceStartup;
    }
    internal static float 丕不一不三丌万丁丘(UnityEngine.Transform 世丟丈丏丕万丝丆万, float 丄七丛丝丏丈丒丝业, UnityEngine.Rect 丕丏丘七丗丘万丟丛, ref float 丑丗丘丞丗丌三丈丆, ref float 三丕丂且一丝丈三一, System.Func<bool> 丝丛业丑专业一丁上, UnityEngine.Vector3 丑丆丘业不丐丌丅下, UnityEngine.Vector3 丛丄丄丏丅东丙专丏)
    {
        float val_4;
        float val_17;
        float val_18;
        if(丝丛业丑专业一丁上 == null)
        {
            goto label_1;
        }
        
        val_17 = 0f;
        if(丝丛业丑专业一丁上.Invoke() == false)
        {
            goto label_11;
        }
        
        label_1:
        val_17 = 0f;
        if(世丟丈丏丕万丝丆万.gameObject.activeInHierarchy != false)
        {
                val_17 = 0f;
            if(UnityEngine.Input.touchCount >= 1)
        {
                UnityEngine.Touch val_6 = UnityEngine.Input.GetTouch(index:  0);
            if((专三三与三且一且一() == 1) && ((1422893792 & 1) != 0))
        {
                丑丗丘丞丗丌三丈丆 = UnityEngine.Time.realtimeSinceStartup;
            UnityEngine.Vector2 val_9 = position;
            float val_10 = UnityEngine.Time.realtimeSinceStartup;
            float val_11 = val_9.x * 丄七丛丝丏丈丒丝业;
            val_11 = val_11 * 0.5f;
            val_10 = val_10 - 三丕丂且一丝丈三一;
            val_17 = val_11 * val_10;
            val_18 = 丑丆丘业不丐丌丅下.x;
            世丟丈丏丕万丝丆万.RotateAround(point:  new UnityEngine.Vector3() {x = val_18, y = 丑丆丘业不丐丌丅下.y, z = 丑丆丘业不丐丌丅下.z}, axis:  new UnityEngine.Vector3() {x = 丛丄丄丏丅东丙专丏.x, y = val_4, z = 丛丄丄丏丅东丙专丏.y}, angle:  val_17);
        }
        
        }
        
            if(UnityEngine.Application.isEditor != false)
        {
                float val_17 = 10f;
            val_17 = (UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel")) * val_17;
            val_17 = val_17 * 丄七丛丝丏丈丒丝业;
            val_18 = UnityEngine.Time.realtimeSinceStartup - 三丕丂且一丝丈三一;
            val_17 = val_17 * val_18;
            if(val_17 != 0f)
        {
                丑丗丘丞丗丌三丈丆 = UnityEngine.Time.realtimeSinceStartup;
            val_18 = 丑丆丘业不丐丌丅下.x;
            世丟丈丏丕万丝丆万.RotateAround(point:  new UnityEngine.Vector3() {x = val_18, y = 丑丆丘业不丐丌丅下.y, z = 丑丆丘业不丐丌丅下.z}, axis:  new UnityEngine.Vector3() {x = 丛丄丄丏丅东丙专丏.x, y = val_4, z = 丛丄丄丏丅东丙专丏.y}, angle:  val_17);
        }
        
        }
        
        }
        
        label_11:
        三丕丂且一丝丈三一 = UnityEngine.Time.realtimeSinceStartup;
        return val_17;
    }
    internal static float 丙丂专一丄丞丛业上()
    {
        var val_2 = (Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11) ? 1 : 0;
        return (float)106018496 + val_1 == 0xB ? 1 : 0;
    }
    private void Start()
    {
        this.上丛丂三上与丂丕丑 = this.transform;
    }
    private void Update()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
        this.上丛丂三上与丂丕丑.Rotate(axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, angle:  this.rate * UnityEngine.Time.deltaTime, relativeTo:  1);
    }
    public RilisoftRotator()
    {
        this.rate = 10f;
    }

}
