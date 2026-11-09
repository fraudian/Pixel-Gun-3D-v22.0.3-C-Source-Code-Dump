using UnityEngine;
public class 丌且丄七上业七丒且
{
    // Fields
    private static UnityEngine.Transform 丂丅丁丛丒不丌万丁;
    private static UnityEngine.Transform 业丘三丒丐丈丏七东;
    private static UnityEngine.Vector3[] 七丛丒丟丁且丘下业;
    private static float[] 东下七且与丕丛丕丏;
    private static int 且丁一世丏万下丒丏;
    private static UnityEngine.Quaternion[] 丘丆世丈丆丘丆与丘;
    private static float[] 丄丄一丏丙丒万世丝;
    private static int 与丐下丂丒丌丁丅丆;
    
    // Methods
    public static void 丘上丐世丆丑且丞丒()
    {
        var val_9 = null;
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁 = new UnityEngine.GameObject(name:  "Math3d_TempChild").transform;
        丌且丄七上业七丒且.业丘三丒丐丈丏七东 = new UnityEngine.GameObject(name:  "Math3d_TempParent").transform;
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.gameObject.hideFlags = 61;
        UnityEngine.Object.DontDestroyOnLoad(target:  丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.gameObject);
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.gameObject.hideFlags = 61;
        UnityEngine.Object.DontDestroyOnLoad(target:  丌且丄七上业七丒且.业丘三丒丐丈丏七东.gameObject);
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.parent = 丌且丄七上业七丒且.业丘三丒丐丈丏七东;
    }
    public static UnityEngine.Vector2 丟丒丘丅七丁不丛东(float 丂丑三丕业丐万与下, UnityEngine.Vector2[] 丁丆东丂丙下丂丅丂)
    {
        float val_34;
        float val_35;
        int val_36;
        val_34 = 丂丑三丕业丐万与下;
        if()
        {
                val_35 = 0f;
        }
        else
        {
                float val_3 = ((float)丁丆东丂丙下丂丅丂.Length - 3) * val_34;
            int val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  val_3), b:  丁丆东丂丙下丂丅丂.Length - 4);
            val_36 = 丁丆东丂丙下丂丅丂.Length;
            if(val_5 >= val_36)
        {
                val_36 = 丁丆东丂丙下丂丅丂.Length;
        }
        
            UnityEngine.Vector2 val_34 = 丁丆东丂丙下丂丅丂[(long)val_5];
            UnityEngine.Vector2 val_35 = 丁丆东丂丙下丂丅丂[(long)val_5];
            var val_6 = (long)val_5 + 1;
            if(val_6 >= val_36)
        {
                val_36 = 丁丆东丂丙下丂丅丂.Length;
        }
        
            UnityEngine.Vector2 val_36 = 丁丆东丂丙下丂丅丂[(long)val_6];
            UnityEngine.Vector2 val_37 = 丁丆东丂丙下丂丅丂[(long)val_6];
            var val_7 = (long)val_5 + 2;
            if(val_7 >= val_36)
        {
                val_36 = 丁丆东丂丙下丂丅丂.Length;
        }
        
            UnityEngine.Vector2 val_38 = 丁丆东丂丙下丂丅丂[(long)val_7];
            UnityEngine.Vector2 val_39 = 丁丆东丂丙下丂丅丂[(long)val_7];
            UnityEngine.Vector2 val_40 = 丁丆东丂丙下丂丅丂[(long)(long)val_5 + 3];
            float val_9 = val_3 - (float)val_5;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(d:  2f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, d:  val_9);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(d:  2f, a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Multiply(d:  5f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(d:  4f, a:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            val_34 = 丁丆东丂丙下丂丅丂[(long)(long)val_5 + 3];
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, b:  new UnityEngine.Vector2() {x = val_40, y = val_34});
            float val_21 = val_9 * val_9;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y}, d:  val_21);
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, b:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_34, y = val_35});
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Multiply(d:  3f, a:  new UnityEngine.Vector2() {x = val_36, y = val_37});
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Multiply(d:  3f, a:  new UnityEngine.Vector2() {x = val_38, y = val_39});
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, b:  new UnityEngine.Vector2() {x = val_40, y = val_34});
            float val_42 = val_9;
            val_42 = val_42 * val_21;
            UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y}, d:  val_42);
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, b:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
            val_35 = val_31.x;
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector2() {x = val_35, y = val_31.y});
        }
        
        UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_32.x, y:  val_32.y);
        return new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
    }
    public static float[] 专丛东丈丛丑丑丅丞(UnityEngine.Vector2[] 丟万丆且丁丏丈丞丆, UnityEngine.Vector2[] 丁丆东丂丙下丂丅丂)
    {
        int val_51;
        var val_53;
        var val_54;
        float val_55;
        int val_56;
        UnityEngine.Vector2 val_57;
        float val_58;
        UnityEngine.Vector2 val_59;
        float val_60;
        float val_61;
        float val_62;
        System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
        int val_2 = 丁丆东丂丙下丂丅丂.Length - 3;
        if(val_2 < 1)
        {
                return (System.Single[])val_1.ToArray();
        }
        
        var val_45 = 0;
        val_51 = 丁丆东丂丙下丂丅丂.Length & 4294967295;
        val_53 = 8589934592;
        val_54 = 12884901888;
        val_55 = 3f;
        goto label_3;
        label_30:
        val_51 = 丁丆东丂丙下丂丅丂.Length;
        val_53 = 12884901888;
        val_54 = 17179869184;
        val_55 = 3f;
        label_3:
        if(val_45 >= val_51)
        {
                val_51 = 丁丆东丂丙下丂丅丂.Length;
        }
        
        val_45 = val_45 + 1;
        if(val_45 >= val_51)
        {
                val_51 = 丁丆东丂丙下丂丅丂.Length;
        }
        
        val_45 = val_45 + 1;
        if(val_45 >= val_51)
        {
                val_51 = 丁丆东丂丙下丂丅丂.Length;
        }
        
        UnityEngine.Vector2 val_46 = 丁丆东丂丙下丂丅丂[0];
        val_45 = val_45 + 1;
        UnityEngine.Vector2 val_47 = 丁丆东丂丙下丂丅丂[0];
        UnityEngine.Vector2 val_48 = 丁丆东丂丙下丂丅丂[0];
        UnityEngine.Vector2 val_49 = 丁丆东丂丙下丂丅丂[0];
        val_56 = 丟万丆且丁丏丈丞丆.Length;
        if(val_56 == 0)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        if(val_56 <= 1)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        if(val_56 <= 1)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        if(val_56 == 0)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        val_57 = 丟万丆且丁丏丈丞丆[0];
        if(val_56 == 0)
        {
                val_57 = 丟万丆且丁丏丈丞丆[0];
            val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        float val_3 = null * val_55;
        float val_4 = null * val_55;
        float val_7 = 7938.641f + 7938.641f;
        if(val_56 <= 1)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        val_3 = val_3 - null;
        val_4 = val_4 - 7938.641f;
        val_55 = val_47 * val_55;
        val_58 = (null + null) - (null * 5f);
        float val_10 = val_46 * 4f;
        val_7 = val_7 - (null * 5f);
        if(val_56 == 0)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
            val_58 = val_58;
        }
        
        val_55 = val_4 - val_55;
        val_10 = val_58 + val_10;
        if(val_56 <= 1)
        {
                val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        val_59 = 丟万丆且丁丏丈丞丆[1];
        float val_15 = val_55 + val_49;
        if(val_56 == 0)
        {
                val_59 = val_59;
            val_56 = 丟万丆且丁丏丈丞丆.Length;
        }
        
        val_60 = ((val_3 - (val_46 * val_55)) + val_48) * 0.5f;
        val_15 = val_15 * 0.5f;
        val_61 = (val_10 - val_48) * 0.5f;
        float val_22 = ((val_7 + (val_47 * 4f)) - val_49) * 0.5f;
        float val_25 = (7938.641f + 7938.641f) * 0.5f;
        float val_27 = 丟万丆且丁丏丈丞丆[1] - val_57;
        if(val_56 == 0)
        {
                val_61 = val_61;
            val_60 = val_60;
            val_59 = val_59;
        }
        
        UnityEngine.Vector2 val_57 = val_57;
        UnityEngine.Vector2 val_56 = 丟万丆且丁丏丈丞丆[0];
        val_57 = val_57 - 丟万丆且丁丏丈丞丆[1];
        UnityEngine.Vector2 val_58 = 丟万丆且丁丏丈丞丆[0];
        val_57 = val_57 * 丟万丆且丁丏丈丞丆[0];
        val_56 = (val_59 - 丟万丆且丁丏丈丞丆[0]) * val_56;
        val_58 = val_58 - 丟万丆且丁丏丈丞丆[1];
        val_56 = val_57 + val_56;
        float val_30 = val_25 * val_58;
        val_30 = val_30 + (((7938.641f + 7938.641f) * 0.5f) * val_27);
        val_22 = (val_61 * val_58) + (val_22 * val_27);
        val_62 = (((val_46 - 7938.641f) * 0.5f) * val_58) + (((val_47 - 7938.641f) * 0.5f) * val_27);
        val_25 = val_30 + val_56;
        丌且丄七上业七丒且.丈东丌七丛且上一丁(三与与专丑丝丕丈丒: out  0, 丄丌三丈丈丞万丌丅: out  float val_39 = -3.620805E-35f, 丕三丛七丕丐世专丆: out  float val_40 = -3.620804E-35f, 且丐上且丞丒丟与丘: out  float val_41 = -3.620803E-35f, 丆丛丑世下一丐且丕:  (val_60 * val_58) + (val_15 * val_27), 丌丗丏丏丛东专丁且:  val_22, 丁丂专业丁丅丅丈丙:  val_62, 丐丆丂丒丁万丈丛丅:  val_25);
        val_45 = val_45 - 3;
        float val_60 = 0f;
        float val_59 = (float)val_45;
        float val_42 = val_59 / (float)val_2;
        val_59 = val_59 + 1f;
        val_59 = val_59 / (float)val_2;
        float val_43 = val_59 - val_42;
        if((val_60 >= 0f) && (val_60 <= 1f))
        {
                val_60 = val_43 * val_60;
            val_62 = val_42 + val_60;
            val_1.Add(item:  val_62);
        }
        
        float val_61 = 0f;
        if((val_61 >= 0f) && (val_61 <= 1f))
        {
                val_61 = val_43 * val_61;
            val_62 = val_42 + val_61;
            val_1.Add(item:  val_62);
        }
        
        float val_62 = 0f;
        if((val_62 >= 0f) && (val_62 <= 1f))
        {
                val_62 = val_43 * val_62;
            val_62 = val_42 + val_62;
            val_1.Add(item:  val_62);
        }
        
        val_45 = val_45 + 1;
        if(val_45 != val_2)
        {
            goto label_30;
        }
        
        return (System.Single[])val_1.ToArray();
    }
    private static void 丈东丌七丛且上一丁(out int 三与与专丑丝丕丈丒, out float 丄丌三丈丈丞万丌丅, out float 丕三丛七丕丐世专丆, out float 且丐上且丞丒丟与丘, float 丆丛丑世下一丐且丕, float 丌丗丏丏丛东专丁且, float 丁丂专业丁丅丅丈丙, float 丐丆丂丒丁万丈丛丅)
    {
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_17 = 丁丂专业丁丅丅丈丙;
        float val_19 = 丌丗丏丏丛东专丁且;
        丆丛丑世下一丐且丕 = val_19 / 丆丛丑世下一丐且丕;
        float val_1 = val_17 / 丆丛丑世下一丐且丕;
        float val_2 = 丐丆丂丒丁万丈丛丅 / 丆丛丑世下一丐且丕;
        float val_18 = 9f;
        val_2 = val_2 * (-27f);
        float val_4 = 丆丛丑世下一丐且丕 * 丆丛丑世下一丐且丕;
        float val_16 = -2f;
        val_4 = (val_1 * 3f) - val_4;
        val_16 = 丆丛丑世下一丐且丕 * val_16;
        val_1 = (丆丛丑世下一丐且丕 * val_18) * val_1;
        val_16 = 丆丛丑世下一丐且丕 * val_16;
        val_1 = val_1 + val_2;
        val_17 = val_4 / val_18;
        val_1 = val_1 + (丆丛丑世下一丐且丕 * val_16);
        val_18 = val_17 * val_17;
        val_16 = val_1 / 54f;
        float val_7 = val_17 * val_18;
        val_1 = val_16 * val_16;
        val_17 = val_7 + val_1;
        val_19 = 丆丛丑世下一丐且丕 / 3f;
        if(val_17 < 0)
        {
                三与与专丑丝丕丈丒 = 3;
            if(丆丛丑世下一丐且丕 >= _TYPE_MAX_)
        {
                val_18 = -val_7;
        }
        
            val_18 = val_16 / val_18;
            val_16 = val_18;
            if(val_17 >= _TYPE_MAX_)
        {
                val_19 = -val_17;
        }
        
            float val_8 = val_16 / 3f;
            val_19 = val_19 + val_19;
            val_8 = val_19 * val_8;
            val_8 = val_8 - val_19;
            丄丌三丈丈丞万丌丅 = val_8;
            float val_9 = val_16 + 6.283185f;
            val_9 = val_9 / 3f;
            val_9 = val_19 * val_9;
            val_9 = val_9 - val_19;
            丕三丛七丕丐世专丆 = val_9;
            float val_10 = val_16 + 12.56637f;
            val_10 = val_10 / 3f;
            val_10 = val_19 * val_10;
            val_20 = val_10 - val_19;
        }
        else
        {
                if(val_17 > 0f)
        {
                三与与专丑丝丕丈丒 = 1;
            if(val_17 >= _TYPE_MAX_)
        {
                float val_20 = val_17;
            val_21 = val_20;
        }
        
            val_20 = val_16 + val_21;
            val_17 = 丌且丄七上业七丒且.不且上丂丆东丑上与(丐丆丂丒丁万丈丛丅:  val_20);
            float val_13 = 丌且丄七上业七丒且.不且上丂丆东丑上与(丐丆丂丒丁万丈丛丅:  val_16 - val_21);
            val_13 = val_17 + val_13;
            val_1 = val_13 - val_19;
            val_20 = 0f;
            丄丌三丈丈丞万丌丅 = val_1;
            丕三丛七丕丐世专丆 = 0f;
        }
        else
        {
                三与与专丑丝丕丈丒 = 3;
            float val_14 = 丌且丄七上业七丒且.不且上丂丆东丑上与(丐丆丂丒丁万丈丛丅:  val_16);
            float val_15 = val_14 + val_14;
            val_20 = val_14 - val_19;
            val_15 = val_15 - val_19;
            丄丌三丈丈丞万丌丅 = val_15;
            丕三丛七丕丐世专丆 = val_20;
        }
        
        }
        
        且丐上且丞丒丟与丘 = val_20;
    }
    private static float 不且上丂丆东丑上与(float 丐丆丂丒丁万丈丛丅)
    {
        if(丐丆丂丒丁万丈丛丅 < 0)
        {
                return (float)-(-丐丆丂丒丁万丈丛丅);
        }
    
    }
    public static UnityEngine.Vector3 丒丝上丙丙丝丐丐万(UnityEngine.Vector3 丒丙丐一丈一三一丆, float 丟丒且一专丟丙下一)
    {
        float val_2 = 丒丙丐一丈一三一丆.y;
        float val_1 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = val_2, z = 丒丙丐一丈一三一丆.z});
        val_2 = val_1 + 丟丒且一专丟丙下一;
        丟丒且一专丟丙下一 = val_2 / val_1;
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z}, d:  丟丒且一专丟丙下一);
    }
    public static UnityEngine.Vector3 且不丄丒世三丗且丑(UnityEngine.Vector3 丒丙丐一丈一三一丆, float 丟丒且一专丟丙下一)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z});
        return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  丟丒且一专丟丙下一);
    }
    public static UnityEngine.Quaternion 上三丁丁专丅丑丂丅(UnityEngine.Quaternion 业与丞不丒丞丕丏丗, UnityEngine.Quaternion 丑万丞丟丘不丛丒丙)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = 丑万丞丟丘不丛丒丙.x, y = 丑万丞丟丘不丛丒丙.y, z = 丑万丞丟丘不丛丒丙.z, w = 丑万丞丟丘不丛丒丙.w});
        return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, rhs:  new UnityEngine.Quaternion() {x = 业与丞不丒丞丕丏丗.x, y = 业与丞不丒丞丕丏丗.y, z = 业与丞不丒丞丕丏丗.z, w = 业与丞不丒丞丕丏丗.w});
    }
    public static UnityEngine.Quaternion 丈丞且丕三丅丗丁万(UnityEngine.Quaternion 丑万丞丟丘不丛丒丙, UnityEngine.Quaternion 业与丞不丒丞丕丏丗)
    {
        return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 丑万丞丟丘不丛丒丙.x, y = 丑万丞丟丘不丛丒丙.y, z = 丑万丞丟丘不丛丒丙.z, w = 丑万丞丟丘不丛丒丙.w}, rhs:  new UnityEngine.Quaternion() {x = 业与丞不丒丞丕丏丗.x, y = 业与丞不丒丞丕丏丗.y, z = 业与丞不丒丞丕丏丗.z, w = 业与丞不丒丞丕丏丗.w});
    }
    public static UnityEngine.Vector3 丒万丕丘丗丕丟不丘(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, UnityEngine.Vector3 丒丙丐一丈一三一丆)
    {
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w}, point:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z});
    }
    public static UnityEngine.Vector3 专下丛丘丑丂不世丗(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, UnityEngine.Vector3 丒丙丐一丈一三一丆)
    {
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = 七丅丗丆丒丌丑丝不.x, y = 七丅丗丆丒丌丑丝不.y, z = 七丅丗丆丒丌丑丝不.z, w = 七丅丗丆丒丌丑丝不.w});
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z});
    }
    public static UnityEngine.Vector3 且下东东业不丞与丛(UnityEngine.Quaternion 丈丗与丞一上且上上, UnityEngine.Quaternion 专丂丕丗丗东世丞下, UnityEngine.Vector3 丒丙丐一丈一三一丆)
    {
        float val_1;
        UnityEngine.Quaternion val_2 = 丌且丄七上业七丒且.上三丁丁专丅丑丂丅(业与丞不丒丞丕丏丗:  new UnityEngine.Quaternion() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z, w = 专丂丕丗丗东世丞下.w}, 丑万丞丟丘不丛丒丙:  new UnityEngine.Quaternion() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z, w = 丈丗与丞一上且上上.w});
        UnityEngine.Vector3 val_3 = 丌且丄七上业七丒且.专下丛丘丑丂不世丗(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z, w = 丈丗与丞一上且上上.w}, 丒丙丐一丈一三一丆:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = val_1, z = 丒丙丐一丈一三一丆.y});
        UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        return 丌且丄七上业七丒且.丒万丕丘丗丕丟不丘(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z, w = 丈丗与丞一上且上上.w}, 丒丙丐一丈一三一丆:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public static bool 下一不下丐专丘丆一(out UnityEngine.Vector3 丙丞下丒丌丘七东丆, out UnityEngine.Vector3 万丆丙世丌丞万与丗, UnityEngine.Vector3 丄上丄业与丘丞丞丝, UnityEngine.Vector3 东世丕丆七世万丂东, UnityEngine.Vector3 万丒丅丙三上丁丙七, UnityEngine.Vector3 丂丝丑丐且丛丑丂丏)
    {
        float val_1;
        float val_7;
        float val_12;
        var val_13;
        val_12 = 万丒丅丙三上丁丙七.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        丙丞下丒丌丘七东丆.x = val_2.x;
        丙丞下丒丌丘七东丆.y = val_2.y;
        丙丞下丒丌丘七东丆.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        万丆丙世丌丞万与丗.x = val_3.x;
        万丆丙世丌丞万与丗.y = val_3.y;
        万丆丙世丌丞万与丗.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 丄上丄业与丘丞丞丝.x, y = 丄上丄业与丘丞丞丝.y, z = 丄上丄业与丘丞丞丝.z}, rhs:  new UnityEngine.Vector3() {x = val_12, y = val_1, z = 万丒丅丙三上丁丙七.y});
        万丆丙世丌丞万与丗.x = val_4.x;
        万丆丙世丌丞万与丗.y = val_4.y;
        万丆丙世丌丞万与丗.z = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_12, y = val_1, z = 万丒丅丙三上丁丙七.y}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丄上丄业与丘丞丞丝.x, y = 丄上丄业与丘丞丞丝.y, z = 丄上丄业与丘丞丞丝.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        if(System.Math.Abs(val_6) > 0.006f)
        {
                val_12 = val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 东世丕丆七世万丂东.x, y = 东世丕丆七世万丂东.y, z = 东世丕丆七世万丂东.z}, b:  new UnityEngine.Vector3() {x = 万丒丅丙三上丁丙七.z, y = val_12, z = 丂丝丑丐且丛丑丂丏.x});
            float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丄上丄业与丘丞丞丝.x, y = 丄上丄业与丘丞丞丝.y, z = 丄上丄业与丘丞丞丝.z}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_9 = val_9 / val_6;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 万丒丅丙三上丁丙七.z, y = val_12, z = 丂丝丑丐且丛丑丂丏.x}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_13 = 1;
            丙丞下丒丌丘七东丆.x = val_11.x;
            丙丞下丒丌丘七东丆.y = val_11.y;
            丙丞下丒丌丘七东丆.z = val_11.z;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    public static bool 世与丅东与业一上丄(out UnityEngine.Vector3 三万丐丄丁三丟丕与, UnityEngine.Vector3 丙丞下丒丌丘七东丆, UnityEngine.Vector3 万丆丙世丌丞万与丗, UnityEngine.Vector3 与一世丌丝丙专丐丁, UnityEngine.Vector3 丘丄丅丒丂业丞丘与)
    {
        float val_1;
        float val_2;
        float val_9;
        float val_10;
        var val_11;
        val_9 = 与一世丌丝丙专丐丁.x;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        三万丐丄丁三丟丕与.x = val_3.x;
        三万丐丄丁三丟丕与.y = val_3.y;
        三万丐丄丁三丟丕与.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.z, y = val_1, z = 丘丄丅丒丂业丞丘与.x}, b:  new UnityEngine.Vector3() {x = 丙丞下丒丌丘七东丆.x, y = 丙丞下丒丌丘七东丆.y, z = 丙丞下丒丌丘七东丆.z});
        val_10 = 万丆丙世丌丞万与丗.z;
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 万丆丙世丌丞万与丗.x, y = 万丆丙世丌丞万与丗.y, z = val_10}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = 与一世丌丝丙专丐丁.y});
        if(val_6 != 0f)
        {
                val_9 = (UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_9, y = val_2, z = 与一世丌丝丙专丐丁.y})) / val_6;
            UnityEngine.Vector3 val_7 = 丌且丄七上业七丒且.且不丄丒世三丗且丑(丒丙丐一丈一三一丆:  new UnityEngine.Vector3() {x = 万丆丙世丌丞万与丗.x, y = 万丆丙世丌丞万与丗.y, z = val_10}, 丟丒且一专丟丙下一:  val_9);
            val_9 = val_7.x;
            val_10 = val_7.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丙丞下丒丌丘七东丆.x, y = 丙丞下丒丌丘七东丆.y, z = 丙丞下丒丌丘七东丆.z}, b:  new UnityEngine.Vector3() {x = val_9, y = val_7.y, z = val_10});
            val_11 = 1;
            三万丐丄丁三丟丕与.x = val_8.x;
            三万丐丄丁三丟丕与.y = val_8.y;
            三万丐丄丁三丟丕与.z = val_8.z;
            return (bool)val_11;
        }
        
        val_11 = 0;
        return (bool)val_11;
    }
    public static bool 专业七丘三与丏不丏(out UnityEngine.Vector3 三万丐丄丁三丟丕与, UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 一丛丅丈丞丌丟丞丄, UnityEngine.Vector3 丏万上丟丐与丌下且, UnityEngine.Vector3 丂丛丂丝世万丏东丘)
    {
        float val_1;
        float val_2;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        var val_16;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = val_2, z = 丏万上丟丐与丌下且.y}, b:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 一丛丅丈丞丌丟丞丄.x, y = 一丛丅丈丞丌丟丞丄.y, z = 一丛丅丈丞丌丟丞丄.z}, rhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_1, z = 丂丛丂丝世万丏东丘.x});
        val_11 = val_3.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_11}, rhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_1, z = 丂丛丂丝世万丏东丘.x});
        val_12 = val_3.y;
        val_13 = val_11;
        val_14 = 0.0001f;
        val_15 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_12, z = val_13}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}));
        if((val_15 < 0) && (val_15 > val_14))
        {
                val_11 = val_4.z;
            float val_11 = val_4.x;
            float val_7 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_11, y = val_4.y, z = val_11});
            val_14 = val_7;
            val_11 = val_14 / val_7;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 一丛丅丈丞丌丟丞丄.x, y = 一丛丅丈丞丌丟丞丄.y, z = 一丛丅丈丞丌丟丞丄.z}, d:  val_11);
            val_15 = 业丏丂丐丂丟丏东丘.x;
            val_12 = 业丏丂丐丂丟丏东丘.y;
            val_13 = 业丏丂丐丂丟丏东丘.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = val_12, z = val_13}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_16 = 1;
        }
        else
        {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_16 = 0;
        }
        
        三万丐丄丁三丟丕与.x = val_10.x;
        三万丐丄丁三丟丕与.y = val_10.y;
        三万丐丄丁三丟丕与.z = val_10.z;
        return (bool)val_16;
    }
    public static bool 业丛世业上与七丘丝(out UnityEngine.Vector3 上一丄丞丑丐丏丕丄, out UnityEngine.Vector3 丂丗一丌万世不丞与, UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 一丛丅丈丞丌丟丞丄, UnityEngine.Vector3 丏万上丟丐与丌下且, UnityEngine.Vector3 丂丛丂丝世万丏东丘)
    {
        float val_1;
        float val_8;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        var val_22;
        val_18 = 一丛丅丈丞丌丟丞丄.z;
        float val_19 = val_1;
        val_19 = 丂丛丂丝世万丏东丘.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        上一丄丞丑丐丏丕丄.x = val_2.x;
        上一丄丞丑丐丏丕丄.y = val_2.y;
        上一丄丞丑丐丏丕丄.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        丂丗一丌万世不丞与.x = val_3.x;
        丂丗一丌万世不丞与.y = val_3.y;
        丂丗一丌万世不丞与.z = val_3.z;
        val_20 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 一丛丅丈丞丌丟丞丄.x, y = 一丛丅丈丞丌丟丞丄.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = 一丛丅丈丞丌丟丞丄.x, y = 一丛丅丈丞丌丟丞丄.y, z = val_18});
        float val_22 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 一丛丅丈丞丌丟丞丄.x, y = 一丛丅丈丞丌丟丞丄.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_19, z = val_19});
        float val_18 = val_19;
        float val_6 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_19, z = val_18}, rhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_19, z = val_19});
        val_18 = val_20 * val_6;
        val_19 = val_18 - (val_22 * val_22);
        if(val_19 != 0f)
        {
                val_21 = 丏万上丟丐与丌下且.x;
            val_21 = val_21;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, b:  new UnityEngine.Vector3() {x = val_21, y = val_8, z = 丏万上丟丐与丌下且.y});
            val_19 = 一丛丅丈丞丌丟丞丄.x;
            val_20 = val_9.y;
            val_18 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_19, y = 一丛丅丈丞丌丟丞丄.y, z = val_18}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z});
            float val_20 = val_19;
            float val_11 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_20, z = val_19}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_20, z = val_9.z});
            float val_21 = val_6;
            val_20 = val_22 * val_11;
            val_21 = val_21 * val_18;
            val_20 = val_20 - val_21;
            val_11 = val_20 * val_11;
            val_11 = val_11 - (val_22 * val_18);
            val_22 = val_11 / val_19;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19, y = 一丛丅丈丞丌丟丞丄.y, z = val_18}, d:  val_20 / val_19);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            上一丄丞丑丐丏丕丄.x = val_15.x;
            上一丄丞丑丐丏丕丄.y = val_15.y;
            上一丄丞丑丐丏丕丄.z = val_15.z;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.z, y = val_19, z = val_19}, d:  val_22);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21, y = val_8, z = 丏万上丟丐与丌下且.y}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_22 = 1;
            丂丗一丌万世不丞与.x = val_17.x;
            丂丗一丌万世不丞与.y = val_17.y;
            丂丗一丌万世不丞与.z = val_17.z;
            return (bool)val_22;
        }
        
        val_22 = 0;
        return (bool)val_22;
    }
    public static UnityEngine.Vector3 丈世丒丘且丕下丟丙(UnityEngine.Vector3 丙丞下丒丌丘七东丆, UnityEngine.Vector3 万丆丙世丌丞万与丗, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = val_1, z = 丅专与丒丈丗丒丘丌.y}, b:  new UnityEngine.Vector3() {x = 丙丞下丒丌丘七东丆.x, y = 丙丞下丒丌丘七东丆.y, z = 丙丞下丒丌丘七东丆.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 万丆丙世丌丞万与丗.x, y = 万丆丙世丌丞万与丗.y, z = 万丆丙世丌丞万与丗.z}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = 万丆丙世丌丞万与丗.x, y = 万丆丙世丌丞万与丗.y, z = 万丆丙世丌丞万与丗.z}));
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丙丞下丒丌丘七东丆.x, y = 丙丞下丒丌丘七东丆.y, z = 丙丞下丒丌丘七东丆.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    public static UnityEngine.Vector3 万下三丝丙丗丄业三(UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 丏万上丟丐与丌下且, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        var val_6;
        float val_10;
        float val_11;
        float val_12;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, b:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z});
        val_6 = null;
        UnityEngine.Vector3 val_3 = 丌且丄七上业七丒且.丈世丒丘且丕下丟丙(丙丞下丒丌丘七东丆:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 万丆丙世丌丞万与丗:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y});
        val_10 = val_3.x;
        val_11 = val_3.y;
        val_12 = val_3.z;
        int val_4 = 丌且丄七上业七丒且.丞丕丗东与一业七丌(业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_10, y = val_12});
        if(val_4 == 0)
        {
                return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        }
        
        if(val_4 == 1)
        {
            goto label_6;
        }
        
        if(val_4 != 2)
        {
            goto label_7;
        }
        
        val_10 = 丏万上丟丐与丌下且.x;
        val_11 = 丏万上丟丐与丌下且.y;
        val_12 = 丏万上丟丐与丌下且.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        label_6:
        val_10 = 业丏丂丐丂丟丏东丘.x;
        val_11 = 业丏丂丐丂丟丏东丘.y;
        val_12 = 业丏丂丐丂丟丏东丘.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
        label_7:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_10 = val_5.x;
        val_11 = val_5.y;
        val_12 = val_5.z;
        return new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12};
    }
    public static UnityEngine.Vector3 下丁丅万丟丄上且丂(UnityEngine.Vector3 与一世丌丝丙专丐丁, UnityEngine.Vector3 丘丄丅丒丂业丞丘与, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_1;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_4 = val_1;
        val_5 = 丅专与丒丈丗丒丘丌.y;
        val_6 = 丅专与丒丈丗丒丘丌.x;
        val_7 = 丘丄丅丒丂业丞丘与.z;
        val_5 = val_5;
        val_4 = val_4;
        val_6 = val_6;
        val_7 = val_7;
        val_5 = val_5;
        val_4 = val_4;
        val_6 = val_6;
        UnityEngine.Vector3 val_3 = 丌且丄七上业七丒且.且不丄丒世三丗且丑(丒丙丐一丈一三一丆:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.x, y = 与一世丌丝丙专丐丁.y, z = 与一世丌丝丙专丐丁.z}, 丟丒且一专丟丙下一:  -(丌且丄七上业七丒且.丄丕且丒世丝丌丕丒(与一世丌丝丙专丐丁:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.x, y = 与一世丌丝丙专丐丁.y, z = 与一世丌丝丙专丐丁.z}, 丘丄丅丒丂业丞丘与:  new UnityEngine.Vector3() {x = 丘丄丅丒丂业丞丘与.x, y = 丘丄丅丒丂业丞丘与.y, z = val_7}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = ???})));
        return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_5}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
    }
    public static UnityEngine.Vector3 丙丌丞丘丌且与丘丕(UnityEngine.Vector3 与一世丌丝丙专丐丁, UnityEngine.Vector3 丒丙丐一丈一三一丆)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z}, rhs:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.x, y = 与一世丌丝丙专丐丁.y, z = 与一世丌丝丙专丐丁.z}), a:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.x, y = 与一世丌丝丙专丐丁.y, z = 与一世丌丝丙专丐丁.z});
        return UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public static float 丄丕且丒世丝丌丕丒(UnityEngine.Vector3 与一世丌丝丙专丐丁, UnityEngine.Vector3 丘丄丅丒丂业丞丘与, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = val_1, z = 丅专与丒丈丗丒丘丌.y}, b:  new UnityEngine.Vector3() {x = 丘丄丅丒丂业丞丘与.x, y = 丘丄丅丒丂业丞丘与.y, z = 丘丄丅丒丂业丞丘与.z});
        return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 与一世丌丝丙专丐丁.x, y = 与一世丌丝丙专丐丁.y, z = 与一世丌丝丙专丐丁.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public static float 一与丌丟丈丝丛一三(UnityEngine.Vector3 丗丕世三丝且丘三不, UnityEngine.Vector3 丙与不且丞业丅不丝, UnityEngine.Vector3 丏与三业丈丕专且丑)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_1, z = 丏与三业丈丕专且丑.y}, rhs:  new UnityEngine.Vector3() {x = 丗丕世三丝且丘三不.x, y = 丗丕世三丝且丘三不.y, z = 丗丕世三丝且丘三不.z});
        return UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = 丙与不且丞业丅不丝.x, y = 丙与不且丞业丅不丝.y, z = 丙与不且丞业丅不丝.z});
    }
    public static float 丗一世丗丙丗万万三(UnityEngine.Vector3 丂业三丒与业丐不丑, UnityEngine.Vector3 丂专丕不丈丆专一丄, UnityEngine.Vector3 丏与三业丈丕专且丑)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = val_1, z = 丏与三业丈丕专且丑.y}, rhs:  new UnityEngine.Vector3() {x = 丂业三丒与业丐不丑.x, y = 丂业三丒与业丐不丑.y, z = 丂业三丒与业丐不丑.z});
        float val_5 = UnityEngine.Mathf.Sign(f:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = 丂专丕不丈丆专一丄.x, y = 丂专丕不丈丆专一丄.y, z = 丂专丕不丈丆专一丄.z}));
        val_5 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = 丂业三丒与业丐不丑.x, y = 丂业三丒与业丐不丑.y, z = 丂业三丒与业丐不丑.z}, to:  new UnityEngine.Vector3() {x = 丂专丕不丈丆专一丄.x, y = 丂专丕不丈丆专一丄.y, z = 丂专丕不丈丆专一丄.z})) * val_5;
        return (float)val_5;
    }
    public static float 丈世丏上东下丁业丑(UnityEngine.Vector3 丒丙丐一丈一三一丆, UnityEngine.Vector3 丏与三业丈丕专且丑)
    {
        float val_2 = (float)(double)UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丒丙丐一丈一三一丆.x, y = 丒丙丐一丈一三一丆.y, z = 丒丙丐一丈一三一丆.z}, rhs:  new UnityEngine.Vector3() {x = 丏与三业丈丕专且丑.x, y = 丏与三业丈丕专且丑.y, z = 丏与三业丈丕专且丑.z});
        val_2 = 1.570796f - val_2;
        return (float)val_2;
    }
    public static float 且万七且下三一丏丒(UnityEngine.Vector3 丟丟丅一丗七丅丕丏, UnityEngine.Vector3 丛与丈万丛丆一与丂)
    {
        float val_1 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 丟丟丅一丗七丅丕丏.x, y = 丟丟丅一丗七丅丕丏.y, z = 丟丟丅一丗七丅丕丏.z}, rhs:  new UnityEngine.Vector3() {x = 丛与丈万丛丆一与丂.x, y = 丛与丈万丛丆一与丂.y, z = 丛与丈万丛丆一与丂.z});
        return (float)(float)丛与丈万丛丆一与丂.z;
    }
    public static void 丆东上七丈丅丂丙三(out UnityEngine.Vector3 与一世丌丝丙专丐丁, out UnityEngine.Vector3 丘丄丅丒丂业丞丘与, UnityEngine.Vector3 丁丞专且丟与世专丝, UnityEngine.Vector3 丝丐不世一与丏丅丙, UnityEngine.Vector3 下丗万丕丐丒丒三丁)
    {
        float val_1;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        与一世丌丝丙专丐丁.x = val_2.x;
        与一世丌丝丙专丐丁.y = val_2.y;
        与一世丌丝丙专丐丁.z = val_2.z;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        丘丄丅丒丂业丞丘与.x = val_3.x;
        丘丄丅丒丂业丞丘与.y = val_3.y;
        丘丄丅丒丂业丞丘与.z = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丝丐不世一与丏丅丙.x, y = 丝丐不世一与丏丅丙.y, z = 丝丐不世一与丏丅丙.z}, b:  new UnityEngine.Vector3() {x = 丁丞专且丟与世专丝.x, y = 丁丞专且丟与世专丝.y, z = 丁丞专且丟与世专丝.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下丗万丕丐丒丒三丁.x, y = val_1, z = 下丗万丕丐丒丒三丁.y}, b:  new UnityEngine.Vector3() {x = 丁丞专且丟与世专丝.x, y = 丁丞专且丟与世专丝.y, z = 丁丞专且丟与世专丝.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Normalize(value:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        与一世丌丝丙专丐丁.x = val_7.x;
        与一世丌丝丙专丐丁.y = val_7.y;
        与一世丌丝丙专丐丁.z = val_7.z;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  2f);
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丁丞专且丟与世专丝.x, y = 丁丞专且丟与世专丝.y, z = 丁丞专且丟与世专丝.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  2f);
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丁丞专且丟与世专丝.x, y = 丁丞专且丟与世专丝.y, z = 丁丞专且丟与世专丝.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 下丗万丕丐丒丒三丁.x, y = val_1, z = 下丗万丕丐丒丒三丁.y}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丝丐不世一与丏丅丙.x, y = 丝丐不世一与丏丅丙.y, z = 丝丐不世一与丏丅丙.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        bool val_14 = 丌且丄七上业七丒且.业丛世业上与七丘丝(上一丄丞丑丐丏丕丄: out  new UnityEngine.Vector3() {x = 丘丄丅丒丂业丞丘与.x, y = 丘丄丅丒丂业丞丘与.y, z = 丘丄丅丒丂业丞丘与.z}, 丂丗一丌万世不丞与: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 一丛丅丈丞丌丟丞丄:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = val_13.x}, 丂丛丂丝世万丏东丘:  new UnityEngine.Vector3() {x = val_13.z, z = val_5.x});
    }
    public static UnityEngine.Vector3 丗丗世丆丈丅七丆不(UnityEngine.Quaternion 丒世且丒丅丆一万丝)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 丒世且丒丅丆一万丝.x, y = 丒世且丒丅丆一万丝.y, z = 丒世且丒丅丆一万丝.z, w = 丒世且丒丅丆一万丝.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public static UnityEngine.Vector3 下一下不丏丑丁丕丗(UnityEngine.Quaternion 丒世且丒丅丆一万丝)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 丒世且丒丅丆一万丝.x, y = 丒世且丒丅丆一万丝.y, z = 丒世且丒丅丆一万丝.z, w = 丒世且丒丅丆一万丝.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public static UnityEngine.Vector3 丟业东丕一丌丕丐丄(UnityEngine.Quaternion 丒世且丒丅丆一万丝)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
        return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 丒世且丒丅丆一万丝.x, y = 丒世且丒丅丆一万丝.y, z = 丒世且丒丅丆一万丝.z, w = 丒世且丒丅丆一万丝.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
    }
    public static UnityEngine.Quaternion 丟丒业丐与丂丅上东(UnityEngine.Matrix4x4 东丝丄丝丙专丘三丏)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = V3.16B});
        return UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, upwards:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    public static UnityEngine.Vector3 一一专三丄不丝丕丟(UnityEngine.Matrix4x4 东丝丄丝丙专丘三丏)
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static void 丙不东丂丂丙丛业丁(ref UnityEngine.GameObject 丂业丝丞万丆七三上, UnityEngine.Vector3 丆一丈丟丙丘专专丛, UnityEngine.Vector3 下丂不丘世丑七丝不, UnityEngine.Vector3 丌丙丈世万丗不世世, UnityEngine.Vector3 东丑丏东与丈丐丕丝)
    {
        float val_1;
        float val_2;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 丆一丈丟丙丘专专丛.x, y = 丆一丈丟丙丘专专丛.y, z = 丆一丈丟丙丘专专丛.z}, upwards:  new UnityEngine.Vector3() {x = 下丂不丘世丑七丝不.x, y = 下丂不丘世丑七丝不.y, z = 下丂不丘世丑七丝不.z});
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 丌丙丈世万丗不世世.x, y = val_2, z = 丌丙丈世万丗不世世.y}, upwards:  new UnityEngine.Vector3() {x = 丌丙丈世万丗不世世.z, y = val_1, z = 东丑丏东与丈丐丕丝.x});
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
        丂业丝丞万丆七三上.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
    }
    public static void 丙不东丅东丒世专七(out UnityEngine.Quaternion 丗丞七丟丝丁业丆上, out UnityEngine.Vector3 丞丁丛不丒业丞丏丈, UnityEngine.Quaternion 丝丝与丑东丐业东丛, UnityEngine.Vector3 且东丑丂丝丟世七一, UnityEngine.Quaternion 丞不七万丞丈丕丅丑, UnityEngine.Vector3 三丄上丛丟丕丈东丅, UnityEngine.Quaternion 丗万丞丙丞业丙丗丌, UnityEngine.Vector3 丕丛业丛丄丈丙上丝)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_7;
        float val_8;
        float val_9;
        var val_13;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        丗丞七丟丝丁业丆上.x = val_1.x;
        丗丞七丟丝丁业丆上.y = val_1.y;
        丗丞七丟丝丁业丆上.z = val_1.z;
        丗丞七丟丝丁业丆上.w = val_1.w;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        丞丁丛不丒业丞丏丈.x = val_2.x;
        丞丁丛不丒业丞丏丈.y = val_2.y;
        丞丁丛不丒业丞丏丈.z = val_2.z;
        val_13 = null;
        val_13 = null;
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.rotation = new UnityEngine.Quaternion() {x = 丞不七万丞丈丕丅丑.x, y = val_4, z = 丞不七万丞丈丕丅丑.y, w = val_3};
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.position = new UnityEngine.Vector3() {x = 丞不七万丞丈丕丅丑.z, y = val_5, z = 丞不七万丞丈丕丅丑.w};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.rotation = new UnityEngine.Quaternion() {x = 三丄上丛丟丕丈东丅.x, y = val_8, z = 三丄上丛丟丕丈东丅.y, w = val_7};
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.position = new UnityEngine.Vector3() {x = 三丄上丛丟丕丈东丅.z, y = val_9, z = 丗万丞丙丞业丙丗丌.x};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.rotation = new UnityEngine.Quaternion() {x = 丝丝与丑东丐业东丛.x, y = 丝丝与丑东丐业东丛.y, z = 丝丝与丑东丐业东丛.z, w = 丝丝与丑东丐业东丛.w};
        丌且丄七上业七丒且.业丘三丒丐丈丏七东.position = new UnityEngine.Vector3() {x = 且东丑丂丝丟世七一.x, y = 且东丑丂丝丟世七一.y, z = 且东丑丂丝丟世七一.z};
        UnityEngine.Quaternion val_11 = 丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.rotation;
        丗丞七丟丝丁业丆上.x = val_11.x;
        丗丞七丟丝丁业丆上.y = val_11.y;
        丗丞七丟丝丁业丆上.z = val_11.z;
        丗丞七丟丝丁业丆上.w = val_11.w;
        UnityEngine.Vector3 val_12 = 丌且丄七上业七丒且.丂丅丁丛丒不丌万丁.position;
        丞丁丛不丒业丞丏丈.x = val_12.x;
        丞丁丛不丒业丞丏丈.y = val_12.y;
        丞丁丛不丒业丞丏丈.z = val_12.z;
    }
    public static void 丌丟丟丟丅不丕上丏(ref UnityEngine.GameObject 丂业丝丞万丆七三上, UnityEngine.Vector3 丆一丈丟丙丘专专丛, UnityEngine.Vector3 下丂不丘世丑七丝不, UnityEngine.Vector3 丒丐业三丄丕七三丝, UnityEngine.Vector3 丙丐丟丟丄丐丈七世, UnityEngine.Vector3 丟与丐丌丁丘且七丑, UnityEngine.Vector3 丘且丘丆丒丘万丙丟)
    {
        float val_1;
        float val_4;
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        val_10 = 丙丐丟丟丄丐丈七世.z;
        val_11 = 丙丐丟丟丄丐丈七世.y;
        val_12 = 丒丐业三丄丕七三丝.z;
        val_13 = 下丂不丘世丑七丝不.x;
        val_14 = 丆一丈丟丙丘专专丛.y;
        val_12 = val_12;
        val_10 = val_10;
        val_11 = val_11;
        val_15 = val_14;
        val_13 = val_13;
        val_14 = val_15;
        val_12 = val_12;
        val_10 = val_10;
        val_11 = val_11;
        val_15 = val_14;
        丌且丄七上业七丒且.丙不东丂丂丙丛业丁(丂业丝丞万丆七三上: ref  UnityEngine.GameObject val_5 = 丂业丝丞万丆七三上, 丆一丈丟丙丘专专丛:  new UnityEngine.Vector3() {x = 丆一丈丟丙丘专专丛.x, y = val_15, z = 丆一丈丟丙丘专专丛.z}, 下丂不丘世丑七丝不:  new UnityEngine.Vector3() {x = val_13, y = 下丂不丘世丑七丝不.y, z = 下丂不丘世丑七丝不.z}, 丌丙丈世万丗不世世:  new UnityEngine.Vector3() {x = val_12, y = 丙丐丟丟丄丐丈七世.x, z = val_11}, 东丑丏东与丈丐丕丝:  new UnityEngine.Vector3() {x = val_10, z = 下丂不丘世丑七丝不.z});
        UnityEngine.Vector3 val_7 = val_5.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 丟与丐丌丁丘且七丑.x, y = val_1, z = 丟与丐丌丁丘且七丑.y});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丒丐业三丄丕七三丝.x, y = val_4, z = 丒丐业三丄丕七三丝.y}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_5.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, relativeTo:  0);
    }
    public static void 丕丂丗丁丄丝丁丆丟(ref UnityEngine.GameObject 丂业丝丞万丆七三上, UnityEngine.Vector3 丅丐丝与丞丟丕业丘, UnityEngine.Vector3 丝业专下丑与丌且丐, UnityEngine.Vector3 丘丈丈三下丟上丅丂)
    {
        float val_1;
        丂业丝丞万丆七三上.transform.position = new UnityEngine.Vector3() {x = 丅丐丝与丞丟丕业丘.x, y = 丅丐丝与丞丟丕业丘.y, z = 丅丐丝与丞丟丕业丘.z};
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 丝业专下丑与丌且丐.x, y = 丝业专下丑与丌且丐.y, z = 丝业专下丑与丌且丐.z}, upwards:  new UnityEngine.Vector3() {x = 丘丈丈三下丟上丅丂.x, y = val_1, z = 丘丈丈三下丟上丅丂.y});
        丂业丝丞万丆七三上.transform.rotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    public static int 丞丕丗东与一业七丌(UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 丏万上丟丐与丌下且, UnityEngine.Vector3 丅专与丒丈丗丒丘丌)
    {
        float val_1;
        float val_7;
        var val_8;
        val_7 = 业丏丂丐丂丟丏东丘.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, b:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = val_7});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = val_1, z = 丅专与丒丈丗丒丘丌.y}, b:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = val_7});
        float val_4 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        if(val_4 > 0f)
        {
                val_7 = val_4;
            val_8 = ((val_7 > val_4) ? 1 : 0) << 1;
            return (int)val_8;
        }
        
        val_8 = 1;
        return (int)val_8;
    }
    public static float 不且东万丘丒不且专(UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 丏万上丟丐与丌下且)
    {
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z});
        UnityEngine.Vector3 val_4 = val_1.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z});
        UnityEngine.Vector3 val_5 = 丌且丄七上业七丒且.万下三丝丙丗丄业三(业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z, z = 0f});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        return (float)val_6.x;
    }
    public static float 丂丈丕丏丛一七上丆(UnityEngine.Vector3 丅专与丒丈丗丒丘丌, float 且丛上丕业丂丒与一)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_4.x = val_4.x - 且丛上丕业丂丒与一;
        return (float)val_4.x;
    }
    public static bool 丏丑下丝丅丆下与一(UnityEngine.Vector3 业丏丂丐丂丟丏东丘, UnityEngine.Vector3 丏万上丟丐与丌下且, UnityEngine.Vector3 七丈丟东且东丏下世, UnityEngine.Vector3 丑丈丂丈丅上下丝上, UnityEngine.Vector3 丛丈世不不上丏丄七, UnityEngine.Vector3 丛丑丏万丆世一丂丟)
    {
        var val_1;
        var val_2;
        var val_3;
        float val_4;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        var val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        val_13 = 1152921505163182080;
        val_14 = val_1;
        val_15 = 丛丈世不不上丏丄七.y;
        val_16 = 丛丈世不不上丏丄七.x;
        val_18 = val_2;
        val_17 = 丑丈丂丈丅上下丝上.z;
        val_19 = null;
        val_20 = 丑丈丂丈丅上下丝上.y;
        val_21 = val_3;
        val_22 = 丑丈丂丈丅上下丝上.x;
        val_23 = 七丈丟东且东丏下世.x;
        val_17 = val_17;
        val_22 = val_22;
        val_15 = val_15;
        val_16 = val_16;
        val_21 = val_21;
        val_14 = val_14;
        val_24 = val_17;
        if((丌且丄七上业七丒且.丁丗世万丈丒丄业丗(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 七丈丟东且东丏下世:  new UnityEngine.Vector3() {x = val_23, y = val_4, z = 七丈丟东且东丏下世.y}, 丛丈世不不上丏丄七:  new UnityEngine.Vector3() {x = val_20, y = val_17, z = 七丈丟东且东丏下世.z}, 丑丈丂丈丅上下丝上:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15}, 丛丑丏万丆世一丂丟:  new UnityEngine.Vector3())) == true)
        {
            goto label_3;
        }
        
        val_25 = null;
        if((丌且丄七上业七丒且.丁丗世万丈丒丄业丗(丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, 七丈丟东且东丏下世:  new UnityEngine.Vector3() {x = val_23, y = val_4, z = 七丈丟东且东丏下世.y}, 丛丈世不不上丏丄七:  new UnityEngine.Vector3() {x = val_20, y = val_24, z = 七丈丟东且东丏下世.z}, 丑丈丂丈丅上下丝上:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15}, 丛丑丏万丆世一丂丟:  new UnityEngine.Vector3() {z = 七丈丟东且东丏下世.z})) == false)
        {
            goto label_6;
        }
        
        label_3:
        val_26 = 1;
        return (bool)val_26;
        label_6:
        val_27 = null;
        val_18 = 丏万上丟丐与丌下且.y;
        val_24 = 丏万上丟丐与丌下且.z;
        val_23 = val_14;
        val_20 = 丏万上丟丐与丌下且.x;
        val_13 = 丌且丄七上业七丒且.丅不七丏丘丈丒且丟(丏丟丄万丅丈丝丛一:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 丆与与丘丄丙且丅丐:  new UnityEngine.Vector3() {x = val_20, y = 丏万上丟丐与丌下且.y, z = val_24}, 丒丏丐丒万丛丆一业:  new UnityEngine.Vector3() {x = val_20, y = val_24, z = val_16}, 丑丝丂丆丙丗下丈丅:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_15});
        bool val_12 = ((丌且丄七上业七丒且.丅不七丏丘丈丒且丟(丏丟丄万丅丈丝丛一:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 丆与与丘丄丙且丅丐:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, 丒丏丐丒万丛丆一业:  new UnityEngine.Vector3() {x = val_23, y = 七丈丟东且东丏下世.y, z = 七丈丟东且东丏下世.z}, 丑丝丂丆丙丗下丈丅:  new UnityEngine.Vector3() {x = val_22, y = val_16, z = val_15})) | (丌且丄七上业七丒且.丅不七丏丘丈丒且丟(丏丟丄万丅丈丝丛一:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 丆与与丘丄丙且丅丐:  new UnityEngine.Vector3() {x = 丏万上丟丐与丌下且.x, y = 丏万上丟丐与丌下且.y, z = 丏万上丟丐与丌下且.z}, 丒丏丐丒万丛丆一业:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.z, y = val_22, z = val_20}, 丑丝丂丆丙丗下丈丅:  new UnityEngine.Vector3() {x = val_24, y = val_16, z = val_15}))) | val_13;
        val_12 = val_12 | (丌且丄七上业七丒且.丅不七丏丘丈丒且丟(丏丟丄万丅丈丝丛一:  new UnityEngine.Vector3() {x = 业丏丂丐丂丟丏东丘.x, y = 业丏丂丐丂丟丏东丘.y, z = 业丏丂丐丂丟丏东丘.z}, 丆与与丘丄丙且丅丐:  new UnityEngine.Vector3() {x = val_20, y = val_18, z = val_24}, 丒丏丐丒万丛丆一业:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_23}, 丑丝丂丆丙丗下丈丅:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.y, y = val_16, z = val_15}));
        val_26 = val_12;
        return (bool)val_26;
    }
    public static bool 丁丗世万丈丒丄业丗(UnityEngine.Vector3 丅专与丒丈丗丒丘丌, UnityEngine.Vector3 七丈丟东且东丏下世, UnityEngine.Vector3 丛丈世不不上丏丄七, UnityEngine.Vector3 丑丈丂丈丅上下丝上, UnityEngine.Vector3 丛丑丏万丆世一丂丟)
    {
        float val_1;
        float val_2;
        float val_3;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丛丈世不不上丏丄七.x, y = val_1, z = 丛丈世不不上丏丄七.y}, b:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.x, y = 七丈丟东且东丏下世.y, z = 七丈丟东且东丏下世.z});
        UnityEngine.Vector3 val_6 = 丌且丄七上业七丒且.丒丝上丙丙丝丐丐万(丒丙丐一丈一三一丆:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丟丒且一专丟丙下一:  val_4.x * (-0.5f));
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.x, y = 七丈丟东且东丏下世.y, z = 七丈丟东且东丏下世.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丛丈世不不上丏丄七.z, y = val_3, z = 丑丈丂丈丅上下丝上.x}, b:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.x, y = 七丈丟东且东丏下世.y, z = 七丈丟东且东丏下世.z});
        val_8.x = val_8.x * 0.5f;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丑丈丂丈丅上下丝上.y, y = val_2, z = 丑丈丂丈丅上下丝上.z}, b:  new UnityEngine.Vector3() {x = 七丈丟东且东丏下世.x, y = 七丈丟东且东丏下世.y, z = 七丈丟东且东丏下世.z});
        UnityEngine.Vector3 val_10 = 丌且丄七上业七丒且.丈世丒丘且丕下丟丙(丙丞下丒丌丘七东丆:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 万丆丙世丌丞万与丗:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z});
        UnityEngine.Vector3 val_12 = 丌且丄七上业七丒且.丈世丒丘且丕下丟丙(丙丞下丒丌丘七东丆:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, 万丆丙世丌丞万与丗:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = 丅专与丒丈丗丒丘丌.x, y = 丅专与丒丈丗丒丘丌.y, z = 丅专与丒丈丗丒丘丌.z});
        float val_17 = 0.5f;
        val_17 = val_9.x * val_17;
        return (bool)((val_13.x <= val_8.x) ? 1 : 0) & ((val_11.x <= val_17) ? 1 : 0);
    }
    public static bool 丅不七丏丘丈丒且丟(UnityEngine.Vector3 丏丟丄万丅丈丝丛一, UnityEngine.Vector3 丆与与丘丄丙且丅丐, UnityEngine.Vector3 丒丏丐丒万丛丆一业, UnityEngine.Vector3 丑丝丂丆丙丗下丈丅)
    {
        float val_1;
        float val_2;
        float val_10;
        float val_11;
        var val_12;
        var val_13;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丆与与丘丄丙且丅丐.x, y = 丆与与丘丄丙且丅丐.y, z = 丆与与丘丄丙且丅丐.z}, b:  new UnityEngine.Vector3() {x = 丏丟丄万丅丈丝丛一.x, y = 丏丟丄万丅丈丝丛一.y, z = 丏丟丄万丅丈丝丛一.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丒丏丐丒万丛丆一业.z, y = val_2, z = 丑丝丂丆丙丗下丈丅.x}, b:  new UnityEngine.Vector3() {x = 丒丏丐丒万丛丆一业.x, y = val_1, z = 丒丏丐丒万丛丆一业.y});
        val_10 = val_4.z;
        val_11 = val_4.y;
        if((丌且丄七上业七丒且.业丛世业上与七丘丝(上一丄丞丑丐丏丕丄: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂丗一丌万世不丞与: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = 丏丟丄万丅丈丝丛一.x, y = 丏丟丄万丅丈丝丛一.y, z = 丏丟丄万丅丈丝丛一.z}, 一丛丅丈丞丌丟丞丄:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_10}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = 丒丏丐丒万丛丆一业.x, y = 丒丏丐丒万丛丆一业.y, z = val_4.x}, 丂丛丂丝世万丏东丘:  new UnityEngine.Vector3() {x = val_4.z, y = val_2, z = 丆与与丘丄丙且丅丐.x})) != false)
        {
                val_12 = null;
            val_11 = 0f;
            val_10 = 0f;
            var val_9 = (((丌且丄七上业七丒且.丞丕丗东与一业七丌(业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = 丏丟丄万丅丈丝丛一.x, y = 丏丟丄万丅丈丝丛一.y, z = 丏丟丄万丅丈丝丛一.z}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = 丆与与丘丄丙且丅丐.x, y = 丆与与丘丄丙且丅丐.y, z = 丆与与丘丄丙且丅丐.z}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = val_4.x})) | (丌且丄七上业七丒且.丞丕丗东与一业七丌(业丏丂丐丂丟丏东丘:  new UnityEngine.Vector3() {x = 丒丏丐丒万丛丆一业.x, y = val_1, z = 丒丏丐丒万丛丆一业.y}, 丏万上丟丐与丌下且:  new UnityEngine.Vector3() {x = 丒丏丐丒万丛丆一业.z, y = val_2, z = 丑丝丂丆丙丗下丈丅.x}, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_4.x}))) == 0) ? 1 : 0;
            return (bool)val_13;
        }
        
        val_13 = 0;
        return (bool)val_13;
    }
    public static bool 东丟业丏不丅丂三专(out UnityEngine.Vector3 丒丙丐一丈一三一丆, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, int 世一丝丐三丑丟万万)
    {
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        System.Single[] val_37;
        var val_38;
        System.Single[] val_39;
        float val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        float val_46;
        float val_47;
        var val_48;
        val_27 = 业丒丝丗与丐丛丟丏.y;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_28 = val_1.x;
        val_29 = val_1.y;
        val_30 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        丒丙丐一丈一三一丆.x = val_2.x;
        丒丙丐一丈一三一丆.y = val_2.y;
        丒丙丐一丈一三一丆.z = val_2.z;
        val_33 = null;
        val_33 = null;
        if(丌且丄七上业七丒且.七丛丒丟丁且丘下业 == null)
        {
                UnityEngine.Vector3[] val_4 = new UnityEngine.Vector3[0];
            val_34 = null;
            val_34 = null;
            丌且丄七上业七丒且.七丛丒丟丁且丘下业 = val_4;
            val_33 = null;
            丌且丄七上业七丒且.东下七且与丕丛丕丏 = new float[0];
        }
        
        val_35 = 1;
        goto label_8;
        label_20:
        val_36 = mem[1152921536928750712];
        var val_6 = W25 + 1;
        if(val_6 >= val_36)
        {
                val_36 = mem[1152921536928750712];
        }
        
        UnityEngine.Vector3 val_36 = val_4[1];
        val_6 = val_6 - 1;
        var val_7 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + ((long)(long)(int)(W25) * 12);
        mem2[0] = val_36;
        mem2[0] = val_4[2];
        mem2[0] = val_4[2];
        val_37 = 丌且丄七上业七丒且.东下七且与丕丛丕丏;
        val_38 = mem[1152921536928754808];
        var val_8 = val_6 + 1;
        if(val_8 >= val_38)
        {
                val_38 = mem[1152921536928754808];
        }
        
        var val_9 = val_8 - 1;
        System.Single[] val_10 = val_37 + (((long)(int)(W25)) << 2);
        mem2[0] = val_36;
        val_33 = null;
        val_35 = 2;
        label_8:
        val_33 = null;
        val_39 = val_35 - 1;
        if(丌且丄七上业七丒且.七丛丒丟丁且丘下业 == null)
        {
                val_33 = null;
        }
        
        var val_39 = mem[1152921536928750712];
        val_39 = val_39 - 1;
        if(val_39 < val_39)
        {
            goto label_20;
        }
        
        val_33 = null;
        var val_40 = -4294967296;
        val_40 = val_40 + ((mem[1152921536928750712]) << 32);
        var val_41 = 12;
        val_41 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + ((val_40 >> 32) * val_41);
        mem2[0] = 业丒丝丗与丐丛丟丏.x;
        mem2[0] = val_27;
        mem2[0] = 业丒丝丗与丐丛丟丏.z;
        if(丌且丄七上业七丒且.东下七且与丕丛丕丏 != null)
        {
                val_41 = UnityEngine.Time.time;
        }
        else
        {
                val_41 = UnityEngine.Time.time;
        }
        
        var val_42 = -4294967296;
        val_42 = val_42 + ((mem[1152921536928754808]) << 32);
        var val_14 = val_42 >> 32;
        System.Single[] val_15 = 丌且丄七上业七丒且.东下七且与丕丛丕丏 + ((((-4294967296 + (mem[1152921536928754808]) << 32) >> 32)) << 2);
        mem2[0] = val_41;
        val_42 = null;
        int val_43 = 丌且丄七上业七丒且.且丁一世丏万下丒丏;
        val_43 = val_43 + 1;
        丌且丄七上业七丒且.且丁一世丏万下丒丏 = val_43;
        if(丌且丄七上业七丒且.且丁一世丏万下丒丏 < ((世一丝丐三丑丟万万 > 3) ? 世一丝丐三丑丟万万 : 3))
        {
                return false;
        }
        
        val_43 = 2;
        goto label_29;
        label_61:
        var val_17 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + (1 * 12);
        var val_18 = (val_39 + 1) - 1;
        val_39 = (long)val_39;
        var val_19 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + (val_39 * 12);
        val_44 = mem[((long)(int)((val_35 - 1)) * 12) + val_4 + 32];
        val_44 = ((long)(int)((val_35 - 1)) * 12) + val_4 + 32;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (1 * 12) + val_4 + 32, y = (1 * 12) + val_4 + 32 + 4, z = (1 * 12) + val_4 + 40}, b:  new UnityEngine.Vector3() {x = val_44, y = ((long)(int)((val_35 - 1)) * 12) + val_4 + 32 + 4, z = ((long)(int)((val_35 - 1)) * 12) + val_4 + 40});
        val_27 = val_20.y;
        val_41 = val_20.z;
        val_18 = val_18 + 1;
        float val_44 = UnityEngine.Vector3.__il2cppRuntimeField_127 + 32;
        val_37 = 丌且丄七上业七丒且.东下七且与丕丛丕丏;
        val_18 = val_18 - 1;
        System.Single[] val_21 = val_37 + (((long)(int)((val_35 - 1))) << 2);
        val_44 = val_44 - (mem[(val_5 + ((long)(int)((val_35 - 1))) << 2) + 32]);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_27, z = val_41}, d:  val_44);
        val_45 = null;
        val_27 = val_22.x;
        val_45 = null;
        val_18 = val_18 + 2;
        val_46 = val_28;
        var val_23 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + (2 * 12);
        val_18 = val_18 - 1;
        var val_24 = 丌且丄七上业七丒且.七丛丒丟丁且丘下业 + (1 * 12);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (2 * 12) + val_4 + 32, y = (2 * 12) + val_4 + 32 + 4, z = (2 * 12) + val_4 + 40}, b:  new UnityEngine.Vector3() {x = (1 * 12) + val_4 + 32, y = (1 * 12) + val_4 + 32 + 4, z = (1 * 12) + val_4 + 40});
        val_44 = val_25.x;
        val_41 = val_25.z;
        val_37 = 丌且丄七上业七丒且.东下七且与丕丛丕丏;
        val_18 = val_18 + 1;
        float val_45 = (2 * 12) + val_4 + 32;
        val_39 = 丌且丄七上业七丒且.东下七且与丕丛丕丏;
        var val_26 = val_18 - 1;
        val_45 = val_45 - (mem[1152921536928754808] + 32);
        if(val_45 == 0f)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_44, y = val_25.y, z = val_41}, d:  val_45);
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_27, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_46, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_42 = null;
        val_28 = val_29.x;
        val_47 = val_29.y;
        val_30 = val_29.z;
        val_43 = 3;
        label_29:
        val_42 = null;
        if(丌且丄七上业七丒且.七丛丒丟丁且丘下业 == null)
        {
                val_42 = null;
        }
        
        var val_46 = mem[1152921536928750712];
        val_46 = val_46 - 2;
        if((val_43 - 2) < val_46)
        {
            goto label_61;
        }
        
        val_48 = 1152921536928746624;
        var val_47 = mem[1152921536928750712];
        val_47 = val_47 - 2;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_28, y = val_47, z = val_30}, d:  (float)val_47);
        var val_48 = -4294967296;
        val_48 = val_48 + ((mem[1152921536928754808]) << 32);
        var val_32 = val_48 >> 32;
        System.Single[] val_33 = 丌且丄七上业七丒且.东下七且与丕丛丕丏 + ((((-4294967296 + (mem[1152921536928754808]) << 32) >> 32)) << 2);
        UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  (mem[(val_5 + (((-4294967296 + (mem[1152921536928754808]) << 32) >> 32)) << 2) + 32]) - mem[1152921536928754816]);
        丒丙丐一丈一三一丆.x = val_35.x;
        丒丙丐一丈一三一丆.y = val_35.y;
        丒丙丐一丈一三一丆.z = val_35.z;
        return false;
    }
    public static bool 丆七丆与上丄与不丗(out UnityEngine.Vector3 丒丙丐一丈一三一丆, UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, int 世一丝丐三丑丟万万)
    {
        float val_34;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        UnityEngine.Quaternion[] val_46;
        var val_47;
        var val_48;
        float val_50;
        var val_51;
        var val_52;
        var val_53;
        float val_54;
        float val_55;
        var val_56;
        val_34 = 七丅丗丆丒丌丑丝不.z;
        val_35 = 七丅丗丆丒丌丑丝不.x;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_36 = val_1.x;
        val_37 = val_1.y;
        val_38 = val_1.z;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        丒丙丐一丈一三一丆.x = val_2.x;
        丒丙丐一丈一三一丆.y = val_2.y;
        丒丙丐一丈一三一丆.z = val_2.z;
        val_41 = null;
        val_41 = null;
        if(丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 == null)
        {
                UnityEngine.Quaternion[] val_4 = new UnityEngine.Quaternion[0];
            val_42 = null;
            val_42 = null;
            丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 = val_4;
            val_41 = null;
            丌且丄七上业七丒且.丄丄一丏丙丒万世丝 = new float[0];
        }
        
        val_43 = 1;
        goto label_8;
        label_20:
        val_44 = mem[1152921536928887256];
        val_45 = 1;
        if(val_4[1] >= val_44)
        {
                val_44 = mem[1152921536928887256];
        }
        
        val_46 = val_4[1] - 1;
        UnityEngine.Quaternion[] val_6 = 丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 + (-32603169792);
        mem2[0] = 丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 32;
        mem2[0] = 丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 32 + 4;
        mem2[0] = 丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40;
        mem2[0] = 丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4;
        val_47 = mem[1152921536928891352];
        if(val_46[1] >= val_47)
        {
                val_47 = mem[1152921536928891352];
        }
        
        UnityEngine.Quaternion[] val_7 = val_46[1] - 1;
        System.Single[] val_8 = 丌且丄七上业七丒且.丄丄一丏丙丒万世丝 + (-8150792448);
        mem2[0] = 丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 32;
        val_41 = null;
        val_43 = 2;
        label_8:
        val_41 = null;
        val_48 = val_43 - 1;
        if(丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 == null)
        {
                val_41 = null;
        }
        
        var val_34 = mem[1152921536928887256];
        val_34 = val_34 - 1;
        if(val_48 < val_34)
        {
            goto label_20;
        }
        
        val_41 = null;
        var val_35 = -4294967296;
        val_35 = val_35 + ((mem[1152921536928887256]) << 32);
        var val_9 = val_35 >> 32;
        UnityEngine.Quaternion[] val_10 = 丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 + ((((-4294967296 + (mem[1152921536928887256]) << 32) >> 32)) << 4);
        mem2[0] = val_35;
        mem2[0] = 七丅丗丆丒丌丑丝不.y;
        mem2[0] = val_34;
        mem2[0] = 七丅丗丆丒丌丑丝不.w;
        if(丌且丄七上业七丒且.丄丄一丏丙丒万世丝 != null)
        {
                val_50 = UnityEngine.Time.time;
        }
        else
        {
                val_50 = UnityEngine.Time.time;
        }
        
        var val_36 = -4294967296;
        val_36 = val_36 + ((mem[1152921536928891352]) << 32);
        val_51 = val_36 >> 32;
        System.Single[] val_13 = 丌且丄七上业七丒且.丄丄一丏丙丒万世丝 + ((((-4294967296 + (mem[1152921536928891352]) << 32) >> 32)) << 2);
        mem2[0] = val_50;
        val_52 = null;
        int val_37 = 丌且丄七上业七丒且.与丐下丂丒丌丁丅丆;
        val_37 = val_37 + 1;
        丌且丄七上业七丒且.与丐下丂丒丌丁丅丆 = val_37;
        if(丌且丄七上业七丒且.与丐下丂丒丌丁丅丆 < ((世一丝丐三丑丟万万 > 3) ? 世一丝丐三丑丟万万 : 3))
        {
            goto label_51;
        }
        
        val_53 = 2;
        goto label_29;
        label_59:
        val_48 = 1;
        val_46 = 丌且丄七上业七丒且.丘丆世丈丆丘丆与丘;
        UnityEngine.Quaternion val_17 = 丌且丄七上业七丒且.上三丁丁专丅丑丂丅(业与丞不丒丞丕丏丗:  new UnityEngine.Quaternion() {x = 0f, y = 2.417852E+24f, z = 7.442759E-40f, w = 0f}, 丑万丞丟丘不丛丒丙:  new UnityEngine.Quaternion() {x = mem[(val_4 + ((long)(int)(丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 32], y = mem[(val_4 + ((long)(int)(丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 32 + 4], z = mem[(val_4 + ((long)(int)(丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 40], w = mem[(val_4 + ((long)(int)(丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 4) + 40 + 4]});
        val_50 = val_17.x;
        val_34 = val_17.z;
        val_54 = 0f - (mem[(val_5 + ((long)(int)(丌且丄七上业七丒且.__il2cppRuntimeField_cctor_finished + 40 + 4)) << 2) + 32]);
        if(val_54 == 0f)
        {
            goto label_51;
        }
        
        UnityEngine.Vector3 val_20 = 丌且丄七上业七丒且.丙丁与丏丅丝不丄专(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_50, y = val_17.y, z = val_34, w = val_17.w}, 丑丗丘与丈不七东丛:  val_54);
        val_34 = val_20.y;
        UnityEngine.Quaternion val_23 = 丌且丄七上业七丒且.上三丁丁专丅丑丂丅(业与丞不丒丞丕丏丗:  new UnityEngine.Quaternion() {x = 0f, y = 2.417852E+24f, z = 7.442759E-40f, w = 0f}, 丑万丞丟丘不丛丒丙:  new UnityEngine.Quaternion() {x = mem[1152921536928887256] + 32, y = mem[1152921536928887256] + 32 + 4, z = mem[1152921536928887256] + 40, w = mem[1152921536928887256] + 40 + 4});
        val_35 = val_23.x;
        val_50 = val_23.z;
        val_54 = 0f - (mem[1152921536928891352] + 32);
        if(val_54 == 0f)
        {
            goto label_51;
        }
        
        UnityEngine.Vector3 val_25 = 丌且丄七上业七丒且.丙丁与丏丅丝不丄专(七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_35, y = val_23.y, z = val_50, w = val_23.w}, 丑丗丘与丈不七东丛:  val_54);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_34, z = val_20.z});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_38}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        val_52 = null;
        val_36 = val_27.x;
        val_37 = val_27.y;
        val_55 = val_27.z;
        val_53 = 3;
        label_29:
        val_52 = null;
        if(丌且丄七上业七丒且.丘丆世丈丆丘丆与丘 == null)
        {
                val_52 = null;
        }
        
        var val_38 = mem[1152921536928887256];
        val_38 = val_38 - 2;
        if((val_53 - 2) < val_38)
        {
            goto label_59;
        }
        
        val_52 = null;
        var val_39 = mem[1152921536928887256];
        val_39 = val_39 - 2;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_55}, d:  (float)val_39);
        val_50 = val_29.x;
        val_54 = val_29.z;
        var val_40 = -4294967296;
        val_40 = val_40 + ((mem[1152921536928891352]) << 32);
        var val_30 = val_40 >> 32;
        System.Single[] val_31 = 丌且丄七上业七丒且.丄丄一丏丙丒万世丝 + ((((-4294967296 + (mem[1152921536928891352]) << 32) >> 32)) << 2);
        val_51 = 1152921536928883152;
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_50, y = val_29.y, z = val_54}, d:  (mem[(val_5 + (((-4294967296 + (mem[1152921536928891352]) << 32) >> 32)) << 2) + 32]) - mem[1152921536928891360]);
        val_56 = 1;
        丒丙丐一丈一三一丆.x = val_33.x;
        丒丙丐一丈一三一丆.y = val_33.y;
        丒丙丐一丈一三一丆.z = val_33.z;
        return (bool)val_56;
        label_51:
        val_56 = 0;
        return (bool)val_56;
    }
    public static float 七丞世丒丂世三业上(float 三丟东丕丄丄下下丑, float 上且丒丂且业丑丘业, float 丐丅丙上世丕丕丂丁)
    {
        上且丒丂且业丑丘业 = 丐丅丙上世丕丕丂丁 / 上且丒丂且业丑丘业;
        三丟东丕丄丄下下丑 = 上且丒丂且业丑丘业 * 三丟东丕丄丄下下丑;
        return (float)三丟东丕丄丄下下丑;
    }
    public static float 丁一与专丟世上七丂(float 三丟东丕丄丄下下丑, float 丈丐七七丈丝三丗丕, float 丐丛下丂世丆七上东, float 上且丒丂且业丑丘业, float 丐丅丙上世丕丕丂丁)
    {
        上且丒丂且业丑丘业 = 上且丒丂且业丑丘业 - 丈丐七七丈丝三丗丕;
        丐丅丙上世丕丕丂丁 = 丐丅丙上世丕丕丂丁 - 丐丛下丂世丆七上东;
        上且丒丂且业丑丘业 = 丐丅丙上世丕丕丂丁 / 上且丒丂且业丑丘业;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 - 丈丐七七丈丝三丗丕;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 * 上且丒丂且业丑丘业;
        三丟东丕丄丄下下丑 = 三丟东丕丄丄下下丑 + 丐丛下丂世丆七上东;
        return (float)三丟东丕丄丄下下丑;
    }
    private static UnityEngine.Vector3 丙丁与丏丅丝不丄专(UnityEngine.Quaternion 七丅丗丆丒丌丑丝不, float 丑丗丘与丈不七东丛)
    {
        float val_1 = 七丅丗丆丒丌丑丝不.x + (-360f);
        七丅丗丆丒丌丑丝不.x = val_1 + (-360f);
        七丅丗丆丒丌丑丝不.z = (七丅丗丆丒丌丑丝不.z > 180f) ? (七丅丗丆丒丌丑丝不.z + (-360f)) : 七丅丗丆丒丌丑丝不.z;
        float val_5 = ((七丅丗丆丒丌丑丝不.x > 180f) ? (val_1) : 七丅丗丆丒丌丑丝不.x) / 丑丗丘与丈不七东丛;
        float val_6 = ((val_1 > 180f) ? (七丅丗丆丒丌丑丝不.x) : (val_1)) / 丑丗丘与丈不七东丛;
        七丅丗丆丒丌丑丝不.z = 七丅丗丆丒丌丑丝不.z / 丑丗丘与丈不七东丛;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public 丌且丄七上业七丒且()
    {
    
    }
    private static 丌且丄七上业七丒且()
    {
    
    }

}
