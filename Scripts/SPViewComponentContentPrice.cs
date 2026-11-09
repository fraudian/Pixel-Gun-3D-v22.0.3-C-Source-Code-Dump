using UnityEngine;
internal sealed class SPViewComponentContentPrice : SPViewComponentBase
{
    // Fields
    internal bool forceShow;
    private PGCompany.InventoryItemView oldPriceView;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        this.gameObject.SetActive(value:  false);
        if(this.forceShow != true)
        {
                if((且丘丏丁丑与丙与丁.与不丞丑七丘丁丂丛().且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  "show-old-price")) == false)
        {
                return;
        }
        
        }
        
        if((PGCompany.丁丑上丞业丞丟丛上.丑丕丈丈不不且丑且(丈丄不七三万丄丁不:  且丘丏丁丑与丙与丁.丄丌丛丑万且丞丙丏())) == false)
        {
                return;
        }
        
        if(且丘丏丁丑与丙与丁.丄丌丛丑万且丞丙丏().丂丁丏一丙丛业且丌() < 1)
        {
                return;
        }
        
        this.oldPriceView.Setup(丈丄不七三万丄丁不:  且丘丏丁丑与丙与丁.丄丌丛丑万且丞丙丏());
        this.gameObject.SetActive(value:  true);
    }
    public SPViewComponentContentPrice()
    {
        val_1 = new PGBehaviour();
    }

}
