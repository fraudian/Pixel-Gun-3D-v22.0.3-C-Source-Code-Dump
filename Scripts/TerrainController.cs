using UnityEngine;
public sealed class TerrainController : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform terrainPlayerTransform;
    public UnityEngine.Vector3 terrainPlayerPosition;
    public UnityEngine.Vector3 prevTerrainPlayerPosition;
    private bool 丙与丏丑丐世丒七三;
    public UnityEngine.Events.UnityEvent cameraChanged;
    public UnityEngine.Transform currentCameraTransform;
    public UnityEngine.Transform globalGameControllerCamera;
    public UnityEngine.Transform cameraSceneController;
    public UnityEngine.Transform thirdPersonCamera;
    public UnityEngine.Transform firstPersonCamera;
    private bool 一丌与下丈丑三业丏;
    private UnityEngine.Coroutine 三丞丏与丆与丆丈丒;
    private UnityEngine.WaitForEndOfFrame 万丆丄丝丞世丑一业;
    
    // Methods
    private void Start()
    {
        this.万丆丄丝丞世丑一业 = new UnityEngine.WaitForEndOfFrame();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丑丗一丄丕丂与万丑());
    }
    private void Update()
    {
        if(this.丙与丏丑丐世丒七三 == false)
        {
                return;
        }
        
        if((this.currentCameraTransform == 0) || (this.currentCameraTransform.gameObject.activeSelf == false))
        {
            goto label_7;
        }
        
        if((UnityEngine.Time.frameCount & 3) != 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_6 = this.currentCameraTransform.position;
        this.terrainPlayerTransform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_7 = this.terrainPlayerTransform.position;
        this.terrainPlayerPosition = val_7;
        mem[1152921539347237428] = val_7.y;
        mem[1152921539347237432] = val_7.z;
        if(this.一丌与下丈丑三业丏 == true)
        {
            goto label_12;
        }
        
        return;
        label_7:
        this.一丌与下丈丑三业丏 = true;
        label_12:
        if(this.三丞丏与丆与丆丈丒 != null)
        {
                return;
        }
        
        this.三丞丏与丆与丆丈丒 = this.StartCoroutine(routine:  this.丞丕丒丄七丗丟丌丐());
    }
    private System.Collections.IEnumerator 丑丗一丄丕丂与万丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TerrainController.丘下丑业丝丒丌丗业();
    }
    private System.Collections.IEnumerator 丞丕丒丄七丗丟丌丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TerrainController.东丛丂上专丏专丒不();
    }
    public TerrainController()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.prevTerrainPlayerPosition = val_1;
        mem[1152921539347626688] = val_1.y;
        mem[1152921539347626692] = val_1.z;
    }

}
