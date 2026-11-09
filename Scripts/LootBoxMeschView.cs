using UnityEngine;
internal sealed class LootBoxMeschView : PGBehaviour
{
    // Fields
    private UnityEngine.Transform lootBoxHolder;
    private PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丏世下丑丕丒丑丙世;
    private ModuleChestAnimationController 丛一丙丁与上万下丕;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 东丌一丟万丄丛且丗)
    {
        this.丏世下丑丕丒丑丙世 = PGCompany.LootBoxSystem.丑丅丘丒万丘万万丐.丌丛业专丈丈丙与丛(丈丄不七三万丄丁不:  东丌一丟万丄丛且丗, 与不丕丆丈不丙丟丛:  0);
        this.丝一丅丆三东丂丞七();
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 丆丞丝丘丗丘丙丅万)
    {
        this.丏世下丑丕丒丑丙世 = 丆丞丝丘丗丘丙丅万;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        if(this.丛一丙丁与上万下丕 != 0)
        {
                UnityEngine.GameObject val_2 = this.丛一丙丁与上万下丕.gameObject;
            UnityEngine.Object.Destroy(obj:  val_2);
            this.丛一丙丁与上万下丕 = 0;
        }
        
        if(this.丏世下丑丕丒丑丙世 == null)
        {
                return;
        }
        
        ModuleChestAnimationController val_3 = val_2.下丕丅丁丑丞三万丘(七丁丑丗丐专丌丝丗:  this.丏世下丑丕丒丑丙世);
        this.丛一丙丁与上万下丕 = val_3;
        val_3.transform.SetParent(p:  this.lootBoxHolder);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.丛一丙丁与上万下丕.transform);
    }
    private ModuleChestAnimationController 下丕丅丁丑丞三万丘(PGCompany.LootBoxSystem.丗丑丂丂上丏丝丙三 七丁丑丗丐专丌丝丗)
    {
        UnityEngine.Object val_14;
        var val_15;
        val_14 = 七丁丑丗丐专丌丝丗;
        if(val_14 != null)
        {
                if(val_14.丟不丛丑一丗丄业丟() == null)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  string val_7 = "Lootbox/"("Lootbox/") + val_14.丟不丛丑一丗丄业丟().世丒丗万丐与丞丗丂()));
        }
        
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14.丟不丛丑一丗丄业丟().世丒丗万丐与丞丗丂())) != false)
        {
                UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, chestName nullable or empty");
        }
        
            if(val_14 != 0)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
        }
        
            UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, prefab " + val_7 + " not found");
            val_14 = UnityEngine.Resources.Load<ModuleChestAnimationController>(path:  "Lootbox/Default");
            if(val_14 != 0)
        {
                return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
        }
        
            UnityEngine.Debug.LogError(message:  "cant GetLootBoxPrefab, prefab LootBox_Default not found");
        }
        
        val_15 = 0;
        return (ModuleChestAnimationController)UnityEngine.Object.Instantiate<ModuleChestAnimationController>(original:  val_14);
    }
    public LootBoxMeschView()
    {
    
    }

}
