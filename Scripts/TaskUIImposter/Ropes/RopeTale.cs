using UnityEngine;

namespace TaskUIImposter.Ropes
{
    public class RopeTale : UIDragDropItem
    {
        // Fields
        private static System.Action<TaskUIImposter.Ropes.RopeTale> 丛上专东万七丕丕丅;
        private static System.Action<TaskUIImposter.Ropes.RopeTale> 丒丒丞丌东丑且丆丕;
        private System.Collections.Generic.List<UIBasicSprite> _colorSprites;
        private string <丄丟丒丁丒不丗与不>k__BackingField;
        internal TaskUIImposter.Ropes.RopeSocket 与丅世丈丝丈丑丈与;
        private UnityEngine.Vector3 丐丝专丈世三丆丅丑;
        
        // Properties
        internal string SocketName { get; set; }
        
        // Methods
        internal static void 丆且丛下与丏万丐丅(System.Action<TaskUIImposter.Ropes.RopeTale> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  TaskUIImposter.Ropes.RopeTale.丛上专东万七丕丕丅, b:  丙业与丙丗丝不丈东);
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
        internal static void 丏丛丙业丙专丏丂丅(System.Action<TaskUIImposter.Ropes.RopeTale> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  TaskUIImposter.Ropes.RopeTale.丛上专东万七丕丕丅, value:  丙业与丙丗丝不丈东);
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
        internal static void 丏上丁东丅丁丐丈丒(System.Action<TaskUIImposter.Ropes.RopeTale> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕 != 1152921505349926920);
        
        }
        internal static void 一一丏上丙丆丐不丙(System.Action<TaskUIImposter.Ropes.RopeTale> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕 != 1152921505349926920);
        
        }
        internal string 丞丘丁不东上丁丕七()
        {
            return (string)this.<丄丟丒丁丒不丗与不>k__BackingField;
        }
        private void 丑丝丒丄七业丛丗东(string 丙业与丙丗丝不丈东)
        {
            this.<丄丟丒丁丒不丗与不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected override void Start()
        {
            this.Start();
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.丐丝专丈世三丆丅丑 = val_2;
            mem[1152921540892250636] = val_2.y;
            mem[1152921540892250640] = val_2.z;
        }
        internal void 丒丗丙丙丙丟专丅万(UnityEngine.Color 丑丞丈丗丄丙丟万丄)
        {
            List.Enumerator<T> val_1 = this._colorSprites.GetEnumerator();
            label_7:
            if((1925777272 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.color = new UnityEngine.Color() {r = 丑丞丈丗丄丙丟万丄.r, g = 丑丞丈丗丄丙丟万丄.g, b = 丑丞丈丗丄丙丟万丄.b, a = 丑丞丈丗丄丙丟万丄.a};
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.<丄丟丒丁丒不丗与不>k__BackingField = 丑丞丈丗丄丙丟万丄.r;
        }
        internal void 丝丈万一业丁三丙丛()
        {
            this.与丅世丈丝丈丑丈与 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.丐丝专丈世三丆丅丑, y = V8.16B, z = V9.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return;
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = this.丐丝专丈世三丆丅丑, y = V9.16B, z = this.丐丝专丈世三丆丅丑};
        }
        protected override void 且与下七下丗丁丂丞()
        {
            this.且与下七下丗丁丂丞();
            if(TaskUIImposter.Ropes.RopeTale.丛上专东万七丕丕丅 == null)
            {
                    return;
            }
            
            TaskUIImposter.Ropes.RopeTale.丛上专东万七丕丕丅.Invoke(obj:  this);
        }
        protected override void 丄丏丈业东万且丝万()
        {
            this.丄丏丈业东万且丝万();
            if(TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕 == null)
            {
                    return;
            }
            
            TaskUIImposter.Ropes.RopeTale.丒丒丞丌东丑且丆丕.Invoke(obj:  this);
        }
        public RopeTale()
        {
        
        }
    
    }

}
