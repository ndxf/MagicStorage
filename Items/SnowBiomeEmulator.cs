﻿using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
	public class SnowBiomeEmulator : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Allows the Storage Crafting Interface to craft snow biome recipes");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("MagicStorage:AnySnowBiomeBlock", 300);
			recipe.AddTile(null, "CraftingAccess");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}