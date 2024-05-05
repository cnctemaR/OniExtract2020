﻿using System;
using UnityEngine;
using static OniExtract2.Patches;
using System.Collections.Generic;
using Klei.AI;
using STRINGS;
using static STRINGS.DUPLICANTS.PERSONALITIES;

namespace OniExtract2
{
    public class BEntity
    {
        public string name;
        public string nameString;
        public List<string> dlcIds = new List<string>();
        public HashSet<Tag> tags;
        //public AirFilter airFilter;
        //public AlgaeDistillery algaeDistillery;
        //public AlgaeHabitat algaeHabitat;
        //public AutoMiner autoMiner;
        //public BasicForagePlantPlanted basicForagePlantPlanted;
        public OutBlightVulnerable blightVulnerable;
        //public CarePackage carePackage;
        //public Checkpoint checkpoint;
        //public ChoreDriver choreDriver;
        //public Claustrophobic claustrophobic;
        //public Climacophobic climacophobic;
        //public CommandModule commandModule;
        //public ComplexFabricatorSM complexFabricatorSM;
        //public Compost compost;
        //public CreatureBait creatureBait;
        //public CreatureLure creatureLure;
        //public CritterTrapPlant critterTrapPlant;
        //public CryoTank cryoTank;
        //public Desalinator desalinator;
        //public EarlyBird earlyBird;
        //public Electrolyzer electrolyzer;
        //public ElementSpout elementSpout;
        //public EntityElementExchanger entityElementExchanger;
        //public EquippableBalloon equippableBalloon;
        //public EvilFlower evilFlower;
        //public FarmTile farmTile;
        //public Fashionable fashionable;
        //public Flatulence flatulence;
        //public FlowerVase flowerVase;
        //public GameFlowManager gameFlowManager;
        //public Geyser geyser;
        //public GlowStick glowStick;
        //public Grave grave;
        //public HeatCompressor heatCompressor;
        //public HighEnergyParticle highEnergyParticle;
        //public HotTub hotTub;
        //public IceCooledFan iceCooledFan;
        //public IceMachine iceMachine;
        //public JetSuitLocker jetSuitLocker;
        //public Juicer juicer;
        //public JungleGasPlant jungleGasPlant;
        //public LeadSuitLocker leadSuitLocker;
        //public Loner loner;
        //public MaskStation maskStation;
        //public MassiveHeatSink massiveHeatSink;
        //public MegaBrainTank megaBrainTank;
        //public Meteorphile meteorphile;
        //public Narcolepsy narcolepsy;
        //public Navigator navigator;
        //public NightOwl nightOwl;
        //public OilEater oilEater;
        //public OilRefinery oilRefinery;
        //public OreScrubber oreScrubber;
        //public Oxyfern oxyfern;
        //public OxyliteRefinery oxyliteRefinery;
        //public Phonobox phonobox;
        //public PlanterBox planterBox;
        //public PodLander podLander;
        //public Polymerizer polymerizer;
        //public PrefersColder prefersColder;
        //public PrefersWarmer prefersWarmer;
        //public PrickleGrass prickleGrass;
        //public RadiationEater radiationEater;
        //public RadiationLight radiationLight;
        //public RailGun railGun;
        //public Reactor reactor;
        //public RocketEngine rocketEngine;
        //public RocketEngineCluster rocketEngineCluster;
        //public RotPile rotPile;
        //public RustDeoxidizer rustDeoxidizer;
        //public SaltPlant saltPlant;
        //public Sauna sauna;
        //public SensitiveFeet sensitiveFeet;
        //public SetLocker setLocker;
        //public Snorer snorer;
        //public SocialGatheringPoint socialGatheringPoint;
        //public SolidConduitDropper solidConduitDropper;
        //public SolidConduitInbox solidConduitInbox;
        //public SolidConduitOutbox solidConduitOutbox;
        //public SolidLogicValve solidLogicValve;
        //public SolitarySleeper solitarySleeper;
        public bool isStandardCropPlant;
        //public StarryEyed starryEyed;
        //public StickerBomb stickerBomb;
        //public Stinky stinky;
        //public SuitLocker suitLocker;
        //public Telepad telepad;
        //public Telephone telephone;
        //public TeleportalPad teleportalPad;
        //public Thriver thriver;
        //public TouristModule touristModule;
        //public Trap trap;
        //public WarmBlooded warmBlooded;
        //public WaterPurifier waterPurifier;
        //public Workaholic workaholic;
        //public KPrefabID kPrefabID;
        //public KSelectable kSelectable;
        //public KBatchedAnimController kBatchedAnimController;
        //public StateMachineController stateMachineController;
        //public PrimaryElement primaryElement;
        //public InfoDescription infoDescription;
        //public Notifier notifier;
        //public KBoxCollider2D kBoxCollider2D;
        //public OccupyArea occupyArea;
        public OutDecorProvider decorProvider;
        //public Rotatable rotatable;
        public OutPressureVulnerable pressureVulnerable;
        //public WiltCondition wiltCondition;
        //public Prioritizable prioritizable;
        //public Uprootable uprootable;
        //public Effects effects;
        //public UprootedMonitor uprootedMonitor;
        public OutDrowningMonitor drowningMonitor;
        //public KAnimControllerBase kAnimControllerBase;
        public OutTemperatureVulnerable temperatureVulnerable;
        public OutMutantPlant mutantPlant;
        public Crop.CropVal? cropVal;
        //public Growing growing;
        //public Harvestable harvestable;
        //public HarvestDesignatable harvestDesignatable;
        //public Trait trait;
        //public Modifiers modifiers;
        //public Pickupable pickupable;
        //public Clearable clearable;
        //public Health health;
        //public CharacterOverlay characterOverlay;
        //public RangedAttackable rangedAttackable;
        //public FactionAlignment factionAlignment;
        //public AnimEventHandler animEventHandler;
        //public Butcherable butcherable;
        //public CreatureBrain creatureBrain;
        //public ChoreConsumer choreConsumer;
        //public Baggable baggable;
        //public Capturable capturable;
        //public Movable movable;
        //public ElementChunk elementChunk;
        //public Dumpable dumpable;
        //public SubstanceChunk substanceChunk;
        //public EntitySplitter entitySplitter;
        //public Edible edible;
        //public HasSortOrder hasSortOrder;
        //public MedicinalPill medicinalPill;
        //public MedicinalPillWorkable medicinalPillWorkable;
        //public PlantableSeed plantableSeed;
        public SeedProducer.SeedInfo? seedInfo;
        //public EntityPreview entityPreview;
        public OutStorage storage;
        public OutElementConsumer elementConsumer;
        //public KCircleCollider2D kCircleCollider2D;
        //public ArcadeMachine arcadeMachine;
        //public BeachChair beachChair;
        //public BottleEmptier bottleEmptier;
        //public ColdBreather coldBreather;
        //public CreatureDeliveryPoint creatureDeliveryPoint;
        //public DevHEPSpawner devHEPSpawner;
        //public ElementConverter elementConverter;
        //public EspressoMachine espressoMachine;
        //public FlushToilet flushToilet;
        //public HandSanitizer handSanitizer;
        //public HighEnergyParticleRedirector highEnergyParticleRedirector;
        //public HighEnergyParticleSpawner highEnergyParticleSpawner;
        //public IlluminationVulnerable illuminationVulnerable;
        //public LaunchableRocket launchableRocket;
        //public LaunchableRocketCluster launchableRocketCluster;
        //public LiquidCooledFan liquidCooledFan;
        //public ManualHighEnergyParticleSpawner manualHighEnergyParticleSpawner;
        //public MechanicalSurfboard mechanicalSurfboard;
        //public NuclearResearchCenter nuclearResearchCenter;
        //public Overheatable overheatable;
        //public PlantElementEmitter plantElementEmitter;
        //public RailGunPayloadOpener railGunPayloadOpener;
        //public ReceptacleMonitor receptacleMonitor;
        //public RocketConduitReceiver rocketConduitReceiver;
        //public RocketConduitSender rocketConduitSender;
        //public RocketControlStation rocketControlStation;
        //public SodaFountain sodaFountain;
        //public SolidTransferArm solidTransferArm;
        //public SpaceHeater spaceHeater;
        //public Toilet toilet;
        //public TravelTubeEntrance travelTubeEntrance;
        //public VerticalWindTunnel verticalWindTunnel;
        //public WarpConduitReceiver warpConduitReceiver;
        //public WarpConduitSender warpConduitSender;
        //public WaterCooler waterCooler;
        public int manualDeliveryKG_Num = 0;
        public List<OutManualDeliveryKG> manualDeliveryKGs = new List<OutManualDeliveryKG>();
        public FertilizationMonitor.Def fertilizationDef;
        public IrrigationMonitor.Def irrigationDef;
        public OutGrowing growing;
        public OutPrimaryElement primaryElement;
        public OutIlluminationVulnerable illuminationVulnerable;
        //Critter
        public DiseaseSourceVisualizer diseaseSourceVisualizer;
        public LureableMonitor.Def lureableMonitorDef;
        public ThreatMonitor.Def threatMonitorDef;
        public bool isHasSubmergedMonitorDef;
        public GasAndLiquidConsumerMonitor.Def gasAndLiquidConsumerMonitorDef;
        public CreatureCalorieMonitor.Def creatureCalorieMonitorDef;
        public AgeMonitor.Def ageMonitorDef;
        public HappinessMonitor.Def happinessMonitorDef;
        public WildnessMonitor.Def wildnessMonitorDef;
        public OvercrowdingMonitor.Def overcrowdingMonitorDef;
        public FertilityMonitor.Def fertilityMonitorDef;
        public OutNavigator navigator;
        public bool isRanchable;
        public bool add_fixed_capturable_monitor;
        public bool add_fish_overcrowding_monitor;
        public BabyMonitor.Def babyMonitorDef;
        public OutIncubationMonitorDef incubatorMonitorDef;
        public bool isHasCreatureSleepMonitorDef;
        public CallAdultMonitor.Def callAdultMonitorDef;
        public OutPickupable pickupable;
        public Clearable clearable;
        public OutHealth health;
        public CharacterOverlay characterOverlay;
        public RangedAttackable rangedAttackable;
        public OutFactionAlignment factionAlignment;
        public OutPrioritizable prioritizable;
        public CreatureDebugGoToMonitor.Def creatureDebugGoToMonitorDef;
        public DeathMonitor.Def deathMonitorDef;
        public EntombVulnerable entombVulnerable;
        public Butcherable butcherable;
        public Baggable baggable;
        public Capturable capturable;
        public EggProtectionMonitor.Def eggProtectionMonitorDef;
        public Trappable trappable;
        public LoopingSounds loopingSounds;
        public CreatureFallMonitor.Def creatureFallMonitorDef;
        public SeedPlantingMonitor.Def seedPlantingMonitorDef;
        public ClimbableTreeMonitor.Def climbableTreeMonitorDef;
        public SymbolOverrideController symbolOverrideController;
        public SolidConsumerMonitor.Def solidConsumerMonitorDef;
        public ScaleGrowthMonitor.Def scaleGrowthMonitorDef;
        public DiggerMonitor.Def diggerMonitorDef;
        public MoltDropperMonitor.Def moltDropperMonitorDef;
        public HiveGrowthMonitor.Def hiveGrowthMonitorDef;
        public HiveEatingMonitor.Def hiveEatingMonitorDef;
        public HiveHarvestMonitor.Def hiveHarvestMonitorDef;
        public FoundationMonitor foundationMonitor;
        public HiveWorkableEmpty hiveWorkableEmpty;
        public BeeHappinessMonitor.Def beeHappinessMonitorDef;
        public BeeSleepMonitor.Def beeSleepMonitorDef;
        public List<OutElementConverter> elementConverters = new List<OutElementConverter>();
        public List<OutPassiveElementConsumer> passiveElementConsumers = new List<OutPassiveElementConsumer>();
        public OutComet comet;
        //duplicant
        public OutOxygenBreather oxygenBreather;

        public BEntity(string name, HashSet<Tag> tags)
        {
            this.name = name;
            this.tags = tags;
        }

    }
}
