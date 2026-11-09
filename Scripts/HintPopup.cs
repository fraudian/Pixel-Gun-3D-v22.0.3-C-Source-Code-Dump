using UnityEngine;
internal class HintPopup : MonoBehaviour
{
    // Fields
    private System.IDisposable 且丟丑万丌丄东丗丟;
    private bool 七丒丛丘丟万下东丘;
    private UnityEngine.GameObject colliderReference;
    private System.Action 丟不丒万丝与丂上丘;
    
    // Methods
    internal void 丘丌世专丌专丕丂丅(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丟不丒万丝与丂上丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟不丒万丝与丂上丘 != 1152921536991194688);
    
    }
    internal void 不丛丛丌上丕丏专三(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丟不丒万丝与丂上丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟不丒万丝与丂上丘 != 1152921536991331264);
    
    }
    protected virtual void OnEnable()
    {
        if(this.且丟丑万丌丄东丗丟 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.且丟丑万丌丄东丗丟.Dispose();
        }
        
        this.且丟丑万丌丄东丗丟 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void HintPopup::丗丟万丂丘丈专丄丂()), 与且专丈不万东一万:  "hint mode in connect scene");
        this.丗丄万七万世丐丙丏();
    }
    private void 丗丟万丂丘丈专丄丂()
    {
        if(ButtonClickSound.丆丕丝丒不丙且丐丗 != 0)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        }
        
        if(this.且丟丑万丌丄东丗丟 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.且丟丑万丌丄东丗丟.Dispose();
        }
        
        this.丙丘丅万且丁丐丆丟();
        this.gameObject.SetActive(value:  false);
        if(this.丟不丒万丝与丂上丘 == null)
        {
                return;
        }
        
        this.丟不丒万丝与丂上丘.Invoke();
    }
    private void OnDestroy()
    {
        if(this.且丟丑万丌丄东丗丟 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.且丟丑万丌丄东丗丟.Dispose();
        }
        
        this.丙丘丅万且丁丐丆丟();
    }
    private void 丗丄万七万世丐丙丏()
    {
        object val_4;
        var val_5;
        丅三丝丙丝万上丝业 val_6;
        val_4 = this;
        if(this.七丒丛丘丟万下东丘 == true)
        {
                return;
        }
        
        this.七丒丛丘丟万下东丘 = true;
        val_5 = null;
        val_5 = null;
        if(((System.Delegate.Combine(a:  UICamera.onClick, b:  new UICamera.丅三丝丙丝万上丝业(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void HintPopup::丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        UICamera.onClick = val_6;
    }
    private void 丙丘丅万且丁丐丆丟()
    {
        object val_4;
        var val_5;
        丅三丝丙丝万上丝业 val_6;
        val_4 = this;
        if(this.七丒丛丘丟万下东丘 == false)
        {
                return;
        }
        
        this.七丒丛丘丟万下东丘 = false;
        val_5 = null;
        val_5 = null;
        if(((System.Delegate.Remove(source:  UICamera.onClick, value:  new UICamera.丅三丝丙丝万上丝业(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void HintPopup::丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)))) != null) && (null != null))
        {
                val_6 = 0;
        }
        
        UICamera.onClick = val_6;
    }
    private void 丆丗世下且丒丏丂丈(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        if(丝三丁东丈丒世丅业 == this.colliderReference)
        {
                return;
        }
        
        this.丗丟万丂丘丈专丄丂();
    }
    public HintPopup()
    {
    
    }

}
