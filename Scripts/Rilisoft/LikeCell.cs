using UnityEngine;

namespace Rilisoft
{
    public class LikeCell : MonoBehaviour
    {
        // Fields
        private System.Action<Rilisoft.LikeCell> 不丁丟且业丙不丞且;
        private UILabel _playerNameLabel;
        private Rilisoft.LobbyCraftLikeGui.丕丟丕丌丒丞世与丅 <丅不丙丌丟业一业丂>k__BackingField;
        
        // Properties
        public Rilisoft.LobbyCraftLikeGui.丕丟丕丌丒丞世与丅 丞丑且东丌与丏丏丁 { get; set; }
        
        // Methods
        public Rilisoft.LobbyCraftLikeGui.丕丟丕丌丒丞世与丅 get_Data()
        {
            return (丕丟丕丌丒丞世与丅)this.<丅不丙丌丟业一业丂>k__BackingField;
        }
        private void 丏丝丈丗丄丛丐万丆(Rilisoft.LobbyCraftLikeGui.丕丟丕丌丒丞世与丅 丙业与丙丗丝不丈东)
        {
            this.<丅不丙丌丟业一业丂>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.LobbyCraftLikeGui.丕丟丕丌丒丞世与丅 一丐丗丁丞丆丅丟丄, System.Action<Rilisoft.LikeCell> 三专丌一且丄且丅丘)
        {
            System.Action<Rilisoft.LikeCell> val_1;
            丕丟丕丌丒丞世与丅 val_2;
            UILabel val_3;
            val_1 = 三专丌一且丄且丅丘;
            val_2 = 一丐丗丁丞丆丅丟丄;
            this.<丅不丙丌丟业一业丂>k__BackingField = val_2;
            this.不丁丟且业丙不丞且 = val_1;
            if(val_2 == null)
            {
                goto label_1;
            }
            
            val_3 = this._playerNameLabel;
            goto label_2;
            label_1:
            UnityEngine.Debug.LogError(message:  "LikeCell setup error: data is null");
            val_3 = this;
            val_1 = mem[一丐丗丁丞丆丅丟丄 + 32];
            val_1 = 一丐丗丁丞丆丅丟丄.业业丁丕丒且万丕上;
            this._playerNameLabel.text = val_1;
            val_2 = this.<丅不丙丌丟业一业丂>k__BackingField;
            if(val_2 == null)
            {
                goto label_7;
            }
            
            label_2:
            null.text = this.<丅不丙丌丟业一业丂>k__BackingField.业业丁丕丒且万丕上;
            return;
            label_7:
        }
        public void U_Click()
        {
            if(this.不丁丟且业丙不丞且 == null)
            {
                    return;
            }
            
            this.不丁丟且业丙不丞且.Invoke(obj:  this);
        }
        public LikeCell()
        {
        
        }
    
    }

}
