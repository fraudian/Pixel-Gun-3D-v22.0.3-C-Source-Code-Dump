using UnityEngine;
private sealed class Player_move_c.丂丞下丆丝丛七东世 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    private int 三不丝世专七丈丅一;
    private WeaponSounds 丁世上丛业丆世丏丐;
    private int 丟丗丒丟丝丘丞丝丏;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.丂丞下丆丝丛七东世(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_82;
        float val_83;
        float val_134;
        int val_135;
        WeaponSounds val_136;
        int val_137;
        int val_138;
        WeaponSounds val_139;
        float val_140;
        var val_141;
        float val_142;
        float val_147;
        var val_148;
        var val_149;
        UnityEngine.Camera val_150;
        float val_151;
        float val_152;
        var val_153;
        var val_154;
        var val_155;
        var val_156;
        float val_157;
        var val_158;
        var val_159;
        var val_160;
        var val_161;
        var val_162;
        float val_163;
        var val_164;
        float val_165;
        float val_166;
        float val_167;
        var val_168;
        float val_169;
        float val_170;
        float val_171;
        var val_172;
        float val_173;
        float val_174;
        float val_175;
        float val_180;
        float val_181;
        float val_182;
        float val_183;
        var val_184;
        var val_185;
        System.Collections.IEnumerator val_186;
        var val_187;
        val_134 = 0;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        val_135 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_135;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三不丝世专七丈丅一 = 0;
        val_136 = this.丝且与丝丒丟万丁专.丅且不三丅丂上丈丅();
        this.丁世上丛业丆世丏丐 = val_136;
        val_137 = 0;
        mem[1152921535885781688] = 0;
        if(val_136 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_1:
        val_138 = this.丟丗丒丟丝丘丞丝丏;
        val_139 = this.丁世上丛业丆世丏丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_215;
        label_2:
        val_139 = this.丁世上丛业丆世丏丐;
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_23;
        label_219:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_10;
        }
        
        if((mem[this.丁世上丛业丆世丏丐] + 929) == 0)
        {
            goto label_11;
        }
        
        goto label_12;
        label_10:
        if((mem[this.丁世上丛业丆世丏丐] + 929) != 0)
        {
            goto label_12;
        }
        
        label_11:
        if(this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕().丕丆万丝上丕下丙业() == false)
        {
            goto label_18;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
                WeaponSounds val_4 = this.丝且与丝丒丟万丁专.丙不丅丕三丂业东丕();
        }
        
        if((this.丝且与丝丒丟万丁专.业且丒丛丛丂丗丆丁(丌丝下丄业一丄不三:  0.丙不丅丕三丂业东丕())) == false)
        {
            goto label_18;
        }
        
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_21;
        }
        
        goto label_20;
        label_18:
        label_12:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_21;
        }
        
        label_20:
        label_21:
        this.丝且与丝丒丟万丁专.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  true, 一丅丁丞万丙丏丁丁:  this.三不丝世专七丈丅一, 丁丂世丑丟一丕丆一:  false);
        val_136 = mem[this.丁世上丛业丆世丏丐];
        val_134 = mem[mem[this.丁世上丛业丆世丏丐] + 292];
        val_134 = mem[this.丁世上丛业丆世丏丐] + 292;
        if(val_134 > 0f)
        {
                val_140 = mem[mem[this.丁世上丛业丆世丏丐] + 292];
            val_140 = mem[this.丁世上丛业丆世丏丐] + 292;
            val_135 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_140);
            this.丗丏丅丕丆世丁专丟 = val_135;
            return (bool)val_135;
        }
        
        label_23:
        if(mem[this.丁世上丛业丆世丏丐].丕丆万丝上丕下丙业() != false)
        {
                if((this.丝且与丝丒丟万丁专.业且丒丛丛丂丗丆丁(丌丝下丄业一丄不三:  mem[this.丁世上丛业丆世丏丐])) == true)
        {
            goto label_36;
        }
        
        }
        
        if(this.丟丗丒丟丝丘丞丝丏 != 0)
        {
                if((mem[this.丁世上丛业丆世丏丐] + 332) == 0)
        {
            goto label_36;
        }
        
        }
        
        if(((mem[this.丁世上丛业丆世丏丐] + 376) != 0) || ((mem[this.丁世上丛业丆世丏丐] + 926) != 0))
        {
            goto label_36;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_37;
        }
        
        if(this.丝且与丝丒丟万丁专.丄丝丝下丟丘丄丒丈() == false)
        {
            goto label_38;
        }
        
        label_40:
        三丈丟与丏丘丈丐万 val_11 = this.丝且与丝丒丟万丁专.丆丌丏丝一丕丕业且();
        goto label_39;
        label_37:
        if(0.丄丝丝下丟丘丄丒丈() == true)
        {
            goto label_40;
        }
        
        label_38:
        三丈丟与丏丘丈丐万 val_15 = this.丝且与丝丒丟万丁专.万三与一丈三丐丅且(丞世不丒下上上丝丑:  this.丝且与丝丒丟万丁专.丛丒丒与丞丝丄丝丒().丈丄丙丙丈丗业丆万());
        label_39:
        if(val_15.下世万丆丛专丒丑丙() == 0)
        {
            goto label_44;
        }
        
        label_222:
        bool val_17 = this.丝且与丝丒丟万丁专.丗丘东专不下三丘业(三七丐丟万上与丁丆:  val_15);
        label_36:
        mem[this.丁世上丛业丆世丏丐].丝丅业且丆东与丗不();
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丂丕丁且世丗丕丛专() != false)
        {
                val_141 = mem[mem[this.丁世上丛业丆世丏丐] + 288];
            val_141 = mem[this.丁世上丛业丆世丏丐] + 288;
        }
        else
        {
                val_141 = 1;
        }
        
        if(((mem[this.丁世上丛业丆世丏丐] + 929) == 0) || ((mem[this.丁世上丛业丆世丏丐] + 287) == 0))
        {
            goto label_56;
        }
        
        UnityEngine.Vector3 val_22 = mem[this.丁世上丛业丆世丏丐] + 1304.Item[this.丝且与丝丒丟万丁专.丕丕不且丝下东丟七 - 1].transform.position;
        val_142 = val_22.x;
        if((mem[this.丁世上丛业丆世丏丐] + 324) == 0)
        {
            goto label_62;
        }
        
        if((mem[this.丁世上丛业丆世丏丐] + 1304.Item[this.丝且与丝丒丟万丁专.丕丕不且丝下东丟七 - 1].transform) != null)
        {
            goto label_102;
        }
        
        label_103:
        label_102:
        UnityEngine.Quaternion val_26 = 0.rotation;
        label_116:
        this.丝且与丝丒丟万丁专.丄专丒专且世丆七业();
        goto label_101;
        label_56:
        if((mem[this.丁世上丛业丆世丏丐] + 345) != 0)
        {
                if((mem[this.丁世上丛业丆世丏丐] + 288) == 0)
        {
            goto label_71;
        }
        
        }
        
        if((mem[this.丁世上丛业丆世丏丐] + 1304.Count) < 1)
        {
            goto label_74;
        }
        
        UnityEngine.Vector3 val_30 = mem[this.丁世上丛业丆世丏丐] + 1304.Item[this.三不丝世专七丈丅一].transform.position;
        val_142 = val_30.x;
        UnityEngine.Quaternion val_33 = mem[this.丁世上丛业丆世丏丐] + 1304.Item[this.三不丝世专七丈丅一].transform.rotation;
        this.丝且与丝丒丟万丁专.丄专丒专且世丆七业(一丅丁丞万丙丏丁丁:  this.三不丝世专七丈丅一);
        int val_34 = this.三不丝世专七丈丅一 + 1;
        this.三不丝世专七丈丅一 = val_34;
        if(val_34 < (mem[this.丁世上丛业丆世丏丐] + 1304.Count))
        {
            goto label_101;
        }
        
        this.三不丝世专七丈丅一 = 0;
        goto label_101;
        label_74:
        UnityEngine.Vector3 val_37 = this.丝且与丝丒丟万丁专.myTransform.position;
        UnityEngine.Vector3 val_39 = this.丝且与丝丒丟万丁专.myTransform.forward;
        UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, d:  0.2f);
        val_134 = val_37.x;
        val_147 = val_37.y;
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_134, y = val_147, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z});
        val_142 = val_41.x;
        UnityEngine.Quaternion val_43 = this.丝且与丝丒丟万丁专.myTransform.rotation;
        this.丝且与丝丒丟万丁专.丄专丒专且世丆七业(一丅丁丞万丙丏丁丁:  0);
        if(((this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆 == false) || (this.丝且与丝丒丟万丁专.七且不东世与且丒丛 == true)) || (this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丘丂三东丁且丙世七() == false))
        {
            goto label_101;
        }
        
        BaseCamera val_45 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        UnityEngine.Vector3 val_46 = val_45.pointForShootFromZoom.position;
        val_142 = val_46.x;
        BaseCamera val_47 = this.丝且与丝丒丟万丁专.丝丙与东丈不丙三丟();
        UnityEngine.Quaternion val_48 = val_47.pointForShootFromZoom.rotation;
        goto label_101;
        label_62:
        if(this.丝且与丝丒丟万丁专.myTransform != null)
        {
            goto label_102;
        }
        
        goto label_103;
        label_71:
        UnityEngine.Vector3 val_52 = mem[this.丁世上丛业丆世丏丐] + 1304.Item[0].transform.position;
        val_142 = val_52.x;
        UnityEngine.Quaternion val_55 = mem[this.丁世上丛业丆世丏丐] + 1304.Item[0].transform.rotation;
        val_148 = mem[this.丁世上丛业丆世丏丐];
        if(mem[this.丁世上丛业丆世丏丐] != 0)
        {
            goto label_112;
        }
        
        val_148 = mem[this.丁世上丛业丆世丏丐];
        if(val_148 == 0)
        {
            goto label_181;
        }
        
        label_112:
        float val_127 = (float)this.丟丗丒丟丝丘丞丝丏;
        val_127 = (mem[this.丁世上丛业丆世丏丐] + 348) * val_127;
        UnityEngine.Quaternion val_57 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_127 - (mem[this.丁世上丛业丆世丏丐] + 348), z:  0f);
        val_134 = val_55.x;
        val_147 = val_55.y;
        UnityEngine.Quaternion val_58 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_134, y = val_147, z = val_55.z, w = val_55.w}, rhs:  new UnityEngine.Quaternion() {x = val_57.x, y = val_57.y, z = val_57.z, w = val_57.w});
        if(this.丟丗丒丟丝丘丞丝丏 == 0)
        {
            goto label_116;
        }
        
        label_101:
        if(mem[this.丁世上丛业丆世丏丐].且且丈丗丗丏丛专丑() != false)
        {
                float val_60 = this.丝且与丝丒丟万丁专.丂一丟丟不丌丑丒丐(丌丝下丄业一丄不三:  mem[this.丁世上丛业丆世丏丐]);
            val_149 = null;
            val_149 = null;
            val_150 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
            UnityEngine.Vector2 val_62 = mem[this.丁世上丛业丆世丏丐].世丆丈丐东东丁丁丗();
            float val_128 = val_62.x;
            UnityEngine.Vector2 val_63 = mem[this.丁世上丛业丆世丏丐].世丆丈丐东东丁丁丗();
            val_63.x = val_60 * val_63.x;
            UnityEngine.Vector2 val_67 = mem[this.丁世上丛业丆世丏丐].世丆丈丐东东丁丁丗();
            val_151 = val_60 * val_128;
            float val_130 = (float)UnityEngine.Screen.height;
            val_128 = (float)UnityEngine.Screen.width - val_151;
            val_152 = 0f;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_153 = null;
            val_153 = null;
            val_151 = (float)UnityEngine.Screen.height;
            float val_129 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_129 = 1f - val_129;
            val_129 = val_129 * val_151;
            val_152 = val_129 * 0.5f;
        }
        
            val_130 = val_130 - (val_60 * val_67.y);
            val_128 = val_128 * 0.5f;
            val_130 = val_130 * 0.5f;
            val_154 = val_128 + ((float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_63.x)));
            UnityEngine.Vector2 val_71 = mem[this.丁世上丛业丆世丏丐].世丆丈丐东东丁丁丗();
            val_155 = (val_130 + val_152) + ((float)UnityEngine.Random.Range(min:  0, max:  UnityEngine.Mathf.RoundToInt(f:  val_60 * val_71.y)));
        }
        else
        {
                val_156 = null;
            val_156 = null;
            val_150 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专;
            val_154 = (float)UnityEngine.Screen.width * 0.5f;
            val_157 = 0f;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_158 = null;
            val_158 = null;
            float val_131 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_131 = 1f - val_131;
            val_131 = val_131 * (float)UnityEngine.Screen.height;
            val_157 = val_131 * 0.5f;
        }
        
            val_155 = ((float)UnityEngine.Screen.height * 0.5f) + val_157;
        }
        
        UnityEngine.Ray val_81 = val_150.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if(val_141 == 0)
        {
            goto label_148;
        }
        
        if((mem[this.丁世上丛业丆世丏丐] + 326) != 0)
        {
                if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丘丂三东丁且丙世七() == false)
        {
            goto label_148;
        }
        
        }
        
        val_159 = null;
        val_159 = null;
        UnityEngine.Vector3 val_87 = this.丝且与丝丒丟万丁专.东丟丕下丏下丝且丁().position;
        UnityEngine.Vector3 val_88 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_87.x, y = val_87.y, z = val_87.z});
        UnityEngine.Vector3 val_89 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_83, y = 0f, z = 0f}, d:  val_88.z);
        UnityEngine.Vector3 val_90 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_83, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_89.x, y = val_89.y, z = val_89.z});
        val_82 = val_82;
        val_83 = val_83;
        val_160 = 300f;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_83, y = val_83, z = val_83}, m_Direction = new UnityEngine.Vector3() {x = val_83, y = val_82, z = val_82}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  300f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丑且丛且丝丞且丗丒())) == false)
        {
            goto label_156;
        }
        
        goto label_157;
        label_148:
        val_161 = null;
        val_161 = null;
        UnityEngine.Vector3 val_95 = this.丝且与丝丒丟万丁专.东丟丕下丏下丝且丁().position;
        UnityEngine.Vector3 val_96 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_95.x, y = val_95.y, z = val_95.z});
        UnityEngine.Vector3 val_97 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_142, y = val_52.y, z = val_52.z}, d:  val_96.z);
        UnityEngine.Vector3 val_98 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_142, y = val_52.y, z = val_52.z}, b:  new UnityEngine.Vector3() {x = val_97.x, y = val_97.y, z = val_97.z});
        val_82 = 0;
        val_83 = 0;
        val_162 = 300f;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  300f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丑且丛且丝丞且丗丒())) != false)
        {
            
        }
        else
        {
                val_162 = 300f;
        }
        
        val_163 = val_142;
        val_164 = val_162;
        val_165 = val_98.y;
        UnityEngine.Vector3 val_101 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 300f, y = val_98.y, z = val_98.z}, b:  new UnityEngine.Vector3() {x = val_163, y = val_52.y, z = val_52.z});
        UnityEngine.Quaternion val_102 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_101.x, y = val_101.y, z = val_101.z});
        UnityEngine.Color val_103 = UnityEngine.Color.cyan;
        val_167 = val_52.z;
        val_166 = val_52.y;
        val_168 = 1084227584;
        val_169 = val_163;
        val_170 = val_166;
        val_171 = val_167;
        val_172 = val_164;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_169, y = val_170, z = val_171}, end:  new UnityEngine.Vector3() {x = 300f, y = val_165, z = val_98.z}, color:  new UnityEngine.Color() {r = val_103.r, g = val_103.b, b = 5f}, duration:  val_142);
        val_173 = val_169;
        val_174 = val_170;
        val_175 = val_171;
        UnityEngine.Color val_104 = UnityEngine.Color.green;
        goto label_173;
        label_156:
        val_160 = 300f;
        label_157:
        val_163 = val_142;
        val_180 = val_163;
        UnityEngine.Vector3 val_105 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 300f, y = val_90.y, z = val_90.z}, b:  new UnityEngine.Vector3() {x = val_180, y = val_52.y, z = val_52.z});
        val_181 = val_105.x;
        val_182 = val_105.y;
        val_183 = val_105.z;
        UnityEngine.Quaternion val_106 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_181, y = val_182, z = val_183});
        if((mem[this.丁世上丛业丆世丏丐] + 345) == 0)
        {
            goto label_179;
        }
        
        val_184 = mem[this.丁世上丛业丆世丏丐];
        if(mem[this.丁世上丛业丆世丏丐] != 0)
        {
            goto label_180;
        }
        
        val_184 = mem[this.丁世上丛业丆世丏丐];
        if(val_184 == 0)
        {
            goto label_181;
        }
        
        label_180:
        float val_132 = (float)this.丟丗丒丟丝丘丞丝丏;
        val_132 = (mem[this.丁世上丛业丆世丏丐] + 348) * val_132;
        UnityEngine.Quaternion val_108 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_132 - (mem[this.丁世上丛业丆世丏丐] + 348), z:  0f);
        val_181 = val_106.x;
        val_182 = val_106.y;
        val_183 = val_106.z;
        val_180 = val_106.w;
        UnityEngine.Quaternion val_109 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_181, y = val_182, z = val_183, w = val_180}, rhs:  new UnityEngine.Quaternion() {x = val_108.x, y = val_108.y, z = val_108.z, w = val_108.w});
        val_163 = val_142;
        label_179:
        val_165 = val_90.y;
        val_164 = val_160;
        UnityEngine.Color val_110 = UnityEngine.Color.blue;
        val_167 = val_52.z;
        val_166 = val_52.y;
        val_168 = 1084227584;
        val_169 = val_163;
        val_170 = val_166;
        val_171 = val_167;
        val_172 = val_164;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_169, y = val_170, z = val_171}, end:  new UnityEngine.Vector3() {x = 300f, y = val_165, z = val_90.z}, color:  new UnityEngine.Color() {r = val_110.r, g = val_110.b, b = 5f}, duration:  val_142);
        val_173 = val_169;
        val_174 = val_170;
        val_175 = val_171;
        UnityEngine.Color val_111 = UnityEngine.Color.red;
        label_173:
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_163, y = val_166, z = val_167}, dir:  new UnityEngine.Vector3() {x = val_173, y = val_174, z = val_175}, color:  new UnityEngine.Color() {r = val_111.r, g = val_111.b, b = 5f}, duration:  val_142);
        bool val_112 = mem[this.丁世上丛业丆世丏丐].三专丏丘丟丞与与下();
        if((mem[this.丁世上丛业丆世丏丐] + 344) != 0)
        {
                val_185 = this.丟丗丒丟丝丘丞丝丏 + 1;
        }
        else
        {
                val_185 = 1;
        }
        
        Rocket val_118 = Player_move_c.丞专一丙丁丒万三丏(专丑一业业下且丅丗:  mem[this.丁世上丛业丆世丏丐], 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = (val_112 != true) ? (val_164) : (val_163), y = (val_112 != true) ? (val_165) : val_52.y, z = (val_112 != true) ? val_90.z : val_52.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_109.x, y = val_109.y, z = val_109.z, w = val_109.w}, 丑三一万丆不丁万丏:  this.丝且与丝丒丟万丁专.丈丗世丕且丐丕丒丝(丌丝下丄业一丄不三:  mem[this.丁世上丛业丆世丏丐]), 丗丑丞丗七业丆丙丁:  1, 不丐丂丂丘丞丁丑丌:  this.丝且与丝丒丟万丁专.一丙一丞丑丈业丗丞(丌丝下丄业一丄不三:  mem[this.丁世上丛业丆世丏丐]));
        if(mem[this.丁世上丛业丆世丏丐].三专丏丘丟丞与与下() != false)
        {
                if(val_118 != null)
        {
                val_186 = val_118.丞丑且与丕丙丒丗专(专不丑且不丏东丟丅:  val_134);
        }
        else
        {
                val_186 = 0.丞丑且与丕丙丒丗专(专不丑且不丏东丟丅:  val_134);
        }
        
            UnityEngine.Coroutine val_122 = val_118.StartCoroutine(routine:  val_186);
        }
        
        this.丝且与丝丒丟万丁专.丂不丑丌丌丂丕且且(丏丞业丗丑丕丌且丄:  val_118);
        this.丝且与丝丒丟万丁专.东丐不业丆三与丄丗.Add(item:  val_118);
        一三专丈世丑丆丑丐 val_123 = PlayerCoreSettingsStorager.dynamicSettings;
        if((val_123.丘东丝丛三丟上丅丅 != false) && (mem[this.丁世上丛业丆世丏丐] != 0))
        {
                mem[this.丁世上丛业丆世丏丐].丘丘丆七世万丂丄丟();
            if(this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆 != false)
        {
                一三专丈世丑丆丑丐 val_125 = PlayerCoreSettingsStorager.dynamicSettings;
            if((val_125.与丑专丑丛与丈丑三 != false) && ((mem[this.丁世上丛业丆世丏丐] + 72) == 5))
        {
                this.丝且与丝丒丟万丁专.丑丝丘丛下丒丈三与();
        }
        
        }
        
        }
        
        val_187 = this;
        var val_133 = mem[this.丁世上丛业丆世丏丐] + 328;
        val_133 = val_133 - 1;
        if((this.丟丗丒丟丝丘丞丝丏 != val_133) && ((mem[this.丁世上丛业丆世丏丐] + 300) > 0f))
        {
                val_140 = mem[mem[this.丁世上丛业丆世丏丐] + 300];
            val_140 = mem[this.丁世上丛业丆世丏丐] + 300;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_140);
            this.丗丏丅丕丆世丁专丟 = 2;
            val_135 = 1;
            return (bool)val_135;
        }
        
        label_215:
        val_137 = val_138 + 1;
        mem2[0] = val_137;
        val_136 = mem[this.丁世上丛业丆世丏丐];
        label_6:
        if(val_137 < (mem[this.丁世上丛业丆世丏丐] + 328))
        {
            goto label_219;
        }
        
        label_221:
        val_135 = 0;
        return (bool)val_135;
        label_44:
        if((mem[this.丁世上丛业丆世丏丐] + 332) != 0)
        {
            goto label_221;
        }
        
        goto label_222;
        label_181:
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
