using UnityEngine;
[Serializable]
private class GeneratorIndications.GeneratorPoints
{
    // Fields
    public string point;
    public WorldPosIndicatonItem_Filling indicator;
    public FortDamageableGenerator currentActivateGenerate;
    public System.Collections.Generic.List<FortDamageableGenerator> listGenerators;
    
    // Methods
    public GeneratorIndications.GeneratorPoints()
    {
        this.listGenerators = new System.Collections.Generic.List<FortDamageableGenerator>();
    }

}
