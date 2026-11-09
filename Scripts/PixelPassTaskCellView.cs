using UnityEngine;
internal sealed class PixelPassTaskCellView : EndlessScrollCellDynamic
{
    // Fields
    private UnityEngine.GameObject enableIfFirst;
    private UnityEngine.GameObject enableIfFirstCalendar;
    private UnityEngine.GameObject enableInNotFirst;
    private PixelPassView pixelPassView;
    private PixelPassTaskListView taskListView;
    private UnityEngine.GameObject holder;
    private UnityEngine.GameObject headerContent;
    private UIBasicSprite icon;
    private UILabel titleLabel;
    private PGCompany.TimerUI timerUi;
    private PixelPassTaskCellViewDaily type_Daily;
    private PixelPassTaskCellViewCalendar type_Calendar;
    private PixelPassTaskCellViewElite type_Elite;
    private 丕丐丟丒丆丒丟丅丈 丅万七丐丗下业世丆;
    private System.Collections.Generic.List<PixelPassTaskView> 一丛一丑业丂丙丄丝;
    
    // Properties
    internal 丕丐丟丒丆丒丟丅丈 七丌丁与业丌丘东丝 { get; }
    internal System.Collections.Generic.List<PixelPassTaskView> 丟丛丐丁丟丅专丛丆 { get; }
    
    // Methods
    internal 丕丐丟丒丆丒丟丅丈 下万三丁丈万专丙业()
    {
        return (丕丐丟丒丆丒丟丅丈)this.丅万七丐丗下业世丆;
    }
    internal System.Collections.Generic.List<PixelPassTaskView> 丟且专三丐丂上丄不()
    {
        System.Collections.Generic.List<PixelPassTaskView> val_4;
        if(this.一丛一丑业丂丙丄丝 != null)
        {
                if(this.一丛一丑业丂丙丄丝.Count != 0)
        {
                val_4 = this.一丛一丑业丂丙丄丝;
            return (System.Collections.Generic.List<PixelPassTaskView>)val_3;
        }
        
        }
        
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<PixelPassTaskView>(source:  this.GetComponentsInChildren<PixelPassTaskView>(includeInactive:  true));
        this.一丛一丑业丂丙丄丝 = val_3;
        return (System.Collections.Generic.List<PixelPassTaskView>)val_3;
    }
    private void OnEnable()
    {
        object val_5 = this;
        List.Enumerator<T> val_2 = this.丟且专三丐丂上丄不().GetEnumerator();
        label_4:
        if(((-385873272) & 1) == 0)
        {
            goto label_2;
        }
        
        new System.Action() = new System.Action(object:  this, method:  System.Void PixelPassTaskCellView::上丛三丒丕丁丛丟与());
        0.丐丏七丌丕丗业且上().丁丂丅万丛丈丝丘丄(丙业与丙丗丝不丈东:  new System.Action());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void OnDisable()
    {
        object val_5 = this;
        List.Enumerator<T> val_2 = this.丟且专三丐丂上丄不().GetEnumerator();
        label_4:
        if(((-385736696) & 1) == 0)
        {
            goto label_2;
        }
        
        new System.Action() = new System.Action(object:  this, method:  System.Void PixelPassTaskCellView::上丛三丒丕丁丛丟与());
        0.丐丏七丌丕丗业且上().丝丛丂丅东丕丐下丝(丙业与丙丗丝不丈东:  new System.Action());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丈且东丑丂且万丒丅(丕丐丟丒丆丒丟丅丈 世丝专丝与丑业丑万)
    {
        this.丅万七丐丗下业世丆 = 世丝专丝与丑业丑万;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        丕丐丟丒丆丒丟丅丈 val_14;
        var val_15;
        PixelPassTaskCellViewDaily val_16;
        if(this.丅万七丐丗下业世丆 == null)
        {
            goto label_1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfFirst, 丏业丟一东丂东丘丛:  (this.丅万七丐丗下业世丆.丞丛与丞丛一丅业东() != 2) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfFirstCalendar, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableInNotFirst, 丏业丟一东丂东丘丛:  false);
        if(this.丅万七丐丗下业世丆.丞丛与丞丛一丅业东() == 2)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableIfFirstCalendar, 丏业丟一东丂东丘丛:  (this.丅万七丐丗下业世丆.丝丐丄丕东世丙七丏 == true) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableInNotFirst, 丏业丟一东丂东丘丛:  (this.丅万七丐丗下业世丆.丝丐丄丕东世丙七丏 == false) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.headerContent, 丏业丟一东丂东丘丛:  (this.丅万七丐丗下业世丆.丝丐丄丕东世丙七丏 == false) ? 1 : 0);
        }
        
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.icon, 与万丆丛丒万丝丙丑:  this.丅万七丐丗下业世丆.三丗一丄不丆不丏三());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.titleLabel, 丕丗丘丑丛与丑业丒:  this.丅万七丐丗下业世丆.丘丄业丞丏与与丅丐());
        val_14 = this.丅万七丐丗下业世丆;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.timerUi, 丏业丟一东丂东丘丛:  (val_14.丝且丁丌丂七丟且丙() > 0) ? 1 : 0);
        if((this.丅万七丐丗下业世丆.丝且丁丌丂七丟且丙() >= 1) && (this.timerUi != null))
        {
                val_14 = this.丅万七丐丗下业世丆;
            this.timerUi.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_14.丝且丁丌丂七丟且丙(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.type_Daily, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.type_Calendar, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.type_Elite, 丏业丟一东丂东丘丛:  false);
        PGCompany.PixelPass.丒且丏万业业七业万 val_13 = this.丅万七丐丗下业世丆.丞丛与丞丛一丅业东();
        if(val_13 == 3)
        {
            goto label_24;
        }
        
        if(val_13 == 2)
        {
            goto label_25;
        }
        
        if(val_13 != 1)
        {
            goto label_26;
        }
        
        val_14 = this.丅万七丐丗下业世丆;
        this.type_Daily.丈且东丑丂且万丒丅(世丝专丝与丑业丑万:  val_14);
        val_15 = null;
        val_16 = this.type_Daily;
        goto label_37;
        label_1:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        return;
        label_24:
        val_14 = this.丅万七丐丗下业世丆;
        this.type_Elite.丈且东丑丂且万丒丅(世丝专丝与丑业丑万:  val_14);
        val_15 = null;
        val_16 = this.type_Elite;
        goto label_37;
        label_25:
        val_14 = this.丅万七丐丗下业世丆;
        this.type_Calendar.丈且东丑丂且万丒丅(世丝专丝与丑业丑万:  val_14);
        val_15 = null;
        val_16 = this.type_Calendar;
        label_37:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_16, 丏业丟一东丂东丘丛:  true);
        label_26:
        this.UpdateRects();
    }
    public void ShowEliteTasks()
    {
        this.pixelPassView.与七丌丌与不不丏丑();
    }
    private void 上丛三丒丕丁丛丟与()
    {
        if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() != false)
        {
                return;
        }
        
        this.taskListView.万丗丞丂丒世丁丟丟(丟丄丛专丏丆与丑一:  this);
    }
    public PixelPassTaskCellView()
    {
    
    }

}
