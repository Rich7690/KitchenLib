﻿using KitchenData;
using System;
using System.Collections.Generic;

namespace KitchenLib.Customs
{
	public abstract class CustomLocalisedGameDataObject<T, L> : CustomGameDataObject<T> where T : GameDataObject where L : Localisation
	{
		[Obsolete("Please use InfoList.")]
		public virtual LocalisationObject<L> Info { get; protected set; }
		public virtual List<(Locale, L)> InfoList { get; protected set; } = new List<(Locale, L)>();
	}

	public abstract class CustomLocalisedGameDataObject<T> : CustomLocalisedGameDataObject<LocalisedGameDataObject<T>, T> where T : Localisation
	{
	}
}
