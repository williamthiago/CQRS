﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Cqrs.Events;
using Cqrs.Domain;

namespace MyCompany.MyProject.Domain.Inventory.Events.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.523.412")]
	public  partial class InventoryItemRenamedEventHandler : IEventHandler<Cqrs.Authentication.ISingleSignOnToken, InventoryItemRenamed>
	{
		#region Implementation of IEventHandler<in InventoryItemRenamed>

		public void Handle(InventoryItemRenamed @event)
		{
			OnHandle(@event);
		}

		#endregion

		partial void OnHandle(InventoryItemRenamed @event);
	}
}
