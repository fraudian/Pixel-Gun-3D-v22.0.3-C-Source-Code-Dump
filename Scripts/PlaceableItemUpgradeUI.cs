using UnityEngine;
public class PlaceableItemUpgradeUI : PGBehaviour
{
    // Fields
    private PlaceableItemSettings 丑丝一一三丟三三丞;
    protected UILabel titleLabel;
    protected UIBasicSprite texture;
    protected UILabel levelLabel;
    protected UILabel timerlLabel;
    protected UnityEngine.GameObject buttonsHolder;
    protected UnityEngine.GameObject clanRankHolder;
    protected UnityEngine.GameObject finishButton;
    protected UnityEngine.GameObject bigFinishButton;
    protected UnityEngine.GameObject speedUpButton;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfPending;
    private System.Collections.Generic.List<PGCompany.ItemCurrencyUI> speedUpCurrencyUI;
    private System.Collections.Generic.List<PGCompany.ItemCurrencyUI> finishCurrencyUI;
    protected UILabel speedUpLabel;
    protected UILabel clanRankExpLabel;
    private UnityEngine.Coroutine 丕丆上下丕与东丈业;
    
    // Properties
    private PGCompany.三东丏不丗世丅丌丄 专丗专丁丞一专业上 { get; }
    private PGCompany.三东丏不丗世丅丌丄 与丞丗丌业上且上三 { get; }
    private 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈 业一且丂丁且丕丘七 { get; }
    
    // Methods
    private PGCompany.三东丏不丗世丅丌丄 三丛世三下丑丞丂丙()
    {
        return 丂丘丗丗与且丌丁丙.东丗丞丄丌且与丁丙(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    private PGCompany.三东丏不丗世丅丌丄 三丕丑丛丐丆丑且上()
    {
        return 丂丘丗丗与且丌丁丙.七丄丝丏丕上东且丙(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    private 丂丘丗丗与且丌丁丙.与丑下丕丙丛丅一丈 丄丂世丕不丂不丐丆()
    {
        return 丂丘丗丗与且丌丁丙.丑东不丏丑丞丕丏丂(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        UILabel val_26;
        var val_27;
        this.丑丝一一三丟三三丞 = 业世丟丐丘丐专与不;
        if(业世丟丐丘丐专与不 != null)
        {
                if(this.丄丂世丕不丂不丐丆() != null)
        {
                this.gameObject.SetActive(value:  true);
            val_27 = null;
            val_27 = null;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  this.丑丝一一三丟三三丞.丘丄业丞丏与与丅丐());
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  this.丑丝一一三丟三三丞.丑东丐下专丞丕丘世());
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8277"), arg0:  this.丄丂世丕不丂不丐丆().一丛与丙上万丏七上() + 2));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.speedUpLabel, 丕丗丘丑丛与丑业丒:  "-"("-") + 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丂丘丗丗与且丌丁丙.丂丅丛丑丈丟万丗丙(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)(专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丂丘丗丗与且丌丁丙.丂丅丛丑丈丟万丗丙(), 丒且下丘丅丘丛丆且:  false, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.finishButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.speedUpButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bigFinishButton, 丏业丟一东丂东丘丛:  true);
            this.buttonsHolder.SetActive(value:  PGCompany.丂丘丞丂丏七丁丄不.丅丂丅七上丁丒且丌());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanRankHolder, 丏业丟一东丂东丘丛:  PGCompany.丂丘丞丂丏七丁丄不.丅丂丅七上丁丒且丌());
            PlaceableItemSettings val_26 = this.丑丝一一三丟三三丞;
            val_26 = 丂丘丗丗与且丌丁丙.与丑不万丐丆世一丞().Contains(item:  val_26);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPending, 丏业丟一东丂东丘丛:  val_26);
            val_26 = this.clanRankExpLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_26, 丕丗丘丑丛与丑业丒:  (丌丅且丗七丘丅丛丑.业丏丐下专东万世丂(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.丒丕丕且业丕丈万丛)) + (丌丅且丗七丘丅丛丑.丂丐丝丏且世与且丄 * this.三丕丑丛丐丆丑且上().丂丁丏一丙丛业且丌()).ToString());
            this.且丒不丙丌丅丑丂丄();
            return;
        }
        
        }
        
        this.gameObject.SetActive(value:  false);
        if(this.丕丆上下丕与东丈业 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
        this.丕丆上下丕与东丈业 = 0;
    }
    private void 丙丑丘业丕丗丗不丘()
    {
        object val_18;
        UILabel val_19;
        var val_20;
        UnityEngine.GameObject val_21;
        var val_22;
        val_18 = this;
        PlaceableItemSettings val_18 = this.丑丝一一三丟三三丞;
        val_18 = 丂丘丗丗与且丌丁丙.与丑不万丐丆世一丞().Contains(item:  val_18);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfPending, 丏业丟一东丂东丘丛:  val_18);
        val_19 = 1152921505065418752;
        if((((((FriendsController.丝丗专上三不丄丑丑() >= 1) && (this.丑丝一一三丟三三丞.IsUnknown != true)) && (this.丄丂世丕不丂不丐丆() != null)) && ((this.丄丂世丕不丂不丐丆().丄丟与丏丄七丒且丗() - FriendsController.丝丗专上三不丄丑丑()) >= 1)) && (this.三丕丑丛丐丆丑且上() != null)) && (this.三丛世三下丑丞丂丙() != null))
        {
                this.finishCurrencyUI.ForEach(action:  new System.Action<PGCompany.ItemCurrencyUI>(object:  this, method:  System.Void PlaceableItemUpgradeUI::丗一丁七七东业丘丏(PGCompany.ItemCurrencyUI 三丟东丕丄丄下下丑)));
            val_20 = null;
            val_20 = null;
            val_19 = this.clanRankExpLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_19, 丕丗丘丑丛与丑业丒:  (丌丅且丗七丘丅丛丑.业丏丐下专东万世丂(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.丒丕丕且业丕丈万丛)) + (丌丅且丗七丘丅丛丑.丂丐丝丏且世与且丄 * this.三丕丑丛丐丆丑且上().丂丁丏一丙丛业且丌()).ToString());
            this.buttonsHolder.SetActive(value:  true);
            val_21 = this.clanRankHolder;
            val_22 = 1;
        }
        else
        {
                this.buttonsHolder.SetActive(value:  false);
            val_18 = this.clanRankHolder;
            val_21 = val_18;
            val_22 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_21, 丏业丟一东丂东丘丛:  false);
    }
    private void 且丒不丙丌丅丑丂丄()
    {
        if(this.丕丆上下丕与东丈业 != null)
        {
                this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
            this.丕丆上下丕与东丈业 = 0;
        }
        
        this.丕丆上下丕与东丈业 = this.StartCoroutine(routine:  this.与东丆丟丞丈一丕上());
    }
    private void 一丛丄七一且东三七()
    {
        if(this.丕丆上下丕与东丈业 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丕丆上下丕与东丈业);
        this.丕丆上下丕与东丈业 = 0;
    }
    private System.Collections.IEnumerator 与东丆丟丞丈一丕上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlaceableItemUpgradeUI.业丒丆一下丘丁一丞();
    }
    public void FinishButtonPressed()
    {
        丂丘丗丗与且丌丁丙.下七上丐上丒丙丏丁(业世丟丐丘丐专与不:  this.丑丝一一三丟三三丞);
    }
    public void SpeedUpButtonPressed()
    {
    
    }
    public PlaceableItemUpgradeUI()
    {
    
    }
    private void 丗一丁七七东业丘丏(PGCompany.ItemCurrencyUI 三丟东丕丄丄下下丑)
    {
        三丟东丕丄丄下下丑.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  this.三丕丑丛丐丆丑且上(), 丗丂丞丛丒丒丟万丗:  false);
    }

}
