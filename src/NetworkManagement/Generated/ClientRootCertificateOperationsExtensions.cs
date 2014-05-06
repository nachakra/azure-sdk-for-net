// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Network;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API includes operations for managing the virtual
    /// networks for your subscription.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/jj157182.aspx for
    /// more information)
    /// </summary>
    public static partial class ClientRootCertificateOperationsExtensions
    {
        /// <summary>
        /// The Upload Client Root Certificate operation is used to upload a
        /// new client root certificate to Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205129.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Upload Client Root Certificate
        /// Virtual Network Gateway operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static GatewayOperationResponse Create(this IClientRootCertificateOperations operations, string networkName, ClientRootCertificateCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IClientRootCertificateOperations)s).CreateAsync(networkName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Upload Client Root Certificate operation is used to upload a
        /// new client root certificate to Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205129.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Upload Client Root Certificate
        /// Virtual Network Gateway operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<GatewayOperationResponse> CreateAsync(this IClientRootCertificateOperations operations, string networkName, ClientRootCertificateCreateParameters parameters)
        {
            return operations.CreateAsync(networkName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Client Root Certificate operation deletes a previously
        /// uploaded client root certificate from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205128.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='certificateThumbprint'>
        /// Required. The X509 certificate thumbprint.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static GatewayOperationResponse Delete(this IClientRootCertificateOperations operations, string networkName, string certificateThumbprint)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IClientRootCertificateOperations)s).DeleteAsync(networkName, certificateThumbprint);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete Client Root Certificate operation deletes a previously
        /// uploaded client root certificate from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205128.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='certificateThumbprint'>
        /// Required. The X509 certificate thumbprint.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<GatewayOperationResponse> DeleteAsync(this IClientRootCertificateOperations operations, string networkName, string certificateThumbprint)
        {
            return operations.DeleteAsync(networkName, certificateThumbprint, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Client Root Certificate operation returns the public
        /// portion of a previously uploaded client root certificate in a
        /// base-64-encoded format from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205127.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='certificateThumbprint'>
        /// Required. The X509 certificate thumbprint.
        /// </param>
        /// <returns>
        /// Response to the Get Client Root Certificate operation.
        /// </returns>
        public static ClientRootCertificateGetResponse Get(this IClientRootCertificateOperations operations, string networkName, string certificateThumbprint)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IClientRootCertificateOperations)s).GetAsync(networkName, certificateThumbprint);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Client Root Certificate operation returns the public
        /// portion of a previously uploaded client root certificate in a
        /// base-64-encoded format from Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205127.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <param name='certificateThumbprint'>
        /// Required. The X509 certificate thumbprint.
        /// </param>
        /// <returns>
        /// Response to the Get Client Root Certificate operation.
        /// </returns>
        public static Task<ClientRootCertificateGetResponse> GetAsync(this IClientRootCertificateOperations operations, string networkName, string certificateThumbprint)
        {
            return operations.GetAsync(networkName, certificateThumbprint, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Client Root Certificates operation returns a list of all
        /// the client root certificates that are associated with the
        /// specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205130.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <returns>
        /// The response for the List Client Root Certificates operation.
        /// </returns>
        public static ClientRootCertificateListResponse List(this IClientRootCertificateOperations operations, string networkName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IClientRootCertificateOperations)s).ListAsync(networkName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Client Root Certificates operation returns a list of all
        /// the client root certificates that are associated with the
        /// specified virtual network in Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn205130.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Network.IClientRootCertificateOperations.
        /// </param>
        /// <param name='networkName'>
        /// Required. The name of the virtual network for this gateway.
        /// </param>
        /// <returns>
        /// The response for the List Client Root Certificates operation.
        /// </returns>
        public static Task<ClientRootCertificateListResponse> ListAsync(this IClientRootCertificateOperations operations, string networkName)
        {
            return operations.ListAsync(networkName, CancellationToken.None);
        }
    }
}
