using UnityEngine;

namespace Rilisoft
{
    public class GameEventSetsCollectedView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.丛且世丐丆上七业丁>
    {
        // Fields
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private UILabel _collectedLabel;
        private UIGrid _grid;
        
        // Properties
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_9;
            System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Boolean> val_11;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            val_9 = null;
            val_9 = null;
            val_11 = GameEventSetsCollectedView.<>c.<>9__5_0;
            if(val_11 == null)
            {
                    System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Boolean> val_3 = null;
                val_11 = val_3;
                val_3 = new System.Func<Rilisoft.与专丒丞丐一丒丂东, System.Boolean>(object:  GameEventSetsCollectedView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GameEventSetsCollectedView.<>c::一丐且丑世丝不丆丒(Rilisoft.与专丒丞丐一丒丂东 丁丂专业丁丅丅丈丙));
                GameEventSetsCollectedView.<>c.<>9__5_0 = val_11;
            }
            
            this._collectedLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4678"), arg0:  System.Linq.Enumerable.Count<Rilisoft.与专丒丞丐一丒丂东>(source:  System.Linq.Enumerable.Cast<Rilisoft.与专丒丞丐一丒丂东>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞()), predicate:  val_3), arg1:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞().Count);
            this.东丘丙且丐丛丏丝业();
        }
        private void 东丘丙且丐丛丏丝业()
        {
            UIGrid val_31;
            object val_32;
            string val_33;
            var val_34;
            UIGrid val_35;
            var val_36;
            var val_37;
            val_31 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞()) == null)
            {
                goto label_2;
            }
            
            if(this._grid != 0)
            {
                goto label_5;
            }
            
            val_32 = "GameEventSetsCollectedView: grid is null";
            goto label_8;
            label_2:
            val_32 = "GameEventSetsCollectedView: Context.Chests is null";
            label_8:
            UnityEngine.Debug.LogError(message:  val_32);
            return;
            label_5:
            System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下> val_3 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞();
            if((val_3 == null) || (val_3.Count < 1))
            {
                goto label_14;
            }
            
            val_33 = 1152921505284374528;
            goto label_15;
            label_24:
            UnityEngine.GameObject val_9 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._grid.transform.GetChild(index:  0).gameObject, 丈东丘丏与丌东东下:  this._grid.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            label_15:
            int val_11 = this._grid.transform.childCount;
            if(val_11 < val_3.Count)
            {
                goto label_24;
            }
            
            goto label_25;
            label_34:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_11.GetChild(丞世不丒下上上丝丑:  val_11.transform.childCount - 1).gameObject);
            label_25:
            if(this._grid.transform.childCount > val_3.Count)
            {
                goto label_34;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._grid.gameObject, 丏业丟一东丂东丘丛:  true);
            val_34 = public System.Int32 System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>::get_Count();
            val_35 = this._grid;
            if(val_3.Count < 1)
            {
                goto label_38;
            }
            
            val_36 = 0;
            goto label_39;
            label_51:
            val_36 = 0;
            label_39:
            Rilisoft.GameEventSetsChestStateView val_24 = val_35.GetChild(丞世不丒下上上丝丑:  0).GetComponent<Rilisoft.GameEventSetsChestStateView>();
            if(val_24 == 0)
            {
                goto label_44;
            }
            
            Rilisoft.上专业三丟丁丞专下 val_26 = val_3.Item[0];
            val_33 = 0.ToString(format:  "#0000");
            if(val_24 == null)
            {
                goto label_45;
            }
            
            val_24.name = val_33;
            if(val_26 != null)
            {
                goto label_46;
            }
            
            goto label_48;
            label_45:
            val_24.name = val_33;
            if(val_26 == null)
            {
                goto label_48;
            }
            
            label_46:
            label_48:
            val_37 = 0;
            val_24.<丅丝丌丝丁丏丙东丞>k__BackingField = ;
            val_24.丝一丅丆三东丂丞七();
            label_44:
            val_34 = public System.Int32 System.Collections.Generic.List<Rilisoft.上专业三丟丁丞专下>::get_Count();
            val_35 = this._grid;
            if((0 + 1) < val_3.Count)
            {
                goto label_51;
            }
            
            label_38:
            val_31 = this._grid;
            val_31.repositionNow = true;
            return;
            label_14:
            val_31 = this._grid.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_31, 丏业丟一东丂东丘丛:  false);
        }
        public GameEventSetsCollectedView()
        {
        
        }
    
    }

}
