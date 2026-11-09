using UnityEngine;
private sealed class Player_move_c.丘丁丁下不业丕三丑 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private WeaponSounds 万丝丗丌与业业丂丈;
    public WeaponSounds 丕丌且下丟与丏丅业;
    public Player_move_c 丝且与丝丒丟万丁专;
    private int 丙丏万丆丁丕丂丈丙;
    private int 丈丌丝且业丏丈丂丁;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丘丁丁下不业丕三丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Coroutine val_82;
        int val_83;
        WeaponSounds val_84;
        float val_85;
        var val_86;
        float val_87;
        float val_88;
        float val_89;
        int val_91;
        WeaponSounds val_92;
        UnityEngine.Object val_93;
        WeaponSounds val_94;
        float val_95;
        var val_96;
        float val_97;
        float val_98;
        WeaponSounds val_101;
        float val_102;
        var val_103;
        var val_104;
        var val_106;
        var val_108;
        float val_113;
        float val_114;
        bool val_115;
        WeaponSounds val_116;
        UnityEngine.Collider val_117;
        var val_118;
        float val_119;
        WeaponSounds val_120;
        float val_121;
        val_82 = this;
        bool val_79 = false;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_83 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_83;
        }
        
        val_84 = this.万丝丗丌与业业丂丈;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.万丝丗丌与业业丂丈.gradualExplosions == false)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_6;
        }
        
        val_82 = this.丝且与丝丒丟万丁专.StartCoroutine(routine:  this.丝且与丝丒丟万丁专.丘一丅丂七丘三与东());
        goto label_7;
        label_1:
        int val_87 = this.丈丌丝且业丏丈丂丁;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_87 = val_87 + 1;
        this.丈丌丝且业丏丈丂丁 = val_87;
        label_52:
        if(val_87 >= this.丙丏万丆丁丕丂丈丙)
        {
            goto label_13;
        }
        
        val_84 = this.万丝丗丌与业业丂丈;
        val_85 = this.丝且与丝丒丟万丁专.丁丌一丗一世七不丅(丛丟三丘丛且业丈丏:  val_84);
        val_83 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_85);
        this.丗丏丅丕丆世丁专丟 = val_83;
        return (bool)val_83;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_84 = this.万丝丗丌与业业丂丈;
        if(val_84 == 0)
        {
            goto label_13;
        }
        
        val_86 = null;
        val_86 = null;
        UnityEngine.Vector3 val_8 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.transform.position;
        UnityEngine.Vector3 val_11 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.transform.forward;
        val_87 = val_11.y;
        val_88 = this.万丝丗丌与业业丂丈.range;
        val_89 = 3.402823E+38f;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, direction:  new UnityEngine.Vector3() {x = val_11.x, y = val_87, z = val_11.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_88, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗())) == false)
        {
            goto label_29;
        }
        
        if(0.gameObject == 0)
        {
            goto label_29;
        }
        
        丅丙上七上一丐不下 val_16 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  0);
        if(val_16 == null)
        {
            goto label_30;
        }
        
        var val_88 = 0;
        val_88 = val_88 + 1;
        goto label_34;
        label_5:
        if(this.万丝丗丌与业业丂丈.isDoubleShot == false)
        {
            goto label_36;
        }
        
        val_91 = this.丝且与丝丒丟万丁专.丕丕不且丝下东丟七;
        var val_17 = (this.丝且与丝丒丟万丁专 == 0) ? 1 : 0;
        goto label_42;
        label_29:
        val_93 = 0;
        goto label_39;
        label_6:
        val_82 = 0.StartCoroutine(routine:  0.丘一丅丂七丘三与东());
        label_7:
        val_83 = 0;
        this.丝且与丝丒丟万丁专.上上不三三丆丕世丅 = val_82;
        return (bool)val_83;
        label_36:
        if(this.丝且与丝丒丟万丁专 != null)
        {
                val_92 = 0;
            val_91 = 0;
        }
        else
        {
                val_91 = 0;
            val_92 = 1;
        }
        
        label_42:
        this.丝且与丝丒丟万丁专.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  false, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        Player_move_c.丙丕业丝七与世三丑(丄丏丅与丙丆丞丒丏:  this.万丝丗丌与业业丂丈, 世丅上丅丆丕下丒万:  0, 丄上丐不专丁丄丏丐:  this.丝且与丝丒丟万丁专);
        val_84 = this.万丝丗丌与业业丂丈;
        if(this.万丝丗丌与业业丂丈.isDamageFromDamageCollider == false)
        {
            goto label_46;
        }
        
        label_13:
        val_83 = 0;
        return (bool)val_83;
        label_46:
        WeaponSounds val_20 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        this.丙丏万丆丁丕丂丈丙 = UnityEngine.Mathf.Max(a:  1, b:  val_20.meleePunchesCount);
        this.丈丌丝且业丏丈丂丁 = 0;
        goto label_52;
        label_30:
        val_93 = 0;
        goto label_53;
        label_34:
        val_93 = val_16.transform.gameObject;
        label_53:
        var val_26 = ((HitBox.丁丞与丗不丈丟下丏(且丙与丏下丅丐世丑:  0)) == 2) ? 1 : 0;
        val_89 = 0f;
        label_39:
        val_94 = this.万丝丗丌与业业丂丈;
        if(val_94 == null)
        {
            goto label_55;
        }
        
        val_95 = this.万丝丗丌与业业丂丈.range;
        goto label_56;
        label_55:
        val_95 = this.万丝丗丌与业业丂丈.range;
        if(this.万丝丗丌与业业丂丈 == null)
        {
            goto label_57;
        }
        
        val_94 = this.万丝丗丌与业业丂丈;
        label_56:
        label_110:
        float val_89 = val_94.丕丙丟丙丟丈丙丝东();
        WeaponSounds val_29 = this.万丝丗丌与业业丂丈;
        val_96 = val_29;
        val_29 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑();
        val_97 = val_95 * this.万丝丗丌与业业丂丈.range;
        if(this.万丝丗丌与业业丂丈.healer != false)
        {
                丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑 val_30 = null;
            val_96 = val_30;
            val_30 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this.丝且与丝丒丟万丁专, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  true, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true);
        }
        
        val_89 = val_97 * val_89;
        val_89 = val_89 * val_29.丕丙丟丙丟丈丙丝东();
        val_98 = 80f;
        val_92 = val_30.世且一丄且上丄不一();
        label_108:
        var val_90 = 0;
        val_90 = val_90 + 1;
        if(val_92.MoveNext() == false)
        {
            goto label_67;
        }
        
        var val_91 = 0;
        val_91 = val_91 + 1;
        T val_35 = val_92.Current;
        if(val_93 != 0)
        {
                if(val_93.transform == val_35)
        {
            goto label_108;
        }
        
        }
        
        UnityEngine.Vector3 val_39 = val_35.position;
        UnityEngine.Vector3 val_41 = this.丝且与丝丒丟万丁专.丒一丄丗丞丗丄丐丂.transform.position;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
        if(val_42.x >= 0)
        {
            goto label_108;
        }
        
        UnityEngine.Vector3 val_45 = this.丝且与丝丒丟万丁专.gameObject.transform.forward;
        val_101 = this.万丝丗丌与业业丂丈;
        if(val_101 != null)
        {
                val_102 = this.万丝丗丌与业业丂丈.meleeAngle;
        }
        else
        {
                val_102 = this.万丝丗丌与业业丂丈.meleeAngle;
            if(this.万丝丗丌与业业丂丈 != null)
        {
                val_101 = this.万丝丗丌与业业丂丈;
        }
        else
        {
                val_101 = 0;
        }
        
        }
        
        float val_47 = val_101.丕丙丟丙丟丈丙丝东();
        val_47 = val_102 * val_47;
        float val_48 = UnityEngine.Mathf.Clamp(value:  val_47, min:  0f, max:  val_98);
        if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, to:  new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z})) >= 0)
        {
            goto label_108;
        }
        
        if(val_42.x < 0)
        {
                UnityEngine.GameObject val_49 = val_35.gameObject;
        }
        
        if(this.万丝丗丌与业业丂丈.isMeleeSlasher == false)
        {
            goto label_108;
        }
        
        UnityEngine.Vector3 val_51 = this.丝且与丝丒丟万丁专.transform.position;
        bool val_53 = this.丝且与丝丒丟万丁专.下丏一丏与三丝丙不(丌丝下丄业一丄不三:  this.万丝丗丌与业业丂丈, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_51.x, y = val_51.y, z = val_51.z}, 丞下万上三丘上与专:  val_35.gameObject, 世丕与丙丄丙不丄丝:  false, 专世丂丆专业丌丈丈:  0f, 丌东世丞世丆丄丑三:  1f, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0, 丄世上丘丄丌丞三专:  false);
        if(this.万丝丗丌与业业丂丈.jumpDisabler == false)
        {
            goto label_108;
        }
        
        this.丝且与丝丒丟万丁专.东东不万丁丒丁且下(丂丈丙且丈丗三丆丕:  val_35.GetComponent<丅丙上七上一丐不下>(), 丗三丕与上丝东丌专:  this.万丝丗丌与业业丂丈.jumpDisableTime);
        goto label_108;
        label_57:
        if(this.万丝丗丌与业业丂丈 != null)
        {
            goto label_110;
        }
        
        goto label_110;
        label_67:
        val_103 = 0;
        val_104 = 0;
        if(val_92 == null)
        {
            
        }
        else
        {
                var val_92 = 0;
            val_92 = val_92 + 1;
            val_92.Dispose();
        }
        
        val_106 = 0;
        if(val_93 == 0)
        {
            goto label_202;
        }
        
        val_92 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_93.transform);
        if(val_92 == null)
        {
            goto label_159;
        }
        
        var val_93 = 0;
        val_93 = val_93 + 1;
        val_106 = 4;
        if((val_92.IsEnemyTo(专丞上七七且丝七丗:  this.丝且与丝丒丟万丁专)) == false)
        {
            goto label_159;
        }
        
        if(this.万丝丗丌与业业丂丈.isLightning == false)
        {
            goto label_161;
        }
        
        val_92 = this.万丝丗丌与业业丂丈;
        if(val_93 != 0)
        {
            goto label_164;
        }
        
        val_108 = 1152921505111851008;
        UnityEngine.Vector3 val_63 = val_93.transform.position;
        goto label_167;
        label_159:
        if(((this.万丝丗丌与业业丂丈.healer == false) || (val_92 == null)) || (null != null))
        {
            goto label_202;
        }
        
        val_103 = 1152921505240178688;
        var val_94 = 0;
        val_94 = val_94 + 1;
        goto label_179;
        label_161:
        if(val_93 != val_93)
        {
            goto label_182;
        }
        
        val_92;
        UnityEngine.Vector3 val_67 = this.丝且与丝丒丟万丁专.transform.position;
        val_113 = val_67.x;
        val_114 = val_67.y;
        val_97 = val_67.z;
        val_115 = 0 & 1;
        val_116 = this.万丝丗丌与业业丂丈;
        val_117 = val_92;
        goto label_186;
        label_164:
        val_108 = 1152921505111851008;
        label_167:
        val_97 = val_8.z;
        UnityEngine.Quaternion val_69 = this.丝且与丝丒丟万丁专.myTransform.rotation;
        val_87 = val_69.y;
        val_88 = val_69.w;
        val_98 = val_98;
        Rocket val_71 = Player_move_c.丞专一丙丁丒万三丏(专丑一业业下且丅丗:  val_92, 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_98, y = val_8.y, z = val_97}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_69.x, y = val_87, z = val_69.z, w = val_88}, 丑三一万丆不丁万丏:  this.丝且与丝丒丟万丁专.丈丗世丕且丐丕丒丝(丌丝下丄业一丄不三:  this.万丝丗丌与业业丂丈), 丗丑丞丗七业丆丙丁:  1, 不丐丂丂丘丞丁丑丌:  0);
        goto label_202;
        label_182:
        val_92 = this.丝且与丝丒丟万丁专.transform;
        UnityEngine.Vector3 val_73 = val_92.position;
        val_113 = val_73.x;
        val_114 = val_73.y;
        val_97 = val_73.z;
        val_115 = 0 & 1;
        val_116 = this.万丝丗丌与业业丂丈;
        val_117 = 0;
        label_186:
        val_98 = val_113;
        bool val_74 = this.丝且与丝丒丟万丁专.下丏一丏与三丝丙不(丌丝下丄业一丄不三:  val_116, 专不丑且不丏东丟丅:  val_117, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_98, y = val_114, z = val_97}, 丞下万上三丘上与专:  val_93, 世丕与丙丄丙不丄丝:  val_115, 专世丂丆专业丌丈丈:  0f, 丌东世丞世丆丄丑三:  1f, 丏丟丘丈丁丌丗丗丕:  false, 丌丙与上且丁丝丌且:  0, 丄世上丘丄丌丞三专:  false);
        goto label_202;
        label_179:
        val_118 = null;
        val_118 = null;
        if((丘丛丞且一丅丁丏丐.丗丏丌一一业且业丘(丛丌丕丐世丑丂七丂:  val_92.transform, 上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC)) != true)
        {
                UnityEngine.Transform val_78 = val_93.transform;
            if(this.丝且与丝丒丟万丁专 != null)
        {
                val_119 = 0f;
            val_120 = this.万丝丗丌与业业丂丈;
            val_121 = this.丝且与丝丒丟万丁专.丏七下丛世丁东丄业(丞下万上三丘上与专:  val_78, 丌丝下丄业一丄不三:  val_120, 专世丂丆专业丌丈丈:  val_119, 世丕与丙丄丙不丄丝:  false, 丙丏与且丘东丆丁丑: out  val_79, 三丁丄丄丐丕丞丆丗:  0f);
        }
        else
        {
                val_119 = 0f;
            val_120 = this.万丝丗丌与业业丂丈;
            val_121 = 0.丏七下丛世丁东丄业(丞下万上三丘上与专:  val_78, 丌丝下丄业一丄不三:  val_120, 专世丂丆专业丌丈丈:  val_119, 世丕与丙丄丙不丄丝:  false, 丙丏与且丘东丆丁丑: out  val_79, 三丁丄丄丐丕丞丆丗:  0f);
        }
        
            float val_95 = this.丝且与丝丒丟万丁专.丝上丐万七上丈丞丐();
            val_95 = val_121 * val_95;
            float val_96 = this.万丝丗丌与业业丂丈.TeammateHealMultiplier;
            val_96 = val_95 * val_96;
            var val_97 = 0;
            val_97 = val_97 + 1;
            val_120 = 8;
            val_98 = val_96;
            val_92.AddHealthFromWeaponOnline(上上丗丁丏丙丄丏七:  val_98, 丝三丛且丘不丌丙下:  this.万丝丗丌与业业丂丈.Tag);
        }
        
        label_202:
        val_84 = this.万丝丗丌与业业丂丈;
        val_85 = this.丝且与丝丒丟万丁专.丁东万丆丞丏一专丛(丛丟三丘丛且业丈丏:  val_84);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_85);
        this.丗丏丅丕丆世丁专丟 = 2;
        val_83 = 1;
        return (bool)val_83;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                Player_move_c.丘丁丁下不业丕三丑 val_2 = null;
            val_4 = val_2;
            val_2 = new Player_move_c.丘丁丁下不业丕三丑();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .万丝丗丌与业业丂丈 = this.丕丌且下丟与丏丅业;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
