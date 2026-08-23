global using BTD_Mod_Helper.Extensions;
using MelonLoader;
using BTD_Mod_Helper;
using DartMonkey2;

[assembly: MelonInfo(typeof(DartMonkey2.DartMonkey2), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6-Epic")]

namespace DartMonkey2;

public class DartMonkey2 : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<DartMonkey2>("DartMonkey2 loaded!");
    }
}
