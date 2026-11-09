using UnityEngine;
internal sealed class 三世丛专丂丗丛丂一 : 丟上下丞世丞不不丁
{
    // Fields
    private string 丌丙丒丕丘业丐丆丟;
    private WeaponSkinChanger 丙三一专且丏丞世丐;
    
    // Properties
    internal string 丗丆东丕丄下与丑丐 { get; }
    internal string 丝丞丂丄不且三丑专 { get; }
    
    // Methods
    internal 三世丛专丂丗丛丂一(PGCompany.丟丝东丈丐丙三下丛 一业一丕丅下业世与, UnityEngine.GameObject 丌丕丟丘万丅丝与一)
    {
        var val_7;
        三丅丁丗丗丝丂万且 val_1 = 一业一丕丅下业世与.丐上下三丑丈丑丄丟();
        mem[1152921540709446064] = val_1.<丙丝万丈丟丕丛丑丗>k__BackingField;
        if(一业一丕丅下业世与 != null)
        {
                val_7 = 0;
            mem[1152921540709446072] = 一业一丕丅下业世与.业东丅东丌上丗丑不();
        }
        else
        {
                val_7 = 0;
            mem[1152921540709446072] = 0.业东丅东丌上丗丑不();
        }
        
        mem[1152921540709446076] = 一业一丕丅下业世与;
        三丅丁丗丗丝丂万且 val_4 = 一业一丕丅下业世与.丐上下三丑丈丑丄丟();
        this.丌丙丒丕丘业丐丆丟 = val_4.<丗丐下三上世丂丅三>k__BackingField;
        this.丙三一专且丏丞世丐 = 丌丕丟丘万丅丝与一.GetComponentInChildren<WeaponSkinChanger>(includeInactive:  true);
        mem[1152921540709446080] = new 丟上下丞世丞不不丁.丙丛丕丆一丛三丛与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(三世丛专丂丗丛丂一).__il2cppRuntimeField_220);
    }
    internal string 丂上丛丝丑三万丑丌()
    {
        return (string)this.丌丙丒丕丘业丐丆丟;
    }
    internal string 丆万丌万丛丏丈万丌()
    {
        return this.丐丙世七丅丅丐下丙();
    }
    internal override System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> 丈不东七与丛丞丞丝()
    {
        return 丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  this.丌丙丒丕丘业丐丆丟);
    }
    internal override bool 丆下万丐七丐一丄丁()
    {
        return (bool)((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.丐丙世七丅丅丐下丙())) != 0) ? 1 : 0;
    }
    internal override void 世丙丙丗丕丐七与下(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        if(丛丆世丂丒丁不世不 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        this.丙三一专且丏丞世丐.上丈一万东三东世东(三丕上下丗丘丌专丒:  (null == null) ? 丛丆世丂丒丁不世不 : 0, 丄丕且丆与业下业下:  0);
    }
    internal override void 下丛东丅丑丏丁丒且()
    {
        this.丙三一专且丏丞世丐.上丈一万东三东世东(三丕上下丗丘丌专丒:  0, 丄丕且丆与业下业下:  0);
    }
    internal override bool 丗丝丌丁丏一专与丟(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        if(丛丆世丂丒丁不世不 == null)
        {
                return false;
        }
        
        if(null == null)
        {
                return 丏丞丛上七丁丞丛万.与丏丘丏丆丗丌专丅(丞丝丌七丁万丗丐一:  (null == null) ? (丛丆世丂丒丁不世不) : 0);
        }
        
        return false;
    }
    internal override void 丅不业丆丟三上丒丝(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        if(丛丆世丂丒丁不世不 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  (null == null) ? (丛丆世丂丒丁不世不) : 0);
    }
    internal override void 丙丆丛丝丞丘七丆丈(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        if(丛丆世丂丒丁不世不 == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        丏丞丛上七丁丞丛万.丄东下丒丙东业丘七(丞丝丌七丁万丗丐一:  (null == null) ? (丛丆世丂丒丁不世不) : 0);
    }
    internal override bool 丌丘丈东不丁不丅不(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        return false;
    }
    internal override int 丄三丛业丕丙丕东万(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        return 1;
    }
    internal override bool 丅丛丘丛丛丅丝丈丙(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        return false;
    }
    internal override 丛且专丞丗丆丙丒万 且世丟丌丌三丞与丛(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        return 0;
    }
    protected override void 专丙丅丈丄丐下三丛(丈丞丕丘丕丗与上一 丒世丘丘上丆丝东丞, PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        丈丞丕丘丕丗与上一 val_12;
        var val_13;
        var val_14;
        三世丛专丂丗丛丂一.与丟业一丈上丅上不 val_1 = new 三世丛专丂丗丛丂一.与丟业一丈上丅上不();
        if(val_1 != null)
        {
                val_12 = val_1;
            .丒世丘丘上丆丝东丞 = 丒世丘丘上丆丝东丞;
            val_13 = 1152921540711251984;
            mem[1152921540711251992] = 丛丆世丂丒丁不世不;
            val_14 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        else
        {
                val_12 = 16;
            mem[16] = 丒世丘丘上丆丝东丞;
            val_13 = 24;
            mem[24] = 丛丆世丂丒丁不世不;
            val_14 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_6 = val_14.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_13.丑丐丙丄丅世世丑丒(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  new System.Action(object:  val_1, method:  System.Void 三世丛专丂丗丛丂一.与丟业一丈上丅上不::丞丒七东丙上与专丗()));
        if((mem[24] != 0) && (mem[24] == null))
        {
                if((上丑三丁丄丛丁万丑.一丙丕丈三丒丌丈丏(丞丝丌七丁万丗丐一:  mem[24])) != false)
        {
                丏丞丛上七丁丞丛万.万三一且丞丏一丗七(丞丝丌七丁万丗丐一:  mem[24]);
        }
        
        }
        
        PGCompany.Analytics.一业丗丆世世上丁且.一丁七丂且丁丗万丏(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 七丆丒与丗丌丄且丂:  128, 丞一丁业丄一一业且:  mem[24].业上丙丞丐丄丆丅七(), 七丐丅专且专七三丆:  "buyWeaponSkin", 万丐丏丐丒万不丟三:  val_12, 与上世丗丞丐万东丌:  (ShopNGUIController.丛世丛与丌不丈丐丐() != true) ? "armory" : "other", 与丙丆世丘丑丒丌丄:  new System.Nullable<Rilisoft.OfferItemType>() {HasValue = false}, 丞业丛世丛丘丝不丌:  false, 丈丄不七三万丄丁不:  0);
    }

}
