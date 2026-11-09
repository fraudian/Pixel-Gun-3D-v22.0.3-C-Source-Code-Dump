using UnityEngine;
public class LevelReset : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
    // Methods
    public void OnPointerClick(UnityEngine.EventSystems.PointerEventData 一丐丗丁丞丆丅丟丄)
    {
        UnityEngine.AsyncOperation val_3 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丘与与丁丏世丟丙丑(专万丟三世业丙丈且:  UnityEngine.Application.loadedLevelName, 丂丛丑东不丅丈一东:  0);
    }
    private void Update()
    {
    
    }
    public LevelReset()
    {
    
    }

}
