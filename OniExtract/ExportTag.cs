using OniExtract2;
using System;
using System.Collections.Generic;

public class ExportTag : BaseExport
{
    public override string ExportFileName { get; set; } = "tags";
    public Dictionary<string, int> SimHashes = new Dictionary<string, int>();
    public List<Tag> RoomConstraintTags = RoomConstraints.ConstraintTags.AllTags;

    public ExportTag()
    {
        foreach (var name in Enum.GetNames(typeof(SimHashes)))
        {
            this.SimHashes[name] = (int)Enum.Parse(typeof(SimHashes), name);
        }
    }
}
