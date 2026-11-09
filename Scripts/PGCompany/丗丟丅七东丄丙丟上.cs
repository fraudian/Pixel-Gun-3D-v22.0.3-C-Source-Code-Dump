using UnityEngine;

namespace PGCompany
{
    internal class 丗丟丅七东丄丙丟上
    {
        // Fields
        private int <上七东下丏不丕丐丑>k__BackingField;
        private PGCompany.ModuleData.ModuleRarity <业丒业丌三丏业下一>k__BackingField;
        private PGCompany.ModuleData.ModuleCategory <七丑丅丅一三世上丆>k__BackingField;
        private System.Collections.Generic.Dictionary<string, PGCompany.丏丂一丗丙世丏丐三> 专东万丏丂丞丏丁丁;
        
        // Properties
        internal int 下丄丈不与世丐业专 { get; set; }
        internal PGCompany.ModuleData.ModuleRarity 与丆与丗下丏丏专一 { get; set; }
        internal PGCompany.ModuleData.ModuleCategory 丁丙丛三丞丛丙丕丏 { get; set; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 丙不丁专丞丕丐上丛 { get; }
        
        // Methods
        internal int 业上丙丞丐丄丆丅七()
        {
            return (int)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        private void 丒丞东丈丁丄丑丅且(int 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.ModuleData.ModuleRarity 丌上一丑丝丁丄丝丞()
        {
            return (ModuleData.ModuleRarity)this.<业丒业丌三丏业下一>k__BackingField;
        }
        private void 丏丅专丗上与东丘丁(PGCompany.ModuleData.ModuleRarity 丙业与丙丗丝不丈东)
        {
            this.<业丒业丌三丏业下一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.ModuleData.ModuleCategory 丈七丑丌丝丁丕七丕()
        {
            return (ModuleCategory)this.<七丑丅丅一三世上丆>k__BackingField;
        }
        private void 丆丁上丏万丞世丒丒(PGCompany.ModuleData.ModuleCategory 丙业与丙丗丝不丈东)
        {
            this.<七丑丅丅一三世上丆>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 丏丝丄丄丗丟丙不丆()
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            return new Rilisoft.丝丑丂丛万丐丈丘且();
        }
        internal 丗丟丅七东丄丙丟上(int 下丞丝丂东东丛丗世, PGCompany.ModuleData.ModuleRarity 丄且与下丂丗丙丗丂, PGCompany.ModuleData.ModuleCategory 丁丝丟东上专丑丗丆)
        {
            this.专东万丏丂丞丏丁丁 = new System.Collections.Generic.Dictionary<System.String, PGCompany.丏丂一丗丙世丏丐三>();
            this.<业丒业丌三丏业下一>k__BackingField = 丄且与下丂丗丙丗丂;
            this.<七丑丅丅一三世上丆>k__BackingField = 丁丝丟东上专丑丗丆;
            this.<上七东下丏不丕丐丑>k__BackingField = 下丞丝丂东东丛丗世;
        }
        internal bool 丛上丌七丗丙丄丞万(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            var val_3;
            if(丕上业丕丘上丘七一 != null)
            {
                    var val_2 = (丕上业丕丘上丘七一.万丕丅下上丄丗万丞() == (this.<七丑丅丅一三世上丆>k__BackingField)) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        internal bool 丗东丞世上上丌丑万()
        {
            var val_3;
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_1 = this.丆丟且丗丒不丄七丌();
            val_3 = null;
            val_3 = null;
            if((丗丟丅七东丄丙丟上.<>c.<>9__16_0) != null)
            {
                    if(val_1 == null)
            {
                    return val_1.Exists(match:  丗丟丅七东丄丙丟上.<>c.<>9__16_0);
            }
            
                return val_1.Exists(match:  丗丟丅七东丄丙丟上.<>c.<>9__16_0);
            }
            
            丗丟丅七东丄丙丟上.<>c.<>9__16_0 = new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  丗丟丅七东丄丙丟上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丗丟丅七东丄丙丟上.<>c::下丐丆丝世一下专丟(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
            if(val_1 != null)
            {
                    return val_1.Exists(match:  丗丟丅七东丄丙丟上.<>c.<>9__16_0);
            }
            
            return val_1.Exists(match:  丗丟丅七东丄丙丟上.<>c.<>9__16_0);
        }
        internal int 丁专一丈丝丈丕七三(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            PGCompany.丏丂一丗丙世丏丐三 val_3;
            var val_4;
            val_3 = 丕上业丕丘上丘七一;
            if(val_3 == null)
            {
                goto label_1;
            }
            
            val_3 = this.丗不万东丟七东丆东(丕上业丕丘上丘七一:  val_3);
            if(val_3.Count < 1)
            {
                goto label_3;
            }
            
            if(val_3 != null)
            {
                    return val_3.Item[0];
            }
            
            return val_3.Item[0];
            label_1:
            val_4 = 1;
            return (int)val_4;
            label_3:
            val_4 = 0;
            return (int)val_4;
        }
        internal System.Collections.Generic.List<int> 丗不万东丟七东丆东(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            .丕上业丕丘上丘七一 = 丕上业丕丘上丘七一;
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            if((this.丆丟且丗丒不丄七丌().Exists(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  new 丗丟丅七东丄丙丟上.与丟业一丈上丅上不(), method:  System.Boolean 丗丟丅七东丄丙丟上.与丟业一丈上丅上不::三下不丕丂下丕三不(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)))) != false)
            {
                    val_2.Add(item:  2);
            }
            
            if((丗丟丅七东丄丙丟上.与丟业一丈上丅上不)[1152921555826614576].丕上业丕丘上丘七一 != null)
            {
                    if((丗丟丅七东丄丙丟上.与丟业一丈上丅上不)[1152921555826614576].丕上业丕丘上丘七一.万丕丅下上丄丗万丞() == (this.<七丑丅丅一三世上丆>k__BackingField))
            {
                goto label_6;
            }
            
            }
            
            val_2.Add(item:  3);
            label_6:
            if((丗丟丅七东丄丙丟上.与丟业一丈上丅上不)[1152921555826614576].丕上业丕丘上丘七一.丟丒万东东丂下七丘() != false)
            {
                    if(this.丗东丞世上上丌丑万() != false)
            {
                    val_2.Add(item:  6);
            }
            
            }
            
            int val_10 = this.丆丟且丗丒不丄七丌().Count;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11 = val_10.丏丝丄丄丗丟丙不丆();
            if(val_10 < )
            {
                    return val_2;
            }
            
            val_2.Add(item:  5);
            return val_2;
        }
        internal bool 下丅丕丗专丄丛丛丕(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            return (bool)((this.丁专一丈丝丈丕七三(丕上业丕丘上丘七一:  丕上业丕丘上丘七一)) == 0) ? 1 : 0;
        }
        internal void 丙专万丗丏丙丒上丂(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一, bool 七丆丟丗世丟且丒丆 = False)
        {
            if(七丆丟丗世丟且丒丆 != true)
            {
                    if((this.丁专一丈丝丈丕七三(丕上业丕丘上丘七一:  丕上业丕丘上丘七一)) != 0)
            {
                    return;
            }
            
            }
            
            this.丐丒丐不不丁丟丝业();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().东与上丌业不丛丌世(丌丘不丆丈丈世万上:  this.<上七东下丏不丕丐丑>k__BackingField, 丕且丏丞业业一上丕:  丕上业丕丘上丘七一.业上丙丞丐丄丆丅七());
        }
        internal bool 专丙七丞丆丝丆与丗(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            PGCompany.丏丂一丗丙世丏丐三 val_4 = 丕上业丕丘上丘七一;
            丗丟丅七东丄丙丟上.丈业丗丞丁七下一不 val_1 = new 丗丟丅七东丄丙丟上.丈业丗丞丁七下一不();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丕上业丕丘上丘七一 = val_4;
            if(val_4 == null)
            {
                    return false;
            }
            
            label_4:
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_2 = this.丆丟且丗丒不丄七丌();
            if(val_2 != null)
            {
                    return val_2.Exists(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  val_1, method:  System.Boolean 丗丟丅七东丄丙丟上.丈业丗丞丁七下一不::世上下丘丈专不丒丝(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)));
            }
            
            return val_2.Exists(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  val_1, method:  System.Boolean 丗丟丅七东丄丙丟上.丈业丗丞丁七下一不::世上下丘丈专不丒丝(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)));
            label_1:
            mem[16] = val_4;
            val_4 = mem[16];
            if(val_4 != 0)
            {
                goto label_4;
            }
            
            return false;
        }
        internal void 丆专丆世专丐丈七专(PGCompany.丏丂一丗丙世丏丐三 丕上业丕丘上丘七一)
        {
            if((this.专丙七丞丆丝丆与丗(丕上业丕丘上丘七一:  丕上业丕丘上丘七一)) == false)
            {
                    return;
            }
            
            this.丐丒丐不不丁丟丝业();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丆丞丕丏万且丗丁且(丌丘不丆丈丈世万上:  this.<上七东下丏不丕丐丑>k__BackingField, 丕且丏丞业业一上丕:  丕上业丕丘上丘七一.业上丙丞丐丄丆丅七());
        }
        internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丆丟且丗丒不丄七丌()
        {
            var val_6;
            var val_13;
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_1 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>();
            val_13 = Progress.七七世万专丕丁上业.三丌丂业专东丌且丈().丕丏世丗一丅一丗丝(丌丘不丆丈丈世万上:  this.<上七东下丏不丕丐丑>k__BackingField);
            List.Enumerator<T> val_4 = val_13.GetEnumerator();
            label_17:
            if(((-319147952) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if((this.专东万丏丂丞丏丁丁.ContainsKey(key:  val_7)) != true)
            {
                    PGCompany.丗丟丄丈东丝丕丄世 val_10 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  126, 丞丅上丏丂且下丅与:  val_7);
                if(val_10 != null)
            {
                    if(null != null)
            {
                
            }
            else
            {
                    this.专东万丏丂丞丏丁丁.Add(key:  val_7, value:  val_10);
            }
            
            }
            
            }
            
            if((this.专东万丏丂丞丏丁丁.ContainsKey(key:  val_7)) == false)
            {
                goto label_17;
            }
            
            val_1.Add(item:  this.专东万丏丂丞丏丁丁.Item[val_7]);
            goto label_17;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 专一三世与丌与丐丑()
        {
            var val_9;
            var val_26;
            var val_28;
            object val_29;
            PGCompany.丏丂一丗丙世丏丐三 val_30;
            PGCompany.丏丂一丗丙世丏丐三 val_31;
            var val_32;
            System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_34;
            var val_35;
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_1 = this.丆丟且丗丒不丄七丌();
            val_26 = null;
            val_26 = null;
            if((丗丟丅七东丄丙丟上.<>c.<>9__25_0) == null)
            {
                goto label_3;
            }
            
            label_23:
            val_28 = val_1.FindAll(match:  丗丟丅七东丄丙丟上.<>c.<>9__25_0);
            if(val_28.Count <= 1)
            {
                goto label_6;
            }
            
            ModulesSetGadgetsStorage.ModuleGadgetRecord val_5 = 0;
            val_29 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance;
            string val_6 = val_29.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_1, 丗丏丛丌丅东丟上丌: out  val_5);
            if(val_5 == 0)
            {
                goto label_32;
            }
            
            List.Enumerator<T> val_7 = val_28.GetEnumerator();
            val_30 = 0;
            goto label_15;
            label_16:
            val_29 = new 丗丟丅七东丄丙丟上.丄丆丌丌丕丈丆丆业();
            val_29 = new System.Object();
            val_31 = val_9.丐丏七丌丕丗业且上();
            .专丒不丁丐丞丐且专 = val_31;
            if(val_30 == 0)
            {
                    ModulesSetGadgetsStorage.ModuleGadgetRecord val_15 = 0;
                System.Predicate<PGCompany.丏丂一丗丙世丏丐三> val_13 = new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  new 丗丟丅七东丄丙丟上.丄丆丌丌丕丈丆丆业(), method:  System.Boolean 丗丟丅七东丄丙丟上.丄丆丌丌丕丈丆丆业::七与丘丄丁下丝丐丟(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                val_31 = val_1.FindAll(match:  null);
                string val_16 = Rilisoft.Singleton<PGCompany.ModulesController>.Instance.丈一一丒丑丘丒丏丝(丐丆丄丆东丕丞丆下:  val_31, 丗丏丛丌丅东丟上丌: out  val_15);
                val_30 = 0;
                if(val_15 == 0)
            {
                    val_30 = (丗丟丅七东丄丙丟上.丄丆丌丌丕丈丆丆业)[1152921555827607088].专丒不丁丐丞丐且专;
            }
            
            }
            
            label_15:
            if(((-318907952) & 1) != 0)
            {
                goto label_16;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_28 != null)
            {
                goto label_43;
            }
            
            goto label_18;
            label_6:
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_17 = null;
            val_28 = val_17;
            val_17 = new System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>();
            return (System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>)val_18;
            label_3:
            System.Predicate<PGCompany.丏丂一丗丙世丏丐三> val_18 = new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  丗丟丅七东丄丙丟上.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丗丟丅七东丄丙丟上.<>c::上丟丂丝万丂丌丂丞(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
            丗丟丅七东丄丙丟上.<>c.<>9__25_0 = val_18;
            if(val_1 != null)
            {
                goto label_23;
            }
            
            goto label_23;
            label_32:
            val_32 = null;
            val_32 = null;
            val_34 = 丗丟丅七东丄丙丟上.<>c.<>9__25_1;
            if(val_34 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32> val_19 = null;
                val_34 = val_19;
                val_19 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(object:  丗丟丅七东丄丙丟上.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丗丟丅七东丄丙丟上.<>c::专丁丐丌丙与丁丗丁(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                丗丟丅七东丄丙丟上.<>c.<>9__25_1 = val_34;
            }
            
            val_35 = null;
            val_35 = null;
            val_29 = 丗丟丅七东丄丙丟上.<>c.<>9__25_2;
            if(val_29 == null)
            {
                    System.Func<PGCompany.丏丂一丗丙世丏丐三, ModuleType> val_21 = null;
                val_29 = val_21;
                val_21 = new System.Func<PGCompany.丏丂一丗丙世丏丐三, ModuleType>(object:  丗丟丅七东丄丙丟上.<>c.__il2cppRuntimeField_static_fields, method:  ModuleType 丗丟丅七东丄丙丟上.<>c::下不七丝三丌丈七丅(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑));
                丗丟丅七东丄丙丟上.<>c.<>9__25_2 = val_29;
            }
            
            val_30 = System.Linq.Enumerable.First<PGCompany.丏丂一丗丙世丏丐三>(source:  System.Linq.Enumerable.ThenByDescending<PGCompany.丏丂一丗丙世丏丐三, ModuleType>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.丏丂一丗丙世丏丐三, System.Int32>(source:  val_18, keySelector:  val_19), keySelector:  val_21));
            if(val_18 != null)
            {
                goto label_43;
            }
            
            label_18:
            label_43:
            bool val_24 = val_18.Remove(item:  val_30);
            return (System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三>)val_18;
        }
        internal System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丟且丘丗七且下三专()
        {
            .丑万丛丗世业三一与 = this.专一三世与丌与丐丑();
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_3 = this.丆丟且丗丒不丄七丌();
            int val_5 = val_3.RemoveAll(match:  new System.Predicate<PGCompany.丏丂一丗丙世丏丐三>(object:  new 丗丟丅七东丄丙丟上.丒丂万丒丂一上丞一(), method:  System.Boolean 丗丟丅七东丄丙丟上.丒丂万丒丂一上丞一::丐丌丐丁三且丈丑丗(PGCompany.丏丂一丗丙世丏丐三 三丟东丕丄丄下下丑)));
            return val_3;
        }
        private void 丐丒丐不不丁丟丝业()
        {
            this.专东万丏丂丞丏丁丁.Clear();
        }
    
    }

}
