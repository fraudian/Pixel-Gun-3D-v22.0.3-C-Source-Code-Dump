using UnityEngine;

namespace LocalNotification
{
    internal abstract class 专丐丛东丄专万下丏
    {
        // Fields
        internal PGCompany.DataObjects.丑丑丘不一丈丞丐且 丒三丝一上丙专丗丒;
        protected System.Collections.Generic.Dictionary<string, LocalNotification.专丐丛东丄专万下丏.丐丝丒业且丁丁下丞> 丁丁下万专丁丆丆三;
        
        // Methods
        protected abstract void 丗七且下上丐世丛且(); // 0
        internal void 丘上丐世丆丑且丞丒()
        {
            goto typeof(LocalNotification.专丐丛东丄专万下丏).__il2cppRuntimeField_168;
        }
        internal virtual System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 丘丟万三丂丂丂丕丄(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_9;
            var val_10;
            var val_11;
            val_9 = this.丁丁下万专丁丆丆三;
            if((val_9.ContainsKey(key:  丂丗下世三丞丁丏且.Id)) == false)
            {
                goto label_12;
            }
            
            val_10 = null;
            val_10 = null;
            val_9 = System.TimeSpan.Zero;
            丐丝丒业且丁丁下丞 val_2 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            if(val_2.丂丌与专七丟丂三不 == null)
            {
                goto label_8;
            }
            
            丐丝丒业且丁丁下丞 val_3 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            val_9 = val_3.丂丌与专七丟丂三不;
            System.TimeSpan val_4 = val_9.Invoke();
            if(val_4._ticks.TotalSeconds <= 0f)
            {
                goto label_12;
            }
            
            val_9 = val_4._ticks;
            label_8:
            LocalNotification.丝东上丅丟一东丗丗 val_6 = this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_9});
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_7 = null;
            val_11 = val_7;
            val_7 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            if(val_6 == null)
            {
                    return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
            }
            
            val_7.Add(item:  val_6);
            return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
            label_12:
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_8 = null;
            val_11 = val_8;
            val_8 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_11;
        }
        protected LocalNotification.丝东上丅丟一东丗丗 丘丟万三丂丂丂丕丄(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且, System.TimeSpan 丄专万丏丘上丑与一)
        {
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_24;
            string val_25;
            var val_26;
            val_24 = this.丁丁下万专丁丆丆三;
            if((val_24.ContainsKey(key:  丂丗下世三丞丁丏且.Id)) == false)
            {
                goto label_17;
            }
            
            丐丝丒业且丁丁下丞 val_2 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            if(val_2.丂丑三丙丁不丗专七 != 0)
            {
                goto label_6;
            }
            
            丐丝丒业且丁丁下丞 val_3 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            if(val_3.丘且丘下丁丑丗且丒 == 0)
            {
                goto label_9;
            }
            
            label_6:
            丐丝丒业且丁丁下丞 val_4 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            if(val_4.丂丑三丙丁不丗专七 < 1)
            {
                goto label_12;
            }
            
            val_25 = 丂丗下世三丞丁丏且.Id;
            val_24 = ExperienceController.丂丂下丑且下丌丝东();
            丐丝丒业且丁丁下丞 val_6 = this.丁丁下万专丁丆丆三.Item[val_25];
            if(val_24 < val_6.丂丑三丙丁不丗专七)
            {
                goto label_17;
            }
            
            label_12:
            丐丝丒业且丁丁下丞 val_7 = this.丁丁下万专丁丆丆三.Item[丂丗下世三丞丁丏且.Id];
            if(val_7.丘且丘下丁丑丗且丒 < 1)
            {
                goto label_31;
            }
            
            val_25 = 丂丗下世三丞丁丏且.Id;
            val_24 = ExperienceController.丂丂下丑且下丌丝东();
            丐丝丒业且丁丁下丞 val_9 = this.丁丁下万专丁丆丆三.Item[val_25];
            if(val_24 <= val_9.丘且丘下丁丑丗且丒)
            {
                goto label_31;
            }
            
            label_17:
            val_26 = 0;
            return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丞丅上丏丂且下丅与:  val_24 = 丂丗下世三丞丁丏且.Id, 专七世丄丝丙丏丅三:  new System.DateTime() {}, 下上丐丆丝丟丝丒不:  丂丗下世三丞丁丏且.NoEmojiLoc, 业丝专丂丂丄七丙丟:  val_25 = 丂丗下世三丞丁丏且.WithEmojiLoc, 一丂丛丗丒丄专丐丆:  丂丗下世三丞丁丏且.AlertAction, 丌与且与丑丈丁丄上:  val_22.七丘丄不与丑丛丛丅);
            label_9:
            val_24 = 丂丗下世三丞丁丏且.MinProgress;
            Rilisoft.丝丑丂丛万丐丈丘且 val_10 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            if((Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_24, 丑丒丄下丁丐专丄丞 = val_24, 上万三丆专丏丒丗业 = 丂丗下世三丞丁丏且.Id}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_10.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_10.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_10.上万三丆专丏丒丗业})) != false)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_13 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  ExperienceController.丂丂下丑且下丌丝东());
                val_26 = 0;
                if((Rilisoft.丝丑丂丛万丐丈丘且.万丟丏丄丄三丝业丞(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_13.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_13.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_13.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丂丗下世三丞丁丏且.MinProgress, 丑丒丄下丁丐专丄丞 = 丂丗下世三丞丁丏且.MinProgress, 上万三丆专丏丒丗业 = val_10.上万三丆专丏丒丗业})) == true)
            {
                    return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丞丅上丏丂且下丅与:  val_24, 专七世丄丝丙丏丅三:  new System.DateTime() {}, 下上丐丆丝丟丝丒不:  丂丗下世三丞丁丏且.NoEmojiLoc, 业丝专丂丂丄七丙丟:  val_25, 一丂丛丗丒丄专丐丆:  丂丗下世三丞丁丏且.AlertAction, 丌与且与丑丈丁丄上:  val_22.七丘丄不与丑丛丛丅);
            }
            
            }
            
            val_24 = 丂丗下世三丞丁丏且.MaxProgress;
            Rilisoft.丝丑丂丛万丐丈丘且 val_15 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            if((Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_24, 丑丒丄下丁丐专丄丞 = val_24, 上万三丆专丏丒丗业 = 丂丗下世三丞丁丏且.Id}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_15.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_15.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_15.上万三丆专丏丒丗业})) != false)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_18 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  ExperienceController.丂丂下丑且下丌丝东());
                val_26 = 0;
                if((Rilisoft.丝丑丂丛万丐丈丘且.上丆丟万丒丈且丈丝(丗专万丄丟丁丈丕丗:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_18.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_18.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_18.上万三丆专丏丒丗业}, 丘丒一丄丅丆世丌专:  new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = 丂丗下世三丞丁丏且.MaxProgress, 丑丒丄下丁丐专丄丞 = 丂丗下世三丞丁丏且.MaxProgress, 上万三丆专丏丒丗业 = val_15.上万三丆专丏丒丗业})) == true)
            {
                    return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丞丅上丏丂且下丅与:  val_24, 专七世丄丝丙丏丅三:  new System.DateTime() {}, 下上丐丆丝丟丝丒不:  丂丗下世三丞丁丏且.NoEmojiLoc, 业丝专丂丂丄七丙丟:  val_25, 一丂丛丗丒丄专丐丆:  丂丗下世三丞丁丏且.AlertAction, 丌与且与丑丈丁丄上:  val_22.七丘丄不与丑丛丛丅);
            }
            
            }
            
            label_31:
            if((丂丗下世三丞丁丏且.MinOffset != 0) && (丂丗下世三丞丁丏且.MaxOffset != 0))
            {
                    System.TimeSpan val_20 = LocalNotification.不丑世丞丕丄不丄丈.与丙丌丘丟万丕业丈(三丝业丈丝丝东丞三:  丂丗下世三丞丁丏且.MinOffset, 丗丙丆世丆丕万下丒:  丂丗下世三丞丁丏且.MaxOffset);
            }
            
            System.DateTime val_21 = System.DateTime.Now;
            丐丝丒业且丁丁下丞 val_22 = this.丁丁下万专丁丆丆三.Item[val_24];
            return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丞丅上丏丂且下丅与:  val_24, 专七世丄丝丙丏丅三:  new System.DateTime() {}, 下上丐丆丝丟丝丒不:  丂丗下世三丞丁丏且.NoEmojiLoc, 业丝专丂丂丄七丙丟:  val_25, 一丂丛丗丒丄专丐丆:  丂丗下世三丞丁丏且.AlertAction, 丌与且与丑丈丁丄上:  val_22.七丘丄不与丑丛丛丅);
        }
        protected LocalNotification.丝东上丅丟一东丗丗 丘丟万三丂丂丂丕丄(string 丞丅上丏丂且下丅与, System.DateTime 专七世丄丝丙丏丅三, string 下上丐丆丝丟丝丒不, string 业丝专丂丂丄七丙丟, string 一丂丛丗丒丄专丐丆, System.Collections.Generic.Dictionary<object, object> 丌与且与丑丈丁丄上)
        {
            string val_10;
            ulong val_11;
            var val_12;
            val_10 = 下上丐丆丝丟丝丒不;
            val_11 = 专七世丄丝丙丏丅三.dateData;
            int val_2 = LocalNotification.丒丗丘东上丘丞丆与.丑七不且上丗丁一世().东下业丅万下丗丙上(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
            if(val_2 == 1)
            {
                goto label_2;
            }
            
            if((LocalNotification.丒丗丘东上丘丞丆与.丑七不且上丗丁一世().丐丁丛业丏丛丙丐丂(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与)) == false)
            {
                goto label_4;
            }
            
            System.DateTime val_5 = LocalNotification.不丑世丞丕丄不丄丈.丏业丛专上与丄丟丅(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11});
            val_11 = val_5.dateData;
            goto label_10;
            label_4:
            if((LocalNotification.不丑世丞丕丄不丄丈.万丆丝丂且丆三丈丅(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_11})) == false)
            {
                goto label_10;
            }
            
            label_2:
            val_12 = 0;
            return (LocalNotification.丝东上丅丟一东丗丗)val_12;
            label_10:
            if(丌与且与丑丈丁丄上 == null)
            {
                    System.Collections.Generic.Dictionary<System.Object, System.Object> val_7 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
                val_7.Add(key:  丞丅上丏丂且下丅与, value:  1);
            }
            
            val_10 = this.丒三丝一上丙专丗丒;
            LocalNotification.丝东上丅丟一东丗丗 val_9 = null;
            val_12 = val_9;
            val_9 = new LocalNotification.丝东上丅丟一东丗丗();
            .<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
            .<且丈丁专东丆丄丂与>k__BackingField = val_10;
            .<丏万丑万七丅丝丏丅>k__BackingField = val_2;
            .<丒丙丝七丞丑东东丝>k__BackingField = val_5;
            .<七下万丏上东上与东>k__BackingField = val_7.丐业丛上丝与丗业丐(专七世丄丝丙丏丅三:  new System.DateTime() {dateData = val_11}, 不丁丗丂丘丒世丟丁:  val_10, 丒丆且丞丈业丏丆丞:  业丝专丂丂丄七丙丟, 一丂丛丗丒丄专丐丆:  业丝专丂丂丄七丙丟, 丌与且与丑丈丁丄上:  val_7);
            return (LocalNotification.丝东上丅丟一东丗丗)val_12;
        }
        protected object 丐业丛上丝与丗业丐(System.DateTime 专七世丄丝丙丏丅三, string 不丁丗丂丘丒世丟丁, string 丒丆且丞丈业丏丆丞, string 一丂丛丗丒丄专丐丆, System.Collections.Generic.Dictionary<object, object> 丌与且与丑丈丁丄上)
        {
            Unity.Notifications.Android.AndroidNotification val_2 = LocalNotification.不丑世丞丕丄不丄丈.三业丑七东三三且丅(专七世丄丝丙丏丅三:  new System.DateTime() {dateData = 专七世丄丝丙丏丅三.dateData}, 丕丅丛业丑万丟且丄:  "Key_0001", 丂七丌丆丘万不丟丄:  LocalNotification.不丑世丞丕丄不丄丈.丝丘丒丗世丒东专丌(且七丟丄丘七丘丒丅:  丒丆且丞丈业丏丆丞, 丈下一世丌丌丏下丞:  不丁丗丂丘丒世丟丁), 丌与且与丑丈丁丄上:  丌与且与丑丈丁丄上);
            return (object);
        }
        protected 专丐丛东丄专万下丏()
        {
        
        }
    
    }

}
