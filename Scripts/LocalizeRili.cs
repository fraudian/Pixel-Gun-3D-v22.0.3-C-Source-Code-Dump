using UnityEngine;
public class LocalizeRili : MonoBehaviour
{
    // Fields
    public bool chek;
    public bool workWithSelection;
    public bool dontNeedLocalize;
    public bool dontNeedFont;
    public System.Collections.Generic.List<UILabel> labels;
    public string term;
    public bool execute;
    public bool localizeFont;
    public bool selfDestroy;
    
    // Methods
    public LocalizeRili()
    {
        this.selfDestroy = true;
    }

}
