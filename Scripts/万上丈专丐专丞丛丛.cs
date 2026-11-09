using UnityEngine;
public static class 万上丈专丐专丞丛丛
{
    // Fields
    public static System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Reflection.ParameterInfo[]> 丂丞丈丏世丐丂一万;
    
    // Methods
    public static System.Reflection.ParameterInfo[] 且丌上世丕与丁丘丂(System.Reflection.MethodInfo 丈丙世世三丌丘丐东)
    {
        var val_3;
        var val_4;
        System.Reflection.MethodInfo val_5;
        val_3 = null;
        val_3 = null;
        if((万上丈专丐专丞丛丛.丂丞丈丏世丐丂一万.TryGetValue(key:  丈丙世世三丌丘丐东, value: out  0)) == true)
        {
                return (System.Reflection.ParameterInfo[])val_5;
        }
        
        val_4 = null;
        val_5 = 丈丙世世三丌丘丐东;
        val_4 = null;
        val_5 = val_5;
        万上丈专丐专丞丛丛.丂丞丈丏世丐丂一万.set_Item(key:  丈丙世世三丌丘丐东, value:  val_5);
        return (System.Reflection.ParameterInfo[])val_5;
    }
    public static PhotonView[] 丂一业万丐丘上万丏(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 != null)
        {
                return 丝三丁东丈丒世丅业.GetComponentsInChildren<PhotonView>(includeInactive:  true);
        }
        
        return 丝三丁东丈丒世丅业.GetComponentsInChildren<PhotonView>(includeInactive:  true);
    }
    public static PhotonView 丄丕业丅三丒丌七丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 != null)
        {
                return 丝三丁东丈丒世丅业.GetComponent<PhotonView>();
        }
        
        return 丝三丁东丈丒世丅业.GetComponent<PhotonView>();
    }
    public static bool 丙下且丒丑东丑丞丈(UnityEngine.Vector3 丞下万上三丘上与专, UnityEngine.Vector3 丒丈丙丐丏丕丆万丗, float 丞丞丙且丄不丈丌三)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丞下万上三丘上与专.x, y = 丞下万上三丘上与专.y, z = 丞下万上三丘上与专.z}, b:  new UnityEngine.Vector3() {x = 丒丈丙丐丏丕丆万丗.x, y = 丒丈丙丐丏丕丆万丗.y, z = 丒丈丙丐丏丕丆万丗.z});
        return (bool)(val_1.x < 0) ? 1 : 0;
    }
    public static bool 丙下且丒丑东丑丞丈(UnityEngine.Vector2 丞下万上三丘上与专, UnityEngine.Vector2 丒丈丙丐丏丕丆万丗, float 丞丞丙且丄不丈丌三)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 丞下万上三丘上与专.x, y = 丞下万上三丘上与专.y}, b:  new UnityEngine.Vector2() {x = 丒丈丙丐丏丕丆万丗.x, y = 丒丈丙丐丏丕丆万丗.y});
        return (bool)(val_1.x.sqrMagnitude < 0) ? 1 : 0;
    }
    public static bool 丙下且丒丑东丑丞丈(UnityEngine.Quaternion 丞下万上三丘上与专, UnityEngine.Quaternion 丒丈丙丐丏丕丆万丗, float 不丝丙丌七丄上东丛)
    {
        return (bool)((UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = 丞下万上三丘上与专.x, y = 丞下万上三丘上与专.y, z = 丞下万上三丘上与专.z, w = 丞下万上三丘上与专.w}, b:  new UnityEngine.Quaternion() {x = 丒丈丙丐丏丕丆万丗.x, y = 丒丈丙丐丏丕丆万丗.y, z = 丒丈丙丐丏丕丆万丗.z, w = 丒丈丙丐丏丕丆万丗.w})) < 0) ? 1 : 0;
    }
    public static bool 丙下且丒丑东丑丞丈(float 丞下万上三丘上与专, float 丒丈丙丐丏丕丆万丗, float 丌丕丗七丒丛万丒东)
    {
        丞下万上三丘上与专 = 丞下万上三丘上与专 - 丒丈丙丐丏丕丆万丗;
        return (bool)(System.Math.Abs(丞下万上三丘上与专) < 0) ? 1 : 0;
    }
    public static void 丝丅丌丁丒丟三丏上(System.Collections.IDictionary 丞下万上三丘上与专, System.Collections.IDictionary 丆丟丏丗下丘丌丛一)
    {
        var val_8;
        var val_15;
        var val_16;
        if(丆丟丏丗下丘丌丛一 == null)
        {
                return;
        }
        
        if((丞下万上三丘上与专 & 1) != 0)
        {
                return;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_8 = 2;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_8 = 0;
        System.Collections.IEnumerator val_4 = 丆丟丏丗下丘丌丛一.Keys.GetEnumerator();
        label_33:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_8 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_8 = 1;
        object val_8 = val_4.Current;
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_8 = 0;
        var val_18 = 0;
        val_18 = val_18 + 1;
        丞下万上三丘上与专.set_Item(key:  val_8, value:  丆丟丏丗下丘丌丛一.Item[val_8]);
        goto label_33;
        label_18:
        val_15 = 0;
        val_16 = 0;
        if(val_4 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_4.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static void 丗不三三丁丕七且上(System.Collections.IDictionary 丞下万上三丘上与专, System.Collections.IDictionary 丆丟丏丗下丘丌丛一)
    {
        var val_8;
        var val_15;
        var val_16;
        if(丆丟丏丗下丘丌丛一 == null)
        {
                return;
        }
        
        if((丞下万上三丘上与专 & 1) != 0)
        {
                return;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_8 = 2;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_8 = 0;
        System.Collections.IEnumerator val_4 = 丆丟丏丗下丘丌丛一.Keys.GetEnumerator();
        label_35:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_8 = 0;
        if(val_4.MoveNext() == false)
        {
            goto label_18;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_8 = 1;
        object val_8 = val_4.Current;
        if((val_8 == null) || (null != null))
        {
            goto label_35;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_8 = 0;
        var val_18 = 0;
        val_18 = val_18 + 1;
        丞下万上三丘上与专.set_Item(key:  val_8, value:  丆丟丏丗下丘丌丛一.Item[val_8]);
        goto label_35;
        label_18:
        val_15 = 0;
        val_16 = 0;
        if(val_4 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_4.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public static string 丛丈丆与专丕丏丐丄(System.Collections.IDictionary 丈丆上丅丘世专丑丕)
    {
        return ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  丈丆上丅丘世专丑丕, includeTypes:  false);
    }
    public static string 丛丈丆与专丕丏丐丄(object[] 一丐丗丁丞丆丅丟丄)
    {
        int val_2;
        string val_3;
        if(一丐丗丁丞丆丅丟丄 == null)
        {
                return "null";
        }
        
        val_2 = 一丐丗丁丞丆丅丟丄.Length;
        string[] val_1 = new string[0];
        if(一丐丗丁丞丆丅丟丄.Length < 1)
        {
                return System.String.Join(separator:  ", ", value:  val_1);
        }
        
        goto label_12;
        label_7:
        val_3 = "null";
        if(val_1 != null)
        {
            goto label_8;
        }
        
        goto label_5;
        label_12:
        if(0 >= 一丐丗丁丞丆丅丟丄.Length)
        {
                val_2 = 0;
        }
        
        object val_3 = 一丐丗丁丞丆丅丟丄[0];
        if(val_3 == null)
        {
            goto label_7;
        }
        
        val_3 = val_3;
        if(val_1 != null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_1[0] = val_3;
        if((0 + 1) < 一丐丗丁丞丆丅丟丄.Length)
        {
            goto label_12;
        }
        
        return System.String.Join(separator:  ", ", value:  val_1);
    }
    public static ExitGames.Client.Photon.Hashtable 万丈丏丁上下丁丕业(System.Collections.IDictionary 专丑业丁丗丏丌不丛)
    {
        var val_8;
        var val_14;
        var val_15;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        if(专丑业丁丗丏丌不丛 == null)
        {
                return val_1;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_8 = 2;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_8 = 0;
        System.Collections.IEnumerator val_5 = 专丑业丁丗丏丌不丛.Keys.GetEnumerator();
        label_29:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_8 = 0;
        if(val_5.MoveNext() == false)
        {
            goto label_16;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_8 = 1;
        object val_9 = val_5.Current;
        if((val_9 == null) || (null != null))
        {
            goto label_29;
        }
        
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_8 = 0;
        val_1.set_Item(key:  val_9, value:  专丑业丁丗丏丌不丛.Item[val_9]);
        goto label_29;
        label_16:
        val_14 = 0;
        val_15 = 0;
        if(val_5 != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_5.Dispose();
        }
        
        if( != 1)
        {
                return val_1;
        }
        
        if( == false)
        {
                return val_1;
        }
        
        return val_1;
    }
    public static void 东三丝丑七丘丝丌万(System.Collections.IDictionary 专丑业丁丗丏丌不丛)
    {
        var val_15;
        var val_16;
        object val_17;
        var val_19;
        var val_20;
        var val_22;
        var val_16 = 0;
        val_16 = val_16 + 1;
        int val_2 = 专丑业丁丗丏丌不丛.Count;
        object[] val_3 = new object[0];
        var val_17 = 0;
        val_17 = val_17 + 1;
        var val_18 = 0;
        val_18 = val_18 + 1;
        System.Collections.IEnumerator val_7 = 专丑业丁丗丏丌不丛.Keys.GetEnumerator();
        goto label_16;
        label_31:
        var val_19 = 0;
        val_19 = val_19 + 1;
        val_3[0] = val_7.Current;
        label_16:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_7.MoveNext() == true)
        {
            goto label_31;
        }
        
        val_15 = 0;
        val_16 = 0;
        val_17 = val_7;
        if(val_17 != null)
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_17.Dispose();
        }
        
        val_19 = 0;
        goto label_43;
        label_57:
        if(val_19 >= (public System.Void System.IDisposable::Dispose()))
        {
                val_20 = 0;
        }
        
        val_17 = val_3[0];
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_20 = 0;
        val_22 = public System.Object System.Collections.IDictionary::get_Item(object key);
        if(专丑业丁丗丏丌不丛.Item[val_17] == null)
        {
                var val_23 = 0;
            val_23 = val_23 + 1;
            val_22 = 10;
            专丑业丁丗丏丌不丛.Remove(key:  val_17);
        }
        
        val_19 = 1;
        label_43:
        if(val_19 < val_3.Length)
        {
            goto label_57;
        }
    
    }
    public static bool 丟不下下且业丛丄丏(int[] 丞下万上三丘上与专, int 丏东丁丂七丟不丒丅)
    {
        var val_1;
        if(丞下万上三丘上与专 == null)
        {
                return (bool)val_1;
        }
        
        if(丞下万上三丘上与专.Length < 1)
        {
            goto label_1;
        }
        
        label_4:
        if(丞下万上三丘上与专[0] == 丏东丁丂七丟不丒丅)
        {
            goto label_3;
        }
        
        if((0 + 1) < 丞下万上三丘上与专.Length)
        {
            goto label_4;
        }
        
        label_1:
        val_1 = 0;
        return (bool)val_1;
        label_3:
        val_1 = 1;
        return (bool)val_1;
    }
    private static 万上丈专丐专丞丛丛()
    {
        万上丈专丐专丞丛丛.丂丞丈丏世丐丂一万 = new System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Reflection.ParameterInfo[]>();
    }

}
