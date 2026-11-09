using UnityEngine;
public class AlmanachTutorialManager : MonoBehaviour
{
    // Fields
    private static System.Action 与万丒丞七丅丝丝上;
    private static bool 不丌丐丄丙丑丞丂万;
    public static int TutorialWeaponIndex;
    public static string TutorialWeaponSetId;
    private static PGCompany.丟丝东丈丐丙三下丛 一万三七丟七丈一丟;
    private static AlmanachWeaponSet 丂专与不丄且丗一丌;
    private AlmanachTutorialStep 上世上丂丆东下东丒;
    public UnityEngine.GameObject holder;
    public UnityEngine.GameObject stepsHplder;
    public System.Collections.Generic.List<AlmanachTutorialStep> steps;
    
    // Properties
    public static bool 三丞丛东一丂丆丆与 { get; }
    internal static PGCompany.丟丝东丈丐丙三下丛 丗三不丟三与丗丛丝 { get; }
    internal static AlmanachWeaponSet 丘上且丄下且丗业丑 { get; }
    public static bool 丄丏丈七丝七世丂世 { get; set; }
    
    // Methods
    public static void add_onTutorialFinished(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  AlmanachTutorialManager.与万丒丞七丅丝丝上, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_onTutorialFinished(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  AlmanachTutorialManager.与万丒丞七丅丝丝上, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static bool get_IsRunning()
    {
        null = null;
        return (bool)AlmanachTutorialManager.不丌丐丄丙丑丞丂万;
    }
    internal static PGCompany.丟丝东丈丐丙三下丛 丑且万丏七丝丞上三()
    {
        var val_4;
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(AlmanachTutorialManager.一万三七丟七丈一丟 == null)
        {
                val_6 = null;
            val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_6 = null;
            val_5 = null;
            AlmanachTutorialManager.一万三七丟七丈一丟 = val_4.丐万且丏丙万下专丑<PGCompany.丟丝东丈丐丙三下丛>(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  AlmanachTutorialManager.TutorialWeaponIndex));
        }
        
        val_5 = null;
        return (PGCompany.丟丝东丈丐丙三下丛)AlmanachTutorialManager.一万三七丟七丈一丟;
    }
    internal static AlmanachWeaponSet 上三丞且丞丐丟世丕()
    {
        AlmanachWeaponSet val_4;
        var val_5;
        var val_6;
        System.Func<AlmanachWeaponSet, System.Boolean> val_8;
        val_5 = null;
        val_5 = null;
        if(AlmanachTutorialManager.丂专与不丄且丗一丌 == null)
        {
                val_6 = null;
            val_6 = null;
            val_8 = AlmanachTutorialManager.<>c.<>9__13_0;
            if(val_8 == null)
        {
                System.Func<AlmanachWeaponSet, System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Func<AlmanachWeaponSet, System.Boolean>(object:  AlmanachTutorialManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean AlmanachTutorialManager.<>c::丐丕丗丞丒丒世万与(AlmanachWeaponSet 三丟东丕丄丄下下丑));
            AlmanachTutorialManager.<>c.<>9__13_0 = val_8;
        }
        
            val_5 = null;
            val_4 = System.Linq.Enumerable.First<AlmanachWeaponSet>(source:  上且丁万与丌下丐上.丗丌丆一与丂丌丌与(), predicate:  val_2);
            val_5 = null;
            AlmanachTutorialManager.丂专与不丄且丗一丌 = val_4;
        }
        
        val_5 = null;
        return (AlmanachWeaponSet)AlmanachTutorialManager.丂专与不丄且丗一丌;
    }
    public static bool get_TutorialFinished()
    {
        return (bool)((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  70)) > 0) ? 1 : 0;
    }
    public static void set_TutorialFinished(bool 丙业与丙丗丝不丈东)
    {
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  70, 丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    private void OnDisable()
    {
        null = null;
        AlmanachTutorialManager.不丌丐丄丙丑丞丂万 = false;
    }
    public void Init()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(上且丁万与丌下丐上.丘丑丕不丝万丝丛下() == false)
        {
                return;
        }
        
        val_7 = null;
        if(AlmanachTutorialManager.TutorialFinished == true)
        {
                return;
        }
        
        val_8 = null;
        if(AlmanachTutorialManager.IsRunning == true)
        {
                return;
        }
        
        this.steps.Clear();
        val_9 = 0;
        goto label_12;
        label_17:
        this.steps.Add(item:  this.stepsHplder.GetComponentsInChildren<AlmanachTutorialStep>(includeInactive:  true)[0]);
        val_9 = 1;
        label_12:
        if(val_9 < val_4.Length)
        {
            goto label_17;
        }
        
        AlmanachTutorialStep val_5 = this.一丅专且不丄丁专丏();
        this.上世上丂丆东下东丒 = val_5;
        if(val_5 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        AlmanachTutorialManager.不丌丐丄丙丑丞丂万 = true;
        this.holder.SetActive(value:  true);
        if(this.上世上丂丆东下东丒 == null)
        {
            
        }
    
    }
    private AlmanachTutorialStep 一丅专且不丄丁专丏()
    {
        var val_3;
        List.Enumerator<T> val_1 = this.steps.GetEnumerator();
        label_4:
        if(((-1761094920) & 1) == 0)
        {
            goto label_2;
        }
        
        val_3 = 0.丐丏七丌丕丗业且上();
        if((val_3 & 1) != 0)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_3 = 0;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (AlmanachTutorialStep);
    }
    public void MainButtonPressed()
    {
        this.ToNextStep();
    }
    public void ToNextStep()
    {
        var val_14;
        var val_15;
        int val_16;
        UnityEngine.Object val_17;
        AlmanachTutorialStep val_18;
        val_14 = this;
        if(this.上世上丂丆东下东丒 == 0)
        {
            goto label_15;
        }
        
        int val_14 = this.上世上丂丆东下东丒.index;
        val_15 = 1152921524320818016;
        label_9:
        val_14 = val_14 + 1;
        val_16 = public System.Int32 System.Collections.Generic.List<AlmanachTutorialStep>::get_Count();
        if(val_14 >= this.steps.Count)
        {
            goto label_6;
        }
        
        if((this.steps.Item[val_14] & 1) != 0)
        {
            goto label_9;
        }
        
        val_16 = val_14;
        val_17 = this.steps.Item[val_16];
        goto label_11;
        label_6:
        val_17 = 0;
        label_11:
        val_18 = this.上世上丂丆东下东丒;
        if(val_17 == 0)
        {
            goto label_15;
        }
        
        this.上世上丂丆东下东丒 = val_17;
        val_14 = ???;
        val_18 = ???;
        val_15 = ???;
        goto mem[282584257677063];
        label_15:
        val_14.丐不丐丑上丈且丆专();
    }
    private void 丐不丐丑上丈且丆专()
    {
        null = null;
        AlmanachTutorialManager.不丌丐丄丙丑丞丂万 = false;
        AlmanachTutorialManager.TutorialFinished = true;
        this.holder.SetActive(value:  false);
        if(AlmanachTutorialManager.与万丒丞七丅丝丝上 == null)
        {
                return;
        }
        
        0.Invoke();
    }
    public AlmanachTutorialManager()
    {
    
    }
    private static AlmanachTutorialManager()
    {
        AlmanachTutorialManager.TutorialWeaponIndex = 162001;
        AlmanachTutorialManager.TutorialWeaponSetId = "starter";
    }

}
