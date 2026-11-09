using UnityEngine;
internal sealed class BattleSpawnController : PGBehaviour
{
    // Fields
    internal static BattleSpawnController 丆丕丝丒不丙且丐丗;
    private float enemyMinDistance;
    private float allyMinDistance;
    
    // Methods
    private void Awake()
    {
        BattleSpawnController.丆丕丝丒不丙且丐丗 = this;
    }
    internal PlayerSpawnPoint 丆丝丒下丕丞丄且三(丅丌丂世一丟丅丕丆 七丞上七下七丈丒丙, 且丑丗丟丒业上东丙 丈丌三丌丐丟三上且)
    {
        var val_4;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        且丑丗丟丒业上东丙 val_51;
        System.Func<PlayerSpawnPoint, System.Boolean> val_53;
        var val_54;
        System.Func<PlayerSpawnPoint, System.Boolean> val_56;
        var val_57;
        var val_58;
        System.Func<PlayerSpawnPoint, System.Boolean> val_60;
        int val_61;
        var val_62;
        System.Collections.Generic.List<PlayerSpawnPoint> val_1 = 丘丛丞且一丅丁丏丐.丅丐丙业丟丙与丁丄(万丕丘七丝丁三丄业:  七丞上七下七丈丒丙, 丈丌三丌丐丟三上且:  丈丌三丌丐丟三上且);
        val_44 = 0;
        val_45 = 0;
        goto label_38;
        label_43:
        val_46 = null;
        val_46 = null;
        List.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_47 = 0;
        val_48 = 0;
        goto label_21;
        label_22:
        string val_5 = val_4.丐丏七丌丕丗业且上();
        if(val_5.丘丑丅三丆丑丌且丝() == 0)
        {
            goto label_9;
        }
        
        int val_7 = val_5.丘丑丅三丆丑丌且丝();
        var val_9 = (val_7 != val_7.丐专丙丈丂丞东丆丐()) ? 1 : 0;
        if(val_5 != null)
        {
            goto label_13;
        }
        
        goto label_12;
        label_9:
        val_49 = 1;
        if(val_5 != null)
        {
            goto label_13;
        }
        
        label_12:
        label_13:
        PlayerSpawnPoint val_10 = val_1.Item[0];
        UnityEngine.Vector3 val_11 = val_10.万东万丆专丌丕丐丗.position;
        float val_13 = (val_49 != 0) ? this.enemyMinDistance : this.allyMinDistance;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) < 0)
        {
                if(val_49 == 0)
        {
                val_48 = 1;
        }
        else
        {
                val_47 = 1;
        }
        
        }
        
        label_21:
        if(((-1430685984) & 1) != 0)
        {
            goto label_22;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(1 == 1)
        {
            goto label_33;
        }
        
        var val_43 = 0;
        val_43 = val_43 ^ 0;
        val_45 = 1 + val_43;
        if(val_1 != null)
        {
            goto label_40;
        }
        
        label_41:
        label_40:
        val_1.Item[0].丕七丂且三与上丗丌(丐与丝专丄丘丈丘上:  1);
        val_1.Item[0].上三上丁七丟东丛丅(丟丞丆丆丈业下下一:  0);
        val_44 = 1;
        goto label_38;
        label_33:
        if(val_1 != null)
        {
            goto label_40;
        }
        
        goto label_41;
        label_38:
        if(val_44 < val_1.Count)
        {
            goto label_43;
        }
        
        val_50 = null;
        val_51 = 丈丌三丌丐丟三上且;
        val_53 = BattleSpawnController.<>c.<>9__4_0;
        if(val_53 == null)
        {
                System.Func<PlayerSpawnPoint, System.Boolean> val_17 = null;
            val_53 = val_17;
            val_17 = new System.Func<PlayerSpawnPoint, System.Boolean>(object:  BattleSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleSpawnController.<>c::业三丕丘一丄丐不万(PlayerSpawnPoint 三丟东丕丄丄下下丑));
            BattleSpawnController.<>c.<>9__4_0 = val_53;
        }
        
        System.Collections.Generic.List<TSource> val_19 = System.Linq.Enumerable.ToList<PlayerSpawnPoint>(source:  System.Linq.Enumerable.Where<PlayerSpawnPoint>(source:  val_1, predicate:  val_17));
        val_54 = null;
        val_54 = null;
        val_56 = BattleSpawnController.<>c.<>9__4_1;
        if(val_56 == null)
        {
                System.Func<PlayerSpawnPoint, System.Boolean> val_20 = null;
            val_56 = val_20;
            val_20 = new System.Func<PlayerSpawnPoint, System.Boolean>(object:  BattleSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleSpawnController.<>c::丙丛万七丆东丈丝万(PlayerSpawnPoint 三丟东丕丄丄下下丑));
            BattleSpawnController.<>c.<>9__4_1 = val_56;
        }
        
        System.Collections.Generic.List<TSource> val_22 = System.Linq.Enumerable.ToList<PlayerSpawnPoint>(source:  System.Linq.Enumerable.Where<PlayerSpawnPoint>(source:  val_1, predicate:  val_20));
        System.Collections.Generic.List<PlayerSpawnPoint> val_23 = null;
        val_57 = val_23;
        val_23 = new System.Collections.Generic.List<PlayerSpawnPoint>();
        if( != 0)
        {
                val_58 = null;
            val_58 = null;
            val_60 = BattleSpawnController.<>c.<>9__4_2;
            if(val_60 == null)
        {
                System.Func<PlayerSpawnPoint, System.Boolean> val_24 = null;
            val_60 = val_24;
            val_24 = new System.Func<PlayerSpawnPoint, System.Boolean>(object:  BattleSpawnController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattleSpawnController.<>c::丁一不丘丅上丆丒下(PlayerSpawnPoint 三丟东丕丄丄下下丑));
            BattleSpawnController.<>c.<>9__4_2 = val_60;
        }
        
            val_57 = System.Linq.Enumerable.ToList<PlayerSpawnPoint>(source:  System.Linq.Enumerable.Where<PlayerSpawnPoint>(source:  val_1, predicate:  val_24));
        }
        
        if(val_19.Count >= 1)
        {
                val_61 = UnityEngine.Random.Range(min:  0, max:  val_19.Count - 1);
            val_62 = 1152921530971108704;
            return (PlayerSpawnPoint)val_57.Item[val_61];
        }
        
        if(val_22.Count >= 1)
        {
                val_61 = UnityEngine.Random.Range(min:  0, max:  val_22.Count - 1);
            val_62 = 1152921530971108704;
            return (PlayerSpawnPoint)val_57.Item[val_61];
        }
        
        if(val_57.Count >= 1)
        {
                val_61 = UnityEngine.Random.Range(min:  0, max:  val_57.Count - 1);
            val_62 = 1152921530971108704;
            return (PlayerSpawnPoint)val_57.Item[val_61];
        }
        
        int val_42 = UnityEngine.Random.Range(min:  0, max:  val_1.Count - 1);
        if(val_1 != null)
        {
                return (PlayerSpawnPoint)val_57.Item[val_61];
        }
        
        return (PlayerSpawnPoint)val_57.Item[val_61];
    }
    private int 丐专丙丈丂丞东丆丐()
    {
        null = null;
        if(null != 0)
        {
                return 丘丑丅三丆丑丌且丝();
        }
        
        return 丘丑丅三丆丑丌且丝();
    }
    public BattleSpawnController()
    {
        this.enemyMinDistance = 15f;
        this.allyMinDistance = 4f;
    }

}
