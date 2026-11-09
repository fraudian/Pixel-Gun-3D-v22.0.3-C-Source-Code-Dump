using UnityEngine;
public class ShopItemSkinView : SelectableButton
{
    // Fields
    private UILabel nameLabel;
    private UnityEngine.GameObject bgPurchased;
    private UnityEngine.GameObject bgEquipped;
    private UnityEngine.GameObject bgDefault;
    private UnityEngine.GameObject bgInLoop;
    protected UnityEngine.Transform previewScaleObject;
    protected UnityEngine.Transform previewHolder;
    protected UnityEngine.GameObject 丑与丅东万丟世丄丌;
    protected float previewScale;
    protected UnityEngine.Vector3 previewPosition;
    protected UnityEngine.Vector3 previewRotation;
    private PGCompany.丗丟丄丈东丝丕丄世 <丐三丑世且丒上丟与>k__BackingField;
    public UnityEngine.Transform scrollCenter;
    public float minDistance;
    public float maxDistance;
    
    // Properties
    internal PGCompany.丗丟丄丈东丝丕丄世 丐且与丆世丘丟丏丘 { get; set; }
    
    // Methods
    internal PGCompany.丗丟丄丈东丝丕丄世 丕丏业丒丘丒世丟且()
    {
        return (PGCompany.丗丟丄丈东丝丕丄世)this.<丐三丑世且丒上丟与>k__BackingField;
    }
    private void 丑专与丆丌丆丅不三(PGCompany.丗丟丄丈东丝丕丄世 丙业与丙丗丝不丈东)
    {
        this.<丐三丑世且丒上丟与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不, UnityEngine.GameObject 万丝丗丛丁丁丆业丞)
    {
        this.<丐三丑世且丒上丟与>k__BackingField = 丛丆世丂丒丁不世不;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.nameLabel, 丕丗丘丑丛与丑业丒:  丛丆世丂丒丁不世不);
        this.丕丕业七丙七丅丈丄();
    }
    internal void 丕丕业七丙七丅丈丄()
    {
        PGCompany.三东丏不丗世丅丌丄 val_6;
        var val_7;
        UnityEngine.GameObject val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bgPurchased, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bgEquipped, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bgDefault, 丏业丟一东丂东丘丛:  false);
        if((this & 1) != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bgEquipped, 丏业丟一东丂东丘丛:  true);
            return;
        }
        
        val_6 = this.<丐三丑世且丒上丟与>k__BackingField.丑丐丙丄丅世世丑丒();
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_6, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                val_7 = null;
            val_8 = this.bgPurchased;
        }
        else
        {
                val_6 = this.<丐三丑世且丒上丟与>k__BackingField;
            if((Rilisoft.丗下丙丅且丐丞丙世.丑七不且上丗丁一世().且七东专世丝丒丟一(下丅丙一丂丗丅丝七:  val_6, 专丏世丑与丐丝丝七:  true, 丗与丟上上丑专世丗:  new System.Nullable<OfferModule>() {HasValue = false})) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bgInLoop, 丏业丟一东丂东丘丛:  true);
        }
        
            val_7 = null;
            val_8 = this.bgDefault;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
    }
    protected virtual void 下丘丈三不万东丟丄(UnityEngine.GameObject 万丝丗丛丁丁丆业丞)
    {
    
    }
    internal virtual bool 丁一丄一丑一且丑丘(PGCompany.丗丟丄丈东丝丕丄世 丛丆世丂丒丁不世不)
    {
        return false;
    }
    internal virtual 丈丞丕丘丕丗与上一 下丆丄与世丂丞丂七()
    {
        null = null;
        return (丈丞丕丘丕丗与上一)new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  200, 丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
    }
    protected void LateUpdate()
    {
        float val_8;
        float val_9;
        float val_10;
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Vector3 val_3 = this.scrollCenter.position;
        float val_5 = UnityEngine.Mathf.Min(a:  UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}), b:  this.maxDistance);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        val_8 = val_6.x;
        val_9 = val_6.y;
        val_10 = val_6.z;
        float val_8 = this.minDistance;
        if(val_5 > val_8)
        {
                val_8 = this.maxDistance - val_8;
            val_8 = (val_5 - val_8) / val_8;
            val_8 = 1f - val_8;
            val_8 = val_8;
            val_9 = val_9;
            val_10 = val_10;
        }
        
        this.previewHolder.localScale = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10};
    }
    public ShopItemSkinView()
    {
        this.minDistance = 0.7f;
        this.maxDistance = 7.346868E-41f;
    }

}
