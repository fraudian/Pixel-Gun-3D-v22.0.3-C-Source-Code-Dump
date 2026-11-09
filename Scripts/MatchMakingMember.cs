using UnityEngine;
internal sealed class MatchMakingMember : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject activeIcon;
    private UnityEngine.GameObject inactiveIcon;
    
    // Methods
    internal void 丐丐丗丁东与丒丈丏(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = (~丙业与丙丗丝不丈东) & 1;
        this.inactiveIcon.SetActive(value:  丙业与丙丗丝不丈东);
        this.activeIcon.SetActive(value:  丙业与丙丗丝不丈东);
    }
    public MatchMakingMember()
    {
    
    }

}
