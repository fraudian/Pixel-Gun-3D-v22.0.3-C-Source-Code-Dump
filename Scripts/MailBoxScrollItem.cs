using UnityEngine;
public class MailBoxScrollItem : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject indicatorNew;
    public UnityEngine.GameObject indicatorReward;
    internal 丈丞丕丘丕丗与上一 丗七丟丈三不丕一三;
    internal UnityEngine.GameObject indicatorTextureRewardGems;
    internal UnityEngine.GameObject indicatorTextureRewardCoins;
    internal UnityEngine.GameObject indicatorRewardChest;
    internal UIGrid gridIndicators;
    private UIToggle 三丅丌丘三上丟丕东;
    public UILabel headerLabel;
    public UILabel shortDescLabel;
    public UILabel dateLabel;
    public UITexture previewPic;
    public string previewPicUrl;
    internal bool 七丈万七丛丟丗丕三;
    public UIToggle currentToogle;
    internal 下丙丟上丂与东丂专 丌世与丘丘下不丗专;
    internal long 七丞与世丟丗丐丌丂;
    internal int 丏三丐丙与丝丁丄丑;
    private static readonly System.Collections.Generic.Dictionary<string, System.Threading.Tasks.Task<bool>> 三丆上东丆丏丌丟丕;
    
    // Properties
    internal UIToggle 且丌且丈上丄丑丕万 { get; }
    
    // Methods
    internal UIToggle 丒丏三东丆业七丗丁()
    {
        UIToggle val_5;
        if(this.三丅丌丘三上丟丕东 == 0)
        {
                if(this.currentToogle == 0)
        {
                UIToggle val_3 = this.GetComponent<UIToggle>();
            this.三丅丌丘三上丟丕东 = val_3;
            this.currentToogle = val_3;
            return val_5;
        }
        
        }
        
        if(this.三丅丌丘三上丟丕东 == 0)
        {
                val_5 = this.currentToogle;
            this.三丅丌丘三上丟丕东 = val_5;
            return val_5;
        }
        
        val_5 = this.三丅丌丘三上丟丕东;
        return val_5;
    }
    private void OnDisable()
    {
        if(this.previewPic == 0)
        {
                return;
        }
        
        this = ???;
        goto typeof(UITexture).__il2cppRuntimeField_2E8;
    }
    public void OnNewsItemClick()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        if(this.currentToogle.value == false)
        {
                return;
        }
        
        ButtonClickSound.丁业上丏不丕三丗不();
        val_5 = 0;
        goto label_3;
        label_14:
        val_6 = null;
        val_6 = null;
        if((Item[0].Equals(other:  this)) == true)
        {
            goto label_9;
        }
        
        val_5 = 1;
        label_3:
        val_7 = null;
        val_7 = null;
        if(val_5 < Count)
        {
            goto label_14;
        }
        
        return;
        label_9:
        val_8 = null;
        val_8 = null;
        PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.万丒丐丌丄丌不丏丞(丞世不丒下上上丝丑:  0, 世丁丒一丛不三丌丗:  this);
    }
    public MailBoxScrollItem()
    {
        this.丏三丐丙与丝丁丄丑 = 0;
    }
    private static MailBoxScrollItem()
    {
        MailBoxScrollItem.三丆上东丆丏丌丟丕 = new System.Collections.Generic.Dictionary<System.String, System.Threading.Tasks.Task<System.Boolean>>();
    }

}
