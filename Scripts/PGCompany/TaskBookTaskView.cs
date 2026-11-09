using UnityEngine;

namespace PGCompany
{
    internal class TaskBookTaskView : MonoBehaviour
    {
        // Fields
        private PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙;
        private UnityEngine.Coroutine 专业七三一丘丁丁丞;
        private PGCompany.NewTaskInTaskbookGuiNotification _notification;
        private PGCompany.GameTaskView _gameTaskView;
        private UISprite _mainSprite;
        private UnityEngine.GameObject _transitionContainer;
        private UnityEngine.GameObject _doTaskButton;
        private UnityEngine.GameObject _notCompleteButton;
        private TweenAlpha _tweenAlpha;
        
        // Properties
        internal PGCompany.GameTaskView 丐万丘丁上业丟丏万 { get; }
        
        // Methods
        internal void 业不丝丄丙丌丌丈丄(PGCompany.世丐下丕专东丘丏且 万不且且丛丆东丒业)
        {
            this.与世七丑丂专专丌丙 = 万不且且丛丆东丒业;
            this._gameTaskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  万不且且丛丆东丒业, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            if(this._notification == null)
            {
                    return;
            }
            
            this._notification.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  this.与世七丑丂专专丌丙);
        }
        internal void 丝一丅丆三东丂丞七()
        {
            if(this.与世七丑丂专专丌丙 == null)
            {
                    return;
            }
            
            this._gameTaskView.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._transitionContainer, 丏业丟一东丂东丘丛:  (~this.与世七丑丂专专丌丙.丞专丅丁丁三丄上专()) & 1);
            PGCompany.丕万丅丗丏三丙丈丁 val_5 = Rilisoft.Singleton<PGCompany.TaskBookController>.Instance.丕不丝东一且与东丂(上万丒丐万世业不丌:  this.与世七丑丂专专丌丙.丅丙丛丑丌丆丌丕丒());
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._doTaskButton, 丏业丟一东丂东丘丛:  (val_5 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notCompleteButton, 丏业丟一东丂东丘丛:  (val_5 == 0) ? 1 : 0);
            this._mainSprite.alpha = 1f;
        }
        public void U_Move()
        {
            this.下丏且一三丐一丐不();
        }
        public void U_GiveReward()
        {
            if(this.专业七三一丘丁丁丞 != null)
            {
                    return;
            }
            
            this._gameTaskView.U_GiveReward();
            UniversalRewardController.与三丆丏丌三丈七丂(且丒丛与丞世丙丕丌:  4, 丌世丕丗不丘世丞专:  1, 一七丁不丝丈丕丑丒:  0);
        }
        private System.Collections.IEnumerator 不丌专丐世丄丛一万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new TaskBookTaskView.丌世与上上世丙与七();
        }
        private void 下丏且一三丐一丐不()
        {
            null = null;
            if(GiftBannerWindow.丘丆且七丑丘且专丟 != false)
            {
                    return;
            }
            
            if(this.与世七丑丂专专丌丙 == null)
            {
                    return;
            }
            
            if((Rilisoft.Singleton<PGCompany.TaskBookController>.Instance.丕不丝东一且与东丂(上万丒丐万世业不丌:  this.与世七丑丂专专丌丙.丅丙丛丑丌丆丌丕丒())) == null)
            {
                    return;
            }
            
            if(PGCompany.TaskBookMainUI.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        internal PGCompany.GameTaskView 东丑丘丅世丘东丞丙()
        {
            return (PGCompany.GameTaskView)this._gameTaskView;
        }
        public TaskBookTaskView()
        {
        
        }
    
    }

}
