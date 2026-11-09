using UnityEngine;
public class PlayerSpawnPoint : MonoBehaviour
{
    // Fields
    public 丅丌丂世一丟丅丕丆 spawnPointType;
    public 且丑丗丟丒业上东丙 teamBelonging;
    public int areaNumber;
    public UnityEngine.BoxCollider boxCollider;
    internal UnityEngine.Transform 万东万丆专丌丕丐丗;
    private int <丑丟丟业丞七业业丆>k__BackingField;
    private int <专七东丏丌丙丌业与>k__BackingField;
    
    // Properties
    internal int 丐与丝专丄丘丈丘上 { get; set; }
    internal int 丟丞丆丆丈业下下一 { get; set; }
    
    // Methods
    internal int 丈丄丙丅不下丒且七()
    {
        return (int)this.<丑丟丟业丞七业业丆>k__BackingField;
    }
    private void 丕三业丒丟世丟丙丟(int 丙业与丙丗丝不丈东)
    {
        this.<丑丟丟业丞七业业丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丑丟且世丛丄丈丝七()
    {
        return (int)this.<专七东丏丌丙丌业与>k__BackingField;
    }
    private void 一丝丏业丂东丌丄丄(int 丙业与丙丗丝不丈东)
    {
        this.<专七东丏丌丙丌业与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.万东万丆专丌丕丐丗 = this.transform;
        if(this.spawnPointType == 6)
        {
                return;
        }
        
        丘丛丞且一丅丁丏丐.丞三世丐丛丂丄丄丛(丏丅丅专七丘丑上丂:  this);
    }
    internal void 丕七丂且三与上丗丌(int 丐与丝专丄丘丈丘上)
    {
        this.<丑丟丟业丞七业业丆>k__BackingField = 丐与丝专丄丘丈丘上;
    }
    internal void 上三上丁七丟东丛丅(int 丟丞丆丆丈业下下一)
    {
        this.<专七东丏丌丙丌业与>k__BackingField = 丟丞丆丆丈业下下一;
    }
    public PlayerSpawnPoint()
    {
    
    }

}
