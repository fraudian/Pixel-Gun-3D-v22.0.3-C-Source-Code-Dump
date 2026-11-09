using UnityEngine;
public class UIOrthoCamera : MonoBehaviour
{
    // Fields
    private UnityEngine.Camera 丟丕东万丐丁丁专一;
    private UnityEngine.Transform 丐一丗丛丕世丘东丁;
    
    // Methods
    private void Start()
    {
        this.丟丕东万丐丁丁专一 = this.GetComponent<UnityEngine.Camera>();
        this.丐一丗丛丕世丘东丁 = this.transform;
        this.丟丕东万丐丁丁专一.orthographic = true;
    }
    private void Update()
    {
        UnityEngine.Rect val_1 = this.丟丕东万丐丁丁专一.rect;
        UnityEngine.Rect val_4 = this.丟丕东万丐丁丁专一.rect;
        float val_10 = val_4.m_XMin;
        UnityEngine.Vector3 val_6 = this.丐一丗丛丕世丘东丁.lossyScale;
        float val_9 = (float)UnityEngine.Screen.height;
        val_9 = val_10 * val_9;
        val_9 = val_9 - (val_1.m_XMin * (float)UnityEngine.Screen.height);
        val_10 = val_9 * 0.5f;
        val_10 = val_10 * val_6.y;
        if((UnityEngine.Mathf.Approximately(a:  this.丟丕东万丐丁丁专一.orthographicSize, b:  val_10)) == true)
        {
                return;
        }
        
        this = this.丟丕东万丐丁丁专一;
        this.orthographicSize = val_10;
    }
    public UIOrthoCamera()
    {
    
    }

}
