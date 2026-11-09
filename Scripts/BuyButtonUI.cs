using UnityEngine;
internal sealed class BuyButtonUI : PGBehaviour
{
    // Fields
    private PGCompany.InventoryItemView priceView;
    private WidgetLayout widgetLayout;
    private bool useFreeState;
    private UnityEngine.GameObject freeState;
    private UnityEngine.GameObject paidState;
    
    // Methods
    public void Setup(PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞)
    {
        UnityEngine.GameObject val_5;
        var val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        val_5 = this.freeState;
        if(this.useFreeState != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.paidState, 丏业丟一东丂东丘丛:  false);
            if((丒世丘丘上丆丝东丞 != null) && (丒世丘丘上丆丝东丞.丂丁丏一丙丛业且丌() >= 1))
        {
                val_6 = null;
            val_5 = this.paidState;
        }
        else
        {
                val_6 = null;
            val_5 = this.freeState;
        }
        
            val_7 = 1;
            val_8 = val_5;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_5, 丏业丟一东丂东丘丛:  false);
            val_8 = this.paidState;
            val_7 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        if(this.priceView != null)
        {
                this.priceView.Setup(丈丄不七三万丄丁不:  丒世丘丘上丆丝东丞);
            if(this.priceView != null)
        {
                UIBasicSprite val_2 = this.priceView.丑一丆丑且丟上业丛();
            if(val_2 != null)
        {
                UnityEngine.Object val_5 = 0;
            val_5 = UnityEngine.Object.op_Inequality(x:  this.priceView.丑一丆丑且丟上业丛(), y:  val_5);
            val_5 = val_5;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  val_5);
        }
        
        }
        
        }
        
        if(this.widgetLayout == null)
        {
                return;
        }
        
        this.widgetLayout.Reposition();
    }
    public BuyButtonUI()
    {
        this.useFreeState = true;
    }

}
