using UnityEngine;
public class UnityARCameraNearFar : MonoBehaviour
{
    // Fields
    private UnityEngine.Camera 上上丝丌不丄专世丈;
    private float 丛业丕世七丂丘万三;
    private float 丟三丟不丕丏与丈丞;
    
    // Methods
    private void Start()
    {
        this.上上丝丌不丄专世丈 = this.GetComponent<UnityEngine.Camera>();
        this.一丐且七丑一与丏一();
    }
    private void 一丐且七丑一与丏一()
    {
        this.丛业丕世七丂丘万三 = this.上上丝丌不丄专世丈.nearClipPlane;
        this.丟三丟不丕丏与丈丞 = this.上上丝丌不丄专世丈.farClipPlane;
        ARController.Instance.NativeSession.万万丒世丞丘丑与丐(丌丛丈丌丝丅丈丏丆:  this.丛业丕世七丂丘万三, 与不东丒丁丙丏丌丄:  this.丟三丟不丕丏与丈丞);
    }
    private void Update()
    {
        if(this.丛业丕世七丂丘万三 == this.上上丝丌不丄专世丈.nearClipPlane)
        {
                if(this.丟三丟不丕丏与丈丞 == this.上上丝丌不丄专世丈.farClipPlane)
        {
                return;
        }
        
        }
        
        this.一丐且七丑一与丏一();
    }
    public UnityARCameraNearFar()
    {
    
    }

}
