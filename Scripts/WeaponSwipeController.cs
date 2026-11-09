using UnityEngine;
public sealed class WeaponSwipeController : MonoBehaviour
{
    // Fields
    private UIWrapContent 上丑丈且丘丙不与丏;
    private UIScrollView 业丘丘丕专丞丅丈丙;
    private Player_move_c 三丑丏世丂丆丕丈专;
    private MyCenterOnChild 丑七丅丄与丅上丄丂;
    private bool 丐东丄专万业丄丈丞;
    
    // Methods
    private void Start()
    {
        上丄丂丛专下丟万下 val_7;
        this.上丑丈且丘丙不与丏 = this.GetComponentInChildren<UIWrapContent>();
        this.丑七丅丄与丅上丄丂 = this.GetComponentInChildren<MyCenterOnChild>();
        this.业丘丘丕专丞丅丈丙 = this.GetComponent<UIScrollView>();
        val_7 = System.Delegate.Combine(a:  this.丑七丅丄与丅上丄丂.onFinished, b:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void WeaponSwipeController::丐与业丐丏丌丑丘丆()));
        if(this.丑七丅丄与丅上丄丂 == null)
        {
            goto label_2;
        }
        
        if(val_7 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_7 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_7 = 0;
        }
        
        label_6:
        this.丑七丅丄与丅上丄丂.onFinished = val_7;
        this.UpdateContent();
    }
    private void 丁专丏业丒丑丄上东()
    {
        this.UpdateContent();
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.不丞业丌上丗且世一(七且丆丞丌丘下世丑:  0.5f));
    }
    private System.Collections.IEnumerator 不丞业丌上丗且世一(float 七且丆丞丌丘下世丑)
    {
        WeaponSwipeController.与一丏世丐丅丂丂丆 val_1 = new WeaponSwipeController.与一丏世丐丅丂丂丆();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丐与业丐丏丌丑丘丆()
    {
        var val_23;
        var val_24;
        Player_move_c val_25;
        var val_26;
        var val_27;
        var val_28;
        int val_29;
        var val_30;
        int val_4 = 0;
        if(this.丐东丄专万业丄丈丞 != false)
        {
                return;
        }
        
        if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  this.丑七丅丄与丅上丄丂.centeredObject.name.Replace(oldValue:  "preview_", newValue:  System.String.alignConst), 丙业与丙丗丝不丈东: out  val_4)) == false)
        {
            goto label_7;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.三丑丏世丂丆丕丈专)) == true)
        {
            goto label_10;
        }
        
        val_23 = null;
        val_23 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_13;
        }
        
        val_24 = null;
        val_24 = null;
        WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC
        goto label_17;
        label_7:
        if(UnityEngine.Debug.isDebugBuild == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "HandleCenteringFinished: error parse");
        return;
        label_13:
        SkinName val_9 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "Player").GetComponent<SkinName>();
        val_25 = val_9.playerMoveC;
        label_17:
        this.三丑丏世丂丆丕丈专 = mem[val_9.playerMoveC];
        label_10:
        val_26 = null;
        val_26 = null;
        if((-1) == WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万())
        {
                return;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) != true)
        {
                val_27 = null;
            val_27 = null;
            if((TrainingController.万丑下丗业且万丄下.TryGetValue(key:  "SwipeWeapon", value: out  val_4)) != false)
        {
                丘丌丒丑一七丁丑一 val_14 = TrainingController.丁丑七与丙丐丘丌下();
            if(val_14 == 0)
        {
                TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  val_14);
        }
        
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        int val_16 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count;
        WeaponManager.丟丗丄业丘丗业丗七.丏丁丑万丐丄世丌丒(丙业与丙丗丝不丈东:  (-1) - (((-1) / val_16) * val_16));
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
                val_29 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万();
        }
        else
        {
                val_29 = 0.丈丄丙丙丈丗业丆万();
        }
        
        WeaponManager.丟丗丄业丘丗业丗七.丘丄万上丐上丞上丆(丞世不丒下上上丝丑:  val_29);
        if(this.三丑丏世丂丆丕丈专 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        this.三丑丏世丂丆丕丈专.专丐丏丒丘丟丁与丟(丞世不丒下上上丝丑:  WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万(), 丟业下东与东专专业:  false);
    }
    private void OnDestroy()
    {
        System.Delegate val_4 = System.Delegate.Remove(source:  this.丑七丅丄与丅上丄丂.onFinished, value:  new SpringPanel.上丄丂丛专下丟万下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void WeaponSwipeController::丐与业丐丏丌丑丘丆()));
        if(this.丑七丅丄与丅上丄丂 == null)
        {
            goto label_2;
        }
        
        if(val_4 != null)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(val_4 == null)
        {
            goto label_6;
        }
        
        label_3:
        if(null != null)
        {
                val_4 = 0;
        }
        
        label_6:
        this.丑七丅丄与丅上丄丂.onFinished = val_4;
    }
    public void UpdateContent()
    {
        var val_5;
        int val_21;
        var val_63;
        var val_65;
        var val_67;
        var val_68;
        var val_69;
        var val_71;
        UnityEngine.Object val_72;
        WeaponSwipeController val_73;
        UnityEngine.Transform val_74;
        var val_75;
        var val_76;
        int val_77;
        int val_78;
        UnityEngine.GameObject val_79;
        var val_80;
        UnityEngine.Transform val_81;
        var val_84;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        val_63 = null;
        val_63 = null;
        List.Enumerator<T> val_3 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().GetEnumerator();
        label_9:
        if((1763250976 & 1) == 0)
        {
            goto label_5;
        }
        
        val_1.Add(item:  val_5.丐丏七丌丕丗业且上().三与丛丑且丐丈业丌() + "_InGamePreview");
        goto label_9;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        System.Collections.Generic.List<UnityEngine.Texture> val_10 = new System.Collections.Generic.List<UnityEngine.Texture>();
        val_65 = 0;
        goto label_17;
        label_25:
        T val_65 = this.GetComponentsInChildren<UITexture>()[0];
        if((UnityEngine.Object.op_Implicit(exists:  val_65)) != false)
        {
                val_10.Add(item:  val_65);
        }
        
        val_65 = 1;
        label_17:
        if(val_65 < val_9.Length)
        {
            goto label_25;
        }
        
        System.Collections.Generic.List<System.String> val_12 = new System.Collections.Generic.List<System.String>();
        List.Enumerator<T> val_13 = val_1.GetEnumerator();
        val_67 = 0;
        val_68 = 0;
        goto label_44;
        label_47:
        string val_14 = val_5.丐丏七丌丕丗业且上();
        List.Enumerator<T> val_15 = val_10.GetEnumerator();
        label_32:
        if((1763250912 & 1) == 0)
        {
            goto label_29;
        }
        
        if((val_5.丐丏七丌丕丗业且上().name.Equals(value:  val_14)) == false)
        {
            goto label_32;
        }
        
        val_69 = 1;
        goto label_34;
        label_29:
        var val_66 = 1;
        val_66 = val_66 + 1;
        val_69 = 0;
        mem2[0] = 243;
        label_34:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_68 = val_66;
        if((val_68 == 1) || ((1763250784 + ((1 + 1)) << 2) != 243))
        {
            goto label_39;
        }
        
        var val_67 = 0;
        val_67 = val_67 ^ (val_68 >> 31);
        val_68 = val_68 + val_67;
        if(( & 1) != 0)
        {
            goto label_44;
        }
        
        label_46:
        val_12.Add(item:  val_14);
        goto label_44;
        label_39:
        if( == 0)
        {
            goto label_43;
        }
        
        val_67 = 0;
        val_68 = 0;
        if(( & 1) != 0)
        {
            goto label_44;
        }
        
        goto label_46;
        label_43:
        val_67 = 0;
        if(( & 1) == 0)
        {
            goto label_46;
        }
        
        label_44:
        if((1763250944 & 1) != 0)
        {
            goto label_47;
        }
        
        var val_69 = val_68;
        val_69 = val_69 + 1;
        mem2[0] = 280;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        var val_71 = val_69;
        if((val_71 == 1) || ((1763250784 + ((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1)) << 2) != 280))
        {
            goto label_54;
        }
        
        var val_70 = 0;
        val_70 = val_70 ^ (val_71 >> 31);
        val_71 = val_71 + val_70;
        if(val_12 != null)
        {
            goto label_58;
        }
        
        goto label_56;
        label_54:
        if( != 0)
        {
                val_68 = 0;
        }
        
        if(val_12 != null)
        {
            goto label_58;
        }
        
        label_56:
        label_58:
        List.Enumerator<T> val_19 = val_12.GetEnumerator();
        label_69:
        if((1763250944 & 1) == 0)
        {
            goto label_59;
        }
        
        string val_22 = val_21.丐丏七丌丕丗业且上();
        val_71 = null;
        val_71 = null;
        val_72 = UnityEngine.Resources.Load(path:  WeaponManager.与丗万与专丑一且丘 + "/"("/") + val_22);
        val_72 = 0;
        val_72.name = val_22;
        if(val_72 == 0)
        {
            goto label_69;
        }
        
        val_10.Add(item:  val_72);
        goto label_69;
        label_59:
        var val_72 = val_71;
        val_72 = val_72 + 1;
        mem2[0] = 380;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        var val_74 = val_72;
        if((val_74 != 1) && ((1763250784 + ((((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1) + (0 ^ ((int)(((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1)) >> 31)) + 1)) << 2) == 380))
        {
                var val_73 = 0;
            val_73 = this;
            val_73 = val_73 ^ (val_74 >> 31);
            val_74 = val_74 + val_73;
        }
        else
        {
                val_73 = this;
            if( != 0)
        {
                val_68 = 0;
        }
        
        }
        
        val_74 = this.transform.GetChild(index:  0);
        int val_28 = val_74.childCount;
        if(val_1 != null)
        {
                val_75 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
            val_76 = val_1.Count;
        }
        else
        {
                val_76 = val_1.Count;
            val_75 = public System.Int32 System.Collections.Generic.List<System.String>::get_Count();
        }
        
        val_77 = val_1.Count;
        if(val_28 <= val_76)
        {
            goto label_86;
        }
        
        if(val_77 >= val_28)
        {
            goto label_95;
        }
        
        do
        {
            UnityEngine.Transform val_32 = val_74.GetChild(index:  val_77);
            if(val_32 != null)
        {
                val_32.parent = 0;
        }
        else
        {
                0.parent = 0;
        }
        
            UnityEngine.Object.Destroy(obj:  val_32.gameObject);
            val_77 = val_77 + 1;
        }
        while(val_28 != val_77);
        
        goto label_95;
        label_86:
        if(val_28 >= val_77)
        {
            goto label_95;
        }
        
        val_78 = val_28;
        goto label_98;
        label_110:
        if(val_78 < val_28)
        {
                val_78 = val_78 + 1;
        }
        else
        {
                UnityEngine.Object val_34 = UnityEngine.Resources.Load(path:  "WeaponPreviewPrefab");
            if(val_34 != null)
        {
                val_34 = (null == null) ? (val_34) : 0;
        }
        else
        {
                val_79 = 0;
        }
        
            UnityEngine.GameObject val_35 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_79);
            val_35.transform.parent = val_74;
            val_78 = val_78 + 1;
            string val_37 = "preview_" + val_78;
            if(val_35 != null)
        {
                val_35.name = val_37;
        }
        else
        {
                0.name = val_37;
        }
        
            val_77 = val_35.transform;
            val_21 = 0;
            val_77.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        
        label_98:
        if(val_78 < val_1.Count)
        {
            goto label_110;
        }
        
        label_95:
        val_80 = 0;
        goto label_111;
        label_136:
        val_77 = val_74.GetChild(index:  0);
        if((UnityEngine.Object.op_Implicit(exists:  val_77)) == false)
        {
            goto label_134;
        }
        
        List.Enumerator<T> val_42 = val_10.GetEnumerator();
        label_121:
        if((1763250912 & 1) == 0)
        {
            goto label_117;
        }
        
        if((val_21.丐丏七丌丕丗业且上().name.Equals(value:  val_1.Item[0])) == false)
        {
            goto label_121;
        }
        
        val_77 = val_77.GetComponent<UITexture>();
        label_117:
        var val_75 = val_74;
        val_75 = val_75 + 1;
        mem2[0] = 691;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_77 = val_75;
        if((val_77 != 1) && ((1763250784 + ((((((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1) + (0 ^ ((int)(((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1)) >> 31)) + 1) + (0 ^ ((int)(((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1) + (0 ^ ((int)(((1 +) << 2) == 691))
        {
                var val_76 = 0;
            val_76 = val_76 ^ (val_77 >> 31);
            val_77 = val_77 + val_76;
        }
        else
        {
                if(null != null)
        {
                val_68 = 0;
        }
        
        }
        
        label_134:
        val_80 = 1;
        label_111:
        if(val_80 < val_1.Count)
        {
            goto label_136;
        }
        
        val_81 = mem[1152921540729848528].transform.GetChild(index:  0);
        System.Collections.IEnumerator val_52 = mem[1152921540729848504].transform.GetEnumerator();
        label_161:
        var val_78 = 0;
        val_78 = val_78 + 1;
        if(val_52.MoveNext() == false)
        {
            goto label_147;
        }
        
        var val_79 = 0;
        val_79 = val_79 + 1;
        val_74 = val_52.Current;
        val_74 = 0;
        val_84 = null;
        val_84 = null;
        val_21 = WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万() + 1;
        val_77 = "preview_" + val_21;
        if((val_74.gameObject.name.Equals(value:  val_77)) == false)
        {
            goto label_161;
        }
        
        var val_80 = val_77;
        val_80 = val_80 + 1;
        mem2[0] = 855;
        val_81 = val_74;
        goto label_163;
        label_147:
        var val_81 = val_80;
        val_81 = val_81 + 1;
        mem2[0] = 855;
        label_163:
        if(val_52 != null)
        {
                var val_82 = 0;
            val_82 = val_82 + 1;
            val_52.Dispose();
        }
        
        if(val_81 == 1)
        {
            goto label_181;
        }
        
        if(( == false) || ((1763250784 + (((((((((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1) + (0 ^ ((int)(((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1)) >> 31)) + 1) + (0 ^ ((int)(((((1 + 1) + (0 ^ ((int)(1 + 1)) >> 31)) + 1) + (0 ^ ((int)((() << 2) == 855))
        {
            goto label_186;
        }
        
        label_185:
        label_186:
        mem[1152921540729848528].CenterOn(丞下万上三丘上与专:  val_81);
        return;
        label_181:
        if( == true)
        {
            goto label_185;
        }
        
        goto label_186;
    }
    public WeaponSwipeController()
    {
    
    }

}
