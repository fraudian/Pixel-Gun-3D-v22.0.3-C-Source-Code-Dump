using UnityEngine;
public class RayAndExplosionsStackItem : MonoBehaviour
{
    // Fields
    public string myName;
    public float timeDeactivate;
    private bool 丞丈丕丒丁丒丒专丞;
    private UnityEngine.AudioSource 丌丕丛丂一丈丙丟丏;
    private FreezerRay 丙七且丛丒七一丅不;
    
    // Methods
    private void Awake()
    {
        this.丙七且丛丒七一丅不 = this.GetComponent<FreezerRay>();
        this.丌丕丛丂一丈丙丟丏 = this.GetComponent<UnityEngine.AudioSource>();
        this.丞丈丕丒丁丒丒专丞 = UnityEngine.Object.op_Equality(x:  this.丙七且丛丒七一丅不, y:  0);
    }
    private void OnEnable()
    {
        this.丞丈丕丒丁丒丒专丞 = UnityEngine.Object.op_Equality(x:  this.丙七且丛丒七一丅不, y:  0);
        if(this.丌丕丛丂一丈丙丟丏 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丌丕丛丂一丈丙丟丏.Play();
        }
        
        }
        
        this.Invoke(methodName:  "Deactivate", time:  this.timeDeactivate);
    }
    internal void 丌丄丄丄丗丐丂丂三()
    {
        this.CancelInvoke(methodName:  "Deactivate");
        this.Invoke(methodName:  "Deactivate", time:  this.timeDeactivate);
    }
    public void Deactivate()
    {
        this.CancelInvoke(methodName:  "Deactivate");
        if(RayAndExplosionsStackController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(this.丌丕丛丂一丈丙丟丏 != 0)
        {
                this.丌丕丛丂一丈丙丟丏.Stop();
        }
        
        RayAndExplosionsStackController.丄丞丁丈与业上丞丟.ReturnObjectFromName(丆且丑丗丛丄丕丂丄:  this.gameObject, 丛丟丒且丌丂丗丑丞:  this.myName);
    }
    public RayAndExplosionsStackItem()
    {
        this.timeDeactivate = 1f;
    }

}
