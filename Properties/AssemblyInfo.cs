using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(VRCPlusPlusFixed.BuildInfo.Description)]
[assembly: AssemblyDescription(VRCPlusPlusFixed.BuildInfo.Description)]
[assembly: AssemblyCompany(VRCPlusPlusFixed.BuildInfo.Company)]
[assembly: AssemblyProduct(VRCPlusPlusFixed.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + VRCPlusPlusFixed.BuildInfo.Author)]
[assembly: AssemblyTrademark(VRCPlusPlusFixed.BuildInfo.Company)]
[assembly: AssemblyVersion(VRCPlusPlusFixed.BuildInfo.Version)]
[assembly: AssemblyFileVersion(VRCPlusPlusFixed.BuildInfo.Version)]
[assembly: MelonInfo(typeof(VRCPlusPlusFixed.VRCPlsPlus), VRCPlusPlusFixed.BuildInfo.Name, VRCPlusPlusFixed.BuildInfo.Version, VRCPlusPlusFixed.BuildInfo.Author, VRCPlusPlusFixed.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]