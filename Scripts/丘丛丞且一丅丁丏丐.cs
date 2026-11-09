using UnityEngine;
public sealed class 丘丛丞且一丅丁丏丐
{
    // Fields
    internal static readonly System.Collections.Generic.List<Player_move_c> 丁丟丌专三上丐丕丙;
    internal static readonly System.Collections.Generic.List<UnityEngine.GameObject> 丑丅丘上丑丛丑世丏;
    internal static readonly System.Collections.Generic.List<UnityEngine.GameObject> 丆丅丗丆七且丏丘丕;
    internal static readonly System.Collections.Generic.List<UnityEngine.GameObject> 丟丙下上丞丕且丝一;
    internal static readonly System.Collections.Generic.List<UnityEngine.Transform> 丌万下一七且丝丐专;
    internal static readonly System.Collections.Generic.List<UnityEngine.GameObject> 不世七丗丑丑丅丞丂;
    internal static readonly System.Collections.Generic.List<PlayerBot.且丏丕丝丄上业上丒> 丆世丐东丏丛万丏与;
    private static System.Collections.Generic.Dictionary<UnityEngine.Transform, 丅丙上七上一丐不下> 丄丛丅一三丆丒丅三;
    private static System.Collections.Generic.Dictionary<UnityEngine.Transform, HitBox> 三丅下一一丈丑下丕;
    private static System.Collections.Generic.Dictionary<UnityEngine.Transform, UnityEngine.Collider> 丁丂丗丐一下丂上丂;
    private static System.Collections.Generic.Dictionary<UnityEngine.Collider, 丅丙上七上一丐不下> 丛丟丄丆一丂下丞七;
    internal static System.Collections.Generic.Dictionary<UnityEngine.Transform, 万丝丅丗且丒丝丌丟> 专丛下丘丆丘丑下丈;
    internal static System.Collections.Generic.List<EnemyCreationZone> 丗上丘丏丙丟丂且三;
    internal static System.Collections.Generic.Dictionary<丅丌丂世一丟丅丕丆, System.Collections.Generic.Dictionary<且丑丗丟丒业上东丙, System.Collections.Generic.List<PlayerSpawnPoint>>> 丒与一三丒丁三丒丒;
    internal static System.Collections.Generic.List<NumberZone> 东丝丟且下丕一不丒;
    internal static System.Collections.Generic.Dictionary<UnityEngine.GameObject, DeadCollider> 丗世丗丌丁丕东七丂;
    internal static System.Collections.Generic.HashSet<RilisoftBot.BaseBot> 丅世丒丗业丝且丟丞;
    
    // Properties
    internal static bool 丄丞丏上丆丞与三丁 { get; }
    
    // Methods
    internal static void 丞三世丐丛丂丄丄丛(PlayerSpawnPoint 丏丅丅专七丘丑上丂)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = null;
        val_9 = null;
        if((丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.ContainsKey(key:  丏丅丅专七丘丑上丂.spawnPointType)) != true)
        {
                val_10 = null;
            val_10 = null;
            丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Add(key:  丏丅丅专七丘丑上丂.spawnPointType, value:  new System.Collections.Generic.Dictionary<且丑丗丟丒业上东丙, System.Collections.Generic.List<PlayerSpawnPoint>>());
        }
        
        val_11 = null;
        val_11 = null;
        if((丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Item[丏丅丅专七丘丑上丂.spawnPointType].ContainsKey(key:  丏丅丅专七丘丑上丂.teamBelonging)) != true)
        {
                val_12 = null;
            val_12 = null;
            丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Item[丏丅丅专七丘丑上丂.spawnPointType].Add(key:  丏丅丅专七丘丑上丂.teamBelonging, value:  new System.Collections.Generic.List<PlayerSpawnPoint>());
        }
        
        val_13 = null;
        val_13 = null;
        丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Item[丏丅丅专七丘丑上丂.spawnPointType].Item[丏丅丅专七丘丑上丂.teamBelonging].Add(item:  丏丅丅专七丘丑上丂);
    }
    internal static System.Collections.Generic.List<PlayerSpawnPoint> 丅丐丙业丟丙与丁丄(丅丌丂世一丟丅丕丆 万丕丘七丝丁三丄业, 且丑丗丟丒业上东丙 丈丌三丌丐丟三上且)
    {
        var val_6;
        System.Collections.Generic.Dictionary<丅丌丂世一丟丅丕丆, System.Collections.Generic.Dictionary<且丑丗丟丒业上东丙, System.Collections.Generic.List<PlayerSpawnPoint>>> val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        val_7 = 丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒;
        if((val_7.ContainsKey(key:  万丕丘七丝丁三丄业)) == false)
        {
                return (System.Collections.Generic.List<PlayerSpawnPoint>)new System.Collections.Generic.List<PlayerSpawnPoint>();
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = 丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Item[万丕丘七丝丁三丄业];
        if((val_7.ContainsKey(key:  丈丌三丌丐丟三上且)) == false)
        {
                return (System.Collections.Generic.List<PlayerSpawnPoint>)new System.Collections.Generic.List<PlayerSpawnPoint>();
        }
        
        val_9 = null;
        val_9 = null;
        System.Collections.Generic.Dictionary<且丑丗丟丒业上东丙, System.Collections.Generic.List<PlayerSpawnPoint>> val_4 = 丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Item[万丕丘七丝丁三丄业];
        if(val_4 != null)
        {
                return val_4.Item[丈丌三丌丐丟三上且];
        }
        
        return val_4.Item[丈丌三丌丐丟三上且];
    }
    internal static bool 丁丕丛丘丈丌与丙七(UnityEngine.Transform 丞下万上三丘上与专)
    {
        null = null;
        if(丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三 != null)
        {
                return 丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.ContainsKey(key:  丞下万上三丘上与专);
        }
        
        return 丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.ContainsKey(key:  丞下万上三丘上与专);
    }
    private static T 东丟一专丞业丒丅不<T>(object 丞下万上三丘上与专, 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 专丐丛丆与专世丆丂)
    {
        var val_2;
        if(丞下万上三丘上与专 != null)
        {
                val_2 = 丞下万上三丘上与专;
            if(val_2 != null)
        {
                return (Player_move_c)val_2;
        }
        
        }
        
        val_2 = 0;
        return (Player_move_c)val_2;
    }
    private static void 丁上丑丛一丟丗万一(UnityEngine.Transform 丄三丟丗东丟丝下丝, 丅丙上七上一丐不下 丕不丝丛丌丁万上万)
    {
        var val_1;
        if(丕不丝丛丌丁万上万 == null)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.Add(key:  丄三丟丗东丟丝下丝, value:  丕不丝丛丌丁万上万);
    }
    internal static void 一世丟丘丗丞丄丆下(PlayerBot.且丏丕丝丄上业上丒 上丌东丘丑丗不三且)
    {
        null = null;
        丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Add(item:  上丌东丘丑丗不三且);
    }
    internal static void 且专丗丅上东三丂东(PlayerBot.且丏丕丝丄上业上丒 上丌东丘丑丗不三且)
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与.Remove(item:  上丌东丘丑丗不三且);
    }
    internal static void 东一万丕世丙丆丐丕(object 丞下万上三丘上与专, 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 专丐丛丆与专世丆丂)
    {
        object val_18 = 丞下万上三丘上与专;
        if(专丐丛丆与专世丆丂 > 6)
        {
                return;
        }
        
        var val_18 = 106024788 + (专丐丛丆与专世丆丂) << 2;
        val_18 = val_18 + 106024788;
        goto (106024788 + (专丐丛丆与专世丆丂) << 2 + 106024788);
    }
    internal static void 丛丂丄丕丁上七世万(object 丞下万上三丘上与专, 丘丛丞且一丅丁丏丐.且业且丙上三与东丕 专丐丛丆与专世丆丂)
    {
        object val_18 = 丞下万上三丘上与专;
        if(专丐丛丆与专世丆丂 > 6)
        {
                return;
        }
        
        var val_18 = 106024816 + (专丐丛丆与专世丆丂) << 2;
        val_18 = val_18 + 106024816;
        goto (106024816 + (专丐丛丆与专世丆丂) << 2 + 106024816);
    }
    internal static 丅丙上七上一丐不下 万丏丘丘世丝三丛丌(UnityEngine.Transform 丞下万上三丘上与专)
    {
        var val_5;
        var val_6;
        丅丙上七上一丐不下 val_2 = 0;
        val_5 = 0;
        if(丞下万上三丘上与专 == 0)
        {
                return (丅丙上七上一丐不下)((丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.TryGetValue(key:  丞下万上三丘上与专, value: out  val_2)) != true) ? (val_2) : 0;
        }
        
        val_6 = null;
        val_6 = null;
        return (丅丙上七上一丐不下)((丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.TryGetValue(key:  丞下万上三丘上与专, value: out  val_2)) != true) ? (val_2) : 0;
    }
    internal static void 丙丅丅丆丂一上业丐(UnityEngine.Transform 不丂丅丁且丆东东丂, 万丝丅丗且丒丝丌丟 丞下万上三丘上与专)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.ContainsKey(key:  不丂丅丁且丆东东丂)) != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.Add(key:  不丂丅丁且丆东东丂, value:  丞下万上三丘上与专);
    }
    internal static void 丏丄丄东丒世专丌丁(UnityEngine.Transform 不丂丅丁且丆东东丂)
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.Remove(key:  不丂丅丁且丆东东丂);
    }
    internal static 万丝丅丗且丒丝丌丟 丆丁丏业一业丏丙丅(UnityEngine.Transform 不丂丅丁且丆东东丂)
    {
        var val_4;
        万丝丅丗且丒丝丌丟 val_1 = 0;
        val_4 = null;
        val_4 = null;
        return (万丝丅丗且丒丝丌丟)((丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.TryGetValue(key:  不丂丅丁且丆东东丂, value: out  val_1)) != true) ? (val_1) : 0;
    }
    internal static void 上丌丈丌丘万东世丐(UnityEngine.Transform 不丂丅丁且丆东东丂, HitBox 万丗且且丒且丏丙世)
    {
        null = null;
        丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕.Add(key:  不丂丅丁且丆东东丂, value:  万丗且且丒且丏丙世);
    }
    internal static void 专丝且丐上东且业丙(UnityEngine.Transform 上丛丂三上与丂丕丑)
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕.Remove(key:  上丛丂三上与丂丕丑);
    }
    internal static HitBox 业下专丂丌丄七丆丞(UnityEngine.Transform 上丛丂三上与丂丕丑)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕.ContainsKey(key:  上丛丂三上与丂丕丑)) != false)
        {
                val_4 = null;
            val_4 = null;
            HitBox val_2 = 丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕.Item[上丛丂三上与丂丕丑];
            return (HitBox)val_5;
        }
        
        val_5 = 0;
        return (HitBox)val_5;
    }
    internal static void 丗丂丈三丑丟三与三(UnityEngine.Transform 丞下万上三丘上与专, UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        System.Collections.Generic.Dictionary<UnityEngine.Transform, UnityEngine.Collider> val_3;
        var val_4;
        var val_5;
        if(且丙与丏下丅丐世丑 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = 丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂;
        if((val_3.ContainsKey(key:  丞下万上三丘上与专)) != false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂.Add(key:  丞下万上三丘上与专, value:  且丙与丏下丅丐世丑);
    }
    internal static void 与丏丝世专万一丕与(UnityEngine.Transform 丞下万上三丘上与专)
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂.Remove(key:  丞下万上三丘上与专);
    }
    private static UnityEngine.Collider 丛丒丏与不丌一丅世(UnityEngine.Transform 丞下万上三丘上与专)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂.ContainsKey(key:  丞下万上三丘上与专)) != false)
        {
                val_4 = null;
            val_4 = null;
            UnityEngine.Collider val_2 = 丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂.Item[丞下万上三丘上与专];
            return (UnityEngine.Collider)val_5;
        }
        
        val_5 = 0;
        return (UnityEngine.Collider)val_5;
    }
    internal static void 且丑丏下丈丆丕业丅(UnityEngine.Collider 且丙与丏下丅丐世丑, 丅丙上七上一丐不下 丗万丑东丂丈下且丗)
    {
        null = null;
        丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七.set_Item(key:  且丙与丏下丅丐世丑, value:  丗万丑东丂丈下且丗);
    }
    internal static void 业丕丕丏世与一丂丆(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        null = null;
        bool val_1 = 丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七.Remove(key:  且丙与丏下丅丐世丑);
    }
    internal static 丅丙上七上一丐不下 丂丅丐世上不丐丏丙(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_4;
        丅丙上七上一丐不下 val_1 = 0;
        val_4 = null;
        val_4 = null;
        return (丅丙上七上一丐不下)((丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七.TryGetValue(key:  且丙与丏下丅丐世丑, value: out  val_1)) != true) ? (val_1) : 0;
    }
    internal static bool 丂丞东丛且世万丒丑()
    {
        null = null;
        return (bool)(丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七.Count > 0) ? 1 : 0;
    }
    internal static UnityEngine.Vector3 丗丏丆丁与丏万丙丆(UnityEngine.Transform 丞下万上三丘上与专)
    {
        float val_43;
        float val_44;
        float val_45;
        UnityEngine.Object val_46;
        TankController val_47;
        var val_48;
        var val_49;
        var val_50;
        float val_54;
        float val_55;
        float val_56;
        float val_57;
        float val_58;
        float val_59;
        UnityEngine.Vector3 val_1 = 丞下万上三丘上与专.position;
        val_43 = val_1.x;
        val_44 = val_1.y;
        val_45 = val_1.z;
        val_46 = 丘丛丞且一丅丁丏丐.丛丒丏与不丌一丅世(丞下万上三丘上与专:  丞下万上三丘上与专);
        if(val_46 == 0)
        {
                if((丞下万上三丘上与专.CompareTag(tag:  "Enemy")) != false)
        {
                val_46 = 丞下万上三丘上与专.GetComponentInChildren<UnityEngine.BoxCollider>();
            丘丛丞且一丅丁丏丐.丗丂丈三丑丟三与三(丞下万上三丘上与专:  丞下万上三丘上与专, 且丙与丏下丅丐世丑:  val_46);
        }
        
        }
        
        if((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专)) == null)
        {
            goto label_22;
        }
        
        val_47 = TankController.丄丘七三上丕世丞业;
        if(val_47 == 0)
        {
            goto label_22;
        }
        
        val_47 = TankController.丄丘七三上丕世丞业.下丈丕丗丟丘丆丗丅();
        if(val_47.Count < 1)
        {
            goto label_22;
        }
        
        val_46 = TankController.丄丘七三上丕世丞业.下丈丕丗丟丘丆丗丅().Item[0].transform;
        UnityEngine.Vector3 val_13 = val_46.position;
        goto label_27;
        label_22:
        if(val_46 != 0)
        {
            goto label_38;
        }
        
        丅丙上七上一丐不下 val_15 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专);
        if(val_15 == null)
        {
            goto label_38;
        }
        
        val_47 = val_15.GetComponent<UnityEngine.BoxCollider>();
        if(val_47 == 0)
        {
            goto label_38;
        }
        
        val_46 = val_15.transform;
        UnityEngine.Vector3 val_19 = val_46.position;
        val_48 = val_19.x;
        val_49 = val_19.y;
        val_50 = val_19.z;
        if(val_47 != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_38:
        if(val_46 != 0)
        {
            goto label_52;
        }
        
        val_47 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专);
        if(val_47 == null)
        {
            goto label_52;
        }
        
        UnityEngine.BoxCollider val_22 = val_47.GetComponentInChildren<UnityEngine.BoxCollider>();
        if(val_22 == 0)
        {
            goto label_52;
        }
        
        val_46 = val_47.transform;
        UnityEngine.Vector3 val_25 = val_46.position;
        val_48 = val_25.x;
        val_49 = val_25.y;
        val_50 = val_25.z;
        label_41:
        UnityEngine.Vector3 val_26 = val_22.center;
        val_54 = val_26.y;
        val_55 = val_48;
        val_56 = val_49;
        val_57 = val_50;
        goto label_57;
        label_52:
        if(val_46 == 0)
        {
                return new UnityEngine.Vector3() {x = val_43, y = val_44, z = val_45};
        }
        
        val_47 = 1152921504838316032;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.zero;
        val_58 = val_28.x;
        val_59 = val_28.y;
        val_54 = val_28.z;
        if(val_46 != null)
        {
                UnityEngine.Vector3 val_31 = val_46.center;
            val_58 = val_33.x;
            val_59 = val_33.y;
            val_54 = val_33.z;
        }
        
        UnityEngine.Vector3 val_35 = val_46.transform.position;
        val_46 = val_46.transform;
        UnityEngine.Quaternion val_37 = val_46.rotation;
        UnityEngine.Vector3 val_38 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, point:  new UnityEngine.Vector3() {x = val_58, y = val_59, z = val_54});
        val_56 = val_35.y;
        val_55 = val_35.x;
        val_57 = val_35.z;
        label_57:
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_57}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
        label_27:
        val_43 = val_39.x;
        val_44 = val_39.y;
        val_45 = val_39.z;
        return new UnityEngine.Vector3() {x = val_43, y = val_44, z = val_45};
    }
    internal static bool 丗丏丌一一业且业丘(UnityEngine.Transform 丛丌丕丐世丑丂七丂, Player_move_c 上丁丆不东丕万丂丏)
    {
        UnityEngine.Object val_7;
        var val_8;
        var val_9;
        val_7 = 上丁丆不东丕万丂丏;
        if(val_7 == 0)
        {
                val_8 = null;
            val_8 = null;
            val_7 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_7 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        }
        
        if(val_7 == 0)
        {
                return false;
        }
        
        if(丛丌丕丐世丑丂七丂 == 0)
        {
                return false;
        }
        
        val_9 = public System.Boolean UnityEngine.Object::Equals(object other);
        if((丛丌丕丐世丑丂七丂.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_378)) == true)
        {
                return false;
        }
        
        丅丙上七上一丐不下 val_5 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丛丌丕丐世丑丂七丂);
        if(val_5 == null)
        {
                return false;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_9 = 4;
        return val_5.IsEnemyTo(专丞上七七且丝七丗:  val_7);
    }
    internal static Player_move_c 丅丞万万三丛且专丁(int 丞丅上丏丂且下丅与)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 丞丅上丏丂且下丅与;
        val_5 = null;
        val_5 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_12:
        if(((-1468928280) & 1) == 0)
        {
            goto label_4;
        }
        
        val_6 = 0.丐丏七丌丕丗业且上();
        if(((X21 + 496) == 0) || ((X21 + 496 + 496 + 32) != val_4))
        {
            goto label_12;
        }
        
        goto label_13;
        label_4:
        val_6 = 0;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (Player_move_c)val_6;
    }
    internal static void 东丙丄三丌丙且丄丁()
    {
        null = null;
        丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Clear();
        丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏.Clear();
        丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.Clear();
        丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.Clear();
        丘丛丞且一丅丁丏丐.丌万下一七且丝丐专.Clear();
        丘丛丞且一丅丁丏丐.不世七丗丑丑丅丞丂.Clear();
        丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈.Clear();
        丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三.Clear();
        丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕.Clear();
        丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂.Clear();
        丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Clear();
        丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒.Clear();
        丘丛丞且一丅丁丏丐.东丝丟且下丕一不丒.Clear();
        丘丛丞且一丅丁丏丐.丗世丗丌丁丕东七丂.Clear();
        丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七.Clear();
    }
    public 丘丛丞且一丅丁丏丐()
    {
    
    }
    private static 丘丛丞且一丅丁丏丐()
    {
        丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙 = new System.Collections.Generic.List<Player_move_c>();
        丘丛丞且一丅丁丏丐.丑丅丘上丑丛丑世丏 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        丘丛丞且一丅丁丏丐.丌万下一七且丝丐专 = new System.Collections.Generic.List<UnityEngine.Transform>();
        丘丛丞且一丅丁丏丐.不世七丗丑丑丅丞丂 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        丘丛丞且一丅丁丏丐.丆世丐东丏丛万丏与 = new System.Collections.Generic.List<PlayerBot.且丏丕丝丄上业上丒>();
        丘丛丞且一丅丁丏丐.丄丛丅一三丆丒丅三 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, 丅丙上七上一丐不下>();
        丘丛丞且一丅丁丏丐.三丅下一一丈丑下丕 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, HitBox>();
        丘丛丞且一丅丁丏丐.丁丂丗丐一下丂上丂 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, UnityEngine.Collider>();
        丘丛丞且一丅丁丏丐.丛丟丄丆一丂下丞七 = new System.Collections.Generic.Dictionary<UnityEngine.Collider, 丅丙上七上一丐不下>();
        丘丛丞且一丅丁丏丐.专丛下丘丆丘丑下丈 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, 万丝丅丗且丒丝丌丟>();
        丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三 = new System.Collections.Generic.List<EnemyCreationZone>();
        丘丛丞且一丅丁丏丐.丒与一三丒丁三丒丒 = new System.Collections.Generic.Dictionary<丅丌丂世一丟丅丕丆, System.Collections.Generic.Dictionary<且丑丗丟丒业上东丙, System.Collections.Generic.List<PlayerSpawnPoint>>>();
        丘丛丞且一丅丁丏丐.东丝丟且下丕一不丒 = new System.Collections.Generic.List<NumberZone>();
        丘丛丞且一丅丁丏丐.丗世丗丌丁丕东七丂 = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, DeadCollider>();
        丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞 = new System.Collections.Generic.HashSet<RilisoftBot.BaseBot>();
    }

}
