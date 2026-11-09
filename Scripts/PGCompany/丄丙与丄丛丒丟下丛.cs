using UnityEngine;

namespace PGCompany
{
    internal struct 丄丙与丄丛丒丟下丛 : IEquatable<PGCompany.丄丙与丄丛丒丟下丛>, IFormattable
    {
        // Fields
        private const string 丗丗丌丕业丏丗丞丄 = "{{\"credits\":{0}, \"totalCredits\":{1}, \"totalCreditsFlag\":{2}}}";
        private readonly int <丝专丑丛业专世丘丅>k__BackingField;
        private readonly int <三丄世丝丑丂丄与丟>k__BackingField;
        private readonly bool <且不三万丒东专丕下>k__BackingField;
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        internal int 世丏不丆世丐上与七 { get; }
        internal int 丟丈丁丁丁丏丝丂丂 { get; }
        internal bool 丛丞三下丘东万且三 { get; }
        
        // Methods
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal 丄丙与丄丛丒丟下丛(int 丈七丄丝七丗丌丏丗, int 丈丄丏一下专丐丘丘, bool 丂丗世丌业丄上丈三)
        {
            mem[1152921555872656592] = 丈七丄丝七丗丌丏丗;
            mem[1152921555872656596] = 丈丄丏一下专丐丘丘;
            mem[1152921555872656600] = 丂丗世丌业丄上丈三;
        }
        internal int 丕三不丄万下一丅丝()
        {
            return (int)this;
        }
        internal int 丁丌丐丛丛丟万丒专()
        {
            return (int)this;
        }
        internal bool 丘丒丅丄丌丅丈且丐()
        {
            return (bool)this;
        }
        internal static PGCompany.丄丙与丄丛丒丟下丛 且丘万丙丝丈丆专与(System.Collections.Generic.Dictionary<string, object> 万丝且丘不丑丝下丑)
        {
            int val_1 = 0;
            if(万丝且丘不丑丝下丑 != null)
            {
                    bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "credits", 丙业与丙丗丝不丈东: out  val_1);
                bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "totalCredits", 丙业与丙丗丝不丈东: out  val_1);
                bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Boolean>(丏丂万业丙专丏丒丒:  万丝且丘不丑丝下丑, 下上丐丆丝丟丝丒不:  "totalCreditsFlag", 丙业与丙丗丝不丈东: out  false);
                return new PGCompany.丄丙与丄丛丒丟下丛() {<且不三万丒东专丕下>k__BackingField = false};
            }
            
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "dictionary");
        }
        internal static bool 东一万丈丘业丂丂丑(string 丌丏不下一与丛丙丝, out PGCompany.丄丙与丄丛丒丟下丛 丙业与丙丗丝不丈东)
        {
            object val_1 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丏不下一与丛丙丝);
            丙业与丙丗丝不丈东.<且不三万丒东专丕下>k__BackingField = false;
            mem[1152921555873311513] = 0;
            丙业与丙丗丝不丈东.<丝专丑丛业专世丘丅>k__BackingField = 0;
            丙业与丙丗丝不丈东.<三丄世丝丑丂丄与丟>k__BackingField = 0;
            return false;
        }
        internal string 丆一丌东丞丆丟东丟()
        {
        
        }
        public bool Equals(PGCompany.丄丙与丄丛丒丟下丛 丘丛丏丘丝七世七丅)
        {
            if(W8 != (丘丛丏丘丝七世七丅.<丝专丑丛业专世丘丅>k__BackingField))
            {
                    return false;
            }
            
            if(W8 != ((丘丛丏丘丝七世七丅.<丝专丑丛业专世丘丅>k__BackingField) >> 32))
            {
                    return false;
            }
            
            var val_2 = (W8 != 0) ? 1 : 0;
            val_2 = (((丘丛丏丘丝七世七丅.<且不三万丒东专丕下>k__BackingField) != true) ? 1 : 0) ^ val_2;
            return (bool)val_2 ^ 1;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
            System.Globalization.CultureInfo val_1 = PGCompany.丄丙与丄丛丒丟下丛.丙专丝世不业下丂丈();
        }
        public string ToString(string 丆丗丘丕且丈丘丁不, System.IFormatProvider 世与丆丁下专丘丆丄)
        {
            return 106040886;
        }
        public static bool 丌且丕丐丛上丅且丁(PGCompany.丄丙与丄丛丒丟下丛 丈丂丕下丏丈丞丗业, PGCompany.丄丙与丄丛丒丟下丛 丂丌丌丛丆丆丙丌丈)
        {
            if((丈丂丕下丏丈丞丗业.<丝专丑丛业专世丘丅>k__BackingField) != (丂丌丌丛丆丆丙丌丈.<丝专丑丛业专世丘丅>k__BackingField))
            {
                    return false;
            }
            
            if(((丈丂丕下丏丈丞丗业.<丝专丑丛业专世丘丅>k__BackingField) >> 32) != ((丂丌丌丛丆丆丙丌丈.<丝专丑丛业专世丘丅>k__BackingField) >> 32))
            {
                    return false;
            }
            
            var val_3 = ((丈丂丕下丏丈丞丗业.<且不三万丒东专丕下>k__BackingField) != true) ? 1 : 0;
            val_3 = val_3 ^ (((丂丌丌丛丆丆丙丌丈.<且不三万丒东专丕下>k__BackingField) != true) ? 1 : 0);
            return (bool)val_3 ^ 1;
        }
        public static bool 万丌专丅丘丘丟万东(PGCompany.丄丙与丄丛丒丟下丛 丈丂丕下丏丈丞丗业, PGCompany.丄丙与丄丛丒丟下丛 丂丌丌丛丆丆丙丌丈)
        {
            if((丈丂丕下丏丈丞丗业.<丝专丑丛业专世丘丅>k__BackingField) != (丂丌丌丛丆丆丙丌丈.<丝专丑丛业专世丘丅>k__BackingField))
            {
                    return true;
            }
            
            if(((丈丂丕下丏丈丞丗业.<丝专丑丛业专世丘丅>k__BackingField) >> 32) != ((丂丌丌丛丆丆丙丌丈.<丝专丑丛业专世丘丅>k__BackingField) >> 32))
            {
                    return true;
            }
            
            return (bool)(((丈丂丕下丏丈丞丗业.<且不三万丒东专丕下>k__BackingField) != true) ? 1 : 0) ^ (((丂丌丌丛丆丆丙丌丈.<且不三万丒东专丕下>k__BackingField) != true) ? 1 : 0);
        }
    
    }

}
