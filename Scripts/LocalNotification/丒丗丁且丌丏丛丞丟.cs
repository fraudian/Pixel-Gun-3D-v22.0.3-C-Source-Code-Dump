using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丒丗丁且丌丏丛丞丟
    {
        // Fields
        private static readonly System.Lazy<LocalNotification.丒丗丁且丌丏丛丞丟> 丝业丆丁业三丈丟东;
        private const string 丐丌丞上世丛丐丏丛 = "scheduled_ln";
        private readonly Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<string, System.DateTime>> 丈丂七丞一丗丁业丛;
        
        // Properties
        internal static LocalNotification.丒丗丁且丌丏丛丞丟 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static LocalNotification.丒丗丁且丌丏丛丞丟 丑七不且上丗丁一世()
        {
            null = null;
            if(LocalNotification.丒丗丁且丌丏丛丞丟.丐丌丞上世丛丐丏丛 != null)
            {
                    return LocalNotification.丒丗丁且丌丏丛丞丟.丐丌丞上世丛丐丏丛.Value;
            }
            
            return LocalNotification.丒丗丁且丌丏丛丞丟.丐丌丞上世丛丐丏丛.Value;
        }
        internal 丒丗丁且丌丏丛丞丟()
        {
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.DateTime>> val_2 = new Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.DateTime>>(丟东丟丑丕丄丂丟丙:  "scheduled_ln", 东三丁丙丗万业七丟:  new DataSystem.丐一丞丄丅三丏且三());
            this.丈丂七丞一丗丁业丛 = val_2;
            if(val_2 != null)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.DateTime> val_3 = new System.Collections.Generic.Dictionary<System.String, System.DateTime>();
            if(this.丈丂七丞一丗丁业丛 == null)
            {
                
            }
        
        }
        internal void 丛且丐下世与丘丆丗()
        {
            LocalNotification.丒丗丘东上丘丞丆与.丂丌一与上丝丐丞丐(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗>>(object:  this, method:  System.Void LocalNotification.丒丗丁且丌丏丛丞丟::丘万下丌一万一丞丘(System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 不专业丐丈丝丅七万)));
        }
        internal void 且上与世丙丗且东七(string 丞丅上丏丂且下丅与)
        {
            var val_5;
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_16;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_16 = this.丈丂七丞一丗丁业丛;
            Dictionary.Enumerator<TKey, TValue> val_2 = val_16.GetEnumerator();
            label_10:
            if((1895447328 & 1) == 0)
            {
                goto label_3;
            }
            
            ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
            if((System.String.IsNullOrEmpty(value:  丞丅上丏丂且下丅与)) != true)
            {
                    if((System.String.op_Equality(a:  val_6._value._obj.丐丏七丌丕丗业且上(), b:  丞丅上丏丂且下丅与)) == true)
            {
                goto label_10;
            }
            
            }
            
            System.DateTime val_10 = System.DateTime.Now;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {}, t2:  new System.DateTime() {dateData = val_10.dateData})) == true)
            {
                goto label_10;
            }
            
            val_1.Add(item:  val_6._value._obj.丐丏七丌丕丗业且上());
            goto label_10;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((System.String.IsNullOrEmpty(value:  丞丅上丏丂且下丅与)) != false)
            {
                    if(val_1.Count == 0)
            {
                    return;
            }
            
            }
            
            val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            PGCompany.Analytics.一业丗丆世世上丁且.丗丐上世三专不世丒(丆丛丑世下一丐且丕:  val_16, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丆丗丞上丞丂丗东丂:  val_1);
        }
        private void 丘万下丌一万一丞丘(System.Collections.Generic.List<LocalNotification.丝东上丅丟一东丗丗> 不专业丐丈丝丅七万)
        {
            var val_3;
            Rilisoft.三丁丁丟与世丆丙丁<System.Collections.Generic.Dictionary<System.String, System.DateTime>> val_6;
            int val_7;
            var val_8;
            val_6 = this;
            this.丈丂七丞一丗丁业丛.Clear();
            List.Enumerator<T> val_1 = 不专业丐丈丝丅七万.GetEnumerator();
            label_9:
            if((1895615680 & 1) == 0)
            {
                goto label_4;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if(val_4 != null)
            {
                    val_7 = val_4.m_stringLength;
            }
            else
            {
                    val_7 = 11993091;
            }
            
            this.丈丂七丞一丗丁业丛.set_Item(key:  val_7, value:  new System.DateTime() {dateData = val_4});
            goto label_9;
            label_4:
            val_8 = public System.Void List.Enumerator<LocalNotification.丝东上丅丟一东丗丗>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(this.丈丂七丞一丗丁业丛.Count == 0)
            {
                    return;
            }
            
            val_6 = this.丈丂七丞一丗丁业丛;
            val_6.丂且不业丂专丛丆东();
        }
        private static 丒丗丁且丌丏丛丞丟()
        {
            null = null;
            LocalNotification.丒丗丁且丌丏丛丞丟.丐丌丞上世丛丐丏丛 = new System.Lazy<LocalNotification.丒丗丁且丌丏丛丞丟>(valueFactory:  new System.Func<LocalNotification.丒丗丁且丌丏丛丞丟>(object:  丒丗丁且丌丏丛丞丟.<>c.<>9, method:  LocalNotification.丒丗丁且丌丏丛丞丟 丒丗丁且丌丏丛丞丟.<>c::丈丘丒不丐丅丒与专()));
        }
    
    }

}
