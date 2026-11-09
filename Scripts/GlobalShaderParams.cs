using UnityEngine;
public class GlobalShaderParams : MonoBehaviour
{
    // Fields
    public UnityEngine.Texture GlobalTex;
    public string globaltexName;
    public float GlobalFloat1;
    public string globalFloatName1;
    public float GlobalFloat2;
    public string globalFloatName2;
    public float GlobalFloat3;
    public string globalFloatName3;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Shader.SetGlobalTexture(name:  this.globaltexName, value:  this.GlobalTex);
        UnityEngine.Shader.SetGlobalFloat(name:  this.globalFloatName1, value:  this.GlobalFloat1);
        UnityEngine.Shader.SetGlobalFloat(name:  this.globalFloatName2, value:  this.GlobalFloat2);
        UnityEngine.Shader.SetGlobalFloat(name:  this.globalFloatName3, value:  this.GlobalFloat3);
    }
    private void OnDestroy()
    {
        UnityEngine.Shader.SetGlobalTexture(name:  this.globaltexName, value:  0);
    }
    public GlobalShaderParams()
    {
    
    }

}
