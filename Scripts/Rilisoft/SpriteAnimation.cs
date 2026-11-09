using UnityEngine;

namespace Rilisoft
{
    internal sealed class SpriteAnimation : UISpriteAnimation
    {
        // Properties
        public bool 丑业丌丁世丘丁丞丟 { get; set; }
        
        // Methods
        public bool get_SnapPixels()
        {
            return (bool)this;
        }
        public void set_SnapPixels(bool 丙业与丙丗丝不丈东)
        {
            mem[1152921543555117833] = 丙业与丙丗丝不丈东;
        }
        protected override void Update()
        {
            var val_18;
            string val_19;
            val_18 = this;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.isPlaying == false)
            {
                    return;
            }
            
            if(this.frames < 2)
            {
                    return;
            }
            
            if(this.framesPerSecond < 1)
            {
                    return;
            }
            
            int val_6 = this.framesPerSecond;
            float val_18 = (float)val_6;
            val_18 = UnityEngine.Time.realtimeSinceStartup * val_18;
            int val_19 = UnityEngine.Mathf.FloorToInt(f:  val_18);
            int val_8 = this.frames;
            val_19 = val_19 - ((val_19 / val_8) * val_8);
            mem[1152921543555233948] = val_19;
            val_19 = X22.Item[val_19];
            val_6.spriteName = val_19;
            if((public System.String System.Collections.Generic.List<System.String>::get_Item(int index)) == 0)
            {
                    return;
            }
            
            val_18 = ???;
            val_19 = ???;
            goto typeof(Rilisoft.SpriteAnimation).__il2cppRuntimeField_358;
        }
        public SpriteAnimation()
        {
        
        }
    
    }

}
