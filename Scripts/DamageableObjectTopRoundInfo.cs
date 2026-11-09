using UnityEngine;
internal sealed class DamageableObjectTopRoundInfo : PGBehaviour, 丏下一丌且三与丘丘
{
    // Fields
    private DamageableObject _damageableObject;
    private string 丟丟万一不业上丐丗;
    private string _iconName;
    private int 东七丛丝丑专世丏三;
    
    // Methods
    public string GetInfo()
    {
        return (string)this.丟丟万一不业上丐丗;
    }
    public string GetNameSprite()
    {
        return (string)this._iconName;
    }
    private void Awake()
    {
        this.丗且万万丝且丂万丅();
    }
    private void 丑丁不万丈丟万且业()
    {
        DamageableObject val_4;
        var val_5;
        if(this._damageableObject == 0)
        {
                return;
        }
        
        val_4 = this._damageableObject;
        if(this._damageableObject != null)
        {
            goto label_4;
        }
        
        val_4 = this._damageableObject;
        if(val_4 == null)
        {
            goto label_5;
        }
        
        label_4:
        float val_4 = this._damageableObject._health;
        val_4 = val_4 / this._damageableObject.下万且与上丝且七世;
        val_4 = val_4 * 100f;
        if(((int)val_4 == 0) && (this._damageableObject._health > 0f))
        {
                val_5 = "1%";
        }
        
        this.丟丟万一不业上丐丗 = (int)val_4.ToString() + " %"(" %");
        return;
        label_5:
    }
    private void 丗且万万丝且丂万丅()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DamageableObjectTopRoundInfo::丑丁不万丈丟万且业()));
        this._damageableObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DamageableObjectTopRoundInfo::丑丁不万丈丟万且业()));
        this.丑丁不万丈丟万且业();
    }
    private void OnDestroy()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DamageableObjectTopRoundInfo::丑丁不万丈丟万且业()));
        this._damageableObject.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void DamageableObjectTopRoundInfo::丑丁不万丈丟万且业()));
    }
    internal void 不丒世下丝万丙丟丆(DamageableObject 丅丞万丒不专丈专丕)
    {
        this._damageableObject = 丅丞万丒不专丈专丕;
        this.丗且万万丝且丂万丅();
    }
    public void SetIndexMiniPool(int 丞世不丒下上上丝丑)
    {
        this.东七丛丝丑专世丏三 = 丞世不丒下上上丝丑;
    }
    public int GetIndexMiniPool()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    public DamageableObjectTopRoundInfo()
    {
        this.丟丟万一不业上丐丗 = "";
        this._iconName = "";
    }

}
