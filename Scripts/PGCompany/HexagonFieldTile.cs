using UnityEngine;

namespace PGCompany
{
    internal abstract class HexagonFieldTile : MonoBehaviour, 业业丌三丞丅世丐丞
    {
        // Fields
        private DiscreteVector2 <且三丑丒专丁丟三专>k__BackingField;
        private float <丌丕七与丑丐丛丛下>k__BackingField;
        
        // Properties
        public DiscreteVector2 丘丂不不下丕丁下丟 { get; set; }
        internal float 丁万丏丏丛丑且丂专 { get; set; }
        
        // Methods
        public DiscreteVector2 get_Position()
        {
            return new DiscreteVector2() {_x = this.<且三丑丒专丁丟三专>k__BackingField, _y = this.<且三丑丒专丁丟三专>k__BackingField};
        }
        private void 丕上丅与丌丈上丏丞(DiscreteVector2 丙业与丙丗丝不丈东)
        {
            this.<且三丑丒专丁丟三专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal float 且丞上下丝且丕业世()
        {
            return (float)this.<丌丕七与丑丐丛丛下>k__BackingField;
        }
        private void 丞丌业丙东丛丆三丒(float 丙业与丙丗丝不丈东)
        {
            this.<丌丕七与丑丐丛丛下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public virtual void Setup(DiscreteVector2 业丒丝丗与丐丛丟丏, float 上丘万且丁丏下丂与 = 0)
        {
            this.<且三丑丒专丁丟三专>k__BackingField = 业丒丝丗与丐丛丟丏;
            this.<丌丕七与丑丐丛丛下>k__BackingField = 上丘万且丁丏下丂与;
            this.gameObject.name = System.String.Format(format:  "tile-{0}", arg0:  业丒丝丗与丐丛丟丏);
        }
        public virtual void Kill()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
        }
        internal virtual void 丝下丝丏世丝丈下丅(UnityEngine.Transform 丈东丘丏与丌东东下, UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            if(this == 0)
            {
                    return;
            }
            
            this.transform.SetParent(p:  丈东丘丏与丌东东下);
            this.transform.localPosition = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        }
        protected HexagonFieldTile()
        {
        
        }
    
    }

}
