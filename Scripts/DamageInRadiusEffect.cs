using UnityEngine;
public class DamageInRadiusEffect : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject surfacedEffectObj;
    private BaseIsInside _isInside;
    private Player_move_c 丕不丘下七丑上丏丏;
    private WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世;
    private Player_move_c.世不丟丂上丟与丌下 与丑丕一丝下三丆丈;
    private float 三丞业丄三上丑丄丗;
    private float 丝丈且丄丑丈万丞丙;
    private float 丒下世丝丂万丑丏下;
    private float 丝专一丏上丅丞丘与;
    private bool 丈业丒世东与三丅丒;
    private float 七下丐丒三下丝上丄;
    private string 丝三丛且丘不丌丙下;
    private int 下丐东专丏丙丗丈不;
    private float 且丝一丈丟下丞丅与;
    private bool 丛丅丘一丏丙且丌上;
    private bool 丌丒丕丄丑丌世不丐;
    private bool 世业万丕丘丘丕丅下;
    private bool 丘丙丛三七丏上专丏;
    private bool 丄世丅下丒七丈下丘;
    private DamageInRadiusEffect.WeaponInfoForPoison 丂丌与三上丄与丙专;
    private bool 东丆丈丘丕丙与丗丄;
    private float 丟丘丟丆丐不丗丝丏;
    private Player_move_c 丞上下与丑业专丅丄;
    private 丅丙上七上一丐不下 丒上丞丐东专不丑丗;
    private System.Collections.Generic.List<UnityEngine.Transform> 丏丞专业丑丆丒丙丄;
    private bool 与下丗丅丑下万业东;
    private bool 不丙丒丙丐丘一丟且;
    
    // Methods
    private void Awake()
    {
        if(this._isInside == 0)
        {
                return;
        }
        
        if(this._isInside == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        (null == null) ? this._isInside : 0.SetRadius(且丛上丕业丂丒与一:  this.三丞业丄三上丑丄丗);
    }
    internal void 丟与丁丐丑世丏丗下(丅丙上七上一丐不下 丂丈丙且丈丗三丆丕)
    {
        this.丒上丞丐东专不丑丗 = 丂丈丙且丈丗三丆丕;
    }
    internal void 丟东丈丙世下专世丐(float 丁丂专业丁丅丅丈丙, Player_move_c 上一丝与业丙丝不丝)
    {
        this.丟丘丟丆丐不丗丝丏 = 丁丂专业丁丅丅丈丙;
        this.东丆丈丘丕丙与丗丄 = true;
        this.丞上下与丑业专丅丄 = 上一丝与业丙丝不丝;
    }
    internal void 丆丌且丙丝不万丂丆(float 丒下世丝丂万丑丏下, float 万丗丛丐丅丄七不丅, float 丂三丟丂丈丐丆丗丟, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三)
    {
        null = null;
        this.丆丌且丙丝不万丂丆(丒下世丝丂万丑丏下:  丒下世丝丂万丑丏下, 万丗丛丐丅丄七不丅:  万丗丛丐丅丄七不丅, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丅业下不东丗丄与三:  丅业下不东丗丄与三, 丘世丛丈丅世丑丙丂:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC);
    }
    internal void 丆丌且丙丝不万丂丆(float 丒下世丝丂万丑丏下, float 万丗丛丐丅丄七不丅, float 丂三丟丂丈丐丆丗丟, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, Player_move_c 丘世丛丈丅世丑丙丂)
    {
        float val_4;
        var val_5;
        val_4 = 万丗丛丐丅丄七不丅;
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
        this.丛丅丘一丏丙且丌上 = true;
        val_5 = PlayerCoreSettingsStorager.dynamicSettings;
        if(val_1.下丆业七丐一世丝下 != 0f)
        {
                val_5 = PlayerCoreSettingsStorager.dynamicSettings;
            val_4 = val_2.下丆业七丐一世丝下 * val_4;
        }
        
        this.丒下世丝丂万丑丏下 = 丒下世丝丂万丑丏下;
        this.丝三丛且丘不丌丙下 = 丝三丛且丘不丌丙下;
        this.东丏业丞丞业下丄世 = 东丏业丞丞业下丄世;
        this.与丑丕一丝下三丆丈 = 丅业下不东丗丄与三;
        this.三丞业丄三上丑丄丗 = val_4;
        if(((this._isInside != 0) && (this._isInside != null)) && (null == null))
        {
                this._isInside.SetRadius(且丛上丕业丂丒与一:  val_4);
        }
        
        this.丝丈且丄丑丈万丞丙 = 丂三丟丂丈丐丆丗丟;
        this.丂丌与三上丄与丙专 = 0;
    }
    internal void 丒丑一不丐丙丏东丑(float 丝专一丏上丅丞丘与, float 万丗丛丐丅丄七不丅, float 丂三丟丂丈丐丆丗丟, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, Player_move_c 丘世丛丈丅世丑丙丂)
    {
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
        this.丝专一丏上丅丞丘与 = 丝专一丏上丅丞丘与;
        this.丝三丛且丘不丌丙下 = 丝三丛且丘不丌丙下;
        this.东丏业丞丞业下丄世 = 东丏业丞丞业下丄世;
        this.与丑丕一丝下三丆丈 = 丅业下不东丗丄与三;
        this.三丞业丄三上丑丄丗 = 万丗丛丐丅丄七不丅;
        this.丛丅丘一丏丙且丌上 = true;
        this.丘丙丛三七丏上专丏 = true;
        if(((this._isInside != 0) && (this._isInside != null)) && (null == null))
        {
                this._isInside.SetRadius(且丛上丕业丂丒与一:  万丗丛丐丅丄七不丅);
        }
        
        this.丝丈且丄丑丈万丞丙 = 丂三丟丂丈丐丆丗丟;
        this.丂丌与三上丄与丙专 = 0;
    }
    internal void 丕丙丝丞丐丐三丄丝(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丂丐丈丕丞下丁下丘, float 丒丙丘丕且一丞丕丑, int 丂上上不一丐业一丕, float 丒下世丝丂万丑丏下, float 万丗丛丐丅丄七不丅, float 丂三丟丂丈丐丆丗丟, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, bool 丌丛丑三丆丘万丘丛)
    {
        null = null;
        this.丕丙丝丞丐丐三丄丝(三一丝且丝丛不丄丐:  三一丝且丝丛不丄丐, 丂丐丈丕丞下丁下丘:  丂丐丈丕丞下丁下丘, 丒丙丘丕且一丞丕丑:  丒丙丘丕且一丞丕丑, 丂上上不一丐业一丕:  丂上上不一丐业一丕, 丒下世丝丂万丑丏下:  丒下世丝丂万丑丏下, 万丗丛丐丅丄七不丅:  万丗丛丐丅丄七不丅, 丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丅业下不东丗丄与三:  丅业下不东丗丄与三, 丘世丛丈丅世丑丙丂:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 丌丛丑三丆丘万丘丛:  丌丛丑三丆丘万丘丛);
    }
    internal void 丕丙丝丞丐丐三丄丝(Rilisoft.丏丏专丙世丝万丅且 三一丝且丝丛不丄丐, float 丂丐丈丕丞下丁下丘, float 丒丙丘丕且一丞丕丑, int 丂上上不一丐业一丕, float 丒下世丝丂万丑丏下, float 万丗丛丐丅丄七不丅, float 丂三丟丂丈丐丆丗丟, string 丝三丛且丘不丌丙下, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三, Player_move_c 丘世丛丈丅世丑丙丂, bool 丌丛丑三丆丘万丘丛)
    {
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
        this.丝三丛且丘不丌丙下 = 丝三丛且丘不丌丙下;
        this.丒下世丝丂万丑丏下 = 丒下世丝丂万丑丏下;
        this.三丞业丄三上丑丄丗 = 万丗丛丐丅丄七不丅;
        this.丛丅丘一丏丙且丌上 = true;
        this.丌丒丕丄丑丌世不丐 = true;
        if(((this._isInside != 0) && (this._isInside != null)) && (null == null))
        {
                this._isInside.SetRadius(且丛上丕业丂丒与一:  万丗丛丐丅丄七不丅);
        }
        
        bool val_2 = 丌丛丑三丆丘万丘丛;
        this.丝丈且丄丑丈万丞丙 = 丂三丟丂丈丐丆丗丟;
        this.丈业丒世东与三丅丒 = val_2;
        this.丂丌与三上丄与丙专 = new DamageInRadiusEffect.WeaponInfoForPoison(三一丝且丝丛不丄丐:  三一丝且丝丛不丄丐, 丒丙丘丕且一丞丕丑:  丒丙丘丕且一丞丕丑, 丂丐丈丕丞下丁下丘:  丂丐丈丕丞下丁下丘, 丂上上不一丐业一丕:  丂上上不一丐业一丕, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下, 东丏业丞丞业下丄世:  东丏业丞丞业下丄世, 丌丛丑三丆丘万丘丛:  val_2);
    }
    internal void 丐丝丟与丛七万业丗(float 丈一丄丙丝东丘与丘, float 下一丐丕三丗丝丑不, Player_move_c 丘世丛丈丅世丑丙丂)
    {
        this.丕不丘下七丑上丏丏 = 丘世丛丈丅世丑丙丂;
        this.七下丐丒三下丝上丄 = 丈一丄丙丝东丘与丘;
        this.丝丈且丄丑丈万丞丙 = 下一丐丕三丗丝丑不;
        this.丛丅丘一丏丙且丌上 = true;
        this.世业万丕丘丘丕丅下 = true;
        this.丂丌与三上丄与丙专 = 0;
    }
    internal void 丞丐业七不万且丂丞(int 七丞丙丒三丕且丌丟)
    {
        this.下丐东专丏丙丗丈不 = 七丞丙丒三丕且丌丟;
    }
    internal void 上东下丏丈丕丅且专()
    {
        float val_9;
        bool val_10;
        if(this.surfacedEffectObj == 0)
        {
            goto label_3;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_9 = val_3.x;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  5f, layerMask:  1)) == false)
        {
            goto label_7;
        }
        
        this.surfacedEffectObj.transform.position = new UnityEngine.Vector3() {x = 5f, y = val_3.y, z = val_3.z};
        val_9 = 5f;
        this.surfacedEffectObj.transform.up = new UnityEngine.Vector3() {x = val_9, y = val_3.y, z = val_3.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.surfacedEffectObj, 丏业丟一东丂东丘丛:  true);
        label_3:
        val_10 = 0;
        goto label_14;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.surfacedEffectObj, 丏业丟一东丂东丘丛:  false);
        val_10 = true;
        label_14:
        this.丄世丅下丒七丈下丘 = val_10;
    }
    private void OnDisable()
    {
        this.丛丅丘一丏丙且丌上 = false;
        this.丌丒丕丄丑丌世不丐 = false;
    }
    private void Update()
    {
        if(this.丛丅丘一丏丙且丌上 == false)
        {
                return;
        }
        
        if(this.丄世丅下丒七丈下丘 == true)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.time;
        if(this.且丝一丈丟下丞丅与 >= 0)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        val_2 = val_2 + this.丝丈且丄丑丈万丞丙;
        this.且丝一丈丟下丞丅与 = val_2;
        this.丐丑且丈丝东丏一丑();
    }
    internal void 下丞与与三上丟丙与(bool 专丒丗与东丗与丙业, bool 世一丅丌专丕东丑丗)
    {
        this.与下丗丅丑下万业东 = 专丒丗与东丗与丙业;
        this.不丙丒丙丐丘一丟且 = 世一丅丌专丕东丑丗;
    }
    private void 丐丑且丈丝东丏一丑()
    {
        float val_25;
        int val_45;
        var val_46;
        var val_49;
        var val_50;
        var val_52;
        var val_53;
        var val_54;
        float val_58;
        float val_59;
        var val_60;
        float val_61;
        float val_62;
        float val_66;
        var val_67;
        var val_68;
        var val_70;
        世不丟丂上丟与丌下 val_72;
        string val_74;
        丏专丐且丘丌丛不丁 val_75;
        if(this.丕不丘下七丑上丏丏 == 0)
        {
                return;
        }
        
        if((GameConnect.丙丘不世专且万丄丐() != false) && ((TimeGameController.丄丞丁丈与业上丞丟 != 0) && (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory != 1)))
        {
                val_45 = this.下丐东专丏丙丗丈不;
            if(val_45 != 1)
        {
                if((val_45 - 1) != ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory)
        {
                return;
        }
        
        }
        
        }
        
        this.丏丞专业丑丆丒丙丄.Clear();
        if(this.与下丗丅丑下万业东 == false)
        {
            goto label_16;
        }
        
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_6 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  this.不丙丒丙丐丘一丟且, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        val_46 = 1152921504686346240;
        label_30:
        var val_49 = 0;
        val_49 = val_49 + 1;
        if(val_6.MoveNext() == false)
        {
            goto label_23;
        }
        
        var val_50 = 0;
        val_50 = val_50 + 1;
        this.丏丞专业丑丆丒丙丄.Add(item:  val_6.Current);
        goto label_30;
        label_16:
        val_49 = 0;
        goto label_45;
        label_23:
        val_49 = 0;
        val_50 = 0;
        if(val_6 == null)
        {
            
        }
        else
        {
                var val_51 = 0;
            val_51 = val_51 + 1;
            val_6.Dispose();
        }
        
        if(( == 1) || (247 != 247))
        {
            goto label_43;
        }
        
        val_52 = 0;
        goto label_78;
        label_43:
        label_45:
        val_53 = null;
        val_53 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.世业万丕丘丘丕丅下 == false)
        {
            goto label_49;
        }
        
        }
        
        val_54 = 0;
        goto label_50;
        label_49:
        bool val_52 = this.丘丙丛三七丏上专丏;
        val_52 = val_52 ^ 1;
        val_54 = val_52 & 255;
        label_50:
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_14 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  this.丕不丘下七丑上丏丏, 不丙丗丞丌丈且丄丟:  (val_54 == true) ? 1 : 0, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        val_46 = 1152921504686346240;
        label_64:
        var val_53 = 0;
        val_53 = val_53 + 1;
        if(val_14.MoveNext() == false)
        {
            goto label_57;
        }
        
        var val_54 = 0;
        val_54 = val_54 + 1;
        this.丏丞专业丑丆丒丙丄.Add(item:  val_14.Current);
        goto label_64;
        label_57:
        val_52 = 0 + 1;
        val_50 = 0;
        mem2[0] = 247;
        if(val_14 == null)
        {
            
        }
        else
        {
                var val_55 = 0;
            val_55 = val_55 + 1;
            val_14.Dispose();
        }
        
        if((val_52 != 1) && ((1152921525880256208 + ((0 + 1)) << 2) == 247))
        {
                var val_56 = 0;
            val_56 = val_56 ^ (val_52 >> 31);
            val_52 = val_52 + val_56;
        }
        else
        {
                if( != false)
        {
                val_50 = 0;
        }
        
        }
        
        label_78:
        if(this.surfacedEffectObj != 0)
        {
            goto label_81;
        }
        
        if(this.transform != null)
        {
            goto label_148;
        }
        
        label_149:
        label_148:
        UnityEngine.Vector3 val_22 = 0.position;
        val_45 = this.丏丞专业丑丆丒丙丄;
        List.Enumerator<T> val_23 = val_45.GetEnumerator();
        label_146:
        if(((-201427168) & 1) == 0)
        {
            goto label_84;
        }
        
        string val_26 = val_25.丐丏七丌丕丗业且上();
        val_58 = this.三丞业丄三上丑丄丗;
        if(this.东丆丈丘丕丙与丗丄 != false)
        {
                if(this.丞上下与丑业专丅丄.myPlayerTransform == val_26)
        {
                val_59 = this.丟丘丟丆丐不丗丝丏;
            val_58 = val_58 * val_59;
            val_25 = val_58;
            UnityEngine.Debug.LogError(message:  val_25 + " is tempRadiusDetectTarget");
        }
        
        }
        
        val_60 = 0;
        if(this._isInside != 0)
        {
            goto label_94;
        }
        
        UnityEngine.Vector3 val_30 = val_26.position;
        val_61 = val_30.x;
        val_62 = val_30.z;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_61, y = val_30.y, z = val_62}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        val_66 = val_58 * val_58;
        if(val_31.x < 0)
        {
            goto label_98;
        }
        
        label_94:
        val_60 = 0;
        if(this._isInside == 0)
        {
            goto label_146;
        }
        
        UnityEngine.Vector3 val_33 = val_26.position;
        val_67 = val_33.x;
        val_66 = val_33.y;
        val_62 = val_33.z;
        if((this._isInside & 1) == 0)
        {
            goto label_146;
        }
        
        label_98:
        if(this.丌丒丕丄丑丌世不丐 == false)
        {
            goto label_105;
        }
        
        this.丕不丘下七丑上丏丏.丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_26.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, 丒下世丝丂万丑丏下:  this.丒下世丝丂万丑丏下, 丌丒万丂丈不且丈丄:  this.丂丌与三上丄与丙专);
        goto label_146;
        label_105:
        if(this.世业万丕丘丘丕丅下 == false)
        {
            goto label_109;
        }
        
        丅丙上七上一丐不下 val_35 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_26);
        if(val_35 == null)
        {
            goto label_112;
        }
        
        var val_57 = 0;
        val_57 = val_57 + 1;
        val_68 = 4;
        goto label_116;
        label_109:
        if(this.丘丙丛三七丏上专丏 == false)
        {
            goto label_117;
        }
        
        丅丙上七上一丐不下 val_36 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_26);
        var val_58 = 0;
        val_58 = val_58 + 1;
        val_70 = 4;
        goto label_124;
        label_117:
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.zero;
        val_72 = this.与丑丕一丝下三丆丈;
        if(this.丕不丘下七丑上丏丏 == 0)
        {
                val_72 = val_72;
        }
        
        this.丕不丘下七丑上丏丏.丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  val_26.gameObject, 丞丈专下丈专业三丞:  this.丒下世丝丂万丑丏下, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, 丝三丛且丘不丌丙下:  this.丝三丛且丘不丌丙下, 东丏业丞丞业下丄世:  this.东丏业丞丞业下丄世, 丐丟丘世丁三丕专专:  val_72);
        goto label_146;
        label_116:
        if((val_35.IsEnemyTo(专丞上七七且丝七丗:  this.丕不丘下七丑上丏丏)) == false)
        {
            goto label_146;
        }
        
        label_112:
        float val_59 = 0.5f;
        val_59 = this.丝丈且丄丑丈万丞丙 + val_59;
        this.丕不丘下七丑上丏丏.与东丁业丁与且丌丕(丞下万上三丘上与专:  val_26.gameObject, 七丏上不丒万丐东丄:  val_59, 三上丅丈丄不丌万丙:  this.七下丐丒三下丝上丄);
        goto label_146;
        label_124:
        if((val_36.IsEnemyTo(专丞上七七且丝七丗:  this.丕不丘下七丑上丏丏)) == false)
        {
            goto label_146;
        }
        
        var val_60 = 0;
        val_60 = val_60 + 1;
        float val_46 = val_36.maxHealth;
        val_74 = this.丝三丛且丘不丌丙下;
        val_75 = this.东丏业丞丞业下丄世;
        if(this.丕不丘下七丑上丏丏 == 0)
        {
                val_75 = val_75;
            val_74 = val_74;
        }
        
        val_46 = val_46 * this.丝专一丏上丅丞丘与;
        this.丕不丘下七丑上丏丏.丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  val_26.gameObject, 丞丈专下丈专业三丞:  val_46, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, 丝三丛且丘不丌丙下:  val_74, 东丏业丞丞业下丄世:  val_75, 丐丟丘世丁三丕专专:  this.与丑丕一丝下三丆丈);
        if(val_36 == null)
        {
            goto label_146;
        }
        
        val_36.丁业丒下丙丟丄世丈(三丈一丑丕世万丁丙:  0, 丂丛丆万丁丆下三丘:  this.丝三丛且丘不丌丙下, 三丛丄一东丑丁且业:  3, 丘万丟丕与专丁三丘:  this.丝丈且丄丑丈万丞丙 * 1.1f, 丆丅丅丂下丏丏丞丂:  0);
        goto label_146;
        label_81:
        if(this.surfacedEffectObj.transform != null)
        {
            goto label_148;
        }
        
        goto label_149;
        label_84:
        val_52 = val_52 + 1;
        mem2[0] = 810;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_52 != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if((1152921525880256208 + (((0 + 1) + 1)) << 2) == 810)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    public DamageInRadiusEffect()
    {
        this.东丏业丞丞业下丄世 = 3;
        this.七下丐丒三下丝上丄 = 1f;
        this.下丐东专丏丙丗丈不 = 0;
        this.三丞业丄三上丑丄丗 = ;
        this.丝丈且丄丑丈万丞丙 = ;
        this.丒下世丝丂万丑丏下 = 1f;
        this.丝专一丏上丅丞丘与 = 1f;
        this.丏丞专业丑丆丒丙丄 = new System.Collections.Generic.List<UnityEngine.Transform>();
    }

}
