// This is Generate File Auto Implement Code form CustomTool.cs

using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public enum LoginType
    {
        Account = 0,
        Device = 1,
        Facebook = 2,
        Google = 3,
        UserId = 4,
        Apple = 5,
        PublicAddress = 6,
    }

    public enum UserRoleType
    {
        Administrator = 0,
        GameMaster = 1,
        SuperModerazor = 2,
        Moderazor = 3,
        User = 100,
        UserNonActivate = 101,
    }

    public enum UserCurrencyType
    {
        Coin = 0,
        Gem = 1,
        Exp = 2,
    }

    public enum CustomPlatform
    {
        PC = 0,
        Android = 1,
        iOS = 2,
        WebGL = 3,
        Unknown = 9,
    }

    public enum FriendStatus
    {
        Friend = 0,
        WaitingAccept = 1,
        SentRequestAndWaitingAccept = 2,
        Unknown = 3,
    }

    public enum CharacterItemType
    {
        Weapon = 1,
        Hat = 2,
        Gloves = 3,
        Outfit = 4,
        Boot = 5,
        Pet = 6,
    }

    public enum GenderType
    {
        Other = 0,
        Male = 1,
        Female = 2,
    }

    public enum FirearmType
    {
        Unknown = 0,
        Revolver = 1,
        AutomaticPistol = 2,
        UZI = 3,
        SMG = 4,
        Rifle = 5,
        AssaultRifle = 6,
        SniperRifle = 7,
        Shotgun = 8,
        RocketLauncher = 9
    }
    public enum MagazineType
    {
        Removable = 0,
        Integral = 1
    }
    public enum HoldType
    {
        RightHandOnly = 0,
        LeftHandOnMagazine = 1,
        LeftHandOnForestock = 2
    }
    public enum FirearmLoadType
    {
        Bolt,
        Drum,
        Lamp
    }
    public enum EquipmentPart
    {
        Armor = 0,
        Helmet = 1,
        Pauldrons = 2,
        Vest = 3,
        Gloves = 4,
        Belt = 5,
        Boots = 6,
        MeleeWeapon1H = 7,
        MeleeWeapon2H = 8,
        MeleeWeaponPaired = 9,
        Bow = 10,
        Firearm1H = 11,
        Firearm2H = 12,
        Shield = 13,
        Earrings = 14,
        Cape = 15,
        Back = 16,
        Glasses = 17,
        Mask = 18
    }

    public enum BodyPart
    {
        Body = 0,
        Head = 1,
        Hair = 2,
        Ears = 3,
        Eyebrows = 4,
        Eyes = 5,
        Mouth = 6,
        Beard = 7
    }

    
}
