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
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Commands;
using Cqrs.Configuration;
using Cqrs.Domain;
using Cqrs.Domain.Exceptions;
using Cqrs.Events;
using cdmdotnet.Logging;

namespace MyCompany.MyProject.Domain.Inventory.Commands.Handlers
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.786")]
	public  partial class CheckInItemsToInventoryCommandHandler
		
		: ICommandHandler<Cqrs.Authentication.ISingleSignOnToken, CheckInItemsToInventoryCommand>
	{
		protected IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> UnitOfWork { get; private set; }

		protected IDependencyResolver DependencyResolver { get; private set; }

		protected ILogger Logger { get; private set; }

		public CheckInItemsToInventoryCommandHandler(IUnitOfWork<Cqrs.Authentication.ISingleSignOnToken> unitOfWork, IDependencyResolver dependencyResolver, ILogger logger)
		{
			UnitOfWork = unitOfWork;
			DependencyResolver = dependencyResolver;
			Logger = logger;
		}

		public long Count { get; set; }

		#region Implementation of ICommandHandler<in CheckInItemsToInventory>

		public void Handle(CheckInItemsToInventoryCommand command)
		{
			ICommandValidator<Cqrs.Authentication.ISingleSignOnToken, CheckInItemsToInventoryCommand> commandValidator = null;
			try
			{
				commandValidator = DependencyResolver.Resolve<ICommandValidator<Cqrs.Authentication.ISingleSignOnToken, CheckInItemsToInventoryCommand>>();
			}
			catch (Exception exception)
			{
				Logger.LogDebug("Locating an ICommandValidator failed.", "CheckInItemsToInventoryCommandHandler\\Handle(CheckInItemsToInventoryCommand)", exception);
			}

			if (commandValidator != null && !commandValidator.IsCommandValid(command))
			{
				Logger.LogInfo("The provided command is not valid.", "CheckInItemsToInventoryCommandHandler\\Handle(CheckInItemsToInventoryCommand)");
				return;
			}

			OnHandle(command);
		}

		#endregion
		partial void OnHandle(CheckInItemsToInventoryCommand command);

	}
}
