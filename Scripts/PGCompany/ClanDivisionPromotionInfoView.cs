using UnityEngine;

namespace PGCompany
{
    public class ClanDivisionPromotionInfoView : PGBehaviour
    {
        // Fields
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Methods
        private void OnEnable()
        {
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanDivisionPromotionInfoView::Hide()), 与且专丈不万东一万:  System.String.Format(format:  "ClanDivisionPromotionInfoView_{0}", arg0:  this.gameObject.name));
        }
        private void OnDisable()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        public void GoToClanWar()
        {
            this.Hide();
        }
        public void Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        public ClanDivisionPromotionInfoView()
        {
        
        }
    
    }

}
