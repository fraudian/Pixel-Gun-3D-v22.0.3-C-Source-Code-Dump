using UnityEngine;
internal sealed class BuffSystem : MonoBehaviour
{
    // Fields
    private static BuffSystem 丝业丆丁业三丈丟东;
    private bool[] 丛丕丕丅丂丘丗且且;
    private BuffSystem.丐丞丟世业丗下丛丙[] 丄丝丄丛万丝丘丞三;
    private System.Collections.Generic.Dictionary<BuffSystem.SituationBuffType, BuffSystem.丟不与丑与丗丙一丙> 丒且丝丒不与丛世丈;
    private System.Collections.Generic.List<BuffSystem.丈丅万丞业不与三与> 丙与万专丗丐丞与一;
    private BuffSystem.丈丅万丞业不与三与 东丒七上丏丑万丝丞;
    private BuffSystem.丈丅万丞业不与三与 三丛丂丌丁丝丑一丂;
    private bool 丈三下丞三丄丅万丝;
    private bool 且世丗丆丌东丆丛丗;
    private BuffSystem.丙丗世不三丕丄上丂 丝丝不丝上丂三丌世;
    private BuffSystem.丏一与丄下丕丟七丘[] 丆丐万丑上丄上丂三;
    private bool 丘丗下七不丏丛丂东;
    private bool 丄丛丑丛世不三丞且;
    private int 一丄丕丄丙丕三一丗;
    private BuffSystem.丟不与丑与丗丙一丙 丗丑不丑世丝丏丗丁;
    private float 且丌丐丂丅下丝与七;
    private float 三丌丆下丞丑丕丂丏;
    private bool 丞丙丘丟丛东丗三丗;
    public bool giveTryGun;
    public float timeForDiscount;
    public int discountValue;
    internal const int 上丈万丛丌丝丌一专 = 50;
    internal const int 业丗丌下丙丗丛丝万 = 3600;
    private int 丞丝世丅丄丑丛丄丐;
    private int 且丙不世丝不丆丟丒;
    private int 业丈业丄七七一丄丟;
    private float 业丕一丄不七丈东丈;
    private float 丘万丏丛万丁业专万;
    private float 丟丁专丕丌丘七万丗;
    private int 丟丌七丌丞与丒上丆;
    private bool 丘不丒三丘专丁七丌;
    private int 丄丝丝丆丕丞丒丛丝;
    private float 七一丅下丄业世七下;
    private float 万上一丗上丂丞丁丟;
    private float 专万与丙丌丟丛丏业;
    private readonly BuffSystem.SituationBuffType[] 不东与丏丑丏丞丝世;
    private readonly BuffSystem.SituationBuffType[] 丛丈丂专丘东东丌丐;
    
    // Properties
    internal static BuffSystem 丄丘七三上丕世丞业 { get; }
    private BuffSystem.丐丞丟世业丗下丛丙 丑不丕丒丟丈丞丒不 { get; }
    public bool 专丛丂东丂丙七丈专 { get; }
    public bool 世业丂丛与丛丛上丆 { get; }
    public float 丝丘丒丌丐丄专丝世 { get; }
    
    // Methods
    internal static BuffSystem 与一丅丝不丈业与丙()
    {
        int val_4 = BuffSystem.业丗丌下丙丗丛丝万;
        if(val_4 != 0)
        {
                return (BuffSystem)BuffSystem.业丗丌下丙丗丛丝万;
        }
        
        UnityEngine.GameObject val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.GameObject(name:  "BuffSystem");
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
        BuffSystem.业丗丌下丙丗丛丝万 = val_2.AddComponent<BuffSystem>();
        return (BuffSystem)BuffSystem.业丗丌下丙丗丛丝万;
    }
    private BuffSystem.丐丞丟世业丗下丛丙 不丛丝丙世下丗业丙()
    {
        return (丐丞丟世业丗下丛丙)this.丄丝丄丛万丝丘丞三[(long)ExpController.丑七不且上丗丁一世().丆丝丁丞丙上万三一()];
    }
    public bool get_haveFirstInteractons()
    {
        return (bool)(this.一丄丕丄丙丕三一丗 > 3) ? 1 : 0;
    }
    public bool get_haveAllInteractons()
    {
        return (bool)(this.丝丝不丝上丂三丌世 != 1) ? 1 : 0;
    }
    public void BuffsActive(bool 丙业与丙丗丝不丈东)
    {
        this.丄丛丑丛世不三丞且 = 丙业与丙丗丝不丈东;
        this.丄丁丞丌与丝丕丆丘();
    }
    public void CheckForPlayerBuff()
    {
        float val_22;
        var val_23;
        丈丅万丞业不与三与 val_24;
        object val_25;
        string val_26;
        丙丗世不三丕丄上丂 val_27;
        float val_28;
        丈丅万丞业不与三与 val_29;
        var val_30;
        var val_31;
        var val_32;
        this.七一丅下丄业世七下 = 1f;
        this.万上一丗上丂丞丁丟 = 1f;
        if(this.丄丛丑丛世不三丞且 == false)
        {
            goto label_50;
        }
        
        this.东丒七上丏丑万丝丞 = 0;
        mem[1152921525550792992] = 0;
        val_22 = this.GetKillrateByInteractions();
        val_23 = 0;
        goto label_2;
        label_33:
        丈丅万丞业不与三与 val_2 = this.丙与万专丗丐丞与一.Item[0];
        if((System.String.IsNullOrEmpty(value:  val_2.丌丝下丄业一丄不三)) == false)
        {
            goto label_5;
        }
        
        if(this.东丒七上丏丑万丝丞 == null)
        {
            goto label_6;
        }
        
        丈丅万丞业不与三与 val_4 = this.丙与万专丗丐丞与一.Item[0];
        if(mem[4306960403] >= val_4.丂丐丄丁丆与丈丂上.与丈丂一丌三丈丟丅)
        {
            goto label_11;
        }
        
        label_6:
        丈丅万丞业不与三与 val_5 = this.丙与万专丗丐丞与一.Item[0];
        mem[1152921525550792984] = val_5;
        if(val_5 != null)
        {
            goto label_13;
        }
        
        goto label_29;
        label_5:
        if(this.三丛丂丌丁丝丑一丂 == null)
        {
            goto label_15;
        }
        
        丈丅万丞业不与三与 val_6 = this.丙与万专丗丐丞与一.Item[0];
        if(this.三丛丂丌丁丝丑一丂.丂丐丄丁丆与丈丂上.与丈丂一丌三丈丟丅 >= val_6.丂丐丄丁丆与丈丂上.与丈丂一丌三丈丟丅)
        {
            goto label_20;
        }
        
        label_15:
        丈丅万丞业不与三与 val_7 = this.丙与万专丗丐丞与一.Item[0];
        this.三丛丂丌丁丝丑一丂 = val_7;
        if(val_7 != null)
        {
            goto label_22;
        }
        
        goto label_29;
        label_11:
        val_24 = mem[1152921525550792984];
        if(val_24 == 0)
        {
            goto label_29;
        }
        
        label_13:
        var val_21 = val_5 + 16;
        val_21 = val_21 + 20;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_25 = val_21.ToString();
        mem2[0] = null;
        val_26 = "<color=green>Buff active: {0}</color>";
        goto label_28;
        label_20:
        if(this.三丛丂丌丁丝丑一丂 == null)
        {
            goto label_29;
        }
        
        label_22:
        float val_9 = this.weaponBuffValue;
        val_25 = val_9;
        val_26 = "<color=green>Weapon buff active: {0}</color>";
        label_28:
        UnityEngine.Debug.Log(message:  System.String.Format(format:  val_26, arg0:  val_9));
        label_29:
        val_23 = 1;
        label_2:
        if(val_23 < this.丙与万专丗丐丞与一.Count)
        {
            goto label_33;
        }
        
        val_27 = this.丝丝不丝上丂三丌世;
        if(val_27 == 3)
        {
            goto label_34;
        }
        
        if(val_27 != 1)
        {
            goto label_35;
        }
        
        if(this.一丄丕丄丙丕三一丗 >= this.丛丕丕丅丂丘丗且且.Length)
        {
            goto label_47;
        }
        
        if(this.丛丕丕丅丂丘丗且且[this.一丄丕丄丙丕三一丗] == false)
        {
            goto label_47;
        }
        
        val_28 = mem[val_12 == 1 ? this.丘万丏丛万丁业专万 : this.丟丁专丕丌丘七万丗];
        val_28 = (ExperienceController.丞丞丘业东丙丏七丌() == 1) ? this.丘万丏丛万丁业专万 : this.丟丁专丕丌丘七万丗;
        goto label_43;
        label_34:
        val_29 = mem[1152921525550792984];
        if(val_29 == 0)
        {
            goto label_44;
        }
        
        if((val_5 + 16) == 0)
        {
            goto label_45;
        }
        
        this.七一丅下丄业世七下 = val_5 + 16 + 28;
        goto label_46;
        label_44:
        float val_14 = this.丛丞下上丙丏丌下东(丙业与丙丗丝不丈东:  val_22);
        val_14 = val_14 * 0.01f;
        val_14 = val_14 + 1f;
        this.七一丅下丄业世七下 = val_14;
        this.万上一丗上丂丞丁丟 = val_14;
        goto label_47;
        label_45:
        val_29 = this.东丒七上丏丑万丝丞;
        this.七一丅下丄业世七下 = val_5 + 16 + 28;
        if(val_29 == null)
        {
            goto label_48;
        }
        
        label_46:
        val_28 = this.东丒七上丏丑万丝丞.丂丐丄丁丆与丈丂上.万上一丗上丂丞丁丟;
        label_43:
        this.万上一丗上丂丞丁丟 = val_28;
        label_47:
        val_27 = this.丝丝不丝上丂三丌世;
        label_35:
        if(val_27 != 1)
        {
                float val_15 = (val_22 < 0) ? 1f : 0f;
            float val_16 = (val_22 > 2f) ? 1f : 2f;
            this.七一丅下丄业世七下 = UnityEngine.Mathf.Clamp(value:  this.七一丅下丄业世七下, min:  val_15, max:  val_16);
            this.万上一丗上丂丞丁丟 = UnityEngine.Mathf.Clamp(value:  this.万上一丗上丂丞丁丟, min:  val_15, max:  val_16);
        }
        
        label_50:
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        val_22 = this.七一丅下丄业世七下;
        七丗丕且丟丈与丘丘(丞丈专下丈专业三丞:  val_22, 一且丘丟万万丑不万:  this.万上一丗上丂丞丁丟);
        return;
        label_48:
    }
    private float 丛丞下上丙丏丌下东(float 丙业与丙丗丝不丈东)
    {
        var val_1;
        var val_10;
        var val_11;
        float val_12;
        float val_14;
        float val_10 = 丙业与丙丗丝不丈东;
        val_10 = this;
        val_10 = val_10 * 10f;
        if(val_10 >= 0f)
        {
            goto label_3;
        }
        
        if((double)val_10 != (-0.5))
        {
            goto label_4;
        }
        
        val_11 = val_1;
        val_12 = -1f;
        goto label_5;
        label_3:
        if((double)val_10 != 0.5)
        {
            goto label_6;
        }
        
        val_11 = val_1;
        val_12 = 1f;
        label_5:
        float val_11 = (float)val_11;
        val_12 = val_11 + val_12;
        val_11 = (((long)val_11 & 1) != 0) ? (val_11) : (val_12);
        goto label_8;
        label_4:
        float val_12 = -0.5f;
        val_12 = val_10 + val_12;
        goto label_8;
        label_6:
        float val_13 = 0.5f;
        val_13 = val_10 + val_13;
        label_8:
        val_14 = val_13 / 10f;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "<color=green>Killrate: {0}</color>", arg0:  val_14));
        丐丞丟世业丗下丛丙 val_3 = this.不丛丝丙世下丗业丙();
        if(val_3.丂丁与万且丒丏东东 < 0)
        {
                丐丞丟世业丗下丛丙 val_4 = this.不丛丝丙世下丗业丙();
            if(val_14 < 0)
        {
                return (float)val_14;
        }
        
        }
        
        丐丞丟世业丗下丛丙 val_5 = this.不丛丝丙世下丗业丙();
        丐丞丟世业丗下丛丙 val_6 = this.不丛丝丙世下丗业丙();
        丐丞丟世业丗下丛丙 val_7 = this.不丛丝丙世下丗业丙();
        val_14 = UnityEngine.Mathf.Clamp(value:  val_14, min:  val_6.专丙丗业世丐与丝丙, max:  val_7.世丂丘万丛万丞丞丌);
        val_10 = this.不丛丝丙世下丗业丙();
        float val_14 = val_9.丆丛丑世下一丐且丕;
        val_14 = val_14 * val_14;
        val_14 = val_5.丌丗丏丏丛东专丁且 - val_14;
        return (float)val_14;
    }
    public void KillInteraction()
    {
        this.丑世下丟世万专且丝(丙业与丙丗丝不丈东:  1);
    }
    public void DeathInteraction()
    {
        this.丑世下丟世万专且丝(丙业与丙丗丝不丈东:  2);
        this.世丘三丒丘丗丁丐一();
    }
    private void 丑世下丟世万专且丝(BuffSystem.丏一与丄下丕丟七丘 丙业与丙丗丝不丈东)
    {
        System.Boolean[] val_3;
        var val_4;
        if(this.丄丛丑丛世不三丞且 == false)
        {
                return;
        }
        
        if(this.丝丝不丝上丂三丌世 == 3)
        {
            goto label_2;
        }
        
        if(this.丝丝不丝上丂三丌世 == 2)
        {
            goto label_3;
        }
        
        if(this.丝丝不丝上丂三丌世 != 1)
        {
            goto label_14;
        }
        
        if(this.一丄丕丄丙丕三一丗 < this.丛丕丕丅丂丘丗且且.Length)
        {
                if(this.丛丕丕丅丂丘丗且且[this.一丄丕丄丙丕三一丗] != true)
        {
                this.与世万丁丂丐丂万丟(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        }
        
        }
        
        val_3 = this.丛丕丕丅丂丘丗且且;
        int val_1 = this.一丄丕丄丙丕三一丗 + 1;
        this.一丄丕丄丙丕三一丗 = val_1;
        if(val_1 >= this.丛丕丕丅丂丘丗且且.Length)
        {
            goto label_11;
        }
        
        goto label_14;
        label_2:
        this.与世万丁丂丐丂万丟(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        int val_4 = this.一丄丕丄丙丕三一丗;
        val_4 = val_4 + 1;
        this.一丄丕丄丙丕三一丗 = val_4;
        goto label_14;
        label_3:
        this.与世万丁丂丐丂万丟(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        int val_5 = this.一丄丕丄丙丕三一丗;
        val_5 = val_5 + 1;
        this.一丄丕丄丙丕三一丗 = val_5;
        if(val_5 < this.丟丌七丌丞与丒上丆)
        {
            goto label_14;
        }
        
        label_11:
        val_4 = null;
        val_4 = null;
        this.三丌丆下丞丑丕丂丏 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch;
        this.丝丝不丝上丂三丌世 = 3;
        label_14:
        this.CheckForPlayerBuff();
    }
    private void 与世万丁丂丐丂万丟(BuffSystem.丏一与丄下丕丟七丘 丙业与丙丗丝不丈东)
    {
        丏一与丄下丕丟七丘[] val_5;
        int val_7;
        this.丘丗下七不丏丛丂东 = true;
        val_5 = this.丆丐万丑上丄上丂三;
        this.专万与丙丌丟丛丏业 = -1f;
        if(this.丆丐万丑上丄上丂三 == null)
        {
                val_5 = this.丆丐万丑上丄上丂三;
        }
        
        var val_1 = (val_5 == null) ? 1 : 0;
        int val_2 = this.丆丐万丑上丄上丂三.Length - 2;
        if((val_2 & 2147483648) == 0)
        {
                var val_6 = (long)val_2;
            int val_3 = this.丆丐万丑上丄上丂三.Length - 1;
            do
        {
            val_7 = this.丆丐万丑上丄上丂三.Length;
            if(val_6 >= val_7)
        {
                val_7 = this.丆丐万丑上丄上丂三.Length;
        }
        
            val_5[((long)(int)((this.丆丐万丑上丄上丂三.Length - 1))) << 2] = val_5[((long)(int)((this.丆丐万丑上丄上丂三.Length - 2))) << 2];
            val_5 = this.丆丐万丑上丄上丂三;
            val_6 = val_6 - 1;
            val_3 = val_3 - 1;
            var val_4 = (val_5 == null) ? 1 : 0;
        }
        while((val_6 & 2147483648) == 0);
        
        }
        
        val_5[0] = 丙业与丙丗丝不丈东;
    }
    public float GetKillrateByInteractions()
    {
        var val_1;
        var val_2;
        var val_3;
        float val_4;
        if(this.专万与丙丌丟丛丏业 != (-1f))
        {
                return val_4;
        }
        
        val_1 = 0;
        val_2 = 0;
        val_3 = 0;
        goto label_1;
        label_8:
        丏一与丄下丕丟七丘 val_1 = this.丆丐万丑上丄上丂三[0];
        if(val_1 == 2)
        {
            goto label_4;
        }
        
        if(val_1 != 1)
        {
            goto label_6;
        }
        
        val_3 = 1;
        goto label_6;
        label_4:
        val_2 = 1;
        label_6:
        val_1 = 1;
        label_1:
        if(val_1 < this.丆丐万丑上丄上丂三.Length)
        {
            goto label_8;
        }
        
        val_4 = 0f;
        if(val_2 != 0)
        {
                val_4 = val_4 / 1f;
        }
        
        this.专万与丙丌丟丛丏业 = val_4;
        return val_4;
    }
    public void OnGetProgress()
    {
        if(this.丝丝不丝上丂三丌世 <= 1)
        {
                this.丝丝不丝上丂三丌世 = 2;
            this.七一丅下丄业世七下 = 1f;
            this.万上一丗上丂丞丁丟 = 1f;
            this.丘不丒三丘专丁七丌 = false;
        }
        
        this.丗丞不丟丂丑丕丙与();
    }
    private void 业万一丁丟丅丅万三()
    {
        丐丞丟世业丗下丛丙[] val_26;
        var val_27;
        this.丈三下丞三丄丅万丝 = false;
        if(this.丄丝丄丛万丝丘丞三 != null)
        {
            goto label_1;
        }
        
        val_26 = new 丐丞丟世业丗下丛丙[6];
        val_27 = 0;
        this.丄丝丄丛万丝丘丞三 = val_26;
        goto label_2;
        label_10:
        BuffSystem.丐丞丟世业丗下丛丙 val_2 = new BuffSystem.丐丞丟世业丗下丛丙();
        .丌丝世不丄丄丞丝丕 = ;
        .丗世丄世丕丏丂丆丘 = ;
        .下丅丞下丘下三七业 = 4800f;
        .丞业丈丞丟丛三丘与 = 0.5f;
        .丞丝丑且丛丕丏丄不 = 1.2f;
        .世丂丘万丛万丞丞丌 = 2f;
        .专丙丗业世丐与丝丙 = 0f;
        .上万丕丒丙三丑丈丁 = ;
        .丆丛丑世下一丐且丕 = ;
        .丌丗丏丏丛东专丁且 = 50f;
        .丂丁与万且丒丏东东 = 0.8f;
        if(this.丄丝丄丛万丝丘丞三 == null)
        {
            goto label_3;
        }
        
        if(val_2 != null)
        {
            goto label_4;
        }
        
        goto label_7;
        label_3:
        if(val_2 == null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        this.丄丝丄丛万丝丘丞三[0] = val_2;
        val_26 = this.丄丝丄丛万丝丘丞三;
        val_27 = 1;
        label_2:
        if(val_27 < this.丄丝丄丛万丝丘丞三.Length)
        {
            goto label_10;
        }
        
        label_1:
        System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙> val_4 = new System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙>(comparer:  new BuffSystem.丆丏丑七丂丂丅不丙());
        this.丒且丝丒不与丛世丈 = val_4;
        .与丈丂一丌三丈丟丅 = 0;
        .丁丅丈丌丟世丗丗丟 = 0;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 540f;
        .丁丑业专不丘上丁七 = 1800f;
        val_4.Add(key:  0, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 8589934591;
        .丁丅丈丌丟世丗丗丟 = 1;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 180f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  1, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 0;
        .丁丅丈丌丟世丗丗丟 = 65533;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 240f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  2, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 3;
        .丁丅丈丌丟世丗丗丟 = 3;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 0f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  3, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 6;
        .丁丅丈丌丟世丗丗丟 = 4;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 600f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  4, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 3;
        .丁丅丈丌丟世丗丗丟 = 5;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 300f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  5, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 7;
        .丁丅丈丌丟世丗丗丟 = 6;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 400f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  6, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 7;
        .丁丅丈丌丟世丗丗丟 = 7;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 500f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  7, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 11;
        .丁丅丈丌丟世丗丗丟 = 8;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 600f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  8, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 3;
        .丁丅丈丌丟世丗丗丟 = 9;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 700f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  9, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 3;
        .丁丅丈丌丟世丗丗丟 = 10;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 800f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  10, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 3;
        .丁丅丈丌丟世丗丗丟 = 11;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 900f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  11, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 12;
        .丁丅丈丌丟世丗丗丟 = 12;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 300f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  12, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 4;
        .丁丅丈丌丟世丗丗丟 = 13;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 400f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  13, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 14;
        .丁丅丈丌丟世丗丗丟 = 14;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 500f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  14, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 15;
        .丁丅丈丌丟世丗丗丟 = 15;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 600f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  15, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 20;
        .丁丅丈丌丟世丗丗丟 = 16;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 700f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  16, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 4;
        .丁丅丈丌丟世丗丗丟 = 17;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 800f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  17, value:  new BuffSystem.丟不与丑与丗丙一丙());
        .与丈丂一丌三丈丟丅 = 4;
        .丁丅丈丌丟世丗丗丟 = 18;
        .万上一丗上丂丞丁丟 = ;
        .七一丅下丄业世七下 = ;
        .丂三丟丂丈丐丆丗丟 = 900f;
        .丁丑业专不丘上丁七 = 1800f;
        this.丒且丝丒不与丛世丈.Add(key:  18, value:  new BuffSystem.丟不与丑与丗丙一丙());
    }
    public void TryLoadConfig()
    {
        var val_49;
        System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙> val_50;
        string val_51;
        string val_52;
        System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙> val_53;
        var val_54;
        if(this.丈三下丞三丄丅万丝 != false)
        {
                return;
        }
        
        val_49 = "BuffsParam";
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "BuffsParam")) == false)
        {
            goto label_10;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "BuffsParam"));
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_49 = "buffSettings";
        val_50 = 1152921516630043280;
        if((val_3.ContainsKey(key:  "buffSettings")) == false)
        {
            goto label_10;
        }
        
        object val_5 = val_3.Item["buffSettings"];
        val_49 = 0;
        if((val_49.ContainsKey(key:  "roundsForGunLow")) == false)
        {
            goto label_14;
        }
        
        this.丞丝世丅丄丑丛丄丐 = System.Convert.ToInt32(value:  val_49.Item["roundsForGunLow"]);
        if(1 != 0)
        {
            goto label_18;
        }
        
        goto label_20;
        label_14:
        if(1 == 0)
        {
            goto label_20;
        }
        
        label_18:
        label_20:
        if((val_49.ContainsKey(key:  "roundsForGunMiddle")) == false)
        {
            goto label_21;
        }
        
        this.且丙不世丝不丆丟丒 = System.Convert.ToInt32(value:  val_49.Item["roundsForGunMiddle"]);
        if(1 != 0)
        {
            goto label_25;
        }
        
        goto label_27;
        label_21:
        if(1 == 0)
        {
            goto label_27;
        }
        
        label_25:
        label_27:
        if((val_49.ContainsKey(key:  "roundsForGunHigh")) == false)
        {
            goto label_28;
        }
        
        this.业丈业丄七七一丄丟 = System.Convert.ToInt32(value:  val_49.Item["roundsForGunHigh"]);
        if(1 != 0)
        {
            goto label_32;
        }
        
        goto label_34;
        label_28:
        if(1 == 0)
        {
            goto label_34;
        }
        
        label_32:
        label_34:
        if((val_49.ContainsKey(key:  "timeForDiscount")) == false)
        {
            goto label_35;
        }
        
        this.timeForDiscount = System.Convert.ToSingle(value:  val_49.Item["timeForDiscount"]);
        if(1 != 0)
        {
            goto label_39;
        }
        
        goto label_41;
        label_35:
        if(1 == 0)
        {
            goto label_41;
        }
        
        label_39:
        label_41:
        if((val_49.ContainsKey(key:  "discountValue")) == false)
        {
            goto label_42;
        }
        
        this.discountValue = System.Convert.ToInt32(value:  val_49.Item["discountValue"]);
        if(1 != 0)
        {
            goto label_46;
        }
        
        goto label_48;
        label_42:
        if(1 == 0)
        {
            goto label_48;
        }
        
        label_46:
        label_48:
        if((val_49.ContainsKey(key:  "debuffKillrateForGun")) == false)
        {
            goto label_49;
        }
        
        this.业丕一丄不七丈东丈 = System.Convert.ToSingle(value:  val_49.Item["debuffKillrateForGun"]);
        if(1 != 0)
        {
            goto label_53;
        }
        
        goto label_55;
        label_49:
        if(1 == 0)
        {
            goto label_55;
        }
        
        label_53:
        label_55:
        if((val_49.ContainsKey(key:  "firstBuffArmor")) == false)
        {
            goto label_56;
        }
        
        this.丘万丏丛万丁业专万 = System.Convert.ToSingle(value:  val_49.Item["firstBuffArmor"]);
        if(1 != 0)
        {
            goto label_60;
        }
        
        goto label_62;
        label_56:
        if(1 == 0)
        {
            goto label_62;
        }
        
        label_60:
        label_62:
        if((val_49.ContainsKey(key:  "firstBuffNoArmor")) == false)
        {
            goto label_63;
        }
        
        this.丟丁专丕丌丘七万丗 = System.Convert.ToSingle(value:  val_49.Item["firstBuffNoArmor"]);
        if(1 != 0)
        {
            goto label_67;
        }
        
        goto label_69;
        label_63:
        if(1 == 0)
        {
            goto label_69;
        }
        
        label_67:
        label_69:
        if((val_49.ContainsKey(key:  "tierParams")) != false)
        {
                val_51 = "tierParams == null";
        }
        else
        {
                val_51 = "get tierParams";
        }
        
        if((val_49.ContainsKey(key:  "buffsParams")) == false)
        {
            goto label_77;
        }
        
        object val_33 = val_49.Item["buffsParams"];
        val_49 = 0;
        goto label_81;
        label_77:
        val_52 = "get buffsParams";
        goto label_82;
        label_81:
        System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙> val_35 = null;
        val_53 = val_35;
        val_35 = new System.Collections.Generic.Dictionary<SituationBuffType, 丟不与丑与丗丙一丙>();
        this.丒且丝丒不与丛世丈 = val_53;
        val_54 = 0;
        goto label_83;
        label_97:
        object val_36 = Item[0];
        val_53 = 0;
        object val_41 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  System.Convert.ToString(value:  Item["type"]));
        val_50 = this.丒且丝丒不与丛世丈;
        val_50.Add(key:  1152921504628731904, value:  new BuffSystem.丟不与丑与丗丙一丙(万丝且丘不丑丝下丑:  null));
        val_54 = 1;
        label_83:
        if(val_54 < Count)
        {
            goto label_97;
        }
        
        val_52 = val_51;
        label_82:
        if((System.String.IsNullOrEmpty(value:  val_52)) != false)
        {
                this.丈三下丞三丄丅万丝 = true;
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Error Deserialize JSON: buffSettings - "("Error Deserialize JSON: buffSettings - ") + val_52);
        label_10:
        this.业万一丁丟丅丅万三();
    }
    private void 专专丄不与丗万丆丕()
    {
        System.Func<System.Object, 丏一与丄下丕丟七丘> val_52;
        var val_53;
        string val_54;
        System.Collections.Generic.List<丈丅万丞业不与三与> val_55;
        var val_56;
        this.且世丗丆丌东丆丛丗 = true;
        object val_52 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "buffsValues"));
        if(val_52 == null)
        {
            goto label_33;
        }
        
        if((val_52.ContainsKey(key:  "interactionCount")) != false)
        {
                this.一丄丕丄丙丕三一丗 = System.Convert.ToInt32(value:  val_52.Item["interactionCount"]);
        }
        
        if((val_52.ContainsKey(key:  "allRoundsCount")) != false)
        {
                this.丄丝丝丆丕丞丒丛丝 = System.Convert.ToInt32(value:  val_52.Item["allRoundsCount"]);
        }
        
        if((val_52.ContainsKey(key:  "isFirstRounds")) != false)
        {
                this.丘不丒三丘专丁七丌 = ((System.Convert.ToInt32(value:  val_52.Item["isFirstRounds"])) == 1) ? 1 : 0;
        }
        
        if((val_52.ContainsKey(key:  "status")) != false)
        {
                this.丝丝不丝上丂三丌世 = System.Convert.ToInt32(value:  val_52.Item["status"]);
        }
        
        if((val_52.ContainsKey(key:  "lastGiveGunTime")) != false)
        {
                this.三丌丆下丞丑丕丂丏 = System.Convert.ToSingle(value:  val_52.Item["lastGiveGunTime"]);
        }
        
        if((val_52.ContainsKey(key:  "giveGun")) != false)
        {
                this.丞丙丘丟丛东丗三丗 = ((System.Convert.ToInt32(value:  val_52.Item["giveGun"])) == 1) ? 1 : 0;
        }
        
        if((val_52.ContainsKey(key:  "waitTime")) != false)
        {
                this.且丌丐丂丅下丝与七 = System.Convert.ToSingle(value:  val_52.Item["waitTime"]);
        }
        
        if((val_52.ContainsKey(key:  "waitBuff")) != false)
        {
                int val_28 = System.Convert.ToInt32(value:  val_52.Item["waitBuff"]);
            if((this.丒且丝丒不与丛世丈.ContainsKey(key:  val_28)) != false)
        {
                this.丗丑不丑世丝丏丗丁 = this.丒且丝丒不与丛世丈.Item[val_28];
        }
        
        }
        
        val_52 = "buffs";
        if((val_52.ContainsKey(key:  "buffs")) == false)
        {
            goto label_33;
        }
        
        object val_32 = val_52.Item["buffs"];
        val_53 = 0;
        val_52 = 0;
        goto label_56;
        label_59:
        object val_33 = Item[0];
        if((0.ContainsKey(key:  "weapon")) == false)
        {
            goto label_45;
        }
        
        val_54 = System.Convert.ToString(value:  0.Item["weapon"]);
        if(1 != 0)
        {
            goto label_49;
        }
        
        goto label_51;
        label_45:
        val_54 = "";
        if(1 == 0)
        {
            goto label_51;
        }
        
        label_49:
        label_51:
        .丂丐丄丁丆与丈丂上 = this.丒且丝丒不与丛世丈.Item[System.Convert.ToInt32(value:  0.Item["type"])];
        .丌丝下丄业一丄不三 = val_54;
        .专丌万丑三丙丕丙丝 = System.Convert.ToSingle(value:  0.Item["expire"]);
        val_55 = this.丙与万专丗丐丞与一;
        val_55.Add(item:  new BuffSystem.丈丅万丞业不与三与());
        val_52 = 1;
        label_56:
        if(val_52 < Count)
        {
            goto label_59;
        }
        
        label_33:
        if(this.丝丝不丝上丂三丌世 == 0)
        {
                if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  220)) != false)
        {
                this.丝丝不丝上丂三丌世 = 2;
        }
        else
        {
                this.丝丝不丝上丂三丌世 = 1;
            this.丘不丒三丘专丁七丌 = 1;
        }
        
            this.丗丞不丟丂丑丕丙与();
        }
        
        object val_47 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "buffsPlayerInteractions"));
        if(val_47 == null)
        {
                return;
        }
        
        val_55 = 1152921505042788352;
        val_56 = null;
        val_56 = null;
        val_52 = BuffSystem.<>c.<>9__61_0;
        if(val_52 == null)
        {
                System.Func<System.Object, 丏一与丄下丕丟七丘> val_49 = null;
            val_52 = val_49;
            val_49 = new System.Func<System.Object, 丏一与丄下丕丟七丘>(object:  BuffSystem.<>c.__il2cppRuntimeField_static_fields, method:  丏一与丄下丕丟七丘 BuffSystem.<>c::丟丈丁三丛丒东丘业(object 丄三丅七丆丛与与上));
            BuffSystem.<>c.<>9__61_0 = val_52;
        }
        
        this.丆丐万丑上丄上丂三 = System.Linq.Enumerable.ToArray<丏一与丄下丕丟七丘>(source:  System.Linq.Enumerable.Select<System.Object, 丏一与丄下丕丟七丘>(source:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_47) : 0, selector:  val_49));
    }
    private void 丗丞不丟丂丑丕丙与()
    {
        var val_7;
        System.Func<丈丅万丞业不与三与, System.Collections.Generic.Dictionary<System.String, System.Object>> val_9;
        if(this.且世丗丆丌东丆丛丗 == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(this.一丄丕丄丙丕三一丗 >= 1)
        {
                val_1.set_Item(key:  "interactionCount", value:  this.一丄丕丄丙丕三一丗);
        }
        
        if(this.丘不丒三丘专丁七丌 != false)
        {
                val_1.set_Item(key:  "isFirstRounds", value:  1);
        }
        
        if(this.丞丙丘丟丛东丗三丗 != false)
        {
                val_1.set_Item(key:  "giveGun", value:  1);
        }
        
        if(this.丄丝丝丆丕丞丒丛丝 >= 1)
        {
                val_1.set_Item(key:  "allRoundsCount", value:  this.丄丝丝丆丕丞丒丛丝);
        }
        
        if((this.丙与万专丗丐丞与一 != null) && (this.丙与万专丗丐丞与一.Count >= 1))
        {
                val_7 = null;
            val_7 = null;
            val_9 = BuffSystem.<>c.<>9__62_0;
            if(val_9 == null)
        {
                System.Func<丈丅万丞业不与三与, System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = null;
            val_9 = val_3;
            val_3 = new System.Func<丈丅万丞业不与三与, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  BuffSystem.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> BuffSystem.<>c::丒三丆丁与业丈一丏(BuffSystem.丈丅万丞业不与三与 丄三丅七丆丛与与上));
            BuffSystem.<>c.<>9__62_0 = val_9;
        }
        
            val_1.set_Item(key:  "buffs", value:  System.Linq.Enumerable.ToArray<System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  System.Linq.Enumerable.Select<丈丅万丞业不与三与, System.Collections.Generic.Dictionary<System.String, System.Object>>(source:  this.丙与万专丗丐丞与一, selector:  val_3)));
        }
        
        if(this.三丌丆下丞丑丕丂丏 > 0f)
        {
                val_1.set_Item(key:  "lastGiveGunTime", value:  this.三丌丆下丞丑丕丂丏);
        }
        
        if(this.且丌丐丂丅下丝与七 > 0f)
        {
                val_1.set_Item(key:  "waitTime", value:  this.且丌丐丂丅下丝与七);
        }
        
        if(this.丗丑不丑世丝丏丗丁 != null)
        {
                val_1.set_Item(key:  "waitBuff", value:  this.丗丑不丑世丝丏丗丁.丁丅丈丌丟世丗丗丟);
        }
        
        val_1.set_Item(key:  "status", value:  this.丝丝不丝上丂三丌世);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "buffsValues", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_1));
        this.世丘三丒丘丗丁丐一();
    }
    private void 世丘三丒丘丗丁丐一()
    {
        var val_5;
        System.Func<丏一与丄下丕丟七丘, System.Int32> val_7;
        if(this.丘丗下七不丏丛丂东 == false)
        {
                return;
        }
        
        this.丘丗下七不丏丛丂东 = false;
        val_5 = null;
        val_5 = null;
        val_7 = BuffSystem.<>c.<>9__63_0;
        if(val_7 == null)
        {
                System.Func<丏一与丄下丕丟七丘, System.Int32> val_1 = null;
            val_7 = val_1;
            val_1 = new System.Func<丏一与丄下丕丟七丘, System.Int32>(object:  BuffSystem.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 BuffSystem.<>c::丒丂三丌上七丄一下(BuffSystem.丏一与丄下丕丟七丘 丄三丅七丆丛与与上));
            BuffSystem.<>c.<>9__63_0 = val_7;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "buffsPlayerInteractions", 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  System.Linq.Enumerable.ToArray<System.Int32>(source:  System.Linq.Enumerable.Select<丏一与丄下丕丟七丘, System.Int32>(source:  this.丆丐万丑上丄上丂三, selector:  val_1))));
    }
    private void 丝丏丞丘丏丗且丝丌()
    {
        this.丞丙丘丟丛东丗三丗 = true;
    }
    private float 丒丄丛丘七东丒三丗()
    {
        var val_5;
        float val_6;
        val_5 = this;
        float val_1 = this.GetKillrateByInteractions();
        丐丞丟世业丗下丛丙 val_2 = this.不丛丝丙世下丗业丙();
        丐丞丟世业丗下丛丙 val_3 = this.不丛丝丙世下丗业丙();
        if(val_1 < 0)
        {
                val_6 = val_3.丌丝世不丄丄丞丝丕;
            return val_6;
        }
        
        val_5 = this.不丛丝丙世下丗业丙();
        if(val_1 < 0)
        {
                val_6 = val_4.丗世丄世丕丏丂丆丘;
            return val_6;
        }
        
        val_6 = val_4.下丅丞下丘下三七业;
        return val_6;
    }
    private void 丄丁丞丌与丝丕丆丘()
    {
        var val_6;
        if(this.丄丛丑丛世不三丞且 == false)
        {
                return;
        }
        
        val_6 = 0;
        goto label_2;
        label_16:
        if(this.丙与万专丗丐丞与一.Item[0].丞业丅一世一丝万丌() != false)
        {
                丈丅万丞业不与三与 val_3 = this.丙与万专丗丐丞与一.Item[0];
            if(val_3.丂丐丄丁丆与丈丂上.丁丅丈丌丟世丗丗丟 != 3)
        {
                丈丅万丞业不与三与 val_4 = this.丙与万专丗丐丞与一.Item[0];
            if(val_4.丂丐丄丁丆与丈丂上.丁丅丈丌丟世丗丗丟 == 0)
        {
                this.丞丙丘丟丛东丗三丗 = true;
        }
        
            this.丙与万专丗丐丞与一.RemoveAt(index:  0);
        }
        
        }
        
        val_6 = 0;
        label_2:
        if(val_6 < this.丙与万专丗丐丞与一.Count)
        {
            goto label_16;
        }
    
    }
    public void PlayerLeaved()
    {
        this.丄丁丞丌与丝丕丆丘();
        this.丗丞不丟丂丑丕丙与();
    }
    public void EndRound()
    {
        float val_7;
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = this.GetKillrateByInteractions();
        UnityEngine.Debug.Log(message:  val_7);
        if((this.丘不丒三丘专丁七丌 != false) && (this.丄丝丝丆丕丞丒丛丝 <= 9))
        {
                Rilisoft.一丟专且三万丞丁丂.上丘丅丁东东丗丅丂(与丛且专丏丁东丟丅:  this.丄丝丝丆丕丞丒丛丝, 丗丘丆丄丝与东下上:  val_7);
        }
        
        val_8 = this.丄丝丝丆丕丞丒丛丝 + 1;
        this.丄丝丝丆丕丞丒丛丝 = val_8;
        if(val_8 == 3)
        {
                Rilisoft.一丟专且三万丞丁丂.专东丂下丛丏下一东(丝丏业丅丈东业丝丒:  "third_round_complete");
            val_8 = this.丄丝丝丆丕丞丒丛丝;
        }
        
        if(val_8 >= 10)
        {
                this.丘不丒三丘专丁七丌 = false;
        }
        
        if((this.丄丛丑丛世不三丞且 != false) && (this.丈三下丞三丄丅万丝 != false))
        {
                this.丄丁丞丌与丝丕丆丘();
            丙丗世不三丕丄上丂 val_7 = this.丝丝不丝上丂三丌世;
            val_7 = val_7 - 1;
            if(val_7 >= 2)
        {
                val_7 = this.丒丄丛丘七东丒三丗();
            val_9 = null;
            val_9 = null;
            float val_3 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch;
            if((this.三丌丆下丞丑丕丂丏 + val_7) < 0)
        {
                val_10 = null;
            val_10 = null;
            this.三丌丆下丞丑丕丂丏 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch;
            if(this.GetKillrateByInteractions() > this.业丕一丄不七丈东丈)
        {
                this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  0, 丝丟丁丁东丟东丆专:  "");
        }
        else
        {
                this.丞丙丘丟丛东丗三丗 = true;
        }
        
        }
        
            if(this.丞丙丘丟丛东丗三丗 != false)
        {
                val_11 = null;
            val_11 = null;
            if( == 0)
        {
                this.giveTryGun = true;
        }
        
        }
        
        }
        
        }
        
        this.丗丞不丟丂丑丕丙与();
        this.CheckForPlayerBuff();
    }
    private void 丟丐丕下丘三丛专七(BuffSystem.SituationBuffType 丁丅丈丌丟世丗丗丟, string 丝丟丁丁东丟东丆专 = "")
    {
        this.丙与万专丗丐丞与一.Add(item:  new BuffSystem.丈丅万丞业不与三与(丂丐丄丁丆与丈丂上:  this.丒且丝丒不与丛世丈.Item[丁丅丈丌丟世丗丗丟], 三丛丂丌丁丝丑一丂:  丝丟丁丁东丟东丆专));
        this.丗丞不丟丂丑丕丙与();
        this.CheckForPlayerBuff();
    }
    private void 丟丐丘专丝三业七丞()
    {
        goto label_1;
        label_7:
        if(this.丙与万专丗丐丞与一.Item[0].丛丕丕丌丁万丂丈与() != false)
        {
                this.丙与万专丗丐丞与一.RemoveAt(index:  0);
        }
        
        0 = 0;
        label_1:
        if(0 < this.丙与万专丗丐丞与一.Count)
        {
            goto label_7;
        }
    
    }
    private void 丏丕丈丌专不丏丅丆(BuffSystem.SituationBuffType 丁丅丈丌丟世丗丗丟)
    {
        goto label_1;
        label_8:
        丈丅万丞业不与三与 val_1 = this.丙与万专丗丐丞与一.Item[0];
        if(val_1.丂丐丄丁丆与丈丂上.丁丅丈丌丟世丗丗丟 == 丁丅丈丌丟世丗丗丟)
        {
                this.丙与万专丗丐丞与一.RemoveAt(index:  0);
        }
        
        0 = 0;
        label_1:
        if(0 < this.丙与万专丗丐丞与一.Count)
        {
            goto label_8;
        }
    
    }
    public void SetGetTryGun(string 丝三丛且丘不丌丙下)
    {
        this.丞丙丘丟丛东丗三丗 = false;
        this.giveTryGun = false;
        this.丟丐丘专丝三业七丞();
        this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  3, 丝丟丁丁东丟东丆专:  丝三丛且丘不丌丙下);
    }
    public void OnTryGunBuyed(string 丝三丛且丘不丌丙下)
    {
        this.丟丐丘专丝三业七丞();
        this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  4, 丝丟丁丁东丟东丆专:  丝三丛且丘不丌丙下);
    }
    public void OnGunBuyed()
    {
        var val_2;
        this.丟丐丘专丝三业七丞();
        val_2 = null;
        val_2 = null;
        this.三丌丆下丞丑丕丂丏 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch;
        this.丗丞不丟丂丑丕丙与();
        this.CheckForPlayerBuff();
    }
    public void OnCurrencyBuyed(bool 与一丗丈丙东七上丒, int 丞世不丒下上上丝丑)
    {
        SituationBuffType[] val_5;
        SituationBuffType[] val_6;
        float val_7;
        var val_8;
        NotificationController val_9;
        var val_10;
        if(与一丗丈丙东七上丒 == false)
        {
            goto label_1;
        }
        
        val_5 = this.不东与丏丑丏丞丝世;
        if(this.不东与丏丑丏丞丝世.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        val_6 = this.不东与丏丑丏丞丝世;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        goto label_5;
        label_1:
        val_5 = this.丛丈丂专丘东东丌丐;
        if(this.丛丈丂专丘东东丌丐.Length <= 丞世不丒下上上丝丑)
        {
                return;
        }
        
        val_6 = this.丛丈丂专丘东东丌丐;
        if(val_6 != null)
        {
            goto label_8;
        }
        
        label_5:
        label_8:
        val_5 = this.丒且丝丒不与丛世丈;
        SituationBuffType val_5 = val_6[((long)(int)(丞世不丒下上上丝丑)) << 2];
        if((val_5.ContainsKey(key:  val_5)) == false)
        {
                return;
        }
        
        丟不与丑与丗丙一丙 val_2 = this.丒且丝丒不与丛世丈.Item[val_5];
        if(this.丗丑不丑世丝丏丗丁 == null)
        {
            goto label_13;
        }
        
        val_7 = this.且丌丐丂丅下丝与七;
        val_8 = null;
        val_8 = null;
        val_9 = NotificationController.丄丘七三上丕世丞业;
        float val_3 = val_9.currentPlayTime;
        val_3 = val_2.丁丑业专不丘上丁七 + val_3;
        if(val_7 >= 0)
        {
            goto label_18;
        }
        
        this.丗丑不丑世丝丏丗丁 = val_2;
        goto label_20;
        label_13:
        this.丗丑不丑世丝丏丗丁 = val_2;
        label_20:
        val_9 = 1152921505235013632;
        val_7 = val_2.丁丑业专不丘上丁七;
        val_10 = null;
        val_10 = null;
        float val_4 = NotificationController.丄丘七三上丕世丞业.currentPlayTime;
        val_4 = val_7 + val_4;
        this.且丌丐丂丅下丝与七 = val_4;
        label_18:
        this.丗丞不丟丂丑丕丙与();
    }
    public void OnSomethingPurchased()
    {
        var val_2;
        if(this.丗丑不丑世丝丏丗丁 == null)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(this.且丌丐丂丅下丝与七 > NotificationController.丄丘七三上丕世丞业.currentPlayTime)
        {
                this.丗丑不丑世丝丏丗丁 = 0;
            this.且丌丐丂丅下丝与七 = 0f;
            this.丟丐丘专丝三业七丞();
            this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  this.丗丑不丑世丝丏丗丁.丁丅丈丌丟世丗丗丟, 丝丟丁丁东丟东丆专:  "");
            return;
        }
        
        this.丗丑不丑世丝丏丗丁 = 0;
        this.且丌丐丂丅下丝与七 = 0f;
        this.丗丞不丟丂丑丕丙与();
    }
    public void OnGunTakeOff()
    {
        this.丏丕丈丌专不丏丅丆(丁丅丈丌丟世丗丗丟:  3);
        this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  1, 丝丟丁丁东丟东丆专:  "");
    }
    public void RemoveGunBuff()
    {
        this.丏丕丈丌专不丏丅丆(丁丅丈丌丟世丗丗丟:  3);
    }
    public void OnTierLvlUp()
    {
        this.丟丐丕下丘三丛专七(丁丅丈丌丟世丗丗丟:  2, 丝丟丁丁东丟东丆专:  "");
    }
    public float get_weaponBuffValue()
    {
        if(this.三丛丂丌丁丝丑一丂 == null)
        {
                return 1f;
        }
        
        return UnityEngine.Mathf.Clamp(value:  this.三丛丂丌丁丝丑一丂.丂丐丄丁丆与丈丂上.七一丅下丄业世七下, min:  (this.GetKillrateByInteractions() < 0) ? 1f : 0f, max:  (this.GetKillrateByInteractions() > 2f) ? 1f : 2f);
    }
    public bool haveBuffForWeapon(string 丌丝下丄业一丄不三)
    {
        if(this.三丛丂丌丁丝丑一丂 == null)
        {
                return false;
        }
        
        if((System.String.IsNullOrEmpty(value:  丌丝下丄业一丄不三)) != false)
        {
                return false;
        }
        
        if(this.三丛丂丌丁丝丑一丂 != null)
        {
                return System.String.op_Equality(a:  this.三丛丂丌丁丝丑一丂.丌丝下丄业一丄不三, b:  丌丝下丄业一丄不三);
        }
        
        return System.String.op_Equality(a:  this.三丛丂丌丁丝丑一丂.丌丝下丄业一丄不三, b:  丌丝下丄业一丄不三);
    }
    public void LogFirstBattlesResult(bool 丑一丂丙丈丝丑丅丑)
    {
        if(this.丘不丒三丘专丁七丌 == false)
        {
                return;
        }
        
        if(this.丄丝丝丆丕丞丒丛丝 > 9)
        {
                return;
        }
        
        丑一丂丙丈丝丑丅丑 = 丑一丂丙丈丝丑丅丑;
        Rilisoft.一丟专且三万丞丁丂.丁丝丑丆丟东丝专万(与丛且专丏丁东丟丅:  this.丄丝丝丆丕丞丒丛丝, 丛七丂丕一世不不丄:  丑一丂丙丈丝丑丅丑);
    }
    private void Awake()
    {
        this.TryLoadConfig();
        this.专专丄不与丗万丆丕();
        this.CheckForPlayerBuff();
    }
    public BuffSystem()
    {
        this.丛丕丕丅丂丘丗且且 = new bool[17] {true, true, false, true, false, true, false, false, true, false, false, true, false, false, true, false, false};
        this.丙与万专丗丐丞与一 = new System.Collections.Generic.List<丈丅万丞业不与三与>();
        this.timeForDiscount = 3600f;
        this.业丕一丄不七丈东丈 = 0.8f;
        this.丘万丏丛万丁业专万 = 8f;
        this.丟丁专丕丌丘七万丗 = 2f;
        this.丟丌七丌丞与丒上丆 = 10;
        this.丆丐万丑上丄上丂三 = new 丏一与丄下丕丟七丘[30];
        this.七一丅下丄业世七下 = 1f;
        this.万上一丗上丂丞丁丟 = 1f;
        this.专万与丙丌丟丛丏业 = -1f;
        this.discountValue = ;
        this.丞丝世丅丄丑丛丄丐 = ;
        this.且丙不世丝不丆丟丒 = 8589934594;
        this.业丈业丄七七一丄丟 = 2;
        this.不东与丏丑丏丞丝世 = new SituationBuffType[7];
        this.丛丈丂专丘东东丌丐 = new SituationBuffType[7];
    }

}
