using UnityEngine;
internal sealed class MiscAppsMenu : MonoBehaviour
{
    // Fields
    internal static MiscAppsMenu 丆丕丝丒不丙且丐丗;
    public HiddenSettings misc;
    
    // Methods
    public void UnloadMisc()
    {
        this.misc = 0;
    }
    private void Awake()
    {
        MiscAppsMenu.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public MiscAppsMenu()
    {
    
    }

}
