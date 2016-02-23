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
using System.Runtime.Serialization;
using Cqrs.Commands;
using Cqrs.Messages;

namespace MyCompany.MyProject.Domain.Inventory.Commands
{
	[GeneratedCode("CQRS UML Code Generator", "1.601.786")]
	public  partial class DeactivateInventoryItemCommand : ICommand<Cqrs.Authentication.ISingleSignOnToken>
	{
		#region Implementation of ICommand

		[DataMember]
		public Guid Id
		{
			get { return Rsn; }
			set { Rsn = value; }
		}

		[DataMember]
		public int ExpectedVersion { get; set; }

		#endregion

		#region Implementation of IMessageWithAuthenticationToken<Cqrs.Authentication.ISingleSignOnToken>

		[DataMember]
		public Cqrs.Authentication.ISingleSignOnToken AuthenticationToken { get; set; }

		#endregion

		#region Implementation of IMessage

		[DataMember]
		public Guid CorrelationId { get; set; }

		[Obsolete("Use CorrelationId")]
		[DataMember]
		public Guid CorrolationId
		{
			get { return CorrelationId; }
			set { CorrelationId = value; }
		}

		[DataMember]
		public FrameworkType Framework { get; set; }

		#endregion

		[DataMember]
		public Guid Rsn { get; set; }

		public DeactivateInventoryItemCommand(Guid rsn)
		{
			Rsn = rsn;
		}
	}
}
