using UnityEngine;
public class BotTrigger : MonoBehaviour
{
    // Fields
    private BotAI 且三万丈丂丌业丒丟;
    private bool 丒丐丒上丐万丛丕丟;
    private UnityEngine.GameObject 丐丒丅丗丏上一丏丅;
    private UnityEngine.GameObject 丒一丄丗丞丗丄丐丂;
    private Player_move_c 丕七三上上一丆丈世;
    private Sounds 丁一世丈下上与丅七;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public bool shouldDetectPlayer;
    
    // Methods
    private void Awake()
    {
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        var val_17;
        var val_18;
        this.万东万丆专丌丕丐丗 = this.transform;
        System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
        var val_17 = 0;
        val_17 = val_17 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        goto label_12;
        label_7:
        val_17 = 0;
        val_18 = 0;
        goto label_13;
        label_12:
        object val_7 = val_3.Current;
        val_17 = 0;
        val_18 = 0;
        this.丐丒丅丗丏上一丏丅 = 0.gameObject;
        label_13:
        if(val_3 != null)
        {
                var val_19 = 0;
            val_19 = val_19 + 1;
            val_3.Dispose();
        }
        
        if(val_17 == 1)
        {
            goto label_22;
        }
        
        if((val_18 == 0) || (79 == 79))
        {
            goto label_32;
        }
        
        label_31:
        label_32:
        this.丁一世丈下上与丅七 = this.丐丒丅丗丏上一丏丅.GetComponent<Sounds>();
        this.且三万丈丂丌业丒丟 = this.GetComponent<BotAI>();
        UnityEngine.GameObject val_14 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player");
        this.丒一丄丗丞丗丄丐丂 = val_14;
        if(val_14 == 0)
        {
                return;
        }
        
        SkinName val_16 = this.丒一丄丗丞丗丄丐丂.GetComponent<SkinName>();
        this.丕七三上上一丆丈世 = val_16.playerMoveC;
        return;
        label_22:
        if(val_18 != 0)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    private void Update()
    {
        UnityEngine.Transform val_31;
        float val_32;
        float val_33;
        float val_34;
        Sounds val_35;
        UnityEngine.Object val_36;
        float val_37;
        var val_38;
        var val_39;
        if(this.shouldDetectPlayer == false)
        {
                return;
        }
        
        if(this.丒丐丒上丐万丛丕丟 == false)
        {
            goto label_2;
        }
        
        TurretController val_1 = this.且三万丈丂丌业丒丟.Target.GetComponent<TurretController>();
        val_31 = this.且三万丈丂丌业丒丟.Target;
        if(val_31 == 0)
        {
            goto label_22;
        }
        
        if((this.且三万丈丂丌业丒丟.Target.CompareTag(tag:  "Player")) == false)
        {
            goto label_14;
        }
        
        val_31 = this.丕七三上上一丆丈世;
        if(this.丕七三上上一丆丈世.万万一与丝业七专下 == true)
        {
            goto label_22;
        }
        
        if(this.丒丐丒上丐万丛丕丟 == false)
        {
            goto label_14;
        }
        
        UnityEngine.Vector3 val_5 = this.transform.position;
        val_32 = val_5.z;
        UnityEngine.Vector3 val_7 = this.丒一丄丗丞丗丄丐丂.transform.position;
        val_33 = val_7.y;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_32}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_33, z = val_7.z});
        val_31 = this.丁一世丈下上与丅七;
        val_34 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        val_35 = val_31;
        if(val_31 != null)
        {
            goto label_20;
        }
        
        val_35 = this.丁一世丈下上与丅七;
        if(val_35 == null)
        {
            goto label_21;
        }
        
        label_20:
        float val_31 = this.丁一世丈下上与丅七.detectRadius;
        val_31 = val_31 * this.丁一世丈下上与丅七.detectRadius;
        if(val_34 > val_31)
        {
            goto label_22;
        }
        
        label_14:
        val_31 = this.且三万丈丂丌业丒丟.Target;
        if((val_31.CompareTag(tag:  "Turret")) == false)
        {
                return;
        }
        
        if(val_1.isKilled == false)
        {
                return;
        }
        
        if(val_1.isRun == false)
        {
                return;
        }
        
        label_22:
        this.且三万丈丂丌业丒丟.SetTarget(与且且丑丌业丙与三:  0, 不专丁丌丌丌与丝世:  false);
        this.丒丐丒上丐万丛丕丟 = false;
        return;
        label_2:
        val_36 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Turret");
        if((val_36 == 0) || ((val_36.GetComponent<TurretController>()) == 0))
        {
            goto label_40;
        }
        
        if(val_12.isKilled == false)
        {
            goto label_39;
        }
        
        label_41:
        val_36 = 0;
        goto label_40;
        label_39:
        if(val_12.isRun == false)
        {
            goto label_41;
        }
        
        label_40:
        if(val_36 != 0)
        {
                UnityEngine.Vector3 val_16 = this.万东万丆专丌丕丐丗.position;
            UnityEngine.Vector3 val_18 = val_36.transform.position;
            val_37 = val_16.x;
            val_34 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_37, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        }
        else
        {
                val_34 = 1E+09f;
        }
        
        if(val_36 != 0)
        {
                val_37 = this.丁一世丈下上与丅七.detectRadius;
            var val_21 = (val_34 <= val_37) ? 1 : 0;
        }
        else
        {
                val_38 = 0;
        }
        
        UnityEngine.Vector3 val_22 = this.万东万丆专丌丕丐丗.position;
        val_32 = val_22.y;
        UnityEngine.Vector3 val_24 = this.丒一丄丗丞丗丄丐丂.transform.position;
        val_33 = val_24.x;
        float val_25 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_32, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_33, y = val_24.y, z = val_24.z});
        if(this.丕七三上上一丆丈世.万万一与丝业七专下 != false)
        {
                val_39 = 0;
        }
        else
        {
                var val_26 = (val_25 <= this.丁一世丈下上与丅七.detectRadius) ? 1 : 0;
        }
        
        if((val_26 & val_38) == 0)
        {
            goto label_65;
        }
        
        if(val_25 >= 0)
        {
            goto label_77;
        }
        
        val_36 = this.丒一丄丗丞丗丄丐丂;
        if(val_36 != null)
        {
            goto label_72;
        }
        
        goto label_68;
        label_65:
        if(val_26 == 0)
        {
            goto label_69;
        }
        
        val_31 = this.丒一丄丗丞丗丄丐丂.transform;
        if(val_38 == 0)
        {
            goto label_78;
        }
        
        label_77:
        if(val_36 != null)
        {
            goto label_72;
        }
        
        label_68:
        label_72:
        val_31 = val_36.transform;
        label_78:
        if(val_31 == 0)
        {
                return;
        }
        
        this.且三万丈丂丌业丒丟.SetTarget(与且且丑丌业丙与三:  val_31, 不专丁丌丌丌与丝世:  true);
        this.丒丐丒上丐万丛丕丟 = true;
        return;
        label_69:
        if(val_38 != 0)
        {
            goto label_77;
        }
        
        goto label_78;
        label_21:
    }
    public BotTrigger()
    {
        this.shouldDetectPlayer = true;
    }

}
