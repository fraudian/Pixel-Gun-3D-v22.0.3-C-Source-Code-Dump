using UnityEngine;
internal sealed class AmongUsButtonLobby : PGBehaviour
{
    // Fields
    private static AmongUsButtonLobby 丝业丆丁业三丈丟东;
    private UnityEngine.GameObject _holder;
    
    // Properties
    public static AmongUsButtonLobby 丆丕丝丒不丙且丐丗 { get; }
    
    // Methods
    public static AmongUsButtonLobby get_Instance()
    {
        return (AmongUsButtonLobby)AmongUsButtonLobby.丝业丆丁业三丈丟东;
    }
    internal static bool 丙丝丌与丘丗与东丁()
    {
        AmongUsButtonLobby val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东;
        if(val_10 == 0)
        {
                return false;
        }
        
        val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东.gameObject;
        if(val_10 == 0)
        {
                return false;
        }
        
        val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东.gameObject;
        if(val_10.activeSelf == false)
        {
                return false;
        }
        
        val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东.gameObject;
        if(val_10.activeInHierarchy == false)
        {
                return false;
        }
        
        val_10 = mem[AmongUsButtonLobby.丝业丆丁业三丈丟东 + 72];
        val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东._holder;
        if(val_10 == 0)
        {
                return false;
        }
        
        val_10 = mem[AmongUsButtonLobby.丝业丆丁业三丈丟东 + 72];
        val_10 = AmongUsButtonLobby.丝业丆丁业三丈丟东._holder;
        if(activeSelf == false)
        {
                return false;
        }
        
        if(null != 0)
        {
                return activeInHierarchy;
        }
        
        return activeInHierarchy;
    }
    private void Awake()
    {
        AmongUsButtonLobby.丝业丆丁业三丈丟东 = this;
    }
    private void OnDestroy()
    {
        AmongUsButtonLobby.丝业丆丁业三丈丟东 = 0;
    }
    private void OnEnable()
    {
        this.丕丕业七丙七丅丈丄();
    }
    private void OnDisable()
    {
    
    }
    internal void 丕丕业七丙七丅丈丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.IEnumerator 丕东丙一七专丗丈丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new AmongUsButtonLobby.丈不业丒三专丘一不();
    }
    private bool 丂万丆丆丌丗丏丅不()
    {
        bool val_2 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  30);
        val_2 = (~val_2) & 1;
        return (bool)val_2;
    }
    public AmongUsButtonLobby()
    {
    
    }

}
