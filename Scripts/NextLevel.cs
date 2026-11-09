using UnityEngine;
internal sealed class NextLevel : MonoBehaviour
{
    // Fields
    public bool isLastLevel;
    public string nextSceneName;
    
    // Methods
    private void OnClick()
    {
    
    }
    public NextLevel()
    {
        this.nextSceneName = "";
    }

}
