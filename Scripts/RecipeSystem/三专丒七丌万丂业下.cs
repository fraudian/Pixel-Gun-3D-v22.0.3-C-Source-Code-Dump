using UnityEngine;

namespace RecipeSystem
{
    internal sealed class 三专丒七丌万丂业下
    {
        // Fields
        private static System.Action 与世专丁一丌丛丐专;
        private static RecipeSystem.三专丒七丌万丂业下 <不丁丄七丛不丆丁丕>k__BackingField;
        private RecipeSystem.丌下丟丅丆丞万丅业 世丂上丌丞且丁七丏;
        private System.Collections.Generic.Dictionary<int, RecipeSystem.丝丏三三丕丁下丅丒> 上丅丗丒专且丏东万;
        
        // Properties
        internal static RecipeSystem.三专丒七丌万丂业下 丆丕丝丒不丙且丐丗 { get; set; }
        internal System.Collections.Generic.Dictionary<int, RecipeSystem.丝丏三三丕丁下丅丒> 丝丏三三丕丁下丅丒 { get; }
        
        // Methods
        internal static void 下不不上丒与一丁专(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  RecipeSystem.三专丒七丌万丂业下.与世专丁一丌丛丐专, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丂且丆丙一丈丙丛万(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  RecipeSystem.三专丒七丌万丂业下.与世专丁一丌丛丐专, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static RecipeSystem.三专丒七丌万丂业下 丑七不且上丗丁一世()
        {
            return (RecipeSystem.三专丒七丌万丂业下)RecipeSystem.三专丒七丌万丂业下.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(RecipeSystem.三专丒七丌万丂业下 丙业与丙丗丝不丈东)
        {
            RecipeSystem.三专丒七丌万丂业下.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<int, RecipeSystem.丝丏三三丕丁下丅丒> 丙且上专丝且丅专丕()
        {
            return (System.Collections.Generic.Dictionary<System.Int32, RecipeSystem.丝丏三三丕丁下丅丒>)this.上丅丗丒专且丏东万;
        }
        internal static void 上丛丌丆丑上七世三()
        {
            var val_2;
            if((RecipeSystem.三专丒七丌万丂业下.<不丁丄七丛不丆丁丕>k__BackingField) != null)
            {
                    return;
            }
            
            RecipeSystem.三专丒七丌万丂业下 val_1 = new RecipeSystem.三专丒七丌万丂业下();
            val_2 = null;
            RecipeSystem.三专丒七丌万丂业下.<不丁丄七丛不丆丁丕>k__BackingField = val_1;
            val_2 = null;
            val_1.丘上丐世丆丑且丞丒();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            this.且丛一三业丈丝丞丅();
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void RecipeSystem.三专丒七丌万丂业下::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
        }
        private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 136)
            {
                    return;
            }
            
            this.且丛一三业丈丝丞丅();
        }
        private void 且丛一三业丈丝丞丅()
        {
            string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  136);
            DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.世丂上丌丞且丁七丏 = val_3;
            if(val_3 != null)
            {
                    this.丛不丄与丅丘丙丁与();
                if(RecipeSystem.三专丒七丌万丂业下.与世专丁一丌丛丐专 == null)
            {
                    return;
            }
            
                RecipeSystem.三专丒七丌万丂业下.与世专丁一丌丛丐专.Invoke();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "[RecipeSystem] ---- _config == null");
        }
        private void 丛不丄与丅丘丙丁与()
        {
            this.上丅丗丒专且丏东万.Clear();
            if(this.世丂上丌丞且丁七丏 == null)
            {
                    return;
            }
            
            if(this.世丂上丌丞且丁七丏.RecipeSettings == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.世丂上丌丞且丁七丏.RecipeSettings.GetEnumerator();
            label_11:
            if(((-1283026264) & 1) == 0)
            {
                goto label_4;
            }
            
            if(((0 == 0) || (0 == 0)) || (0.Count == 0))
            {
                goto label_11;
            }
            
            this.上丅丗丒专且丏东万.set_Item(key:  X22.业东丅东丌上丗丑不(), value:  0.丐丏七丌丕丗业且上());
            goto label_11;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal bool 丘丛世专专丝丂丘丕(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与)
        {
            var val_6;
            PGCompany.三东丏不丗世丅丌丄 val_1 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
            if(val_1.丕丐一丙专丛丒丑万() != false)
            {
                    var val_5 = ((this.丝丛世丆上丛丐丞丐(丞世不丒下上上丝丑:  val_1.业东丅东丌上丗丑不())) != 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        internal bool 丘丛世专专丝丂丘丕(int 丞世不丒下上上丝丑)
        {
            return (bool)((this.丝丛世丆上丛丐丞丐(丞世不丒下上上丝丑:  丞世不丒下上上丝丑)) != 0) ? 1 : 0;
        }
        internal RecipeSystem.丝丏三三丕丁下丅丒 丝丛世丆上丛丐丞丐(int 丞世不丒下上上丝丑)
        {
            var val_3;
            if((this.上丅丗丒专且丏东万.ContainsKey(key:  丞世不丒下上上丝丑)) != false)
            {
                    RecipeSystem.丝丏三三丕丁下丅丒 val_2 = this.上丅丗丒专且丏东万.Item[丞世不丒下上上丝丑];
                return (RecipeSystem.丝丏三三丕丁下丅丒)val_3;
            }
            
            val_3 = 0;
            return (RecipeSystem.丝丏三三丕丁下丅丒)val_3;
        }
        public 三专丒七丌万丂业下()
        {
            this.上丅丗丒专且丏东万 = new System.Collections.Generic.Dictionary<System.Int32, RecipeSystem.丝丏三三丕丁下丅丒>();
        }
    
    }

}
