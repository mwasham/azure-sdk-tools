// ----------------------------------------------------------------------------------
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

namespace Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo
{
    using Microsoft.WindowsAzure.Management.ServiceManagement.Test.FunctionalTests.PowershellCore;    
    using Microsoft.WindowsAzure.ServiceManagement;

    public class AddAzureVMImageCmdletInfo : CmdletsInfo
    {
        public AddAzureVMImageCmdletInfo(string imageName, string mediaLocation, OSType os, string label)
        {
            cmdletName = Utilities.AddAzureVMImageCmdletName;

            cmdletParams.Add(new CmdletParam("ImageName", imageName));
            cmdletParams.Add(new CmdletParam("MediaLocation", mediaLocation));
            cmdletParams.Add(new CmdletParam("OS", os.ToString()));
                
            if (System.String.IsNullOrWhiteSpace(label))
            {
                cmdletParams.Add(new CmdletParam("Label", label));
            }
        }
    }
}
