using UnityEngine;
internal sealed class FreeplayModeSpawnController : PGBehaviour
{
    // Fields
    internal static FreeplayModeSpawnController 丆丕丝丒不丙且丐丗;
    public bool forcePredictedSpawnPoint;
    public System.Collections.Generic.List<string> areaLocalizationKeys;
    private int 丟万业下丛丁东业一;
    private UnityEngine.Vector3 丗丕上业丑业丆且丆;
    
    // Methods
    private void Awake()
    {
        FreeplayModeSpawnController.丆丕丝丒不丙且丐丗 = this;
    }
    internal System.Collections.Generic.List<int> 世丂丛丕丌丁丟万丌()
    {
        float val_7;
        System.Collections.Generic.List<Player_move_c> val_24;
        var val_25;
        var val_26;
        var val_27;
        int val_28;
        var val_29;
        var val_31;
        System.Func<丌丘丛上世丞三丕与, System.Int32> val_33;
        int val_1 = this.areaLocalizationKeys.Count;
        System.Collections.Generic.List<丌丘丛上世丞三丕与> val_2 = new System.Collections.Generic.List<丌丘丛上世丞三丕与>();
        if(val_1 >= 1)
        {
                int val_24 = 0;
            do
        {
            FreeplayModeSpawnController.丌丘丛上世丞三丕与 val_3 = new FreeplayModeSpawnController.丌丘丛上世丞三丕与();
            if(val_3 != null)
        {
                .且丁丑丕东专丂七下 = val_24;
        }
        else
        {
                mem[16] = val_24;
        }
        
            .下丘下丝丂丄丝三东 = 0;
            val_2.Add(item:  val_3);
            val_24 = val_24 + 1;
        }
        while(val_1 != val_24);
        
        }
        
        System.Collections.Generic.List<PlayerSpawnPoint> val_4 = 丘丛丞且一丅丁丏丐.丅丐丙业丟丙与丁丄(万丕丘七丝丁三丄业:  9, 丈丌三丌丐丟三上且:  0);
        val_24 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙;
        List.Enumerator<T> val_5 = val_24.GetEnumerator();
        val_25 = 1152921525761785056;
        goto label_12;
        label_26:
        val_24 = val_7.丐丏七丌丕丗业且上();
        if(val_7 < 0)
        {
            goto label_12;
        }
        
        val_26 = 0;
        val_27 = 0;
        goto label_13;
        label_20:
        PlayerSpawnPoint val_9 = val_4.Item[0];
        UnityEngine.Vector3 val_10 = val_9.万东万丆专丌丕丐丗.position;
        float val_11 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
        var val_13 = (val_11 < 0) ? (val_11) : 3.402823E+38f;
        val_26 = 1;
        label_13:
        if(val_26 < val_4.Count)
        {
            goto label_20;
        }
        
        PlayerSpawnPoint val_15 = val_4.Item[(val_11 < 0) ? (val_26) : (val_27)];
        val_24 = val_2.Item[val_15.areaNumber];
        if(val_24 != null)
        {
                val_28 = val_16.下丘下丝丂丄丝三东;
            val_25 = 1152921525761785056;
        }
        else
        {
                val_25 = 1152921525761785056;
            val_28 = val_16.下丘下丝丂丄丝三东;
        }
        
        mem2[0] = val_28 + 1;
        label_12:
        if(((-1425351952) & 1) != 0)
        {
            goto label_26;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<TSource> val_19 = System.Linq.Enumerable.ToList<丌丘丛上世丞三丕与>(source:  丞东丑专丛丆丄丝世.丛且一丙七七丑东世<丌丘丛上世丞三丕与>(丑东与丅丐丅丂丞业:  val_2));
        val_29 = null;
        val_29 = null;
        if((FreeplayModeSpawnController.<>c.<>9__7_0) == null)
        {
            goto label_45;
        }
        
        label_55:
        val_19.Sort(comparison:  FreeplayModeSpawnController.<>c.<>9__7_0);
        val_31 = null;
        val_31 = null;
        val_33 = FreeplayModeSpawnController.<>c.<>9__7_1;
        if(val_33 != null)
        {
                return (System.Collections.Generic.List<System.Int32>)System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<丌丘丛上世丞三丕与, System.Int32>(source:  val_19, selector:  System.Func<丌丘丛上世丞三丕与, System.Int32> val_20 = null));
        }
        
        val_33 = val_20;
        val_20 = new System.Func<丌丘丛上世丞三丕与, System.Int32>(object:  FreeplayModeSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreeplayModeSpawnController.<>c::下世丝丁丅丈丘丈上(FreeplayModeSpawnController.丌丘丛上世丞三丕与 三丟东丕丄丄下下丑));
        FreeplayModeSpawnController.<>c.<>9__7_1 = val_33;
        return (System.Collections.Generic.List<System.Int32>)System.Linq.Enumerable.ToList<System.Int32>(source:  System.Linq.Enumerable.Select<丌丘丛上世丞三丕与, System.Int32>(source:  val_19, selector:  val_20));
        label_45:
        FreeplayModeSpawnController.<>c.<>9__7_0 = new System.Comparison<丌丘丛上世丞三丕与>(object:  FreeplayModeSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreeplayModeSpawnController.<>c::万丕三丄上一丄上丒(FreeplayModeSpawnController.丌丘丛上世丞三丕与 专丟丒丐丘丈丈三丑, FreeplayModeSpawnController.丌丘丛上世丞三丕与 业且丝万七三丝丈丒));
        if(val_19 != null)
        {
            goto label_55;
        }
        
        goto label_55;
    }
    internal PlayerSpawnPoint 万专万三丏万丌丞且(bool 丕丅不业专丑丁上丅)
    {
        var val_9;
        int val_10;
        UnityEngine.Object val_11;
        val_9 = this;
        var val_9 = this.areaLocalizationKeys.Count;
        if(val_9 >= 1)
        {
                do
        {
            new System.Collections.Generic.List<System.Int32>().Add(item:  0);
            val_9 = val_9 - 1;
        }
        while(val_9 != 0);
        
        }
        
        if(丕丅不业专丑丁上丅 != false)
        {
                val_10 = this.丟万业下丛丁东业一;
        }
        else
        {
                val_10 = this.丑万万丕万丑丙丒丝();
        }
        
        val_11 = RespawnWindow.丑七不且上丗丁一世();
        if(val_11 != 0)
        {
                val_11 = RespawnWindow.丑七不且上丗丁一世();
            if(val_6.丅丗丌丅丐三丞丑万 != false)
        {
                val_10 = this.丟万业下丛丁东业一;
        }
        
        }
        
        if(val_10 != 1)
        {
                return val_8.丏丙且与丂丞东丁专(且丁丑丕东专丂七下:  val_10 = val_8);
        }
        
        val_9 = this.世丂丛丕丌丁丟万丌();
        int val_8 = val_9.Item[0];
        return val_8.丏丙且与丂丞东丁专(且丁丑丕东专丂七下:  val_10);
    }
    internal PlayerSpawnPoint 丏丙且与丂丞东丁专(int 且丁丑丕东专丂七下)
    {
        var val_8;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        FreeplayModeSpawnController.丌万一一业丝丁丈丝 val_39;
        var val_41;
        int val_42;
        var val_43;
        FreeplayModeSpawnController.丌万一一业丝丁丈丝 val_1 = new FreeplayModeSpawnController.丌万一一业丝丁丈丝();
        .且丁丑丕东专丂七下 = 且丁丑丕东专丂七下;
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<PlayerSpawnPoint>(source:  System.Linq.Enumerable.Where<PlayerSpawnPoint>(source:  丘丛丞且一丅丁丏丐.丅丐丙业丟丙与丁丄(万丕丘七丝丁三丄业:  9, 丈丌三丌丐丟三上且:  0), predicate:  new System.Func<PlayerSpawnPoint, System.Boolean>(object:  val_1, method:  System.Boolean FreeplayModeSpawnController.丌万一一业丝丁丈丝::丗丑丑与东丌丑丈丒(PlayerSpawnPoint 丅专与丒丈丗丒丘丌))));
        val_34 = 0;
        goto label_27;
        label_32:
        val_35 = null;
        val_35 = null;
        List.Enumerator<T> val_6 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_36 = 0;
        goto label_15;
        label_16:
        string val_9 = val_8.丐丏七丌丕丗业且上();
        PlayerSpawnPoint val_10 = val_5.Item[0];
        UnityEngine.Vector3 val_11 = val_10.万东万丆专丌丕丐丗.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) < 0)
        {
                val_36 = 1;
        }
        
        label_15:
        if(((-1424945680) & 1) != 0)
        {
            goto label_16;
        }
        
        var val_34 = 1;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_34 == 1)
        {
            goto label_24;
        }
        
        var val_33 = 0;
        val_33 = val_33 ^ 0;
        val_34 = val_34 + val_33;
        if(val_5 != null)
        {
            goto label_29;
        }
        
        label_30:
        label_29:
        val_5.Item[0].丕七丂且三与上丗丌(丐与丝专丄丘丈丘上:  1);
        val_34 = 1;
        goto label_27;
        label_24:
        if(val_5 != null)
        {
            goto label_29;
        }
        
        goto label_30;
        label_27:
        if(val_34 < val_5.Count)
        {
            goto label_32;
        }
        
        val_37 = null;
        val_38 = 1152921530971216224;
        val_39 = val_1;
        if((FreeplayModeSpawnController.<>c.<>9__9_1) == null)
        {
            goto label_36;
        }
        
        label_62:
        val_5.Sort(comparison:  FreeplayModeSpawnController.<>c.<>9__9_1);
        mem[1152921537541683880] = System.Linq.Enumerable.First<PlayerSpawnPoint>(source:  val_5);
        val_5.Sort(comparison:  new System.Comparison<PlayerSpawnPoint>(object:  val_1, method:  System.Int32 FreeplayModeSpawnController.丌万一一业丝丁丈丝::万丗丞与三丈丒丝业(PlayerSpawnPoint 三丑丝丗不丈丐丞与, PlayerSpawnPoint 丕七业丏专业上与丅)));
        System.Collections.Generic.List<PlayerSpawnPoint> val_17 = new System.Collections.Generic.List<PlayerSpawnPoint>();
        System.Collections.Generic.List<PlayerSpawnPoint> val_18 = new System.Collections.Generic.List<PlayerSpawnPoint>();
        val_41 = 0;
        goto label_47;
        label_53:
        val_39 = val_5.Item[0];
        if(val_39.丈丄丙丅不下丒且七() <= 0)
        {
            goto label_43;
        }
        
        if(val_41 == 0)
        {
            goto label_51;
        }
        
        label_50:
        val_39 = val_5.Item[0];
        val_18.Add(item:  val_39);
        label_51:
        val_41 = 1;
        goto label_47;
        label_43:
        val_17.Add(item:  val_5.Item[0]);
        if(val_41 != 0)
        {
            goto label_50;
        }
        
        goto label_51;
        label_47:
        float val_35 = (float)val_5.Count;
        val_35 = val_35 * 0.65f;
        if(val_41 < (int)val_35)
        {
            goto label_53;
        }
        
        if(val_17.Count == 0)
        {
            goto label_55;
        }
        
        val_42 = UnityEngine.Random.Range(min:  0, max:  val_17.Count - 1);
        val_43 = public PlayerSpawnPoint System.Collections.Generic.List<PlayerSpawnPoint>::get_Item(int index);
        return (PlayerSpawnPoint)val_18.Item[val_42];
        label_36:
        FreeplayModeSpawnController.<>c.<>9__9_1 = new System.Comparison<PlayerSpawnPoint>(object:  FreeplayModeSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 FreeplayModeSpawnController.<>c::丆丌丗丄丞丟丈丒丘(PlayerSpawnPoint 三丑丝丗不丈丐丞与, PlayerSpawnPoint 丕七业丏专业上与丅));
        if(val_5 != null)
        {
            goto label_62;
        }
        
        goto label_62;
        label_55:
        val_42 = UnityEngine.Random.Range(min:  0, max:  val_18.Count - 1);
        val_43 = public PlayerSpawnPoint System.Collections.Generic.List<PlayerSpawnPoint>::get_Item(int index);
        return (PlayerSpawnPoint)val_18.Item[val_42];
    }
    internal string 丑丕与万七东丕丁丕(int 且丁丑丕东专丂七下)
    {
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.areaLocalizationKeys.Item[且丁丑丕东专丂七下]);
    }
    internal void 丐一丞丞丂丑丝丏丄(int 且丁丑丕东专丂七下)
    {
        this.丟万业下丛丁东业一 = 且丁丑丕东专丂七下;
    }
    internal void 七三且丒丏丂丌丌丁(UnityEngine.Vector3 丗丕上业丑业丆且丆)
    {
        this.丗丕上业丑业丆且丆 = 丗丕上业丑业丆且丆;
        mem[1152921537542078064] = 丗丕上业丑业丆且丆.y;
        mem[1152921537542078068] = 丗丕上业丑业丆且丆.z;
    }
    private int 丑万万丕万丑丙丒丝()
    {
        var val_10;
        var val_11;
        UnityEngine.Transform val_12;
        var val_13;
        System.Collections.Generic.List<PlayerSpawnPoint> val_1 = 丘丛丞且一丅丁丏丐.丅丐丙业丟丙与丁丄(万丕丘七丝丁三丄业:  9, 丈丌三丌丐丟三上且:  0);
        val_10 = 0;
        val_11 = 0;
        goto label_3;
        label_9:
        val_12 = val_1.Count;
        val_13 = public PlayerSpawnPoint System.Collections.Generic.List<PlayerSpawnPoint>::get_Item(int index);
        if(val_10 >= val_12)
        {
            goto label_4;
        }
        
        label_10:
        PlayerSpawnPoint val_3 = val_1.Item[0];
        val_12 = val_3.万东万丆专丌丕丐丗;
        UnityEngine.Vector3 val_4 = val_12.position;
        float val_5 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = this.丗丕上业丑业丆且丆, y = V11.16B, z = V10.16B});
        var val_7 = (val_5 < 0) ? (val_5) : 3.402823E+38f;
        val_10 = 1;
        label_3:
        if(val_1 == null)
        {
            goto label_9;
        }
        
        val_13 = public PlayerSpawnPoint System.Collections.Generic.List<PlayerSpawnPoint>::get_Item(int index);
        if(val_10 < val_1.Count)
        {
            goto label_10;
        }
        
        label_4:
        if((val_1.Item[(val_5 < 0) ? (val_10) : (val_11)]) != null)
        {
                return (int)val_9.areaNumber;
        }
        
        return (int)val_9.areaNumber;
    }
    public FreeplayModeSpawnController()
    {
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        if(val_1 != null)
        {
                val_1.Add(item:  "Key_5443");
        }
        else
        {
                val_1.Add(item:  "Key_5443");
        }
        
        val_1.Add(item:  "Key_5688");
        if(val_1 != null)
        {
                val_1.Add(item:  "Key_5438");
        }
        else
        {
                val_1.Add(item:  "Key_5438");
        }
        
        val_1.Add(item:  "Key_5684");
        if(val_1 != null)
        {
                val_1.Add(item:  "Key_5674");
        }
        else
        {
                val_1.Add(item:  "Key_5674");
        }
        
        val_1.Add(item:  "Key_5446");
        if(val_1 != null)
        {
                val_1.Add(item:  "Key_5660");
        }
        else
        {
                val_1.Add(item:  "Key_5660");
        }
        
        val_1.Add(item:  "Key_5662");
        val_1.Add(item:  "Key_5903");
        this.areaLocalizationKeys = val_1;
        this.丟万业下丛丁东业一 = 0;
    }

}
