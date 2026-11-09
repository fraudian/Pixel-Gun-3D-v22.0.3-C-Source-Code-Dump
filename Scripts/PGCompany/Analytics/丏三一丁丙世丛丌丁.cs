using UnityEngine;

namespace PGCompany.Analytics
{
    internal sealed class 丏三一丁丙世丛丌丁
    {
        // Fields
        private static PGCompany.Analytics.丏三一丁丙世丛丌丁 世丒丞七专三与万丕;
        private readonly System.Threading.Tasks.Task <丐业专上丗不丁丐三>k__BackingField;
        
        // Properties
        public System.Threading.Tasks.Task 上丁且业世丟专丂三 { get; }
        internal static PGCompany.Analytics.丏三一丁丙世丛丌丁 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        private 丏三一丁丙世丛丌丁(System.Threading.Tasks.Task 丝与丆丞东丘丈东丘)
        {
            this.<丐业专上丗不丁丐三>k__BackingField = 丝与丆丞东丘丈东丘;
        }
        public System.Threading.Tasks.Task 七一丆丙丗丛业丌丌()
        {
            return (System.Threading.Tasks.Task)this.<丐业专上丗不丁丐三>k__BackingField;
        }
        internal static PGCompany.Analytics.丏三一丁丙世丛丌丁 丑七不且上丗丁一世()
        {
            if(PGCompany.Analytics.丏三一丁丙世丛丌丁.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Analytics.丏三一丁丙世丛丌丁 val_1 = PGCompany.Analytics.丏三一丁丙世丛丌丁.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "Instance");
            PGCompany.Analytics.丏三一丁丙世丛丌丁.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        internal static void 东丕丝世丑丈丞丄丁()
        {
            if(PGCompany.Analytics.丏三一丁丙世丛丌丁.世丒丞七专三与万丕 != null)
            {
                    return;
            }
            
            PGCompany.Analytics.丏三一丁丙世丛丌丁.世丒丞七专三与万丕 = PGCompany.Analytics.丏三一丁丙世丛丌丁.东丝七业丄丑丒世七(与丗丆丏丙丟与丒业:  "EnsureInitialized");
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈);
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈, string 丘丂万丟丅丕丗一上, string 三丒丑且丁下丅丒丏)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈, parameterName:  丘丂万丟丅丕丗一上, parameterValue:  三丒丑且丁下丅丒丏);
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈, string 丘丂万丟丅丕丗一上, int 三丒丑且丁下丅丒丏)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈, parameterName:  丘丂万丟丅丕丗一上, parameterValue:  三丒丑且丁下丅丒丏);
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈, string 丘丂万丟丅丕丗一上, long 三丒丑且丁下丅丒丏)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈, parameterName:  丘丂万丟丅丕丗一上, parameterValue:  三丒丑且丁下丅丒丏);
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈, string 丘丂万丟丅丕丗一上, double 三丒丑且丁下丅丒丏)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈, parameterName:  丘丂万丟丅丕丗一上, parameterValue:  三丒丑且丁下丅丒丏);
        }
        internal void 丟丕且丏不丛东丛东(string 丒丘丏上丙丟丑丕丈, Firebase.Analytics.Parameter[] 丗丟上上丒丐丗丞丙)
        {
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  丒丘丏上丙丟丑丕丈, parameters:  丗丟上上丒丐丗丞丙);
        }
        private static void 丗且世与丗丑下且上(System.Exception 一丌七七下丐丕上丟, string 丒丘丏上丙丟丑丕丈, string 与丗丆丏丙丟与丒业 = "")
        {
            UnityEngine.Debug.LogError(message:  "[FirebaseAnalyticsFacade." + 与丗丆丏丙丟与丒业 + "] An error occurred while logging: "("] An error occurred while logging: ") + 丒丘丏上丙丟丑丕丈);
            UnityEngine.Debug.LogException(exception:  一丌七七下丐丕上丟);
        }
        private static PGCompany.Analytics.丏三一丁丙世丛丌丁 东丝七业丄丑丒世七(string 与丗丆丏丙丟与丒业)
        {
            string val_12;
            string val_13;
            System.Action<System.Threading.Tasks.Task<T>> val_14;
            丏三一丁丙世丛丌丁.丕丛业丁丏下一七丘 val_1 = new 丏三一丁丙世丛丌丁.丕丛业丁丏下一七丘();
            if(val_1 != null)
            {
                    val_12 = val_1;
                .与丗丆丏丙丟与丒业 = 与丗丆丏丙丟与丒业;
                val_13 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            }
            else
            {
                    val_12 = 16;
                mem[16] = 与丗丆丏丙丟与丒业;
                val_13 = PGCompany.丙丁东丅丒上世与东.丞不与丑世丂七丙三();
            }
            
            .万丄丅丝三丈丆世丟 = val_13;
            val_14 = 1152921505171275776;
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[FirebaseAnalyticsFacade.Create] caller: "("[FirebaseAnalyticsFacade.Create] caller: ") + val_12 + ", userId: "(", userId: ") + (丏三一丁丙世丛丌丁.丕丛业丁丏下一七丘)[1152921560211108272].万丄丅丝三丈丆世丟);
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() == 1)
            {
                    System.Threading.Tasks.Task<TResult> val_7 = System.Threading.Tasks.Task.FromResult<System.Boolean>(result:  false);
            }
            else
            {
                    System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> val_9 = null;
                val_14 = val_9;
                val_9 = new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  val_1, method:  System.Void 丏三一丁丙世丛丌丁.丕丛业丁丏下一七丘::丌且丞七丌丒业丆丟(System.Threading.Tasks.Task<Firebase.DependencyStatus> 万不且且丛丆东丒业));
            }
            
            .<丐业专上丗不丁丐三>k__BackingField = Firebase.Extensions.TaskExtension.ContinueWithOnMainThread<Firebase.DependencyStatus>(task:  Firebase.FirebaseApp.CheckAndFixDependenciesAsync(), continuation:  val_9);
            return (PGCompany.Analytics.丏三一丁丙世丛丌丁)new PGCompany.Analytics.丏三一丁丙世丛丌丁();
        }
    
    }

}
