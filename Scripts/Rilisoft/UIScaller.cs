using UnityEngine;

namespace Rilisoft
{
    public class UIScaller : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector2 IndentsPercent;
        public UnityEngine.Transform RelativeTo;
        
        // Methods
        public void Execute()
        {
            var val_31;
            var val_32;
            float val_33;
            AnchorPoint val_36;
            var val_37;
            AnchorPoint val_38;
            var val_39;
            val_31 = this;
            if(this.RelativeTo == 0)
            {
                    return;
            }
            
            UIRect val_2 = this.RelativeTo.GetComponent<UIRect>();
            val_32 = this.gameObject;
            T[] val_4 = val_32.GetComponentsInChildren<UIRect>();
            if(val_4.Length == 0)
            {
                    return;
            }
            
            val_32 = val_4[0];
            if(val_4.Length >= 1)
            {
                    do
            {
                if((val_4[0x0][0] + 32) < 0)
            {
                    UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4[0x0][0] + 32, y:  val_4[0] + 36);
                val_33 = val_5.y;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_5.x, y = val_33});
                mem2[0] = val_6.x;
                mem2[0] = val_6.y;
                mem2[0] = val_6.z;
            }
            
                if((val_4[0x0][0] + 36) < 0)
            {
                    UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4[0] + 32, y:  val_4[0x0][0] + 36);
                val_33 = val_7.y;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_33});
                mem2[0] = val_8.x;
                mem2[0] = val_8.y;
                mem2[0] = val_8.z;
            }
            
                if((val_4[0x0][0] + 44) < 0)
            {
                    UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_4[0x0][0] + 44, y:  val_4[0] + 48);
                val_33 = val_9.y;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_33});
                mem2[0] = val_10.x;
                mem2[0] = val_10.y;
                mem2[0] = val_10.z;
            }
            
                if((val_4[0x0][0] + 48) > (val_4[0] + 48))
            {
                    UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_4[0] + 44, y:  val_4[0x0][0] + 48);
                val_33 = val_11.y;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_33});
                mem2[0] = val_12.x;
                mem2[0] = val_12.y;
                mem2[0] = val_12.z;
            }
            
                if((val_4[0x0][0] + 56) > (val_4[0] + 56))
            {
                    UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_4[0x0][0] + 56, y:  val_4[0] + 60);
                val_33 = val_13.y;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_33});
                mem2[0] = val_14.x;
                mem2[0] = val_14.y;
                mem2[0] = val_14.z;
            }
            
                if((val_4[0x0][0] + 60) > (val_4[0] + 60))
            {
                    UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  val_4[0] + 56, y:  val_4[0x0][0] + 60);
                val_33 = val_15.y;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_15.x, y = val_33});
                mem2[0] = val_16.x;
                mem2[0] = val_16.y;
                mem2[0] = val_16.z;
            }
            
                if((val_4[0x0][0] + 68) > (val_4[0] + 68))
            {
                    UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_4[0x0][0] + 68, y:  val_4[0] + 72);
                val_33 = val_17.y;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_33});
                mem2[0] = val_18.x;
                mem2[0] = val_18.y;
                mem2[0] = val_18.z;
            }
            
                if((val_4[0x0][0] + 72) < 0)
            {
                    UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_4[0] + 68, y:  val_4[0x0][0] + 72);
                val_33 = val_19.y;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_33});
                mem2[0] = val_20.x;
                mem2[0] = val_20.y;
                mem2[0] = val_20.z;
            }
            
                string val_22 = val_4[0].gameObject.name;
            }
            while((0 + 1) < val_4.Length);
            
            }
            
            val_36 = val_2.leftAnchor;
            if(val_36 == null)
            {
                    val_36 = val_2.leftAnchor;
            }
            
            val_37 = mem[val_4[0] + 24];
            val_37 = val_4[0] + 24;
            if(val_37 == 0)
            {
                    val_37 = mem[val_4[0] + 24];
                val_37 = val_4[0] + 24;
            }
            
            val_38 = val_2.leftAnchor;
            float val_34 = val_4[0] + 68;
            if(val_38 == null)
            {
                    val_38 = val_2.leftAnchor;
            }
            
            val_39 = mem[val_4[0] + 24];
            val_39 = val_4[0] + 24;
            if(val_39 == 0)
            {
                    val_39 = mem[val_4[0] + 24];
                val_39 = val_4[0] + 24;
            }
            
            float val_35 = val_4[0] + 48;
            val_34 = (val_4[0] + 32) - val_34;
            val_35 = (val_4[0] + 36) - val_35;
            val_35 = (S12 - val_2.topAnchor) / val_35;
            float val_26 = val_2.rightAnchor - val_20.z;
            val_26 = val_26 / val_34;
            val_26 = val_26 * this.IndentsPercent;
            val_31 = this.gameObject.transform;
            UnityEngine.Vector3 val_30 = val_31.localScale;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z}, d:  UnityEngine.Mathf.Min(a:  val_26, b:  val_35 * val_20.y));
            val_31.localScale = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
        }
        private UnityEngine.Bounds 丈丏丆丐一东业丆丆(UnityEngine.Vector3[] 丌丄下丌不丌丘丈丂)
        {
            UnityEngine.Bounds val_0;
            UnityEngine.Vector3 val_2 = 丌丄下丌不丌丘丈丂[0];
            UnityEngine.Vector3 val_3 = 丌丄下丌不丌丘丈丂[0];
            UnityEngine.Vector3 val_4 = 丌丄下丌不丌丘丈丂[1];
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            var val_5 = 1;
            do
            {
                val_5 = val_5 + 1;
            }
            while(val_5 != 4);
            
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        public UIScaller()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.IndentsPercent = val_2;
            mem[1152921543304590124] = val_2.y;
        }
    
    }

}
