﻿using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using static EdiblesManager;

public class ExportGeyser : BaseExport
{
    public override string ExportFileName { get; set; } = "geyser";
    public List<GeyserGenericConfig.GeyserPrefabParams> geysers;

    public ExportGeyser()
	{
        geysers = new List<GeyserGenericConfig.GeyserPrefabParams>();
    }

    public static void AddGeyserPrefabParams(ExportGeyser export, List<GeyserGenericConfig.GeyserPrefabParams> geysersParams)
    {
        geysersParams.ForEach(param => {
            export.geysers.Add(param);
        });
        export.ExportJsonFile();
    }
}