using UnityEngine;
internal sealed class PotionsController : MonoBehaviour
{
    // Fields
    internal const string 丁七丌丞丞万丈三丆 = "InvisibilityPotion";
    internal static int 上丐专丟丏丑专业丝;
    internal static PotionsController 丄丞丁丈与业上丞丟;
    internal static System.Collections.Generic.Dictionary<string, System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<string, object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<string, object>>>> 不业丌丘丒丁下七业;
    internal static System.Collections.Generic.Dictionary<string, float> 一一丄丌万丞丂丂上;
    private System.Collections.Generic.List<string> 不丆丌万上业万丆丕;
    private System.Collections.Generic.List<string> 三与丅丘上丘丄三丘;
    public System.Collections.Generic.Dictionary<string, float> activePotions;
    public System.Collections.Generic.List<string> activePotionsList;
    private static System.Action<string> 一丏丙丕丆丌东东丈;
    private static System.Action<string> 丁丆上丂一七丞丝上;
    
    // Properties
    internal static float 业丑丑上专丝上丌一 { get; }
    
    // Methods
    private static PotionsController()
    {
        var val_33;
        PotionsController.上丐专丟丏丑专业丝 = 1000000;
        PotionsController.丄丞丁丈与业上丞丟 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>>();
        PotionsController.不业丌丘丒丁下七业 = val_1;
        System.Collections.Generic.Dictionary<System.String, System.Single> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        PotionsController.一一丄丌万丞丂丂上 = val_2;
        MoonSharp.Interpreter.TablePair val_5 = new MoonSharp.Interpreter.TablePair(key:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::丅上丟丏三业上丘七(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)), val:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::丞丑一丘下不与丟丞(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)));
        val_1.Add(key:  "InvisibilityPotion", value:  new System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>() {Value = val_5.key});
        val_33 = null;
        val_33 = null;
        MoonSharp.Interpreter.TablePair val_8 = new MoonSharp.Interpreter.TablePair(key:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::且世丏丄万丒下丗不(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)), val:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::丞丏丐丄丏业丆丟且(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)));
        val_1.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗, value:  new System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>() {Value = val_8.key});
        MoonSharp.Interpreter.TablePair val_11 = new MoonSharp.Interpreter.TablePair(key:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::专丟东丛一丕且三丙(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)), val:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::世且丌丌专万丝丌丆(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)));
        val_1.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐, value:  new System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>() {Value = val_11.key});
        MoonSharp.Interpreter.TablePair val_14 = new MoonSharp.Interpreter.TablePair(key:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::丌丒丟专丒丂东三丈(Player_move_c 丛丆东与丑丞丅丝专, System.Collections.Generic.Dictionary<string, object> 不丁丌丐业丑丟且不)), val:  new System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  0, method:  static System.Void PotionsController::丟丙丄丅丁丟丘丄丑(Player_move_c 丛丆东与丑丞丅丝专, System.Collections.Generic.Dictionary<string, object> 不丁丌丐业丑丟且不)));
        val_1.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆, value:  new System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>>() {Value = val_14.key});
        val_2.Add(key:  "InvisibilityPotion0", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "0", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "0", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "0", value:  30f);
        val_2.Add(key:  "InvisibilityPotion1", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "1", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "1", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "1", value:  30f);
        val_2.Add(key:  "InvisibilityPotion2", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "2", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "2", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "2", value:  30f);
        val_2.Add(key:  "InvisibilityPotion3", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "3", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "3", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "3", value:  30f);
        val_2.Add(key:  "InvisibilityPotion4", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "4", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "4", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "4", value:  30f);
        val_2.Add(key:  "InvisibilityPotion5", value:  30f);
        val_2.Add(key:  下专世丏丈丞三丗不.东且丄一丕专丌丆丐 + "5", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丘丝丂丌万丅丝丟丗 + "5", value:  60f);
        val_2.Add(key:  下专世丏丈丞三丗不.丁不丟丒丟丁下丈丆 + "5", value:  30f);
    }
    internal static float 丕七丑丄丘丝丕上丐()
    {
        return 0.75f;
    }
    public bool PotionIsActive(string 丛丄万三丂东丙丑东)
    {
        if(丛丄万三丂东丙丑东 == null)
        {
                return false;
        }
        
        if(this.activePotions == null)
        {
                return false;
        }
        
        return this.activePotions.ContainsKey(key:  丛丄万三丂东丙丑东);
    }
    internal static void 丅上丒下丕东一七丄(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        if((UnityEngine.Object.op_Implicit(exists:  丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂)) == false)
        {
                return;
        }
        
        if(丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂 == 0)
        {
                return;
        }
        
        丘丒且与丁丑丐上与 = 丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂.GetComponent<FirstPersonControlSharp>();
        if((UnityEngine.Object.op_Implicit(exists:  丘丒且与丁丑丐上与)) == false)
        {
                return;
        }
        
        if(丘丒且与丁丑丐上与 == 0)
        {
                return;
        }
        
        float val_6 = 0.75f;
        val_6 = val_3.万世东丞丑丟丒世三 * val_6;
        val_3.万世东丞丑丟丒世三 = val_6;
    }
    internal static void 丏上丂七且且丏丆丗(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        if((UnityEngine.Object.op_Implicit(exists:  丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂)) == false)
        {
                return;
        }
        
        if(丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂 == 0)
        {
                return;
        }
        
        丘丒且与丁丑丐上与 = 丘丒且与丁丑丐上与.丒一丄丗丞丗丄丐丂.GetComponent<FirstPersonControlSharp>();
        if((UnityEngine.Object.op_Implicit(exists:  丘丒且与丁丑丐上与)) == false)
        {
                return;
        }
        
        if(丘丒且与丁丑丐上与 == 0)
        {
                return;
        }
        
        float val_6 = 0.75f;
        val_6 = val_3.万世东丞丑丟丒世三 / val_6;
        val_3.万世东丞丑丟丒世三 = val_6;
    }
    internal static void 且世丏丄万丒下丗不(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_5 = null;
            val_5 = null;
            val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
            val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        }
        else
        {
                val_6 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        SkinName val_3 = val_6.GetComponent<SkinName>();
        val_3.playerMoveC.丅且丆丂丝世丁七丟(丐上不业丐丕丅丆与:  true);
    }
    internal static void 丞丏丐丄丏业丆丟且(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        val_4 = null;
        val_4 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_5 = null;
            val_5 = null;
            val_6 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
            val_6 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        }
        else
        {
                val_6 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        }
        
        if(val_6 == 0)
        {
                return;
        }
        
        SkinName val_3 = val_6.GetComponent<SkinName>();
        val_3.playerMoveC.丅且丆丂丝世丁七丟(丐上不业丐丕丅丆与:  false);
    }
    internal static void 专丟东丛一丕且三丙(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    internal static void 万一丏世丗丘上万丙(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    internal static void 世且丌丌专万丝丌丆(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        var val_6;
        var val_7;
        Player_move_c val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                val_7 = null;
            val_7 = null;
            WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC
        }
        else
        {
                UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
            if(val_1 == 0)
        {
            goto label_28;
        }
        
            SkinName val_3 = val_1.GetComponent<SkinName>();
            val_8 = val_3.playerMoveC;
        }
        
        label_28:
        if(mem[val_3.playerMoveC] == 0)
        {
                return;
        }
        
        if((mem[val_3.playerMoveC] + 1264) == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
            丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  mem[val_3.playerMoveC] + 1264);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  mem[val_3.playerMoveC] + 1264);
    }
    internal static void 三丝且一下七丒三上(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    internal static void 丗上丘东七丝丑丂上(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    internal static void 丅上丟丏三业上丘七(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        丘丒且与丁丑丐上与.丏七七专业世上丞业(七下丛丌世上丞丂丗:  true);
    }
    internal static void 丞丑一丘下不与丟丞(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        丘丒且与丁丑丐上与.丏七七专业世上丞业(七下丛丌世上丞丂丗:  false);
    }
    internal static void 且丈丅东丈七丝上丈(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    internal static void 丏丟丂丁业丏与七丂(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
    
    }
    private static void 丌丒丟专丒丂东三丈(Player_move_c 丛丆东与丑丞丅丝专, System.Collections.Generic.Dictionary<string, object> 不丁丌丐业丑丟且不)
    {
        UnityEngine.Debug.Log(message:  "Mech ON");
        丛丆东与丑丞丅丝专.丛下丟不丅三丟丌上(丞丅上丏丂且下丅与:  "");
    }
    private static void 丟丙丄丅丁丟丘丄丑(Player_move_c 丛丆东与丑丞丅丝专, System.Collections.Generic.Dictionary<string, object> 不丁丌丐业丑丟且不)
    {
        UnityEngine.Debug.Log(message:  "Mech OFF");
        丛丆东与丑丞丅丝专.丘丂丘丞不丒丆丆世();
    }
    internal static void 丏丕丗丛丆且丞东丌(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  PotionsController.一丏丙丕丆丌东东丈, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PotionsController.一丏丙丕丆丌东东丈 != 1152921505247744032);
    
    }
    internal static void 丗七丘且三丒业丐且(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  PotionsController.一丏丙丕丆丌东东丈, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PotionsController.一丏丙丕丆丌东东丈 != 1152921505247744032);
    
    }
    internal static void 七与世丆且上丈丒三(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Combine(a:  PotionsController.丁丆上丂一七丞丝上, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PotionsController.丁丆上丂一七丞丝上 != 1152921505247744040);
    
    }
    internal static void 丛世丂丒一一上且丌(System.Action<string> 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        do
        {
            val_4 = System.Delegate.Remove(source:  PotionsController.丁丆上丂一七丞丝上, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
            val_5 = null;
            val_5 = null;
        }
        while(PotionsController.丁丆上丂一七丞丝上 != 1152921505247744040);
    
    }
    public float RemainDuratioForPotion(string 丄万丗专专丐丁丘丄)
    {
        if(丄万丗专专丐丁丘丄 == null)
        {
                return (float)0f;
        }
        
        if((this.activePotions.ContainsKey(key:  丄万丗专专丐丁丘丄)) == false)
        {
                return (float)0f;
        }
        
        0f = this.activePotions.Item[丄万丗专专丐丁丘丄] + (丘丐丘万丌丟丞下丝.下丑业万丈丟丌丂丑(丄万丗专专丐丁丘丄:  丄万丗专专丐丁丘丄));
        return (float)0f;
    }
    internal void 不东丂丈丝丆丌丄丛(Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三)
    {
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.activePotions.Keys.GetEnumerator();
        label_4:
        if(((-243483272) & 1) == 0)
        {
            goto label_3;
        }
        
        this.丙丞丁三专丏不专一(丄万丗专专丐丁丘丄:  0.丐丏七丌丕丗业且上(), 丘丒且与丁丑丐上与:  丘丒且与丁丑丐上与, 丗丅七业丝不三丄三:  丗丅七业丝不三丄三 = 丗丅七业丝不三丄三, 丕丕且一丕业丕丂七:  false);
        goto label_4;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丙丞丁三专丏不专一(string 丄万丗专专丐丁丘丄, Player_move_c 丘丒且与丁丑丐上与, System.Collections.Generic.Dictionary<string, object> 丗丅七业丝不三丄三, bool 丕丕且一丕业丕丂七 = False)
    {
        float val_18;
        float val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Action<System.String> val_24;
        var val_25;
        var val_26;
        var val_27;
        if((this.activePotions.ContainsKey(key:  丄万丗专专丐丁丘丄)) == false)
        {
            goto label_2;
        }
        
        if(丕丕且一丕业丕丂七 == false)
        {
            goto label_52;
        }
        
        bool val_2 = this.activePotions.Remove(key:  丄万丗专专丐丁丘丄);
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_7;
        }
        
        val_18 = 180f;
        if(this.activePotions != null)
        {
            goto label_41;
        }
        
        goto label_9;
        label_2:
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_12;
        }
        
        val_19 = 180f;
        if(this.activePotions != null)
        {
            goto label_20;
        }
        
        goto label_14;
        label_12:
        val_20 = null;
        val_20 = null;
        val_19 = PotionsController.一一丄丌万丞丂丂上.Item[丄万丗专专丐丁丘丄 + 下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  丄万丗专专丐丁丘丄).ToString()(下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  丄万丗专专丐丁丘丄).ToString())];
        if(this.activePotions != null)
        {
            goto label_20;
        }
        
        label_14:
        label_20:
        this.activePotions.Add(key:  丄万丗专专丐丁丘丄, value:  val_19);
        this.activePotionsList.Add(item:  丄万丗专专丐丁丘丄);
        label_52:
        val_21 = null;
        val_21 = null;
        if((PotionsController.不业丌丘丒丁下七业.ContainsKey(key:  丄万丗专专丐丁丘丄)) != false)
        {
                val_22 = null;
            val_22 = null;
            System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_10 = PotionsController.不业丌丘丒丁下七业.Item[丄万丗专专丐丁丘丄];
            val_10.Value.丐丏七丌丕丗业且上().Invoke(arg1:  丘丒且与丁丑丐上与, arg2:  丗丅七业丝不三丄三);
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = PotionsController.一丏丙丕丆丌东东丈;
        if(val_24 == null)
        {
                return;
        }
        
        val_24 = PotionsController.一丏丙丕丆丌东东丈;
        if(val_24 == null)
        {
                val_24 = 0;
        }
        
        val_24.Invoke(obj:  丄万丗专专丐丁丘丄);
        return;
        label_7:
        val_25 = null;
        val_25 = null;
        val_18 = PotionsController.一一丄丌万丞丂丂上.Item[丄万丗专专丐丁丘丄 + 下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  丄万丗专专丐丁丘丄).ToString()(下专世丏丈丞三丗不.上丘丅丁丐丈上丞丛(丞丅上丏丂且下丅与:  丄万丗专专丐丁丘丄).ToString())];
        if(this.activePotions != null)
        {
            goto label_41;
        }
        
        label_9:
        label_41:
        this.activePotions.Add(key:  丄万丗专专丐丁丘丄, value:  val_18);
        bool val_16 = this.activePotionsList.Remove(item:  丄万丗专专丐丁丘丄);
        this.activePotionsList.Add(item:  丄万丗专专丐丁丘丄);
        val_26 = null;
        val_26 = null;
        if(TableGearController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_52;
        }
        
        val_27 = null;
        val_27 = null;
        TableGearController.丄丞丁丈与业上丞丟.ReactivatePotion(丕且丙丙且下丛丟丒:  丄万丗专专丐丁丘丄);
        goto label_52;
    }
    internal void 且丑七专与且丈业丑(float 七且丆丞丌丘下世丑, Player_move_c 七丏丄丅丌业与且丙)
    {
        var val_13;
        float val_15;
        var val_16;
        if(this.三与丅丘上丘丄三丘 != null)
        {
                this.三与丅丘上丘丄三丘.Clear();
        }
        else
        {
                this.三与丅丘上丘丄三丘 = new System.Collections.Generic.List<System.String>();
        }
        
        if(this.不丆丌万上业万丆丕 != null)
        {
                this.不丆丌万上业万丆丕.Clear();
        }
        else
        {
                this.不丆丌万上业万丆丕 = new System.Collections.Generic.List<System.String>();
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = this.activePotions.GetEnumerator();
        if(((-243040200) & 1) != 0)
        {
                val_13 = 1152921538723486192;
            do
        {
            ConfiguredValueTaskAwaiter val_4 = 0.GetAwaiter();
            this.不丆丌万上业万丆丕.Add(item:  val_4._value._obj.丐丏七丌丕丗业且上());
        }
        while(((-243040200) & 1) != 0);
        
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        int val_6 = this.不丆丌万上业万丆丕.Count;
        if(val_6 >= 1)
        {
                val_13 = 1152921516107659296;
            var val_13 = 0;
            do
        {
            string val_7 = this.不丆丌万上业万丆丕.Item[0];
            if(this.activePotions != null)
        {
                val_15 = this.activePotions.Item[val_7];
        }
        else
        {
                float val_9 = 0.Item[val_7];
            val_15 = val_9;
        }
        
            val_9 = val_15 - 七且丆丞丌丘下世丑;
            this.activePotions.set_Item(key:  val_7, value:  val_9);
            if((this.RemainDuratioForPotion(丄万丗专专丐丁丘丄:  val_7)) <= 0f)
        {
                this.三与丅丘上丘丄三丘.Add(item:  val_7);
        }
        
            val_13 = val_13 + 1;
        }
        while(val_6 != val_13);
        
        }
        
        val_16 = 0;
        goto label_18;
        label_20:
        this.丁下丙世丛不上丞丝(丕且丙丙且下丛丟丒:  val_7.Item[0], 七丏丄丅丌业与且丙:  七丏丄丅丌业与且丙, 一世且专业丒丆业丟:  true);
        val_16 = 1;
        label_18:
        if(val_16 < this.三与丅丘上丘丄三丘.Count)
        {
            goto label_20;
        }
        
        this.三与丅丘上丘丄三丘.Clear();
        this.不丆丌万上业万丆丕.Clear();
    }
    internal void 丁下丙世丛不上丞丝(string 丕且丙丙且下丛丟丒, Player_move_c 七丏丄丅丌业与且丙, bool 一世且专业丒丆业丟 = True)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_6;
        var val_7;
        System.Action<System.String> val_8;
        System.Collections.Generic.Dictionary<System.String, System.Single> val_9;
        var val_10;
        val_6 = 一世且专业丒丆业丟;
        val_7 = null;
        val_7 = null;
        val_8 = PotionsController.丁丆上丂一七丞丝上;
        if(val_8 != null)
        {
                val_8 = PotionsController.丁丆上丂一七丞丝上;
            if(val_8 == null)
        {
                val_8 = 0;
        }
        
            val_8.Invoke(obj:  丕且丙丙且下丛丟丒);
        }
        
        val_9 = this.activePotions;
        if((val_9.ContainsKey(key:  丕且丙丙且下丛丟丒)) == false)
        {
                return;
        }
        
        val_9 = this.activePotions;
        bool val_2 = val_9.Remove(key:  丕且丙丙且下丛丟丒);
        bool val_3 = this.activePotionsList.Remove(item:  丕且丙丙且下丛丟丒);
        if(val_6 == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        System.Collections.Generic.KeyValuePair<System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>, System.Action<Player_move_c, System.Collections.Generic.Dictionary<System.String, System.Object>>> val_4 = PotionsController.不业丌丘丒丁下七业.Item[丕且丙丙且下丛丟丒];
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = null;
        val_6 = val_5;
        val_5 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_4.Value.Invoke(arg1:  七丏丄丅丌业与且丙, arg2:  val_5);
    }
    private void 东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)
    {
        this.activePotions.Clear();
        this.activePotionsList.Clear();
    }
    private void Start()
    {
        null = null;
        PotionsController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    private void OnEnable()
    {
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PotionsController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    private void OnDisable()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void PotionsController::东七丏三丗丅下丛世(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 丟丞与丕丐丝丏丛不)));
    }
    public PotionsController()
    {
        this.activePotions = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        this.activePotionsList = new System.Collections.Generic.List<System.String>();
    }

}
