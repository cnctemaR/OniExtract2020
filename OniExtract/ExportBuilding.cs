﻿using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class ExportBuilding : BaseExport
{
    public override string ExportFileName { get; set; } = "building";
    public List<BuildingDef> buildingDefs;
    public List<BBuildingDef> bBuildingDefList;
    public List<PlanScreen.PlanInfo> PlanOrder = TUNING.BUILDINGS.PLANORDER;

    public ExportBuilding()
	{
        buildingDefs = new List<BuildingDef>();
        bBuildingDefList = new List<BBuildingDef>();
    }

    public void AddNewBBuildingDef(BuildingDef buildingDef)
    {
        GameObject go = buildingDef.BuildingComplete;
        BBuildingDef bBuild = new BBuildingDef(buildingDef.Tag.Name);
        EnergyGenerator energyGenerator = go.GetComponent<EnergyGenerator>();
        if (energyGenerator != null)
        {
            bBuild.energyGenerator = new OutEnergyGenerator(energyGenerator);
        }
        else
        {
            bBuild.energyGenerator = null;
        }
        ConduitConsumer conduitConsumer = go.GetComponent<ConduitConsumer>();
        if (conduitConsumer != null)
        {
            bBuild.conduitConsumer = new OutConduitConsumer(conduitConsumer);
        }
        else
        {
            bBuild.conduitConsumer = null;
        }
        ConduitDispenser conduitDispenser = go.GetComponent<ConduitDispenser>();
        if (conduitDispenser != null)
        {
            bBuild.conduitDispenser = new OutConduitDispenser(conduitDispenser);
        }
        else
        {
            bBuild.conduitDispenser = null;
        }
        ElementConverter[] elementConverters = go.GetComponents<ElementConverter>();
        if (elementConverters != null && elementConverters.Length > 0)
        {
            foreach (var elementConverter in elementConverters)
            {
                bBuild.elementConverters.Add(new OutElementConverter(elementConverter));
            }
        }
        PlantablePlot plantablePlot = go.GetComponent<PlantablePlot>();
        if (plantablePlot != null)
        {
            bBuild.plantablePlot = new OutPlantablePlot(plantablePlot);
        }
        else
        {
            bBuild.plantablePlot = null;
        }
        ElementConsumer[] elementConsumers = go.GetComponents<ElementConsumer>();
        if (elementConsumers != null && elementConsumers.Length > 0)
        {
            foreach (var elementConsumer in elementConsumers)
            {
                bBuild.elementConsumers.Add(new OutElementConsumer(elementConsumer));
            }
        }
        PassiveElementConsumer[] passiveElementConsumers = go.GetComponents<PassiveElementConsumer>();
        if (passiveElementConsumers != null && passiveElementConsumers.Length > 0)
        {
            foreach (var passiveElementConsumer in passiveElementConsumers)
            {
                bBuild.passiveElementConsumers.Add(new OutPassiveElementConsumer(passiveElementConsumer));
            }
        }
        Storage storage = go.GetComponent<Storage>();
        if (storage != null)
        {
            bBuild.storage = new OutStorage(storage);
        }       

        this.bBuildingDefList.Add(bBuild);
    }
}
