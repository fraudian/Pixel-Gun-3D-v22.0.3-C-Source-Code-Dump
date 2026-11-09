using UnityEngine;
internal sealed class FreemodeSecretPoint : PGBehaviour
{
    // Fields
    internal short 丞世不丒下上上丝丑;
    private FreemodeSecret mySecret;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    public void SetIndex(short 七丞丙丒三丕且丌丟)
    {
        this.丞世不丒下上上丝丑 = 七丞丙丒三丕且丌丟;
    }
    public void SetStatusByIndex()
    {
        FreemodeSecret val_6;
        var val_7;
        val_6 = this;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((Progress.七七世万专丕丁上业.丞丛丟且丞丌丞丌且().不丆专丅丗且丑不世(丅东与业丒一业万丅:  this.丞世不丒下上上丝丑, 七丆丂丂下丈且丟世:  val_2.m_Handle.name, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业())) != true)
        {
                val_7 = null;
            val_7 = null;
            if(GameConnect.丛丑世丕丌上丑丂丈 == false)
        {
                return;
        }
        
        }
        
        val_6 = this.mySecret;
        val_6.SetInactive();
    }
    public FreemodeSecretPoint()
    {
    
    }

}
