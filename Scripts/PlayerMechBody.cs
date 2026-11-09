using UnityEngine;
public class PlayerMechBody : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip activationSound;
    public UnityEngine.AudioClip stepSound;
    public UnityEngine.AudioClip shootSound;
    public UnityEngine.Transform tpsCamPivot;
    public UnityEngine.Transform tpsCamVisualPivot;
    public UnityEngine.Vector3 cameraPosition;
    public UnityEngine.Vector3 gunCameraPosition;
    public float gunCameraFieldOfView;
    internal float bodyColliderHeight;
    internal UnityEngine.Vector3 bodyColliderCenter;
    internal float bodyColliderRadius;
    internal float characterControllerRadius;
    public UnityEngine.Transform headColliderPivot;
    public UnityEngine.AudioSource explosionSound;
    public UnityEngine.GameObject activationEffect;
    public UnityEngine.GameObject explosionEffect;
    internal float nickLabelYPoision;
    public UnityEngine.GameObject jetpackObject;
    public UnityEngine.GameObject body;
    public UnityEngine.GameObject gun;
    public UnityEngine.GameObject point;
    public UnityEngine.Renderer bodyRenderer;
    public UnityEngine.Renderer handsRenderer;
    public UnityEngine.Renderer gunRenderer;
    public UnityEngine.Animation bodyAnimation;
    public UnityEngine.Animation gunAnimation;
    public WeaponSounds weapon;
    internal 三丈丟与丏丘丈丐万 丕丟上丆丛丙丈世业;
    public string killChatIcon;
    public 丅世一丈七丆业丝丘 scoreEventOnKill;
    internal float 七一一丘下丈专与且;
    internal float 丌丙丛丄丒丘且丄世;
    internal float 丕丈业丐与丆世万丞;
    public string[] healthSpriteName;
    internal bool 丕丙一丏专东丛不七;
    private float 丏丈丆且上不丕丐丈;
    private float 业丞丌丅世上丝丁丆;
    private UnityEngine.Texture 丌下丑丐丙丑丙丏丛;
    private UnityEngine.Texture 东丛丌上丆且丙不丂;
    internal UnityEngine.Material 万下万丐上世丌丂三;
    internal UnityEngine.Material 东下丈专与丂且丗丑;
    internal UnityEngine.Material 一一丅丒与丄丂丏丒;
    internal UnityEngine.Shader 万丅七丄一业丄丅丈;
    private RilisoftBot.BotHpIndicator _mechHpIndicator;
    public GadgetArmsRotator armsRotator;
    internal float jumpModifier;
    internal float slowdownWhenShootModifier;
    internal float slowdownTimeWhenShoot;
    private bool 一上丕丐丈丆东丄与;
    private Player_move_c 丒一丄丗丞丗丄丐丂;
    
    // Properties
    internal Player_move_c 专丞上七七且丝七丗 { get; set; }
    
    // Methods
    internal Player_move_c 且上世且一丈丞专上()
    {
        return (Player_move_c)this.丒一丄丗丞丗丄丐丂;
    }
    internal void 丐丝丝上丐丑丝与上(Player_move_c 丙业与丙丗丝不丈东)
    {
        this.丒一丄丗丞丗丄丐丂 = 丙业与丙丗丝不丈东;
        if(this.armsRotator == 0)
        {
                return;
        }
        
        this.armsRotator.丒专丈丛下丒一丒丛 = this.丒一丄丗丞丗丄丐丂.mySkinName.firstPersonControl;
        this = this.丒一丄丗丞丗丄丐丂.丝丙与东丈不丙三丟().gameObject.transform;
        this.armsRotator.fpsCamTransform = this;
    }
    internal void 且丁不丏丅丟丝丘丟()
    {
        this.activationEffect.SetActive(value:  true);
        DisableObjectFromTimer val_1 = this.activationEffect.GetComponent<DisableObjectFromTimer>();
        val_1.timer = this.丕丈业丐与丆世万丞;
    }
    internal void 丞万丘丟丕丕与与丑()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + this.七一一丘下丈专与且;
        this.丏丈丆且上不丕丐丈 = val_1;
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + this.丌丙丛丄丒丘且丄世;
        this.业丞丌丅世上丝丁丆 = val_2;
        this.explosionEffect.SetActive(value:  true);
    }
    private void Awake()
    {
        this.一上丕丐丈丆东丄与 = false;
        this.丌下丑丐丙丑丙丏丛 = this.bodyRenderer.sharedMaterial.mainTexture;
        this.东丛丌上丆且丙不丂 = this.handsRenderer.sharedMaterial.mainTexture;
        this.万下万丐上世丌丂三 = this.bodyRenderer.material;
        this.东下丈专与丂且丗丑 = this.handsRenderer.material;
        this.一一丅丒与丄丂丏丒 = this.gunRenderer.material;
        this.bodyRenderer.sharedMaterial = this.万下万丐上世丌丂三;
        this.handsRenderer.sharedMaterial = this.东下丈专与丂且丗丑;
        this.gunRenderer.sharedMaterial = this.一一丅丒与丄丂丏丒;
        this.万丅七丄一业丄丅丈 = this.万下万丐上世丌丂三.shader;
    }
    internal void 世下三上丟七丙丛丛(bool 丁丂丝不丟丛丟一丂, bool 万东丏丌不七东丘万 = False)
    {
        UnityEngine.Texture val_6;
        UnityEngine.Texture val_7;
        if(丁丂丝不丟丛丟一丂 == false)
        {
            goto label_1;
        }
        
        if(万东丏丌不七东丘万 == false)
        {
            goto label_2;
        }
        
        UnityEngine.Texture2D val_1 = SkinsController.丈三且与上丄丗丙专();
        goto label_5;
        label_1:
        this.万下万丐上世丌丂三.mainTexture = this.丌下丑丐丙丑丙丏丛;
        val_6 = this.东丛丌上丆且丙不丂;
        val_7 = val_6;
        goto label_8;
        label_2:
        label_5:
        this.万下万丐上世丌丂三.mainTexture = SkinsController.丝丕且丐上丁丛三丝();
        val_6 = this.东下丈专与丂且丗丑;
        if(万东丏丌不七东丘万 != false)
        {
                UnityEngine.Texture2D val_3 = SkinsController.丈三且与上丄丗丙专();
        }
        
        val_7 = SkinsController.丝丕且丐上丁丛三丝();
        label_8:
        val_6.mainTexture = val_7;
    }
    private void Update()
    {
        if(this.丏丈丆且上不丕丐丈 != (-1f))
        {
                float val_1 = UnityEngine.Time.time;
            if(this.丏丈丆且上不丕丐丈 < 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.point, 丏业丟一东丂东丘丛:  false);
            this.丏丈丆且上不丕丐丈 = -1f;
        }
        
        }
        
        if(this.业丞丌丅世上丝丁丆 == (-1f))
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        if(this.业丞丌丅世上丝丁丆 >= 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.explosionEffect, 丏业丟一东丂东丘丛:  false);
        this.业丞丌丅世上丝丁丆 = -1f;
    }
    private void 下丘丆专三丁丆东专(UnityEngine.Renderer 世万一丘丘世丟丟丛, bool 与丒丕丁下世东丅丌)
    {
        UnityEngine.Renderer val_4 = 世万一丘丘世丟丟丛;
        if(val_4 != null)
        {
                val_4 = 0;
        }
        
        if( == 0)
        {
                return;
        }
        
        allowOcclusionWhenDynamic = 与丒丕丁下世东丅丌;
    }
    internal void 东丌东三东丑丁丈万()
    {
        this.万下万丐上世丌丂三.shader = this.万丅七丄一业丄丅丈;
        this.东下丈专与丂且丗丑.shader = this.万丅七丄一业丄丅丈;
        this.一一丅丒与丄丂丏丒.shader = this.万丅七丄一业丄丅丈;
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.bodyRenderer, 与丒丕丁下世东丅丌:  true);
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.handsRenderer, 与丒丕丁下世东丅丌:  true);
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.gunRenderer, 与丒丕丁下世东丅丌:  true);
    }
    internal void 东世丌丄世业丞丛丐(UnityEngine.Shader 丕丄与专丛丝丄丐下, UnityEngine.Color 三丗丄丄丝丏丒丌一)
    {
        this.万下万丐上世丌丂三.shader = 丕丄与专丛丝丄丐下;
        this.东下丈专与丂且丗丑.shader = 丕丄与专丛丝丄丐下;
        this.一一丅丒与丄丂丏丒.shader = 丕丄与专丛丝丄丐下;
        this.万下万丐上世丌丂三.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = 三丗丄丄丝丏丒丌一.r, g = 三丗丄丄丝丏丒丌一.g, b = 三丗丄丄丝丏丒丌一.b, a = 三丗丄丄丝丏丒丌一.a});
        this.东下丈专与丂且丗丑.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = 三丗丄丄丝丏丒丌一.r, g = 三丗丄丄丝丏丒丌一.g, b = 三丗丄丄丝丏丒丌一.b, a = 三丗丄丄丝丏丒丌一.a});
        this.一一丅丒与丄丂丏丒.SetColor(name:  "_Color2", value:  new UnityEngine.Color() {r = 三丗丄丄丝丏丒丌一.r, g = 三丗丄丄丝丏丒丌一.g, b = 三丗丄丄丝丏丒丌一.b, a = 三丗丄丄丝丏丒丌一.a});
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.bodyRenderer, 与丒丕丁下世东丅丌:  false);
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.handsRenderer, 与丒丕丁下世东丅丌:  false);
        this.一一丅丒与丄丂丏丒.下丘丆专三丁丆东专(世万一丘丘世丟丟丛:  this.gunRenderer, 与丒丕丁下世东丅丌:  false);
    }
    internal void 万东丙丑上丐下丒丐()
    {
        this.上七世丙丁丄丗且丒();
        this.丏丈丆且上不丕丐丈 = -1f;
    }
    private void 上七世丙丁丄丗且丒()
    {
        this._mechHpIndicator.丆丐丘丂丂丑世丈丞();
    }
    private void 世丕丝丈世丁丒丞与()
    {
        this.丏丈丆且上不丕丐丈 = -1f;
    }
    internal void 丏丌与丟丌丌丘与丂(UnityEngine.Vector3 丗丕上业丑业丆且丆)
    {
        if(this.一上丕丐丈丆东丄与 != false)
        {
                return;
        }
        
        this.一上丕丐丈丆东丄与 = true;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.explosionEffect, position:  new UnityEngine.Vector3() {x = 丗丕上业丑业丆且丆.x, y = 丗丕上业丑业丆且丆.y, z = 丗丕上业丑业丆且丆.z}, rotation:  new UnityEngine.Quaternion() {x = 0f, y = 0f, z = 0f, w = 0f}), 丏业丟一东丂东丘丛:  true);
    }
    public PlayerMechBody()
    {
        this.cameraPosition = 0;
        mem[1152921535927877592] = 0;
        this.gunCameraPosition = 0;
        this.gunCameraFieldOfView = 45f;
        this.bodyColliderHeight = 4.408065E-41f;
        mem[1152921535927877604] = 0;
        this.bodyColliderRadius = 0.45f;
        this.characterControllerRadius = 7.346868E-41f;
        this.nickLabelYPoision = 1.72f;
        this.bodyColliderCenter = 0;
        mem[1152921535927877624] = 0;
        this.丕丟上丆丛丙丈世业 = new 三丈丟与丏丘丈丐万();
        this.scoreEventOnKill = 7;
        this.丌丙丛丄丒丘且丄世 = Infinityf;
        this.丕丈业丐与丆世万丞 = 2f;
        this.killChatIcon = "Chat_Mech";
        string[] val_2 = new string[6];
        val_2[0] = "mech_armor1";
        val_2[1] = "mech_armor2";
        val_2[2] = "mech_armor3";
        val_2[3] = "mech_armor4";
        val_2[4] = "mech_armor5";
        val_2[5] = "mech_armor6";
        this.healthSpriteName = val_2;
        mem2[0] = -1082130432;
        this.jumpModifier = 1f;
        this.slowdownWhenShootModifier = 1f;
        this.slowdownTimeWhenShoot = 1f;
    }

}
