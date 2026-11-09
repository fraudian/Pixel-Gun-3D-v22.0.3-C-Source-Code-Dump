using UnityEngine;
public sealed class StoreInfoInCompetition : PGBehaviour
{
    // Fields
    private WidgetLayout _widgetLayout;
    private UILabel _currencyCompetitionTier1Count;
    private UILabel _currencyCompetitionTier2Count;
    
    // Methods
    public void UpdateView()
    {
        WidgetLayout val_6;
        var val_7;
        val_6 = this;
        val_7 = null;
        val_7 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._currencyCompetitionTier1Count, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  丐丏七丈且丌丄三丏.七丌丒丏丟丂丒丑丙));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._currencyCompetitionTier2Count, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  丐丏七丈且丌丄三丏.丝下三丕七丕一万与));
        if(this._widgetLayout == 0)
        {
                return;
        }
        
        val_6 = this._widgetLayout;
        val_6.Reposition();
    }
    public StoreInfoInCompetition()
    {
    
    }

}
