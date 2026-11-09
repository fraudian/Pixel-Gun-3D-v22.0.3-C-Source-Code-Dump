using UnityEngine;
public class EggReadyIndicatorController : MonoBehaviour
{
    // Fields
    public bool weaponUpIndicator;
    private UISprite 丛东上丂东一丒丈世;
    
    // Properties
    private UISprite 与丄丈丘丟丕丏丐丁 { get; }
    
    // Methods
    private void OnEnable()
    {
        Rilisoft.EggsManager.丟丁丞丈丕丏东丅丅(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::七专丌一专万丁丏丙(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
        Rilisoft.EggsManager.七丙丏丏东业丄丝专(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<System.String, System.Int32>, PGCompany.丝不丅丗丄丄与丌丘>(object:  this, method:  System.Void EggReadyIndicatorController::与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)));
        Rilisoft.EggsManager.丞丈丅世丆丐丛丕丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
        Rilisoft.EggsManager.下丗七且上三丑丄业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::丅丕丛丗丙专不丂丕(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        Rilisoft.EggsManager.丟三万丐丛丏丑丝丝(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::丅丕丛丗丙专不丂丕(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
        Rilisoft.EggsManager.专七丕三业丗丑丞丌(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
        Rilisoft.EggsManager.丅不七不三丞丈丝七(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress, System.Collections.Generic.Dictionary<System.String, System.Int32>, PGCompany.丝不丅丗丄丄与丌丘>(object:  this, method:  System.Void EggReadyIndicatorController::与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)));
        Rilisoft.EggsManager.一下丗丒丛下丘丞丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.EggIncubatorProgress>(object:  this, method:  System.Void EggReadyIndicatorController::七专丌一专万丁丏丙(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)));
    }
    private void 丅丕丛丗丙专不丂丕(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丌业七丟丆东不丅三(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 与丆丕丙下丑丐丛专(PGCompany.EggIncubatorProgress 且丆丏丛东下上丄丟, System.Collections.Generic.Dictionary<string, int> 丏丂丅丟上丁东丞丂, PGCompany.丝不丅丗丄丄与丌丘 东丏上丄丙丘丘丂三)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 七专丌一专万丁丏丙(PGCompany.EggIncubatorProgress 万且万且丑丗且丌丆)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        var val_17;
        var val_18;
        val_17 = this;
        if(this.weaponUpIndicator == true)
        {
                return;
        }
        
        if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.一且丂不丈丝丗一丆()) <= 0)
        {
            goto label_3;
        }
        
        this.丛丒丝丈与丞丆丙丂().spriteName = "PetAlert";
        label_18:
        val_18 = 1;
        goto label_5;
        label_3:
        if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄().Count) >= 1)
        {
                if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丁世丌丝丙丞丑丄世()) == null)
        {
            goto label_10;
        }
        
        }
        
        val_18 = 0;
        label_5:
        if(this.丛丒丝丈与丞丆丙丂() == 0)
        {
                return;
        }
        
        if(val_18 ^ this.丛丒丝丈与丞丆丙丂().enabled == false)
        {
                return;
        }
        
        val_17 = this.丛丒丝丈与丞丆丙丂();
        val_17.enabled = false;
        return;
        label_10:
        this.丛丒丝丈与丞丆丙丂().spriteName = "EggAlert";
        goto label_18;
    }
    private UISprite 丛丒丝丈与丞丆丙丂()
    {
        UISprite val_3;
        if(this.丛东上丂东一丒丈世 == 0)
        {
                this.丛东上丂东一丒丈世 = this.GetComponent<UISprite>();
            return val_3;
        }
        
        val_3 = this.丛东上丂东一丒丈世;
        return val_3;
    }
    public EggReadyIndicatorController()
    {
    
    }

}
