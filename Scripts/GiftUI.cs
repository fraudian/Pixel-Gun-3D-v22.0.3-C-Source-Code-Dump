using UnityEngine;
internal sealed class GiftUI : PGBehaviour
{
    // Fields
    internal PGCompany.UI.GiftSystem.ReceiveGiftAnimationWrapper animations;
    internal PGCompany.InventoryItemView itemView;
    private UITextureMasked _giftTexture;
    private UILabel _countLabel;
    private UILabel _gifterName;
    internal System.Action 三万万万丁三丒丘丗;
    internal System.Action 上丈丏丈丄丛丕丛丏;
    internal System.Action 丗丒上丙丁七七业上;
    
    // Properties
    set; }
    internal int 丒专下与丑丁丆丟业 { set; }
    internal string 丏丏丈丛七且丏万丗 { set; }
    
    // Methods
    internal void 且专与东专丏三丌丁(UnityEngine.Texture 丙业与丙丗丝不丈东)
    {
        if(this._giftTexture == 0)
        {
                return;
        }
        
        丙业与丙丗丝不丈东 = ???;
        goto typeof(UITextureMasked).__il2cppRuntimeField_2E8;
    }
    internal void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._countLabel, 丕丗丘丑丛与丑业丒:  丙业与丙丗丝不丈东);
    }
    internal void 丙丘上万丝丐丑丒丒(string 丙业与丙丗丝不丈东)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gifterName, 丕丗丘丑丛与丑业丒:  丙业与丙丗丝不丈东);
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.GiftSystem.丏下丙丂万且一丑丛 丄丒丞专丐丌东丒业)
    {
        this.itemView.Setup(丈丄不七三万丄丁不:  System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  丄丒丞专丐丌东丒业.丒丑丛丂丟丑丝丘丐()));
        this.丙丘上万丝丐丑丒丒(丙业与丙丗丝不丈东:  丂与专万与丐丌丏不.丑七不且上丗丁一世().三业三一丟上丁丌丅(丄丒且丙三丆丟与丏:  丄丒丞专丐丌东丒业.丕不业丟丕丘万世三()));
        this.animations.与丛上丞丈丏东万万 = new System.Action(object:  this, method:  System.Void GiftUI::丆世东不下东丗丞不());
        this.animations.丗丂万丙丌一丁万丏();
        this.animations.丗三丕丝丘丆丂一丆();
    }
    public void OnUnpackButtonClicked()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Unpack");
        this.animations.丗丂万丙丌一丁万丏();
        this.animations.丗三丕丝丘丆丂一丆();
        if(this.上丈丏丈丄丛丕丛丏 == null)
        {
                return;
        }
        
        this.上丈丏丈丄丛丕丛丏.Invoke();
    }
    public void OnOkButtonClicked()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Ok");
        this.animations.丗丂万丙丌一丁万丏();
        this.animations.丟专与丄专且丂下且();
        if(this.三万万万丁三丒丘丗 == null)
        {
                return;
        }
        
        this.三万万万丁三丒丘丗.Invoke();
    }
    private void 丆世东不下东丗丞不()
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "On Close");
        this.animations.丗丂万丙丌一丁万丏();
        this.animations.丄丂丌丅不丛世丘一();
        if(this.丗丒上丙丁七七业上 == null)
        {
                return;
        }
        
        this.丗丒上丙丁七七业上.Invoke();
    }
    public GiftUI()
    {
    
    }

}
