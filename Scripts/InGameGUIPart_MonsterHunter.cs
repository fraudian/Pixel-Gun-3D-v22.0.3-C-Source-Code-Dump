using UnityEngine;
internal sealed class InGameGUIPart_MonsterHunter : InGameGUIPartContainer
{
    // Fields
    internal ProgressBarUI monsterBarHP;
    private GameStageEvent monsterNameLabel;
    private string 丝丘不东三丗丈丒专;
    
    // Methods
    private void Awake()
    {
        InGameGUI.丙丞专丌丁丞与不丐.丁丁丕丂丐丐丒万丂 = this;
    }
    internal void 与上丗丞丐丆丕丈一(string 丒丘丏上丙丟丑丕丈)
    {
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        this.monsterNameLabel.Show(丕丗丘丑丛与丑业丒:  System.String.Format(format:  this.丝丘不东三丗丈丒专, arg0:  丒丘丏上丙丟丑丕丈), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public InGameGUIPart_MonsterHunter()
    {
        this.丝丘不东三丗丈丒专 = "Игрок {0} стал монстром";
    }

}
