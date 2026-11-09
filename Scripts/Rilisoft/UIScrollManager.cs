using UnityEngine;

namespace Rilisoft
{
    internal class UIScrollManager : MonoBehaviour
    {
        // Fields
        private UIGrid 丅丅丄一丂不丁丅三;
        private UIScrollView 丞万丌下丕丟丂世不;
        private UIWrapContent 丒业丈丄丌与丞丐东;
        private UnityEngine.GameObject Prefab;
        private bool Populate;
        private bool add;
        private bool clean;
        private bool center;
        private int count;
        private int centerOn;
        private System.Collections.Generic.List<string> 丝丐丗丐与不丕丁丆;
        
        // Properties
        private UIScrollView 业丘丘丕专丞丅丈丙 { get; }
        private UIGrid 世一三业丈下丙且丟 { get; }
        private UIWrapContent 上丈世丁丐丒业上世 { get; }
        private UIPanel 丗丒丟下丕丆丗丆丈 { get; }
        private bool 丒七丗丙业七丁丅业 { get; }
        
        // Methods
        private UIScrollView 不丆丝丗丕下丙一下()
        {
            UIScrollView val_4;
            if(this.丞万丌下丕丟丂世不 == 0)
            {
                    this.丞万丌下丕丟丂世不 = this.gameObject.GetComponent<UIScrollView>();
                return val_4;
            }
            
            val_4 = this.丞万丌下丕丟丂世不;
            return val_4;
        }
        private UIGrid 丙专丙业丘丁与七下()
        {
            UIGrid val_4;
            if(this.丅丅丄一丂不丁丅三 == 0)
            {
                    this.丅丅丄一丂不丁丅三 = this.gameObject.GetComponentInChildren<UIGrid>();
                return val_4;
            }
            
            val_4 = this.丅丅丄一丂不丁丅三;
            return val_4;
        }
        private UIWrapContent 丙丒上丙丏丏丂丞东()
        {
            UIWrapContent val_4;
            if(this.丒业丈丄丌与丞丐东 == 0)
            {
                    this.丒业丈丄丌与丞丐东 = this.gameObject.GetComponentInChildren<UIWrapContent>();
                return val_4;
            }
            
            val_4 = this.丒业丈丄丌与丞丐东;
            return val_4;
        }
        private UIPanel 丙丁不丂丝丛丁一七()
        {
            UIScrollView val_1 = this.不丆丝丗丕下丙一下();
            if(val_1 != null)
            {
                    return val_1.panel;
            }
            
            return val_1.panel;
        }
        private bool 丆三丐丞丐丘丂一一()
        {
            return UnityEngine.Object.op_Inequality(x:  this.丙丒上丙丏丏丂丞东(), y:  0);
        }
        public void ScrollTo(int 世万专丛与丐丌专不)
        {
            if(this.丆三丐丞丐丘丂一一() != false)
            {
                    this.丗专不下丏下丐上丗(世万专丛与丐丌专不:  世万专丛与丐丌专不);
                return;
            }
            
            this.丘丌东丗不且且丂丏(世万专丛与丐丌专不:  世万专丛与丐丌专不);
        }
        private void 丘丌东丗不且且丂丏(int 世万专丛与丐丌专不)
        {
            var val_58;
            float val_59;
            float val_60;
            float val_61;
            float val_62;
            UnityEngine.Transform val_3 = this.丙专丙业丘丁与七下().transform.GetChild(index:  世万专丛与丐丌专不);
            UIScrollView val_4 = this.不丆丝丗丕下丙一下();
            if(val_4.movement != 1)
            {
                goto label_4;
            }
            
            UnityEngine.Vector4 val_8 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            UnityEngine.Vector3 val_9 = this.丙丁不丂丝丛丁一七().transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector4 val_11 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            float val_57 = val_11.w;
            UnityEngine.Vector3 val_14 = this.不丆丝丗丕下丙一下().transform.lossyScale;
            float val_58 = val_14.y;
            int val_16 = val_3.GetComponent<UIWidget>().height;
            UnityEngine.Vector3 val_19 = this.不丆丝丗丕下丙一下().transform.lossyScale;
            float val_60 = val_19.y;
            var val_20 = (val_16 < 0) ? (val_16 + 1) : (val_16);
            float val_59 = 0.5f;
            UnityEngine.Vector2 val_22 = this.丙丁不丂丝丛丁一七().clipSoftness;
            val_57 = val_57 * val_59;
            val_20 = val_20 >> 1;
            val_58 = this.不丆丝丗丕下丙一下().transform;
            val_58 = val_57 * val_58;
            UnityEngine.Vector3 val_25 = val_58.lossyScale;
            val_59 = val_9.y + val_58;
            val_60 = val_60 * (float)val_20;
            val_59 = val_22.y * val_25.y;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.up;
            val_60 = val_26.x;
            val_61 = val_26.y;
            val_62 = val_26.z;
            UnityEngine.Vector3 val_27 = val_3.position;
            float val_28 = val_59 - val_27.y;
            val_28 = val_28 - val_60;
            val_11.w = val_28 - val_59;
            goto label_21;
            label_4:
            val_58 = this.不丆丝丗丕下丙一下();
            if(val_29.movement != 0)
            {
                goto label_23;
            }
            
            UnityEngine.Vector4 val_33 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            UnityEngine.Vector3 val_34 = this.丙丁不丂丝丛丁一七().transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector4 val_36 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            float val_61 = val_36.z;
            UnityEngine.Vector3 val_39 = this.不丆丝丗丕下丙一下().transform.lossyScale;
            float val_62 = val_39.x;
            int val_41 = val_3.GetComponent<UIWidget>().width;
            UnityEngine.Vector3 val_44 = this.不丆丝丗丕下丙一下().transform.lossyScale;
            float val_64 = val_44.x;
            var val_45 = (val_41 < 0) ? (val_41 + 1) : (val_41);
            float val_63 = -0.5f;
            UnityEngine.Vector2 val_47 = this.丙丁不丂丝丛丁一七().clipSoftness;
            val_61 = val_61 * val_63;
            val_45 = val_45 >> 1;
            val_58 = this.不丆丝丗丕下丙一下().transform;
            val_62 = val_61 * val_62;
            UnityEngine.Vector3 val_50 = val_58.lossyScale;
            val_63 = val_34.x + val_62;
            val_64 = val_64 * (float)val_45;
            val_59 = val_47.y * val_50.x;
            UnityEngine.Vector3 val_51 = UnityEngine.Vector3.right;
            val_60 = val_51.x;
            val_61 = val_51.y;
            val_62 = val_51.z;
            UnityEngine.Vector3 val_52 = val_3.position;
            val_52.x = val_63 - val_52.x;
            val_52.x = val_64 + val_52.x;
            label_21:
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_60, y = val_61, z = val_62}, d:  val_59 + val_52.x);
            this.不丆丝丗丕下丙一下().MoveAbsolute(业丘丕万七专丑丂一:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
            label_23:
            this.不丆丝丗丕下丙一下().Restrict();
        }
        private void 丗专不下丏下丐上丗(int 世万专丛与丐丌专不)
        {
            float val_68;
            var val_69;
            var val_70;
            float val_71;
            var val_72;
            float val_73;
            var val_74;
            float val_76;
            float val_78;
            UIScrollView val_1 = this.不丆丝丗丕下丙一下();
            if(val_1.movement != 1)
            {
                goto label_2;
            }
            
            UnityEngine.Vector4 val_3 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            val_68 = val_3.y;
            UnityEngine.Vector4 val_5 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            float val_69 = val_5.w;
            val_69 = this.不丆丝丗丕下丙一下();
            UnityEngine.Transform val_7 = this.丅丞且丞丗下一下且(下丞丟丄丛丁丁丏丙:  val_6.movement);
            if(val_7 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = val_7.localPosition;
            UIWrapContent val_10 = this.丙丒上丙丏丏丂丞东();
            float val_68 = (float)val_10.itemSize;
            val_68 = val_9.y / val_68;
            val_70 = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_68));
            if(val_7 == null)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_13 = val_7.localPosition;
            val_71 = val_13.y;
            goto label_14;
            label_2:
            val_70 = this.不丆丝丗丕下丙一下();
            if(val_14.movement != 0)
            {
                goto label_55;
            }
            
            UnityEngine.Vector4 val_16 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            val_68 = val_16.x;
            UnityEngine.Vector4 val_18 = this.丙丁不丂丝丛丁一七().finalClipRegion;
            float val_74 = val_18.z;
            val_69 = this.不丆丝丗丕下丙一下();
            UnityEngine.Transform val_20 = this.丅丞且丞丗下一下且(下丞丟丄丛丁丁丏丙:  val_19.movement);
            if(val_20 != 0)
            {
                goto label_22;
            }
            
            return;
            label_13:
            UnityEngine.Vector3 val_22 = 0.localPosition;
            val_71 = val_22.y;
            label_14:
            int val_24 = val_7.GetComponent<UIWidget>().height;
            val_69 = val_69 * 0.5f;
            val_69 = val_68 + val_69;
            UnityEngine.Vector3 val_27 = this.丙丒上丙丏丏丂丞东().transform.localPosition;
            val_72 = this.丙丁不丂丝丛丁一七();
            UnityEngine.Vector2 val_29 = val_72.clipSoftness;
            var val_30 = (val_24 < 0) ? (val_24 + 1) : (val_24);
            val_30 = val_30 >> 1;
            float val_70 = (float)val_30;
            val_70 = val_71 + val_70;
            val_70 = val_70 + val_27.y;
            val_70 = val_70 - val_69;
            val_73 = val_70 + val_29.y;
            UIWrapContent val_31 = this.丙丒上丙丏丏丂丞东();
            int val_71 = val_31.itemSize;
            val_71 = val_71 * (世万专丛与丐丌专不 - val_70);
            val_69 = (float)val_71 - val_73;
            UIWrapContent val_33 = this.丙丒上丙丏丏丂丞东();
            int val_34 = (val_69 > 0f) ? (-val_33.itemSize) : val_33.itemSize;
            if(val_69 == 0f)
            {
                goto label_55;
            }
            
            val_73 = (float)-val_34;
            do
            {
                UIScrollView val_36 = this.不丆丝丗丕下丙一下();
                if(System.Math.Abs(val_69) > ((float)UnityEngine.Mathf.Abs(value:  val_34)))
            {
                    UnityEngine.Vector3 val_37 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, d:  val_73);
                val_71 = val_38.x;
                val_74 = val_38.z;
                val_76 = val_69 + (float)val_34;
            }
            else
            {
                    UnityEngine.Vector3 val_39 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z}, d:  val_69);
                val_71 = val_40.y;
                val_76 = 0f;
            }
            
                val_70 = this.丙丒上丙丏丏丂丞东();
            }
            while(val_76 != 0f);
            
            goto label_55;
            label_22:
            UnityEngine.Vector3 val_42 = val_20.localPosition;
            UIWrapContent val_43 = this.丙丒上丙丏丏丂丞东();
            float val_73 = (float)val_43.itemSize;
            val_73 = val_42.x / val_73;
            val_70 = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_73));
            val_72 = val_20.GetComponent<UIWidget>().width;
            UnityEngine.Vector3 val_48 = val_20.localPosition;
            val_71 = val_48.x;
            val_74 = val_74 * (-0.5f);
            val_74 = val_68 + val_74;
            UnityEngine.Vector3 val_51 = this.丙丒上丙丏丏丂丞东().transform.localPosition;
            UnityEngine.Vector2 val_53 = this.丙丁不丂丝丛丁一七().clipSoftness;
            var val_54 = (val_72 < 0) ? (val_72 + 1) : (val_72);
            val_54 = val_54 >> 1;
            float val_75 = (float)val_54;
            val_75 = val_71 + val_75;
            val_75 = val_75 + (val_74 + val_51.x);
            val_73 = val_75 + val_53.x;
            UIWrapContent val_56 = this.丙丒上丙丏丏丂丞东();
            int val_76 = val_56.itemSize;
            val_76 = val_76 * (val_70 - 世万专丛与丐丌专不);
            val_74 = val_73 + (float)val_76;
            UIWrapContent val_58 = this.丙丒上丙丏丏丂丞东();
            int val_59 = (val_74 > 0f) ? (-val_58.itemSize) : val_58.itemSize;
            if(val_74 != 0f)
            {
                    val_73 = (float)-val_59;
                do
            {
                UIScrollView val_61 = this.不丆丝丗丕下丙一下();
                if(System.Math.Abs(val_74) > ((float)UnityEngine.Mathf.Abs(value:  val_59)))
            {
                    UnityEngine.Vector3 val_62 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, d:  val_73);
                val_71 = val_63.x;
                val_74 = val_63.z;
                val_78 = val_74 + (float)val_59;
            }
            else
            {
                    UnityEngine.Vector3 val_64 = UnityEngine.Vector3.right;
                UnityEngine.Vector3 val_65 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_64.x, y = val_64.y, z = val_64.z}, d:  val_74);
                val_71 = val_65.y;
                val_78 = 0f;
            }
            
                val_70 = this.丙丒上丙丏丏丂丞东();
            }
            while(val_78 != 0f);
            
            }
            
            label_55:
            this.不丆丝丗丕下丙一下().Restrict();
        }
        private UnityEngine.Transform 丅丞且丞丗下一下且(UIScrollView.丘丌东丌丐丛丄丅丗 下丞丟丄丛丁丁丏丙)
        {
            var val_14;
            System.Func<UnityEngine.GameObject, System.Boolean> val_16;
            var val_17;
            System.Func<UnityEngine.GameObject, System.Boolean> val_19;
            var val_20;
            System.Func<UnityEngine.GameObject, System.Single> val_22;
            var val_24;
            System.Func<UnityEngine.GameObject, System.Single> val_26;
            UnityEngine.Object val_27;
            val_14 = null;
            val_14 = null;
            val_16 = UIScrollManager.<>c.<>9__16_0;
            if(val_16 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Boolean> val_4 = null;
                val_16 = val_4;
                val_4 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  UIScrollManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean UIScrollManager.<>c::专丕丏不丆业丐丒三(UnityEngine.GameObject 丕上丙丝丅丛丐丏丑));
                UIScrollManager.<>c.<>9__16_0 = val_16;
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = UIScrollManager.<>c.<>9__16_1;
            if(val_19 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Boolean> val_6 = null;
                val_19 = val_6;
                val_6 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  UIScrollManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean UIScrollManager.<>c::丈丏丙丆丆丆丘业万(UnityEngine.GameObject 丝三丁东丈丒世丅业));
                UIScrollManager.<>c.<>9__16_1 = val_19;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.丙丒上丙丏丏丂丞东().gameObject), predicate:  val_4), predicate:  val_6);
            if(下丞丟丄丛丁丁丏丙 == 0)
            {
                goto label_12;
            }
            
            if(下丞丟丄丛丁丁丏丙 != 1)
            {
                goto label_13;
            }
            
            val_20 = null;
            val_20 = null;
            val_22 = UIScrollManager.<>c.<>9__16_2;
            if(val_22 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Single> val_8 = null;
                val_22 = val_8;
                val_8 = new System.Func<UnityEngine.GameObject, System.Single>(object:  UIScrollManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Single UIScrollManager.<>c::丆丌业且丗上不丈丙(UnityEngine.GameObject 丕上丙丝丅丛丐丏丑));
                UIScrollManager.<>c.<>9__16_2 = val_22;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_9 = System.Linq.Enumerable.OrderByDescending<UnityEngine.GameObject, System.Single>(source:  val_7, keySelector:  val_8);
            goto label_19;
            label_12:
            val_24 = null;
            val_24 = null;
            val_26 = UIScrollManager.<>c.<>9__16_3;
            if(val_26 == null)
            {
                    System.Func<UnityEngine.GameObject, System.Single> val_10 = null;
                val_26 = val_10;
                val_10 = new System.Func<UnityEngine.GameObject, System.Single>(object:  UIScrollManager.<>c.__il2cppRuntimeField_static_fields, method:  System.Single UIScrollManager.<>c::丘专丈丟丟与丞丑丅(UnityEngine.GameObject 丕上丙丝丅丛丐丏丑));
                UIScrollManager.<>c.<>9__16_3 = val_26;
            }
            
            label_19:
            val_27 = System.Linq.Enumerable.FirstOrDefault<UnityEngine.GameObject>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.GameObject, System.Single>(source:  val_7, keySelector:  val_10));
            goto label_25;
            label_13:
            val_27 = 0;
            label_25:
            if(val_27 == 0)
            {
                    return 0;
            }
            
            if(val_27 != 0)
            {
                    return val_27.transform;
            }
            
            return val_27.transform;
        }
        private void 世丅丘丄与丙专丗丌()
        {
            if(this.count >= 1)
            {
                    object val_10 = 0;
                do
            {
                UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Prefab, parent:  this.丙专丙业丘丁与七下().transform);
                val_3.gameObject.name = System.String.Format(format:  "{0}_{1}", arg0:  this.Prefab.name, arg1:  val_10);
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_3.gameObject, 丏业丟一东丂东丘丛:  true);
                UIGrid val_8 = this.丙专丙业丘丁与七下();
                val_10 = val_10 + 1;
            }
            while(val_10 < this.count);
            
            }
            
            this.不丆丝丗丕下丙一下().ResetPosition();
        }
        private void 丟丘丂丟下一丄专七()
        {
            var val_9;
            if(this.count >= 1)
            {
                    var val_10 = 0;
                var val_9 = 0;
                do
            {
                UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Prefab, parent:  this.丙丒上丙丏丏丂丞东().transform);
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_3.gameObject, 丏业丟一东丂东丘丛:  true);
                UIScrollView val_5 = this.不丆丝丗丕下丙一下();
                if(val_5.movement == 1)
            {
                    val_9 = val_10;
            }
            else
            {
                    val_9 = val_9;
            }
            
                this.丙丏丒丐丑三丆丝世(丝三丁东丈丒世丅业:  val_3, 丆丘丝丟丑丘丂丘专:  0, 丞丂业丅丟丙丏七丗:  0);
                UIWrapContent val_6 = this.丙丒上丙丏丏丂丞东();
                val_9 = val_9 + 1;
                val_10 = val_10 - 1;
            }
            while(val_9 < this.count);
            
            }
            
            UIWrapContent val_7 = this.丙丒上丙丏丏丂丞东();
            this.不丆丝丗丕下丙一下().ResetPosition();
        }
        private void 且上丛丂三丛且丟下()
        {
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.Prefab, parent:  this.丙丁不丂丝丛丁一七().transform);
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_3.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丙专丙业丘丁与七下().AddChild(丄上七丟不丗丕下丟:  val_3.transform);
        }
        private void 与东丁三丘不下丕丟()
        {
            goto label_1;
            label_9:
            UnityEngine.Object.Destroy(obj:  this.丙专丙业丘丁与七下().transform.GetChild(index:  0).gameObject);
            0 = 1;
            label_1:
            if(0 < this.丙专丙业丘丁与七下().transform.childCount)
            {
                goto label_9;
            }
        
        }
        private void Update()
        {
            if(this.Populate != false)
            {
                    this.Populate = false;
                if(this.丆三丐丞丐丘丂一一() != false)
            {
                    this.且丗世业丄丅且不丁();
                this.丟丘丂丟下一丄专七();
            }
            else
            {
                    this.世丅丘丄与丙专丗丌();
            }
            
            }
            
            if(this.center != false)
            {
                    this.center = false;
                if(this.丆三丐丞丐丘丂一一() != false)
            {
                    this.丗专不下丏下丐上丗(世万专丛与丐丌专不:  this.centerOn);
            }
            else
            {
                    this.丘丌东丗不且且丂丏(世万专丛与丐丌专不:  this.centerOn);
            }
            
            }
            
            if(this.add != false)
            {
                    if(this.丆三丐丞丐丘丂一一() != true)
            {
                    this.add = false;
                this.且上丛丂三丛且丟下();
            }
            
            }
            
            if(this.clean == false)
            {
                    return;
            }
            
            this.clean = false;
            this.与东丁三丘不下丕丟();
        }
        private void 且丗世业丄丅且不丁()
        {
            var val_18;
            int val_19;
            丙丏丒丐丑三丆丝世 val_20;
            丙丏丒丐丑三丆丝世 val_21;
            var val_22;
            this.丝丐丗丐与不丕丁丆.Clear();
            do
            {
                this.丝丐丗丐与不丕丁丆.Add(item:  0.ToString());
            }
            while(1 < 30);
            
            UIScrollView val_2 = this.不丆丝丗丕下丙一下();
            if(val_2.movement != 1)
            {
                goto label_5;
            }
            
            UIWrapContent val_3 = this.丙丒上丙丏丏丂丞东();
            int val_17 = 1;
            val_17 = val_17 - this.丝丐丗丐与不丕丁丆.Count;
            val_3.minIndex = val_17;
            UIWrapContent val_5 = this.丙丒上丙丏丏丂丞东();
            val_18 = val_5;
            if(val_18 == null)
            {
                goto label_27;
            }
            
            val_19 = 0;
            goto label_9;
            label_5:
            UIScrollView val_6 = this.不丆丝丗丕下丙一下();
            if(val_6.movement != 0)
            {
                goto label_11;
            }
            
            UIWrapContent val_7 = this.丙丒上丙丏丏丂丞东();
            val_7.minIndex = 0;
            val_18 = this.丙丒上丙丏丏丂丞东();
            val_19 = this.丝丐丗丐与不丕丁丆.Count - 1;
            label_9:
            val_8.maxIndex = val_19;
            label_11:
            val_20 = System.Delegate.Remove(source:  val_10.onInitializeItem, value:  new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.UIScrollManager::丙丏丒丐丑三丆丝世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)));
            if(this.丙丒上丙丏丏丂丞东() == null)
            {
                goto label_16;
            }
            
            if(val_20 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_20 == null)
            {
                goto label_20;
            }
            
            label_17:
            if(null != null)
            {
                    val_20 = 0;
            }
            
            label_20:
            val_10.onInitializeItem = val_20;
            val_21 = System.Delegate.Combine(a:  val_14.onInitializeItem, b:  new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.UIScrollManager::丙丏丒丐丑三丆丝世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)));
            if(this.丙丒上丙丏丏丂丞东() == null)
            {
                goto label_22;
            }
            
            if(val_21 != null)
            {
                goto label_23;
            }
            
            goto label_26;
            label_22:
            if(val_21 == null)
            {
                goto label_26;
            }
            
            label_23:
            if(null != null)
            {
                    val_21 = 0;
            }
            
            label_26:
            val_14.onInitializeItem = val_21;
            return;
            label_27:
            val_22 = val_5;
        }
        private void 丙丏丒丐丑三丆丝世(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)
        {
            var val_7;
            UIScrollView val_1 = this.不丆丝丗丕下丙一下();
            if(val_1.movement == 1)
            {
                    val_7 = -丞丂业丅丟丙丏七丗;
            }
            else
            {
                    UIScrollView val_2 = this.不丆丝丗丕下丙一下();
                object val_3 = (val_2.movement == 0) ? 丞丂业丅丟丙丏七丗 : 0;
            }
            
            UnityEngine.Debug.Log(message:  ">>> index: "(">>> index: ") + val_3);
            string val_5 = this.丝丐丗丐与不丕丁丆.Item[val_3];
            if(丝三丁东丈丒世丅业 != null)
            {
                    丝三丁东丈丒世丅业.name = val_5;
            }
            else
            {
                    0.name = val_5;
            }
            
            丝三丁东丈丒世丅业.GetComponentInChildren<UILabel>().text = val_5;
        }
        public UIScrollManager()
        {
            this.丝丐丗丐与不丕丁丆 = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
