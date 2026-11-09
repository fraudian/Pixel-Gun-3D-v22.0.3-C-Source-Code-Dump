using UnityEngine;

namespace PGCompany
{
    public class LoadoutsUi : PGBehaviour
    {
        // Fields
        private const string 专业下三业丕丑丙丙 = "NguiWindows/LoadoutUI/Loadout_MainUI";
        internal static PGCompany.LoadoutsUi 丆丕丝丒不丙且丐丗;
        public UnityEngine.Color activeTabTint;
        public UnityEngine.Color lockedTabTint;
        public UnityEngine.Color defaultTabTint;
        public UnityEngine.Color activeTabNameTint;
        public UnityEngine.Color selectedTabNameTint;
        public UnityEngine.Color defaultTabNameTint;
        public UnityEngine.Transform transformForInfoWindows;
        private UnityEngine.GameObject _hintsPanel;
        private UnityEngine.GameObject _selectLoadoutButton;
        private UnityEngine.GameObject _alreadySelectedLoadoutButton;
        private SelectableButtonController _tabsSelectorController;
        private UnityEngine.GameObject _simpleTabExample;
        private UnityEngine.GameObject _lockedTabExample;
        private WidgetLayout _tabsLayout;
        private PGCompany.ItemCellOfLoadoutsUi _primaryWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _backupWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _meleeWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _specialWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _sniperWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _premiumWeaponCell;
        private PGCompany.ItemCellOfLoadoutsUi _skinCell;
        private PGCompany.ItemCellOfLoadoutsUi _armorCell;
        private PGCompany.ItemCellOfLoadoutsUi _hatCell;
        private PGCompany.ItemCellOfLoadoutsUi _maskCell;
        private PGCompany.ItemCellOfLoadoutsUi _capeCell;
        private PGCompany.ItemCellOfLoadoutsUi _bootsCell;
        private PGCompany.ItemCellOfLoadoutsUi _petCell;
        private PGCompany.ItemCellOfLoadoutsUi _vehicleCell;
        private PGCompany.ItemCellOfLoadoutsUi _throwingGadgetCell;
        private PGCompany.ItemCellOfLoadoutsUi _toolGadgetCell;
        private UIInput _nameInput;
        private System.Collections.Generic.List<UnityEngine.GameObject> _categoryLabels;
        private UIToggle _additionalInfoToggle;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private int 不专丙丌一丆且丝丛;
        private bool 丞七丗一丌七丞丘东;
        private System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi> 丌丅东丑业且丐与丛;
        
        // Methods
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丈东丘丏与丌东东下)
        {
            UnityEngine.GameObject val_5;
            UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "NguiWindows/LoadoutUI/Loadout_MainUI");
            if(val_1 != null)
            {
                    val_1 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            UnityEngine.GameObject val_2 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_5, 丈东丘丏与丌东东下:  丈东丘丏与丌东东下, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_2 == 0)
            {
                    return;
            }
            
            PGCompany.LoadoutsUi.丆丕丝丒不丙且丐丗 = val_2.GetComponent<PGCompany.LoadoutsUi>();
        }
        public void U_Close()
        {
            this.丗丟万丂丘丈专丄丂();
        }
        public void U_ShowHintPanel()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hintsPanel, 丏业丟一东丂东丘丛:  true);
        }
        public void U_HideHintPanel()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hintsPanel, 丏业丟一东丂东丘丛:  false);
        }
        public void U_SubmitNameInput()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丙丕丂东丕丒丛与丗(丒丘丏上丙丟丑丕丈:  this._nameInput.value, 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this.丅丈丟丙东不丝丞丗();
        }
        public void U_SelectLoadoutAsCurrent()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  79);
            Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丒东丗丕万三不七丁(与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            this.丅丈丟丙东不丝丞丗();
        }
        public void U_ToggleAdditionalInfo()
        {
            bool val_2 = this._additionalInfoToggle.value;
            this.丞七丗一丌七丞丘东 = val_2;
            this.丘丅丟丑万丑丂丑丞(丑丒业丘丑东丕世丅:  val_2);
        }
        private void Awake()
        {
            this._tabsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
            不丌丂丁丄一与丆丙.丐丛丛丆万下丒一丂(丙丒七丄上与丏丙丙:  this._tabsLayout.transform);
            this._tabsSelectorController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.LoadoutsUi::丈丐下丝丂不丞且丒()));
            this._nameInput.defaultText = System.String.alignConst;
            this.丞七丗一丌七丞丘东 = false;
            System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi> val_3 = new System.Collections.Generic.List<PGCompany.ItemCellOfLoadoutsUi>();
            val_3.Add(item:  this._primaryWeaponCell);
            val_3.Add(item:  this._backupWeaponCell);
            val_3.Add(item:  this._meleeWeaponCell);
            val_3.Add(item:  this._specialWeaponCell);
            val_3.Add(item:  this._sniperWeaponCell);
            val_3.Add(item:  this._premiumWeaponCell);
            val_3.Add(item:  this._skinCell);
            val_3.Add(item:  this._armorCell);
            val_3.Add(item:  this._hatCell);
            val_3.Add(item:  this._maskCell);
            val_3.Add(item:  this._capeCell);
            val_3.Add(item:  this._bootsCell);
            val_3.Add(item:  this._petCell);
            val_3.Add(item:  this._vehicleCell);
            val_3.Add(item:  this._throwingGadgetCell);
            val_3.Add(item:  this._toolGadgetCell);
            this.丌丅东丑业且丐与丛 = val_3;
        }
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.LoadoutsUi::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  71);
        }
        private void 丝东丐丝东三丈世丝()
        {
            if(this._hintsPanel.activeInHierarchy != false)
            {
                    this.U_HideHintPanel();
                return;
            }
            
            this.丗丟万丂丘丈专丄丂();
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void 丈丐下丝丂不丞且丒()
        {
            var val_3 = 0;
            if( == 0)
            {
                    return;
            }
            
            this.不专丙丌一丆且丝丛 = (SelectableButton.__il2cppRuntimeField_typeHierarchy + -9223372036775542784) + -8 == 1152921505255460864 ? this._tabsSelectorController.selectedButton : 0 + 112;
            this.丅丈丟丙东不丝丞丗();
        }
        private void Start()
        {
            this.世上专丁丏一万丏丄();
            this.万东丝丘且上丘丁且();
            this.丅丈丟丙东不丝丞丗();
            this.丘丐丏三上丆世丟丝();
        }
        private void 世上专丁丏一万丏丄()
        {
            int val_11;
            WidgetLayout val_12;
            val_11 = 0;
            goto label_1;
            label_16:
            UnityEngine.GameObject val_2 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._simpleTabExample, 丈东丘丏与丌东东下:  this._tabsLayout.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  true);
            val_12 = this._tabsLayout;
            val_12.AddElement(丅丆东丏丙丝丅丆丟:  val_2);
            SelectableButtonLoadoutTab val_3 = val_2.GetComponent<SelectableButtonLoadoutTab>();
            if(val_3 != 0)
            {
                    val_12 = this._tabsSelectorController;
                if(val_3 != null)
            {
                    mem2[0] = val_12;
            }
            else
            {
                    mem[24] = val_12;
            }
            
                val_3.万丁丙七丙丙一丅不 = val_11;
            }
            
            val_11 = 1;
            label_1:
            if(val_11 < Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丁丁丆丈丂上丙丞丏())
            {
                goto label_16;
            }
            
            if(Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丁丁丆丈丂上丙丞丏() == 2)
            {
                    UnityEngine.GameObject val_10 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._lockedTabExample, 丈东丘丏与丌东东下:  this._tabsLayout.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
                val_12 = this._tabsLayout;
                val_12.AddElement(丅丆东丏丙丝丅丆丟:  val_10);
            }
            
            this._tabsLayout.Reposition();
        }
        private void 丅丈丟丙东不丝丞丗()
        {
            this.丟不丁万丏丒丐丂下();
            this.三丁丏东丂丏丙丟丌();
            this.丈业丏三丞下丈业丏();
            this.不丝丞上专七丞七丅();
        }
        private void 万东丝丘且上丘丁且()
        {
            var val_15;
            var val_16;
            int val_17;
            val_15 = this;
            val_16 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().万业七丟丏丄不七三();
            if(this._tabsSelectorController.allButtons.Count > val_16.一丗专丅丐丝业万丒())
            {
                    val_17 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().万业七丟丏丄不七三().一丗专丅丐丝业万丒();
                this.不专丙丌一丆且丝丛 = val_17;
                if(this._tabsSelectorController == null)
            {
                    val_17 = this.不专丙丌一丆且丝丛;
            }
            
                SelectableButton val_8 = this._tabsSelectorController.allButtons.Item[val_17];
                val_15 = ???;
                val_16 = ???;
            }
            else
            {
                    mem2[0] = 0;
                val_15 + 200.下丁万万丅丆东不不();
            }
        
        }
        private void 丟不丁万丏丒丐丂下()
        {
            object val_22;
            var val_23;
            string val_24;
            UIWidget val_27;
            var val_28;
            val_22 = 0;
            goto label_10;
            label_38:
            SelectableButton val_1 = this._tabsSelectorController.allButtons.Item[0];
            val_23 = 0;
            if( != 0)
            {
                goto label_9;
            }
            
            val_22 = 1;
            goto label_10;
            label_9:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 96, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 112).东丙上东业丆不丟丘());
            int val_7 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七();
            val_24 = mem[(SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 112];
            val_24 = (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 112;
            if(val_24 != this.不专丙丌一丆且丝丛)
            {
                    if(val_24 != Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七())
            {
                goto label_24;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 88, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.activeTabTint, g = V9.16B, b = V10.16B, a = V8.16B});
            val_27 = mem[(SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 96];
            val_27 = (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 96;
            goto label_31;
            label_24:
            val_27 = (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 96;
            label_31:
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  null, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.defaultTabNameTint, g = V9.16B, b = V10.16B, a = V8.16B});
            val_22 = 1;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  (SelectableButton.__il2cppRuntimeField_typeHierarchy + (SelectableButtonLoadoutTab.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_1 : 0 + 104, 丕丗丘丑丛与丑业丒:  val_22);
            label_10:
            if(val_22 < this._tabsSelectorController.allButtons.Count)
            {
                goto label_38;
            }
            
            val_28 = 0;
            goto label_46;
            label_61:
            if((this._tabsLayout.widgets.Item[0].GetComponent<PGCompany.LockedTabOfLoadoutsUi>()) == 0)
            {
                    val_28 = 1;
            }
            else
            {
                    val_24 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  专且丝丄丙丗丈不丞.丌丄丟东丂下业丕东(丑丅世丐丒丏丐三丅:  (float)Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丙丑丟业丈丐丈丑且()));
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12.levelLabel, 丕丗丘丑丛与丑业丒:  val_24);
                val_28 = 1;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_12.tabNumber, 丕丗丘丑丛与丑业丒:  val_28 + this._tabsSelectorController.allButtons.Count);
            }
            
            label_46:
            if(val_28 < this._tabsLayout.widgets.Count)
            {
                goto label_61;
            }
        
        }
        private void 三丁丏东丂丏丙丟丌()
        {
            var val_20;
            Progress.丛下丄专下万丒专丂 val_2 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._primaryWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丂丕丄上三东丆丌丟(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._backupWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.业丞丄七丞丒丐丒丐(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._meleeWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丐万一丁专下专东丞(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._specialWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丕上下丌与丆丝丛丄(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._sniperWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丒丕丕一丙丒丅丑丞(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._premiumWeaponCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丗不且东丌丙三丆业(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._skinCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丏世上东一丌丙世七(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._armorCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丟丆丝上且丌丞丈丘(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._hatCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.世丑七丙丈丐丅丕业(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._maskCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丛丝与丄丝下丅三三(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._capeCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丗不丂丛丗丄丕世世(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._bootsCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丕丞丕丗七丒丗东丒(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._petCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.业万丝丟七丝丈不丌(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._vehicleCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丙万三丗丘丌业且丕(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._throwingGadgetCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丈丞下丄丌丕丆丞且(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            this._toolGadgetCell.一丞一丝丘丕且丒丆(丆专且丕专丗与一丏:  val_2.丆下丟丁丝丁一丕业(), 与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛);
            val_20 = null;
            val_20 = null;
            if((LoadoutsUi.<>c.<>9__56_0) == null)
            {
                goto label_38;
            }
            
            label_43:
            this.丌丅东丑业且丐与丛.ForEach(action:  LoadoutsUi.<>c.<>9__56_0);
            this.丘丅丟丑万丑丂丑丞(丑丒业丘丑东丕世丅:  this.丞七丗一丌七丞丘东);
            return;
            label_38:
            LoadoutsUi.<>c.<>9__56_0 = new System.Action<PGCompany.ItemCellOfLoadoutsUi>(object:  LoadoutsUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoadoutsUi.<>c::业丄且下东丂丂业丝(PGCompany.ItemCellOfLoadoutsUi 三丟东丕丄丄下下丑));
            if(this.丌丅东丑业且丐与丛 != null)
            {
                goto label_43;
            }
            
            goto label_43;
        }
        private void 丈业丏三丞下丈业丏()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectLoadoutButton, 丏业丟一东丂东丘丛:  (Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().丑专丘世丙丑丝世七() != this.不专丙丌一丆且丝丛) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._alreadySelectedLoadoutButton, 丏业丟一东丂东丘丛:  (~this._selectLoadoutButton.activeSelf) & 1);
        }
        private void 不丝丞上专七丞七丅()
        {
            this._nameInput.value = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  this.不专丙丌一丆且丝丛).东丙上东业丆不丟丘();
        }
        private void 丗丟万丂丘丈专丄丂()
        {
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丅与丌专丟一丝业三());
            PGCompany.LoadoutsUi.丆丕丝丒不丙且丐丗 = 0;
        }
        private void 丘丐丏三上丆世丟丝()
        {
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  70)) != true)
            {
                    if((丌丝世丞世丛丆丅丟.丗三丝业丅丁丁丑下(下上丐丆丝丟丝丒不:  "LoadoutsUi-shown-tutor-"("LoadoutsUi-shown-tutor-") + 丅丛丟上丁丆上丛专.不七不丙丏上与三一().业与丆丌丆丅丄丝万(), 丞丌丑丛上丕丙丕下:  0)) == 1)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  70);
                return;
            }
            
            }
            
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  70)) != false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._hintsPanel, 丏业丟一东丂东丘丛:  true);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  70);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "LoadoutsUi-shown-tutor-"("LoadoutsUi-shown-tutor-") + 丅丛丟上丁丆上丛专.不七不丙丏上与三一().业与丆丌丆丅丄丝万(), 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        private void 丘丅丟丑万丑丂丑丞(bool 丑丒业丘丑东丕世丅)
        {
            .丑丒业丘丑东丕世丅 = 丑丒业丘丑东丕世丅;
            this.丌丅东丑业且丐与丛.ForEach(action:  new System.Action<PGCompany.ItemCellOfLoadoutsUi>(object:  new LoadoutsUi.丙丏七丏丝丝丂下东(), method:  System.Void LoadoutsUi.丙丏七丏丝丝丂下东::七丅丏丅世丟丂丛三(PGCompany.ItemCellOfLoadoutsUi 三丟东丕丄丄下下丑)));
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._categoryLabels, 丏业丟一东丂东丘丛:  ((LoadoutsUi.丙丏七丏丝丝丂下东)[1152921555736341104].丑丒业丘丑东丕世丅 == false) ? 1 : 0);
        }
        public LoadoutsUi()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.green;
            this.activeTabTint = val_1;
            mem[1152921555736437564] = val_1.g;
            mem[1152921555736437568] = val_1.b;
            mem[1152921555736437572] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            this.lockedTabTint = val_2;
            mem[1152921555736437580] = val_2.g;
            mem[1152921555736437584] = val_2.b;
            mem[1152921555736437588] = val_2.a;
            this.defaultTabTint = 0;
            mem[1152921555736437596] = 0;
            mem[1152921555736437604] = 0;
            UnityEngine.Color val_3 = UnityEngine.Color.green;
            this.activeTabNameTint = val_3;
            mem[1152921555736437612] = val_3.g;
            mem[1152921555736437616] = val_3.b;
            mem[1152921555736437620] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.yellow;
            this.selectedTabNameTint = val_4;
            mem[1152921555736437628] = val_4.g;
            mem[1152921555736437632] = val_4.b;
            mem[1152921555736437636] = val_4.a;
            this.defaultTabNameTint = 0;
            mem[1152921555736437644] = 0;
            mem[1152921555736437652] = 0;
        }
    
    }

}
