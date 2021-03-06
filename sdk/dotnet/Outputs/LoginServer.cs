// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Mssql.Outputs
{

    [OutputType]
    public sealed class LoginServer
    {
        /// <summary>
        /// Azure AD login for managing the database resources. The attributes supported in the `azure_login` block is detailed below.
        /// </summary>
        public readonly Outputs.LoginServerAzureLogin? AzureLogin;
        /// <summary>
        /// The host of the SQL Server. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// SQL Server login for managing the database resources. The attributes supported in the `login` block is detailed below.
        /// </summary>
        public readonly Outputs.LoginServerLogin? Login;
        /// <summary>
        /// The port of the SQL Server. Defaults to `1433`. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string? Port;

        [OutputConstructor]
        private LoginServer(
            Outputs.LoginServerAzureLogin? azureLogin,

            string host,

            Outputs.LoginServerLogin? login,

            string? port)
        {
            AzureLogin = azureLogin;
            Host = host;
            Login = login;
            Port = port;
        }
    }
}
