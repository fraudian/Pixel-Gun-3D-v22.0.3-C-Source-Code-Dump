using UnityEngine;
public class UIButtonToggleMap : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        UIMiniMap.instance.ToggleWorldMap();
    }
    public UIButtonToggleMap()
    {
    
    }

}
