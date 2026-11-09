using UnityEngine;
public class UIButtonCloseMap : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        if((UnityEngine.Object.op_Implicit(exists:  UIWorldMap.instance)) == false)
        {
                return;
        }
        
        if(UIWorldMap.instance == null)
        {
            
        }
    
    }
    public UIButtonCloseMap()
    {
    
    }

}
