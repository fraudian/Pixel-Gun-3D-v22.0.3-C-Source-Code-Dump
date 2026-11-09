using UnityEngine;
internal sealed class LifetimeEventsRaiser : MonoBehaviour
{
    // Fields
    private static LifetimeEventsRaiser 世丒丞七专三与万丕;
    private System.Action<bool> 一丐丁丌丈一丒丐丘;
    private System.Action 七丅丙丌丏丁且丂丒;
    
    // Properties
    internal static LifetimeEventsRaiser 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    internal static LifetimeEventsRaiser 丑七不且上丗丁一世()
    {
        var val_4;
        LifetimeEventsRaiser val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = LifetimeEventsRaiser.世丒丞七专三与万丕;
        if(val_5 == 0)
        {
                val_5 = new UnityEngine.GameObject();
            val_5 = new UnityEngine.GameObject(name:  "LifetimeEventsRaiser");
            val_6 = null;
            val_6 = null;
            LifetimeEventsRaiser.世丒丞七专三与万丕 = new UnityEngine.GameObject().AddComponent<LifetimeEventsRaiser>();
            UnityEngine.Object.DontDestroyOnLoad(target:  new UnityEngine.GameObject());
        }
        
        val_7 = null;
        val_7 = null;
        return (LifetimeEventsRaiser)LifetimeEventsRaiser.世丒丞七专三与万丕;
    }
    internal void 丈丒丒东下丆丙丄丌(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.一丐丁丌丈一丒丐丘, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丐丁丌丈一丒丐丘 != 1152921538254398744);
    
    }
    internal void 丏万万丄丐上丙且下(System.Action<bool> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.一丐丁丌丈一丒丐丘, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.一丐丁丌丈一丒丐丘 != 1152921538254535320);
    
    }
    internal void 丐业丆一业不丁一专(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.七丅丙丌丏丁且丂丒, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七丅丙丌丏丁且丂丒 != 1152921538254671904);
    
    }
    internal void 丏上一上七东丟丅业(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.七丅丙丌丏丁且丂丒, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.七丅丙丌丏丁且丂丒 != 1152921538254808480);
    
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(this.一丐丁丌丈一丒丐丘 == null)
        {
                return;
        }
        
        丁与丟万丄丒丗专丌 = 丁与丟万丄丒丗专丌;
        this.一丐丁丌丈一丒丐丘.Invoke(obj:  丁与丟万丄丒丗专丌);
    }
    private void OnApplicationQuit()
    {
        if(this.七丅丙丌丏丁且丂丒 == null)
        {
                return;
        }
        
        this.七丅丙丌丏丁且丂丒.Invoke();
    }
    public LifetimeEventsRaiser()
    {
    
    }
    private static LifetimeEventsRaiser()
    {
    
    }

}
