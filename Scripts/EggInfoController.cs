using UnityEngine;
public class EggInfoController : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform _modelPoint;
    private UISprite barSprite;
    private UnityEngine.GameObject description;
    private UILabel eggDescription;
    private EggIncubator3dController eggIncubator3d;
    private UILabel eggName;
    public CharacterViewRotator eggRotator;
    private UISprite frameSprite;
    private UnityEngine.GameObject glowEffect;
    private UIButton hatchButton;
    private EggIncubator3dController 丄丈万与丛丆一与丄;
    private int 丏丌世丙与丌丐专丟;
    private bool 专丆七丑万业丟东业;
    private int 专七东世丌丞丏丆万;
    private UIButton speedUpButton;
    private PriceContainer speedUpPrice;
    private UIButton startButton;
    private UILabel timerLabel;
    private UnityEngine.GameObject timerObject;
    
    // Methods
    public void DeleteModel()
    {
        if(this.丄丈万与丛丆一与丄 == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.丄丈万与丛丆一与丄.gameObject);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丝丂丕东专世丅丝丁());
    }
    public void CheckFifthEgg()
    {
    
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.丝丂丕东专世丅丝丁());
        this.DeleteModel();
    }
    private void 丆丅丝一一丅丌丟丒()
    {
    
    }
    public void SpeedUpEgg()
    {
    
    }
    private void 七丛丟丄丐丒丐丞丐()
    {
    
    }
    private void 丒丂下世万丌上丌万()
    {
        EggHatchingWindowControllerV2.丌丅世丑丄丐丐丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoController::丒丂下世万丌上丌万()));
        if(NurseryGuiController.且丕丈丙丛不业丂丗() != 0)
        {
                NurseryGuiController.且丕丈丙丛不业丂丗().UpdateIncubators();
        }
        
        NurseryGuiController.且丕丈丙丛不业丂丗().不丑丞丌丂世专丄下(与丝丕与丙不与丗丆:  0, 丕丝丟下丗丛一丕业:  true);
        if(NurseryTrainingController.丁丏丒专一丄丏丙七() == 6)
        {
                return;
        }
        
        NurseryGuiController val_7 = NurseryGuiController.且丕丈丙丛不业丂丗();
        val_7.trainingController.UpdateTrainingStep(丒且丆丘丞丑业丅不:  3);
    }
    private void 丟专万丆丄丈东丆丄()
    {
        if(NurseryGuiController.且丕丈丙丛不业丂丗() != 0)
        {
                NurseryGuiController.且丕丈丙丛不业丂丗().UpdateIncubators();
        }
        
        EggHatchingWindowControllerV2.且七丌不丐丈与丘七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void EggInfoController::丟专万丆丄丈东丆丄()));
    }
    public void StartEgg()
    {
    
    }
    private System.Collections.IEnumerator 丝丂丕东专世丅丝丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new EggInfoController.丌丑下丁丙丐丐一丏();
    }
    public EggInfoController()
    {
        this.专七东世丌丞丏丆万 = 0;
    }

}
