using UnityEngine;

namespace Rilisoft.TimeManagment
{
    public class 丝丞丒丆三业丈丏丟 : IDisposable
    {
        // Fields
        protected float 丏丄丁丄与业丘丏与;
        protected string 丏世丑万世一七丟丞;
        protected long 丌与丞丘且丏丈丞丆;
        protected float 且丟丄丆丟丅上东丞;
        protected float 丗且一丅丏一万万上;
        public System.Action<int> 专一且世世世丏上东;
        private bool <业丐丞丘丒东丑丐丏>k__BackingField;
        private static System.Collections.Generic.Dictionary<string, Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟> 丗且丂丐丞丗丟丅丄;
        
        // Properties
        public bool 丐丕三不丆丁上丄三 { get; set; }
        public string 下丄丈不与世丐业专 { get; }
        public float 丛七世丙丙与不丄丗 { get; set; }
        public float 丌与丁不下丅丆丘丞 { get; }
        public float 与世丏丞丐不丗丝业 { get; set; }
        public float 丝丂丕丑上专七业丘 { get; }
        public float 丑三且不丙不丅丂丂 { get; }
        public virtual System.Nullable<long> 丏一丛丗丝丘丆丌专 { get; }
        
        // Methods
        public 丝丞丒丆三业丈丏丟(string 丞丅上丏丂且下丅与, float 与丈业丛丝丒丙一丏, float 丟七丒丟一上丏世丄 = 1)
        {
            var val_4;
            var val_5;
            this.丗且一丅丏一万万上 = 1f;
            val_4 = null;
            val_4 = null;
            if((Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.ContainsKey(key:  丞丅上丏丂且下丅与)) != true)
            {
                    val_5 = null;
                val_5 = null;
                Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.Add(key:  丞丅上丏丂且下丅与, value:  this);
                this.丏世丑万世一七丟丞 = 丞丅上丏丂且下丅与;
                this.丏丄丁丄与业丘丏与 = 与丈业丛丝丒丙一丏;
                this.且丟丄丆丟丅上东丞 = 与丈业丛丝丒丙一丏;
                this.丗且一丅丏一万万上 = 丟七丒丟一上丏世丄;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  System.String.Format(format:  "timer with id \'{0}\' allready exists", arg0:  丞丅上丏丂且下丅与));
        }
        public bool 不丆丑与七下一丛丅()
        {
            return (bool)this.<业丐丞丘丒东丑丐丏>k__BackingField;
        }
        protected void 丌下丛丒三丛丝与一(bool 丙业与丙丗丝不丈东)
        {
            this.<业丐丞丘丒东丑丐丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string 业上丙丞丐丄丆丅七()
        {
            return (string)this;
        }
        public float 丌丛丟丙丘丝丂一不()
        {
            return (float)this.丏丄丁丄与业丘丏与;
        }
        public void 丈丟丛七丂一丐一下(float 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 < 0f)
            {
                    return;
            }
            
            this.丏丄丁丄与业丘丏与 = 丙业与丙丗丝不丈东;
        }
        public float 丙世丑丅丒丑业与不()
        {
            return (float)this.且丟丄丆丟丅上东丞;
        }
        public float 丂丏丟丑丌下丈万万()
        {
            return (float)this.丗且一丅丏一万万上;
        }
        public void 丄丛丂丈业下且丌丕(float 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 < 0f)
            {
                    return;
            }
            
            this.丗且一丅丏一万万上 = 丙业与丙丗丝不丈东;
        }
        public float 丄下不一专丑丄丄三()
        {
            float val_1 = this.且丟丄丆丟丅上东丞;
            val_1 = val_1 / this.丗且一丅丏一万万上;
            return (float)val_1;
        }
        public float 丐且与丝世专丙下丝()
        {
            float val_1 = this.且丟丄丆丟丅上东丞;
            float val_2 = this.丗且一丅丏一万万上;
            val_1 = val_1 / val_2;
            val_2 = this.丏丄丁丄与业丘丏与 * val_2;
            val_1 = val_2 - val_1;
            return (float)val_1;
        }
        public virtual System.Nullable<long> 丅丘七世上丘且丗不()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_1.dateData}, d2:  new System.DateTime());
            double val_3 = val_2._ticks.TotalSeconds;
            return 0;
        }
        public virtual void Dispose()
        {
            null = null;
            bool val_1 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.Remove(key:  this.丏世丑万世一七丟丞);
            CoroutineRunner.东丁丗三丌丆丝丘丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟::专丞丛丘丞丅且丒丐()));
        }
        public virtual void 三丑丛丄万丟丄丞丁()
        {
            CoroutineRunner.东丁丗三丌丆丝丘丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟::专丞丛丘丞丅且丒丐()));
            CoroutineRunner.丈与丅丆丘丟丆丆丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟::专丞丛丘丞丅且丒丐()));
            this.<业丐丞丘丒东丑丐丏>k__BackingField = true;
        }
        public virtual void 丌丄丏下七丁专丂世()
        {
            this.<业丐丞丘丒东丑丐丏>k__BackingField = false;
        }
        public virtual void 世丆不专丆世丗丗丝()
        {
            goto typeof(Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟).__il2cppRuntimeField_198;
        }
        public virtual void 且七丙丄丘一丄上不()
        {
            if(( & 1) != 0)
            {
                    this.且丟丄丆丟丅上东丞 = this.丏丄丁丄与业丘丏与;
                this.丌与丞丘且丏丈丞丆 = ;
                return;
            }
            
            System.Exception val_1 = new System.Exception(message:  "CurrentTime has not value");
        }
        private void 专丞丛丘丞丅且丒丐()
        {
            if((this.<业丐丞丘丒东丑丐丏>k__BackingField) == false)
            {
                    return;
            }
            
            if(( & 1) == 0)
            {
                    return;
            }
            
            if(this.丌与丞丘且丏丈丞丆 > 0)
            {
                    return;
            }
            
            if(( & 1) != 0)
            {
                    this.丌与丞丘且丏丈丞丆 = ;
                if( >= 1)
            {
                    return;
            }
            
                return;
            }
            
            this.丌与丞丘且丏丈丞丆 = 0;
        }
        protected virtual void 丛丙世丞丌丄业丙丅()
        {
            long val_1 = this.丌与丞丘且丏丈丞丆;
            float val_2 = this.丗且一丅丏一万万上;
            val_1 =  - val_1;
            val_2 = val_2 * (float)val_1;
            val_2 = this.且丟丄丆丟丅上东丞 - val_2;
            this.且丟丄丆丟丅上东丞 = val_2;
            this.丌与丞丘且丏丈丞丆 = ;
            if(this.且丟丄丆丟丅上东丞 > 0f)
            {
                    return;
            }
            
            this.且丟丄丆丟丅上东丞 = this.丏丄丁丄与业丘丏与;
            if(this.专一且世世世丏上东 == null)
            {
                    return;
            }
            
            this.专一且世世世丏上东.Invoke(obj:  1);
        }
        internal static bool 丒且万与一丌丆且丙(string 丞丅上丏丂且下丅与)
        {
            null = null;
            if(Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄 != null)
            {
                    return Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.ContainsKey(key:  丞丅上丏丂且下丅与);
            }
            
            return Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.ContainsKey(key:  丞丅上丏丂且下丅与);
        }
        internal static T 下丗丆世丙丛丐丒七<T>(string 丞丅上丏丂且下丅与)
        {
            var val_4;
            var val_5;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟> val_6;
            var val_7;
            var val_8;
            val_4 = __RuntimeMethodHiddenParam;
            val_5 = null;
            val_5 = null;
            val_6 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄;
            if((val_6.ContainsKey(key:  丞丅上丏丂且下丅与)) != false)
            {
                    val_7 = null;
                val_7 = null;
                val_6 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.Item[丞丅上丏丂且下丅与];
                val_4 = mem[__RuntimeMethodHiddenParam + 48];
                val_4 = __RuntimeMethodHiddenParam + 48;
                if(val_6 != null)
            {
                    val_8 = val_6;
                if(val_8 != null)
            {
                    return (Rilisoft.TimeManagment.专一丈七丏丟丑丗丞)val_8;
            }
            
            }
            
            }
            
            val_8 = 0;
            return (Rilisoft.TimeManagment.专一丈七丏丟丑丗丞)val_8;
        }
        internal static void 三丈世丘东丏不上丆(string 丞丅上丏丂且下丅与)
        {
            var val_4;
            var val_5;
            val_4 = null;
            val_4 = null;
            if((Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.ContainsKey(key:  丞丅上丏丂且下丅与)) == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟 val_2 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.Item[丞丅上丏丂且下丅与];
            bool val_3 = Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄.Remove(key:  丞丅上丏丂且下丅与);
        }
        private static 丝丞丒丆三业丈丏丟()
        {
            Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟.丗且丂丐丞丗丟丅丄 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.TimeManagment.丝丞丒丆三业丈丏丟>();
        }
    
    }

}
