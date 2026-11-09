using UnityEngine;

namespace Rilisoft
{
    public class AchievementsGUIController : MonoBehaviour
    {
        // Fields
        private UIGrid _grid;
        private Rilisoft.AchievementInfoView _infoView;
        private UIScrollView _scrollView;
        private Rilisoft.AchievementView _viewPrefab;
        private System.Collections.Generic.List<Rilisoft.AchievementView> _views;
        
        // Methods
        private void Awake()
        {
            Rilisoft.AchievementsManager.丅丈丂东上不丛下丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.AchievementsGUIController::东丌丝丑三业丗三且()));
            Rilisoft.AchievementsManager.丆丘丞丏丈上丏丗丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.AchievementsGUIController::东丌丝丑三业丗三且()));
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丛三丟不丙且丅丛丅());
            Rilisoft.AchievementView.万万且丞与万业丈丌(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.AchievementView>(object:  this, method:  System.Void Rilisoft.AchievementsGUIController::万丑丙丂丈三一丂专(Rilisoft.AchievementView 万且万且丑丗且丌丆)));
        }
        private void 东丌丝丑三业丗三且()
        {
            List.Enumerator<T> val_1 = this._views.GetEnumerator();
            label_6:
            if(((-1058307576) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._views.Clear();
            UnityEngine.Coroutine val_6 = CoroutineRunner.Instance.StartCoroutine(routine:  this.丛三丟不丙且丅丛丅());
        }
        private System.Collections.IEnumerator 丛三丟不丙且丅丛丅()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AchievementsGUIController.丞万丅丏丟与丝丄丌();
        }
        private Rilisoft.AchievementView 专丄丞丈世一丒丅东(Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)
        {
            Rilisoft.AchievementView val_1 = UnityEngine.Object.Instantiate<Rilisoft.AchievementView>(original:  this._viewPrefab);
            val_1.Achievement = 世丞丞万丞丙一丟专;
            this._views.Add(item:  val_1);
            UnityEngine.Transform val_3 = val_1.gameObject.transform;
            val_3.SetParent(p:  this._grid.gameObject.transform);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_3.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_3.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            return val_1;
        }
        private void 丅丛三丛丂丑丑丐七(int 下业丕七东丌丝下且, Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)
        {
            this.专丄丞丈世一丒丅东(世丞丞万丞丙一丟专:  世丞丞万丞丙一丟专).gameObject.transform.SetSiblingIndex(index:  下业丕七东丌丝下且);
            if(this._grid == null)
            {
                
            }
        
        }
        private void 七且丌专丒上丛丄丕(int 下业丕七东丌丝下且, Rilisoft.丞专七丛丛丌世丈丕 世丞丞万丞丙一丟专)
        {
            .世丞丞万丞丙一丟专 = 世丞丞万丞丙一丟专;
            Rilisoft.AchievementView val_3 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.AchievementView>(source:  this._views, predicate:  new System.Func<Rilisoft.AchievementView, System.Boolean>(object:  new AchievementsGUIController.下丌丛三下专丘丐丕(), method:  System.Boolean AchievementsGUIController.下丌丛三下专丘丐丕::丈丆丗丙下丒丌世丕(Rilisoft.AchievementView 业下丌下三丕丙丌下)));
            if(val_3 == 0)
            {
                    return;
            }
            
            bool val_5 = this._views.Remove(item:  val_3);
            val_3.gameObject.transform.SetParent(p:  this.gameObject.transform);
            val_3.gameObject.SetActive(value:  false);
            UnityEngine.Object.Destroy(obj:  val_3);
        }
        private void 万丑丙丂丈三一丂专(Rilisoft.AchievementView 万且万且丑丗且丌丆)
        {
            this._infoView.Show(世丞丞万丞丙一丟专:  万且万且丑丗且丌丆.专丅丐万下上不丛丐);
        }
        private void OnDestroy()
        {
            Rilisoft.AchievementView.丂东东丌世与与上丛(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.AchievementView>(object:  this, method:  System.Void Rilisoft.AchievementsGUIController::万丑丙丂丈三一丂专(Rilisoft.AchievementView 万且万且丑丗且丌丆)));
        }
        public AchievementsGUIController()
        {
            this._views = new System.Collections.Generic.List<Rilisoft.AchievementView>();
        }
    
    }

}
