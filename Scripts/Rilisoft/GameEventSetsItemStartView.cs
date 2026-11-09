using UnityEngine;

namespace Rilisoft
{
    internal class GameEventSetsItemStartView : GameEventSetItemView
    {
        // Fields
        private UILabel _lapLabel;
        
        // Properties
        public override Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 上丅丑丌丑丏丏丙东 { get; set; }
        public override bool 丐丞三丑不丝且丞丐 { get; set; }
        
        // Methods
        public override Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 get_CurrentState()
        {
            return (且世丈业丘丆不上丄)this;
        }
        public override void set_CurrentState(Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丙业与丙丗丝不丈东)
        {
            this.CurrentState = 丙业与丙丗丝不丈东;
            this.世一业丆一三丕一业();
        }
        public override bool get_LastDropped()
        {
            return this.LastDropped;
        }
        public override void set_LastDropped(bool 丙业与丙丗丝不丈东)
        {
            this.LastDropped = 丙业与丙丗丝不丈东;
            this.世一业丆一三丕一业();
        }
        public override void Setup(Rilisoft.GameEventItem 与且专丈不万东一万, int 丆且丁丒丒丆丁三丆, Rilisoft.GameEventSetItemView.且世丈业丘丆不上丄 丟丆七丅丘丒丒丘丈)
        {
            this.Setup(与且专丈不万东一万:  与且专丈不万东一万, 丆且丁丒丒丆丁三丆:  丆且丁丒丒丆丁三丆, 丟丆七丅丘丒丒丘丈:  丟丆七丅丘丒丒丘丈);
            this.世一业丆一三丕一业();
        }
        private void 世一业丆一三丕一业()
        {
            if(this._lapLabel == 0)
            {
                    return;
            }
            
            if(this.LastDropped != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._lapLabel, 丏业丟一东丂东丘丛:  false);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._lapLabel, 丏业丟一东丂东丘丛:  true);
            Rilisoft.上专业三丟丁丞专下 val_5 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context.且丌三丙丙与与丝世();
            if(val_5 == null)
            {
                    return;
            }
            
            this = this._lapLabel;
            this.text = val_5.专且丌丁丙丂上丘丄() + 1.ToString();
        }
        public GameEventSetsItemStartView()
        {
        
        }
    
    }

}
