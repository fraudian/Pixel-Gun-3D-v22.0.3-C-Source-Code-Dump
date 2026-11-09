using UnityEngine;
public static class 不丌丂丁丄一与丆丙
{
    // Fields
    private static UnityEngine.AudioListener 且丛丏丘且丁丒丙丛;
    private static bool 丁丘一专丘万丛与丁;
    private static float 丁丟丝丂且丙万丞丈;
    private static float 丒丘不世丐世丌丒丗;
    private static UnityEngine.AudioClip 七三丘丙与丆东东万;
    private static UnityEngine.Vector3[] 专丏丛下世丙丝丈三;
    public static UnityEngine.KeyCode[] 与丟且丝丞一丘七丑;
    
    // Properties
    public static float 不丌丄丙不丕丂丑丛 { get; set; }
    public static bool 东丞丈七丂世不丒与 { get; }
    public static string 不东丑丌丌丄专丏丄 { get; set; }
    public static UnityEngine.Vector2 且丅丗丞丕丝上丒丒 { get; }
    
    // Methods
    public static float 上丘丗丒一丟上且丗()
    {
        var val_2 = null;
        if(不丌丂丁丄一与丆丙.丁丘一专丘万丛与丁 != true)
        {
                不丌丂丁丄一与丆丙.丁丘一专丘万丛与丁 = true;
            val_2 = null;
            不丌丂丁丄一与丆丙.丁丟丝丂且丙万丞丈 = UnityEngine.PlayerPrefs.GetFloat(key:  "Sound", defaultValue:  1f);
        }
        
        val_2 = null;
        return (float)不丌丂丁丄一与丆丙.丁丟丝丂且丙万丞丈;
    }
    public static void 丛丕丕且丞上丆丏丁(float 丙业与丙丗丝不丈东)
    {
        if(不丌丂丁丄一与丆丙.丁丟丝丂且丙万丞丈 == 丙业与丙丗丝不丈东)
        {
                return;
        }
        
        null = null;
        不丌丂丁丄一与丆丙.丁丘一专丘万丛与丁 = true;
        不丌丂丁丄一与丆丙.丁丟丝丂且丙万丞丈 = 丙业与丙丗丝不丈东;
        UnityEngine.PlayerPrefs.SetFloat(key:  "Sound", value:  丙业与丙丗丝不丈东);
    }
    public static bool 业丛丏丙丅不丗丘丙()
    {
        return true;
    }
    public static UnityEngine.AudioSource 丛不上丛一丆丛丅下(UnityEngine.AudioClip 丏世一不与丗丏三不)
    {
        return 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丏世一不与丗丏三不, 与丁万东丌丑下丏丕:  1f, 丟与不丄丕丞专下丛:  1f);
    }
    public static UnityEngine.AudioSource 丛不上丛一丆丛丅下(UnityEngine.AudioClip 丏世一不与丗丏三不, float 与丁万东丌丑下丏丕)
    {
        return 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  丏世一不与丗丏三不, 与丁万东丌丑下丏丕:  与丁万东丌丑下丏丕, 丟与不丄丕丞专下丛:  1f);
    }
    public static UnityEngine.AudioSource 丛不上丛一丆丛丅下(UnityEngine.AudioClip 丏世一不与丗丏三不, float 与丁万东丌丑下丏丕, float 丟与不丄丕丞专下丛)
    {
        var val_26;
        var val_27;
        UnityEngine.Object val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        UnityEngine.Object val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        float val_28 = 与丁万东丌丑下丏丕;
        float val_1 = RealTime.time;
        val_26 = null;
        val_26 = null;
        val_27 = null;
        if(不丌丂丁丄一与丆丙.七三丘丙与丆东东万 != 丏世一不与丗丏三不)
        {
            goto label_5;
        }
        
        val_27 = null;
        float val_27 = 不丌丂丁丄一与丆丙.丒丘不世丐世丌丒丗;
        val_27 = val_27 + 0.001f;
        if(val_27 > val_1)
        {
            goto label_8;
        }
        
        label_5:
        val_27 = null;
        不丌丂丁丄一与丆丙.七三丘丙与丆东东万 = 丏世一不与丗丏三不;
        不丌丂丁丄一与丆丙.丒丘不世丐世丌丒丗 = val_1;
        val_28 = 不丌丂丁丄一与丆丙.上丘丗丒一丟上且丗() * val_28;
        val_28 = 0;
        if(val_28 <= 0.01f)
        {
                return (UnityEngine.AudioSource)val_28;
        }
        
        if(丏世一不与丗丏三不 == 0)
        {
                return (UnityEngine.AudioSource)val_28;
        }
        
        val_29 = null;
        val_29 = null;
        if(不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛 == 0)
        {
            goto label_19;
        }
        
        val_30 = null;
        val_30 = null;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛)) == true)
        {
            goto label_55;
        }
        
        label_19:
        UnityEngine.Object[] val_8 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        if((val_8 == null) || (val_8.Length < 1))
        {
            goto label_34;
        }
        
        label_33:
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(不丗上三丛丒上东丑:  val_8[0])) == true)
        {
            goto label_32;
        }
        
        if((0 + 1) < val_8.Length)
        {
            goto label_33;
        }
        
        goto label_34;
        label_8:
        val_28 = 0;
        return (UnityEngine.AudioSource)val_28;
        label_32:
        val_31 = null;
        val_31 = null;
        不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛 = val_8[0x0] + 32;
        label_34:
        val_32 = null;
        val_32 = null;
        if(不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛 == 0)
        {
                val_33 = UnityEngine.Camera.main;
            if(val_33 == 0)
        {
                System.Type val_30 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_15 = UnityEngine.Object.FindObjectOfType(type:  val_30);
            if(val_15 != null)
        {
                val_30 = (null == null) ? (val_15) : 0;
        }
        else
        {
                val_33 = 0;
        }
        
        }
        
            if(val_33 != 0)
        {
                val_34 = null;
            val_34 = null;
            不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛 = val_33.gameObject.AddComponent<UnityEngine.AudioListener>();
        }
        
        }
        
        label_55:
        val_35 = null;
        val_35 = null;
        val_28 = 0;
        if(不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛 == 0)
        {
                return (UnityEngine.AudioSource)val_28;
        }
        
        val_36 = null;
        val_36 = null;
        val_28 = 0;
        if(不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛.enabled == false)
        {
                return (UnityEngine.AudioSource)val_28;
        }
        
        val_37 = null;
        val_37 = null;
        val_28 = 0;
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛.gameObject)) == false)
        {
                return (UnityEngine.AudioSource)val_28;
        }
        
        val_38 = null;
        val_38 = null;
        val_28 = 不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛.GetComponent<UnityEngine.AudioSource>();
        if(val_28 == 0)
        {
                val_39 = null;
            val_39 = null;
            val_28 = 不丌丂丁丄一与丆丙.且丛丏丘且丁丒丙丛.gameObject.AddComponent<UnityEngine.AudioSource>();
        }
        
        if(val_28 != null)
        {
                val_28.priority = 50;
            val_28.pitch = 丟与不丄丕丞专下丛;
        }
        else
        {
                val_28.priority = 50;
            val_28.pitch = 丟与不丄丕丞专下丛;
        }
        
        val_28.PlayOneShot(clip:  丏世一不与丗丏三不, volumeScale:  val_28);
        return (UnityEngine.AudioSource)val_28;
    }
    public static int 丟丐丏世世丒丞丏且(int 丒丛七丄世业东丝丁, int 七丝东丛东丝且丆不)
    {
        if(丒丛七丄世业东丝丁 == 七丝东丛东丝且丆不)
        {
                return (int)丒丛七丄世业东丝丁;
        }
        
        七丝东丛东丝且丆不 = 七丝东丛东丝且丆不 + 1;
        return UnityEngine.Random.Range(min:  丒丛七丄世业东丝丁, max:  七丝东丛东丝且丆不);
    }
    public static string 上丞丁业丛丑与丅丞(UnityEngine.GameObject 万且万且丑丗且丌丆)
    {
        UnityEngine.Object val_11;
        string val_12;
        val_11 = 万且万且丑丗且丌丆;
        if(val_11 == 0)
        {
                val_12 = "";
            return (string)val_12;
        }
        
        val_12 = val_11.name;
        goto label_6;
        label_15:
        val_11 = val_11.transform.parent.gameObject;
        val_12 = val_11.name + "\\" + val_12;
        label_6:
        if(val_11.transform.parent != 0)
        {
            goto label_15;
        }
        
        return (string)val_12;
    }
    public static T[] 不丑万三丞丟丛丅且<T>()
    {
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
    }
    public static UnityEngine.Camera 丄且丂丏一七业业丒(int 且丅丟丛丛万丝下上)
    {
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.Object val_22;
        var val_23;
        val_19 = 1152921505096622080;
        val_20 = 0;
        int val_2 = 1 << (且丅丟丛丛万丝下上 & 31);
        goto label_1;
        label_16:
        val_21 = null;
        val_21 = null;
        var val_3 = (UICamera.list + 16) + 0;
        val_22 = (UICamera.list + 16 + 0) + 32.cachedCamera;
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) != false)
        {
                if((val_22.cullingMask & val_2) != 0)
        {
                return (UnityEngine.Camera)val_22;
        }
        
        }
        
        val_20 = 1;
        label_1:
        val_23 = null;
        val_23 = null;
        if(val_20 < (UICamera.list + 24))
        {
            goto label_16;
        }
        
        val_22 = UnityEngine.Camera.main;
        if((UnityEngine.Object.op_Implicit(exists:  val_22)) != false)
        {
                if((val_22.cullingMask & val_2) != 0)
        {
                return (UnityEngine.Camera)val_22;
        }
        
        }
        
        int val_12 = UnityEngine.Camera.allCamerasCount;
        UnityEngine.Camera[] val_13 = new UnityEngine.Camera[0];
        int val_14 = UnityEngine.Camera.GetAllCameras(cameras:  val_13);
        if(val_14 >= 1)
        {
                val_19 = 0;
            do
        {
            if((UnityEngine.Object.op_Implicit(exists:  1152921507347125808)) != false)
        {
                if(1152921507347125808.enabled != false)
        {
                if((1152921507347125808.cullingMask & val_2) != 0)
        {
                return (UnityEngine.Camera)val_22;
        }
        
        }
        
        }
        
            val_19 = val_19 + 1;
        }
        while(val_19 < (long)val_14);
        
        }
        
        val_22 = 0;
        return (UnityEngine.Camera)val_22;
    }
    public static void 世丞业且三丗丘三丑(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        不丌丂丁丄一与丆丙.世丞业且三丗丘三丑(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 三世与丌丈丈丅丒三:  false);
    }
    public static void 世丞业且三丗丘三丑(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 三世与丌丈丈丅丒三)
    {
        UnityEngine.Object val_20;
        var val_21;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        val_20 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.Collider>();
        val_21 = 0;
        if( == 0)
        {
            goto label_10;
        }
        
        label_47:
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  null, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
        return;
        label_10:
        if(val_20 != 0)
        {
                return;
        }
        
        UnityEngine.BoxCollider2D val_7 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.BoxCollider2D>();
        if(val_7 == 0)
        {
            goto label_19;
        }
        
        label_37:
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  val_7, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
        return;
        label_19:
        if((UICamera.FindCameraForLayer(且丅丟丛丛万丝下上:  丝三丁东丈丒世丅业.layer)) == 0)
        {
            goto label_29;
        }
        
        丗丄丐丈丛丛三丗丏 val_20 = val_11.eventType;
        val_20 = val_20 & 4294967294;
        if(val_20 != 2)
        {
            goto label_29;
        }
        
        丝三丁东丈丒世丅业.AddComponent<UnityEngine.BoxCollider2D>().isTrigger = true;
        if((丝三丁东丈丒世丅业.GetComponent<UIWidget>()) == 0)
        {
            goto label_37;
        }
        
        val_14.autoResizeBoxCollider = true;
        goto label_37;
        label_29:
        丝三丁东丈丒世丅业.AddComponent<UnityEngine.BoxCollider>().isTrigger = true;
        if((丝三丁东丈丒世丅业.GetComponent<UIWidget>()) != 0)
        {
                val_17.autoResizeBoxCollider = true;
        }
        
        bool val_19 = 三世与丌丈丈丅丒三;
        goto label_47;
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 三世与丌丈丈丅丒三:  false);
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 三世与丌丈丈丅丒三)
    {
        UnityEngine.Object val_8;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return;
        }
        
        val_8 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.BoxCollider>();
        if(val_8 != 0)
        {
                不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  val_8, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
            return;
        }
        
        UnityEngine.BoxCollider2D val_5 = 丝三丁东丈丒世丅业.GetComponent<UnityEngine.BoxCollider2D>();
        if(val_5 == 0)
        {
                return;
        }
        
        不丌丂丁丄一与丆丙.丝丁丏丟丂丅丌丂丌(不丌丗丂丆业丂丏世:  val_5, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.BoxCollider 不丌丗丂丆业丂丏世, bool 三世与丌丈丈丅丒三)
    {
        float val_12;
        UnityEngine.Object val_17;
        var val_20;
        float val_21;
        val_17 = 1152921504848912384;
        if(不丌丗丂丆业丂丏世 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = 不丌丗丂丆业丂丏世.gameObject;
        val_17 = val_2.GetComponent<UIWidget>();
        if(val_17 == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Vector4 val_5 = val_17.drawRegion;
        if((((val_5.w != 1f) || (val_5.z != 1f)) || (val_5.x != 0f)) || (val_5.y != 0f))
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
        不丌丗丂丆业丂丏世.center = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        val_20 = val_7.x;
        val_21 = val_7.z;
        if(不丌丗丂丆业丂丏世 != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_8:
        UnityEngine.Bounds val_10 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_2.transform, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
        val_21 = V2.16B;
        不丌丗丂丆业丂丏世.center = new UnityEngine.Vector3() {x = val_12, y = V1.16B, z = val_21};
        val_20 = val_12;
        if(不丌丗丂丆业丂丏世 != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        label_24:
        不丌丗丂丆业丂丏世.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_13:
        val_5.x = val_5.x + val_5.z;
        float val_16 = 0.5f;
        val_5.x = val_5.x * val_16;
        val_16 = (val_5.y + val_5.w) * val_16;
        val_12 = 0;
        不丌丗丂丆业丂丏世.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_14 = val_5.z - val_5.x;
        float val_15 = val_5.w - val_5.y;
        if(不丌丗丂丆业丂丏世 != null)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    public static void 丝丁丏丟丂丅丌丂丌(UnityEngine.BoxCollider2D 不丌丗丂丆业丂丏世, bool 三世与丌丈丈丅丒三)
    {
        float val_13;
        var val_17;
        float val_20;
        float val_23;
        if(不丌丗丂丆业丂丏世 == 0)
        {
                return;
        }
        
        val_17 = 不丌丗丂丆业丂丏世.gameObject;
        if((val_17.GetComponent<UIWidget>()) != 0)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            不丌丗丂丆业丂丏世.offset = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_23 = val_8.x;
            if(不丌丗丂丆业丂丏世 != null)
        {
            goto label_21;
        }
        
        }
        else
        {
                UnityEngine.Bounds val_11 = 万丗丅且丄丑世专与.丌不上业三丞丕且丁(丄上七丟不丗丕下丟:  val_17.transform, 三世与丌丈丈丅丒三:  三世与丌丈丈丅丒三);
            val_20 = V2.16B;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13, y = V1.16B, z = val_20});
            不丌丗丂丆业丂丏世.offset = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            val_23 = val_14.x;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_23, y:  val_14.y);
        }
        
        label_21:
        不丌丗丂丆业丂丏世.size = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
    }
    public static string 三丒世丝七丛与业丒<T>()
    {
        var val_5;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
        if(val_1 == null)
        {
            goto label_4;
        }
        
        if((val_1.StartsWith(value:  "UI")) == false)
        {
            goto label_5;
        }
        
        label_7:
        val_5 = 2;
        return val_1.Substring(startIndex:  12);
        label_4:
        if((0.StartsWith(value:  "UI")) == true)
        {
            goto label_7;
        }
        
        label_5:
        if((val_1.StartsWith(value:  "UnityEngine.")) == false)
        {
                return (string)val_1;
        }
        
        val_5 = 12;
        return val_1.Substring(startIndex:  12);
    }
    public static string 三丒世丝七丛与业丒(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        var val_6;
        if(万且万且丑丗且丌丆 == 0)
        {
                return "Null";
        }
        
        System.Type val_2 = 万且万且丑丗且丌丆.GetType();
        if(val_2 == null)
        {
            goto label_6;
        }
        
        if((val_2.StartsWith(value:  "UI")) == false)
        {
            goto label_7;
        }
        
        label_9:
        val_6 = 2;
        return val_2.Substring(startIndex:  12);
        label_6:
        if((0.StartsWith(value:  "UI")) == true)
        {
            goto label_9;
        }
        
        label_7:
        if((val_2.StartsWith(value:  "UnityEngine.")) == false)
        {
                return "Null";
        }
        
        val_6 = 12;
        return val_2.Substring(startIndex:  12);
    }
    public static void 丏万世世万丁世丟丛(UnityEngine.Object 万且万且丑丗且丌丆, string 丒丘丏上丙丟丑丕丈)
    {
    
    }
    public static void 丒不七东丙丒丞业丛(UnityEngine.Object 万且万且丑丗且丌丆)
    {
    
    }
    public static void 丈丝丟丁业丙一世丕(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
    
    }
    public static UnityEngine.GameObject 丗上世丑丘业丆七一(UnityEngine.GameObject 丈东丘丏与丌东东下)
    {
        return 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丞丆丏专且不丂上业:  false);
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
    public static int 丛丘世丟丝上丙与丕(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        int val_9;
        var val_10;
        var val_11;
        int val_12;
        UIWidget val_1 = 丝三丁东丈丒世丅业.GetComponent<UIWidget>();
        if(val_1 != 0)
        {
                if(val_1 != null)
        {
                return val_1.raycastDepth;
        }
        
            return val_1.raycastDepth;
        }
        
        val_9 = val_3.Length;
        if(val_9 == 0)
        {
            goto label_8;
        }
        
        if(val_9 < 1)
        {
            goto label_9;
        }
        
        val_10 = 0;
        val_11 = 2147483647;
        goto label_10;
        label_18:
        val_9 = val_3.Length;
        val_10 = 1;
        label_10:
        if(X21.enabled != false)
        {
                val_12 = X21.raycastDepth;
            val_11 = UnityEngine.Mathf.Min(a:  2147483647, b:  val_12);
        }
        
        if(((val_9 & 4294967295) - 1) != val_10)
        {
            goto label_18;
        }
        
        return (int)val_11;
        label_8:
        val_11 = 0;
        return (int)val_11;
        label_9:
        val_11 = 2147483647;
        return (int)val_11;
    }
    public static int 丒与万丘且丕丙丏丛(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.Object val_6;
        int val_7;
        var val_8;
        var val_9;
        val_6 = 丝三丁东丈丒世丅业;
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
        {
            goto label_6;
        }
        
        val_6 = val_6.GetComponentsInChildren<UIWidget>();
        if(val_2.Length < 1)
        {
            goto label_6;
        }
        
        val_7 = val_2.Length & 4294967295;
        val_8 = 0;
        goto label_7;
        label_12:
        val_7 = val_2.Length;
        val_8 = 1;
        label_7:
        if((val_7 - 1) != val_8)
        {
            goto label_12;
        }
        
        val_9 = (UnityEngine.Mathf.Max(a:  0, b:  X21.depth)) + 1;
        return (int)val_9;
        label_6:
        val_9 = 0;
        return (int)val_9;
    }
    public static int 丒与万丘且丕丙丏丛(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丁丏与丅丈三与丝丛)
    {
        int val_12;
        var val_13;
        var val_14;
        UnityEngine.Object val_15;
        if(((UnityEngine.Object.op_Implicit(exists:  丝三丁东丈丒世丅业)) == false) || (丁丏与丅丈三与丝丛 == false))
        {
                return 不丌丂丁丄一与丆丙.丒与万丘且丕丙丏丛(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业);
        }
        
        if(val_2.Length < 1)
        {
            goto label_7;
        }
        
        val_12 = val_2.Length & 4294967295;
        val_13 = 0;
        val_14 = 0;
        goto label_8;
        label_25:
        val_12 = val_2.Length;
        val_13 = 1;
        label_8:
        val_15 = X22.cachedGameObject;
        if(val_15 == 丝三丁东丈丒世丅业)
        {
            goto label_13;
        }
        
        val_15 = X22.GetComponent<UnityEngine.Collider>();
        if(val_15 != 0)
        {
            goto label_21;
        }
        
        val_15 = X22.GetComponent<UnityEngine.Collider2D>();
        if(val_15 != 0)
        {
            goto label_21;
        }
        
        label_13:
        val_14 = UnityEngine.Mathf.Max(a:  0, b:  X22.depth);
        label_21:
        if((val_12 - 1) != val_13)
        {
            goto label_25;
        }
        
        return (int)val_14 + 1;
        label_7:
        val_14 = 0;
        return (int)val_14 + 1;
    }
    public static int 丘丞东且丐丞下丛丁(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丙丘丏上丗丗丐丕丞)
    {
        UnityEngine.Object val_15;
        var val_16;
        var val_17;
        var val_18;
        int val_19;
        var val_20;
        if(丝三丁东丈丒世丅业 == 0)
        {
            goto label_3;
        }
        
        val_15 = 丝三丁东丈丒世丅业.GetComponent<UIPanel>();
        if(val_15 == 0)
        {
            goto label_7;
        }
        
        val_16 = 0;
        goto label_9;
        label_14:
        val_15 = 丝三丁东丈丒世丅业.GetComponentsInChildren<UIPanel>(includeInactive:  true)[0];
        if(val_15 != 0)
        {
                val_17 = val_15.depth;
        }
        else
        {
                val_17 = 0.depth;
        }
        
        val_15.depth = val_17 + 丙丘丏上丗丗丐丕丞;
        val_16 = 1;
        label_9:
        if(val_16 < val_4.Length)
        {
            goto label_14;
        }
        
        val_18 = 1;
        return (int)val_18;
        label_7:
        val_15 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丕丗丆丕丈丑东丆丈:  0);
        if(val_15 != 0)
        {
            goto label_20;
        }
        
        label_3:
        val_18 = 0;
        return (int)val_18;
        label_20:
        if(val_10.Length < 1)
        {
                return (int)val_18;
        }
        
        val_19 = val_10.Length & 4294967295;
        val_20 = 0;
        goto label_24;
        label_30:
        val_19 = val_10.Length;
        val_20 = 1;
        label_24:
        if((X22 + 216) == val_15)
        {
                X22.depth = X22.depth + 丙丘丏上丗丗丐丕丞;
        }
        
        if((val_19 - 1) != val_20)
        {
            goto label_30;
        }
        
        return (int)val_18;
    }
    public static void 丕丆与三一世丘丝丞(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        int val_1 = 不丌丂丁丄一与丆丙.丘丞东且丐丞下丛丁(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丙丘丏上丗丗丐丕丞:  232);
        if(val_1 != 2)
        {
                if(val_1 != 1)
        {
                return;
        }
        
            不丌丂丁丄一与丆丙.丅丝丈丕丏七不丆丘();
            return;
        }
        
        不丌丂丁丄一与丆丙.业七丞三丆丛丘丌不();
    }
    public static void 与丁三丅不丂丝丛且(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        int val_1 = 不丌丂丁丄一与丆丙.丘丞东且丐丞下丛丁(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丙丘丏上丗丗丐丕丞:  999);
        if(val_1 != 2)
        {
                if(val_1 != 1)
        {
                return;
        }
        
            不丌丂丁丄一与丆丙.丅丝丈丕丏七不丆丘();
            return;
        }
        
        不丌丂丁丄一与丆丙.业七丞三丆丛丘丌不();
    }
    public static void 业与丐七丕东丕世丗()
    {
        不丌丂丁丄一与丆丙.业七丞三丆丛丘丌不();
        不丌丂丁丄一与丆丙.丅丝丈丕丏七不丆丘();
    }
    public static void 业七丞三丆丛丘丌不()
    {
        不丌丂丁丄一与丆丙.业七丞三丆丛丘丌不(丝丘丑业丛万丞丌丝:  不丌丂丁丄一与丆丙.不丑万三丞丟丛丅且<UIWidget>());
    }
    public static void 业七丞三丆丛丘丌不(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        不丌丂丁丄一与丆丙.业七丞三丆丛丘丌不(丝丘丑业丛万丞丌丝:  丝三丁东丈丒世丅业.GetComponentsInChildren<UIWidget>());
    }
    public static void 业七丞三丆丛丘丌不(UIWidget[] 丝丘丑业丛万丞丌丝)
    {
        int val_8;
        int val_9;
        val_8 = 丝丘丑业丛万丞丌丝.Length;
        if(val_8 < 1)
        {
                return;
        }
        
        System.Array.Sort<UIWidget>(array:  丝丘丑业丛万丞丌丝, comparison:  new System.Comparison<UIWidget>(object:  0, method:  public static System.Int32 UIWidget::FullCompareFunc(UIWidget 丈丂丕下丏丈丞丗业, UIWidget 丂丌丌丛丆丆丙丌丈)));
        val_8 = 丝丘丑业丛万丞丌丝[0].depth;
        var val_9 = 0;
        val_9 = 0;
        label_10:
        if(null == null)
        {
            goto label_6;
        }
        
        if(1152921509272069040.depth == val_8)
        {
            goto label_9;
        }
        
        val_8 = 1152921509272069040.depth;
        goto label_8;
        label_6:
        if(0.depth == val_8)
        {
            goto label_9;
        }
        
        val_8 = 0.depth;
        label_8:
        val_9 = val_9 + 1;
        label_9:
        1152921509272069040.depth = val_9;
        val_9 = val_9 + 1;
        if((val_8 & 4294967295) != val_9)
        {
            goto label_10;
        }
    
    }
    public static void 丅丝丈丕丏七不丆丘()
    {
        int val_9;
        int val_10;
        T[] val_1 = 不丌丂丁丄一与丆丙.不丑万三丞丟丛丅且<UIPanel>();
        val_9 = val_1.Length;
        if(val_9 < 1)
        {
                return;
        }
        
        System.Array.Sort<UIPanel>(array:  val_1, comparison:  new System.Comparison<UIPanel>(object:  0, method:  public static System.Int32 UIPanel::CompareFunc(UIPanel 丆丛丑世下一丐且丕, UIPanel 丌丗丏丏丛东专丁且)));
        val_9 = val_1[0].depth;
        var val_10 = 0;
        val_10 = 0;
        label_12:
        if(null == null)
        {
            goto label_8;
        }
        
        if(1152921509270664944.depth == val_9)
        {
            goto label_11;
        }
        
        val_9 = 1152921509270664944.depth;
        goto label_10;
        label_8:
        if(0.depth == val_9)
        {
            goto label_11;
        }
        
        val_9 = 0.depth;
        label_10:
        val_10 = val_10 + 1;
        label_11:
        1152921509270664944.depth = val_10;
        val_10 = val_10 + 1;
        if((val_9 & 4294967295) != val_10)
        {
            goto label_12;
        }
    
    }
    public static UIPanel 丁丄丘万东丑丕万一(bool 专丆七上丆丈丈丂万)
    {
        return 不丌丂丁丄一与丆丙.丁丄丘万东丑丕万一(丄上七丟不丗丕下丟:  0, 专丆七上丆丈丈丂万:  专丆七上丆丈丈丂万, 且丅丟丛丛万丝下上:  0);
    }
    public static UIPanel 丁丄丘万东丑丕万一(bool 专丆七上丆丈丈丂万, int 且丅丟丛丛万丝下上)
    {
        return 不丌丂丁丄一与丆丙.丁丄丘万东丑丕万一(丄上七丟不丗丕下丟:  0, 专丆七上丆丈丈丂万:  专丆七上丆丈丈丂万, 且丅丟丛丛万丝下上:  且丅丟丛丛万丝下上);
    }
    public static UIPanel 丁丄丘万东丑丕万一(UnityEngine.Transform 丄上七丟不丗丕下丟, bool 专丆七上丆丈丈丂万, int 且丅丟丛丛万丝下上)
    {
        var val_8;
        var val_82;
        UnityEngine.Object val_83;
        UnityEngine.Object val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_89;
        var val_90;
        var val_91;
        UIPanel val_92;
        int val_93;
        float val_94;
        float val_95;
        int val_96;
        丟专丐专与东丈丟丒 val_97;
        var val_98;
        UnityEngine.Transform val_101;
        var val_102;
        var val_103;
        var val_106;
        float val_107;
        float val_108;
        float val_109;
        UnityEngine.Transform val_110;
        UnityEngine.Transform val_111;
        val_82 = 且丅丟丛丛万丝下上;
        val_83 = 丄上七丟不丗丕下丟;
        val_84 = 0;
        if(val_83 != 0)
        {
                val_84 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIRoot>(丝三丁东丈丒世丅业:  val_83.gameObject, 丕丗丆丕丈丑东丆丈:  0);
        }
        
        if(val_84 != 0)
        {
            goto label_25;
        }
        
        val_85 = 1152921505098964992;
        val_86 = null;
        val_86 = null;
        if(UIRoot.list.Count < 1)
        {
            goto label_25;
        }
        
        val_87 = null;
        val_87 = null;
        List.Enumerator<T> val_6 = UIRoot.list.GetEnumerator();
        val_85 = 1152921535205032240;
        label_20:
        if((533647520 & 1) == 0)
        {
            goto label_17;
        }
        
        string val_9 = val_8.丐丏七丌丕丗业且上();
        if(val_9.gameObject.layer != val_82)
        {
            goto label_20;
        }
        
        val_84 = val_9;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_25:
        if(val_84 == 0)
        {
                val_85 = 1152921505098698752;
            val_89 = null;
            val_89 = null;
            int val_13 = UIPanel.list.Count;
            if(val_13 >= 1)
        {
                val_90 = 0;
            do
        {
            val_91 = null;
            val_91 = null;
            val_92 = UIPanel.list.Item[0];
            UnityEngine.GameObject val_15 = val_92.gameObject;
            if(val_15.hideFlags == 0)
        {
                if(val_15.layer == val_82)
        {
            goto label_40;
        }
        
        }
        
            val_90 = val_90 + 1;
        }
        while(val_90 < val_13);
        
        }
        
        }
        
        if(val_84 != 0)
        {
                UICamera val_19 = val_84.GetComponentInChildren<UICamera>();
            if(val_19 != 0)
        {
                bool val_83 = 专丆七上丆丈丈丂万;
            val_83 = (val_19.GetComponent<UnityEngine.Camera>().orthographic) ^ val_83;
            UnityEngine.Object val_24 = (val_83 != true) ? (val_83) : 0;
        }
        
        }
        
        if(((val_83 != true) ? (val_84) : 0) != 0)
        {
            goto label_53;
        }
        
        UnityEngine.GameObject val_26 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  0, 丞丆丏专且不丂上业:  false);
        val_84 = val_26.AddComponent<UIRoot>();
        if(val_82 != 1)
        {
            goto label_57;
        }
        
        val_93 = UnityEngine.LayerMask.NameToLayer(layerName:  "UI");
        if(val_93 == 1)
        {
            goto label_58;
        }
        
        label_57:
        if(val_26 == null)
        {
            goto label_59;
        }
        
        label_67:
        val_26.layer = val_93;
        goto label_60;
        label_40:
        val_83.parent = val_92.transform;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.one;
        val_94 = val_30.x;
        val_95 = val_30.z;
        val_83.localScale = new UnityEngine.Vector3() {x = val_94, y = val_30.y, z = val_95};
        return val_92;
        label_58:
        val_96 = UnityEngine.LayerMask.NameToLayer(layerName:  "2D UI");
        if(val_26 != null)
        {
            goto label_67;
        }
        
        label_59:
        0.layer = val_96;
        label_60:
        if(专丆七上丆丈丈丂万 != false)
        {
                val_26.name = "UI Root (3D)";
            val_97 = 1;
        }
        else
        {
                val_26.name = "UI Root";
            val_97 = 0;
        }
        
        val_27.scalingStyle = val_97;
        label_53:
        val_90 = 1152921505098964992;
        UIPanel val_33 = 0;
        val_98 = null;
        val_98 = null;
        if((UIRoot.丅丘丝不七丝丝三丘.TryGetValue(key:  val_84.transform, value: out  val_33)) == true)
        {
            goto label_146;
        }
        
        System.Collections.IEnumerator val_36 = val_84.transform.GetEnumerator();
        label_96:
        var val_84 = 0;
        val_84 = val_84 + 1;
        if(val_36.MoveNext() == false)
        {
            goto label_84;
        }
        
        var val_85 = 0;
        val_85 = val_85 + 1;
        val_101 = val_36.Current;
        if(val_101 != null)
        {
                val_101 = 0;
        }
        
        val_102 = null;
        val_102 = null;
        if((UIRoot.丅丘丝不七丝丝三丘.TryGetValue(key:  val_101, value: out  val_33)) == false)
        {
            goto label_96;
        }
        
        label_84:
        val_85 = 0;
        val_103 = 0;
        if(val_36 != null)
        {
                var val_86 = 0;
            val_86 = val_86 + 1;
            val_36.Dispose();
        }
        
        if( == 1)
        {
            goto label_109;
        }
        
        if(( == false) || (475 == 475))
        {
            goto label_146;
        }
        
        label_145:
        label_146:
        if(val_33 != 0)
        {
            goto label_114;
        }
        
        int val_49 = val_84.gameObject.layer & 31;
        val_49 = 1 << val_49;
        val_106 = 0;
        val_85 = 0;
        val_94 = -1f;
        goto label_119;
        label_131:
        T val_87 = 不丌丂丁丄一与丆丙.不丑万三丞丟丛丅且<UnityEngine.Camera>()[0];
        if(val_87.clearFlags != 2)
        {
                if(val_87.clearFlags != 1)
        {
            goto label_124;
        }
        
        }
        
        val_85 = 1;
        label_124:
        val_94 = UnityEngine.Mathf.Max(a:  val_94, b:  val_87.depth);
        if(val_87 != 0)
        {
                val_90 = val_87.cullingMask;
        }
        else
        {
                val_90 = 0.cullingMask;
        }
        
        val_87.cullingMask = val_90 & (~val_49);
        val_106 = 1;
        label_119:
        if(val_106 < val_46.Length)
        {
            goto label_131;
        }
        
        UnityEngine.Camera val_58 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一<UnityEngine.Camera>(丈东丘丏与丌东东下:  val_84.gameObject, 丞丆丏专且不丂上业:  false);
        UICamera val_60 = val_58.gameObject.AddComponent<UICamera>();
        val_58.clearFlags = (val_85 != 1) ? (2 + 1) : 2;
        UnityEngine.Color val_62 = UnityEngine.Color.grey;
        val_95 = val_62.b;
        if(val_58 != null)
        {
                val_107 = val_62.g;
            val_108 = val_95;
            val_58.backgroundColor = new UnityEngine.Color() {r = val_62.r, g = val_107, b = val_108, a = val_62.a};
            val_58.cullingMask = val_49;
            float val_88 = 1f;
            val_88 = val_94 + val_88;
            val_58.depth = val_88;
        }
        else
        {
                val_107 = val_62.g;
            val_108 = val_95;
            val_58.backgroundColor = new UnityEngine.Color() {r = val_62.r, g = val_107, b = val_108, a = val_62.a};
            val_58.cullingMask = val_49;
            float val_89 = 1f;
            val_89 = val_94 + val_89;
            val_58.depth = val_89;
        }
        
        if(专丆七上丆丈丈丂万 == false)
        {
            goto label_140;
        }
        
        val_58.nearClipPlane = 0.1f;
        if(val_58 == null)
        {
            goto label_141;
        }
        
        val_58.farClipPlane = 4f;
        goto label_142;
        label_140:
        val_58.orthographic = true;
        if(val_58 == null)
        {
            goto label_143;
        }
        
        val_58.orthographicSize = 1f;
        val_58.nearClipPlane = -10f;
        goto label_144;
        label_109:
        if( == true)
        {
            goto label_145;
        }
        
        goto label_146;
        label_141:
        val_58.farClipPlane = 4f;
        label_142:
        val_85 = val_58.transform;
        val_8 = 0;
        val_109 = 0f;
        val_107 = 0f;
        val_108 = 0f;
        val_85.localPosition = new UnityEngine.Vector3() {x = val_109, y = val_107, z = val_108};
        goto label_148;
        label_143:
        val_58.orthographicSize = 1f;
        val_58.nearClipPlane = -10f;
        label_144:
        val_109 = 10f;
        val_58.farClipPlane = val_109;
        label_148:
        if((不丌丂丁丄一与丆丙.不丑万三丞丟丛丅且<UnityEngine.AudioListener>()) != null)
        {
                if(val_64.Length != 0)
        {
            goto label_152;
        }
        
        }
        
        val_85 = val_58.gameObject;
        UnityEngine.AudioListener val_66 = val_85.AddComponent<UnityEngine.AudioListener>();
        label_152:
        label_114:
        if(val_24 != 0)
        {
            goto label_159;
        }
        
        goto label_172;
        label_165:
        val_110 = val_24.parent;
        label_159:
        if(val_110.parent != 0)
        {
            goto label_165;
        }
        
        val_85 = 1152921505093320704;
        if((不丌丂丁丄一与丆丙.丛丂不丞丄东东丆丙(丈东丘丏与丌东东下:  val_110, 不七丘丘丒万七丄丒:  val_84.gameObject.AddComponent<UIPanel>().transform)) != false)
        {
                val_111 = val_110.gameObject;
            UIPanel val_76 = val_111.AddComponent<UIPanel>();
        }
        else
        {
                val_110.parent = val_76.transform;
            UnityEngine.Vector3 val_78 = UnityEngine.Vector3.one;
            val_110.localScale = new UnityEngine.Vector3() {x = val_78.x, y = val_78.y, z = val_78.z};
            UnityEngine.Vector3 val_79 = UnityEngine.Vector3.zero;
            val_94 = val_79.x;
            val_95 = val_79.z;
            val_110.localPosition = new UnityEngine.Vector3() {x = val_94, y = val_79.y, z = val_95};
            val_111 = val_76.cachedTransform;
            不丌丂丁丄一与丆丙.三专丘专与东丌丅上(丙丒七丄上与丏丙丙:  val_111, 且丅丟丛丛万丝下上:  val_76.cachedGameObject.layer);
        }
        
        label_172:
        val_92 = val_76;
        return val_92;
    }
    public static void 三专丘专与东丌丅上(UnityEngine.Transform 丙丒七丄上与丏丙丙, int 且丅丟丛丛万丝下上)
    {
        goto label_1;
        label_9:
        丙丒七丄上与丏丙丙.GetChild(index:  0).gameObject.layer = 且丅丟丛丛万丝下上;
        0 = 1;
        label_1:
        if(0 < 丙丒七丄上与丏丙丙.childCount)
        {
            goto label_9;
        }
    
    }
    public static T 丗上世丑丘业丆七一<T>(UnityEngine.GameObject 丈东丘丏与丌东东下)
    {
        UnityEngine.GameObject val_1 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  丈东丘丏与丌东东下);
        if(val_1 != null)
        {
                val_1.name = __RuntimeMethodHiddenParam + 48;
        }
        else
        {
                val_1.name = __RuntimeMethodHiddenParam + 48;
        }
    
    }
    public static T 丗上世丑丘业丆七一<T>(UnityEngine.GameObject 丈东丘丏与丌东东下, bool 丞丆丏专且不丂上业)
    {
        丞丆丏专且不丂上业 = 丞丆丏专且不丂上业;
        UnityEngine.GameObject val_1 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丞丆丏专且不丂上业:  丞丆丏专且不丂上业);
        if(val_1 != null)
        {
                val_1.name = __RuntimeMethodHiddenParam + 48;
        }
        else
        {
                val_1.name = __RuntimeMethodHiddenParam + 48;
        }
    
    }
    public static T 丞丝业一丟世丒上且<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丟丕丞丁丝丂上丄上 = 2147483647)
    {
        int val_2 = 丟丕丞丁丝丂上丄上;
        if(val_2 == 2147483647)
        {
                val_2 = 不丌丂丁丄一与丆丙.丒与万丘且丕丙丏丛(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业);
        }
        
        if(丝三丁东丈丒世丅业 != null)
        {
                丝三丁东丈丒世丅业.width = 100;
            丝三丁东丈丒世丅业.height = 100;
        }
        else
        {
                丝三丁东丈丒世丅业.width = 100;
            丝三丁东丈丒世丅业.height = 100;
        }
        
        丝三丁东丈丒世丅业.depth = val_2;
        return (object)丝三丁东丈丒世丅业;
    }
    public static UISprite 世丑丒万不丕丕三丆(UnityEngine.GameObject 丝三丁东丈丒世丅业, UIAtlas 不丗丐丘业专丂丝上, string 万丑丞一丝丌丐丒丘, int 丟丕丞丁丝丂上丄上 = 2147483647)
    {
        var val_5;
        丒三丝一上丙专丗丒 val_6;
        val_5 = 0;
        if(不丗丐丘业专丂丝上 != 0)
        {
                val_5 = 不丗丐丘业专丂丝上.GetSprite(丒丘丏上丙丟丑丕丈:  万丑丞一丝丌丐丒丘);
        }
        
        UISprite val_3 = 不丌丂丁丄一与丆丙.丞丝业一丟世丒上且<UISprite>(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上);
        if((val_5 == null) || (val_5.hasBorder == false))
        {
            goto label_8;
        }
        
        val_6 = 1;
        if(val_3 != null)
        {
            goto label_9;
        }
        
        goto label_11;
        label_8:
        val_6 = 0;
        if(val_3 == null)
        {
            goto label_11;
        }
        
        label_9:
        val_3.type = val_6;
        val_3.atlas = 不丗丐丘业专丂丝上;
        val_3.spriteName = 万丑丞一丝丌丐丒丘;
        return val_3;
        label_11:
    }
    public static UnityEngine.GameObject 丅丟东不三丘七丑丙(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        UnityEngine.Transform val_1 = 丝三丁东丈丒世丅业.transform;
        do
        {
        
        }
        while(val_1.parent != 0);
        
        if(val_1 != null)
        {
                return val_1.gameObject;
        }
        
        return val_1.gameObject;
    }
    public static T 东丙丗一丄上不丙与<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丕丗丆丕丈丑东丆丈 = -1)
    {
        UnityEngine.Object val_11;
        UnityEngine.Object val_12;
        val_11 = 0;
        if(丝三丁东丈丒世丅业 == 0)
        {
                return (ContextMenuBase)val_11;
        }
        
        val_11 = 丝三丁东丈丒世丅业;
        if(val_11 != 0)
        {
                return (ContextMenuBase)val_11;
        }
        
        val_12 = 丝三丁东丈丒世丅业.transform.parent;
        int val_11 = 丕丗丆丕丈丑东丆丈;
        goto label_10;
        label_20:
        var val_7 = (val_11 != 0) ? 1 : 0;
        if(val_11 != 0)
        {
                return (ContextMenuBase)val_11;
        }
        
        val_7 = ((丕丗丆丕丈丑东丆丈 == 1) ? 1 : 0) | val_7;
        if((val_7 & 1) == 0)
        {
                return (ContextMenuBase)val_11;
        }
        
        val_11 = val_12.gameObject;
        val_12 = val_12.parent;
        val_11 = val_11 - 1;
        label_10:
        if(val_12 != 0)
        {
            goto label_20;
        }
        
        return (ContextMenuBase)val_11;
    }
    public static T 东丙丗一丄上不丙与<T>(UnityEngine.Transform 丄上七丟不丗丕下丟)
    {
        if(丄上七丟不丗丕下丟 == 0)
        {
                return 0;
        }
        
        if(丄上七丟不丗丕下丟 == null)
        {
            
        }
    
    }
    public static void Destroy(UnityEngine.Object 万且万且丑丗且丌丆)
    {
        var val_8;
        var val_9;
        if((UnityEngine.Object.op_Implicit(exists:  万且万且丑丗且丌丆)) == false)
        {
                return;
        }
        
        if(万且万且丑丗且丌丆 != null)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_8;
        }
        
        val_8 = null;
        goto label_11;
        label_8:
        val_9 = null;
        goto label_14;
        label_7:
        if(UnityEngine.Application.isPlaying == false)
        {
            goto label_15;
        }
        
        万且万且丑丗且丌丆.transform.parent = 0;
        val_8 = null;
        label_11:
        UnityEngine.Object.Destroy(obj:  万且万且丑丗且丌丆);
        return;
        label_15:
        val_9 = null;
        label_14:
        UnityEngine.Object.DestroyImmediate(obj:  万且万且丑丗且丌丆);
    }
    public static void 丐丛丛丆万下丒一丂(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        UnityEngine.Object val_6;
        bool val_1 = UnityEngine.Application.isPlaying;
        goto label_8;
        label_13:
        UnityEngine.Transform val_2 = 丙丒七丄上与丏丙丙.GetChild(index:  0);
        if(val_2 == null)
        {
            goto label_3;
        }
        
        if(val_1 == false)
        {
            goto label_4;
        }
        
        label_9:
        val_2.parent = 0;
        val_6 = val_2.gameObject;
        UnityEngine.Object.Destroy(obj:  val_6);
        goto label_8;
        label_3:
        if(val_1 == true)
        {
            goto label_9;
        }
        
        label_4:
        val_6 = val_2.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  val_6);
        label_8:
        if(丙丒七丄上与丏丙丙.childCount != 0)
        {
            goto label_13;
        }
    
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
    public static void 丟丅丄与不与丝专且(string 且丁三丙丄一世不七)
    {
        int val_4;
        var val_5;
        if(val_2.Length < 1)
        {
                return;
        }
        
        val_4 = val_2.Length & 4294967295;
        val_5 = 0;
        goto label_7;
        label_10:
        val_4 = val_2.Length;
        val_5 = 1;
        label_7:
        X21.SendMessage(methodName:  且丁三丙丄一世不七, options:  1);
        if((val_4 - 1) != val_5)
        {
            goto label_10;
        }
    
    }
    public static void 丟丅丄与不与丝专且(string 且丁三丙丄一世不七, object 丂丐丄丁丆与丈丂上)
    {
        int val_4;
        var val_5;
        if(val_2.Length < 1)
        {
                return;
        }
        
        val_4 = val_2.Length & 4294967295;
        val_5 = 0;
        goto label_7;
        label_10:
        val_4 = val_2.Length;
        val_5 = 1;
        label_7:
        X22.SendMessage(methodName:  且丁三丙丄一世不七, value:  丂丐丄丁丆与丈丂上, options:  1);
        if((val_4 - 1) != val_5)
        {
            goto label_10;
        }
    
    }
    public static bool 丛丂不丞丄东东丆丙(UnityEngine.Transform 丈东丘丏与丌东东下, UnityEngine.Transform 不七丘丘丒万七丄丒)
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = 不七丘丘丒万七丄丒;
        if(丈东丘丏与丌东东下 == 0)
        {
            goto label_11;
        }
        
        if(val_6 != 0)
        {
            goto label_6;
        }
        
        goto label_11;
        label_14:
        val_6 = val_6.parent;
        label_6:
        if(val_6 == 0)
        {
            goto label_11;
        }
        
        if(val_6 != 丈东丘丏与丌东东下)
        {
            goto label_14;
        }
        
        val_7 = 1;
        return (bool)val_7;
        label_11:
        val_7 = 0;
        return (bool)val_7;
    }
    private static void 一与丙业丐三丙丟丆(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        不丌丂丁丄一与丆丙.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  丙丒七丄上与丏丙丙, 与丟丗下丌丐丕丛丁:  false);
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
        label_11:
        if(val_8 >= 丙丒七丄上与丏丙丙.childCount)
        {
            goto label_8;
        }
        
        val_8 = val_8 + 1;
        if((丙丒七丄上与丏丙丙.GetChild(index:  0).gameObject.activeSelf) == false)
        {
            goto label_11;
        }
        
        return;
        label_8:
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
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        不丌丂丁丄一与丆丙.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丝三丁东丈丒世丅业, 丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛, 与丟丗下丌丐丕丛丁:  true);
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
                不丌丂丁丄一与丆丙.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  val_2, 与丟丗下丌丐丕丛丁:  与丟丗下丌丐丕丛丁);
            return;
        }
        
        不丌丂丁丄一与丆丙.Deactivate(丙丒七丄上与丏丙丙:  val_2);
    }
    private static void 丕丞丈丞丂丘万专丅(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
    
    }
    public static void 业丞且不丂丒丆上丝(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        bool val_5 = 丏业丟一东丂东丘丛;
        UnityEngine.Transform val_1 = 丝三丁东丈丒世丅业.transform;
        int val_2 = val_1.childCount;
        if(val_5 != false)
        {
                if(val_2 < 1)
        {
                return;
        }
        
            do
        {
            不丌丂丁丄一与丆丙.一与丙业丐三丙丟丆(丙丒七丄上与丏丙丙:  val_1.GetChild(index:  0));
            val_5 = 0 + 1;
        }
        while(val_2 != val_5);
        
            return;
        }
        
        if(val_2 < 1)
        {
                return;
        }
        
        do
        {
            不丌丂丁丄一与丆丙.Deactivate(丙丒七丄上与丏丙丙:  val_1.GetChild(index:  0));
            val_5 = 0 + 1;
        }
        while(val_2 != val_5);
    
    }
    public static bool 丅业东万丌丕上丌丄(UnityEngine.Behaviour 不丗上三丛丒上东丑)
    {
        if(不丗上三丛丒上东丑 == 0)
        {
                return false;
        }
        
        if(不丗上三丛丒上东丑.enabled == false)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = 不丗上三丛丒上东丑.gameObject;
        if(val_3 != null)
        {
                return val_3.activeInHierarchy;
        }
        
        return val_3.activeInHierarchy;
    }
    public static bool 世三丅不丄丂丒丕上(UnityEngine.Behaviour 不丗上三丛丒上东丑)
    {
        if((UnityEngine.Object.op_Implicit(exists:  不丗上三丛丒上东丑)) == false)
        {
                return false;
        }
        
        if(不丗上三丛丒上东丑.enabled == false)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = 不丗上三丛丒上东丑.gameObject;
        if(val_3 != null)
        {
                return val_3.activeInHierarchy;
        }
        
        return val_3.activeInHierarchy;
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
    public static void 丝与丒丞丒丛丑世丟(UnityEngine.GameObject 丝三丁东丈丒世丅业, bool 丏业丟一东丂东丘丛)
    {
        丏业丟一东丂东丘丛 = 丏业丟一东丂东丘丛;
        丝三丁东丈丒世丅业.SetActive(value:  丏业丟一东丂东丘丛);
    }
    public static void 下且下丐专丑且丁丐(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 且丅丟丛丛万丝下上)
    {
        if(丝三丁东丈丒世丅业 != null)
        {
                丝三丁东丈丒世丅业.layer = 且丅丟丛丛万丝下上;
        }
        else
        {
                0.layer = 且丅丟丛丛万丝下上;
        }
        
        UnityEngine.Transform val_1 = 丝三丁东丈丒世丅业.transform;
        int val_2 = val_1.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        var val_5 = 0;
        do
        {
            UnityEngine.GameObject val_4 = val_1.GetChild(index:  0).gameObject;
            val_5 = val_5 + 1;
        }
        while(val_2 != val_5);
    
    }
    public static UnityEngine.Vector3 丅丝丂丟丗专世丄丄(UnityEngine.Vector3 业下丌下三丕丙丌下)
    {
        var val_1;
        var val_5;
        float val_6;
        var val_8;
        float val_9;
        var val_11;
        float val_12;
        if(业下丌下三丕丙丌下.x >= 0f)
        {
            goto label_3;
        }
        
        if((double)业下丌下三丕丙丌下.x != (-0.5))
        {
            goto label_4;
        }
        
        val_5 = val_1;
        val_6 = -1f;
        goto label_5;
        label_3:
        if((double)业下丌下三丕丙丌下.x != 0.5)
        {
            goto label_6;
        }
        
        val_5 = val_1;
        val_6 = 1f;
        label_5:
        val_6 = (float)val_5 + val_6;
        var val_2 = (((long)val_5 & 1) != 0) ? ((float)val_5) : (val_6);
        goto label_8;
        label_4:
        float val_5 = -0.5f;
        val_5 = 业下丌下三丕丙丌下.x + val_5;
        goto label_8;
        label_6:
        float val_6 = 0.5f;
        val_6 = 业下丌下三丕丙丌下.x + val_6;
        label_8:
        if(业下丌下三丕丙丌下.y >= 0f)
        {
            goto label_9;
        }
        
        if((double)业下丌下三丕丙丌下.y != (-0.5))
        {
            goto label_10;
        }
        
        val_8 = val_1;
        val_9 = -1f;
        goto label_11;
        label_9:
        if((double)业下丌下三丕丙丌下.y != 0.5)
        {
            goto label_12;
        }
        
        val_8 = val_1;
        val_9 = 1f;
        label_11:
        val_9 = (float)val_8 + val_9;
        var val_3 = (((long)val_8 & 1) != 0) ? ((float)val_8) : (val_9);
        goto label_14;
        label_10:
        float val_7 = -0.5f;
        val_7 = 业下丌下三丕丙丌下.y + val_7;
        goto label_14;
        label_12:
        float val_8 = 0.5f;
        val_8 = 业下丌下三丕丙丌下.y + val_8;
        label_14:
        if(业下丌下三丕丙丌下.z >= 0f)
        {
            goto label_15;
        }
        
        if((double)业下丌下三丕丙丌下.z != (-0.5))
        {
            goto label_16;
        }
        
        val_11 = val_1;
        val_12 = -1f;
        goto label_17;
        label_15:
        if((double)业下丌下三丕丙丌下.z != 0.5)
        {
            goto label_18;
        }
        
        val_11 = val_1;
        val_12 = 1f;
        label_17:
        val_12 = (float)val_11 + val_12;
        var val_4 = (((long)val_11 & 1) != 0) ? ((float)val_11) : (val_12);
        return new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z};
        label_16:
        float val_9 = -0.5f;
        val_9 = 业下丌下三丕丙丌下.z + val_9;
        return new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z};
        label_18:
        float val_10 = 0.5f;
        val_10 = 业下丌下三丕丙丌下.z + val_10;
        return new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z};
    }
    public static void 丛丁丝丙丑丆丗丑业(UnityEngine.Transform 丙丒七丄上与丏丙丙)
    {
        var val_13;
        float val_14;
        float val_15;
        float val_16;
        val_13 = 1152921504848912384;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  丙丒七丄上与丏丙丙.GetComponent<UIWidget>(), y:  0);
        if(((丙丒七丄上与丏丙丙.GetComponent<UIAnchor>()) == 0) && ((丙丒七丄上与丏丙丙.GetComponent<UIRoot>()) == 0))
        {
                UnityEngine.Vector3 val_7 = 丙丒七丄上与丏丙丙.localPosition;
            UnityEngine.Vector3 val_8 = 不丌丂丁丄一与丆丙.丅丝丂丟丗专世丄丄(业下丌下三丕丙丌下:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            if(丙丒七丄上与丏丙丙 != null)
        {
                val_14 = val_8.x;
            val_15 = val_8.y;
            val_16 = val_8.z;
            丙丒七丄上与丏丙丙.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
        }
        else
        {
                val_14 = val_8.x;
            val_15 = val_8.y;
            val_16 = val_8.z;
            0.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
        }
        
            UnityEngine.Vector3 val_9 = 丙丒七丄上与丏丙丙.localScale;
            UnityEngine.Vector3 val_10 = 不丌丂丁丄一与丆丙.丅丝丂丟丗专世丄丄(业下丌下三丕丙丌下:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            丙丒七丄上与丏丙丙.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        
        int val_11 = 丙丒七丄上与丏丙丙.childCount;
        if(val_11 < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Transform val_12 = 丙丒七丄上与丏丙丙.GetChild(index:  0);
            val_13 = 0 + 1;
        }
        while(val_11 != val_13);
    
    }
    public static bool 丂且不业丂专丛丆东(string 丝丈丝丆世丁丄专丂, byte[] 丝丆丁丞丛三丁丑丙)
    {
        string val_2 = UnityEngine.Application.persistentDataPath + "/"("/") + 丝丈丝丆世丁丄专丂;
        if(丝丆丁丞丛三丁丑丙 != null)
        {
                System.IO.File.Create(path:  val_2).Close();
            return true;
        }
        
        if((System.IO.File.Exists(path:  val_2)) == false)
        {
                return true;
        }
        
        System.IO.File.Delete(path:  val_2);
        return true;
    }
    public static byte[] Load(string 丝丈丝丆世丁丄专丂)
    {
        string val_2 = UnityEngine.Application.persistentDataPath + "/"("/") + 丝丈丝丆世丁丄专丂;
        if((System.IO.File.Exists(path:  val_2)) == false)
        {
                return 0;
        }
        
        return System.IO.File.ReadAllBytes(path:  val_2);
    }
    public static UnityEngine.Color 下丑与且丅丛丁丄丒(UnityEngine.Color 丁丂专业丁丅丅丈丙)
    {
        if(丁丂专业丁丅丅丈丙.a == 1f)
        {
                return new UnityEngine.Color() {r = 丁丂专业丁丅丅丈丙.r, g = 丁丂专业丁丅丅丈丙.g, b = 丁丂专业丁丅丅丈丙.b, a = 丁丂专业丁丅丅丈丙.a};
        }
        
        丁丂专业丁丅丅丈丙.r = 丁丂专业丁丅丅丈丙.r * 丁丂专业丁丅丅丈丙.a;
        丁丂专业丁丅丅丈丙.g = 丁丂专业丁丅丅丈丙.g * 丁丂专业丁丅丅丈丙.a;
        丁丂专业丁丅丅丈丙.b = 丁丂专业丁丅丅丈丙.b * 丁丂专业丁丅丅丈丙.a;
        return new UnityEngine.Color() {r = 丁丂专业丁丅丅丈丙.r, g = 丁丂专业丁丅丅丈丙.g, b = 丁丂专业丁丅丅丈丙.b, a = 丁丂专业丁丅丅丈丙.a};
    }
    public static void 东丘东丏丑丛东丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        int val_3;
        var val_4;
        if(val_1.Length < 1)
        {
                return;
        }
        
        val_3 = val_1.Length & 4294967295;
        val_4 = 0;
        goto label_4;
        label_7:
        val_3 = val_1.Length;
        val_4 = 1;
        label_4:
        if((val_3 - 1) != val_4)
        {
            goto label_7;
        }
    
    }
    public static string 丞一丆上丝丕上三一()
    {
        UnityEngine.TextEditor val_1 = new UnityEngine.TextEditor();
        if(val_1 != null)
        {
                bool val_2 = val_1.Paste();
            return val_1.text;
        }
        
        bool val_3 = val_1.Paste();
        return val_1.text;
    }
    public static void 丐丅丟丕世丈业丑七(string 丙业与丙丗丝不丈东)
    {
        UnityEngine.TextEditor val_1 = new UnityEngine.TextEditor();
        if(val_1 != null)
        {
                val_1.text = 丙业与丙丗丝不丈东;
            val_1.OnFocus();
        }
        else
        {
                val_1.text = 丙业与丙丗丝不丈东;
            val_1.OnFocus();
        }
        
        val_1.Copy();
    }
    public static string 丁三丆上与丆丞丟丝(UnityEngine.Color 丁丂专业丁丅丅丈丙)
    {
        return 丐丄七丙丁丆丁专丏.丆丗丂丟七丘东三丙(丁丂专业丁丅丅丈丙:  new UnityEngine.Color() {r = 丁丂专业丁丅丅丈丙.r, g = 丁丂专业丁丅丅丈丙.g, b = 丁丂专业丁丅丅丈丙.b, a = 丁丂专业丁丅丅丈丙.a});
    }
    public static UnityEngine.Color 世丝不丄且丅且丏丈(string 丕丗丘丑丛与丑业丒, int 丛上丙丄丄七丈且丅)
    {
        return 丐丄七丙丁丆丁专丏.丒丒丂三丙东万专丁(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丛上丙丄丄七丈且丅:  丛上丙丄丄七丈且丅);
    }
    public static string 丂丞世丐丌丑丕下三(string 丕丗丘丑丛与丑业丒)
    {
        return 丐丄七丙丁丆丁专丏.丂丞世丐丌丑丕下三(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
    }
    public static T 丒丘丏不丄丌丂丌丄<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        var val_7;
        UnityEngine.Object val_8;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = 丝三丁东丈丒世丅业;
        if(val_8 != 0)
        {
                return (object)val_8;
        }
        
        val_7 = ???;
        val_8 = ???;
        goto __RuntimeMethodHiddenParam + 48 + 16;
    }
    public static UnityEngine.Vector3[] 万丆上世丁丐丂丌丈(UnityEngine.Camera 业丆丆东丂与万丅不)
    {
        float val_5;
        if(业丆丆东丂与万丅不 != null)
        {
                val_5 = 业丆丆东丂与万丅不.nearClipPlane;
            return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5 = 0.nearClipPlane, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  0);
        }
        
        return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  0);
    }
    public static UnityEngine.Vector3[] 万丆上世丁丐丂丌丈(UnityEngine.Camera 业丆丆东丂与万丅不, float 丟丕丞丁丝丂上丄上)
    {
        return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上, 一世丛下丘东世专丈:  0);
    }
    public static UnityEngine.Vector3[] 万丆上世丁丐丂丌丈(UnityEngine.Camera 业丆丆东丂与万丅不, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        float val_5;
        if(业丆丆东丂与万丅不 != null)
        {
                val_5 = 业丆丆东丂与万丅不.nearClipPlane;
            return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5 = 0.nearClipPlane, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        return 不丌丂丁丄一与丆丙.万丆上世丁丐丂丌丈(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  一世丛下丘东世专丈);
    }
    public static UnityEngine.Vector3[] 万丆上世丁丐丂丌丈(UnityEngine.Camera 业丆丆东丂与万丅不, float 丟丕丞丁丝丂上丄上, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        float val_28;
        float val_29;
        var val_30;
        UnityEngine.Vector3[] val_31;
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_28 = 丟丕丞丁丝丂上丄上;
        if(业丆丆东丂与万丅不.orthographic == false)
        {
            goto label_2;
        }
        
        if(业丆丆东丂与万丅不 == null)
        {
            goto label_3;
        }
        
        val_29 = 业丆丆东丂与万丅不.orthographicSize;
        goto label_4;
        label_2:
        val_30 = null;
        val_30 = null;
        UnityEngine.Vector3 val_3 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_3.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_3.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_3.z;
        UnityEngine.Vector3 val_4 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_2C = val_4.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_30 = val_4.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_34 = val_4.z;
        UnityEngine.Vector3 val_5 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_38 = val_5.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_3C = val_5.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_40 = val_5.z;
        val_31 = 不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三;
        UnityEngine.Vector3 val_6 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_35 = val_6.x;
        val_36 = val_6.y;
        val_37 = val_6.z;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_44 = val_35;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_48 = val_36;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_4C = val_37;
        goto label_19;
        label_3:
        val_29 = 0.orthographicSize;
        label_4:
        UnityEngine.Rect val_8 = 业丆丆东丂与万丅不.rect;
        val_31 = 1152921505093320704;
        UnityEngine.Vector2 val_9 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        val_38 = val_9.x;
        val_39 = val_9.y;
        if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_40 = null;
            val_40 = null;
            float val_28 = IphoneXCameraScaler.不丅七丘丈不丌丝丏;
            val_28 = val_28 * val_38;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_28, y:  val_39);
            val_38 = val_11.x;
            val_39 = val_11.y;
        }
        
        float val_31 = val_28;
        UnityEngine.Transform val_12 = 业丆丆东丂与万丅不.transform;
        UnityEngine.Quaternion val_13 = val_12.rotation;
        UnityEngine.Vector3 val_14 = val_12.position;
        val_39 = val_38 / val_39;
        if(((UnityEngine.Mathf.RoundToInt(f:  val_11.x)) & 1) != 0)
        {
                float val_29 = val_11.x;
            val_29 = (-1f) / val_29;
            float val_30 = val_14.x;
            val_30 = val_30 + val_29;
        }
        
        val_31 = val_39 * (val_28 / val_31);
        if(((UnityEngine.Mathf.RoundToInt(f:  val_11.y)) & 1) != 0)
        {
                float val_32 = val_11.y;
            val_32 = 1f / val_32;
            float val_33 = val_14.y;
            val_33 = val_33 + val_32;
        }
        
        val_41 = null;
        val_39 = val_31 * (-val_29);
        val_28 = val_13.x;
        val_41 = null;
        UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_28, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_30, y = val_33, z = val_14.z});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_19.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_19.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_19.z;
        UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_28, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_30, y = val_33, z = val_14.z});
        val_31 = val_29 * val_31;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_2C = val_21.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_30 = val_21.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_34 = val_21.z;
        UnityEngine.Vector3 val_22 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_28, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_30, y = val_33, z = val_14.z});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_38 = val_23.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_3C = val_23.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_40 = val_23.z;
        UnityEngine.Vector3 val_24 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_28, y = val_13.y, z = val_13.z, w = val_13.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_30, y = val_33, z = val_14.z});
        val_35 = val_25.x;
        val_36 = val_25.y;
        val_37 = val_25.z;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_44 = val_35;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_48 = val_36;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_4C = val_37;
        label_19:
        if(一世丛下丘东世专丈 != 0)
        {
                var val_34 = 0;
            do
        {
            val_42 = null;
            val_42 = null;
            UnityEngine.Vector3 val_27 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = X24 + 32, y = X24 + 32 + 4, z = X24 + 40});
            val_35 = val_27.x;
            val_37 = val_27.z;
            val_31 = 0 + 1;
            val_34 = val_34 + 12;
            mem2[0] = val_35;
            mem2[0] = val_27.y;
            mem2[0] = val_37;
        }
        while(val_31 != 4);
        
        }
        
        val_43 = null;
        val_43 = null;
        return (UnityEngine.Vector3[])不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三;
    }
    public static UnityEngine.Vector3[] 丁丗不东东上下三丒(UnityEngine.Camera 业丆丆东丂与万丅不)
    {
        float val_5;
        if(业丆丆东丂与万丅不 != null)
        {
                val_5 = 业丆丆东丂与万丅不.nearClipPlane;
            return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5 = 0.nearClipPlane, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  0);
        }
        
        return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  0);
    }
    public static UnityEngine.Vector3[] 丁丗不东东上下三丒(UnityEngine.Camera 业丆丆东丂与万丅不, float 丟丕丞丁丝丂上丄上)
    {
        return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  丟丕丞丁丝丂上丄上, 一世丛下丘东世专丈:  0);
    }
    public static UnityEngine.Vector3[] 丁丗不东东上下三丒(UnityEngine.Camera 业丆丆东丂与万丅不, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        float val_5;
        if(业丆丆东丂与万丅不 != null)
        {
                val_5 = 业丆丆东丂与万丅不.nearClipPlane;
            return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5 = 0.nearClipPlane, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  一世丛下丘东世专丈);
        }
        
        return 不丌丂丁丄一与丆丙.丁丗不东东上下三丒(业丆丆东丂与万丅不:  业丆丆东丂与万丅不, 丟丕丞丁丝丂上丄上:  UnityEngine.Mathf.Lerp(a:  val_5, b:  业丆丆东丂与万丅不.farClipPlane, t:  0.5f), 一世丛下丘东世专丈:  一世丛下丘东世专丈);
    }
    public static UnityEngine.Vector3[] 丁丗不东东上下三丒(UnityEngine.Camera 业丆丆东丂与万丅不, float 丟丕丞丁丝丂上丄上, UnityEngine.Transform 一世丛下丘东世专丈)
    {
        float val_24;
        var val_25;
        UnityEngine.Vector3[] val_26;
        float val_30;
        float val_31;
        float val_32;
        var val_33;
        var val_34;
        if(业丆丆东丂与万丅不.orthographic == false)
        {
            goto label_2;
        }
        
        if(业丆丆东丂与万丅不 == null)
        {
            goto label_3;
        }
        
        val_24 = 业丆丆东丂与万丅不.orthographicSize;
        goto label_4;
        label_2:
        val_25 = null;
        val_25 = null;
        UnityEngine.Vector3 val_3 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_3.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_3.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_3.z;
        UnityEngine.Vector3 val_4 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_2C = val_4.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_30 = val_4.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_34 = val_4.z;
        UnityEngine.Vector3 val_5 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_38 = val_5.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_3C = val_5.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_40 = val_5.z;
        val_26 = 不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三;
        UnityEngine.Vector3 val_6 = 业丆丆东丂与万丅不.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_30 = val_6.x;
        val_31 = val_6.y;
        val_32 = val_6.z;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_44 = val_30;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_48 = val_31;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_4C = val_32;
        goto label_19;
        label_3:
        val_24 = 0.orthographicSize;
        label_4:
        UnityEngine.Rect val_8 = 业丆丆东丂与万丅不.rect;
        val_26 = 1152921505093320704;
        UnityEngine.Vector2 val_9 = 不丌丂丁丄一与丆丙.一业丝丂东下丁丄丗();
        float val_24 = val_9.x;
        val_24 = val_24 / val_9.x;
        val_24 = (val_9.x / val_9.y) * val_24;
        UnityEngine.Transform val_11 = 业丆丆东丂与万丅不.transform;
        val_24 = val_24 * (-val_24);
        UnityEngine.Quaternion val_12 = val_11.rotation;
        UnityEngine.Vector3 val_13 = val_11.position;
        UnityEngine.Vector3 val_14 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_20 = val_15.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_24 = val_15.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_28 = val_15.z;
        float val_25 = val_24;
        UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_25 = val_25 * val_24;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_2C = val_17.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_30 = val_17.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_34 = val_17.z;
        UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_38 = val_19.x;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_3C = val_19.y;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_40 = val_19.z;
        UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        val_30 = val_21.x;
        val_31 = val_21.y;
        val_32 = val_21.z;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_44 = val_30;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_48 = val_31;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三.__unknownFiledOffset_4C = val_32;
        label_19:
        if(一世丛下丘东世专丈 != 0)
        {
                var val_26 = 0;
            do
        {
            val_33 = null;
            val_33 = null;
            UnityEngine.Vector3 val_23 = 一世丛下丘东世专丈.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = X24 + 32, y = X24 + 32 + 4, z = X24 + 40});
            val_30 = val_23.x;
            val_32 = val_23.z;
            val_26 = 0 + 1;
            val_26 = val_26 + 12;
            mem2[0] = val_30;
            mem2[0] = val_23.y;
            mem2[0] = val_32;
        }
        while(val_26 != 4);
        
        }
        
        val_34 = null;
        val_34 = null;
        return (UnityEngine.Vector3[])不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三;
    }
    public static string 世丗世丁下丅丆丕丕(object 万且万且丑丗且丌丆, string 丛丌丙世专世东丕下)
    {
        string val_6;
        if(万且万且丑丗且丌丆 != null)
        {
                val_6 = 万且万且丑丗且丌丆.GetType();
            int val_2 = val_6.LastIndexOf(value:  '/');
            if(val_2 >= 1)
        {
                val_6 = val_6.Substring(startIndex:  val_2 + 1);
        }
        
            if((System.String.IsNullOrEmpty(value:  丛丌丙世专世东丕下)) == true)
        {
                return (string)val_6;
        }
        
            return val_6 + "/"("/") + 丛丌丙世专世东丕下;
        }
        
        val_6 = "<null>";
        return (string)val_6;
    }
    public static void 丞丙东丌一三专丏不<T>(UnityEngine.GameObject 丝三丁东丈丒世丅业, string 且丁三丙丄一世不七)
    {
        var val_5;
        var val_6;
        val_5 = __RuntimeMethodHiddenParam;
        val_6 = 0;
        goto label_1;
        label_8:
        System.Reflection.MethodInfo val_2 = UnityEngine.GameObject.__il2cppRuntimeField_byval_arg.GetType().GetMethod(name:  且丁三丙丄一世不七, bindingAttr:  52);
        if((System.Reflection.MethodInfo.op_Inequality(left:  val_2, right:  0)) != false)
        {
                object val_4 = val_2.Invoke(obj:  UnityEngine.GameObject.__il2cppRuntimeField_byval_arg, parameters:  0);
        }
        
        val_6 = 1;
        label_1:
        if(val_6 < null)
        {
            goto label_8;
        }
    
    }
    public static void 三丗丗万三丏三专丗<T>(UnityEngine.GameObject 七万上丐一丈丏丏专, string 且丁三丙丄一世不七)
    {
        UnityEngine.Transform val_1 = 七万上丐一丈丏丏专.transform;
        int val_2 = val_1.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        var val_5 = 0;
        do
        {
            UnityEngine.GameObject val_4 = val_1.GetChild(index:  0).gameObject;
            val_5 = val_5 + 1;
        }
        while(val_2 != val_5);
    
    }
    public static void 丐丑不丗丙七丘丂丛(UnityEngine.GameObject 七万上丐一丈丏丏专)
    {
        不丌丂丁丄一与丆丙.三丗丗万三丏三专丗<UIWidget>(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 且丁三丙丄一世不七:  "Start");
        不丌丂丁丄一与丆丙.三丗丗万三丏三专丗<UIPanel>(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 且丁三丙丄一世不七:  "Start");
        不丌丂丁丄一与丆丙.三丗丗万三丏三专丗<UIWidget>(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 且丁三丙丄一世不七:  "Update");
        不丌丂丁丄一与丆丙.三丗丗万三丏三专丗<UIPanel>(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 且丁三丙丄一世不七:  "Update");
        不丌丂丁丄一与丆丙.三丗丗万三丏三专丗<UIPanel>(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 且丁三丙丄一世不七:  "LateUpdate");
    }
    public static UnityEngine.Vector2 一业丝丂东下丁丄丗()
    {
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  (float)UnityEngine.Screen.width, y:  (float)UnityEngine.Screen.height);
        return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
    }
    public static string 丟且丄丒丆上丕下丁(UnityEngine.KeyCode 下上丐丆丝丟丝丒不)
    {
        var val_3;
        if(下上丐丆丝丟丝丒不 <= 127)
        {
                var val_2 = 106041408 + (下上丐丆丝丟丝丒不) << 2;
            val_2 = val_2 + 106041408;
        }
        else
        {
                val_3 = 0;
            if((下上丐丆丝丟丝丒不 - 256) > 93)
        {
                return (string);
        }
        
            var val_3 = 106041920 + ((下上丐丆丝丟丝丒不 - 256)) << 2;
            val_3 = val_3 + 106041920;
        }
    
    }
    public static UnityEngine.Vector3 与下丆丒下丝世丝丂(UnityEngine.Transform 东丒不丘东丐丂丅业)
    {
        UnityEngine.Object val_10;
        float val_14;
        float val_15;
        float val_16;
        val_10 = 东丒不丘东丐丂丅业;
        if(val_10 == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        val_14 = val_2.x;
        val_15 = val_2.y;
        val_16 = val_2.z;
        goto label_6;
        label_17:
        if((val_10.GetComponent<UIPanel>()) != 0)
        {
                return new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
        }
        
        UnityEngine.Vector3 val_5 = val_10.localScale;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_14 = val_6.x;
        val_15 = val_6.y;
        val_16 = val_6.z;
        val_10 = val_10.parent;
        label_6:
        if(val_10 != 0)
        {
            goto label_17;
        }
        
        return new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
        label_3:
        System.ArgumentNullException val_9 = new System.ArgumentNullException();
    }
    private static 不丌丂丁丄一与丆丙()
    {
        不丌丂丁丄一与丆丙.丁丘一专丘万丛与丁 = false;
        不丌丂丁丄一与丆丙.丁丟丝丂且丙万丞丈 = 1f;
        不丌丂丁丄一与丆丙.丒丘不世丐世丌丒丗 = 0f;
        不丌丂丁丄一与丆丙.专丏丛下世丙丝丈三 = new UnityEngine.Vector3[4];
        不丌丂丁丄一与丆丙.与丟且丝丞一丘七丑 = new UnityEngine.KeyCode[145];
    }

}
