using UnityEngine;

namespace Progress
{
    internal abstract class 丙丕丈一一丝丑七丈
    {
        // Properties
        internal abstract string 丞丘丗丑丏下东三丘 { get; }
        internal abstract string 丛业丐丈三丏丘世丆 { get; }
        internal virtual string 七丕丁且丁丒七丟业 { get; }
        
        // Methods
        internal 丙丕丈一一丝丑七丈()
        {
            goto typeof(Progress.丙丕丈一一丝丑七丈).__il2cppRuntimeField_238;
        }
        internal abstract string 与丐且丂丆万丛丘丕(); // 0
        internal abstract string 三丄丈丞一专丝丛丛(); // 0
        internal virtual string 丆七丅丐丝丐丝东丗()
        {
            return "";
        }
        internal abstract int 丈七丞丁丕东丌丄丘(); // 0
        internal abstract string 丆专丟一不东丈丁丆(); // 0
        protected abstract string 丈丞丘丛世业业丈丘(); // 0
        internal virtual void 业丒一上丑世万世丘(object 一丐丗丁丞丆丅丟丄)
        {
        
        }
        internal abstract void 不一丘丅且丆不七上(object 一丐丗丁丞丆丅丟丄); // 0
        internal abstract object 丙丘丝七业丟丁与丛(); // 0
        internal abstract void 丟丈丌丛且专丐丒丌(); // 0
        internal virtual void 丘上丐世丆丑且丞丒()
        {
        
        }
        internal virtual void 与世丄万丈丈上丆下()
        {
        
        }
        internal abstract void 且七丙丄丘一丄上不(); // 0
        internal string 专下丐丛丄东上丐三()
        {
            goto typeof(Progress.丙丕丈一一丝丑七丈).__il2cppRuntimeField_1B8;
        }
        internal virtual void Load()
        {
            if(this != null)
            {
                
            }
            else
            {
                    UnityEngine.Debug.LogErrorFormat(format:  "data == null", args:  System.Array.Empty<System.Object>());
            }
        
        }
        internal virtual void 丂且不业丂专丛丆东()
        {
            if((System.String.IsNullOrEmpty(value:  this)) != false)
            {
                    this = System.Array.Empty<System.Object>();
                UnityEngine.Debug.LogErrorFormat(format:  "save slot dataDict == null", args:  this);
                return;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  this);
            if((System.String.IsNullOrEmpty(value:  this)) == true)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  this);
        }
        internal virtual string 丁丑一丁丗业丒丗不()
        {
            if(this == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this);
        }
        internal virtual string 业丝丛丒丄专丕万丒()
        {
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  this)) == true)
            {
                    return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this);
            }
            
            0 = "{}";
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this, 下下丏一丙不丘丌丞:  0);
            return 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this);
        }
        internal virtual object 丟丗丞丕七丝世丌丞(string 丙七且丄丝丌丒万丘)
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丙七且丄丝丌丒万丘);
        }
        internal string 丙丈丌丛七丆丆丂丁()
        {
            return Progress.丗东丞丆丆丝丒丌专.且丁上一丞丅丐丞丘(丑东与丅丐丅丂丞业:  this);
        }
    
    }

}
