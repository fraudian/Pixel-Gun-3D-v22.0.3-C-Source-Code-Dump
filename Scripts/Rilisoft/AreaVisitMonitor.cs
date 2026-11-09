using UnityEngine;

namespace Rilisoft
{
    public class AreaVisitMonitor : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.AreaBase> _activeAreas;
        private UnityEngine.Vector3 丙丘且丗丑丅丁东三;
        private UnityEngine.Transform 专三丞丑丞一丗丆丞;
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        
        // Properties
        private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_15;
            UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
            if(val_1 != 0)
            {
                    val_15 = this.丌丟丄业且三丛丕丄().parent;
                this.专三丞丑丞一丗丆丞 = val_15;
                if(val_15 != 0)
            {
                    UnityEngine.Vector3 val_7 = this.丌丟丄业且三丛丕丄().position;
                val_15 = this.专三丞丑丞一丗丆丞;
                UnityEngine.Vector3 val_8 = val_15.position;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                this.丙丘且丗丑丅丁东三 = val_9;
                mem[1152921542325335828] = val_9.y;
                mem[1152921542325335832] = val_9.z;
            }
            
                if(val_1.isTrigger != false)
            {
                    return;
            }
            
                object[] val_11 = new object[1];
                val_11[0] = this.gameObject.name;
                UnityEngine.Debug.LogWarningFormat(format:  "[AREA SYSTEM] collider now is trigger go:\'{0}\'", args:  val_11);
                val_1.isTrigger = true;
                return;
            }
            
            System.Exception val_14 = new System.Exception(message:  "Collider not found");
        }
        private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
        {
            var val_6;
            Rilisoft.AreaBase val_7;
            var val_8;
            val_6 = this;
            Rilisoft.AreaBase val_2 = 0;
            Initializer val_1 = Initializer.丑七不且上丗丁一世();
            if((val_1.丏丗丙丞丛世丞七七.TryGetValue(key:  丘丛丏丘丝七世七丅, value: out  val_2)) == false)
            {
                    return;
            }
            
            val_7 = val_2;
            val_8 = null;
            val_8 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_668 != 0)
            {
                    return;
            }
            
            val_7 = val_2;
            this._activeAreas.Add(item:  val_7);
            val_6 = this.gameObject;
        }
        private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
        {
            var val_8;
            Rilisoft.AreaBase val_9;
            var val_10;
            var val_11;
            val_8 = this;
            Rilisoft.AreaBase val_2 = 0;
            Initializer val_1 = Initializer.丑七不且上丗丁一世();
            if((val_1.丏丗丙丞丛世丞七七.TryGetValue(key:  丘丛丏丘丝七世七丅, value: out  val_2)) == false)
            {
                    return;
            }
            
            val_9 = val_2;
            val_10 = null;
            val_10 = null;
            if(typeof(Player_move_c).__il2cppRuntimeField_668 != 0)
            {
                    return;
            }
            
            val_9 = val_2;
            val_11 = public System.Boolean System.Collections.Generic.List<Rilisoft.AreaBase>::Contains(Rilisoft.AreaBase item);
            if((this._activeAreas.Contains(item:  val_9)) != false)
            {
                    val_11 = public System.Boolean System.Collections.Generic.List<Rilisoft.AreaBase>::Remove(Rilisoft.AreaBase item);
                bool val_6 = this._activeAreas.Remove(item:  val_2);
            }
            
            val_8 = this.gameObject;
        }
        private void OnDisable()
        {
            this._activeAreas.ForEach(action:  new System.Action<Rilisoft.AreaBase>(object:  this, method:  System.Void Rilisoft.AreaVisitMonitor::丑世三一丞与丝丈丗(Rilisoft.AreaBase 丆丛丑世下一丐且丕)));
            this._activeAreas.Clear();
        }
        private void LateUpdate()
        {
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.丌丟丄业且三丛丕丄().rotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
            if(this.专三丞丑丞一丗丆丞 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.专三丞丑丞一丗丆丞.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.丙丘且丗丑丅丁东三, y = val_2.w, z = val_2.z});
            this.丌丟丄业且三丛丕丄().position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        private UnityEngine.Transform 丌丟丄业且三丛丕丄()
        {
            UnityEngine.Transform val_3;
            if(this.专专丏下丐丂丂丅东 == 0)
            {
                    this.专专丏下丐丂丂丅东 = this.transform;
                return val_3;
            }
            
            val_3 = this.专专丏下丐丂丂丅东;
            return val_3;
        }
        public AreaVisitMonitor()
        {
            this._activeAreas = new System.Collections.Generic.List<Rilisoft.AreaBase>();
        }
        private void 丑世三一丞与丝丈丗(Rilisoft.AreaBase 丆丛丑世下一丐且丕)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(丆丛丑世下一丐且丕 == null)
            {
                
            }
        
        }
    
    }

}
