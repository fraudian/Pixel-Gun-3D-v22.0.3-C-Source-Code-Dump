using UnityEngine;
internal sealed class AutoCollectBannerWindow : BannerWindow
{
    // Fields
    private GoblinAutoCollectorUi _goblinAutoCollectorUi;
    
    // Methods
    protected override void Awake()
    {
        if(this._goblinAutoCollectorUi != 0)
        {
                return;
        }
        
        this._goblinAutoCollectorUi = this.GetComponent<GoblinAutoCollectorUi>();
    }
    public override void Show()
    {
        this.Show();
        new System.Action() = new System.Action(object:  this, method:  typeof(AutoCollectBannerWindow).__il2cppRuntimeField_210);
        this._goblinAutoCollectorUi.丞业丅丛丐丌丗丝丌(丞丟万丝七丁丈丌丝:  new System.Action());
        this._goblinAutoCollectorUi.丈且东丑丂且万丒丅(丙且丄丑丂万丅丘丗:  2);
        this._goblinAutoCollectorUi.丞三业东丐丛丛丈丄();
    }
    public AutoCollectBannerWindow()
    {
    
    }

}
