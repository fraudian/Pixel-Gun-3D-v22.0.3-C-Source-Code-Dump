using UnityEngine;
internal class SPViewComponentCommon : SPViewComponentBase
{
    // Fields
    private UILabel titleLabel;
    private UILabel descriptionLabel;
    private PGCompany.TimerUI timerUI;
    private UILabel firstItemTitleLabel;
    private UILabel rarityLabel;
    private UIBasicSprite mainTexture;
    private PGCompany.InventoryItemView mainItemCountView;
    private TagSpecificObject tagSpecificObject;
    private UnityEngine.GameObject blockContainer;
    private UnityEngine.GameObject previewLobbyButton;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        PGCompany.三东丏不丗世丅丌丄 val_17;
        var val_18;
        var val_19;
        var val_20;
        PGCompany.TimerUI val_21;
        var val_22;
        UnityEngine.MonoBehaviour val_23;
        UnityEngine.GameObject val_24;
        UnityEngine.GameObject val_25;
        var val_26;
        PGCompany.东丑丆丗丏丐丟下丄 val_17 = 且丘丏丁丑与丙与丁;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  val_17);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.descriptionLabel, 丕丗丘丑丛与丑业丒:  val_17);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.firstItemTitleLabel, 丕丗丘丑丛与丑业丒:  val_17);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rarityLabel, 丕丗丘丑丛与丑业丒:  val_17);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.mainTexture, 与万丆丛丒万丝丙丑:  val_17);
        if(this.mainItemCountView != null)
        {
                if(val_17 != null)
        {
                val_17 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_17);
        }
        else
        {
                val_17 = 0;
        }
        
            this.mainItemCountView.Setup(丈丄不七三万丄丁不:  val_17);
        }
        
        if(this.tagSpecificObject != null)
        {
                this.tagSpecificObject.丈且东丑丂且万丒丅(丏万且丈丙丁丁且世:  val_17.与不丞丑七丘丁丂丛());
        }
        
        if(((val_17.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "state.purchased")) == true) || ((val_17.七丈丒丒下下且万与().StartsWith(value:  "lb")) == false))
        {
            goto label_20;
        }
        
        val_18 = null;
        val_18 = null;
        if((GiftBannerWindow.丘丆且七丑丘且专丟 == true) || (Initializer.丑七不且上丗丁一世() != 0))
        {
            goto label_20;
        }
        
        val_19 = null;
        val_19 = null;
        val_20 = UnityEngine.Object.op_Equality(x:  Rilisoft.LevelCompleteScript.丗丐丙且丒丙万一丂, y:  0);
        goto label_25;
        label_20:
        val_20 = 0;
        label_25:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.previewLobbyButton, 丏业丟一东丂东丘丛:  false);
        val_21 = this.timerUI;
        long val_12 = (long)val_17.下丒丗丄丌丘不丑丘() - PixelTime.丙三丝下丛丈丌丟下();
        if(val_12 >= 1)
        {
                if(val_21 != null)
        {
                val_21.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_12, 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_21 = this.timerUI;
        }
        
            val_22 = 1;
            val_23 = val_21;
        }
        else
        {
                val_23 = val_21;
            val_22 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_23, 丏业丟一东丂东丘丛:  false);
        if((val_17.与不丞丑七丘丁丂丛().丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "NoBlockContainer")) != true)
        {
                if(与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏() == false)
        {
            goto label_41;
        }
        
        }
        
        val_24 = this.blockContainer;
        val_25 = val_24;
        val_26 = 0;
        goto label_44;
        label_41:
        val_24 = 0;
        val_25 = this.blockContainer;
        val_26 = val_24;
        label_44:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_25, 丏业丟一东丂东丘丛:  false);
    }
    public SPViewComponentCommon()
    {
        val_1 = new PGBehaviour();
    }

}
