using UnityEngine;
internal sealed class ArsenalNestButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject holder;
    private UILabel label;
    private PGCompany.TimerUI timerUi;
    
    // Properties
    private bool 东丅丞丁丗万且丁丗 { get; }
    
    // Methods
    private bool 丒万万三丂丆且丁一()
    {
        var val_5;
        if(Rilisoft.Nest.丑七不且上丗丁一世() != 0)
        {
                val_5 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() ^ 1;
            return (bool)val_5 & 1;
        }
        
        val_5 = 0;
        return (bool)val_5 & 1;
    }
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        UILabel val_12;
        bool val_13;
        var val_14;
        val_12 = this;
        val_13 = this.丒万万三丂丆且丁一();
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  val_13);
        if(this.holder.丒万万三丂丆且丁一() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUi, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.label, 丏业丟一东丂东丘丛:  false);
        val_13 = 1152921505443745792;
        if(Rilisoft.Nest.丑七不且上丗丁一世().专丟丒世丈上丞下与() != false)
        {
                val_14 = null;
            val_12 = this.label;
        }
        else
        {
                System.Nullable<System.Int64> val_7 = Rilisoft.Nest.丑七不且上丗丁一世().TimeLeft;
            if(val_7.HasValue.丐丏七丌丕丗业且上() < 1)
        {
                return;
        }
        
            if(( & 1) == 0)
        {
                return;
        }
        
            System.Nullable<System.Int64> val_10 = Rilisoft.Nest.丑七不且上丗丁一世().TimeLeft;
            val_13 = ;
            this.timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  891852992, 三丘丄丕丂丏东不丛:  new System.Action(object:  this, method:  System.Void ArsenalNestButton::丝一丅丆三东丂丞七()), 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
            val_14 = null;
            val_12 = this.timerUi;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_12, 丏业丟一东丂东丘丛:  true);
    }
    public void U_OnPress()
    {
        var val_5;
        if(this.丒万万三丂丆且丁一() == false)
        {
                return;
        }
        
        if(Rilisoft.Nest.丑七不且上丗丁一世().专丟丒世丈上丞下与() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        Rilisoft.Nest.丑七不且上丗丁一世().丈且丂丞丒丘丄不丅(丘丒丅三丞丞丛丛丌:  ShopNGUIController.丏丙丅丕一丑丕丑丑.bannersHolder);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.一丘丂世丐丒丄丂一(上三丂三丈丂丆丏丝:  48, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
        this.丝一丅丆三东丂丞七();
    }
    public ArsenalNestButton()
    {
    
    }

}
