using UnityEngine;

namespace PGCompany
{
    internal class 上与上一万丌丆丝世 : 丝丆丌丏丆丆丗丙三
    {
        // Fields
        protected string 丌丄丟丂丆丑下丐世;
        protected UnityEngine.Transform 丕专上丁丅丅丏万丌;
        protected System.Func<UnityEngine.Transform> 丑七丐丛东业丛万一;
        protected string 丐三专三丟丞丟丙上;
        private int 丙丒且业下丛丙上丆;
        private string 丈一丂丗丐丄丘丗丏;
        protected System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> 且万丛与丏三七丐七;
        
        // Methods
        public 上与上一万丌丆丝世(string 丝三丗万丞丁丄丌一, string 丛丄业丕且丗下一万)
        {
            this.且万丛与丏三七丐七 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.丌丄丟丂丆丑下丐世 = 丛丄业丕且丗下一万;
        }
        public 上与上一万丌丆丝世(UnityEngine.Transform 丈东丘丏与丌东东下, string 丝三丗万丞丁丄丌一, string 丛丄业丕且丗下一万)
        {
            this.且万丛与丏三七丐七 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.丌丄丟丂丆丑下丐世 = 丛丄业丕且丗下一万;
            this.丕专上丁丅丅丏万丌 = 丈东丘丏与丌东东下;
        }
        public 上与上一万丌丆丝世(System.Func<UnityEngine.Transform> 业丆丒丟与且丙与三, string 丝三丗万丞丁丄丌一, string 丛丄业丕且丗下一万)
        {
            this.且万丛与丏三七丐七 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.丌丄丟丂丆丑下丐世 = 丛丄业丕且丗下一万;
            this.丑七丐丛东业丛万一 = 业丆丒丟与且丙与三;
        }
        public 上与上一万丌丆丝世(string 丛三丒丛丑东下丅万, string 丝三丗万丞丁丄丌一, string 丛丄业丕且丗下一万)
        {
            this.且万丛与丏三七丐七 = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
            this.丌丄丟丂丆丑下丐世 = 丛丄业丕且丗下一万;
            this.丐三专三丟丞丟丙上 = 丛三丒丛丑东下丅万;
        }
        internal void 丐丙丒丆丗万世丛万(string 万丄丐丙丆丝与丄丕, int 与业丄丂丂丆下上丞)
        {
            this.丙丒且业下丛丙上丆 = 与业丄丂丂丆下上丞;
            this.丈一丂丗丐丄丘丗丏 = 万丄丐丙丆丝与丄丕;
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            UnityEngine.Object val_21;
            string val_22;
            System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject> val_23;
            int val_2 = 丛丑业万丗丝丒三丗.gameObject.GetInstanceID();
            if((this.且万丛与丏三七丐七.ContainsKey(key:  val_2)) != true)
            {
                    UnityEngine.GameObject val_4 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  this.丌丄丟丂丆丑下丐世);
                if(val_4 != 0)
            {
                    if(this.丑七丐丛东业丛万一 != null)
            {
                    val_21 = this.丑七丐丛东业丛万一.Invoke();
            }
            else
            {
                    val_21 = 0;
            }
            
                if(val_21 == 0)
            {
                    val_21 = this.丕专上丁丅丅丏万丌;
            }
            
                if(val_21 == 0)
            {
                    val_22 = this.丐三专三丟丞丟丙上;
                if(val_22 == null)
            {
                    val_22 = System.String.alignConst;
            }
            
                TagSystem.CompoundTagBehaviour val_11 = System.Linq.Enumerable.FirstOrDefault<TagSystem.CompoundTagBehaviour>(source:  TagSystem.丐丝丙不丛丞丏丌丏.丑七不且上丗丁一世().不丄丑东丈丅上丌业(丆万一不丌且东丐丐:  val_22));
                if(val_11 != null)
            {
                    val_21 = val_11.丌丟丄业且三丛丕丄();
            }
            else
            {
                    val_21 = 0;
            }
            
            }
            
                if(val_21 == 0)
            {
                    val_21 = 丛丑业万丗丝丒三丗.transform;
            }
            
                UnityEngine.GameObject val_15 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_4, 丈东丘丏与丌东东下:  val_21, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
                if(val_15 != 0)
            {
                    this.且万丛与丏三七丐七.set_Item(key:  val_2, value:  val_15);
            }
            
            }
            
            }
            
            val_23 = this.且万丛与丏三七丐七;
            if((val_23.ContainsKey(key:  val_2)) == false)
            {
                    return;
            }
            
            if(((System.String.IsNullOrEmpty(value:  this.丈一丂丗丐丄丘丗丏)) != true) && (this.丙丒且业下丛丙上丆 >= 1))
            {
                    val_23 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  this.丈一丂丗丐丄丘丗丏, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
                if(val_23 >= this.丙丒且业下丛丙上丆)
            {
                    return;
            }
            
                val_21 = 1;
            }
            else
            {
                    val_23 = 0;
                val_21 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.且万丛与丏三七丐七.Item[val_2], 丏业丟一东丂东丘丛:  true);
            if(val_21 == 0)
            {
                    return;
            }
            
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  this.丈一丂丗丐丄丘丗丏, 下下丏一丙不丘丌丞:  val_23 + 1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if(丛丑业万丗丝丒三丗 == 0)
            {
                    return;
            }
            
            int val_3 = 丛丑业万丗丝丒三丗.gameObject.GetInstanceID();
            if((this.且万丛与丏三七丐七.ContainsKey(key:  val_3)) == false)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.且万丛与丏三七丐七.Item[val_3], 丏业丟一东丂东丘丛:  false);
        }
    
    }

}
