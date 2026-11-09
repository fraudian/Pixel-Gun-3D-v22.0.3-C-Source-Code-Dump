using UnityEngine;
[Serializable]
public class SkinnedMeshCombiner.JustMaterialColorsParams
{
    // Fields
    public UnityEngine.Material materialToUse;
    public bool mergeOnlyEqualsRootBones;
    public bool useDefaultColorProperty;
    public string colorPropertyToFind;
    public string mainTexturePropertyToInsert;
    
    // Methods
    public SkinnedMeshCombiner.JustMaterialColorsParams()
    {
        this.mergeOnlyEqualsRootBones = true;
        this.useDefaultColorProperty = true;
        this.colorPropertyToFind = "_Color";
        this.mainTexturePropertyToInsert = "_MainTex";
    }

}
