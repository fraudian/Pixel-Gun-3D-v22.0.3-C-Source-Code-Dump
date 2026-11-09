using UnityEngine;

namespace Rilisoft
{
    internal sealed class 专七丞且丑丌丅丕丌 : 丙丐丐丙丈业丒不丁
    {
        // Methods
        protected override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁)
        {
            var val_10;
            var val_19;
            var val_25;
            var val_29;
            AGSGameDataMap val_30;
            var val_31;
            System.Func<System.String, System.Boolean> val_33;
            int val_34;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_35;
            Rilisoft.专七丞且丑丌丅丕丌 val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_46;
            var val_47;
            var val_49;
            var val_50;
            Rilisoft.专七丞且丑丌丅丕丌 val_51;
            var val_52;
            val_30 = 丟丝上三丙丁丁世丁.GetMap(name:  "progressMap");
            val_31 = null;
            val_31 = null;
            val_33 = 专七丞且丑丌丅丕丌.<>c.<>9__0_0;
            if(val_33 == null)
            {
                    val_33 = null;
                val_33 = new System.Func<System.String, System.Boolean>(object:  专七丞且丑丌丅丕丌.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 专七丞且丑丌丅丕丌.<>c::且世丅丘万东丐世丁(string 丟三下万一丄七一丗));
                专七丞且丑丌丅丕丌.<>c.<>9__0_0 = val_33;
                val_29 = -769565968;
            }
            
            System.Collections.Generic.HashSet<System.String> val_5 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Where<System.String>(source:  val_30.GetMapKeys(), predicate:  null));
            val_34 = null.Count;
            val_35 = null;
            val_35 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>>(capacity:  val_34);
            HashSet.Enumerator<T> val_8 = null.GetEnumerator();
            val_37 = 0;
            val_38 = 0;
            val_39 = 0;
            goto label_63;
            label_67:
            string val_11 = val_10.丐丏七丌丕丗业且上();
            val_34 = val_30.GetMap(name:  val_11);
            if(val_34 == null)
            {
                goto label_12;
            }
            
            System.Collections.Generic.HashSet<System.String> val_14 = new System.Collections.Generic.HashSet<System.String>(collection:  val_34.GetHighestNumberKeys());
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_16 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  null.Count);
            HashSet.Enumerator<T> val_17 = null.GetEnumerator();
            val_40 = -769565968;
            goto label_30;
            label_12:
            val_39 = 1;
            goto label_16;
            label_30:
            if(((-769565856) & 1) == 0)
            {
                goto label_18;
            }
            
            string val_20 = val_19.丐丏七丌丕丗业且上();
            AGSSyncableNumber val_21 = val_34.GetHighestNumber(name:  val_20);
            if(val_21 == null)
            {
                goto label_19;
            }
            
            null.set_Item(key:  val_20, value:  val_21.AsInt());
            val_41 = -769565968;
            val_42 = 1;
            var val_28 = 0;
            val_28 = val_28 + 1;
            goto label_24;
            label_19:
            val_42 = 1;
            goto label_25;
            label_24:
            val_21.Dispose();
            label_25:
            if((val_42 == 1) || (204 != 204))
            {
                goto label_27;
            }
            
            var val_29 = 0;
            val_29 = val_29 ^ 0;
            val_42 = val_42 + val_29;
            goto label_30;
            label_27:
            if(val_38 == 0)
            {
                goto label_30;
            }
            
            goto label_30;
            label_18:
            val_35 = val_35;
            val_46 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_46 == 1) || (229 != 229))
            {
                goto label_46;
            }
            
            var val_30 = 0;
            val_30 = val_30 ^ 0;
            val_46 = val_46 + val_30;
            if( != 0)
            {
                goto label_54;
            }
            
            goto label_51;
            label_46:
            if( == 0)
            {
                goto label_49;
            }
            
            val_37 = 0;
            val_47 = 0;
            if( != 0)
            {
                goto label_54;
            }
            
            goto label_51;
            label_49:
            val_37 = 0;
            if( != 0)
            {
                goto label_54;
            }
            
            label_51:
            label_54:
            null.set_Item(key:  val_11, value:  null);
            val_30 = val_30;
            val_39 = val_46 + 1;
            mem2[0] = 253;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_34.Dispose();
            label_16:
            if((val_39 != 1) && ((val_29 + ((val_46 + 1)) << 2) == 253))
            {
                    var val_32 = 0;
                val_32 = val_32 ^ (val_39 >> 31);
                val_39 = val_39 + val_32;
                val_38 = ;
            }
            else
            {
                    val_37 = 0;
                val_38 = 0;
                if( != 0)
            {
                    val_37 = 0;
                val_38 = 0;
            }
            
            }
            
            label_63:
            if(((-769565824) & 1) != 0)
            {
                goto label_67;
            }
            
            val_49 = val_39 + 1;
            mem2[0] = 281;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (val_25 == 281))
            {
                    val_51 = this;
                var val_33 = 0;
                val_33 = val_33 ^ 0;
                val_49 =  + val_33;
            }
            else
            {
                    val_51 = this;
                if( != 0)
            {
                    val_37 = 0;
                val_38 = 0;
            }
            else
            {
                    val_37 = 0;
            }
            
            }
            
            this.丄丈上一丙且万丅丞(丙业与丙丗丝不丈东:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  null));
            this.丞专世丗丛不丘丗丘(丙业与丙丗丝不丈东:  true);
            val_50 =  + 1;
            mem2[0] = 314;
            if( != 0)
            {
                goto label_87;
            }
            
            goto label_93;
            label_87:
            var val_36 = ;
            if((val_1 + 286) == 0)
            {
                goto label_97;
            }
            
            var val_34 = val_1 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_96:
            if(((val_1 + 176 + 8) + -8) == null)
            {
                goto label_95;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (val_1 + 286))
            {
                goto label_96;
            }
            
            goto label_97;
            label_95:
            val_36 = val_36 + (((val_1 + 176 + 8)) << 4);
            val_52 = val_36 + 296;
            label_97:
            Dispose();
            label_93:
            if(val_50 != 1)
            {
                    if((this == null) || ((val_29 + ((val_50 + 1)) << 2) == 314))
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
                return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            if(this != null)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
        }
        protected override void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄)
        {
            var val_6;
            var val_13;
            var val_20;
            var val_23;
            var val_24;
            AGSGameDataMap val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            string val_22 = 一丐丗丁丞丆丅丟丄;
            val_24 = 丟丝上三丙丁丁世丁;
            if(val_22 == null)
            {
                    return;
            }
            
            object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_22);
            if(val_1 == null)
            {
                    return;
            }
            
            val_22 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
            val_25 = val_24.GetMap(name:  "progressMap");
            Dictionary.Enumerator<TKey, TValue> val_3 = val_22.GetEnumerator();
            val_24 = 1152921516595684768;
            val_26 = 0;
            val_27 = 0;
            val_28 = 0;
            goto label_61;
            label_64:
            ConfiguredValueTaskAwaiter val_7 = val_6.GetAwaiter();
            val_29;
            if(val_7._value._obj == 0)
            {
                goto label_61;
            }
            
            AGSGameDataMap val_9 = val_25.GetMap(name:  val_7._value._obj.丐丏七丌丕丗业且上());
            Dictionary.Enumerator<TKey, TValue> val_10 = val_7._value._obj.GetEnumerator();
            label_29:
            if(((-769355504) & 1) == 0)
            {
                goto label_15;
            }
            
            ConfiguredValueTaskAwaiter val_14 = val_13.GetAwaiter();
            AGSSyncableNumber val_17 = val_9.GetHighestNumber(name:  val_14._value._obj.丐丏七丌丕丗业且上());
            val_17.Set(val:  System.Convert.ToInt32(value:  val_14._value._obj));
            val_30 = val_27;
            if(val_17 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_17.Dispose();
            }
            
            if((1 == 1) || (169 != 169))
            {
                goto label_26;
            }
            
            goto label_29;
            label_26:
            if(val_30 == 0)
            {
                goto label_29;
            }
            
            goto label_29;
            label_15:
            val_25 = val_25;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(2 == 1)
            {
                goto label_41;
            }
            
            if( != 0)
            {
                    if(206 != 206)
            {
                goto label_43;
            }
            
            }
            
            val_29 = ;
            if(val_9 != null)
            {
                goto label_50;
            }
            
            goto label_52;
            label_41:
            if( == 0)
            {
                goto label_49;
            }
            
            label_43:
            val_26 = 0;
            val_29 = 0;
            if(val_9 != null)
            {
                goto label_50;
            }
            
            goto label_52;
            label_49:
            val_26 = 0;
            val_29 = 0;
            if(val_9 == null)
            {
                goto label_52;
            }
            
            label_50:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_9.Dispose();
            label_52:
            val_28 = 0;
            if((val_28 != 1) && (val_20 == 206))
            {
                    val_28 = 0;
                val_27 = val_29;
            }
            else
            {
                    val_26 = 0;
                val_27 = 0;
                if(val_29 != 0)
            {
                    val_26 = 0;
                val_27 = 0;
            }
            
            }
            
            label_61:
            if(((-769355440) & 1) != 0)
            {
                goto label_64;
            }
            
            val_23 = val_28 + 1;
            mem2[0] = 244;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_73;
            }
            
            if( == 0)
            {
                goto label_76;
            }
            
            if(val_20 != 244)
            {
                goto label_75;
            }
            
            goto label_76;
            label_73:
            if( == 0)
            {
                goto label_77;
            }
            
            label_75:
            val_26 = 0;
            val_27 = 0;
            if(val_25 != null)
            {
                goto label_80;
            }
            
            goto label_84;
            label_77:
            val_26 = 0;
            val_23 = 0;
            if(val_25 != null)
            {
                goto label_80;
            }
            
            goto label_84;
            label_76:
            if(val_25 == null)
            {
                goto label_84;
            }
            
            label_80:
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_25.Dispose();
            label_84:
            if(val_23 != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(val_20 == 244)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        public 专七丞且丑丌丅丕丌()
        {
        
        }
    
    }

}
