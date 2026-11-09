using UnityEngine;
public class OfflineModController : MonoBehaviour
{
    // Fields
    internal static OfflineModController 丄丘七三上丕世丞业;
    public UnityEngine.GameObject offlineWindowHolder;
    public UnityEngine.GameObject offlineButtonHolder;
    public UIButton openWindowButton;
    public UIButton closeWindowButton;
    public UIButton goOnlineButton;
    private static readonly int 丛丞丛七丛且丙丝丒;
    private static readonly System.Collections.Generic.List<string> 丑丅丆不丒三业丙丘;
    private static readonly System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> 丐丙下丈七不丛丘丝;
    private System.Collections.Generic.List<UIButton> 与世丝上下七丗一丕;
    
    // Properties
    internal static bool 丛丄丒丛专专丌丆丙 { get; }
    
    // Methods
    internal static bool 丂丁丌丘丗丅专专丛()
    {
        var val_9;
        var val_10;
        val_9 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
        if((val_9.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  47)) == false)
        {
                return (bool)0 & 1;
        }
        
        丒下丄与丏三世丘丝 val_3 = null;
        val_9 = val_3;
        val_3 = new 丒下丄与丏三世丘丝();
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  55)) == false)
        {
                return (bool)0 & 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(ExperienceController.丞丞丘业东丙丏七丌() < OfflineModController.丛丞丛七丛且丙丝丒)
        {
                return (bool)0 & 1;
        }
        
        bool val_9 = val_3.丝三世且七丆不丈下() ^ 1;
        return (bool)0 & 1;
    }
    private void Awake()
    {
        null = null;
        OfflineModController.丄丘七三上丕世丞业 = this;
    }
    private void Start()
    {
        this.丘上丐世丆丑且丞丒();
        this.丝丗丅一丛丗丂东丐(下下丏一丙不丘丌丞:  与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆());
    }
    private void Update()
    {
        var val_4;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offlineButtonHolder, 丏业丟一东丂东丘丛:  activeInHierarchy);
    }
    private void OnDestroy()
    {
        null = null;
        OfflineModController.丄丘七三上丕世丞业 = 0;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_5;
        object val_17;
        var val_18;
        System.Collections.Generic.List<UIButton> val_19;
        val_17 = this;
        System.Collections.Generic.List<UnityEngine.GameObject> val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        val_18 = null;
        val_18 = null;
        val_1.Add(item:  BottomButtonLobbyPanel.__il2cppRuntimeField_namespaze);
        val_1.Add(item:  gameObject);
        val_1.Add(item:  PGCompany.MainMenuMainPanel.__il2cppRuntimeField_element_class);
        val_1.Add(item:  BottomButtonLobbyPanel.__il2cppRuntimeField_this_arg);
        val_19 = this.与世丝上下七丗一丕;
        val_19.Clear();
        List.Enumerator<T> val_3 = val_1.GetEnumerator();
        label_23:
        if((790636656 & 1) == 0)
        {
            goto label_18;
        }
        
        T[] val_7 = val_5.丐丏七丌丕丗业且上().GetComponents<UIButton>();
        if((val_7 == null) || (val_7.Length == 0))
        {
            goto label_23;
        }
        
        this.与世丝上下七丗一丕.AddRange(collection:  val_7);
        goto label_23;
        label_18:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.openWindowButton != 0)
        {
                EventDelegate val_10 = null;
            val_19 = val_10;
            val_10 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void OfflineModController::丁一丌丝三专不丅不()));
            this.openWindowButton.onClick.Add(item:  val_10);
        }
        
        if(this.closeWindowButton != 0)
        {
                EventDelegate val_13 = null;
            val_19 = val_13;
            val_13 = new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void OfflineModController::专丏丗一下丑丝丆丙()));
            this.closeWindowButton.onClick.Add(item:  val_13);
        }
        
        if(this.goOnlineButton == 0)
        {
                return;
        }
        
        EventDelegate.丒万业丛丏东专世丟 val_15 = null;
        val_19 = val_15;
        val_15 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void OfflineModController::丝丅上丙与与丘丙丈());
        EventDelegate val_16 = null;
        val_17 = val_16;
        val_16 = new EventDelegate(丟丕丞丂一丙不丅丝:  val_15);
        this.goOnlineButton.onClick.Add(item:  val_16);
    }
    private void 丁一丌丝三专不丅不()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offlineWindowHolder, 丏业丟一东丂东丘丛:  true);
    }
    private void 专丏丗一下丑丝丆丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offlineWindowHolder, 丏业丟一东丂东丘丛:  false);
    }
    private void 丝丅上丙与与丘丙丈()
    {
        丕世不丐丒丕丅丗且.东丟东丝一丐丈丗业(丝丏丁丟丌丄丁与专:  true, 丘丘不丏且丂丐丘丝:  true);
    }
    internal static bool 丘三且七且丅上丑丆(string 东业世丕与丛丞丈丒)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((OfflineModController.丑丅丆不丒三业丙丘.Contains(item:  东业世丕与丛丞丈丒)) != false)
        {
                val_5 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() ^ 1;
            return (bool)val_5 & 1;
        }
        
        val_5 = 1;
        return (bool)val_5 & 1;
    }
    internal static bool 丂东丏丒丆下与丈业(Rilisoft.七丕丟丏三丈一丄世 与丝丛东上丆丁丘丕)
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((OfflineModController.丐丙下丈七不丛丘丝.Contains(item:  与丝丛东上丆丁丘丕)) != false)
        {
                val_5 = 1;
        }
        else
        {
                bool val_2 = 与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆();
            val_5 = val_2 ^ 1;
        }
        
        val_2 = val_5;
        return (bool)val_2;
    }
    private void 丝丗丅一丛丗丂东丐(bool 下下丏一丙不丘丌丞)
    {
        var val_8;
        UnityEngine.GameObject val_9;
        bool val_10;
        var val_11;
        val_8 = 下下丏一丙不丘丌丞;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offlineWindowHolder, 丏业丟一东丂东丘丛:  false);
        val_9 = this.offlineButtonHolder;
        val_10 = 0;
        if(val_8 != false)
        {
                val_11 = null;
            val_11 = null;
            val_10 = activeInHierarchy;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  val_10);
        if(this.与世丝上下七丗一丕 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.与世丝上下七丗一丕.GetEnumerator();
        val_9 = 1152921535463079680;
        label_13:
        if((791480712 & 1) == 0)
        {
            goto label_11;
        }
        
        string val_6 = (0.丐丏七丌丕丗业且上() & val_8 ^ 1) & 1;
        goto label_13;
        label_11:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public OfflineModController()
    {
        this.与世丝上下七丗一丕 = new System.Collections.Generic.List<UIButton>();
    }
    private static OfflineModController()
    {
        OfflineModController.丛丞丛七丛且丙丝丒 = 2;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        if(val_1 != null)
        {
                val_1.Add(item:  "BattleRoyale");
        }
        else
        {
                val_1.Add(item:  "BattleRoyale");
        }
        
        val_1.Add(item:  "League");
        if(val_1 != null)
        {
                val_1.Add(item:  "Craft");
        }
        else
        {
                val_1.Add(item:  "Craft");
        }
        
        val_1.Add(item:  "Modules");
        OfflineModController.丑丅丆不丒三业丙丘 = val_1;
        System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世> val_2 = new System.Collections.Generic.List<Rilisoft.七丕丟丏三丈一丄世>();
        if(val_2 != null)
        {
                val_2.Add(item:  11);
            val_2.Add(item:  12);
            val_2.Add(item:  13);
        }
        else
        {
                val_2.Add(item:  11);
            val_2.Add(item:  12);
            val_2.Add(item:  13);
        }
        
        val_2.Add(item:  25);
        OfflineModController.丐丙下丈七不丛丘丝 = val_2;
    }

}
