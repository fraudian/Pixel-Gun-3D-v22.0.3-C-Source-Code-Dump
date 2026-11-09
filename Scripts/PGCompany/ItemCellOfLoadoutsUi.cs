using UnityEngine;

namespace PGCompany
{
    public class ItemCellOfLoadoutsUi : PGBehaviour
    {
        // Fields
        private ItemView _itemView;
        private UIBasicSprite _itemTexture;
        private UITexture _moduleIcon;
        private UnityEngine.Texture _energyModuleTexture;
        private UnityEngine.Texture _magicModuleTexture;
        private UnityEngine.Texture _kineticModuleTexture;
        private UnityEngine.GameObject _emptyLabel;
        private UnityEngine.GameObject _itemTextureContainer;
        private UnityEngine.GameObject _item3dObjectContainer;
        private UnityEngine.MeshRenderer _item3dObjectMeshRenderer;
        private UIButton _button;
        private UILabel _itemName;
        private UILabel _almanachNumber;
        private UnityEngine.GameObject _almanachNumberContainer;
        private UISprite _gradeColorFrame;
        private UnityEngine.GameObject _additionalInfoContainer;
        private int 丁下丕丒丝丐丛丅专;
        private int 丙丈丈一下丗不丏丅;
        
        // Methods
        internal void 一丞一丝丘丕且丒丆(int 丆专且丕专丗与一丏, int 与与丕万丌与下丒丆)
        {
            UnityEngine.GameObject val_11;
            var val_12;
            var val_13;
            UnityEngine.GameObject val_14;
            this.丁下丕丒丝丐丛丅专 = 丆专且丕专丗与一丏;
            this.丙丈丈一下丗不丏丅 = 与与丕万丌与下丒丆;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  丆专且丕专丗与一丏)) != false)
            {
                    this._itemView.丈且东丑丂且万丒丅(下丅丙一丂丗丅丝七:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  丆专且丕专丗与一丏));
            }
            else
            {
                    this._itemView.世业丒万丘丆专丘丐();
            }
            
            val_11 = this._itemTextureContainer;
            if((SkinsController.丂专丞丒丟丂专与东(丞世不丒下上上丝丑:  丆专且丕专丗与一丏)) == null)
            {
                goto label_9;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._item3dObjectContainer, 丏业丟一东丂东丘丛:  true);
            val_11 = this._item3dObjectMeshRenderer;
            if(val_11 == 0)
            {
                goto label_20;
            }
            
            val_12 = null;
            val_11 = this._item3dObjectMeshRenderer.material;
            val_12 = null;
            val_11.mainTexture = SkinsController.与业七丙三三万丕上.Item[SkinsController.丂专丞丒丟丂专与东(丞世不丒下上上丝丑:  丆专且丕专丗与一丏)];
            goto label_20;
            label_9:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._item3dObjectContainer, 丏业丟一东丂东丘丛:  false);
            label_20:
            this.丌丌一丂丗丌丞丏丄();
            this.丆世下三丒丌丞与丒();
            this.丒与专与上丗丌不丝();
            this.不丞丝丝丏丁万万丑();
            if(this.丂丁丒业丙丛七丗丟() != false)
            {
                    val_13 = 1;
                val_14 = this._emptyLabel;
            }
            else
            {
                    val_14 = this._emptyLabel;
                val_13 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_14, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丘丅丟丑万丑丂丑丞(bool 丑丒业丘丑东丕世丅)
        {
            丑丒业丘丑东丕世丅 = 丑丒业丘丑东丕世丅;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._additionalInfoContainer, 丏业丟一东丂东丘丛:  丑丒业丘丑东丕世丅);
        }
        internal void 与丛丛专丄丘不丌东()
        {
            this._button.enabled = (~this.丂丁丒业丙丛七丗丟()) & 1;
        }
        private bool 丂丁丒业丙丛七丗丟()
        {
            UnityEngine.GameObject val_5;
            var val_6;
            val_5 = this;
            if(this._itemTexture != 0)
            {
                goto label_4;
            }
            
            if(this._item3dObjectContainer != 0)
            {
                goto label_7;
            }
            
            val_6 = 1;
            goto label_9;
            label_4:
            val_6 = 0;
            goto label_9;
            label_7:
            val_5 = this._item3dObjectContainer;
            bool val_3 = val_5.activeInHierarchy;
            val_6 = val_3 ^ 1;
            label_9:
            val_3 = val_6;
            return (bool)val_3;
        }
        private void 丌丌一丂丗丌丞丏丄()
        {
            var val_28;
            System.Collections.Generic.IEnumerable<TSource> val_29;
            var val_31;
            System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三> val_33;
            var val_34;
            var val_35;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_37;
            var val_38;
            System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三> val_40;
            var val_41;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_43;
            var val_44;
            UITexture val_45;
            UnityEngine.Texture val_46;
            val_28 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_28.丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) == false)
            {
                    return;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专);
            val_28 = 0;
            if(val_4.不业丙丒丂丞下丆丙() != 10)
            {
                goto label_5;
            }
            
            Progress.丛下丄专下万丒专丂 val_7 = Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  this.丙丈丈一下丗不丏丅);
            System.Collections.Generic.List<System.Int32> val_8 = null;
            val_29 = val_8;
            val_8 = new System.Collections.Generic.List<System.Int32>();
            if(val_4 > 5)
            {
                goto label_10;
            }
            
            var val_28 = 106039388 + (val_4) << 2;
            val_28 = val_28 + 106039388;
            goto (106039388 + (val_4) << 2 + 106039388);
            label_10:
            val_31 = null;
            val_31 = null;
            val_33 = ItemCellOfLoadoutsUi.<>c.<>9__22_0;
            if(val_33 == null)
            {
                    System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三> val_15 = null;
                val_33 = val_15;
                val_15 = new System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三>(object:  ItemCellOfLoadoutsUi.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.丏丂一丗丙世丏丐三 ItemCellOfLoadoutsUi.<>c::东七丗丘丛丒丗不世(int 三丟东丕丄丄下下丑));
                ItemCellOfLoadoutsUi.<>c.<>9__22_0 = val_33;
            }
            
            val_35 = null;
            val_35 = null;
            val_37 = ItemCellOfLoadoutsUi.<>c.<>9__22_1;
            if(val_37 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_17 = null;
                val_37 = val_17;
                val_17 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  ItemCellOfLoadoutsUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ItemCellOfLoadoutsUi.<>c::丗丒丄且上万七与丄(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                ItemCellOfLoadoutsUi.<>c.<>9__22_1 = val_37;
            }
            
            val_28 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丏丂一丗丙世丏丐三>(source:  System.Linq.Enumerable.Select<System.Int32, PGCompany.丏丂一丗丙世丏丐三>(source:  null, selector:  val_15), predicate:  val_17);
            label_5:
            if(val_4.不业丙丒丂丞下丆丙() == 20)
            {
                    val_34 = 1152921505619890176;
                val_38 = null;
                val_38 = null;
                val_40 = ItemCellOfLoadoutsUi.<>c.<>9__22_2;
                if(val_40 == null)
            {
                    System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三> val_23 = null;
                val_40 = val_23;
                val_23 = new System.Func<System.Int32, PGCompany.丏丂一丗丙世丏丐三>(object:  ItemCellOfLoadoutsUi.<>c.__il2cppRuntimeField_static_fields, method:  PGCompany.丏丂一丗丙世丏丐三 ItemCellOfLoadoutsUi.<>c::下丌下丝丕万下丙丂(int 三丟东丕丄丄下下丑));
                ItemCellOfLoadoutsUi.<>c.<>9__22_2 = val_40;
            }
            
                val_41 = null;
                val_41 = null;
                val_43 = ItemCellOfLoadoutsUi.<>c.<>9__22_3;
                if(val_43 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean> val_25 = null;
                val_43 = val_25;
                val_25 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Boolean>(object:  ItemCellOfLoadoutsUi.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ItemCellOfLoadoutsUi.<>c::丈与世东万丐丂丁三(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                ItemCellOfLoadoutsUi.<>c.<>9__22_3 = val_43;
            }
            
                val_28 = System.Linq.Enumerable.FirstOrDefault<PGCompany.丏丂一丗丙世丏丐三>(source:  System.Linq.Enumerable.Select<System.Int32, PGCompany.丏丂一丗丙世丏丐三>(source:  Progress.七七世万专丕丁上业.世丟东丗丈丅专丞丗().东业七上丛上丝丘丛(与与丕万丌与下丒丆:  this.丙丈丈一下丗不丏丅).与丐丅丆丝不东丌丐(), selector:  val_23), predicate:  val_25);
            }
            
            if(val_28 == null)
            {
                goto label_48;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleIcon, 丏业丟一东丂东丘丛:  true);
            ModuleType val_27 = val_28.与丝丅丘且丐上丅世();
            if(val_27 == 1)
            {
                goto label_51;
            }
            
            if(val_27 == 2)
            {
                goto label_52;
            }
            
            if(val_27 != 3)
            {
                    return;
            }
            
            val_44 = null;
            val_45 = this._moduleIcon;
            val_46 = this._magicModuleTexture;
            goto label_61;
            label_48:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._moduleIcon, 丏业丟一东丂东丘丛:  false);
            return;
            label_51:
            val_44 = null;
            val_45 = this._moduleIcon;
            val_46 = this._kineticModuleTexture;
            goto label_61;
            label_52:
            val_44 = null;
            val_45 = this._moduleIcon;
            val_46 = this._energyModuleTexture;
            label_61:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_45, 与万丆丛丒万丝丙丑:  val_46);
        }
        private void 丆世下三丒丌丞与丒()
        {
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gradeColorFrame, 丏业丟一东丂东丘丛:  true);
                PGCompany.丗丟丄丈东丝丕丄世 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专);
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._gradeColorFrame, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color());
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._gradeColorFrame, 丏业丟一东丂东丘丛:  false);
        }
        private void 丒与专与上丗丌不丝()
        {
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemName, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._itemName, 丕丗丘丑丛与丑业丒:  PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专));
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemName, 丏业丟一东丂东丘丛:  false);
        }
        private void 不丞丝丝丏丁万万丑()
        {
            UILabel val_7;
            UnityEngine.GameObject val_8;
            val_7 = this;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._almanachNumberContainer, 丏业丟一东丂东丘丛:  false);
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_8.丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) == false)
            {
                    return;
            }
            
            int val_7 = this.丁下丕丒丝丐丛丅专;
            val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_4 = val_8.一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  val_7);
            if(val_4 == null)
            {
                    return;
            }
            
            val_7 = (null == null) ? (val_4) : 0;
            if(null != null)
            {
                    return;
            }
            
            val_8 = this._almanachNumberContainer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
            val_7 = this._almanachNumber;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_7, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "#{0}", arg0:  val_7.丏万东丐丛不丛不世()));
        }
        public void U_Click()
        {
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) != false)
            {
                    PGCompany.丗丟丄丈东丝丕丄世 val_4 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专);
                Rilisoft.ItemViewer val_6 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  PGCompany.LoadoutsUi.丆丕丝丒不丙且丐丗.transformForInfoWindows, 下丅丙一丂丗丅丝七:  val_4, 与丙丆世丘丑丒丌丄:  val_4.不业丙丒丂丞下丆丙(), 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 丒不业且丄丅世世下:  false);
            }
            else
            {
                    if((SkinsController.丂专丞丒丟丂专与东(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专)) == null)
            {
                    return;
            }
            
            }
            
            Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoView", 丆丏七丟不丒与七专:  PGCompany.LoadoutsUi.丆丕丝丒不丙且丐丗.transformForInfoWindows, 丕丁下丌不万丅丞丛:  SkinsController.丂专丞丒丟丂专与东(丞世不丒下上上丝丑:  this.丁下丕丒丝丐丛丅专), 丅三丟世下丞丝丙万:  0, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  65, 丒不业且丄丅世世下:  false).DoNotChangeAmbientColor = true;
        }
        public ItemCellOfLoadoutsUi()
        {
        
        }
    
    }

}
