using UnityEngine;

namespace RilisoftBot
{
    internal class KamikadzeBot : BaseBot
    {
        // Fields
        public float detonationTime;
        public float detonationRadius;
        public string detonationExplosionName;
        private bool <七万世丙丝一七丒丌>k__BackingField;
        private float 与世世丟一丄丆丄不;
        private float 丁业下丙丘丁万丐丝;
        private float 丞丑七丟丏东丄丝丅;
        private bool 与专世丁一专东下丈;
        
        // Properties
        internal bool 上丌上上丟业丌丂丗 { get; set; }
        
        // Methods
        internal bool 业专丗丆三丐丕业丑()
        {
            return (bool)this.<七万世丙丝一七丒丌>k__BackingField;
        }
        private void 丙专丒东丒丄丞东丐(bool 丙业与丙丗丝不丈东)
        {
            this.<七万世丙丝一七丒丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected override void 上丛丌丆丑上七世三()
        {
            this.上丛丌丆丑上七世三();
        }
        internal void 一东专丅业丂丐上与()
        {
            if((this.<七万世丙丝一七丒丌>k__BackingField) != false)
            {
                    return;
            }
            
            float val_1 = this.与世世丟一丄丆丄不;
            this.<七万世丙丝一七丒丌>k__BackingField = true;
            val_1 = val_1 + this.detonationTime;
            this.与世世丟一丄丆丄不 = val_1;
        }
        protected override void Update()
        {
            float val_6;
            this.Update();
            if((this.<七万世丙丝一七丒丌>k__BackingField) == false)
            {
                    return;
            }
            
            if(this.与世世丟一丄丆丄不 > 0f)
            {
                    val_6 = this.与世世丟一丄丆丄不 - UnityEngine.Time.deltaTime;
                this.与世世丟一丄丆丄不 = val_6;
            }
            else
            {
                    this.<七万世丙丝一七丒丌>k__BackingField = false;
                UnityEngine.Vector3 val_2 = this.万丈且与七下上不专();
                this.ApplyDamage(丞丈专下丈专业三丞:  2.147484E+09f, 丛世一丟丞丁业丘丒:  0, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, 丐丟丘世丁三丕专专:  0, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
                val_6 = -2.147484E+09f;
                this.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  val_6, 一丗丈丛万丄世一丘:  0, 业一丘不万丂七上丝:  false, 丅业下不东丗丄与三:  0, 丝丅且丁万下业七万:  true);
            }
            
            if(this.丁业下丙丘丁万丐丝 > 0f)
            {
                    float val_3 = UnityEngine.Time.deltaTime;
                val_3 = this.丁业下丙丘丁万丐丝 - val_3;
                this.丁业下丙丘丁万丐丝 = val_3;
                return;
            }
            
            float val_6 = 0.8f;
            this.丁业下丙丘丁万丐丝 = this.丞丑七丟丏东丄丝丅;
            val_6 = this.丞丑七丟丏东丄丝丅 * val_6;
            this.丞丑七丟丏东丄丝丅 = val_6;
            this.与专世丁一专东下丈 = this.与专世丁一专东下丈 ^ 1;
            this.丟丘一丄一东且丐丗(丞七丛与丝下一一丆:  (this.与专世丁一专东下丈 == false) ? 1 : 0, 丌丒丕丄丑丌世不丐:  false);
        }
        public override bool CheckEnemyInAttackZone(float 七业三下专与丛丆丙)
        {
            return (bool)(this.GetSquareAttackDistance() >= 七业三下专与丛丆丙) ? 1 : 0;
        }
        protected override void 丑万万丞丘且与下丛()
        {
            this.三上世七七上丞不丛();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.七下下丗丕且万与丅(丕丕世且下一与丝与:  0f));
            enabled = false;
            if(137105408 == 0)
            {
                    return;
            }
            
            this.enabled = false;
        }
        private void 三上世七七上丞不丛()
        {
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            var val_31;
            var val_33;
            val_25 = this;
            UnityEngine.GameObject val_2 = RayAndExplosionsStackController.丄丞丁丈与业上丞丟.GetObjectFromName(丛丟丒且丌丂丗丑丞:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  "Explosions", 丌丗丏丏丛东专丁且:  this.detonationExplosionName));
            UnityEngine.Transform val_3 = this.transform;
            if(val_2 != 0)
            {
                    UnityEngine.Vector3 val_6 = val_3.position;
                val_2.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_15;
            }
            
            }
            
            val_26 = 1152921504691191808;
            val_27 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W22, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
            label_33:
            var val_30 = 0;
            val_30 = val_30 + 1;
            if(val_27.MoveNext() == false)
            {
                goto label_22;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            T val_14 = val_27.Current;
            UnityEngine.Vector3 val_15 = val_14.position;
            UnityEngine.Vector3 val_16 = val_3.position;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            float val_32 = this.detonationRadius;
            val_32 = val_32 * val_32;
            if(val_17.x > val_32)
            {
                goto label_33;
            }
            
            this.MakeDamage(丞下万上三丘上与专:  val_14);
            goto label_33;
            label_15:
            val_30 = 0;
            goto label_51;
            label_22:
            val_30 = 0;
            val_31 = 0;
            if(val_27 == null)
            {
                
            }
            else
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                val_27.Dispose();
            }
            
            if( != 1)
            {
                    if(282 == 282)
            {
                    return;
            }
            
            }
            
            label_51:
            val_33 = null;
            val_33 = null;
            val_26 = 1152921504686346240;
            val_27 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  true, 丆世上且丗与丕丂丘:  true, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  true, 与丌上专不丌丘东丑:  true, 丌万丅丏丈丝丄一丌:  true, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
            label_72:
            var val_34 = 0;
            val_34 = val_34 + 1;
            if(val_27.MoveNext() == false)
            {
                goto label_61;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            T val_24 = val_27.Current;
            UnityEngine.Vector3 val_25 = val_24.position;
            UnityEngine.Vector3 val_26 = val_3.position;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            float val_36 = this.detonationRadius;
            val_36 = val_36 * val_36;
            if(val_27.x > val_36)
            {
                goto label_72;
            }
            
            this.MakeDamage(丞下万上三丘上与专:  val_24);
            goto label_72;
            label_61:
            val_25 = 0;
            mem2[0] = 282;
            if(val_27 == null)
            {
                
            }
            else
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_27.Dispose();
            }
            
            if((0 + 1) != 1)
            {
                    if( == false)
            {
                    return;
            }
            
                if((1152921541005819488 + ((0 + 1)) << 2) == 282)
            {
                    return;
            }
            
                return;
            }
            
            if( == true)
            {
                    return;
            }
        
        }
        public KamikadzeBot()
        {
            this.detonationTime = 1.5f;
            this.detonationRadius = 0f;
            this.丞丑七丟丏东丄丝丅 = 0.2f;
            this.detonationExplosionName = "Explosion1";
        }
    
    }

}
