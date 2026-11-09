using UnityEngine;
private sealed class ZombieCreator.且万业业丅丌丂且丟 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ZombieCreator 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ZombieCreator.且万业业丅丌丂且丟(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_54;
        ZombieCreator.且万业业丅丌丂且丟 val_55;
        int val_56;
        int val_57;
        var val_58;
        int val_59;
        var val_60;
        float val_61;
        Rilisoft.丝丑丂丛万丐丈丘且 val_62;
        System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_63;
        int val_64;
        var val_65;
        var val_66;
        int val_67;
        var val_68;
        System.Collections.Generic.List<System.String> val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        int val_75;
        var val_76;
        var val_78;
        int val_79;
        System.Collections.Generic.List<UnityEngine.GameObject> val_80;
        var val_81;
        ZombieCreator.且万业业丅丌丂且丟 val_82;
        var val_83;
        val_55 = this;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_56 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_56;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_38;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_10;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_11;
        }
        
        val_57 = this.丝且与丝丒丟万丁专.丙业七且东丞万业与 + 1;
        this.丝且与丝丒丟万丁专.丙业七且东丞万业与 = val_57;
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丒丗丟丄丕丘三丗丏 == true)
        {
            goto label_14;
        }
        
        goto label_143;
        label_11:
        mem[36] = 1;
        val_57 = mem[36];
        label_12:
        if(val_57 != 3)
        {
            goto label_22;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_17;
        }
        
        val_58 = this.丝且与丝丒丟万丁专;
        val_59 = this.丝且与丝丒丟万丁专.丐三且下丒丆丙不与;
        goto label_18;
        label_10:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_19;
        }
        
        val_60 = 72;
        goto label_20;
        label_17:
        val_58 = 40;
        val_59 = 135970152;
        label_18:
        int val_53 = this.丝且与丝丒丟万丁专.且丒业丈七东七丘丗.Length;
        val_53 = val_53 - 1;
        if(135970152 < val_53)
        {
                mem[40] = 135970153;
        }
        
        label_22:
        bool val_3 = GameConnect.万七丄丛丈丟专一丑();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_25;
        }
        
        if(val_3 == false)
        {
            goto label_26;
        }
        
        label_29:
        val_61 = this.丝且与丝丒丟万丁专.timeForSpawnMobInClassicArena;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_25:
        if(val_3 == true)
        {
            goto label_29;
        }
        
        label_26:
        val_61 = (float)this.丝且与丝丒丟万丁专.且丒业丈七东七丘丗[this.丝且与丝丒丟万丁专.丐三且下丒丆丙不与];
        label_28:
        this.丝且与丝丒丟万丁专.curInterval = val_61;
        label_19:
        val_60 = this.丝且与丝丒丟万丁专.上丝丂丘一丅丄丆七;
        label_20:
        val_62 = this.丝且与丝丒丟万丁专.不丛丂丟丞七丈东丌;
        if((val_62 + val_60) >= ZombieCreator.专丁且业专不丑东丏())
        {
                if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
                return (bool)val_56;
        }
        
        }
        
        }
        
        label_38:
        val_63 = this.丝且与丝丒丟万丁专.不丛丂丟丞七丈东丌;
        val_64 = UnityEngine.Mathf.Min(a:  丟丌丁且且世丈丈丟.丞丒丕丆丆三丛丛丞(), b:  丟丌丁且且世丈丈丟.万丁丗东丕不丏丁一() - val_63);
        if(GameConnect.万七丄丛丈丟专一丑() != true)
        {
                val_65 = null;
            if(this.丝且与丝丒丟万丁专 != null)
        {
                val_63 = this.丝且与丝丒丟万丁专.上丝丂丘一丅丄丆七;
        }
        else
        {
                val_63 = 72;
        }
        
            val_64 = UnityEngine.Mathf.Min(a:  val_64, b:  (ZombieCreator.专丁且业专不丑东丏() - val_63) - this.丝且与丝丒丟万丁专.不丛丂丟丞七丈东丌);
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_58;
        }
        
        val_66 = null;
        val_66 = null;
        if(this.丝且与丝丒丟万丁专.丘丂丄丗丙丅丈丏下 >= ZombieCreator.且丁丙上与丝丌丐不.Count)
        {
            goto label_63;
        }
        
        val_67 = this.丝且与丝丒丟万丁专.丘丂丄丗丙丅丈丏下;
        goto label_64;
        label_58:
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_67;
        }
        
        val_68 = null;
        val_68 = null;
        val_69 = ZombieCreator.世丙专不七丘丕东丘;
        if(val_69 != null)
        {
            goto label_78;
        }
        
        goto label_71;
        label_63:
        val_70 = null;
        val_70 = null;
        val_67 = ZombieCreator.且丁丙上与丝丌丐不.Count - 1;
        label_64:
        val_71 = null;
        val_71 = null;
        val_63 = ZombieCreator.且丁丙上与丝丌丐不;
        val_69 = val_63.Item[val_67];
        if(val_69 != null)
        {
            goto label_78;
        }
        
        label_71:
        label_78:
        T[] val_22 = val_69.ToArray();
        label_150:
        if(val_64 < 1)
        {
            goto label_79;
        }
        
        label_125:
        int val_23 = UnityEngine.Random.Range(min:  0, max:  val_22.Length);
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_86;
        }
        
        }
        
        val_72 = null;
        val_72 = null;
        if(丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三 != null)
        {
                val_73 = 丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Count;
        }
        else
        {
                val_73 = 0.Count;
        }
        
        val_74 = public EnemyCreationZone System.Collections.Generic.List<EnemyCreationZone>::get_Item(int index);
        val_75 = 0 - ((0 / val_73) * val_73);
        goto label_91;
        label_86:
        val_76 = null;
        val_76 = null;
        val_75 = UnityEngine.Random.Range(min:  0, max:  丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Count);
        val_74 = public EnemyCreationZone System.Collections.Generic.List<EnemyCreationZone>::get_Item(int index);
        label_91:
        UnityEngine.Vector3 val_33 = 0.丈丐七丙丗丅丁专丂(丟不丄不三不东业丆:  丘丛丞且一丅丁丏丐.丗上丘丏丙丟丂且三.Item[val_75].gameObject);
        val_61 = val_33.y;
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_100;
        }
        
        if(this.丝且与丝丒丟万丁专.zombiePrefabs.Item[val_23] == 0)
        {
            goto label_105;
        }
        
        val_78 = public UnityEngine.GameObject System.Collections.Generic.List<UnityEngine.GameObject>::get_Item(int index);
        val_79 = val_23;
        goto label_107;
        label_100:
        if(GameConnect.丌专丌万一下丕专上() != true)
        {
                if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_113;
        }
        
        }
        
        val_80 = this.丝且与丝丒丟万丁专.waveZombiePrefabs;
        goto label_115;
        label_105:
        val_63 = "Такого моба не существует " + val_23.ToString();
        UnityEngine.Debug.LogError(message:  val_63);
        goto label_118;
        label_113:
        val_80 = this.丝且与丝丒丟万丁专.zombiePrefabs;
        label_115:
        val_78 = public UnityEngine.GameObject System.Collections.Generic.List<UnityEngine.GameObject>::get_Item(int index);
        val_79 = val_23;
        label_107:
        val_63 = 0.Item[val_79];
        UnityEngine.Quaternion val_42 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_43 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_63, position:  new UnityEngine.Vector3() {x = val_33.x, y = val_61, z = val_33.z}, rotation:  new UnityEngine.Quaternion() {x = val_42.x, y = val_42.y, z = val_42.z, w = val_42.w});
        label_118:
        val_81 = 0 + 1;
        if(val_64 != val_81)
        {
            goto label_125;
        }
        
        label_79:
        val_54 = this.丝且与丝丒丟万丁专.不丛丂丟丞七丈东丌;
        val_82 = val_55;
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_128;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_129;
        }
        
        val_64 = this.丝且与丝丒丟万丁专.上丝丂丘一丅丄丆七;
        goto label_130;
        label_67:
        if((丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一() == 0) || ((丛丑且业丗世丈丙丌.丈丏与上丑丒专丈丕(丞世不丒下上上丝丑:  丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一())) == null))
        {
            goto label_138;
        }
        
        goto label_150;
        label_129:
        val_64 = 72;
        label_130:
        val_83 = val_54;
        if((val_83 + val_64) >= ZombieCreator.专丁且业专不丑东丏())
        {
            goto label_142;
        }
        
        label_128:
        label_143:
        val_61 = this.丝且与丝丒丟万丁专.curInterval;
        mem[1152921539721300088] = new UnityEngine.WaitForSeconds(seconds:  val_61);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_56 = 1;
        return (bool)val_56;
        label_142:
        this.丝且与丝丒丟万丁专.丒丗丟丄丕丘三丗丏 = true;
        label_14:
        val_56 = 1;
        mem[1152921539721300088] = new UnityEngine.WaitForEndOfFrame();
        this.丗丏丅丕丆世丁专丟 = val_56;
        return (bool)val_56;
        label_138:
        new string[1][0] = "1";
        goto label_150;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
