﻿namespace FagNet.Core.Constants.Packets
{
    public enum EGamePacket : byte
    {
        CKeepAliveReq = 0x01,
        CLoginReq = 0x03,
        CCreateCharacterReq = 0x09,
        CDeleteCharacterReq = 0x0B,
        CSelectCharacterReq = 0x0D,
        CNATInfoReq = 0x0F,
        CQuickJoinReq = 0x10,
        CCreateRoomReq = 0x11,
        CUseItemReq = 0x15,
        CJoinTunnelReq = 0x1C,
        CTimeSyncReq = 0x1E,
        CChannelEnterReq = 0x2B,
        CChannelLeaveReq = 0x2C,
        CChannelInfoReq = 0x2F,
        CEnterRoomReq = 0x36,
        CGetPlayerInfoReq = 0x39,
        CBuyItemReq = 0x3B,
        CRepairItemReq = 0x3D,
        CRefundItemReq = 0x41,
        CAdminActionReq = 0x44,
        CAdminShowWindowReq = 0x46,
        CRefreshItemsReq = 0x4F,
        CClearInvalidateItemsReq = 0x51,
        CTutorialCompletedReq = 0x54,
        CRegisterLicenseReq = 0x58,
        CLogoutReq = 0x5C,
        CRandomshopReq = 0x6F,
        CRefreshEQItemsReq = 0x75,
        CRoomLeaveReq = 0x78,
        CRoomKickReq = 0x82,
        CChangeTeamReq = 0x83,
        CRoomShuffleReq = 0x85,
        CEventMessageReq = 0x87, //0x85,
        CRoomReadyReq = 0x89, //0x87,
        CBeginRoundReq = 0x8A, //0x88,
        CChangeRoomReq = 0x8B,
        CScoreSurvivalReq = 0x9E, //0x8C,
        CScoreKillReq = 0x8F, //0x8D,
        SScoreKillAssistReq = 0x90, //0x8E,
        CScoreOffenseReq = 0x91, //0x8F,
        CScoreOffenseAssistReq = 0x92, //0x90,
        CScoreDefenseReq = 0x93, //0x91,
        CScoreDefenseAssistReq = 0x94, //0x92,
        CReboundFumbiReq = 0x97, //0x95,
        CScoreSuicideReq = 0x98, //0x96,
        CRoomChangeItemsReq = 0x9A, //0x98,
        CRoomPlayerGameModeChangeReq = 0x9B, //0x99,
        CAvatarChangeReq = 0x8C, //0x8A,

        SResultAck = 0x02,
        SLoginAck = 0x04,
        SBeginAccountInfoAck = 0x05,
        SOpenCharInfoAck = 0x06,
        SCharEquipInfoAck = 0x07,
        SInventoryAck = 0x08,
        SCreateCharacterAck = 0x0A,
        SDeleteCharacterAck = 0x0C,
        SSelectCharacterAck = 0x0E,
        SUseItemAck = 0x16,
        SInventoryAddItemAck = 0x17,
        SIdsInfoAck = 0x18,
        SPlayerEnteredAck = 0x19,
        SEnterRoomSuccessAck = 0x1A,
        SPlayerLeaveAck = 0x1B,
        SJoinTunnelAck = 0x1D,
        STimeSyncAck = 0x1F,
        SChannelInfoAck = 0x2A,
        SChannelDeployPlayerAck = 0x2D,
        SChannelDisposePlayerAck = 0x2E,
        SRoomListAck = 0x30,
        SPlayerListAck = 0x31,
        SDeployRoomAck = 0x32,
        SDisposeRoomAck = 0x33,
        SChangeRoomAck = 0x34,
        SRoomsInfoAck = 0x35,
        SGetPlayerInfoAck = 0x3A,
        SBuyItemAck = 0x3C,
        SRepairItemAck = 0x3F,
        SItemDurabilityInfoAck = 0x40,
        SRefundItemAck = 0x42,
        SCashUpdateAck = 0x43,
        SAdminActionAck = 0x45,
        SAdminShowWindowAck = 0x47,
        SNoticeAck = 0x48,
        SCharSlotInfoAck = 0x49,
        SRefreshInvalidateItemsAck = 0x50,
        SClearInvalidateItemsAck = 0x52,
        SRefreshItemTimeInfoAck = 0x53,
        SActiveEquipPresetAck = 0x56,
        SLicenseInfoAck = 0x57,
        SRefreshLicenseInfoAck = 0x59,
        SLogoutAck = 0x5D,
        SRandomshopChanceInfoAck = 0x72,
        SRandomshopItemInfoAck = 0x73,
        SRefreshInvalidateEQItemsAck = 0x76,
        SCapsuleBuyAck = 0x79,
        SRoomPlayerLeave = 0x82,
        SChangeTeamAck = 0x84,
        //S_CHANGE_TEAM_FAIL_ACK = 0x85,
        SEventMessageAck = 0x89, //0x87,
        SRoomBriefingAck = 0x8A, //0x88,
        SRoomChangeStateAck = 0x8B, //0x89,
        SRoomChangeSubState = 0x8C, //0x8A,
        SRoomDestroyGameRule = 0x8D, //0x8B,
        SRoomChangeMasterAck = 0x8E, //0x8C,
        SRoomChangeRefereeAck = 0x8F,//0x8D,
        SRoomReadyAck = 0x91, //0x8F,
        //S_CHANGE_ROOM_ACK = 0x93,
        SScoreKillAck = 0x99, //0x97,
        SScoreKillAssistAck = 0x9A, //0x98,
        SScoreOffenseAck = 0x9B, //0x99,
        SScoreOffenseAssistAck = 0x9C, //0x9A,
        SScoreDefenseAck = 0x9D, //0x9B,
        SScoreDefenseAssistAck = 0x9E, //0x9C,
        SScoreHealAssistAck = 0x9F, //0x9D,
        SScoreTouchdownAck = 0xA0, //0x9E,
        SScoreTouchdownAssistAck = 0xA1, //0x9F,
        SReboundFumbiAck = 0xA2, //0xA0,
        SScoreSuicideAck = 0xA3, //0xA1,
        SAvatarChangeAck = 0x93, //0x91,
        SRoomChangeItemsAck = 0xA5, //0xA3,

        SCRoomPlayerEnter = 0x81,
        SCRoomMovePlayer = 0x86,
        SCTouchdown = 0x96, //0x94,

    }
}
