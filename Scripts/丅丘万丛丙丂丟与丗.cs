using UnityEngine;
internal static class 丅丘万丛丙丂丟与丗
{
    // Methods
    internal static 丅丘万丛丙丂丟与丗.东丝丕上不一下丄万 专七丘丙且丝下丆丅()
    {
        object val_18;
        int val_19;
        var val_21;
        val_18 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
        if(val_18 == null)
        {
            goto label_4;
        }
        
        val_19 = val_18.Call<System.String>(methodName:  "getPackageName", args:  System.Array.Empty<System.String>());
        if(val_19 == null)
        {
                val_19 = System.String.alignConst;
        }
        
        val_18 = val_18.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageManager", args:  System.Array.Empty<System.Object>());
        if(val_18 == null)
        {
            goto label_6;
        }
        
        object[] val_7 = new object[2];
        val_7[0] = val_19;
        val_19 = 64;
        val_7[1] = val_19;
        UnityEngine.AndroidJavaObject val_8 = val_18.Call<UnityEngine.AndroidJavaObject>(methodName:  "getPackageInfo", args:  val_7);
        if(val_8 == null)
        {
            goto label_14;
        }
        
        UnityEngine.AndroidJavaObject[] val_9 = val_8.Get<UnityEngine.AndroidJavaObject[]>(fieldName:  "signatures");
        if(val_9 == null)
        {
            goto label_15;
        }
        
        if(val_9.Length != 1)
        {
            goto label_16;
        }
        
        new System.Security.Cryptography.SHA1Managed() = new System.Security.Cryptography.SHA1Managed();
        string val_14 = System.Convert.ToBase64String(inArray:  new System.Security.Cryptography.SHA1Managed().ComputeHash(buffer:  val_9[0].Call<System.Byte[]>(methodName:  "toByteArray", args:  System.Array.Empty<System.Object>())));
        if(new System.Security.Cryptography.SHA1Managed() == null)
        {
            goto label_57;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        goto label_25;
        label_4:
        val_21 = 0;
        UnityEngine.Debug.LogWarning(message:  "activity == null");
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        label_6:
        val_21 = 0;
        UnityEngine.Debug.LogWarning(message:  "manager == null");
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        label_14:
        val_21 = 0;
        UnityEngine.Debug.LogWarning(message:  "packageInfo == null");
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        label_15:
        val_21 = 0;
        UnityEngine.Debug.LogWarning(message:  "signatures == null");
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        label_16:
        val_18 = "signatures.Length == "("signatures.Length == ") + val_9.Length;
        val_21 = 0;
        UnityEngine.Debug.LogWarning(message:  val_18);
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        label_25:
        new System.Security.Cryptography.SHA1Managed().Dispose();
        label_57:
        if(0 != 1)
        {
                if(0 == 0)
        {
                return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        }
        
            if(328 != 328)
        {
                return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        }
        
            return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        }
        
        if(0 == 0)
        {
                return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
        }
        
        return new 东丝丕上不一下丄万() {<丛丈丐且丄丆丆丕丞>k__BackingField = val_19, <万丒丁丂丗丒下不丂>k__BackingField = System.String.alignConst};
    }

}
