﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Figure out what bitfield(s) these values map to and replace with OR's
public enum MotionStyle {
    Motion_Invalid = -2147483648,
    Motion_HandCombat = -2147483588,
    Motion_NonCombat = -2147483587,
    Motion_SwordCombat = -2147483586,
    Motion_BowCombat = -2147483585,
    Motion_SwordShieldCombat = -2147483584,
    Motion_CrossbowCombat = -2147483583,
    Motion_UnusedCombat = -2147483582,
    Motion_SlingCombat = -2147483581,
    Motion_2HandedSwordCombat = -2147483580,
    Motion_2HandedStaffCombat = -2147483579,
    Motion_DualWieldCombat = -2147483578,
    Motion_ThrownWeaponCombat = -2147483577,
    Motion_Graze = -2147483576,
    Motion_Magic = -2147483575,
    Motion_BowNoAmmo = -2147483416,
    Motion_CrossBowNoAmmo = -2147483415,
    Motion_AtlatlCombat = -2147483336,
    Motion_ThrownShieldCombat = -2147483335,
    Motion_HoldRun = -2063597567,
    Motion_HoldSidestep = -2063597566,
    Command_Invalid = 0,
    Command_Cancel = 134217890,
    Command_CreateShortcutToSelected = 134217897,
    Command_EnterChat = 134217909,
    Command_ToggleChat = 134217910,
    Command_SavePosition = 134217911,
    Command_UseSelected = 150995107,
    Command_AutosortSelected = 150995108,
    Command_DropSelected = 150995109,
    Command_GiveSelected = 150995110,
    Command_SplitSelected = 150995111,
    Command_ExamineSelected = 150995112,
    Command_PreviousCompassItem = 150995114,
    Command_NextCompassItem = 150995115,
    Command_ClosestCompassItem = 150995116,
    Command_PreviousSelection = 150995117,
    Command_LastAttacker = 150995118,
    Command_PreviousFellow = 150995119,
    Command_NextFellow = 150995120,
    Command_ToggleCombat = 150995121,
    Command_OptionsPanel = 150995128,
    Command_ResetView = 150995129,
    Command_FloorView = 150995136,
    Command_PreviousItem = 150995138,
    Command_NextItem = 150995139,
    Command_ClosestItem = 150995140,
    Command_MapView = 150995142,
    Command_AutoRun = 150995143,
    Command_DecreasePowerSetting = 150995144,
    Command_IncreasePowerSetting = 150995145,
    Command_FirstPersonView = 150995157,
    Command_AllegiancePanel = 150995158,
    Command_FellowshipPanel = 150995159,
    Command_SpellbookPanel = 150995160,
    Command_SpellComponentsPanel = 150995161,
    Command_HousePanel = 150995162,
    Command_AttributesPanel = 150995163,
    Command_SkillsPanel = 150995164,
    Command_MapPanel = 150995165,
    Command_InventoryPanel = 150995166,
    Command_CaptureScreenshotToFile = 150995175,
    Command_AutoCreateShortcuts = 150995198,
    Command_AutoRepeatAttacks = 150995199,
    Command_AutoTarget = 150995200,
    Command_AdvancedCombatInterface = 150995201,
    Command_IgnoreAllegianceRequests = 150995202,
    Command_IgnoreFellowshipRequests = 150995203,
    Command_InvertMouseLook = 150995204,
    Command_LetPlayersGiveYouItems = 150995205,
    Command_AutoTrackCombatTargets = 150995206,
    Command_DisplayTooltips = 150995207,
    Command_AttemptToDeceivePlayers = 150995208,
    Command_RunAsDefaultMovement = 150995209,
    Command_StayInChatModeAfterSend = 150995210,
    Command_RightClickToMouseLook = 150995211,
    Command_VividTargetIndicator = 150995212,
    Command_SelectSelf = 150995213,
    Command_NextMonster = 150995215,
    Command_PreviousMonster = 150995216,
    Command_ClosestMonster = 150995217,
    Command_NextPlayer = 150995218,
    Command_PreviousPlayer = 150995219,
    Command_ClosestPlayer = 150995220,
    Command_TradePanel = 150995226,
    Command_CharacterOptionsPanel = 150995281,
    Command_SoundAndGraphicsPanel = 150995282,
    Command_HelpfulSpellsPanel = 150995283,
    Command_HarmfulSpellsPanel = 150995284,
    Command_CharacterInformationPanel = 150995285,
    Command_LinkStatusPanel = 150995286,
    Command_VitaePanel = 150995287,
    Command_ShareFellowshipXP = 150995288,
    Command_ShareFellowshipLoot = 150995289,
    Command_AcceptCorpseLooting = 150995290,
    Command_IgnoreTradeRequests = 150995291,
    Command_DisableWeather = 150995292,
    Command_DisableHouseEffect = 150995293,
    Command_SideBySideVitals = 150995294,
    Command_ShowRadarCoordinates = 150995295,
    Command_ShowSpellDurations = 150995296,
    Command_MuteOnLosingFocus = 150995297,
    Command_AllegianceChat = 150995301,
    Command_AutomaticallyAcceptFellowshipRequests = 150995302,
    Command_Reply = 150995303,
    Command_MonarchReply = 150995304,
    Command_PatronReply = 150995305,
    Command_ToggleCraftingChanceOfSuccessDialog = 150995306,
    Command_UseClosestUnopenedCorpse = 150995307,
    Command_UseNextUnopenedCorpse = 150995308,
    Command_IssueSlashCommand = 150995309,
    Command_MouseLook = 201326785,
    Command_HighAttack = 218103986,
    Command_MediumAttack = 218103987,
    Command_LowAttack = 218103988,
    Command_CameraLeftRotate = 218103994,
    Command_CameraRightRotate = 218103995,
    Command_CameraRaise = 218103996,
    Command_CameraLower = 218103997,
    Command_CameraCloser = 218103998,
    Command_CameraFarther = 218103999,
    Command_ShiftView = 218104005,
    Motion_Hop = 268435530,
    Motion_Jumpup = 268435531,
    Motion_ChestBeat = 268435533,
    Motion_TippedLeft = 268435534,
    Motion_TippedRight = 268435535,
    Motion_FallDown = 268435536,
    Motion_Twitch1 = 268435537,
    Motion_Twitch2 = 268435538,
    Motion_Twitch3 = 268435539,
    Motion_Twitch4 = 268435540,
    Motion_StaggerBackward = 268435541,
    Motion_StaggerForward = 268435542,
    Motion_Sanctuary = 268435543,
    Motion_ThrustMed = 268435544,
    Motion_ThrustLow = 268435545,
    Motion_ThrustHigh = 268435546,
    Motion_SlashHigh = 268435547,
    Motion_SlashMed = 268435548,
    Motion_SlashLow = 268435549,
    Motion_BackhandHigh = 268435550,
    Motion_BackhandMed = 268435551,
    Motion_BackhandLow = 268435552,
    Motion_Shoot = 268435553,
    Motion_AttackHigh1 = 268435554,
    Motion_AttackMed1 = 268435555,
    Motion_AttackLow1 = 268435556,
    Motion_AttackHigh2 = 268435557,
    Motion_AttackMed2 = 268435558,
    Motion_AttackLow2 = 268435559,
    Motion_AttackHigh3 = 268435560,
    Motion_AttackMed3 = 268435561,
    Motion_AttackLow3 = 268435562,
    Motion_HeadThrow = 268435563,
    Motion_FistSlam = 268435564,
    Motion_BreatheFlame_ = 268435565,
    Motion_SpinAttack = 268435566,
    Motion_MagicPowerUp01 = 268435567,
    Motion_MagicPowerUp02 = 268435568,
    Motion_MagicPowerUp03 = 268435569,
    Motion_MagicPowerUp04 = 268435570,
    Motion_MagicPowerUp05 = 268435571,
    Motion_MagicPowerUp06 = 268435572,
    Motion_MagicPowerUp07 = 268435573,
    Motion_MagicPowerUp08 = 268435574,
    Motion_MagicPowerUp09 = 268435575,
    Motion_MagicPowerUp10 = 268435576,
    Motion_EnterGame = 268435612,
    Motion_ExitGame = 268435613,
    Motion_OnCreation = 268435614,
    Motion_OnDestruction = 268435615,
    Motion_EnterPortal = 268435616,
    Motion_ExitPortal = 268435617,
    Motion_SpecialAttack1 = 268435661,
    Motion_SpecialAttack2 = 268435662,
    Motion_SpecialAttack3 = 268435663,
    Motion_MissileAttack1 = 268435664,
    Motion_MissileAttack2 = 268435665,
    Motion_MissileAttack3 = 268435666,
    Motion_Blink = 268435682,
    Motion_Bite = 268435683,
    Motion_SkillHealSelf = 268435726,
    Motion_LogOut = 268435739,
    Motion_DoubleSlashLow = 268435740,
    Motion_DoubleSlashMed = 268435741,
    Motion_DoubleSlashHigh = 268435742,
    Motion_TripleSlashLow = 268435743,
    Motion_TripleSlashMed = 268435744,
    Motion_TripleSlashHigh = 268435745,
    Motion_DoubleThrustLow = 268435746,
    Motion_DoubleThrustMed = 268435747,
    Motion_DoubleThrustHigh = 268435748,
    Motion_TripleThrustLow = 268435749,
    Motion_TripleThrustMed = 268435750,
    Motion_TripleThrustHigh = 268435751,
    Motion_MagicPowerUp01Purple = 268435752,
    Motion_MagicPowerUp02Purple = 268435753,
    Motion_MagicPowerUp03Purple = 268435754,
    Motion_MagicPowerUp04Purple = 268435755,
    Motion_MagicPowerUp05Purple = 268435756,
    Motion_MagicPowerUp06Purple = 268435757,
    Motion_MagicPowerUp07Purple = 268435758,
    Motion_MagicPowerUp08Purple = 268435759,
    Motion_MagicPowerUp09Purple = 268435760,
    Motion_MagicPowerUp10Purple = 268435761,
    Motion_HouseRecall = 268435767,
    Motion_LifestoneRecall = 268435792,
    Motion_Fishing = 268435810,
    Motion_MarketplaceRecall = 268435811,
    Motion_EnterPKLite = 268435812,
    Motion_AllegianceHometownRecall = 268435822,
    Motion_PKArenaRecall = 268435823,
    Motion_OffhandSlashHigh = 268435824,
    Motion_OffhandSlashMed = 268435825,
    Motion_OffhandSlashLow = 268435826,
    Motion_OffhandThrustHigh = 268435827,
    Motion_OffhandThrustMed = 268435828,
    Motion_OffhandThrustLow = 268435829,
    Motion_OffhandDoubleSlashLow = 268435830,
    Motion_OffhandDoubleSlashMed = 268435831,
    Motion_OffhandDoubleSlashHigh = 268435832,
    Motion_OffhandTripleSlashLow = 268435833,
    Motion_OffhandTripleSlashMed = 268435834,
    Motion_OffhandTripleSlashHigh = 268435835,
    Motion_OffhandDoubleThrustLow = 268435836,
    Motion_OffhandDoubleThrustMed = 268435837,
    Motion_OffhandDoubleThrustHigh = 268435838,
    Motion_OffhandTripleThrustLow = 268435839,
    Motion_OffhandTripleThrustMed = 268435840,
    Motion_OffhandTripleThrustHigh = 268435841,
    Motion_OffhandKick = 268435842,
    Motion_AttackHigh4 = 268435843,
    Motion_AttackMed4 = 268435844,
    Motion_AttackLow4 = 268435845,
    Motion_AttackHigh5 = 268435846,
    Motion_AttackMed5 = 268435847,
    Motion_AttackLow5 = 268435848,
    Motion_AttackHigh6 = 268435849,
    Motion_AttackMed6 = 268435850,
    Motion_AttackLow6 = 268435851,
    Motion_PunchFastHigh = 268435852,
    Motion_PunchFastMed = 268435853,
    Motion_PunchFastLow = 268435854,
    Motion_PunchSlowHigh = 268435855,
    Motion_PunchSlowMed = 268435856,
    Motion_PunchSlowLow = 268435857,
    Motion_OffhandPunchFastHigh = 268435858,
    Motion_OffhandPunchFastMed = 268435859,
    Motion_OffhandPunchFastLow = 268435860,
    Motion_OffhandPunchSlowHigh = 268435861,
    Motion_OffhandPunchSlowMed = 268435862,
    Motion_OffhandPunchSlowLow = 268435863,
    Motion_YMCA = 301990043,
    Motion_Flatulence = 301990100,
    Motion_Demonet = 301990111,
    Motion_Cheer = 318767180,
    Motion_ShakeFist = 318767225,
    Motion_Beckon = 318767226,
    Motion_BeSeeingYou = 318767227,
    Motion_BlowKiss = 318767228,
    Motion_BowDeep = 318767229,
    Motion_ClapHands = 318767230,
    Motion_Cry = 318767231,
    Motion_Laugh = 318767232,
    Motion_MimeEat = 318767233,
    Motion_MimeDrink = 318767234,
    Motion_Nod = 318767235,
    Motion_Point = 318767236,
    Motion_ShakeHead = 318767237,
    Motion_Shrug = 318767238,
    Motion_Wave = 318767239,
    Motion_Akimbo = 318767240,
    Motion_HeartyLaugh = 318767241,
    Motion_Salute = 318767242,
    Motion_ScratchHead = 318767243,
    Motion_SmackHead = 318767244,
    Motion_TapFoot = 318767245,
    Motion_WaveHigh = 318767246,
    Motion_WaveLow = 318767247,
    Motion_YawnStretch = 318767248,
    Motion_Cringe = 318767249,
    Motion_Kneel = 318767250,
    Motion_Plead = 318767251,
    Motion_Shiver = 318767252,
    Motion_Shoo = 318767253,
    Motion_Slouch = 318767254,
    Motion_Spit = 318767255,
    Motion_Surrender = 318767256,
    Motion_Woah = 318767257,
    Motion_Winded = 318767258,
    Motion_Pray = 318767306,
    Motion_Mock = 318767307,
    Motion_Teapot = 318767308,
    Motion_WarmHands = 318767382,
    Motion_Helper = 318767410,
    Motion_NudgeLeft = 318767431,
    Motion_NudgeRight = 318767432,
    Motion_PointLeft = 318767433,
    Motion_PointRight = 318767434,
    Motion_PointDown = 318767435,
    Motion_Knock = 318767436,
    Motion_ScanHorizon = 318767437,
    Motion_DrudgeDance = 318767438,
    Motion_HaveASeat = 318767439,
    Motion_StopTurning = 536870970,
    Motion_Jump = 620757051,
    Motion_Stop = 1073741828,
    Motion_Fallen = 1073741832,
    Motion_Interpolating = 1073741833,
    Motion_Hover = 1073741834,
    Motion_On = 1073741835,
    Motion_Off = 1073741836,
    Motion_Dead = 1073741841,
    Motion_Falling = 1073741845,
    Motion_Reload = 1073741846,
    Motion_Unload = 1073741847,
    Motion_Pickup = 1073741848,
    Motion_StoreInBackpack = 1073741849,
    Motion_Eat = 1073741850,
    Motion_Drink = 1073741851,
    Motion_Reading = 1073741852,
    Motion_JumpCharging = 1073741853,
    Motion_AimLevel = 1073741854,
    Motion_AimHigh15 = 1073741855,
    Motion_AimHigh30 = 1073741856,
    Motion_AimHigh45 = 1073741857,
    Motion_AimHigh60 = 1073741858,
    Motion_AimHigh75 = 1073741859,
    Motion_AimHigh90 = 1073741860,
    Motion_AimLow15 = 1073741861,
    Motion_AimLow30 = 1073741862,
    Motion_AimLow45 = 1073741863,
    Motion_AimLow60 = 1073741864,
    Motion_AimLow75 = 1073741865,
    Motion_AimLow90 = 1073741866,
    Motion_MagicBlast = 1073741867,
    Motion_MagicSelfHead = 1073741868,
    Motion_MagicSelfHeart = 1073741869,
    Motion_MagicBonus = 1073741870,
    Motion_MagicClap = 1073741871,
    Motion_MagicHarm = 1073741872,
    Motion_MagicHeal = 1073741873,
    Motion_MagicThrowMissile = 1073741874,
    Motion_MagicRecoilMissile = 1073741875,
    Motion_MagicPenalty = 1073741876,
    Motion_MagicTransfer = 1073741877,
    Motion_MagicVision = 1073741878,
    Motion_MagicEnchantItem = 1073741879,
    Motion_MagicPortal = 1073741880,
    Motion_MagicPray = 1073741881,
    Motion_CastSpell = 1073742035,
    Motion_UseMagicStaff = 1073742048,
    Motion_UseMagicWand = 1073742049,
    Motion_TwitchSubstate1 = 1073742052,
    Motion_TwitchSubstate2 = 1073742053,
    Motion_TwitchSubstate3 = 1073742054,
    Motion_Pickup5 = 1073742131,
    Motion_Pickup10 = 1073742132,
    Motion_Pickup15 = 1073742133,
    Motion_Pickup20 = 1073742134,
    Motion_Ready = 1090519043,
    Motion_Crouch = 1090519058,
    Motion_Sitting = 1090519059,
    Motion_Sleeping = 1090519060,
    Motion_ATOYOT = 1107296505,
    Motion_ShakeFistState = 1124073706,
    Motion_PrayState = 1124073707,
    Motion_BowDeepState = 1124073708,
    Motion_ClapHandsState = 1124073709,
    Motion_CrossArmsState = 1124073710,
    Motion_ShiverState = 1124073711,
    Motion_PointState = 1124073712,
    Motion_WaveState = 1124073713,
    Motion_AkimboState = 1124073714,
    Motion_SaluteState = 1124073715,
    Motion_ScratchHeadState = 1124073716,
    Motion_TapFootState = 1124073717,
    Motion_LeanState = 1124073718,
    Motion_KneelState = 1124073719,
    Motion_PleadState = 1124073720,
    Motion_SlouchState = 1124073722,
    Motion_SurrenderState = 1124073723,
    Motion_WoahState = 1124073724,
    Motion_WindedState = 1124073725,
    Motion_SnowAngelState = 1124073749,
    Motion_CurtseyState = 1124073751,
    Motion_AFKState = 1124073752,
    Motion_MeditateState = 1124073753,
    Motion_SitState = 1124073786,
    Motion_SitCrossleggedState = 1124073787,
    Motion_SitBackState = 1124073788,
    Motion_PointLeftState = 1124073789,
    Motion_PointRightState = 1124073790,
    Motion_TalktotheHandState = 1124073791,
    Motion_PointDownState = 1124073792,
    Motion_DrudgeDanceState = 1124073793,
    Motion_PossumState = 1124073794,
    Motion_ReadState = 1124073795,
    Motion_ThinkerState = 1124073796,
    Motion_HaveASeatState = 1124073797,
    Motion_AtEaseState = 1124073798,
    Motion_RunForward = 1140850695,
    Motion_WalkForward = 1157627909,
    Motion_WalkBackwards = 1157627910,
    Motion_TurnRight = 1694498829,
    Motion_TurnLeft = 1694498830,
    Motion_SideStepRight = 1694498831,
    Motion_SideStepLeft = 1694498832
}

namespace MovementTypes {
    public enum Type {
        Invalid,
        RawCommand,
        InterpretedCommand,
        StopRawCommand,
        StopInterpretedCommand,
        StopCompletely,
        MoveToObject,
        MoveToPosition,
        TurnToObject,
        TurnToHeading
    }
}

public enum HoldKey {
    HoldKey_Invalid,
    HoldKey_None,
    HoldKey_Run,
    Num_HoldKeys
}