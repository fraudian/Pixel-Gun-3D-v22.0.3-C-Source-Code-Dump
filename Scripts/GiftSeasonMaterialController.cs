using UnityEngine;
public class GiftSeasonMaterialController : MonoBehaviour
{
    // Fields
    public UnityEngine.SkinnedMeshRenderer GiftMaterial;
    private readonly string 丘丒东不丄业下丆东;
    private readonly string 丙丅且丐丞丑丂万专;
    
    // Methods
    private void Awake()
    {
        GiftController.下丅丕丈丗丅上不一(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftSeasonMaterialController::丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)));
        GiftSettingType val_3 = GiftController.丆丕丝丒不丙且丐丗.丗丕万专丄丗丐且丛();
        this.丟丘东丆丘与丈丗下(上丞丕专丈业丁世专:  GiftController.丆丕丝丒不丙且丐丗.丌业丏丄与世三丁不(), 丗丕下东丅丏丕上丏:  System.Void GiftSeasonMaterialController::丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏));
    }
    private void OnDestroy()
    {
        GiftController.丘丏丂专业丙上丒丗(丙业与丙丗丝不丈东:  new System.Action<GiftSettingType, GiftSettingType>(object:  this, method:  System.Void GiftSeasonMaterialController::丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)));
    }
    private void 丟丘东丆丘与丈丗下(GiftSettingType 上丞丕专丈业丁世专, GiftSettingType 丗丕下东丅丏丕上丏)
    {
        this.GiftMaterial.material.mainTexture = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.IO.Path.Combine(path1:  this.丘丒东不丄业下丆东, path2:  this.丙丅且丐丞丑丂万专 + 上丞丕专丈业丁世专).ToLowerInvariant());
    }
    public GiftSeasonMaterialController()
    {
        this.丘丒东不丄业下丆东 = "LuckyChest";
        this.丙丅且丐丞丑丂万专 = "lucky_chest_";
    }

}
