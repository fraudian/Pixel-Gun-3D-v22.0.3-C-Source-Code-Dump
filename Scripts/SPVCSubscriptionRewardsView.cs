using UnityEngine;
internal sealed class SPVCSubscriptionRewardsView : SPViewComponentBase
{
    // Fields
    private SPVCSubscriptionRewardsView.丅且丂丐丘三万万丗 _rewardsToShow;
    private ItemListUI itemListUI;
    private ScrollViewHelper scrollViewHelper;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private Subscription20.丘丛不东丒丆丁丑丁 丅丟丑东上丟丌丗丆;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539237352392] = 且丘丏丁丑与丙与丁;
        if(且丘丏丁丑与丙与丁 != null)
        {
                Subscription20.丒丗业丑丛东上下一 val_2 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与());
        }
        else
        {
                Subscription20.丒丗业丑丛东上下一 val_4 = Subscription20.丑丆丑丛世丁七下东.丈丛丘丗丌东丞丌丒(一丗与一专丙丙丅丄:  0.七丈丒丒下下且万与());
        }
        
        if(且丘丏丁丑与丙与丁.不业丙丒丂丞下丆丙() == 27)
        {
                this.丅丟丑东上丟丌丗丆 = Subscription20.万丞且丐世丙丄丄丌.丑七不且上丗丁一世().专三丞丄丕丐丟丝丏(丞世不丒下上上丝丑:  Subscription20.丑丆丑丛世丁七下东.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  且丘丏丁丑与丙与丁.七丈丒丒下下且万与()));
            专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
            if(this.scrollViewHelper != null)
        {
                this.scrollViewHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
        }
        
            if(this.itemListUI != null)
        {
                this.itemListUI.丈且东丑丂且万丒丅(丝丛丟世丁与一万丞:  this.丐下万丑丘专七丌世(丙丏丂丒一丒丏丂东:  this._rewardsToShow));
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丁与不七与丕丄丁丛();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丐下万丑丘专七丌世(SPVCSubscriptionRewardsView.丅且丂丐丘三万万丗 丙丏丂丒一丒丏丂东)
    {
        if(丙丏丂丒一丒丏丂东 == 3)
        {
            goto label_0;
        }
        
        if(丙丏丂丒一丒丏丂东 == 2)
        {
            goto label_1;
        }
        
        if(丙丏丂丒一丒丏丂东 != 1)
        {
                return 0;
        }
        
        if(this.丅丟丑东上丟丌丗丆 != null)
        {
                return this.丅丟丑东上丟丌丗丆.丐丐丟上丁七上丗丞();
        }
        
        return this.丅丟丑东上丟丌丗丆.丐丐丟上丁七上丗丞();
        label_0:
        if(this.丅丟丑东上丟丌丗丆 != null)
        {
                return this.丅丟丑东上丟丌丗丆.丏七世丗丆丒丛丄世();
        }
        
        return this.丅丟丑东上丟丌丗丆.丏七世丗丆丒丛丄世();
        label_1:
        if(this.丅丟丑东上丟丌丗丆 != null)
        {
                return this.丅丟丑东上丟丌丗丆.丘丘丗丂丏丘一一且();
        }
        
        return this.丅丟丑东上丟丌丗丆.丘丘丗丂丏丘一一且();
    }
    private void 丁与不七与丕丄丁丛()
    {
        float val_16;
        if(this.itemListUI == 0)
        {
                return;
        }
        
        if(this.itemListUI.三丂一业万七丟丈一() == 0)
        {
                return;
        }
        
        if(this.scrollViewHelper == 0)
        {
                return;
        }
        
        if(this.scrollViewHelper.Panel == 0)
        {
                return;
        }
        
        val_16 = this.itemListUI.三丂一业万七丟丈一().GetSize();
        UnityEngine.Vector3 val_10 = this.itemListUI.transform.localPosition;
        if(this.scrollViewHelper.Panel.width < val_16)
        {
                val_16 = this.scrollViewHelper.Panel.width;
        }
        
        val_16 = val_16 * (-0.5f);
        this.itemListUI.transform.localPosition = new UnityEngine.Vector3() {x = val_16, y = val_10.y, z = val_10.z};
    }
    public SPVCSubscriptionRewardsView()
    {
        val_1 = new PGBehaviour();
    }

}
