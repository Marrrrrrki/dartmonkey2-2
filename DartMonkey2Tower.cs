using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;

namespace DartMonkey2;

public class DartMonkey2Tower : ModTower
{
    public override string TowerSet => TowerSet.Primary;

    public override int Cost => 200;

    public override string BaseTower => TowerType.DartMonkey;

    public override int TopPathUpgrades => 5;

    public override int MiddlePathUpgrades => 5;

    public override int BottomPathUpgrades => 5;

    public override string Icon => "DartMonkey-Icon";

    public override string Portrait => "DartMonkey-Icon";

    public override string Description => "A second Dart Monkey.";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
    }
}
