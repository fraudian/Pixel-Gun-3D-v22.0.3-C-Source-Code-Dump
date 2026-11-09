using UnityEngine;

namespace Rilisoft
{
    internal struct 丂上丐丄丛一一丒七
    {
        // Fields
        private int 丏丆丑丗七丄丙丝与;
        private int 丒丈丙丐丏丕丆万丗;
        private int 丄专万丄丌世丁丕专;
        private int 丗上丈丁丙丛丆丝丆;
        private readonly int 丑丒丄下丁丐专丄丞;
        private static int[] 丑丁丗业业下丝丏丛;
        
        // Properties
        internal decimal 不丑一丙东丙丆丁七 { get; set; }
        
        // Methods
        public static Rilisoft.丂上丐丄丛一一丒七 万丒丌丕万丏不丈世(decimal 丐丆丂丒丁万丈丛丅)
        {
            val_0.丏丆丑丗七丄丙丝与 = 0;
            val_0.丒丈丙丐丏丕丆万丗 = 0;
            val_0.丄专万丄丌世丁丕专 = 0;
            val_0.丗上丈丁丙丛丆丝丆 = 0;
            val_0.丑丒丄下丁丐专丄丞 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
        }
        internal decimal 世三丞丅丑丌丈丈一()
        {
        
        }
        internal void 丙丏不三丗三丙丈与(decimal 丙业与丙丗丝不丈东)
        {
        
        }
        internal 丂上丐丄丛一一丒七(int 与丏七丞三与丐丆业, decimal 丝丂丘丄丅且三丌三)
        {
            this.丑丒丄下丁丐专丄丞 = 0;
            mem[1152921543530601252] = 0;
            mem[1152921543530601264] = 与丏七丞三与丐丆业;
            mem[1152921543530601256] = 0;
        }
        private void 丈三丗丕丁丏一丄丟(decimal 丙业与丙丗丝不丈东)
        {
        
        }
        internal static Rilisoft.丂上丐丄丛一一丒七 东丝七业丄丑丒世七(decimal 丙业与丙丗丝不丈东)
        {
            int val_6;
            Rilisoft.丂上丐丄丛一一丒七 val_0;
            val_0.丏丆丑丗七丄丙丝与 = 0;
            val_0.丒丈丙丐丏丕丆万丗 = 0;
            val_0.丄专万丄丌世丁丕专 = 0;
            val_0.丗上丈丁丙丛丆丝丆 = 0;
            val_0.丑丒丄下丁丐专丄丞 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            System.Int32[] val_2 = System.Decimal.GetBits(d:  new System.Decimal() {flags = 丙业与丙丗丝不丈东.flags, hi = 丙业与丙丗丝不丈东.hi, lo = 丙业与丙丗丝不丈东.lo, mid = 丙业与丙丗丝不丈东.mid});
            int val_7 = val_2[0];
            val_6 = val_0.丑丒丄下丁丐专丄丞;
            val_7 = val_6 ^ val_7;
            val_0.丏丆丑丗七丄丙丝与 = val_7;
            if(val_2.Length <= 1)
            {
                    val_6 = val_0.丑丒丄下丁丐专丄丞;
            }
            
            int val_8 = val_2[0];
            val_8 = val_6 ^ val_8;
            val_0.丒丈丙丐丏丕丆万丗 = val_8;
            if(val_2.Length <= 2)
            {
                    val_6 = val_0.丑丒丄下丁丐专丄丞;
            }
            
            int val_9 = val_2[1];
            val_9 = val_6 ^ val_9;
            val_0.丄专万丄丌世丁丕专 = val_9;
            if(val_2.Length <= 3)
            {
                    val_6 = val_0.丑丒丄下丁丐专丄丞;
            }
            
            val_6 = val_6 ^ val_2[1];
            val_0.丗上丈丁丙丛丆丝丆 = val_6;
            return val_0;
        }
        public override string ToString()
        {
            return (string)this.丑丒丄下丁丐专丄丞.ToString();
        }
        private static 丂上丐丄丛一一丒七()
        {
            Rilisoft.丂上丐丄丛一一丒七.丑丁丗业业下丝丏丛 = new int[4];
        }
    
    }

}
