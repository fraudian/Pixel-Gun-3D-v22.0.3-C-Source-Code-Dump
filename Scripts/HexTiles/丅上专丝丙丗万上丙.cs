using UnityEngine;

namespace HexTiles
{
    public static class 丅上专丝丙丗万上丙
    {
        // Fields
        private static readonly float 丑不丑上丈丁专七业;
        private static readonly float 丄丁世丞丏丟丕丘上;
        
        // Methods
        private static UnityEngine.Vector2 丑丙丈世不且一丕丟(HexTiles.HexCoords 丁东且丘丂丁丝下丘)
        {
            var val_4;
            float val_5;
            int val_6;
            val_4 = null;
            val_4 = null;
            val_5 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            if(丁东且丘丂丁丝下丘 == null)
            {
                    val_5 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            }
            
            val_6 = 丁东且丘丂丁丝下丘.Q;
            float val_6 = 0.5f;
            float val_4 = 3f;
            float val_5 = (float);
            val_4 = (HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业 * val_6) * val_4;
            float val_2 = val_5 * val_6;
            val_5 = val_5 * val_6;
            val_6 = val_4 * val_6;
            val_2 = val_2 * 1.732051f;
            val_5 = val_5 + (float)丁东且丘丂丁丝下丘.R;
            val_5 = val_2 * val_5;
            val_6 = val_6 * (float)丁东且丘丂丁丝下丘.Q;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_6, y:  val_5);
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        internal static HexTiles.丅上专丝丙丗万上丙.专业万不丟丝一丞七 万丁丂下下丈丙丘丑(HexTiles.HexCoords 业丒丝丗与丐丛丟丏, float 丟丏东下丄丑丈万丟, System.Collections.Generic.IEnumerable<HexTiles.SidePiece> 丙世丁丈上丟丒丛丆)
        {
            专业万不丟丝一丞七 val_0;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            HexTiles.丅上专丝丙丗万上丙.东专丐丒七丗丄丏世(业丒丝丗与丐丛丟丏:  业丒丝丗与丐丛丟丏, 丐业丕东丈丑丐丝丞:  val_1, 且东丟丐丈丅丆专三:  val_2, 丌丌丁专与东丌丗且:  val_3, 丟丏东下丄丑丈万丟:  丟丏东下丄丑丈万丟);
            HexTiles.丅上专丝丙丗万上丙.三七七丄三丞丑丒不(丐业丕东丈丑丐丝丞:  val_1, 且东丟丐丈丅丆专三:  val_2, 丌丌丁专与东丌丗且:  val_3, 丙世丁丈上丟丒丛丆:  丙世丁丈上丟丒丛丆, 丟丏东下丄丑丈万丟:  丟丏东下丄丑丈万丟);
            val_0.丗丞不丞业丑七且丗 = val_1;
            val_0.丐丌上与丈七丝丅丐 = val_2;
            val_0.丂丙丆丂丑丝丂丝丒 = val_3;
            return val_0;
        }
        private static void 东专丐丒七丗丄丏世(HexTiles.HexCoords 业丒丝丗与丐丛丟丏, System.Collections.Generic.List<UnityEngine.Vector3> 丐业丕东丈丑丐丝丞, System.Collections.Generic.List<int> 且东丟丐丈丅丆专三, System.Collections.Generic.List<UnityEngine.Vector2> 丌丌丁专与东丌丗且, float 丟丏东下丄丑丈万丟)
        {
            float val_21;
            var val_22;
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            var val_28;
            float val_29;
            float val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            UnityEngine.Vector2 val_1 = HexTiles.丅上专丝丙丗万上丙.丑丙丈世不且一丕丟(丁东且丘丂丁丝下丘:  业丒丝丗与丐丛丟丏);
            丐业丕东丈丑丐丝丞.AddRange(collection:  HexTiles.下丈上丆七丅丑与丗.丟下丘丆不丏丁丒万(丟丒且一专丟丙下一:  丟丏东下丄丑丈万丟));
            UnityEngine.Vector2 val_3 = 业丒丝丗与丐丛丟丏.与丙丏专世丗不丂丞();
            val_21 = val_3.y;
            if((val_3.x != 0f) || (val_21 != 0f))
            {
                goto label_8;
            }
            
            val_22 = 1152921516216385664;
            UnityEngine.Vector3 val_4 = 丐业丕东丈丑丐丝丞.Item[0];
            if(丐业丕东丈丑丐丝丞 == null)
            {
                goto label_10;
            }
            
            val_23 = val_4.x;
            val_24 = val_4.y;
            val_25 = val_4.z;
            丐业丕东丈丑丐丝丞.Insert(index:  4, item:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            goto label_11;
            label_8:
            且东丟丐丈丅丆专三.AddRange(collection:  new int[12] {0, 1, 2, 0, 2, 3, 0, 3, 5, 5, 3, 4});
            val_22 = 1152921516216385664;
            float val_20 = 1f;
            val_26 = 0;
            val_20 = val_21 + val_20;
            goto label_13;
            label_33:
            UnityEngine.Vector3 val_6 = 丐业丕东丈丑丐丝丞.Item[0];
            val_27 = null;
            val_27 = null;
            val_21 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            if(val_3.x != 0f)
            {
                goto label_17;
            }
            
            label_25:
            if(val_3.x != 0f)
            {
                goto label_18;
            }
            
            label_27:
            val_28 = null;
            val_21 = (val_6.z / 丟丏东下丄丑丈万丟) * val_21;
            val_28 = null;
            float val_21 = val_1.y;
            float val_22 = HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗;
            val_21 = val_21 + val_21;
            val_22 = val_21 / val_22;
            val_22 = val_22 * 0.5f;
            val_29 = val_22 + 0.5f;
            val_30 = -val_29;
            if(丐业丕东丈丑丐丝丞 != null)
            {
                goto label_28;
            }
            
            goto label_22;
            label_17:
            val_29 = val_20;
            if((-1) > 1)
            {
                goto label_25;
            }
            
            val_30 = -0.5f;
            if(val_29 == 0f)
            {
                goto label_24;
            }
            
            goto label_25;
            label_18:
            val_29 = val_21;
            if(0 != 4)
            {
                goto label_27;
            }
            
            val_30 = 0f;
            if(val_29 != 0f)
            {
                goto label_27;
            }
            
            label_24:
            if(丐业丕东丈丑丐丝丞 != null)
            {
                goto label_28;
            }
            
            label_22:
            label_28:
            UnityEngine.Vector3 val_8 = 丐业丕东丈丑丐丝丞.Item[0];
            val_31 = null;
            val_31 = null;
            float val_23 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            val_23 = (val_8.x / 丟丏东下丄丑丈万丟) * val_23;
            val_23 = val_1.x + val_23;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  -val_23, y:  val_30);
            丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            val_26 = 1;
            label_13:
            if(val_26 < 丐业丕东丈丑丐丝丞.Count)
            {
                goto label_33;
            }
            
            return;
            label_10:
            val_23 = val_4.x;
            val_24 = val_4.y;
            val_25 = val_4.z;
            0.Insert(index:  4, item:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25});
            label_11:
            UnityEngine.Vector3 val_12 = 丐业丕东丈丑丐丝丞.Item[3];
            val_30 = val_12.y;
            丐业丕东丈丑丐丝丞.Insert(index:  5, item:  new UnityEngine.Vector3() {x = val_12.x, y = val_30, z = val_12.z});
            且东丟丐丈丅丆专三.AddRange(collection:  new int[12] {0, 1, 2, 0, 2, 3, 4, 5, 7, 7, 5, 6});
            val_26 = 0;
            goto label_49;
            label_53:
            if(val_26 < 6)
            {
                    if((0 & 1) != 0)
            {
                goto label_39;
            }
            
            }
            
            UnityEngine.Vector3 val_14 = 丐业丕东丈丑丐丝丞.Item[0];
            val_32 = null;
            val_32 = null;
            val_33 = null;
            val_21 = (val_14.z / 丟丏东下丄丑丈万丟) * HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            val_33 = null;
            float val_24 = val_1.y;
            float val_25 = HexTiles.下丈上丆七丅丑与丗.丘丁世上丘丝丛丁丗;
            val_24 = val_24 + val_21;
            val_25 = val_24 / val_25;
            val_25 = val_25 * 0.5f;
            val_25 = val_25 + 0.5f;
            val_30 = -val_25;
            if(丐业丕东丈丑丐丝丞 != null)
            {
                goto label_50;
            }
            
            label_51:
            label_50:
            UnityEngine.Vector3 val_16 = 丐业丕东丈丑丐丝丞.Item[0];
            val_34 = null;
            val_34 = null;
            float val_26 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
            val_26 = (val_16.x / 丟丏东下丄丑丈万丟) * val_26;
            val_26 = val_1.x + val_26;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  -val_26, y:  val_30);
            丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            val_26 = 1;
            goto label_49;
            label_39:
            if(丐业丕东丈丑丐丝丞 != null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_49:
            if(val_26 < 丐业丕东丈丑丐丝丞.Count)
            {
                goto label_53;
            }
        
        }
        private static void 三七七丄三丞丑丒不(System.Collections.Generic.List<UnityEngine.Vector3> 丐业丕东丈丑丐丝丞, System.Collections.Generic.List<int> 且东丟丐丈丅丆专三, System.Collections.Generic.List<UnityEngine.Vector2> 丌丌丁专与东丌丗且, System.Collections.Generic.IEnumerable<HexTiles.SidePiece> 丙世丁丈上丟丒丛丆, float 丟丏东下丄丑丈万丟)
        {
            var val_34;
            var val_36;
            var val_37;
            var val_38;
            int val_40;
            var val_41;
            var val_47;
            var val_48;
            float val_38 = 丟丏东下丄丑丈万丟;
            val_34 = 且东丟丐丈丅丆专三;
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<UnityEngine.Vector3>(source:  HexTiles.下丈上丆七丅丑与丗.丟下丘丆不丏丁丒万(丟丒且一专丟丙下一:  val_38));
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_36 = 1152921504686346240;
            val_37 = 1152921504838422528;
            float val_5 = val_38 * 0.5f;
            val_38 = 丙世丁丈上丟丒丛丆.GetEnumerator();
            val_38 = val_5 * 3f;
            goto label_8;
            label_59:
            var val_39 = 0;
            val_39 = val_39 + 1;
            T val_7 = val_38.Current;
            T val_8 = val_7 >> 32;
            T val_9 = val_7 + 1;
            val_8 = val_8 >> 32;
            val_8 = val_8 + (val_8 >> 63);
            val_8 = val_9 - (val_8 * 6);
            do
            {
                float val_11 = val_38 * 0f;
                val_5 = val_8 - val_11;
                float val_42 = UnityEngine.Mathf.Min(a:  val_38, b:  val_5);
                int val_13 = 丐业丕东丈丑丐丝丞.Count;
                UnityEngine.Vector3 val_14 = val_2.Item[val_7];
                UnityEngine.Vector3 val_15 = val_2.Item[val_7];
                float val_40 = -val_11;
                丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_16 = val_2.Item[val_8];
                UnityEngine.Vector3 val_17 = val_2.Item[val_8];
                丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_18 = val_2.Item[val_7];
                UnityEngine.Vector3 val_19 = val_2.Item[val_7];
                val_40 = val_40 - val_42;
                丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_20 = val_2.Item[val_8];
                UnityEngine.Vector3 val_21 = val_2.Item[val_8];
                丐业丕东丈丑丐丝丞.Add(item:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                int[] val_22 = new int[6];
                val_40 = val_22.Length;
                if(val_40 == 0)
            {
                    val_40 = val_22.Length;
            }
            
                val_22[0] = val_13;
                if(val_40 <= 1)
            {
                    val_40 = val_22.Length;
            }
            
                int val_23 = val_13 + 2;
                val_22[0] = val_23;
                if(val_40 <= 2)
            {
                    val_40 = val_22.Length;
            }
            
                int val_24 = val_13 + 1;
                val_22[1] = val_24;
                if(val_40 <= 3)
            {
                    val_40 = val_22.Length;
            }
            
                val_22[1] = val_24;
                val_34 = val_34;
                val_36 = val_36;
                val_38 = val_38;
                if(val_40 <= 4)
            {
                    val_40 = val_22.Length;
            }
            
                val_22[2] = val_23;
                int val_41 = val_13;
                val_41 = val_41 + 3;
                val_22[2] = val_41;
                val_34.AddRange(collection:  val_22);
                val_41 = null;
                val_37 = 1152921504838422528;
                val_41 = null;
                val_37 = 1152921504838422528;
                float val_25 = val_42 / val_38;
                val_25 = val_25 * (-0.25f);
                val_42 = HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上 + val_25;
                if(0 != 0)
            {
                    float val_43 = HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上;
                HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields = HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields * 0.5f;
                HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields = HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields * (float)val_7;
                val_43 = val_43 + (-0.25f);
                UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields, y:  val_43);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
                float val_44 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                float val_45 = HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上;
                val_44 = val_44 * 0.5f;
                val_44 = val_44 * (float)val_9;
                val_45 = val_45 + (-0.25f);
                UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  val_44, y:  val_45);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y});
                val_42 = val_42 + (-0.25f);
                float val_46 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                val_46 = val_46 * 0.5f;
                val_46 = val_46 * (float)val_7;
                UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_46, y:  val_42);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y});
                float val_47 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                val_47 = val_47 * 0.5f;
                val_47 = val_47 * (float)val_9;
                UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_47, y:  val_42);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_29.x, y = val_29.y});
            }
            else
            {
                    HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields = HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields * 0.5f;
                HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields = HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields * (float)val_7;
                UnityEngine.Vector2 val_30 = new UnityEngine.Vector2(x:  HexTiles.丅上专丝丙丗万上丙.__il2cppRuntimeField_static_fields, y:  HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_30.x, y = val_30.y});
                float val_48 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                val_48 = val_48 * 0.5f;
                val_48 = val_48 * (float)val_9;
                UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_48, y:  HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y});
                float val_49 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                val_49 = val_49 * 0.5f;
                val_49 = val_49 * (float)val_7;
                UnityEngine.Vector2 val_32 = new UnityEngine.Vector2(x:  val_49, y:  val_42);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
                float val_50 = HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业;
                val_50 = val_50 * 0.5f;
                val_50 = val_50 * (float)val_9;
                UnityEngine.Vector2 val_33 = new UnityEngine.Vector2(x:  val_50, y:  val_42);
                丌丌丁专与东丌丗且.Add(item:  new UnityEngine.Vector2() {x = val_33.x, y = val_33.y});
            }
            
                var val_51 = 0;
                val_51 = val_51 + 1;
                float val_52 = (float)val_51;
                val_52 = val_38 * val_52;
            }
            while(val_52 < 0);
            
            label_8:
            var val_53 = 0;
            val_53 = val_53 + 1;
            if(val_38.MoveNext() == true)
            {
                goto label_59;
            }
            
            val_47 = 0;
            val_48 = 0;
            if(val_38 == null)
            {
                
            }
            else
            {
                    var val_54 = 0;
                val_54 = val_54 + 1;
                val_38.Dispose();
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
        private static 丅上专丝丙丗万上丙()
        {
            HexTiles.丅上专丝丙丗万上丙.丑不丑上丈丁专七业 = 0.3333333f;
            HexTiles.丅上专丝丙丗万上丙.丄丁世丞丏丟丕丘上 = 0.5f;
        }
    
    }

}
