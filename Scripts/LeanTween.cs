using UnityEngine;
public class LeanTween : MonoBehaviour
{
    // Fields
    public static bool throwErrors;
    private static 丛丙丆丌七丘丘且世[] 丏且与丕丅七不丁丅;
    private static int 下世一一丝丕世三七;
    private static int 下七不丑丁丄业且丐;
    private static int 丞丏丑丌丏专丄丌丂;
    private static UnityEngine.GameObject 业丄丌业一丗业一七;
    private static float 丟丛东丁丛丁七三东;
    private static float 七上丌且丛丆业专丘;
    private static float 且丆丝世上丐上不万;
    private static float 丅丙丗专丆上丞丕一;
    private static 丛丙丆丌七丘丘且世 丞万丈丙东且丗与下;
    private static int 七丞丙丒三丕且丌丟;
    private static int 丏丂丛丙丆三专丂丛;
    private static UnityEngine.AnimationCurve 七下丈一丂七丁丏与;
    private static UnityEngine.AnimationCurve 丑业不丌丂丘与业丄;
    private static UnityEngine.Transform 丄上七丟不丗丕下丟;
    private static float 丐丁丛丙与与丟与丕;
    private static 不丞七业上七丘丑丒 丝万丕丅丆丂三丈一;
    private static float 丁丁丛丟丝不上丌三;
    private static float 丈丗与丞一上且上上;
    private static float 专丂丕丗丗东世丞下;
    private static float 下下丏一丙不丘丌丞;
    private static UnityEngine.Vector3 且东丟一丌丅丌丕丌;
    private static bool 且一丌业三不丝丁与;
    private static UnityEngine.GameObject 丞下万上三丘上与专;
    private static UnityEngine.GameObject 与丙丝一丆丛丁丑丟;
    public static int startSearch;
    public static 丛丙丆丌七丘丘且世 descr;
    private static System.Action<丐丌七丅丌下上且丏>[] 上丟世丝丏丏且丆与;
    private static UnityEngine.GameObject[] 七东万丅丒丑丄丙丌;
    private static int 丄丂且下丝不三东业;
    public static int EVENTS_MAX;
    public static int LISTENERS_MAX;
    
    // Properties
    public static UnityEngine.GameObject 专一丘丘下丆丝一一 { get; }
    
    // Methods
    public static void init()
    {
        null = null;
        LeanTween.init(丄东丛丗三丘丐丞丟:  LeanTween.下七不丑丁丄业且丐);
    }
    public static void init(int 丄东丛丗三丘丐丞丟)
    {
        int val_6;
        var val_7;
        var val_9;
        var val_10;
        val_6 = 丄东丛丗三丘丐丞丟;
        val_7 = null;
        val_7 = null;
        if(LeanTween.丏且与丕丅七不丁丅 != null)
        {
                return;
        }
        
        val_7 = null;
        LeanTween.下七不丑丁丄业且丐 = val_6;
        丛丙丆丌七丘丘且世[] val_1 = new 丛丙丆丌七丘丘且世[0];
        LeanTween.丏且与丕丅七不丁丅 = val_1;
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject();
        LeanTween.业丄丌业一丗业一七 = val_2;
        val_2.name = "~LeanTween";
        UnityEngine.Component val_4 = val_2.AddComponent(componentType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        val_2.isStatic = true;
        val_2.hideFlags = 61;
        val_6 = LeanTween.业丄丌业一丗业一七;
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        val_9 = 0;
        goto label_14;
        label_25:
        丛丙丆丌七丘丘且世 val_5 = null;
        val_6 = val_5;
        val_5 = new 丛丙丆丌七丘丘且世();
        if(LeanTween.丏且与丕丅七不丁丅 == null)
        {
            goto label_17;
        }
        
        if(val_6 != null)
        {
            goto label_18;
        }
        
        goto label_21;
        label_17:
        if(val_6 == null)
        {
            goto label_21;
        }
        
        label_18:
        丛丙丆丌七丘丘且世 val_6 = val_1[4];
        label_21:
        val_9 = 1;
        mem2[0] = val_6;
        label_14:
        val_10 = null;
        val_10 = null;
        if(val_9 < LeanTween.下七不丑丁丄业且丐)
        {
            goto label_25;
        }
    
    }
    public static void reset()
    {
        null = null;
        LeanTween.丏且与丕丅七不丁丅 = 0;
    }
    public void Update()
    {
        LeanTween.update();
    }
    public void OnLevelWasLoaded(int 丄与丘不丘七业丗一)
    {
        万丁且丒丂七丐不三.丞专丙万丕不丗丈丛();
    }
    public static void update()
    {
        int val_311;
        float val_312;
        var val_313;
        var val_314;
        丛丙丆丌七丘丘且世 val_315;
        UnityEngine.Object val_316;
        float val_317;
        float val_318;
        float val_320;
        float val_321;
        float val_322;
        float val_323;
        float val_327;
        var val_330;
        float val_331;
        float val_333;
        float val_339;
        float val_340;
        var val_341;
        不丞七业上七丘丑丒 val_344;
        var val_345;
        UnityEngine.Vector3 val_346;
        var val_347;
        var val_348;
        不丞七业上七丘丑丒 val_351;
        var val_352;
        var val_353;
        var val_354;
        var val_355;
        var val_356;
        var val_358;
        丛丙丆丌七丘丘且世 val_359;
        var val_360;
        var val_361;
        丛丙丆丌七丘丘且世 val_362;
        int val_363;
        var val_364;
        var val_365;
        var val_366;
        var val_367;
        var val_368;
        丛丙丆丌七丘丘且世 val_369;
        var val_372;
        var val_373;
        var val_374;
        var val_375;
        var val_378;
        var val_379;
        丛丙丆丌七丘丘且世 val_383;
        var val_386;
        var val_387;
        var val_389;
        var val_390;
        var val_391;
        var val_397;
        丛丙丆丌七丘丘且世 val_399;
        UnityEngine.Vector3 val_400;
        float val_401;
        var val_407;
        var val_408;
        var val_410;
        var val_411;
        var val_519;
        var val_520;
        var val_521;
        var val_522;
        UnityEngine.GameObject val_523;
        不丞七业上七丘丑丒 val_525;
        丛丙丆丌七丘丘且世 val_527;
        UnityEngine.Transform val_530;
        var val_531;
        var val_532;
        var val_533;
        UnityEngine.GameObject val_534;
        var val_535;
        var val_536;
        var val_537;
        var val_538;
        var val_539;
        var val_547;
        var val_548;
        var val_754;
        var val_755;
        UnityEngine.GameObject val_756;
        var val_757;
        var val_758;
        UnityEngine.GameObject val_759;
        var val_760;
        float val_761;
        float val_762;
        float val_763;
        var val_764;
        var val_765;
        var val_766;
        var val_767;
        var val_768;
        var val_770;
        var val_771;
        var val_772;
        UnityEngine.GameObject val_773;
        var val_805;
        var val_806;
        var val_807;
        UnityEngine.Transform val_812;
        var val_819;
        丛丙丆丌七丘丘且世 val_822;
        var val_823;
        var val_826;
        var val_827;
        var val_830;
        var val_831;
        var val_832;
        var val_833;
        var val_834;
        var val_835;
        var val_836;
        var val_837;
        var val_838;
        val_311 = LeanTween.丞丏丑丌丏专丄丌丂;
        if(val_311 == UnityEngine.Time.frameCount)
        {
                return;
        }
        
        LeanTween.init();
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        val_2 = val_2 - LeanTween.七上丌且丛丆业专丘;
        LeanTween.丟丛东丁丛丁七三东 = val_2;
        if(LeanTween.丟丛东丁丛丁七三东 > 0.2f)
        {
                LeanTween.丟丛东丁丛丁七三东 = 0.2f;
        }
        
        LeanTween.七上丌且丛丆业专丘 = UnityEngine.Time.realtimeSinceStartup;
        val_312 = UnityEngine.Time.deltaTime;
        float val_5 = UnityEngine.Time.timeScale;
        val_5 = val_312 * val_5;
        val_313 = 0;
        val_314 = 32;
        LeanTween.丅丙丗专丆上丞丕一 = val_5;
        goto label_1395;
        label_1584:
        if(val_313 >= LeanTween.下七不丑丁丄业且丐)
        {
            goto label_14;
        }
        
        val_315 = 0;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 16) == 0)
        {
            goto label_1039;
        }
        
        LeanTween.丞万丈丙东且丗与下 = LeanTween.丏且与丕丅七不丁丅.Length + 32;
        LeanTween.丄上七丟不丗丕下丟 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丄上七丟不丗丕下丟;
        LeanTween.丐丁丛丙与与丟与丕 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丂三丟丂丈丐丆丗丟;
        LeanTween.丝万丕丅丆丂三丈一 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丁丅丈丌丟世丗丗丟;
        LeanTween.且丆丝世上丐上不万 = LeanTween.丅丙丗专丆上丞丕一;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.七丙东丌丂丞丑万丅) != false)
        {
                LeanTween.且丆丝世上丐上不万 = LeanTween.丟丛东丁丛丁七三东;
            LeanTween.丐丁丛丙与与丟与丕 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丂三丟丂丈丐丆丗丟;
        }
        else
        {
                if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丞丘丘丂丏万丗丛丄) != false)
        {
                LeanTween.且丆丝世上丐上不万 = 1f;
        }
        else
        {
                if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丈丘业丛丁丏丙丘) == 0f)
        {
                LeanTween.且丆丝世上丐上不万 = 0f;
        }
        
        }
        
        }
        
        val_316 = 0;
        if(LeanTween.丄上七丟不丗丕下丟 != val_316)
        {
            goto label_51;
        }
        
        label_618:
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  0);
        goto label_1039;
        label_51:
        LeanTween.且一丌业三不丝丁与 = false;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与) > 0f)
        {
            goto label_84;
        }
        
        float val_295 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏;
        val_317 = LeanTween.且丆丝世上丐上不万;
        val_318 = LeanTween.丐丁丛丙与与丟与丕;
        val_295 = val_295 + val_317;
        if((val_295 <= val_318) || ((LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丈丘业丛丁丏丙丘) <= 0f))
        {
            goto label_66;
        }
        
        LeanTween.且一丌业三不丝丁与 = true;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_69;
        }
        
        val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 32];
        val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丂三丟丂丈丐丆丗丟;
        goto label_70;
        label_66:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丈丘业丛丁丏丙丘) >= 0)
        {
            goto label_84;
        }
        
        float val_296 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏;
        val_317 = LeanTween.且丆丝世上丐上不万;
        val_296 = val_296 - val_317;
        if(val_296 >= 0)
        {
            goto label_84;
        }
        
        LeanTween.且一丌业三不丝丁与 = true;
        丒丛七丈不丌丕世丏 = UnityEngine.Mathf.Epsilon;
        goto label_84;
        label_69:
        val_312 = 8.96831E-44f;
        label_70:
        丒丛七丈不丌丕世丏 = val_312;
        label_84:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.与业丏丆丌下丟丞上) == true)
        {
            goto label_100;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏) == 0f)
        {
                if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与) == 0f)
        {
            goto label_96;
        }
        
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏) <= 0f)
        {
            goto label_100;
        }
        
        label_96:
        与业丏丆丌下丟丞上 = true;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.七丙东丌丂丞丑万丅) != true)
        {
                if(LeanTween.丞万丈丙东且丗与下 != null)
        {
                float val_7 = UnityEngine.Time.timeScale;
        }
        else
        {
                float val_8 = UnityEngine.Time.timeScale;
        }
        
            val_8 = val_8 * (8.96831E-44f);
            mem[32] = val_8;
        }
        
        if(LeanTween.丝万丕丅丆丂三丈一 > 30)
        {
            goto label_290;
        }
        
        var val_297 = 106067856 + (LeanTween.丏且与丕丅七不丁丅.Length + 32.丁丅丈丌丟世丗丗丟) << 2;
        val_297 = val_297 + 106067856;
        goto (106067856 + (LeanTween.丏且与丕丅七不丁丅.Length + 32.丁丅丈丌丟世丗丗丟) << 2 + 106067856);
        label_290:
        val_315 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_315 = LeanTween.丞万丈丙东且丗与下;
        }
        
        val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 92];
        val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.专丂丕丗丗东世丞下;
        val_320 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 92 + 4];
        val_321 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 100];
        val_322 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 88];
        val_317 = val_320;
        val_318 = val_321;
        val_323 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丈丗与丞一上且上上;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_312, y = val_317, z = val_318}, b:  new UnityEngine.Vector3() {x = val_323, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 80 + 4], z = val_322});
        丕丙丘丂丙七丘丕丆 = val_56;
        mem2[0] = val_56.y;
        mem2[0] = val_56.z;
        label_100:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与) > 0f)
        {
            goto label_1481;
        }
        
        if(LeanTween.丐丁丛丙与与丟与丕 > 0f)
        {
                val_317 = LeanTween.丐丁丛丙与与丟与丕;
            float val_57 = (LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏) / val_317;
        }
        
        LeanTween.丁丁丛丟丝不上丌三 = 0f;
        if(LeanTween.丁丁丛丟丝不上丌三 <= 1f)
        {
            goto label_313;
        }
        
        goto label_321;
        label_313:
        if(LeanTween.丁丁丛丟丝不上丌三 >= 0)
        {
            goto label_319;
        }
        
        label_321:
        LeanTween.丁丁丛丟丝不上丌三 = 0f;
        label_319:
        if((LeanTween.丝万丕丅丆丂三丈一 & 2147483648) == 0)
        {
                if(LeanTween.丝万丕丅丆丂三丈一 <= 19)
        {
            goto label_327;
        }
        
        }
        
        if(LeanTween.丝万丕丅丆丂三丈一 < 20)
        {
            goto label_1581;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丆丁业东上丁丆丘) == null)
        {
            goto label_334;
        }
        
        val_327 = LeanTween.丁丁丛丟丝不上丌三;
        UnityEngine.Vector3 val_58 = LeanTween.一不丙丗丏业丒丏丝(上丙丛一丒丒丆丛丄:  LeanTween.丞万丈丙东且丗与下, 丁丁丛丟丝不上丌三:  val_327);
        val_330 = null;
        LeanTween.且东丟一丌丅丌丕丌 = val_58.x;
        LeanTween.throwErrors.__il2cppRuntimeField_7C = val_58.y;
        LeanTween.throwErrors.__il2cppRuntimeField_80 = val_58.z;
        goto label_1346;
        label_327:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丆丁业东上丁丆丘) == null)
        {
            goto label_341;
        }
        
        val_331 = LeanTween.丁丁丛丟丝不上丌三;
        label_1026:
        LeanTween.下下丏一丙不丘丌丞 = LeanTween.且丘丞丄丑与东不且(上丙丛一丒丒丆丛丄:  LeanTween.丞万丈丙东且丗与下, 丁丁丛丟丝不上丌三:  val_331);
        if(LeanTween.丝万丕丅丆丂三丈一 == 0)
        {
            goto label_346;
        }
        
        if(LeanTween.丝万丕丅丆丂三丈一 != 1)
        {
            goto label_349;
        }
        
        UnityEngine.Vector3 val_60 = LeanTween.丄上七丟不丗丕下丟.position;
        val_333 = val_60.x;
        UnityEngine.Vector3 val_61 = LeanTween.丄上七丟不丗丕下丟.position;
        goto label_388;
        label_334:
        if(((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂) == 1) || ((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂) < 1))
        {
            goto label_362;
        }
        
        丆丟上丝且三上丂丆 val_301 = LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂;
        val_301 = val_301 - 2;
        if(val_301 > 32)
        {
            goto label_1346;
        }
        
        var val_302 = 106068116 + ((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂 - 2)) << 2;
        val_302 = val_302 + 106068116;
        goto (106068116 + ((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂 - 2)) << 2 + 106068116);
        label_341:
        丆丟上丝且三上丂丆 val_303 = LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂;
        val_303 = val_303 - 1;
        if(val_303 > 33)
        {
            goto label_378;
        }
        
        var val_304 = 106067980 + ((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂 - 1)) << 2;
        val_304 = val_304 + 106067980;
        goto (106067980 + ((LeanTween.丏且与丕丅七不丁丅.Length + 32.三丄丙业一三丛丄丂 - 1)) << 2 + 106067980);
        label_346:
        UnityEngine.Vector3 val_63 = LeanTween.丄上七丟不丗丕下丟.position;
        val_333 = val_63.y;
        UnityEngine.Vector3 val_64 = LeanTween.丄上七丟不丗丕下丟.position;
        goto label_388;
        label_349:
        if(LeanTween.丝万丕丅丆丂三丈一 != 2)
        {
            goto label_391;
        }
        
        UnityEngine.Vector3 val_65 = LeanTween.丄上七丟不丗丕下丟.position;
        UnityEngine.Vector3 val_66 = LeanTween.丄上七丟不丗丕下丟.position;
        label_388:
        val_331 = 0f;
        val_339 = 0f;
        val_340 = 0f;
        LeanTween.丄上七丟不丗丕下丟.position = new UnityEngine.Vector3() {x = val_331, y = val_339, z = val_340};
        label_391:
        val_341 = null;
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 3)
        {
            goto label_399;
        }
        
        UnityEngine.Vector3 val_67 = LeanTween.丄上七丟不丗丕下丟.localPosition;
        val_333 = val_67.y;
        val_315 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_68 = val_315.localPosition;
        goto label_404;
        label_399:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 4)
        {
            goto label_407;
        }
        
        UnityEngine.Vector3 val_69 = LeanTween.丄上七丟不丗丕下丟.localPosition;
        val_333 = val_69.x;
        val_315 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_70 = val_315.localPosition;
        label_404:
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_413;
        }
        
        goto label_413;
        label_362:
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_416;
        }
        
        goto label_417;
        label_407:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 5)
        {
            goto label_420;
        }
        
        UnityEngine.Vector3 val_71 = LeanTween.丄上七丟不丗丕下丟.localPosition;
        UnityEngine.Vector3 val_72 = LeanTween.丄上七丟不丗丕下丟.localPosition;
        goto label_404;
        label_420:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 6)
        {
            goto label_428;
        }
        
        val_345 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.丌业丞丌丛世不丞丑) == false)
        {
            goto label_433;
        }
        
        val_315 = LeanTween.丄上七丟不丗丕下丟;
        val_316 = val_315;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.且丒丛与丞世丙丕丌(不丂丅丁且丆东东丂:  val_316, 东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1581;
        label_416:
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_439;
        }
        
        label_417:
        val_346 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 104];
        val_346 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丙丘丂丙七丘丕丆;
        label_704:
        label_705:
        val_322 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 108];
        val_315 = LeanTween.丞万丈丙东且丗与下;
        label_1413:
        val_323 = (mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 112]) * LeanTween.丁丁丛丟丝不上丌三;
        val_327 = (LeanTween.丏且与丕丅七不丁丅.Length + 32.丈丗与丞一上且上上) + (val_346 * LeanTween.丁丁丛丟丝不上丌三);
        val_347 = (mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 84]) + (val_322 * LeanTween.丁丁丛丟丝不上丌三);
        val_348 = (mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 88]) + val_323;
        val_316 = 0;
        val_330 = null;
        LeanTween.且东丟一丌丅丌丕丌 = 0;
        LeanTween.throwErrors.__il2cppRuntimeField_80 = 0;
        label_1346:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 20)
        {
            goto label_442;
        }
        
        val_333 = 0f;
        val_321 = 0f;
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_745;
        }
        
        label_746:
        label_745:
        val_316 = 0;
        LeanTween.丄上七丟不丗丕下丟.position = new UnityEngine.Vector3() {x = 0f, y = val_333, z = val_321};
        goto label_1581;
        label_442:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 21)
        {
            goto label_449;
        }
        
        val_333 = 0f;
        val_321 = 0f;
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_790;
        }
        
        label_791:
        label_790:
        label_413:
        val_316 = 0;
        LeanTween.丄上七丟不丗丕下丟.localPosition = new UnityEngine.Vector3() {x = 0f, y = val_333, z = val_321};
        label_1581:
        val_352 = null;
        val_352 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_352 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丟东七七丈丆七丗万) == null)
        {
            goto label_456;
        }
        
        val_312 = LeanTween.下下丏一丙不丘丌丞;
        label_1476:
        val_316 = public System.Void System.Action<System.Single>::Invoke(System.Single obj);
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丟东七七丈丆七丗万.Invoke(obj:  val_312);
        goto label_1481;
        label_456:
        val_352 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_352 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.且且不世丁丘上业丂) == null)
        {
            goto label_465;
        }
        
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_1587;
        }
        
        }
        
        val_312 = LeanTween.下下丏一丙不丘丌丞;
        val_315 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 248];
        val_315 = LeanTween.丏且与丕丅七不丁丅.Length + 32.一丕世丄丅上不一丌;
        label_1471:
        val_316 = val_315;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.且且不世丁丘上业丂.Invoke(arg1:  val_312, arg2:  val_316);
        goto label_1481;
        label_465:
        val_352 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_352 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丌三丏上丆丂丘与专) == null)
        {
            goto label_475;
        }
        
        val_312 = 0f;
        val_321 = 0f;
        val_315 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 248];
        val_315 = LeanTween.丏且与丕丅七不丁丅.Length + 32.一丕世丄丅上不一丌;
        label_1012:
        val_316 = val_315;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丌三丏上丆丂丘与专.Invoke(arg1:  new UnityEngine.Vector3() {x = val_312, y = 0f, z = val_321}, arg2:  val_316);
        goto label_1481;
        label_449:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 22)
        {
            goto label_484;
        }
        
        label_1490:
        LeanTween.丄上七丟不丗丕下丟.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_1581;
        label_475:
        val_352 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_352 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丞丐三上丅下丈且) == null)
        {
            goto label_492;
        }
        
        val_312 = 0f;
        val_321 = 0f;
        val_316 = public System.Void System.Action<UnityEngine.Vector3>::Invoke(UnityEngine.Vector3 obj);
        label_1385:
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丞丐三上丅下丈且.Invoke(obj:  new UnityEngine.Vector3() {x = val_312, y = 0f, z = val_321});
        label_1481:
        if(LeanTween.且一丌业三不丝丁与 == false)
        {
            goto label_499;
        }
        
        if(LeanTween.丝万丕丅丆丂三丈一 == 30)
        {
                rotateFinished = true;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.上丒一丂丞丅丏丅丂) != 35)
        {
                if((LeanTween.丏且与丕丅七不丁丅.Length + 32.世七业七一七丅丌丗) != 1)
        {
            goto label_514;
        }
        
        }
        
        if(LeanTween.丝万丕丅丆丂三丈一 != 31)
        {
            goto label_517;
        }
        
        val_315 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 != null)
        {
            goto label_520;
        }
        
        val_315 = LeanTween.丞万丈丙东且丗与下;
        if(val_315 == null)
        {
            goto label_1587;
        }
        
        label_520:
        val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 92];
        val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.专丂丕丗丗东世丞下;
        val_321 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 100];
        val_316 = 0;
        UnityEngine.AudioSource.PlayClipAtPoint(clip:  0, position:  new UnityEngine.Vector3() {x = val_312, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 92 + 4], z = val_321}, volume:  LeanTween.丏且与丕丅七不丁丅.Length + 32.丈丗与丞一上且上上);
        label_517:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丟丘丙丄丅万丏与丗) == null)
        {
            goto label_528;
        }
        
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  0);
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丟丘丙丄丅万丏与丗.Invoke();
        goto label_1039;
        label_499:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与) <= 0f)
        {
            goto label_537;
        }
        
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_540;
        }
        
        val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 28];
        val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与;
        goto label_541;
        label_537:
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_1587;
        }
        
        }
        
        float val_305 = LeanTween.且丆丝世上丐上不万;
        val_305 = val_305 * (LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丈丘业丛丁丏丙丘);
        val_305 = (LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丛七丈不丌丕世丏) + val_305;
        丒丛七丈不丌丕世丏 = val_305;
        goto label_1039;
        label_528:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.业世丁下丅与丘丞丁) == null)
        {
            goto label_550;
        }
        
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  0);
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_1587;
        }
        
        }
        
        val_315 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 240];
        val_315 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丗万丗一丞丘丆丘丛;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.业世丁下丅与丘丞丁.Invoke(obj:  val_315);
        goto label_1039;
        label_514:
        if((((LeanTween.丏且与丕丅七不丁丅.Length + 32.世七业七一七丅丌丗) & 2147483648) == 0) || ((LeanTween.丏且与丕丅七不丁丅.Length + 32.丁丅丈丌丟世丗丗丟) != 19))
        {
            goto label_629;
        }
        
        val_353 = null;
        val_353 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_353 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丟丘丙丄丅万丏与丗) == null)
        {
            goto label_568;
        }
        
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丟丘丙丄丅万丏与丗.Invoke();
        goto label_629;
        label_540:
        val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 28];
        val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与;
        label_541:
        mem2[0] = val_312 - LeanTween.且丆丝世上丐上不万;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丕世且下一与丝与) >= 0)
        {
            goto label_1039;
        }
        
        丒丛七丈不丌丕世丏 = 0f;
        丕丕世且下一与丝与 = 0f;
        goto label_1039;
        label_550:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_618;
        }
        
        if(((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null) || ((UnityEngine.Object.op_Implicit(exists:  LeanTween.丏且与丕丅七不丁丅.Length + 32.丄上七丟不丗丕下丟)) == false))
        {
            goto label_599;
        }
        
        val_354 = null;
        val_354 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_599;
        }
        
        val_355 = null;
        val_355 = null;
        val_315 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上;
        if((System.Type.op_Equality(left:  LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_609;
        }
        
        val_356 = null;
        val_356 = null;
        System.Collections.Hashtable val_306 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上;
        if(val_306 == null)
        {
            goto label_953;
        }
        
        val_306 = ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? (val_306) : 0;
        goto label_953;
        label_484:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 23)
        {
            goto label_621;
        }
        
        LeanTween.丄上七丟不丗丕下丟.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_1581;
        label_568:
        val_353 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.业世丁下丅与丘丞丁) == null)
        {
            goto label_629;
        }
        
        val_358 = null;
        val_358 = null;
        val_359 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 != null)
        {
            goto label_632;
        }
        
        val_359 = LeanTween.丞万丈丙东且丗与下;
        if(val_359 == null)
        {
            goto label_1587;
        }
        
        label_632:
        val_315 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 240];
        val_315 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丗万丗一丞丘丆丘丛;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.业世丁下丅与丘丞丁.Invoke(obj:  val_315);
        label_629:
        val_360 = null;
        val_360 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.世七业七一七丅丌丗) >= 1)
        {
                val_361 = null;
            val_361 = null;
            val_362 = LeanTween.丞万丈丙东且丗与下;
            if(val_362 != null)
        {
                val_363 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 44];
            val_363 = LeanTween.丏且与丕丅七不丁丅.Length + 32.世七业七一七丅丌丗;
        }
        else
        {
                val_363 = 0;
            val_362 = 44;
        }
        
            mem[44] = -1;
        }
        
        val_364 = null;
        val_364 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_364 = null;
        }
        
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.上丒一丂丞丅丏丅丂) != 36)
        {
            goto label_646;
        }
        
        val_365 = null;
        val_366 = null;
        val_366 = null;
        val_315 = UnityEngine.Mathf.Epsilon;
        丒丛七丈不丌丕世丏 = val_315;
        goto label_1039;
        label_646:
        val_367 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.上丒一丂丞丅丏丅丂) != 37)
        {
            goto label_1039;
        }
        
        val_368 = null;
        val_368 = null;
        val_369 = LeanTween.丞万丈丙东且丗与下;
        if(val_369 != null)
        {
                val_312 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 52];
            val_312 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丒丈丘业丛丁丏丙丘;
        }
        else
        {
                val_312 = 5.142877E-39f;
            val_369 = 52;
        }
        
        mem[52] = 0f - val_312;
        goto label_1039;
        label_621:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 24)
        {
            goto label_664;
        }
        
        label_1052:
        LeanTween.丄上七丟不丗丕下丟.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_1581;
        label_492:
        val_352 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_1481;
        }
        
        val_372 = null;
        val_372 = null;
        val_373 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上;
        if(val_373 == null)
        {
            goto label_1481;
        }
        
        val_374 = null;
        val_374 = null;
        System.Type val_82 = val_373.GetType();
        if(LeanTween.丝万丕丅丆丂三丈一 != 25)
        {
            goto label_685;
        }
        
        if((System.Type.op_Equality(left:  val_82, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_688;
        }
        
        val_375 = null;
        var val_85 = ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? (val_373) : 0;
        goto label_1353;
        label_428:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 7)
        {
            goto label_693;
        }
        
        val_378 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.丌业丞丌丛世不丞丑) == false)
        {
            goto label_698;
        }
        
        val_379 = null;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.与丏丛与世丑丈丘东(不丂丅丁且丆东东丂:  LeanTween.丄上七丟不丗丕下丟, 东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1581;
        label_439:
        if(LeanTween.丞万丈丙东且丗与下 != null)
        {
            goto label_704;
        }
        
        if(LeanTween.丞万丈丙东且丗与下 != null)
        {
            goto label_705;
        }
        
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_706;
        }
        
        goto label_1413;
        label_664:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 26)
        {
            goto label_710;
        }
        
        val_383 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_383 = LeanTween.丞万丈丙东且丗与下;
        }
        
        UnityEngine.Rect val_86 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丝丛丁丏丑丞丈三一.rect;
        UnityEngine.Rect val_87 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丝丛丁丏丑丞丈三一.rect;
        label_990:
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丝丛丁丏丑丞丈三一.rect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        goto label_1581;
        label_693:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 8)
        {
            goto label_722;
        }
        
        val_386 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.orientToPath) == false)
        {
            goto label_727;
        }
        
        val_387 = null;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.且丒丛与丞世丙丕丌(不丂丅丁且丆东东丂:  LeanTween.丄上七丟不丗丕下丟, 东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1581;
        label_609:
        val_389 = null;
        if(val_315 == null)
        {
            goto label_733;
        }
        
        val_390 = null;
        val_391 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上;
        if((val_391 == null) || ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null))
        {
            goto label_739;
        }
        
        goto label_953;
        label_433:
        val_345 = null;
        UnityEngine.Vector3 val_88 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        label_1022:
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_745;
        }
        
        goto label_746;
        label_378:
        val_397 = null;
        val_397 = null;
        val_399 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_399 = LeanTween.丞万丈丙东且丗与下;
            if(val_399 == null)
        {
            goto label_1587;
        }
        
        }
        
        val_400 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 80];
        val_400 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丈丗与丞一上且上上;
        val_401 = (LeanTween.丏且与丕丅七不丁丅.Length + 32.丕丙丘丂丙七丘丕丆) * LeanTween.丁丁丛丟丝不上丌三;
        goto label_759;
        label_710:
        val_330 = null;
        val_351 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_351 != 27)
        {
            goto label_762;
        }
        
        UnityEngine.Vector2 val_89 = new UnityEngine.Vector2(x:  0f, y:  0f);
        margin = val_89.x;
        mem2[0] = val_89.y;
        goto label_1581;
        label_722:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 9)
        {
            goto label_770;
        }
        
        val_407 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.orientToPath) == false)
        {
            goto label_775;
        }
        
        val_408 = null;
        LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.与丏丛与世丑丈丘东(不丂丅丁且丆东东丂:  LeanTween.丄上七丟不丗丕下丟, 东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1581;
        label_685:
        if((System.Type.op_Equality(left:  val_82, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_783;
        }
        
        val_410 = null;
        goto label_1363;
        label_698:
        val_411 = null;
        UnityEngine.Vector3 val_93 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丄业丕且丗下一万.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        label_1390:
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_790;
        }
        
        goto label_791;
        label_759:
         =  + ;
        goto label_1026;
        label_733:
        val_519 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) != null)
        {
                if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1404;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  "callback was not converted");
        label_599:
        val_315 = 0;
        label_953:
        val_391 = 0;
        label_739:
        label_1404:
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  0);
        if(val_391 == 0)
        {
            goto label_964;
        }
        
        val_391.Invoke(obj:  val_315);
        val_314 = 32;
        goto label_1039;
        label_964:
        if(0 == 0)
        {
            goto label_966;
        }
        
        0.Invoke();
        val_314 = 32;
        goto label_1039;
        label_966:
        val_314 = 32;
        if((System.String.op_Inequality(a:  System.String.alignConst, b:  System.String.alignConst)) == false)
        {
            goto label_1039;
        }
        
        val_520 = null;
        val_520 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_973;
        }
        
        val_521 = null;
        val_521 = null;
        val_522 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_978;
        }
        
        var val_111 = ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上 : 0;
        goto label_979;
        label_762:
        val_330 = null;
        val_525 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_525 != 28)
        {
            goto label_982;
        }
        
        val_527 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_527 = LeanTween.丞万丈丙东且丗与下;
            if(val_527 == null)
        {
            goto label_1587;
        }
        
        }
        
        UnityEngine.Rect val_112 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丝丛丁丏丑丞丈三一.rect;
        float val_113 = val_112.m_XMin.System.IConvertible.ToSingle(provider:  0);
        UnityEngine.Rect val_114 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丝丛丁丏丑丞丈三一.rect;
        goto label_990;
        label_770:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 10)
        {
            goto label_993;
        }
        
        val_530 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_115 = val_530.localScale;
        UnityEngine.Vector3 val_116 = LeanTween.丄上七丟不丗丕下丟.localScale;
        val_531 = val_115.y;
        goto label_998;
        label_973:
        val_532 = null;
        if(val_315 == 0)
        {
            goto label_999;
        }
        
        val_533 = null;
        val_534 = LeanTween.丄上七丟不丗丕下丟.gameObject;
        if(val_534 != null)
        {
            goto label_1038;
        }
        
        goto label_1004;
        label_688:
        val_535 = null;
        if((System.Type.op_Equality(left:  val_373.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_1007;
        }
        
        val_536 = null;
        if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1012;
        }
        
        val_537 = 0;
        goto label_1012;
        label_783:
        if((System.Type.op_Equality(left:  val_373.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_1015;
        }
        
        val_538 = null;
        goto label_1468;
        label_727:
        val_539 = null;
        UnityEngine.Vector3 val_124 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1022;
        label_982:
        val_330 = null;
        val_525 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_525 != 29)
        {
            goto label_1029;
        }
        
        alpha = 0f;
        goto label_1581;
        label_978:
        val_523 = 0;
        label_979:
        LeanTween.与丙丝一丆丛丁丑丟 = val_523;
        if(val_315 == 0)
        {
            goto label_1035;
        }
        
        val_547 = null;
        val_534 = LeanTween.与丙丝一丆丛丁丑丟;
        if(val_534 != null)
        {
            goto label_1038;
        }
        
        label_1004:
        label_1038:
        val_534.BroadcastMessage(methodName:  System.String.alignConst, parameter:  val_315);
        goto label_1039;
        label_1035:
        val_548 = null;
        val_315 = LeanTween.与丙丝一丆丛丁丑丟;
        if(val_315 != null)
        {
            goto label_1394;
        }
        
        goto label_1043;
        label_993:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 11)
        {
            goto label_1046;
        }
        
        val_530 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_126 = val_530.localScale;
        UnityEngine.Vector3 val_127 = LeanTween.丄上七丟不丗丕下丟.localScale;
        val_531 = LeanTween.下下丏一丙不丘丌丞;
        label_998:
        if(val_530 != null)
        {
            goto label_1052;
        }
        
        goto label_1052;
        label_1353:
        val_754 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_1356;
        }
        
        val_755 = null;
        System.Collections.Hashtable val_358 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上;
        if(val_358 == null)
        {
            goto label_1361;
        }
        
        val_358 = ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? (val_358) : 0;
        goto label_1399;
        label_1363:
        val_757 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_1366;
        }
        
        val_758 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上) == null)
        {
            goto label_1371;
        }
        
        var val_236 = ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上 : 0;
        goto label_1372;
        label_1007:
        val_760 = null;
        val_761 = 0f;
        val_762 = 0f;
        val_763 = 0f;
        if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1385;
        }
        
        val_764 = 0;
        goto label_1377;
        label_1015:
        val_765 = null;
        if((System.Type.op_Equality(left:  val_373.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_1380;
        }
        
        val_766 = null;
        val_761 = 0f;
        val_762 = 0f;
        val_763 = 0f;
        if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1385;
        }
        
        val_764 = 0;
        label_1377:
        val_767 = 0;
        goto label_1385;
        label_775:
        val_768 = null;
        UnityEngine.Vector3 val_240 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丂丈万丗丕丙丟上.丅专与丒丈丗丒丘丌(东丞丅丕丌丑丗丞下:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1390;
        label_999:
        val_770 = null;
        val_315 = LeanTween.丄上七丟不丗丕下丟.gameObject;
        if(val_315 != null)
        {
            goto label_1394;
        }
        
        label_1043:
        label_1394:
        val_315.BroadcastMessage(methodName:  System.String.alignConst);
        label_1039:
        val_313 = 1;
        goto label_1395;
        label_1356:
        val_771 = null;
        val_756 = LeanTween.丄上七丟不丗丕下丟.gameObject;
        goto label_1399;
        label_1366:
        val_772 = null;
        val_773 = LeanTween.丄上七丟不丗丕下丟.gameObject;
        goto label_1403;
        label_1029:
        val_330 = null;
        val_525 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_525 != 30)
        {
            goto label_1581;
        }
        
        rotation = 0f;
        goto label_1581;
        label_706:
        if(LeanTween.丞万丈丙东且丗与下 != null)
        {
            goto label_1413;
        }
        
        goto label_1587;
        label_1046:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 12)
        {
            goto label_1417;
        }
        
        UnityEngine.Vector3 val_244 = LeanTween.丄上七丟不丗丕下丟.localScale;
        UnityEngine.Vector3 val_245 = LeanTween.丄上七丟不丗丕下丟.localScale;
        goto label_998;
        label_1468:
        if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1471;
        }
        
        goto label_1471;
        label_1380:
        val_805 = null;
        if((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null)
        {
            goto label_1476;
        }
        
        goto label_1476;
        label_1361:
        val_756 = 0;
        label_1399:
        val_806 = null;
        val_806 = null;
        LeanTween.与丙丝一丆丛丁丑丟 = val_756;
        val_807 = null;
        val_773 = LeanTween.与丙丝一丆丛丁丑丟;
        goto label_1479;
        label_1371:
        val_759 = 0;
        label_1372:
        LeanTween.与丙丝一丆丛丁丑丟 = val_759;
        val_773 = LeanTween.与丙丝一丆丛丁丑丟;
        label_1403:
        val_807 = null;
        label_1479:
        val_773.BroadcastMessage(methodName:  ((mem[LeanTween.丏且与丕丅七不丁丅.Length + 32.丛丛丁丟上东丈丗上]) == null) ? (val_373) : 0, parameter:  LeanTween.下下丏一丙不丘丌丞);
        goto label_1481;
        label_1417:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 13)
        {
            goto label_1484;
        }
        
        UnityEngine.Vector3 val_263 = LeanTween.丄上七丟不丗丕下丟.eulerAngles;
        UnityEngine.Vector3 val_264 = LeanTween.丄上七丟不丗丕下丟.eulerAngles;
        if(LeanTween.丄上七丟不丗丕下丟 != null)
        {
            goto label_1490;
        }
        
        goto label_1490;
        label_1484:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 14)
        {
            goto label_1493;
        }
        
        val_812 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_265 = val_812.eulerAngles;
        UnityEngine.Vector3 val_266 = LeanTween.丄上七丟不丗丕下丟.eulerAngles;
        val_339 = LeanTween.下下丏一丙不丘丌丞;
        goto label_1498;
        label_1493:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 15)
        {
            goto label_1501;
        }
        
        val_812 = LeanTween.丄上七丟不丗丕下丟;
        UnityEngine.Vector3 val_267 = val_812.eulerAngles;
        UnityEngine.Vector3 val_268 = LeanTween.丄上七丟不丗丕下丟.eulerAngles;
        label_1498:
        val_812.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        goto label_1581;
        label_1501:
        val_341 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 16)
        {
            goto label_1510;
        }
        
        val_819 = null;
        float val_384 = LeanTween.下下丏一丙不丘丌丞;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_819 = null;
        }
        
        if(LeanTween.且一丌业三不丝丁与 == false)
        {
            goto label_1514;
        }
        
        LeanTween.丄上七丟不丗丕下丟.eulerAngles = new UnityEngine.Vector3() {x = LeanTween.丏且与丕丅七不丁丅.Length + 32.丆丏丕不一三丐不丆, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 140 + 4], z = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 148]};
        UnityEngine.Vector3 val_269 = LeanTween.丄上七丟不丗丕下丟.TransformPoint(position:  new UnityEngine.Vector3() {x = LeanTween.丏且与丕丅七不丁丅.Length + 32.丅专与丒丈丗丒丘丌, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 116 + 4], z = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 124]});
        val_822 = LeanTween.丞万丈丙东且丗与下;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_822 = LeanTween.丞万丈丙东且丗与下;
        }
        
        LeanTween.丄上七丟不丗丕下丟.RotateAround(point:  new UnityEngine.Vector3() {x = val_269.x, y = val_269.y, z = val_269.z}, axis:  new UnityEngine.Vector3() {x = LeanTween.丏且与丕丅七不丁丅.Length + 32.世丐世丄不不丈丗丏, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 128 + 4], z = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 136]}, angle:  LeanTween.丏且与丕丅七不丁丅.Length + 32.专丂丕丗丗东世丞下);
        goto label_1581;
        label_1510:
        val_823 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 17)
        {
            goto label_1527;
        }
        
        UnityEngine.SpriteRenderer val_271 = LeanTween.丄上七丟不丗丕下丟.gameObject.GetComponent<UnityEngine.SpriteRenderer>();
        if(val_271 == 0)
        {
            goto label_1534;
        }
        
        if(val_271 == null)
        {
            goto label_1535;
        }
        
        UnityEngine.Color val_273 = val_271.color;
        val_826 = val_273.r;
        UnityEngine.Color val_274 = val_271.color;
        val_827 = val_274.g;
        goto label_1536;
        label_1527:
        val_823 = null;
        val_344 = LeanTween.丝万丕丅丆丂三丈一;
        if(val_344 != 18)
        {
            goto label_1581;
        }
        
        UnityEngine.Mesh val_276 = LeanTween.丄上七丟不丗丕下丟.GetComponent<UnityEngine.MeshFilter>().mesh;
        UnityEngine.Vector3[] val_277 = val_276.vertices;
        UnityEngine.Color32[] val_278 = new UnityEngine.Color32[0];
        UnityEngine.Color32 val_280 = val_276.colors32[0] & 255;
        UnityEngine.Color32 val_281 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        if((val_277 + 24) >= 1)
        {
                var val_383 = 0;
            do
        {
            val_278[0] = val_281;
            val_383 = val_383 + 1;
        }
        while(val_383 < (val_277 + 24));
        
        }
        
        val_276.colors32 = val_278;
        goto label_1581;
        label_1514:
        UnityEngine.Vector3 val_282 = LeanTween.丄上七丟不丗丕下丟.TransformPoint(position:  new UnityEngine.Vector3() {x = LeanTween.丏且与丕丅七不丁丅.Length + 32.丅专与丒丈丗丒丘丌, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 116 + 4], z = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 124]});
        val_384 = val_384 - (LeanTween.丏且与丕丅七不丁丅.Length + 32.丏三丟丈丕丂万不专);
        LeanTween.丄上七丟不丗丕下丟.RotateAround(point:  new UnityEngine.Vector3() {x = val_282.x, y = val_282.y, z = val_282.z}, axis:  new UnityEngine.Vector3() {x = LeanTween.丏且与丕丅七不丁丅.Length + 32.世丐世丄不不丈丗丏, y = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 128 + 4], z = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32 + 136]}, angle:  val_384);
        丏三丟丈丕丂万不专 = LeanTween.下下丏一丙不丘丌丞;
        goto label_1581;
        label_1534:
        val_830 = null;
        val_830 = null;
        val_831 = 0;
        goto label_1568;
        label_1576:
        UnityEngine.Material val_385 = LeanTween.丄上七丟不丗丕下丟.gameObject.GetComponent<UnityEngine.Renderer>().materials[0];
        if(val_385 != null)
        {
                UnityEngine.Color val_286 = val_385.color;
            val_832 = val_286.r;
            UnityEngine.Color val_287 = val_385.color;
            val_833 = val_287.g;
        }
        else
        {
                UnityEngine.Color val_288 = 0.color;
            val_832 = val_288.r;
            UnityEngine.Color val_289 = 0.color;
            val_833 = val_289.g;
        }
        
        UnityEngine.Color val_290 = val_385.color;
        val_834 = null;
        val_834 = null;
        val_385.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_831 = 1;
        label_1568:
        if(val_831 < val_285.Length)
        {
            goto label_1576;
        }
        
        goto label_1581;
        label_1535:
        UnityEngine.Color val_291 = val_271.color;
        val_826 = val_291.r;
        UnityEngine.Color val_292 = val_271.color;
        val_827 = val_292.g;
        label_1536:
        UnityEngine.Color val_293 = val_271.color;
        val_835 = null;
        val_835 = null;
        val_271.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        goto label_1581;
        label_1395:
        val_836 = null;
        val_836 = null;
        if(val_313 < LeanTween.下世一一丝丕世三七)
        {
            goto label_1584;
        }
        
        label_14:
        val_837 = null;
        val_311 = UnityEngine.Time.frameCount;
        val_837 = null;
        LeanTween.丞丏丑丌丏专丄丌丂 = val_311;
        return;
        label_1587:
        val_838 = X0;
    }
    public static void removeTween(int 七丞丙丒三丕且丌丟)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_8 = null;
        val_8 = null;
        丛丙丆丌七丘丘且世[] val_1 = LeanTween.丏且与丕丅七不丁丅 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((long)(int)(七丞丙丒三丕且丌丟)) << 3) + 32 + 16) == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
        mem2[0] = 0;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((long)(int)(七丞丙丒三丕且丌丟)) << 3) + 32 + 56) != 0)
        {
                val_10 = null;
            val_10 = null;
            丛丙丆丌七丘丘且世[] val_4 = LeanTween.丏且与丕丅七不丁丅 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
            if(((LeanTween.丏且与丕丅七不丁丅 + ((long)(int)(七丞丙丒三丕且丌丟)) << 3) + 32 + 72) != 0)
        {
                val_11 = null;
            val_11 = null;
            丛丙丆丌七丘丘且世[] val_5 = LeanTween.丏且与丕丅七不丁丅 + (((long)(int)(七丞丙丒三丕且丌丟)) << 3);
            万丁且丒丂七丐不三.丏丞丙丌丆丙万丂丛(丞丅上丏丂且下丅与:  (LeanTween.丏且与丕丅七不丁丅 + ((long)(int)(七丞丙丒三丕且丌丟)) << 3) + 32 + 72.id);
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        LeanTween.startSearch = 七丞丙丒三丕且丌丟;
        if((七丞丙丒三丕且丌丟 + 1) < LeanTween.下世一一丝丕世三七)
        {
                return;
        }
        
        val_12 = null;
        LeanTween.startSearch = 0;
        int val_8 = LeanTween.下世一一丝丕世三七;
        val_8 = val_8 - 1;
        LeanTween.下世一一丝丕世三七 = val_8;
    }
    public static UnityEngine.Vector3[] add(UnityEngine.Vector3[] 丆丛丑世下一丐且丕, UnityEngine.Vector3 丌丗丏丏丛东专丁且)
    {
        var val_3;
        UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
        val_3 = null;
        val_3 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 0;
        goto label_4;
        label_14:
        var val_2 = 丆丛丑世下一丐且丕 + (0 * 12);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (0 * 12) + 丆丛丑世下一丐且丕 + 32, y = (0 * 12) + 丆丛丑世下一丐且丕 + 32 + 4, z = (0 * 12) + 丆丛丑世下一丐且丕 + 40}, b:  new UnityEngine.Vector3() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y, z = 丌丗丏丏丛东专丁且.z});
        var val_4 = val_1 + (0 * 12);
        mem2[0] = val_3.x;
        mem2[0] = val_3.y;
        mem2[0] = val_3.z;
        val_3 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 1;
        label_4:
        val_3 = null;
        if(LeanTween.七丞丙丒三丕且丌丟 < 丆丛丑世下一丐且丕.Length)
        {
            goto label_14;
        }
        
        return val_1;
    }
    public static float closestRot(float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下)
    {
        专丂丕丗丗东世丞下 = 360f - 专丂丕丗丗东世丞下;
        float val_1 = 0f - 专丂丕丗丗东世丞下;
        float val_2 = 专丂丕丗丗东世丞下 + 360f;
        专丂丕丗丗东世丞下 = val_1 - 丈丗与丞一上且上上;
        float val_6 = System.Math.Abs(专丂丕丗丗东世丞下 - 丈丗与丞一上且上上);
        float val_7 = System.Math.Abs(val_2 - 丈丗与丞一上且上上);
        if((val_6 >= 0) || (val_6 >= 0))
        {
                return (float)(System.Math.Abs(专丂丕丗丗东世丞下) >= 0) ? (val_2) : (val_1);
        }
        
        return (float)(System.Math.Abs(专丂丕丗丗东世丞下) >= 0) ? (val_2) : (val_1);
    }
    public static void cancel(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        var val_3;
        var val_4;
        LeanTween.init();
        val_3 = 0;
        goto label_4;
        label_17:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 64) == 下丐三丆丝与不丗丕.transform)
        {
                LeanTween.removeTween(七丞丙丒三丕且丌丟:  0);
        }
        
        val_3 = 1;
        label_4:
        val_4 = null;
        val_4 = null;
        if(val_3 < LeanTween.下世一一丝丕世三七)
        {
            goto label_17;
        }
    
    }
    public static void cancel(UnityEngine.GameObject 下丐三丆丝与不丗丕, int 丙下不丏丅丅专丂丗)
    {
        var val_8;
        UnityEngine.Object val_9;
        var val_10;
        var val_11;
        val_8 = 丙下不丏丅丅专丂丗;
        val_9 = 下丐三丆丝与不丗丕;
        if((val_8 & 2147483648) != 0)
        {
                return;
        }
        
        LeanTween.init();
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 64) != 0)
        {
            goto label_9;
        }
        
        label_26:
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  val_8 & 65535);
        return;
        label_9:
        val_10 = null;
        val_10 = null;
        丛丙丆丌七丘丘且世[] val_4 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 64.gameObject) != val_9)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        丛丙丆丌七丘丘且世[] val_7 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_9 = mem[(LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32];
        val_9 = (LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32;
        val_8 = val_8 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) == val_8)
        {
            goto label_26;
        }
    
    }
    public static void cancel(LTRect 丝丛丁丏丑丞丈三一, int 丙下不丏丅丅专丂丗)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 丙下不丏丅丅专丂丗;
        val_5 = 丝丛丁丏丑丞丈三一;
        if((val_4 & 2147483648) != 0)
        {
                return;
        }
        
        LeanTween.init();
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 72) != val_5)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_5 = mem[(LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32];
        val_5 = (LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32;
        val_4 = val_4 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) != val_4)
        {
                return;
        }
        
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  val_4 & 65535);
    }
    private static void 一丞丏世丗专丕三丗(int 丙下不丏丅丅专丂丗)
    {
        var val_4;
        var val_5;
        val_4 = 丙下不丏丅丅专丂丗;
        if((val_4 & 2147483648) != 0)
        {
                return;
        }
        
        LeanTween.init();
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 19) == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_4 = val_4 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) != val_4)
        {
                return;
        }
        
        LeanTween.removeTween(七丞丙丒三丕且丌丟:  val_4 & 65535);
    }
    public static 丛丙丆丌七丘丘且世 description(int 丙下不丏丅丅专丂丗)
    {
        丛丙丆丌七丘丘且世[] val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_9 = 丙下不丏丅丅专丂丗;
        int val_1 = val_9 & 65535;
        val_10 = null;
        val_10 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_11 = val_9 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32) == 0)
        {
            goto label_17;
        }
        
        val_12 = null;
        val_12 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32.丛东丐丐东专丟丂丂()) != val_9)
        {
            goto label_17;
        }
        
        val_13 = null;
        val_13 = null;
        丛丙丆丌七丘丘且世[] val_5 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) != (val_11 << ))
        {
            goto label_17;
        }
        
        val_14 = null;
        val_14 = null;
        val_9 = LeanTween.丏且与丕丅七不丁丅;
        val_15 = val_9 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        goto label_22;
        label_17:
        val_16 = 0;
        val_11 = (long)val_11;
        goto label_23;
        label_38:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32.丛东丐丐东专丟丂丂()) != val_9)
        {
            goto label_29;
        }
        
        val_17 = null;
        val_17 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 48) == val_11)
        {
            goto label_35;
        }
        
        label_29:
        val_16 = 1;
        label_23:
        val_18 = null;
        val_18 = null;
        if(val_16 < LeanTween.下世一一丝丕世三七)
        {
            goto label_38;
        }
        
        val_19 = 0;
        return (丛丙丆丌七丘丘且世)val_19;
        label_35:
        val_20 = null;
        val_20 = null;
        val_9 = LeanTween.丏且与丕丅七不丁丅;
        label_22:
        val_19 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32];
        val_19 = LeanTween.丏且与丕丅七不丁丅.Length + 32;
        return (丛丙丆丌七丘丘且世)val_19;
    }
    public static void pause(UnityEngine.GameObject 下丐三丆丝与不丗丕, int 丙下不丏丅丅专丂丗)
    {
        LeanTween.pause(丙下不丏丅丅专丂丗:  丙下不丏丅丅专丂丗);
    }
    public static void pause(int 丙下不丏丅丅专丂丗)
    {
        var val_5;
        var val_6;
        int val_5 = 丙下不丏丅丅专丂丗;
        int val_1 = val_5 & 65535;
        val_5 = null;
        val_5 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_5 = val_5 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) != (val_5 << ))
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        丛丙丆丌七丘丘且世 val_4 = (LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32.丁与丟万丄丒丗专丌();
    }
    public static void pause(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 0;
        goto label_2;
        label_18:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 64) == 下丐三丆丝与不丗丕.transform)
        {
                val_5 = null;
            val_5 = null;
            丛丙丆丌七丘丘且世 val_3 = LeanTween.丏且与丕丅七不丁丅.Length + 32.丁与丟万丄丒丗专丌();
        }
        
        val_4 = 1;
        label_2:
        val_6 = null;
        val_6 = null;
        if(val_4 < LeanTween.下世一一丝丕世三七)
        {
            goto label_18;
        }
    
    }
    public static void resume(UnityEngine.GameObject 下丐三丆丝与不丗丕, int 丙下不丏丅丅专丂丗)
    {
        LeanTween.resume(丙下不丏丅丅专丂丗:  丙下不丏丅丅专丂丗);
    }
    public static void resume(int 丙下不丏丅丅专丂丗)
    {
        var val_5;
        var val_6;
        int val_5 = 丙下不丏丅丅专丂丗;
        int val_1 = val_5 & 65535;
        val_5 = null;
        val_5 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_5 = val_5 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) != (val_5 << ))
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        丛丙丆丌七丘丘且世 val_4 = (LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32.不业下世三世七七丐();
    }
    public static void resume(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 0;
        goto label_2;
        label_18:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 64) == 下丐三丆丝与不丗丕.transform)
        {
                val_5 = null;
            val_5 = null;
            丛丙丆丌七丘丘且世 val_3 = LeanTween.丏且与丕丅七不丁丅.Length + 32.不业下世三世七七丐();
        }
        
        val_4 = 1;
        label_2:
        val_6 = null;
        val_6 = null;
        if(val_4 < LeanTween.下世一一丝丕世三七)
        {
            goto label_18;
        }
    
    }
    public static bool isTweening(UnityEngine.GameObject 下丐三丆丝与不丗丕)
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_3 = 0;
        goto label_2;
        label_19:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 16) == 0)
        {
            goto label_8;
        }
        
        val_4 = null;
        val_4 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 64) == 下丐三丆丝与不丗丕.transform)
        {
            goto label_16;
        }
        
        label_8:
        val_3 = 1;
        label_2:
        val_5 = null;
        val_5 = null;
        if(val_3 < LeanTween.下世一一丝丕世三七)
        {
            goto label_19;
        }
        
        val_6 = 0;
        return (bool)val_6;
        label_16:
        val_6 = 1;
        return (bool)val_6;
    }
    public static bool isTweening(int 丙下不丏丅丅专丂丗)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        int val_1 = 丙下不丏丅丅专丂丗 & 65535;
        val_4 = null;
        val_4 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
        val_5 = 丙下不丏丅丅专丂丗 >> 16;
        if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 48) == (val_5 << ))
        {
                val_6 = null;
            val_6 = null;
            丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((丙下不丏丅丅专丂丗 & 65535)) << 3);
            val_5 = mem[(LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32];
            val_5 = (LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32;
            if(((LeanTween.丏且与丕丅七不丁丅 + ((丙下不丏丅丅专丂丗 & 65535)) << 3) + 32 + 16) != 0)
        {
                val_7 = 1;
            return (bool)val_7;
        }
        
        }
        
        val_7 = 0;
        return (bool)val_7;
    }
    public static bool isTweening(LTRect 丝丛丁丏丑丞丈三一)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = 0;
        goto label_1;
        label_16:
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 16) == 0)
        {
            goto label_7;
        }
        
        val_2 = null;
        val_2 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 72) == 丝丛丁丏丑丞丈三一)
        {
            goto label_13;
        }
        
        label_7:
        val_1 = 1;
        label_1:
        val_3 = null;
        val_3 = null;
        if(val_1 < LeanTween.下世一一丝丕世三七)
        {
            goto label_16;
        }
        
        val_4 = 0;
        return (bool)val_4;
        label_13:
        val_4 = 1;
        return (bool)val_4;
    }
    public static void drawBezierPath(UnityEngine.Vector3 丆丛丑世下一丐且丕, UnityEngine.Vector3 丌丗丏丏丛东专丁且, UnityEngine.Vector3 丁丂专业丁丅丅丈丙, UnityEngine.Vector3 丐丆丂丒丁万丈丛丅)
    {
        float val_1;
        float val_2;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y, z = 丌丗丏丏丛东专丁且.z}, b:  new UnityEngine.Vector3() {x = 丁丂专业丁丅丅丈丙.x, y = val_1, z = 丁丂专业丁丅丅丈丙.y});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 丁丂专业丁丅丅丈丙.z, y = val_2, z = 丐丆丂丒丁万丈丛丅.x});
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z}, b:  new UnityEngine.Vector3() {x = 丁丂专业丁丅丅丈丙.x, y = val_1, z = 丁丂专业丁丅丅丈丙.y});
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  6f, a:  new UnityEngine.Vector3() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y, z = 丌丗丏丏丛东专丁且.z});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丌丗丏丏丛东专丁且.x, y = 丌丗丏丏丛东专丁且.y, z = 丌丗丏丏丛东专丁且.z}, b:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        var val_21 = 1;
        do
        {
            float val_14 = 1f / 30f;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  val_14);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  val_14);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  val_14);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 丆丛丑世下一丐且丕.x, y = 丆丛丑世下一丐且丕.y, z = 丆丛丑世下一丐且丕.z}, to:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_21 = val_21 + 1;
        }
        while(val_21 != 31);
    
    }
    public static object logError(string 丂七东不不丈一丐不)
    {
        null = null;
        if(LeanTween.throwErrors != false)
        {
                UnityEngine.Debug.LogError(message:  丂七东不不丈一丐不);
            return 0;
        }
        
        UnityEngine.Debug.Log(message:  丂七东不不丈一丐不);
        return 0;
    }
    public static 丛丙丆丌七丘丘且世 options(丛丙丆丌七丘丘且世 上七不丈下下丛丘与)
    {
        UnityEngine.Debug.LogError(message:  "error this function is no longer used");
        return 0;
    }
    public static 丛丙丆丌七丘丘且世 options()
    {
        var val_5;
        int val_7;
        var val_8;
        丛丙丆丌七丘丘且世 val_10;
        int val_11;
        int val_13;
        丛丙丆丌七丘丘且世 val_14;
        LeanTween.init();
        val_5 = null;
        LeanTween.丏丂丛丙丆三专丂丛 = 0;
        val_7 = LeanTween.startSearch;
        goto label_3;
        label_22:
        val_8 = null;
        int val_7 = LeanTween.下七不丑丁丄业且丐;
        val_7 = val_7 - 1;
        if(LeanTween.七丞丙丒三丕且丌丟 >= val_7)
        {
                val_8 = null;
            LeanTween.七丞丙丒三丕且丌丟 = 0;
        }
        
        val_8 = null;
        val_10 = mem[LeanTween.丏且与丕丅七不丁丅.Length + 32];
        val_10 = LeanTween.丏且与丕丅七不丁丅.Length + 32;
        val_5 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 16) == 0)
        {
            goto label_14;
        }
        
        val_5 = null;
        LeanTween.丏丂丛丙丆三专丂丛 = 1;
        val_11 = LeanTween.下七不丑丁丄业且丐;
        if(LeanTween.丏丂丛丙丆三专丂丛 >= val_11)
        {
            goto label_17;
        }
        
        val_5 = null;
        val_7 = LeanTween.七丞丙丒三丕且丌丟 + 1;
        label_3:
        LeanTween.七丞丙丒三丕且丌丟 = val_7;
        val_5 = null;
        if(LeanTween.丏丂丛丙丆三专丂丛 < LeanTween.下七不丑丁丄业且丐)
        {
            goto label_22;
        }
        
        goto label_23;
        label_14:
        val_5 = null;
        val_13 = LeanTween.七丞丙丒三丕且丌丟;
        if((val_13 + 1) > LeanTween.下世一一丝丕世三七)
        {
                val_5 = null;
            val_13 = LeanTween.七丞丙丒三丕且丌丟;
            val_13 = val_13 + 1;
            LeanTween.下世一一丝丕世三七 = val_13;
        }
        
        val_5 = null;
        int val_8 = LeanTween.七丞丙丒三丕且丌丟;
        val_8 = val_8 + 1;
        LeanTween.startSearch = val_8;
        label_23:
        val_5 = null;
        丛丙丆丌七丘丘且世[] val_2 = LeanTween.丏且与丕丅七不丁丅 + (((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3);
        LeanTween.丞万丈丙东且丗与下 = (LeanTween.丏且与丕丅七不丁丅 + ((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3) + 32;
        LeanTween.丞万丈丙东且丗与下.丞专丙万丕不丗丈丛();
        val_10 = LeanTween.丞万丈丙东且丗与下;
        丛丙丆丌七丘丘且世 val_3 = val_10.丐世下不一丁丟丅专(丞丅上丏丂且下丅与:  LeanTween.七丞丙丒三丕且丌丟);
        val_14 = LeanTween.丞万丈丙东且丗与下;
        return (丛丙丆丌七丘丘且世)val_14;
        label_17:
        val_11 = LeanTween.下七不丑丁丄业且丐;
        object val_6 = LeanTween.logError(丂七东不不丈一丐不:  "LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( "("LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( ") + val_11 << 1(val_11 << 1) + " );");
        val_14 = 0;
        return (丛丙丆丌七丘丘且世)val_14;
    }
    public static UnityEngine.GameObject get_tweenEmpty()
    {
        null = null;
        LeanTween.init(丄东丛丗三丘丐丞丟:  LeanTween.下七不丑丁丄业且丐);
        return (UnityEngine.GameObject)LeanTween.业丄丌业一丗业一七;
    }
    private static 丛丙丆丌七丘丘且世 万丂丂丟世三丙丑且(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, 不丞七业上七丘丑丒 丝万丕丅丆丂三丈一, 丛丙丆丌七丘丘且世 丞万丈丙东且丗与下)
    {
        UnityEngine.Object val_3;
        var val_4;
        var val_5;
        val_3 = 下丐三丆丝与不丗丕;
        val_4 = null;
        val_4 = null;
        LeanTween.init(丄东丛丗三丘丐丞丟:  LeanTween.下七不丑丁丄业且丐);
        val_5 = 0;
        if(val_3 == 0)
        {
                return (丛丙丆丌七丘丘且世)val_5;
        }
        
        val_3 = val_3.transform;
        if(丞万丈丙东且丗与下 != null)
        {
                丞万丈丙东且丗与下.丄上七丟不丗丕下丟 = val_3;
        }
        else
        {
                mem[64] = val_3;
        }
        
        丞万丈丙东且丗与下.专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
        mem2[0] = 专丂丕丗丗东世丞下.y;
        mem2[0] = 专丂丕丗丗东世丞下.z;
        if(丞万丈丙东且丗与下 != null)
        {
                丞万丈丙东且丗与下.丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        }
        else
        {
                mem[32] = 丂三丟丂丈丐丆丗丟;
        }
        
        val_5 = 丞万丈丙东且丗与下;
        丞万丈丙东且丗与下.丁丅丈丌丟世丗丗丟 = 丝万丕丅丆丂三丈一;
        return (丛丙丆丌七丘丘且世)val_5;
    }
    public static 丛丙丆丌七丘丘且世 alpha(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  17, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 alpha(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        丝丛丁丏丑丞丈三一.alphaEnabled = true;
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  29, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丛丁丏丑丞丈三一));
    }
    public static 丛丙丆丌七丘丘且世 alphaVertex(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  18, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 delayedCall(float 丂七上与上不丘丐丛, System.Action 业丏丈世世世丞丒世)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且世下丁丈丐丘丆丟(丟丘丙丄丅万丏与丗:  业丏丈世世世丞丒世));
    }
    public static 丛丙丆丌七丘丘且世 delayedCall(float 丂七上与上不丘丐丛, System.Action<object> 业丏丈世世世丞丒世)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且世下丁丈丐丘丆丟(丟丘丙丄丅万丏与丗:  业丏丈世世世丞丒世));
    }
    public static 丛丙丆丌七丘丘且世 delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, System.Action 业丏丈世世世丞丒世)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且世下丁丈丐丘丆丟(丟丘丙丄丅万丏与丗:  业丏丈世世世丞丒世));
    }
    public static 丛丙丆丌七丘丘且世 delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, System.Action<object> 业丏丈世世世丞丒世)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且世下丁丈丐丘丆丟(丟丘丙丄丅万丏与丗:  业丏丈世世世丞丒世));
    }
    public static 丛丙丆丌七丘丘且世 destroyAfter(LTRect 丝丆丏丕丕丕丗丛业, float 丂七上与上不丘丐丛)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丆丏丕丕丕丗丛业).丕丅丆上丕丆世上与(不丌丕三七专专丝丑:  true));
    }
    public static 丛丙丆丌七丘丘且世 move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  20, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        UnityEngine.Vector3 val_2 = 下丐三丆丝与不丗丕.transform.position;
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  20, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        var val_4;
        var val_5;
        上三世丟丛丘东丌丕 val_6;
        var val_7;
        var val_8;
        val_4 = null;
        LeanTween.descr = LeanTween.options();
        if(LeanTween.descr == null)
        {
                val_4 = null;
        }
        
        if(val_1.丛丄业丕且丗下一万 != null)
        {
                val_5 = null;
            val_6 = mem[val_1 + 152];
            val_6 = val_1.丛丄业丕且丗下一万;
            val_6.三丄丞丘丘东丑丛一(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
        }
        else
        {
                val_7 = null;
            上三世丟丛丘东丌丕 val_2 = null;
            val_6 = val_2;
            val_2 = new 上三世丟丛丘东丌丕(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
            丛丄业丕且丗下一万 = val_6;
        }
        
        val_8 = null;
        val_8 = null;
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  6, 丞万丈丙东且丗与下:  LeanTween.descr);
    }
    public static 丛丙丆丌七丘丘且世 moveSpline(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        LeanTween.descr = LeanTween.options();
        丆丂丈万丗丕丙丟上 = new LTSpline(丑丂丈丗且东丒丌七:  专丂丕丗丗东世丞下);
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  8, 丞万丈丙东且丗与下:  LeanTween.descr);
    }
    public static 丛丙丆丌七丘丘且世 moveSplineLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        LeanTween.descr = LeanTween.options();
        丆丂丈万丗丕丙丟上 = new LTSpline(丑丂丈丗且东丒丌七:  专丂丕丗丗东世丞下);
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  9, 丞万丈丙东且丗与下:  LeanTween.descr);
    }
    public static 丛丙丆丌七丘丘且世 move(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y});
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  26, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丛丁丏丑丞丈三一));
    }
    public static 丛丙丆丌七丘丘且世 moveMargin(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y});
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  27, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丛丁丏丑丞丈三一));
    }
    public static 丛丙丆丌七丘丘且世 moveX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  0, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  1, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  2, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  21, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        var val_4;
        var val_5;
        上三世丟丛丘东丌丕 val_6;
        var val_7;
        var val_8;
        val_4 = null;
        LeanTween.descr = LeanTween.options();
        if(LeanTween.descr == null)
        {
                val_4 = null;
        }
        
        if(val_1.丛丄业丕且丗下一万 != null)
        {
                val_5 = null;
            val_6 = mem[val_1 + 152];
            val_6 = val_1.丛丄业丕且丗下一万;
            val_6.三丄丞丘丘东丑丛一(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
        }
        else
        {
                val_7 = null;
            上三世丟丛丘东丌丕 val_2 = null;
            val_6 = val_2;
            val_2 = new 上三世丟丛丘东丌丕(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
            丛丄业丕且丗下一万 = val_6;
        }
        
        val_8 = null;
        val_8 = null;
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  7, 丞万丈丙东且丗与下:  LeanTween.descr);
    }
    public static 丛丙丆丌七丘丘且世 moveLocalX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  3, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveLocalY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  4, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 moveLocalZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  5, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotate(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  22, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotate(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  30, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丛丁丏丑丞丈三一));
    }
    public static 丛丙丆丌七丘丘且世 rotateLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  23, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotateX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  13, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotateY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  14, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotateZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  15, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 rotateAround(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 世丐世丄不不丈丗丏, float 丘丂丂丅丁一丈丕三, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  16, 丞万丈丙东且丗与下:  LeanTween.options().与丕丈丛丐丌世丐丘(世丐世丄不不丈丗丏:  new UnityEngine.Vector3() {x = 世丐世丄不不丈丗丏.x, y = 世丐世丄不不丈丗丏.y, z = 世丐世丄不不丈丗丏.z}));
    }
    public static 丛丙丆丌七丘丘且世 scale(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  24, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 scale(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y});
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  28, 丞万丈丙东且丗与下:  LeanTween.options().丑丁七与丛丄万丞东(丝丆丏丕丕丕丗丛业:  丝丛丁丏丑丞丈三一));
    }
    public static 丛丙丆丌七丘丘且世 scaleX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  10, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 scaleY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  11, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 scaleZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  12, 丞万丈丙东且丗与下:  LeanTween.options());
    }
    public static 丛丙丆丌七丘丘且世 value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且丙丕丒丕丅世一丏(专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}).下下丝丞丛万七丞丆(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}).三七七丁丌丐丏丙丘(丄丙丞丁世上丄与与:  丘丝一下一一丛丞东));
    }
    public static 丛丙丆丌七丘丘且世 value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<UnityEngine.Vector3> 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  25, 丞万丈丙东且丗与下:  LeanTween.options().且丙丕丒丕丅世一丏(专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}).下下丝丞丛万七丞丆(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}).丝丏一丕丕与世专丈(丄丙丞丁世上丄与与:  丘丝一下一一丛丞东));
    }
    public static 丛丙丆丌七丘丘且世 value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float, object> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  19, 丞万丈丙东且丗与下:  LeanTween.options().且丙丕丒丕丅世一丏(专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}).下下丝丞丛万七丞丆(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}).下丗丙万东丂丙三业(丄丙丞丁世上丄与与:  丘丝一下一一丛丞东));
    }
    public static 丛丙丆丌七丘丘且世 delayedSound(UnityEngine.AudioClip 丌丕丛丂一丈丙丟丏, UnityEngine.Vector3 下业丕七东丌丝下且, float 与丁万东丌丑下丏丕)
    {
        return (丛丙丆丌七丘丘且世)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 丂三丟丂丈丐丆丗丟:  0f, 丝万丕丅丆丂三丈一:  31, 丞万丈丙东且丗与下:  LeanTween.options().且丙丕丒丕丅世一丏(专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}).下下丝丞丛万七丞丆(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}).丙丗丗东与万丕东七(丌丕丛丂一丈丙丟丏:  丌丕丛丂一丈丙丟丏));
    }
    public static System.Collections.Hashtable h(object[] 七丗丝世丒丕丝丆丂)
    {
        var val_5;
        var val_6;
        int val_7;
        int val_8;
        int val_5 = 七丗丝世丒丕丝丆丂.Length;
        var val_1 = (val_5 < 0) ? (val_5 + 1) : (val_5);
        val_1 = val_1 & 4294967294;
        val_5 = val_5 - val_1;
        if(val_5 == 1)
        {
                object val_2 = LeanTween.logError(丂七东不不丈一丐不:  "LeanTween - You have attempted to create a Hashtable with an odd number of values.");
            val_5 = 0;
            return (System.Collections.Hashtable)val_5;
        }
        
        System.Collections.Hashtable val_3 = null;
        val_5 = val_3;
        val_3 = new System.Collections.Hashtable();
        val_6 = null;
        val_6 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 0;
        goto label_8;
        label_19:
        val_7 = 七丗丝世丒丕丝丆丂.Length;
        val_8 = LeanTween.七丞丙丒三丕且丌丟;
        if(val_8 >= val_7)
        {
                val_7 = 七丗丝世丒丕丝丆丂.Length;
            val_8 = LeanTween.七丞丙丒三丕且丌丟;
        }
        
        object val_6 = 七丗丝世丒丕丝丆丂[0];
        val_8 = val_8 + 1;
        object val_7 = 七丗丝世丒丕丝丆丂[(long)val_8];
        if(val_5 == null)
        {
            goto label_13;
        }
        
        if(val_6 == null)
        {
            goto label_14;
        }
        
        label_16:
        var val_4 = (null == null) ? (val_6) : 0;
        goto label_15;
        label_13:
        if(val_6 != null)
        {
            goto label_16;
        }
        
        label_14:
        label_15:
        val_6 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 2;
        label_8:
        val_6 = null;
        if(LeanTween.七丞丙丒三丕且丌丟 < 七丗丝世丒丕丝丆丂.Length)
        {
            goto label_19;
        }
        
        return (System.Collections.Hashtable)val_5;
    }
    private static int 丕丟丑与不下丒丞丈(int 丙下不丏丅丅专丂丗)
    {
        丙下不丏丅丅专丂丗 = 丙下不丏丅丅专丂丗 & 65535;
        return (int)丙下不丏丅丅专丂丗;
    }
    private static int 万丂丂丟世三丙丑且(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, 不丞七业上七丘丑丒 丝万丕丅丆丂三丈一, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_21;
        UnityEngine.Object val_22;
        var val_23;
        var val_24;
        int val_26;
        var val_27;
        int val_29;
        int val_31;
        var val_32;
        var val_33;
        uint val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        丛丙丆丌七丘丘且世 val_41;
        丆丟上丝且三上丂丆 val_42;
        var val_43;
        var val_44;
        var val_45;
        LTRect val_46;
        var val_47;
        上三世丟丛丘东丌丕 val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_21 = 丛丛丁丟上东丈丗上;
        val_22 = 下丐三丆丝与不丗丕;
        val_23 = null;
        val_23 = null;
        LeanTween.init(丄东丛丗三丘丐丞丟:  LeanTween.下七不丑丁丄业且丐);
        if(val_22 == 0)
        {
            goto label_5;
        }
        
        val_24 = null;
        val_24 = null;
        LeanTween.丏丂丛丙丆三专丂丛 = 0;
        val_26 = LeanTween.startSearch;
        goto label_8;
        label_27:
        val_27 = null;
        int val_24 = LeanTween.下七不丑丁丄业且丐;
        val_24 = val_24 - 1;
        if(LeanTween.七丞丙丒三丕且丌丟 >= val_24)
        {
                val_27 = null;
            LeanTween.七丞丙丒三丕且丌丟 = 0;
        }
        
        val_27 = null;
        val_24 = null;
        if((LeanTween.丏且与丕丅七不丁丅.Length + 32 + 16) == 0)
        {
            goto label_19;
        }
        
        val_24 = null;
        LeanTween.丏丂丛丙丆三专丂丛 = 1;
        val_29 = LeanTween.下七不丑丁丄业且丐;
        if(LeanTween.丏丂丛丙丆三专丂丛 >= val_29)
        {
            goto label_22;
        }
        
        val_24 = null;
        val_26 = LeanTween.七丞丙丒三丕且丌丟 + 1;
        label_8:
        LeanTween.七丞丙丒三丕且丌丟 = val_26;
        val_24 = null;
        if(LeanTween.丏丂丛丙丆三专丂丛 < LeanTween.下七不丑丁丄业且丐)
        {
            goto label_27;
        }
        
        goto label_28;
        label_19:
        val_24 = null;
        val_31 = LeanTween.七丞丙丒三丕且丌丟;
        if((val_31 + 1) > LeanTween.下世一一丝丕世三七)
        {
                val_24 = null;
            val_31 = LeanTween.七丞丙丒三丕且丌丟;
            val_31 = val_31 + 1;
            LeanTween.下世一一丝丕世三七 = val_31;
        }
        
        val_24 = null;
        int val_25 = LeanTween.七丞丙丒三丕且丌丟;
        val_25 = val_25 + 1;
        LeanTween.startSearch = val_25;
        label_28:
        val_24 = null;
        val_32 = null;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3);
        LeanTween.丞万丈丙东且丗与下 = (LeanTween.丏且与丕丅七不丁丅 + ((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3) + 32;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_32 = null;
        }
        
        丒世丅业丝东下与丗 = true;
        LeanTween.丞万丈丙东且丗与下.丞专丙万丕不丗丈丛();
        丄上七丟不丗丕下丟 = val_22.transform;
        val_33 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_33 = null;
        }
        
        专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
        mem2[0] = 专丂丕丗丗东世丞下.y;
        mem2[0] = 专丂丕丗丗东世丞下.z;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_33 = null;
        }
        
        丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_33 = null;
        }
        
        丁丅丈丌丟世丗丗丟 = 丝万丕丅丆丂三丈一;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
                val_33 = null;
        }
        
        丛丛丁丟上东丈丗上 = val_21;
        val_22 = LeanTween.七丞丙丒三丕且丌丟;
        val_34 = val_22;
        丛丙丆丌七丘丘且世 val_5 = LeanTween.丞万丈丙东且丗与下.丐世下不一丁丟丅专(丞丅上丏丂且下丅与:  val_34);
        if(val_21 == null)
        {
            goto label_49;
        }
        
        if(val_21 == null)
        {
            goto label_50;
        }
        
        val_35 = null;
        val_35 = null;
        三丄丙业一三丛丄丂 = 1;
        if((System.Type.op_Equality(left:  val_21.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_56;
        }
        
        val_36 = null;
        val_36 = null;
        三丄丙业一三丛丄丂 = null;
        goto label_89;
        label_22:
        val_29 = LeanTween.下七不丑丁丄业且丐;
        object val_11 = LeanTween.logError(丂七东不不丈一丐不:  "LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( "("LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( ") + val_29 << 1(val_29 << 1) + " );");
        label_5:
        val_37 = 0;
        return (int)val_37.丛东丐丐东专丟丂丂();
        label_50:
        val_22 = 0;
        goto label_64;
        label_56:
        if((System.Type.op_Equality(left:  val_21.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == false)
        {
            goto label_67;
        }
        
        val_38 = null;
        val_38 = null;
        val_39 = 0;
        goto label_73;
        label_67:
        string val_15 = val_21.ToString();
        if((val_15.Equals(value:  "easeOutQuad")) == false)
        {
            goto label_76;
        }
        
        val_40 = null;
        val_40 = null;
        val_41 = LeanTween.丞万丈丙东且丗与下;
        val_42 = 2;
        goto label_86;
        label_76:
        if((val_15.Equals(value:  "easeInQuad")) == false)
        {
            goto label_82;
        }
        
        val_43 = null;
        val_43 = null;
        val_41 = LeanTween.丞万丈丙东且丗与下;
        val_42 = 3;
        goto label_86;
        label_73:
        丛丆丁业东上丁丆丘 = ;
        goto label_89;
        label_82:
        if((val_15.Equals(value:  "easeInOutQuad")) == false)
        {
            goto label_89;
        }
        
        val_44 = null;
        val_44 = null;
        val_41 = LeanTween.丞万丈丙东且丗与下;
        val_42 = 4;
        label_86:
        三丄丙业一三丛丄丂 = val_42;
        label_89:
        val_22 = 1;
        label_64:
        if(val_21 == null)
        {
            goto label_93;
        }
        
        val_45 = null;
        val_45 = null;
        val_46 = val_21;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_96;
        }
        
        if(val_46 != null)
        {
            goto label_97;
        }
        
        goto label_101;
        label_96:
        if(val_46 == null)
        {
            goto label_101;
        }
        
        label_97:
        val_46 = 0;
        label_101:
        val_22 = val_22 + 1;
        丝丛丁丏丑丞丈三一 = val_46;
        label_93:
        if(val_21 == null)
        {
            goto label_102;
        }
        
        val_47 = null;
        val_47 = null;
        val_48 = val_21;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_105;
        }
        
        if(val_48 != null)
        {
            goto label_106;
        }
        
        goto label_110;
        label_105:
        if(val_48 == null)
        {
            goto label_110;
        }
        
        label_106:
        val_48 = 0;
        label_110:
        val_22 = val_22 + 1;
        丛丄业丕且丗下一万 = val_48;
        label_102:
        if(val_21 != null)
        {
                val_49 = null;
            val_49 = null;
            val_22 = val_22 + 1;
            丕丕世且下一与丝与 = null;
        }
        
        if(val_21 != null)
        {
                val_50 = null;
            val_50 = null;
            val_22 = val_22 + 1;
            七丙东丌丂丞丑万丅 = null;
        }
        
        if(val_21 != null)
        {
                val_51 = null;
            val_51 = null;
            val_22 = val_22 + 1;
            丞丘丘丂丏万丗丛丄 = null;
        }
        
        if(val_21 != null)
        {
                val_52 = null;
            val_52 = null;
            val_22 = val_22 + 1;
            上丒一丂丞丅丏丅丂 = null;
        }
        
        if(val_21 != null)
        {
                val_53 = null;
            val_53 = null;
            世七业七一七丅丌丗 = null;
            if(((LeanTween.丏且与丕丅七不丁丅 + ((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3) + 32.上丒一丂丞丅丏丅丂) == 35)
        {
                val_54 = null;
            val_54 = null;
            上丒一丂丞丅丏丅丂 = 36;
        }
        
            val_22 = val_22 + 1;
        }
        
        if(val_21 != null)
        {
                val_55 = null;
            val_55 = null;
            val_22 = val_22 + 1;
            丅专与丒丈丗丒丘丌 = new UnityEngine.Vector3();
            mem2[0] = null;
        }
        
        if(val_21 != null)
        {
                val_56 = null;
            val_56 = null;
            val_22 = val_22 + 1;
            世丐世丄不不丈丗丏 = new UnityEngine.Vector3();
            mem2[0] = null;
        }
        
        if(val_21 > val_22)
        {
            goto label_144;
        }
        
        label_49:
        val_57 = null;
        val_57 = null;
        if(LeanTween.丞万丈丙东且丗与下 == null)
        {
            goto label_153;
        }
        
        丛丛丁丟上东丈丗上 = 0;
        label_144:
        val_58 = null;
        val_58 = null;
        丛丙丆丌七丘丘且世[] val_22 = LeanTween.丏且与丕丅七不丁丅 + (((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3);
        val_21 = mem[(LeanTween.丏且与丕丅七不丁丅 + ((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3) + 32];
        val_21 = (LeanTween.丏且与丕丅七不丁丅 + ((LeanTween.七丞丙丒三丕且丌丟 + 1)) << 3) + 32;
        val_37 = val_21;
        return (int)val_37.丛东丐丐东专丟丂丂();
        label_153:
        val_59 = 0;
    }
    public static int value(string 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, string 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  new System.Collections.Hashtable());
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, string 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float, System.Collections.Hashtable> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  丈丗与丞一上且上上, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, string 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 0;
        mem2[0] = 0;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 0;
        mem2[0] = 0;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<float, System.Collections.Hashtable> 丘丝一下一一丛丞东, float 丈丗与丞一上且上上, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 0;
        mem2[0] = 0;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, string 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  25, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 丈丗与丞一上且上上.x;
        mem2[0] = 丈丗与丞一上且上上.y;
        mem2[0] = 丈丗与丞一上且上上.z;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, string 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<UnityEngine.Vector3> 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  25, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 丈丗与丞一上且上上.x;
        mem2[0] = 丈丗与丞一上且上上.y;
        mem2[0] = 丈丗与丞一上且上上.z;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<UnityEngine.Vector3, System.Collections.Hashtable> 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        UnityEngine.GameObject val_4 = 下丐三丆丝与不丗丕;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        val_4 = (LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_4, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  25, 丛丛丁丟上东丈丗上:  val_1)) & 65535;
        丛丙丆丌七丘丘且世[] val_3 = LeanTween.丏且与丕丅七不丁丅 + (((val_2 & 65535)) << 3);
        mem2[0] = 丈丗与丞一上且上上.x;
        mem2[0] = 丈丗与丞一上且上上.y;
        mem2[0] = 丈丗与丞一上且上上.z;
        return (int)val_4;
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<UnityEngine.Vector3> 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int value(UnityEngine.GameObject 下丐三丆丝与不丗丕, System.Action<UnityEngine.Vector3, System.Collections.Hashtable> 丘丝一下一一丛丞东, UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.value(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丘丝一下一一丛丞东:  丘丝一下一一丛丞东, 丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotate(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  22, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int rotate(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotate(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotate(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        LeanTween.init();
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_5;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_5:
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  30, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int rotate(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotate(丝丛丁丏丑丞丈三一:  丝丛丁丏丑丞丈三一, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotateX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  13, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int rotateX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotateX(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotateY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  14, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int rotateY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotateY(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotateZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  15, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int rotateZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotateZ(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotateLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  23, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int rotateLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotateLocal(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int rotateAround(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 世丐世丄不不丈丗丏, float 丘丂丂丅丁一丈丕三, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_2;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_2:
        if(val_4 == null)
        {
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        }
        
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  16, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int rotateAround(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 世丐世丄不不丈丗丏, float 丘丂丂丅丁一丈丕三, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.rotateAround(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 世丐世丄不不丈丗丏:  new UnityEngine.Vector3() {x = 世丐世丄不不丈丗丏.x, y = 世丐世丄不不丈丗丏.y, z = 世丐世丄不不丈丗丏.z}, 丘丂丂丅丁一丈丕三:  丘丂丂丅丁一丈丕三, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  0, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveX(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  1, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveY(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  2, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveZ(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  20, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.move(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4;
        var val_5;
        var val_6;
        object val_7;
        UnityEngine.GameObject val_8;
        val_4 = 丛丛丁丟上东丈丗上;
        int val_4 = 专丂丕丗丗东世丞下.Length;
        if(val_4 <= 3)
        {
            goto label_2;
        }
        
        val_4 = val_4 & 3;
        if(val_4 == 0)
        {
            goto label_3;
        }
        
        val_5 = 1152921505100935168;
        val_6 = null;
        val_7 = "LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...";
        goto label_4;
        label_2:
        val_5 = 1152921505100935168;
        val_6 = null;
        val_7 = "LeanTween - When passing values for a vector path, you must pass four or more values!";
        label_4:
        if(LeanTween.throwErrors != false)
        {
                UnityEngine.Debug.LogError(message:  val_7);
            val_8 = 0;
            return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8 = 下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  6, 丛丛丁丟上东丈丗上:  System.Collections.Hashtable val_1 = null);
        }
        
        UnityEngine.Debug.Log(message:  val_7);
        val_8 = 0;
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  6, 丛丛丁丟上东丈丗上:  val_1);
        label_3:
        LeanTween.init();
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_17;
        }
        
        }
        
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_17:
        上三世丟丛丘东丌丕 val_2 = new 上三世丟丛丘东丌丕(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
        if(val_4 != null)
        {
                .丌业丞丌丛世不丞丑 = true;
        }
        
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  6, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int move(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.move(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int move(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        LeanTween.init();
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_5;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_5:
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y});
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  26, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int move(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z});
        return LeanTween.move(丝丛丁丏丑丞丈三一:  丝丛丁丏丑丞丈三一, 专丂丕丗丗东世丞下:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  21, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveLocal(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4;
        var val_5;
        var val_6;
        object val_7;
        UnityEngine.GameObject val_8;
        val_4 = 丛丛丁丟上东丈丗上;
        int val_4 = 专丂丕丗丗东世丞下.Length;
        if(val_4 <= 3)
        {
            goto label_2;
        }
        
        val_4 = val_4 & 3;
        if(val_4 == 0)
        {
            goto label_3;
        }
        
        val_5 = 1152921505100935168;
        val_6 = null;
        val_7 = "LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...";
        goto label_4;
        label_2:
        val_5 = 1152921505100935168;
        val_6 = null;
        val_7 = "LeanTween - When passing values for a vector path, you must pass four or more values!";
        label_4:
        if(LeanTween.throwErrors != false)
        {
                UnityEngine.Debug.LogError(message:  val_7);
            val_8 = 0;
            return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8 = 下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  7, 丛丛丁丟上东丈丗上:  System.Collections.Hashtable val_1 = null);
        }
        
        UnityEngine.Debug.Log(message:  val_7);
        val_8 = 0;
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  7, 丛丛丁丟上东丈丗上:  val_1);
        label_3:
        LeanTween.init();
        if(val_4 == null)
        {
                val_4 = val_1;
            val_1 = new System.Collections.Hashtable();
        }
        
        上三世丟丛丘东丌丕 val_2 = new 上三世丟丛丘东丌丕(三丝不丂丆丟专丘万:  专丂丕丗丗东世丞下);
        if(val_4 != null)
        {
                .丌业丞丌丛世不丞丑 = true;
        }
        
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  val_8, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  7, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int moveLocal(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3[] 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveLocal(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveLocalX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  3, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveLocalX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveLocalX(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveLocalY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  4, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveLocalY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveLocalY(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int moveLocalZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  5, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int moveLocalZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.moveLocalZ(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int scale(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  24, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int scale(UnityEngine.GameObject 下丐三丆丝与不丗丕, UnityEngine.Vector3 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.scale(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int scale(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_4 = 丛丛丁丟上东丈丗上;
        LeanTween.init();
        if(val_4 != null)
        {
                if(val_4 != null)
        {
            goto label_5;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_5:
        UnityEngine.Vector3 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y});
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  28, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int scale(LTRect 丝丛丁丏丑丞丈三一, UnityEngine.Vector2 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.scale(丝丛丁丏丑丞丈三一:  丝丛丁丏丑丞丈三一, 专丂丕丗丗东世丞下:  new UnityEngine.Vector2() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int alpha(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        LeanTween.init();
        if((丛丛丁丟上东丈丗上 == null) || (丛丛丁丟上东丈丗上 == null))
        {
            goto label_4;
        }
        
        label_10:
        丝丛丁丏丑丞丈三一.alphaEnabled = true;
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  29, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
        label_4:
        System.Collections.Hashtable val_3 = new System.Collections.Hashtable();
        if(丝丛丁丏丑丞丈三一 != null)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    public static int alpha(LTRect 丝丛丁丏丑丞丈三一, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.alpha(丝丛丁丏丑丞丈三一:  丝丛丁丏丑丞丈三一, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int scaleX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  10, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int scaleX(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.scaleX(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int scaleY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  11, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int scaleY(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.scaleY(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int scaleZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  12, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int scaleZ(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.scaleZ(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int delayedCall(float 丂七上与上不丘丐丛, string 业丏丈世世世丞丒世, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        LeanTween.init();
        return LeanTween.delayedCall(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 丂七上与上不丘丐丛:  丂七上与上不丘丐丛, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int delayedCall(float 丂七上与上不丘丐丛, System.Action 业丏丈世世世丞丒世, object[] 丛丛丁丟上东丈丗上)
    {
        LeanTween.init();
        return LeanTween.delayedCall(下丐三丆丝与不丗丕:  LeanTween.tweenEmpty, 丂七上与上不丘丐丛:  丂七上与上不丘丐丛, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, string 业丏丈世世世丞丒世, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.delayedCall(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丂七上与上不丘丐丛:  丂七上与上不丘丐丛, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, System.Action 业丏丈世世世丞丒世, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.delayedCall(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 丂七上与上不丘丐丛:  丂七上与上不丘丐丛, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    public static int delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, string 业丏丈世世世丞丒世, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_3 = 丛丛丁丟上东丈丗上;
        if(val_3 != null)
        {
                if(val_3 != null)
        {
            goto label_3;
        }
        
        }
        
        System.Collections.Hashtable val_1 = null;
        val_3 = val_1;
        val_1 = new System.Collections.Hashtable();
        label_3:
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, System.Action 业丏丈世世世丞丒世, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_3 = 丛丛丁丟上东丈丗上;
        if(val_3 == null)
        {
                System.Collections.Hashtable val_1 = null;
            val_3 = val_1;
            val_1 = new System.Collections.Hashtable();
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int delayedCall(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 丂七上与上不丘丐丛, System.Action<object> 业丏丈世世世丞丒世, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        System.Collections.Hashtable val_3 = 丛丛丁丟上东丈丗上;
        if(val_3 == null)
        {
                System.Collections.Hashtable val_1 = null;
            val_3 = val_1;
            val_1 = new System.Collections.Hashtable();
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丂三丟丂丈丐丆丗丟:  丂七上与上不丘丐丛, 丝万丕丅丆丂三丈一:  19, 丛丛丁丟上东丈丗上:  val_1);
    }
    public static int alpha(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, System.Collections.Hashtable 丛丛丁丟上东丈丗上)
    {
        return (int)LeanTween.万丂丂丟世三丙丑且(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝万丕丅丆丂三丈一:  17, 丛丛丁丟上东丈丗上:  丛丛丁丟上东丈丗上);
    }
    public static int alpha(UnityEngine.GameObject 下丐三丆丝与不丗丕, float 专丂丕丗丗东世丞下, float 丂三丟丂丈丐丆丗丟, object[] 丛丛丁丟上东丈丗上)
    {
        return LeanTween.alpha(下丐三丆丝与不丗丕:  下丐三丆丝与不丗丕, 专丂丕丗丗东世丞下:  专丂丕丗丗东世丞下, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丛丛丁丟上东丈丗上:  LeanTween.h(七丗丝世丒丕丝丆丂:  丛丛丁丟上东丈丗上));
    }
    private static float 且丘丞丄丑与东不且(丛丙丆丌七丘丘且世 上丙丛一丒丒丆丛丄, float 丁丁丛丟丝不上丌三)
    {
        UnityEngine.Vector3 val_2;
        UnityEngine.Vector3 val_3;
        if(上丙丛一丒丒丆丛丄 != null)
        {
                val_2 = 上丙丛一丒丒丆丛丄.丈丗与丞一上且上上;
            val_3 = 上丙丛一丒丒丆丛丄.丕丙丘丂丙七丘丕丆;
        }
        else
        {
                val_2 = 0f;
            val_3 = 1.643967E-34f;
        }
        
        float val_1 = 上丙丛一丒丒丆丛丄.丛丆丁业东上丁丆丘.Evaluate(time:  丁丁丛丟丝不上丌三);
        val_1 = val_3 * val_1;
        val_1 = val_2 + val_1;
        return (float)val_1;
    }
    private static UnityEngine.Vector3 一不丙丗丏业丒丏丝(丛丙丆丌七丘丘且世 上丙丛一丒丒丆丛丄, float 丁丁丛丟丝不上丌三)
    {
        UnityEngine.Vector3 val_9;
        if(上丙丛一丒丒丆丛丄 != null)
        {
                val_9 = 上丙丛一丒丒丆丛丄.丕丙丘丂丙七丘丕丆;
        }
        else
        {
                val_9 = 1.643967E-34f;
        }
        
        float val_9 = 0f;
        val_9 = val_9 + (val_9 * (上丙丛一丒丒丆丛丄.丛丆丁业东上丁丆丘.Evaluate(time:  丁丁丛丟丝不上丌三)));
        float val_7 = S13 + (S14 * (上丙丛一丒丒丆丛丄.丛丆丁业东上丁丆丘.Evaluate(time:  丁丁丛丟丝不上丌三)));
        float val_8 = S15 + (S11 * (上丙丛一丒丒丆丛丄.丛丆丁业东上丁丆丘.Evaluate(time:  丁丁丛丟丝不上丌三)));
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private static float 丑丐一且万万丕丑丈(float 丄且一丄丏丆丐丗与, float 丕丙丘丂丙七丘丕丆, float 丁丁丛丟丝不上丌三)
    {
        丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
        丁丁丛丟丝不上丌三 = 丁丁丛丟丝不上丌三 + (-2f);
        丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
        丄且一丄丏丆丐丗与 = 丄且一丄丏丆丐丗与 - 丕丙丘丂丙七丘丕丆;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 一七与丙一丙丙丙丆(float 丄且一丄丏丆丐丗与, float 丕丙丘丂丙七丘丕丆, float 丁丁丛丟丝不上丌三)
    {
        丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
        丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
        丄且一丄丏丆丐丗与 = 丕丙丘丂丙七丘丕丆 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丘丁与丒丏丏万丘一(float 丄且一丄丏丆丐丗与, float 丕丙丘丂丙七丘丕丆, float 丁丁丛丟丝不上丌三)
    {
        float val_1;
        丁丁丛丟丝不上丌三 = 丁丁丛丟丝不上丌三 + 丁丁丛丟丝不上丌三;
        if(丁丁丛丟丝不上丌三 < 0)
        {
                丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 0.5f;
            丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
            val_1 = 丁丁丛丟丝不上丌三 * 丕丙丘丂丙七丘丕丆;
        }
        else
        {
                丁丁丛丟丝不上丌三 = 丁丁丛丟丝不上丌三 + (-1f);
            丕丙丘丂丙七丘丕丆 = 丕丙丘丂丙七丘丕丆 * (-0.5f);
            float val_1 = -2f;
            val_1 = 丁丁丛丟丝不上丌三 + val_1;
            丁丁丛丟丝不上丌三 = 丁丁丛丟丝不上丌三 * val_1;
            丁丁丛丟丝不上丌三 = 丁丁丛丟丝不上丌三 + (-1f);
            val_1 = 丕丙丘丂丙七丘丕丆 * 丁丁丛丟丝不上丌三;
        }
        
        丄且一丄丏丆丐丗与 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丟丅丅东七丗丐且丝(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        return UnityEngine.Mathf.Lerp(a:  丄且一丄丏丆丐丗与, b:  丈丝世且万世丈丌万, t:  下下丏一丙不丘丌丞);
    }
    private static float 且丝丏专丄下丗丈七(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(val_1 < 0)
        {
                float val_1 = 360f;
            val_1 = val_1 - 丄且一丄丏丆丐丗与;
            val_1 = val_1 + 丈丝世且万世丈丌万;
        }
        else
        {
                if(val_1 > 180f)
        {
                float val_2 = 360f;
            val_2 = val_2 - 丈丝世且万世丈丌万;
            val_2 = val_2 + 丄且一丄丏丆丐丗与;
            val_1 = -val_2;
        }
        
        }
        
        val_1 = val_1 * 下下丏一丙不丘丌丞;
        val_1 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)val_1;
    }
    private static float 丈丛丌三丛东下丗丐(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = UnityEngine.Mathf.Clamp01(value:  下下丏一丙不丘丌丞);
        float val_4 = 2.5f;
        float val_5 = 3.141593f;
        val_4 = val_1 * val_4;
        val_4 = val_1 * val_4;
        val_4 = val_1 * val_4;
        val_5 = val_1 * val_5;
        val_4 = val_4 + 0.2f;
        val_4 = val_5 * val_4;
        float val_2 = 1f - val_1;
        float val_6 = val_2;
        float val_7 = 1.2f;
        val_6 = val_4 * val_6;
        val_6 = val_1 + val_6;
        val_7 = val_2 * val_7;
        val_7 = val_7 + 1f;
        val_6 = val_7 * val_6;
        val_6 = (丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与) * val_6;
        val_6 = val_6 + 丄且一丄丏丆丐丗与;
        return (float)val_6;
    }
    private static float 丘业丅一丘三丆下专(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 业丆丝万丒丈业丈丙(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-2f);
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丄且一丄丏丆丐丗与 - 丈丝世且万世丈丌万;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丟丙丐丈丂丄丞丞一(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
            val_1 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
        }
        else
        {
                下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1f);
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * (-0.5f);
            float val_1 = -2f;
            val_1 = 下下丏一丙不丘丌丞 + val_1;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1f);
            val_1 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        }
        
        丄且一丄丏丆丐丗与 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 三丙丝丕丘丞丞且丑(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丆丐丏丒丘丕丁丝丂(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = -1f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_1;
        val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 1f;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 与丈业东且万丝不丄(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            val_1 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
        }
        else
        {
                float val_1 = -2f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_1;
            val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 2f;
            val_1 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        }
        
        丄且一丄丏丆丐丗与 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丌丙一下且上丌丏丄(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丆东且专丘且且丗一(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1f);
        float val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
        val_1 = 下下丏一丙不丘丌丞 * val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1f);
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丄且一丄丏丆丐丗与 - 丈丝世且万世丈丌万;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 与丟丞丌丂丁不丙丄(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_2;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            val_2 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
        }
        else
        {
                下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-2f);
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * (-0.5f);
            float val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
            val_1 = 下下丏一丙不丘丌丞 * val_1;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-2f);
            val_2 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        }
        
        丄且一丄丏丆丐丗与 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 与丅丁丆丙七丁丄丐(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 丟且丞丝一且丟丂丙(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = -1f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_1;
        val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
        val_1 = 下下丏一丙不丘丌丞 * val_1;
        val_1 = 下下丏一丙不丘丌丞 * val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 1f;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 世下丑丑丘不与丗丙(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            丈丝世且万世丈丌万 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
            val_1 = 下下丏一丙不丘丌丞 * 丈丝世且万世丈丌万;
        }
        else
        {
                float val_1 = -2f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_1;
            val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
            val_1 = 下下丏一丙不丘丌丞 * val_1;
            val_1 = 下下丏一丙不丘丌丞 * val_1;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_1;
            丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 0.5f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 2f;
            val_1 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        }
        
        丄且一丄丏丆丐丗与 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 业专丗丕丒丞丒丘丟(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万;
        val_1 = val_1 - 丄且一丄丏丆丐丗与;
        float val_2 = 1.570796f;
        val_2 = 下下丏一丙不丘丌丞 * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_1 - val_2;
        val_2 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)val_2;
    }
    private static float 丟丆不丑丄丐东世且(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万;
        val_1 = val_1 - 丄且一丄丏丆丐丗与;
        float val_2 = 1.570796f;
        val_2 = 下下丏一丙不丘丌丞 * val_2;
        val_2 = val_1 * val_2;
        val_2 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)val_2;
    }
    private static float 丛业丙丘一业丗丛东(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万;
        val_1 = val_1 - 丄且一丄丏丆丐丗与;
        float val_2 = 3.141593f;
        val_2 = 下下丏一丙不丘丌丞 * val_2;
        float val_3 = -0.5f;
        val_3 = val_1 * val_3;
        val_2 = val_2 + (-1f);
        val_2 = val_3 * val_2;
        val_2 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)val_2;
    }
    private static float 丁丙丞七世丈丝业专(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万;
        val_1 = val_1 - 丄且一丄丏丆丐丗与;
        float val_2 = -1f;
        val_2 = 下下丏一丙不丘丌丞 + val_2;
        val_2 = val_2 * 10f;
        val_2 = val_1 * val_2;
        val_2 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)val_2;
    }
    private static float 丈上三丗丝东丈丒丆(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 丈丝世且万世丈丌万;
        val_1 = val_1 - 丄且一丄丏丆丐丗与;
        float val_2 = -10f;
        val_2 = 下下丏一丙不丘丌丞 * val_2;
        val_2 = 1f - val_2;
        val_2 = val_1 * val_2;
        val_2 = val_2 + 丄且一丄丏丆丐丗与;
        return (float)val_2;
    }
    private static float 丞丟与丆世丒丅丆丐(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        float val_2;
        float val_1 = 下下丏一丙不丘丌丞;
        float val_2 = 丈丝世且万世丈丌万;
        val_1 = val_1 + val_1;
        val_2 = val_2 - 丄且一丄丏丆丐丗与;
        if(val_1 < 0)
        {
                float val_3 = -1f;
            val_3 = val_1 + val_3;
            val_1 = val_3 * 10f;
            val_2 = val_2 * 0.5f;
        }
        else
        {
                val_1 = val_1 + (-1f);
            float val_4 = -10f;
            val_4 = val_1 * val_4;
            val_2 = val_2 * 0.5f;
            val_1 = 2f - val_4;
        }
        
        val_1 = val_2 * val_1;
        val_1 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)val_1;
    }
    private static float 丅一丄丟东三丘东七(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_2;
        float val_3 = 丈丝世且万世丈丌万;
        float val_1 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
        float val_2 = 1f;
        val_2 = val_2 - val_1;
        val_3 = val_3 - 丄且一丄丏丆丐丗与;
        if(val_1 >= _TYPE_MAX_)
        {
                val_2 = val_2;
        }
        
        val_2 = val_2 + (-1f);
        val_2 = val_3 * val_2;
        val_2 = 丄且一丄丏丆丐丗与 - val_2;
        return (float)val_2;
    }
    private static float 专下丗丒且丆丕丑丈(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        float val_1 = 下下丏一丙不丘丌丞;
        float val_4 = 丈丝世且万世丈丌万;
        float val_2 = -1f;
        val_1 = val_1 + val_2;
        val_2 = val_1 * val_1;
        float val_3 = 1f;
        val_3 = val_3 - val_2;
        val_4 = val_4 - 丄且一丄丏丆丐丗与;
        if(val_2 >= _TYPE_MAX_)
        {
                val_1 = val_3;
        }
        
        val_1 = val_4 * val_1;
        val_1 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)val_1;
    }
    private static float 丑七丛丈不丟丛上丅(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        float val_4 = 丈丝世且万世丈丌万;
        float val_1 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        if(val_1 < 0)
        {
                val_5 = val_1 * val_1;
            val_6 = -1f;
            val_7 = -0.5f;
        }
        else
        {
                val_1 = val_1 + (-2f);
            val_5 = val_1 * val_1;
            val_7 = 0.5f;
            val_6 = 1f;
        }
        
        val_4 = val_4 - 丄且一丄丏丆丐丗与;
        if(val_5 >= _TYPE_MAX_)
        {
                val_8 = 1f - val_5;
        }
        
        val_8 = val_6 + val_8;
        val_8 = (val_4 * val_7) * val_8;
        val_8 = val_8 + 丄且一丄丏丆丐丗与;
        return (float)val_8;
    }
    private static float 且丅不丌与一丞丗丒(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_2 = 丈丝世且万世丈丌万;
        val_2 = val_2 - 丄且一丄丏丆丐丗与;
        下下丏一丙不丘丌丞 = 1f - 下下丏一丙不丘丌丞;
        float val_1 = LeanTween.丕丝下三下上丂万丙(丄且一丄丏丆丐丗与:  0f, 丈丝世且万世丈丌万:  val_2, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
        val_1 = val_2 - val_1;
        val_1 = val_1 + 丄且一丄丏丆丐丗与;
        return (float)val_1;
    }
    private static float 丕丝下三下上丂万丙(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                float val_1 = 7.5625f;
            val_1 = 下下丏一丙不丘丌丞 * val_1;
            val_1 = val_1 * 下下丏一丙不丘丌丞;
        }
        else
        {
                if(下下丏一丙不丘丌丞 < 0)
        {
                float val_2 = -0.5454546f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_2;
            val_2 = 下下丏一丙不丘丌丞 * 7.5625f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_2;
            val_1 = 下下丏一丙不丘丌丞 + 0.75f;
        }
        else
        {
                if((double)下下丏一丙不丘丌丞 < 0)
        {
                float val_3 = -0.8181818f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_3;
            val_3 = 下下丏一丙不丘丌丞 * 7.5625f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_3;
            val_1 = 下下丏一丙不丘丌丞 + 0.9375f;
        }
        else
        {
                float val_4 = -0.9545454f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + val_4;
            val_4 = 下下丏一丙不丘丌丞 * 7.5625f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_4;
            val_1 = 下下丏一丙不丘丌丞 + 0.984375f;
        }
        
        }
        
        }
        
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * val_1;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 专七七丝丂丑丞丒一(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_6;
        float val_5 = 丈丝世且万世丈丌万;
        val_5 = val_5 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
            val_6 = (LeanTween.且丅不丌与一丞丗丒(丄且一丄丏丆丐丗与:  0f, 丈丝世且万世丈丌万:  val_5, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞)) * 0.5f;
        }
        else
        {
                下下丏一丙不丘丌丞 = (下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞) + (-1f);
            float val_3 = LeanTween.丕丝下三下上丂万丙(丄且一丄丏丆丐丗与:  0f, 丈丝世且万世丈丌万:  val_5, 下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞);
            val_3 = val_3 * 0.5f;
            val_6 = (val_5 * 0.5f) + val_3;
        }
        
        val_6 = val_6 + 丄且一丄丏丆丐丗与;
        return (float)val_6;
    }
    private static float 上业丆丘丅且丌丂一(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 2.70158f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1.70158f);
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 与丛丁丒与丒下万专(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_1 = 2.70158f;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-1f);
        float val_2 = 1.70158f;
        val_1 = 下下丏一丙不丘丌丞 * val_1;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        val_2 = val_1 + val_2;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * val_2;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 1f;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 * 下下丏一丙不丘丌丞;
        丄且一丄丏丆丐丗与 = 丈丝世且万世丈丌万 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 业丗丞丌丕丘三业丕(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_3;
        float val_4;
        下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 下下丏一丙不丘丌丞;
        丈丝世且万世丈丌万 = 丈丝世且万世丈丌万 - 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 < 0)
        {
                val_3 = 丈丝世且万世丈丌万 * 0.5f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 3.594909f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-2.594909f);
            val_4 = (下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞) * 下下丏一丙不丘丌丞;
        }
        else
        {
                下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + (-2f);
            val_3 = 丈丝世且万世丈丌万 * 0.5f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 3.594909f;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 + 2.594909f;
            下下丏一丙不丘丌丞 = (下下丏一丙不丘丌丞 * 下下丏一丙不丘丌丞) * 下下丏一丙不丘丌丞;
            val_4 = 下下丏一丙不丘丌丞 + 2f;
        }
        
        val_3 = val_3 * val_4;
        丄且一丄丏丆丐丗与 = val_3 + 丄且一丄丏丆丐丗与;
        return (float)丄且一丄丏丆丐丗与;
    }
    private static float 东丄世丌丒且丅一不(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_3;
        float val_4;
        val_3 = 丈丝世且万世丈丌万;
        val_4 = 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 == 0f)
        {
                return (float)val_4;
        }
        
        val_3 = val_3 - val_4;
        if(下下丏一丙不丘丌丞 == 1f)
        {
                val_4 = val_3 + val_4;
            return (float)val_4;
        }
        
        float val_1 = 下下丏一丙不丘丌丞 + (-1f);
        float val_3 = 10f;
        val_3 = val_1 * val_3;
        float val_4 = -0.075f;
        val_4 = val_1 + val_4;
        val_4 = val_4 * 6.283185f;
        val_4 = val_4 / 0.3f;
        val_4 = (val_3 * val_3) * val_4;
        val_4 = val_4 - val_4;
        return (float)val_4;
    }
    private static float 三丘丛丕一丕丁与东(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_3;
        float val_4;
        val_3 = 丈丝世且万世丈丌万;
        val_4 = 丄且一丄丏丆丐丗与;
        if(下下丏一丙不丘丌丞 == 0f)
        {
                return (float)val_4;
        }
        
        float val_1 = val_3 - val_4;
        if(下下丏一丙不丘丌丞 == 1f)
        {
                val_4 = val_1 + val_4;
            return (float)val_4;
        }
        
        float val_3 = -10f;
        val_3 = 下下丏一丙不丘丌丞 * val_3;
        val_3 = val_3;
        float val_4 = -0.075f;
        val_4 = 下下丏一丙不丘丌丞 + val_4;
        val_4 = val_4 * 6.283185f;
        val_4 = val_4 / 0.3f;
        val_4 = (val_1 * val_3) * val_4;
        val_4 = val_1 + val_4;
        val_4 = val_4 + val_4;
        return (float)val_4;
    }
    private static float 东丟上丗丁世且丅三(float 丄且一丄丏丆丐丗与, float 丈丝世且万世丈丌万, float 下下丏一丙不丘丌丞)
    {
        float val_6;
        float val_7;
        val_6 = 下下丏一丙不丘丌丞;
        val_7 = 丄且一丄丏丆丐丗与;
        if(val_6 == 0f)
        {
                return (float)val_7;
        }
        
        float val_1 = val_6 + val_6;
        val_6 = 丈丝世且万世丈丌万 - val_7;
        if(val_1 == 2f)
        {
                val_7 = val_6 + val_7;
            return (float)val_7;
        }
        
        float val_2 = val_1 + (-1f);
        if(val_1 < 0)
        {
                float val_5 = 10f;
            val_5 = val_2 * val_5;
            float val_6 = -0.075f;
            val_6 = val_2 + val_6;
            val_6 = val_6 * 6.283185f;
            val_6 = val_6 / 0.3f;
            val_6 = (val_6 * val_5) * val_6;
            val_6 = val_6 * (-0.5f);
            val_7 = val_7 + val_6;
            return (float)val_7;
        }
        
        float val_7 = -10f;
        val_7 = val_2 * val_7;
        float val_8 = -0.075f;
        val_8 = val_2 + val_8;
        val_8 = val_8 * 6.283185f;
        val_8 = val_8 / 0.3f;
        val_8 = (val_6 * val_7) * val_8;
        val_8 = val_8 * 0.5f;
        val_8 = val_6 + val_8;
        val_7 = val_8 + val_7;
        return (float)val_7;
    }
    public static void addListener(int 丟丟丄专上丟丁丐丝, System.Action<丐丌七丅丌下上且丏> 业丏丈世世世丞丒世)
    {
        LeanTween.addListener(与丗丆丏丙丟与丒业:  LeanTween.tweenEmpty, 丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世);
    }
    public static void addListener(UnityEngine.GameObject 与丗丆丏丙丟与丒业, int 丟丟丄专上丟丁丐丝, System.Action<丐丌七丅丌下上且丏> 业丏丈世世世丞丒世)
    {
        System.Action<丐丌七丅丌下上且丏>[] val_16;
        var val_17;
        var val_19;
        var val_20;
        var val_21;
        int val_23;
        var val_24;
        int val_26;
        val_16 = 丟丟丄专上丟丁丐丝;
        val_17 = null;
        val_17 = null;
        if(LeanTween.上丟世丝丏丏且丆与 == null)
        {
                int val_1 = LeanTween.LISTENERS_MAX * LeanTween.EVENTS_MAX;
            System.Action<丐丌七丅丌下上且丏>[] val_2 = new System.Action<丐丌七丅丌下上且丏>[0];
            LeanTween.上丟世丝丏丏且丆与 = val_2;
            int val_3 = LeanTween.LISTENERS_MAX * LeanTween.EVENTS_MAX;
            UnityEngine.GameObject[] val_4 = new UnityEngine.GameObject[0];
            val_17 = null;
            LeanTween.七东万丅丒丑丄丙丌 = val_4;
        }
        
        val_17 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 0;
        goto label_8;
        label_37:
        int val_5 = LeanTween.七丞丙丒三丕且丌丟 + (LeanTween.LISTENERS_MAX * val_16);
        UnityEngine.GameObject[] val_6 = LeanTween.七东万丅丒丑丄丙丌 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        if((mem[(val_4 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32]) == 0)
        {
            goto label_20;
        }
        
        val_19 = null;
        val_19 = null;
        System.Action<丐丌七丅丌下上且丏>[] val_8 = LeanTween.上丟世丝丏丏且丆与 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        if((mem[(val_2 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32]) == 0)
        {
            goto label_20;
        }
        
        val_20 = null;
        val_20 = null;
        UnityEngine.GameObject[] val_9 = LeanTween.七东万丅丒丑丄丙丌 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        if((mem[(val_4 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32]) == 与丗丆丏丙丟与丒业)
        {
                val_21 = null;
            val_21 = null;
            System.Action<丐丌七丅丌下上且丏>[] val_11 = LeanTween.上丟世丝丏丏且丆与 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
            if((mem[(val_2 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32]) == 业丏丈世世世丞丒世)
        {
                return;
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 1;
        label_8:
        val_17 = null;
        val_23 = LeanTween.LISTENERS_MAX;
        if(LeanTween.七丞丙丒三丕且丌丟 < val_23)
        {
            goto label_37;
        }
        
        val_23 = LeanTween.LISTENERS_MAX;
        UnityEngine.Debug.LogError(message:  "You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = "("You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = ") + val_23 << 1(val_23 << 1));
        return;
        label_20:
        val_24 = null;
        val_24 = null;
        val_16 = LeanTween.上丟世丝丏丏且丆与;
        if(业丏丈世世世丞丒世 != null)
        {
                System.Action<丐丌七丅丌下上且丏> val_16 = val_2[4];
        }
        
        System.Action<丐丌七丅丌下上且丏>[] val_14 = val_16 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        mem2[0] = 业丏丈世世世丞丒世;
        if(与丗丆丏丙丟与丒业 != null)
        {
                UnityEngine.GameObject val_17 = val_4[4];
        }
        
        UnityEngine.GameObject[] val_15 = LeanTween.七东万丅丒丑丄丙丌 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        mem2[0] = 与丗丆丏丙丟与丒业;
        val_26 = LeanTween.七丞丙丒三丕且丌丟;
        if(val_26 < LeanTween.丄丂且下丝不三东业)
        {
                return;
        }
        
        val_26 = LeanTween.七丞丙丒三丕且丌丟;
        LeanTween.丄丂且下丝不三东业 = 2;
    }
    public static bool removeListener(int 丟丟丄专上丟丁丐丝, System.Action<丐丌七丅丌下上且丏> 业丏丈世世世丞丒世)
    {
        return LeanTween.removeListener(与丗丆丏丙丟与丒业:  LeanTween.tweenEmpty, 丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 业丏丈世世世丞丒世:  业丏丈世世世丞丒世);
    }
    public static bool removeListener(UnityEngine.GameObject 与丗丆丏丙丟与丒业, int 丟丟丄专上丟丁丐丝, System.Action<丐丌七丅丌下上且丏> 业丏丈世世世丞丒世)
    {
        UnityEngine.GameObject[] val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = 业丏丈世世世丞丒世;
        val_8 = null;
        val_8 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 0;
        goto label_3;
        label_20:
        int val_1 = LeanTween.七丞丙丒三丕且丌丟 + (LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝);
        UnityEngine.GameObject[] val_2 = LeanTween.七东万丅丒丑丄丙丌 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        if(((LeanTween.七东万丅丒丑丄丙丌 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32) != 与丗丆丏丙丟与丒业)
        {
            goto label_10;
        }
        
        val_9 = null;
        val_9 = null;
        System.Action<丐丌七丅丌下上且丏>[] val_4 = LeanTween.上丟世丝丏丏且丆与 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        if(((LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3) + 32) == val_7)
        {
            goto label_15;
        }
        
        label_10:
        val_8 = null;
        val_8 = null;
        LeanTween.七丞丙丒三丕且丌丟 = 1;
        label_3:
        val_8 = null;
        if(LeanTween.七丞丙丒三丕且丌丟 < LeanTween.丄丂且下丝不三东业)
        {
            goto label_20;
        }
        
        val_10 = 0;
        return (bool)val_10;
        label_15:
        val_11 = null;
        val_11 = null;
        System.Action<丐丌七丅丌下上且丏>[] val_5 = LeanTween.上丟世丝丏丏且丆与 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        (LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3).__unknownFiledOffset_20 = 0;
        val_7 = LeanTween.七东万丅丒丑丄丙丌;
        UnityEngine.GameObject[] val_6 = val_7 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3);
        (LeanTween.七东万丅丒丑丄丙丌 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + LeanTween.七丞丙丒三丕且丌丟)) << 3).__unknownFiledOffset_20 = 0;
        val_10 = 1;
        return (bool)val_10;
    }
    public static void dispatchEvent(int 丟丟丄专上丟丁丐丝)
    {
        LeanTween.dispatchEvent(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 一丐丗丁丞丆丅丟丄:  0);
    }
    public static void dispatchEvent(int 丟丟丄专上丟丁丐丝, object 一丐丗丁丞丆丅丟丄)
    {
        System.Action<丐丌七丅丌下上且丏>[] val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = 0;
        goto label_1;
        label_26:
        val_8 = LeanTween.上丟世丝丏丏且丆与;
        int val_1 = val_9 + (LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝);
        System.Action<丐丌七丅丌下上且丏>[] val_2 = val_8 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3);
        if(((LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3) + 32) != 0)
        {
                val_10 = null;
            val_10 = null;
            UnityEngine.GameObject[] val_3 = LeanTween.七东万丅丒丑丄丙丌 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3);
            val_11 = null;
            if((UnityEngine.Object.op_Implicit(exists:  (LeanTween.七东万丅丒丑丄丙丌 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3) + 32)) != false)
        {
                val_12 = null;
            System.Action<丐丌七丅丌下上且丏>[] val_5 = LeanTween.上丟世丝丏丏且丆与 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3);
            val_8 = mem[(LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3) + 32];
            val_8 = (LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3) + 32;
            val_8.Invoke(obj:  new 丐丌七丅丌下上且丏(丞丅上丏丂且下丅与:  丟丟丄专上丟丁丐丝, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄));
        }
        else
        {
                val_13 = null;
            val_8 = LeanTween.上丟世丝丏丏且丆与;
            System.Action<丐丌七丅丌下上且丏>[] val_7 = val_8 + (((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3);
            (LeanTween.上丟世丝丏丏且丆与 + ((long)(int)((LeanTween.LISTENERS_MAX * 丟丟丄专上丟丁丐丝) + val_9)) << 3).__unknownFiledOffset_20 = 0;
        }
        
        }
        
        val_9 = 1;
        label_1:
        val_14 = null;
        val_14 = null;
        if(val_9 < LeanTween.丄丂且下丝不三东业)
        {
            goto label_26;
        }
    
    }
    public LeanTween()
    {
    
    }
    private static LeanTween()
    {
        LeanTween.throwErrors = true;
        LeanTween.下世一一丝丕世三七 = 0;
        LeanTween.下七不丑丁丄业且丐 = 400;
        LeanTween.丞丏丑丌丏专丄丌丂 = 0;
        UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[9];
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        val_1[1] = 0;
        val_1[2] = 0;
        val_1[2] = 0;
        val_1[3] = 0;
        val_1[3] = 0;
        val_1[4] = 0;
        val_1[4] = 0;
        val_1[5] = 0;
        val_1[5] = 0;
        val_1[6] = 0;
        val_1[6] = 0;
        val_1[7] = 0;
        val_1[7] = 0;
        val_1[8] = 0;
        mem2[0] = 0;
        LeanTween.七下丈一丂七丁丏与 = new UnityEngine.AnimationCurve(keys:  val_1);
        UnityEngine.Keyframe[] val_3 = new UnityEngine.Keyframe[4];
        val_3[0] = 0;
        val_3[0] = 0;
        val_3[1] = 0;
        val_3[1] = 0;
        val_3[2] = 0;
        val_3[2] = 0;
        val_3[3] = 0;
        val_3[3] = 0;
        LeanTween.丑业不丌丂丘与业丄 = new UnityEngine.AnimationCurve(keys:  val_3);
        LeanTween.startSearch = 0;
        LeanTween.丄丂且下丝不三东业 = 0;
        LeanTween.EVENTS_MAX = 10;
        LeanTween.LISTENERS_MAX = 10;
    }

}
