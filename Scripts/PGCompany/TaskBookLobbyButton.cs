using UnityEngine;

namespace PGCompany
{
    internal class TaskBookLobbyButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.BoxCollider _boxCollider;
        private UISprite _mainSprite;
        private UILabel _titleLabel;
        private UILabel levelRequiredLabel;
        
        // Methods
        private void Awake()
        {
            Rilisoft.Nest.丈世与丛丆丌且丛且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TaskBookLobbyButton::丕七丞丞丂专丛且专()));
            this._boxCollider = this.GetComponent<UnityEngine.BoxCollider>();
        }
        private void 丕七丞丞丂专丛且专()
        {
            this.丅且丂且丘与丅一丅();
        }
        private void OnDestroy()
        {
            Rilisoft.Nest.丒一丈上东丟不丕与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.TaskBookLobbyButton::丕七丞丞丂专丛且专()));
        }
        private void OnEnable()
        {
            this.丅且丂且丘与丅一丅();
        }
        private void 丅且丂且丘与丅一丅()
        {
            var val_10;
            bool val_11;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            UILabel val_24;
            var val_25;
            if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.taskbook")) != false)
            {
                    val_10 = (PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丂世三丅一万东三三(不七丆万丁一丞七下:  164)) ^ 1;
            }
            else
            {
                    val_10 = 0;
            }
            
            val_11 = val_10 & 1;
            this._boxCollider.enabled = val_11;
            if((val_11 & 1) != 0)
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.white;
                val_16 = val_4.r;
                val_17 = val_4.g;
                val_18 = val_4.b;
                val_19 = val_4.a;
            }
            else
            {
                    val_16 = 0f;
                val_17 = 0f;
                val_18 = 0f;
                val_19 = 0f;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._mainSprite, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_16, g = val_17, b = val_18, a = val_19});
            if((val_10 & 1) != 0)
            {
                    UnityEngine.Color val_5 = UnityEngine.Color.white;
                val_20 = val_5.r;
                val_21 = val_5.g;
                val_22 = val_5.b;
                val_23 = val_5.a;
            }
            else
            {
                    val_20 = 0f;
                val_21 = 0f;
                val_22 = 0f;
                val_23 = 0f;
            }
            
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this._titleLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_20, g = val_21, b = val_22, a = val_23});
            if((val_10 & 1) != 0)
            {
                    val_24 = this.levelRequiredLabel;
                val_25 = 0;
            }
            else
            {
                    val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  丐丄丞世丂丄丛不一.丒与丆三丟三丈丄丄(丆万一不丌且东丐丐:  "feature.taskbook"));
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.levelRequiredLabel, 丕丗丘丑丛与丑业丒:  val_11);
                val_24 = this.levelRequiredLabel;
                val_25 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  true);
        }
        public TaskBookLobbyButton()
        {
        
        }
    
    }

}
