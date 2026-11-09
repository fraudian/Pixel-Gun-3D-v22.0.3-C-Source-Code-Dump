using UnityEngine;

namespace LocalNotification
{
    internal static class 不丑世丞丕丄不丄丈
    {
        // Fields
        private static readonly System.TimeSpan 丟下上丗丆丆丏丗丌;
        private static readonly System.TimeSpan 专东丝丙丂丌一七万;
        private static readonly System.Collections.Generic.Dictionary<PGCompany.DataObjects.丑丑丘不一丈丞丐且, System.Type> 世丂上丌丞且丁七丏;
        private static System.Collections.Generic.Dictionary<System.Type, LocalNotification.专丐丛东丄专万下丏> 业丘东东丞丈七丝丐;
        
        // Methods
        internal static LocalNotification.专丐丛东丄专万下丏 且三与与丑丝丄丝三(PGCompany.DataObjects.丑丑丘不一丈丞丐且 丁丅丈丌丟世丗丗丟)
        {
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.Type, LocalNotification.专丐丛东丄专万下丏> val_12;
            var val_13;
            var val_14;
            val_9 = null;
            val_9 = null;
            if((LocalNotification.不丑世丞丕丄不丄丈.世丂上丌丞且丁七丏.ContainsKey(key:  丁丅丈丌丟世丗丗丟)) == false)
            {
                goto label_4;
            }
            
            val_10 = null;
            val_10 = null;
            System.Type val_2 = LocalNotification.不丑世丞丕丄不丄丈.世丂上丌丞且丁七丏.Item[丁丅丈丌丟世丗丗丟];
            if((LocalNotification.不丑世丞丕丄不丄丈.业丘东东丞丈七丝丐.ContainsKey(key:  val_2)) == false)
            {
                goto label_9;
            }
            
            val_11 = null;
            val_11 = null;
            val_12 = LocalNotification.不丑世丞丕丄不丄丈.业丘东东丞丈七丝丐;
            LocalNotification.专丐丛东丄专万下丏 val_4 = val_12.Item[val_2];
            return (LocalNotification.专丐丛东丄专万下丏)val_13;
            label_4:
            val_12 = 丁丅丈丌丟世丗丗丟;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  "LocalNotification20Helper: LocalNotificationSchedulerAbstract for "("LocalNotification20Helper: LocalNotificationSchedulerAbstract for ") + 丁丅丈丌丟世丗丗丟.ToString() + " not registered");
            val_13 = 0;
            return (LocalNotification.专丐丛东丄专万下丏)val_13;
            label_9:
            object val_7 = System.Activator.CreateInstance(type:  val_2);
            if(val_7 == null)
            {
                    return (LocalNotification.专丐丛东丄专万下丏)val_13;
            }
            
            mem2[0] = 丁丅丈丌丟世丗丗丟;
            val_14 = null;
            val_14 = null;
            LocalNotification.不丑世丞丕丄不丄丈.业丘东东丞丈七丝丐.set_Item(key:  val_2, value:  (((System.Object.__il2cppRuntimeField_typeHierarchy + (LocalNotification.专丐丛东丄专万下丏.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_7) : 0);
            return (LocalNotification.专丐丛东丄专万下丏)val_13;
        }
        internal static string 丝丘丒丗世丒东专丌(string 且七丟丄丘七丘丒丅, string 丈下一世丌丌丏下丞)
        {
            var val_3 = null;
            return (string)(LocalNotification.不丑世丞丕丄不丄丈.丙丐上丆下一丘丟业() != true) ? 且七丟丄丘七丘丒丅 : 丈下一世丌丌丏下丞;
        }
        private static bool 丙丐上丆下一丘丟业()
        {
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != true)
            {
                    if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 8)
            {
                goto label_2;
            }
            
            }
            
            return true;
            label_2:
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                    return true;
            }
            
            var val_5 = (Rilisoft.丅丒三丐不丏业丛万.丞三丅丈上丘丕且丈() > 22) ? 1 : 0;
            return true;
        }
        internal static Unity.Notifications.Android.AndroidNotification 三业丑七东三三且丅(System.DateTime 专七世丄丝丙丏丅三, string 丕丅丛业丑万丟且丄, string 丂七丌丆丘万不丟丄, System.Collections.Generic.Dictionary<object, object> 丌与且与丑丈丁丄上)
        {
            int val_4;
            int val_5;
            Unity.Notifications.Android.AndroidNotification val_0;
            val_4 = 丂七丌丆丘万不丟丄;
            val_5 = 丕丅丛业丑万丟且丄;
            selectOnLeft = "large_icon";
            string val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  丌与且与丑丈丁丄上);
            ThreadContextChanged = true;
            丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  "small_icon");
            if(val_5 == null)
            {
                    val_5 = System.String.alignConst;
            }
            
            丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_5));
            if(val_4 == null)
            {
                    val_4 = System.String.alignConst;
            }
            
            string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
            return val_0;
        }
        internal static bool 万丆丝丂且丆三丈丅(System.DateTime 不丗万丘丆丗上丗丏)
        {
            var val_6;
            long val_7;
            System.TimeSpan val_1 = 不丗万丘丆丗上丗丏.dateData.TimeOfDay;
            val_6 = null;
            val_6 = null;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌})) == false)
            {
                goto label_5;
            }
            
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_1._ticks}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌})) == false)
            {
                goto label_8;
            }
            
            val_7 = 1;
            goto label_15;
            label_5:
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_1._ticks}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌})) == false)
            {
                goto label_12;
            }
            
            label_8:
            val_7 = val_1._ticks;
            bool val_5 = System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_7}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万});
            goto label_15;
            label_12:
            val_7 = 0;
            label_15:
            val_7 = val_7 & 1;
            return (bool)val_7;
        }
        internal static System.DateTime 丏业丛专上与丄丟丅(System.DateTime 不丗万丘丆丗上丗丏)
        {
            ulong val_8;
            var val_9;
            val_8 = 不丗万丘丆丗上丗丏.dateData;
            if((LocalNotification.不丑世丞丕丄不丄丈.万丆丝丂且丆三丈丅(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_8})) == false)
            {
                    return (System.DateTime)val_8;
            }
            
            val_9 = null;
            val_9 = null;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万})) == false)
            {
                goto label_8;
            }
            
            System.DateTime val_3 = val_8.Date;
            goto label_9;
            label_8:
            System.TimeSpan val_4 = val_8.TimeOfDay;
            System.DateTime val_6 = val_8.Date;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_4._ticks}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万})) == true)
            {
                goto label_12;
            }
            
            System.DateTime val_7 = val_6.dateData.AddDays(value:  1);
            label_9:
            label_12:
            val_8;
            return (System.DateTime)val_8;
        }
        internal static System.DateTime 下三七丌专三丗丂上(System.DateTime 不丗万丘丆丗上丗丏)
        {
            ulong val_8;
            var val_9;
            var val_11;
            var val_12;
            val_8 = 不丗万丘丆丗上丗丏.dateData;
            if((LocalNotification.不丑世丞丕丄不丄丈.万丆丝丂且丆三丈丅(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_8})) == false)
            {
                    return (System.DateTime)val_8;
            }
            
            val_9 = null;
            val_9 = null;
            if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万})) == false)
            {
                goto label_8;
            }
            
            System.DateTime val_3 = val_8.Date;
            goto label_9;
            label_8:
            System.TimeSpan val_4 = val_8.TimeOfDay;
            val_11 = null;
            val_11 = null;
            System.DateTime val_6 = val_8.Date;
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_4._ticks}, t2:  new System.TimeSpan() {_ticks = LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌})) == false)
            {
                goto label_14;
            }
            
            val_12 = null;
            goto label_15;
            label_14:
            System.DateTime val_7 = val_6.dateData.AddDays(value:  -1);
            label_9:
            val_12 = null;
            label_15:
            val_12 = null;
            val_8 = ;
            return (System.DateTime)val_8;
        }
        internal static System.TimeSpan 与丙丌丘丟万丕业丈(int 三丝业丈丝丝东丞三, int 丗丙丆世丆丕万下丒)
        {
            System.TimeSpan val_1 = System.TimeSpan.FromMinutes(value:  (double)三丝业丈丝丝东丞三);
            System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  (double)丗丙丆世丆丕万下丒);
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  (double)UnityEngine.Random.Range(min:  (int)val_1._ticks.TotalSeconds, max:  (int)val_3._ticks.TotalSeconds));
            return (System.TimeSpan)val_6._ticks;
        }
        private static 不丑世丞丕丄不丄丈()
        {
            System.TimeSpan val_1 = System.TimeSpan.FromHours(value:  23);
            LocalNotification.不丑世丞丕丄不丄丈.丟下上丗丆丆丏丗丌 = val_1._ticks;
            System.TimeSpan val_2 = System.TimeSpan.FromHours(value:  8);
            LocalNotification.不丑世丞丕丄不丄丈.专东丝丙丂丌一七万 = val_2._ticks;
            System.Collections.Generic.Dictionary<PGCompany.DataObjects.丑丑丘不一丈丞丐且, System.Type> val_3 = new System.Collections.Generic.Dictionary<PGCompany.DataObjects.丑丑丘不一丈丞丐且, System.Type>();
            val_3.Add(key:  1, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  2, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  3, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  4, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  5, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  6, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  7, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  8, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  9, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  10, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  11, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  12, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  13, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  14, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  15, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  16, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  17, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  18, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  19, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  20, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_3.Add(key:  21, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            LocalNotification.不丑世丞丕丄不丄丈.世丂上丌丞且丁七丏 = val_3;
            LocalNotification.不丑世丞丕丄不丄丈.业丘东东丞丈七丝丐 = new System.Collections.Generic.Dictionary<System.Type, LocalNotification.专丐丛东丄专万下丏>();
        }
    
    }

}
