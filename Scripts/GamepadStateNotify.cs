using UnityEngine;
internal sealed class GamepadStateNotify : PGBehaviour
{
    // Fields
    internal static GamepadStateNotify 丆丕丝丒不丙且丐丗;
    private UnityEngine.Coroutine 万丈丑下丈与与东丒;
    
    // Methods
    private void Awake()
    {
        if(GamepadStateNotify.丆丕丝丒不丙且丐丗 == 0)
        {
                GamepadStateNotify.丆丕丝丒不丙且丐丗 = this;
        }
        
        GamepadManager.业世丘世丏一丗丗业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GamepadStateNotify::业专丘丑丞且七丅世(string 丙业与丙丗丝不丈东)));
        GamepadManager.丟专与丟丅丑丝丅上(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void GamepadStateNotify::一上丁一丞业丆且下(string 丙业与丙丗丝不丈东)));
    }
    private void 丗丅丙丙丌丛世丝且()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_7 = null;
            val_7 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_8 = null;
            val_8 = null;
            if(丆丗丂三丐不东且丏() != true)
        {
                val_9 = null;
            val_9 = null;
            if(与丂丏丛丞丞丒丟丄.东丟东丟丐丕丗东丅 != true)
        {
                val_10 = null;
            val_10 = null;
            丝丞丙上一丕业丙丒(七丆丂专丁丈丒东丐:  true);
        }
        
        }
        
        }
        
        }
        
        if(this.万丈丑下丈与与东丒 != null)
        {
                this.StopCoroutine(routine:  this.万丈丑下丈与与东丒);
        }
        
        this.万丈丑下丈与与东丒 = this.StartCoroutine(routine:  this.丕世丘丐一丒丄丕丕());
    }
    private void 一上丁一丞业丆且下(string 丙业与丙丗丝不丈东)
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙业与丙丗丝不丈东)) == false)
        {
                return;
        }
        
        this.丗丅丙丙丌丛世丝且();
    }
    private void 业专丘丑丞且七丅世(string 丙业与丙丗丝不丈东)
    {
        if(this.万丈丑下丈与与东丒 != null)
        {
                this.StopCoroutine(routine:  this.万丈丑下丈与与东丒);
        }
        
        丏丝世丆且一专一丗(丙业与丙丗丝不丈东:  false);
    }
    private System.Collections.IEnumerator 丕世丘丐一丒丄丕丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new GamepadStateNotify.丏丙且丅丙丛三丗丌();
    }
    public GamepadStateNotify()
    {
    
    }

}
