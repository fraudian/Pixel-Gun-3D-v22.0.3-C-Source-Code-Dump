using UnityEngine;
internal sealed class FortFieldTurretInfoManagerUI : PGBehaviour
{
    // Fields
    private bool 丈一丛丙下丟专三丄;
    private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>> 丞不与丘世丝且丈丁;
    private string 丅上丂丏丟丞东丛一;
    private float zoomDelta;
    private bool 下丁丞丝丛一丘丐丒;
    
    // Methods
    private void Start()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        bool val_3 = System.String.op_Equality(a:  val_1.m_Handle.name, b:  "FortFieldBuild");
        this.丈一丛丙下丟专三丄 = val_3;
        if(val_3 == false)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().丂丑丏上丑丕丏与丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldTurretInfoManagerUI::下丝丈丌丄丌丌七丄()));
        丂丘丗丗与且丌丁丙.七丈七万丂丒丐丐丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldTurretInfoManagerUI::下丝丈丌丄丌丌七丄()));
        this.下丝丈丌丄丌丌七丄();
        this.下丁丞丝丛一丘丐丒 = true;
    }
    private void OnDestroy()
    {
        丂丘丗丗与且丌丁丙.丐丟丂丁下丐丑丈丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldTurretInfoManagerUI::下丝丈丌丄丌丌七丄()));
        if(this.丈一丛丙下丟专三丄 == false)
        {
                return;
        }
        
        if(ClanFieldBuildController.丑七不且上丗丁一世() == 0)
        {
                return;
        }
        
        ClanFieldBuildController.丑七不且上丗丁一世().三丛丗丘丞丕丒丝七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldTurretInfoManagerUI::下丝丈丌丄丌丌七丄()));
    }
    private void LateUpdate()
    {
        if(GestureCamera.ZoomValue01 <= this.zoomDelta)
        {
                if(PGCompany.ClanStoreMainUI.丛世丛与丌不丈丐丐() == false)
        {
            goto label_4;
        }
        
        }
        
        this.七丗七业丙丆不丐专();
        return;
        label_4:
        this.七丂丕丒丌上下一上();
    }
    private void 七丗七业丙丆不丐专()
    {
        if(this.下丁丞丝丛一丘丐丒 == false)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.丞不与丘世丝且丈丁.GetEnumerator();
        label_9:
        if((1828536784 & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        if(val_2._value._obj == 0)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2._value._obj, 丏业丟一东丂东丘丛:  false);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丁丞丝丛一丘丐丒 = false;
    }
    private void 七丂丕丒丌上下一上()
    {
        if(this.下丁丞丝丛一丘丐丒 == true)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.丞不与丘世丝且丈丁.GetEnumerator();
        label_9:
        if((1828656976 & 1) == 0)
        {
            goto label_3;
        }
        
        ConfiguredValueTaskAwaiter val_2 = 0.GetAwaiter();
        if(val_2._value._obj == 0)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2._value._obj, 丏业丟一东丂东丘丛:  true);
        goto label_9;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丁丞丝丛一丘丐丒 = true;
    }
    private void 下丝丈丌丄丌丌七丄()
    {
        var val_20;
        var val_41;
        var val_42;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>> val_44;
        var val_45;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        int val_51;
        val_41 = this;
        val_42 = 0;
        goto label_1;
        label_24:
        System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_1 = X21.Item[0];
        System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_4 = this.丞不与丘世丝且丈丁.Item[0];
        if(val_1.Value.丐丏七丌丕丗业且上() != 0)
        {
            goto label_6;
        }
        
        if(val_4.Value == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_6 = this.丞不与丘世丝且丈丁.Item[0];
        goto label_11;
        label_6:
        if(val_6.Value != 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_8 = this.丞不与丘世丝且丈丁.Item[0];
        if(val_8.Value.丐丏七丌丕丗业且上() == 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_11 = this.丞不与丘世丝且丈丁.Item[0];
        label_11:
        UnityEngine.Object.DestroyImmediate(obj:  val_11.Value.丐丏七丌丕丗业且上().gameObject);
        label_18:
        val_42 = 1;
        label_1:
        val_44 = this.丞不与丘世丝且丈丁;
        if(val_42 < this.丞不与丘世丝且丈丁.Count)
        {
            goto label_24;
        }
        
        val_45 = null;
        val_45 = null;
        if((FortFieldTurretInfoManagerUI.<>c.<>9__10_0) == null)
        {
            goto label_27;
        }
        
        label_76:
        int val_15 = val_44.RemoveAll(match:  FortFieldTurretInfoManagerUI.<>c.<>9__10_0);
        val_47 = 1152921505143320576;
        ClanFieldBuildController val_16 = ClanFieldBuildController.丑七不且上丗丁一世();
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_18 = val_16.专丁丑世业丌丏丁丛.Keys.GetEnumerator();
        val_48 = 1152921536500438624;
        val_49 = 1152921536500439648;
        goto label_43;
        label_71:
        val_44 = val_20.丐丏七丌丕丗业且上();
        new FortFieldTurretInfoManagerUI.下丌丛三下专丘丐丕() = new System.Object();
        if(val_44 != 0)
        {
                SquareFieldSelectableCell val_24 = val_44.GetComponent<SquareFieldSelectableCell>();
            if(new FortFieldTurretInfoManagerUI.下丌丛三下专丘丐丕() != null)
        {
                val_50 = new FortFieldTurretInfoManagerUI.下丌丛三下专丘丐丕();
            .下丅丙一丂丗丅丝七 = val_24;
        }
        else
        {
                mem[16] = val_24;
            val_50 = 16;
        }
        
            val_44 = mem[val_24 + 144];
            val_44 = val_24 + 144;
            if((val_24 + 144 + 64) == 1)
        {
                System.Predicate<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>> val_25 = new System.Predicate<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>>(object:  new FortFieldTurretInfoManagerUI.下丌丛三下专丘丐丕(), method:  System.Boolean FortFieldTurretInfoManagerUI.下丌丛三下专丘丐丕::丄丙丘丗世丁丂与业(System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> 三丟东丕丄丄下下丑));
            val_51 = this.丞不与丘世丝且丈丁.FindIndex(match:  null);
            if(val_51 == 1)
        {
                val_20 = 0;
            MoonSharp.Interpreter.TablePair val_31 = new MoonSharp.Interpreter.TablePair(key:  mem[16], val:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丅上丂丏丟丞东丛一), parent:  this.丌丟丄业且三丛丕丄()).GetComponent<FortFieldTurretInfoUI>());
            this.丞不与丘世丝且丈丁.Add(item:  new System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>() {Value = val_31.key});
            val_51 = this.丞不与丘世丝且丈丁.Count - 1;
        }
        
            System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_33 = this.丞不与丘世丝且丈丁.Item[val_51];
            val_33.Value.丄丅一万丐七三丘世(七丆丟丗世丟且丒丆:  val_24 + 144.Power, 东丝丅专丝丈一丘下:  ClanFieldBuildController.丑七不且上丗丁一世().世丗丄丄丛丕业丕丅(与不丕丆丈不丙丟丛:  val_24 + 144));
            System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_37 = this.丞不与丘世丝且丈丁.Item[val_51];
            val_37.Value.丗世七丕东且业业万(丈下丑丆上丏丗丈专:  val_24 + 144.ItemRarity);
            System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> val_39 = this.丞不与丘世丝且丈丁.Item[val_51];
            val_44;
            val_47 = 1152921505143320576;
            val_48 = 1152921536500438624;
            val_49 = 1152921536500439648;
        }
        
        }
        
        label_43:
        if((1828916400 & 1) != 0)
        {
            goto label_71;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return;
        label_27:
        FortFieldTurretInfoManagerUI.<>c.<>9__10_0 = new System.Predicate<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>>(object:  FortFieldTurretInfoManagerUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortFieldTurretInfoManagerUI.<>c::丙丐下不丕专丁与丆(System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI> 三丟东丕丄丄下下丑));
        if(val_44 != null)
        {
            goto label_76;
        }
        
        goto label_76;
    }
    public FortFieldTurretInfoManagerUI()
    {
        this.丞不与丘世丝且丈丁 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<SquareFieldSelectableCell, FortFieldTurretInfoUI>>();
        this.zoomDelta = 0.35f;
        this.丅上丂丏丟丞东丛一 = "FortField/Prefabs/FortBuildTurretInfoUI";
    }

}
