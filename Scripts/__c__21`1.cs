using UnityEngine;
[Serializable]
private sealed class SquareFieldTouch.<>c__21<T>
{
    // Fields
    public static readonly SquareFieldTouch.<>c__21<T> <>9;
    public static System.Func<UnityEngine.RaycastHit, float> <>9__21_0;
    
    // Methods
    private static SquareFieldTouch.<>c__21<T>()
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
    public SquareFieldTouch.<>c__21<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    internal float 丝丟三丒丏丒丆丏业(UnityEngine.RaycastHit 一丗世三专三万丞丞)
    {
        return 一丗世三专三万丞丞.m_Point.x.targetValue;
    }

}
