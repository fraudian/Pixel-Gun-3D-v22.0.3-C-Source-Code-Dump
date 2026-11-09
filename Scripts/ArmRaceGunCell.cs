using UnityEngine;
public sealed class ArmRaceGunCell : PGBehaviour
{
    // Fields
    private UITextureMasked weaponIcon;
    private UILabel weaponLevelLabel;
    private UILabel weaponAmmo;
    private UnityEngine.GameObject weaponAmmoSlash;
    private UnityEngine.GameObject weaponAmmoInfinity;
    private UnityEngine.GameObject finalState;
    private UnityEngine.GameObject eventState;
    private UnityEngine.GameObject eventGunPlash;
    private UnityEngine.GameObject activeStateObj;
    private UnityEngine.Transform scaler;
    private UnityEngine.AudioSource activeStateSoundSource;
    private string 丈丁丄丘丛世七丙丝;
    private int 东丝不七丆世丈丅丐;
    private PGCompany.DataObjects.丞东三丒一丒下丈不.七专丟丒七丆下丂丛 丑丘丌与上丁七三丒;
    private WidgetLayout ammoLayout;
    private WidgetLayout levelLayout;
    private string 且业丝三丟丕与丕与;
    
    // Methods
    internal void 东业丌丁三丞丗丛万(PGCompany.DataObjects.丞东三丒一丒下丈不.七专丟丒七丆下丂丛 专丈丈丅不丅与三世)
    {
        CategoryNames val_11;
        var val_12;
        var val_13;
        var val_14;
        七专丟丒七丆下丂丛 val_15;
        UnityEngine.GameObject val_16;
        this.丑丘丌与上丁七三丒 = 专丈丈丅不丅与三世;
        三丅丁丗丗丝丂万且 val_1 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  专丈丈丅不丅与三世.weaponId);
        if(val_1 != null)
        {
                val_11 = val_1.丒万丕七专不丏丞丌();
        }
        else
        {
                val_11 = 0.丒万丕七专不丏丞丌();
        }
        
        val_12 = null;
        val_12 = null;
        if(GameController.onlineMode == null)
        {
            goto label_8;
        }
        
        val_13 = null;
        if(null == val_13)
        {
            goto label_9;
        }
        
        label_8:
        val_14 = null;
        goto label_10;
        label_9:
        val_14 = val_13;
        label_10:
        var val_5 = (val_13 == val_14) ? GameController.onlineMode : 0;
        int val_6 = val_13 == val_14 ? GameController.onlineMode : 0 + 536.LoadoutNumberInList(丐三丞七丝丅不万丛:  this.丑丘丌与上丁七三丒);
        val_15 = this.丑丘丌与上丁七三丒;
        if(this.丑丘丌与上丁七三丒 != null)
        {
            goto label_12;
        }
        
        val_15 = this.丑丘丌与上丁七三丒;
        if(val_15 == null)
        {
            goto label_13;
        }
        
        label_12:
        this.eventState.SetActive(value:  (this.丑丘丌与上丁七三丒.eventGun == true) ? 1 : 0);
        val_16 = this.eventGunPlash;
        if(val_16 != 0)
        {
                val_16 = this.eventGunPlash;
            val_16.SetActive(value:  (this.丑丘丌与上丁七三丒.eventGun == true) ? 1 : 0);
        }
        
        this.丞业与下丛万丁下丙(七丆丒与丗丌丄且丂:  val_11, 丐不丞丆与丘丙东丄:  val_1.与不丞丑七丘丁丂丛());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.weaponLevelLabel, 丕丗丘丑丛与丑业丒:  val_6 + 1);
        this.levelLayout.Reposition();
        this.丈丁丄丘丛世七丙丝 = this.丑丘丌与上丁七三丒.weaponId;
        this.东丝不七丆世丈丅丐 = val_6;
        return;
        label_13:
    }
    private void Start()
    {
    
    }
    private UnityEngine.Color 丝一丙丝上丛三丄丈(System.Nullable<ItemRarity> 丈下丑丆上丏丗丈专, int 且丐且与丟丞业丈丗 = 0)
    {
        UnityEngine.Color val_2 = ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "ArmsRace/Arms{0}_{1}", arg0:  丈下丑丆上丏丗丈专.HasValue, arg1:  且丐且与丟丞业丈丗));
        return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    private void 丌与且丂上万且丐丁(bool 丏丛与丅丛丌万专丌)
    {
        if(丏丛与丅丛丌万专丌 != false)
        {
                if(this.activeStateObj.activeSelf != true)
        {
                this.activeStateSoundSource.Play();
        }
        
        }
        
        this.activeStateObj.SetActive(value:  丏丛与丅丛丌万专丌);
    }
    private void Update()
    {
        UILabel val_31;
        var val_32;
        var val_33;
        var val_34;
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        val_31 = 1152921505219145728;
        if(val_2.x < 0)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        
        UnityEngine.Vector3 val_5 = this.transform.localPosition;
        val_5.x = val_5.x - InGameGUIPart_ArmRace.__il2cppRuntimeField_cctor_finished;
        float val_31 = System.Math.Abs(val_5.x);
        val_31 = val_31 * (-0.0015f);
        val_31 = val_31 + 1f;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_31, y:  val_31);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        this.scaler.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        val_32 = null;
        val_32 = null;
        if((GameController.onlineMode == null) || (null != null))
        {
            goto label_18;
        }
        
        if((GameController.onlineMode + 536.CurrentWeapon) == null)
        {
            goto label_53;
        }
        
        val_31 = GameController.onlineMode + 536.CurrentWeapon;
        if((System.String.op_Equality(a:  this.丈丁丄丘丛世七丙丝, b:  val_9.weaponId)) == false)
        {
            goto label_53;
        }
        
        val_31 = mem[GameController.onlineMode + 536];
        val_31 = GameController.onlineMode + 536;
        if(this.东丝不七丆世丈丅丐 != (GameController.onlineMode + 536 + 72))
        {
            goto label_53;
        }
        
        bool val_11 = GameController.onlineMode + 536 + 88 + 48.丐专丒丟丈丛丈丂业();
        val_31 = this.weaponAmmo.gameObject;
        if(val_31 == null)
        {
            goto label_30;
        }
        
        if(val_11 == false)
        {
            goto label_31;
        }
        
        label_39:
        val_31.SetActive(value:  false);
        this.weaponAmmoInfinity.gameObject.SetActive(value:  false);
        this.weaponAmmoSlash.gameObject.SetActive(value:  false);
        this.finalState.gameObject.SetActive(value:  false);
        goto label_50;
        label_30:
        if(val_11 == true)
        {
            goto label_39;
        }
        
        label_31:
        val_31.SetActive(value:  true);
        this.weaponAmmoInfinity.gameObject.SetActive(value:  true);
        this.weaponAmmoSlash.gameObject.SetActive(value:  true);
        this.finalState.gameObject.SetActive(value:  false);
        string val_20 = +GameController.onlineMode + 536 + 88.下世万丆丛专丒丑丙()(GameController.onlineMode + 536 + 88.下世万丆丛专丒丑丙());
        val_31 = this.weaponAmmo;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_31, 丕丗丘丑丛与丑业丒:  val_20);
        if((System.String.op_Inequality(a:  this.且业丝三丟丕与丕与, b:  val_20)) != false)
        {
                val_31 = this.ammoLayout;
            this.且业丝三丟丕与丕与 = val_20;
            val_31.Reposition();
        }
        
        label_50:
        if((GameController.onlineMode + 536.isFinalLoadout) != false)
        {
                this.weaponAmmo.gameObject.SetActive(value:  false);
            this.weaponAmmoInfinity.gameObject.SetActive(value:  false);
            this.weaponAmmoSlash.gameObject.SetActive(value:  false);
            this.finalState.gameObject.SetActive(value:  true);
        }
        
        label_53:
        val_33 = null;
        val_33 = null;
        if((System.String.op_Equality(a:  丙不丅丕三丂业东丕().三与丛丑且丐丈业丌(), b:  this.丈丁丄丘丛世七丙丝)) != false)
        {
                val_31 = mem[GameController.onlineMode + 536];
            val_31 = GameController.onlineMode + 536;
            var val_30 = (this.东丝不七丆世丈丅丐 == (GameController.onlineMode + 536 + 72)) ? 1 : 0;
        }
        else
        {
                val_34 = 0;
        }
        
        this.丌与且丂上万且丐丁(丏丛与丅丛丌万专丌:  false);
        return;
        label_18:
    }
    private void 丞业与下丛万丁下丙(CategoryNames 七丆丒与丗丌丄且丂, string 丐不丞丆与丘丙东丄)
    {
        CategoryNames val_9;
        var val_10;
        val_9 = 七丆丒与丗丌丄且丂;
        val_10 = this;
        if((丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  丐不丞丆与丘丙东丄, 七丆丒与丗丌丄且丂:  val_9, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false)) == 0)
        {
                return;
        }
        
        val_10 = ???;
        val_9 = ???;
        goto typeof(UITextureMasked).__il2cppRuntimeField_2E8;
    }
    public ArmRaceGunCell()
    {
        this.且业丝三丟丕与丕与 = "";
    }

}
