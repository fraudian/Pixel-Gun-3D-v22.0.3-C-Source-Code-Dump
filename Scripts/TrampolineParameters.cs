using UnityEngine;
public class TrampolineParameters : MonoBehaviour
{
    // Fields
    public float force;
    public float decaySpeed;
    
    // Methods
    public TrampolineParameters()
    {
        this.force = 45f;
        this.decaySpeed = 2f;
    }

}
