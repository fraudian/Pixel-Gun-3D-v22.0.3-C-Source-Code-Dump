using UnityEngine;

namespace RilisoftBot
{
    internal class ShootingBot : BaseShootingBot, 丆丈上丑丘丙专丆三, 丟一丘丛丟丑一且丞, 丙七丟丞丝丅丛丝丝
    {
        // Fields
        private const float 丗丂丟丂世丆丘万丕 = 0.5;
        private float 业七丁且一丑与丛七;
        public float angle;
        private System.Collections.Generic.List<UnityEngine.Transform> 上丁丛上丟且业丐下;
        public float damagePerHitMin;
        public UnityEngine.GameObject effectExplosion;
        public float force;
        public bool isCalculateSpeedBullet;
        public bool isMoveByPhysics;
        public bool isProjectileExplosion;
        public float radiusExplosion;
        public UnityEngine.AudioClip shootingSound;
        public float speedBullet;
        
        // Properties
        public bool 丅丙丟一丁下三丕丟 { get; set; }
        public float 东丁丝东丗丂七丝业 { get; set; }
        public UnityEngine.GameObject 专丅东丈且丏专丂业 { get; set; }
        public float 丅丘丁丝丑一业丄丒 { get; set; }
        public float 丁万丄与丐且世万且 { get; set; }
        
        // Methods
        protected override void 上丛丌丆丑上七世三()
        {
            this.上丛丌丆丑上七世三();
            if((UnityEngine.TrackedReference.op_Implicit(exists:  X20.Item[X21 + 16])) == false)
            {
                    return;
            }
            
            float val_4 = X20.Item[X21 + 16 + 16].length;
            val_4 = (S1 + S2) / val_4;
            this.业七丁且一丑与丛七 = val_4;
        }
        protected override void 七丌与丂专丈世东丌(int 上七丘丅上丁丅一丅)
        {
            东世丌丗丂丛丂丑下 val_7;
            float val_8;
            var val_9;
            this.七丌与丂专丈世东丌(上七丘丅上丁丅一丅:  上七丘丅上丁丅一丅);
            if(this.isCalculateSpeedBullet != false)
            {
                    val_8 = this.业七丁且一丑与丛七 * S3;
                this.speedBullet = val_8;
            }
            else
            {
                    val_8 = this.speedBullet;
            }
            
            val_9 = 0;
            goto label_3;
            label_14:
            val_7 = 0;
            int val_3 = 上七丘丅上丁丅一丅 + 0;
            BulletForBot val_4 = (上七丘丅上丁丅一丅 + 0) + 32.GetComponent<BulletForBot>();
            if(val_4 != 0)
            {
                    val_4.lifeTime = (S0 + S1) / val_8;
                BulletForBot.东世丌丗丂丛丂丑下 val_6 = null;
                val_7 = val_6;
                val_6 = new BulletForBot.东世丌丗丂丛丂丑下(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void RilisoftBot.ShootingBot::丈且与专丙丄丐丐丑(UnityEngine.GameObject 丞下万上三丘上与专, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙));
                if(val_4 != null)
            {
                    val_4.add_OnBulletDamage(丙业与丙丗丝不丈东:  val_6);
            }
            else
            {
                    val_4.add_OnBulletDamage(丙业与丙丗丝不丈东:  val_6);
            }
            
                val_4.needDestroyByStop = false;
            }
            
            val_9 = 1;
            label_3:
            if(val_9 < val_4.丒万不且且万丒丙一)
            {
                goto label_14;
            }
        
        }
        private BulletForBot 业万丛业丙三丕不一()
        {
            UnityEngine.GameObject val_1 = this.丝下丘丟丆东丞下丙();
            if(val_1 != null)
            {
                    return val_1.GetComponent<BulletForBot>();
            }
            
            return val_1.GetComponent<BulletForBot>();
        }
        private float 丛丞丈与丛且三丂丝()
        {
            if(this.isCalculateSpeedBullet == false)
            {
                    return (float)this.speedBullet;
            }
            
            float val_1 = this.业七丁且一丑与丛七;
            val_1 = val_1 * S1;
            this.speedBullet = val_1;
            return val_1;
        }
        private void 丈且与专丙丄丐丐丑(UnityEngine.GameObject 丞下万上三丘上与专, UnityEngine.Vector3 世丘丂丁七丐丐一专, bool 丂丘且丝丙上业世丙)
        {
            UnityEngine.GameObject val_38;
            float val_39;
            val_38 = 丞下万上三丘上与专;
            if(this.isProjectileExplosion == false)
            {
                goto label_1;
            }
            
            val_38 = this.effectExplosion;
            if(val_38 != 0)
            {
                    val_38 = this.effectExplosion;
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
                val_39 = val_2.y;
                UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_38, position:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z}, rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_39, z = val_2.z, w = val_2.w});
            }
            
            if(丂丘且丝丙上业世丙 == false)
            {
                    return;
            }
            
            if(val_5.Length == 0)
            {
                    return;
            }
            
            val_38 = this.上丁丛上丟且业丐下;
            val_38.Clear();
            if(val_5.Length < 1)
            {
                    return;
            }
            
            label_62:
            val_38 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z}, radius:  this.radiusExplosion, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丁丝丒丞不丑丈丆下())[0].gameObject;
            if(val_38 == 0)
            {
                goto label_60;
            }
            
            val_38 = val_5[0x0] + 32.transform;
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if(GameConnect.七丂万专且丏丘一丙() == false)
            {
                goto label_30;
            }
            
            }
            
            if((System.String.op_Inequality(a:  val_38.tag, b:  "HeadCollider")) != false)
            {
                    if((System.String.op_Inequality(a:  val_38.tag, b:  "BodyCollider")) != false)
            {
                    if(val_38.gameObject.layer != 27)
            {
                goto label_33;
            }
            
            }
            
            }
            
            label_30:
            val_38 = val_38.root;
            label_33:
            if(((val_38.gameObject == 0) || (this.丌丟丄业且三丛丕丄().gameObject == 0)) || ((val_38.Equals(other:  this.丌丟丄业且三丛丕丄())) == true))
            {
                goto label_60;
            }
            
            UnityEngine.Vector3 val_26 = val_38.position;
            val_39 = val_26.y;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_39, z = val_26.z}, b:  new UnityEngine.Vector3() {x = 世丘丂丁七丐丐一专.x, y = 世丘丂丁七丐丐一专.y, z = 世丘丂丁七丐丐一专.z});
            if(val_27.x > (this.radiusExplosion * this.radiusExplosion))
            {
                goto label_60;
            }
            
            if((GameConnect.丅丟下专不丁一丈七() == false) || ((val_38.CompareTag(tag:  "Enemy")) == false))
            {
                goto label_51;
            }
            
            RilisoftBot.BaseBot val_30 = val_38.GetComponent<RilisoftBot.BaseBot>();
            if(((val_30.世丗万丞世丂丂丕丝 == true) ? 1 : 0) == (((public System.Boolean UnityEngine.Object::Equals(object other)) != 0) ? 1 : 0))
            {
                goto label_60;
            }
            
            label_51:
            if(GameConnect.丅丟下专不丁一丈七() != true)
            {
                    if((val_38.CompareTag(tag:  "Enemy")) == true)
            {
                goto label_60;
            }
            
            }
            
            if((this.上丁丛上丟且业丐下.Contains(item:  val_38)) != true)
            {
                    this.MakeDamage(丞下万上三丘上与专:  val_38);
                this.上丁丛上丟且业丐下.Add(item:  val_38);
            }
            
            label_60:
            if((0 + 1) < val_5.Length)
            {
                goto label_62;
            }
            
            return;
            label_1:
            if(val_38 == 0)
            {
                    return;
            }
            
            this.MakeDamage(丞下万上三丘上与专:  val_38.transform);
        }
        protected override void 且丝丑丄丝不东丅丗(UnityEngine.Transform 丂丁丟世丗东丙丐丐, UnityEngine.GameObject 丞下万上三丘上与专)
        {
            this.且丝丑丄丝不东丅丗(丂丁丟世丗东丙丐丐:  丂丁丟世丗东丙丐丐, 丞下万上三丘上与专:  丞下万上三丘上与专);
            UnityEngine.Vector3 val_2 = 丞下万上三丘上与专.transform.position;
            float val_3 = val_2.y + 0.5f;
            UnityEngine.Vector3 val_4 = 丂丁丟世丗东丙丐丐.position;
            this.丁丗丈丈丛丅世不下(丂丁丟世丗东丙丐丐:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丅七丟上专一丈万丙:  new UnityEngine.Vector3() {x = val_2.x, y = val_3, z = val_2.z}, 丂丘且丝丙上业世丙:  true);
            if((GameConnect.丙丘不世专且万丄丐() != true) && (GameConnect.且丞丁东丝丗上丈业() != true))
            {
                    if(GameConnect.七丂万专且丏丘一丙() != true)
            {
                    if(GameConnect.丅丟下专不丁一丈七() == false)
            {
                    return;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_9 = 丂丁丟世丗东丙丐丐.position;
            this.FireByRPC(丂丁丟世丗东丙丐丐:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, 丅七丟上专一丈万丙:  new UnityEngine.Vector3() {x = val_2.x, y = val_3, z = val_2.z});
        }
        private void 丁丗丈丈丛丅世不下(UnityEngine.Vector3 丂丁丟世丗东丙丐丐, UnityEngine.Vector3 丅七丟上专一丈万丙, bool 丂丘且丝丙上业世丙)
        {
            float val_16;
            float val_17;
            float val_18;
            val_16 = 丅七丟上专一丈万丙.y;
            val_17 = 丂丁丟世丗东丙丐丐.z;
            BulletForBot val_1 = this.业万丛业丙三丕不一();
            if(this.isCalculateSpeedBullet != false)
            {
                    UnityEngine.AnimationState val_2 = X22.Item[X23 + 16];
                val_2.speed = V8.16B;
            }
            
            val_1.丗丞丝不三且不丕丘(丗不丛七丏丄业三丁:  this);
            if(this.isMoveByPhysics != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 丂丁丟世丗东丙丐丐.x, y = 丂丁丟世丗东丙丐丐.y, z = val_17}, b:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = val_16, z = 丅七丟上专一丈万丙.z});
                val_16 = this.angle;
                UnityEngine.Vector3 val_5 = this.丌丟丄业且三丛丕丄().right;
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.AngleAxis(angle:  val_16 - val_3.x, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                UnityEngine.Transform val_8 = this.丌丟丄业且三丛丕丄();
                UnityEngine.Vector3 val_9 = val_8.forward;
                UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_18 = this.force;
                val_17 = val_10.y;
                val_1.ApplyForceFroBullet(七丝丑丐东丅丒丁丂:  new UnityEngine.Vector3() {x = 丂丁丟世丗东丙丐丐.x, y = 丂丁丟世丗东丙丐丐.y, z = val_17}, 丂七丅一一丒且万丕:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = val_16, z = 丅七丟上专一丈万丙.z}, 丅上丝丟且专世丏与:  (val_8 != 0) ? 1 : 0, 丒东业丙一丙业丏丆:  val_18, 丅丕万丐不丄丗且七:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.z, z = val_3.x}, 丂丘且丝丙上业世丙:  丂丘且丝丙上业世丙);
            }
            else
            {
                    if(this.isCalculateSpeedBullet != false)
            {
                    val_18 = this.业七丁且一丑与丛七 * 丂丁丟世丗东丙丐丐.y;
                this.speedBullet = val_18;
            }
            else
            {
                    val_18 = this.speedBullet;
            }
            
                val_1.StartBullet(七丝丑丐东丅丒丁丂:  new UnityEngine.Vector3() {x = 丂丁丟世丗东丙丐丐.x, y = 丂丁丟世丗东丙丐丐.y, z = val_17}, 丂七丅一一丒且万丕:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = val_16, z = 丅七丟上专一丈万丙.z}, 丘丛丝世丄丄丑三丁:  val_18, 丅上丝丟且专世丏与:  (val_2 != 0) ? 1 : 0, 丂丘且丝丙上业世丙:  丂丘且丝丙上业世丙);
            }
            
            this.TryPlayAudioClip(丆与丈丏丟七丁东丛:  this.shootingSound);
        }
        public override bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_7;
            var val_8;
            int val_9;
            int val_10;
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            if(this.IsDead() != false)
            {
                    return true;
            }
            
            byte val_2 = 丞世不丒下上上丝丑 & 255;
            if(val_2 > 44)
            {
                goto label_2;
            }
            
            if(val_2 > 24)
            {
                goto label_3;
            }
            
            byte val_3 = 丞世不丒下上上丝丑 & 255;
            if(val_3 == 11)
            {
                goto label_4;
            }
            
            if(val_3 != 24)
            {
                    return true;
            }
            
            if(专丒丌丆下丐丞丟丞 == null)
            {
                goto label_6;
            }
            
            val_7 = 专丒丌丆下丐丞丟丞;
            val_8 = 专丒丌丆下丐丞丟丞.Length;
            if(专丒丌丆下丐丞丟丞.Length != 0)
            {
                goto label_40;
            }
            
            goto label_8;
            label_2:
            if(val_2 > 92)
            {
                goto label_9;
            }
            
            byte val_4 = 丞世不丒下上上丝丑 & 255;
            if(val_4 == 61)
            {
                goto label_10;
            }
            
            if(val_4 != 92)
            {
                    return true;
            }
            
            val_9 = 专丒丌丆下丐丞丟丞.Length;
            if(val_9 == 0)
            {
                    val_9 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_7 = 专丒丌丆下丐丞丟丞[0];
            object val_8 = 专丒丌丆下丐丞丟丞[1];
            this.丁丗丈丈丛丅世不下(丂丁丟世丗东丙丐丐:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 丅七丟上专一丈万丙:  new UnityEngine.Vector3() {x = 3.782474E-38f}, 丂丘且丝丙上业世丙:  false);
            return true;
            label_3:
            byte val_5 = 丞世不丒下上上丝丑 & 255;
            if(val_5 == 43)
            {
                goto label_16;
            }
            
            if(val_5 != 44)
            {
                    return true;
            }
            
            this.丞丘世丙丂丂专业专();
            return true;
            label_9:
            byte val_6 = 丞世不丒下上上丝丑 & 255;
            if(val_6 == 191)
            {
                goto label_19;
            }
            
            if(val_6 == 204)
            {
                goto label_20;
            }
            
            if(val_6 != 205)
            {
                    return true;
            }
            
            this.HardKillMob();
            return true;
            label_4:
            val_10 = 专丒丌丆下丐丞丟丞.Length;
            if(val_10 == 0)
            {
                    val_10 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_9 = 专丒丌丆下丐丞丟丞[0];
            if(val_10 <= 1)
            {
                    val_10 = 专丒丌丆下丐丞丟丞.Length;
            }
            
            object val_10 = 专丒丌丆下丐丞丟丞[1];
            object val_11 = 专丒丌丆下丐丞丟丞[2];
            this.且丐不丆丈丛丝丛丗(丗一丏上丛丑丗丏丁:  21884928, 丘七丛丂专丅丛业丑:  3.782474E-38f, 丈丛丂一丝丘丁丌丝:  3.782474E-38f);
            return true;
            label_10:
            object val_12 = 专丒丌丆下丐丞丟丞[0];
            this.丝丁三丏三一且丟且(丙专丅丂世丂世丅丆:  3.782474E-38f);
            return true;
            label_16:
            this.且专丐丅业丄上丟丈();
            return true;
            label_19:
            this.丝丄丒下丁不丕丘丐();
            return true;
            label_20:
            if(专丒丌丆下丐丞丟丞 == null)
            {
                goto label_34;
            }
            
            val_11 = 专丒丌丆下丐丞丟丞;
            val_12 = 专丒丌丆下丐丞丟丞.Length;
            if(val_12 >= 2)
            {
                goto label_35;
            }
            
            label_47:
            if(val_12 == 0)
            {
                    return true;
            }
            
            if(专丒丌丆下丐丞丟丞 == null)
            {
                    val_13 = mem[专丒丌丆下丐丞丟丞 + 24];
                val_13 = 专丒丌丆下丐丞丟丞 + 24;
            }
            
            object val_13 = 专丒丌丆下丐丞丟丞[0];
            val_14 = 0;
            goto label_39;
            label_6:
            val_7 = 24;
            val_8 = 28563616;
            if(28563616 != 0)
            {
                goto label_40;
            }
            
            label_8:
            label_40:
            object val_14 = 专丒丌丆下丐丞丟丞[0];
            object val_15 = 专丒丌丆下丐丞丟丞[1];
            if(val_8 == 3)
            {
                    object val_16 = 专丒丌丆下丐丞丟丞[2];
                val_16 = 1152921504628731904;
            }
            else
            {
                    val_15 = 0;
            }
            
            this.万不丄下丂三丕丒不(丞丈专下丈专业三丞:  3.782474E-38f, 丗东丏与上丆丌不且:  21884928, 丂东丄丏丕丕丅上一:  0);
            return true;
            label_34:
            val_11 = 24;
            val_17 = 28563616;
            if(28563616 < 2)
            {
                goto label_47;
            }
            
            label_35:
            object val_17 = 专丒丌丆下丐丞丟丞[0];
            object val_18 = 专丒丌丆下丐丞丟丞[1];
            label_39:
            this.世一丘丗丛专丐丌一(丙专丅丂世丂世丅丆:  3.782474E-38f, 丘丞丛万世丈丅丂丆:  false);
            return true;
        }
        private void 丑丗丁丄丛丒世三丗(UnityEngine.Vector3 丂丁丟世丗东丙丐丐, UnityEngine.Vector3 丅七丟上专一丈万丙)
        {
            this.丁丗丈丈丛丅世不下(丂丁丟世丗东丙丐丐:  new UnityEngine.Vector3() {x = 丂丁丟世丗东丙丐丐.x, y = 丂丁丟世丗东丙丐丐.y, z = 丂丁丟世丗东丙丐丐.z}, 丅七丟上专一丈万丙:  new UnityEngine.Vector3() {x = 丅七丟上专一丈万丙.x, y = 丅七丟上专一丈万丙.y, z = 丅七丟上专一丈万丙.z}, 丂丘且丝丙上业世丙:  false);
        }
        protected override void 丞丐丅丆丕丕一丏丌()
        {
        
        }
        public bool get_p_isProjectileExplosion()
        {
            return (bool)this.isProjectileExplosion;
        }
        public void set_p_isProjectileExplosion(bool 丙业与丙丗丝不丈东)
        {
            this.isProjectileExplosion = 丙业与丙丗丝不丈东;
        }
        public float get_p_damagePerHitMin()
        {
            return (float)this.damagePerHitMin;
        }
        public void set_p_damagePerHitMin(float 丙业与丙丗丝不丈东)
        {
            this.damagePerHitMin = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.GameObject get_p_effectExplosion()
        {
            return (UnityEngine.GameObject)this.effectExplosion;
        }
        public void set_p_effectExplosion(UnityEngine.GameObject 丙业与丙丗丝不丈东)
        {
            this.effectExplosion = 丙业与丙丗丝不丈东;
        }
        public float get_p_radiusExplosion()
        {
            return (float)this.radiusExplosion;
        }
        public void set_p_radiusExplosion(float 丙业与丙丗丝不丈东)
        {
            this.radiusExplosion = 丙业与丙丗丝不丈东;
        }
        public float get_p_speedBullet()
        {
            return (float)this.speedBullet;
        }
        public void set_p_speedBullet(float 丙业与丙丗丝不丈东)
        {
            this.speedBullet = 丙业与丙丗丝不丈东;
        }
        public ShootingBot()
        {
            this.angle = -10f;
            this.上丁丛上丟且业丐下 = new System.Collections.Generic.List<UnityEngine.Transform>();
            this.force = 14f;
            this.speedBullet = 10f;
        }
    
    }

}
