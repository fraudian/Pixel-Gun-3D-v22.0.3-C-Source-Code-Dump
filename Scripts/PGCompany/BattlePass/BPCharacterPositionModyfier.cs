using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPCharacterPositionModyfier : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform _baseTransform;
        private System.Collections.Generic.List<PGCompany.BattlePass.BPCharacterPositionModyfier.PositionDescription> _positions;
        private UnityEngine.Transform 专专丏下丐丂丂丅东;
        
        // Properties
        private UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
        
        // Methods
        public bool SetPosition(System.Nullable<CategoryNames> 业丈世与下丘丛丐且, string 丞一丁业丄一一业且)
        {
            object val_16;
            System.Func<TSource, System.Boolean> val_17;
            var val_18;
            float val_19;
            float val_20;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_29;
            float val_30;
            float val_31;
            BPCharacterPositionModyfier.丞上丕丈丒丘丆三丈 val_1 = null;
            val_16 = val_1;
            val_1 = new BPCharacterPositionModyfier.丞上丕丈丒丘丆三丈();
            val_17 = val_16;
            .业丈世与下丘丛丐且 = 业丈世与下丘丛丐且;
            if(this._baseTransform == 0)
            {
                    val_18 = 0;
                return (bool)val_18;
            }
            
            if((1152921560123355344 & 1) == 0)
            {
                goto label_10;
            }
            
            System.Func<PositionDescription, System.Boolean> val_3 = null;
            val_17 = val_3;
            val_3 = new System.Func<PositionDescription, System.Boolean>(object:  val_1, method:  System.Boolean BPCharacterPositionModyfier.丞上丕丈丒丘丆三丈::丁东一丂七丑丁丝丘(PGCompany.BattlePass.BPCharacterPositionModyfier.PositionDescription 丁丂专业丁丅丅丈丙));
            val_16 = System.Linq.Enumerable.FirstOrDefault<PositionDescription>(source:  this._positions, predicate:  val_3);
            if((val_16 == null) || (val_4.Trans == 0))
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_6 = val_4.Trans.localPosition;
            val_19 = val_6.y;
            val_20 = val_6.z;
            UnityEngine.Quaternion val_7 = val_4.Trans.localRotation;
            val_16 = val_4.Trans;
            val_22 = val_7.x;
            val_23 = val_7.y;
            val_24 = val_7.z;
            val_25 = val_7.w;
            UnityEngine.Vector3 val_8 = val_16.localScale;
            val_29 = val_8.y;
            val_30 = val_8.z;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞一丁业丄一一业且)) != true)
            {
                    if((PGCompany.BattlePass.BPCharacterPositions.丐丅丟丙一且丟丗丝(丞一丁业丄一一业且:  丞一丁业丄一一业且)) != null)
            {
                    UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_19, z = val_20}, b:  new UnityEngine.Vector3() {x = val_10.Position, y = ???, z = ???});
                val_19 = val_11.y;
                val_20 = val_11.z;
            }
            
            }
            
            UnityEngine.Debug.LogError(message:  "SetPosition itemID: "("SetPosition itemID: ") + 丞一丁业丄一一业且);
            val_31 = val_8.x;
            val_18 = 1;
            goto label_22;
            label_10:
            UnityEngine.Vector3 val_13 = this._baseTransform.localPosition;
            UnityEngine.Quaternion val_14 = this._baseTransform.localRotation;
            val_29 = val_14.w;
            UnityEngine.Vector3 val_15 = this._baseTransform.localScale;
            val_31 = val_15.x;
            val_30 = val_15.z;
            val_18 = 0;
            val_19 = val_13.y;
            val_20 = val_13.z;
            val_22 = val_14.x;
            val_23 = val_14.y;
            val_24 = val_14.z;
            val_25 = val_29;
            label_22:
            this.下丏且一三丐一丐不(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_13.x, y = val_19, z = val_20}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = val_22, y = val_23, z = val_24, w = val_25}, 丝丕丁丏丏上丅丏且:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = ???});
            return (bool)val_18;
        }
        private void 下丏且一三丐一丐不(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, UnityEngine.Vector3 丝丕丁丏丏上丅丏且)
        {
            float val_30;
            float val_31;
            UnityEngine.Object val_32;
            Holoville.HOTween.Plugins.Core.ABSTweenPlugin val_33;
            val_30 = 丙丆与丅丈丑一且丏.w;
            val_31 = 丙丆与丅丈丑一且丏.y;
            val_32 = this;
            int val_2 = Holoville.HOTween.HOTween.Kill(p_target:  this.丌丟丄业且三丛丕丄());
            val_33 = new Holoville.HOTween.TweenParms().Prop(p_propName:  "localPosition", p_endVal:  下业丕七东丌丝下且).Prop(p_propName:  "localRotation", p_plugin:  new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = val_31, z = 丙丆与丅丈丑一且丏.z, w = val_30})).Prop(p_propName:  "localScale", p_endVal:  丝丕丁丏丏上丅丏且).UpdateType(p_updateType:  3);
            Holoville.HOTween.Tweener val_12 = Holoville.HOTween.HOTween.To(p_target:  this.丌丟丄业且三丛丕丄(), p_duration:  0.5f, p_parms:  val_33.Ease(p_easeType:  0));
            if(this.丌丟丄业且三丛丕丄().childCount < 1)
            {
                    return;
            }
            
            val_32 = this.丌丟丄业且三丛丕丄().GetComponentInChildren<CharacterInterfaceV2>();
            if(val_32 == 0)
            {
                    return;
            }
            
            val_32 = val_32.transform;
            UnityEngine.Quaternion val_19 = val_32.localRotation;
            val_33 = 1152921504838369280;
            val_30 = val_19.x;
            val_31 = val_19.z;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.identity;
            if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = val_30, y = val_19.y, z = val_31, w = val_19.w}, rhs:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w})) == false)
            {
                    return;
            }
            
            int val_22 = Holoville.HOTween.HOTween.Kill(p_target:  val_32);
            UnityEngine.Quaternion val_24 = UnityEngine.Quaternion.identity;
            val_30 = val_24.x;
            val_31 = val_24.z;
            Holoville.HOTween.Plugins.PlugQuaternion val_25 = null;
            val_33 = val_25;
            val_25 = new Holoville.HOTween.Plugins.PlugQuaternion(p_endVal:  new UnityEngine.Quaternion() {x = val_30, y = val_24.y, z = val_31, w = val_24.w});
            Holoville.HOTween.Tweener val_29 = Holoville.HOTween.HOTween.To(p_target:  val_32, p_duration:  0.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localRotation", p_plugin:  val_25).UpdateType(p_updateType:  3).Ease(p_easeType:  0));
        }
        private UnityEngine.Transform 丌丟丄业且三丛丕丄()
        {
            UnityEngine.Transform val_3;
            if(this.专专丏下丐丂丂丅东 == 0)
            {
                    this.专专丏下丐丂丂丅东 = this.transform;
                return val_3;
            }
            
            val_3 = this.专专丏下丐丂丂丅东;
            return val_3;
        }
        public BPCharacterPositionModyfier()
        {
        
        }
    
    }

}
