using UnityEngine;
internal sealed class GovernorCellRowLocked : PGBehaviour
{
    // Fields
    private UILabel topTextLabel;
    private UILabel mainTextLabel;
    private ClanGovernorTaskCellView 世丝专丝与丑业丑万;
    
    // Methods
    public void Setup(ClanGovernorTaskCellView 丙丈丌丗丅三丙万丁)
    {
        this.世丝专丝与丑业丑万 = 丙丈丌丗丅三丙万丁;
        this.UpdateView();
    }
    public void UpdateView()
    {
        if(this.世丝专丝与丑业丑万 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.topTextLabel, 丕丗丘丑丛与丑业丒:  this.世丝专丝与丑业丑万.三下丌且与丘丆丏且.丘丆丐不丟丛丞丝与());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.mainTextLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "ClanGovernor_RowLockLevel_" + this.世丝专丝与丑业丑万.三下丌且与丘丆丏且.丘丆丐不丟丛丞丝与()));
        this.上丅丕丅丟丕丏丁丆();
    }
    private void 上丅丕丅丟丕丏丁丆()
    {
        if(this.世丝专丝与丑业丑万 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.世丝专丝与丑业丑万.transform.position;
        this.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Vector3 val_6 = this.transform.localPosition;
        this.transform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = 0f, z = val_6.z};
    }
    private void Update()
    {
        this.上丅丕丅丟丕丏丁丆();
    }
    public GovernorCellRowLocked()
    {
    
    }

}
