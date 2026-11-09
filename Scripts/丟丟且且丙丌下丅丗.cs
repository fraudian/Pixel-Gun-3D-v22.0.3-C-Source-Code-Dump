using UnityEngine;
public class 丟丟且且丙丌下丅丗
{
    // Fields
    public CloudRegionCode 丂与丒不丄丛丏丟丆;
    public string 丗丗下丟三丆丅丕丐;
    public string 丒业下丁丂丆丝丘丏;
    public int 丕丗丈丞丑丁下七丝;
    
    // Methods
    public 丟丟且且丙丌下丅丗(CloudRegionCode 专丏不丏东丏丈丆上)
    {
        this.丂与丒不丄丛丏丟丆 = 专丏不丏东丏丈丆上;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丗丗下丟三丆丅丕丐 = 专丏不丏东丏丈丆上.ToString();
    }
    public 丟丟且且丙丌下丅丗(CloudRegionCode 专丏不丏东丏丈丆上, string 丌丗丌丁丄且丝丝丌, string 下丗世万丈丞上丌丏)
    {
        val_1 = new System.Object();
        this.丂与丒不丄丛丏丟丆 = 专丏不丏东丏丈丆上;
        this.丗丗下丟三丆丅丕丐 = val_1;
        this.丒业下丁丂丆丝丘丏 = 下丗世万丈丞上丌丏;
    }
    public static CloudRegionCode 与丛丆专东丐一且丅(string 世丄东且七一丗丟与)
    {
        var val_8;
        var val_9;
        object val_10;
        var val_11;
        val_8 = 世丄东且七一丗丟与;
        if(val_8 != null)
        {
                int val_1 = val_8.IndexOf(value:  '/');
            if(val_1 >= 1)
        {
                val_9 = val_8.Substring(startIndex:  0, length:  val_1);
        }
        
            val_10 = val_9.ToLower();
            if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_10)) != false)
        {
                object val_7 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_10);
            return (CloudRegionCode)val_11;
        }
        
        }
        
        val_11 = 4;
        return (CloudRegionCode)val_11;
    }
    internal static CloudRegionFlag 丙且丅丟三丁一丘丐(CloudRegionCode 万丅丝丈上丅丘丈丘)
    {
        System.Type val_7;
        var val_8;
        var val_9;
        val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_8 = 万丅丝丈上丅丘丈丘;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((System.Enum.IsDefined(enumType:  val_7, value:  万丅丝丈上丅丘丈丘.ToString())) != false)
        {
                val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_8 = null;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            object val_6 = System.Enum.Parse(enumType:  val_7, value:  null.ToString());
            return (CloudRegionFlag)val_9;
        }
        
        val_9 = 0;
        return (CloudRegionFlag)val_9;
    }
    internal static CloudRegionFlag 丙且丅丟三丁一丘丐(string 世丄东且七一丗丟与)
    {
        var val_6;
        string val_1 = 世丄东且七一丗丟与.ToLower();
        if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_1)) != false)
        {
                object val_5 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_1);
            return (CloudRegionFlag)val_6;
        }
        
        val_6 = 0;
        return (CloudRegionFlag)val_6;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "\'{0}\' \t{1}ms \t{2}", arg0:  this.丗丗下丟三丆丅丕丐, arg1:  this.丕丗丈丞丑丁下七丝, arg2:  this.丒业下丁丂丆丝丘丏);
    }

}
