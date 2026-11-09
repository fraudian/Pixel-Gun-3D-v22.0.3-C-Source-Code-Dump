using UnityEngine;
internal sealed class UniversalRewardView : PGBehaviour
{
    // Fields
    private System.Action 丛丏下丙不丝且一一;
    public UILabel titleLabrl;
    public UniversalRewardOneByOneView oneByOneView;
    public UniversalRewardFinalView finalView;
    public System.Collections.Generic.List<UnityEngine.GameObject> collectButton;
    private UniversalRewardController.与丏下丒与丙丟丝一 丝一丏丟丌丙一下丝;
    internal static bool 丅业东万丌丕上丌丄;
    protected System.IDisposable 专丏业专不丂一丂丛;
    
    // Methods
    internal void 丞丌丑丐丑丆上丗丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丛丏下丙不丝且一一, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丏下丙不丝且一一 != 1152921539487421368);
    
    }
    internal void 丛不丝丗一丏三专丄(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丛丏下丙不丝且一一, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丛丏下丙不丝且一一 != 1152921539487557944);
    
    }
    private void OnEnable()
    {
        this.oneByOneView.丘丏丘丄丈且上丕东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardView::丞与业丅世下上丆丙()));
        this.finalView.丘丏丘丄丈且上丕东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardView::万东丈世业丛丌且丐()));
        UniversalRewardView.丅业东万丌丕上丌丄 = true;
        ModalBannerHolder.丑七不且上丗丁一世().丐业专丆万不世丈丑(丙业与丙丗丝不丈东:  false);
    }
    private void OnDisable()
    {
        this.oneByOneView.丁丁丁东业丒下丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardView::丞与业丅世下上丆丙()));
        this.finalView.丁丁丁东业丒下丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void UniversalRewardView::万东丈世业丛丌且丐()));
        UniversalRewardView.丅业东万丌丕上丌丄 = false;
        ModalBannerHolder.丑七不且上丗丁一世().丐业专丆万不世丈丑(丙业与丙丗丝不丈东:  true);
    }
    public void Setup(UniversalRewardController.与丏下丒与丙丟丝一 丗丐丝丗丞丏丝丕丄)
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "Back Is Locked");
        this.Clear();
        this.丝一丏丟丌丙一下丝 = 丗丐丝丗丞丏丝丕丄;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabrl, 丕丗丘丑丛与丑业丒:  this.丘丄业丞丏与与丅丐(丗丐丝丗丞丏丝丕丄:  丗丐丝丗丞丏丝丕丄));
        if(this.丝一丏丟丌丙一下丝.丌世丕丗不丘世丞专 == 2)
        {
                this.finalView.Setup(丁东丛丅业七丏丌丑:  this.丝一丏丟丌丙一下丝);
            return;
        }
        
        this.oneByOneView.Setup(丁东丛丅业七丏丌丑:  this.丝一丏丟丌丙一下丝);
    }
    private void 丞与业丅世下上丆丙()
    {
        this.finalView.Setup(丁东丛丅业七丏丌丑:  this.丝一丏丟丌丙一下丝);
    }
    private void 万东丈世业丛丌且丐()
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.collectButton, 丏业丟一东丂东丘丛:  true);
        PGCompany.丂丞万丒下万丒业丌.丑七不且上丗丁一世().丝东丟丕丅丄万万东(且丒丛与丞世丙丕丌:  this.丝一丏丟丌丙一下丝.且丒丛与丞世丙丕丌);
    }
    public void Clear()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.collectButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.oneByOneView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.finalView, 丏业丟一东丂东丘丛:  false);
    }
    public void U_CollectButtonPressed()
    {
        if(this.丛丏下丙不丝且一一 == null)
        {
                return;
        }
        
        this.丛丏下丙不丝且一一.Invoke();
    }
    private string 丘丄业丞丏与与丅丐(UniversalRewardController.与丏下丒与丙丟丝一 丗丐丝丗丞丏丝丕丄)
    {
        if(丗丐丝丗丞丏丝丕丄.一七丁不丝丈丕丑丒 == null)
        {
                return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "UniversalRewardView_Title_{0}", arg0:  丗丐丝丗丞丏丝丕丄.且丒丛与丞世丙丕丌));
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丗丐丝丗丞丏丝丕丄.一七丁不丝丈丕丑丒.不下丅世丝三七东不)) == false)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丗丐丝丗丞丏丝丕丄.一七丁不丝丈丕丑丒.不下丅世丝三七东不);
        }
        
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "UniversalRewardView_Title_{0}", arg0:  丗丐丝丗丞丏丝丕丄.且丒丛与丞世丙丕丌));
    }
    public UniversalRewardView()
    {
    
    }

}
