using UnityEngine;
public class LeaderboardsFriendsWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private static readonly string 丑世不丌世丟上且丕;
    private Rilisoft.ButtonHandler 丆丐丘丘世万丛万丁;
    private 七丗上丂丕丂丈丛丞 与丂且下丟丆丅丙丝;
    private UnityEngine.GameObject headerContainer;
    private UnityEngine.GameObject[] leagueHeaders;
    private UnityEngine.GameObject myPlayerHightlightObj;
    private UILabel nameLabel;
    private UnityEngine.GameObject parentWindowObj;
    private UILabel placeLabel;
    private UnityEngine.GameObject playerContainer;
    private UILabel ratingLabel;
    
    // Methods
    protected override void Awake()
    {
        UnityEngine.GameObject val_1;
        var val_2;
        val_1 = this;
        this.Awake();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.headerContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myPlayerHightlightObj, 丏业丟一东丂东丘丛:  true);
        val_2 = 0;
        goto label_3;
        label_8:
        val_1 = this.leagueHeaders[0];
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
        val_2 = 1;
        label_3:
        if(val_2 < this.leagueHeaders.Length)
        {
            goto label_8;
        }
    
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        string val_9;
        System.Object[] val_10;
        var val_11;
        var val_12;
        val_10 = this;
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        this.与丂且下丟丆丅丙丝 = 三丏丑不业丏不丂丈;
        if(null == 0)
        {
            goto label_4;
        }
        
        val_9 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.headerContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.playerContainer, 丏业丟一东丂东丘丛:  false);
        if(((this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌 & 2147483648) != 0) || (this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌 >= this.leagueHeaders.Length))
        {
            goto label_15;
        }
        
        if(this.leagueHeaders[this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌] == 0)
        {
            goto label_15;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueHeaders[this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌], 丏业丟一东丂东丘丛:  true);
        val_11 = 0;
        goto label_20;
        label_32:
        if(this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌 != val_11)
        {
                if(this.leagueHeaders[0] != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.leagueHeaders[0], 丏业丟一东丂东丘丛:  false);
        }
        
        }
        
        val_11 = 1;
        label_20:
        if(val_11 < this.leagueHeaders.Length)
        {
            goto label_32;
        }
        
        return;
        label_15:
        object[] val_3 = new object[1];
        val_10 = val_3;
        val_10[0] = this.与丂且下丟丆丅丙丝.丙丑七万丆万丆且丌;
        UnityEngine.Debug.LogErrorFormat(format:  "LeaderboardsGUI: Can\'t show friend {0} league header", args:  val_3);
        return;
        label_4:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.playerContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.headerContainer, 丏业丟一东丂东丘丛:  false);
        this.placeLabel.text = this.与丂且下丟丆丅丙丝.且丒丛与丞世丙丕丌.ToString();
        this.nameLabel.text = this.与丂且下丟丆丅丙丝.丅业业丟不业丙丏丂;
        if((this.与丂且下丟丆丅丙丝.丈丐世下丞与丂专丏 & 2147483648) != 0)
        {
            goto label_49;
        }
        
        val_9 = this.与丂且下丟丆丅丙丝.丈丐世下丞与丂专丏.ToString();
        if(this.ratingLabel != null)
        {
            goto label_60;
        }
        
        label_61:
        label_60:
        this.ratingLabel.text = val_9;
        if(this.myPlayerHightlightObj == 0)
        {
                return;
        }
        
        val_9 = this.与丂且下丟丆丅丙丝;
        string val_13 = this.与丂且下丟丆丅丙丝.丞丅上丏丂且下丅与;
        val_10 = System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_13);
        val_13 = val_10;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myPlayerHightlightObj, 丏业丟一东丂东丘丛:  val_13);
        return;
        label_49:
        val_12 = null;
        val_12 = null;
        if(this.ratingLabel != null)
        {
            goto label_60;
        }
        
        goto label_61;
    }
    public void U_SelfClick()
    {
        if(this.与丂且下丟丆丅丙丝 == null)
        {
                return;
        }
        
        bool val_4 = this.与丂且下丟丆丅丙丝.丈世七丌丌丈丙丝万;
        val_4 = val_4 + 3;
        var val_5 = ~val_4;
        val_5 = val_5 & 3;
        if(val_5 != 0)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.与丂且下丟丆丅丙丝.丞丅上丏丂且下丅与, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                return;
        }
        
        this.parentWindowObj.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.与丂且下丟丆丅丙丝.丞丅上丏丂且下丅与, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void LeaderboardsFriendsWrapGridItem::万丅与三丝丁丟业丁(bool 丕丁丗丘丟丆一丟丆)));
    }
    public LeaderboardsFriendsWrapGridItem()
    {
    
    }
    private static LeaderboardsFriendsWrapGridItem()
    {
        LeaderboardsFriendsWrapGridItem.丑世不丌世丟上且丕 = "--";
    }
    private void 万丅与三丝丁丟业丁(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentWindowObj.SetActive(value:  true);
    }

}
