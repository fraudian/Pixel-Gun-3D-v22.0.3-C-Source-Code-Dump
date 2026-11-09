using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class PrefabHandler
    {
        // Fields
        public UnityEngine.GameObject _prefab;
        public string FullPath;
        
        // Properties
        public string ResourcePath { get; }
        public UnityEngine.GameObject Prefab { get; }
        public bool PrefabIsLoaded { get; set; }
        
        // Methods
        public string get_ResourcePath()
        {
            return Rilisoft.PrefabHandler.丗专丙业丈丅丝丘不(丒丌丆三与丐三七丑:  this.FullPath);
        }
        public UnityEngine.GameObject get_Prefab()
        {
            UnityEngine.GameObject val_4;
            if(this._prefab == 0)
            {
                    this._prefab = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  Rilisoft.PrefabHandler.丗专丙业丈丅丝丘不(丒丌丆三与丐三七丑:  this.FullPath));
                return val_4;
            }
            
            val_4 = this._prefab;
            return val_4;
        }
        public bool get_PrefabIsLoaded()
        {
            return UnityEngine.Object.op_Inequality(x:  this._prefab, y:  0);
        }
        public void set_PrefabIsLoaded(bool 丙业与丙丗丝不丈东)
        {
            this._prefab = 0;
        }
        internal static string 丗专丙业丈丅丝丘不(string 丒丌丆三与丐三七丑)
        {
            string val_16;
            int val_17;
            var val_18;
            var val_19;
            var val_20;
            val_16 = 丒丌丆三与丐三七丑;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_16)) != false)
            {
                    val_17 = System.String.alignConst;
                return (string)System.IO.Path.Combine(path1:  System.IO.Path.GetDirectoryName(path:  string val_12 = System.String.Join(separator:  System.IO.Path.DirectorySeparatorChar, value:  val_6.ToArray())), path2:  System.IO.Path.GetFileNameWithoutExtension(path:  val_16 = val_12));
            }
            
            char[] val_2 = new char[1];
            char val_4 = ((val_16.Contains(value:  "/")) != true) ? 47 : 92;
            val_2[0] = val_4;
            System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.String>(source:  val_16.Split(separator:  val_2));
            if(val_6.Count < 1)
            {
                goto label_18;
            }
            
            val_19 = 1;
            goto label_11;
            label_16:
            if((val_6.Item[val_4].Equals(value:  "Resources")) == true)
            {
                goto label_14;
            }
            
            val_19 = 2;
            label_11:
            val_18 = 1;
            if(val_18 < val_6.Count)
            {
                goto label_16;
            }
            
            goto label_18;
            label_14:
            if((val_4 & 2147483648) == 0)
            {
                    val_6.RemoveRange(index:  0, count:  1);
            }
            
            label_18:
            val_20 = null;
            val_20 = null;
            return (string)System.IO.Path.Combine(path1:  System.IO.Path.GetDirectoryName(path:  val_12), path2:  System.IO.Path.GetFileNameWithoutExtension(path:  val_16));
        }
        public PrefabHandler()
        {
        
        }
    
    }

}
