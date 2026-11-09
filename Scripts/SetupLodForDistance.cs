using UnityEngine;
public class SetupLodForDistance : MonoBehaviour
{
    // Fields
    public UnityEngine.LODGroup[] Lod;
    public float defaultFov;
    public float[] distanceLevels;
    private float[] 丗丈丌丂三丙东丕且;
    
    // Methods
    private void 丞丙东丌一三专丏不()
    {
        var val_13;
        var val_14;
        System.Single[] val_15;
        float val_16;
        System.Single[] val_17;
        int val_18;
        val_13 = 0;
        goto label_1;
        label_41:
        UnityEngine.LODGroup val_13 = this.Lod[0];
        if((val_13 == 0) || (val_13.lodCount == 0))
        {
            goto label_23;
        }
        
        val_14 = 0;
        this.丗丈丌丂三丙东丕且 = new float[0];
        goto label_9;
        label_15:
        val_15 = this.distanceLevels;
        val_16 = this.世丛丏专业世丒丂丂(丌七丒世丄上丞丞丁:  val_15[0], 丟丒且一专丟丙下一:  (this.丗万丌七七三丒丑一(丘丑与丛丐丑与丗丞:  val_13)) * UnityEngine.QualitySettings.lodBias);
        val_14 = 1;
        this.丗丈丌丂三丙东丕且[0] = val_16;
        label_9:
        if(val_14 < this.distanceLevels.Length)
        {
            goto label_15;
        }
        
        UnityEngine.LOD[] val_8 = val_13.GetLODs();
        val_17 = this.distanceLevels;
        val_18 = val_8.Length;
        if(val_18 <= this.distanceLevels.Length)
        {
            goto label_19;
        }
        
        UnityEngine.Debug.LogError(message:  val_13.name + " have more lod levels than needed");
        goto label_23;
        label_19:
        if(this.distanceLevels == null)
        {
                val_18 = val_8.Length;
        }
        
        if(val_18 < 1)
        {
            goto label_25;
        }
        
        int val_15 = this.distanceLevels.Length;
        var val_16 = 0;
        label_34:
        if(this.丗丈丌丂三丙东丕且 == null)
        {
            goto label_26;
        }
        
        if(val_16 == 0)
        {
            goto label_27;
        }
        
        label_31:
        val_15 = (val_15 - val_18) + val_16;
        val_17 = (long)val_15;
        val_16 = this.丗丈丌丂三丙东丕且[val_17];
        val_15 = 0;
        if(val_16 < val_8.Length)
        {
            goto label_30;
        }
        
        goto label_30;
        label_26:
        if(val_16 != 0)
        {
            goto label_31;
        }
        
        label_27:
        val_16 = this.丗丈丌丂三丙东丕且[0];
        val_15 = 0;
        label_30:
        val_8[val_15] = val_16;
        val_18 = val_8.Length;
        val_16 = val_16 + 1;
        if(val_16 < val_18)
        {
            goto label_34;
        }
        
        label_25:
        if(val_18 == 1)
        {
                var val_17 = -4294967296;
            val_17 = val_17 + ((this.丗丈丌丂三丙东丕且.Length) << 32);
            val_17 = this.丗丈丌丂三丙东丕且[val_17 >> 32];
            val_8[0] = val_17;
        }
        
        val_13.SetLODs(lods:  val_8);
        label_23:
        val_13 = 1;
        label_1:
        if(val_13 < this.Lod.Length)
        {
            goto label_41;
        }
    
    }
    private float 世丛丏专业世丒丂丂(float 丌七丒世丄上丞丞丁, float 丟丒且一专丟丙下一)
    {
        float val_1 = 0.01745329f;
        val_1 = this.defaultFov * val_1;
        val_1 = val_1 * 0.5f;
        丟丒且一专丟丙下一 = 丟丒且一专丟丙下一 * 0.5f;
        val_1 = val_1 * 丌七丒世丄上丞丞丁;
        val_1 = 丟丒且一专丟丙下一 / val_1;
        return (float)val_1;
    }
    private float 丗万丌七七三丒丑一(UnityEngine.LODGroup 丘丑与丛丐丑与丗丞)
    {
        UnityEngine.Transform val_1 = 丘丑与丛丐丑与丗丞.transform;
        float val_3 = 丘丑与丛丐丑与丗丞.size;
        val_3 = (val_1.下上丞丌与丛丆丝业(丙丒七丄上与丏丙丙:  val_1)) * val_3;
        return (float)val_3;
    }
    private float 下上丞丌与丛丆丝业(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        UnityEngine.Vector3 val_1 = 丙丒七丄上与丏丙丙.lossyScale;
        return UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  System.Math.Abs(val_1.x), b:  System.Math.Abs(val_1.y)), b:  System.Math.Abs(val_1.z));
    }
    public SetupLodForDistance()
    {
        this.defaultFov = 65f;
        this.distanceLevels = new float[3] {1.157052E-41f, 4.026911E-41f, 7.183897E-41f};
    }

}
