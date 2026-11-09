using UnityEngine;
internal class TriggerObject : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal PhotonView 丅丏三七丁丑丞丄丏;
    private System.Action<int> 丌七丌东丘不丞下丏;
    private bool 丛丂丁丕丕丞七七丅;
    private UnityEngine.BoxCollider _boxCollider;
    public float indicationOffset;
    
    // Methods
    internal void 专三丅且丌丏万丕丆(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丌七丌东丘不丞下丏, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌七丌东丘不丞下丏 != 1152921540061098256);
    
    }
    internal void 三丛丐丄丑丗丏丞上(System.Action<int> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丌七丌东丘不丞下丏, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丌七丌东丘不丞下丏 != 1152921540061234832);
    
    }
    private void Awake()
    {
        this.丅丏三七丁丑丞丄丏 = this.GetComponent<PhotonView>();
        if(this._boxCollider != 0)
        {
                return;
        }
        
        this._boxCollider = this.GetComponent<UnityEngine.BoxCollider>();
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        if((丞世不丒下上上丝丑 & 255) == 197)
        {
                if(专丒丌丆下丐丞丟丞.Length != 0)
        {
                object val_2 = 专丒丌丆下丐丞丟丞[0];
            this.一上上专丂丅丄丗丄(丅上丁不丛丁上七丈:  21884928);
        }
        
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        Player_move_c val_8;
        PhotonView val_9;
        var val_10;
        var val_11;
        val_9 = this;
        if(this.丛丂丁丕丕丞七七丅 == true)
        {
                return;
        }
        
        val_8 = 1152921504848912384;
        if((丘丛丏丘丝七世七丅.gameObject.GetComponentInParent<SkinName>()) == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_8 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_2.playerMoveC != val_8)
        {
                return;
        }
        
        val_9 = this.丅丏三七丁丑丞丄丏;
        object[] val_5 = new object[1];
        val_11 = null;
        val_11 = null;
        val_8 = typeof(Player_move_c).__il2cppRuntimeField_3B8.owner.业丐丐三丕一丗丛丁();
        val_5[0] = val_8;
        val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  197, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_5);
    }
    private void 一上上专丂丅丄丗丄(int 丅上丁不丛丁上七丈)
    {
        if(this.丛丂丁丕丕丞七七丅 != false)
        {
                return;
        }
        
        this.丛丂丁丕丕丞七七丅 = true;
        if(this.丌七丌东丘不丞下丏 == null)
        {
                return;
        }
        
        this.丌七丌东丘不丞下丏.Invoke(obj:  丅上丁不丛丁上七丈);
    }
    public void ActivateTrigger(bool 世丁万下丗专世万丅)
    {
        世丁万下丗专世万丅 = 世丁万下丗专世万丅;
        this._boxCollider.enabled = 世丁万下丗专世万丅;
    }
    public TriggerObject()
    {
    
    }

}
