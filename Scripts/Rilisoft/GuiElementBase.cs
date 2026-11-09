using UnityEngine;

namespace Rilisoft
{
    public abstract class GuiElementBase : MonoBehaviour, IDisposable
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Rilisoft.GuiElementBase>> 丏七上丆丕上丑丙丙;
        public string StackName;
        public bool NameAsId;
        
        // Properties
        public abstract bool 七七业丒丟丝丘不丞 { get; }
        internal string 丁丟东丏丐不丂丙下 { get; }
        internal bool 世丗世不丑且丑丒丗 { get; }
        
        // Methods
        private static bool 丅万丞丘与丏丝丕丅(Rilisoft.GuiElementBase 丅丆东丏丙丝丅丆丟)
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(丅丆东丏丙丝丅丆丟 != 0)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丆东丏丙丝丅丆丟.StackName)) == false)
            {
                goto label_7;
            }
            
            }
            
            T[] val_3 = System.Array.Empty<System.Object>();
            return false;
            label_7:
            val_17 = null;
            val_17 = null;
            if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.ContainsKey(key:  丅丆东丏丙丝丅丆丟.StackName)) != false)
            {
                    val_18 = null;
                val_18 = null;
                if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName].Contains(item:  丅丆东丏丙丝丅丆丟)) != false)
            {
                    T[] val_7 = System.Array.Empty<System.Object>();
                return false;
            }
            
            }
            
            val_19 = null;
            val_19 = null;
            if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.ContainsKey(key:  丅丆东丏丙丝丅丆丟.StackName)) != true)
            {
                    val_20 = null;
                val_20 = null;
                Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Add(key:  丅丆东丏丙丝丅丆丟.StackName, value:  new System.Collections.Generic.List<Rilisoft.GuiElementBase>());
            }
            
            val_21 = null;
            val_21 = null;
            System.Collections.Generic.List<Rilisoft.GuiElementBase> val_10 = Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName];
            val_10.Add(item:  丅丆东丏丙丝丅丆丟);
            if(val_10.Count < 2)
            {
                    return false;
            }
            
            if(val_10 != null)
            {
                    val_22 = val_10.Count;
            }
            else
            {
                    val_22 = val_10.Count;
            }
            
            if((val_10.Item[val_22 - 2]) == 0)
            {
                    return false;
            }
            
            return false;
        }
        private static bool 丁丆丞丛上世专丟丕(Rilisoft.GuiElementBase 丅丆东丏丙丝丅丆丟)
        {
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            Rilisoft.GuiElementBase val_37;
            var val_38;
            var val_39;
            if(丅丆东丏丙丝丅丆丟 != 0)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丆东丏丙丝丅丆丟.StackName)) == false)
            {
                goto label_7;
            }
            
            }
            
            T[] val_3 = System.Array.Empty<System.Object>();
            return false;
            label_7:
            val_33 = null;
            val_33 = null;
            if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.ContainsKey(key:  丅丆东丏丙丝丅丆丟.StackName)) == false)
            {
                goto label_14;
            }
            
            val_34 = null;
            val_34 = null;
            if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName].Contains(item:  丅丆东丏丙丝丅丆丟)) == false)
            {
                goto label_28;
            }
            
            label_14:
            val_35 = null;
            val_35 = null;
            System.Collections.Generic.List<Rilisoft.GuiElementBase> val_7 = Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName];
            if(val_7.Count < 1)
            {
                    return false;
            }
            
            if(val_7 != null)
            {
                    val_36 = val_7.Count;
            }
            else
            {
                    val_36 = val_7.Count;
            }
            
            if(丅丆东丏丙丝丅丆丟.GetHashCode() != (val_7.Item[val_36 - 1].GetHashCode()))
            {
                goto label_28;
            }
            
            if(val_7 == null)
            {
                goto label_29;
            }
            
            val_37 = val_7.Item[val_7.Count - 1];
            goto label_30;
            label_28:
            T[] val_18 = System.Array.Empty<System.Object>();
            return false;
            label_29:
            val_37 = val_7.Item[val_7.Count - 1];
            label_30:
            bool val_22 = val_7.Remove(item:  val_37);
            if(val_7.Count < 1)
            {
                    return false;
            }
            
            if(val_7 != null)
            {
                    val_38 = val_7.Count;
            }
            else
            {
                    val_38 = val_7.Count;
            }
            
            if((val_7.Item[val_38 - 1]) == 0)
            {
                    return false;
            }
            
            if(val_7 != null)
            {
                    val_39 = val_7.Count;
            }
            else
            {
                    val_39 = val_7.Count;
            }
            
            Rilisoft.GuiElementBase val_32 = val_7.Item[val_39 - 1];
            return false;
        }
        private static bool Remove(Rilisoft.GuiElementBase 丅丆东丏丙丝丅丆丟)
        {
            var val_4;
            var val_5;
            if((Rilisoft.GuiElementBase.一三丄丕上丂专与丆(丅丆东丏丙丝丅丆丟:  丅丆东丏丙丝丅丆丟)) != false)
            {
                    val_4 = null;
                val_4 = null;
                bool val_3 = Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName].Remove(item:  丅丆东丏丙丝丅丆丟);
                val_5 = 1;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        internal static bool 一三丄丕上丂专与丆(Rilisoft.GuiElementBase 丅丆东丏丙丝丅丆丟)
        {
            var val_5;
            var val_6;
            if(丅丆东丏丙丝丅丆丟 == 0)
            {
                    return false;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丅丆东丏丙丝丅丆丟.StackName)) == true)
            {
                    return false;
            }
            
            val_5 = null;
            val_5 = null;
            if((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.ContainsKey(key:  丅丆东丏丙丝丅丆丟.StackName)) == false)
            {
                    return false;
            }
            
            val_6 = null;
            val_6 = null;
            System.Collections.Generic.List<Rilisoft.GuiElementBase> val_4 = Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[丅丆东丏丙丝丅丆丟.StackName];
            if(val_4 != null)
            {
                    return val_4.Contains(item:  丅丆东丏丙丝丅丆丟);
            }
            
            return val_4.Contains(item:  丅丆东丏丙丝丅丆丟);
        }
        internal static bool 一三丄丕上丂专与丆(string 东三丘不丂丌上丁丑, string 下丗专七一东万世东)
        {
            string val_9;
            var val_10;
            var val_11;
            val_9 = 下丗专七一东万世东;
            .下丗专七一东万世东 = val_9;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  东三丘不丂丌上丁丑)) == true)
            {
                goto label_4;
            }
            
            val_9 = (GuiElementBase.丞丂万丅不丒丘丟丗)[1152921542140365248].下丗专七一东万世东;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) == false)
            {
                goto label_7;
            }
            
            label_4:
            T[] val_4 = System.Array.Empty<System.Object>();
            return false;
            label_7:
            .下丗专七一东万世东 = 丞东丑专丛丆丄丝世.丄丘一丐上丕丌一丏(下业七不丑丂丏丟东:  (GuiElementBase.丞丂万丅不丒丘丟丗)[1152921542140365248].下丗专七一东万世东);
            val_10 = null;
            val_10 = null;
            val_9 = Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙;
            if((val_9.ContainsKey(key:  东三丘不丂丌上丁丑)) == false)
            {
                    return false;
            }
            
            val_11 = null;
            val_11 = null;
            return System.Linq.Enumerable.Any<Rilisoft.GuiElementBase>(source:  Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[东三丘不丂丌上丁丑], predicate:  new System.Func<Rilisoft.GuiElementBase, System.Boolean>(object:  new GuiElementBase.丞丂万丅不丒丘丟丗(), method:  System.Boolean GuiElementBase.丞丂万丅不丒丘丟丗::丈丁丙丒丟丁丕丏丛(Rilisoft.GuiElementBase 丗丛不丁丑专专丂且)));
        }
        internal static void 丆丟丟三丗东一丆三(string 丆丗丘丕且丈丘丁不, object[] 专丒丌丆下丐丞丟丞)
        {
        
        }
        public abstract bool get_IsVisible(); // 0
        internal string 丂与丅业丕万丗丂业()
        {
            return 丞东丑专丛丆丄丝世.丈丝丌丞丐一丌丝丐(万且万且丑丗且丌丆:  this.gameObject);
        }
        internal bool 专三三上东丆丒丂丘()
        {
            var val_10;
            var val_11;
            if((Rilisoft.GuiElementBase.一三丄丕上丂专与丆(丅丆东丏丙丝丅丆丟:  this)) != false)
            {
                    val_10 = null;
                val_10 = null;
                var val_9 = ((Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[this.StackName].Item[Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙.Item[this.StackName].Count - 1].GetHashCode()) == this.GetHashCode()) ? 1 : 0;
                return (bool)val_11;
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        internal void 业下丛七业丆丛万丂()
        {
            if((Rilisoft.GuiElementBase.一三丄丕上丂专与丆(丅丆东丏丙丝丅丆丟:  this)) != false)
            {
                    if(this.专三三上东丆丒丂丘() == true)
            {
                    return;
            }
            
                if((Rilisoft.GuiElementBase.Remove(丅丆东丏丙丝丅丆丟:  this)) == false)
            {
                    return;
            }
            
            }
            
            bool val_4 = Rilisoft.GuiElementBase.丅万丞丘与丏丝丕丅(丅丆东丏丙丝丅丆丟:  this);
        }
        internal void 专丌丅下万丐三丗丗()
        {
            if(this.专三三上东丆丒丂丘() != false)
            {
                    bool val_2 = Rilisoft.GuiElementBase.丁丆丞丛上世专丟丕(丅丆东丏丙丝丅丆丟:  this);
                return;
            }
            
            if((Rilisoft.GuiElementBase.一三丄丕上丂专与丆(丅丆东丏丙丝丅丆丟:  this)) != false)
            {
                    bool val_4 = Rilisoft.GuiElementBase.Remove(丅丆东丏丙丝丅丆丟:  this);
            }
        
        }
        internal void 丘一东专丐丁七丞七()
        {
            if((Rilisoft.GuiElementBase.Remove(丅丆东丏丙丝丅丆丟:  this)) == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Rilisoft.GuiElementBase).__il2cppRuntimeField_1A8;
        }
        protected virtual void 东丟丘世丕丆下不万()
        {
        
        }
        protected virtual void 丙丝七丅丑三丞丂且()
        {
        
        }
        public virtual void Dispose()
        {
        
        }
        protected virtual void Awake()
        {
        
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void Update()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        protected virtual void OnDestroy()
        {
            goto typeof(Rilisoft.GuiElementBase).__il2cppRuntimeField_1A8;
        }
        protected GuiElementBase()
        {
            this.StackName = System.String.alignConst;
        }
        private static GuiElementBase()
        {
            Rilisoft.GuiElementBase.丏七上丆丕上丑丙丙 = new System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<Rilisoft.GuiElementBase>>();
        }
    
    }

}
