using UnityEngine;
internal sealed class ProgressRoadLevelUpView : PGBehaviour
{
    // Fields
    private static System.Action 丟不丒万丝与丂上丘;
    private UILabel newLevelLabel;
    private ProgressRoadPointRewardsView rewardsView;
    private float showTime;
    
    // Methods
    internal static void 丘丌世专丌专丕丂丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ProgressRoadLevelUpView.丟不丒万丝与丂上丘, b:  丙业与丙丗丝不丈东);
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
    internal static void 不丛丛丌上丕丏专三(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ProgressRoadLevelUpView.丟不丒万丝与丂上丘, value:  丙业与丙丗丝不丈东);
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
    public void Show(ProgressRoad.丅丂丅丕下丑丘万一 东东丗丅与一下丄丈)
    {
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.newLevelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11113"), arg0:  东东丗丅与一下丄丈.丘丈不不下丙万丌专));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        一丛丟世丗丈丘丏万 val_5 = 丌东一万丗上丝丌三.七丄丂丆万一与丅丕(丒丘丏上丙丟丑丕丈:  "ProgressRoad_LevelUpAnimationClose", 丘丁三丅丆与丆业业:  this.showTime, 七丐丅专且专七三丆:  new System.Action(object:  this, method:  public System.Void ProgressRoadLevelUpView::Hide()));
    }
    public void Hide()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        if(ProgressRoadLevelUpView.丟不丒万丝与丂上丘 == null)
        {
                return;
        }
        
        ProgressRoadLevelUpView.丟不丒万丝与丂上丘.Invoke();
    }
    public ProgressRoadLevelUpView()
    {
        this.showTime = 4f;
    }

}
