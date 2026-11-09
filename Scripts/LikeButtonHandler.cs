using UnityEngine;
public sealed class LikeButtonHandler : PGBehaviour
{
    // Fields
    internal System.Collections.Generic.List<LikeTextureByType> likeTypesTexture;
    internal Rilisoft.ButtonHandler button;
    private string 丄丒且丙三丆丟与丏;
    private 七丈丆丝三丌七专丙 下七丆上一丏丌丟丈;
    private bool 一七不三丌专三丆一;
    private bool 业三丙上丙丙丝七万;
    
    // Methods
    private void OnEnable()
    {
        var val_4;
        System.Action<System.String, 七丈丆丝三丌七专丙> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Combine(a:  PlayerLikeController.GetLikeFromPlayer, b:  new System.Action<System.String, 七丈丆丝三丌七专丙>(object:  this, method:  System.Void LikeButtonHandler::且丌丌丈丙丕业丝丞(string 丞丅上丏丂且下丅与, 七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        PlayerLikeController.GetLikeFromPlayer = val_5;
    }
    private void OnDisable()
    {
        var val_4;
        System.Action<System.String, 七丈丆丝三丌七专丙> val_5;
        val_4 = null;
        val_4 = null;
        if(((System.Delegate.Remove(source:  PlayerLikeController.GetLikeFromPlayer, value:  new System.Action<System.String, 七丈丆丝三丌七专丙>(object:  this, method:  System.Void LikeButtonHandler::且丌丌丈丙丕业丝丞(string 丞丅上丏丂且下丅与, 七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且)))) != null) && (null != null))
        {
                val_5 = 0;
        }
        
        PlayerLikeController.GetLikeFromPlayer = val_5;
    }
    private void 且丌丌丈丙丕业丝丞(string 丞丅上丏丂且下丅与, 七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且)
    {
        if((this.丄丒且丙三丆丟与丏.Equals(value:  丞丅上丏丂且下丅与, comparisonType:  5)) == false)
        {
                return;
        }
        
        this.丛七丛丑丗与丑丆丁(丐丑丘与丘丈丟丒且:  丐丑丘与丘丈丟丒且);
    }
    internal void 丈且东丑丂且万丒丅(string 丄丒且丙三丆丟与丏, string 丞丞下东且丗丄丒丏, 七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且, bool 一七不三丌专三丆一)
    {
        if(一七不三丌专三丆一 == false)
        {
            goto label_1;
        }
        
        if(this.业三丙上丙丙丝七万 == true)
        {
            goto label_3;
        }
        
        this.丛七丛丑丗与丑丆丁(丐丑丘与丘丈丟丒且:  丐丑丘与丘丈丟丒且);
        this.业三丙上丙丙丝七万 = true;
        goto label_3;
        label_1:
        this.丛七丛丑丗与丑丆丁(丐丑丘与丘丈丟丒且:  丐丑丘与丘丈丟丒且);
        this.业三丙上丙丙丝七万 = false;
        label_3:
        this.丄丒且丙三丆丟与丏 = 丄丒且丙三丆丟与丏;
        this.一七不三丌专三丆一 = 一七不三丌专三丆一;
        this.button.ClearEvents();
        this.button.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LikeButtonHandler::三丕丌专丏七丘丝丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 三丕丌专丏七丘丝丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        七丈丆丝三丌七专丙 val_5;
        var val_6;
        if(PGCompany.丁东丌世与丕东丆上.丁丒丟上东下世丑丛() == false)
        {
                return;
        }
        
        七丈丆丝三丌七专丙 val_5 = this.下七丆上一丏丌丟丈;
        val_5 = val_5 | 2;
        if(val_5 == 3)
        {
                return;
        }
        
        if(this.一七不三丌专三丆一 != false)
        {
                val_5 = 1;
        }
        else
        {
                val_6 = null;
            val_6 = null;
            val_5 = PlayerLikeController.丄丘七三上丕世丞业.丌七丙丆丟丑业且世(丏世丑万世一七丟丞:  this.丄丒且丙三丆丟与丏, 下世丆且世丗与不下:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三());
        }
        
        this.丛七丛丑丗与丑丆丁(丐丑丘与丘丈丟丒且:  val_5);
    }
    private void 丛七丛丑丗与丑丆丁(七丈丆丝三丌七专丙 丐丑丘与丘丈丟丒且)
    {
        this.下七丆上一丏丌丟丈 = 丐丑丘与丘丈丟丒且;
        this.likeTypesTexture.ForEach(action:  new System.Action<LikeTextureByType>(object:  this, method:  System.Void LikeButtonHandler::专丈丝丐东丑万一与(LikeTextureByType 三丟东丕丄丄下下丑)));
    }
    public LikeButtonHandler()
    {
    
    }
    private void 专丈丝丐东丑万一与(LikeTextureByType 三丟东丕丄丄下下丑)
    {
        七丈丆丝三丌七专丙 val_2;
        UnityEngine.GameObject val_3;
        var val_4;
        val_2 = this.下七丆上一丏丌丟丈;
        if(val_2 != 三丟东丕丄丄下下丑.likePlayerType)
        {
            goto label_1;
        }
        
        if(三丟东丕丄丄下下丑.likeObject.activeSelf == false)
        {
            goto label_3;
        }
        
        val_2 = this.下七丆上一丏丌丟丈;
        label_1:
        if(val_2 == 三丟东丕丄丄下下丑.likePlayerType)
        {
                return;
        }
        
        val_3 = 三丟东丕丄丄下下丑.likeObject;
        val_4 = 0;
        goto label_7;
        label_3:
        val_4 = 1;
        val_3 = 三丟东丕丄丄下下丑.likeObject;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
    }

}
