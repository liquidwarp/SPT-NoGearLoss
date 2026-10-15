using System.Threading;
using System.Threading.Tasks;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Spt.Config;

namespace Liquidwarp.NoGearLoss;

/// Same as setting every toggle in SPT_Data/configs/lostondeath.json to false.
[Injectable(TypePriority = OnLoadOrder.PostLoad)]
public class Mod(LostOnDeathConfig config) : IOnLoad
{
    public Task OnLoadAsync(CancellationToken ct = default)
    {
        var equipment = config.Equipment;
        equipment.ArmBand = false;
        equipment.Compass = false;
        equipment.Headwear = false;
        equipment.Earpiece = false;
        equipment.FaceCover = false;
        equipment.ArmorVest = false;
        equipment.Eyewear = false;
        equipment.TacticalVest = false;
        equipment.PocketItems = false;
        equipment.Backpack = false;
        equipment.Holster = false;
        equipment.FirstPrimaryWeapon = false;
        equipment.SecondPrimaryWeapon = false;
        equipment.Scabbard = false;
        equipment.SecuredContainer = false;

        config.QuestItems = false;
        config.SpecialSlotItems = false;
        config.WipeOnRaidStart = false;

        return Task.CompletedTask;
    }
}
