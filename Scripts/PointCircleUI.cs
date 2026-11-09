using UnityEngine;
internal class PointCircleUI : MonoBehaviour
{
    // Fields
    private static readonly UnityEngine.Color 万丈丒丆不丁丛丌不;
    private static readonly UnityEngine.Color 丟丑丄下专丌东丝丗;
    private static readonly UnityEngine.Color 丌世丑丟业七下丝丁;
    private static readonly UnityEngine.Color 专七不丕上丘丟丗丝;
    private static readonly UnityEngine.Color 三东丕上且丕丐丒一;
    private UITexture ring;
    private UITexture innerCircle;
    private UITexture halfCirlce;
    private UILabel nameLabel;
    private float 丂三丟丂丈丐丆丗丟;
    private const float 丄一丆与业丑丆丅丟 = 0.5;
    
    // Methods
    internal void 丐专丒丁专丌丑丘丙(bool 丙东丏丕丞丁丈丈万, bool 专七世丕且丐丙丕东, bool 七丟丁下且不丟丌丏, bool 下丑业丕丌丐三丒丙, bool 下且下丄专下丝丞丟, bool 丆丅丐三一不丕世三, float 丑丁丐一三东丟业丝, bool 上不世不七丒上不东 = False, bool 丟下丑三丒与丘世东 = False)
    {
        UITexture val_5;
        UITexture val_6;
        var val_7;
        var val_8;
        float val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_21;
        var val_22;
        float val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        UnityEngine.Color val_29;
        float val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        float val_50;
        val_5 = 下丑业丕丌丐三丒丙;
        this.ring.fillAmount = 丑丁丐一三东丟业丝;
        val_6 = this.ring;
        val_7 = null;
        if(丆丅丐三一不丕世三 == false)
        {
            goto label_2;
        }
        
        if(七丟丁下且不丟丌丏 == false)
        {
            goto label_3;
        }
        
        val_8 = null;
        val_9 = 1152921505209512000;
        val_10 = 1152921505209512004;
        val_11 = 1152921505209512008;
        val_12 = 1152921505209512012;
        goto label_6;
        label_2:
        if(val_5 == false)
        {
            goto label_7;
        }
        
        val_13 = null;
        val_15 = 1152921505209511940;
        val_16 = 1152921505209511944;
        val_17 = 1152921505209511948;
        goto label_10;
        label_3:
        val_18 = null;
        val_9 = 1152921505209511984;
        val_10 = 1152921505209511988;
        val_11 = 1152921505209511992;
        val_12 = 1152921505209511996;
        label_6:
        val_19 = mem[1152921505209511988];
        val_6.color = new UnityEngine.Color() {r = val_9, g = val_19, b = mem[1152921505209511992], a = mem[1152921505209511996]};
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_16;
        }
        
        val_21 = null;
        val_6 = this.ring;
        if(val_5 == false)
        {
            goto label_17;
        }
        
        val_22 = null;
        val_24 = 1152921505209511940;
        val_25 = 1152921505209511944;
        val_26 = 1152921505209511948;
        goto label_20;
        label_7:
        val_14 = 1152921505209511952;
        val_15 = 1152921505209511956;
        val_16 = 1152921505209511960;
        val_17 = 1152921505209511964;
        label_10:
        val_6.color = new UnityEngine.Color() {r = val_14, g = mem[1152921505209511956], b = mem[1152921505209511960], a = mem[1152921505209511964]};
        if(丟下丑三丒与丘世东 == false)
        {
            goto label_24;
        }
        
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = this.丂三丟丂丈丐丆丗丟 + val_2;
        this.丂三丟丂丈丐丆丗丟 = val_2;
        if(val_2 > 0.5f)
        {
                this.丂三丟丂丈丐丆丗丟 = val_2;
        }
        
        val_27 = null;
        if(val_2 <= 0.25f)
        {
            goto label_26;
        }
        
        val_28 = null;
        val_29 = PointCircleUI.丌世丑丟业七下丝丁;
        if(this.innerCircle != null)
        {
            goto label_30;
        }
        
        goto label_30;
        label_24:
        val_31 = null;
        if(丙东丏丕丞丁丈丈万 == false)
        {
            goto label_31;
        }
        
        if(val_5 == false)
        {
            goto label_32;
        }
        
        val_32 = null;
        val_34 = 1152921505209511940;
        val_35 = 1152921505209511944;
        val_36 = 1152921505209511948;
        goto label_59;
        label_17:
        val_37 = null;
        val_23 = 1152921505209511952;
        val_24 = 1152921505209511956;
        val_25 = 1152921505209511960;
        val_26 = 1152921505209511964;
        label_20:
        val_19 = mem[1152921505209511956];
        val_6.color = new UnityEngine.Color() {r = val_23, g = val_19, b = mem[1152921505209511960], a = mem[1152921505209511964]};
        label_16:
        val_38 = null;
        val_5 = this.innerCircle;
        if((丙东丏丕丞丁丈丈万 == false) || (七丟丁下且不丟丌丏 == true))
        {
            goto label_40;
        }
        
        val_39 = null;
        val_5.color = new UnityEngine.Color() {r = PointCircleUI.丟丑丄下专丌东丝丗, g = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_14, b = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_18, a = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_1C};
        val_29 = PointCircleUI.丄一丆与业丑丆丅丟;
        if(this.halfCirlce != null)
        {
            goto label_51;
        }
        
        label_52:
        label_51:
        this.halfCirlce.color = new UnityEngine.Color() {r = val_29, g = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_4, b = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_8, a = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_C};
        val_40 = this.halfCirlce.gameObject;
        val_41 = 1;
        goto label_47;
        label_40:
        val_42 = null;
        val_5.color = new UnityEngine.Color() {r = PointCircleUI.丄一丆与业丑丆丅丟, g = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_4, b = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_8, a = PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_C};
        if(this.halfCirlce != null)
        {
            goto label_51;
        }
        
        goto label_52;
        label_26:
        if(val_5 == false)
        {
            goto label_53;
        }
        
        val_43 = null;
        val_45 = 1152921505209511940;
        val_46 = 1152921505209511944;
        val_47 = 1152921505209511948;
        goto label_56;
        label_31:
        val_48 = null;
        val_33 = 1152921505209511968;
        val_34 = 1152921505209511972;
        val_35 = 1152921505209511976;
        val_36 = 1152921505209511980;
        goto label_59;
        label_32:
        val_49 = null;
        val_33 = 1152921505209511952;
        val_34 = 1152921505209511956;
        val_35 = 1152921505209511960;
        val_36 = 1152921505209511964;
        label_59:
        val_29 = mem[1152921505209511960];
        val_50 = mem[1152921505209511956];
        val_30 = mem[1152921505209511964];
        if(this.innerCircle != null)
        {
            goto label_63;
        }
        
        goto label_63;
        label_53:
        val_44 = 1152921505209511952;
        val_45 = 1152921505209511956;
        val_46 = 1152921505209511960;
        val_47 = 1152921505209511964;
        label_56:
        val_29 = mem[1152921505209511960];
        val_50 = mem[1152921505209511956];
        val_30 = mem[1152921505209511964];
        label_63:
        label_30:
        this.innerCircle.color = new UnityEngine.Color() {r = val_44, g = val_50, b = val_29, a = val_30};
        val_40 = this.halfCirlce.gameObject;
        val_41 = 0;
        label_47:
        val_40.SetActive(value:  false);
    }
    internal void 东与丂丏丐丞三丘丁(string 丙业与丙丗丝不丈东)
    {
        this.nameLabel.text = 丙业与丙丗丝不丈东;
    }
    public PointCircleUI()
    {
    
    }
    private static PointCircleUI()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.blue;
        PointCircleUI.丄一丆与业丑丆丅丟 = val_1.r;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_4 = val_1.g;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_8 = val_1.b;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_C = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        PointCircleUI.丟丑丄下专丌东丝丗 = val_2.r;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_14 = val_2.g;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_18 = val_2.b;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_1C = val_2.a;
        UnityEngine.Color val_3 = UnityEngine.Color.gray;
        PointCircleUI.丌世丑丟业七下丝丁 = val_3.r;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_24 = val_3.g;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_28 = val_3.b;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_2C = val_3.a;
        PointCircleUI.专七不丕上丘丟丗丝 = 0;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_34 = 0;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_3C = 0;
        PointCircleUI.三东丕上且丕丐丒一 = 0;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_44 = 0;
        PointCircleUI.丄一丆与业丑丆丅丟.__il2cppRuntimeField_4C = 0;
    }

}
