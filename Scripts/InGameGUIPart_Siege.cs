using UnityEngine;
public class InGameGUIPart_Siege : InGameGUIPartContainer
{
    // Fields
    private UILabel siegeEventLabel;
    private UILabel siegeEventEndLabel;
    internal SiegeContainerGUI containerUI;
    private float 世丝三丁丑不与世丏;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丅丟与丟东丛东丛一 = this;
    }
    internal void 丘丆丈丝万不丕丘丐(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟, bool 丛丌万丐世丞丗丟丑)
    {
        this.siegeEventLabel.gameObject.SetActive(value:  true);
        this.siegeEventLabel.text = 丕丗丘丑丛与丑业丒;
        this.世丝三丁丑不与世丏 = 丂三丟丂丈丐丆丗丟;
        this.siegeEventEndLabel.gameObject.SetActive(value:  丛丌万丐世丞丗丟丑);
    }
    private void Update()
    {
        if(this.世丝三丁丑不与世丏 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.世丝三丁丑不与世丏 - val_1;
        this.世丝三丁丑不与世丏 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.siegeEventLabel.gameObject.SetActive(value:  false);
    }
    public InGameGUIPart_Siege()
    {
    
    }

}
