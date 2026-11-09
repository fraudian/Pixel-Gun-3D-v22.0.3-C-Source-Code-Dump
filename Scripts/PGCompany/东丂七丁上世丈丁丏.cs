using UnityEngine;

namespace PGCompany
{
    internal class 东丂七丁上世丈丁丏
    {
        // Fields
        private static Rilisoft.不丅且丝丁丁与不丒<PGCompany.东丂七丁上世丈丁丏.ResorcesState> 上丙东一丆不丄丘上;
        private static System.Collections.Generic.Dictionary<string, UnityEngine.Coroutine> 专专丁丘丝丏上丕丏;
        
        // Properties
        private static System.Collections.Generic.Dictionary<string, string> 丝东下丕丗丂丑丟丐 { get; }
        
        // Methods
        private static System.Collections.Generic.Dictionary<string, string> 丙丒丝不东丒丆丐丄()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            if(PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上 == null)
            {
                    val_4 = null;
                val_4 = null;
                val_3 = new 东丂七丁上世丈丁丏.ResorcesState();
            }
            
            val_5 = null;
            val_5 = null;
            if(PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上 != null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.String>)PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上 + 16;
            }
            
            return (System.Collections.Generic.Dictionary<System.String, System.String>)PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上 + 16;
        }
        public static void 丗丏东丟世丅丏一丈(string 专专三丒丛丁且七丛, string 七丙不丅丛丘丗万与, System.Action 业丒丒专丞丒丘丌丗)
        {
            PGCompany.东丂七丁上世丈丁丏.不专丕与丁上丑丕丕(丂丐丄丁丆与丈丂上:  专专三丒丛丁且七丛);
            PGCompany.东丂七丁上世丈丁丏.专专丁丘丝丏上丕丏.Add(key:  专专三丒丛丁且七丛, value:  CoroutineRunner.Start(丂丒丐下丑丏丐专上:  PGCompany.东丂七丁上世丈丁丏.东丙丏丕丆丞丅丑万(专专三丒丛丁且七丛:  专专三丒丛丁且七丛, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 业丒丒专丞丒丘丌丗:  业丒丒专丞丒丘丌丗)));
        }
        private static System.Collections.IEnumerator 东丙丏丕丆丞丅丑万(string 专专三丒丛丁且七丛, string 七丙不丅丛丘丗万与, System.Action 业丒丒专丞丒丘丌丗)
        {
            东丂七丁上世丈丁丏.上丕专丛丌七东丒丙 val_1 = new 东丂七丁上世丈丁丏.上丕专丛丌七东丒丙();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .专专三丒丛丁且七丛 = 专专三丒丛丁且七丛;
                .七丙不丅丛丘丗万与 = 七丙不丅丛丘丗万与;
            }
            else
            {
                    mem[32] = 专专三丒丛丁且七丛;
                mem[40] = 七丙不丅丛丘丗万与;
            }
            
            .业丒丒专丞丒丘丌丗 = 业丒丒专丞丒丘丌丗;
            return (System.Collections.IEnumerator)val_1;
        }
        private static void 不专丕与丁上丑丕丕(string 丂丐丄丁丆与丈丂上)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((PGCompany.东丂七丁上世丈丁丏.专专丁丘丝丏上丕丏.ContainsKey(key:  丂丐丄丁丆与丈丂上)) == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            UnityEngine.Coroutine val_2 = PGCompany.东丂七丁上世丈丁丏.专专丁丘丝丏上丕丏.Item[丂丐丄丁丆与丈丂上];
            bool val_3 = PGCompany.东丂七丁上世丈丁丏.专专丁丘丝丏上丕丏.Remove(key:  丂丐丄丁丆与丈丂上);
            if(val_2 == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  val_2);
        }
        public static bool 与丌丒东丂且丅丕丐(string 下上丐丆丝丟丝丒不)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄();
            if(val_1 != null)
            {
                    return val_1.ContainsKey(key:  下上丐丆丝丟丝丒不);
            }
            
            return val_1.ContainsKey(key:  下上丐丆丝丟丝丒不);
        }
        public static byte[] 丂丈丏丝下丄丝丕上(string 下上丐丆丝丟丝丒不)
        {
            string val_9 = 下上丐丆丝丟丝丒不;
            if((PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().ContainsKey(key:  val_9 = 下上丐丆丝丟丝丒不)) != false)
            {
                    val_9 = Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  PGCompany.东丂七丁上世丈丁丏.丙丒丝不东丒丆丐丄().Item[val_9]);
                if(val_9 != null)
            {
                    if((System.IO.File.Exists(path:  val_9)) != false)
            {
                    return System.IO.File.ReadAllBytes(path:  val_9);
            }
            
            }
            
            }
            
            byte[] val_8 = new byte[0];
        }
        public static UnityEngine.Texture2D 丑东丐下专丞丕丘世(string 下上丐丆丝丟丝丒不, UnityEngine.FilterMode 专一与业丟七丈且下 = 0)
        {
            UnityEngine.Texture2D val_4;
            System.Byte[] val_1 = PGCompany.东丂七丁上世丈丁丏.丂丈丏丝下丄丝丕上(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            if((val_1 != null) && (val_1.Length >= 1))
            {
                    UnityEngine.Texture2D val_2 = null;
                val_4 = val_2;
                val_2 = new UnityEngine.Texture2D(width:  2, height:  2, textureFormat:  4, mipChain:  false);
                bool val_3 = UnityEngine.ImageConversion.LoadImage(tex:  val_2, data:  val_1, markNonReadable:  true);
                val_2.filterMode = 专一与业丟七丈且下;
                return (UnityEngine.Texture2D)val_4;
            }
            
            val_4 = 0;
            return (UnityEngine.Texture2D)val_4;
        }
        private static void 丘丛丘世一丟世丝丅(string 七丙不丅丛丘丗万与, byte[] 一丐丗丁丞丆丅丟丄)
        {
            string val_2 = Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) != false)
            {
                    return;
            }
            
            string val_4 = System.IO.Path.GetDirectoryName(path:  val_2);
            if((System.IO.Directory.Exists(path:  val_4)) != true)
            {
                    System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  val_4);
            }
            
            System.IO.File.WriteAllBytes(path:  val_2, bytes:  一丐丗丁丞丆丅丟丄);
        }
        private static void 专且丁丟丐丝丌丈上(string 七丙不丅丛丘丗万与)
        {
            string val_2 = Rilisoft.不丛丞丅丁且一七丗.丑七不且上丗丁一世().三丆世上丁丗丆丈丄(七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与);
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == true)
            {
                    return;
            }
            
            if((System.IO.File.Exists(path:  val_2)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  val_2);
        }
        public 东丂七丁上世丈丁丏()
        {
        
        }
        private static 东丂七丁上世丈丁丏()
        {
            PGCompany.东丂七丁上世丈丁丏.上丙东一丆不丄丘上 = new Rilisoft.不丅且丝丁丁与不丒<ResorcesState>(丟东丟丑丕丄丂丟丙:  "PersistentDataManager-_resorcesStates");
            PGCompany.东丂七丁上世丈丁丏.专专丁丘丝丏上丕丏 = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Coroutine>();
        }
    
    }

}
