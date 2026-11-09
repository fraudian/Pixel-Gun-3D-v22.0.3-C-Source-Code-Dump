using UnityEngine;

namespace PGCompany.GameplayLoop
{
    internal abstract class 业丒丅丂丗丁业上且
    {
        // Fields
        private PGCompany.GameplayLoop.GameplayLoopType <且丈丁专东丆丄丂与>k__BackingField;
        private System.Collections.Generic.HashSet<string> <万丞丛丙不上丂三丕>k__BackingField;
        
        // Properties
        internal PGCompany.GameplayLoop.GameplayLoopType 丒三丝一上丙专丗丒 { get; set; }
        internal System.Collections.Generic.HashSet<string> 且上丐下丛三丄专三 { get; set; }
        
        // Methods
        internal PGCompany.GameplayLoop.GameplayLoopType 不业丙丒丂丞下丆丙()
        {
            return (PGCompany.GameplayLoop.GameplayLoopType)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        private void 东丝丕专丒丏三三与(PGCompany.GameplayLoop.GameplayLoopType 丙业与丙丗丝不丈东)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.HashSet<string> 丄且且丆丏丘东与世()
        {
            return (System.Collections.Generic.HashSet<System.String>)this.<万丞丛丙不上丂三丕>k__BackingField;
        }
        private void 丁丈丒丁丛丝丈丐丅(System.Collections.Generic.HashSet<string> 丙业与丙丗丝不丈东)
        {
            this.<万丞丛丙不上丂三丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 业丒丅丂丗丁业上且()
        {
            this.<万丞丛丙不上丂三丕>k__BackingField = new System.Collections.Generic.HashSet<System.String>();
        }
        internal virtual bool 且下丑丂丂丌丘丛丘(string 下丅丙一丂丗丅丝七)
        {
            if((this.<万丞丛丙不上丂三丕>k__BackingField) != null)
            {
                    return this.<万丞丛丙不上丂三丕>k__BackingField.Contains(item:  下丅丙一丂丗丅丝七);
            }
            
            return this.<万丞丛丙不上丂三丕>k__BackingField.Contains(item:  下丅丙一丂丗丅丝七);
        }
        internal void 东丕丂东且丂下与丏(System.Collections.Generic.HashSet<string> 丏上业丞上丈丄丈不)
        {
            var val_3 = this;
            this.<万丞丛丙不上丂三丕>k__BackingField.Clear();
            HashSet.Enumerator<T> val_1 = 丏上业丞上丈丄丈不.GetEnumerator();
            label_4:
            if(((-275351704) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            goto label_4;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        protected virtual void 丁上丟上不丘七不万(string 下丅丙一丂丗丅丝七)
        {
            bool val_1 = this.<万丞丛丙不上丂三丕>k__BackingField.Add(item:  下丅丙一丂丗丅丝七);
        }
        internal abstract bool 丑丏丙丑且丞丈丝业(bool 丘丄一丘丁丞丘丆且); // 0
        internal abstract bool 万丑万上丕丆不丒七(string 下丅丙一丂丗丅丝七, bool 丘丄一丘丁丞丘丆且); // 0
        internal string 丅丆丁世丏万与下丏()
        {
            return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}_{1}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField, arg1:  this);
        }
        internal string 与不丕丏丐丂丕上丆()
        {
            return this.丅丆丁世丏万与下丏() + "_shop";
        }
        internal string 丐丆丅丝七世一丛且()
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this)) == false)
            {
                    return "Textures/GameLoop_Textures/"("Textures/GameLoop_Textures/") + this.与不丕丏丐丂丕上丆().ToLowerInvariant();
            }
            
            return (string)System.String.alignConst;
        }
        internal string 丒丂丑丞丟丟万丆丙()
        {
            string val_5;
            int val_6;
            val_5 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this)) != false)
            {
                    val_6 = System.String.alignConst;
                return (string)"Textures/GameLoop_Textures/"("Textures/GameLoop_Textures/") + this.<且丈丁专东丆丄丂与>k__BackingField.ToString().ToLowerInvariant()(this.<且丈丁专东丆丄丂与>k__BackingField.ToString().ToLowerInvariant()) + "_default";
            }
            
            val_5 = this.<且丈丁专东丆丄丂与>k__BackingField;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (string)"Textures/GameLoop_Textures/"("Textures/GameLoop_Textures/") + this.<且丈丁专东丆丄丂与>k__BackingField.ToString().ToLowerInvariant()(this.<且丈丁专东丆丄丂与>k__BackingField.ToString().ToLowerInvariant()) + "_default";
        }
        internal virtual string 丒丅三丕丙丏丌丕不()
        {
            return (string)System.String.alignConst;
        }
        protected void 丛丟丌丛上丟世上世(PGCompany.GameplayLoop.GameplayLoopType 丁丅丈丌丟世丗丗丟)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丁丅丈丌丟世丗丗丟;
        }
        internal string 丗万丐业不丑丛丝丝(string 丞一丁业丄一一业且, bool 丑丗丕丈丒不丙专丐)
        {
            return (string)专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {_ticks = this}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
        internal virtual System.TimeSpan 丅世不下丑且丏丙一(string 丞一丁业丄一一业且)
        {
            return System.TimeSpan.FromSeconds(value:  0);
        }
    
    }

}
