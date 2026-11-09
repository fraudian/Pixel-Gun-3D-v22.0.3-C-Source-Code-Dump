using UnityEngine;
[Serializable]
private sealed class TapOnTankPointGesture.<>c__2<T>
{
    // Fields
    public static readonly TapOnTankPointGesture.<>c__2<T> <>9;
    public static System.Func<UnityEngine.RaycastHit, float> <>9__2_0;
    
    // Methods
    private static TapOnTankPointGesture.<>c__2<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
        val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        val_2 = __RuntimeMethodHiddenParam + 24;
        if((val_1 & 1) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
            val_1 = mem[__RuntimeMethodHiddenParam + 24 + 294];
            val_1 = __RuntimeMethodHiddenParam + 24 + 294;
        }
        
        mem2[0] = __RuntimeMethodHiddenParam + 24 + 192;
    }
    public TapOnTankPointGesture.<>c__2<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal float 丙丗三专与丕丆不且(UnityEngine.RaycastHit 一丗世三专三万丞丞)
    {
        return 一丗世三专三万丞丞.m_Point.x.targetValue;
    }

}
