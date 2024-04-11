using Il2CppVRC.SDKBase;
using MelonLoader;
using System.IO;
using UnityEngine;

namespace VRCPlusPlusFixed
{
    public static class BuildInfo
    {
        public const string Name = "VRCPlusPlus";
        public const string Description = "Get some worlds extras perks";
        public const string Author = "FS21114 | Fixed by Biscuit";
        public const string Company = null;
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }

    public class VRCPlsPlus : MelonMod
    {
        public override void OnInitializeMelon()
        {
        MelonLogger.Msg("Starting VRCPlusPlus...");
        }
        public override void OnLateUpdate()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.P))
            {
                Networking.LocalPlayer.displayName = File.ReadAllText("UserData/VRCPlusPlus.cfg");
            }
        }
    }
 }