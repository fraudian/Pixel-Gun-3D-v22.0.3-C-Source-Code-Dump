using UnityEngine;
public class AlmanachEndlessScrollCell : EndlessScrollCell
{
    // Fields
    internal PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与;
    private int spacing;
    private UIWidget mainWidget;
    private UITextureMasked texture;
    private UIBasicSprite silhouetteTexture;
    private System.Collections.Generic.List<UILabel> name;
    private System.Collections.Generic.List<UILabel> number;
    private UnityEngine.GameObject selectedGO;
    private UnityEngine.GameObject silhouetteGO;
    private UnityEngine.GameObject purchasedGO;
    private UnityEngine.GameObject emptyGO;
    private UnityEngine.GameObject lockedGO;
    private OfferItemView rewardUi;
    private UnityEngine.GameObject alternativeBuyUI;
    private CurrencyUI alternativePriceUI;
    private UnityEngine.GameObject alternativeBuyButtonEnabled;
    private UnityEngine.GameObject alternativeBuyButtonDisabled;
    private UnityEngine.GameObject skinsIndicator;
    
    // Methods
    public override void OnSelectStateUpdate()
    {
        this.OnSelectStateUpdate();
        this.丈且东丑丂且万丒丅(一业一丕丅下业世与:  this.一业一丕丅下业世与);
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
    {
        object val_38;
        UnityEngine.GameObject val_39;
        var val_40;
        bool val_41;
        var val_42;
        UnityEngine.GameObject val_43;
        var val_44;
        bool val_45;
        bool val_46;
        bool val_47;
        val_38 = this;
        this.一业一丕丅下业世与 = 一业一丕丅下业世与;
        mem[1152921524325418672] = "";
        val_39 = this.emptyGO;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  (一业一丕丅下业世与 == 0) ? 1 : 0);
        if(一业一丕丅下业世与 == null)
        {
            goto label_3;
        }
        
        mem[1152921524325418672] = 一业一丕丅下业世与.业东丅东丌上丗丑不().ToString();
        bool val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        if((PGCompany.丌东丛不丅三下业上.不与与丈丝丌丑丒丞(一业一丕丅下业世与:  一业一丕丅下业世与)) == 0)
        {
            goto label_7;
        }
        
        if((val_7 | (~一业一丕丅下业世与.丄丕三丄专丆丛丙专())) == false)
        {
            goto label_8;
        }
        
        label_13:
        val_40 = 0;
        val_41 = 0;
        val_42 = 1;
        goto label_9;
        label_3:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  0);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.silhouetteTexture, 与万丆丛丒万丝丙丑:  0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.name, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.number, 丕丗丘丑丛与丑业丒:  "");
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedGO, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.purchasedGO, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.silhouetteGO, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedGO, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.texture, 丏业丟一东丂东丘丛:  false);
        val_43 = this.skinsIndicator;
        val_44 = 0;
        goto label_12;
        label_7:
        if(val_7 == true)
        {
            goto label_13;
        }
        
        label_8:
        val_42 = 0;
        val_41 = (~与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘()) & 1;
        val_40 = 1;
        label_9:
        this.世七七且专丌上专丘(丙业与丙丗丝不丈东:  val_41);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  一业一丕丅下业世与);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.silhouetteTexture, 与万丆丛丒万丝丙丑:  一业一丕丅下业世与.丗丁丆丝丐丆丛与丕());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.name, 丕丗丘丑丛与丑业丒:  一业一丕丅下业世与);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.number, 丕丗丘丑丛与丑业丒:  "#" + 一业一丕丅下业世与.丏万东丐丛不丛不世().ToString());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lockedGO, 丏业丟一东丂东丘丛:  true);
        if((val_40 & 1) != 0)
        {
                val_45 = 0;
        }
        else
        {
                val_45 = this.Selected;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.selectedGO, 丏业丟一东丂东丘丛:  val_45);
        if((val_40 & 1) != 0)
        {
                val_46 = 0;
        }
        else
        {
                val_46 = val_7 | this.Selected;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.texture, 丏业丟一东丂东丘丛:  val_46);
        if((val_40 & 1) == 0)
        {
                if(this.Selected == false)
        {
            goto label_27;
        }
        
        }
        
        val_47 = 0;
        goto label_28;
        label_27:
        val_47 = (~val_7) & 1;
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.silhouetteGO, 丏业丟一东丂东丘丛:  val_47);
        this.purchasedGO.SetActive(value:  val_42 & val_7);
        if(this.Selected != false)
        {
                if((上且丁万与丌下丐上.丙丛丘上万丆丝丄七(一业一丕丅下业世与:  一业一丕丅下业世与)) != false)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Give reward for weapon: "("Give reward for weapon: ") + 一业一丕丅下业世与);
        }
        
        }
        
        if(val_7 != false)
        {
                if((上且丁万与丌下丐上.丟万下专丟上业丁下(一业一丕丅下业世与:  一业一丕丅下业世与)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardUi, 丏业丟一东丂东丘丛:  false);
        }
        else
        {
                Rilisoft.OfferItem val_24 = 上且丁万与丌下丐上.丕丏丂一与万丟专丙(一业一丕丅下业世与:  一业一丕丅下业世与);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.rewardUi, 丏业丟一东丂东丘丛:  (val_24 != 0) ? 1 : 0);
            this.rewardUi.Setup(与且专丈不万东一万:  val_24);
        }
        
        }
        
        this.丛丄且万丅丝丝丐与();
        上且丁万与丌下丐上.丑丄丘万万丄丑丁业(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void AlmanachEndlessScrollCell::丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)));
        上且丁万与丌下丐上.丈与丞丒丂丟丗一丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.丟丝东丈丐丙三下丛>(object:  this, method:  System.Void AlmanachEndlessScrollCell::丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)));
        val_39 = this.skinsIndicator;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_39, 丏业丟一东丂东丘丛:  false);
        if(DeveloperConsoleController.丙丒丛一丞下三且一() == false)
        {
                return;
        }
        
        if((丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  一业一丕丅下业世与.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌()).Count) < 1)
        {
                return;
        }
        
        val_38 = this.skinsIndicator;
        val_44 = 1;
        val_43 = val_38;
        label_12:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  true);
    }
    private void 丒丘丂一丁丈丘上且(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与)
    {
        if(this == 0)
        {
                return;
        }
        
        if(一业一丕丅下业世与 == null)
        {
                return;
        }
        
        if(this.一业一丕丅下业世与 == null)
        {
                return;
        }
        
        if(this.一业一丕丅下业世与.业东丅东丌上丗丑不() != 一业一丕丅下业世与.业东丅东丌上丗丑不())
        {
                return;
        }
        
        this.丈且东丑丂且万丒丅(一业一丕丅下业世与:  一业一丕丅下业世与);
    }
    private void 丛丄且万丅丝丝丐与()
    {
        CurrencyUI val_8;
        CurrencyUI val_9;
        val_8 = this;
        this.alternativeBuyUI.SetActive(value:  false);
        if(this.Selected == false)
        {
                return;
        }
        
        this.alternativeBuyUI.SetActive(value:  true);
        丈丞丕丘丕丗与上一 val_2 = 上且丁万与丌下丐上.丁上丄丐丞丐专丘丛(一业一丕丅下业世与:  this.一业一丕丅下业世与);
        val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if((val_2 != null) && ((val_9.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  this.一业一丕丅下业世与.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != true))
        {
                if(val_2.丟丂丞不专丆万丒世() >= 1)
        {
                val_9 = this.alternativePriceUI;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_9, 丏业丟一东丂东丘丛:  true);
            val_8 = this.alternativePriceUI;
            val_8.丈且东丑丂且万丒丅(万丐丏丐丒万不丟三:  val_2);
            return;
        }
        
        }
        
        val_8 = this.alternativePriceUI;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  false);
    }
    public void AlternativeBuyButtonPressed()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(AlmanachMainUI.instance == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        AlmanachMainUI.instance.丅丞不丌丐七丈丄不(一业一丕丅下业世与:  this.一业一丕丅下业世与);
    }
    public AlmanachEndlessScrollCell()
    {
        this.spacing = 5;
    }

}
