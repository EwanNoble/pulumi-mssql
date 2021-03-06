// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mssql

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Login
//
// The `Login` resource creates and manages a login on a SQL Server.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-mssql/sdk/go/mssql"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := mssql.NewLogin(ctx, "example", &mssql.LoginArgs{
// 			LoginName: pulumi.String("testlogin"),
// 			Server: &LoginServerArgs{
// 				AzureLogin: nil,
// 				Host:       pulumi.String("example-sql-server.database.windows.net"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// Before importing `mssql_login`, you must to configure the authentication to your sql server1. Using Azure AD authentication, you must set the following environment variables`MSSQL_TENANT_ID`, `MSSQL_CLIENT_ID` and `MSSQL_CLIENT_SECRET`. 2. Using SQL authentication, you must set the following environment variables`MSSQL_USERNAME` and `MSSQL_PASSWORD`. After that you can import the SQL Server login using the server URL and `login name`, e.g.
//
// ```sh
//  $ pulumi import mssql:index/login:Login example 'mssql://example-sql-server.database.windows.net/testlogin'
// ```
type Login struct {
	pulumi.CustomResourceState

	// The default database of this server login. Defaults to `master`. This argument does not apply to Azure SQL Database.
	DefaultDatabase pulumi.StringPtrOutput `pulumi:"defaultDatabase"`
	// The default language of this server login. Defaults to `usEnglish`. This argument does not apply to Azure SQL Database.
	DefaultLanguage pulumi.StringPtrOutput `pulumi:"defaultLanguage"`
	// The name of the server login. Changing this forces a new resource to be created.
	LoginName pulumi.StringOutput `pulumi:"loginName"`
	// The password of the server login.
	Password pulumi.StringOutput `pulumi:"password"`
	// The principal id of this server login.
	PrincipalId pulumi.IntOutput `pulumi:"principalId"`
	// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
	Server LoginServerOutput `pulumi:"server"`
}

// NewLogin registers a new resource with the given unique name, arguments, and options.
func NewLogin(ctx *pulumi.Context,
	name string, args *LoginArgs, opts ...pulumi.ResourceOption) (*Login, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LoginName == nil {
		return nil, errors.New("invalid value for required argument 'LoginName'")
	}
	if args.Password == nil {
		return nil, errors.New("invalid value for required argument 'Password'")
	}
	if args.Server == nil {
		return nil, errors.New("invalid value for required argument 'Server'")
	}
	var resource Login
	err := ctx.RegisterResource("mssql:index/login:Login", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLogin gets an existing Login resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLogin(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LoginState, opts ...pulumi.ResourceOption) (*Login, error) {
	var resource Login
	err := ctx.ReadResource("mssql:index/login:Login", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Login resources.
type loginState struct {
	// The default database of this server login. Defaults to `master`. This argument does not apply to Azure SQL Database.
	DefaultDatabase *string `pulumi:"defaultDatabase"`
	// The default language of this server login. Defaults to `usEnglish`. This argument does not apply to Azure SQL Database.
	DefaultLanguage *string `pulumi:"defaultLanguage"`
	// The name of the server login. Changing this forces a new resource to be created.
	LoginName *string `pulumi:"loginName"`
	// The password of the server login.
	Password *string `pulumi:"password"`
	// The principal id of this server login.
	PrincipalId *int `pulumi:"principalId"`
	// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
	Server *LoginServer `pulumi:"server"`
}

type LoginState struct {
	// The default database of this server login. Defaults to `master`. This argument does not apply to Azure SQL Database.
	DefaultDatabase pulumi.StringPtrInput
	// The default language of this server login. Defaults to `usEnglish`. This argument does not apply to Azure SQL Database.
	DefaultLanguage pulumi.StringPtrInput
	// The name of the server login. Changing this forces a new resource to be created.
	LoginName pulumi.StringPtrInput
	// The password of the server login.
	Password pulumi.StringPtrInput
	// The principal id of this server login.
	PrincipalId pulumi.IntPtrInput
	// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
	Server LoginServerPtrInput
}

func (LoginState) ElementType() reflect.Type {
	return reflect.TypeOf((*loginState)(nil)).Elem()
}

type loginArgs struct {
	// The default database of this server login. Defaults to `master`. This argument does not apply to Azure SQL Database.
	DefaultDatabase *string `pulumi:"defaultDatabase"`
	// The default language of this server login. Defaults to `usEnglish`. This argument does not apply to Azure SQL Database.
	DefaultLanguage *string `pulumi:"defaultLanguage"`
	// The name of the server login. Changing this forces a new resource to be created.
	LoginName string `pulumi:"loginName"`
	// The password of the server login.
	Password string `pulumi:"password"`
	// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
	Server LoginServer `pulumi:"server"`
}

// The set of arguments for constructing a Login resource.
type LoginArgs struct {
	// The default database of this server login. Defaults to `master`. This argument does not apply to Azure SQL Database.
	DefaultDatabase pulumi.StringPtrInput
	// The default language of this server login. Defaults to `usEnglish`. This argument does not apply to Azure SQL Database.
	DefaultLanguage pulumi.StringPtrInput
	// The name of the server login. Changing this forces a new resource to be created.
	LoginName pulumi.StringInput
	// The password of the server login.
	Password pulumi.StringInput
	// Server and login details for the SQL Server. The attributes supported in the `server` block is detailed below.
	Server LoginServerInput
}

func (LoginArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*loginArgs)(nil)).Elem()
}

type LoginInput interface {
	pulumi.Input

	ToLoginOutput() LoginOutput
	ToLoginOutputWithContext(ctx context.Context) LoginOutput
}

func (*Login) ElementType() reflect.Type {
	return reflect.TypeOf((**Login)(nil)).Elem()
}

func (i *Login) ToLoginOutput() LoginOutput {
	return i.ToLoginOutputWithContext(context.Background())
}

func (i *Login) ToLoginOutputWithContext(ctx context.Context) LoginOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LoginOutput)
}

// LoginArrayInput is an input type that accepts LoginArray and LoginArrayOutput values.
// You can construct a concrete instance of `LoginArrayInput` via:
//
//          LoginArray{ LoginArgs{...} }
type LoginArrayInput interface {
	pulumi.Input

	ToLoginArrayOutput() LoginArrayOutput
	ToLoginArrayOutputWithContext(context.Context) LoginArrayOutput
}

type LoginArray []LoginInput

func (LoginArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Login)(nil)).Elem()
}

func (i LoginArray) ToLoginArrayOutput() LoginArrayOutput {
	return i.ToLoginArrayOutputWithContext(context.Background())
}

func (i LoginArray) ToLoginArrayOutputWithContext(ctx context.Context) LoginArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LoginArrayOutput)
}

// LoginMapInput is an input type that accepts LoginMap and LoginMapOutput values.
// You can construct a concrete instance of `LoginMapInput` via:
//
//          LoginMap{ "key": LoginArgs{...} }
type LoginMapInput interface {
	pulumi.Input

	ToLoginMapOutput() LoginMapOutput
	ToLoginMapOutputWithContext(context.Context) LoginMapOutput
}

type LoginMap map[string]LoginInput

func (LoginMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Login)(nil)).Elem()
}

func (i LoginMap) ToLoginMapOutput() LoginMapOutput {
	return i.ToLoginMapOutputWithContext(context.Background())
}

func (i LoginMap) ToLoginMapOutputWithContext(ctx context.Context) LoginMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LoginMapOutput)
}

type LoginOutput struct{ *pulumi.OutputState }

func (LoginOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Login)(nil)).Elem()
}

func (o LoginOutput) ToLoginOutput() LoginOutput {
	return o
}

func (o LoginOutput) ToLoginOutputWithContext(ctx context.Context) LoginOutput {
	return o
}

type LoginArrayOutput struct{ *pulumi.OutputState }

func (LoginArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Login)(nil)).Elem()
}

func (o LoginArrayOutput) ToLoginArrayOutput() LoginArrayOutput {
	return o
}

func (o LoginArrayOutput) ToLoginArrayOutputWithContext(ctx context.Context) LoginArrayOutput {
	return o
}

func (o LoginArrayOutput) Index(i pulumi.IntInput) LoginOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Login {
		return vs[0].([]*Login)[vs[1].(int)]
	}).(LoginOutput)
}

type LoginMapOutput struct{ *pulumi.OutputState }

func (LoginMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Login)(nil)).Elem()
}

func (o LoginMapOutput) ToLoginMapOutput() LoginMapOutput {
	return o
}

func (o LoginMapOutput) ToLoginMapOutputWithContext(ctx context.Context) LoginMapOutput {
	return o
}

func (o LoginMapOutput) MapIndex(k pulumi.StringInput) LoginOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Login {
		return vs[0].(map[string]*Login)[vs[1].(string)]
	}).(LoginOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LoginInput)(nil)).Elem(), &Login{})
	pulumi.RegisterInputType(reflect.TypeOf((*LoginArrayInput)(nil)).Elem(), LoginArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*LoginMapInput)(nil)).Elem(), LoginMap{})
	pulumi.RegisterOutputType(LoginOutput{})
	pulumi.RegisterOutputType(LoginArrayOutput{})
	pulumi.RegisterOutputType(LoginMapOutput{})
}
