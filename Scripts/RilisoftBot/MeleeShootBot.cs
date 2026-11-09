using UnityEngine;

namespace RilisoftBot
{
    internal sealed class MeleeShootBot : ShootingBot
    {
        // Fields
        private string 丒丑丛且丞丈丞丌丌;
        public RilisoftBot.MeleeShootBot.丞丑一丘丑业专丄一 attackType;
        private bool 专世业下丏丝下一丕;
        private bool 丝丝丕且三丘丗丟丝;
        public float maxTimeToShoot;
        public float meleeAttackDetect;
        public float meleeAttackDistance;
        public float meleeDamagePerHit;
        public float minTimeToShoot;
        private float 丈丞上世丝一丘上丝;
        private bool 丐万丝丙丞丝丒丟丑;
        
        // Methods
        private string 丁丘丑专与不丟且专()
        {
            if(137105408 != 0)
            {
                    return System.String.Format(format:  "{0}_shooting", arg0:  this.gameObject.name);
            }
            
            return (string)System.String.alignConst;
        }
        protected override void 上丛丌丆丑上七世三()
        {
            this.上丛丌丆丑上七世三();
            this.丒丑丛且丞丈丞丌丌 = this.丁丘丑专与不丟且专();
            float val_3 = UnityEngine.Random.Range(min:  this.minTimeToShoot, max:  this.maxTimeToShoot);
            val_3 = UnityEngine.Time.time + val_3;
            this.丈丞上世丝一丘上丝 = val_3;
        }
        public override void DelayShootAfterEvent(float 丆丐七丅丆丗丛上与)
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 + 丆丐七丅丆丗丛上与;
            if(this.丈丞上世丝一丘上丝 >= 0)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_2 = val_2 + 丆丐七丅丆丗丛上与;
            this.丈丞上世丝一丘上丝 = val_2;
        }
        public override bool CheckEnemyInAttackZone(float 七业三下专与丛丆丙)
        {
            bool val_4;
            float val_1 = this.GetSquareAttackDistance();
            this.丝丝丕且三丘丗丟丝 = false;
            if(val_1 <= 七业三下专与丛丆丙)
            {
                goto label_0;
            }
            
            float val_4 = this.meleeAttackDetect;
            val_4 = val_4 * val_4;
            if(val_4 > 七业三下专与丛丆丙)
            {
                    float val_5 = this.meleeAttackDistance;
                this.丝丝丕且三丘丗丟丝 = true;
                val_5 = val_5 * val_5;
                var val_2 = (val_5 > 七业三下专与丛丆丙) ? 1 : 0;
                return val_4;
            }
            
            if(this.attackType != 1)
            {
                goto label_5;
            }
            
            float val_3 = UnityEngine.Time.time;
            if(this.丈丞上世丝一丘上丝 < 0)
            {
                goto label_7;
            }
            
            if(this.attackType != 1)
            {
                goto label_5;
            }
            
            label_0:
            if(this.专世业下丏丝下一丕 == false)
            {
                goto label_6;
            }
            
            val_3 = val_3 * val_3;
            val_3 = val_1 + val_3;
            if(val_3 > 七业三下专与丛丆丙)
            {
                goto label_7;
            }
            
            label_6:
            val_4 = 0;
            this.专世业下丏丝下一丕 = false;
            return val_4;
            label_7:
            val_4 = 1;
            return val_4;
            label_5:
            val_4 = true;
            this.专世业下丏丝下一丕 = val_4;
            return val_4;
        }
        protected override void 下丐丂丂万丛丛万丆(UnityEngine.GameObject 丞下万上三丘上与专)
        {
            if(this.丐万丝丙丞丝丒丟丑 != false)
            {
                    this.丂丄丗业上丁丌丝东(丞下万上三丘上与专:  丞下万上三丘上与专);
                return;
            }
            
            if(this.attackType == 1)
            {
                    float val_2 = UnityEngine.Random.Range(min:  this.minTimeToShoot, max:  this.maxTimeToShoot);
                val_2 = UnityEngine.Time.time + val_2;
                this.丈丞上世丝一丘上丝 = val_2;
            }
            
            this.下丐丂丂万丛丛万丆(丞下万上三丘上与专:  丞下万上三丘上与专);
        }
        protected override void 丞丟丗丕丒下丞丟丑()
        {
            string val_7;
            string val_8;
            string val_9;
            if(this.丝丝丕且三丘丗丟丝 == false)
            {
                goto label_0;
            }
            
            val_7 = this.丒丑丛且丞丈丞丌丌;
            this.丐万丝丙丞丝丒丟丑 = true;
            if((UnityEngine.TrackedReference.op_Implicit(exists:  X20.Item[val_7])) == false)
            {
                goto label_2;
            }
            
            val_8 = this.丒丑丛且丞丈丞丌丌;
            if(X20 != 0)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            val_9 = val_8;
            goto label_4;
            label_0:
            this.丐万丝丙丞丝丒丟丑 = false;
            bool val_4 = UnityEngine.TrackedReference.op_Implicit(exists:  X20.Item[X21 + 16]);
            if(X22 == 0)
            {
                goto label_7;
            }
            
            if(val_4 == false)
            {
                goto label_8;
            }
            
            label_16:
            if(X20 != 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_2:
            if(X20 != 0)
            {
                goto label_17;
            }
            
            label_18:
            label_17:
            if((UnityEngine.TrackedReference.op_Implicit(exists:  X20.Item[val_7])) == false)
            {
                    return;
            }
            
            val_9 = X20 + 48;
            label_4:
            this.CrossFade(animation:  val_9);
            return;
            label_7:
            if(val_4 == true)
            {
                goto label_16;
            }
            
            label_8:
            if(X20 != 0)
            {
                goto label_17;
            }
            
            goto label_18;
        }
        private void 丂丄丗业上丁丌丝东(UnityEngine.GameObject 丞下万上三丘上与专)
        {
            UnityEngine.Transform val_1 = 丞下万上三丘上与专.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            float val_7 = this.meleeAttackDistance;
            val_7 = val_7 * val_7;
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) >= 0)
            {
                    return;
            }
            
            this.MakeDamage(丞下万上三丘上与专:  val_1);
        }
        public MeleeShootBot()
        {
            this.minTimeToShoot = 30f;
            this.maxTimeToShoot = ;
            this.meleeAttackDetect = ;
            this.meleeAttackDistance = 3f;
            this.meleeDamagePerHit = 5f;
        }
    
    }

}
