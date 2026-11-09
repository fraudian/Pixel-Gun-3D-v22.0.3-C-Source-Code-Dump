using UnityEngine;
internal sealed class CoinBonus : MonoBehaviour
{
    // Fields
    private static System.Action 专东一丆丌与丂丏世;
    public UnityEngine.GameObject player;
    public UnityEngine.AudioClip CoinItemUpAudioClip;
    private Player_move_c 丂丝世丗丏丐丂丕万;
    private Rilisoft.丝一丌上丟且三一丏 <三世丒下七丆丙丞专>k__BackingField;
    
    // Properties
    private Rilisoft.丝一丌上丟且三一丏 不丕丟丐丒且与丛下 { get; set; }
    
    // Methods
    internal static void 丐丄丞东万七上下丅(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  CoinBonus.专东一丆丌与丂丏世, b:  丙业与丙丗丝不丈东);
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
    internal static void 丑丙丞丂丁一丁丆下(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  CoinBonus.专东一丆丌与丂丏世, value:  丙业与丙丗丝不丈东);
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
    private Rilisoft.丝一丌上丟且三一丏 下丈丘丐下与丆东且()
    {
        return (Rilisoft.丝一丌上丟且三一丏)this.<三世丒下七丆丙丞专>k__BackingField;
    }
    public void set_BonusType(Rilisoft.丝一丌上丟且三一丏 丙业与丙丗丝不丈东)
    {
        this.<三世丒下七丆丙丞专>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static System.Collections.Generic.List<string> 丟丐业东丑丘丐丘东(Rilisoft.丝一丌上丟且三一丏 丆丙丅丝七丒丐丙万)
    {
        Progress.丅丕东丑下世丏丑与 val_1 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏();
        if(val_1 != null)
        {
                return val_1.丕丌上丘下丑丄世与(丆丙丅丝七丒丐丙万:  丆丙丅丝七丒丐丙万);
        }
        
        return val_1.丕丌上丘下丑丄世与(丆丙丅丝七丒丐丙万:  丆丙丅丝七丒丐丙万);
    }
    internal static string[] 丆丈专万丁丝丈与丅()
    {
        System.Collections.Generic.List<System.String> val_2 = Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丕丌上丘下丑丄世与(丆丙丅丝七丒丐丙万:  1);
        if(val_2 != null)
        {
                return val_2.ToArray();
        }
        
        return val_2.ToArray();
    }
    internal static System.Collections.Generic.IEnumerable<string> 世丗不丒丞不丕一丐()
    {
        if((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().丕丌上丘下丑丄世与(丆丙丅丝七丒丐丙万:  2)) != null)
        {
                return (System.Collections.Generic.IEnumerable<System.String>)new string[0];
        }
        
        return (System.Collections.Generic.IEnumerable<System.String>)new string[0];
    }
    internal static bool 丌丒丆万丏丗丛丛丏(System.Collections.Generic.List<string> 世与丁丝专丂丕丄丏, Rilisoft.丝一丌上丟且三一丏 丆丙丅丝七丒丐丙万)
    {
        Rilisoft.丝一丌上丟且三一丏 val_4;
        var val_5;
        val_4 = 丆丙丅丝七丒丐丙万;
        List.Enumerator<T> val_1 = 世与丁丝专丂丕丄丏.GetEnumerator();
        label_8:
        if(((-328016296) & 1) == 0)
        {
            goto label_2;
        }
        
        val_5 = null;
        val_5 = null;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丐万万丗丂丈丄东丏(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  0.丐丏七丌丕丗业且上(), 下丂丌上丏下万丗丁:  val_4);
        goto label_8;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return true;
    }
    public void SetPlayer()
    {
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                null = null;
        }
        
        this.丂丝世丗丏丐丂丕万 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        this.player = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
    }
    private void Update()
    {
        var val_54;
        var val_55;
        var val_56;
        int val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        int val_62;
        int val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        int val_68;
        var val_69;
        var val_70;
        string val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_78;
        var val_79;
        var val_80;
        var val_81;
        string val_82;
        var val_83;
        if(this.丂丝世丗丏丐丂丕万 == 0)
        {
                return;
        }
        
        if(this.player == 0)
        {
                return;
        }
        
        if((this.<三世丒下七丆丙丞专>k__BackingField) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_6 = this.player.transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) > (((this.<三世丒下七丆丙丞专>k__BackingField) == 3) ? 64f : 2.25f))
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_15;
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  11);
        if((this.<三世丒下七丆丙丞专>k__BackingField) == 1)
        {
            goto label_19;
        }
        
        if((this.<三世丒下七丆丙丞专>k__BackingField) == 2)
        {
            goto label_20;
        }
        
        if((this.<三世丒下七丆丙丞专>k__BackingField) != 3)
        {
            goto label_126;
        }
        
        val_54 = null;
        val_54 = null;
        val_55 = null;
        if((BalanceController.丟一丁丏万丆丝丞丐.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_27;
        }
        
        val_56 = null;
        val_57 = BalanceController.丟一丁丏万丆丝丞丐.Item[ExpController.万上一丝丆且七丅丅()];
        goto label_33;
        label_20:
        val_58 = null;
        val_58 = null;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丗世丈丂丒丞专上丟:  1, 世丁丙世丄一万丆三:  39, 丛丞万三下丘七丌丅:  true);
        this.丛一丒丗一丗东世丞();
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  1, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丅丅丞丙丁丕丌世东:  0);
        goto label_126;
        label_19:
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_44;
        }
        
        val_59 = null;
        val_59 = null;
        val_60 = null;
        if((BalanceController.丈丞东丞丞丝且上与.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) == false)
        {
            goto label_50;
        }
        
        val_61 = null;
        val_62 = BalanceController.丈丞东丞丞丝且上与.Item[ExpController.万上一丝丆且七丅丅()];
        goto label_56;
        label_44:
        val_63 = 0;
        val_62 = 1;
        goto label_108;
        label_27:
        val_64 = null;
        val_57 = BalanceController.丟一丁丏万丆丝丞丐.Item[BalanceController.丟一丁丏万丆丝丞丐.Count - 1];
        label_33:
        val_65 = null;
        val_65 = null;
        val_66 = null;
        if((BalanceController.且丄丈丄不世丞丗东.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) != false)
        {
                val_67 = null;
            val_68 = BalanceController.且丄丈丄不世丞丗东.Item[ExpController.万上一丝丆且七丅丅()];
        }
        else
        {
                val_69 = null;
            val_68 = BalanceController.且丄丈丄不世丞丗东.Item[BalanceController.且丄丈丄不世丞丗东.Count - 1];
        }
        
        val_70 = null;
        val_70 = null;
        val_71 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_71, 丗世丈丂丒丞专上丟:  val_57, 世丁丙世丄一万丆三:  39, 丛丞万三下丘七丌丅:  true);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  val_57, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丅丅丞丙丁丕丌世东:  0);
        if((val_68 < 1) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
        {
            goto label_126;
        }
        
        val_72 = null;
        val_72 = null;
        ExperienceController.sharedController.丗丒丂丕丟东丟丙不(业不七丗东丛下一东:  val_68, 世丁丙世丄一万丆三:  8, 与丌丛丈丕丁丅丄丗:  0);
        goto label_126;
        label_50:
        val_73 = null;
        val_62 = BalanceController.丈丞东丞丞丝且上与.Item[BalanceController.丈丞东丞丞丝且上与.Count - 1];
        label_56:
        val_74 = null;
        val_74 = null;
        val_75 = null;
        if((BalanceController.丆东丆一世丑丛丈丗.ContainsKey(key:  ExpController.万上一丝丆且七丅丅())) != false)
        {
                val_76 = null;
            val_63 = BalanceController.丆东丆一世丑丛丈丗.Item[ExpController.万上一丝丆且七丅丅()];
        }
        else
        {
                val_77 = null;
            val_63 = BalanceController.丆东丆一世丑丛丈丗.Item[BalanceController.丆东丆一世丑丛丈丗.Count - 1];
        }
        
        label_108:
        int val_46 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丗丞丝丅丈丑丗丂丌();
        this.丛一丒丗一丗东世丞();
        val_78 = null;
        val_78 = null;
        val_71 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_71, 丗世丈丂丒丞专上丟:  val_62, 世丁丙世丄一万丆三:  39, 丛丞万三下丘七丌丅:  true);
        Rilisoft.丝丄三业丙专丛与不.一丞丕丛三一丁丒丒(丛丁三世世丆七不业:  val_62, 丅不一丞丘丕丄丈丏:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄, 丅丅丞丙丁丕丌世东:  0);
        if(val_63 >= 1)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
        {
                val_79 = null;
            val_79 = null;
            ExperienceController.sharedController.丗丒丂丕丟东丟丙不(业不七丗东丛下一东:  val_63, 世丁丙世丄一万丆三:  7, 与丌丛丈丕丁丅丄丗:  0);
        }
        
        }
        
        label_126:
        if(UnityEngine.Application.platform != 8)
        {
                UnityEngine.PlayerPrefs.Save();
        }
        
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        label_15:
        val_80 = null;
        if((this.<三世丒下七丆丙丞专>k__BackingField) == 2)
        {
                val_81 = null;
            val_82 = 1152921505171281160;
        }
        else
        {
                val_83 = null;
            val_82 = 1152921505171281152;
        }
        
        CoinsMessage.丄丝世丒一下丙丗不(丏丂不专上丘丂不丅:  val_82, 丌丒丝东丌下丕丁丅:  1);
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  104);
            if(CoinBonus.专东一丆丌与丂丏世 != null)
        {
                CoinBonus.专东一丆丌与丂丏世.Invoke();
        }
        
        }
        
        label_191:
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if(0 != 1)
        {
            goto label_190;
        }
        
        goto label_191;
        label_190:
    }
    private void 丛一丒丗一丗东世丞()
    {
        if(this.丂丝世丗丏丐丂丕万.丈丕丈丑专丘丐丛丙 == true)
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) == false)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_5 = val_4.m_Handle.name;
        if((CoinBonus.丟丐业东丑丘丐丘东(丆丙丅丝七丒丐丙万:  this.<三世丒下七丆丙丞专>k__BackingField).Contains(item:  val_5)) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
        val_7.Add(item:  val_5);
        bool val_8 = CoinBonus.丌丒丆万丏丗丛丛丏(世与丁丝专丂丕丄丏:  val_7, 丆丙丅丝七丒丐丙万:  this.<三世丒下七丆丙丞专>k__BackingField);
    }
    public CoinBonus()
    {
    
    }

}
