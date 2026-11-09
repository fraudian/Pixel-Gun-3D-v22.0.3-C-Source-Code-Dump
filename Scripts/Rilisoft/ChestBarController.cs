using UnityEngine;

namespace Rilisoft
{
    public class ChestBarController : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<ClanChestView> _chestViews;
        private System.Collections.Generic.List<UnityEngine.Transform> _3dChestsPlacePoints;
        private UnityEngine.AudioClip _openChestSound;
        private 丂丁丏与丈丈东下万 丟丏丛丂丅东丂丘且;
        private System.Collections.Generic.List<UnityEngine.Animator> 东丘丂世丛东丌丂丛;
        
        // Methods
        private void Awake()
        {
            ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ChestBarController::专七丗一且一丞世专()));
        }
        private void OnEnable()
        {
            ClansController.丕业七东万丝三丌下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ChestBarController::丄不丏七三丆万专丕()));
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丘丗丈丛下一且世丐());
        }
        private void 专七丗一且一丞世专()
        {
            this.丟丏丛丂丅东丂丘且 = 0;
        }
        private void OnDisable()
        {
            this.万不丒上丕丗丂丘丒();
        }
        private void 丄不丏七三丆万专丕()
        {
            this.丕丕业七丙七丅丈丄();
        }
        private void 丄不丏七三丆万专丕(int 丁下丁世东世丂丘且)
        {
            this.丕丕业七丙七丅丈丄();
        }
        private void OnDestroy()
        {
            this.万不丒上丕丗丂丘丒();
            ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ChestBarController::专七丗一且一丞世专()));
        }
        private void 万不丒上丕丗丂丘丒()
        {
            ClansController.专一业与世不世丄专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ChestBarController::丄不丏七三丆万专丕()));
        }
        private System.Collections.IEnumerator 丘丗丈丛下一且世丐()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ChestBarController.与丄丐与上丝丘且不();
        }
        private void 丕丕业七丙七丅丈丄()
        {
            goto label_1;
            label_5:
            this._chestViews.Item[0].Setup(丐下丝丘丑丟丟丗丌:  0);
            0 = 1;
            label_1:
            if(0 < this._chestViews.Count)
            {
                goto label_5;
            }
        
        }
        public ChestBarController()
        {
            this.东丘丂世丛东丌丂丛 = new System.Collections.Generic.List<UnityEngine.Animator>();
        }
    
    }

}
