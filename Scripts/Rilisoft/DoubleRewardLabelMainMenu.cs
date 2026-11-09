using UnityEngine;

namespace Rilisoft
{
    internal sealed class DoubleRewardLabelMainMenu : MonoBehaviour
    {
        // Fields
        private Rilisoft.TextGroup _doubleRewardLabel;
        private Rilisoft.NewDayWatcher 丅与七丟上丏丑丅丒;
        private UnityEngine.Coroutine 丐丘丌丁丐丐且专丈;
        
        // Properties
        private Rilisoft.NewDayWatcher 丈七业且丝丗丏丏丆 { get; }
        
        // Methods
        private Rilisoft.NewDayWatcher 万不业不丂丏三丕一()
        {
            Rilisoft.NewDayWatcher val_6;
            if(this.丅与七丟上丏丑丅丒 == 0)
            {
                    this.丅与七丟上丏丑丅丒 = this.gameObject.AddComponent<Rilisoft.NewDayWatcher>();
                return val_6;
            }
            
            val_6 = this.丅与七丟上丏丑丅丒;
            return val_6;
        }
        private void OnEnable()
        {
            this.丗与丄丑一丈丙不丛();
            if(this.万不业不丂丏三丕一() != 0)
            {
                    this.万不业不丂丏三丕一().下世丁东七丗万上丁(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.DoubleRewardLabelMainMenu::万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            }
            
            if(this.丐丘丌丁丐丐且专丈 != null)
            {
                    this.StopCoroutine(routine:  this.丐丘丌丁丐丐且专丈);
            }
            
            this.丐丘丌丁丐丐且专丈 = this.StartCoroutine(routine:  this.七丈丝丁丏丁丛丑丌());
        }
        private void OnDisable()
        {
            if(this.丐丘丌丁丐丐且专丈 != null)
            {
                    this.StopCoroutine(routine:  this.丐丘丌丁丐丐且专丈);
                this.丐丘丌丁丐丐且专丈 = 0;
            }
            
            if(this.万不业不丂丏三丕一() == 0)
            {
                    return;
            }
            
            this.万不业不丂丏三丕一().丈丂丏下丈专丛丝丞(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void Rilisoft.DoubleRewardLabelMainMenu::万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        private System.Collections.IEnumerator 七丈丝丁丏丁丛丑丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new DoubleRewardLabelMainMenu.丒丝丌丛业丌一上专();
        }
        private void 丗与丄丑一丈丙不丛()
        {
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            this.丗与丄丑一丈丙不丛(丑专丛丅丞下丄丈丞:  new System.Nullable<System.DateTime>() {HasValue = val_1.HasValue});
        }
        private void 丗与丄丑一丈丙不丛(System.Nullable<System.DateTime> 丑专丛丅丞下丄丈丞)
        {
            Rilisoft.TextGroup val_15;
            .丑专丛丅丞下丄丈丞 = 丑专丛丅丞下丄丈丞;
            mem[1152921542551817544] = X2;
            val_15 = this._doubleRewardLabel;
            if(val_15 == 0)
            {
                    return;
            }
            
            if((1152921542551817536 & 1) != 0)
            {
                    System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Boolean> val_3 = new System.Func<Rilisoft.七丕丟丏三丈一丄世, System.Boolean>(object:  new DoubleRewardLabelMainMenu.丌万一一业丝丁丈丝(), method:  System.Boolean DoubleRewardLabelMainMenu.丌万一一业丝丁丈丝::七下丂丄丁丆东丐丅(Rilisoft.七丕丟丏三丈一丄世 业七丐世专丝丂丟丈));
                this._doubleRewardLabel.gameObject.SetActive(value:  System.Linq.Enumerable.Any<Rilisoft.七丕丟丏三丈一丄世>(source:  Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().七不丈专丙世丅丕丝(), predicate:  null));
            }
            else
            {
                    this._doubleRewardLabel.gameObject.SetActive(value:  false);
            }
            
            val_15 = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3146"), arg0:  Rilisoft.丂丒三丙世丝三丏丞.丑七不且上丗丁一世().丞业不丅丑丙与不不());
            this._doubleRewardLabel.Text = val_15;
        }
        private void 万丂丁与丗丐丄七丛(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丗与丄丑一丈丙不丛();
        }
        public DoubleRewardLabelMainMenu()
        {
        
        }
    
    }

}
