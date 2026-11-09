using UnityEngine;
internal class 下丟世丏三东万丘丏
{
    // Fields
    private static 下丟世丏三东万丘丏 世丒丞七专三与万丕;
    private static System.TimeSpan 与丞下丐与丑丅丑三;
    
    // Properties
    internal static 下丟世丏三东万丘丏 丆丕丝丒不丙且丐丗 { get; }
    internal static bool 丈丘不丏丅丒东丕世 { get; }
    internal static bool 丁丛丏不丗上丁丁丙 { get; }
    internal static bool 专专丘世丘上丑丘业 { get; }
    internal static bool 三一丆万一丘不丝三 { get; }
    internal static System.TimeSpan 世且丁下与世上丆丒 { get; }
    
    // Methods
    internal static 下丟世丏三东万丘丏 丑七不且上丗丁一世()
    {
        下丟世丏三东万丘丏 val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(下丟世丏三东万丘丏.世丒丞七专三与万丕 == null)
        {
                下丟世丏三东万丘丏 val_1 = null;
            val_2 = val_1;
            val_1 = new 下丟世丏三东万丘丏();
            val_4 = null;
            val_4 = null;
            下丟世丏三东万丘丏.世丒丞七专三与万丕 = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        return (下丟世丏三东万丘丏)下丟世丏三东万丘丏.世丒丞七专三与万丕;
    }
    internal static bool 丆丐不上三专丝丌不()
    {
        Rilisoft.WebSocket.WebSocketManager val_1 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        if(val_1 != null)
        {
                return val_1.丕上业丐七丂且不丁();
        }
        
        return val_1.丕上业丐七丂且不丁();
    }
    internal static bool 不丂丆丏丒三丝丆丄()
    {
        var val_2 = null;
        bool val_1 = 下丟世丏三东万丘丏.丆丐不上三专丝丌不();
        val_1 = (~val_1) & 1;
        return (bool)val_1;
    }
    internal static bool 下不丙丌丙丞丞万上()
    {
        if((Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丕且一与专丘丄上上()) == false)
        {
                return 与丂丏丛丞丞丒丟丄.丕丟与丕上东丅丏丏();
        }
        
        return true;
    }
    internal static bool 东丗业一丌且丟世一()
    {
        var val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        if(val_5.丕上业丐七丂且不丁() == false)
        {
                return false;
        }
        
        val_5 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
        BestHTTP.SocketIO.SocketManager val_4 = val_5.丛且丈世下下丂丏七();
        if(val_4 == null)
        {
                return false;
        }
        
        return val_4.InSoftDisconnect;
    }
    internal static System.TimeSpan 一丁丒丕丐丙丗上丛()
    {
        null = null;
        return (System.TimeSpan)下丟世丏三东万丘丏.与丞下丐与丑丅丑三;
    }
    public 下丟世丏三东万丘丏()
    {
    
    }
    private static 下丟世丏三东万丘丏()
    {
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  10);
        下丟世丏三东万丘丏.与丞下丐与丑丅丑三 = val_1._ticks;
    }

}
