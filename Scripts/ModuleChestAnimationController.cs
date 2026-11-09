using UnityEngine;
public class ModuleChestAnimationController : MonoBehaviour
{
    // Fields
    private UnityEngine.Animator animator;
    private float openAnimLenght;
    private float closeAnimLenght;
    private float openAndCloseAnimLenght;
    internal float 丏万丒丏丌丗与丗丕;
    private UnityEngine.Coroutine 丅丄丐东七丛丁业丗;
    
    // Methods
    internal float 一丒专丝丛丟上三丅()
    {
        float val_1 = this.animator.speed;
        val_1 = val_1 * this.openAnimLenght;
        return (float)val_1;
    }
    private void Awake()
    {
        this.丏万丒丏丌丗与丗丕 = this.openAnimLenght;
    }
    internal void 下丌上且世丅业丂一(float 下下丏一丙不丘丌丞)
    {
        this.openAnimLenght = 下下丏一丙不丘丌丞;
    }
    internal void 丌专丄丆丐与且不丙()
    {
        this.animator.ResetTrigger(name:  "Open");
        this.animator.ResetTrigger(name:  "Close");
        this.animator.ResetTrigger(name:  "OpenAndClose");
    }
    internal void 丌万丗与七丄丕不丁(System.Action 丑丙丙丕与丂丐丘一)
    {
        this.animator.SetTrigger(name:  "Open");
        this.七与丈业专东丁三丁(丆丐七丅丆丗丛上与:  this.openAnimLenght, 丑丙丙丕与丂丐丘一:  丑丙丙丕与丂丐丘一);
    }
    internal void 丗丟万丂丘丈专丄丂(System.Action 丑丙丙丕与丂丐丘一)
    {
        this.animator.SetTrigger(name:  "Close");
        this.七与丈业专东丁三丁(丆丐七丅丆丗丛上与:  this.closeAnimLenght, 丑丙丙丕与丂丐丘一:  丑丙丙丕与丂丐丘一);
    }
    internal void 丐丐七丒丄丘丙专丞(System.Action 丑丙丙丕与丂丐丘一)
    {
        this.animator.SetTrigger(name:  "OpenAndClose");
        this.七与丈业专东丁三丁(丆丐七丅丆丗丛上与:  this.openAndCloseAnimLenght, 丑丙丙丕与丂丐丘一:  丑丙丙丕与丂丐丘一);
    }
    private void 七与丈业专东丁三丁(float 丆丐七丅丆丗丛上与, System.Action 丑丙丙丕与丂丐丘一)
    {
        if(this.丅丄丐东七丛丁业丗 != null)
        {
                this.StopCoroutine(routine:  this.丅丄丐东七丛丁业丗);
            this.丅丄丐东七丛丁业丗 = 0;
        }
        
        this.丅丄丐东七丛丁业丗 = this.StartCoroutine(routine:  this.丘丕丞上上七丐万丒(丆丐七丅丆丗丛上与:  丆丐七丅丆丗丛上与, 丑丙丙丕与丂丐丘一:  丑丙丙丕与丂丐丘一));
    }
    private System.Collections.IEnumerator 丘丕丞上上七丐万丒(float 丆丐七丅丆丗丛上与, System.Action 丑丙丙丕与丂丐丘一)
    {
        ModuleChestAnimationController.丘丅下与一上世丐丛 val_1 = new ModuleChestAnimationController.丘丅下与一上世丐丛();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
        }
        else
        {
                mem[32] = 丆丐七丅丆丗丛上与;
        }
        
        .丑丙丙丕与丂丐丘一 = 丑丙丙丕与丂丐丘一;
        return (System.Collections.IEnumerator)val_1;
    }
    public ModuleChestAnimationController()
    {
        this.openAnimLenght = 0.25f;
        this.closeAnimLenght = 0.25f;
        this.openAndCloseAnimLenght = 0.5f;
    }

}
