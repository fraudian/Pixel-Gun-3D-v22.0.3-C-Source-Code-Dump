using UnityEngine;
public class RespawnWindowController : MonoBehaviour
{
    // Fields
    private Rilisoft.PrefabHandler _respawnWindowPrefab;
    private Rilisoft.PrefabHandler _respawnWindowFDPrefab;
    private Rilisoft.专丕丝丏丒一一万丏<RespawnWindow> 一丅专丆且一与一且;
    
    // Properties
    public RespawnWindow 不丌不世且丄不三丝 { get; }
    public bool 丁丞三七丌且丐丁丝 { get; }
    
    // Methods
    public RespawnWindow get_window()
    {
        Rilisoft.专丕丝丏丒一一万丏<RespawnWindow> val_7 = this.一丅专丆且一与一且;
        if(val_7 != null)
        {
                return val_6.世三丞丅丑丌丈丈一();
        }
        
        if(GameConnect.丅丟下专不丁一丈七() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_7;
        }
        
        }
        
        if(this._respawnWindowFDPrefab != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        Rilisoft.专丕丝丏丒一一万丏<RespawnWindow> val_6 = null;
        val_7 = val_6;
        val_6 = new Rilisoft.专丕丝丏丒一一万丏<RespawnWindow>(丆万丕丏与丈与丒丗:  this._respawnWindowFDPrefab.ResourcePath, 丆丏七丟不丒与七专:  this.transform.gameObject);
        this.一丅专丆且一与一且 = val_7;
        if(val_7 != null)
        {
                return val_6.世三丞丅丑丌丈丈一();
        }
        
        return val_6.世三丞丅丑丌丈丈一();
        label_7:
        if(this._respawnWindowPrefab != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    public bool get_isShown()
    {
        if(this.window == 0)
        {
                return false;
        }
        
        RespawnWindow val_3 = this.window;
        if(val_3 != null)
        {
                return val_3.isShown;
        }
        
        return val_3.isShown;
    }
    public void HandleBackClick()
    {
        if(this.window == 0)
        {
                return;
        }
        
        if(this.window.isShown == false)
        {
                return;
        }
        
        if(this.window.isCanClose == false)
        {
                return;
        }
        
        this.window.CloseRespawnWindow();
    }
    public void Close()
    {
        if(this.window == 0)
        {
                return;
        }
        
        if(this.window.isShown == false)
        {
                return;
        }
        
        this.window.CloseRespawnWindow();
    }
    internal void 专三丟三且下丅丂丄(bool 丄丈且丂丕丐丅丐七 = False)
    {
        null = null;
        丄丈且丂丕丐丅丐七 = 丄丈且丂丕丐丅丐七;
        MutationController.丆丕丝丒不丙且丐丗.与丟丁七万万下丈与(丄丈且丂丕丐丅丐七:  丄丈且丂丕丐丅丐七);
    }
    internal System.Collections.IEnumerator 下与丞三丅丛丄七丕(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄, float 丆丐七丅丆丗丛上与, System.Threading.CancellationToken 不丒三业下丑不丞业, UnityEngine.Vector3 世业三丘丒丙丅丈丌, UnityEngine.Quaternion 三上七丛丅丒七丒丒)
    {
        RespawnWindowController.万丂丗丌丟丝东丅东 val_1 = new RespawnWindowController.万丂丗丌丟丝东丅东();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝丞丛七且一丅丐丄 = 丝丞丛七且一丅丐丄;
            .丝且与丝丒丟万丁专 = this;
            .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
        }
        else
        {
                mem[40] = this;
            mem[32] = 丝丞丛七且一丅丐丄;
            .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            mem[80] = 不丒三业下丑不丞业.m_source;
        }
        
        .世业三丘丒丙丅丈丌 = 世业三丘丒丙丅丈丌;
        mem[1152921536084583076] = 世业三丘丒丙丅丈丌.y;
        mem[1152921536084583080] = 世业三丘丒丙丅丈丌.z;
        .三上七丛丅丒七丒丒 = 三上七丛丅丒七丒丒;
        mem[1152921536084583088] = 三上七丛丅丒七丒丒.y;
        mem[1152921536084583092] = 三上七丛丅丒七丒丒.z;
        mem[1152921536084583096] = 三上七丛丅丒七丒丒.w;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丆丒丕不与丈丞丘下(ref bool 丄丕丝与丞下专丑丏)
    {
        if(丄丕丝与丞下专丑丏 == true)
        {
                return;
        }
        
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
        RespawnWindow val_1 = RespawnWindow.丑七不且上丗丁一世();
        GamepadCursorController.丆丕丝丒不丙且丐丗.下与丆丌世丛丗丝丝(丟丒丞丐丐丘丒丄东:  val_1.respawnButton.transform, 与业丞东丙丕且丏丈:  InGameGUI.丙丞专丌丁丞与不丐.丝丙与东丈不丙三丟());
        丄丕丝与丞下专丑丏 = true;
    }
    private void 丌一丏业丟不丒丟不(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        var val_13;
        var val_14;
        System.Func<Player_move_c, System.Int32> val_16;
        float val_18;
        if(丝丞丛七且一丅丐丄 == null)
        {
                return;
        }
        
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
                return;
        }
        
        if(丝丞丛七且一丅丐丄.丝万丘丂与丄不丑不 == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        System.Collections.Generic.List<Player_move_c> val_2 = 专丕与万丈丞丒与且();
        if(val_2.Count < 1)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = RespawnWindowController.<>c.<>9__12_0;
        if(val_16 == null)
        {
                System.Func<Player_move_c, System.Int32> val_5 = null;
            val_16 = val_5;
            val_5 = new System.Func<Player_move_c, System.Int32>(object:  RespawnWindowController.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 RespawnWindowController.<>c::丁丐东丁丌丙丙丗丌(Player_move_c 三丟东丕丄丄下下丑));
            RespawnWindowController.<>c.<>9__12_0 = val_16;
        }
        
        .丌专丂专丛丏一丏丁 = System.Linq.Enumerable.Max<Player_move_c>(source:  val_2, selector:  val_5);
        Player_move_c val_8 = System.Linq.Enumerable.First<Player_move_c>(source:  val_2, predicate:  new System.Func<Player_move_c, System.Boolean>(object:  new RespawnWindowController.丒丛丁与丅东丒不七(), method:  System.Boolean RespawnWindowController.丒丛丁与丅东丒不七::丕丌丅上东丞东丐业(Player_move_c 三丟东丕丄丄下下丑)));
        丝丞丛七且一丅丐丄.业七丑丁且丐丝上三 = val_8;
        丝丞丛七且一丅丐丄.丛三三与丁丘丄丑下 = val_8.mySkinName.不与丏上丐七丄专且;
        丝丞丛七且一丅丐丄.专下不丘丘丝丅七三 = val_8.丟三丏丅世一丟丟上.丐丆丒丅且丏世一与;
        丝丞丛七且一丅丐丄.丙业丛不丂丅丘与一 = val_8.丟三丏丅世一丟丟上.丏丅业丞丁丌丈与丆;
        丝丞丛七且一丅丐丄.与三丐丆万不丝万丒 = val_8.丄丞丘不下七一丘丘;
        val_18 = 0f;
        if(val_8.丘七业丒丐世丂丅丒() > 0f)
        {
                val_18 = val_8.丘七业丒丐世丂丅丒();
        }
        
        丝丞丛七且一丅丐丄.丌三一专与一丕丗丗 = UnityEngine.Mathf.CeilToInt(f:  val_18);
        丝丞丛七且一丅丐丄.丐专丕丕丒丏丁丁丑 = val_8.丅三业丆丄丝丝丕东;
        丝丞丛七且一丅丐丄.丅丞丕与丁丂三丌丙 = UnityEngine.Mathf.CeilToInt(f:  val_8.三丕丘下业丑丞下丘);
    }
    public RespawnWindowController()
    {
    
    }

}
