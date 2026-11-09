using UnityEngine;

namespace Rilisoft
{
    internal sealed class BackSystem : MonoBehaviour
    {
        // Fields
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.BackSystem> 世丒丞七专三与万丕;
        private readonly System.Collections.Generic.LinkedList<Rilisoft.BackSystem.丛且丐下世与丘丆丗> 丞万上七世丈丏丘业;
        internal static byte[] 丁万丛丒丄业丐丙丟;
        
        // Properties
        internal static Rilisoft.BackSystem 丆丕丝丒不丙且丐丗 { get; }
        internal static bool 丞专丗丞世丂丝丈丒 { get; }
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        
        // Methods
        internal static Rilisoft.BackSystem 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.BackSystem.世丒丞七专三与万丕 != null)
            {
                    return Rilisoft.BackSystem.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.BackSystem.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
        }
        internal static bool 丁不与丕丐七丝丛丟()
        {
            return true;
        }
        private static bool 世丈且业丆丑丏丐一()
        {
            return true;
        }
        public System.IDisposable Register(System.Action 业丏丈世世世丞丒世, string 与且专丈不万东一万)
        {
            return (System.IDisposable)new BackSystem.丛且丐下世与丘丆丗(业丏丈世世世丞丒世:  业丏丈世世世丞丒世, 与且专丈不万东一万:  与且专丈不万东一万, 丝丘丑业丛万丞丌丝:  this.丞万上七世丈丏丘业);
        }
        public override string ToString()
        {
            return Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.丂丆丑世一不丘丏七());
        }
        private void Update()
        {
            System.Collections.Generic.LinkedList<丛且丐下世与丘丆丗> val_8;
            var val_9;
            val_8 = this;
            val_9 = null;
            if(Rilisoft.BackSystem.世丐与一丛业丆专丝() != false)
            {
                    if(PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().东丏东丕七业且丂七() == true)
            {
                    return;
            }
            
                UnityEngine.Input.ResetInputAxes();
                bool val_4 = UnityEngine.Application.isEditor;
                this.上世万丝与七万一丌();
                val_8 = this.丞万上七世丈丏丘业;
                System.Collections.Generic.LinkedListNode<T> val_5 = val_8.Last;
                if(val_5 == null)
            {
                    return;
            }
            
                val_8 = val_5.Value;
                val_8.丕丅丝丌业下三丘丅();
                return;
            }
            
            if((UnityEngine.Input.GetKeyUp(key:  8)) == false)
            {
                    return;
            }
        
        }
        private static bool 世丐与一丛业丆专丝()
        {
            return UnityEngine.Input.GetKeyUp(key:  27);
        }
        private object 丂丆丑世一不丘丏七()
        {
            var val_6;
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>(capacity:  this.丞万上七世丈丏丘业.Count);
            LinkedList.Enumerator<T> val_3 = this.丞万上七世丈丏丘业.GetEnumerator();
            label_11:
            if(((-930158720) & 1) == 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = val_6.丘一一丆业丂丘丒世();
            if(val_7.丘丒丙丕丅上丐丘丗() == false)
            {
                goto label_5;
            }
            
            val_2.Add(item:  val_7.丄丌一七丈万万丌丐() + " (Disposed)");
            goto label_11;
            label_5:
            val_2.Add(item:  val_7.丄丌一七丈万万丌丐());
            goto label_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (object)val_2;
        }
        private void 上世万丝与七万一丌()
        {
            System.Collections.Generic.LinkedListNode<T> val_1 = this.丞万上七世丈丏丘业.Last;
            if(val_1 == null)
            {
                    return;
            }
            
            do
            {
                if(val_1.Value.丘丒丙丕丅上丐丘丗() == false)
            {
                    return;
            }
            
                this.丞万上七世丈丏丘业.RemoveLast();
            }
            while(this.丞万上七世丈丏丘业.Last != null);
        
        }
        internal void 与专丅丁丏丞丂丞一()
        {
            this.丞万上七世丈丏丘业.RemoveLast();
        }
        internal static void 上丛丌丆丑上七世三()
        {
            UnityEngine.Object val_11;
            var val_13;
            string val_11 = 0.CreateString(val:  new char[8]);
            UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  System.IO.Path.Combine(path1:  val_11, path2:  0.CreateString(val:  new char[8])));
            if(val_6 != null)
            {
                    val_11 = (null == null) ? (val_6) : 0;
            }
            else
            {
                    val_11 = 0;
            }
            
            if(val_11 != 0)
            {
                    System.Byte[] val_8 = val_11.GetRawTextureData();
            }
            
            byte[] val_10 = new byte[32];
            val_13 = null;
            val_13 = null;
            Rilisoft.BackSystem.丁万丛丒丄业丐丙丟 = val_10;
            System.Array.Copy(sourceArray:  new byte[32], destinationArray:  val_10, length:  32);
        }
        private static Rilisoft.BackSystem 且上丛丏丁丕丟万上()
        {
            Rilisoft.BackSystem val_1 = UnityEngine.Object.FindObjectOfType<Rilisoft.BackSystem>();
            if(val_1 != 0)
            {
                    UnityEngine.Object.DontDestroyOnLoad(target:  val_1.gameObject);
                return val_1;
            }
            
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "Rilisoft.BackSystem");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_4);
            if(val_4 != null)
            {
                    return val_4.AddComponent<Rilisoft.BackSystem>();
            }
            
            return val_4.AddComponent<Rilisoft.BackSystem>();
        }
        public BackSystem()
        {
            this.丞万上七世丈丏丘业 = new System.Collections.Generic.LinkedList<丛且丐下世与丘丆丗>();
        }
        private static BackSystem()
        {
            Rilisoft.BackSystem.世丒丞七专三与万丕 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.BackSystem>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.BackSystem>(object:  0, method:  static Rilisoft.BackSystem Rilisoft.BackSystem::且上丛丏丁丕丟万上()));
        }
    
    }

}
