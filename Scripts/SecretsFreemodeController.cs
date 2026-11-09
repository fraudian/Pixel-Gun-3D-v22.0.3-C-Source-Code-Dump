using UnityEngine;
internal sealed class SecretsFreemodeController : PGBehaviour
{
    // Fields
    public FreemodeSecretPoint[] secretPoints;
    internal static SecretsFreemodeController 丆丕丝丒不丙且丐丗;
    
    // Methods
    private void Awake()
    {
        SecretsFreemodeController.丆丕丝丒不丙且丐丗 = this;
    }
    private void Start()
    {
        FreemodeSecretPoint val_2;
        var val_3;
        val_2 = this;
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.丈东丄丑丟世下丑丛();
        val_3 = 0;
        goto label_1;
        label_5:
        val_2 = this.secretPoints[0];
        val_2.SetStatusByIndex();
        val_3 = 1;
        label_1:
        if(val_3 < this.secretPoints.Length)
        {
            goto label_5;
        }
    
    }
    private void Update()
    {
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                return;
        }
        
        this.丈东丄丑丟世下丑丛();
    }
    private void 丈东丄丑丟世下丑丛()
    {
        FreemodeSecretPoint[] val_5;
        short val_6;
        val_5 = this.gameObject.transform.GetComponentsInChildren<FreemodeSecretPoint>();
        val_6 = 0;
        this.secretPoints = val_5;
        goto label_3;
        label_8:
        FreemodeSecretPoint val_4 = this.secretPoints[0];
        this.secretPoints[0x0][0].丞世不丒下上上丝丑 = val_6;
        val_5 = this.secretPoints;
        val_6 = W22 + 1;
        label_3:
        if(((int)val_6 & 65535) < this.secretPoints.Length)
        {
            goto label_8;
        }
    
    }
    internal int 业上一七丘丏丝下丈()
    {
        if(this.secretPoints == null)
        {
                return 0;
        }
        
        return (int)this.secretPoints.Length;
    }
    public int GetCurrentSecretCount()
    {
        var val_7;
        var val_8;
        if(this.secretPoints == null)
        {
            goto label_1;
        }
        
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        val_7 = 0;
        val_8 = 0;
        goto label_2;
        label_9:
        val_8 = val_8 + (Progress.七七世万专丕丁上业.丞丛丟且丞丌丞丌且().不丆专丅丗且丑不世(丅东与业丒一业万丅:  0, 七丆丂丂下丈且丟世:  val_1.m_Handle.name, 上且丗一丏丏万丅丌:  GameConnect.丑丌丛丈丅丅与不业()));
        val_7 = 1;
        label_2:
        if(val_7 < this.secretPoints.Length)
        {
            goto label_9;
        }
        
        return (int)val_8;
        label_1:
        val_8 = 0;
        return (int)val_8;
    }
    public SecretsFreemodeController()
    {
    
    }

}
