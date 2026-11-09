using UnityEngine;
public class ClickerDetector : MonoBehaviour
{
    // Fields
    internal static ClickerDetector 丄丘七三上丕世丞业;
    internal bool 丞七丛与丝下一一丆;
    internal ClickerDetectorSettings 与不丕丆丈不丙丟丛;
    internal float 丈丐世下丞与丂专丏;
    private float 丝丁上丅丕丟丗七丐;
    private System.Collections.Generic.List<int> 与业世万丌与丝丏丟;
    private ClickerDetector.专丅丟丏丑上下丂丒 丁丐万下东丈丘万专;
    private string 丒丝丄下丅业丙丅丙;
    private float 丑下世丈丈丌东专丝;
    private float 丗丏万丂下丗专丛丕;
    private double 丘丁丐上丐三丏万丅;
    private UnityEngine.Vector3 下七丐上专丆丄丙丏;
    private double 专丏丌世不世丝丂丈;
    private float 丗丟专丕丈丘丗丝业;
    private int 上丑丂且不业丒七丙;
    private System.Collections.Generic.List<int> 丂丂丛丟丏且不下下;
    
    // Methods
    internal static ClickerDetector.上丅丁不丒一丌丙东 丗丁万丈丅丕丄丙丂(GadgetCategory 七丆丒与丗丌丄且丂)
    {
        if(七丆丒与丗丌丄且丂 == 12500)
        {
                return 6;
        }
        
        if(七丆丒与丗丌丄且丂 != 13000)
        {
                return (上丅丁不丒一丌丙东)(七丆丒与丗丌丄且丂 == 13500) ? 5 : 8;
        }
        
        return 7;
    }
    private void Awake()
    {
        this.丛不丄与丅丘丙丁与();
    }
    private void Start()
    {
        var val_10;
        ClickerDetectorSettings val_11;
        val_10 = null;
        val_10 = null;
        ClickerDetector.丄丘七三上丕世丞业 = this;
        if(ExperienceController.丞丞丘业东丙丏七丌() < 6)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = this.与不丕丆丈不丙丟丛;
            if(val_11 != null)
        {
                val_11 = this.与不丕丆丈不丙丟丛.enable;
            if(val_11 != false)
        {
                if((((GameConnect.丑丌丛丈丅丅与不业() != 0) && (GameConnect.丑丌丛丈丅丅与不业() != 2)) && (GameConnect.丑丌丛丈丅丅与不业() != 1)) && (GameConnect.丑丌丛丈丅丅与不业() != 4))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 5)
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 33)
        {
            goto label_27;
        }
        
        }
        
        }
        
            val_11 = true;
        }
        
        }
        
        }
        
        label_30:
        this.丞七丛与丝下一一丆 = val_11;
        return;
        label_27:
        var val_9 = (GameConnect.丑丌丛丈丅丅与不业() == 29) ? 1 : 0;
        goto label_30;
    }
    private void 丌丙丟丄七丛七业丗(ClickerDetector.丛丁东丒丟业丛丈且 丂丐丌丏丒丏与且丁, float 丏丒丑丛丌丞不丙不 = 1)
    {
        string val_3;
        float val_4;
        float val_4 = 丏丒丑丛丌丞不丙不;
        val_3 = this;
        this.丒丝丄下丅业丙丅丙 = System.String.Format(format:  "{0}{1}({2}), ", arg0:  this.丒丝丄下丅业丙丅丙, arg1:  丂丐丌丏丒丏与且丁, arg2:  val_4);
        if(丂丐丌丏丒丏与且丁 <= 3)
        {
                var val_3 = 106024176 + (丂丐丌丏丒丏与且丁) << 2;
            val_3 = val_3 + 106024176;
        }
        else
        {
                val_4 = 0f;
             =  * val_4;
            val_4 = this.丈丐世下丞与丂专丏 + ;
            this.丈丐世下丞与丂专丏 = val_4;
            if(val_4 <= this.与不丕丆丈不丙丟丛.maxRating)
        {
                return;
        }
        
            val_3 = this.丒丝丄下丅业丙丅丙;
            GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  val_3);
        }
    
    }
    internal void 不世上丐丑世下丁业(ClickerDetector.上丅丁不丒一丌丙东 丟丒丞丐丐丘丒丄东)
    {
        ClickerDetectorSettings val_15;
        var val_16;
        var val_17;
        if(this.丞七丛与丝下一一丆 == false)
        {
                return;
        }
        
        val_15 = this.与不丕丆丈不丙丟丛;
        if(this.与不丕丆丈不丙丟丛.enablePattern == false)
        {
                return;
        }
        
        this.与业世万丌与丝丏丟.Add(item:  丟丒丞丐丐丘丒丄东);
        if(this.与业世万丌与丝丏丟.Count > this.与不丕丆丈不丙丟丛.maxLenListButtonsPress)
        {
                this.与业世万丌与丝丏丟.RemoveAt(index:  0);
        }
        
        val_15 = this.与不丕丆丈不丙丟丛;
        if(this.与业世万丌与丝丏丟.Count <= (this.与不丕丆丈不丙丟丛.lengthPatternButtonPress << 1))
        {
                return;
        }
        
        val_16 = 0;
        goto label_12;
        label_22:
        var val_16 = 0;
        label_19:
        if(val_16 >= this.与不丕丆丈不丙丟丛.lengthPatternButtonPress)
        {
            goto label_14;
        }
        
        val_16 = val_16 + 1;
        if((this.与业世万丌与丝丏丟.Item[val_16 + val_16]) == (this.与业世万丌与丝丏丟.Item[val_16 + (this.与业世万丌与丝丏丟.Count - this.与不丕丆丈不丙丟丛.lengthPatternButtonPress)]))
        {
            goto label_19;
        }
        
        val_16 = 1;
        label_12:
        val_15 = this.与不丕丆丈不丙丟丛;
        int val_17 = this.与不丕丆丈不丙丟丛.lengthPatternButtonPress;
        val_17 = this.与业世万丌与丝丏丟.Count - val_17;
        if(val_16 < val_17)
        {
            goto label_22;
        }
        
        return;
        label_14:
        System.Collections.Generic.List<System.Int32> val_10 = new System.Collections.Generic.List<System.Int32>();
        val_17 = 0;
        goto label_23;
        label_30:
        if((val_10.Contains(item:  this.与业世万丌与丝丏丟.Item[0])) != true)
        {
                val_10.Add(item:  this.与业世万丌与丝丏丟.Item[0]);
        }
        
        val_17 = 1;
        label_23:
        if(val_17 < this.与不丕丆丈不丙丟丛.lengthPatternButtonPress)
        {
            goto label_30;
        }
        
        this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  0, 丏丒丑丛丌丞不丙不:  (float)System.Math.Min(val1:  3, val2:  val_10.Count));
        this.与业世万丌与丝丏丟.Clear();
    }
    internal void 丘丆与与且专与与丅(ClickerDetector.专丅丟丏丑上下丂丒 丙丆万丙丟且业不丆)
    {
        if(this.丞七丛与丝下一一丆 == false)
        {
                return;
        }
        
        this.丁丐万下东丈丘万专 = 丙丆万丙丟且业不丆;
    }
    private void Update()
    {
        int val_29;
        var val_30;
        var val_31;
        float val_32;
        float val_33;
        var val_34;
        float val_35;
        float val_36;
        var val_37;
        float val_38;
        var val_39;
        float val_40;
        int val_41;
        var val_42;
        if(this.丞七丛与丝下一一丆 == false)
        {
            goto label_17;
        }
        
        if(this.与不丕丆丈不丙丟丛.enableDistance != true)
        {
                if(this.与不丕丆丈不丙丟丛.enableDistanceLoop == false)
        {
            goto label_17;
        }
        
        }
        
        val_29 = 1152921505286238208;
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_17;
        }
        
        val_31 = null;
        val_31 = null;
        UnityEngine.Vector3 val_2 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_32 = -1000f;
        if(val_2.y <= val_32)
        {
            goto label_17;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        val_3 = this.丑下世丈丈丌东专丝 + val_3;
        this.丑下世丈丈丌东专丝 = val_3;
        val_33 = this.丗丏万丂下丗专丛丕 + UnityEngine.Time.deltaTime;
        this.丗丏万丂下丗专丛丕 = val_33;
        val_34 = null;
        val_34 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_33 = this.下七丐上专丆丄丙丏;
            val_35 = this.丑下世丈丈丌东专丝;
            val_36 = this.丗丏万丂下丗专丛丕;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_33, y = val_35, z = val_36}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) != false)
        {
                val_37 = null;
            val_37 = null;
            UnityEngine.Vector3 val_8 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            float val_28 = val_8.x;
            UnityEngine.Vector3 val_9 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
            val_28 = val_28 - this.下七丐上专丆丄丙丏;
            float val_11 = val_28 * val_28;
            val_11 = val_11 + ((val_9.z - val_9.x) * (val_9.z - val_9.x));
            if(val_11 >= _TYPE_MAX_)
        {
                val_38 = (double)val_11;
        }
        
            val_36 = this.丘丁丐上丐三丏万丅;
            val_35 = val_38 + this.专丏丌世不世丝丂丈;
            val_33 = val_38 + val_36;
            this.专丏丌世不世丝丂丈 = val_35;
            this.丘丁丐上丐三丏万丅 = val_33;
        }
        
        }
        
        val_39 = null;
        val_39 = null;
        UnityEngine.Vector3 val_13 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_40 = this.丗丏万丂下丗专丛丕;
        this.下七丐上专丆丄丙丏 = val_13;
        mem[1152921525751309932] = val_13.y;
        mem[1152921525751309936] = val_13.z;
        val_32 = this.与不丕丆丈不丙丟丛.loopDistanceTime;
        if(val_40 <= val_32)
        {
            goto label_54;
        }
        
        val_40 = this.丘丁丐上丐三丏万丅 / (double)this.丗丏万丂下丗专丛丕;
        if((val_40 < 0) && (this.与不丕丆丈不丙丟丛.enableDistanceLoop != false))
        {
                this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  1, 丏丒丑丛丌丞不丙不:  (val_40 < 0) ? 2f : 1f);
        }
        
        val_32 = (double)this.与不丕丆丈不丙丟丛.minSpeedInvertCoef;
        if((val_40 > val_32) && (this.与不丕丆丈不丙丟丛.enableDistanceLoop != false))
        {
                val_32 = -1f;
            this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  1, 丏丒丑丛丌丞不丙不:  val_32);
        }
        
        this.丗丏万丂下丗专丛丕 = 0f;
        this.丘丁丐上丐三丏万丅 = 0;
        goto label_54;
        label_17:
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
        this.下七丐上专丆丄丙丏 = val_15;
        mem[1152921525751309932] = val_15.y;
        mem[1152921525751309936] = val_15.z;
        label_54:
        if(this.丞七丛与丝下一一丆 == false)
        {
                return;
        }
        
        if(this.与不丕丆丈不丙丟丛.enableIntensity == false)
        {
                return;
        }
        
        val_40 = this.丗丟专丕丈丘丗丝业 + UnityEngine.Time.deltaTime;
        this.丗丟专丕丈丘丗丝业 = val_40;
        if(val_40 <= this.与不丕丆丈不丙丟丛.timeDetectIntensityPressButtons)
        {
            goto label_61;
        }
        
        if(this.丂丂丛丟丏且不下下.Count >= 1)
        {
                if(this.上丑丂且不业丒七丙 >= 11)
        {
            goto label_64;
        }
        
        }
        
        label_82:
        if(this.丂丂丛丟丏且不下下 == null)
        {
            goto label_65;
        }
        
        if(0 == 0)
        {
            goto label_66;
        }
        
        label_68:
        this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  3, 丏丒丑丛丌丞不丙不:  (float)this.丂丂丛丟丏且不下下.Count);
        goto label_67;
        label_65:
        if(0 != 0)
        {
            goto label_68;
        }
        
        label_66:
        this.丂丂丛丟丏且不下下.Clear();
        label_67:
        val_29 = this.上丑丂且不业丒七丙;
        this.丂丂丛丟丏且不下下.Add(item:  val_29);
        this.丗丟专丕丈丘丗丝业 = 0f;
        this.上丑丂且不业丒七丙 = 0;
        label_61:
        int val_19 = UnityEngine.Input.touchCount;
        if(val_19 < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Touch val_20 = UnityEngine.Input.GetTouch(index:  0);
            if(专三三与三且一且一() == 0)
        {
                int val_29 = this.上丑丂且不业丒七丙;
            val_29 = val_29 + 1;
            this.上丑丂且不业丒七丙 = val_29;
        }
        
            val_29 = 0 + 1;
        }
        while(val_19 != val_29);
        
        return;
        label_64:
        val_41 = this.上丑丂且不业丒七丙;
        int val_23 = (System.Linq.Enumerable.Last<System.Int32>(source:  this.丂丂丛丟丏且不下下)) - this.上丑丂且不业丒七丙;
        float val_25 = ((float)(this.上丑丂且不业丒七丙 < 0) ? (-val_23) : (val_23)) / (float);
        if(val_25 < 0)
        {
                var val_26 = (this.上丑丂且不业丒七丙 > this.与不丕丆丈不丙丟丛.minCountPressButtonsForDetect) ? 1 : 0;
        }
        else
        {
                val_42 = 0;
        }
        
        var val_27 = (val_42 != 0) ? 1 : 0;
        if(val_25 <= this.与不丕丆丈不丙丟丛.thresholdInvertDetectIntensityPressButtonst)
        {
            goto label_82;
        }
        
        this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  3, 丏丒丑丛丌丞不丙不:  -3f);
        goto label_82;
    }
    internal void 三一上专三丟下下丘()
    {
        if(this.丞七丛与丝下一一丆 == false)
        {
                return;
        }
        
        if(this.丑下世丈丈丌东专丝 < 0)
        {
                return;
        }
        
        if(this.与不丕丆丈不丙丟丛.enableDistance == false)
        {
                return;
        }
        
        double val_1 = this.专丏丌世不世丝丂丈 / (double)this.丑下世丈丈丌东专丝;
        if(val_1 < 0)
        {
                this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  2, 丏丒丑丛丌丞不丙不:  (val_1 < 0) ? 2f : 1f);
        }
        
        if(val_1 > (double)this.与不丕丆丈不丙丟丛.minSpeedInvertCoef)
        {
                this.丌丙丟丄七丛七业丗(丂丐丌丏丒丏与且丁:  2, 丏丒丑丛丌丞不丙不:  -1f);
        }
        
        this.专丏丌世不世丝丂丈 = 0;
        this.丑下世丈丈丌东专丝 = 0f;
    }
    private void OnDestroy()
    {
        null = null;
        ClickerDetector.丄丘七三上丕世丞业 = 0;
    }
    internal void 丛不丄与丅丘丙丁与()
    {
        string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  95);
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.与不丕丆丈不丙丟丛 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
    }
    public ClickerDetector()
    {
        this.丝丁上丅丕丟丗七丐 = 1f;
        this.与业世万丌与丝丏丟 = new System.Collections.Generic.List<System.Int32>();
        this.丒丝丄下丅业丙丅丙 = "Clicker: ";
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.下七丐上专丆丄丙丏 = val_2;
        mem[1152921525751906556] = val_2.y;
        mem[1152921525751906560] = val_2.z;
        this.丂丂丛丟丏且不下下 = new System.Collections.Generic.List<System.Int32>();
    }
    private static ClickerDetector()
    {
    
    }

}
