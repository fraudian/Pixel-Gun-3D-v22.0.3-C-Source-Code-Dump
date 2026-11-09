using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassGuiHandler : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private static PGCompany.BattlePass.BattlePassGuiHandler <不丁丄七丛不丆丁丕>k__BackingField;
        private static System.Action 丛丄业丘不丆丄三丞;
        private BattlePassRootUI 且丂丄丞且丗业下业;
        private static System.Action 丈丈下丒世东东丝丟;
        private static bool <丛世业丁与丗上丌三>k__BackingField;
        private BattlePassRootUI.丝丂丅丝丟丞丐上与 与东七丐丝丒丈不丄;
        
        // Properties
        internal static PGCompany.BattlePass.BattlePassGuiHandler 丆丕丝丒不丙且丐丗 { get; set; }
        internal static bool 丅业东万丌丕上丌丄 { get; }
        internal static bool 丈丛丙丂万万丘一丆 { get; set; }
        
        // Methods
        internal static PGCompany.BattlePass.BattlePassGuiHandler 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.BattlePass.BattlePassGuiHandler)PGCompany.BattlePass.BattlePassGuiHandler.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.BattlePass.BattlePassGuiHandler 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.BattlePass.BattlePassGuiHandler.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞 != 1152921505682247688);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞 != 1152921505682247688);
        
        }
        internal static bool 丈丐丞丐上丑且丕万()
        {
            PGCompany.BattlePass.BattlePassGuiHandler val_7 = PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世();
            if(val_7 == 0)
            {
                    return false;
            }
            
            PGCompany.BattlePass.BattlePassGuiHandler val_3 = PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世();
            val_7 = val_3.且丂丄丞且丗业下业;
            if(val_7 == 0)
            {
                    return false;
            }
            
            PGCompany.BattlePass.BattlePassGuiHandler val_5 = PGCompany.BattlePass.BattlePassGuiHandler.丑七不且上丗丁一世();
            UnityEngine.GameObject val_6 = val_5.且丂丄丞且丗业下业.gameObject;
            if(val_6 != null)
            {
                    return val_6.activeSelf;
            }
            
            return val_6.activeSelf;
        }
        public override void Show()
        {
            PGCompany.BattlePass.BattlePassGuiHandler val_26;
            System.Action<ArmoryInfoScreenController> val_27;
            BattlePassRootUI val_28;
            var val_29;
            var val_31;
            System.Action<Rilisoft.ItemViewer> val_33;
            val_26 = this;
            this.Show();
            PGCompany.BattlePass.BattlePassGuiHandler.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            val_27 = 1152921504848912384;
            if(this.且丂丄丞且丗业下业 != 0)
            {
                    if((System.String.op_Inequality(a:  this.且丂丄丞且丗业下业.丒三丝一上丙专丗丒, b:  val_2.丕世丝七世与三丞一())) != false)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.且丂丄丞且丗业下业.gameObject);
                this.且丂丄丞且丗业下业 = 0;
            }
            
            }
            
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            if(this.且丂丄丞且丗业下业 == 0)
            {
                    UnityEngine.GameObject val_11 = Rilisoft.Singleton<BattlePassController>.Instance.丟丒且丙丝三世三丝(业丑丐丞丅丌丈丐丆:  val_2.丕世丝七世与三丞一());
                if(val_11 != 0)
            {
                    int val_14 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
                UnityEngine.GameObject val_15 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_11, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                BattlePassRootUI val_16 = val_15.GetComponent<BattlePassRootUI>();
                this.且丂丄丞且丗业下业 = val_16;
                if(val_16 == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_15);
            }
            
            }
            
            }
            
            val_28 = this.且丂丄丞且丗业下业;
            if(val_28 != 0)
            {
                    val_29 = null;
                val_29 = null;
                val_27 = BattlePassGuiHandler.<>c.<>9__10_0;
                if(val_27 == null)
            {
                    System.Action<ArmoryInfoScreenController> val_21 = null;
                val_27 = val_21;
                val_21 = new System.Action<ArmoryInfoScreenController>(object:  BattlePassGuiHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BattlePassGuiHandler.<>c::丁业丁丈下七丄东丐(ArmoryInfoScreenController 三丟东丕丄丄下下丑));
                BattlePassGuiHandler.<>c.<>9__10_0 = val_27;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<ArmoryInfoScreenController>(丌丛丏业世丄丞三丌:  this.GetComponentsInChildren<ArmoryInfoScreenController>(includeInactive:  true), 七丐丅专且专七三丆:  val_21);
                val_31 = null;
                val_31 = null;
                val_33 = BattlePassGuiHandler.<>c.<>9__10_1;
                if(val_33 == null)
            {
                    System.Action<Rilisoft.ItemViewer> val_22 = null;
                val_33 = val_22;
                val_22 = new System.Action<Rilisoft.ItemViewer>(object:  BattlePassGuiHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BattlePassGuiHandler.<>c::丟丆丕不七且丁丐丈(Rilisoft.ItemViewer 三丟东丕丄丄下下丑));
                BattlePassGuiHandler.<>c.<>9__10_1 = val_33;
            }
            
                丞东丑专丛丆丄丝世.且三丁且与丆一世下<Rilisoft.ItemViewer>(丌丛丏业世丄丞三丌:  this.GetComponentsInChildren<Rilisoft.ItemViewer>(includeInactive:  true), 七丐丅专且专七三丆:  val_22);
                val_28 = this.且丂丄丞且丗业下业;
                this.且丂丄丞且丗业下业.丒三丝一上丙专丗丒 = val_2.丕世丝七世与三丞一();
                this.且丂丄丞且丗业下业.gameObject.SetActive(value:  true);
            }
            
            val_26 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世();
            val_26.一东丁世丆与丆万丌(丈七丄丆丅丂东丄一:  4);
        }
        public override void Hide()
        {
            var val_3;
            System.Action val_4;
            this.Hide();
            if(this.且丂丄丞且丗业下业 != 0)
            {
                    this.且丂丄丞且丗业下业.gameObject.SetActive(value:  false);
            }
            
            val_3 = null;
            val_3 = null;
            val_4 = PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞;
            if(val_4 == null)
            {
                    return;
            }
            
            val_4 = PGCompany.BattlePass.BattlePassGuiHandler.丛丄业丘不丆丄三丞;
            if(val_4 == null)
            {
                    val_4 = 0;
            }
            
            val_4.Invoke();
        }
        protected override void OnDestroy()
        {
            if(this.且丂丄丞且丗业下业 != 0)
            {
                    this.且丂丄丞且丗业下业.gameObject.SetActive(value:  false);
            }
            
            this.OnDestroy();
        }
        public void Back()
        {
            this.HideSelf();
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        }
        internal static void 且与丌一东不丝丛业()
        {
            var val_1;
            System.Action val_2;
            val_1 = null;
            val_1 = null;
            val_2 = PGCompany.BattlePass.BattlePassGuiHandler.丈丈下丒世东东丝丟;
            if(val_2 != null)
            {
                    val_2 = PGCompany.BattlePass.BattlePassGuiHandler.丈丈下丒世东东丝丟;
                PGCompany.BattlePass.BattlePassGuiHandler.丟不丛世下东且丗丈(丙业与丙丗丝不丈东:  val_2);
                val_1 = null;
            }
            
            val_1 = null;
            PGCompany.BattlePass.BattlePassGuiHandler.丈丈下丒世东东丝丟 = 0;
        }
        internal static void 丙丂丂丕专丞世下与(丙且上东下丏丏丟下 丑丝丏丂且不下一东, CategoryNames 七丆丒与丗丌丄且丂, FilterMaps 专丆丌丛东一不丑丙)
        {
            BattlePassGuiHandler.丞丆丌万丛不且七丐 val_1 = new BattlePassGuiHandler.丞丆丌万丛不且七丐();
            if(val_1 != null)
            {
                    .丑丝丏丂且不下一东 = 丑丝丏丂且不下一东;
                .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
            }
            else
            {
                    mem[16] = 丑丝丏丂且不下一东;
                mem[24] = 七丆丒与丗丌丄且丂;
            }
            
            .专丆丌丛东一不丑丙 = 专丆丌丛东一不丑丙;
            System.Action val_2 = new System.Action(object:  val_1, method:  System.Void BattlePassGuiHandler.丞丆丌万丛不且七丐::三丌丈上丙丆丅与丅());
            if((丏丟丏丅丙业丆下专.一丈丒丑一丏丗丛丈(丟万上三丙下丞丝丐:  val_2)) != false)
            {
                    return;
            }
            
            val_2.Invoke();
        }
        internal static bool 丞丝下丑丁世丈丙上()
        {
            null = null;
            return (bool)PGCompany.BattlePass.BattlePassGuiHandler.<丛世业丁与丗上丌三>k__BackingField;
        }
        private static void 丄世上丏丄丝七丗下(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.BattlePass.BattlePassGuiHandler.<丛世业丁与丗上丌三>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void TurnOn()
        {
            null = null;
            BattlePassRootUI.丂丑丌且丄丞丝七上 = this.与东七丐丝丒丈不丄;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.且丂丄丞且丗业下业, 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            null = null;
            this.与东七丐丝丒丈不丄 = BattlePassRootUI.丂丑丌且丄丞丝七上;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.且丂丄丞且丗业下业, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return false;
        }
        public float GetDelayTurnOff()
        {
            return 0f;
        }
        public BattlePassGuiHandler()
        {
        
        }
        private static BattlePassGuiHandler()
        {
        
        }
    
    }

}
