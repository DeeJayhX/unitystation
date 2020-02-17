using System;
using System.Collections;
using System.Collections.Generic;
using Objects;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GUI_Crafting : NetTab
{
	//public variables
	public List<CraftableItem> CraftableItems = new List<CraftableItem>();
	public NetLabel CraftingMenuTitle;
	public RectTransform Content;

	public void CloseTab()
	{
		ControlTabs.CloseTab(Type, Provider);
	}
}

public class CraftableItem
{
	public GameObject Item;
	public Dictionary<GameObject, int> craftingMaterials = new Dictionary<GameObject, int>();

	public CraftableItem(CraftableItem item)
	{
		this.Item = item.Item;
		this.craftingMaterials = item.craftingMaterials;
	}
}
