using UnityEngine;
private sealed class Player_move_c.万上丂丏业与且丒丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Player_move_c 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Player_move_c.万上丂丏业与且丒丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_53;
        float val_54;
        float val_81;
        Player_move_c val_82;
        int val_83;
        var val_84;
        float val_85;
        bool val_86;
        float val_87;
        float val_88;
        float val_89;
        var val_90;
        var val_91;
        float val_96;
        float val_97;
        var val_101;
        float val_102;
        var val_103;
        var val_104;
        var val_105;
        float val_106;
        float val_110;
        val_81 = 0;
        val_82 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        val_83 = 0;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_83;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_82 == null)
        {
            goto label_3;
        }
        
        val_82.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  true, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_8;
        label_3:
        0.万丗丄丟东丄丒丞丁(丌丗丈丕丆丁三丌丗:  true, 一丅丁丞万丙丏丁丁:  0, 丁丂世丑丟一丕丆一:  false);
        label_4:
        val_84 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
        val_81 = val_2.bazookaDelay;
        if(val_81 > 0f)
        {
                WeaponSounds val_4 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
            val_85 = val_4.bazookaDelay;
            UnityEngine.WaitForSeconds val_5 = null;
            val_82 = val_5;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  val_85);
            val_83 = 1;
            this.丒上七丌业七丟与丐 = val_82;
            this.丗丏丅丕丆世丁专丟 = val_83;
            return (bool)val_83;
        }
        
        label_8:
        int val_7 = val_82.丛丒丒与丞丝丄丝丒().丈丄丙丙丈丗业丆万();
        if(val_82 != null)
        {
                bool val_9 = val_82.丗丘东专不下三丘业(三七丐丟万上与丁丆:  val_82.万三与一丈三丐丅且(丞世不丒下上上丝丑:  val_7));
        }
        else
        {
                bool val_11 = 0.丗丘东专不下三丘业(三七丐丟万上与丁丆:  0.万三与一丈三丐丅且(丞世不丒下上上丝丑:  val_7));
        }
        
        val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗().丝丅业且丆东与丗不();
        if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丂丕丁且世丗丕丛专() != false)
        {
                WeaponSounds val_16 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
            val_86 = val_16.raycastOnRocketFire;
        }
        else
        {
                val_86 = 1;
        }
        
        WeaponSounds val_18 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
        if(val_18.bulletSpawnPoints.Item[0] != 0)
        {
                WeaponSounds val_22 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
            UnityEngine.Vector3 val_25 = val_22.bulletSpawnPoints.Item[0].transform.position;
        }
        else
        {
                UnityEngine.Vector3 val_27 = val_82.myTransform.position;
            val_87 = val_27.z;
            UnityEngine.Vector3 val_29 = val_82.myTransform.forward;
            val_88 = val_29.x;
            val_89 = val_29.z;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_88, y = val_29.y, z = val_89}, d:  0.2f);
            val_81 = val_27.x;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_81, y = val_27.y, z = val_87}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        }
        
        val_90 = val_31.x;
        val_91 = val_31.y;
        WeaponSounds val_32 = val_82.丙不丅丕三丂业东丕();
        if(val_32.bazookaUseGunFlashDirection == false)
        {
            goto label_48;
        }
        
        WeaponSounds val_33 = val_82.丙不丅丕三丂业东丕();
        if(val_33.bulletSpawnPoints.Item[0] == 0)
        {
            goto label_48;
        }
        
        WeaponSounds val_36 = val_82.丙不丅丕三丂业东丕();
        if(val_36.bulletSpawnPoints.Item[0].transform != null)
        {
            goto label_54;
        }
        
        goto label_53;
        label_48:
        if(val_82.myTransform != null)
        {
            goto label_54;
        }
        
        label_53:
        label_54:
        UnityEngine.Quaternion val_40 = 0.rotation;
        val_82.丄专丒专且世丆七业(一丅丁丞万丙丏丁丁:  0);
        if((this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆 != false) && (this.丝且与丝丒丟万丁专.七且不东世与且丒丛 != true))
        {
                if(this.丝且与丝丒丟万丁专.mySkinName.firstPersonControl.丘丂三东丁且丙世七() != false)
        {
                BaseCamera val_42 = val_82.丝丙与东丈不丙三丟();
            UnityEngine.Vector3 val_43 = val_42.pointForShootFromZoom.position;
            val_96 = val_43.x;
            val_97 = val_43.y;
            BaseCamera val_44 = val_82.丝丙与东丈不丙三丟();
            UnityEngine.Quaternion val_45 = val_44.pointForShootFromZoom.rotation;
        }
        
        }
        
        if(val_86 != 0)
        {
                val_101 = null;
            val_101 = null;
            float val_50 = (float)UnityEngine.Screen.width * 0.5f;
            val_102 = 0f;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_103 = null;
            val_103 = null;
            float val_80 = (float)UnityEngine.Screen.height;
            float val_79 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            val_79 = 1f - val_79;
            val_79 = val_79 * val_80;
            val_102 = val_79 * 0.5f;
        }
        
            val_80 = ((float)UnityEngine.Screen.height * 0.5f) + val_102;
            UnityEngine.Ray val_52 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_104 = null;
            val_104 = null;
            UnityEngine.Vector3 val_57 = val_82.东丟丕下丏下丝且丁().position;
            UnityEngine.Vector3 val_58 = 丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z});
            UnityEngine.Vector3 val_59 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_54, y = 0f, z = 0f}, d:  val_58.z);
            UnityEngine.Vector3 val_60 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_54, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_59.x, y = val_59.y, z = val_59.z});
            val_105 = 300f;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_54, y = val_54, z = val_54}, m_Direction = new UnityEngine.Vector3() {x = val_54, y = val_53, z = val_53}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  300f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丑且丛且丝丞且丗丒())) != false)
        {
            
        }
        else
        {
                val_105 = 300f;
        }
        
            val_88 = val_105;
            val_89 = val_60.z;
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 300f, y = val_60.y, z = val_89}, b:  new UnityEngine.Vector3() {x = val_96, y = val_97, z = val_43.z});
            UnityEngine.Quaternion val_64 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.y, z = val_63.z});
            UnityEngine.Color val_65 = UnityEngine.Color.blue;
            val_106 = val_96;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_106, y = val_97, z = val_43.z}, end:  new UnityEngine.Vector3() {x = 300f, y = val_60.y, z = val_89}, color:  new UnityEngine.Color() {r = val_65.r, g = val_65.b, b = 5f, a = val_54}, duration:  val_54);
            val_87 = val_43.z;
            UnityEngine.Color val_66 = UnityEngine.Color.red;
            val_110 = val_97;
            val_81 = val_106;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_81, y = val_97, z = val_43.z}, dir:  new UnityEngine.Vector3() {x = val_106, y = val_97, z = val_87}, color:  new UnityEngine.Color() {r = val_66.r, g = val_66.b, b = 5f, a = val_54}, duration:  val_54);
        }
        
        val_85 = val_64.x;
        this.丝且与丝丒丟万丁专.东丐不业丆三与丄丗.Add(item:  Player_move_c.丞专一丙丁丒万三丏(专丑一业业下且丅丗:  val_82.丙不丅丕三丂业东丕(), 下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_106, y = val_110, z = val_43.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_85, y = val_64.y, z = val_64.z, w = val_64.w}, 丑三一万丆不丁万丏:  val_82.丈丗世丕且丐丕丒丝(丌丝下丄业一丄不三:  val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗()), 丗丑丞丗七业丆丙丁:  1, 不丐丂丂丘丞丁丑丌:  0));
        val_84 = 1152921505320529920;
        一三专丈世丑丆丑丐 val_72 = PlayerCoreSettingsStorager.dynamicSettings;
        if((val_72.丘东丝丛三丟上丅丅 != false) && (val_82.丙不丅丕三丂业东丕() != 0))
        {
                val_82.丙不丅丕三丂业东丕().丘丘丆七世万丂丄丟();
            if(this.丝且与丝丒丟万丁专.丄丁丑丞丅一三丌丆 != false)
        {
                一三专丈世丑丆丑丐 val_76 = PlayerCoreSettingsStorager.dynamicSettings;
            if(val_76.与丑专丑丛与丈丑三 != false)
        {
                WeaponSounds val_78 = val_82.丛丒丒与丞丝丄丝丒().丞丛丏丐丘与丆七丗();
            if(val_78.categoryNabor == 5)
        {
                val_82.丑丝丘丛下丒丈三与();
        }
        
        }
        
        }
        
        }
        
        val_83 = 0;
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

}
