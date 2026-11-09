using UnityEngine;
public class meminfo
{
    // Fields
    public static meminfo.meminf minf;
    private static System.Text.RegularExpressions.Regex re;
    
    // Methods
    public static bool getMemInfo()
    {
        System.IO.FileStream val_23;
        var val_24;
        val_23 = "/proc/meminfo";
        if((System.IO.File.Exists(path:  "/proc/meminfo")) == false)
        {
            goto label_1;
        }
        
        System.IO.FileStream val_2 = new System.IO.FileStream(path:  "/proc/meminfo", mode:  3, access:  1, share:  1);
        System.IO.StreamReader val_3 = new System.IO.StreamReader(stream:  val_2);
        goto label_35;
        label_39:
        string val_5 = val_3.ToLower().Replace(oldValue:  " ", newValue:  "");
        if((val_5.Contains(value:  "memtotal")) != false)
        {
                meminfo.minf = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "memfree")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_4 = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "active")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_8 = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "inactive")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_C = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "cached")) != false)
        {
                if((val_5.Contains(value:  "swapcached")) != true)
        {
                meminfo.minf.__il2cppRuntimeField_10 = meminfo.mVal(s:  val_5);
        }
        
        }
        
        if((val_5.Contains(value:  "swapcached")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_14 = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "swaptotal")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_18 = meminfo.mVal(s:  val_5);
        }
        
        if((val_5.Contains(value:  "swapfree")) != false)
        {
                meminfo.minf.__il2cppRuntimeField_1C = meminfo.mVal(s:  val_5);
        }
        
        label_35:
        if(val_3 != null)
        {
            goto label_39;
        }
        
        val_23 = val_2;
        if(val_23 == 0)
        {
            goto label_40;
        }
        
        val_2.Dispose();
        val_24 = 1;
        return (bool)val_24;
        label_1:
        val_24 = 0;
        return (bool)val_24;
        label_40:
    }
    private static int mVal(string s)
    {
        null = null;
        return System.Int32.Parse(s:  meminfo.re.Match(input:  s).Value);
    }
    public static void gc_Collect()
    {
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "java.lang.System");
        T[] val_2 = System.Array.Empty<System.Object>();
        if(val_1 != null)
        {
                val_1.CallStatic(methodName:  "gc", args:  val_2);
        }
        else
        {
                0.CallStatic(methodName:  "gc", args:  val_2);
        }
        
        val_1.Dispose();
    }
    public meminfo()
    {
    
    }
    private static meminfo()
    {
        meminfo.minf = 0;
        meminfo.minf.__il2cppRuntimeField_10 = 0;
        meminfo.re = new System.Text.RegularExpressions.Regex(pattern:  "\\d+");
    }

}
