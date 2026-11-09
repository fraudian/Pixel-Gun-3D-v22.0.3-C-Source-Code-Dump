using UnityEngine;
public class HeartEffect : MonoBehaviour
{
    // Fields
    private UISprite 下与不七丆丕丞丘丈;
    private bool 丗上专丆与丂丙不丛;
    private bool 丗上丟上丌丂丂丂不;
    private UnityEngine.Vector3 丈丅上上三丑丝丅丑;
    private string 万丑丞一丝丌丐丒丘;
    public int heartIndex;
    private readonly string[] 丄丄丙丐丟丐专丅东;
    
    // Methods
    public string GetMechHealthSpriteName(int 丞世不丒下上上丝丑)
    {
        var val_4;
        var val_5;
        var val_7;
        val_4 = 丞世不丒下上上丝丑;
        val_5 = null;
        val_5 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_D48 == 0)
        {
                return (string)((typeof(Player_move_c).__il2cppRuntimeField_D48 + 272 + ((long)(int)(丞世不丒下上上丝丑)) << 3) + 32);
        }
        
        val_7 = null;
        val_7 = null;
        val_4 = (long)val_4;
        return (string)((typeof(Player_move_c).__il2cppRuntimeField_D48 + 272 + ((long)(int)(丞世不丒下上上丝丑)) << 3) + 32);
    }
    public void Animate(int 丞世不丒下上上丝丑, HeartEffect.丅丅东东丏世业丟丟 丁丅丈丌丟世丗丗丟)
    {
        int val_7;
        string val_9;
        val_7 = 丞世不丒下上上丝丑;
        this.heartIndex = val_7;
        if(val_7 <= 0)
        {
            goto label_1;
        }
        
        if(val_7 == 1)
        {
                this.三丗丏丅且世丝丒专(丛与丙丒丒下丌丟且:  true);
        }
        
        if(丁丅丈丌丟世丗丗丟 == 0)
        {
            goto label_3;
        }
        
        if(丁丅丈丌丟世丗丗丟 == 1)
        {
            goto label_4;
        }
        
        if(丁丅丈丌丟世丗丗丟 != 2)
        {
            goto label_5;
        }
        
        string val_2 = this.GetMechHealthSpriteName(丞世不丒下上上丝丑:  this.heartIndex - 1);
        goto label_6;
        label_1:
        this.heartIndex = 0;
        this.三丗丏丅且世丝丒专(丛与丙丒丒下丌丟且:  false);
        return;
        label_3:
        label_6:
        val_9 = "heart" + UnityEngine.Mathf.Min(a:  6, b:  this.heartIndex).ToString()(UnityEngine.Mathf.Min(a:  6, b:  this.heartIndex).ToString());
        goto label_10;
        label_4:
        val_7 = (long)this.heartIndex - 1;
        val_9 = this.丄丄丙丐丟丐专丅东[val_7];
        label_10:
        this.万丑丞一丝丌丐丒丘 = val_9;
        goto label_13;
        label_5:
        val_9 = this.万丑丞一丝丌丐丒丘;
        label_13:
        this.世业丏丕丛丏不丑丒(丌业丅丁下丆丏丂丅:  val_9);
    }
    public void SetIndex(int 丞世不丒下上上丝丑, HeartEffect.丅丅东东丏世业丟丟 丁丅丈丌丟世丗丗丟)
    {
        int val_13;
        UISprite val_14;
        string val_15;
        var val_16;
        val_13 = 丞世不丒下上上丝丑;
        val_14 = this;
        if(this.下与不七丆丕丞丘丈 == 0)
        {
                return;
        }
        
        this.heartIndex = val_13;
        this.丗上专丆与丂丙不丛 = false;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        this.丈丅上上三丑丝丅丑 = val_2;
        mem[1152921526219843064] = val_2.y;
        mem[1152921526219843068] = val_2.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        if(this.heartIndex <= 0)
        {
            goto label_7;
        }
        
        this.丗上丟上丌丂丂丂不 = true;
        val_13 = this.gameObject;
        val_13.SetActive(value:  true);
        if(丁丅丈丌丟世丗丗丟 == 2)
        {
            goto label_9;
        }
        
        if(丁丅丈丌丟世丗丗丟 == 1)
        {
            goto label_10;
        }
        
        if(丁丅丈丌丟世丗丗丟 != 0)
        {
                return;
        }
        
        val_14 = "heart" + UnityEngine.Mathf.Min(a:  6, b:  this.heartIndex).ToString()(UnityEngine.Mathf.Min(a:  6, b:  this.heartIndex).ToString());
        if(this.下与不七丆丕丞丘丈 != null)
        {
            goto label_25;
        }
        
        label_26:
        label_25:
        val_15 = val_14;
        goto label_21;
        label_7:
        this.heartIndex = 0;
        val_13 = this.gameObject;
        val_13.SetActive(value:  false);
        this.丗上丟上丌丂丂丂不 = false;
        if(丁丅丈丌丟世丗丗丟 == 2)
        {
            goto label_17;
        }
        
        if(丁丅丈丌丟世丗丗丟 == 1)
        {
            goto label_18;
        }
        
        if(丁丅丈丌丟世丗丗丟 != 0)
        {
                return;
        }
        
        val_14 = this.下与不七丆丕丞丘丈;
        val_15 = "heart1";
        goto label_21;
        label_9:
        val_14 = this.下与不七丆丕丞丘丈;
        val_16 = this.heartIndex - 1;
        goto label_22;
        label_10:
        string val_12 = this.丄丄丙丐丟丐专丅东[(long)this.heartIndex - 1];
        if(this.下与不七丆丕丞丘丈 != null)
        {
            goto label_25;
        }
        
        goto label_26;
        label_17:
        val_14 = this.下与不七丆丕丞丘丈;
        val_16 = 0;
        label_22:
        if(val_14 != null)
        {
            goto label_30;
        }
        
        label_31:
        label_30:
        val_15 = val_13.GetMechHealthSpriteName(丞世不丒下上上丝丑:  0);
        label_21:
        val_14.spriteName = val_15;
        return;
        label_18:
        string val_13 = this.丄丄丙丐丟丐专丅东[0];
        if(this.下与不七丆丕丞丘丈 != null)
        {
            goto label_30;
        }
        
        goto label_31;
    }
    private void 三丗丏丅且世丝丒专(bool 丛与丙丒丒下丌丟且)
    {
        this.丗上丟上丌丂丂丂不 = 丛与丙丒丒下丌丟且;
        this.丗上专丆与丂丙不丛 = true;
        if(丛与丙丒丒下丌丟且 != false)
        {
                this.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        }
        else
        {
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  0.001f);
        }
        
        this.丈丅上上三丑丝丅丑 = val_5;
        mem[1152921526220098424] = val_5.y;
        mem[1152921526220098428] = val_5.z;
    }
    private void 世业丏丕丛丏不丑丒(string 丌业丅丁下丆丏丂丅)
    {
        this.万丑丞一丝丌丐丒丘 = 丌业丅丁下丆丏丂丅;
        this.丗上专丆与丂丙不丛 = true;
        this.丗上丟上丌丂丂丂不 = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  1.7f);
        this.丈丅上上三丑丝丅丑 = val_2;
        mem[1152921526220222712] = val_2.y;
        mem[1152921526220222716] = val_2.z;
        this.gameObject.SetActive(value:  true);
    }
    private void Awake()
    {
        this.下与不七丆丕丞丘丈 = this.GetComponent<UISprite>();
    }
    private void Update()
    {
        string val_17;
        float val_18;
        float val_19;
        if(this.丗上专丆与丂丙不丛 == false)
        {
                return;
        }
        
        val_17 = this.transform;
        UnityEngine.Vector3 val_3 = val_17.localScale;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, target:  new UnityEngine.Vector3() {x = this.丈丅上上三丑丝丅丑, y = V11.16B, z = V12.16B}, maxDistanceDelta:  UnityEngine.Time.deltaTime * 7f);
        val_18 = val_6.x;
        val_19 = val_6.z;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_18, y = val_6.y, z = val_19};
        UnityEngine.Vector3 val_8 = this.transform.localScale;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = this.丈丅上上三丑丝丅丑, y = V11.16B, z = V12.16B})) == false)
        {
                return;
        }
        
        if(this.丗上丟上丌丂丂丂不 == false)
        {
            goto label_8;
        }
        
        UnityEngine.Vector3 val_11 = this.transform.localScale;
        val_18 = val_11.x;
        val_19 = val_11.z;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_11.y, z = val_19}, rhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z})) == false)
        {
            goto label_12;
        }
        
        label_8:
        this.丗上专丆与丂丙不丛 = false;
        this.gameObject.SetActive(value:  (this.丗上丟上丌丂丂丂不 == true) ? 1 : 0);
        return;
        label_12:
        val_17 = this.万丑丞一丝丌丐丒丘;
        this.下与不七丆丕丞丘丈.spriteName = val_17;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        this.丈丅上上三丑丝丅丑 = val_16;
        mem[1152921526220491768] = val_16.y;
        mem[1152921526220491772] = val_16.z;
    }
    public HeartEffect()
    {
        string[] val_1 = new string[7];
        val_1[0] = "wood_armor";
        val_1[1] = "armor";
        val_1[2] = "gold_armor";
        val_1[3] = "crystal_armor";
        val_1[4] = "red_armor";
        val_1[5] = "adamant_armor";
        val_1[6] = "adamant_armor";
        this.丄丄丙丐丟丐专丅东 = val_1;
    }

}
