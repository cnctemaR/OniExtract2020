using Klei.AI;

public class OutWiltConditions
{
    public float minRad = 0f;
    public float maxRad = float.NaN;

    public OutWiltConditions(WiltCondition wiltable, Modifiers componentMods)
    {
        this.minRad = componentMods.GetPreModifiedAttributeValue(Db.Get().PlantAttributes.MinRadiationThreshold);
        this.maxRad = componentMods.GetPreModifiedAttributeValue(Db.Get().PlantAttributes.MaxRadiationThreshold);
    }
}