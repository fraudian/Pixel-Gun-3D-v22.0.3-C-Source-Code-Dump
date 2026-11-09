using UnityEngine;
internal class DungeonSpawnPoint : MonoBehaviour
{
    // Fields
    private static System.Action<bool, DungeonSpawnPoint> 三丝丘丞丄丑丝万丒;
    public string nameZone;
    public PlayerSpawnPoint spawnPoint;
    private UnityEngine.GameObject _activatePlatform;
    private UnityEngine.GameObject _deactivatePlatform;
    
    // Methods
    public static void add_OnEnterTrogger(System.Action<bool, DungeonSpawnPoint> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  DungeonSpawnPoint.三丝丘丞丄丑丝万丒, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    public static void remove_OnEnterTrogger(System.Action<bool, DungeonSpawnPoint> 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  DungeonSpawnPoint.三丝丘丞丄丑丝万丒, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void Start()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(DungeonsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        Add(item:  this);
    }
    private void OnTriggerEnter(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_2 = null;
        if((且丙与丏下丅丐世丑.gameObject & 1) == 0)
        {
                return;
        }
        
        if(DungeonSpawnPoint.三丝丘丞丄丑丝万丒 == null)
        {
                return;
        }
        
        DungeonSpawnPoint.三丝丘丞丄丑丝万丒.Invoke(arg1:  true, arg2:  this);
    }
    private void OnTriggerExit(UnityEngine.Collider 且丙与丏下丅丐世丑)
    {
        var val_2 = null;
        if((且丙与丏下丅丐世丑.gameObject & 1) == 0)
        {
                return;
        }
        
        if(DungeonSpawnPoint.三丝丘丞丄丑丝万丒 == null)
        {
                return;
        }
        
        DungeonSpawnPoint.三丝丘丞丄丑丝万丒.Invoke(arg1:  false, arg2:  this);
    }
    internal void 下丒不丄七东丟丟丝()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._activatePlatform, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._deactivatePlatform, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丙丅丞东丛丐万七丆()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._activatePlatform, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._deactivatePlatform, 丏业丟一东丂东丘丛:  true);
    }
    public DungeonSpawnPoint()
    {
        this.nameZone = "";
    }

}
