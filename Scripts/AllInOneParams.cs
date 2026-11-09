using UnityEngine;
[Serializable]
public class SkinnedMeshCombiner.AllInOneParams
{
    // Fields
    public UnityEngine.Material materialToUse;
    public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丒丁下丕上不万丏丟 atlasResolution;
    public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丟世丆丄三丌丘丘丑 mipMapEdgesSize;
    public MTAssets.SkinnedMeshCombiner.SkinnedMeshCombiner.丑丌七丙丕丂丒专丈 atlasPadding;
    public bool mergeTiledTextures;
    public bool mergeOnlyEqualsRootBones;
    public bool useDefaultMainTextureProperty;
    public string mainTexturePropertyToFind;
    public string mainTexturePropertyToInsert;
    public bool metallicMapSupport;
    public string metallicMapPropertyToFind;
    public string metallicMapPropertyToInsert;
    public bool specularMapSupport;
    public string specularMapPropertyToFind;
    public string specularMapPropertyToInsert;
    public bool normalMapSupport;
    public string normalMapPropertyToFind;
    public string normalMapPropertyToInsert;
    public bool normalMap2Support;
    public string normalMap2PropertyFind;
    public string normalMap2PropertyToInsert;
    public bool heightMapSupport;
    public string heightMapPropertyToFind;
    public string heightMapPropertyToInsert;
    public bool occlusionMapSupport;
    public string occlusionMapPropertyToFind;
    public string occlusionMapPropertyToInsert;
    public bool detailAlbedoMapSupport;
    public string detailMapPropertyToFind;
    public string detailMapPropertyToInsert;
    public bool detailMaskSupport;
    public string detailMaskPropertyToFind;
    public string detailMaskPropertyToInsert;
    public bool pinkNormalMapsFix;
    
    // Methods
    public SkinnedMeshCombiner.AllInOneParams()
    {
        this.atlasResolution = 7;
        this.mergeTiledTextures = true;
        this.mergeOnlyEqualsRootBones = true;
        this.useDefaultMainTextureProperty = true;
        this.mainTexturePropertyToFind = "_MainTex";
        this.mainTexturePropertyToInsert = "_MainTex";
        this.metallicMapPropertyToFind = "_MetallicGlossMap";
        this.metallicMapPropertyToInsert = "_MetallicGlossMap";
        this.specularMapPropertyToFind = "_SpecGlossMap";
        this.specularMapPropertyToInsert = "_SpecGlossMap";
        this.normalMapPropertyToFind = "_BumpMap";
        this.normalMapPropertyToInsert = "_BumpMap";
        this.normalMap2PropertyFind = "_DetailNormalMap";
        this.normalMap2PropertyToInsert = "_DetailNormalMap";
        this.heightMapPropertyToFind = "_ParallaxMap";
        this.heightMapPropertyToInsert = "_ParallaxMap";
        this.occlusionMapPropertyToFind = "_OcclusionMap";
        this.occlusionMapPropertyToInsert = "_OcclusionMap";
        this.detailMapPropertyToFind = "_DetailAlbedoMap";
        this.detailMapPropertyToInsert = "_DetailAlbedoMap";
        this.pinkNormalMapsFix = true;
        this.detailMaskPropertyToFind = "_DetailMask";
        this.detailMaskPropertyToInsert = "_DetailMask";
    }

}
