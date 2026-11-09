using UnityEngine;
public class LeaderboardsCraftersWrapGridItem : DynamicWrapGridItem
{
    // Fields
    private Rilisoft.ButtonHandler 丆丐丘丘世万丛万丁;
    private 丑丈专丙丅丝丟丅万 下丄丂业丟丁丁上下;
    private UnityEngine.GameObject firstPlaceObj;
    private UILabel likesLabel;
    private UnityEngine.GameObject myPlayerHightlightObj;
    private UILabel nameLabel;
    private UnityEngine.GameObject parentWindowObj;
    private UILabel placeLabel;
    private UnityEngine.GameObject secondPlaceObj;
    private UnityEngine.GameObject thirdPlaceObj;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        if(this.myPlayerHightlightObj != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myPlayerHightlightObj, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.firstPlaceObj != 0)
        {
                this.firstPlaceObj.SetActive(value:  true);
        }
        
        if(this.secondPlaceObj != 0)
        {
                this.secondPlaceObj.SetActive(value:  true);
        }
        
        if(this.thirdPlaceObj == 0)
        {
                return;
        }
        
        this.thirdPlaceObj.SetActive(value:  true);
    }
    public override void UpdateContent(object 三丏丑不业丏不丂丈)
    {
        string val_19;
        bool val_20;
        var val_22;
        UnityEngine.GameObject val_23;
        UnityEngine.GameObject val_24;
        val_20 = this;
        if(三丏丑不业丏不丂丈 == null)
        {
                return;
        }
        
        if(this.placeLabel != 0)
        {
                this.placeLabel.text = System.String.alignConst;
        }
        
        if(System.String.alignConst != 0)
        {
            goto label_8;
        }
        
        if(this.firstPlaceObj == 0)
        {
            goto label_11;
        }
        
        val_22 = 1;
        goto label_13;
        label_11:
        label_8:
        if(this.secondPlaceObj == 0)
        {
            goto label_17;
        }
        
        this.secondPlaceObj.SetActive(value:  true);
        if(this.firstPlaceObj == 0)
        {
            goto label_48;
        }
        
        val_23 = this.firstPlaceObj;
        if(val_23 != null)
        {
            goto label_49;
        }
        
        goto label_23;
        label_17:
        if(this.thirdPlaceObj == 0)
        {
            goto label_27;
        }
        
        this.thirdPlaceObj.SetActive(value:  true);
        if(this.firstPlaceObj != 0)
        {
                this.firstPlaceObj.SetActive(value:  false);
        }
        
        if(this.secondPlaceObj == 0)
        {
            goto label_52;
        }
        
        val_24 = this.secondPlaceObj;
        if(val_24 != null)
        {
            goto label_53;
        }
        
        goto label_37;
        label_27:
        if(this.placeLabel != 0)
        {
                this.placeLabel.text = (UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 1).ToString();
        }
        
        if(this.firstPlaceObj == 0)
        {
            goto label_44;
        }
        
        val_22 = 0;
        label_13:
        this.firstPlaceObj.SetActive(value:  false);
        label_44:
        if(this.secondPlaceObj == 0)
        {
            goto label_48;
        }
        
        val_23 = this.secondPlaceObj;
        if(val_23 != null)
        {
            goto label_49;
        }
        
        label_23:
        label_49:
        val_23.SetActive(value:  false);
        label_48:
        if(this.thirdPlaceObj == 0)
        {
            goto label_52;
        }
        
        val_24 = this.thirdPlaceObj;
        if(val_24 != null)
        {
            goto label_53;
        }
        
        label_37:
        label_53:
        val_24.SetActive(value:  false);
        label_52:
        this.下丄丂业丟丁丁上下 = 三丏丑不业丏不丂丈;
        this.nameLabel.text = 三丏丑不业丏不丂丈;
        val_19 = this.下丄丂业丟丁丁上下.丆专丕丘丏丂与丏丑.ToString();
        this.likesLabel.text = val_19;
        if(this.myPlayerHightlightObj == 0)
        {
                return;
        }
        
        val_19 = this.下丄丂业丟丁丁上下;
        string val_19 = this.下丄丂业丟丁丁上下.丞丅上丏丂且下丅与;
        val_20 = System.String.op_Equality(a:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), b:  val_19);
        val_19 = val_20;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myPlayerHightlightObj, 丏业丟一东丂东丘丛:  val_19);
    }
    public void U_SelfClick()
    {
        if((System.String.op_Equality(a:  this.下丄丂业丟丁丁上下.丞丅上丏丂且下丅与, b:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false)
        {
                return;
        }
        
        this.parentWindowObj.SetActive(value:  false);
        FriendsController.丗七万丝七下丅丞丏(丞丅上丏丂且下丅与:  this.下丄丂业丟丁丁上下.丞丅上丏丂且下丅与, 丁丅丈丌丟世丗丗丟:  2, 丅丗专丕丑上丝下丕:  new System.Action<System.Boolean>(object:  this, method:  System.Void LeaderboardsCraftersWrapGridItem::丆万丒三丝丑业世与(bool 丕丁丗丘丟丆一丟丆)));
    }
    public LeaderboardsCraftersWrapGridItem()
    {
    
    }
    private void 丆万丒三丝丑业世与(bool 丕丁丗丘丟丆一丟丆)
    {
        this.parentWindowObj.SetActive(value:  true);
    }

}
