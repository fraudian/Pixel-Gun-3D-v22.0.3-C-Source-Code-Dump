using UnityEngine;
public class FortCraftDetailsController : MonoBehaviour
{
    // Fields
    private Rilisoft.东且东丒丐世丐丞丒 万丞丁不丏丌七专万;
    private int 专丟丙丒丑下丒丄丗;
    private UnityEngine.GameObject checkMark;
    private UISprite gearIcon;
    private UILabel itemCount;
    private UILabel labelPrice;
    private System.Action 丌不丂丌丁丛丆丟与;
    
    // Methods
    public void add_OnClicked(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921537239429192);
    
    }
    public void remove_OnClicked(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌不丂丌丁丛丆丟与 != 1152921537239565768);
    
    }
    private void OnClick()
    {
        if(this.丌不丂丌丁丛丆丟与 == null)
        {
                return;
        }
        
        this.丌不丂丌丁丛丆丟与.Invoke();
    }
    private void Update()
    {
        string val_15;
        int val_16;
        Rilisoft.东且东丒丐世丐丞丒 val_17;
        val_15 = this;
        val_16 = this.万丞丁不丏丌七专万.丗三三丐丁东丘丌一() - (this.万丞丁不丏丌七专万.丝丗丑万万丗不丙丁() * this.万丞丁不丏丌七专万.三丐丟丒业丞东三丕());
        val_17 = this.万丞丁不丏丌七专万;
        if((this.万丞丁不丏丌七专万.丄且丞且且且世丂丅() * this.万丞丁不丏丌七专万.三丐丟丒业丞东三丕()) < val_17.丗三三丐丁东丘丌一())
        {
                val_17 = this.万丞丁不丏丌七专万.丄且丞且且且世丂丅();
            val_16 = (val_17 - this.万丞丁不丏丌七专万.丝丗丑万万丗不丙丁()) * this.万丞丁不丏丌七专万.三丐丟丒业丞东三丕();
        }
        
        if(this.专丟丙丒丑下丒丄丗 == val_16)
        {
                return;
        }
        
        this.专丟丙丒丑下丒丄丗 = val_16;
        val_17 = this.万丞丁不丏丌七专万;
        val_15 = System.String.Format(format:  "{0}/{1}", arg0:  val_16, arg1:  val_17.三丐丟丒业丞东三丕());
        this.labelPrice.text = val_15;
    }
    public void SetPrice(Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七)
    {
        var val_26;
        UISprite val_27;
        int val_28;
        object val_29;
        var val_30;
        UnityEngine.GameObject val_32;
        val_26 = this;
        this.checkMark.SetActive(value:  false);
        val_27 = this.itemCount.gameObject;
        val_27.SetActive(value:  false);
        if(下丅丙一丂丗丅丝七 == null)
        {
                return;
        }
        
        this.万丞丁不丏丌七专万 = 下丅丙一丂丗丅丝七;
        if((下丅丙一丂丗丅丝七.丄且丞且且且世丂丅() * 下丅丙一丂丗丅丝七.三丐丟丒业丞东三丕()) < 下丅丙一丂丗丅丝七.丗三三丐丁东丘丌一())
        {
                val_28 = (下丅丙一丂丗丅丝七.丄且丞且且且世丂丅() - 下丅丙一丂丗丅丝七.丝丗丑万万丗不丙丁()) * 下丅丙一丂丗丅丝七.三丐丟丒业丞东三丕();
        }
        else
        {
                val_28 = 下丅丙一丂丗丅丝七.丗三三丐丁东丘丌一() - (下丅丙一丂丗丅丝七.丝丗丑万万丗不丙丁() * 下丅丙一丂丗丅丝七.三丐丟丒业丞东三丕());
        }
        
        if(下丅丙一丂丗丅丝七.三丐丟丒业丞东三丕() <= val_28)
        {
            goto label_7;
        }
        
        if((Rilisoft.FortsManager.丛且一与丑丅下丌丏(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七)) == false)
        {
            goto label_10;
        }
        
        val_29 = 1;
        val_30 = null;
        goto label_11;
        label_7:
        val_32 = this.checkMark;
        if(val_32 != null)
        {
            goto label_16;
        }
        
        goto label_13;
        label_10:
        int val_15 = 下丅丙一丂丗丅丝七.丝丗丑万万丗不丙丁();
        val_29 = val_15;
        val_30 = null;
        label_11:
        this.itemCount.text = System.String.Format(format:  "{0}/{1}", arg0:  val_15, arg1:  下丅丙一丂丗丅丝七.丄且丞且且且世丂丅());
        val_32 = this.itemCount.gameObject;
        if(val_32 != null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        val_32.SetActive(value:  true);
        this.专丟丙丒丑下丒丄丗 = val_28;
        this.labelPrice.text = System.String.Format(format:  "{0}/{1}", arg0:  val_28, arg1:  下丅丙一丂丗丅丝七.三丐丟丒业丞东三丕());
        this.gearIcon.spriteName = "storage_icon_common";
        val_27 = this.gearIcon;
        val_27.color = new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)下丅丙一丂丗丅丝七.七东与丄丕丁丛世三()], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)下丅丙一丂丗丅丝七.七东与丄丕丁丛世三()], b = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)下丅丙一丂丗丅丝七.七东与丄丕丁丛世三()], a = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[(long)下丅丙一丂丗丅丝七.七东与丄丕丁丛世三()]};
        this.labelPrice.gameObject.SetActive(value:  true);
        val_26 = this.gearIcon.gameObject;
        val_26.SetActive(value:  true);
    }
    public void HidePrice()
    {
        this.labelPrice.gameObject.SetActive(value:  false);
        this.gearIcon.gameObject.SetActive(value:  false);
    }
    public FortCraftDetailsController()
    {
    
    }

}
