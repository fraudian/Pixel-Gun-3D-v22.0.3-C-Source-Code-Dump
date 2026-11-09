using UnityEngine;
public class BannerWindowWithBack : BannerWindow
{
    // Fields
    protected System.IDisposable 专丏业专不丂一丂丛;
    
    // Methods
    public virtual void Back()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(BannerWindowWithBack).__il2cppRuntimeField_230);
        丕世不丐丒丕丅丗且.业世世七丌丕丝丆丙(丙业与丙丗丝不丈东:  new System.Action());
    }
    public override void Show()
    {
        this.Show();
        new System.Action() = new System.Action(object:  this, method:  typeof(BannerWindowWithBack).__il2cppRuntimeField_230);
        丕世不丐丒丕丅丗且.业世世七丌丕丝丆丙(丙业与丙丗丝不丈东:  new System.Action());
        new System.Action() = new System.Action(object:  this, method:  typeof(BannerWindowWithBack).__il2cppRuntimeField_230);
        丕世不丐丒丕丅丗且.七丅东丐世与下万丞(丙业与丙丗丝不丈东:  new System.Action());
    }
    protected virtual void 丆丅下丆丂丏丙丌丛()
    {
        goto typeof(BannerWindowWithBack).__il2cppRuntimeField_218;
    }
    protected override void OnEnable()
    {
        if(this.专丏业专不丂一丂丛 != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        
        new System.Action() = new System.Action(object:  this, method:  typeof(BannerWindowWithBack).__il2cppRuntimeField_220);
        this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "BannerWindowWithBack_" + this.gameObject.name);
    }
    protected override void OnDisable()
    {
        mem[1152921536325828696] = 0;
        if(this.专丏业专不丂一丂丛 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.专丏业专不丂一丂丛.Dispose();
    }
    protected override void OnDestroy()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(BannerWindowWithBack).__il2cppRuntimeField_230);
        丕世不丐丒丕丅丗且.业世世七丌丕丝丆丙(丙业与丙丗丝不丈东:  new System.Action());
    }
    public BannerWindowWithBack()
    {
        val_1 = new PGBehaviour();
    }

}
