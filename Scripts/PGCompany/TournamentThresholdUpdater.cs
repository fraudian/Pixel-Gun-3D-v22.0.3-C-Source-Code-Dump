using UnityEngine;

namespace PGCompany
{
    internal sealed class TournamentThresholdUpdater : MonoBehaviour
    {
        // Fields
        private bool 丅丈专三一丄丞丐丅;
        private UILabel[] _labels;
        private string _localizationKey;
        
        // Methods
        private void Start()
        {
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.TournamentThresholdUpdater::丙丁与丝东丞丐丐且()));
        }
        private void OnDestroy()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.TournamentThresholdUpdater::丙丁与丝东丞丐丐且()));
        }
        private void OnEnable()
        {
            this.丝丂世业与丙与专丁();
        }
        private void 丙丁与丝东丞丐丐且()
        {
            this.丅丈专三一丄丞丐丅 = false;
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.丝丂世业与丙与专丁();
        }
        private void 丝丂世业与丙与专丁()
        {
            var val_6;
            if(this.丅丈专三一丄丞丐丅 != false)
            {
                    return;
            }
            
            if(this._labels == null)
            {
                    return;
            }
            
            if(this._localizationKey == null)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_11;
            label_15:
            this._labels[0].text = System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._localizationKey), arg0:  RatingSystem.与一丅丝不丈业与丙().丄专上业下丛丛东丁());
            val_6 = 1;
            label_11:
            if(val_6 < this._labels.Length)
            {
                goto label_15;
            }
            
            this.丅丈专三一丄丞丐丅 = true;
        }
        public TournamentThresholdUpdater()
        {
        
        }
    
    }

}
