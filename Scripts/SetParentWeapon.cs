using UnityEngine;
internal sealed class SetParentWeapon : MonoBehaviour
{
    // Fields
    private bool 丌且下丕下下丌万丞;
    private bool 丝丙七丒且丂丝与丏;
    private bool 丁丑丅丏丒不七上丁;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    
    // Methods
    private void Start()
    {
        var val_7;
        if((Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗().Equals(value:  与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐())) == true)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        val_7 = null;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        PhotonView val_4 = PhotonView.Get(丑丅丈东丐丐丕丞丙:  this);
        this.丄丈丑丐丆丞丘与丗 = val_4;
        if(this.丝丙七丒且丂丝与丏 != false)
        {
                this.丌且下丕下下丌万丞 = val_4.isMine;
        }
        
        this.SetParent();
    }
    private void SetParent()
    {
        var val_7;
        var val_63;
        var val_64;
        var val_65;
        var val_69;
        var val_70;
        var val_72;
        var val_73;
        var val_76;
        var val_77;
        var val_78;
        UnityEngine.GameObject val_83;
        var val_84;
        if(((this.丝丙七丒且丂丝与丏 != false) && ((UnityEngine.Object.op_Implicit(exists:  this.丄丈丑丐丆丞丘与丗)) != false)) && (this.丄丈丑丐丆丞丘与丗.owner != null))
        {
                val_63 = this.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁();
        }
        else
        {
                val_63 = 0;
        }
        
        val_64 = null;
        val_64 = null;
        List.Enumerator<T> val_5 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_65 = 1152921525761785056;
        label_26:
        if((782286176 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_8 = val_7.丐丏七丌丕丗业且上();
        if((((this.丝丙七丒且丂丝与丏 == false) || ((X22 + 496) == 0)) || ((X22 + 496 + 496.owner) == null)) || ((X22 + 496 + 496 + 496.owner.业丐丐三丕一丗丛丁()) != val_63))
        {
            goto label_26;
        }
        
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        this.transform.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        WeaponSounds val_16 = this.transform.GetComponent<WeaponSounds>();
        if(val_16.isMelee == false)
        {
            goto label_33;
        }
        
        label_66:
        val_65 = 0;
        val_69 = 0;
        if(456 != 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        goto label_230;
        label_57:
        var val_68 = X25;
        if((X25 + 286) == 0)
        {
            goto label_42;
        }
        
        var val_65 = X25 + 176;
        var val_66 = 0;
        val_65 = val_65 + 8;
        label_41:
        if(((X25 + 176 + 8) + -8) == X22)
        {
            goto label_40;
        }
        
        val_66 = val_66 + 1;
        val_65 = val_65 + 16;
        if(val_66 < (X25 + 286))
        {
            goto label_41;
        }
        
        goto label_42;
        label_40:
        var val_67 = val_65;
        val_67 = val_67 + 1;
        val_68 = val_68 + val_67;
        val_70 = val_68 + 296;
        label_42:
        0.parent = 0;
        UnityEngine.Vector3 val_20 = 0.position;
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  V8.16B);
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
        0.position = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
        label_50:
        var val_69 = 0;
        val_69 = val_69 + 1;
        if(456.transform.GetEnumerator().MoveNext() == true)
        {
            goto label_57;
        }
        
        val_72 = 456;
        val_73 = 0 + 1;
        mem2[0] = 503;
        goto label_58;
        label_33:
        if(val_16.bulletSpawnPoints.Count < 1)
        {
            goto label_60;
        }
        
        if(this.丌且下丕下下丌万丞 == true)
        {
            goto label_66;
        }
        
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  val_16.bulletSpawnPoints.Item[0].gameObject, 丙丗七丕且与丞丘丁:  false);
        goto label_66;
        label_60:
        System.Collections.IEnumerator val_31 = this.transform.GetEnumerator();
        goto label_81;
        label_89:
        var val_70 = 0;
        val_70 = val_70 + 1;
        object val_33 = val_31.Current;
        if(((0.gameObject.name.Equals(value:  "BulletSpawnPoint")) == false) || ((0.childCount & 2147483648) != 0))
        {
            goto label_81;
        }
        
        goto label_82;
        label_81:
        var val_71 = 0;
        val_71 = val_71 + 1;
        if(val_31.MoveNext() == true)
        {
            goto label_89;
        }
        
        label_96:
        val_76 = 456;
        val_77 = 0;
        val_78 = 0;
        goto label_90;
        label_82:
        if(this.丌且下丕下下丌万丞 == true)
        {
            goto label_96;
        }
        
        WeaponManager.丙与业东丒丒丈业不(世上与丁丈与丁丂丁:  0.GetChild(index:  0).gameObject, 丙丗七丕且与丞丘丁:  false);
        goto label_96;
        label_90:
        if(val_31 != null)
        {
                var val_72 = 0;
            val_72 = val_72 + 1;
            val_31.Dispose();
        }
        
        if(( == 1) || (401 != 401))
        {
            goto label_128;
        }
        
        if( != 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_128:
        if( != 0)
        {
            goto label_50;
        }
        
        goto label_50;
        label_58:
        if(val_31 != null)
        {
                var val_73 = 0;
            val_73 = val_73 + 1;
            val_31.Dispose();
        }
        
        if(( != 1) && (401 == 503))
        {
                var val_74 = 0;
            val_74 = val_74 ^ 0;
            val_73 =  + val_74;
        }
        else
        {
                if( != false)
        {
                val_65 = 0;
            val_69 = 0;
        }
        else
        {
                val_65 = 0;
        }
        
        }
        
        this.transform.parent = 456.transform;
        if((val_16 + 1304.Count) < 1)
        {
            goto label_163;
        }
        
        val_83 = val_16 + 1304.Item[0].gameObject;
        if(val_8 != null)
        {
            goto label_174;
        }
        
        goto label_174;
        label_163:
        if((this.transform.Find(n:  "BulletSpawnPoint")) == 0)
        {
            goto label_171;
        }
        
        val_83 = this.transform.Find(n:  "BulletSpawnPoint").gameObject;
        label_174:
        mem2[0] = val_83;
        label_171:
        val_84 = null;
        val_84 = null;
        this.transform.localPosition = new UnityEngine.Vector3() {x = Player_move_c.一与丆东丐丁七不东, y = Player_move_c.世且上一七下丈丕丑.__il2cppRuntimeField_194, z = Player_move_c.世且上一七下丈丕丑.__il2cppRuntimeField_198};
        UnityEngine.Quaternion val_60 = 456.transform.rotation;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_60.x, y = val_60.y, z = val_60.z, w = val_60.w};
        if(456.transform.parent.gameObject != 0)
        {
                val_8.七万丗丅丄丑万丅丐();
            val_8.丂与业丈东丝丒丑丗();
        }
        
        val_63 =  + 1;
        mem2[0] = 732;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_227;
        }
        
        if(401 == 716)
        {
            goto label_230;
        }
        
        if(401 == 732)
        {
                return;
        }
        
        label_227:
        label_230:
        this.Invoke(methodName:  "SetParent", time:  0.1f);
    }
    public SetParentWeapon()
    {
    
    }

}
