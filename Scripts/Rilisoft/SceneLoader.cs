using UnityEngine;

namespace Rilisoft
{
    internal sealed class SceneLoader : Singleton<Rilisoft.SceneLoader>
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.且丙业丂丞一丈丙七> _loadingHistory;
        private Rilisoft.ScenesList 世丈丂丑业丆丆丈丞;
        private System.Action<Rilisoft.且丙业丂丞一丈丙七> 丄丌一丄与专丞丙丘;
        private System.Action<Rilisoft.且丙业丂丞一丈丙七> 丙与东丏丕丞丕丐东;
        
        // Properties
        private Rilisoft.ScenesList 丟与丄丕丗丛丈一业 { get; }
        internal static string 丐下丛世下一丂丌丑 { get; }
        
        // Methods
        private Rilisoft.ScenesList 不丙丗上丂一上丄上()
        {
            Rilisoft.ScenesList val_3;
            if(this.世丈丂丑业丆丆丈丞 == 0)
            {
                    this.世丈丂丑业丆丆丈丞 = UnityEngine.Resources.Load<Rilisoft.ScenesList>(path:  "ScenesList");
                return val_3;
            }
            
            val_3 = this.世丈丂丑业丆丆丈丞;
            return val_3;
        }
        internal static string 丝丝三丏丈丁丏丘丗()
        {
            int val_3;
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if(val_1.m_Handle.name != null)
            {
                    return (string)val_3;
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal void 丈丏丕丞一丗丏丄丅(System.Action<Rilisoft.且丙业丂丞一丈丙七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丄丌一丄与专丞丙丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丌一丄与专丞丙丘 != 1152921543535506968);
        
        }
        internal void 丞上下丆东丐丝七丈(System.Action<Rilisoft.且丙业丂丞一丈丙七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丄丌一丄与专丞丙丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丄丌一丄与专丞丙丘 != 1152921543535643544);
        
        }
        internal void 七东七不不丅下丞东(System.Action<Rilisoft.且丙业丂丞一丈丙七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丙与东丏丕丞丕丐东, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙与东丏丕丞丕丐东 != 1152921543535780128);
        
        }
        internal void 丛丌上丐丘不且丙七(System.Action<Rilisoft.且丙业丂丞一丈丙七> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丙与东丏丕丞丕丐东, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙与东丏丕丞丕丐东 != 1152921543535916704);
        
        }
        private void OnInstanceCreated()
        {
            var val_17;
            System.Func<Rilisoft.ExistsSceneInfo, System.String> val_19;
            var val_20;
            System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.Boolean> val_22;
            var val_23;
            System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.String> val_25;
            var val_26;
            System.Func<System.String, System.String, System.String> val_28;
            if(this.不丙丗上丂一上丄上() != 0)
            {
                    Rilisoft.ScenesList val_3 = this.不丙丗上丂一上丄上();
                val_17 = null;
                val_17 = null;
                val_19 = SceneLoader.<>c.<>9__12_0;
                if(val_19 == null)
            {
                    System.Func<Rilisoft.ExistsSceneInfo, System.String> val_4 = null;
                val_19 = val_4;
                val_4 = new System.Func<Rilisoft.ExistsSceneInfo, System.String>(object:  SceneLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.String SceneLoader.<>c::一一丄上七丅下上万(Rilisoft.ExistsSceneInfo 七丞丙丒三丕且丌丟));
                SceneLoader.<>c.<>9__12_0 = val_19;
            }
            
                val_20 = null;
                val_20 = null;
                val_22 = SceneLoader.<>c.<>9__12_1;
                if(val_22 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.Boolean> val_6 = null;
                val_22 = val_6;
                val_6 = new System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.Boolean>(object:  SceneLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean SceneLoader.<>c::丑丑丒丑一丏丙业东(System.Linq.IGrouping<string, Rilisoft.ExistsSceneInfo> 业七丐世专丝丂丟丈));
                SceneLoader.<>c.<>9__12_1 = val_22;
            }
            
                System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>>(source:  System.Linq.Enumerable.Where<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>>(source:  System.Linq.Enumerable.GroupBy<Rilisoft.ExistsSceneInfo, System.String>(source:  val_3.Infos, keySelector:  val_4), predicate:  val_6));
                if(val_8.Count >= 1)
            {
                    val_23 = null;
                val_23 = null;
                val_25 = SceneLoader.<>c.<>9__12_2;
                if(val_25 == null)
            {
                    System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.String> val_10 = null;
                val_25 = val_10;
                val_10 = new System.Func<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.String>(object:  SceneLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.String SceneLoader.<>c::七丄万丕丁丒万三七(System.Linq.IGrouping<string, Rilisoft.ExistsSceneInfo> 业七丐世专丝丂丟丈));
                SceneLoader.<>c.<>9__12_2 = val_25;
            }
            
                val_26 = null;
                val_26 = null;
                val_28 = SceneLoader.<>c.<>9__12_3;
                if(val_28 == null)
            {
                    System.Func<System.String, System.String, System.String> val_12 = null;
                val_28 = val_12;
                val_12 = new System.Func<System.String, System.String, System.String>(object:  SceneLoader.<>c.__il2cppRuntimeField_static_fields, method:  System.String SceneLoader.<>c::丞丑丒丐丒且丆丘业(string 上丕与丆丙丆丈丄丁, string 丗丕下东丅丏丕上丏));
                SceneLoader.<>c.<>9__12_3 = val_28;
            }
            
                UnityEngine.Debug.LogError(message:  "[SCENELOADER] duplicate scenes: "("[SCENELOADER] duplicate scenes: ") + System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.String>(source:  val_8, selector:  val_10), func:  val_12)(System.Linq.Enumerable.Aggregate<System.String>(source:  System.Linq.Enumerable.Select<System.Linq.IGrouping<System.String, Rilisoft.ExistsSceneInfo>, System.String>(source:  val_8, selector:  val_10), func:  val_12)));
                return;
            }
            
                System.Action<Rilisoft.且丙业丂丞一丈丙七> val_15 = new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this._loadingHistory, method:  typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_1E0);
                this.七东七不不丅下丞东(丙业与丙丗丝不丈东:  null);
                return;
            }
            
            System.Exception val_16 = new System.Exception(message:  "scenes list is null");
        }
        internal void 上丂丟丑丒上丄业丒(string 专万丟三世业丙丈且)
        {
            Rilisoft.ExistsSceneInfo val_1 = this.上丄业下丕丅丄不且(专万丟三世业丙丈且:  专万丟三世业丙丈且);
            0.丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  val_1.Name);
            if(this.丄丌一丄与专丞丙丘 != null)
            {
                    this.丄丌一丄与专丞丙丘.Invoke(obj:  new Rilisoft.且丙业丂丞一丈丙七());
            }
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  专万丟三世业丙丈且, mode:  0);
            if(this.丙与东丏丕丞丕丐东 == null)
            {
                    return;
            }
            
            this.丙与东丏丕丞丕丐东.Invoke(obj:  new Rilisoft.且丙业丂丞一丈丙七());
        }
        internal UnityEngine.AsyncOperation 丘与与丁丏世丟丙丑(string 专万丟三世业丙丈且, UnityEngine.SceneManagement.LoadSceneMode 丂丛丑东不丅丈一东 = 0)
        {
            Rilisoft.ExistsSceneInfo val_1 = this.上丄业下丕丅丄不且(专万丟三世业丙丈且:  专万丟三世业丙丈且);
            0.丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  val_1.Name);
            if(this.丄丌一丄与专丞丙丘 != null)
            {
                    this.丄丌一丄与专丞丙丘.Invoke(obj:  new Rilisoft.且丙业丂丞一丈丙七());
            }
            
            UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  val_1.Name, mode:  丂丛丑东不丅丈一东);
            UnityEngine.Coroutine val_5 = Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.StartCoroutine(routine:  this.一不丝丗下丈丄丒业(东丞丙专下七丞且东:  new Rilisoft.且丙业丂丞一丈丙七(), 丌万业且丟三丘丝万:  val_2));
            return val_2;
        }
        internal Rilisoft.ExistsSceneInfo 上丄业下丕丅丄不且(string 专万丟三世业丙丈且)
        {
            string val_9;
            object val_10;
            IntPtr val_11;
            val_9 = 专万丟三世业丙丈且;
            SceneLoader.丕丛业丁丏下一七丘 val_1 = new SceneLoader.丕丛业丁丏下一七丘();
            if(val_1 != null)
            {
                    val_10 = val_1;
                .专万丟三世业丙丈且 = val_9;
            }
            else
            {
                    val_10 = 16;
                mem[16] = val_9;
                val_9 = mem[16];
            }
            
            Rilisoft.ScenesList val_4 = this.不丙丗上丂一上丄上();
            if((System.String.IsNullOrEmpty(value:  System.IO.Path.GetDirectoryName(path:  val_9))) != false)
            {
                    val_11 = 1152921543536646064;
            }
            else
            {
                    val_11 = 1152921543536647088;
            }
            
            System.Func<Rilisoft.ExistsSceneInfo, System.Boolean> val_5 = new System.Func<Rilisoft.ExistsSceneInfo, System.Boolean>(object:  val_1, method:  val_11);
            Rilisoft.ExistsSceneInfo val_6 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.ExistsSceneInfo>(source:  val_4.Infos, predicate:  null);
            if(val_6 != null)
            {
                    return val_6;
            }
            
            System.ArgumentException val_8 = new System.ArgumentException(message:  System.String.Format(format:  "Unknown scene : \'{0}\'", arg0:  val_10));
        }
        private System.Collections.IEnumerator 一不丝丗下丈丄丒业(Rilisoft.且丙业丂丞一丈丙七 东丞丙专下七丞且东, UnityEngine.AsyncOperation 丌万业且丟三丘丝万)
        {
            SceneLoader.丂丏不丐三万丅丂丟 val_1 = new SceneLoader.丂丏不丐三万丅丂丟();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .东丞丙专下七丞且东 = 东丞丙专下七丞且东;
                mem[1152921543536880808] = 东丞丙专下七丞且东.<上三七世一丆丅一丐>k__BackingField;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 东丞丙专下七丞且东.<且上丁世丞丛上丁不>k__BackingField;
                mem[56] = 东丞丙专下七丞且东.<上三七世一丆丅一丐>k__BackingField;
            }
            
            .丌万业且丟三丘丝万 = 丌万业且丟三丘丝万;
            return (System.Collections.IEnumerator)val_1;
        }
        public SceneLoader()
        {
            this._loadingHistory = new System.Collections.Generic.List<Rilisoft.且丙业丂丞一丈丙七>();
        }
    
    }

}
