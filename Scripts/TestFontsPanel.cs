using UnityEngine;
public class TestFontsPanel : MonoBehaviour
{
    // Fields
    public UILabel[] labels;
    private System.Collections.Generic.List<I2.Loc.TermData> 丑丟丁丈丞三丟丄上;
    
    // Methods
    private void Start()
    {
    
    }
    private void OnEnable()
    {
        null = null;
        I2.Loc.LanguageSource val_3 = I2.Loc.丗丈下丕丟丟丙七丞.下且丛丐丕丘丐丑丒.Item[I2.Loc.丗丈下丕丟丟丙七丞.丑丂丕专丛丅丅不丈(丞丞丐丝丝丏丐丛丞:  I2.Loc.丗丈下丕丟丟丙七丞.丗七丏三万丛丙丟业(), 丒一上业三丛丐专丘:  true)];
        this.丑丟丁丈丞三丟丄上 = val_3.mTerms;
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丐丑下丕七丗丗丝丝());
    }
    private System.Collections.IEnumerator 丐丑下丕七丗丗丝丝()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TestFontsPanel.丒丞丁丞不上专丟丁();
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.丐丑下丕七丗丗丝丝());
    }
    public void Close()
    {
        this.gameObject.SetActive(value:  false);
    }
    public TestFontsPanel()
    {
    
    }

}
