using UnityEngine;

namespace ProGrids
{
    public static class 丅丌三上丑丈丏专一
    {
        // Fields
        private const float 丄丌丌一丗丆三丆丄 = 0.0001;
        private static System.Collections.Generic.Dictionary<UnityEngine.Transform, ProGrids.丅丌三上丑丈丏专一.丒丌丌三上丙丞下丑> 不丑丅且丕丟东七丆;
        private static System.Collections.Generic.Dictionary<System.Type, bool> 丁丆丞丁业丛丅丗东;
        private static System.Collections.Generic.Dictionary<System.Type, System.Reflection.MethodInfo> 上丁丘丕丆万东丒丞;
        
        // Methods
        public static UnityEngine.Color 丗东丌丅丌丞丕丟下(string 丙业与丙丗丝不丈东)
        {
            var val_12;
            var val_13;
            .七东丗三世下丆万丝 = "01234567890.,";
            char[] val_6 = new char[1];
            val_6[0] = ',';
            System.String[] val_7 = 0.CreateString(val:  System.Linq.Enumerable.ToArray<System.Char>(source:  System.Linq.Enumerable.Where<System.Char>(source:  丙业与丙丗丝不丈东, predicate:  new System.Func<System.Char, System.Boolean>(object:  new 丅丌三上丑丈丏专一.丞上丕丈丒丘丆三丈(), method:  System.Boolean 丅丌三上丑丈丏专一.丞上丕丈丒丘丆三丈::丛下丅丆丗丌三丟下(char 丁丂专业丁丅丅丈丙))))).Split(separator:  val_6);
            if(val_7.Length > 3)
            {
                    float val_8 = System.Single.Parse(s:  val_7[0]);
                float val_10 = System.Single.Parse(s:  val_7[2]);
                val_12 = System.Single.Parse(s:  val_7[3]);
                val_13 = System.Single.Parse(s:  val_7[1]);
                return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            val_13 = 0f;
            val_12 = 1f;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        private static UnityEngine.Vector3 业丕东且丏一且丑且(UnityEngine.Vector3 且下丛丁丄不三丞与)
        {
            var val_4;
            float val_6;
            val_4 = null;
            val_4 = null;
            val_6 = UnityEngine.Mathf.Epsilon;
            var val_1 = (System.Math.Abs(且下丛丁丄不三丞与.x) > val_6) ? 1f : 0f;
            val_4 = null;
            val_6 = UnityEngine.Mathf.Epsilon;
            var val_2 = (System.Math.Abs(且下丛丁丄不三丞与.y) > val_6) ? 1f : 0f;
            val_6 = UnityEngine.Mathf.Epsilon;
            var val_3 = (System.Math.Abs(且下丛丁丄不三丞与.z) > val_6) ? 1f : 0f;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static ProGrids.丙专专丆丆丒三下丏 丗丆丛丆丆丗丟一丑(UnityEngine.Vector3 且下丛丁丄不三丞与)
        {
            var val_2 = (且下丛丁丄不三丞与.x <= 0f) ? ((且下丛丁丄不三丞与.x < 0) ? 1 : 0) : (0 + 1);
            null = null;
            var val_4 = (且下丛丁丄不三丞与.y == 0f) ? (val_2) : (val_2 | 2);
            var val_5 = (且下丛丁丄不三丞与.y > _TYPE_MAX_) ? (val_2) : (val_4);
            var val_6 = val_5 | 4;
            val_4 = (且下丛丁丄不三丞与.z < 0) ? (val_6) : (val_5);
            return (ProGrids.丙专专丆丆丒三下丏)(且下丛丁丄不三丞与.z > 0f) ? (val_6) : (val_4);
        }
        private static ProGrids.丙专专丆丆丒三下丏 七丟上丂丙丟万且丟(UnityEngine.Vector3 且下丛丁丄不三丞与)
        {
            var val_2;
            float val_2 = System.Math.Abs(且下丛丁丄不三丞与.x);
            float val_3 = System.Math.Abs(且下丛丁丄不三丞与.y);
            float val_4 = System.Math.Abs(且下丛丁丄不三丞与.z);
            if((val_2 > val_3) && (val_2 > val_4))
            {
                    val_2 = 1;
                return (ProGrids.丙专专丆丆丒三下丏)(val_3 > val_4) ? 2 : (val_2);
            }
            
            val_2 = 4;
            if(val_3 <= val_2)
            {
                    return (ProGrids.丙专专丆丆丒三下丏)(val_3 > val_4) ? 2 : (val_2);
            }
            
            return (ProGrids.丙专专丆丆丒三下丏)(val_3 > val_4) ? 2 : (val_2);
        }
        public static ProGrids.丙专专丆丆丒三下丏 三东业丌丝且丄专专(UnityEngine.Vector3 下丞丟丄丛丁丁丏丙, UnityEngine.Camera 业丆丆东丂与万丅不)
        {
            var val_31;
            float val_32;
            float val_33;
            var val_34;
            var val_35;
            val_31 = 业丆丆东丂与万丅不;
            UnityEngine.Vector3 val_1 = ProGrids.丅丌三上丑丈丏专一.业丕东且丏一且丑且(且下丛丁丄不三丞与:  new UnityEngine.Vector3() {x = 下丞丟丄丛丁丁丏丙.x, y = 下丞丟丄丛丁丁丏丙.y, z = 下丞丟丄丛丁丁丏丙.z});
            val_32 = val_1.x;
            val_33 = val_1.z;
            val_1.x = val_32 + val_1.y;
            val_1.x = val_33 + val_1.x;
            if(val_1.x == 2f)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_32, y = val_1.y, z = val_33});
                return ProGrids.丅丌三上丑丈丏专一.丗丆丛丆丆丗丟一丑(且下丛丁丄不三丞与:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
            ProGrids.丙专专丆丆丒三下丏 val_4 = ProGrids.丅丌三上丑丈丏专一.丗丆丛丆丆丗丟一丑(且下丛丁丄不三丞与:  new UnityEngine.Vector3() {x = val_32, y = val_1.y, z = val_33});
            if(val_4 == 4)
            {
                goto label_10;
            }
            
            if(val_4 == 2)
            {
                goto label_11;
            }
            
            if(val_4 != 1)
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_6 = val_31.transform.forward;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            val_31 = val_31.transform;
            UnityEngine.Vector3 val_10 = val_31.forward;
            val_33 = val_10.x;
            val_32 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.forward;
            float val_32 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_33, y = val_10.y, z = val_32}, rhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}));
            var val_13 = ((System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}))) >= 0) ? 2 : 4;
            return (ProGrids.丙专专丆丆丒三下丏)val_34;
            label_10:
            UnityEngine.Vector3 val_15 = val_31.transform.forward;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.right;
            float val_33 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rhs:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}));
            val_31 = val_31.transform;
            UnityEngine.Vector3 val_19 = val_31.forward;
            val_33 = val_19.x;
            val_32 = val_19.z;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.up;
            float val_34 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_33, y = val_19.y, z = val_32}, rhs:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}));
            val_35 = 2;
            goto label_30;
            label_11:
            UnityEngine.Vector3 val_23 = val_31.transform.forward;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.right;
            val_31 = val_31.transform;
            UnityEngine.Vector3 val_27 = val_31.forward;
            val_33 = val_27.x;
            val_32 = val_27.z;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.forward;
            float val_36 = System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_33, y = val_27.y, z = val_32}, rhs:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}));
            val_35 = 4;
            label_30:
            var val_30 = ((System.Math.Abs(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, rhs:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}))) < 0) ? (val_35) : (0 + 1);
            return (ProGrids.丙专专丆丆丒三下丏)val_34;
            label_12:
            val_34 = 0;
            return (ProGrids.丙专专丆丆丒三下丏)val_34;
        }
        public static float 七丅与丝丟丆丙丌不(UnityEngine.Vector3 下下丏一丙不丘丌丞, UnityEngine.Vector3 丟世丟丐且丐丟七上)
        {
            if(System.Math.Abs(丟世丟丐且丐丟七上.x) <= 0.0001f)
            {
                    return (float)(System.Math.Abs(丟世丟丐且丐丟七上.y) > 0.0001f) ? 下下丏一丙不丘丌丞.y : 下下丏一丙不丘丌丞.z;
            }
            
            return (float)(System.Math.Abs(丟世丟丐且丐丟七上.y) > 0.0001f) ? 下下丏一丙不丘丌丞.y : 下下丏一丙不丘丌丞.z;
        }
        public static UnityEngine.Vector3 丅不丂世丄东丟三与(UnityEngine.Vector3 下下丏一丙不丘丌丞, float 丄丛丞丒丘上上丙且)
        {
            float val_1 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.x, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            float val_2 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.y, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            float val_3 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.z, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static System.Type 丞东三丕丛丘丑丕丟(string 丁丅丈丌丟世丗丗丟, string 世丏上丅丗且丌丑丂)
        {
            object val_14;
            System.Type val_15;
            System.Collections.Generic.IEnumerable<TSource> val_16;
            System.Type val_20;
            var val_21;
            var val_22;
            丅丌三上丑丈丏专一.丒丑万一丁丕东一丗 val_1 = null;
            val_14 = val_1;
            val_1 = new 丅丌三上丑丈丏专一.丒丑万一丁丕东一丗();
            .世丏上丅丗且丌丑丂 = 世丏上丅丗且丌丑丂;
            val_15 = System.Type.GetType(typeName:  丁丅丈丌丟世丗丗丟);
            if(val_15 == null)
            {
                    val_15 = System.Type.GetType(typeName:  丁丅丈丌丟世丗丗丟);
            }
            
            if((System.Type.op_Equality(left:  val_15, right:  0)) == false)
            {
                goto label_46;
            }
            
            val_16 = System.AppDomain.CurrentDomain.GetAssemblies();
            if((丅丌三上丑丈丏专一.丒丑万一丁丕东一丗)[1152921541420681568].世丏上丅丗且丌丑丂 != null)
            {
                    val_16 = System.Linq.Enumerable.Where<System.Reflection.Assembly>(source:  val_16, predicate:  new System.Func<System.Reflection.Assembly, System.Boolean>(object:  val_1, method:  System.Boolean 丅丌三上丑丈丏专一.丒丑万一丁丕东一丗::丅丏丝丐上三丛专下(System.Reflection.Assembly 三丟东丕丄丄下下丑)));
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_14 = val_16.GetEnumerator();
            label_27:
            var val_18 = 0;
            val_18 = val_18 + 1;
            if(val_14.MoveNext() == false)
            {
                goto label_18;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = val_14.Current;
            if((System.Type.op_Inequality(left:  val_20, right:  0)) == false)
            {
                goto label_27;
            }
            
            val_21 = 0;
            val_22 = 0;
            val_15 = val_20;
            if(val_14 != null)
            {
                goto label_30;
            }
            
            goto label_36;
            label_18:
            val_21 = 0;
            val_22 = 0;
            val_20 = 0;
            if(val_14 != null)
            {
                goto label_30;
            }
            
            goto label_36;
            label_30:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_14.Dispose();
            label_36:
            if( == 1)
            {
                goto label_41;
            }
            
            if(123 == 125)
            {
                    return (System.Type)val_20;
            }
            
            if( == false)
            {
                goto label_46;
            }
            
            if(123 != 123)
            {
                goto label_44;
            }
            
            goto label_46;
            label_41:
            if( == false)
            {
                goto label_46;
            }
            
            label_44:
            label_46:
            val_20 = ;
            return (System.Type)val_20;
        }
        public static void 丌丁丑丟丗东丈不东(bool 丆丛丆丞下丅丂且丝)
        {
            bool val_3 = 丆丛丆丞下丅丂且丝;
            if((ProGrids.丅丌三上丑丈丏专一.丞东三丕丛丘丑丕丟(丁丅丈丌丟世丗丗丟:  "UnityEditor.AnnotationUtility", 世丏上丅丗且丌丑丂:  0).GetProperty(name:  "showGrid", bindingAttr:  40)) != null)
            {
                    return;
            }
        
        }
        public static bool 丒上世丂万丟丞业专()
        {
            System.Reflection.PropertyInfo val_2 = ProGrids.丅丌三上丑丈丏专一.丞东三丕丛丘丑丕丟(丁丅丈丌丟世丗丗丟:  "UnityEditor.AnnotationUtility", 世丏上丅丗且丌丑丂:  0).GetProperty(name:  "showGrid", bindingAttr:  40);
            return (bool)(null != 0) ? 1 : 0;
        }
        public static UnityEngine.Vector3 丅不丂世丄东丟三与(UnityEngine.Vector3 下下丏一丙不丘丌丞, UnityEngine.Vector3 丟世丟丐且丐丟七上, float 丄丛丞丒丘上上丙且)
        {
            float val_4;
            float val_5;
            float val_6;
            val_4 = 下下丏一丙不丘丌丞.z;
            val_5 = 下下丏一丙不丘丌丞.y;
            val_6 = 下下丏一丙不丘丌丞.x;
            if(System.Math.Abs(丟世丟丐且丐丟七上.x) >= 0)
            {
                    val_6 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  val_6, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.y) >= 0)
            {
                    val_5 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  val_5, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.z) >= 0)
            {
                    val_4 = ProGrids.丅丌三上丑丈丏专一.业丅七丏丂丝三万且(下下丏一丙不丘丌丞:  val_4, 丟东丝专丒丒且不且:  丄丛丞丒丘上上丙且);
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Vector3 上丏丛专东丐丒丘七(UnityEngine.Vector3 下下丏一丙不丘丌丞, UnityEngine.Vector3 丟世丟丐且丐丟七上, float 丄丛丞丒丘上上丙且)
        {
            float val_4;
            float val_5;
            float val_6;
            val_4 = 下下丏一丙不丘丌丞.z;
            val_5 = 下下丏一丙不丘丌丞.y;
            val_6 = 下下丏一丙不丘丌丞.x;
            if(System.Math.Abs(丟世丟丐且丐丟七上.x) >= 0)
            {
                    val_6 = ProGrids.丅丌三上丑丈丏专一.上丏丛专东丐丒丘七(下下丏一丙不丘丌丞:  val_6, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.y) >= 0)
            {
                    val_5 = ProGrids.丅丌三上丑丈丏专一.上丏丛专东丐丒丘七(下下丏一丙不丘丌丞:  val_5, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.z) >= 0)
            {
                    val_4 = ProGrids.丅丌三上丑丈丏专一.上丏丛专东丐丒丘七(下下丏一丙不丘丌丞:  val_4, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Vector3 丑七丁丌业万丑不丞(UnityEngine.Vector3 下下丏一丙不丘丌丞, float 丄丛丞丒丘上上丙且)
        {
            float val_1 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.x, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            float val_2 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.y, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            float val_3 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  下下丏一丙不丘丌丞.z, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static UnityEngine.Vector3 丑七丁丌业万丑不丞(UnityEngine.Vector3 下下丏一丙不丘丌丞, UnityEngine.Vector3 丟世丟丐且丐丟七上, float 丄丛丞丒丘上上丙且)
        {
            float val_4;
            float val_5;
            float val_6;
            val_4 = 下下丏一丙不丘丌丞.z;
            val_5 = 下下丏一丙不丘丌丞.y;
            val_6 = 下下丏一丙不丘丌丞.x;
            if(System.Math.Abs(丟世丟丐且丐丟七上.x) >= 0)
            {
                    val_6 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  val_6, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.y) >= 0)
            {
                    val_5 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  val_5, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            if(System.Math.Abs(丟世丟丐且丐丟七上.z) >= 0)
            {
                    val_4 = ProGrids.丅丌三上丑丈丏专一.丑七丁丌业万丑不丞(下下丏一丙不丘丌丞:  val_4, 丄丛丞丒丘上上丙且:  丄丛丞丒丘上上丙且);
            }
            
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static float 业丅七丏丂丝三万且(float 下下丏一丙不丘丌丞, float 丟东丝专丒丒且不且)
        {
            var val_1;
            var val_2;
            float val_3;
            float val_2 = 下下丏一丙不丘丌丞;
            val_2 = val_2 / 丟东丝专丒丒且不且;
            if(val_2 >= 0f)
            {
                goto label_3;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_4;
            }
            
            val_2 = val_1;
            val_3 = -1f;
            goto label_5;
            label_3:
            if((double)val_2 != 0.5)
            {
                goto label_6;
            }
            
            val_2 = val_1;
            val_3 = 1f;
            label_5:
            float val_3 = (float)val_2;
            val_3 = val_3 + val_3;
            val_3 = (((long)val_2 & 1) != 0) ? (val_3) : (val_3);
            goto label_8;
            label_4:
            float val_4 = -0.5f;
            val_4 = val_2 + val_4;
            goto label_8;
            label_6:
            float val_5 = 0.5f;
            val_5 = val_2 + val_5;
            label_8:
            val_5 = val_5 * 丟东丝专丒丒且不且;
            return (float)val_5;
        }
        public static float 丑七丁丌业万丑不丞(float 下下丏一丙不丘丌丞, float 丄丛丞丒丘上上丙且)
        {
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 / 丄丛丞丒丘上上丙且;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 丄丛丞丒丘上上丙且;
            return (float)下下丏一丙不丘丌丞;
        }
        public static float 上丏丛专东丐丒丘七(float 下下丏一丙不丘丌丞, float 丄丛丞丒丘上上丙且)
        {
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 / 丄丛丞丒丘上上丙且;
            下下丏一丙不丘丌丞 = 下下丏一丙不丘丌丞 * 丄丛丞丒丘上上丙且;
            return (float)下下丏一丙不丘丌丞;
        }
        public static UnityEngine.Vector3 丞不上丆丁丅一丌丛(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            return new UnityEngine.Vector3() {x = (业下丌下三丕丙丌下.x < 0) ? -1f : 1f, y = (业下丌下三丕丙丌下.y < 0) ? -1f : 1f, z = (业下丌下三丕丙丌下.z < 0) ? -1f : 1f};
        }
        public static void 丌不七不丛丈万且丆()
        {
            null = null;
            ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆.Clear();
        }
        public static bool 下三下丌丝丗下不专(UnityEngine.Transform 丙丒七丄上与丏丙丙)
        {
            UnityEngine.Transform val_28;
            var val_29;
            UnityEngine.Transform val_30;
            var val_31;
            var val_32;
            var val_33;
            UnityEngine.Component val_34;
            var val_35;
            var val_36;
            System.Func<System.Object, System.Boolean> val_38;
            var val_39;
            bool val_40;
            var val_41;
            var val_42;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            UnityEngine.Transform val_48;
            UnityEngine.Transform val_49;
            var val_50;
            UnityEngine.Transform val_51;
            System.Collections.Generic.Dictionary<UnityEngine.Transform, 丒丌丌三上丙丞下丑> val_52;
            IntPtr val_54;
            var val_55;
            val_28 = 丙丒七丄上与丏丙丙;
            丒丌丌三上丙丞下丑 val_1 = 0;
            val_29 = null;
            val_29 = null;
            if((ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆.TryGetValue(key:  val_28, value: out  val_1)) == false)
            {
                goto label_4;
            }
            
            val_30 = val_1;
            val_31 = val_30;
            goto label_78;
            label_4:
            val_32 = 0;
            goto label_8;
            label_59:
            丅丌三上丑丈丏专一.丒丂万丒丂一上丞一 val_4 = new 丅丌三上丑丈丏专一.丒丂万丒丂一上丞一();
            .丁丂专业丁丅丅丈丙 = val_28.GetComponents<UnityEngine.MonoBehaviour>()[0];
            丅丌三上丑丈丏专一.上丞丌丘下丗丆七七 val_5 = new 丅丌三上丑丈丏专一.上丞丌丘下丗丆七七();
            if(val_5 != null)
            {
                    val_33 = val_5;
                .东丟且丗且三专丙丁 = val_4;
            }
            else
            {
                    mem[24] = val_4;
                val_33 = 24;
            }
            
            val_34 = .丁丂专业丁丅丅丈丙;
            if(val_34 == 0)
            {
                goto label_53;
            }
            
            val_35 = null;
            val_34 = .丁丂专业丁丅丅丈丙.GetType();
            val_35 = null;
            if((ProGrids.丅丌三上丑丈丏专一.丁丆丞丁业丛丅丗东.TryGetValue(key:  val_34, value: out  false)) != true)
            {
                    val_36 = null;
                val_36 = null;
                val_38 = 丅丌三上丑丈丏专一.<>c.<>9__26_0;
                if(val_38 == null)
            {
                    System.Func<System.Object, System.Boolean> val_10 = null;
                val_38 = val_10;
                val_10 = new System.Func<System.Object, System.Boolean>(object:  丅丌三上丑丈丏专一.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅丌三上丑丈丏专一.<>c::且万不专丈丑丐业万(object 三丟东丕丄丄下下丑));
                丅丌三上丑丈丏专一.<>c.<>9__26_0 = val_38;
            }
            
                val_39 = null;
                val_40 = System.Linq.Enumerable.Any<System.Object>(source:  val_34, predicate:  val_10);
                val_39 = null;
                val_40 = val_40;
                ProGrids.丅丌三上丑丈丏专一.丁丆丞丁业丛丅丗东.Add(key:  val_34, value:  (val_40 == true) ? 1 : 0);
            }
            
            if(val_40 == true)
            {
                goto label_33;
            }
            
            val_41 = null;
            val_41 = null;
            val_40 = ProGrids.丅丌三上丑丈丏专一.上丁丘丕丆万东丒丞;
            if((val_40.TryGetValue(key:  val_34, value: out  (丅丌三上丑丈丏专一.上丞丌丘下丗丆七七)[1152921541422288096].丞丟世丅世业丝丑丆)) == false)
            {
                goto label_38;
            }
            
            if((System.Reflection.MethodInfo.op_Inequality(left:  mem[(丅丌三上丑丈丏专一.上丞丌丘下丗丆七七)[1152921541422288096].丞丟世丅世业丝丑丆], right:  0)) == false)
            {
                goto label_53;
            }
            
            goto label_41;
            label_38:
            val_42 = null;
            val_42 = null;
            val_40 = 丅丌三上丑丈丏专一.<>c.<>9__26_2;
            if(val_40 == null)
            {
                    System.Func<System.Object, System.Boolean> val_16 = null;
                val_40 = val_16;
                val_16 = new System.Func<System.Object, System.Boolean>(object:  丅丌三上丑丈丏专一.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丅丌三上丑丈丏专一.<>c::且三丂丒丐业丞且丂(object 三丟东丕丄丄下下丑));
                丅丌三上丑丈丏专一.<>c.<>9__26_2 = val_40;
            }
            
            if((System.Linq.Enumerable.Any<System.Object>(source:  val_34, predicate:  val_16)) == false)
            {
                goto label_47;
            }
            
            val_40 = val_34.GetMethod(name:  "IsSnapEnabled", bindingAttr:  116);
            mem2[0] = val_40;
            val_44 = null;
            val_44 = null;
            val_40 = mem[(丅丌三上丑丈丏专一.上丞丌丘下丗丆七七)[1152921541422288096].丞丟世丅世业丝丑丆];
            ProGrids.丅丌三上丑丈丏专一.上丁丘丕丆万东丒丞.Add(key:  val_34, value:  val_40);
            if((System.Reflection.MethodInfo.op_Inequality(left:  mem[(丅丌三上丑丈丏专一.上丞丌丘下丗丆七七)[1152921541422288096].丞丟世丅世业丝丑丆], right:  0)) == false)
            {
                goto label_53;
            }
            
            goto label_54;
            label_47:
            val_45 = null;
            val_45 = null;
            ProGrids.丅丌三上丑丈丏专一.上丁丘丕丆万东丒丞.Add(key:  val_34, value:  0);
            label_53:
            val_32 = 1;
            label_8:
            if(val_32 < val_3.Length)
            {
                goto label_59;
            }
            
            val_46 = null;
            val_46 = null;
            val_30 = val_28;
            丅丌三上丑丈丏专一.丏丛上三上丛丁丁丒 val_20 = null;
            val_28 = val_20;
            val_20 = new 丅丌三上丑丈丏专一.丏丛上三上丛丁丁丒();
            .丒七东世东丆丕下丕 = true;
            val_47 = 1152921541422163488;
            val_48 = val_30;
            goto label_63;
            label_33:
            val_49 = val_28;
            val_30 = false;
            丅丌三上丑丈丏专一.丏丛上三上丛丁丁丒 val_21 = null;
            val_28 = val_21;
            val_21 = new 丅丌三上丑丈丏专一.丏丛上三上丛丁丁丒();
            .丒七东世东丆丕下丕 = val_30;
            val_47 = 1152921541422163488;
            val_48 = ;
            label_63:
            ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆.Add(key:  val_48, value:  val_21);
            val_31 = 1;
            label_78:
            val_31 = val_31 & 1;
            return (bool)val_31;
            label_41:
            val_50 = null;
            val_50 = null;
            val_51 = val_28;
            val_52 = ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆;
            val_54 = 1152921541422172704;
            goto label_70;
            label_54:
            val_55 = null;
            val_51 = val_28;
            val_52 = ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆;
            System.Func<System.Boolean> val_23 = null;
            val_54 = 1152921541422177824;
            label_70:
            val_23 = new System.Func<System.Boolean>(object:  val_5, method:  val_54);
            .七丐七丝世不丘三丕 = val_23;
            val_52.Add(key:  null, value:  new 丅丌三上丑丈丏专一.七七丞丆世丆不丒三());
            object val_25 = mem[(丅丌三上丑丈丏专一.上丞丌丘下丗丆七七)[1152921541422288096].丞丟世丅世业丝丑丆].Invoke(obj:  .丁丂专业丁丅丅丈丙, parameters:  0);
            var val_26 = (null != 0) ? 1 : 0;
            goto label_78;
        }
        private static 丅丌三上丑丈丏专一()
        {
            ProGrids.丅丌三上丑丈丏专一.不丑丅且丕丟东七丆 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, 丒丌丌三上丙丞下丑>();
            ProGrids.丅丌三上丑丈丏专一.丁丆丞丁业丛丅丗东 = new System.Collections.Generic.Dictionary<System.Type, System.Boolean>();
            ProGrids.丅丌三上丑丈丏专一.上丁丘丕丆万东丒丞 = new System.Collections.Generic.Dictionary<System.Type, System.Reflection.MethodInfo>();
        }
    
    }

}
