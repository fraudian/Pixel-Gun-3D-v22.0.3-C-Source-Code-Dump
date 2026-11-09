using UnityEngine;
public sealed class 丈丅一下丛丝丌丁丕
{
    // Properties
    internal static string 丈丒丑万丌丏东丐丅 { get; }
    
    // Methods
    private static void 丌丝丁且一丝丟丞上(string 丌不丝一不丒丕业丐)
    {
    
    }
    internal static void 世丄业丐七丁不上丄(UnityEngine.Texture2D 丙丒七丄上与丏丙丙, string 丛丄万三丂东丙丑东)
    {
        string val_2 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  丛丄万三丂东丙丑东);
    }
    internal static bool 丅丑丟丄丟且业丒丝(UnityEngine.Texture2D 丙丒七丄上与丏丙丙, string 丛丄万三丂东丙丑东, bool 一一世丛七东丆丞且 = True)
    {
        string val_2 = System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  丛丄万三丂东丙丑东);
        System.Byte[] val_3 = UnityEngine.ImageConversion.EncodeToPNG(tex:  丙丒七丄上与丏丙丙);
        if((System.IO.File.Exists(path:  val_2)) != false)
        {
                System.IO.File.Delete(path:  val_2);
        }
        
        new System.IO.FileStream() = new System.IO.FileStream(path:  val_2, mode:  2, access:  2);
        var val_7 = 0;
        val_7 = val_7 + 1;
        new System.IO.FileStream().Dispose();
        if(0 != 1)
        {
                if(65 == 65)
        {
                return true;
        }
        
        }
        
        if(0 == 0)
        {
                return true;
        }
        
        return true;
    }
    internal static byte[] 下丗丏世三世上三丗(string 丛丄业丕且丗下一万)
    {
        var val_6;
        var val_7;
        var val_8;
        System.IO.FileStream val_1 = new System.IO.FileStream(path:  丛丄业丕且丗下一万, mode:  3, access:  1);
        var val_6 = val_1;
        if(val_6 >= (-2147483648))
        {
            goto label_2;
        }
        
        val_6 = new byte[843787088];
        if(val_6 < 1)
        {
            goto label_3;
        }
        
        label_5:
        if(val_1 == null)
        {
            goto label_4;
        }
        
        val_6 = val_6 - val_1;
        if(val_6 >= 1)
        {
            goto label_5;
        }
        
        label_3:
        val_7 = 0;
        val_8 = 0;
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_14;
        label_4:
        new System.IO.EndOfStreamException() = new System.IO.EndOfStreamException(message:  "Read beyond end of file.");
        label_2:
        new System.IO.IOException() = new System.IO.IOException(message:  "File is too long.");
        val_6 = 0;
        if(0 != 1)
        {
            goto label_13;
        }
        
        val_7 = 0;
        if(val_1 == null)
        {
            goto label_14;
        }
        
        label_6:
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_1.Dispose();
        label_14:
        if(val_7 != 1)
        {
                return 0;
        }
        
        if(null == null)
        {
                return 0;
        }
        
        return 0;
        label_13:
    }
    internal static UnityEngine.Texture2D 不丟丒专不丆不万万(string 丛丄万三丂东丙丑东, int 与丘东下丈东丛丂万 = 64, int 一丗世三专三万丞丞 = 32, bool 丞丅丆丘不丒丝万丈 = False)
    {
        if(丞丅丆丘不丒丝万丈 != false)
        {
                new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  与丘东下丈东丛丂万, height:  一丗世三专三万丞丞, textureFormat:  5, mipChain:  false);
        }
        else
        {
                new UnityEngine.Texture2D() = new UnityEngine.Texture2D(width:  与丘东下丈东丛丂万, height:  一丗世三专三万丞丞);
        }
        
        bool val_6 = UnityEngine.ImageConversion.LoadImage(tex:  new UnityEngine.Texture2D(), data:  丈丅一下丛丝丌丁丕.下丗丏世三世上三丗(丛丄业丕且丗下一万:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  丛丄万三丂东丙丑东)), markNonReadable:  true);
        return (UnityEngine.Texture2D)new UnityEngine.Texture2D();
    }
    internal static bool 丏世万丌下丘万丕专(string 丛丄万三丂东丙丑东)
    {
        System.IO.File.Delete(path:  System.IO.Path.Combine(path1:  UnityEngine.Application.persistentDataPath, path2:  丛丄万三丂东丙丑东));
        return true;
    }
    internal static string 一丟上丐丞业世专丘()
    {
        return UnityEngine.Application.persistentDataPath;
    }
    public 丈丅一下丛丝丌丁丕()
    {
    
    }

}
