using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ItemAPI;
using UnityEngine;

namespace ExampleMod
{
    class SuperHeart : PassiveItem
    {
        public static void Init()
        {
            string ItemName = "Super Heart";
            string SpriteDirectory = "Mod/Resources/SuperHeart.png";
            GameObject obj = new GameObject("Super Heart");

            var item = obj.AddComponent<SuperHeart>();
            ItemBuilder.AddSpriteToObject(ItemName, SpriteDirectory, obj);

            string shortDesc = "Maximum Health!";
            string longDesc = "A little boost.\n\n" +
            "Adds 2 heart containers.";

            ItemBuilder.SetupItem(item, shortDesc, longDesc, "hom:super_heart");

            ItemBuilder.AddPassiveStatModifier(item, PlayerStats.StatType.Health, 2, StatModifier.ModifyMethod.ADDITIVE);
            ItemBuilder.AddPassiveStatModifier(item, PlayerStats.StatType.Curse, 1, StatModifier.ModifyMethod.ADDITIVE);

            item.quality = PickupObject.ItemQuality.A;
        }

            public override void Pickup(PlayerController player)
            {
            base.Pickup(player);
            }

            public override DebrisObject Drop(PlayerController player)
            {
            return base.Drop(player);
            }
    }
}
