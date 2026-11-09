using UnityEngine;
internal class StorePromotionExtendUIDefault : StorePromotionExtendUIAbstract
{
    // Methods
    protected override void OnEnable()
    {
        mem[1152921539301494624] = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  "StorePromotionExtendUIDefault_" + this.gameObject.name);
    }
    protected override void OnDisable()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.Dispose();
    }
    internal void 丈且东丑丂且万丒丅()
    {
        this.gameObject.SetActive(value:  true);
    }
    public override void Hide()
    {
        if(this != null)
        {
                this.Invoke();
        }
        
        this.gameObject.SetActive(value:  false);
    }
    public StorePromotionExtendUIDefault()
    {
        val_1 = new PGBehaviour();
    }

}
