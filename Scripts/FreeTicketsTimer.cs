using UnityEngine;
public class FreeTicketsTimer : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UILabel> periodicalFreeTicketsTimerLabels;
    public UnityEngine.GameObject periodicalFreeTicketsTimer;
    private static System.Collections.Generic.List<FreeTicketsTimer> 丒丏与丑上世一丛丒;
    
    // Properties
    internal static bool 下丌不业丈丏下丁丒 { get; }
    
    // Methods
    internal static bool 七丕丕丙与东丝东丁()
    {
        var val_3;
        System.Collections.Generic.List<FreeTicketsTimer> val_4;
        var val_5;
        var val_6;
        System.Func<FreeTicketsTimer, System.Boolean> val_8;
        val_3 = null;
        val_3 = null;
        val_4 = FreeTicketsTimer.丒丏与丑上世一丛丒;
        if(val_4 == null)
        {
                return false;
        }
        
        val_4 = FreeTicketsTimer.丒丏与丑上世一丛丒;
        if(val_4 == null)
        {
                val_4 = 0;
        }
        
        if(val_4.Count < 1)
        {
                return false;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        val_8 = FreeTicketsTimer.<>c.<>9__3_0;
        if(val_8 != null)
        {
                return System.Linq.Enumerable.Any<FreeTicketsTimer>(source:  FreeTicketsTimer.丒丏与丑上世一丛丒, predicate:  System.Func<FreeTicketsTimer, System.Boolean> val_2 = null);
        }
        
        val_8 = val_2;
        val_2 = new System.Func<FreeTicketsTimer, System.Boolean>(object:  FreeTicketsTimer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FreeTicketsTimer.<>c::丁丗业丛与世丝东业(FreeTicketsTimer 丙一丑丏丁一且丒业));
        FreeTicketsTimer.<>c.<>9__3_0 = val_8;
        return System.Linq.Enumerable.Any<FreeTicketsTimer>(source:  FreeTicketsTimer.丒丏与丑上世一丛丒, predicate:  val_2);
    }
    private void Start()
    {
        null = null;
        FreeTicketsTimer.丒丏与丑上世一丛丒.Add(item:  this);
    }
    private void Update()
    {
    
    }
    private void OnDestroy()
    {
        null = null;
        bool val_1 = FreeTicketsTimer.丒丏与丑上世一丛丒.Remove(item:  this);
    }
    private void 丝丂丕东专世丅丝丁()
    {
    
    }
    public FreeTicketsTimer()
    {
    
    }
    private static FreeTicketsTimer()
    {
        FreeTicketsTimer.丒丏与丑上世一丛丒 = new System.Collections.Generic.List<FreeTicketsTimer>();
    }

}
