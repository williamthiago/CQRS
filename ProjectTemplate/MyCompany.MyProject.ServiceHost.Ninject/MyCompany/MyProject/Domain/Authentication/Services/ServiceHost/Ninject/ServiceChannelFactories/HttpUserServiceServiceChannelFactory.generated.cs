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
using MyCompany.MyProject.Domain.Authentication.Entities;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using Cqrs.Services;

namespace MyCompany.MyProject.Domain.Authentication.Services.ServiceHost.Ninject.ServiceChannelFactories
{
	/// <summary>
	/// A <see cref="ServiceChannelFactory{TService}"/> for using  <see cref="IUserService"/> via WCF
	/// </summary>
	[GeneratedCode("CQRS UML Code Generator", "1.601.786")]
	public partial class HttpUserServiceChannelFactory : ServiceChannelFactory<IUserService>
	{

		partial void RegisterServiceDataContracts()
		{

			UserServiceGetAllResolver.RegisterDataContracts();

			UserServiceGetByRsnResolver.RegisterDataContracts();

		}
	}
}
