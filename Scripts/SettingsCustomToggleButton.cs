using UnityEngine;
internal sealed class SettingsCustomToggleButton : PGBehaviour, 东七丟与丞丌专丞三
{
    // Fields
    private UnityEngine.GameObject checkStateObject;
    private bool defaultValue;
    private bool 万下丛下业丐丗丘下;
    
    // Methods
    public bool CheckState()
    {
        return (bool)this.万下丛下业丐丗丘下;
    }
    public void SetCheckState(bool 三丟东丕丄丄下下丑)
    {
        this.万下丛下业丐丗丘下 = 三丟东丕丄丄下下丑;
        this.业丄丄丅丝丐丑丄丕();
    }
    public void SwitchCheckState()
    {
        bool val_1 = this.万下丛下业丐丗丘下;
        val_1 = val_1 ^ 1;
        this.万下丛下业丐丗丘下 = val_1;
        this.业丄丄丅丝丐丑丄丕();
    }
    private void 业丄丄丅丝丐丑丄丕()
    {
        this.checkStateObject.SetActive(value:  (this.万下丛下业丐丗丘下 == true) ? 1 : 0);
    }
    public void SetDefault()
    {
        this.万下丛下业丐丗丘下 = this.defaultValue;
        this.业丄丄丅丝丐丑丄丕();
    }
    public bool IsDefault()
    {
        var val_1 = (this.万下丛下业丐丗丘下 == true) ? 1 : 0;
        val_1 = val_1 ^ ((this.defaultValue == true) ? 1 : 0);
        return (bool)val_1 ^ 1;
    }
    public void Set(object 丄三丅七丆丛与与上)
    {
        this.万下丛下业丐丗丘下 = null;
        this.业丄丄丅丝丐丑丄丕();
    }
    public object Get()
    {
        return (object)this.万下丛下业丐丗丘下;
    }
    public void SetReadonly(bool 三丟东丕丄丄下下丑)
    {
        this.GetComponentInChildren<UnityEngine.BoxCollider>().enabled = (~三丟东丕丄丄下下丑) & 1;
    }
    public SettingsCustomToggleButton()
    {
        this.万下丛下业丐丗丘下 = true;
    }

}
