using UnityEngine;

namespace PGCompany
{
    internal class InventoryItemInfoView : PGBehaviour, 世丙丘下丝丗上下丏<PGCompany.丗丟丄丈东丝丕丄世>
    {
        // Fields
        internal bool 一万丛丈丝上丟一世;
        private PGCompany.丗丟丄丈东丝丕丄世 <丅丝丌丝丁丏丙东丞>k__BackingField;
        public System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> propertyToShow;
        private PropertiesHideSHow _propertiesHideSHow;
        private UnityEngine.GameObject _weaponContainer;
        private PGCompany.ItemPropertiesLayout _weaponPropertiesLayout;
        private PGCompany.ItemEffectsLayout _weaponEffectsLayout;
        private UILabel _weaponRarityLabel;
        private UnityEngine.GameObject _gadgetContainer;
        private PGCompany.ItemPropertiesLayout _gadgetPropertiesLayout;
        private PGCompany.ItemEffectsLayout _gadgetEffectsLayout;
        private UILabel _gadgetRarityLabel;
        private UILabel _descriptionLabel;
        private UnityEngine.GameObject _armorContainer;
        private PGCompany.ItemPropertiesLayout _armorPropertiesLayout;
        private UILabel _armorEffectDescriptionLabel;
        private UILabel _armorRarityLabel;
        private UnityEngine.GameObject _petContainer;
        private PGCompany.ItemPropertiesLayout _petPropertiesLayout;
        private PGCompany.ItemEffectsLayout _petEffectsLayout;
        private UILabel _petRarityLabel;
        
        // Properties
        public PGCompany.丗丟丄丈东丝丕丄世 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.丗丟丄丈东丝丕丄世 get_Context()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.丗丟丄丈东丝丕丄世 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.丗丟丄丈东丝丕丄世 与且专丈不万东一万)
        {
            var val_5;
            var val_6;
            PropertiesHideSHow val_7;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gadgetContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._armorContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petContainer, 丏业丟一东丂东丘丛:  false);
            Rilisoft.OfferItemType val_1 = 与且专丈不万东一万.不业丙丒丂丞下丆丙();
            if(val_1 <= 20)
            {
                goto label_4;
            }
            
            if(val_1 == 70)
            {
                goto label_5;
            }
            
            if(val_1 == 80)
            {
                goto label_6;
            }
            
            if(val_1 != 1080)
            {
                goto label_15;
            }
            
            if(与且专丈不万东一万 == null)
            {
                goto label_8;
            }
            
            val_5 = null;
            if(null == val_5)
            {
                goto label_9;
            }
            
            label_8:
            val_6 = null;
            goto label_10;
            label_4:
            if(val_1 == 10)
            {
                goto label_11;
            }
            
            if(val_1 != 20)
            {
                goto label_15;
            }
            
            this.七丑世万东专丂与丏();
            goto label_15;
            label_11:
            this.三且七丐与丐不丄与();
            goto label_15;
            label_5:
            this.东与万丕丂且七上专();
            goto label_15;
            label_6:
            this.东与且不上不东且上();
            label_15:
            label_22:
            val_7 = this._propertiesHideSHow;
            if(val_7 != 0)
            {
                    val_7 = this._propertiesHideSHow;
                val_7.SetState(丁丞三七丌且丐丁丝:  true);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
            return;
            label_9:
            val_6 = val_5;
            label_10:
            var val_4 = (((val_5 == val_6) ? 与且专丈不万东一万 : 0) != 190000) ? 1 : 0;
            goto label_22;
        }
        private void 三且七丐与丐不丄与()
        {
            var val_17;
            var val_18;
            var val_19;
            PGCompany.丕万丁不丁丑东丌七 val_20;
            var val_21;
            PGCompany.丕万丁不丁丑东丌七 val_22;
            val_17 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._weaponContainer, 丏业丟一东丂东丘丛:  true);
            val_18 = null;
            val_18 = null;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._weaponRarityLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[this.<丅丝丌丝丁丏丙东丞>k__BackingField])(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.七丕丏不上丞丛七不.Item[this.<丅丝丌丝丁丏丙东丞>k__BackingField])) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)));
            System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> val_6 = new System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>();
            if((this.propertyToShow == null) || (this.propertyToShow.Count == 0))
            {
                goto label_14;
            }
            
            List.Enumerator<T> val_8 = this.propertyToShow.GetEnumerator();
            label_18:
            if(((-618113352) & 1) == 0)
            {
                goto label_16;
            }
            
            val_6.Add(item:  0.丙东专丂世丈丏丁丂());
            goto label_18;
            label_14:
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丐上下三丑丈丑丄丟().丐专丒丟丈丛丈丂业()) != false)
            {
                    if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丐上下三丑丈丑丄丟().不丅丟丞丏丒丌三丌()) == false)
            {
                goto label_22;
            }
            
            }
            
            if(val_6 == null)
            {
                goto label_23;
            }
            
            val_6.Add(item:  8);
            val_6.Add(item:  1);
            val_19 = public System.Void System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>::Add(PGCompany.丕万丁不丁丑东丌七 item);
            val_20 = 2;
            goto label_24;
            label_23:
            val_6.Add(item:  8);
            val_6.Add(item:  1);
            val_21 = public System.Void System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>::Add(PGCompany.丕万丁不丁丑东丌七 item);
            val_22 = 2;
            goto label_25;
            label_22:
            if(val_6 == null)
            {
                goto label_26;
            }
            
            val_6.Add(item:  8);
            val_19 = public System.Void System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>::Add(PGCompany.丕万丁不丁丑东丌七 item);
            val_20 = 4;
            label_24:
            val_6.Add(item:  val_20);
            goto label_27;
            label_16:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_33;
            label_26:
            val_6.Add(item:  8);
            val_21 = public System.Void System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>::Add(PGCompany.丕万丁不丁丑东丌七 item);
            val_22 = 4;
            label_25:
            val_6.Add(item:  val_22);
            label_27:
            val_6.Add(item:  3);
            label_33:
            1152921504691564544.丈且东丑丂且万丒丅(丌不七丗丌丏丄丐丞:  val_6, 丙丑丆上不丒上丕丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.世丙万丞上与一丌丅(丆丗万丛丞丈三丗丅:  false));
            val_6.七丗丏丌丌丛业世一(丌丞丌丌丈丁丏丅丟:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丐上下三丑丈丑丄丟().丞丁下丅上不且丐丄());
        }
        private void 东与万丕丂且七上专()
        {
            var val_9;
            var val_11;
            UILabel val_14;
            var val_15;
            UILabel val_17;
            val_15 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gadgetContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._gadgetRarityLabel, 丕丗丘丑丛与丑业丒:  上丑三丁丄丛丁万丑.一丝丆七丁三三上丒(七丆丒与丗丌丄且丂:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)(上丑三丁丄丛丁万丑.一丝丆七丁三三上丒(七丆丒与丗丌丄且丂:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField)));
            System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> val_5 = new System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>();
            if((this.propertyToShow == null) || (this.propertyToShow.Count == 0))
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_7 = this.propertyToShow.GetEnumerator();
            label_15:
            if(( & 1) == 0)
            {
                goto label_13;
            }
            
            val_5.Add(item:  0.丙东专丂世丈丏丁丂());
            goto label_15;
            label_11:
            if(val_5 != null)
            {
                    val_5.Add(item:  8);
                val_5.Add(item:  5);
                val_5.Add(item:  6);
            }
            else
            {
                    val_5.Add(item:  8);
                val_5.Add(item:  5);
                val_5.Add(item:  6);
            }
            
            val_5.Add(item:  7);
            goto label_23;
            label_13:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_23:
            val_9.丈且东丑丂且万丒丅(丌不七丗丌丏丄丐丞:  val_5, 丙丑丆上不丒上丕丛:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.世丙万丞上与一丌丅());
            val_11.七丗丏丌丌丛业世一(丌丞丌丌丈丁丏丅丟:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丕丞且丕不丘丙丑().丑丐丗世业丙丗丘不());
            val_17 = val_14;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_17, 丕丗丘丑丛与丑业丒:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        private void 七丑世万东专丂与丏()
        {
            var val_6;
            UILabel val_15;
            System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_16;
            string val_17;
            val_15 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            string val_1 = (((PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchy + (PGCompany.且万丅丙丛丌丞与丈.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? this.<丅丝丌丝丁丏丙东丞>k__BackingField : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._armorContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._armorRarityLabel, 丕丗丘丑丛与丑业丒:  val_1);
            System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> val_2 = new System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>();
            if((this.propertyToShow == null) || (this.propertyToShow.Count == 0))
            {
                goto label_8;
            }
            
            List.Enumerator<T> val_4 = this.propertyToShow.GetEnumerator();
            val_16 = 1152921555528304704;
            label_12:
            if(((-617676368) & 1) == 0)
            {
                goto label_10;
            }
            
            val_2.Add(item:  val_6.丙东专丂世丈丏丁丂());
            goto label_12;
            label_8:
            if(val_2 != null)
            {
                    val_2.Add(item:  8);
                val_2.Add(item:  10);
            }
            else
            {
                    val_2.Add(item:  8);
                val_2.Add(item:  10);
            }
            
            val_2.Add(item:  9);
            goto label_19;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_19:
            if(this._armorPropertiesLayout != 0)
            {
                    val_16 = val_1.世丙万丞上与一丌丅();
                this._armorPropertiesLayout.丈且东丑丂且万丒丅(丌不七丗丌丏丄丐丞:  val_2, 丙丑丆上不丒上丕丛:  val_16);
            }
            
            val_15 = this._armorEffectDescriptionLabel;
            if(val_1.下丆丂丌上丑一三丆().Count > 0)
            {
                    val_17 = val_1.下丆丘丆一丝七世专();
            }
            else
            {
                    val_17 = "Key_8971";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_17));
        }
        private void 东与且不上不东且上()
        {
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            ItemRarity val_1 = (((PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchy + (PGCompany.世丒丗丅丛丕不万丂.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? this.<丅丝丌丝丁丏丙东丞>k__BackingField : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._petContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._petRarityLabel, 丕丗丘丑丛与丑业丒:  丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_1));
            System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> val_3 = new System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七>();
            if((this.propertyToShow == null) || (this.propertyToShow.Count == 0))
            {
                goto label_10;
            }
            
            List.Enumerator<T> val_5 = this.propertyToShow.GetEnumerator();
            label_14:
            if(((-617461960) & 1) == 0)
            {
                goto label_12;
            }
            
            val_3.Add(item:  0.丙东专丂世丈丏丁丂());
            goto label_14;
            label_10:
            val_3.Add(item:  8);
            goto label_20;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_20:
            if(this._petPropertiesLayout != null)
            {
                    this._petPropertiesLayout.丈且东丑丂且万丒丅(丌不七丗丌丏丄丐丞:  val_3, 丙丑丆上不丒上丕丛:  val_1.世丙万丞上与一丌丅());
            }
            
            this = this._petEffectsLayout;
            if(this == null)
            {
                    return;
            }
            
            PetInfo val_8 = val_1.丕东专业七丑丄不万();
            this.七丗丏丌丌丛业世一(丌丞丌丌丈丁丏丅丟:  val_8.Effects);
        }
        public InventoryItemInfoView()
        {
        
        }
    
    }

}
