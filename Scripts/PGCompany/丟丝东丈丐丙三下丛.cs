using UnityEngine;

namespace PGCompany
{
    internal sealed class 丟丝东丈丐丙三下丛 : 丗丟丄丈东丝丕丄世, 七专丙与东丘丌丘丈
    {
        // Fields
        private System.Lazy<三丅丁丗丗丝丂万且> 丝丞丈不且丂丕万不;
        internal PGCompany.丏丅丂东丐东七丂丙 业丁丒丒丕东丂丌且;
        
        // Properties
        internal 三丅丁丗丗丝丂万且 一下丑丏且且七业丁 { get; }
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal int 业丂上丘业丂且丏丗 { get; }
        internal int 业丂上丆三不丘丘丟 { get; }
        
        // Methods
        internal 三丅丁丗丗丝丂万且 丐上下三丑丈丑丄丟()
        {
            if(this.丝丞丈不且丂丕万不 != null)
            {
                    return this.丝丞丈不且丂丕万不.Value;
            }
            
            return this.丝丞丈不且丂丕万不.Value;
        }
        public 丟丝东丈丐丙三下丛(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.丝丞丈不且丂丕万不 = new System.Lazy<三丅丁丗丗丝丂万且>(valueFactory:  new System.Func<三丅丁丗丗丝丂万且>(object:  this, method:  三丅丁丗丗丝丂万且 PGCompany.丟丝东丈丐丙三下丛::世丒三专丞丒丘丌下()));
        }
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            三丅丁丗丗丝丂万且 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 != null)
            {
                    return val_1.丒万丕七专不丏丞丌();
            }
            
            return val_1.丒万丕七专不丏丞丌();
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            var val_8;
            var val_9;
            丕丑丙丑丙东丌丘丕 val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    val_8 = 0;
                ItemRarity val_4 = val_3.七东与丄丕丁丛世三();
            }
            else
            {
                    val_9 = this.丐上下三丑丈丑丄丟();
            }
            
            if(this.业丁丒丒丕东丂丌且 == null)
            {
                    return (ItemRarity)val_9;
            }
            
            return UnityEngine.Mathf.Min(a:  5, b:  this.业丁丒丒丕东丂丌且.丂丁丏一丙丛业且丌() + val_9);
        }
        internal int 一丏丑丅丟世丗丈丒()
        {
            return BalanceController.下三丌一丅丗三丏丝(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不(), 丘丟与七丕丝丁丗丏:  false);
        }
        internal int 丏万东丐丛不丛不世()
        {
            三丅丁丗丗丝丂万且 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 != null)
            {
                    return val_1.丏万东丐丛不丛不世();
            }
            
            return val_1.丏万东丐丛不丛不世();
        }
        internal override string 七业丑不七丐业丟丂()
        {
            return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  this.丐上下三丑丈丑丄丟().万上丄下业丛丌不丈() - 1);
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            return 丏丄丑上丛不丈且万.丛丐丏上丗不丘丕丕(丆万一不丌且东丐丐:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  this.丐上下三丑丈丑丄丟().万上丄下业丛丌不丈() - 1);
        }
        internal override string 东且丏丆万与东丙万()
        {
            if(this.丐上下三丑丈丑丄丟().东七与与不丅丙上上() == false)
            {
                    return 丏丄丑上丛不丈且万.丒丅丈且且专不丅一(丆万一不丌且东丐丐:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛());
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5531");
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  this.丐上下三丑丈丑丄丟().万上丄下业丛丌不丈() - 1, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/gears");
        }
        internal int 三三三东丑丁且与万()
        {
            丕丑丙丑丙东丌丘丕 val_3 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this.业上丙丞丐丄丆丅七());
            三丅丁丗丗丝丂万且 val_5 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
            if(val_5 == null)
            {
                    return 1;
            }
            
            return val_5.七丙丛与万且专三三();
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            丈丞丕丘丕丗与上一 val_5 = 上丑三丁丄丛丁万丑.丞丟丛下丘下与上下(不三丙万与丗丌七丈:  this.丐上下三丑丈丑丄丟().丒万丕七专不丏丞丌(), 丞一丁业丄一一业且:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            if(val_5 == null)
            {
                    return 丏丄丑上丛不丈且万.丂丈一丐丂丟三丆丂(不三丙万与丗丌七丈:  this.丐上下三丑丈丑丄丟().丒万丕七专不丏丞丌(), 丛丐且下丂丏丁专丌:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛(), 丂丆丗丈丏丘一丙世:  false, 丐丏上业丈丂与万丞:  false, 丗业丕七且丝丆丝丘:  false);
            }
            
            return val_5;
        }
        internal UnityEngine.GameObject 丑丑丛丛丙丙七丏丆(int 且丅丟丛丛万丝下上 = -1)
        {
            int val_29;
            UnityEngine.GameObject val_30;
            var val_31;
            丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32> val_32;
            UnityEngine.GameObject val_33;
            var val_34;
            val_29 = 且丅丟丛丛万丝下上;
            val_30 = this;
            丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东 val_1 = new 丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东();
            if(val_1 != null)
            {
                    val_31 = val_1;
                .且丅丟丛丛万丝下上 = val_29;
            }
            else
            {
                    val_31 = 24;
                mem[24] = val_29;
                val_29 = mem[24];
            }
            
            if(val_29 == 1)
            {
                    mem[24] = 0;
            }
            
            val_32 = 1152921504834002944;
            .东且丁丆丛丁丏丘且 = new UnityEngine.GameObject(name:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛() + " _preview");
            UnityEngine.GameObject val_9 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Weapons/"("Weapons/") + this.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌());
            if(val_9 != 0)
            {
                    WeaponSounds val_11 = val_9.GetComponent<WeaponSounds>();
                if(val_11 != 0)
            {
                    if((System.String.IsNullOrEmpty(value:  val_11.armoryPreviewName)) == false)
            {
                goto label_16;
            }
            
            }
            
                val_32 = null;
                val_32 = new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void 丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东::三一丑丒丝业与丂丘(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌));
                val_30 = this.丐上下三丑丈丑丄丟();
                丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_9, 丌专业且丛丏丞丝且:  null, 七丆丒与丗丌丄且丂:  val_30.丒万丕七专不丏丞丌(), 丐丑七万丌丂专与丌:  val_11);
            }
            
            label_70:
            if((mem[24] & 2147483648) != 0)
            {
                    return (UnityEngine.GameObject)(丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东)[1152921555681681472].东且丁丆丛丁丏丘且;
            }
            
            val_30 = (丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东)[1152921555681681472].东且丁丆丛丁丏丘且.gameObject;
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_30, 不东丛三丂丌丑专丆:  0, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            return (UnityEngine.GameObject)(丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东)[1152921555681681472].东且丁丆丛丁丏丘且;
            label_16:
            UnityEngine.Object val_19 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "Weapons/{0}", arg0:  val_11.armoryPreviewName));
            if(val_19 != null)
            {
                    var val_20 = (null == null) ? (val_19) : 0;
            }
            else
            {
                    val_33 = 0;
            }
            
            UnityEngine.GameObject val_21 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_33);
            val_21.transform.SetParent(p:  (丟丝东丈丐丙三下丛.丒业丛丟专丛丒与东)[1152921555681681472].东且丁丆丛丁丏丘且.transform);
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_21, 不东丛三丂丌丑专丆:  0);
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_11.rotationShop, y = V8.16B, z = V9.16B});
            val_21.transform.localRotation = new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w};
            val_21.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_21.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(val_11.useTextureSkinForArmoryPreview == false)
            {
                goto label_70;
            }
            
            val_34 = null;
            val_34 = null;
            Player_move_c.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  val_21, 丐丅丁丂丐下丘世丄:  SkinsController.丌与世丂丘且下丒丑, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
            goto label_70;
        }
        internal bool 丄丕三丄专丆丛丙专()
        {
            bool val_6 = WeaponManager.丒上丙丕一丘三万丄(三不三丟专丘东东丂:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛());
            val_6 = (丛且丗丌丏下七下丈.上丏丘不业丅七丝丂(丞一丁业丄一一业且:  this.丐上下三丑丈丑丄丟().与不丞丑七丘丁丂丛())) | val_6;
            return (bool)val_6;
        }
        internal System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 世丙万丞上与一丌丅(bool 丆丗万丛丞丈三丗丅 = False)
        {
            int val_14;
            PGCompany.丗丒下万与下丂万丂 val_15;
            System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_1 = new System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂>();
            val_1.Add(item:  PGCompany.丏丕丄丟上丟丗世与.七丝丄且丙丄丂丄丙(丒与丏丛且万丘业丆:  1, 丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不()));
            val_1.Add(item:  PGCompany.丏丕丄丟上丟丗世与.七丝丄且丙丄丂丄丙(丒与丏丛且万丘业丆:  2, 丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不()));
            val_1.Add(item:  PGCompany.丏丕丄丟上丟丗世与.七丝丄且丙丄丂丄丙(丒与丏丛且万丘业丆:  3, 丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不()));
            val_1.Add(item:  PGCompany.丏丕丄丟上丟丗世与.七丝丄且丙丄丂丄丙(丒与丏丛且万丘业丆:  4, 丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不()));
            val_14 = this.业东丅东丌上丗丑不();
            if(丆丗万丛丞丈三丗丅 == false)
            {
                goto label_5;
            }
            
            val_14 = BalanceController.下三丌一丅丗三丏丝(丞世不丒下上上丝丑:  val_14, 丘丟与七丕丝丁丗丏:  true);
            PGCompany.丗丒下万与下丂万丂 val_12 = null;
            val_15 = val_12;
            val_12 = new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  8, 丙业与丙丗丝不丈东:  val_14);
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_9;
            label_5:
            val_15 = PGCompany.丏丕丄丟上丟丗世与.七丝丄且丙丄丂丄丙(丒与丏丛且万丘业丆:  8, 丆专且丕专丗与一丏:  val_14);
            if(val_1 != null)
            {
                goto label_10;
            }
            
            label_9:
            label_10:
            val_1.Add(item:  val_15);
            return val_1;
        }
        public override string ToString()
        {
            object[] val_1 = new object[4];
            int val_2 = this.业东丅东丌上丗丑不();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.不业丙丒丂丞下丆丙();
            val_1[2] = this.业上丙丞丐丄丆丅七();
            val_1[3] = this.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌();
            return (string)System.String.Format(format:  "[index={0} type={1} id={2} pref={3}]", args:  val_1);
        }
        internal override string 丟七万东万七丙丘丌()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2444")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2444")) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this));
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2444");
        }
        internal System.Collections.Generic.List<PGCompany.丟丝世万东万丆丟上> 丁丟下丟七丁丙丁丄()
        {
            System.Collections.Generic.List<PGCompany.丟丝世万东万丆丟上> val_1 = new System.Collections.Generic.List<PGCompany.丟丝世万东万丆丟上>();
            List.Enumerator<T> val_5 = 丏丞丛上七丁丞丛万.丟丛下丟业丈丟丟上(丈丁丄丘丛世七丙丝:  this.丐上下三丑丈丑丄丟().三与丛丑且丐丈业丌()).GetEnumerator();
            label_10:
            if(((-463827512) & 1) == 0)
            {
                goto label_5;
            }
            
            PGCompany.丟丝世万东万丆丟上 val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丟丝世万东万丆丟上>(丞世不丒下上上丝丑:  0.丐丏七丌丕丗业且上().SkinIndex);
            if(val_9 == null)
            {
                goto label_10;
            }
            
            val_1.Add(item:  val_9);
            goto label_10;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> 上丒一丄业丁且且专()
        {
            三丅丁丗丗丝丂万且 val_1 = this.丐上下三丑丈丑丄丟();
            if(val_1 != null)
            {
                    return val_1.丞丁下丅上不且丐丄();
            }
            
            return val_1.丞丁下丅上不且丐丄();
        }
        public int 丁丕丁三丁丗不三丟()
        {
            return this.三三三东丑丁且与万();
        }
        public int 万丙东丙丐丕专丈丕()
        {
            null = null;
            return (int)丕丑丙丑丙东丌丘丕.丞丁丏且与丒丐业下;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丟丝东丈丐丙三下丛(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private 三丅丁丗丗丝丂万且 世丒三专丞丒丘丌下()
        {
            return 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
        }
    
    }

}
