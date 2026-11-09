using UnityEngine;
public class LeaderboardsTournamentWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private static readonly string 丑世不丌世丟上且丕;
    private UnityEngine.GameObject parentWindowObj;
    private UnityEngine.GameObject awardContainer;
    private UnityEngine.GameObject playerContainer;
    private UnityEngine.GameObject waitingChestWinnerContainer;
    private UnityEngine.GameObject lookingPlayerContainer;
    private UnityEngine.GameObject noPlayersContainer;
    private UnityEngine.GameObject topRequirementContainer;
    private UITable rewardTable;
    private UILabel rewardLabel;
    private UIBasicSprite rewardEggSprite;
    private UILabel rewardGemsLabel;
    private UILabel rewardCoinsLabel;
    private UILabel rewardSuper1label;
    private UITextureMasked rewardSuper1Texture;
    private UILabel rewardSuper2label;
    private UITextureMasked rewardSuper2Texture;
    private UnityEngine.GameObject rewardLeagueDownArrowObj;
    private UnityEngine.GameObject rewardLeagueUpArrowObj;
    private UISprite rewardLeagueChangeShieldSprite;
    private UnityEngine.GameObject[] playerPlaceObjs;
    private UILabel placeLabel;
    private UILabel nameLabel;
    private UILabel ratingLabel;
    private UnityEngine.GameObject myPlayerHightlightObj;
    private UnityEngine.GameObject playerBottomPlayerFrame;
    private UnityEngine.GameObject playerSimpleFrame;
    private UnityEngine.GameObject playerChestContainerObj;
    private UITextureMasked playerChestSprite;
    private UnityEngine.GameObject playerLoadingChestObj;
    private UILabel lookingPlayerPlaceLabel;
    private UILabel topRequirementShieldCountLabel;
    private 下七丒世丝丗七专丒 <一与业业丁丁丅丞一>k__BackingField;
    
    // Properties
    public 下七丒世丝丗七专丒 丙丏丆一丈丂专丛丛 { get; set; }
    
    // Methods
    public 下七丒世丝丗七专丒 get_tournamentItem()
    {
        return (下七丒世丝丗七专丒)this.<一与业业丁丁丅丞一>k__BackingField;
    }
    private void 与丝丄丄丆丑世丙七(下七丒世丝丗七专丒 丙业与丙丗丝不丈东)
    {
        this.<一与业业丁丁丅丞一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void Awake()
    {
        var val_1;
        this.Awake();
        this.playerContainer.SetActive(value:  true);
        this.waitingChestWinnerContainer.SetActive(value:  true);
        this.awardContainer.SetActive(value:  true);
        this.lookingPlayerContainer.SetActive(value:  true);
        this.noPlayersContainer.SetActive(value:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.topRequirementContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.placeLabel, 丏业丟一东丂东丘丛:  true);
        this.myPlayerHightlightObj.SetActive(value:  true);
        val_1 = 0;
        goto label_9;
        label_13:
        this.playerPlaceObjs[0].SetActive(value:  true);
        val_1 = 1;
        label_9:
        if(val_1 < this.playerPlaceObjs.Length)
        {
            goto label_13;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerChestContainerObj, 丏业丟一东丂东丘丛:  true);
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        this.<一与业业丁丁丅丞一>k__BackingField = 三丏丑不业丏不丂丈;
    }
    private string 下丟丝丝世且丄丐丏(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
    {
        var val_1;
        if(丙丑七万丆万丆且丌 <= 6)
        {
                val_1 = mem[130689104 + (丙丑七万丆万丆且丌) << 3];
            val_1 = 130689104 + (丙丑七万丆万丆且丌) << 3;
            return (string)val_1;
        }
        
        val_1 = "";
        return (string)val_1;
    }
    public void U_SelfClick()
    {
        if((this.<一与业业丁丁丅丞一>k__BackingField) == null)
        {
                return;
        }
        
        if((this.<一与业业丁丁丅丞一>k__BackingField.丕丒丒世一丏丌上且) == true)
        {
                return;
        }
        
        if((this.<一与业业丁丁丅丞一>k__BackingField.不三丏万丙丝丝丏丕) != false)
        {
                return;
        }
        
        if((this.<一与业业丁丁丅丞一>k__BackingField.专丞上七七且丝七丗) == null)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.<一与业业丁丁丅丞一>k__BackingField.专丞上七七且丝七丗.id, b:  System.String.alignConst)) == true)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.<一与业业丁丁丅丞一>k__BackingField.专丞上七七且丝七丗.id, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
                return;
        }
        
        this.parentWindowObj.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.<一与业业丁丁丅丞一>k__BackingField.专丞上七七且丝七丗.id, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void LeaderboardsTournamentWrapGridItem::丛丝且丌东丆丛丟丟(bool 丕丁丗丘丟丆一丟丆)));
    }
    public LeaderboardsTournamentWrapGridItem()
    {
    
    }
    private static LeaderboardsTournamentWrapGridItem()
    {
        LeaderboardsTournamentWrapGridItem.丑世不丌世丟上且丕 = "--";
    }
    private void 丛丝且丌东丆丛丟丟(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentWindowObj.SetActive(value:  true);
    }

}
