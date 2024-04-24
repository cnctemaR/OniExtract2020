using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using static EdiblesManager;
using static STRINGS.BUILDING.STATUSITEMS;
using Database;
using Klei.AI;

public class ExportDb : BaseExport
{
    public override string ExportFileName { get; set; } = "db";
    public List<Disease> dieases;
    public List<Sickness> sicknesses;
    public List<Urge> urges;
    public List<AssignableSlot> assignableSlots;
    public List<StateMachine.Category> stateMachineCategories;
    public List<Personality> personalities;
    public List<Face> faces;
    public List<Shirt> shirts;
    public List<Expression> expressions;
    public List<Emote> minionEmotes;
    public List<Emote> critterEmotes;
    public List<Thought> thoughts;
    public List<Dream> dreams;
    public List<StatusItem> buildingStatusItems;
    public List<StatusItem> miscStatusItems;
    public List<StatusItem> creatureStatusItems;
    public List<StatusItem> robotStatusItems;
    public List<StatusItemCategory> statusItemCategories;
    public List<Death> deaths;
    //public List<ChoreType> choreTypes;
    //public List<OutTechItem> techItems;
    public List<AccessorySlot> accessorySlots;
    public List<Accessory> accessories;
    //public List<ScheduleBlockType> scheduleBlockTypes;
    //public List<ScheduleGroup> scheduleGroups;
    public List<RoomTypeCategory> roomTypeCategories;
    public List<RoomType> roomTypes;
    public List<ArtifactDropRate> artifactDropRates;
    public List<SpaceDestinationType> spaceDestinationTypes;
    public List<SkillPerk> skillPerks;
    public List<SkillGroup> skillGroups;
    public List<Skill> skills;
    public List<ColonyAchievement> colonyAchievements;
    public List<Quest> quests;
    public List<GameplayEvent> gameplayEvents;
    public List<GameplaySeason> gameplaySeasons;
    public List<PlantMutation> plantMutations;
    //public List<Spice> spices;
    public List<OutTech> techs;
    public List<TechTreeTitle> techTreeTitles;
    public List<OrbitalData> orbitalTypeCategories;
    public List<PermitResource> permitResources;
    public List<ArtableStatusItem> artableStatuses;
    public List<Story> stories;

    public ExportDb()
    {
        this.dieases = new List<Disease>();
        this.sicknesses = new List<Sickness>();
        this.urges = new List<Urge>();
        this.assignableSlots = new List<AssignableSlot>();
        this.stateMachineCategories = new List<StateMachine.Category>();
        this.personalities = new List<Personality>();
        this.faces = new List<Face>();
        this.shirts = new List<Shirt>();
        this.expressions = new List<Expression>();
        this.minionEmotes = new List<Emote>();
        this.critterEmotes = new List<Emote>();
        this.thoughts = new List<Thought>();
        this.dreams = new List<Dream>();
        this.buildingStatusItems = new List<StatusItem>();
        this.miscStatusItems = new List<StatusItem>();
        this.creatureStatusItems = new List<StatusItem>();
        this.robotStatusItems = new List<StatusItem>();
        this.statusItemCategories = new List<StatusItemCategory>();
        this.deaths = new List<Death>();
        //this.choreTypes = new List<ChoreType>();
        //this.techItems = new List<OutTechItem>();
        this.accessorySlots = new List<AccessorySlot>();
        this.accessories = new List<Accessory>();
        //this.scheduleBlockTypes = new List<ScheduleBlockType>();
        //this.scheduleGroups = new List<ScheduleGroup>();
        this.roomTypeCategories = new List<RoomTypeCategory>();
        this.roomTypes = new List<RoomType>();
        this.artifactDropRates = new List<ArtifactDropRate>();
        this.spaceDestinationTypes = new List<SpaceDestinationType>();
        this.skillPerks = new List<SkillPerk>();
        this.skillGroups = new List<SkillGroup>();
        this.skills = new List<Skill>();
        this.colonyAchievements = new List<ColonyAchievement>();
        this.quests = new List<Quest>();
        this.gameplayEvents = new List<GameplayEvent>();
        this.gameplaySeasons = new List<GameplaySeason>();
        this.plantMutations = new List<PlantMutation>();
        //this.spices = new List<Spice>();
        this.techs = new List<OutTech>();
        this.techTreeTitles = new List<TechTreeTitle>();
        this.orbitalTypeCategories = new List<OrbitalData>();
        this.permitResources = new List<PermitResource>();
        this.artableStatuses = new List<ArtableStatusItem>();
        this.stories = new List<Story>();
    }

    public void AddDbResources()
    {
        foreach (var resource in Db.Get().Diseases.resources)
        {
            this.dieases.Add(resource);
        }
        foreach (var resource in Db.Get().Sicknesses.resources)
        {
            this.sicknesses.Add(resource);
        }
        foreach (var resource in Db.Get().Urges.resources)
        {
            this.urges.Add(resource);
        }
        foreach (var resource in Db.Get().AssignableSlots.resources)
        {
            this.assignableSlots.Add(resource);
        }
        foreach (var resource in Db.Get().StateMachineCategories.resources)
        {
            this.stateMachineCategories.Add(resource);
        }
        foreach (var resource in Db.Get().Personalities.resources)
        {
            this.personalities.Add(resource);
        }
        foreach (var resource in Db.Get().Faces.resources)
        {
            this.faces.Add(resource);
        }
        foreach (var resource in Db.Get().Shirts.resources)
        {
            this.shirts.Add(resource);
        }
        foreach (var resource in Db.Get().Expressions.resources)
        {
            this.expressions.Add(resource);
        }
        foreach (var resource in Db.Get().Emotes.Minion.resources)
        {
            this.minionEmotes.Add(resource);
        }
        foreach (var resource in Db.Get().Emotes.Critter.resources)
        {
            this.critterEmotes.Add(resource);
        }
        foreach (var resource in Db.Get().Thoughts.resources)
        {
            this.thoughts.Add(resource);
        }
        foreach (var resource in Db.Get().Dreams.resources)
        {
            this.dreams.Add(resource);
        }
        foreach (var resource in Db.Get().BuildingStatusItems.resources)
        {
            this.buildingStatusItems.Add(resource);
        }
        foreach (var resource in Db.Get().MiscStatusItems.resources)
        {
            this.miscStatusItems.Add(resource);
        }
        foreach (var resource in Db.Get().CreatureStatusItems.resources)
        {
            this.creatureStatusItems.Add(resource);
        }
        foreach (var resource in Db.Get().RobotStatusItems.resources)
        {
            this.robotStatusItems.Add(resource);
        }
        foreach (var resource in Db.Get().StatusItemCategories.resources)
        {
            this.statusItemCategories.Add(resource);
        }
        foreach (var resource in Db.Get().Deaths.resources)
        {
            this.deaths.Add(resource);
        }
        //foreach (var resource in Db.Get().ChoreTypes.resources)
        //{
        //    this.choreTypes.Add(resource);
        //}
        //foreach (var resource in Db.Get().TechItems.resources)
        //{
        //    this.techItems.Add(resource);
        //}
        foreach (var resource in Db.Get().AccessorySlots.resources)
        {
            this.accessorySlots.Add(resource);
        }
        foreach (var resource in Db.Get().Accessories.resources)
        {
            this.accessories.Add(resource);
        }
        //foreach (var resource in Db.Get().ScheduleBlockTypes.resources)
        //{
        //    this.scheduleBlockTypes.Add(resource);
        //}
        //foreach (var resource in Db.Get().ScheduleGroups.resources)
        //{
        //    this.scheduleGroups.Add(resource);
        //}
        foreach (var resource in Db.Get().RoomTypeCategories.resources)
        {
            this.roomTypeCategories.Add(resource);
        }
        foreach (var resource in Db.Get().RoomTypes.resources)
        {
            this.roomTypes.Add(resource);
        }
        foreach (var resource in Db.Get().ArtifactDropRates.resources)
        {
            this.artifactDropRates.Add(resource);
        }
        foreach (var resource in Db.Get().SpaceDestinationTypes.resources)
        {
            this.spaceDestinationTypes.Add(resource);
        }
        foreach (var resource in Db.Get().SkillPerks.resources)
        {
            this.skillPerks.Add(resource);
        }
        foreach (var resource in Db.Get().SkillGroups.resources)
        {
            this.skillGroups.Add(resource);
        }
        foreach (var resource in Db.Get().Skills.resources)
        {
            this.skills.Add(resource);
        }
        foreach (var resource in Db.Get().ColonyAchievements.resources)
        {
            this.colonyAchievements.Add(resource);
        }
        foreach (var resource in Db.Get().Quests.resources)
        {
            this.quests.Add(resource);
        }
        foreach (var resource in Db.Get().GameplayEvents.resources)
        {
            this.gameplayEvents.Add(resource);
        }
        foreach (var resource in Db.Get().GameplaySeasons.resources)
        {
            this.gameplaySeasons.Add(resource);
        }
        foreach (var resource in Db.Get().PlantMutations.resources)
        {
            this.plantMutations.Add(resource);
        }
        //foreach (var resource in Db.Get().Spices.resources)
        //{
        //    this.spices.Add(resource);
        //}
        foreach (var resource in Db.Get().Techs.resources)
        {
            this.techs.Add(new OutTech(resource));
        }
        foreach (var resource in Db.Get().TechTreeTitles.resources)
        {
            this.techTreeTitles.Add(resource);
        }
        foreach (var resource in Db.Get().OrbitalTypeCategories.resources)
        {
            this.orbitalTypeCategories.Add(resource);
        }
        foreach (var resource in Db.Get().Permits.resources)
        {
            this.permitResources.Add(resource);
        }
        foreach (var resource in Db.Get().ArtableStatuses.resources)
        {
            this.artableStatuses.Add(resource);
        }
        //foreach (var resource in Db.Get().Stories.resources)
        //{
        //    this.stories.Add(resource);
        //}
    }
}
