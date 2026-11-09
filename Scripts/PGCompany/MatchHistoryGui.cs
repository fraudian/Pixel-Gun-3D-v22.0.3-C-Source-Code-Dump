using UnityEngine;

namespace PGCompany
{
    public sealed class MatchHistoryGui : PGBehaviour
    {
        // Fields
        private UnityEngine.GameObject _matchViewExample;
        private UIScrollView _scrollView;
        private System.Collections.Generic.List<UnityEngine.GameObject> 业丕丄丏丏与与且丙;
        
        // Methods
        private void OnEnable()
        {
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丁丞一丗丈与丅世丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MatchHistoryGui::下专专专业上丒丟七()));
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丝丛丄一三丒世三丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MatchHistoryGui::丄东丛一世七不万业()));
            this.丁专且丞且七七丌丝();
            this.一丁万丂七上万丄业();
            this.丒丛丕一丗丁三丒丂();
            this.业东不丘丟丏丛丙七();
            this._scrollView.ResetPosition();
        }
        private void 一丁万丂七上万丄业()
        {
            var val_3;
            System.Collections.Generic.List<UnityEngine.GameObject> val_12;
            float val_13;
            val_12 = this.业丕丄丏丏与与且丙;
            List.Enumerator<T> val_1 = val_12.GetEnumerator();
            val_13 = 0f;
            goto label_6;
            label_13:
            val_12 = val_3.丐丏七丌丕丗业且上().GetComponent<PGCompany.MatchHistoryView>();
            if(val_12 != 0)
            {
                    float val_7 = val_12.丙丞丏丏三丙丙业丁();
                val_5.viewWidget.height = (int)val_7;
                val_12 = val_12.transform;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  val_13);
                val_12.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                val_13 = val_13 + (val_7 + 12f);
            }
            
            label_6:
            if(((-385398224) & 1) != 0)
            {
                goto label_13;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 丒丛丕一丗丁三丒丂()
        {
            var val_6;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            var val_20;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_22;
            var val_23;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_25;
            var val_26;
            System.Func<专丛业丅丕丅丅丅丄, System.String> val_28;
            System.Collections.Generic.List<System.String> val_3 = null;
            val_19 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_4 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丌且且三丂丐下东丑().GetEnumerator();
            label_23:
            if(((-385202224) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            val_20 = null;
            val_20 = null;
            val_22 = MatchHistoryGui.<>c.<>9__5_0;
            if(val_22 == null)
            {
                    val_22 = null;
                val_22 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryGui.<>c::东丏丁与世丗丈东丑(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__5_0 = val_22;
            }
            
            if((System.Linq.Enumerable.Any<专丛业丅丕丅丅丅丄>(source:  val_7.丈丟丂丐一丕七东丗(), predicate:  null)) == false)
            {
                goto label_23;
            }
            
            val_23 = null;
            val_23 = null;
            val_25 = MatchHistoryGui.<>c.<>9__5_1;
            if(val_25 == null)
            {
                    val_25 = null;
                val_25 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryGui.<>c::丌丞丑专丒丅上与丟(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__5_1 = val_25;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = MatchHistoryGui.<>c.<>9__5_2;
            if(val_28 == null)
            {
                    val_28 = null;
                val_28 = new System.Func<专丛业丅丕丅丅丅丄, System.String>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.String MatchHistoryGui.<>c::下七一丌丕丛专一丝(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__5_2 = val_28;
            }
            
            val_3.AddRange(collection:  System.Linq.Enumerable.Select<专丛业丅丕丅丅丅丄, System.String>(source:  System.Linq.Enumerable.Where<专丛业丅丕丅丅丅丄>(source:  val_7.丈丟丂丐一丕七东丗(), predicate:  null), selector:  null));
            goto label_23;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3.Count < 1)
            {
                    return;
            }
            
            val_19 = System.Linq.Enumerable.Distinct<System.String>(source:  val_3);
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丒丛丕一丗丁三丒丂(丁丟丌专三上丐丕丙:  val_19);
        }
        private void 业东不丘丟丏丛丙七()
        {
            var val_6;
            System.Collections.Generic.IEnumerable<TSource> val_19;
            var val_20;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_22;
            var val_23;
            System.Func<专丛业丅丕丅丅丅丄, System.Boolean> val_25;
            var val_26;
            System.Func<专丛业丅丕丅丅丅丄, System.String> val_28;
            System.Collections.Generic.List<System.String> val_3 = null;
            val_19 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>();
            List.Enumerator<T> val_4 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丌且且三丂丐下东丑().GetEnumerator();
            label_23:
            if(((-384980656) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            val_20 = null;
            val_20 = null;
            val_22 = MatchHistoryGui.<>c.<>9__6_0;
            if(val_22 == null)
            {
                    val_22 = null;
                val_22 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryGui.<>c::丑丙下丐丅丌东丄一(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__6_0 = val_22;
            }
            
            if((System.Linq.Enumerable.Any<专丛业丅丕丅丅丅丄>(source:  val_7.丈丟丂丐一丕七东丗(), predicate:  null)) == false)
            {
                goto label_23;
            }
            
            val_23 = null;
            val_23 = null;
            val_25 = MatchHistoryGui.<>c.<>9__6_1;
            if(val_25 == null)
            {
                    val_25 = null;
                val_25 = new System.Func<专丛业丅丕丅丅丅丄, System.Boolean>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean MatchHistoryGui.<>c::丕丝丛丂业业丈丐丝(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__6_1 = val_25;
            }
            
            val_26 = null;
            val_26 = null;
            val_28 = MatchHistoryGui.<>c.<>9__6_2;
            if(val_28 == null)
            {
                    val_28 = null;
                val_28 = new System.Func<专丛业丅丕丅丅丅丄, System.String>(object:  MatchHistoryGui.<>c.__il2cppRuntimeField_static_fields, method:  System.String MatchHistoryGui.<>c::丅丕丘丂丆丘丌丁丏(Progress.丝下丛万丐丙且七丌.专丛业丅丕丅丅丅丄 三丟东丕丄丄下下丑));
                MatchHistoryGui.<>c.<>9__6_2 = val_28;
            }
            
            val_3.AddRange(collection:  System.Linq.Enumerable.Select<专丛业丅丕丅丅丅丄, System.String>(source:  System.Linq.Enumerable.Where<专丛业丅丕丅丅丅丄>(source:  val_7.丈丟丂丐一丕七东丗(), predicate:  null), selector:  null));
            goto label_23;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_3.Count < 1)
            {
                    return;
            }
            
            val_19 = System.Linq.Enumerable.Distinct<System.String>(source:  val_3);
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().业东不丘丟丏丛丙七(丁丟丌专三上丐丕丙:  val_19);
        }
        private void OnDisable()
        {
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().下丄专且丟上丏丘不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MatchHistoryGui::下专专专业上丒丟七()));
            PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丄东丝万东丛丞丒丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MatchHistoryGui::丄东丛一世七不万业()));
        }
        private void Start()
        {
            this.一丁万丂七上万丄业();
            this._scrollView.ResetPosition();
        }
        private void Awake()
        {
            this.丝丟东七丑丂丅业丒();
        }
        private void 丁专且丞且七七丌丝()
        {
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌> val_2 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丌且且三丂丐下东丑();
            val_12 = 0;
            goto label_2;
            label_22:
            UnityEngine.GameObject val_3 = this.业丕丄丏丏与与且丙.Item[0];
            if(val_2.Count <= val_12)
            {
                goto label_5;
            }
            
            if(val_2 == null)
            {
                goto label_6;
            }
            
            val_13 = val_2.Count;
            goto label_7;
            label_5:
            val_14 = null;
            goto label_20;
            label_6:
            val_13 = val_2.Count;
            label_7:
            Progress.丝下丛万丐丙且七丌 val_8 = val_2.Item[val_13 + 0];
            val_14 = null;
            if(val_8 == null)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            PGCompany.MatchHistoryView val_9 = val_3.GetComponent<PGCompany.MatchHistoryView>();
            if(val_9 == 0)
            {
                goto label_18;
            }
            
            val_9.一丞一丝丘丕且丒丆(与丛丙一丙丆丁七业:  val_8);
            goto label_18;
            label_10:
            label_20:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
            label_18:
            val_12 = 1;
            label_2:
            if(val_12 < this.业丕丄丏丏与与且丙.Count)
            {
                goto label_22;
            }
        
        }
        private void 丝丟东七丑丂丅业丒()
        {
            不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._scrollView.transform);
            this.业丕丄丏丏与与且丙 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._matchViewExample, 丏业丟一东丂东丘丛:  false);
            do
            {
                this.业丕丄丏丏与与且丙.Add(item:  丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._matchViewExample, 丈东丘丏与丌东东下:  this._scrollView.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}));
            }
            while((10 - 1) != 0);
            
            this._scrollView.ResetPosition();
        }
        private void 下专专专业上丒丟七()
        {
            this.丁专且丞且七七丌丝();
        }
        private void 丄东丛一世七不万业()
        {
            this.三丛下丄且且与丝丈();
        }
        private void 三丛下丄且且与丝丈()
        {
            var val_9;
            System.Collections.Generic.List<Progress.丝下丛万丐丙且七丌> val_2 = PGCompany.一丆丏专不丙上丟业.丑七不且上丗丁一世().丌且且三丂丐下东丑();
            val_9 = 0;
            goto label_2;
            label_14:
            if(this.业丕丄丏丏与与且丙.Item[0] != 0)
            {
                    PGCompany.MatchHistoryView val_6 = this.业丕丄丏丏与与且丙.Item[0].GetComponent<PGCompany.MatchHistoryView>();
                if(val_6 != 0)
            {
                    val_6.与丌上世丞丛丄丒丛();
            }
            
            }
            
            val_9 = 1;
            label_2:
            if(val_9 < this.业丕丄丏丏与与且丙.Count)
            {
                goto label_14;
            }
        
        }
        public MatchHistoryGui()
        {
        
        }
    
    }

}
