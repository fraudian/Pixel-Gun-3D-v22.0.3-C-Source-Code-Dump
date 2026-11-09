using UnityEngine;

namespace PGCompany
{
    internal sealed class 下丗与业丌丅丝丑东 : 不丄上丘丆业丟丕七, IDisposable
    {
        // Fields
        private static PGCompany.下丗与业丌丅丝丑东 世丒丞七专三与万丕;
        private System.WeakReference 丄丟业世丄丁丌专万;
        
        // Properties
        internal static PGCompany.下丗与业丌丅丝丑东 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        private 下丗与业丌丅丝丑东()
        {
        
        }
        internal static PGCompany.下丗与业丌丅丝丑东 丑七不且上丗丁一世()
        {
            PGCompany.下丗与业丌丅丝丑东 val_2;
            PGCompany.下丗与业丌丅丝丑东 val_3 = PGCompany.下丗与业丌丅丝丑东.世丒丞七专三与万丕;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.下丗与业丌丅丝丑东 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.下丗与业丌丅丝丑东();
            PGCompany.下丗与业丌丅丝丑东.世丒丞七专三与万丕 = val_2;
            val_3 = PGCompany.下丗与业丌丅丝丑东.世丒丞七专三与万丕;
            return val_3;
        }
        public PGCompany.七丙上丛七万且丁丟 丘丑丗丛下丒丁丙上()
        {
            int val_7;
            var val_8;
            val_7 = this;
            if(UnityEngine.Application.isEditor != true)
            {
                    UnityEngine.AndroidJavaObject val_3 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().且丄业丈丞丘丛业下();
                if(val_3 != null)
            {
                    val_7 = this.三丙丌丒丌不丆不丅(世丗丆丛丆且一世七:  val_3);
                if(val_7 != null)
            {
                    object[] val_5 = new object[2];
                val_5[0] = "status";
                val_5[1] = 0;
                val_8 = val_7;
                return (PGCompany.七丙上丛七万且丁丟)val_8;
            }
            
            }
            
            }
            
            val_8 = 0;
            return (PGCompany.七丙上丛七万且丁丟)val_8;
        }
        public PGCompany.丌丛万丅丕丞业丌丄 丁丐丘丟丈丌丞世丒()
        {
            var val_11;
            object val_12;
            PGCompany.丌丛万丅丕丞业丌丄 val_0;
            if(UnityEngine.Application.isEditor != false)
            {
                
            }
            else
            {
                    val_11 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世();
                UnityEngine.AndroidJavaObject val_3 = val_11.且丄业丈丞丘丛业下();
                if(val_3 != null)
            {
                    UnityEngine.AndroidJavaObject val_4 = this.三丙丌丒丌不丆不丅(世丗丆丛丆且一世七:  val_3);
                if(val_4 != null)
            {
                    object[] val_5 = new object[2];
                val_5[0] = "status";
                val_5[1] = 0;
                val_11 = val_4.Call<System.Int32>(methodName:  "getIntExtra", args:  val_5);
                object[] val_7 = new object[2];
                val_7[0] = "level";
                val_12 = 0;
                val_7[1] = val_12;
                if(((val_4.Call<System.Int32>(methodName:  "getIntExtra", args:  val_7)) & 2147483648) == 0)
            {
                    object[] val_9 = new object[2];
                val_12 = val_9;
                val_12[0] = "scale";
                val_12[1] = 0;
                if((val_4.Call<System.Int32>(methodName:  "getIntExtra", args:  val_9)) > 0)
            {
                
            }
            
            }
            
            }
            
            }
            
            }
            
            val_0.<丟不丆上与三不不丞>k__BackingField = 0;
            val_0.<丗丈世七七丗丙万丒>k__BackingField = 0;
            val_0.<丐下丘丟丂丁丘丄下>k__BackingField = 0;
            return val_0;
        }
        public void Dispose()
        {
            if(this.丄丟业世丄丁丌专万 == null)
            {
                    return;
            }
            
            if((this.丄丟业世丄丁丌专万 & 1) == 0)
            {
                    return;
            }
            
            this = this.丄丟业世丄丁丌专万;
            if(this == null)
            {
                    return;
            }
            
            this = (((System.WeakReference.__il2cppRuntimeField_typeHierarchy + (UnityEngine.AndroidJavaObject.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (this) : 0;
        }
        private UnityEngine.AndroidJavaObject 三丙丌丒丌不丆不丅(UnityEngine.AndroidJavaObject 世丗丆丛丆且一世七)
        {
            System.WeakReference val_8;
            System.Object[] val_9;
            val_8 = this;
            object[] val_1 = new object[1];
            val_1[0] = "android.intent.action.BATTERY_CHANGED";
            object[] val_3 = new object[2];
            val_9 = val_3;
            val_9[1] = new UnityEngine.AndroidJavaObject(className:  "android.content.IntentFilter", args:  val_1);
            UnityEngine.AndroidJavaObject val_4 = 世丗丆丛丆且一世七.Call<UnityEngine.AndroidJavaObject>(methodName:  "registerReceiver", args:  val_3);
            if(this.丄丟业世丄丁丌专万 != null)
            {
                    if((this.丄丟业世丄丁丌专万 & 1) != 0)
            {
                    return val_4;
            }
            
                val_8 = this.丄丟业世丄丁丌专万;
                if(val_8 != null)
            {
                    return val_4;
            }
            
                return val_4;
            }
            
            System.WeakReference val_5 = null;
            val_9 = val_5;
            val_5 = new System.WeakReference(target:  val_4, trackResurrection:  false);
            this.丄丟业世丄丁丌专万 = val_9;
            return val_4;
        }
    
    }

}
