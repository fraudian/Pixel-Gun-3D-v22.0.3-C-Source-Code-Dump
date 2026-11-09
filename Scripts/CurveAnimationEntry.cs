using UnityEngine;
[Serializable]
public class CurveAnimationEntry
{
    // Fields
    public CurveAnimationEntry.丈且且丞与丄丄丏丗 entryType;
    public CurveAnimationEntry.丗丐丒一丙丕丑三上 entryAxis;
    public float curveDelay;
    public UnityEngine.AnimationCurve curve;
    private float _curveTime;
    
    // Properties
    public float curveTime { get; }
    
    // Methods
    public float get_curveTime()
    {
        if(this._curveTime != (-1f))
        {
                return val_4;
        }
        
        UnityEngine.Keyframe[] val_1 = this.curve.keys;
        if(this.curve.keys == null)
        {
            goto label_3;
        }
        
        label_7:
        int val_5 = val_2.Length;
        val_5 = val_5 - 1;
        var val_6 = 28;
        val_6 = val_1 + ((long)val_5 * val_6);
        float val_4 = val_6 + 32.System.IConvertible.ToSingle(provider:  0);
        this._curveTime = val_4;
        return val_4;
        label_3:
        if(val_1 != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    public CurveAnimationEntry()
    {
        this._curveTime = -1f;
    }

}
