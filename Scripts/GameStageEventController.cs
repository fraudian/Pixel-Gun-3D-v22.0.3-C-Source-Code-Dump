using UnityEngine;
public class GameStageEventController : MonoBehaviour
{
    // Fields
    private UILabel eventLabel;
    private float 丁丝丘丌不丁丂丝万;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丒不上三且与丐丞与 = this;
    }
    private void Update()
    {
        if(this.丁丝丘丌不丁丂丝万 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丁丝丘丌不丁丂丝万 - val_1;
        this.丁丝丘丌不丁丂丝万 = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.eventLabel.gameObject.SetActive(value:  false);
    }
    public void Show(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟, bool 丂丝且专丒三世丞丐 = True)
    {
        UILabel val_5;
        this.eventLabel.gameObject.SetActive(value:  true);
        this.eventLabel.text = 丕丗丘丑丛与丑业丒;
        val_5 = this.eventLabel;
        if(val_5.applyGradient ^ 丂丝且专丒三世丞丐 != false)
        {
                val_5 = this.eventLabel;
            val_5.applyGradient = 丂丝且专丒三世丞丐;
        }
        
        this.丁丝丘丌不丁丂丝万 = 丂三丟丂丈丐丆丗丟;
    }
    public GameStageEventController()
    {
    
    }

}
