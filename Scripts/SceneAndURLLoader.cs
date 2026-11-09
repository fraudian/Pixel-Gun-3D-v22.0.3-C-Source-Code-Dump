using UnityEngine;
public class SceneAndURLLoader : MonoBehaviour
{
    // Fields
    private PauseMenu 丈丂七万一东丌与七;
    
    // Methods
    private void Awake()
    {
        this.丈丂七万一东丌与七 = this.GetComponentInChildren<PauseMenu>();
    }
    public void SceneLoad(string 专万丟三世业丙丈且)
    {
        this.丈丂七万一东丌与七.MenuOff();
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  专万丟三世业丙丈且);
    }
    public void LoadURL(string 七丙不丅丛丘丗万与)
    {
        UnityEngine.Application.OpenURL(url:  七丙不丅丛丘丗万与);
    }
    public SceneAndURLLoader()
    {
    
    }

}
