using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丄丙万万丁丄丞丒上 : 专丐丛东丄专万下丏
    {
        // Fields
        private const string 丁上丟丛上丆丌丙万 = "TimetablePromotionManualStart";
        private const string 丒丅丆丄丟不丙丆丐 = "TimetablePromotionManualEnd";
        private const string 丙丐世三业丛丅下丐 = "TimetablePromotionConstructableStart";
        private const string 丛世丐业丝一丄丘不 = "TimetablePromotionConstructableEnd";
        private const string 不且上丕一丟且七丑 = "TimetablePromotionUniversalStart";
        private const string 丞丑丏一下下丄丒丟 = "TimetablePromotionUniversalEnd";
        
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            string val_8;
            string val_9;
            string val_10;
            string val_11;
            string val_12;
            string val_13;
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540882701560] = val_1;
            val_8 = "TimetablePromotionManualStart";
            .下丄丈不与世丐业专 = val_8;
            if(val_1 == null)
            {
                    val_8 = "TimetablePromotionManualStart";
            }
            
            val_1.set_Item(key:  val_8, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            val_9 = "TimetablePromotionConstructableStart";
            .下丄丈不与世丐业专 = val_9;
            if(val_1 == null)
            {
                    val_9 = "TimetablePromotionConstructableStart";
            }
            
            val_1.set_Item(key:  val_9, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            val_10 = "TimetablePromotionUniversalStart";
            .下丄丈不与世丐业专 = val_10;
            if(val_1 == null)
            {
                    val_10 = "TimetablePromotionUniversalStart";
            }
            
            val_1.set_Item(key:  val_10, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            val_11 = "TimetablePromotionManualEnd";
            .下丄丈不与世丐业专 = val_11;
            if(val_1 == null)
            {
                    val_11 = "TimetablePromotionManualEnd";
            }
            
            val_1.set_Item(key:  val_11, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            val_12 = "TimetablePromotionConstructableEnd";
            .下丄丈不与世丐业专 = val_12;
            if(val_1 == null)
            {
                    val_12 = "TimetablePromotionConstructableEnd";
            }
            
            val_1.set_Item(key:  val_12, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            val_13 = "TimetablePromotionUniversalEnd";
            .下丄丈不与世丐业专 = val_13;
            if(this == null)
            {
                    val_13 = "TimetablePromotionUniversalEnd";
            }
            
            this.set_Item(key:  val_13, value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        internal override System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 丘丟万三丂丂丂丕丄(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            if((X22.ContainsKey(key:  丂丗下世三丞丁丏且.Id)) == false)
            {
                    return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionManualStart")) == true)
            {
                    return this.丛专七丝丂七且与且(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionManualEnd")) != false)
            {
                    return this.丛专七丝丂七且与且(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionConstructableStart")) == true)
            {
                    return this.丘丛丁且且下丗丞三(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionConstructableEnd")) != false)
            {
                    return this.丘丛丁且且下丗丞三(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionUniversalStart")) == true)
            {
                    return this.东与一不丆丄丑丆丌(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionUniversalEnd")) == false)
            {
                    return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            }
            
            return this.东与一不丆丄丑丆丌(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且);
        }
        private System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 东与一不丆丄丑丆丌(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            var val_6;
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_3 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            List.Enumerator<T> val_4 = PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().一丛丆下丒丐丆丈丏(丁丅丈丌丟世丗丗丟:  23).GetEnumerator();
            label_24:
            if((1916442752 & 1) == 0)
            {
                goto label_5;
            }
            
            PGCompany.StorePromotionConfig val_9 = PGCompany.丕一业万丂丟丄丘丙.丑七不且上丗丁一世().丏且专三丏一东丄丞(一丗与一专丙丙丅丄:  val_6.丐丏七丌丕丗业且上());
            if(val_9 == null)
            {
                goto label_24;
            }
            
            PGCompany.StorePromotionSettings val_10 = val_9.Settings;
            System.DateTimeOffset val_11 = System.DateTimeOffset.FromUnixTimeSeconds(seconds:  (long)val_10.StartTime);
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionUniversalStart")) != false)
            {
                    System.DateTime val_13 = System.DateTime.Now;
                System.TimeSpan val_14 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime() {dateData = val_13.dateData});
                LocalNotification.丝东上丅丟一东丗丗 val_15 = this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_14._ticks});
                if(val_15 != null)
            {
                    val_3.Add(item:  val_15);
            }
            
            }
            
            if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionUniversalEnd")) == false)
            {
                goto label_24;
            }
            
            PGCompany.StorePromotionSettings val_17 = val_9.Settings;
            PGCompany.StorePromotionSettings val_18 = val_9.Settings;
            LocalNotification.丝东上丅丟一东丗丗 val_19 = this.丏东丏且丑丕上丒丙(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 与丕丌丒丗丄丘丙东:  (long)val_17.StartTime, 业下丄丟丞丙一一一:  (long)val_18.EndTime);
            if(val_19 == null)
            {
                goto label_24;
            }
            
            val_3.Add(item:  val_19);
            goto label_24;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_3;
        }
        private System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 丛专七丝丂七且与且(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            var val_21;
            PGCompany.专丟专世丅丂丁且专 val_22;
            System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> val_2 = PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().一丛丆下丒丐丆丈丏(丁丅丈丌丟世丗丗丟:  17);
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_3 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            val_21 = 0;
            goto label_4;
            label_33:
            val_22 = val_2.Item[0];
            PGCompany.StorePromotionConfig val_6 = PGCompany.ManualOffers.与丈三上丗不丝丐丛.丑七不且上丗丁一世().丏且专三丏一东丄丞(一丗与一专丙丙丅丄:  val_22);
            if(val_6 != null)
            {
                    if((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionManualStart")) != false)
            {
                    PGCompany.StorePromotionSettings val_9 = val_6.Settings;
                if(PixelTime.丝丗专上三不丄丑丑() < (val_9.StartTime << ))
            {
                    PGCompany.StorePromotionSettings val_10 = val_6.Settings;
                var val_21 = (long)val_10.StartTime;
                val_21 = val_21 - PixelTime.丝丗专上三不丄丑丑();
                System.TimeSpan val_12 = System.TimeSpan.FromSeconds(value:  (double)val_21);
                LocalNotification.丝东上丅丟一东丗丗 val_13 = this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_12._ticks});
                if(val_13 != null)
            {
                    val_3.Add(item:  val_13);
            }
            
            }
            
            }
            
                val_22 = 丂丗下世三丞丁丏且.Id;
                if((val_22.Equals(value:  "TimetablePromotionManualEnd")) != false)
            {
                    val_22 = PixelTime.丝丗专上三不丄丑丑();
                PGCompany.StorePromotionSettings val_16 = val_6.Settings;
                if(val_22 < (val_16.EndTime << ))
            {
                    PGCompany.StorePromotionSettings val_17 = val_6.Settings;
                val_22 = val_17.StartTime;
                PGCompany.StorePromotionSettings val_18 = val_6.Settings;
                LocalNotification.丝东上丅丟一东丗丗 val_19 = this.丏东丏且丑丕上丒丙(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 与丕丌丒丗丄丘丙东:  (long)val_22, 业下丄丟丞丙一一一:  (long)val_18.EndTime);
                if(val_19 != null)
            {
                    val_3.Add(item:  val_19);
            }
            
            }
            
            }
            
            }
            
            val_21 = 1;
            label_4:
            if(val_21 < val_2.Count)
            {
                goto label_33;
            }
            
            return val_3;
        }
        private System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 丘丛丁且且下丗丞三(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且)
        {
            var val_21;
            var val_22;
            var val_23;
            PGCompany.专丟专世丅丂丁且专 val_24;
            System.Collections.Generic.List<PGCompany.专丟专世丅丂丁且专> val_2 = PGCompany.丁丞丒业不与万且下.丑七不且上丗丁一世().一丛丆下丒丐丆丈丏(丁丅丈丌丟世丗丗丟:  13);
            System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> val_3 = null;
            val_21 = val_3;
            val_3 = new System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>();
            val_22 = 1152921540883201952;
            val_23 = 0;
            goto label_4;
            label_28:
            val_24 = val_2.Item[0];
            PGCompany.丞丞丒下三三丘丈丗 val_6 = PGCompany.不三丄丆丄丛万丁且.丑七不且上丗丁一世().丈丒丞东专丒下丈专(一丗与一专丙丙丅丄:  val_24);
            if(val_6 != null)
            {
                    if(((丂丗下世三丞丁丏且.Id.Equals(value:  "TimetablePromotionConstructableStart")) != false) && (PixelTime.丝丗专上三不丄丑丑() < (val_6.上丟丄与丁三丌丘专() << )))
            {
                    var val_21 = (long)val_6.上丟丄与丁三丌丘专();
                val_21 = val_21 - PixelTime.丝丗专上三不丄丑丑();
                System.TimeSpan val_12 = System.TimeSpan.FromSeconds(value:  (double)val_21);
                LocalNotification.丝东上丅丟一东丗丗 val_13 = this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_12._ticks});
                val_21 = val_21;
                val_22 = 1152921540883201952;
                if(val_13 != null)
            {
                    val_3.Add(item:  val_13);
            }
            
            }
            
                val_24 = 丂丗下世三丞丁丏且.Id;
                if((val_24.Equals(value:  "TimetablePromotionConstructableEnd")) != false)
            {
                    val_24 = PixelTime.丝丗专上三不丄丑丑();
                if(val_24 < (val_6.下丒丗丄丌丘不丑丘() << ))
            {
                    val_24 = val_6.上丟丄与丁三丌丘专();
                LocalNotification.丝东上丅丟一东丗丗 val_19 = this.丏东丏且丑丕上丒丙(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 与丕丌丒丗丄丘丙东:  (long)val_24, 业下丄丟丞丙一一一:  (long)val_6.下丒丗丄丌丘不丑丘());
                if(val_19 != null)
            {
                    val_3.Add(item:  val_19);
            }
            
            }
            
            }
            
            }
            
            val_23 = 1;
            label_4:
            if(val_23 < val_2.Count)
            {
                goto label_28;
            }
            
            return (System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>)val_21;
        }
        private LocalNotification.丝东上丅丟一东丗丗 丏东丏且丑丕上丒丙(PGCompany.DataObjects.丆丏丛丝丈三七丗东 丂丗下世三丞丁丏且, long 与丕丌丒丗丄丘丙东, long 业下丄丟丞丙一一一)
        {
            var val_11;
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)业下丄丟丞丙一一一 - 与丕丌丒丗丄丘丙东);
            val_11 = 0;
            if(val_2._ticks.TotalHours < 0)
            {
                    return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks});
            }
            
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  (double)业下丄丟丞丙一一一 - PixelTime.丝丗专上三不丄丑丑());
            val_11 = 0;
            if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_6._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks});
            }
            
            System.TimeSpan val_8 = System.TimeSpan.FromHours(value:  6);
            val_11 = 0;
            if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = 1152921540883652920}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks});
            }
            
            return (LocalNotification.丝东上丅丟一东丗丗)this.丘丟万三丂丂丂丕丄(丂丗下世三丞丁丏且:  丂丗下世三丞丁丏且, 丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = val_6._ticks});
        }
        public 丄丙万万丁丄丞丒上()
        {
            val_1 = new System.Object();
        }
    
    }

}
