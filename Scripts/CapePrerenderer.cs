using UnityEngine;
public class CapePrerenderer : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera activeCamera;
    private UnityEngine.RenderTexture 业丑丌业一丈七丘丂;
    public bool FinishPrerendering;
    private UnityEngine.GameObject 三不专丘丕丟七丈丘;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  512, height:  512, depth:  24);
        this.业丑丌业一丈七丘丂 = val_1;
        bool val_2 = val_1.Create();
        this.activeCamera.targetTexture = this.业丑丌业一丈七丘丂;
        this.activeCamera.useOcclusionCulling = false;
    }
    public UnityEngine.Texture Render_()
    {
        this.activeCamera.Render();
        UnityEngine.RenderTexture.active = this.业丑丌业一丈七丘丂;
        this.activeCamera.targetTexture = 0;
        UnityEngine.RenderTexture.active = 0;
        UnityEngine.Object.Destroy(obj:  this.transform.parent.gameObject);
        return (UnityEngine.Texture)this.业丑丌业一丈七丘丂;
    }
    public CapePrerenderer()
    {
    
    }

}
