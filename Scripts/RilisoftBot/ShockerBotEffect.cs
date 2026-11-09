using UnityEngine;

namespace RilisoftBot
{
    public class ShockerBotEffect : MonoBehaviour
    {
        // Fields
        public float damageInRadius;
        public float damageValue;
        private RilisoftBot.BaseBot 丛丒与丗丏三专上丅;
        private float 且丝一丈丟下丞丅与;
        public float timeToRadiusDamage;
        private System.Action<丅丙上七上一丐不下> 丐丝上七丘下上万七;
        
        // Methods
        private void Awake()
        {
            this.丛丒与丗丏三专上丅 = this.GetComponent<RilisoftBot.BaseBot>();
        }
        private void Update()
        {
            var val_6;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_15 = this;
            val_16 = null;
            val_16 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            if(this.且丝一丈丟下丞丅与 >= 0)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.time;
            val_3 = val_3 + this.timeToRadiusDamage;
            this.且丝一丈丟下丞丅与 = val_3;
            val_17 = null;
            val_17 = null;
            List.Enumerator<T> val_4 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
            label_12:
            if((2041571296 & 1) == 0)
            {
                goto label_11;
            }
            
            this.东丐丁丗丒丄世丄丞(丞下万上三丘上与专:  val_6.丐丏七丌丕丗业且上());
            goto label_12;
            label_11:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_18 = null;
            val_18 = null;
            List.Enumerator<T> val_8 = 丘丛丞且一丅丁丏丐.丟丙下上丞丕且丝一.GetEnumerator();
            label_22:
            if((2041571264 & 1) == 0)
            {
                goto label_20;
            }
            
            this.东丐丁丗丒丄世丄丞(丞下万上三丘上与专:  val_6.丐丏七丌丕丗业且上().transform);
            goto label_22;
            label_20:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_19 = null;
            val_19 = null;
            List.Enumerator<T> val_11 = 丘丛丞且一丅丁丏丐.丆丅丗丆七且丏丘丕.GetEnumerator();
            label_33:
            if((2041571264 & 1) == 0)
            {
                goto label_31;
            }
            
            this.东丐丁丗丒丄世丄丞(丞下万上三丘上与专:  val_6.丐丏七丌丕丗业且上().transform);
            goto label_33;
            label_31:
            val_20 = 0;
            val_15 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if(224 == 224)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        internal void 丄丟丝丄业丟丂丏丘(System.Action<丅丙上七上一丐不下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丐丝上七丘下上万七, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丝上七丘下上万七 != 1152921541008313568);
        
        }
        internal void 丄丏丑七业丏与且丞(System.Action<丅丙上七上一丐不下> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丐丝上七丘下上万七, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丐丝上七丘下上万七 != 1152921541008450144);
        
        }
        private void 东丐丁丗丒丄世丄丞(UnityEngine.Transform 丞下万上三丘上与专)
        {
            string val_12;
            float val_13;
            float val_14;
            val_12 = this;
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_13 = val_4.x;
            val_14 = val_4.z;
            UnityEngine.Vector3 val_6 = 丞下万上三丘上与专.transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = val_4.y, z = val_14}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            float val_12 = this.damageInRadius;
            val_12 = val_12 * val_12;
            if(val_7.x > val_12)
            {
                    return;
            }
            
            丅丙上七上一丐不下 val_8 = 丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  丞下万上三丘上与专);
            if(val_8 == null)
            {
                    return;
            }
            
            if((val_8 & 1) != 0)
            {
                    return;
            }
            
            if(this.丐丝上七丘下上万七 != null)
            {
                    this.丐丝上七丘下上万七.Invoke(obj:  val_8);
            }
            
            val_13 = this.damageValue;
            UnityEngine.Vector3 val_10 = this.丛丒与丗丏三专上丅.万丈且与七下上不专();
            val_14 = val_10.y;
            val_12 = "";
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_8.ApplyDamage(丞丈专下丈专业三丞:  val_13, 丛世一丟丞丁业丘丒:  this.丛丒与丗丏三专上丅, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_10.x, y = val_14, z = val_10.z}, 丐丟丘世丁三丕专专:  16, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  val_12, 丒丈丐丐丗丐专丈丏:  0);
        }
        private void 东丐丁丗丒丄世丄丞(Player_move_c 丞下万上三丘上与专)
        {
            RilisoftBot.BaseBot val_13;
            float val_14;
            float val_15;
            PlayerDamageable val_16;
            val_13 = this;
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_14 = val_4.x;
            val_15 = val_4.z;
            val_16 = 丞下万上三丘上与专.transform;
            UnityEngine.Vector3 val_6 = val_16.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14, y = val_4.y, z = val_15}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            float val_13 = this.damageInRadius;
            val_13 = val_13 * val_13;
            if(val_7.x > val_13)
            {
                    return;
            }
            
            val_16 = 丞下万上三丘上与专.丂七一业下丈业丕丒;
            if(val_16 == 0)
            {
                    return;
            }
            
            if(this.丐丝上七丘下上万七 != null)
            {
                    this.丐丝上七丘下上万七.Invoke(obj:  丞下万上三丘上与专.丂七一业下丈业丕丒);
            }
            
            val_16 = 丞下万上三丘上与专.丂七一业下丈业丕丒;
            val_13 = this.丛丒与丗丏三专上丅;
            val_14 = 丞下万上三丘上与专.与丙丕丛一丌丛丆丈.丝世不丑丒丏丄丑专(丂上不世业丒三世丕:  this.丛丒与丗丏三专上丅.丙丕丁丅丁与丗丑丘());
            UnityEngine.Vector3 val_11 = val_13.万丈且与七下上不专();
            val_15 = val_11.y;
            val_16.ApplyDamage(丞丈专下丈专业三丞:  this.damageValue * val_14, 丛世一丟丞丁业丘丒:  val_13, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_11.x, y = val_15, z = val_11.z}, 丐丟丘世丁三丕专专:  16, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        }
        public ShockerBotEffect()
        {
            this.damageInRadius = Infinityf;
            this.damageValue = 0.5f;
            this.timeToRadiusDamage = 0.5f;
        }
    
    }

}
