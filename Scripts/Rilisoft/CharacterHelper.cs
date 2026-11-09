using UnityEngine;

namespace Rilisoft
{
    public class CharacterHelper : MonoBehaviour
    {
        // Fields
        private CharacterInterfaceV2 上丄丙丈世丝丅丈丄;
        
        // Properties
        internal CharacterInterfaceV2 丙世丐万丆丌上丕丘 { get; }
        public bool 东丝丝专世丁东丗丗 { get; set; }
        
        // Methods
        internal CharacterInterfaceV2 丟丑万与丒与不下丛()
        {
            CharacterInterfaceV2 val_10;
            if(this.上丄丙丈世丝丅丈丄 != 0)
            {
                    return (CharacterInterfaceV2)this.上丄丙丈世丝丅丈丄;
            }
            
            UnityEngine.GameObject val_2 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Character_model_V2");
            val_2.SetActive(value:  false);
            UnityEngine.GameObject val_4 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_2, 丈东丘丏与丌东东下:  this.transform, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  val_4);
            val_10 = val_4.GetComponent<CharacterInterfaceV2>();
            this.上丄丙丈世丝丅丈丄 = val_10;
            val_10.丟且丟七丌丞专七丁();
            val_2.SetActive(value:  true);
            if((this.GetComponent<ShopShootingController>()) == 0)
            {
                    return (CharacterInterfaceV2)this.上丄丙丈世丝丅丈丄;
            }
            
            val_6.PlayIdleSound = false;
            val_6.专丒下丛丄丁丁万丐 = new System.Func<CharacterInterfaceV2>(object:  this, method:  CharacterInterfaceV2 Rilisoft.CharacterHelper::丏丌丁上丄丅一专丂());
            System.Func<UnityEngine.GameObject> val_9 = null;
            val_10 = val_9;
            val_9 = new System.Func<UnityEngine.GameObject>(object:  this, method:  UnityEngine.GameObject Rilisoft.CharacterHelper::丂丗七业丝世丒丛丆());
            val_6.CurrentWeaponObjectGetter = val_10;
            return (CharacterInterfaceV2)this.上丄丙丈世丝丅丈丄;
        }
        internal void 不丟丞丆丑丅丘丛东(bool 东世丛丘丐下丏丄丈)
        {
            this.上丄丙丈世丝丅丈丄.一一丝专东丘丅一丌(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.上丄丙丈世丝丅丈丄.丐丕丌一丆丛丆丘万(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.上丄丙丈世丝丅丈丄.专世丐丝丑丒专下丑(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this.专业丞丞专下丒丌下(东世丛丘丐下丏丄丈:  东世丛丘丐下丏丄丈);
        }
        internal void 专业丞丞专下丒丌下(bool 东世丛丘丐下丏丄丈)
        {
            bool val_1 = 东世丛丘丐下丏丄丈;
            this.ResetWear(东世丛丘丐下丏丄丈:  val_1);
            this.丞丈丛丅丗丒丟七七(东世丛丘丐下丏丄丈:  val_1);
            this.专丑丒下三上世不丆(东世丛丘丐下丏丄丈:  val_1);
        }
        internal void 丂不丅不专丆丅丌与()
        {
            var val_2 = null;
            this.丟丑万与丒与不下丛().世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  与世丁丙且丑下丌不.丕丆丒丌丘丌丘与与);
        }
        public bool get_CharacterVisible()
        {
            UnityEngine.GameObject val_2 = this.丟丑万与丒与不下丛().gameObject;
            if(val_2 != null)
            {
                    return val_2.activeSelf;
            }
            
            return val_2.activeSelf;
        }
        public void set_CharacterVisible(bool 丙业与丙丗丝不丈东)
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丟丑万与丒与不下丛().gameObject, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
        }
        public void SetAnimationEnabled(bool 丆丛丆丞下丅丂且丝)
        {
            CharacterInterfaceV2 val_1 = this.丟丑万与丒与不下丛();
            if(val_1 == null)
            {
                goto label_0;
            }
            
            if(丆丛丆丞下丅丂且丝 == false)
            {
                goto label_1;
            }
            
            label_2:
            val_1.丟且丟七丌丞专七丁();
            return;
            label_0:
            if(丆丛丆丞下丅丂且丝 == true)
            {
                goto label_2;
            }
            
            label_1:
            val_1.丒不丆丙丙不与丞世();
        }
        public void SetWeapon(string 三不三丟专丘东东丂)
        {
            this.丟丑万与丒与不下丛().世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  三不三丟专丘东东丂);
            this.丟丑万与丒与不下丛().业不丛不丞七丕东世(七不丐下丟专业万丅:  "Profile");
            this.丟丑万与丒与不下丛().且一丞丗三一丄万丝(三丕上下丗丘丌专丒:  0);
            Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this.丟丑万与丒与不下丛().gameObject);
        }
        internal void 丟且丏业丈七七三与(string 不丐上专丌丒丘丟丐)
        {
            this.丟丑万与丒与不下丛().丟且丏业丈七七三与(丕丁下丌不万丅丞丛:  不丐上专丌丒丘丟丐);
        }
        internal void 专丑丒下三上世不丆(bool 东世丛丘丐下丏丄丈 = True)
        {
            string val_6;
            if(东世丛丘丐下丏丄丈 != false)
            {
                    val_6 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
            }
            else
            {
                    val_6 = 0;
            }
            
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6)) != true)
            {
                    if((System.String.op_Inequality(a:  val_6, b:  "EMPTY_ROYALE_AVATAR")) != false)
            {
                    this.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丛且丗丌丏下七下丈.业且不丂东丄一丁丈());
                return;
            }
            
            }
            
            this.下丙丅丙丏业丗丞世();
        }
        internal void 丈丑丅上七丑丅一丒(string 丗上丛丌丅下丙不丙, bool 与丙丁不丆丘丄不丞)
        {
            string val_20;
            string val_21;
            string val_22;
            string val_23;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丗上丛丌丅下丙不丙)) == true)
            {
                goto label_26;
            }
            
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  丗上丛丌丅下丙不丙)) == false)
            {
                goto label_12;
            }
            
            丛且专丞丗丆丙丒万 val_5 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[丗上丛丌丅下丙不丙];
            if(val_5.上七不丅丈丁不丛丝 == null)
            {
                goto label_12;
            }
            
            丛且专丞丗丆丙丒万 val_7 = 丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Item[丗上丛丌丅下丙不丙];
            if((val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsKey(key:  9)) == false)
            {
                goto label_19;
            }
            
            val_20 = val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Item[9];
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_28;
            }
            
            goto label_22;
            label_12:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  丗上丛丌丅下丙不丙)) != false)
            {
                    this.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  丗上丛丌丅下丙不丙);
                return;
            }
            
            label_26:
            this.ResetWear(东世丛丘丐下丏丄丈:  true);
            this.丞丈丛丅丗丒丟七七(东世丛丘丐下丏丄丈:  true);
            this.下丙丅丙丏业丗丞世();
            return;
            label_19:
            val_20 = 0;
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_28;
            }
            
            label_22:
            label_28:
            if((val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsKey(key:  12)) == false)
            {
                goto label_29;
            }
            
            val_21 = val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Item[12];
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_33;
            }
            
            goto label_32;
            label_29:
            val_21 = 0;
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_33;
            }
            
            label_32:
            label_33:
            if((val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsKey(key:  6)) == false)
            {
                goto label_34;
            }
            
            val_22 = val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Item[6];
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_38;
            }
            
            goto label_37;
            label_34:
            val_22 = 0;
            if(val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁 != null)
            {
                goto label_38;
            }
            
            label_37:
            label_38:
            if((val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.ContainsKey(key:  10)) != false)
            {
                    val_23 = val_7.上七不丅丈丁不丛丝.丝丈不丗丐不丙丟丁.Item[10];
            }
            else
            {
                    val_23 = 0;
            }
            
            this.SetWear(丈丐丕业下丟业丛一:  val_20, 丟世丟丐且丐丟七上:  val_21, 上丈专丌万丕丙万丘:  val_22, 且与丛专丗丞丑丑丝:  val_23, 专丆东丌上七丄丄下:  (~与丙丁不丆丘丄不丞) & 1, 下丈丝丁丟下世丐丒:  true, 丈七与世丏丕业世丙:  true);
            this.SetArmor(业丄东下世丗丘下丑:  val_7.上七不丅丈丁不丛丝.丟丁业专下丈专丐七, 下丈丝丁丟下世丐丒:  true, 东世丛丘丐下丏丄丈:  true);
        }
        public void SetWear(string 丈丐丕业下丟业丛一, string 丟世丟丐且丐丟七上, string 上丈专丌万丕丙万丘, string 且与丛专丗丞丑丑丝, bool 专丆东丌上七丄丄下, bool 下丈丝丁丟下世丐丒, bool 丈七与世丏丕业世丙 = True)
        {
            string val_45;
            string val_46;
            string val_47;
            string val_48;
            var val_49;
            var val_50;
            val_45 = 且与丛专丗丞丑丑丝;
            val_46 = 上丈专丌万丕丙万丘;
            val_47 = 丟世丟丐且丐丟七上;
            val_48 = 丈丐丕业下丟业丛一;
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_48)) != false) && (专丆东丌上七丄丄下 != false))
            {
                    val_48 = 七丌丞万七万丁丐丙.一万丌东丄世上丕丟();
            }
            
            this.丟丑万与丒与不下丛().丑丞丟丁东丂三与丁(丕丁下丌不万丅丞丛:  val_48);
            bool val_6 = 下丈丝丁丟下世丐丒 ^ 1;
            this.丟丑万与丒与不下丛().丒三丞上专丌丟丞与(丙业与丙丗丝不丈东:  val_6 & 三丐下丁丒丆丘下丄.丗丄且丝一世丁丌七() ^ 1);
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_47)) != false) && (专丆东丌上七丄丄下 != false))
            {
                    val_47 = 七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝();
            }
            
            val_49 = this.丟丑万与丒与不下丛();
            val_49.不一丙东七下不丕丑(丕丁下丌不万丅丞丛:  val_47);
            this.丟丑万与丒与不下丛().丘上丗丗且七丈一丕(丙业与丙丗丝不丈东:  val_6 & 三丐下丁丒丆丘下丄.丝丗丂且上丅丒三丅() ^ 1);
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) != false) && (专丆东丌上七丄丄下 != false))
            {
                    val_46 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_46)) != true)
            {
                    val_50 = null;
                val_50 = null;
                string val_21 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丈丂下丕丝丝丆丅下);
                if((System.String.IsNullOrEmpty(value:  val_21)) != true)
            {
                    val_49 = 七丌丞万七万丁丐丙.丗且且丁万丛丗与一();
                if(((val_49.IndexOf(item:  val_46)) & 2147483648) == 0)
            {
                    val_49 = 七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_46);
            }
            
            }
            
            }
            
            this.丟丑万与丒与不下丛().丘丄丏世丒上东丘丒(丕丁下丌不万丅丞丛:  (val_49 < (七丌丞万七万丁丐丙.丗且且丁万丛丗与一().IndexOf(item:  val_21))) ? (val_21) : (val_46));
            this.丟丑万与丒与不下丛().不丑丂丏丐丟下万丑(丙业与丙丗丝不丈东:  val_6 & 三丐下丁丒丆丘下丄.丟万三丁丙丅东三三() ^ 1);
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_45)) != false) && (专丆东丌上七丄丄下 != false))
            {
                    val_45 = 七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐();
            }
            
            this.丟丑万与丒与不下丛().上丒丈世丗丆丗丛下(丕丁下丌不万丅丞丛:  val_45);
            this.丟丑万与丒与不下丛().业丙丆七上业丈丕丐(丙业与丙丗丝不丈东:  val_6 & 三丐下丁丒丆丘下丄.丈七七丞不丄丈丄丏() ^ 1);
            if(丈七与世丏丕业世丙 != false)
            {
                    this.丞丈丛丅丗丒丟七七(东世丛丘丐下丏丄丈:  true);
                return;
            }
            
            this.丟丑万与丒与不下丛().上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  System.String.alignConst);
        }
        public void ResetWear(bool 东世丛丘丐下丏丄丈 = True)
        {
            string val_6;
            string val_7;
            string val_8;
            string val_9;
            if(东世丛丘丐下丏丄丈 != false)
            {
                    val_6 = 七丌丞万七万丁丐丙.一万丌东丄世上丕丟();
                val_7 = 七丌丞万七万丁丐丙.上三丐丛东丐丏丗丝();
                val_8 = 丘丕万丁丞业七丛与.东专丑三丕业世业丈();
                val_9 = 七丌丞万七万丁丐丙.业丟丄业丏丏丌丒丐();
            }
            else
            {
                    val_8 = 0;
                val_6 = 0;
                val_7 = 0;
                val_9 = 0;
            }
            
            this.SetWear(丈丐丕业下丟业丛一:  val_6, 丟世丟丐且丐丟七上:  val_7, 上丈专丌万丕丙万丘:  val_8, 且与丛专丗丞丑丑丝:  val_9, 专丆东丌上七丄丄下:  东世丛丘丐下丏丄丈, 下丈丝丁丟下世丐丒:  true, 丈七与世丏丕业世丙:  true);
        }
        public void SetArmor(string 业丄东下世丗丘下丑, bool 下丈丝丁丟下世丐丒, bool 东世丛丘丐下丏丄丈 = True)
        {
            string val_16;
            var val_17;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.Boolean> val_19;
            var val_20;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.String> val_22;
            int val_23;
            var val_24;
            var val_25;
            val_16 = 业丄东下世丗丘下丑;
            if(东世丛丘丐下丏丄丈 != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
            {
                    val_16 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
            }
            
            }
            
            val_17 = null;
            val_17 = null;
            val_19 = CharacterHelper.<>c.<>9__16_0;
            if(val_19 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.Boolean> val_4 = null;
                val_19 = val_4;
                val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.Boolean>(object:  CharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CharacterHelper.<>c::专丏丛丞专三丌专丙(System.Collections.Generic.KeyValuePair<string, 丛且专丞丗丆丙丒万> 丈丏万丄丒业丅丒一));
                CharacterHelper.<>c.<>9__16_0 = val_19;
            }
            
            val_20 = null;
            val_20 = null;
            val_22 = CharacterHelper.<>c.<>9__16_1;
            if(val_22 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.String> val_6 = null;
                val_22 = val_6;
                val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.String>(object:  CharacterHelper.<>c.__il2cppRuntimeField_static_fields, method:  System.String CharacterHelper.<>c::专丄丝丈上丘丄丏三(System.Collections.Generic.KeyValuePair<string, 丛且专丞丗丆丙丒万> 丈丏万丄丒业丅丒一));
                CharacterHelper.<>c.<>9__16_1 = val_22;
            }
            
            val_23 = val_16;
            if(val_16 == null)
            {
                    val_23 = System.String.alignConst;
            }
            
            if((System.Linq.Enumerable.Contains<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>, System.String>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, 丛且专丞丗丆丙丒万>>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞(), predicate:  val_4), selector:  val_6), value:  val_23)) == false)
            {
                goto label_20;
            }
            
            val_24 = this.丟丑万与丒与不下丛();
            goto label_24;
            label_20:
            val_22 = 丆丟七丌丞东丆丕丌.丑丙丑丟丟丛丞丟七(丙丄不丈专丕与万万:  val_16);
            val_24 = this.丟丑万与丒与不下丛();
            if(val_22 == null)
            {
                goto label_24;
            }
            
            string val_12 = val_22.业上丙丞丐丄丆丅七();
            goto label_25;
            label_24:
            val_25 = 0;
            label_25:
            val_24.上丛与丅丏丌上丁丞(丙丄不丈专丕与万万:  (val_25 == 0) ? (val_16) : (val_25));
            ShopNGUIController.丙丗丐丁丆不丈上丈(世丟丈丏丕万丝丆万:  this.丟丑万与丒与不下丛(), 下丈丝丁丟下世丐丒:  下丈丝丁丟下世丐丒);
        }
        private void 丞丈丛丅丗丒丟七七(bool 东世丛丘丐下丏丄丈 = True)
        {
            string val_3;
            if(东世丛丘丐下丏丄丈 != false)
            {
                    val_3 = 七丌丞万七万丁丐丙.东与丑丌丄万业丘丄();
            }
            else
            {
                    val_3 = 0;
            }
            
            this.SetArmor(业丄东下世丗丘下丑:  val_3, 下丈丝丁丟下世丐丒:  true, 东世丛丘丐下丏丄丈:  东世丛丘丐下丏丄丈);
        }
        public void SetCharacterRotation(UnityEngine.Quaternion 专丂丕丗丗东世丞下)
        {
            this.丟丑万与丒与不下丛().gameObject.transform.localRotation = new UnityEngine.Quaternion() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z, w = 专丂丕丗丗东世丞下.w};
        }
        public void AddCharacterRotation(UnityEngine.Quaternion 专丂丕丗丗东世丞下)
        {
            UnityEngine.Quaternion val_4 = this.丟丑万与丒与不下丛().gameObject.transform.localRotation;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, rhs:  new UnityEngine.Quaternion() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z, w = 专丂丕丗丗东世丞下.w});
            this.丟丑万与丒与不下丛().gameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        private void 下丙丅丙丏业丗丞世()
        {
            var val_2 = null;
            this.丟丑万与丒与不下丛().上丈一万东三东世东(丂丒丘丅专丗丂世丛:  SkinsController.丌与世丂丘且下丒丑);
        }
        private void OnDestroy()
        {
            this.DestroyModel();
        }
        public void DestroyModel()
        {
            if(this.上丄丙丈世丝丅丈丄 == 0)
            {
                    return;
            }
            
            if(this.上丄丙丈世丝丅丈丄 != 0)
            {
                    if(this.上丄丙丈世丝丅丈丄.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.上丄丙丈世丝丅丈丄.gameObject);
            }
            
            }
            
            this.上丄丙丈世丝丅丈丄 = 0;
        }
        public CharacterHelper()
        {
        
        }
        private CharacterInterfaceV2 丏丌丁上丄丅一专丂()
        {
            return (CharacterInterfaceV2)this.上丄丙丈世丝丅丈丄;
        }
        private UnityEngine.GameObject 丂丗七业丝世丒丛丆()
        {
            UnityEngine.Object val_1 = this.上丄丙丈世丝丅丈丄.丞丑丈且世丛东丝东(下丗丁丒丘东丂不丑:  1);
            if(val_1 == null)
            {
                    return (UnityEngine.GameObject)(null == null) ? (val_1) : 0;
            }
            
            return (UnityEngine.GameObject)(null == null) ? (val_1) : 0;
        }
    
    }

}
