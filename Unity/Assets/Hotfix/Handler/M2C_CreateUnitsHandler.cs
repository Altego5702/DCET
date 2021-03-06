﻿using DCET.Model;
using Vector3 = UnityEngine.Vector3;

namespace DCET.Hotfix
{
	[MessageHandler]
	public class M2C_CreateUnitsHandler : AMHandler<M2C_CreateUnits>
	{
		protected override async ETTask Run(DCET.Model.Session session, M2C_CreateUnits message)
		{	
			UnitComponent unitComponent = DCET.Model.Game.Scene.GetComponent<UnitComponent>();
			
			foreach (UnitInfo unitInfo in message.Units)
			{
				if (unitComponent.Get(unitInfo.UnitId) != null)
				{
					continue;
				}
				Unit unit = UnitFactory.Create(DCET.Model.Game.Scene, unitInfo.UnitId);
				unit.Position = new Vector3(unitInfo.X, unitInfo.Y, unitInfo.Z);
			}

			await ETTask.CompletedTask;
		}
	}
}
