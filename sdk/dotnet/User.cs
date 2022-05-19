// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Mssql
{
    /// <summary>
    /// ## # mssql.User
    /// 
    /// The `mssql.User` resource creates and manages a user on a SQL Server database.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Mssql = Pulumi.Mssql;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Mssql.User("example", new Mssql.UserArgs
    ///         {
    ///             Roles = 
    ///             {
    ///                 "db_owner",
    ///             },
    ///             Server = new Mssql.Inputs.UserServerArgs
    ///             {
    ///                 AzureLogin = new Mssql.Inputs.UserServerAzureLoginArgs
    ///                 {
    ///                     ClientId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    ///                     ClientSecret = "terriblySecretSecret",
    ///                     TenantId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    ///                 },
    ///                 Host = "example-sql-server.database.windows.net",
    ///             },
    ///             Username = "user@example.com",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// &gt; Note that in order to create an external user referencing an Azure AD entity (user, application), the Azure SQL Server needs to be a member of an Azure AD group assigned the Azure AD role `Directory Readers`. If it is not possible to give the Azure SQL Server this role (through the group), you can use the `object id` of the Azure AD entity instead.
    /// 
    /// ## Import
    /// 
    /// Before importing `mssql_user`, you must to configure the authentication to your sql server1. Using Azure AD authentication, you must set the following environment variables`MSSQL_TENANT_ID`, `MSSQL_CLIENT_ID` and `MSSQL_CLIENT_SECRET`. 2. Using SQL authentication, you must set the following environment variables`MSSQL_USERNAME` and `MSSQL_PASSWORD`. After that you can import the SQL Server database user using the server URL and `login name`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import mssql:index/user:User example 'mssql://example-sql-server.database.windows.net/master/user@example.com'
    /// ```
    /// </summary>
    [MssqlResourceType("mssql:index/user:User")]
    public partial class User : Pulumi.CustomResource
    {
        /// <summary>
        /// One of `DATABASE`, `INSTANCE`, or `EXTERNAL`.
        /// </summary>
        [Output("authenticationType")]
        public Output<string> AuthenticationType { get; private set; } = null!;

        /// <summary>
        /// The user will be created in this database. Defaults to `master`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("database")]
        public Output<string?> Database { get; private set; } = null!;

        /// <summary>
        /// Specifies the default language for the user. If no default language is specified, the default language for the user will bed the default language of the database. This argument does not apply to Azure SQL Database or if the user is not a contained database user.
        /// </summary>
        [Output("defaultLanguage")]
        public Output<string?> DefaultLanguage { get; private set; } = null!;

        /// <summary>
        /// Specifies the first schema that will be searched by the server when it resolves the names of objects for this database user. Defaults to `dbo`.
        /// </summary>
        [Output("defaultSchema")]
        public Output<string?> DefaultSchema { get; private set; } = null!;

        /// <summary>
        /// The login name of the database user. This must refer to an existing SQL Server login name. Conflicts with the `password` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Output("loginName")]
        public Output<string?> LoginName { get; private set; } = null!;

        /// <summary>
        /// The object id of the external username. Only used in azure_login auth context when AAD role delegation to sql server identity is not possible.
        /// </summary>
        [Output("objectId")]
        public Output<string?> ObjectId { get; private set; } = null!;

        /// <summary>
        /// The password of the database user. Conflicts with the `login_name` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The principal id of this database user.
        /// </summary>
        [Output("principalId")]
        public Output<int> PrincipalId { get; private set; } = null!;

        /// <summary>
        /// List of database roles the user has. Defaults to none.
        /// </summary>
        [Output("roles")]
        public Output<ImmutableArray<string>> Roles { get; private set; } = null!;

        /// <summary>
        /// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
        /// </summary>
        [Output("server")]
        public Output<Outputs.UserServer> Server { get; private set; } = null!;

        /// <summary>
        /// The name of the database user. Changing this forces a new resource to be created.
        /// </summary>
        [Output("username")]
        public Output<string> Username { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("mssql:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("mssql:index/user:User", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The user will be created in this database. Defaults to `master`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// Specifies the default language for the user. If no default language is specified, the default language for the user will bed the default language of the database. This argument does not apply to Azure SQL Database or if the user is not a contained database user.
        /// </summary>
        [Input("defaultLanguage")]
        public Input<string>? DefaultLanguage { get; set; }

        /// <summary>
        /// Specifies the first schema that will be searched by the server when it resolves the names of objects for this database user. Defaults to `dbo`.
        /// </summary>
        [Input("defaultSchema")]
        public Input<string>? DefaultSchema { get; set; }

        /// <summary>
        /// The login name of the database user. This must refer to an existing SQL Server login name. Conflicts with the `password` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Input("loginName")]
        public Input<string>? LoginName { get; set; }

        /// <summary>
        /// The object id of the external username. Only used in azure_login auth context when AAD role delegation to sql server identity is not possible.
        /// </summary>
        [Input("objectId")]
        public Input<string>? ObjectId { get; set; }

        /// <summary>
        /// The password of the database user. Conflicts with the `login_name` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// List of database roles the user has. Defaults to none.
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
        /// </summary>
        [Input("server", required: true)]
        public Input<Inputs.UserServerArgs> Server { get; set; } = null!;

        /// <summary>
        /// The name of the database user. Changing this forces a new resource to be created.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// One of `DATABASE`, `INSTANCE`, or `EXTERNAL`.
        /// </summary>
        [Input("authenticationType")]
        public Input<string>? AuthenticationType { get; set; }

        /// <summary>
        /// The user will be created in this database. Defaults to `master`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// Specifies the default language for the user. If no default language is specified, the default language for the user will bed the default language of the database. This argument does not apply to Azure SQL Database or if the user is not a contained database user.
        /// </summary>
        [Input("defaultLanguage")]
        public Input<string>? DefaultLanguage { get; set; }

        /// <summary>
        /// Specifies the first schema that will be searched by the server when it resolves the names of objects for this database user. Defaults to `dbo`.
        /// </summary>
        [Input("defaultSchema")]
        public Input<string>? DefaultSchema { get; set; }

        /// <summary>
        /// The login name of the database user. This must refer to an existing SQL Server login name. Conflicts with the `password` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Input("loginName")]
        public Input<string>? LoginName { get; set; }

        /// <summary>
        /// The object id of the external username. Only used in azure_login auth context when AAD role delegation to sql server identity is not possible.
        /// </summary>
        [Input("objectId")]
        public Input<string>? ObjectId { get; set; }

        /// <summary>
        /// The password of the database user. Conflicts with the `login_name` argument. Changing this forces a new resource to be created.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// The principal id of this database user.
        /// </summary>
        [Input("principalId")]
        public Input<int>? PrincipalId { get; set; }

        [Input("roles")]
        private InputList<string>? _roles;

        /// <summary>
        /// List of database roles the user has. Defaults to none.
        /// </summary>
        public InputList<string> Roles
        {
            get => _roles ?? (_roles = new InputList<string>());
            set => _roles = value;
        }

        /// <summary>
        /// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
        /// </summary>
        [Input("server")]
        public Input<Inputs.UserServerGetArgs>? Server { get; set; }

        /// <summary>
        /// The name of the database user. Changing this forces a new resource to be created.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public UserState()
        {
        }
    }
}