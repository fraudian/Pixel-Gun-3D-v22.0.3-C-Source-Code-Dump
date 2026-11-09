using UnityEngine;

namespace Rilisoft
{
    internal sealed class NetworkPetEngineSynch : VTableHolder, 东丁丆一业丈万丆丐
    {
        // Fields
        private Rilisoft.NetworkPetEngineSynch.丝丙丒丌东下丕丘丘[] 东专业丑与丐丆丐丟;
        private UnityEngine.Vector3 丞上业丐丞丝不丐专;
        private double 丌丟丗下专丙丕不丘;
        private UnityEngine.Quaternion 丘丐丐不丐丁丛且丝;
        private UnityEngine.Transform 万一丂丐丄丁上与丟;
        private double 下丟丒丁下丄丕丂专;
        private int 三与丅业上丏与与丛;
        private bool 丝丝丁且丈丂丛丐丏;
        public Rilisoft.丘且一万丏丕丝丘丁 currentAnimation;
        private int 丞丒丏丛丘丒丂业世;
        public bool isTeleported;
        private bool 上丅丝世且与与下丄;
        private bool 丌且下丕下下丌万丞;
        private bool 一一丆丌专丑丏丕丗;
        private Rilisoft.PetEngine 丅丟七丈七三一丏万;
        private bool 丁一上一与丆丌世丈;
        private bool 丅且业丑且丄不丟丒;
        
        // Methods
        internal NetworkPetEngineSynch()
        {
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.丘丐丐不丐丁丛且丝 = val_1;
            mem[1152921543360951436] = val_1.y;
            mem[1152921543360951440] = val_1.z;
            mem[1152921543360951444] = val_1.w;
            this.三与丅业上丏与与丛 = 8;
            this.丝丝丁且丈丂丛丐丏 = true;
            this.上丅丝世且与与下丄 = true;
            Rilisoft.且三与世丁丏丂丌下 val_2 = this.与丑丌丌丌丁丌不丕();
            val_2.丁万丂丝丘业丈丛丘 = new System.Action<下丌丙丘丈丌世万专, 业丘丘丘丁丂丕万东>(object:  this, method:  System.Void Rilisoft.NetworkPetEngineSynch::OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐));
        }
        private void Awake()
        {
            var val_5;
            丝丙丒丌东下丕丘丘[] val_6;
            val_5 = null;
            val_5 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != true)
            {
                    this.enabled = false;
            }
            
            this.万一丂丐丄丁上与丟 = this.transform;
            this.丞上业丐丞丝不丐专 = 0;
            mem[1152921543361129976] = 0;
            val_6 = new 丝丙丒丌东下丕丘丘[0];
            this.东专业丑与丐丆丐丟 = val_6;
            if(this.三与丅业上丏与与丛 < 1)
            {
                goto label_4;
            }
            
            var val_6 = 0;
            goto label_5;
            label_8:
            val_6 = this.东专业丑与丐丆丐丟;
            label_5:
            var val_3 = val_6 + (0 * 48);
            mem2[0] = 0;
            val_6 = val_6 + 1;
            if(val_6 < this.三与丅业上丏与与丛)
            {
                goto label_8;
            }
            
            label_4:
            this.下丟丒丁下丄丕丂专 = 1;
            Rilisoft.PetEngine val_4 = this.GetComponent<Rilisoft.PetEngine>();
            this.丅丟七丈七三一丏万 = val_4;
            val_4.add_OnStateChanged(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.丛七下丌丑不一丄业, Rilisoft.丛七下丌丑不一丄业>(object:  this, method:  System.Void Rilisoft.NetworkPetEngineSynch::丁丗丗丗三东丗丂三(Rilisoft.丛七下丌丑不一丄业 丟丄丈上丌东丑丝三, Rilisoft.丛七下丌丑不一丄业 专丟丈七丘丑丁世业)));
        }
        private void Start()
        {
            null = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
            if(this.photonView.isMine == false)
            {
                    return;
            }
            
            this.丌且下丕下下丌万丞 = true;
        }
        private void 丁丗丗丗三东丗丂三(Rilisoft.丛七下丌丑不一丄业 丟丄丈上丌东丑丝三, Rilisoft.丛七下丌丑不一丄业 专丟丈七丘丑丁世业)
        {
            var val_1;
            var val_2;
            if(丟丄丈上丌东丑丝三 == 7)
            {
                goto label_0;
            }
            
            if(丟丄丈上丌东丑丝三 != 5)
            {
                goto label_1;
            }
            
            val_1 = 1;
            val_2 = 0;
            goto label_2;
            label_0:
            this.一丅三丁上专丕一丝(丏业丟一东丂东丘丛:  false, 丆下一丌东丞与丏不:  false);
            label_1:
            if(专丟丈七丘丑丁世业 != 7)
            {
                    return;
            }
            
            val_2 = 1;
            val_1 = 1;
            label_2:
            this.一丅三丁上专丕一丝(丏业丟一东丂东丘丛:  true, 丆下一丌东丞与丏不:  true);
        }
        private void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
        {
            object val_19;
            string val_20;
            float val_21;
            val_20 = this;
            if(东业丄丅丅且世七丄.丕专丏万下不丞丐丛() != false)
            {
                    UnityEngine.Vector3 val_2 = this.万一丂丐丄丁上与丟.position;
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_2);
                UnityEngine.Quaternion val_3 = this.万一丂丐丄丁上与丟.rotation;
                float val_19 = 10f;
                val_19 = val_3.y * val_19;
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  (int)val_19);
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.currentAnimation);
                byte val_6 = System.Convert.ToByte(value:  (this.isTeleported == true) ? 1 : 0);
                val_19 = val_6;
                东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  val_6);
                this.isTeleported = false;
                if(UnityEngine.Application.isEditor == false)
            {
                    return;
            }
            
                val_20 = "Stream " + this.GetType();
                丅丑丞上丛丆东丟丂.三丅丐业丙丕丙业丕(丑与丆丝丕东丛丄丝:  val_20, 丗丟上上丒丐丗丞丙:  东业丄丅丅且世七丄.东与上丗与丏下丂丘());
                return;
            }
            
            if(this.上丅丝世且与与下丄 != false)
            {
                    this.上丅丝世且与与下丄 = false;
                return;
            }
            
            object val_11 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            this.丞上业丐丞丝不丐专 = new UnityEngine.Vector3();
            mem[1152921543361659464] = ???;
            object val_12 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            val_21 = (1.152922E+18f) / 10f;
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_21, z:  0f);
            this.丘丐丐不丐丁丛且丝 = val_13;
            mem[1152921543361659484] = val_13.y;
            mem[1152921543361659488] = val_13.z;
            mem[1152921543361659492] = val_13.w;
            object val_14 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            this.丌丟丗下专丙丕不丘 = null;
            object val_15 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
            bool val_18 = System.Convert.ToBoolean(value:  东业丄丅丅且世七丄.与万三丘与专丛丄七());
            this.isTeleported = val_18;
            if(val_18 == true)
            {
                goto label_31;
            }
            
            val_21 = 1000f;
            float val_20 = (float)this.下丟丒丁下丄丕丂专;
            val_20 = val_20 - (float)this.丌丟丗下专丙丕不丘;
            if(System.Math.Abs(val_20) <= val_21)
            {
                goto label_34;
            }
            
            label_31:
            this.丝丝丁且丈丂丛丐丏 = true;
            this.下丟丒丁下丄丕丂专 = this.丌丟丗下专丙丕不丘;
            label_34:
            if(this.丅且业丑且丄不丟丒 == true)
            {
                    return;
            }
            
            this.专丘丐丐世专丆丗上(丑丏与上不丐丘丕丐:  new UnityEngine.Vector3() {x = this.丞上业丐丞丝不丐专, y = val_21, z = (float)this.丌丟丗下专丙丕不丘}, 丝丏丏东丘丐丝下不:  new UnityEngine.Quaternion() {x = this.丘丐丐不丐丁丛且丝}, 丄丆万一丙丂丕不丐:  this.丌丟丗下专丙丕不丘, 丆丄七丙丅丈上丞一:  21884928, 丛丂丟一且丒丁东三:  this.isTeleported);
        }
        private void Update()
        {
            var val_30;
            double val_31;
            double val_32;
            float val_33;
            Rilisoft.PetEngine val_34;
            var val_35;
            UnityEngine.AudioClip val_36;
            if(this.丌且下丕下下丌万丞 == true)
            {
                    return;
            }
            
            if(this.丅丟七丈七三一丏万.万东丂七东丁与业东() == 0)
            {
                    return;
            }
            
            if(this.丅丟七丈七三一丏万.丐丂丌丗丆丛东丘丁() == false)
            {
                goto label_7;
            }
            
            if(this.丅丟七丈七三一丏万.万东丂七东丁与业东() == 0)
            {
                goto label_14;
            }
            
            Player_move_c val_6 = this.丅丟七丈七三一丏万.万东丂七东丁与业东();
            if(val_6.万丝一万丐且丌业丛 == false)
            {
                goto label_14;
            }
            
            label_7:
            this.丅丟七丈七三一丏万.丂丌不丝丂下丙专东(丙业与丙丗丝不丈东:  true);
            label_14:
            if(this.丅且业丑且丄不丟丒 == true)
            {
                    return;
            }
            
            if(this.丅丟七丈七三一丏万.丐丂丌丗丆丛东丘丁() == false)
            {
                    return;
            }
            
            if(this.丝丝丁且丈丂丛丐丏 == false)
            {
                goto label_19;
            }
            
            var val_30 = -4294967296;
            val_30 = val_30 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            val_30 = val_30 >> 32;
            var val_31 = 48;
            val_31 = this.东专业丑与丐丆丐丟 + (val_30 * val_31);
            if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 72) == 0)
            {
                goto label_116;
            }
            
            var val_32 = -4294967296;
            val_32 = val_32 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_33 = 48;
            val_33 = this.东专业丑与丐丆丐丟 + ((val_32 >> 32) * val_33);
            this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 32, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 40};
            var val_34 = -4294967296;
            val_34 = val_34 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_35 = 48;
            val_35 = this.东专业丑与丐丆丐丟 + ((val_34 >> 32) * val_35);
            this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 44, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 52, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 52 + 4};
            var val_36 = -4294967296;
            val_36 = val_36 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            val_30 = val_36 >> 32;
            var val_37 = 48;
            val_37 = this.东专业丑与丐丆丐丟 + (val_30 * val_37);
            this.下丟丒丁下丄丕丂专 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 64;
            if(this.丅丟七丈七三一丏万 != null)
            {
                goto label_74;
            }
            
            label_75:
            label_74:
            this.丅丟七丈七三一丏万.丗丑丝丕上丙世丆下();
            label_116:
            if(this.丅丟七丈七三一丏万.万东丂七东丁与业东() != 0)
            {
                    Player_move_c val_12 = this.丅丟七丈七三一丏万.万东丂七东丁与业东();
                if(val_12.万丝一万丐且丌业丛 != false)
            {
                    if(this.丁一上一与丆丌世丈 != true)
            {
                    this.丁一上一与丆丌世丈 = true;
                this.丅丟七丈七三一丏万.丗丑丝丕上丙世丆下();
            }
            
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.down;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  10000f);
                this.transform.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                return;
            }
            
            }
            
            this.丁一上一与丆丌世丈 = false;
            if(this.丅丟七丈七三一丏万.一不丑一丑一丛丘丙() == false)
            {
                    return;
            }
            
            this.丅丟七丈七三一丏万.丞丘丏丏丂一丞业七();
            return;
            label_19:
            float val_39 = UnityEngine.Time.deltaTime;
            var val_38 = -4294967296;
            val_38 = val_38 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_19 = this.东专业丑与丐丆丐丟 + ((val_38 >> 32) * 48);
            val_39 = this.下丟丒丁下丄丕丂专 + (double)val_39;
            float val_20 = UnityEngine.Time.deltaTime;
            val_31 = val_20 * 1.5f;
            val_20 = (val_39 < 0) ? (val_31) : (val_20);
            val_32 = (double)val_20;
            val_33 = this.下丟丒丁下丄丕丂专 + val_32;
            label_54:
            if(0 >= this.东专业丑与丐丆丐丟.Length)
            {
                goto label_51;
            }
            
            var val_21 = this.东专业丑与丐丆丐丟 + (0 * 48);
            val_32 = mem[(0 * 48) + this.东专业丑与丐丆丐丟 + 64];
            val_32 = (0 * 48) + this.东专业丑与丐丆丐丟 + 64;
            val_31 = this.下丟丒丁下丄丕丂专;
            var val_22 = 0 + 1;
            if(val_32 > val_31)
            {
                goto label_54;
            }
            
            label_51:
            if(0 == 0)
            {
                    this.丝丝丁且丈丂丛丐丏 = true;
            }
            
            if(0 < this.东专业丑与丐丆丐丟.Length)
            {
                goto label_58;
            }
            
            val_32 = (1.06099789553204E-313) - this.下丟丒丁下丄丕丂专;
            val_31 = 4;
            if(val_32 > val_31)
            {
                goto label_59;
            }
            
            label_58:
            var val_40 = 48;
            val_40 = this.东专业丑与丐丆丐丟 + (0 * val_40);
            if(((0 * 48) + this.东专业丑与丐丆丐丟 + 72) == 0)
            {
                goto label_62;
            }
            
            label_59:
            var val_41 = 48;
            val_41 = this.东专业丑与丐丆丐丟 + (((long)0 - 1) * val_41);
            this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 32, y = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 32 + 4, z = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 40};
            var val_42 = 48;
            val_42 = this.东专业丑与丐丆丐丟 + (((long)0 - 1) * val_42);
            this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 44, y = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 52, w = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 52 + 4};
            var val_43 = 48;
            val_43 = this.东专业丑与丐丆丐丟 + (((long)0 - 1) * val_43);
            val_34 = this.丅丟七丈七三一丏万;
            this.下丟丒丁下丄丕丂专 = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 64;
            if(this.丅丟七丈七三一丏万 != null)
            {
                goto label_71;
            }
            
            val_34 = this.丅丟七丈七三一丏万;
            if(val_34 == null)
            {
                goto label_72;
            }
            
            label_71:
            this.丅丟七丈七三一丏万.七丈丁万丛万业丈与.position = new UnityEngine.Vector3() {x = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 44, y = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = ((long)(int)((0 - 1)) * 48) + this.东专业丑与丐丆丐丟 + 52};
            label_115:
            if(this.丅丟七丈七三一丏万 != null)
            {
                goto label_74;
            }
            
            goto label_75;
            label_62:
            double val_45 = this.下丟丒丁下丄丕丂专;
            var val_44 = 48;
            val_44 = this.东专业丑与丐丆丐丟 + (0 * val_44);
            val_45 = val_33 - val_45;
            UnityEngine.Vector3 val_25 = this.万一丂丐丄丁上与丟.position;
            val_45 = val_45 / (((0 * 48) + this.东专业丑与丐丆丐丟 + 64) - this.下丟丒丁下丄丕丂专);
            var val_46 = 48;
            val_46 = this.东专业丑与丐丆丐丟 + (0 * val_46);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = (0 * 48) + this.东专业丑与丐丆丐丟 + 32, y = (0 * 48) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (0 * 48) + this.东专业丑与丐丆丐丟 + 40}, t:  (float)val_45);
            this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            val_35 = null;
            val_35 = null;
            if(东丗上丁下业一丂丂.丆丒一专且业七丟丈 != false)
            {
                    var val_47 = 48;
                val_47 = this.东专业丑与丐丆丐丟 + (0 * val_47);
                this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = (0 * 48) + this.东专业丑与丐丆丐丟 + 44, y = (0 * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (0 * 48) + this.东专业丑与丐丆丐丟 + 52, w = (0 * 48) + this.东专业丑与丐丆丐丟 + 52 + 4};
            }
            else
            {
                    UnityEngine.Quaternion val_27 = this.万一丂丐丄丁上与丟.rotation;
                var val_48 = 48;
                val_48 = this.东专业丑与丐丆丐丟 + (0 * val_48);
                UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_27.x, y = val_27.y, z = val_27.z, w = val_27.w}, b:  new UnityEngine.Quaternion() {x = (0 * 48) + this.东专业丑与丐丆丐丟 + 44, y = (0 * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = (0 * 48) + this.东专业丑与丐丆丐丟 + 52, w = (0 * 48) + this.东专业丑与丐丆丐丟 + 52 + 4}, t:  (float)val_45);
                this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w};
                val_33 = val_33;
            }
            
            this.下丟丒丁下丄丕丂专 = val_33;
            var val_49 = 48;
            val_49 = this.东专业丑与丐丆丐丟 + (0 * val_49);
            if(((0 * 48) + this.东专业丑与丐丆丐丟 + 60) == 3)
            {
                goto label_99;
            }
            
            if(((0 * 48) + this.东专业丑与丐丆丐丟 + 60) != 2)
            {
                goto label_100;
            }
            
            var val_50 = 48;
            val_50 = this.东专业丑与丐丆丐丟 + (0 * val_50);
            if(this.丅丟七丈七三一丏万 != null)
            {
                goto label_112;
            }
            
            goto label_112;
            label_99:
            var val_51 = 48;
            val_51 = this.东专业丑与丐丆丐丟 + (0 * val_51);
            if(this.丅丟七丈七三一丏万 == null)
            {
                goto label_108;
            }
            
            val_36 = this.丅丟七丈七三一丏万.ClipDeath;
            goto label_109;
            label_100:
            Rilisoft.丘且一万丏丕丝丘丁 val_29 = this.丅丟七丈七三一丏万.一丈七万丕丏丑丛丘();
            this.丅丟七丈七三一丏万.丁丑丌世丟丏丛丘丟();
            goto label_112;
            label_108:
            val_36 = 456;
            label_109:
            this.丅丟七丈七三一丏万.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_36);
            label_112:
            var val_52 = 48;
            val_52 = this.东专业丑与丐丆丐丟 + (0 * val_52);
            if(((0 * 48) + this.东专业丑与丐丆丐丟 + 72) != 0)
            {
                goto label_115;
            }
            
            goto label_116;
            label_72:
        }
        private void 专丘丐丐世专丆丗上(UnityEngine.Vector3 丑丏与上不丐丘丕丐, UnityEngine.Quaternion 丝丏丏东丘丐丝下不, double 丄丆万一丙丂丕不丐, int 丆丄七丙丅丈上丞一, bool 丛丂丟一且丒丁东三)
        {
            丝丙丒丌东下丕丘丘 val_12;
            丝丙丒丌东下丕丘丘 val_13;
            丝丙丒丌东下丕丘丘[] val_14;
            var val_16;
            丝丙丒丌东下丕丘丘[] val_17;
            val_12 = 丄丆万一丙丂丕不丐;
            val_13 = 丝丏丏东丘丐丝下不.z;
            val_14 = this.东专业丑与丐丆丐丟;
            if(this.东专业丑与丐丆丐丟 == null)
            {
                    val_14 = this.东专业丑与丐丆丐丟;
            }
            
            int val_8 = this.东专业丑与丐丆丐丟.Length;
            var val_1 = (val_14 == null) ? 1 : 0;
            val_16 = val_8 - 1;
            if(val_16 >= 1)
            {
                    val_8 = val_8 - 2;
                var val_10 = (long)val_16;
                var val_2 = X11 + 32;
                int val_3 = val_8 + 32;
                do
            {
                val_16 = val_16 - 1;
                val_10 = val_10 - 1;
                val_2 = val_2 - 48;
                val_14[val_2] = val_14[val_3];
                val_3 = val_3 - 48;
                mem2[0] = 丑丏与上不丐丘丕丐.y;
                mem2[0] = null;
                val_14 = this.东专业丑与丐丆丐丟;
                var val_4 = (val_14 == null) ? 1 : 0;
            }
            while(val_16 > 0);
            
            }
            
            val_14[0] = 丑丏与上不丐丘丕丐.x;
            val_14[0] = 丑丏与上不丐丘丕丐.y;
            val_14[1] = 丑丏与上不丐丘丕丐.z;
            this.东专业丑与丐丆丐丟[1] = 丝丏丏东丘丐丝下不.x;
            this.东专业丑与丐丆丐丟[2] = 丝丏丏东丘丐丝下不.y;
            this.东专业丑与丐丆丐丟[2] = val_13;
            this.东专业丑与丐丆丐丟[3] = 丝丏丏东丘丐丝下不.w;
            this.东专业丑与丐丆丐丟[4] = val_12;
            this.东专业丑与丐丆丐丟[3] = 丆丄七丙丅丈上丞一;
            val_17 = this.东专业丑与丐丆丐丟;
            val_17[5] = 丛丂丟一且丒丁东三;
            if(this.丝丝丁且丈丂丛丐丏 == false)
            {
                    return;
            }
            
            var val_11 = -4294967296;
            val_11 = val_11 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            val_17 = val_11 >> 32;
            var val_12 = 48;
            val_12 = this.东专业丑与丐丆丐丟 + (val_17 * val_12);
            if(((((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 64) <= this.下丟丒丁下丄丕丂专)
            {
                    return;
            }
            
            this.丝丝丁且丈丂丛丐丏 = false;
            var val_13 = -4294967296;
            val_13 = val_13 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            val_17 = val_13 >> 32;
            var val_14 = 48;
            val_14 = this.东专业丑与丐丆丐丟 + (val_17 * val_14);
            this.下丟丒丁下丄丕丂专 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 64;
            if(this.一一丆丌专丑丏丕丗 == true)
            {
                    return;
            }
            
            var val_15 = -4294967296;
            val_15 = val_15 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_16 = 48;
            val_16 = this.东专业丑与丐丆丐丟 + ((val_15 >> 32) * val_16);
            this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 32, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 32 + 4, z = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 40};
            val_17 = this.东专业丑与丐丆丐丟;
            var val_17 = -4294967296;
            val_17 = val_17 + ((this.东专业丑与丐丆丐丟.Length) << 32);
            var val_18 = 48;
            val_18 = val_17 + ((val_17 >> 32) * val_18);
            val_12 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 44];
            val_12 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 44;
            val_13 = mem[(((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 52];
            val_13 = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 52;
            this.万一丂丐丄丁上与丟.rotation = new UnityEngine.Quaternion() {x = val_12, y = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 44 + 4, z = val_13, w = (((-4294967296 + (this.东专业丑与丐丆丐丟.Length) << 32) >> 32) * 48) + this.东专业丑与丐丆丐丟 + 52 + 4};
            this.一一丆丌专丑丏丕丗 = true;
        }
        private void 一丅三丁上专丕一丝(bool 丏业丟一东丂东丘丛, bool 丆下一丌东丞与丏不)
        {
            bool val_7;
            System.Object[] val_8;
            var val_9;
            val_7 = 丆下一丌东丞与丏不;
            val_8 = 1152921505171275776;
            val_9 = null;
            val_9 = null;
            if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
            {
                    return;
            }
            
            if(this.丌且下丕下下丌万丞 == false)
            {
                    return;
            }
            
            this.丝丝丁且丈丂丛丐丏 = true;
            if(丏业丟一东丂东丘丛 != false)
            {
                    this.isTeleported = true;
            }
            
            val_9 = null;
            if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
            {
                    return;
            }
            
            object[] val_2 = new object[2];
            val_8 = val_2;
            val_8[0] = System.Convert.ToByte(value:  丏业丟一东丂东丘丛);
            val_7 = System.Convert.ToByte(value:  val_7);
            val_8[1] = val_7;
            this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  33, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
        }
        public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
        {
            var val_2;
            int val_3;
            var val_4;
            val_2 = 丗与一丛丐丞丘丌丞;
            if((val_2 & 255) == 33)
            {
                    val_3 = 专丒丌丆下丐丞丟丞.Length;
                if(val_3 == 0)
            {
                    val_3 = 专丒丌丆下丐丞丟丞.Length;
            }
            
                object val_2 = 专丒丌丆下丐丞丟丞[0];
                object val_3 = 专丒丌丆下丐丞丟丞[1];
                this.上且丌不世上丅丐丞(丕丞七丁下丗丏丈丏:  0, 丟专丒一丁业丂丐万:  0);
                val_4 = 1;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private void 上且丌不世上丅丐丞(byte 丕丞七丁下丗丏丈丏, byte 丟专丒一丁业丂丐万)
        {
            byte val_11;
            UnityEngine.AudioClip val_12;
            val_11 = 丕丞七丁下丗丏丈丏;
            if(this.丌且下丕下下丌万丞 == true)
            {
                    return;
            }
            
            val_11 = System.Convert.ToBoolean(value:  丟专丒一丁业丂丐万);
            if((System.Convert.ToBoolean(value:  val_11)) != false)
            {
                    this.丅且业丑且丄不丟丒 = false;
                return;
            }
            
            this.丅且业丑且丄不丟丒 = true;
            if(this.丅丟七丈七三一丏万 == null)
            {
                goto label_5;
            }
            
            if(val_11 == false)
            {
                goto label_6;
            }
            
            label_11:
            bool val_5 = this.丅丟七丈七三一丏万.与丒万一世与万七专().Play(animation:  this.丅丟七丈七三一丏万.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  3));
            if(this.丅丟七丈七三一丏万 == null)
            {
                goto label_9;
            }
            
            val_12 = this.丅丟七丈七三一丏万.ClipDeath;
            goto label_10;
            label_5:
            if(val_11 == true)
            {
                goto label_11;
            }
            
            label_6:
            this.丅丟七丈七三一丏万.丗丑丝丕上丙世丆下();
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  10000f);
            this.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            return;
            label_9:
            val_12 = 456;
            label_10:
            this.丅丟七丈七三一丏万.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_12);
            this.丅丟七丈七三一丏万.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this.丅丟七丈七三一丏万.丙丒丏三丆业丗东丟(丌七丞丌丑丆丈万不:  3), 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void Rilisoft.NetworkPetEngineSynch::丅丝丏丒丆东丛丞丆()));
        }
        private void 业丅丝世丒业丘丞东()
        {
            if(this.丅丟七丈七三一丏万.EffectHide != 0)
            {
                    this.丅丟七丈七三一丏万.EffectHide.OnEffectCompleted.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.NetworkPetEngineSynch::业丅丝世丒业丘丞东()));
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  10000f);
            this.transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        private void 丅丝丏丒丆东丛丞丆()
        {
            bool val_3 = this.丅丟七丈七三一丏万.与丒万一世与万七专().Play(animation:  this.丅丟七丈七三一丏万.丕丘下东一丆丏且专(丁丅丈丌丟世丗丗丟:  0));
            this.丅丟七丈七三一丏万.丌七业一丞丈丅万三();
            if(this.丅丟七丈七三一丏万.EffectHide != 0)
            {
                    this.丅丟七丈七三一丏万.EffectHide.OnEffectCompleted.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Rilisoft.NetworkPetEngineSynch::业丅丝世丒业丘丞东()));
                return;
            }
            
            this.业丅丝世丒业丘丞东();
        }
    
    }

}
