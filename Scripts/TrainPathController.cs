using UnityEngine;
public class TrainPathController : MonoBehaviour
{
    // Fields
    public TramPath startPath;
    public System.Collections.Generic.List<TramPath> allPath;
    public System.Collections.Generic.List<TramPath> checkpoints;
    private float 下且东三丂丈七万万;
    
    // Methods
    private void Awake()
    {
        TramPath val_15;
        TramPath val_16;
        val_15 = 1152921504691564544;
        this.allPath = new System.Collections.Generic.List<TramPath>();
        this.checkpoints = new System.Collections.Generic.List<TramPath>();
        val_16 = this.startPath;
        goto label_29;
        label_32:
        this.startPath.distance = 0f;
        this.startPath.myIndex = this.allPath.Count;
        this.startPath.distancePoint = this.下且东三丂丈七万万;
        if(this.startPath.next != 0)
        {
                UnityEngine.Vector3 val_6 = this.startPath.next.transform.position;
            UnityEngine.Vector3 val_8 = val_16.transform.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            this.startPath.distance = val_9.x;
            val_9.x = val_9.x + this.下且东三丂丈七万万;
            this.下且东三丂丈七万万 = val_9.x;
        }
        
        val_15 = this.startPath.next;
        if(val_15 != this.startPath)
        {
                val_15 = this.allPath;
            val_15.Add(item:  val_16);
            val_16 = this.startPath.next;
        }
        else
        {
                val_16 = 0;
        }
        
        if(val_16 == 0)
        {
            goto label_29;
        }
        
        if(0 != 0)
        {
            goto label_21;
        }
        
        val_15 = 64;
        if(val_15 != 0)
        {
            goto label_29;
        }
        
        label_21:
        this.checkpoints.Add(item:  val_16);
        val_15 = 64;
        if((val_15 == 0) && (0 != 0))
        {
                mem[100] = 0;
        }
        
        label_29:
        if(val_16 != 0)
        {
            goto label_32;
        }
    
    }
    public void Reset()
    {
        goto label_1;
        label_5:
        TramPath val_1 = this.checkpoints.Item[0];
        0 = 1;
        val_1.wasReached = false;
        label_1:
        if(0 < this.checkpoints.Count)
        {
            goto label_5;
        }
    
    }
    public TramPath GetPathByIndex(int 丞世不丒下上上丝丑)
    {
        System.Collections.Generic.List<TramPath> val_4;
        var val_5;
        val_4 = this.allPath;
        if(val_4.Count > 丞世不丒下上上丝丑)
        {
                val_4 = this.allPath;
            if((val_4.Count & 2147483648) == 0)
        {
                TramPath val_3 = this.allPath.Item[丞世不丒下上上丝丑];
            return (TramPath)val_5;
        }
        
        }
        
        val_5 = 0;
        return (TramPath)val_5;
    }
    public 一上丕丞丙一丈七丛 GetCheckpointsProgressFor(float 丛一与丝丝丟上不丛)
    {
        int val_9;
        int val_10;
        var val_11;
        float val_9 = 丛一与丝丝丟上不丛;
        val_9 = 1152921537525660048;
        val_10 = (int)val_9;
        val_11 = 0;
        val_9 = val_9 - (float)val_10;
        goto label_1;
        label_6:
        TramPath val_1 = this.checkpoints.Item[0];
        if(val_1.myIndex > val_10)
        {
            goto label_4;
        }
        
        val_11 = 1;
        label_1:
        if(val_11 < this.checkpoints.Count)
        {
            goto label_6;
        }
        
        this.不上丑丗业与丂丕丗(丞世不丒下上上丝丑:  0);
        goto label_8;
        label_4:
        this.不上丑丗业与丂丕丗(丞世不丒下上上丝丑:  0);
        if(val_11 == 1)
        {
            goto label_8;
        }
        
        val_10 = this.GetPathByIndex(丞世不丒下上上丝丑:  val_10);
        TramPath val_4 = this.checkpoints.Item[0];
        val_9 = UnityEngine.Mathf.Max(a:  0, b:  -1);
        TramPath val_6 = this.checkpoints.Item[val_9];
        float val_10 = val_4.distancePoint;
        val_10 = val_10 - val_6.distancePoint;
        float val_12 = val_3.distancePoint;
        if(val_10 != 0f)
        {
            goto label_16;
        }
        
        float val_11 = val_3.distance;
        val_11 = val_9 * val_11;
        val_12 = val_12 + val_11;
        val_12 = val_12 / val_4.distancePoint;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
        label_8:
        int val_8 = this.checkpoints.Count - 1;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
        label_16:
        float val_14 = val_6.distancePoint;
        float val_13 = val_3.distance;
        val_12 = val_12 - val_14;
        val_13 = val_9 * val_13;
        val_12 = val_12 + val_13;
        val_14 = val_4.distancePoint - val_14;
        val_12 = val_12 / val_14;
        return new 一上丕丞丙一丈七丛() {上丕丈丞丌丘丅不与 = 0f};
    }
    public float GetDistanceProgressFor(float 上丕丈丞丌丘丅不与)
    {
        float val_3;
        float val_4;
        val_3 = 上丕丈丞丌丘丅不与;
        TramPath val_1 = this.GetPathByIndex(丞世不丒下上上丝丑:  (int)val_3);
        if(val_1 == 0)
        {
                return (float)val_3;
        }
        
        val_3 = val_3 - (float)(int)val_3;
        if(val_1 != null)
        {
                val_4 = val_1.distancePoint;
        }
        else
        {
                val_4 = 1.643967E-34f;
        }
        
        float val_3 = val_1.distance;
        val_3 = val_3 * val_3;
        val_3 = val_4 + val_3;
        return (float)val_3;
    }
    private void 不上丑丗业与丂丕丗(int 丞世不丒下上上丝丑)
    {
        goto label_1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  X22.Item[0], 丏业丟一东丂东丘丛:  false);
        0 = 1;
        label_1:
        if(0 < this.checkpoints.Count)
        {
            goto label_6;
        }
        
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return;
        }
        
        if(this.checkpoints.Count <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.checkpoints.Item[丞世不丒下上上丝丑], 丏业丟一东丂东丘丛:  true);
    }
    public TrainPathController()
    {
    
    }

}
