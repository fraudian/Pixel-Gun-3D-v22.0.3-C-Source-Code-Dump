using UnityEngine;
public class CraftNewItemWindowController : BaseWindowController
{
    // Fields
    private UnityEngine.ParticleSystem[] particles;
    private UIBasicSprite icon;
    public UILabel[] itemName;
    
    // Methods
    internal static CraftNewItemWindowController 下与丞三丅丛丄七丕(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘, UnityEngine.Transform 丈东丘丏与丌东东下, string 且丅丟丛丛万丝下上, int 丒丛丞丙丙丄丛丗一 = 100500)
    {
        CraftNewItemWindowController val_2 = UnityEngine.Object.Instantiate<CraftNewItemWindowController>(original:  UnityEngine.Resources.Load<CraftNewItemWindowController>(path:  "NguiWindows/CraftFinishedWindow"), parent:  丈东丘丏与丌东东下);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_2.transform);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  且丅丟丛丛万丝下上));
        if(val_2 != null)
        {
                丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  val_2.gameObject, 丙业与丙丗丝不丈东:  丒丛丞丙丙丄丛丗一);
        }
        else
        {
                丞东丑专丛丆丄丝世.业丆丌且上东丂东丗(万且万且丑丗且丌丆:  val_2.gameObject, 丙业与丙丗丝不丈东:  丒丛丞丙丙丄丛丗一);
        }
        
        val_2.丈且东丑丂且万丒丅(丞丘丞丏业且丛丏丘:  丞丘丞丏业且丛丏丘);
        return val_2;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 丞丘丞丏业且丛丏丘)
    {
        CraftNewItemWindowController.世丞丒丅一专丌丐丏 val_1 = new CraftNewItemWindowController.世丞丒丅一专丌丐丏();
        if(val_1 == null)
        {
            goto label_1;
        }
        
        .丞丘丞丏业且丛丏丘 = 丞丘丞丏业且丛丏丘;
        if(丞丘丞丏业且丛丏丘 != null)
        {
            goto label_16;
        }
        
        label_17:
        label_16:
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .与万丆丛丒万丝丙丑 = 丞丘丞丏业且丛丏丘;
        if(this.icon != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        .丐丅与世七不丌丙丆 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Android_Alpha/{0}_Alpha", arg0:  .与万丆丛丒万丝丙丑.name));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.itemName, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void CraftNewItemWindowController.世丞丒丅一专丌丐丏::丆一且世上丗上一丗(UILabel 丐三丞七丝丅不万丛)));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.ParticleSystem>(丌丛丏业世丄丞三丌:  this.particles, 七丐丅专且专七三丆:  new System.Action<UnityEngine.ParticleSystem>(object:  val_1, method:  System.Void CraftNewItemWindowController.世丞丒丅一专丌丐丏::一丄业丐丄丒下丏丞(UnityEngine.ParticleSystem 七丏丄丅丌业与且丙)));
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioClip val_8 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/craft_weapon_end");
        UnityEngine.AudioSource val_9 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_8);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  val_8.专上七丂丂丄万不丛(丕丕世且下一与丝与:  val_8.length));
        return;
        label_1:
        mem[16] = 丞丘丞丏业且丛丏丘;
        if(mem[16] != 0)
        {
            goto label_16;
        }
        
        goto label_17;
        label_3:
        mem[24] = 丞丘丞丏业且丛丏丘;
        if(this.icon != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    public void Setup(string 丞一丁业丄一一业且, CategoryNames 七丆丒与丗丌丄且丂)
    {
        CategoryNames val_14;
        string val_15;
        val_14 = 七丆丒与丗丌丄且丂;
        val_15 = 丞一丁业丄一一业且;
        CraftNewItemWindowController.丞丂万丅不丒丘丟丗 val_1 = new CraftNewItemWindowController.丞丂万丅不丒丘丟丗();
        if(val_1 != null)
        {
                .丞一丁业丄一一业且 = val_15;
            .七丆丒与丗丌丄且丂 = val_14;
        }
        else
        {
                mem[16] = val_15;
            mem[24] = val_14;
            val_15 = mem[16];
            val_14 = mem[24];
        }
        
        UnityEngine.Texture val_2 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_15, 七丆丒与丗丌丄且丂:  val_14, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        if(val_1 == null)
        {
            goto label_5;
        }
        
        .与万丆丛丒万丝丙丑 = val_2;
        if(this.icon != null)
        {
            goto label_18;
        }
        
        label_19:
        label_18:
        .丐丅与世七不丌丙丆 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/Android_Alpha/{0}_Alpha", arg0:  .与万丆丛丒万丝丙丑.name));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UILabel>(丌丛丏业世丄丞三丌:  this.itemName, 七丐丅专且专七三丆:  new System.Action<UILabel>(object:  val_1, method:  System.Void CraftNewItemWindowController.丞丂万丅不丒丘丟丗::丆一且世上丗上一丗(UILabel 丐三丞七丝丅不万丛)));
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.ParticleSystem>(丌丛丏业世丄丞三丌:  this.particles, 七丐丅专且专七三丆:  new System.Action<UnityEngine.ParticleSystem>(object:  val_1, method:  System.Void CraftNewItemWindowController.丞丂万丅不丒丘丟丗::一丄业丐丄丒下丏丞(UnityEngine.ParticleSystem 七丏丄丅丌业与且丙)));
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioClip val_9 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd/craft_weapon_end");
        UnityEngine.AudioSource val_10 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_9);
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  val_9.专上七丂丂丄万不丛(丕丕世且下一与丝与:  val_9.length));
        return;
        label_5:
        mem[32] = val_2;
        if(this.icon != null)
        {
            goto label_18;
        }
        
        goto label_19;
    }
    private System.Collections.IEnumerator 专上七丂丂丄万不丛(float 丕丕世且下一与丝与)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)new CraftNewItemWindowController.下丟丌与下三丂万世();
    }
    protected override void Awake()
    {
        this.Awake();
        this.icon = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icon);
    }
    public CraftNewItemWindowController()
    {
    
    }

}
