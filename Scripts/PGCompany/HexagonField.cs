using UnityEngine;

namespace PGCompany
{
    internal class HexagonField : MonoBehaviour
    {
        // Fields
        private System.Action<DiscreteVector2> 丆丟与丕万万三丌上;
        private System.Action<DiscreteVector2> 东不丛七丛丑丗世下;
        private System.Action<DiscreteVector2> 东丑丁且丅丟丌与丙;
        private readonly System.Collections.Generic.Dictionary<DiscreteVector2, PGCompany.HexagonFieldTile> 万丂不下业丗下丛世;
        private float _tileSize;
        
        // Properties
        internal float 丗不东不丘丟丌丑丝 { get; }
        
        // Methods
        internal void 上丑不且东三丘丝东(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丆丟与丕万万三丌上, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆丟与丕万万三丌上 != 1152921553911344376);
        
        }
        internal void 丌丆丆三丑丌丘三丛(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丆丟与丕万万三丌上, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丆丟与丕万万三丌上 != 1152921553911480952);
        
        }
        internal void 丈世丑丂万上丂丄上(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.东不丛七丛丑丗世下, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东不丛七丛丑丗世下 != 1152921553911617536);
        
        }
        internal void 不丘丗东丐东丝丞丅(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.东不丛七丛丑丗世下, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东不丛七丛丑丗世下 != 1152921553911754112);
        
        }
        internal void 一丑一丄丅七三丂一(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.东丑丁且丅丟丌与丙, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丑丁且丅丟丌与丙 != 1152921553911890696);
        
        }
        internal void 业丂与丄丟丌丝世一(System.Action<DiscreteVector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.东丑丁且丅丟丌与丙, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.东丑丁且丅丟丌与丙 != 1152921553912027272);
        
        }
        internal float 东七万不丅丆与丂丌()
        {
            return (float)this._tileSize;
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.HexagonFieldTile> 万业丏三上不丟丝丑)
        {
            if(this == 0)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<DiscreteVector2, PGCompany.HexagonFieldTile>>(source:  this.万丂不下业丗下丛世)) != false)
            {
                    this.世业丒万丘丆专丘丐();
            }
            
            List.Enumerator<T> val_3 = 万业丏三上不丟丝丑.GetEnumerator();
            label_12:
            if((2060790776 & 1) == 0)
            {
                goto label_6;
            }
            
            string val_4 = 0.丐丏七丌丕丗业且上();
            if(val_4 == 0)
            {
                goto label_12;
            }
            
            UnityEngine.Vector3 val_6 = 丝丙一上业丁且丄不.与一丅丙丛丈下万丌(丗丒且世丆专丄三专:  new DiscreteVector2(), 丒丆一丄丛丒且万七:  1f, 上丘万且丁丏下丂与:  0f);
            UnityEngine.Transform val_7 = this.transform;
            this.万丂不下业丗下丛世.Add(key:  new DiscreteVector2() {_x = X22, _y = X22}, value:  val_4);
            goto label_12;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 世业丒万丘丆专丘丐()
        {
            if(this == 0)
            {
                    return;
            }
            
            if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<DiscreteVector2, PGCompany.HexagonFieldTile>>(source:  this.万丂不下业丗下丛世)) == false)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.万丂不下业丗下丛世.GetEnumerator();
            label_8:
            if((2060941720 & 1) == 0)
            {
                goto label_6;
            }
            
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            if(val_4._value._obj != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this = this.万丂不下业丗下丛世;
            this.Clear();
        }
        internal void 世丌丞丁万东丒丛与(PGCompany.HexagonFieldTile 丝丝丕丐丘业三丅丕)
        {
            if(this == 0)
            {
                    return;
            }
            
            if(丝丝丕丐丘业三丅丕 == 0)
            {
                    return;
            }
            
            PGCompany.HexagonFieldTile val_3 = this.丒丅下丗万与世且业(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField});
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            if(val_3 == 丝丝丕丐丘业三丅丕)
            {
                goto label_13;
            }
            
            this.丛丑且丁丁丆一丏不(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = val_3.<且三丑丒专丁丟三专>k__BackingField, _y = val_3.<且三丑丒专丁丟三专>k__BackingField});
            this.丄丞丗丁丏丐丟专丐(丝丝丕丐丘业三丅丕:  丝丝丕丐丘业三丅丕);
            if(this.丆丟与丕万万三丌上 == null)
            {
                    return;
            }
            
            this.丆丟与丕万万三丌上.Invoke(obj:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField});
            return;
            label_10:
            this.丄丞丗丁丏丐丟专丐(丝丝丕丐丘业三丅丕:  丝丝丕丐丘业三丅丕);
            return;
            label_13:
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Vector3 val_7 = 丝丙一上业丁且丄不.与一丅丙丛丈下万丌(丗丒且世丆专丄三专:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField}, 丒丆一丄丛丒且万七:  this._tileSize, 上丘万且丁丏下丂与:  0f);
            goto typeof(PGCompany.HexagonFieldTile).__il2cppRuntimeField_198;
        }
        internal void 丄丞丗丁丏丐丟专丐(PGCompany.HexagonFieldTile 丝丝丕丐丘业三丅丕)
        {
            if(this == 0)
            {
                    return;
            }
            
            if(丝丝丕丐丘业三丅丕 == 0)
            {
                    return;
            }
            
            if((this.万丗丛下与上与一七(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField})) == true)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = this.transform;
            UnityEngine.Vector3 val_5 = 丝丙一上业丁且丄不.与一丅丙丛丈下万丌(丗丒且世丆专丄三专:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField}, 丒丆一丄丛丒且万七:  this._tileSize, 上丘万且丁丏下丂与:  0f);
            1152921504848912384 = this.万丂不下业丗下丛世;
            1152921504848912384.Add(key:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField}, value:  丝丝丕丐丘业三丅丕);
            if(this.东不丛七丛丑丗世下 == null)
            {
                    return;
            }
            
            this.东不丛七丛丑丗世下.Invoke(obj:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField});
        }
        internal void 丛丑且丁丁丆一丏不(DiscreteVector2 业丒丝丗与丐丛丟丏)
        {
            if(this == 0)
            {
                    return;
            }
            
            if((this.丒丅下丗万与世且业(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y})) == 0)
            {
                    return;
            }
            
            bool val_4 = this.万丂不下业丗下丛世.Remove(key:  new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y});
            if(this.东丑丁且丅丟丌与丙 == null)
            {
                    return;
            }
            
            this.东丑丁且丅丟丌与丙.Invoke(obj:  new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y});
        }
        internal bool 万丗丛下与上与一七(DiscreteVector2 业丒丝丗与丐丛丟丏)
        {
            if((this.万丂不下业丗下丛世.ContainsKey(key:  new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y})) == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  this.万丂不下业丗下丛世.Item[new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y}], y:  0);
        }
        internal PGCompany.HexagonFieldTile 丒丅下丗万与世且业(DiscreteVector2 业丒丝丗与丐丛丟丏)
        {
            var val_3;
            if((this.万丂不下业丗下丛世.ContainsKey(key:  new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y})) != false)
            {
                    PGCompany.HexagonFieldTile val_2 = this.万丂不下业丗下丛世.Item[new DiscreteVector2() {_x = 业丒丝丗与丐丛丟丏._x, _y = 业丒丝丗与丐丛丟丏._y}];
                return (PGCompany.HexagonFieldTile)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.HexagonFieldTile)val_3;
        }
        internal System.Collections.Generic.List<PGCompany.HexagonFieldTile> 且丑丏三丛七不丆丏(System.Collections.Generic.List<DiscreteVector2> 丅丁万丂三上且不三)
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.HexagonFieldTile> val_2 = new System.Collections.Generic.List<PGCompany.HexagonFieldTile>(capacity:  丅丁万丂三上且不三.Count);
            List.Enumerator<T> val_3 = 丅丁万丂三上且不三.GetEnumerator();
            label_8:
            if((2061787792 & 1) == 0)
            {
                goto label_3;
            }
            
            PGCompany.HexagonFieldTile val_7 = this.丒丅下丗万与世且业(业丒丝丗与丐丛丟丏:  new DiscreteVector2() {_x = val_5.丐丏七丌丕丗业且上(), _y = val_5.丐丏七丌丕丗业且上()});
            if(val_7 == 0)
            {
                goto label_8;
            }
            
            val_2.Add(item:  val_7);
            goto label_8;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_2;
        }
        internal System.Collections.Generic.List<PGCompany.HexagonFieldTile> 丅丛丂丁丙丂丝丟三(PGCompany.HexagonFieldTile 丝丝丕丐丘业三丅丕, int 且丛上丕业丂丒与一)
        {
            return this.且丑丏三丛七不丆丏(丅丁万丂三上且不三:  丝丙一上业丁且丄不.业丗丕丌丏丁丗丁万(下业丕七东丌丝下且:  new DiscreteVector2() {_x = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField, _y = 丝丝丕丐丘业三丅丕.<且三丑丒专丁丟三专>k__BackingField}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一));
        }
        internal bool 丄丗下上丑丅丆丒丂(PGCompany.HexagonFieldTile 丆丛丑世下一丐且丕, PGCompany.HexagonFieldTile 丌丗丏丏丛东专丁且, int 且丛上丕业丂丒与一 = 1)
        {
            System.Collections.Generic.List<PGCompany.HexagonFieldTile> val_1 = this.丅丛丂丁丙丂丝丟三(丝丝丕丐丘业三丅丕:  丆丛丑世下一丐且丕, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一);
            if(val_1 != null)
            {
                    return val_1.Contains(item:  丌丗丏丏丛东专丁且);
            }
            
            return val_1.Contains(item:  丌丗丏丏丛东专丁且);
        }
        public HexagonField()
        {
            this.万丂不下业丗下丛世 = new System.Collections.Generic.Dictionary<DiscreteVector2, PGCompany.HexagonFieldTile>();
            this._tileSize = 1f;
        }
    
    }

}
