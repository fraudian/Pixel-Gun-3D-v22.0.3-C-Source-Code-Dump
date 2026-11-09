using UnityEngine;
public class UpgradeWindow : MonoBehaviour
{
    // Fields
    public TweenColor[] upgrades;
    public UnityEngine.GameObject[] rootUpgradesObjects;
    public ItemPreviewUpgradeIndicator[] indicators;
    private UnityEngine.Coroutine 丒丄丅丅丝丏丗且万;
    
    // Methods
    public void SetUpgrade(int 丙丐一丕丗万丁下一, int 丘丕七丅丅不丝一丑)
    {
        var val_4 = 0;
        goto label_1;
        label_21:
        this.rootUpgradesObjects[0].SetActive(value:  (val_4 <= 丙丐一丕丗万丁下一) ? 1 : 0);
        TweenColor val_5 = this.upgrades[0];
        if(val_4 > 丘丕七丅丅不丝一丑)
        {
                this.丞不丅与万且丂且与(丈不不丁丆世丑专上:  this.三三上下世一上丗专(丛丄丌三丁丝丈且七:  val_5));
            this.upgrades[0].enabled = true;
            this.upgrades[0].ResetToBeginning();
        }
        else
        {
                val_5.enabled = false;
            this.upgrades[0].GetComponent<UISprite>().color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        
        val_4 = 1;
        label_1:
        if(val_4 < this.upgrades.Length)
        {
            goto label_21;
        }
    
    }
    private void 丞不丅与万且丂且与(System.Collections.IEnumerator 丈不不丁丆世丑专上)
    {
        if(this.丒丄丅丅丝丏丗且万 != null)
        {
                this.StopCoroutine(routine:  this.丒丄丅丅丝丏丗且万);
        }
        
        this.丒丄丅丅丝丏丗且万 = this.StartCoroutine(routine:  丈不不丁丆世丑专上);
    }
    private System.Collections.IEnumerator 三三上下世一上丗专(TweenColor 丛丄丌三丁丝丈且七)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丛丄丌三丁丝丈且七 = 丛丄丌三丁丝丈且七;
        return (System.Collections.IEnumerator)new UpgradeWindow.丆丛七丌丐丕丐下丄();
    }
    public UpgradeWindow()
    {
    
    }

}
