using UnityEngine;
public class ScenePrerenderer : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera activeCamera;
    private UnityEngine.RenderTexture 业丑丌业一丈七丘丂;
    public bool FinishPrerendering;
    public UnityEngine.GameObject[] objsToRender;
    private UnityEngine.GameObject 三不专丘丕丟七丈丘;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  32, height:  32, depth:  24);
        this.业丑丌业一丈七丘丂 = val_1;
        bool val_2 = val_1.Create();
        this.activeCamera.targetTexture = this.业丑丌业一丈七丘丂;
        this.activeCamera.useOcclusionCulling = false;
    }
    private void Start()
    {
        this.丟丅丘世丅专世丁丕();
    }
    private void 丟丅丘世丅专世丁丕()
    {
        var val_5;
        var val_37;
        string val_38;
        var val_39;
        val_37 = null;
        val_37 = null;
        int val_1 = Count;
        List.Enumerator<T> val_3 = GetEnumerator();
        var val_37 = 0;
        goto label_6;
        label_39:
        string val_6 = val_5.丐丏七丌丕丗业且上();
        UnityEngine.Vector3 val_11 = this.transform.position;
        UnityEngine.Vector3 val_13 = this.transform.position;
        UnityEngine.Vector3 val_15 = this.transform.position;
        val_5 = 0;
        float val_16 = val_13.y + (-20f);
        UnityEngine.Quaternion val_21 = val_6.transform.GetChild(index:  0).gameObject.transform.rotation;
        UnityEngine.GameObject val_22 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_6.transform.GetChild(index:  0).gameObject, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w});
        int val_24 = val_22.name.IndexOf(value:  "(Clone)");
        if((val_24 & 2147483648) != 0)
        {
            goto label_22;
        }
        
        val_38 = val_22.name.Remove(startIndex:  val_24, count:  Length);
        if(val_22 != null)
        {
            goto label_29;
        }
        
        goto label_27;
        label_22:
        val_38 = val_22.name;
        if(val_22 != null)
        {
            goto label_29;
        }
        
        label_27:
        label_29:
        val_22.name = val_38;
        val_22.transform.parent = this.transform.parent;
        UnityEngine.Texture val_32 = SkinsController.丙东丛且丗丟丂丑丏(丂与丙丛丐丆丗丄七:  val_22);
        new UnityEngine.GameObject[0][0] = val_22;
        val_37 = val_37 + 1;
        label_6:
        if((1507448112 & 1) != 0)
        {
            goto label_39;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.activeCamera.Render();
        UnityEngine.RenderTexture.active = this.业丑丌业一丈七丘丂;
        this.activeCamera.targetTexture = 0;
        UnityEngine.RenderTexture.active = 0;
        val_39 = 0;
        goto label_73;
        label_78:
        UnityEngine.Object.Destroy(obj:  this.objsToRender[0]);
        val_39 = 1;
        label_73:
        if(val_39 < this.objsToRender.Length)
        {
            goto label_78;
        }
        
        UnityEngine.Object.Destroy(obj:  this.transform.parent.parent.gameObject);
        UnityEngine.Object.Destroy(obj:  this.activeCamera);
    }
    public ScenePrerenderer()
    {
    
    }

}
