using UnityEngine;

namespace Rilisoft
{
    public class TargetPositionMonitor : MonoBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.Vector3> 丌丄丟丂丆丑下丐世;
        private float 丆世丈丁世丘丄丒且;
        private int 业丒世丕丅万一三丟;
        private float <丑丆丐世丟丄丝丅丈>k__BackingField;
        private float <丅上丞丒丛丘丁丒丆>k__BackingField;
        private bool <丛丌且业丆丑丗丘丄>k__BackingField;
        private System.Func<UnityEngine.Vector3> <丕且万丂丌专不丏丗>k__BackingField;
        
        // Properties
        public float 丙丗七丐丑丏丑丐丆 { get; set; }
        public float 丗上万东丛与丙丄不 { get; set; }
        public bool 三不专丗七丄且丝业 { get; set; }
        public System.Func<UnityEngine.Vector3> 上丅丅丑七丝一丐不 { get; set; }
        
        // Methods
        public float get_MinDistance()
        {
            return (float)this.<丑丆丐世丟丄丝丅丈>k__BackingField;
        }
        private void 丟东专丂丘丆上且丐(float 丙业与丙丗丝不丈东)
        {
            this.<丑丆丐世丟丄丝丅丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float get_CheckInterval()
        {
            return (float)this.<丅上丞丒丛丘丁丒丆>k__BackingField;
        }
        private void 丅丈丐丐丟丅万业丆(float 丙业与丙丗丝不丈东)
        {
            this.<丅上丞丒丛丘丁丒丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_Enabled()
        {
            return (bool)this.<丛丌且业丆丑丗丘丄>k__BackingField;
        }
        private void 丏丐丝上三丁丞丝丕(bool 丙业与丙丗丝不丈东)
        {
            this.<丛丌且业丆丑丗丘丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Func<UnityEngine.Vector3> get_TargetPositionGetter()
        {
            return (System.Func<UnityEngine.Vector3>)this.<丕且万丂丌专不丏丗>k__BackingField;
        }
        private void 业东丌专世丙下一丞(System.Func<UnityEngine.Vector3> 丙业与丙丗丝不丈东)
        {
            this.<丕且万丂丌专不丏丗>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void StartMonitoring(System.Func<UnityEngine.Vector3> 专与且世丟且丕丙东, float 丁七三丛丐丛丌东万 = 0.1, float 丕上丅下与一丕丟且 = 0.1)
        {
            float val_2;
            bool val_3;
            val_2 = 丕上丅下与一丕丟且;
            this.<丕且万丂丌专不丏丗>k__BackingField = 0;
            this.丌丄丟丂丆丑下丐世.Clear();
            this.丆世丈丁世丘丄丒且 = 0f;
            this.业丒世丕丅万一三丟 = 0;
            if(专与且世丟且丕丙东 != null)
            {
                    this.<丕且万丂丌专不丏丗>k__BackingField = 专与且世丟且丕丙东;
                this.<丑丆丐世丟丄丝丅丈>k__BackingField = 丁七三丛丐丛丌东万;
                this.<丅上丞丒丛丘丁丒丆>k__BackingField = val_2;
                UnityEngine.Vector3 val_1 = 专与且世丟且丕丙东.Invoke();
                val_2 = val_1.x;
                this.丌丄丟丂丆丑下丐世.Add(item:  new UnityEngine.Vector3() {x = val_2, y = val_1.y, z = val_1.z});
                val_3 = 1;
            }
            else
            {
                    val_3 = false;
            }
            
            this.<丛丌且业丆丑丗丘丄>k__BackingField = val_3;
        }
        public void Reset()
        {
            if((this.<丛丌且业丆丑丗丘丄>k__BackingField) == false)
            {
                    return;
            }
            
            this.丌丄丟丂丆丑下丐世.Clear();
            this.丆世丈丁世丘丄丒且 = 0f;
            this.业丒世丕丅万一三丟 = 0;
            UnityEngine.Vector3 val_1 = this.<丕且万丂丌专不丏丗>k__BackingField.Invoke();
            this.丌丄丟丂丆丑下丐世.Add(item:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
        public void StopMonitoring()
        {
            this.丌丄丟丂丆丑下丐世.Clear();
            this.<丛丌且业丆丑丗丘丄>k__BackingField = false;
        }
        public bool HasNextPoint()
        {
            return (bool)((this.丌丄丟丂丆丑下丐世.Count - 1) > this.业丒世丕丅万一三丟) ? 1 : 0;
        }
        public UnityEngine.Vector3 GetCurrentPoint()
        {
            if(this.丌丄丟丂丆丑下丐世 != null)
            {
                    return this.丌丄丟丂丆丑下丐世.Item[this.业丒世丕丅万一三丟];
            }
            
            return this.丌丄丟丂丆丑下丐世.Item[this.业丒世丕丅万一三丟];
        }
        public UnityEngine.Vector3 GetNextPoint()
        {
            int val_1 = this.业丒世丕丅万一三丟 + 1;
            this.业丒世丕丅万一三丟 = val_1;
            if(this.丌丄丟丂丆丑下丐世 != null)
            {
                    return this.丌丄丟丂丆丑下丐世.Item[val_1];
            }
            
            return this.丌丄丟丂丆丑下丐世.Item[val_1];
        }
        private void Update()
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_9;
            float val_10;
            var val_11;
            float val_12;
            val_9 = this;
            if((this.<丛丌且业丆丑丗丘丄>k__BackingField) == false)
            {
                    return;
            }
            
            if((this.<丕且万丂丌专不丏丗>k__BackingField) == null)
            {
                    return;
            }
            
            val_10 = this.丆世丈丁世丘丄丒且;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_10 + val_1;
            this.丆世丈丁世丘丄丒且 = val_1;
            if(val_1 < 0)
            {
                    return;
            }
            
            this.丆世丈丁世丘丄丒且 = 0f;
            if(this.丌丄丟丂丆丑下丐世 != null)
            {
                    val_11 = this.丌丄丟丂丆丑下丐世.Count;
            }
            else
            {
                    val_11 = 0.Count;
            }
            
            UnityEngine.Vector3 val_5 = this.丌丄丟丂丆丑下丐世.Item[val_11 - 1];
            val_12 = val_5.z;
            UnityEngine.Vector3 val_6 = this.<丕且万丂丌专不丏丗>k__BackingField.Invoke();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_12}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_10 = val_7.x;
            float val_10 = this.<丑丆丐世丟丄丝丅丈>k__BackingField;
            val_10 = val_10 + val_10;
            if(System.Math.Abs(val_10) < val_10)
            {
                    return;
            }
            
            val_9 = this.丌丄丟丂丆丑下丐世;
            UnityEngine.Vector3 val_8 = this.<丕且万丂丌专不丏丗>k__BackingField.Invoke();
            val_10 = val_8.x;
            val_12 = val_8.z;
            val_9.Add(item:  new UnityEngine.Vector3() {x = val_10, y = val_8.y, z = val_12});
        }
        public TargetPositionMonitor()
        {
            this.丌丄丟丂丆丑下丐世 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
