using UnityEngine;
internal class CampaignBaseUI : MonoBehaviour
{
    // Fields
    public UISprite health;
    public UnityEngine.Gradient gradient;
    
    // Methods
    private void Start()
    {
        if(CampaignBaseController.丄丘七三上丕世丞业 == 0)
        {
                this.gameObject.SetActive(value:  false);
            return;
        }
        
        CampaignBaseController.丄丘七三上丕世丞业.且丂世丆丌不丏与丂(丙业与丙丗丝不丈东:  new System.Action<CampaignBase>(object:  this, method:  System.Void CampaignBaseUI::丂万丝丌丙与丕专丏(CampaignBase 东业丟专丘丐丏丕不)));
        if(Count < 1)
        {
                return;
        }
        
        this.丂万丝丌丙与丕专丏(东业丟专丘丐丏丕不:  Item[0]);
    }
    private void OnDestroy()
    {
        if(CampaignBaseController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        CampaignBaseController.丄丘七三上丕世丞业.丟下丒丐一丏丁丙丂(丙业与丙丗丝不丈东:  new System.Action<CampaignBase>(object:  this, method:  System.Void CampaignBaseUI::丂万丝丌丙与丕专丏(CampaignBase 东业丟专丘丐丏丕不)));
    }
    internal void 丂万丝丌丙与丕专丏(CampaignBase 东业丟专丘丐丏丕不)
    {
        float val_1;
        if(东业丟专丘丐丏丕不 != null)
        {
                val_1 = 东业丟专丘丐丏丕不.世丙丟上丘上七万万;
        }
        else
        {
                val_1 = 0f;
        }
        
        float val_1 = 东业丟专丘丐丏丕不.maxHealth;
        val_1 = val_1 / val_1;
        this.丞专万丒丆丙专丒丛(丗与丘不且万丟丙丑:  val_1);
    }
    internal void 丞专万丒丆丙专丒丛(float 丗与丘不且万丟丙丑)
    {
        this.health.fillAmount = 丗与丘不且万丟丙丑;
        UnityEngine.Color val_1 = this.gradient.Evaluate(time:  丗与丘不且万丟丙丑);
        this.health.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
    }
    public CampaignBaseUI()
    {
    
    }

}
