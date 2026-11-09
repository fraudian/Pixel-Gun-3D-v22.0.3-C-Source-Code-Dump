using UnityEngine;
[Serializable]
public class LightMapUvSaver.MeshRenderWithName
{
    // Fields
    public int lmIndex;
    public string name;
    public string parentName;
    public int siblingIndex;
    public UnityEngine.Vector4 uvTiling;
    
    // Methods
    public LightMapUvSaver.MeshRenderWithName()
    {
        this.parentName = "";
    }

}
