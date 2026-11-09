using UnityEngine;
internal sealed class SPVCSubscriptionBuyResubRewardsView : SPViewComponentBase
{
    // Fields
    private ItemRewardListView itemRewardListView;
    private ScrollViewHelper scrollViewHelper;
    private System.Collections.Generic.List<UIRect> rectsToUpdate;
    private Subscription20.丘丛不东丒丆丁丑丁 丅丟丑东上丟丌丗丆;
    
    // Methods
    public override void Setup(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁)
    {
        mem[1152921539235410584] = 且丘丏丁丑与丙与丁;
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
        
            if(this.itemRewardListView != null)
        {
                this.itemRewardListView.丈且东丑丂且万丒丅(丑丟上一三业万万丏:  this.丐下万丑丘专七丌世());
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丁与不七与丕丄丁丛();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丐下万丑丘专七丌世()
    {
        var val_5;
        var val_14;
        System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_1 = new System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>();
        val_14 = this.丅丟丑东上丟丌丗丆.丐丐丟上丁七上丗丞();
        List.Enumerator<T> val_3 = val_14.GetEnumerator();
        label_5:
        if((269031616 & 1) == 0)
        {
            goto label_3;
        }
        
        new TagSystem.三与下丘七丘丌丏丄() = new TagSystem.三与下丘七丘丌丏丄();
        new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_5.丐丏七丌丕丗业且上(), 丆万一不丌且东丐丐:  new TagSystem.三与下丘七丘丌丏丄());
        val_1.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
        goto label_5;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_10 = this.丅丟丑东上丟丌丗丆.丏七世丗丆丒丛丄世().GetEnumerator();
        label_17:
        if((269031616 & 1) == 0)
        {
            goto label_15;
        }
        
        new TagSystem.三与下丘七丘丌丏丄() = new TagSystem.三与下丘七丘丌丏丄(丆万一不丌且东丐丐:  "bonus");
        new PGCompany.丄与丘丑业专丞七丅() = new PGCompany.丄与丘丑业专丞七丅(丈丄不七三万丄丁不:  val_5.丐丏七丌丕丗业且上(), 丆万一不丌且东丐丐:  new TagSystem.三与下丘七丘丌丏丄());
        val_1.Add(item:  new PGCompany.丄与丘丑业专丞七丅());
        goto label_17;
        label_15:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return val_1;
    }
    private void 丁与不七与丕丄丁丛()
    {
        float val_16;
        if(this.itemRewardListView == 0)
        {
                return;
        }
        
        if(this.itemRewardListView.三丂一业万七丟丈一() == 0)
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
        
        val_16 = this.itemRewardListView.三丂一业万七丟丈一().GetSize();
        UnityEngine.Vector3 val_10 = this.itemRewardListView.transform.localPosition;
        if(this.scrollViewHelper.Panel.width < val_16)
        {
                val_16 = this.scrollViewHelper.Panel.width;
        }
        
        val_16 = val_16 * (-0.5f);
        this.itemRewardListView.transform.localPosition = new UnityEngine.Vector3() {x = val_16, y = val_10.y, z = val_10.z};
    }
    public SPVCSubscriptionBuyResubRewardsView()
    {
        val_1 = new PGBehaviour();
    }

}
