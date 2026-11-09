using UnityEngine;
public class UIButtonGenerate : MonoBehaviour
{
    // Methods
    private void OnClick()
    {
        NJGMap.instance.GenerateMap();
    }
    public UIButtonGenerate()
    {
    
    }

}
