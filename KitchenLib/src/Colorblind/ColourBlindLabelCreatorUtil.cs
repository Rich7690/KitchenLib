﻿using Kitchen;
using KitchenData;
using System.Collections;
using System.Linq;

namespace KitchenLib.Colorblind
{

	public class ColourBlindLabelCreatorUtil : ItemGroupView
	{

		public static IEnumerable createLabelGroup(ItemLabelGroup itemLabels)
		{
			return itemLabels.itemLabels.ToList()
				.Select(createLabel).ToList();
		}

		private static ColourBlindLabel createLabel(ItemLabel label)
		{
			return new ColourBlindLabel { Item = GameData.Main.Get<Item>(label.itemId), Text = label.label };
		}
	}
}
