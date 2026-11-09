using UnityEngine;

namespace Rilisoft
{
    internal class 丒且丐三丁丅丕一业
    {
        // Fields
        private static float[] 上丆丝上一丁丙丏七;
        private int 丌下丕不且世丟丒上;
        private float 下专丑丛丗丝丙专七;
        private float 丅业丟丒一丝丑丕丄;
        
        // Properties
        internal float 丙业与丙丗丝不丈东 { get; set; }
        
        // Methods
        internal float 丝丙丐且丟丅三丛七()
        {
            null = null;
            System.Single[] val_1 = Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七 + ((this.丌下丕不且世丟丒上) << 2);
            float val_3 = (Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七 + (this.丌下丕不且世丟丒上) << 2) + 32;
            val_3 = this.丅业丟丒一丝丑丕丄 + val_3;
            float val_2 = this.下专丑丛丗丝丙专七 - val_3;
            val_2 = (val_2 > 0f) ? (val_2) : (-val_2);
            if(val_2 <= 0.1f)
            {
                    return val_3;
            }
            
            this.下专丑丛丗丝丙专七 = val_3;
            return val_3;
        }
        internal void 与万万丆丆三不上世(float 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            int val_1 = this.丌下丕不且世丟丒上 + 1;
            this.丌下丕不且世丟丒上 = val_1;
            val_3 = null;
            val_3 = null;
            if(val_1 >= Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七.Length)
            {
                    this.丌下丕不且世丟丒上 = 0;
            }
            
            this.下专丑丛丗丝丙专七 = 丙业与丙丗丝不丈东;
            val_4 = null;
            val_4 = null;
            System.Single[] val_2 = Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七 + ((this.丌下丕不且世丟丒上) << 2);
            float val_3 = (Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七 + (this.丌下丕不且世丟丒上) << 2) + 32;
            val_3 = 丙业与丙丗丝不丈东 - val_3;
            this.丅业丟丒一丝丑丕丄 = val_3;
        }
        internal 丒且丐三丁丅丕一业()
        {
            this.与万万丆丆三不上世(丙业与丙丗丝不丈东:  0f);
        }
        internal 丒且丐三丁丅丕一业(float 下与且且丞丒丝专丌)
        {
            this.与万万丆丆三不上世(丙业与丙丗丝不丈东:  下与且且丞丒丝专丌);
        }
        private float 丏三丒丙丌一丒东丑(float 丙业与丙丗丝不丈东)
        {
            丙业与丙丗丝不丈东 = (丙业与丙丗丝不丈东 > 0f) ? 丙业与丙丗丝不丈东 : (-丙业与丙丗丝不丈东);
            return (float)丙业与丙丗丝不丈东;
        }
        private static 丒且丐三丁丅丕一业()
        {
            Rilisoft.丒且丐三丁丅丕一业.上丆丝上一丁丙丏七 = new float[10] {-6.411664E-30f, 9.63834E-39f, 4.798182E+07f, -5.2191E-17f, 1.170772E+11f, -3.661831E-23f, -5.540144E+14f, 0.03387857f, 0.03385282f, -1.803582E+08f};
        }
    
    }

}
