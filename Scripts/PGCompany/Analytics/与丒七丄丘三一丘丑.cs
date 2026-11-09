using UnityEngine;

namespace PGCompany.Analytics
{
    internal static class 与丒七丄丘三一丘丑
    {
        // Methods
        internal static void 丈丝与丞与丒丘丑丏()
        {
            PGCompany.Analytics.丏三一丁丙世丛丌丁 val_1 = PGCompany.Analytics.丏三一丁丙世丛丌丁.丑七不且上丗丁一世();
            0.丟丕且丏不丛东丛东(丒丘丏上丙丟丑丕丈:  "custom_app_open", 丘丂万丟丅丕丗一上:  "deviceModel", 三丒丑且丁下丅丒丏:  UnityEngine.SystemInfo.deviceModel);
        }
        internal static void 丌与丞上三丟丄丛与(double 丙业与丙丗丝不丈东, string 丟下丟丈万一丙东丄, string 丏丂不专上丘丂不丅)
        {
            object val_6;
            if(丟下丟丈万一丙东丄 == null)
            {
                goto label_1;
            }
            
            if(丏丂不专上丘丂不丅 == null)
            {
                goto label_2;
            }
            
            PGCompany.Analytics.丏三一丁丙世丛丌丁 val_1 = PGCompany.Analytics.丏三一丁丙世丛丌丁.丑七不且上丗丁一世();
            Firebase.Analytics.Parameter[] val_2 = new Firebase.Analytics.Parameter[3];
            val_2[0] = new Firebase.Analytics.Parameter(parameterName:  "value", parameterValue:  丙业与丙丗丝不丈东);
            val_2[1] = new Firebase.Analytics.Parameter(parameterName:  "currency", parameterValue:  丏丂不专上丘丂不丅);
            val_2[2] = new Firebase.Analytics.Parameter(parameterName:  "itemName", parameterValue:  丟下丟丈万一丙东丄);
            0.丟丕且丏不丛东丛东(丒丘丏上丙丟丑丕丈:  "first_buy", 丗丟上上丒丐丗丞丙:  val_2);
            return;
            label_1:
            val_6 = "[FirebaseA_nalyticsHelper:FirstB_uy] itemName: null";
            goto label_16;
            label_2:
            val_6 = "[FirebaseA_nalyticsHelper:FirstB_uy] currency: null";
            label_16:
            UnityEngine.Debug.LogError(message:  val_6);
        }
    
    }

}
