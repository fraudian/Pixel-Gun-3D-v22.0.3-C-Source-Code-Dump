using UnityEngine;
public class GoMapInEndGame : MonoBehaviour
{
    // Fields
    public int mapIndex;
    public UITexture mapTexture;
    public UILabel mapLabel;
    private float 丐七不丏丈七丈丂丟;
    private bool 丏东丗丅一丕三丕与;
    
    // Properties
    public bool 丄专万丄丘丄丆专丙 { get; set; }
    
    // Methods
    private void OnEnable()
    {
        this.丐七不丏丈七丈丂丟 = UnityEngine.Time.time;
    }
    private void Start()
    {
        null = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false)
        {
                if(GameConnect.东且三丆丑世世丘丟() == false)
        {
                return;
        }
        
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public void SetMap(SceneInfo 丄不东丁丂丅万丒丟)
    {
        UITexture val_9;
        UILabel val_10;
        if(丄不东丁丂丅万丒丟 == 0)
        {
                this.mapIndex = 0;
            val_9 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LevelLoadingsSmall/Random_Map");
            val_10 = this.mapLabel;
            string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2463");
        }
        else
        {
                if(丄不东丁丂丅万丒丟 != null)
        {
                val_9 = this.mapTexture;
            this.mapIndex = 丄不东丁丂丅万丒丟.indexMap;
        }
        else
        {
                val_9 = this.mapTexture;
            this.mapIndex = 4194311;
        }
        
            UnityEngine.Texture val_6 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LevelLoadingsSmall/Loading_"("LevelLoadingsSmall/Loading_") + 丄不东丁丂丅万丒丟.丙且上丒不下丑下丞());
            if(丄不东丁丂丅万丒丟 == 0)
        {
                return;
        }
        
            val_10 = this.mapLabel;
        }
        
        val_10.text = 丄不东丁丂丅万丒丟.上丘丙丒一丈丕丈世();
    }
    public void OnClick()
    {
        var val_18;
        int val_19;
        var val_20;
        var val_21;
        不丆万上丏丒丕丝万 val_22;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 - this.丐七不丏丈七丈丂丟;
        if(val_1 < 0)
        {
                return;
        }
        
        val_18 = 1152921505210572800;
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                if(BankController.丑七不且上丗丁一世().上丙丆不丂丂丄一丂() == true)
        {
                return;
        }
        
        }
        
        val_18 = 1152921505175109632;
        if(ExpController.丑七不且上丗丁一世() != 0)
        {
                if(ExpController.丑七不且上丗丁一世().下不上丌丘七世丘丙() != false)
        {
                return;
        }
        
        }
        
        val_19 = this.mapIndex;
        if(val_19 != 1)
        {
                val_20 = null;
            val_20 = null;
            val_19 = this.mapIndex;
        }
        else
        {
                val_19 = GameConnect.三丂丗下丑丛丕不丏(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
            if(val_19 == 1)
        {
            goto label_46;
        }
        
            val_20 = null;
            val_20 = null;
        }
        
        label_46:
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) != 0)
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万()) != null)
        {
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.专丆世丁与丂丁丂丅(丙业与丙丗丝不丈东:  0);
        }
        
        }
        
        val_21 = null;
        val_21 = null;
        GameController.丆丘丂丈世丏丟丑丏.丟业丌丗丒丅丞丗不(丄不东丁丂丅万丒丟:  SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  val_19));
        GamepadCursorController.丆丕丝丒不丙且丐丗.丅业丂丆万不丏丈丝(丏业丟一东丂东丘丛:  false);
        this.丏东丗丅一丕三丕与 = true;
        if(this.mapIndex != 1)
        {
                val_22 = 1;
        }
        else
        {
                val_22 = 3;
        }
        
        GameConnect.丘丕丈丄丛业东丈丝(丙业与丙丗丝不丈东:  val_22);
    }
    public bool get_IsLeavingRoom()
    {
        return (bool)this.丏东丗丅一丕三丕与;
    }
    protected void 丐且三与世丛不一三(bool 丙业与丙丗丝不丈东)
    {
        this.丏东丗丅一丕三丕与 = 丙业与丙丗丝不丈东;
    }
    public GoMapInEndGame()
    {
    
    }

}
