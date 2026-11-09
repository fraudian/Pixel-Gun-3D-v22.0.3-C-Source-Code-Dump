using UnityEngine;

namespace Rilisoft
{
    public class AchievementInfoView : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UILabel _labelDesc;
        private UISprite _spriteIcon;
        private Rilisoft.TextGroup _textName;
        private UITexture _textureAchievementsBg;
        
        // Methods
        private void OnEnable()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.AchievementInfoView::Hide()), 与且专丈不万东一万:  this.GetType());
        }
        private void OnDisable()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        public void Show(Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)
        {
            int val_29;
            var val_30;
            var val_31;
            var val_32;
            this.gameObject.SetActive(value:  true);
            UnityEngine.Texture val_2 = Rilisoft.AchievementView.丑一东丏专丙丟丌丝(世丞丞万丞丙一丟专:  世丞丞万丞丙一丟专);
            this._spriteIcon.spriteName = 世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丑一丆丑且丟上业丛();
            this._textName.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丄专丟不万丕丒丝丙());
            val_29 = System.String.alignConst;
            if(世丞丞万丞丙一丟专.不业丙丒丂丞下丆丙() != 1)
            {
                    if(世丞丞万丞丙一丟专.不业丙丒丂丞下丆丙() != 3)
            {
                goto label_16;
            }
            
            }
            
            if(世丞丞万丞丙一丟专 != null)
            {
                    val_30 = 世丞丞万丞丙一丟专.丙万丙丂一丝丁丂下();
                val_31 = 世丞丞万丞丙一丟专.丐万丐且丁东丈上丟();
                val_32 = 世丞丞万丞丙一丟专;
            }
            else
            {
                    val_30 = 0.丙万丙丂一丝丁丂下();
                val_31 = 0.丐万丐且丁东丈上丟();
                val_32 = 0;
            }
            
            int val_14 = val_32.且专丂丐丟一不丌丟();
            if(val_30 < val_31)
            {
                    string val_16 = System.String.Format(format:  "{0}/{1}", arg0:  val_14, arg1:  世丞丞万丞丙一丟专.万不东不上且东丑万());
            }
            
            val_29 = System.String.Format(format:  "[00ff00]{0}", arg0:  val_14);
            label_16:
            if((世丞丞万丞丙一丟专.不业丙丒丂丞下丆丙() == 3) && (世丞丞万丞丙一丟专.世丑丐丅丆丂丘不丁() != false))
            {
                    if(世丞丞万丞丙一丟专.丁专丗万三上丟三丆().丝且丘与丅专丈丛丘()[0] == 1)
            {
                    val_29 = System.String.alignConst;
            }
            
            }
            
            string val_24 = 世丞丞万丞丙一丟专.丁专丗万三上丟三丆().三业丕不丂不丟丕且();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_29)) != false)
            {
                    string val_25 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_24);
            }
            
            this._labelDesc.text = System.String.Format(format:  "{0}{1}{2}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_24), arg1:  System.Environment.NewLine, arg2:  val_29);
        }
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public AchievementInfoView()
        {
        
        }
    
    }

}
