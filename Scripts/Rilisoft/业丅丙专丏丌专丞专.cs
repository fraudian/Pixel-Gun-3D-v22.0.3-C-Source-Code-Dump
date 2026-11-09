using UnityEngine;

namespace Rilisoft
{
    internal sealed class 业丅丙专丏丌专丞专 : 丙丐丐丙丈业丒不丁
    {
        // Fields
        private readonly string 万七丟丗且丆丈丙与;
        
        // Methods
        public 业丅丙专丏丌专丞专(string 专丛专丆三丏丟丆世)
        {
            this = new Rilisoft.丆专且丆世丟丄与丂();
            if(专丛专丆三丏丟丆世 != null)
            {
                    this.万七丟丗且丆丈丙与 = 专丛专丆三丏丟丆世;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "syncableStringName");
        }
        protected override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁)
        {
            AGSSyncableString val_1 = 丟丝上三丙丁丁世丁.GetLatestString(name:  this.万七丟丗且丆丈丙与);
            mem[1152921542494993264] = val_1.GetValue();
            mem[1152921542494993272] = 1;
            if(val_1 == null)
            {
                    return System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            return System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
        }
        protected override void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄)
        {
            var val_9;
            var val_10;
            val_9 = 丟丝上三丙丁丁世丁;
            val_10 = this;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            val_9 = val_9.GetLatestString(name:  this.万七丟丗且丆丈丙与);
            val_9.Set(val:  一丐丗丁丞丆丅丟丄);
            val_10 = 0;
            if(val_9 != null)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_9.Dispose();
            }
            
            if(val_10 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_9 = ???;
            val_10 = ???;
        }
        public override string ToString()
        {
            return System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0}(`{1}`)", arg0:  this.GetType(), arg1:  this.万七丟丗且丆丈丙与);
        }
    
    }

}
