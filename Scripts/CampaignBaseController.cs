using UnityEngine;
internal class CampaignBaseController : MonoBehaviour
{
    // Fields
    internal static CampaignBaseController 丄丘七三上丕世丞业;
    public System.Collections.Generic.List<CampaignBase> listBase;
    private System.Action<CampaignBase> 丈丌丙丘丅不丌万世;
    
    // Methods
    internal void 且丂世丆丌不丏与丂(System.Action<CampaignBase> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丌丙丘丅不丌万世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丌丙丘丅不丌万世 != 1152921539931972208);
    
    }
    internal void 丟下丒丐一丏丁丙丂(System.Action<CampaignBase> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丌丙丘丅不丌万世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丌丙丘丅不丌万世 != 1152921539932108784);
    
    }
    private void Awake()
    {
        CampaignBaseController.丄丘七三上丕世丞业 = this;
        List.Enumerator<T> val_1 = this.listBase.GetEnumerator();
        label_4:
        if((965654024 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<CampaignBase> val_3 = new System.Action<CampaignBase>(object:  this, method:  System.Void CampaignBaseController::丂万丝丌丙与丕专丏(CampaignBase 且丗丕丆丂丆丁丄下));
        0.丐丏七丌丕丗业且上().且丂世丆丌不丏与丂(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丂万丝丌丙与丕专丏(CampaignBase 且丗丕丆丂丆丁丄下)
    {
        if(this.丈丌丙丘丅不丌万世 == null)
        {
                return;
        }
        
        this.丈丌丙丘丅不丌万世.Invoke(obj:  且丗丕丆丂丆丁丄下);
    }
    public CampaignBaseController()
    {
        this.listBase = new System.Collections.Generic.List<CampaignBase>();
    }

}
