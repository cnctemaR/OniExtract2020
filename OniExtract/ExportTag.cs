using OniExtract2;
using OniExtract2.model;
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ExportTag : BaseExport
{
    public override string ExportFileName { get; set; } = "tags";
    public Dictionary<string, int> SimHashes = new Dictionary<string, int>();
    public List<Tag> RoomConstraintTags = RoomConstraints.ConstraintTags.AllTags;
    public OutGameTags mGameTags = new OutGameTags();
    public Dictionary<string, List<string>> prefabIDs = new Dictionary<string, List<string>>();
    public Dictionary<string, BUISprite> uiSpriteInfos = new Dictionary<string, BUISprite>();

    public class OutGameTags
    {
        public Dictionary<string, Tag> tags = new Dictionary<string, Tag>();
        public Dictionary<string, List<Tag>> tagLists = new Dictionary<string, List<Tag>>();
        public Dictionary<string, TagSet> tagSets = new Dictionary<string, TagSet>();
        public List<string> tagNotOutput = new List<string>();
    }

    public ExportTag()
    {
        foreach (var name in Enum.GetNames(typeof(SimHashes)))
        {
            this.SimHashes[name] = (int)Enum.Parse(typeof(SimHashes), name);
        }
    }

    public void AddAllGameTags()
    {
        Type type = typeof(GameTags);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);

        foreach (var field in fields)
        {
            if (field.FieldType == typeof(Tag))
            {
                mGameTags.tags.Add(field.Name, (Tag)field.GetValue(null));
            }
            else if (field.FieldType == typeof(List<Tag>))
            {
                mGameTags.tagLists.Add(field.Name,(List<Tag>)field.GetValue(null));
            }
            else if (field.FieldType == typeof(TagSet))
            {
                mGameTags.tagSets.Add(field.Name, (TagSet)field.GetValue(null));
            }
            else
            {
                mGameTags.tagNotOutput.Add(field.Name);
            }
        }
        foreach (var prefab in Assets.Prefabs)
        {
            List<string> tags = new List<string>();
            foreach(var tag in prefab.Tags)
            {
                tags.Add(tag.Name);
            }
            var name = prefab.PrefabTag.Name;
            if (name != null)
            {
                this.prefabIDs[name] = tags;
            }
        }
    }
    public void AddAllTextureInfo()
    {
        foreach (var prefab in Assets.Prefabs)
        {
            if (prefab == null || prefab.PrefabTag == null)
            {
                continue;
            }
            Tuple<Sprite, Color> tupleUISprite = null;
            try
            {
                tupleUISprite = Def.GetUISprite(prefab.PrefabTag);
            }catch (Exception e)
            {
                Debug.LogError("OniExtract: read "+prefab.PrefabTag.Name+" Failed.");
            }
            string name = prefab.PrefabTag.Name;
            if (tupleUISprite != null && name != null)
            {
                uiSpriteInfos[prefab.PrefabTag.Name] = new BUISprite(tupleUISprite.first, tupleUISprite.second);
            }
        }
    }
}
