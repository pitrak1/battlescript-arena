using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consts : MonoBehaviour
{
    public static int ConsoleHeight = 400;

    public enum TileTypes {
        Empty,
        High,
        Low,
        Middle,
        Rock,
        Tree,
        Water
    }
	
    public static Dictionary<TileTypes, int> TileSpriteOffsetsMap = new() {
        {TileTypes.High, -30},
        {TileTypes.Low, 0},
        {TileTypes.Middle, -10},
        {TileTypes.Rock, 0},
        {TileTypes.Tree, 0},
        {TileTypes.Water, 0}
    };

    public static int TileHighlightOffset = -18;
    public static double TileDiameter = 1;
    public static double TileRowHeight = 0.72;
    public static double TileCornerSlope = 0.5;
    public static int IconWidth = 70;

    public static Vector2Int StartPosition = new (330, 110);
    public static Vector2Int MapDimensions = new(9, 9);

    public enum Characters {
        Druid,
        Hunter,
        Mage,
        Paladin,
        Priest,
        Rogue,
        Shaman,
        Warlock,
        Warrior
    }

    public enum ActionKeys {
        TestAbility,
        Charge,
        Whirlwind,
        Taunt,
        BattleShout,
        HuntersMark,
        AimedShot,
        ExplosiveTrap,
        Disengage,
        HammerOfJustice,
        Judgement,
        FlashOfLight,
        DivineShield,
        StarShards,
        PowerWordShield,
        ElunesGrace,
        LightOfElune,
        LifeDrain,
        Fear,
        LifeTap,
        Corruption,
        Fireball,
        Blizzard,
        Blink,
        Counterspell,
        Shadowstep,
        Stealth,
        SinisterStrike,
        Eviscerate,
        MagmaTotem,
        Windfury,
        StoneskinTotem,
        ChainLightning,
        Rejuvenation,
        EntanglingRoots,
        Moonfire,
        Tranquility,
        Bleed,
        Bite
    }

    public enum ActionTiming {
        Active,
        EndOfTurn,
        StartOfTurn,
        StartOfRound,
        StartOfMatch
    }
}
