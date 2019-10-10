﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.Azure.Commands.DataFactoryV2.Models;

namespace Microsoft.Azure.Commands.DataFactoryV2
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DataFactoryV2DataFlowDebugSession", DefaultParameterSetName = ParameterSetNames.ByFactoryName), OutputType(typeof(PSDataFlowDebugSessionInfo))]
    public class GetAzureDataFactoryDataFlowDebugSessionCommand : DataFactoryDataFlowDebugSessionBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            ByResourceId();
            ByFactoryObject();
            WriteObject(DataFactoryClient.GetDebugSessions(ResourceGroupName, DataFactoryName));
        }
    }
}
