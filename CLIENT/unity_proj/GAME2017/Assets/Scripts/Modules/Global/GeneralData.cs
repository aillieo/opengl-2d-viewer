﻿using System.Collections;
using System.Collections.Generic;
using System;

namespace GAME2017
{
	public class ElementProperty
	{
		public int air;
		public int water;
		public int fire;
		public int earth;

		public void SetData(ProtoBuf.DAT_ElementProperty ele)
		{
			air = ele.air;
			water = ele.water;
			fire = ele.fire;
			earth = ele.earth;
		}

	}


	public enum ElementType
	{
		air = 0,
		water = 1,
		fire = 2,
		earth = 3
	}

	public class UserData
	{
		public string uid;
		public string code;
		public string username;
		public string nickname;
		public int lv;
		public int gold;
		public int gem;
		public int experience;
		public int roleId;
		public int strength;
		public int magic;
		public int agility;
		public ElementProperty eleProperty;
		public ElementProperty keys;
		public List<HeroData> heroes;

		public void SetData(ProtoBuf.DAT_UserData dat)
		{
			lv = dat.lv;
			experience = dat.experience;
			uid = dat.uid;
			gold = dat.gold;
			gem = dat.gem;
			roleId = dat.roleId;
			strength = dat.strength;
			magic = dat.magic;
			agility = dat.agility;
			eleProperty.SetData(dat.elementProperty);
			keys.SetData(dat.keys);
			//heroes = dat.heroes;
		}
	}

	[Serializable]
	public class HeroData
	{
		public string id;
		// ...
	}

	[Serializable]
	public class RoleData
	{
		public string RoleId;
		public int Strength;
		public int Magic;
		public int Agility;
		public int ElemProperty;
		public int Air;
		public int Water;
		public int Fire;
		public int Earth;
	}

}