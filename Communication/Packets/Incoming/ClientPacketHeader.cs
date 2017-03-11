﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mango.Communication.Packets.Incoming
{
    static class ClientPacketHeader
    {
        public const int GetClientVersionEvent = 4000;
        public const int InitCryptoMessageEvent = 1525;//93;
        public const int GenerateSecretKeyMessageEvent = 3557;//3735;
        public const int VersionCheckMessageEvent = 482;//2621;
        public const int UniqueIDMessageEvent = 3786;//3405;
        public const int GetSessionParametersMessageEvent = 1817; // to remove???
        public const int SSOTicketMessageEvent = 1887;//694;
        public const int TryLoginMessageEvent = 3423;//3757;
        public const int PongMessageEvent = 2170;//3869;
        public const int InfoRetrieveMessageEvent = 3897;//2613;
        public const int DisconnectMessageEvent = 2367;//2408;
        public const int MessengerInitMessageEvent = 2959;//87;
        public const int FriendListUpdateMessageEvent = 3911;//1737;
        public const int SendMsgMessageEvent = 2790;//104;
        public const int AcceptBuddyMessageEvent = 1606;//1974;
        public const int DeclineBuddyMessageEvent = 2543;//2006;
        public const int RequestBuddyMessageEvent = 2926;//2553;
        public const int RemoveBuddyMessageEvent = 768;//615;
        public const int HabboSearchMessageEvent = 351;//1136;
        public const int GetBuddyRequestsMessageEvent = 66;//2287;
        public const int FollowFriendMessageEvent = 2297;//2827;
        public const int SendRoomInviteMessageEvent = 1135;//3858;
        public const int FindNewFriendsMessageEvent = 1886;//7;
        public const int GetEventStreamEvent = 763;//3879;
        public const int SetEventStreamingAllowedEvent = 1590;//1280;
        public const int GetCreditsInfoEvent = 184;//1177;
        public const int RequestFurniInventoryEvent = 1074;//3136;
        public const int AvatarEffectSelectedEvent = 209;//3577;
        public const int AvatarEffectActivatedEvent = 2198;//1093;
        public const int GetBadgesEvent = 3090;//842;
        public const int SetActivatedBadgesEvent = 3078;//992;
        public const int GetBadgePointLimitsEvent = 3981;//297;
        public const int GetAchievementsEvent = 3466;//2922;
        public const int UnacceptTradingEvent = 1250;//1584;
        public const int AcceptTradingEvent = 2748;//1803;
        public const int CloseTradingEvent = 2887;//3189;
        public const int OpenTradingEvent = 156;//1825;
        public const int AddItemToTradeEvent = 3921;//2778;
        public const int ConfirmAcceptTradingEvent = 591;//2871;
        public const int ConfirmDeclineTradingEvent = 3932;//2948;
        public const int RemoveItemFromTradeEvent = 2314;//1726;
        public const int GetPetInventoryEvent = 3948;//490;
        public const int MakeOfferMessageEvent = 1045;//3682;
        public const int GetMarketplaceConfigurationMessageEvent = 3174;//527;
        public const int GetMarketplaceCanMakeOfferEvent = 2406;//3011;
        public const int BuyMarketplaceTokensMessageEvent = 1051;//3297;
        public const int BuyOfferMessageEvent = 986;//1572;
        public const int CancelOfferMessageEvent = 1310;//2169;
        public const int RedeemOfferCreditsMessageEvent = 1542;//2603;
        public const int GetOffersMessageEvent = 1493;//924;
        public const int GetOwnOffersMessageEvent = 3627;//1094;
        public const int GetMarketplaceItemStatsEvent = 195;//3949;
        public const int DeleteFavouriteRoomMessageEvent = 1568;//1693;
        public const int AddFavouriteRoomMessageEvent = 174;//3557;
        public const int GetUserFlatCatsMessageEvent = 2232;//371;
        public const int CanCreateEventMessageEvent = 345; // TO REMOVE???
        public const int CreateEventMessageEvent = 346; //  TO REMOVE ?
        public const int CancelEventMessageEvent = 347; // TO REMOVE ?
        public const int EditEventMessageEvent = 348; // TO REMOVE ?
        public const int GetRoomSettingsMessageEvent = 1244;//1381;
        public const int SaveRoomSettingsMessageEvent = 259;//1069;
        public const int DeleteRoomMessageEvent = 1499;//3105;
        public const int GetOfficialRoomsMessageEvent = 53;//2353;
        public const int GetPopularRoomTagsMessageEvent = 2697;//1831;
        public const int UpdateNavigatorSettingsMessageEvent = 2240;//3724;
        public const int GetGuestRoomMessageEvent = 2210;//1044;
        public const int CanCreateRoomMessageEvent = 2369;//2415;
        public const int CreateFlatMessageEvent = 2004;//3581;
        public const int RateFlatMessageEvent = 267;//2818;
        public const int GetPublicSpaceCastLibsMessageEvent = 388; // TO REMOVE ?
        public const int PopularRoomsSearchMessageEvent = 1308;//3086;
        public const int RoomsWithHighestScoreSearchMessageEvent = 2583;//255;
        public const int MyFriendsRoomsSearchMessageEvent = 2523;//1684;
        public const int RoomsWhereMyFriendsAreSearchMessageEvent = 3038;//935;
        public const int MyRoomsSearchMessageEvent = 2606;//3031;
        public const int MyFavouriteRoomsSearchMessageEvent = 3674;//1443;
        public const int MyRoomHistorySearchMessageEvent = 3900;//179;
        public const int RoomTextSearchMessageEvent = 1341;//489;
        public const int RoomTagSearchMessageEvent = 2819;//1450;
        public const int LatestEventsSearchMessageEvent = 165;//2540;
        public const int ToggleStaffPickMessageEvent = 3583;//3216;
        public const int GetPetCommandsMessageEvent = 3004; // OUTDATED x2 ?
        public const int OpenConnectionMessageEvent = 3156;//1000;
        public const int OpenFlatConnectionMessageEvent = 3056;//1192;
        public const int ChatMessageEvent = 1148;//2147;
        public const int ShoutMessageEvent = 999;//3465;
        public const int WhisperMessageEvent = 784;//926;
        public const int StartTypingMessageEvent = 382;//2412;
        public const int CancelTypingMessageEvent = 2952;//700;
        public const int SignMessageEvent = 2123;//1151;
        public const int ChangeMottoMessageEvent = 3776;//2695;
        public const int GoToFlatMessageEvent = 1136;//2908;
        public const int GetRoomEntryDataMessageEvent = 2589;//1690;
        public const int UseFurnitureMessageEvent = 2241;//2715;
        public const int PickupObjectMessageEvent = 2996;//1148;
        public const int MoveObjectMessageEvent = 1937;//581;
        public const int SetObjectDataMessageEvent = 916;//2327;
        public const int MoveAvatarMessageEvent = 1193;//901;
        public const int PlaceObjectMessageEvent = 2775;//2598;
        public const int MoveWallItemMessageEvent = 327;//3777;
        public const int PlacePetMessageEvent = 1828;//2498;
        public const int RemovePetFromFlatMessageEvent = 559;//908;
        public const int GetMOTDMessageEvent = 3110; // Doesnt exist
        public const int GetUserNotificationsMessageEvent = 3105787; // doesnt exist
        public const int ChangeQueueMessageEvent = 2383;//889;
        public const int RoomDimmerGetPresetsMessageEvent = 2857; // wrong
        public const int RoomDimmerSavePresetMessageEvent = 1817;//3628;
        public const int RoomDimmerChangeStateMessageEvent = 31;//3514;
        public const int UseWallItemMessageEvent = 2876;//3872;
        public const int GetItemDataMessageEvent = 3518;//1320;
        public const int SetItemDataMessageEvent = 2010;//635;
        public const int RemoveItemMessageEvent = 1423;//800;
        public const int GetPetInfoMessageEvent = 2345;//3838;
        public const int GetFurnitureAliasesMessageEvent = 2403;//804;
        public const int QuitMessageEvent = 1344;//1882;
        public const int PlacePostItMessageEvent = 217;//3273;
        public const int AddSpamWallPostItMessageEvent = 1145;//512;
        public const int DanceMessageEvent = 1199;//1003;
        public const int WaveMessageEvent = 964;//3310;
        public const int LookToMessageEvent = 3901;//2078;
        public const int ThrowDiceMessageEvent = 2446;//927;
        public const int DiceOffMessageEvent = 2027;//3166;
        public const int CreditFurniRedeemMessageEvent = 2180;//793; // todo: check
        public const int EnterOneWayDoorMessageEvent = 827;//2606;
        public const int SpinWheelOfFortuneMessageEvent = 2126;//765;
        public const int SetRandomStateMessageEvent = 2247;//3141;
        public const int SetClothingChangeDataMessageEvent = 589;//3353;
        public const int QuestVendingWallItemMessageEvent = 2985;//2274;
        public const int OpenPetPackageMessageEvent = 2274;//1852;
        public const int OpenWelcomeGiftEvent = 796;//3592;
        public const int KickUserMessageEvent = 957;//3175;
        public const int AssignRightsMessageEvent = 112;//252;
        public const int RemoveRightsMessageEvent = 1099;//3864;
        public const int LetUserInMessageEvent = 1208;//3968;
        public const int RemoveAllRightsMessageEvent = 3300;//1260;
        public const int BanUserMessageEvent = 2349;//3231;
        public const int KickBotMessageEvent = 441; // to remove
        public const int GetUserTagsMessageEvent = 3124;//1449;
        public const int GetSelectedBadgesMessageEvent = 822;//3406;
        public const int GetHabboGroupBadgesMessageEvent = 243;//163;
        public const int IgnoreUserMessageEvent = 2357;//437;
        public const int GetIgnoredUsersMessageEvent = 0x0707;//1705;
        public const int UnignoreUserMessageEvent = 3154;//3882;
        public const int RespectUserMessageEvent = 1087;//1345;
        public const int RespectPetMessageEvent = 1087;//3953;
        public const int PickIssuesMessageEvent = 2203;//673;
        public const int ReleaseIssuesMessageEvent = 2354;//1335;
        public const int CloseIssuesMessageEvent = 1155;//346;
        public const int GetModeratorUserInfoMessageEvent = 1374;//181;
        public const int GetUserChatlogMessageEvent = 2049;//3396;
        public const int GetRoomChatlogMessageEvent = 208;//2236;
        public const int GetCfhChatlogMessageEvent = 2414;//670;
        public const int GetRoomVisitsMessageEvent = 3893;//732;
        public const int GetModeratorRoomInfoMessageEvent = 2334;//2469;
        public const int ModerateRoomMessageEvent = 2509;//1272;
        public const int ModAlertMessageEvent = 1821;//2854;
        public const int ModMessageMessageEvent = 1271;//2084;
        public const int ModKickMessageEvent = 2965;//3996;
        public const int ModBanMessageEvent = 3547;//2623;
        public const int ModeratorActionMessageEvent = 2148;//741;
        public const int CallForHelpMessageEvent = 668;//247;
        public const int DeletePendingCallsForHelpMessageEvent = 1155;//346;
        public const int OpenHelpToolMessageEvent = 3949;//184;
        public const int ChangeEmailEvent = 1892;//3386;
        public const int ScrGetUserInfoMessageEvent = 1646;//3361;
        public const int GetAchievementShareIdEvent = 2063;//3057;
        public const int PurchaseFromCatalogEvent = 402;//651;
        public const int PurchaseFromCatalogAsGiftEvent = 3311;//1769;
        public const int GetGiftWrappingConfigurationEvent = 2346;//511;
        public const int SelectClubGiftEvent = 1631;//1770;
        public const int GetCatalogIndexEvent = 383;//2793;
        public const int GetCatalogPageEvent = 3187;//3181;
        public const int RedeemVoucherMessageEvent = 3128;//964;
        public const int GetClubOffersMessageEvent = 522;//1218; // ?? todo: do this
        public const int GetSellablePetBreedsEvent = 1272;//3793;
        public const int MarkCatalogNewAdditionsPageOpenedEvent = 1885;//1713;
        public const int GetRoomAdMessageEvent = 499;//3357;
        public const int GetInterstitialMessageEvent = 2079;//3615;
        public const int EventLogMessageEvent = 2901;//1204;
        public const int GetSoundSettingsEvent = 3206;//1323;
        public const int SetSoundSettingsEvent = 452;//2775;
        public const int GetWardrobeMessageEvent = 1917;//1453;
        public const int SaveWardrobeOutfitMessageEvent = 3240;//939;
        public const int UpdateFigureDataMessageEvent = 3519;//256;
        public const int GetQuestsMessageEvent = 3037;//2270;
        public const int AcceptQuestMessageEvent = 1036;//3902;
        public const int RejectQuestMessageEvent = 1720;//1054;
        public const int OpenQuestTrackerMessageEvent = 1094;//3419;
        public const int StartCampaignMessageEvent = 79;//1510;
        public const int GetProfileInformationEvent = 3096;//2531;
        public const int PromotedRoomsEvent = 569;//960;
        public const int SitAvatarEvent = 1202;//2195;
        public const int ApplyDecorationEvent = 3006;

        public const int InitGameCenterEvent = 396;
        public const int GetGameAchievementsEvent = 2644;
        public const int Game2QuickJoinGameEvent = 2888;

        public static Dictionary<int, string> PacketNames = new Dictionary<int, string>()
        {
        };
    }
}
