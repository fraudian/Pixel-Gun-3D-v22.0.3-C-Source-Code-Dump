using UnityEngine;
internal class ShoppingAreaBase : PhotonEventBehaviour
{
    // Fields
    protected bool 专丒丄丌丂丙丟世丅;
    protected FpcShoppingAreaStateController 世丐三东丑丈丄丝丈;
    protected FirstPersonControlSharp 丌丕万丑丒丂丟丌七;
    private bool 丛三丟丘丈丏三丈下;
    
    // Properties
    internal 丟丞世万丈丒丒上丟 丄丆专丁丕丆丐丝丝 { get; }
    
    // Methods
    internal 丟丞世万丈丒丒上丟 丝专丗丂丅丒七丞东()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.世丐三东丑丈丄丝丈)) == false)
        {
                return 0;
        }
        
        if(this.世丐三东丑丈丄丝丈 != null)
        {
                return this.世丐三东丑丈丄丝丈.丄丙丂丝丄丌丗丂丅();
        }
        
        return this.世丐三东丑丈丄丝丈.丄丙丂丝丄丌丗丂丅();
    }
    protected virtual void Awake()
    {
        this.世丐三东丑丈丄丝丈 = this.GetComponent<FpcShoppingAreaStateController>();
    }
    protected virtual void Start()
    {
        this.世丐三东丑丈丄丝丈.丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  1);
    }
    internal virtual void 丙丆丐一三丌丝丕丌()
    {
        this.专丒丄丌丂丙丟世丅 = true;
    }
    internal virtual void 丛三丐丘丂丈专丏专()
    {
        this.专丒丄丌丂丙丟世丅 = false;
    }
    protected virtual void LateUpdate()
    {
        this.丝丘丒丛三业且丄世();
    }
    private void 丝丘丒丛三业且丄世()
    {
        UnityEngine.GameObject val_6;
        if(this.丛三丟丘丈丏三丈下 == true)
        {
                return;
        }
        
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        val_6 = 1152921505219145728;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂 == 0)
        {
                return;
        }
        
        if(InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg == 0)
        {
                return;
        }
        
        val_6 = this.gameObject;
        InGameGUIPart_Freeplay.__il2cppRuntimeField_byval_arg.丛丘丗丆丌丏不丑专(万不且且丛丆东丒业:  val_6, 丁丅丈丌丟世丗丗丟:  29);
        this.丛三丟丘丈丏三丈下 = true;
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.丂丈与万一丆丄丅丂(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        goto typeof(ShoppingAreaBase).__il2cppRuntimeField_188;
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.丂丈与万一丆丄丅丂(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        goto typeof(ShoppingAreaBase).__il2cppRuntimeField_198;
    }
    private bool 丂丈与万一丆丄丅丂(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        FirstPersonControlSharp val_9;
        var val_10;
        val_9 = this;
        if((丘丛丏丘丝七世七丅.CompareTag(tag:  "BodyCollider")) != false)
        {
                UnityEngine.Transform val_3 = 丘丛丏丘丝七世七丅.transform.parent;
            if((val_3 != 0) && ((val_3.CompareTag(tag:  "Player")) != false))
        {
                FirstPersonControlSharp val_6 = val_3.GetComponent<FirstPersonControlSharp>();
            this.丌丕万丑丒丂丟丌七 = val_6;
            if(val_6 != 0)
        {
                val_9 = this.丌丕万丑丒丂丟丌七;
            var val_8 = (this.丌丕万丑丒丂丟丌七.丌且下丕下下丌万丞 == true) ? 1 : 0;
            return (bool)val_10;
        }
        
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public ShoppingAreaBase()
    {
    
    }

}
