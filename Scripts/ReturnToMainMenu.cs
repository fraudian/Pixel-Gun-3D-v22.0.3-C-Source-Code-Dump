using UnityEngine;
public class ReturnToMainMenu : MonoBehaviour
{
    // Fields
    private bool 下东丅上丂下丅丗丟;
    
    // Methods
    public void Start()
    {
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ReturnToMainMenu::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void ReturnToMainMenu::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        this.下东丅上丂下丅丗丟 = true;
    }
    private void Update()
    {
        if(this.下东丅上丂下丅丗丟 == false)
        {
                return;
        }
        
        UnityEngine.Canvas val_2 = this.gameObject.GetComponent<UnityEngine.Canvas>();
        if(val_2 != null)
        {
                val_2.enabled = false;
        }
        else
        {
                0.enabled = false;
        }
        
        val_2.enabled = true;
        this.下东丅上丂下丅丗丟 = false;
    }
    public void GoBackToMainMenu()
    {
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "MainMenu");
    }
    public ReturnToMainMenu()
    {
    
    }

}
