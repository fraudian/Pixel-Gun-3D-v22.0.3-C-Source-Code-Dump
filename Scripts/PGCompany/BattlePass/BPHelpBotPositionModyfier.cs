using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPHelpBotPositionModyfier : PGBehaviour
    {
        // Fields
        private float _modelPositionMultipler;
        private UnityEngine.Vector3 丞丕世且不丕万丟世;
        
        // Methods
        private void Start()
        {
            UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().localPosition;
            this.丞丕世且不丕万丟世 = val_2;
            mem[1152921560129826224] = val_2.y;
            mem[1152921560129826228] = val_2.z;
        }
        private void Update()
        {
            float val_9 = -1.333333f;
            float val_8 = (float)UnityEngine.Screen.width;
            val_8 = val_8 / (float)UnityEngine.Screen.height;
            val_9 = val_8 + val_9;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.left;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this._modelPositionMultipler * val_9);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.丞丕世且不丕万丟世, y = V10.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public BPHelpBotPositionModyfier()
        {
            this._modelPositionMultipler = 2f;
        }
    
    }

}
