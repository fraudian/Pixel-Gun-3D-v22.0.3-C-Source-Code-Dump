using UnityEngine;
public class LobbyItemInfoDesigner : MonoBehaviour
{
    // Fields
    public string BindedEventName;
    public 丕专丟上与丄丈三丏.LobbyItemBuff[] Buffs;
    public string EffectLocKey;
    public bool IsHidedItem;
    public string Lkey;
    public 丕专丟上与丄丈三丏.LobbyItemLockInfo[] Lockers;
    public UnityEngine.Material[] materials;
    public 丕专丟上与丄丈三丏.LobbyItemSlot slot;
    
    // Methods
    public LobbyItemInfoDesigner()
    {
        this.Buffs = new LobbyItemBuff[0];
        this.Lockers = new LobbyItemLockInfo[0];
    }

}
