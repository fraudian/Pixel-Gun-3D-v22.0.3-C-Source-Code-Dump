using UnityEngine;

namespace Rilisoft
{
    internal class 不丙世丁丐七三丁丌
    {
        // Fields
        private float[] 与丁七丞七丛万丙业;
        private byte[] 丆不丗三丄丕丛丈丏;
        
        // Properties
        internal float 丙业与丙丗丝不丈东 { get; set; }
        
        // Methods
        internal float 丝丙丐且丟丅三丛七()
        {
            System.Buffer.BlockCopy(src:  this.丆不丗三丄丕丛丈丏, srcOffset:  0, dst:  this.与丁七丞七丛万丙业, dstOffset:  0, count:  this.与丁七丞七丛万丙业.Length);
            return (float)this.与丁七丞七丛万丙业[0];
        }
        internal void 与万万丆丆三不上世(float 丙业与丙丗丝不丈东)
        {
            this.与丁七丞七丛万丙业[0] = 丙业与丙丗丝不丈东;
            System.Buffer.BlockCopy(src:  this.与丁七丞七丛万丙业, srcOffset:  0, dst:  this.丆不丗三丄丕丛丈丏, dstOffset:  0, count:  this.丆不丗三丄丕丛丈丏.Length);
        }
        internal 不丙世丁丐七三丁丌()
        {
        
        }
        internal 不丙世丁丐七三丁丌(float 丘丆丗丕丙且不一丟)
        {
            this.与丁七丞七丛万丙业 = new float[1];
            this.丆不丗三丄丕丛丈丏 = new byte[4];
            this.与万万丆丆三不上世(丙业与丙丗丝不丈东:  丘丆丗丕丙且不一丟);
        }
    
    }

}
