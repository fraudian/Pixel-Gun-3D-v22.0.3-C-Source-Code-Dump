using UnityEngine;
public class 丁丒丐丂万三丌万业
{
    // Methods
    public static void Destroy(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                if((万且万且丑丗且丌丆 != null) && (null == null))
        {
                万且万且丑丗且丌丆.transform.parent = 0;
        }
        
            UnityEngine.Object.Destroy(obj:  万且万且丑丗且丌丆);
            return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  万且万且丑丗且丌丆);
    }
    public static void 丟丘下万世世丐丆丅(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        if(万且万且丑丗且丌丆 == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  万且万且丑丗且丌丆);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  万且万且丑丗且丌丆);
    }
    public static UnityEngine.Mesh 一丗东世专与丐丒一()
    {
        UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
        UnityEngine.Vector3[] val_2 = new UnityEngine.Vector3[4];
        val_2[0] = 0;
        val_2[0] = 0;
        val_2[1] = 0;
        val_2[1] = 0;
        val_2[2] = 0;
        val_2[2] = 0;
        val_2[3] = 0;
        val_2[3] = 0;
        val_2[4] = 0;
        val_2[4] = 0;
        val_2[5] = 0;
        val_2[5] = 0;
        UnityEngine.Vector2[] val_3 = new UnityEngine.Vector2[4];
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  1f, y:  1f);
        val_3[0] = val_4.x;
        val_3[0] = val_4.y;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  1f, y:  0f);
        val_3[1] = val_5.x;
        val_3[1] = val_5.y;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  1f);
        val_3[2] = val_6.x;
        val_3[2] = val_6.y;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0f, y:  0f);
        val_3[3] = val_7.x;
        val_3[3] = val_7.y;
        int[] val_8 = new int[6] {0, 1, 2, 0, 2, 3};
        if(val_1 != null)
        {
                val_1.vertices = val_2;
            val_1.uv = val_3;
            val_1.triangles = val_8;
            val_1.RecalculateNormals();
        }
        else
        {
                val_1.vertices = val_2;
            val_1.uv = val_3;
            val_1.triangles = val_8;
            val_1.RecalculateNormals();
        }
        
        val_1.RecalculateBounds();
        return val_1;
    }
    public static T[] 不丑万三丞丟丛丅且<T>()
    {
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
    }
    public static UnityEngine.Camera 丄且丂丏一七业业丒(int 且丅丟丛丛万丝下上)
    {
        var val_12;
        UnityEngine.Object val_13;
        var val_14;
        val_12 = 且丅丟丛丛万丝下上 & 31;
        var val_12 = 1;
        val_13 = UnityEngine.Camera.main;
        val_12 = val_12 << val_12;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                if((val_13.cullingMask & val_12) != 0)
        {
                return (UnityEngine.Camera)val_13;
        }
        
        }
        
        int val_5 = UnityEngine.Camera.allCamerasCount;
        UnityEngine.Camera[] val_6 = new UnityEngine.Camera[0];
        val_12 = val_6;
        int val_7 = UnityEngine.Camera.GetAllCameras(cameras:  val_6);
        if(val_7 >= 1)
        {
                val_14 = 0;
            do
        {
            if((UnityEngine.Object.op_Implicit(exists:  1152921507347125808)) != false)
        {
                if(1152921507347125808.enabled != false)
        {
                if((1152921507347125808.cullingMask & val_12) != 0)
        {
                return (UnityEngine.Camera)val_13;
        }
        
        }
        
        }
        
            val_14 = val_14 + 1;
        }
        while(val_14 < (long)val_7);
        
        }
        
        val_13 = 0;
        return (UnityEngine.Camera)val_13;
    }
    public static bool 世三丅不丄丂丒丕上(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if((UnityEngine.Object.op_Implicit(exists:  丝三丁东丈丒世丅业)) == false)
        {
                return false;
        }
        
        if(丝三丁东丈丒世丅业 != null)
        {
                return 丝三丁东丈丒世丅业.activeInHierarchy;
        }
        
        return 丝三丁东丈丒世丅业.activeInHierarchy;
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下)
    {
        return 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丞丆丏专且不丂上业:  false);
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下, bool 丞丆丏专且不丂上业)
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        if(丈东丘丏与丌东东下 == 0)
        {
                return val_1;
        }
        
        UnityEngine.Transform val_3 = val_1.transform;
        val_3.parent = 丈东丘丏与丌东东下.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_3.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        val_3.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_3.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        val_1.layer = 丈东丘丏与丌东东下.layer;
        return val_1;
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下, UnityEngine.GameObject 丑且不丕与专丄业丙)
    {
        UnityEngine.Object val_10;
        var val_11;
        val_10 = 丈东丘丏与丌东东下;
        val_11 = 1152921504848912384;
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙);
        if(val_1 == 0)
        {
                return val_1;
        }
        
        if(val_10 == 0)
        {
                return val_1;
        }
        
        val_11 = val_1.transform;
        val_11.parent = val_10.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_11.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        val_11.localRotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        val_11.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        val_10 = val_10.layer;
        val_1.layer = val_10;
        return val_1;
    }
    private static void 一与丙业丐三丙丟丆(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        丁丒丐丂万三丌万业.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  丙丒七丄上与丏丙丙, 与丟丗下丌丐丕丛丁:  false);
    }
    private static void 一与丙业丐三丙丟丆(UnityEngine.Transform 丙丒七丄上与丏丙丙, bool 与丟丗下丌丐丕丛丁)
    {
        var val_8 = 丙丒七丄上与丏丙丙.gameObject;
        val_8.SetActive(value:  true);
        if(与丟丗下丌丐丕丛丁 == false)
        {
                return;
        }
        
        val_8 = 0;
        label_8:
        if(val_8 >= 丙丒七丄上与丏丙丙.childCount)
        {
            goto label_5;
        }
        
        val_8 = val_8 + 1;
        if((丙丒七丄上与丏丙丙.GetChild(index:  0).gameObject.activeSelf) == false)
        {
            goto label_8;
        }
        
        return;
        label_5:
        int val_6 = 丙丒七丄上与丏丙丙.childCount;
        if(val_6 < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Transform val_7 = 丙丒七丄上与丏丙丙.GetChild(index:  0);
            val_8 = 0 + 1;
        }
        while(val_6 != val_8);
    
    }
    private static void Deactivate(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        丙丒七丄上与丏丙丙.gameObject.SetActive(value:  false);
    }
    public static void 不上丕不丞业一丗丂(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛, 与丟丗下丌丐丕丛丁:  true);
    }
    public static void 不上丕不丞业一丗丂(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛, bool 与丟丗下丌丐丕丛丁)
    {
        if((UnityEngine.Object.op_Implicit(exists:  丝三丁东丈丒世丅业)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = 丝三丁东丈丒世丅业.transform;
        if(丏业丟一东丂东丘丛 != false)
        {
                丁丒丐丂万三丌万业.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  val_2, 与丟丗下丌丐丕丛丁:  与丟丗下丌丐丕丛丁);
            return;
        }
        
        丁丒丐丂万三丌万业.Deactivate(丙丒七丄上与丏丙丙:  val_2);
    }
    public static void 丝与丒丞丒丛丑世丟(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        丝三丁东丈丒世丅业.SetActive(value:  丏业丟一东丂东丘丛);
    }
    public static T 东丙丗一丄上不丙与<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_7;
        UnityEngine.Object val_8;
        var val_9;
        var val_10;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = 丝三丁东丈丒世丅业;
        val_9 = 0;
        if(val_8 == 0)
        {
                return (object)val_9;
        }
        
        val_10 = val_8;
        if(val_10 != null)
        {
            goto label_9;
        }
        
        UnityEngine.Transform val_2 = val_8.transform;
        val_10 = 0;
        goto label_12;
        label_15:
        if((val_2 & 1) == 0)
        {
            goto label_9;
        }
        
        val_10 = val_2.gameObject;
        label_12:
        val_8 = val_2.parent;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  val_8, y:  0);
        if(val_10 == null)
        {
            goto label_15;
        }
        
        label_9:
        val_7 = mem[__RuntimeMethodHiddenParam + 48 + 8];
        val_7 = __RuntimeMethodHiddenParam + 48 + 8;
        if(val_10 != null)
        {
                val_9 = val_10;
            if(val_9 != null)
        {
                return (object)val_9;
        }
        
        }
        
        val_9 = 0;
        return (object)val_9;
    }
    public static T 东丙丗一丄上不丙与<T>(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        var val_7;
        UnityEngine.Object val_8;
        var val_9;
        var val_10;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = 丄上七丟不丗丕下丟;
        val_9 = 0;
        if(val_8 == 0)
        {
                return (object)val_9;
        }
        
        val_10 = val_8;
        if(val_10 != null)
        {
            goto label_9;
        }
        
        UnityEngine.Transform val_2 = val_8.transform;
        val_10 = 0;
        goto label_12;
        label_15:
        if((val_2 & 1) == 0)
        {
            goto label_9;
        }
        
        val_10 = val_2.gameObject;
        label_12:
        val_8 = val_2.parent;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  val_8, y:  0);
        if(val_10 == null)
        {
            goto label_15;
        }
        
        label_9:
        val_7 = mem[__RuntimeMethodHiddenParam + 48 + 8];
        val_7 = __RuntimeMethodHiddenParam + 48 + 8;
        if(val_10 != null)
        {
                val_9 = val_10;
            if(val_9 != null)
        {
                return (object)val_9;
        }
        
        }
        
        val_9 = 0;
        return (object)val_9;
    }
    public static UnityEngine.BoxCollider 世丞业且三丗丘三丑(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        return 丁丒丐丂万三丌万业.世丞业且三丗丘三丑(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 三世与丌丈丈丅丒三:  false);
    }
    public static UnityEngine.BoxCollider 世丞业且三丗丘三丑(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 三世与丌丈丈丅丒三)
    {
        UnityEngine.BoxCollider val_8 = 0;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return val_8;
        }
        
        UnityEngine.Collider val_2 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Collider>();
        val_8 = 0;
        if( != 0)
        {
            goto label_10;
        }
        
        if(val_2 == 0)
        {
            goto label_13;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_14;
        }
        
        UnityEngine.Object.Destroy(obj:  val_2);
        label_13:
        if(丝三丁东丈丒世丅业 != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        val_8 = 丝三丁东丈丒世丅业.AddComponent<UnityEngine.BoxCollider>();
        val_8.isTrigger = true;
        label_10:
        丁丒丐丂万三丌万业.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  val_8, 三世与丌丈丈丅丒三:  false);
        return val_8;
        label_14:
        UnityEngine.Object.DestroyImmediate(obj:  val_2);
        if(丝三丁东丈丒世丅业 != null)
        {
            goto label_21;
        }
        
        goto label_22;
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        丁丒丐丂万三丌万业.丝丁丏丟丂丅丌丂丌(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 三世与丌丈丈丅丒三:  false);
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 三世与丌丈丈丅丒三)
    {
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        丁丒丐丂万三丌万业.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  丝三丁东丈丒世丅业.GetComponent<UnityEngine.BoxCollider>(), 三世与丌丈丈丅丒三:  false);
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.BoxCollider 丝丂且丙丕丅丐丘丞)
    {
        丁丒丐丂万三丌万业.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  丝丂且丙丕丅丐丘丞, 三世与丌丈丈丅丒三:  false);
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.BoxCollider 不丌丗丂丆业丂丏世, bool 三世与丌丈丈丅丒三)
    {
        if(不丌丗丂丆业丂丏世 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        不丌丗丂丆业丂丏世.center = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        不丌丗丂丆业丂丏世.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public 丁丒丐丂万三丌万业()
    {
    
    }

}
