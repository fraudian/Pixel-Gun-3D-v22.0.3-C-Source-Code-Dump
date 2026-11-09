using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventItem
    {
        // Fields
        private Rilisoft.GameEventItemData _data;
        private UnityEngine.Texture _texture;
        
        // Properties
        public Rilisoft.GameEventItemData Data { get; }
        public bool AvailableToDrop { get; }
        
        // Methods
        public GameEventItem(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            this._data = 一丐丗丁丞丆丅丟丄;
        }
        public Rilisoft.GameEventItemData get_Data()
        {
            return (Rilisoft.GameEventItemData)this._data;
        }
        public bool get_AvailableToDrop()
        {
            Rilisoft.GameEventItemData val_40;
            var val_41;
            var val_42;
            PGCompany.三东丏不丗世丅丌丄 val_43;
            var val_44;
            val_40 = this;
            Rilisoft.GameEventItemType val_1 = this._data.Type;
            if(val_1 <= 800)
            {
                goto label_2;
            }
            
            if(val_1 <= 1200)
            {
                goto label_3;
            }
            
            if(val_1 <= 1400)
            {
                goto label_4;
            }
            
            if(val_1 == 1500)
            {
                goto label_5;
            }
            
            if(val_1 != 1600)
            {
                goto label_57;
            }
            
            val_40 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七丟丘不下万丙丄下>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  this._data.Id);
            if((((val_40 == null) || ((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丅且丟丅丙丘上丁丏(丞世不丒下上上丝丑:  val_40.业东丅东丌上丗丑不())) == false)) || (val_40.不一丆丑业且丆丙三() == null)) || ((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_40.不一丆丑业且丆丙三().业东丅东丌上丗丑不())) == true))
            {
                goto label_57;
            }
            
            val_40 = val_40.不一丆丑业且丆丙三().丑丐丙丄丅世世丑丒();
            val_41;
            val_42 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_43 = val_40;
            goto label_18;
            label_2:
            if(val_1 <= 300)
            {
                goto label_19;
            }
            
            if(val_1 <= 500)
            {
                goto label_20;
            }
            
            if(val_1 == 600)
            {
                    return this.丁丁上丘丙丘下且上();
            }
            
            if(val_1 != 800)
            {
                goto label_57;
            }
            
            return this.与丗丆丝与丕丁丞世();
            label_3:
            if(val_1 <= 1000)
            {
                goto label_23;
            }
            
            if(val_1 == 1100)
            {
                goto label_24;
            }
            
            if(val_1 != 1200)
            {
                goto label_57;
            }
            
            return 丐东不丅丂丂丅丙不.丈丆上丅丏丟东万丞(丞丅上丏丂且下丅与:  this._data.Id);
            label_19:
            if(val_1 == 100)
            {
                    return this.丌业丟不三丗万丐丒();
            }
            
            if(val_1 == 200)
            {
                    return this.丌丌丟三七丛业与一();
            }
            
            if(val_1 == 300)
            {
                    return this.丄丐丛丏丞与丌一丗();
            }
            
            goto label_57;
            label_4:
            if(val_1 != 1300)
            {
                goto label_33;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  this._data.Id)) == false)
            {
                goto label_57;
            }
            
            val_40 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_44 = (val_40.不丌丝丗丒丛丏丙丌(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  this._data.Id)) ^ 1;
            return (bool)val_44 & 1;
            label_20:
            if(val_1 == 400)
            {
                    return this.丄丐丛丏丞与丌一丗();
            }
            
            if(val_1 != 500)
            {
                goto label_57;
            }
            
            val_40 = this._data;
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_40.Id)) == false)
            {
                goto label_51;
            }
            
            val_40 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if((val_40.丛丐丘与丂万丌专三(丁丅丈丌丟世丗丗丟:  100)) == true)
            {
                goto label_51;
            }
            
            Rilisoft.三一丈七且丄与丝东 val_27 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_27 != null)
            {
                    return val_27.丛丐丘与丂万丌专三(丁丅丈丌丟世丗丗丟:  44);
            }
            
            return val_27.丛丐丘与丂万丌专三(丁丅丈丌丟世丗丗丟:  44);
            label_23:
            if(val_1 == 900)
            {
                goto label_51;
            }
            
            if(val_1 != 1000)
            {
                goto label_57;
            }
            
            return this.丙业丅一专丘且丂丂();
            label_51:
            val_44 = 1;
            return (bool)val_44 & 1;
            label_33:
            var val_28 = (val_1 == 1400) ? 1 : 0;
            return (bool)val_44 & 1;
            label_5:
            val_40 = PGCompany.GraffitiSystem.七丄上丑七丐丟与东.丑七不且上丗丁一世();
            PGCompany.丘三丏丌丗丒万丏丈 val_31 = val_40.一丌世丑丄东丞丘三(丞丅上丏丂且下丅与:  this._data.Id);
            if(val_31 == null)
            {
                goto label_57;
            }
            
            val_40 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_42 = val_40;
            val_43 = val_31.丑丐丙丄丅世世丑丒();
            label_18:
            val_44 = (val_42.不丌丝丗丒丛丏丙丌(丈丄不七三万丄丁不:  val_43, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) ^ 1;
            return (bool)val_44 & 1;
            label_57:
            val_44 = 0;
            return (bool)val_44 & 1;
            label_24:
            PGCompany.ModulesController val_36 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            if(val_36 != null)
            {
                    return val_36.丒丘世丄丟丌且且专(丕且丏丞业业一上丕:  this._data.Id);
            }
            
            return val_36.丒丘世丄丟丌且且专(丕且丏丞业业一上丕:  this._data.Id);
        }
        public void 且七丙丄丘一丄上不()
        {
        
        }
        private bool 丄丐丛丏丞与丌一丗()
        {
            string val_10;
            var val_11;
            val_10 = this;
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  this._data.Id)) == false)
            {
                goto label_4;
            }
            
            val_11 = 0;
            goto label_5;
            label_4:
            if((Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  this._data.Id)) == false)
            {
                goto label_9;
            }
            
            val_10 = this._data.Id;
            bool val_6 = Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  val_10);
            val_11 = val_6 ^ 1;
            label_5:
            val_6 = val_11;
            return (bool)val_6;
            label_9:
            Rilisoft.EggsManager val_7 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
            if(val_7 != null)
            {
                    return val_7.丄丞丂丟丗三丗丙丝(丈丕丁丘七丙丞不丙:  this._data.Id);
            }
            
            return val_7.丄丞丂丟丗三丗丙丝(丈丕丁丘七丙丞不丙:  this._data.Id);
        }
        private bool 丌业丟不三丗万丐丒()
        {
            PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  10, 丞丅上丏丂且下丅与:  this._data.Id);
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            return PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_2, 丆丗丝丄丄万丂丂且:  new PGCompany.ItemSystem.三三丌丞丘不且丗业[5]);
        }
        private bool 丌丌丟三七丛业与一()
        {
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  this._data.Id)) == true)
            {
                    return (bool)0 & 1;
            }
            
            this = System.Linq.Enumerable.FirstOrDefault<Rilisoft.丏丘七丞丄丙丌丞丁>(source:  Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.三下丙丛且丛丄丅丕(), predicate:  new System.Func<Rilisoft.丏丘七丞丄丙丌丞丁, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.GameEventItem::丐三与专丙丒丛丙一(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)));
            if(this == null)
            {
                    return (bool)0 & 1;
            }
            
            if(this.丐万且七专丒七丛丞() != false)
            {
                    if(this.丑丆丑三且丛上且丟() == false)
            {
                goto label_8;
            }
            
            }
            
            return (bool)0 & 1;
            label_8:
            bool val_12 = (Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丕丌丈丏丙丁丟东丘(下丅丙一丂丗丅丝七:  this)) ^ 1;
            return (bool)0 & 1;
        }
        private bool 丁丁上丘丙丘下且上()
        {
            object val_17;
            System.Func<TSource, System.Boolean> val_18;
            var val_19;
            val_17 = this;
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  this._data.Id)) != true)
            {
                    System.Func<丕丈丏丝丗下丟丅丂, System.Boolean> val_5 = null;
                val_18 = val_5;
                val_5 = new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.GameEventItem::下万丙丙丞丒专七丙(丕丈丏丝丗下丟丅丂 七丞丙丒三丕且丌丟));
                val_17 = System.Linq.Enumerable.FirstOrDefault<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  val_5);
                if(val_17 == null)
            {
                    return (bool)val_19;
            }
            
                val_18 = val_17.业东丅东丌上丗丑不();
                if((PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().TryGetValue(下上丐丆丝丟丝丒不:  val_18, 丙业与丙丗丝不丈东: out  0)) != true)
            {
                    if((丁下万丟且丟丛下业.东丞丄丌丙丟丘世丈(丗丑丐丕丟丝且下丕:  val_17.业上丙丞丐丄丆丅七(), 丝丒上丑一三丑丐丛:  true)) == false)
            {
                goto label_16;
            }
            
            }
            
            }
            
            val_19 = 0;
            return (bool)val_19;
            label_16:
            var val_16 = (val_17.丈丒丟下丂丒东与丑() <= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
            return (bool)val_19;
        }
        private bool 与丗丆丝与丕丁丞世()
        {
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_67;
            val_62 = this;
            if((丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<System.Char>(丑东与丅丐丅丂丞业:  this._data.Id)) == false)
            {
                goto label_4;
            }
            
            label_97:
            val_63 = 0;
            return (bool)val_63;
            label_4:
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  this._data.Id)) == false)
            {
                goto label_9;
            }
            
            val_62 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  this._data.Id);
            if((val_62 == null) || (val_62.丗三三丐丁东丘丌一() >= val_62.三丐丟丒业丞东三丕()))
            {
                goto label_97;
            }
            
            goto label_69;
            label_9:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this._data.Id)) == false)
            {
                goto label_18;
            }
            
            label_69:
            val_63 = 1;
            return (bool)val_63;
            label_18:
            val_64 = null;
            val_64 = null;
            if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  this._data.Id)) == false)
            {
                goto label_23;
            }
            
            三丅丁丗丗丝丂万且 val_15 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this._data.Id);
            if(val_15 == null)
            {
                    return (bool)val_63;
            }
            
            if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_15.业东丅东丌上丗丑不())) != null)
            {
                goto label_97;
            }
            
            label_101:
            if((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  this._data.Id)) >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_15.三与丛丑且丐丈业丌())))
            {
                goto label_97;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_23 = WeaponManager.万一丛七丙丑丄丆丑();
            if((System.String.op_Inequality(a:  val_23.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  val_15.与不丞丑七丘丁丂丛())) == false)
            {
                goto label_97;
            }
            
            val_65 = WeaponManager.七世丂丁丆丙丐丆丌();
            string val_28 = val_15.与不丞丑七丘丁丂丛();
            goto label_43;
            label_23:
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  this._data.Id)) == false)
            {
                goto label_48;
            }
            
            if((丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  this._data.Id)) == true)
            {
                goto label_97;
            }
            
            label_87:
            if((Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  this._data.Id)) >= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this._data.Id)))
            {
                goto label_97;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_38 = WeaponManager.万一丛七丙丑丄丆丑();
            if((System.String.op_Inequality(a:  val_38.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key()), b:  this._data.Id)) == false)
            {
                goto label_97;
            }
            
            val_65 = WeaponManager.七世丂丁丆丙丐丆丌();
            label_43:
            if((val_65.Contains(item:  this._data.Id)) == true)
            {
                goto label_97;
            }
            
            goto label_69;
            label_48:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this._data.Id)) == false)
            {
                goto label_74;
            }
            
            if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this._data.Id)) == true)
            {
                goto label_97;
            }
            
            丟丄七万东与上丒丟 val_52 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上().Item[this._data.Id];
            if(val_52 == null)
            {
                    return (bool)val_63;
            }
            
            if(val_52.丈丒丟下丂丒东与丑() > ExperienceController.丞丞丘业东丙丏七丌())
            {
                goto label_97;
            }
            
            goto label_87;
            label_74:
            val_67 = null;
            val_67 = null;
            if(((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  this._data.Id)) == false) || ((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丄东丝丛丝丁丐业不(丒东业不丐丑丕丄丆:  this._data.Id)) != null))
            {
                goto label_97;
            }
            
            if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this._data.Id)) != null)
            {
                goto label_101;
            }
            
            return (bool)val_63;
        }
        private bool 丙业丅一专丘且丂丂()
        {
            var val_12;
            var val_13;
            val_12 = this;
            if(((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this._data.Id)) != false) && ((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this._data.Id)) != true))
            {
                    val_12 = 丛且丗丌丏下七下丈.一三专丞丒丅上业上();
                丟丄七万东与上丒丟 val_8 = val_12.Item[this._data.Id];
                if(val_8 != null)
            {
                    val_12 = val_8.丈丒丟下丂丒东与丑();
                var val_11 = (val_12 <= ExperienceController.丞丞丘业东丙丏七丌()) ? 1 : 0;
                return (bool)val_13;
            }
            
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        public UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            UnityEngine.Texture val_3;
            if(this._texture == 0)
            {
                    this._texture = this._data.丑东丐下专丞丕丘世();
                return val_3;
            }
            
            val_3 = this._texture;
            return val_3;
        }
        public void 七丏丟丈丞丌一丆丒(bool 丏上一世一下丑丂三)
        {
            丏上一世一下丑丂三 = 丏上一世一下丑丂三;
            this._data.七丏丟丈丞丌一丆丒(丏上一世一下丑丂三:  丏上一世一下丑丂三);
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}:{1}:{2}", arg0:  this._data.Type, arg1:  this._data.Id, arg2:  this._data.Count);
        }
        private bool 丐三与专丙丒丛丙一(Rilisoft.丏丘七丞丄丙丌丞丁 七丞丙丒三丕且丌丟)
        {
            return System.String.op_Equality(a:  七丞丙丒三丕且丌丟.丙丕丞且丕不丘丙丑().业上丙丞丐丄丆丅七(), b:  this._data.Id);
        }
        private bool 下万丙丙丞丒专七丙(丕丈丏丝丗下丟丅丂 七丞丙丒三丕且丌丟)
        {
            return System.String.op_Equality(a:  七丞丙丒三丕且丌丟.业上丙丞丐丄丆丅七(), b:  this._data.Id);
        }
    
    }

}
