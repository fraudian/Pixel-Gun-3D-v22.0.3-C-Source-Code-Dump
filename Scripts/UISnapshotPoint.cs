using UnityEngine;
public class UISnapshotPoint : MonoBehaviour
{
    // Fields
    public bool isOrthographic;
    public float nearClip;
    public float farClip;
    public int fieldOfView;
    public float orthoSize;
    public UnityEngine.Texture2D thumbnail;
    
    // Methods
    private void Start()
    {
        if((System.String.op_Inequality(a:  this.tag, b:  "EditorOnly")) == false)
        {
                return;
        }
        
        this.tag = "EditorOnly";
    }
    public UISnapshotPoint()
    {
        this.isOrthographic = true;
        this.nearClip = -100f;
        this.farClip = 100f;
        this.fieldOfView = 35;
        this.orthoSize = 30f;
    }

}
