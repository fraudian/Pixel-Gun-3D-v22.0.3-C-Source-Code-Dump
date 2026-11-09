using UnityEngine;
public class 丗万万上丝丏专丏丏
{
    // Fields
    private static int 丏丗丏三丕业丝丝丙;
    private static UnityEngine.Mesh 丑与丗丛丝丈丙丆丌;
    private static float 丄丐不专丗丂丌丗丂;
    private static System.Collections.Generic.List<int> 万世专三丁三东丌三;
    private static bool 且丙与丏下丅丐世丑;
    
    // Methods
    private static int 丐上丒丟丂丕丛上丑(int 三丟东丕丄丄下下丑, int 丒丒丄丁且丄丆丂丌)
    {
        null = null;
        return (int)三丟东丕丄丄下下丑 + (丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙 * 丒丒丄丁且丄丆丂丌);
    }
    public static void 与丞丙上业丛世丟上(UnityEngine.Mesh 三丞东丄丅丄丆丕丐, int 丟东丌七丈丄不丑东, float 不丗丘七丌丁丗丆丝, bool 上丏丑下丒万丏丙丝 = False)
    {
        bool val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = 上丏丑下丒万丏丙丝;
        val_6 = null;
        val_6 = null;
        丗万万上丝丏专丏丏.丄丐不专丗丂丌丗丂 = 不丗丘七丌丁丗丆丝;
        丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 = val_5;
        丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙 = 丟东丌七丈丄不丑东;
        丗万万上丝丏专丏丏.万世专三丁三东丌三 = new System.Collections.Generic.List<System.Int32>();
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌 = 三丞东丄丅丄丆丕丐;
        val_7 = null;
        val_8 = 0;
        int val_4 = 0;
        goto label_4;
        label_17:
        val_5 = 0;
        goto label_5;
        label_14:
        丗万万上丝丏专丏丏.丁丐丕丄东上丈丞万(丐业丕东丈丑丐丝丞:  丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.vertices, 丝万与丟丆丅七丟丄:  0, 一世丘丛丕丗丗丄丟:  0, 丄三丁丈三丞丅丟东: ref  val_4, 丛且不专丄丆丕丘丞: ref  val_4);
        if((0 > val_8) && (0 > val_5))
        {
                丗万万上丝丏专丏丏.丗丐丝丕丕丈丒丞下(丝万与丟丆丅七丟丄:  0, 一世丘丛丕丗丗丄丟:  0, 丄七业丟与丆丅丒丑:  0, 丆东丈不丝丂业与丒:  0);
        }
        
        val_7 = null;
        val_5 = 1;
        label_5:
        val_7 = null;
        if(val_5 < 丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙)
        {
            goto label_14;
        }
        
        val_8 = 1;
        label_4:
        val_7 = null;
        if(val_8 < 丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙)
        {
            goto label_17;
        }
        
        丗万万上丝丏专丏丏.丆世丙丛七丞丂丌专();
    }
    private static void 丁丐丕丄东上丈丞万(UnityEngine.Vector3[] 丐业丕东丈丑丐丝丞, int 丝万与丟丆丅七丟丄, int 一世丘丛丕丗丗丄丟, ref int 丄三丁丈三丞丅丟东, ref int 丛且不专丄丆丕丘丞)
    {
        var val_22;
        int val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        float val_28;
        var val_29;
        val_22 = null;
        val_22 = null;
        val_23 = 丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙;
        丄三丁丈三丞丅丟东 = 丝万与丟丆丅七丟丄;
        丛且不专丄丆丕丘丞 = 一世丘丛丕丗丗丄丟;
        if()
        {
                return;
        }
        
        if()
        {
                return;
        }
        
        val_23 = (val_23 - (UnityEngine.Mathf.Max(a:  丝万与丟丆丅七丟丄, b:  一世丘丛丕丗丗丄丟))) - 1;
        if(val_23 < 1)
        {
                return;
        }
        
        var val_6 = 丐业丕东丈丑丐丝丞 + (((long)丗万万上丝丏专丏丏.丐上丒丟丂丕丛上丑(三丟东丕丄丄下下丑:  丝万与丟丆丅七丟丄, 丒丒丄丁且丄丆丂丌:  一世丘丛丕丗丗丄丟)) * 12);
        System.Collections.Generic.List<System.Single> val_7 = new System.Collections.Generic.List<System.Single>();
        var val_22 = 0;
        do
        {
            do
        {
            var val_11 = 丐业丕东丈丑丐丝丞 + (((long)丗万万上丝丏专丏丏.丐上丒丟丂丕丛上丑(三丟东丕丄丄下下丑:  val_22 + 丝万与丟丆丅七丟丄, 丒丒丄丁且丄丆丂丌:  一世丘丛丕丗丗丄丟 + 0)) * 12);
            val_24 = mem[((long)(int)(val_10) * 12) + 丐业丕东丈丑丐丝丞 + 36];
            val_24 = ((long)(int)(val_10) * 12) + 丐业丕东丈丑丐丝丞 + 36;
            val_7.Add(item:  val_24);
            val_25 = 0 + 1;
        }
        while(val_25 != 2);
        
            val_22 = val_22 + 1;
        }
        while(val_22 != 2);
        
        val_26 = 0;
        label_25:
        if(val_26 >= val_7.Count)
        {
            goto label_19;
        }
        
        float val_13 = val_7.Item[0];
        val_13 = (((long)(int)(val_5) * 12) + 丐业丕东丈丑丐丝丞 + 36) - val_13;
        val_24 = System.Math.Abs(val_13);
        val_27 = null;
        val_27 = null;
        val_26 = val_26 + 1;
        if(val_24 <= 丗万万上丝丏专丏丏.丄丐不专丗丂丌丗丂)
        {
            goto label_25;
        }
        
        丄三丁丈三丞丅丟东 = 丝万与丟丆丅七丟丄;
        丛且不专丄丆丕丘丞 = 一世丘丛丕丗丗丄丟;
        return;
        label_19:
        if(val_23 < 1)
        {
                return;
        }
        
        label_46:
        val_7.Clear();
        var val_24 = 0;
        do
        {
            var val_23 = 0;
            do
        {
            var val_17 = 丐业丕东丈丑丐丝丞 + (((long)丗万万上丝丏专丏丏.丐上丒丟丂丕丛上丑(三丟东丕丄丄下下丑:  val_24 + 丝万与丟丆丅七丟丄, 丒丒丄丁且丄丆丂丌:  一世丘丛丕丗丗丄丟 + val_23)) * 12);
            val_7.Add(item:  ((long)(int)(val_16) * 12) + 丐业丕东丈丑丐丝丞 + 36);
            val_23 = val_23 + 1;
        }
        while(val_23 != val_23);
        
            val_24 = val_24 + 1;
        }
        while(val_24 != val_23);
        
        val_25 = 1152921526036591968;
        val_26 = 0;
        val_28 = 0f;
        goto label_36;
        label_40:
        val_28 = val_28 + val_7.Item[0];
        val_26 = 1;
        label_36:
        if(val_7 == null)
        {
            goto label_37;
        }
        
        if(val_26 < val_7.Count)
        {
            goto label_40;
        }
        
        goto label_39;
        label_37:
        if(val_26 < val_7.Count)
        {
            goto label_40;
        }
        
        label_39:
        float val_25 = (float)val_7.Count;
        val_28 = val_28 / val_25;
        val_25 = (((long)(int)(val_5) * 12) + 丐业丕东丈丑丐丝丞 + 36) - val_28;
        val_24 = System.Math.Abs(val_25);
        val_29 = null;
        val_29 = null;
        if(val_24 <= 丗万万上丝丏专丏丏.丄丐不专丗丂丌丗丂)
        {
            goto label_45;
        }
        
        val_23 = val_23 - 1;
        if(val_23 >= 1)
        {
            goto label_46;
        }
        
        return;
        label_45:
        int val_27 = 一世丘丛丕丗丗丄丟 - 1;
        int val_26 = 丝万与丟丆丅七丟丄 - 1;
        val_26 = val_26 + val_23;
        丄三丁丈三丞丅丟东 = val_26;
        val_27 = val_27 + val_23;
        丛且不专丄丆丕丘丞 = val_27;
    }
    private static void 丗丐丝丕丕丈丒丞下(int 丝万与丟丆丅七丟丄, int 一世丘丛丕丗丗丄丟, int 丄七业丟与丆丅丒丑, int 丆东丈不丝丂业与丒)
    {
        int val_9;
        var val_10;
        var val_11;
        int val_12;
        var val_13;
        System.Collections.Generic.List<System.Int32> val_14;
        var val_15;
        var val_16;
        UnityEngine.Vector2 val_18;
        UnityEngine.Vector2 val_19;
        UnityEngine.Vector2[] val_20;
        var val_21;
        val_9 = 丝万与丟丆丅七丟丄;
        val_10 = null;
        val_10 = null;
        UnityEngine.Vector3[] val_1 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.vertices;
        UnityEngine.Vector2[] val_2 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv;
        val_11 = 1152921516995557280;
        val_12 = 丗万万上丝丏专丏丏.丐上丒丟丂丕丛上丑(三丟东丕丄丄下下丑:  val_9, 丒丒丄丁且丄丆丂丌:  一世丘丛丕丗丗丄丟);
        var val_9 = 0;
        label_12:
        val_13 = null;
        val_13 = null;
        val_14 = 丗万万上丝丏专丏丏.万世专三丁三东丌三;
        if(val_9 >= val_14.Count)
        {
            goto label_8;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = 丗万万上丝丏专丏丏.万世专三丁三东丌三;
        val_9 = val_9 + 1;
        if(val_12 != val_14.Item[0])
        {
            goto label_12;
        }
        
        return;
        label_8:
        val_11 = (long)val_12;
        var val_10 = 12;
        val_10 = val_1 + (val_11 * val_10);
        val_16 = null;
        val_16 = null;
        val_18 = 0f;
        val_19 = 0f;
        if(丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 != true)
        {
                val_19 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv[val_11];
            val_18 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv[val_11];
        }
        
        if(val_9 < 丄七业丟与丆丅丒丑)
        {
                val_11 = 1152921516995548064;
            do
        {
            val_12 = 一世丘丛丕丗丗丄丟;
            if(val_12 < 丆东丈不丝丂业与丒)
        {
                do
        {
            int val_7 = 丗万万上丝丏专丏丏.丐上丒丟丂丕丛上丑(三丟东丕丄丄下下丑:  val_9, 丒丒丄丁且丄丆丂丌:  val_12);
            丗万万上丝丏专丏丏.万世专三丁三东丌三.Add(item:  val_7);
            val_14 = (long)val_7;
            var val_8 = val_1 + (val_14 * 12);
            mem2[0] = ((long)(int)(val_3) * 12) + val_1 + 32;
            mem2[0] = ((long)(int)(val_3) * 12) + val_1 + 32 + 4;
            mem2[0] = ((long)(int)(val_3) * 12) + val_1 + 40;
            if(丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 != true)
        {
                val_20 = val_2;
            if(val_20 == 0)
        {
                val_20 = val_2;
        }
        
            UnityEngine.Vector2[] val_11 = val_2;
            val_11 = val_11 + (((long)(int)(val_7)) << 3);
            mem2[0] = val_19;
            mem2[0] = val_18;
        }
        
            val_12 = val_12 + 1;
        }
        while(丆东丈不丝丂业与丒 != val_12);
        
        }
        
            val_9 = val_9 + 1;
        }
        while(val_9 != 丄七业丟与丆丅丒丑);
        
        }
        
        val_21 = null;
        val_21 = null;
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.vertices = val_1;
        if(丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 != false)
        {
                return;
        }
        
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv = val_2;
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.RecalculateNormals();
    }
    private static void 丆世丙丛七丞丂丌专()
    {
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        UnityEngine.Vector3[] val_32;
        UnityEngine.Vector2[] val_33;
        int val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<UnityEngine.Vector3> val_2 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<UnityEngine.Vector2> val_3 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        val_24 = null;
        val_24 = null;
        System.Int32[] val_5 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.triangles;
        UnityEngine.Vector3[] val_6 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.vertices;
        UnityEngine.Vector3[] val_7 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.normals;
        UnityEngine.Vector2[] val_8 = 丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv;
        System.Collections.Generic.List<System.Int32> val_9 = new System.Collections.Generic.List<System.Int32>();
        val_25 = 1152921516995557280;
        val_26 = 1152921516995548064;
        val_27 = 0;
        goto label_7;
        label_35:
        var val_29 = 0;
        label_11:
        if(val_29 >= val_9.Count)
        {
            goto label_9;
        }
        
        val_29 = val_29 + 1;
        if(val_27 != val_9.Item[0])
        {
            goto label_11;
        }
        
        goto label_12;
        label_9:
        var val_12 = val_6 + (0 * 12);
        val_28 = mem[(0 * 12) + val_6 + 32];
        val_28 = (0 * 12) + val_6 + 32;
        val_29 = mem[(0 * 12) + val_6 + 32 + 4];
        val_29 = (0 * 12) + val_6 + 32 + 4;
        val_30 = mem[(0 * 12) + val_6 + 32 + 8];
        val_30 = (0 * 12) + val_6 + 32 + 8;
        val_1.Add(item:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
        val_31 = null;
        val_31 = null;
        if(丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 != true)
        {
                val_32 = val_7;
            if(val_32 == 0)
        {
                val_32 = val_7;
        }
        
            if(val_27 >= (val_7 + 24))
        {
                val_32 = val_7;
        }
        
            var val_30 = 12;
            val_30 = val_32 + (0 * val_30);
            val_29 = mem[(0 * 12) + val_7 + 40];
            val_29 = (0 * 12) + val_7 + 40;
            val_2.Add(item:  new UnityEngine.Vector3() {x = (0 * 12) + val_7 + 32, y = (0 * 12) + val_7 + 32 + 4, z = val_29});
            val_33 = val_8;
            if(val_33 == 0)
        {
                val_33 = val_8;
        }
        
            if(val_27 >= (val_8 + 24))
        {
                val_33 = val_8;
        }
        
            UnityEngine.Vector2[] val_13 = val_33 + 0;
            val_28 = mem[(val_8 + 0) + 32];
            val_28 = (val_8 + 0) + 32;
            val_30 = mem[(val_8 + 0) + 32 + 4];
            val_30 = (val_8 + 0) + 32 + 4;
            val_3.Add(item:  new UnityEngine.Vector2() {x = val_28, y = val_30});
        }
        
        val_34 = val_6.Length;
        if(val_34 >= 1)
        {
                do
        {
            if(0 >= val_34)
        {
                val_34 = val_6.Length;
        }
        
            var val_31 = 12;
            val_31 = val_6 + (0 * val_31);
            val_28 = mem[(0 * 12) + val_6 + 32];
            val_28 = (0 * 12) + val_6 + 32;
            val_29 = mem[(0 * 12) + val_6 + 40];
            val_29 = (0 * 12) + val_6 + 40;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_28, y = (0 * 12) + val_6 + 32 + 4, z = val_29}, rhs:  new UnityEngine.Vector3() {x = (0 * 12) + val_6 + 32, y = (0 * 12) + val_6 + 32 + 4, z = (0 * 12) + val_6 + 32 + 8})) != false)
        {
                val_9.Add(item:  0);
            val_4.Add(key:  0, value:  1);
        }
        
        }
        while((0 + 1) < val_6.Length);
        
        }
        
        val_26 = val_26;
        label_12:
        val_27 = 1;
        label_7:
        if(val_27 < val_6.Length)
        {
            goto label_35;
        }
        
        val_35 = 0;
        goto label_36;
        label_41:
        System.Int32[] val_16 = val_5 + 0;
        val_35 = 1;
        mem2[0] = val_4.Item[(val_5 + 0) + 32];
        label_36:
        if(val_35 < (val_5 + 24))
        {
            goto label_41;
        }
        
        System.Collections.Generic.List<System.Int32> val_18 = new System.Collections.Generic.List<System.Int32>();
        val_36 = mem[val_5 + 24];
        val_36 = val_5 + 24;
        if(val_36 < 1)
        {
            goto label_42;
        }
        
        label_51:
        long val_32 = 0;
        if(0 >= val_36)
        {
                val_36 = mem[val_5 + 24];
            val_36 = val_5 + 24;
        }
        
        System.Int32[] val_19 = val_5 + 0;
        var val_20 = val_32 + 1;
        if(val_20 >= val_36)
        {
                val_36 = mem[val_5 + 24];
            val_36 = val_5 + 24;
        }
        
        System.Int32[] val_21 = val_5 + (((long)(int)((0 + 1))) << 2);
        var val_22 = val_32 + 2;
        val_32 = (long)val_20 + 1;
        System.Int32[] val_23 = val_5 + (((long)(int)((0 + 2))) << 2);
        val_25 = mem[(val_5 + ((long)(int)((0 + 2))) << 2) + 32];
        val_25 = (val_5 + ((long)(int)((0 + 2))) << 2) + 32;
        if((((val_5 + ((long)(int)((0 + 1))) << 2) + 32) == val_25) && (((val_5 + 0) + 32) == ((val_5 + ((long)(int)((0 + 1))) << 2) + 32)))
        {
                if(((val_5 + 0) + 32) == val_25)
        {
            goto label_48;
        }
        
        }
        
        if(val_18 != null)
        {
                val_18.Add(item:  (val_5 + 0) + 32);
            val_18.Add(item:  (val_5 + ((long)(int)((0 + 1))) << 2) + 32);
        }
        else
        {
                val_18.Add(item:  (val_5 + 0) + 32);
            val_18.Add(item:  (val_5 + ((long)(int)((0 + 1))) << 2) + 32);
        }
        
        val_18.Add(item:  val_25);
        label_48:
        if((val_32 + 1) < (val_5 + 24))
        {
            goto label_51;
        }
        
        label_42:
        val_37 = null;
        val_37 = null;
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.Clear();
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.vertices = val_1.ToArray();
        val_38 = null;
        if(丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 != true)
        {
                丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.uv = val_3.ToArray();
            丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.normals = val_2.ToArray();
            val_38 = null;
        }
        
        val_38 = null;
        丗万万上丝丏专丏丏.丑与丗丛丝丈丙丆丌.SetTriangles(triangles:  val_18.ToArray(), submesh:  0);
    }
    public 丗万万上丝丏专丏丏()
    {
    
    }
    private static 丗万万上丝丏专丏丏()
    {
        丗万万上丝丏专丏丏.丏丗丏三丕业丝丝丙 = 51;
        丗万万上丝丏专丏丏.丄丐不专丗丂丌丗丂 = 0f;
        丗万万上丝丏专丏丏.且丙与丏下丅丐世丑 = false;
    }

}
