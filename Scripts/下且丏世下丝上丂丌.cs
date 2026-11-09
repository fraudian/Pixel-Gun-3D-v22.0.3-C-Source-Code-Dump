using UnityEngine;
internal static class 下且丏世下丝上丂丌
{
    // Methods
    internal static float 丙下丑东专丘不专不(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东)
    {
        float val_3 = 0.01745329f;
        val_3 = 一不丅与丟丌丏丟东 * val_3;
        UnityEngine.Vector3 val_1 = UnityEngine.Physics.gravity;
        float val_4 = System.Math.Abs(val_1.y);
        float val_2 = 丛上丟丌丄丗丁世与 + 丛上丟丌丄丗丁世与;
        val_2 = val_2 * val_3;
        val_4 = val_2 / val_4;
        return (float)val_4;
    }
    internal static float 下且丏丑丘丅世丌丐(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东)
    {
        float val_4 = 一不丅与丟丌丏丟东;
        val_4 = val_4 * 0.01745329f;
        UnityEngine.Vector3 val_2 = UnityEngine.Physics.gravity;
        float val_5 = System.Math.Abs(val_2.y);
        float val_3 = (丛上丟丌丄丗丁世与 * 丛上丟丌丄丗丁世与) + (丛上丟丌丄丗丁世与 * 丛上丟丌丄丗丁世与);
        val_3 = val_3 * val_4;
        val_3 = val_3 * val_4;
        val_5 = val_3 / val_5;
        return (float)val_5;
    }
    internal static float 与下丌丘丗上丄丞与(float 下丈丌三且三丝丄与, float 一不丅与丟丌丏丟东)
    {
        float val_3 = 一不丅与丟丌丏丟东;
        val_3 = val_3 * 0.01745329f;
        UnityEngine.Vector3 val_1 = UnityEngine.Physics.gravity;
        float val_4 = System.Math.Abs(val_1.y);
        float val_2 = val_3 + val_3;
        val_4 = val_4 * 下丈丌三且三丝丄与;
        val_2 = val_2 * val_3;
        val_4 = val_4 / val_2;
        if(val_2 <= _TYPE_MAX_)
        {
                return val_2;
        }
    
    }
    internal static float 上东上丕一丈丆东与(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东)
    {
        return 下且丏世下丝上丂丌.上东上丕一丈丆东与(丛上丟丌丄丗丁世与:  丛上丟丌丄丗丁世与, 一不丅与丟丌丏丟东:  一不丅与丟丌丏丟东, 丟丌丐丘丆丙丑丑一:  0f);
    }
    internal static float 丟丟东丝丈丞丌下丗(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东, float 下丈丌三且三丝丄与)
    {
        float val_5 = 一不丅与丟丌丏丟东;
        float val_4 = 丛上丟丌丄丗丁世与;
        val_4 = val_4 * val_4;
        val_5 = val_5 * 0.01745329f;
        float val_6 = val_5;
        float val_7 = -2f;
        val_6 = val_6 * val_6;
        val_7 = val_4 * val_7;
        val_4 = val_7 * val_6;
        UnityEngine.Vector3 val_1 = UnityEngine.Physics.gravity;
        float val_8 = System.Math.Abs(val_1.y);
        val_8 = val_8 / val_4;
        val_8 = (下丈丌三且三丝丄与 * 下丈丌三且三丝丄与) * val_8;
        val_8 = (val_5 * 下丈丌三且三丝丄与) + val_8;
        return (float)val_8;
    }
    internal static float 下且丏丑丘丅世丌丐(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东, float 丟丌丐丘丆丙丑丑一)
    {
        float val_9;
        float val_10 = 丟丌丐丘丆丙丑丑一;
        float val_1 = 一不丅与丟丌丏丟东 * 0.01745329f;
        val_1 = val_1 * val_1;
        UnityEngine.Vector3 val_3 = UnityEngine.Physics.gravity;
        float val_9 = System.Math.Abs(val_3.y);
        float val_5 = (丛上丟丌丄丗丁世与 * 丛上丟丌丄丗丁世与) * val_1;
        val_9 = (val_10 + val_10) * val_9;
        val_5 = val_5 + val_9;
        if(val_9 >= _TYPE_MAX_)
        {
                val_9 = val_5;
        }
        
        val_10 = (val_1 * 丛上丟丌丄丗丁世与) + val_9;
        UnityEngine.Vector3 val_7 = UnityEngine.Physics.gravity;
        float val_11 = System.Math.Abs(val_7.y);
        float val_8 = val_1 * 丛上丟丌丄丗丁世与;
        val_8 = val_8 * val_10;
        val_11 = val_8 / val_11;
        return (float)val_11;
    }
    internal static float 上东上丕一丈丆东与(float 丛上丟丌丄丗丁世与, float 一不丅与丟丌丏丟东, float 丟丌丐丘丆丙丑丑一)
    {
        float val_5 = 一不丅与丟丌丏丟东;
        float val_3 = 丛上丟丌丄丗丁世与;
        float val_4 = 0.01745329f;
        val_3 = val_3 * val_3;
        val_4 = val_5 * val_4;
        val_5 = val_4 * val_4;
        UnityEngine.Vector3 val_1 = UnityEngine.Physics.gravity;
        float val_6 = System.Math.Abs(val_1.y);
        val_6 = val_6 + val_6;
        val_6 = (val_3 * val_5) / val_6;
        val_6 = val_6 + 丟丌丐丘丆丙丑丑一;
        return (float)val_6;
    }
    internal static float 与下丌丘丗上丄丞与(UnityEngine.Vector3 与与丕丁且丐丘丆东, UnityEngine.Vector3 丌丛丒与丝且丗万与, float 一不丅与丟丌丏丟东)
    {
        float val_4 = 一不丅与丟丌丏丟东;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丌丛丒与丝且丗万与.x, y = 丌丛丒与丝且丗万与.y, z = 丌丛丒与丝且丗万与.z}, b:  new UnityEngine.Vector3() {x = 与与丕丁且丐丘丆东.x, y = 与与丕丁且丐丘丆东.y, z = 与与丕丁且丐丘丆东.z});
        val_4 = val_4 * 0.01745329f;
        UnityEngine.Vector3 val_2 = UnityEngine.Physics.gravity;
        float val_6 = val_4;
        float val_3 = val_1.x * val_4;
        val_3 = val_1.y - val_3;
        val_6 = val_6 * val_6;
        val_2.y = val_1.x * System.Math.Abs(val_2.y);
        val_3 = val_3 + val_3;
        val_2.y = val_1.x * val_2.y;
        val_6 = val_6 * val_3;
        val_6 = val_2.y / val_6;
        if(val_6 < _TYPE_MAX_)
        {
                return (float)System.Math.Abs(val_6);
        }
        
        return (float)System.Math.Abs(val_6);
    }

}
