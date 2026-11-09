using UnityEngine;

namespace RilisoftBot
{
    internal class BaseShootingBot : BaseBot, 丟一丘丛丟丑一且丞, 丙七丟丞丝丅丛丝丝
    {
        // Fields
        protected const int 与丌丑丙丆丌丂丐丅 = 4;
        private bool 丄丁上丑不丗丟丅下;
        private int 世万一业丝万丛丞七;
        private int 三丗丑丂丝与丛且丗;
        public UnityEngine.GameObject bulletPrefab;
        protected UnityEngine.GameObject[] 不东不不丅业丄一丙;
        public UnityEngine.Transform[] firePoints;
        public UnityEngine.Transform headPoint;
        public bool isFriendlyFire;
        public bool isSequentialShooting;
        public float rangeShootingDistance;
        
        // Properties
        public float 丒丐丒丘丞与下一丗 { get; set; }
        public bool 世且丂七丆世业与专 { get; set; }
        
        // Methods
        protected override void 上丛丌丆丑上七世三()
        {
            this.上丛丌丆丑上七世三();
            mem2[0] = this.丒丈丆七丞丁七丌丈();
            RilisoftBot.BotAnimationEventHandler val_2 = this.GetComponentInChildren<RilisoftBot.BotAnimationEventHandler>();
            if(val_2 != 0)
            {
                    BotAnimationEventHandler.丁丅不丟东且丏专丘 val_4 = new BotAnimationEventHandler.丁丅不丟东且丏专丘(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_610);
                val_2.业东不丘丁丟东且且(丙业与丙丗丝不丈东:  val_4);
            }
            
            if((UnityEngine.TrackedReference.op_Implicit(exists:  val_2.Item[val_4])) != false)
            {
                    val_2.Item[val_4].speed = V8.16B;
            }
            
            this.丄丁上丑不丗丟丅下 = false;
        }
        internal override void 下丌业业丐丘丐丘三()
        {
            this.下丌业业丐丘丐丘三();
            mem2[0] = this.丒丈丆七丞丁七丌丈();
            RilisoftBot.BotAnimationEventHandler val_2 = this.GetComponentInChildren<RilisoftBot.BotAnimationEventHandler>();
            if(val_2 != 0)
            {
                    val_2.丌万不三东丗丐丕丘(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.丁丅不丟东且丏专丘(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_610));
                BotAnimationEventHandler.丁丅不丟东且丏专丘 val_5 = new BotAnimationEventHandler.丁丅不丟东且丏专丘(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_610);
                val_2.业东不丘丁丟东且且(丙业与丙丗丝不丈东:  val_5);
            }
            
            val_2.Item[val_5].speed = V8.16B;
        }
        internal override void 不与丞下业丑丒丙万()
        {
            this.不与丞下业丑丒丙万();
            RilisoftBot.BotAnimationEventHandler val_1 = this.GetComponentInChildren<RilisoftBot.BotAnimationEventHandler>();
            if(val_1 == 0)
            {
                    return;
            }
            
            new BotAnimationEventHandler.丁丅不丟东且丏专丘() = new BotAnimationEventHandler.丁丅不丟东且丏专丘(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_610);
            val_1.丌万不三东丗丐丕丘(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.丁丅不丟东且丏专丘());
        }
        internal string 丒丈丆七丞丁七丌丈()
        {
            if(static_value_082C4000 != 0)
            {
                    return System.String.Format(format:  "{0}_shooting", arg0:  this.gameObject.name);
            }
            
            return (string)System.String.alignConst;
        }
        protected virtual void 七丌与丂专丈世东丌(int 上七丘丅上丁丅一丅)
        {
            UnityEngine.Transform[] val_3;
            int val_3 = 上七丘丅上丁丅一丅;
            val_3 = this.firePoints;
            val_3 = this.firePoints.Length * val_3;
            this.不东不不丅业丄一丙 = new UnityEngine.GameObject[0];
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            label_11:
            val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bulletPrefab);
            if(this.不东不不丅业丄一丙 == null)
            {
                goto label_5;
            }
            
            if(val_3 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_3 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_4 = val_4 + 1;
            this.不东不不丅业丄一丙[val_4] = val_3;
            if(val_3 != val_4)
            {
                goto label_11;
            }
        
        }
        protected virtual UnityEngine.Transform 七丒丏丑丙丛丅丝一()
        {
            int val_1 = this.世万一业丝万丛丞七 + 1;
            this.世万一业丝万丛丞七 = val_1;
            if(val_1 >= this.firePoints.Length)
            {
                    this.世万一业丝万丛丞七 = 0;
            }
            
            return (UnityEngine.Transform)this.firePoints[this.世万一业丝万丛丞七];
        }
        protected virtual void 下丐丂丂万丛丛万丆(UnityEngine.GameObject 丞下万上三丘上与专)
        {
            var val_9;
            UnityEngine.Transform[] val_10;
            var val_11;
            var val_13;
            val_9 = this;
            val_10 = this.firePoints;
            val_11 = 丞下万上三丘上与专;
            if(this.firePoints.Length != 1)
            {
                goto label_1;
            }
            
            val_10 = this.firePoints;
            UnityEngine.Transform val_9 = val_10[0];
            goto label_4;
            label_1:
            if(this.isSequentialShooting == false)
            {
                goto label_5;
            }
            
            label_4:
            val_9 = ???;
            val_11 = ???;
            goto typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_5F8;
            label_5:
            val_13 = 0;
            goto label_6;
            label_10:
            var val_1 = (val_9 + 744) + 0;
            val_13 = 1;
            label_6:
            if(val_13 < (val_9 + 744 + 24))
            {
                goto label_10;
            }
        
        }
        protected virtual void 且丝丑丄丝不东丅丗(UnityEngine.Transform 丂丁丟世丗东丙丐丐, UnityEngine.GameObject 丞下万上三丘上与专)
        {
        
        }
        protected UnityEngine.GameObject 丝下丘丟丆东丞下丙()
        {
            int val_1 = this.三丗丑丂丝与丛且丗 + 1;
            this.三丗丑丂丝与丛且丗 = val_1;
            if(val_1 >= this.不东不不丅业丄一丙.Length)
            {
                    this.三丗丑丂丝与丛且丗 = 0;
            }
            
            return (UnityEngine.GameObject)this.不东不不丅业丄一丙[this.三丗丑丂丝与丛且丗];
        }
        protected virtual void 丘丝万三与丂上丆丘()
        {
            if(static_value_082C4000 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = currentTarget;
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = val_2.currentTarget.gameObject;
            goto typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_5E8;
        }
        internal void 丟丑丙七丁三丞丕丁(UnityEngine.GameObject 丞下万上三丘上与专)
        {
            if(丞下万上三丘上与专 != 0)
            {
                goto typeof(RilisoftBot.BaseShootingBot).__il2cppRuntimeField_5E8;
            }
        
        }
        public override bool CheckEnemyInAttackZone(float 七业三下专与丛丆丙)
        {
            bool val_2;
            float val_1 = S1 * S1;
            if(val_1 > 七业三下专与丛丆丙)
            {
                    val_2 = 1;
            }
            else
            {
                    val_2 = this.丄丁上丑不丗丟丅下;
                if(val_2 != false)
            {
                    float val_2 = this.rangeShootingDistance;
                val_2 = val_2 * val_2;
                val_1 = val_1 + val_2;
                if(val_1 > 七业三下专与丛丆丙)
            {
                    return val_2;
            }
            
                val_2 = false;
            }
            
            }
            
            this.丄丁上丑不丗丟丅下 = val_2;
            return val_2;
        }
        public override float GetMaxAttackDistance()
        {
            float val_2 = this.rangeShootingDistance;
            val_2 = val_2 * val_2;
            val_2 = val_2 + (S1 * S1);
            return (float)val_2;
        }
        public override UnityEngine.Vector3 GetHeadPoint()
        {
            if(this.headPoint == 0)
            {
                    return this.GetHeadPoint();
            }
            
            if(this.headPoint != null)
            {
                    return this.headPoint.position;
            }
            
            return this.headPoint.position;
        }
        public float get_p_rangeShootingDistance()
        {
            return (float)this.rangeShootingDistance;
        }
        public void set_p_rangeShootingDistance(float 丙业与丙丗丝不丈东)
        {
            this.rangeShootingDistance = 丙业与丙丗丝不丈东;
        }
        public bool get_p_isFriendlyFire()
        {
            return (bool)this.isFriendlyFire;
        }
        public void set_p_isFriendlyFire(bool 丙业与丙丗丝不丈东)
        {
            this.isFriendlyFire = 丙业与丙丗丝不丈东;
        }
        public BaseShootingBot()
        {
            this.rangeShootingDistance = 10f;
        }
    
    }

}
