using UnityEngine;
public class NurseryTrainingController : MonoBehaviour
{
    // Fields
    internal static string 业丝不丞丅东专丕七;
    internal static string 东世下世丅丂丕丟丈;
    private UnityEngine.GameObject choosePet;
    private UnityEngine.GameObject getPet;
    private UnityEngine.GameObject hatchEgg;
    private UnityEngine.GameObject speedUpEgg;
    private UnityEngine.GameObject startHatchEgg;
    private UnityEngine.GameObject trainingFinish;
    
    // Properties
    internal static string 丆丘丛东丝七丕丗丅 { get; set; }
    internal static NurseryTrainingController.世上丐丘东丌且丒三 且丙万下丝丘丆丑不 { get; set; }
    
    // Methods
    internal static string 丛丂七三丞三丟丐东()
    {
        null = null;
        return UnityEngine.PlayerPrefs.GetString(key:  NurseryTrainingController.东世下世丅丂丕丟丈, defaultValue:  "");
    }
    internal static void 万丙上业丞东业丐丆(string 丙业与丙丗丝不丈东)
    {
        null = null;
        UnityEngine.PlayerPrefs.SetString(key:  NurseryTrainingController.东世下世丅丂丕丟丈, value:  丙业与丙丗丝不丈东);
        UnityEngine.PlayerPrefs.Save();
    }
    internal static NurseryTrainingController.世上丐丘东丌且丒三 丁丏丒专一丄丏丙七()
    {
        null = null;
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  NurseryTrainingController.业丝不丞丅东专丕七, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    internal static void 丑丄丆丗专丁丛三专(NurseryTrainingController.世上丐丘东丌且丒三 丙业与丙丗丝不丈东)
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  NurseryTrainingController.业丝不丞丅东专丕七, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void UpdateTrainingStep(NurseryTrainingController.世上丐丘东丌且丒三 丒且丆丘丞丑业丅不)
    {
        NurseryTrainingController.丑丄丆丗专丁丛三专(丙业与丙丗丝不丈东:  丒且丆丘丞丑业丅不);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startHatchEgg, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.speedUpEgg, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.choosePet, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getPet, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trainingFinish, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hatchEgg, 丏业丟一东丂东丘丛:  false);
        if((丒且丆丘丞丑业丅不 - 1) <= 6)
        {
                var val_23 = 106017016 + ((丒且丆丘丞丑业丅不 - 1)) << 2;
            val_23 = val_23 + 106017016;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "NureseryTraining this step does not exist");
        }
    
    }
    private void 丌与丄丅丝丄丑丏丕()
    {
    
    }
    public void HideHint()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.startHatchEgg, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.speedUpEgg, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.choosePet, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.getPet, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.trainingFinish, 丏业丟一东丂东丘丛:  false);
    }
    public NurseryTrainingController()
    {
    
    }
    private static NurseryTrainingController()
    {
        NurseryTrainingController.业丝不丞丅东专丕七 = "nursery_tutorial_state_passed_VER_14_1_0";
        NurseryTrainingController.东世下世丅丂丕丟丈 = "nursery_TARININGPET_VER_14_1_0";
    }

}
