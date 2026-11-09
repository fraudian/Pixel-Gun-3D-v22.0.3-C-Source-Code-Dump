using UnityEngine;
public class MakeLeaderMenuItem : ContextMenuItemBase
{
    // Fields
    private UIButton 下丒丘丅丌丏丛丗丆;
    
    // Methods
    private void Awake()
    {
        this.下丒丘丅丌丏丛丗丆 = this.GetComponent<UIButton>();
    }
    private void OnEnable()
    {
        PGCompany.Clans.Network.丈万丂丌一丅下丐丂.世丕丝三与丄丄丑三(丙业与丙丗丝不丈东:  new System.Action<专世一东业丛丞且丗>(object:  this, method:  System.Void MakeLeaderMenuItem::丄丑七丘丁且丞丙专(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
        PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丐丁七东丑专丌丏丆(丙业与丙丗丝不丈东:  new System.Action<System.Int32, 专世一东业丛丞且丗>(object:  this, method:  System.Void MakeLeaderMenuItem::东丆且世丑上丕丕丙(int 丂七东不不丈一丐不, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
    }
    private void OnDisable()
    {
        PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丛丌丌丁丑丘丛丈业(丙业与丙丗丝不丈东:  new System.Action<专世一东业丛丞且丗>(object:  this, method:  System.Void MakeLeaderMenuItem::丄丑七丘丁且丞丙专(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
        PGCompany.Clans.Network.丈万丂丌一丅下丐丂.丆丒丐丕丒下丙丐七(丙业与丙丗丝不丈东:  new System.Action<System.Int32, 专世一东业丛丞且丗>(object:  this, method:  System.Void MakeLeaderMenuItem::东丆且世丑上丕丕丙(int 丂七东不不丈一丐不, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)));
    }
    public override void Interact()
    {
        MakeLeaderMenuItem.世丞丒丅一专丌丐丏 val_1 = new MakeLeaderMenuItem.世丞丒丅一专丌丐丏();
        .丝且与丝丒丟万丁专 = this;
        .丆业丂三丘丗与与丏 = 0;
    }
    public override void UpdateSelf()
    {
        if(static_value_082C5058.丙丐丅丕丗丁丅丁丐() == 2)
        {
                if((Rilisoft.Singleton<ClansController>.Instance.下丑上丌丐丑世丁丕()) != false)
        {
                this.丄丑七丘丁且丞丙专(丝三丄专丗丞丄丄丌:  (~PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丘三丞丁三丙上丁丑().丝丈丁丟丞丆丈一丕()) & 1);
            return;
        }
        
        }
        
        this = this.gameObject;
        this.SetActive(value:  false);
    }
    private void 东丆且世丑上丕丕丙(int 丂七东不不丈一丐不, PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)
    {
        this.丄丑七丘丁且丞丙专(专丒丌丆下丐丞丟丞:  丂七东不不丈一丐不);
    }
    private void 丄丑七丘丁且丞丙专(PGCompany.Clans.Network.丈万丂丌一丅下丐丂.专世一东业丛丞且丗 专丒丌丆下丐丞丟丞)
    {
        this.丄丑七丘丁且丞丙专(丝三丄专丗丞丄丄丌:  (~PGCompany.Clans.Network.丛丝丒丆东丄丙丒丁.丑七不且上丗丁一世().丘三丞丁三丙上丁丑().丝丈丁丟丞丆丈一丕()) & 1);
    }
    private void 丄丑七丘丁且丞丙专(bool 丝三丄专丗丞丄丄丌)
    {
        if(this.下丒丘丅丌丏丛丗丆 == 0)
        {
                return;
        }
        
        bool val_2 = 丝三丄专丗丞丄丄丌;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public MakeLeaderMenuItem()
    {
    
    }

}
