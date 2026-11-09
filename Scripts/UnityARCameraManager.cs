using UnityEngine;
public class UnityARCameraManager : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera m_camera;
    private UnityEngine.Material 丗丑专丅丟丅且丈三;
    public UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄 startAlignment;
    public UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不 planeDetection;
    public bool getPointCloud;
    public bool enableLightEstimation;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        if(this.m_camera == 0)
        {
                return;
        }
        
        UnityEngine.Matrix4x4 val_4 = ARController.Instance.NativeSession.万丛丛丝一三丅七丄();
        UnityEngine.Vector3 val_6 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丘丛丝七丐丁七一丐(丙丐万下万下丄上专:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
        this.m_camera.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Quaternion val_8 = UnityEngine.XR.iOS.丗七丄下东不专丞专.丟丒业丐与丂丅上东(东丝丄丝丙专丘三丏:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
        this.m_camera.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = -val_8.z, w = -val_8.w};
        this = this.m_camera;
        UnityEngine.Matrix4x4 val_11 = ARController.Instance.NativeSession.上丙丄丌东专下丈与();
        this.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f};
    }
    public UnityARCameraManager()
    {
        this.planeDetection = 1;
        this.getPointCloud = true;
        this.enableLightEstimation = true;
    }

}
