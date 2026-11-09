using UnityEngine;
internal sealed class CurrentProgressView : PGBehaviour
{
    // Fields
    private UILabel _progressLabel;
    
    // Methods
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅();
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrentProgressView::丈且东丑丂且万丒丅()));
        ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrentProgressView::丈且东丑丂且万丒丅()));
    }
    private void OnDisable()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrentProgressView::丈且东丑丂且万丒丅()));
        ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CurrentProgressView::丈且东丑丂且万丒丅()));
    }
    private void 丈且东丑丂且万丒丅()
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)ExperienceController.丂丂下丑且下丌丝东())(专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)ExperienceController.丂丂下丑且下丌丝东())) + " [14ff05]XP[-]"(" [14ff05]XP[-]"));
    }
    public CurrentProgressView()
    {
    
    }

}
