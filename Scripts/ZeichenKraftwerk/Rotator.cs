using UnityEngine;

namespace ZeichenKraftwerk
{
    public sealed class Rotator : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector3 eulersPerSecond;
        private UnityEngine.Transform 万东万丆专丌丕丐丗;
        
        // Methods
        public void Start()
        {
            this.万东万丆专丌丕丐丗 = this.transform;
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.eulersPerSecond, y = V9.16B, z = V10.16B}, d:  UnityEngine.Time.deltaTime);
            this.万东万丆专丌丕丐丗.Rotate(eulers:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public Rotator()
        {
            this.eulersPerSecond = 0;
            mem[1152921540738537008] = 0;
        }
    
    }

}
