using UnityEngine;
public class SampleSceneScript : MonoBehaviour
{
    // Methods
    private void OnGUI()
    {
        var val_112;
        UnityEngine.GameObject val_113;
        var val_115;
        System.Func<UnityEngine.GameObject, UnityEngine.GameObject> val_116;
        var val_117;
        System.Func<UnityEngine.GameObject, System.Boolean> val_118;
        var val_123;
        var val_131;
        var val_133;
        var val_139;
        System.Func<UnityEngine.GameObject, System.Boolean> val_141;
        var val_142;
        var val_144;
        System.Func<UnityEngine.GameObject, System.Boolean> val_146;
        var val_147;
        System.Func<UnityEngine.GameObject, UnityEngine.GameObject> val_149;
        val_112 = 1152921526243353056;
        val_113 = UnityEngine.GameObject.Find(name:  "Origin");
        if((UnityEngine.GUILayout.Button(text:  "Parent", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                UnityEngine.Debug.Log(message:  "------Parent");
            UnityEngine.Debug.Log(message:  Unity.Linq.丅丆万丟丐丏丏下丄.丘且三与丂世丂万丛(丈丆上丅丘世专丑丕:  val_113).name);
        }
        
        if((UnityEngine.GUILayout.Button(text:  "Child", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                UnityEngine.Debug.Log(message:  "------Child");
            UnityEngine.Debug.Log(message:  Unity.Linq.丅丆万丟丐丏丏下丄.上丅丝与丌下丛丁丑(丈丆上丅丘世专丑丕:  val_113, 丒丘丏上丙丟丑丕丈:  "Sphere_B").name);
        }
        
        if((UnityEngine.GUILayout.Button(text:  "Descendants", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
        {
            goto label_9;
        }
        
        UnityEngine.Debug.Log(message:  "------Descendants");
        var val_124 = 0;
        val_124 = val_124 + 1;
        goto label_16;
        label_9:
        val_115 = 0;
        val_116 = 0;
        val_117 = 0;
        goto label_46;
        label_16:
        System.Collections.Generic.IEnumerator<T> val_14 = Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_113).GetEnumerator();
        val_118 = 1152921504686346240;
        label_32:
        var val_125 = 0;
        val_125 = val_125 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_126 = 0;
        val_126 = val_126 + 1;
        UnityEngine.Debug.Log(message:  val_14.Current.name);
        goto label_32;
        label_23:
        val_117 = 0;
        val_115 = 0;
        if(val_14 == null)
        {
            
        }
        else
        {
                var val_127 = 0;
            val_127 = val_127 + 1;
            val_14.Dispose();
        }
        
        if(( != 1) && (179 == 179))
        {
                val_117 = 0;
            val_116 = ;
        }
        else
        {
                if( != false)
        {
                val_115 = 0;
        }
        
            val_116 = 0;
        }
        
        label_46:
        if((UnityEngine.GUILayout.Button(text:  "name filter overload", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
        {
            goto label_86;
        }
        
        UnityEngine.Debug.Log(message:  "name filter overload");
        var val_128 = 0;
        val_128 = val_128 + 1;
        System.Collections.Generic.IEnumerator<T> val_25 = Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_113, 丒丘丏上丙丟丑丕丈:  "Group").GetEnumerator();
        val_123 = 1152921504686346240;
        label_70:
        var val_129 = 0;
        val_129 = val_129 + 1;
        if(val_25.MoveNext() == false)
        {
            goto label_61;
        }
        
        var val_130 = 0;
        val_130 = val_130 + 1;
        UnityEngine.Debug.Log(message:  val_25.Current.name);
        goto label_70;
        label_61:
        val_117 = 1;
        if(val_25 == null)
        {
            
        }
        else
        {
                var val_131 = 0;
            val_131 = val_131 + 1;
            val_25.Dispose();
        }
        
        if((val_117 != 1) && (261 == 261))
        {
                var val_132 = 0;
            val_132 = val_132 ^ 0;
            val_117 = val_117 + val_132;
        }
        else
        {
                if( != false)
        {
                val_115 = 0;
            val_116 = 0;
        }
        else
        {
                val_115 = 0;
        }
        
        }
        
        label_86:
        if((UnityEngine.GUILayout.Button(text:  "OfComponent", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
        {
            goto label_87;
        }
        
        UnityEngine.Debug.Log(message:  "------OfComponent");
        var val_133 = 0;
        val_133 = val_133 + 1;
        System.Collections.Generic.IEnumerator<T> val_37 = Unity.Linq.丅丆万丟丐丏丏下丄.专丙上不东三丙七三<UnityEngine.SphereCollider>(丑东与丅丐丅丂丞业:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_113)).GetEnumerator();
        label_123:
        var val_134 = 0;
        val_134 = val_134 + 1;
        if(val_37.MoveNext() == false)
        {
            goto label_100;
        }
        
        var val_135 = 0;
        val_135 = val_135 + 1;
        T val_41 = val_37.Current;
        object[] val_42 = new object[4];
        val_42[0] = "Sphere:";
        val_42[1] = val_41.name;
        val_42[2] = " Radius:";
        val_42[3] = val_41.radius;
        UnityEngine.Debug.Log(message:  +val_42);
        goto label_123;
        label_100:
        val_117 = val_117 + 1;
        mem2[0] = 392;
        val_112 = 1152921526243353056;
        if(val_37 == null)
        {
            
        }
        else
        {
                var val_136 = 0;
            val_136 = val_136 + 1;
            val_37.Dispose();
        }
        
        if((val_117 != 1) && ((439608416 + ((val_117 + 1)) << 2) == 392))
        {
                var val_137 = 0;
            val_137 = val_137 ^ (val_117 >> 31);
            val_117 = val_117 + val_137;
        }
        else
        {
                if( != false)
        {
                val_115 = 0;
            val_116 = 0;
        }
        else
        {
                val_115 = 0;
        }
        
        }
        
        val_123 = 1152921505079422976;
        val_131 = null;
        val_131 = null;
        val_118 = SampleSceneScript.<>c.<>9__0_4;
        if(val_118 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_48 = null;
            val_118 = val_48;
            val_48 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SampleSceneScript.<>c::丒一业丁丞三丒业丑(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_4 = val_118;
        }
        
        System.Collections.Generic.IEnumerable<T> val_50 = Unity.Linq.丅丆万丟丐丏丏下丄.专丙上不东三丙七三<UnityEngine.BoxCollider2D>(丑东与丅丐丅丂丞业:  System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_113), predicate:  val_48));
        label_87:
        if((UnityEngine.GUILayout.Button(text:  "LINQ", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
        {
            goto label_301;
        }
        
        val_123 = 1152921504833470464;
        UnityEngine.Debug.Log(message:  "------LINQ");
        val_133 = null;
        val_133 = null;
        val_118 = SampleSceneScript.<>c.<>9__0_5;
        if(val_118 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_54 = null;
            val_118 = val_54;
            val_54 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SampleSceneScript.<>c::七丟业丛世丛业万丙(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_5 = val_118;
        }
        
        var val_138 = 0;
        val_138 = val_138 + 1;
        System.Collections.Generic.IEnumerator<T> val_57 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  val_113), predicate:  val_54).GetEnumerator();
        label_179:
        var val_139 = 0;
        val_139 = val_139 + 1;
        if(val_57.MoveNext() == false)
        {
            goto label_170;
        }
        
        var val_140 = 0;
        val_140 = val_140 + 1;
        UnityEngine.Debug.Log(message:  val_57.Current.name);
        goto label_179;
        label_170:
        val_117 = val_117 + 1;
        mem2[0] = 553;
        if(val_57 == null)
        {
            
        }
        else
        {
                var val_141 = 0;
            val_141 = val_141 + 1;
            val_57.Dispose();
        }
        
        if(val_117 == 1)
        {
            goto label_191;
        }
        
        if(( == false) || ((439608416 + (((val_117 + 1) + 1)) << 2) == 553))
        {
            goto label_301;
        }
        
        label_300:
        label_301:
        if((UnityEngine.GUILayout.Button(text:  "Add", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                UnityEngine.GameObject[] val_66 = new UnityEngine.GameObject[3];
            val_66[0] = new UnityEngine.GameObject(name:  "lastChild1");
            val_66[1] = new UnityEngine.GameObject(name:  "lastChild2");
            val_66[2] = new UnityEngine.GameObject(name:  "lastChild3");
            System.Collections.Generic.List<UnityEngine.GameObject> val_70 = Unity.Linq.丅丆万丟丐丏丏下丄.业丏丗丐丂业东丂丗(丈东丘丏与丌东东下:  val_113, 东七丘业且万丟丅丒:  val_66, 丐丅丒丙下丁上业丂:  0, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false}, 丛上丞丘丑丐丄专丒:  0);
            UnityEngine.GameObject[] val_71 = new UnityEngine.GameObject[3];
            val_71[0] = new UnityEngine.GameObject(name:  "firstChild1");
            val_71[1] = new UnityEngine.GameObject(name:  "firstChild2");
            val_71[2] = new UnityEngine.GameObject(name:  "firstChild3");
            System.Collections.Generic.List<UnityEngine.GameObject> val_75 = Unity.Linq.丅丆万丟丐丏丏下丄.东专丗世业丄丐丟世(丈东丘丏与丌东东下:  val_113, 东七丘业且万丟丅丒:  val_71, 丐丅丒丙下丁上业丂:  0, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false}, 丛上丞丘丑丐丄专丒:  0);
            UnityEngine.GameObject[] val_76 = new UnityEngine.GameObject[3];
            val_76[0] = new UnityEngine.GameObject(name:  "beforeSelf1");
            val_76[1] = new UnityEngine.GameObject(name:  "beforeSelf2");
            val_76[2] = new UnityEngine.GameObject(name:  "beforeSelf3");
            System.Collections.Generic.List<UnityEngine.GameObject> val_80 = Unity.Linq.丅丆万丟丐丏丏下丄.丕下不三丑业一丂丛(丈东丘丏与丌东东下:  val_113, 东七丘业且万丟丅丒:  val_76, 丐丅丒丙下丁上业丂:  0, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false}, 丛上丞丘丑丐丄专丒:  0);
            UnityEngine.GameObject[] val_81 = new UnityEngine.GameObject[3];
            val_81[0] = new UnityEngine.GameObject(name:  "afterSelf1");
            val_81[1] = new UnityEngine.GameObject(name:  "afterSelf2");
            val_81[2] = new UnityEngine.GameObject(name:  "afterSelf3");
            System.Collections.Generic.List<UnityEngine.GameObject> val_85 = Unity.Linq.丅丆万丟丐丏丏下丄.丙丆七丛万丁丞丅丝(丈东丘丏与丌东东下:  val_113, 东七丘业且万丟丅丒:  val_81, 丐丅丒丙下丁上业丂:  0, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false}, 丛上丞丘丑丐丄专丒:  0);
            val_118 = 1152921505079422976;
            val_139 = null;
            val_139 = null;
            val_141 = SampleSceneScript.<>c.<>9__0_0;
            if(val_141 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_88 = null;
            val_141 = val_88;
            val_88 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SampleSceneScript.<>c::三丆丁丏不丙丄丝丟(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_0 = val_141;
        }
        
            val_142 = null;
            val_142 = null;
            val_116 = SampleSceneScript.<>c.<>9__0_1;
            if(val_116 == null)
        {
                System.Func<UnityEngine.GameObject, UnityEngine.GameObject> val_90 = null;
            val_116 = val_90;
            val_90 = new System.Func<UnityEngine.GameObject, UnityEngine.GameObject>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject SampleSceneScript.<>c::专万丆丕丂丄丅丗业(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_1 = val_116;
        }
        
            Unity.Linq.丅丆万丟丐丏丏下丄.Destroy(丑东与丅丐丅丂丞业:  System.Linq.Enumerable.Select<UnityEngine.GameObject, UnityEngine.GameObject>(source:  System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  System.Linq.Enumerable.Cast<UnityEngine.GameObject>(source:  UnityEngine.Resources.FindObjectsOfTypeAll<UnityEngine.GameObject>()), predicate:  val_88), selector:  val_90), 与丁丁一丕丝东丄丂:  false);
        }
        
        if((UnityEngine.GUILayout.Button(text:  "MoveTo", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                val_118 = 1152921507364547232;
            UnityEngine.GameObject[] val_94 = new UnityEngine.GameObject[3];
            val_94[0] = new UnityEngine.GameObject(name:  "lastChild1(Original)");
            val_94[1] = new UnityEngine.GameObject(name:  "lastChild2(Original)");
            val_94[2] = new UnityEngine.GameObject(name:  "lastChild3(Original)");
            System.Collections.Generic.List<UnityEngine.GameObject> val_98 = Unity.Linq.丅丆万丟丐丏丏下丄.东与丞业丄上业丕丄(丈东丘丏与丌东东下:  val_113, 不丏丟丞丅丄世丒丒:  val_94, 丛七三丘业专三丒一:  2, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false});
            UnityEngine.GameObject[] val_99 = new UnityEngine.GameObject[3];
            val_99[0] = new UnityEngine.GameObject(name:  "firstChild1(Original)");
            val_99[1] = new UnityEngine.GameObject(name:  "firstChild2(Original)");
            val_99[2] = new UnityEngine.GameObject(name:  "firstChild3(Original)");
            System.Collections.Generic.List<UnityEngine.GameObject> val_103 = Unity.Linq.丅丆万丟丐丏丏下丄.万丁丌三东三丐专不(丈东丘丏与丌东东下:  val_113, 不丏丟丞丅丄世丒丒:  val_99, 丛七三丘业专三丒一:  2, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false});
            UnityEngine.GameObject[] val_104 = new UnityEngine.GameObject[3];
            val_104[0] = new UnityEngine.GameObject(name:  "beforeSelf1(Original)");
            val_104[1] = new UnityEngine.GameObject(name:  "beforeSelf2(Original)");
            val_104[2] = new UnityEngine.GameObject(name:  "beforeSelf3(Original)");
            System.Collections.Generic.List<UnityEngine.GameObject> val_108 = Unity.Linq.丅丆万丟丐丏丏下丄.世丝世专东七丄丁下(丈东丘丏与丌东东下:  val_113, 不丏丟丞丅丄世丒丒:  val_104, 丛七三丘业专三丒一:  2, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false});
            UnityEngine.GameObject[] val_109 = new UnityEngine.GameObject[3];
            val_109[0] = new UnityEngine.GameObject(name:  "afterSelf1(Original)");
            val_109[1] = new UnityEngine.GameObject(name:  "afterSelf2(Original)");
            UnityEngine.GameObject val_112 = null;
            val_116 = val_112;
            val_112 = new UnityEngine.GameObject(name:  "afterSelf3(Original)");
            val_109[2] = val_116;
            System.Collections.Generic.List<UnityEngine.GameObject> val_113 = Unity.Linq.丅丆万丟丐丏丏下丄.丁丆一一丄上丟丈丙(丈东丘丏与丌东东下:  val_113, 不丏丟丞丅丄世丒丒:  val_109, 丛七三丘业专三丒一:  2, 丗一不上东业专不业:  new System.Nullable<System.Boolean>() {HasValue = false});
        }
        
        if((UnityEngine.GUILayout.Button(text:  "Destroy", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) == false)
        {
                return;
        }
        
        val_144 = null;
        val_144 = null;
        val_146 = SampleSceneScript.<>c.<>9__0_2;
        if(val_146 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_120 = null;
            val_146 = val_120;
            val_120 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SampleSceneScript.<>c::丁万三丒丌东丑业业(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_2 = val_146;
        }
        
        val_147 = null;
        val_113 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丛且丞不业丅丆丝且(丈丆上丅丘世专丑丕:  val_113.transform.root.gameObject), predicate:  val_120);
        val_147 = null;
        val_149 = SampleSceneScript.<>c.<>9__0_3;
        if(val_149 == null)
        {
                System.Func<UnityEngine.GameObject, UnityEngine.GameObject> val_122 = null;
            val_149 = val_122;
            val_122 = new System.Func<UnityEngine.GameObject, UnityEngine.GameObject>(object:  SampleSceneScript.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.GameObject SampleSceneScript.<>c::丌一丑丅且丟丆丏丕(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            SampleSceneScript.<>c.<>9__0_3 = val_149;
        }
        
        Unity.Linq.丅丆万丟丐丏丏下丄.Destroy(丑东与丅丐丅丂丞业:  System.Linq.Enumerable.Select<UnityEngine.GameObject, UnityEngine.GameObject>(source:  val_113, selector:  val_122), 与丁丁一丕丝东丄丂:  false);
        return;
        label_191:
        if( == true)
        {
            goto label_300;
        }
        
        goto label_301;
    }
    public SampleSceneScript()
    {
    
    }

}
