using UnityEngine;
internal sealed class ClanBuildingInvestmentView : PGBehaviour
{
    // Fields
    private System.Action 不丘丄丙丙丞丈三丞;
    private UILabel investmentParts_label;
    private UISprite allPartsBar;
    private UISprite investmentPartsBar;
    private UnityEngine.GameObject moreButton;
    private UnityEngine.GameObject lessButton;
    private System.Collections.Generic.List<PGCompany.InventoryItemView> investPriceViews;
    private System.Collections.Generic.List<UnityEngine.GameObject> investButtons;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    private int 丒丕三丌丒丑世丙丄;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丞下丗丅且上且上丟;
    internal static readonly System.Collections.Generic.List<BankView.BankViewTab> 丑丝专丐与与业丏丗;
    
    // Methods
    internal void 专丞专丑万且三丒丌(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.不丘丄丙丙丞丈三丞, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不丘丄丙丙丞丈三丞 != 1152921536558359208);
    
    }
    internal void 丙丁丂不业丆丒东业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.不丘丄丙丙丞丈三丞, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.不丘丄丙丙丞丈三丞 != 1152921536558495784);
    
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 上丟专三丙丅丆丛且)
    {
        this.丛不丈不丙丟不三上 = 上丟专三丙丅丆丛且;
        this.丒丕三丌丒丑世丙丄 = 0;
        this.UpdateView();
    }
    public void UpdateView()
    {
        int val_24;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_25;
        var val_26;
        var val_27;
        if(this.丛不丈不丙丟不三上.丙丅丗丏丆丆世世丙() == false)
        {
            goto label_2;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moreButton, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lessButton, 丏业丟一东丂东丘丛:  true);
        val_24 = UnityEngine.Mathf.Clamp(value:  this.丒丕三丌丒丑世丙丄, min:  0, max:  this.丛不丈不丙丟不三上.丌与一丏丏丌不不丒());
        this.丒丕三丌丒丑世丙丄 = val_24;
        if(val_24 <= 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lessButton, 丏业丟一东丂东丘丛:  false);
            val_24 = this.丒丕三丌丒丑世丙丄;
        }
        
        if(val_24 >= this.丛不丈不丙丟不三上.丌与一丏丏丌不不丒())
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moreButton, 丏业丟一东丂东丘丛:  false);
        }
        
        float val_24 = (float)this.丛不丈不丙丟不三上.且丆丟业丞丕丑上且();
        val_24 = val_24 / (float)this.丛不丈不丙丟不三上.丏丈丁专专丘丒丂丂();
        this.allPartsBar.fillAmount = val_24;
        float val_25 = (float)this.丒丕三丌丒丑世丙丄 + this.丛不丈不丙丟不三上.且丆丟业丞丕丑上且();
        val_25 = val_25 / (float)this.丛不丈不丙丟不三上.丏丈丁专专丘丒丂丂();
        this.investmentPartsBar.fillAmount = val_25;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.investmentParts_label, 丕丗丘丑丛与丑业丒:  this.丒丕三丌丒丑世丙丄);
        val_25 = PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丁丗丌且丄下丆丐丄(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不(), 丞三丑不丆丁丄丐上:  this.丒丕三丌丒丑世丙丄);
        this.丞下丗丅且上且上丟 = val_25;
        val_26 = 0;
        goto label_25;
        label_41:
        if((val_26 < this.investPriceViews.Count) && (val_26 < this.investButtons.Count))
        {
                this.investPriceViews.Item[0].Setup(丈丄不七三万丄丁不:  this.丞下丗丅且上且上丟.Item[0]);
            if(val_26 < this.investButtons.Count)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.investButtons.Item[0], 丏业丟一东丂东丘丛:  (this.丞下丗丅且上且上丟.Item[0].丂丁丏一丙丛业且丌() > 0) ? 1 : 0);
        }
        
        }
        
        val_25 = this.丞下丗丅且上且上丟;
        val_26 = 1;
        label_25:
        if(val_26 < val_25.Count)
        {
            goto label_41;
        }
        
        return;
        label_2:
        this.丒丕三丌丒丑世丙丄 = 0;
        this.allPartsBar.fillAmount = 1f;
        this.investmentPartsBar.fillAmount = 0f;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.moreButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.lessButton, 丏业丟一东丂东丘丛:  false);
        val_27 = null;
        val_27 = null;
        if((ClanBuildingInvestmentView.<>c.<>9__14_0) == null)
        {
            goto label_48;
        }
        
        label_53:
        this.investButtons.ForEach(action:  ClanBuildingInvestmentView.<>c.<>9__14_0);
        return;
        label_48:
        ClanBuildingInvestmentView.<>c.<>9__14_0 = new System.Action<UnityEngine.GameObject>(object:  ClanBuildingInvestmentView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanBuildingInvestmentView.<>c::不丅丙七丅丈且丗丝(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(this.investButtons != null)
        {
            goto label_53;
        }
        
        goto label_53;
    }
    public void U_GoToBank()
    {
        null = null;
        this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
    }
    private void 万丞丌七丈丄丙东万(string 丏丂不专上丘丂不丅)
    {
        var val_5 = null;
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  ClanBuildingInvestmentView.丑丝专丐与与业丏丗);
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanBuildingInvestmentView::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanBuildingInvestmentView::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    public void U_MoreParts()
    {
        int val_1 = this.丒丕三丌丒丑世丙丄;
        val_1 = val_1 + 1;
        this.丒丕三丌丒丑世丙丄 = val_1;
        this.UpdateView();
    }
    public void U_LessParts()
    {
        int val_1 = this.丒丕三丌丒丑世丙丄;
        val_1 = val_1 - 1;
        this.丒丕三丌丒丑世丙丄 = val_1;
        this.UpdateView();
    }
    public void U_InvestSilver()
    {
        PGCompany.三东丏不丗世丅丌丄 val_15;
        if(this.丞下丗丅且上且上丟 == null)
        {
                return;
        }
        
        if(this.丞下丗丅且上且上丟.Count < 1)
        {
                return;
        }
        
        val_15 = this.丞下丗丅且上且上丟.Item[0];
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_15, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                val_15 = this.丛不丈不丙丟不三上.业东丅东丌上丗丑不();
            PGCompany.三东丏不丗世丅丌丄 val_9 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  this.丛不丈不丙丟不三上.丞万丒丌丈东丄业下().业东丅东丌上丗丑不());
            val_9.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丒丕三丌丒丑世丙丄);
            PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丒不丅丅业世丟不不(丘丗丈东下业丟丟丑:  val_15, 不且丐一丆丛丙丙丒:  val_9, 上七丂丏丅业丞且且:  this.丞下丗丅且上且上丟.Item[0].业东丅东丌上丗丑不());
            this.UpdateView();
            if(this.不丘丄丙丙丞丈三丞 == null)
        {
                return;
        }
        
            this.不丘丄丙丙丞丈三丞.Invoke();
            return;
        }
        
        this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  this.丞下丗丅且上且上丟.Item[0].业上丙丞丐丄丆丅七());
    }
    public void U_InvestGems()
    {
        PGCompany.三东丏不丗世丅丌丄 val_15;
        if(this.丞下丗丅且上且上丟 == null)
        {
                return;
        }
        
        if(this.丞下丗丅且上且上丟.Count < 2)
        {
                return;
        }
        
        val_15 = this.丞下丗丅且上且上丟.Item[1];
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_15, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                val_15 = this.丛不丈不丙丟不三上.业东丅东丌上丗丑不();
            PGCompany.三东丏不丗世丅丌丄 val_9 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  this.丛不丈不丙丟不三上.丞万丒丌丈东丄业下().业东丅东丌上丗丑不());
            val_9.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丒丕三丌丒丑世丙丄);
            PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丒不丅丅业世丟不不(丘丗丈东下业丟丟丑:  val_15, 不且丐一丆丛丙丙丒:  val_9, 上七丂丏丅业丞且且:  this.丞下丗丅且上且上丟.Item[1].业东丅东丌上丗丑不());
            this.UpdateView();
            if(this.不丘丄丙丙丞丈三丞 == null)
        {
                return;
        }
        
            this.不丘丄丙丙丞丈三丞.Invoke();
            return;
        }
        
        this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  this.丞下丗丅且上且上丟.Item[1].业上丙丞丐丄丆丅七());
    }
    public ClanBuildingInvestmentView()
    {
    
    }
    private static ClanBuildingInvestmentView()
    {
        System.Collections.Generic.List<BankViewTab> val_1 = new System.Collections.Generic.List<BankViewTab>();
        if(val_1 != null)
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
        }
        else
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
        }
        
        val_1.Add(item:  8);
        ClanBuildingInvestmentView.丑丝专丐与与业丏丗 = val_1;
    }

}
