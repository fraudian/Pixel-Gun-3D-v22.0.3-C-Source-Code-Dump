using UnityEngine;
internal sealed class FortTrapBarrel : FortTrap
{
    // Fields
    private Rilisoft.丏丏专丙世丝万丅且 _poisenType;
    private float _percentDamage;
    private int _ticks;
    private string _nameExplosion;
    
    // Methods
    public override void DetectedTarget()
    {
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        this.业丂丛丟上且丂东丂(丛业专丘丂丅丗丝丛:  1000f, 丞丗且下世丐业丌丙:  0, 丐丟丘世丁三丕专专:  0);
    }
    private void 丁丛丏上一业七上丁()
    {
        if(GameConnect.七丂万专且丏丘一丙() != false)
        {
                this.上丈丘且丕丕专东丌();
            return;
        }
        
        this.三丏丂丞丒丆丙专丅();
    }
    public override void StartDeactivate()
    {
        if(true != 0)
        {
                return;
        }
        
        mem[1152921537222774100] = 1;
        if(137105408 != 0)
        {
                SetActive(value:  false);
        }
        
        this.Invoke(methodName:  "DeactivateDelayed", time:  null);
        this.丁丛丏上一业七上丁();
        UnityEngine.GameObject val_3 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  this._nameExplosion));
        if(val_3 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_3.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private void 三丏丂丞丒丆丙专丅()
    {
        var val_2;
        var val_3;
        var val_34;
        var val_35;
        string val_37;
        var val_39;
        var val_40;
        float val_42;
        float val_43;
        float val_44;
        float val_45;
        var val_50;
        var val_51;
        val_35 = null;
        val_35 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_37 = 1152921525761786080;
        label_8:
        if(((-1743637824) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if((X21 + 496.viewID) != val_2)
        {
            goto label_8;
        }
        
        goto label_9;
        label_4:
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_7 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  true, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        val_39 = 1152921504686346240;
        val_40 = 1152921504691191808;
        goto label_46;
        label_62:
        var val_36 = 0;
        val_36 = val_36 + 1;
        T val_9 = val_7.Current;
        UnityEngine.Vector3 val_10 = val_9.position;
        val_37 = this.transform;
        UnityEngine.Vector3 val_12 = val_37.position;
        val_42 = val_12.x;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_42, y = val_12.y, z = val_12.z});
        val_43 = 0f;
        if(val_13.x == 0)
        {
            goto label_27;
        }
        
        val_44 = val_13.x.七与万且专丁丝丘丈();
        if(val_13.x == 0)
        {
            goto label_29;
        }
        
        val_43 = val_13.x.七与万且专丁丝丘丈();
        goto label_29;
        label_27:
        val_44 = 0f;
        label_29:
        val_45 = val_44 * val_43;
        if(val_13.x < 0)
        {
                丅丙上七上一丐不下 val_16 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_9);
            if(val_16 != null)
        {
                UnityEngine.Vector3 val_19 = this.transform.position;
            val_43 = val_19.x;
            val_42 = val_19.z;
            val_37 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_45 = this.下与丗丒丐三丕丘丈();
            val_16.ApplyDamage(丞丈专下丈专业三丞:  val_45, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_43, y = val_19.y, z = val_42}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  val_37, 丒丈丐丐丗丐专丈丏:  0);
        }
        
            bool val_23 = UnityEngine.Object.op_Inequality(x:  0, y:  0);
            if((val_23 != false) && (val_23 != false))
        {
                val_37 = val_23.丆丘丒东且丂与丂丑();
            if((val_37.Equals(value:  "")) != false)
        {
                float val_27 = this.三丟丅不丅丅业丛丁();
            val_43 = val_27;
            string val_29 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
            val_27 = this.下与丗丒丐三丕丘丈() * val_43;
            val_37 = 28563616;
            val_40 = val_40;
            val_34 = 81;
            val_39 = val_39;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_3 = 0;
            val_2 = 0;
            val_37.一且专下丆业且万一(丞下万上三丘上与专:  val_16.transform.gameObject, 万东丏丌不七东丘万:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
        }
        
        }
        
        }
        
        label_46:
        var val_39 = 0;
        val_39 = val_39 + 1;
        if(val_7.MoveNext() == true)
        {
            goto label_62;
        }
        
        val_50 = 0;
        val_51 = 0;
        mem[81] = 359;
        if(val_7 == null)
        {
            
        }
        else
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_7.Dispose();
        }
        
        if( != 1)
        {
                if( == false)
        {
                return;
        }
        
            if(val_34 == 359)
        {
                return;
        }
        
            return;
        }
        
        if( == true)
        {
                return;
        }
    
    }
    private void 上丈丘且丕丕专东丌()
    {
        var val_29;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        var val_36;
        var val_39;
        var val_40;
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_2 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        val_29 = 1152921505117388800;
        goto label_36;
        label_51:
        var val_30 = 0;
        val_30 = val_30 + 1;
        T val_4 = val_2.Current;
        UnityEngine.Vector3 val_5 = val_4.position;
        UnityEngine.Vector3 val_7 = this.transform.position;
        val_31 = val_7.x;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_31, y = val_7.y, z = val_7.z});
        val_32 = 0f;
        if(val_8.x == 0)
        {
            goto label_12;
        }
        
        val_33 = val_8.x.七与万且专丁丝丘丈();
        if(val_8.x == 0)
        {
            goto label_14;
        }
        
        val_32 = val_8.x.七与万且专丁丝丘丈();
        goto label_14;
        label_12:
        val_33 = 0f;
        label_14:
        val_34 = val_33 * val_32;
        if(val_8.x < 0)
        {
                丅丙上七上一丐不下 val_11 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_4);
            if(val_11 != null)
        {
                UnityEngine.Vector3 val_14 = this.transform.position;
            val_32 = val_14.x;
            val_31 = val_14.z;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_34 = this.下与丗丒丐三丕丘丈();
            val_11.ApplyDamage(丞丈专下丈专业三丞:  val_34, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_32, y = val_14.y, z = val_31}, 丐丟丘世丁三丕专专:  20, 东丏业丞丞业下丄世:  1, 丝三丛且丘不丌丙下:  丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject), 丒丈丐丐丗丐专丈丏:  0);
        }
        
            if((this._poisenType != 0) && (val_11 != null))
        {
                val_36 = null;
            val_36 = null;
            if(val_11 == typeof(Player_move_c).__il2cppRuntimeField_600)
        {
                float val_19 = this.下与丗丒丐三丕丘丈();
            string val_21 = 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
            val_19 = val_19 * this._percentDamage;
            var val_32 = 0;
            val_32 = val_32 + 1;
            UnityEngine.Vector3 val_26 = this.transform.position;
            val_32 = val_26.y;
            this._poisenType.丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_11.transform.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_26.x, y = val_32, z = val_26.z}, 丂丐丄丁丆与丈丂上:  new 丛上一丂不业丒丄丏() {丈丒丄丝丐专丐丙丌 = 0f, 丂丐丈丕丞下丁下丘 = 0f, 丌丛丑三丆丘万丘丛 = false});
            val_29 = 1152921505117388800;
        }
        
        }
        
        }
        
        label_36:
        var val_33 = 0;
        val_33 = val_33 + 1;
        if(val_2.MoveNext() == true)
        {
            goto label_51;
        }
        
        val_39 = 0;
        val_40 = 0;
        if(val_2 == null)
        {
            
        }
        else
        {
                var val_34 = 0;
            val_34 = val_34 + 1;
            val_2.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public override bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        var val_4;
        var val_5;
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_3;
        }
        
        val_4 = null;
        val_4 = null;
        if(SiegeController.三三万丆下一丗万丛.attackTeam != 专丞上七七且丝七丗.丘丑丅三丆丑丌且丝())
        {
            goto label_8;
        }
        
        label_3:
        val_5 = 1;
        return (bool)val_5;
        label_8:
        val_5 = 0;
        return (bool)val_5;
    }
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        Rilisoft.丏丏专丙世丝万丅且 val_6;
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        if(this == null)
        {
                return;
        }
        
        string val_1 = this.丆丘丒东且丂与丂丑();
        if((System.String.op_Equality(a:  val_1, b:  "Poison Area")) == false)
        {
            goto label_2;
        }
        
        val_6 = 1;
        goto label_3;
        label_2:
        if((System.String.op_Equality(a:  val_1, b:  "Fire Area")) == false)
        {
            goto label_4;
        }
        
        val_6 = 2;
        label_3:
        this._poisenType = val_6;
        this._percentDamage = this.三丟丅不丅丅业丛丁();
        return;
        label_4:
        if(val_1 == null)
        {
                return;
        }
        
        if(val_1.Length != 0)
        {
                return;
        }
        
        this._poisenType = 0;
    }
    public FortTrapBarrel()
    {
        this._percentDamage = 0.1f;
        this._ticks = 3;
        mem[1152921537223604928] = 1073741824;
        mem[1152921537223604952] = 1073741824;
        this._nameExplosion = "Explosion47";
        this = new FortEquipObject();
    }

}
