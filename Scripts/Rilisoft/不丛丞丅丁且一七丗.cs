using UnityEngine;

namespace Rilisoft
{
    internal sealed class 不丛丞丅丁且一七丗
    {
        // Fields
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.不丛丞丅丁且一七丗> 丝业丆丁业三丈丟东;
        private readonly string 丐七丛丏丆丈七丛业;
        
        // Properties
        public string 丟下丞丟与丂丟业丒 { get; }
        internal static Rilisoft.不丛丞丅丁且一七丗 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        public 不丛丞丅丁且一七丗()
        {
            string val_8;
            this.丐七丛丏丆丈七丛业 = System.String.alignConst;
            if((System.String.IsNullOrEmpty(value:  UnityEngine.Application.persistentDataPath)) != false)
            {
                    val_8 = System.Environment.GetFolderPath(folder:  26);
            }
            else
            {
                    val_8 = UnityEngine.Application.persistentDataPath;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_8)) == true)
            {
                    return;
            }
            
            if((System.IO.Directory.Exists(path:  val_8)) != true)
            {
                    System.IO.DirectoryInfo val_7 = System.IO.Directory.CreateDirectory(path:  val_8);
            }
            
            this.丐七丛丏丆丈七丛业 = val_8;
        }
        public string 不万丛七世三丗丐丟()
        {
            return (string)this.丐七丛丏丆丈七丛业;
        }
        internal static Rilisoft.不丛丞丅丁且一七丗 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.不丛丞丅丁且一七丗.丝业丆丁业三丈丟东 != null)
            {
                    return Rilisoft.不丛丞丅丁且一七丗.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.不丛丞丅丁且一七丗.丝业丆丁业三丈丟东.世三丞丅丑丌丈丈一();
        }
        public string 三丆世上丁丗丆丈丄(string 七丙不丅丛丘丗万与)
        {
            string val_10;
            int val_11;
            var val_12;
            val_10 = this;
            if(七丙不丅丛丘丗万与 == null)
            {
                goto label_15;
            }
            
            if((System.String.IsNullOrEmpty(value:  七丙不丅丛丘丗万与)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  this.丐七丛丏丆丈七丛业)) == false)
            {
                goto label_3;
            }
            
            }
            
            label_18:
            val_11 = System.String.alignConst;
            return (string)System.IO.Path.Combine(path1:  val_10 = this.丐七丛丏丆丈七丛业, path2:  +new System.Uri().Segments.TrimStart(trimChars:  char[] val_6 = new char[1]));
            label_3:
            new System.Uri() = new System.Uri(uriString:  七丙不丅丛丘丗万与);
            val_6[0] = '/';
            return (string)System.IO.Path.Combine(path1:  val_10, path2:  +new System.Uri().Segments.TrimStart(trimChars:  val_6));
            label_15:
            val_12 = new System.ArgumentNullException(paramName:  "url");
            if(0 != 1)
            {
                goto label_16;
            }
            
            if((null & 1) == 0)
            {
                goto label_17;
            }
            
            goto label_18;
            label_17:
            mem[8] = null;
            val_12 = 8;
            label_16:
        }
        private static 不丛丞丅丁且一七丗()
        {
            null = null;
            Rilisoft.不丛丞丅丁且一七丗.丝业丆丁业三丈丟东 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.不丛丞丅丁且一七丗>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.不丛丞丅丁且一七丗>(object:  不丛丞丅丁且一七丗.<>c.<>9, method:  Rilisoft.不丛丞丅丁且一七丗 不丛丞丅丁且一七丗.<>c::丞丛丄丆三三丏丝丒()));
        }
    
    }

}
