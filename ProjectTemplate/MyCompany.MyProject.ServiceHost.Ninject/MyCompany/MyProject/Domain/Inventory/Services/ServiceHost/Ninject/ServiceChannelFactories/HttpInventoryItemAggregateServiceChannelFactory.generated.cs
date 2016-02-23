﻿










//------------------------------------------------------------------------------
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

using Cqrs.Services;
using MyCompany.MyProject.Domain.Inventory.Services;

namespace MyCompany.MyProject.Domain.Inventory.Services.ServiceHost.Ninject.ServiceChannelFactories
{

	/// <summary>
	/// A <see cref="ServiceChannelFactory{TService}"/> for using  <see cref="IInventoryItemService.CreateInventoryItem"/> via WCF
	/// </summary>
	public partial class HttpInventoryItemServiceChannelFactory : ServiceChannelFactory<IInventoryItemService>
	{
		/// <summary>
		/// Instantiates a new instance of the <see cref="HttpInventoryItemServiceChannelFactory"/> class with the default endpoint configuration name of HttpInventoryItemService.
		/// </summary>
		public HttpInventoryItemServiceChannelFactory()
			: this("HttpInventoryItemService")
		{
		}

		/// <summary>
		/// Instantiates a new instance of the <see cref="HttpInventoryItemServiceChannelFactory"/> class with a specified endpoint configuration name.
		/// </summary>
		/// <param name="endpointConfigurationName">The configuration name used for the endpoint.</param>
		public HttpInventoryItemServiceChannelFactory(string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
		}

		protected override void RegisterDataContracts()
		{
			RegisterAggregateServiceDataContracts();
			RegisterServiceDataContracts();
		}

		partial void RegisterServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts();
		partial void RegisterAggregateServiceDataContracts()
		{
	



		}
	}
}
