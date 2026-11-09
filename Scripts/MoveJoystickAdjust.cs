using UnityEngine;
internal sealed class MoveJoystickAdjust : ButtonJoystickAdjust
{
    // Fields
    private AutorunButtonAdjust 东丟丅丙一丒东世丏;
    
    // Methods
    internal void 且丅七丗丙万一三专(AutorunButtonAdjust 丟丒丞丐丐丘丒丄东)
    {
        this.东丟丅丙一丒东世丏 = 丟丒丞丐丐丘丒丄东;
    }
    protected override bool 丁丝丑丙三丘且业丄(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, out UnityEngine.Vector2[] 业东丛丂丏下丗丘且, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        float val_26;
        var val_27;
        var val_28;
        var val_29;
        val_26 = 丝丕丁丏丏上丅丏且.z;
        if(this.东丟丅丙一丒东世丏 != 0)
        {
                if(this.东丟丅丙一丒东世丏.gameObject.activeInHierarchy != false)
        {
                UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_9 = this.东丟丅丙一丒东世丏.transform.position;
            UnityEngine.Transform val_10 = this.东丟丅丙一丒东世丏.transform;
            UnityEngine.Vector3 val_11 = val_10.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            bool val_15 = val_10.丑且世丑七丁丂丌世(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = val_26}, 业东丛丂丏下丗丘且: out  UnityEngine.Vector2[] val_14 = 业东丛丂丏下丗丘且, 丒丐与丁丆丄丗丏丕:  (X23 + 112) & 1);
            val_27 = null;
            val_27 = null;
            UnityEngine.Vector3 val_18 = this.东丟丅丙一丒东世丏.transform.parent.lossyScale;
            val_26 = val_18.x;
            bool val_19 = 丒丐与丁丆丄丗丏丕;
            val_28 = val_10.丑且世丑七丁丂丌世(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, 且丛上丕业丂丒与一:  (float)AutorunButtonAdjust.专丛三且丛上丛业丈, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_26, y = val_18.y, z = val_18.z}, 业东丛丂丏下丗丘且: out  0, 丒丐与丁丆丄丗丏丕:  val_19);
            val_29 = val_28 & (val_10.万与丕丑丄丕专与丟(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = val_26}, 业东丛丂丏下丗丘且: out  val_14, 丒丐与丁丆丄丗丏丕:  val_19));
            return (bool)this.万与丕丑丄丕专与丟(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = val_26}, 业东丛丂丏下丗丘且: out  val_14, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
        }
        
        }
        
        val_29 = this;
        return (bool)this.万与丕丑丄丕专与丟(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = val_26}, 业东丛丂丏下丗丘且: out  val_14, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
    }
    protected override UnityEngine.Vector3 丑丛丂丏丅丅丕丕下(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 世专七丘万丌一丟丗, float 且丛上丕业丂丒与一, UnityEngine.Vector3 丝丕丁丏丏上丅丏且, bool 一世丅丕丑丈丕世丈, bool 丒丐与丁丆丄丗丏丕 = True)
    {
        float val_23;
        float val_24;
        float val_28;
        float val_29;
        float val_30;
        AutorunButtonAdjust val_31;
        var val_32;
        float val_33;
        val_23 = 业丒丝丗与丐丛丟丏.z;
        val_24 = 业丒丝丗与丐丛丟丏.x;
        UnityEngine.Vector3 val_3 = 丛丆丅丗丌七丆下丒(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_24, y = 业丒丝丗与丐丛丟丏.y, z = val_23}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = 世专七丘万丌一丟丗.x, y = 世专七丘万丌一丟丗.y, z = 世专七丘万丌一丟丗.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = 丝丕丁丏丏上丅丏且.x, y = 丝丕丁丏丏上丅丏且.y, z = 世专七丘万丌一丟丗.z}, 丒丐与丁丆丄丗丏丕:  (X22 + 112) & 1);
        val_28 = val_3.x;
        val_29 = val_3.y;
        val_30 = val_3.z;
        val_31 = this.东丟丅丙一丒东世丏;
        if(val_31 == 0)
        {
                return new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
        }
        
        val_31 = this.东丟丅丙一丒东世丏.gameObject;
        if(val_31.activeInHierarchy == false)
        {
                return new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
        }
        
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
        UnityEngine.Vector3 val_12 = this.东丟丅丙一丒东世丏.transform.position;
        UnityEngine.Transform val_13 = this.东丟丅丙一丒东世丏.transform;
        UnityEngine.Vector3 val_14 = val_13.position;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_24 = 0f;
        val_32 = null;
        val_23 = val_15.y;
        val_33 = val_15.x;
        UnityEngine.Vector3 val_18 = this.东丟丅丙一丒东世丏.transform.parent.lossyScale;
        UnityEngine.Vector3 val_20 = val_13.上上专丂丂世业业七(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {z = val_15.z}, 世专七丘万丌一丟丗:  new UnityEngine.Vector3() {x = val_24, y = 0f, z = 0f}, 且丛上丕业丂丒与一:  (float)AutorunButtonAdjust.专丛三且丛上丛业丈, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.z, z = val_10.y}, 丒丐与丁丆丄丗丏丕:  丒丐与丁丆丄丗丏丕);
        val_20.x = val_20.x - 0f;
        val_20.y = val_20.y - 0f;
        UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_20.x, y:  val_20.y);
        UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        val_22.x = val_28 + val_22.x;
        val_22.y = val_22.y + val_29;
        val_28 = val_28;
        val_29 = val_29;
        val_30 = val_30;
        return new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
    }
    internal void 与不丗上丈丛丈丘丁()
    {
        if(this.东丟丅丙一丒东世丏 == 0)
        {
                return;
        }
        
        if(this.东丟丅丙一丒东世丏.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.东丟丅丙一丒东世丏.Touch();
    }
    protected override void 丕下丗丆丄丘丆丈万(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        this.丕下丗丆丄丘丆丈万(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
        if(this.东丟丅丙一丒东世丏 == 0)
        {
                return;
        }
        
        if(this.东丟丅丙一丒东世丏.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_7 = this.transform.localPosition;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.东丟丅丙一丒东世丏.丒丆丙丆七且丟万且(丞且丅三三东不丄且:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
    }
    internal override void 丝丆且下丁三不丘世(float 与专丌丅丙上丌一丄)
    {
        this.丝丆且下丁三不丘世(与专丌丅丙上丌一丄:  与专丌丅丙上丌一丄);
        if(this.东丟丅丙一丒东世丏 == 0)
        {
                return;
        }
        
        if(this.东丟丅丙一丒东世丏.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.东丟丅丙一丒东世丏.世丏万丄丄七不专丆(与专丌丅丙上丌一丄:  与专丌丅丙上丌一丄);
    }
    public MoveJoystickAdjust()
    {
    
    }

}
