using UnityEngine;
[Serializable]
internal sealed class StorageExplanation : MonoBehaviour
{
    // Fields
    private static StorageExplanation s_firstInstance;
    private System.IDisposable _backSubscription;
    private UnityEngine.GameObject _continueButton;
    private System.Action _continueCallback;
    private UnityEngine.GameObject _window;
    
    // Properties
    internal static StorageExplanation Instance { get; }
    
    // Methods
    internal static StorageExplanation get_Instance()
    {
        return (StorageExplanation)StorageExplanation.s_firstInstance;
    }
    public void SetContinueCallback(System.Action 丁世丏丁丁且丌丞万)
    {
        this._continueCallback = 丁世丏丁丁且丌丞万;
    }
    public void SetVisibiliity(bool 丗丞丑丌丂东丑丅丙)
    {
        if(this._window != 0)
        {
                this._window.SetActive(value:  丗丞丑丌丂东丑丅丙);
        }
        
        if(this._backSubscription != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this._backSubscription.Dispose();
            this._backSubscription = 0;
        }
        
        if(丗丞丑丌丂东丑丅丙 == false)
        {
                return;
        }
        
        this._backSubscription = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void StorageExplanation::HandleQuit()), 与且专丈不万东一万:  0);
    }
    public void HandleQuit()
    {
        this.SetVisibiliity(丗丞丑丌丂东丑丅丙:  false);
        if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                return;
        }
        
        PGCompany.七丞丝丏业丞丂丆上.一丐丛专下丞七丌万();
    }
    public void HandleContinue()
    {
        this.SetVisibiliity(丗丞丑丌丂东丑丅丙:  false);
        if(this._continueCallback != null)
        {
                this._continueCallback.Invoke();
        }
        
        this._continueCallback = 0;
    }
    private void Awake()
    {
        if(StorageExplanation.s_firstInstance != 0)
        {
                return;
        }
        
        StorageExplanation.s_firstInstance = this;
    }
    public StorageExplanation()
    {
    
    }

}
