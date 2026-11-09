using UnityEngine;
internal class TurnOnTurnOffRepeater : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject objectWhichInfluence;
    
    // Methods
    private void OnEnable()
    {
        if(this.objectWhichInfluence == 0)
        {
                return;
        }
        
        this.objectWhichInfluence.SetActive(value:  true);
    }
    private void OnDisable()
    {
        if(this.objectWhichInfluence == 0)
        {
                return;
        }
        
        this.objectWhichInfluence.SetActive(value:  false);
    }
    public TurnOnTurnOffRepeater()
    {
    
    }

}
