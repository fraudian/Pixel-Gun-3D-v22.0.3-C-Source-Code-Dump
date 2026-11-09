using UnityEngine;
internal sealed class FreeplayVehicleOwner : PGBehaviour
{
    // Fields
    private bool 丏下丏丂丛下东丞丙;
    private int ownerId;
    
    // Properties
    internal bool 丟丁万下一丈专丕与 { get; }
    internal int 业丄专万三丞丙世丗 { get; }
    
    // Methods
    private void Awake()
    {
        var val_7;
        if(this.ownerId == 1)
        {
                object val_7 = this.photonView.instantiationData[0];
            this.ownerId = null;
            System.Object[] val_4 = this.photonView.instantiationData;
            if(val_4.Length >= 2)
        {
                object val_8 = this.photonView.instantiationData[1];
            if(null != null)
        {
                this.丏下丏丂丛下东丞丙 = true;
        }
        
        }
        
        }
        
        val_7 = null;
        val_7 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        GameController.mode + 504.专丘丁丆丕丝丘一业(丝丘下丄丈丗丈丄丘:  this);
    }
    private void 业业丑丝丕丙一万与()
    {
        this.丏下丏丂丛下东丞丙 = true;
    }
    internal void 丞丞业丌东七下丏丐(int 丞丅上丏丂且下丅与)
    {
        var val_1;
        this.ownerId = 丞丅上丏丂且下丅与;
        val_1 = null;
        val_1 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        GameController.mode + 504.专丘丁丆丕丝丘一业(丝丘下丄丈丗丈丄丘:  this);
    }
    internal bool 丏东不世丝丗丅丙丁(int 丞丅上丏丂且下丅与)
    {
        return (bool)(this.ownerId == 丞丅上丏丂且下丅与) ? 1 : 0;
    }
    internal bool 丟丝丐且且丁丏丝上(int 丞丅上丏丂且下丅与)
    {
        if(this.丏下丏丂丛下东丞丙 == false)
        {
                return (bool)(this.ownerId == 丞丅上丏丂且下丅与) ? 1 : 0;
        }
        
        return 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
    }
    internal bool 丈丆下丛万业丏丗丝()
    {
        return (bool)this.丏下丏丂丛下东丞丙;
    }
    internal int 丂丞东丞万万丒丑丆()
    {
        return (int)this.ownerId;
    }
    private void OnDestroy()
    {
        null = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        GameController.mode + 504.丗一丆三丗丐丘丄下(丝丘下丄丈丗丈丄丘:  this);
    }
    public FreeplayVehicleOwner()
    {
        this.ownerId = 0;
    }

}
