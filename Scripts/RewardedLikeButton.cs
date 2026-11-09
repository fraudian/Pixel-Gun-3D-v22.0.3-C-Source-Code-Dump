using UnityEngine;
internal sealed class RewardedLikeButton : MonoBehaviour
{
    // Fields
    private const int 东丁丘丟丝三丕三三 = 10;
    internal const string 不丁一世丒与与丄与 = "RewardForLikeGained";
    public UIButton rewardedLikeButton;
    public UILabel rewardedLikeCaption;
    
    // Methods
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new RewardedLikeButton.丈丙丒丅业丌下且三();
    }
    private void OnEnable()
    {
        this.业不不且丐且与不与();
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RewardedLikeButton::丟丏丕下丐丐丐丄丈()));
    }
    public void OnClick()
    {
        string val_4;
        var val_5;
        UnityEngine.Application.OpenURL(url:  "https://www.facebook.com/PixelGun3DOfficial");
        Rilisoft.丞丛七上丕专丏丌丈.丄专丏上与上丄丐丗(与丂丒丄丟丌丆丁丕:  "likeFacebook");
        val_4 = "RewardForLikeGained";
        if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  "RewardForLikeGained", 丝丒上丑一三丑丐丛:  true)) != true)
        {
                丌丝世丞世丛丆丅丟.东丌丟三丞世一一丑(丌丘不丆丈丈世万上:  "RewardForLikeGained", 丕万不丌世丟三丛丈:  false);
            val_5 = null;
            val_5 = null;
            val_4 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_4, 丗世丈丂丒丞专上丟:  10, 世丁丙世丄一万丆三:  12, 丛丞万三下丘七丌丅:  true);
            Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  10, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丅丅丞丙丁丕丌世东:  0);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            null.Add(key:  "Like Facebook Page", value:  "Likes");
            Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Virality", 丛东不丒丏丈丄且丕:  null);
            CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丌丒丝东丌下丕丁丅:  2);
        }
        
        this.业不不且丐且与不与();
    }
    private void 丟丏丕下丐丐丐丄丈()
    {
        if(this.rewardedLikeCaption == 0)
        {
                UnityEngine.Debug.LogError(message:  "rewardedLikeCaption == null");
            return;
        }
        
        this.rewardedLikeCaption.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1653"), arg0:  10);
    }
    internal void 业不不且丐且与不与()
    {
        var val_10;
        if(FacebookController.且丈丄一丁丞丒丑东() == false)
        {
            goto label_3;
        }
        
        if(this.rewardedLikeButton != 0)
        {
            goto label_6;
        }
        
        val_10 = null;
        goto label_10;
        label_3:
        val_10 = null;
        goto label_10;
        label_6:
        if((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  "RewardForLikeGained", 丝丒上丑一三丑丐丛:  true)) == false)
        {
            goto label_13;
        }
        
        UnityEngine.Object.Destroy(obj:  this.rewardedLikeButton.gameObject);
        label_10:
        UnityEngine.Object.Destroy(obj:  this);
        return;
        label_13:
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                if(ExpController.与丁丆丂丒丌丝且丅() > 1)
        {
                if(MainMenuController.丝丂丒且与丆丛丝丒() == false)
        {
            goto label_25;
        }
        
        }
        
        }
        
        label_30:
        this.rewardedLikeButton.gameObject.SetActive(value:  false);
        return;
        label_25:
        this.丟丏丕下丐丐丐丄丈();
        if(this.rewardedLikeButton.gameObject != null)
        {
            goto label_30;
        }
        
        goto label_30;
    }
    public RewardedLikeButton()
    {
    
    }

}
