using UnityEngine;
public class UIViewport : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera sourceCamera;
    public UIRect sourceRect;
    public UnityEngine.Transform topLeft;
    public UnityEngine.Transform bottomRight;
    public float fullSize;
    public bool disableChangeCameraState;
    private UnityEngine.Camera 丟丕东万丐丁丁专一;
    
    // Methods
    private void Start()
    {
        this.丟丕东万丐丁丁专一 = this.GetComponent<UnityEngine.Camera>();
        if(this.sourceCamera != 0)
        {
                return;
        }
        
        UnityEngine.Camera val_3 = this.sourceRect.anchorCamera;
        this.sourceCamera = val_3;
        if(val_3 != 0)
        {
                return;
        }
        
        this.sourceCamera = UnityEngine.Camera.main;
    }
    private void LateUpdate()
    {
        UnityEngine.Camera val_20;
        var val_21;
        float val_22;
        float val_23;
        var val_24;
        var val_25;
        val_20 = this;
        val_21 = 1152921504848912384;
        if(this.topLeft == 0)
        {
                return;
        }
        
        if(this.bottomRight == 0)
        {
                return;
        }
        
        if(this.丟丕东万丐丁丁专一.enabled == false)
        {
                return;
        }
        
        if(this.topLeft.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_6 = this.topLeft.position;
            UnityEngine.Vector3 val_7 = this.sourceCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = this.bottomRight.position;
            UnityEngine.Vector3 val_9 = this.sourceCamera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_21 = UnityEngine.Screen.height;
            float val_20 = (float)UnityEngine.Screen.width;
            float val_21 = (float)val_21;
            float val_14 = val_9.x - val_7.x;
            val_20 = val_7.x / val_20;
            val_21 = val_9.y / val_21;
            val_14 = val_14 / (float)UnityEngine.Screen.width;
            float val_16 = (val_7.y - val_9.y) / (float)UnityEngine.Screen.height;
            val_22 = 0f;
            val_23 = 0f;
            float val_22 = val_20;
            UnityEngine.Rect val_17 = this.丟丕东万丐丁丁专一.rect;
            val_24 = 0f;
            if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_22, m_Width = 0f, m_Height = val_23}, rhs:  new UnityEngine.Rect() {m_XMin = val_17.m_XMin, m_YMin = val_17.m_YMin, m_Width = val_17.m_Width, m_Height = val_17.m_Height})) != false)
        {
                val_22 = 0f;
            val_23 = 0f;
            val_24 = 0f;
            this.丟丕东万丐丁丁专一.rect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_22, m_Width = 0f, m_Height = val_23};
        }
        
            val_22 = this.fullSize * val_22;
            if(this.丟丕东万丐丁丁专一.orthographicSize != val_22)
        {
                this.丟丕东万丐丁丁专一.orthographicSize = val_22;
        }
        
            if(this.disableChangeCameraState == true)
        {
                return;
        }
        
            val_20 = this.丟丕东万丐丁丁专一;
            val_25 = 1;
        }
        else
        {
                if(this.disableChangeCameraState == true)
        {
                return;
        }
        
            val_20 = this.丟丕东万丐丁丁专一;
            val_25 = 0;
        }
        
        val_20.enabled = false;
    }
    private void OnDisable()
    {
    
    }
    public UIViewport()
    {
        this.fullSize = 1f;
    }

}
