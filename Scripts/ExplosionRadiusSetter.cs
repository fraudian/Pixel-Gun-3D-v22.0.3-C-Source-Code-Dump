using UnityEngine;
internal class ExplosionRadiusSetter : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform transformToScale;
    
    // Methods
    private void Awake()
    {
        if(this.transformToScale != 0)
        {
                return;
        }
        
        this.transformToScale = this.transform;
    }
    internal void 丅业上东丆丛世万丄(float 且丛上丕业丂丒与一)
    {
        this.transformToScale.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ExplosionRadiusSetter()
    {
    
    }

}
