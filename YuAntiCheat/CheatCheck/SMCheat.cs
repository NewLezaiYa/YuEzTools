using AmongUs.GameOptions;
using Hazel;
using System;
using System.Linq;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using InnerNet;
using UnityEngine;
using YuAntiCheat.Get;
using YuAntiCheat;

namespace YuAntiCheat;

public class SMCheat
{
    public static bool ReceiveInvalidRpc(PlayerControl pc, byte callId)
    {
        switch (callId)
        {
            case unchecked((byte)420):
                Main.Logger.LogWarning($"有SickoMenu玩家，{"好友编号："+pc.GetClient().FriendCode+"/名字："+pc.GetRealName()+"/ProductUserId："+pc.GetClient().ProductUserId}");
                //Main.PlayerStates[pc.GetClient().Id].IsSM = true;
                return true;
            case 168:
                Main.Logger.LogWarning($"有SickoMenu玩家，{"好友编号："+pc.GetClient().FriendCode+"/名字："+pc.GetRealName()+"/ProductUserId："+pc.GetClient().ProductUserId}");
                //Main.PlayerStates[pc.GetClient().Id].IsSM = true;
                return true;
        }
        return false;
    }
}