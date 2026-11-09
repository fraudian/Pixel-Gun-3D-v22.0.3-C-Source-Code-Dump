using UnityEngine;

namespace ARKitPlugin.Utils
{
    public static class 丆丙下与丛专丙丒丁
    {
        // Methods
        public static byte[] 且一且丗业万丛上丑(object 万且万且丑丗且丌丆)
        {
            System.IO.Stream val_4;
            object val_5 = 万且万且丑丗且丌丆;
            if(val_5 == null)
            {
                    return (System.Byte[])val_5;
            }
            
            System.IO.MemoryStream val_2 = null;
            val_4 = val_2;
            val_2 = new System.IO.MemoryStream();
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(serializationStream:  val_2, graph:  val_5 = 万且万且丑丗且丌丆);
            val_5 = val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_2.Dispose();
            if(0 != 1)
            {
                    return (System.Byte[])val_5;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])val_5;
            }
            
            return (System.Byte[])val_5;
        }
        public static T 丂东专丙丒丏且丛丁<T>(byte[] 与丏丝丅专世丘且且)
        {
            System.IO.Stream val_6;
            var val_7;
            var val_8;
            var val_9;
            if(与丏丝丅专世丘且且 == null)
            {
                goto label_1;
            }
            
            System.IO.MemoryStream val_1 = null;
            val_6 = val_1;
            val_1 = new System.IO.MemoryStream();
            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter() = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            val_7 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(serializationStream:  val_1);
            if(val_7 == null)
            {
                goto label_5;
            }
            
            val_8 = val_7;
            if(val_8 == null)
            {
                goto label_6;
            }
            
            val_9 = 0;
            goto label_7;
            label_1:
            val_8 = 0;
            return (ARKitPlugin.Utils.serializableFromEditorMessage)val_8;
            label_5:
            val_9 = 0;
            val_8 = 0;
            goto label_9;
            label_6:
            val_9 = 0;
            val_8 = 0;
            label_7:
            val_7 = 0;
            label_9:
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_1.Dispose();
            if(val_7 != 1)
            {
                    return (ARKitPlugin.Utils.serializableFromEditorMessage)val_8;
            }
            
            if(val_9 == 0)
            {
                    return (ARKitPlugin.Utils.serializableFromEditorMessage)val_8;
            }
            
            return (ARKitPlugin.Utils.serializableFromEditorMessage)val_8;
        }
    
    }

}
