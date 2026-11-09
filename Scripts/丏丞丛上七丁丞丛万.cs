using UnityEngine;
public static class 丏丞丛上七丁丞丛万
{
    // Fields
    private static System.Collections.Generic.List<WeaponSkinSettings> 丌与一丌丒丈丂业丆;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<WeaponSkinSettings>> 上丙丂专丙丘丝与丝;
    
    // Properties
    internal static System.Collections.Generic.List<WeaponSkinSettings> 不不丕丏丏一一丈丆 { get; }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<WeaponSkinSettings>> 丑丕万丞丒丝丛丗丅 { get; }
    
    // Methods
    private static 丏丞丛上七丁丞丛万()
    {
        丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<WeaponSkinSettings>>();
        if(AuthSceneController.一不丆丏与丐丏丈丄() != false)
        {
                丏丞丛上七丁丞丛万.丛丒丑丕丏丟世丆丝();
            return;
        }
        
        AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丏丞丛上七丁丞丛万::丛丒丑丕丏丟世丆丝()));
    }
    internal static System.Collections.Generic.List<WeaponSkinSettings> 与丝丂丘上丏丑丛丙()
    {
        System.Collections.Generic.List<TSource> val_4;
        var val_5;
        System.Collections.Generic.List<WeaponSkinSettings> val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = 丏丞丛上七丁丞丛万.丌与一丌丒丈丂业丆;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_6 = 丏丞丛上七丁丞丛万.丌与一丌丒丈丂业丆;
        if(val_6 == null)
        {
                val_6 = 0;
        }
        
        if(val_6.Count != 0)
        {
            goto label_7;
        }
        
        label_3:
        val_7 = null;
        val_4 = System.Linq.Enumerable.ToList<WeaponSkinSettings>(source:  UnityEngine.Resources.LoadAll<WeaponSkinSettings>(path:  "WeaponSkinsV2"));
        val_7 = null;
        丏丞丛上七丁丞丛万.丌与一丌丒丈丂业丆 = val_4;
        label_7:
        val_8 = null;
        val_8 = null;
        return (System.Collections.Generic.List<WeaponSkinSettings>)丏丞丛上七丁丞丛万.丌与一丌丒丈丂业丆;
    }
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<WeaponSkinSettings>> 丞丕丟丆丕丌专丈专()
    {
        var val_5;
        var val_14;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<WeaponSkinSettings>> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = null;
        val_14 = null;
        val_15 = 丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝;
        if(val_15.Count != 0)
        {
            goto label_38;
        }
        
        val_15 = 丏丞丛上七丁丞丛万.与丝丂丘上丏丑丛丙();
        List.Enumerator<T> val_3 = val_15.GetEnumerator();
        label_25:
        if((1754840704 & 1) == 0)
        {
            goto label_8;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        val_16 = null;
        val_16 = null;
        val_17 = null;
        if((丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝.ContainsKey(key:  val_6.WeaponPrefabName)) == false)
        {
            goto label_13;
        }
        
        val_18 = null;
        丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝.Item[val_6.WeaponPrefabName].Add(item:  val_6);
        goto label_25;
        label_13:
        val_19 = null;
        System.Collections.Generic.List<WeaponSkinSettings> val_12 = new System.Collections.Generic.List<WeaponSkinSettings>();
        null.Add(item:  val_6);
        丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝.Add(key:  val_6.WeaponPrefabName, value:  null);
        goto label_25;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_38:
        val_20 = null;
        val_20 = null;
        return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<WeaponSkinSettings>>)丏丞丛上七丁丞丛万.上丙丂专丙丘丝与丝;
    }
    internal static WeaponSkinSettings 丆丄三丐丌世下万丟(string 丝与丙丘丞且丄专丅)
    {
        .丝与丙丘丞且丄专丅 = 丝与丙丘丞且丄专丅;
        return System.Linq.Enumerable.FirstOrDefault<WeaponSkinSettings>(source:  丏丞丛上七丁丞丛万.与丝丂丘上丏丑丛丙(), predicate:  new System.Func<WeaponSkinSettings, System.Boolean>(object:  new 丏丞丛上七丁丞丛万.丒丑万一丁丕东一丗(), method:  System.Boolean 丏丞丛上七丁丞丛万.丒丑万一丁丕东一丗::丌且丏丂与丞丙丝丌(WeaponSkinSettings 三丟东丕丄丄下下丑)));
    }
    internal static PGCompany.丟丝世万东万丆丟上 丏丌丗丛丅丗丕丘专(string 丅丐丞丞丐丘东丘丘)
    {
        Progress.丟丕丒丑东丗丑丏丑 val_1 = Progress.七七世万专丕丁上业.丌丌业万丗丘丗丞丄();
        if(val_1 != null)
        {
                return val_1.丂业丑上七丆与上上(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘);
        }
        
        return val_1.丂业丑上七丆与上上(丅丐丞丞丐丘东丘丘:  丅丐丞丞丐丘东丘丘);
    }
    internal static void 万三一且丞丏一丗七(PGCompany.丟丝世万东万丆丟上 丞丝丌七丁万丗丐一)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丙三丐丆丕丟丟丆业(丛丆世丂丒丁不世不:  丞丝丌七丁万丗丐一);
    }
    internal static void 丄东下丒丙东业丘七(PGCompany.丟丝世万东万丆丟上 丞丝丌七丁万丗丐一)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丄业丞丆东丘且丏专(丛丆世丂丒丁不世不:  丞丝丌七丁万丗丐一);
    }
    internal static bool 与丏丘丏丆丗丌专丅(PGCompany.丟丝世万东万丆丟上 丞丝丌七丁万丗丐一)
    {
        Progress.丟丕丒丑东丗丑丏丑 val_1 = Progress.七七世万专丕丁上业.丌丌业万丗丘丗丞丄();
        if(val_1 != null)
        {
                return val_1.与丏丘丏丆丗丌专丅(丛丆世丂丒丁不世不:  丞丝丌七丁万丗丐一);
        }
        
        return val_1.与丏丘丏丆丗丌专丅(丛丆世丂丒丁不世不:  丞丝丌七丁万丗丐一);
    }
    internal static System.Collections.Generic.List<WeaponSkinSettings> 丟丛下丟业丈丟丟上(string 丈丁丄丘丛世七丙丝)
    {
        var val_4;
        var val_5;
        System.Collections.Generic.List<WeaponSkinSettings> val_2 = new System.Collections.Generic.List<WeaponSkinSettings>();
        List.Enumerator<T> val_3 = 丏丞丛上七丁丞丛万.丙且七业七专一且丈(丈丁丄丘丛世七丙丝:  丈丁丄丘丛世七丙丝).GetEnumerator();
        label_18:
        if((1755673472 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(val_6.AvailableForPurchase == true)
        {
            goto label_6;
        }
        
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_6.SkinIndex);
        val_4 = 0;
        val_5 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == false)
        {
            goto label_9;
        }
        
        label_6:
        val_2.Add(item:  val_6);
        goto label_18;
        label_9:
        val_5 = 0;
        if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且七东专世丝丒丟一(丞一丁业丄一一业且:  val_6.name, 专丏世丑与丐丝丝七:  true, 丗与丟上上丑专世丗:  new System.Nullable<OfferModule>() {HasValue = false})) == false)
        {
            goto label_18;
        }
        
        val_2.Add(item:  val_6);
        goto label_18;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_2;
    }
    internal static System.Collections.Generic.List<WeaponSkinSettings> 丙且七业七专一且丈(string 丈丁丄丘丛世七丙丝)
    {
        var val_9;
        var val_10;
        System.Func<WeaponSkinSettings, System.Boolean> val_12;
        var val_13;
        val_9 = 1152921505339326464;
        if((丏丞丛上七丁丞丛万.丞丕丟丆丕丌专丈专().ContainsKey(key:  丈丁丄丘丛世七丙丝)) != false)
        {
                val_10 = null;
            val_10 = null;
            val_12 = 丏丞丛上七丁丞丛万.<>c.<>9__13_0;
            if(val_12 == null)
        {
                System.Func<WeaponSkinSettings, System.Boolean> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Func<WeaponSkinSettings, System.Boolean>(object:  丏丞丛上七丁丞丛万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丏丞丛上七丁丞丛万.<>c::丁一万丙丂丅业丌丁(WeaponSkinSettings 三丟东丕丄丄下下丑));
            丏丞丛上七丁丞丛万.<>c.<>9__13_0 = val_12;
        }
        
            val_13 = System.Linq.Enumerable.ToList<WeaponSkinSettings>(source:  System.Linq.Enumerable.OrderByDescending<WeaponSkinSettings, System.Boolean>(source:  丏丞丛上七丁丞丛万.丞丕丟丆丕丌专丈专().Item[丈丁丄丘丛世七丙丝], keySelector:  val_5));
            return (System.Collections.Generic.List<WeaponSkinSettings>)val_13;
        }
        
        System.Collections.Generic.List<WeaponSkinSettings> val_8 = null;
        val_13 = val_8;
        val_8 = new System.Collections.Generic.List<WeaponSkinSettings>(capacity:  0);
        return (System.Collections.Generic.List<WeaponSkinSettings>)val_13;
    }
    internal static void 且丑东东东专下丕不()
    {
        var val_5;
        var val_9;
        var val_10;
        var val_11;
        Dictionary.Enumerator<TKey, TValue> val_2 = 丏丞丛上七丁丞丛万.丞丕丟丆丕丌专丈专().GetEnumerator();
        val_9 = 0;
        val_10 = 0;
        var val_9 = 0;
        label_14:
        if((1756012144 & 1) == 0)
        {
            goto label_4;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        List.Enumerator<T> val_7 = val_6._value._obj.GetEnumerator();
        label_7:
        if((1756012096 & 1) == 0)
        {
            goto label_6;
        }
        
        string val_8 = val_5.丐丏七丌丕丗业且上();
        goto label_7;
        label_6:
        val_9 = val_9 + 1;
        mem2[0] = 69;
        val_11 = val_10;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((val_9 == 1) || ((1152921540722597376 + ((0 + 1)) << 2) != 69))
        {
            goto label_11;
        }
        
        var val_10 = 0;
        val_10 = val_10 ^ (val_9 >> 31);
        val_9 = val_9 + val_10;
        goto label_14;
        label_11:
        if( == 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_4:
        val_9 = val_9 + 1;
        mem2[0] = 94;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_9 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921540722597376 + ((0 + 1)) << 2) == 94)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    internal static void 世丘上丈丅丂丛业丈(string 丅丐丞丞丐丘东丘丘)
    {
        var val_3;
        var val_4;
        string val_16;
        PGCompany.丟丝世万东万丆丟上 val_17;
        val_16 = 丅丐丞丞丐丘东丘丘;
        List.Enumerator<T> val_2 = 丏丞丛上七丁丞丛万.丙且七业七专一且丈(丈丁丄丘丛世七丙丝:  val_16).GetEnumerator();
        label_18:
        if((1756169488 & 1) == 0)
        {
            goto label_4;
        }
        
        string val_5 = val_4.丐丏七丌丕丗业且上();
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  val_5.SkinIndex);
        if(val_5.IsDefault == false)
        {
            goto label_18;
        }
        
        val_3 = 0;
        val_4 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
        {
            goto label_18;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Приобретаем дефолтный скин для пушки: "("Приобретаем дефолтный скин для пушки: ") + val_16);
        PGCompany.丗丟丄丈东丝丕丄世 val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        if(val_13 != null)
        {
                var val_14 = (null == null) ? (val_13) : 0;
        }
        else
        {
                val_17 = 0;
        }
        
        if((丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  val_16)) != null)
        {
            goto label_18;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Эквипаем дефолтный скин");
        丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  val_17);
        goto label_18;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal static void 丛丒丑丕丏丟世丆丝()
    {
        var val_8;
        object val_9;
        var val_32;
        PGCompany.丟丝世万东万丆丟上 val_33;
        var val_34;
        AuthSceneController.万丅东丝七三丕丞丈(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void 丏丞丛上七丁丞丛万::丛丒丑丕丏丟世丆丝()));
        val_32 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if((val_32.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  66)) > 0)
        {
                return;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  163);
        List.Enumerator<T> val_7 = Progress.七七世万专丕丁上业.专不丛丛丕一丌丂丕().与丆丄丈丅丟下丙丞().GetEnumerator();
        label_40:
        if((1756412560 & 1) == 0)
        {
            goto label_12;
        }
        
        string val_11 = 丏丞丛上七丁丞丛万.丛丘丟丗丕万东一丈(丞与丟丆下丏一万业:  val_9.丙东专丂世丈丏丁丂());
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_11)) == false)
        {
            goto label_40;
        }
        
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_11);
        val_8 = 0;
        val_9 = 0;
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != null)
        {
            goto label_40;
        }
        
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  146, 丞丅上丏丂且下丅与:  val_11);
        val_33 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        if(val_33 != null)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        val_33 = 0;
        val_34 = 1;
        goto label_23;
        label_22:
        val_34 = 0;
        label_23:
        三丅丁丗丗丝丂万且 val_21 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_33.上专丗丏丛丁专丑丄().WeaponPrefabName);
        if(((val_21 == null) || (((Progress.七七世万专丕丁上业.专不丛丛丕一丌丂丕().丙与业东丗丈专丞丘(丞专东丏丈下丛丞且:  val_21.业东丅东丌上丗丑不())) & 2147483648) != 0)) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  val_33.上专丗丏丛丁专丑丄().WeaponTag)) == null))
        {
            goto label_40;
        }
        
        丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  val_33);
        goto label_40;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_9 = 1;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  66, 丙业与丙丗丝不丈东:  val_9);
        val_32 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_32.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    private static string 丛丘丟丗丕万东一丈(Rilisoft.WeaponSkin.三丐不东业东不丄丑 丞与丟丆下丏一万业)
    {
        var val_2;
        if((丞与丟丆下丏一万业 - 1) <= 16)
        {
                val_2 = mem[130688768 + ((丞与丟丆下丏一万业 - 1)) << 3];
            val_2 = 130688768 + ((丞与丟丆下丏一万业 - 1)) << 3;
            return (string)val_2;
        }
        
        val_2 = "";
        return (string)val_2;
    }

}
