﻿// -----------------------------------------------------------------------
// <copyright file="GetPartnerSupportProfile.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.PowerShell.Commands
{
    using System.Management.Automation;
    using Models.Partners;
    using PartnerCenter.Models.Partners;

    /// <summary>
    /// Gets the partner support profile from Partner Center.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "PartnerSupportProfile"), OutputType(typeof(PSSupportProfile))]
    public class GetPartnerSupportProfile : PartnerPSCmdlet
    {
        /// <summary>
        /// Executes the operations associated with the cmdlet.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            SupportProfile profile;

            try
            {
                profile = Partner.Profiles.SupportProfile.Get();

                WriteObject(new PSSupportProfile(profile));
            }
            finally
            {
                profile = null;
            }
        }
    }
}