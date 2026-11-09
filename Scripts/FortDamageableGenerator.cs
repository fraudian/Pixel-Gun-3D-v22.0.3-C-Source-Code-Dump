using UnityEngine;
internal sealed class FortDamageableGenerator : PGBehaviour
{
    // Fields
    private DamageableObject _damageableObject;
    private BaseIsInside _isInsidePlayer;
    private BaseIsInside _isInsideFortObject;
    private int 丗丝丘丞丅丙丟丆下;
    private System.Action<int> 丐丌且下丛世丒丌丘;
    private System.Action<bool> 丟丗丑丝丙丕丅丏丏;
    private bool 丐丐下丌与丘专东丝;
    private System.Action<int> 丘东丌丕万丕丆世丘;
    private int 与业丌丕丛丆丅丟丙;
    
    // Properties
    internal int 与丈且丝一一丄丝丒 { get; }
    internal DamageableObject 丐不丒丅且丏七业与 { get; }
    public int 上丒丗七丙下一上万 { get; }
    
    // Methods
    private void Awake()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDamageableGenerator::下丐丅专丝万丞专丛()));
    }
    private void OnDestroy()
    {
        if(this._damageableObject == 0)
        {
                return;
        }
        
        this._damageableObject.不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDamageableGenerator::下丐丅专丝万丞专丛()));
    }
    internal int 下丟七一东丑丁丘万()
    {
        return (int)this.丗丝丘丞丅丙丟丆下;
    }
    internal DamageableObject 业丒丁丙丛丒上丙丟()
    {
        return (DamageableObject)this._damageableObject;
    }
    internal bool 丏丏丘丄丟丆丝丗丄()
    {
        if(this._damageableObject == 0)
        {
                return false;
        }
        
        if(this._damageableObject != null)
        {
                return this._damageableObject.IsDead();
        }
        
        return this._damageableObject.IsDead();
    }
    private void Update()
    {
        this.下丅丄丟丆世专一丞();
    }
    public void add_OnChangePlayerCount(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丐丌且下丛世丒丌丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丌且下丛世丒丌丘 != 1152921540097123736);
    
    }
    public void remove_OnChangePlayerCount(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丐丌且下丛世丒丌丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丐丌且下丛世丒丌丘 != 1152921540097260312);
    
    }
    public void add_OnEnterMyPlayer(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丟丗丑丝丙丕丅丏丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟丗丑丝丙丕丅丏丏 != 1152921540097396896);
    
    }
    public void remove_OnEnterMyPlayer(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丟丗丑丝丙丕丅丏丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丟丗丑丝丙丕丅丏丏 != 1152921540097533472);
    
    }
    private void 世丑丙丕丛丗丙丝万()
    {
        var val_5;
        var val_15;
        if(this._isInsidePlayer == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(this.丟丗丑丝丙丕丅丏丏 == null)
        {
                return;
        }
        
        this.丗丝丘丞丅丙丟丆下 = 0;
        val_15 = null;
        val_15 = null;
        List.Enumerator<T> val_3 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_31:
        if((1131088832 & 1) == 0)
        {
            goto label_11;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(X21 != 0)
        {
                if(((X21 + 352) != 0) && ((X21 + 352 + 349) != 0))
        {
                if((X21 + 352 + 352 + 92) != 0)
        {
            goto label_31;
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_10 = val_6.丌丟丄业且三丛丕丄().position;
        if((this._isInsidePlayer & 1) != 0)
        {
                int val_14 = this.丗丝丘丞丅丙丟丆下;
            val_14 = val_14 + 1;
            this.丗丝丘丞丅丙丟丆下 = val_14;
        }
        
        if(val_6.丟丌下三七丁与丟丑() == false)
        {
            goto label_31;
        }
        
        var val_12 = (this.丐丐下丌与丘专东丝 == true) ? 1 : 0;
        val_12 = this._isInsidePlayer ^ val_12;
        if((val_12 & 1) == 0)
        {
            goto label_31;
        }
        
        BaseIsInside val_13 = this._isInsidePlayer & 1;
        this.丐丐下丌与丘专东丝 = val_13;
        if(this.丟丗丑丝丙丕丅丏丏 == null)
        {
            goto label_31;
        }
        
        this.丟丗丑丝丙丕丅丏丏.Invoke(obj:  val_13);
        goto label_31;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丗丝丘丞丅丙丟丆下 == this.丗丝丘丞丅丙丟丆下)
        {
                return;
        }
        
        if(this.丐丌且下丛世丒丌丘 == null)
        {
                return;
        }
        
        this.丐丌且下丛世丒丌丘.Invoke(obj:  this.丗丝丘丞丅丙丟丆下);
    }
    public void add_OnChangeMobCount(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丘东丌丕万丕丆世丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘东丌丕万丕丆世丘 != 1152921540097839408);
    
    }
    public void remove_OnChangeMobCount(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丘东丌丕万丕丆世丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丘东丌丕万丕丆世丘 != 1152921540097975984);
    
    }
    public int get_NearCountEnemy()
    {
        return (int)this.与业丌丕丛丆丅丟丙;
    }
    private void 下丐丅专丝万丞专丛()
    {
        this.与业丌丕丛丆丅丟丙 = 0;
        this.下丅丄丟丆世专一丞();
    }
    private void 下丅丄丟丆世专一丞()
    {
        var val_4;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        this.与业丌丕丛丆丅丟丙 = 0;
        val_4 = null;
        val_4 = null;
        HashSet.Enumerator<T> val_2 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.GetEnumerator();
        label_9:
        if((1131734904 & 1) == 0)
        {
            goto label_7;
        }
        
        string val_3 = 0.丐丏七丌丕丗业且上();
        if(0 == 0)
        {
            goto label_9;
        }
        
        int val_4 = this.与业丌丕丛丆丅丟丙;
        val_4 = val_4 + 1;
        this.与业丌丕丛丆丅丟丙 = val_4;
        label_7:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.与业丌丕丛丆丅丟丙 == this.与业丌丕丛丆丅丟丙)
        {
                return;
        }
        
        if(this.丘东丌丕万丕丆世丘 == null)
        {
                return;
        }
        
        this.丘东丌丕万丕丆世丘.Invoke(obj:  this.与业丌丕丛丆丅丟丙);
    }
    public FortDamageableGenerator()
    {
    
    }

}
