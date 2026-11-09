using UnityEngine;
internal sealed class ClanLootBoxInfoUICategoryButton : PGBehaviour
{
    // Fields
    internal 丟三丁与丞丘一东丄 与丄不丌一世东丁丙;
    public UnityEngine.GameObject pressed;
    private System.Action<ClanLootBoxInfoUICategoryButton> 三专丌一且丄且丅丘;
    
    // Methods
    internal void 丁丂丅万丛丈丝丘丄(System.Action<ClanLootBoxInfoUICategoryButton> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三专丌一且丄且丅丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921525726877528);
    
    }
    internal void 丝丛丂丅东丕丐下丝(System.Action<ClanLootBoxInfoUICategoryButton> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三专丌一且丄且丅丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三专丌一且丄且丅丘 != 1152921525727014104);
    
    }
    private void OnPress(bool 丁丐不且七丂业丗丆)
    {
        if(this.pressed == 0)
        {
                return;
        }
        
        this.pressed.SetActive(value:  丁丐不且七丂业丗丆);
    }
    public void U_OnClick()
    {
        if(this.三专丌一且丄且丅丘 == null)
        {
                return;
        }
        
        this.三专丌一且丄且丅丘.Invoke(obj:  this);
    }
    public ClanLootBoxInfoUICategoryButton()
    {
    
    }

}
