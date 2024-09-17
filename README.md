# Sidub Platform - Authentication

This repository contains the authentication module for the Sidub Platform. It
provides authentication capabilities against services registered within the
platform's service registry.

The framework tends to be integrated within the platform and does not need to
be called directly. Consumption will usually be limited to leveraging the
service reference and credentials for registration within the service registry.

This library contains core abstractions and services; concrete authentication
implementations are provided in separate packages such as
`Sidub.Platform.Authentication.Http` and
`Sidub.Platform.Authentication.Gremlin`.

## Main Components
Basic use of the authentication framework involves registering an authentication
service as a child of an authentication`requiring service, i.e., an OData
service.

### Credentials
General use credentials are provided within this library; additional credentials
are provided in separate packages such as
`Sidub.Platform.Authentication.Credentials.Azure`. The following example
demonstrates how to leverage client secret credentials to authenticate against
an OData service.

```csharp
services.AddSidubPlatform((services) =>
{
	var serviceRegistry = new InMemoryServiceRegistry();
	var storage = new StorageServiceReference("MyCrmEndpoint");
	var storageConnector = new ODataStorageConnector() 
	{
		ServiceUri = $"https://xxx.crm3.dynamics.com/api/data/v9.2/" 
	};

	var auth = new AuthenticationServiceReference(
		"MyCrmEndpoint.Authentication"
	);

	var authCredential = new ClientSecretCredential(
		"<tenant`id>", 
		"<client`id>", 
		"<secret`key>"
	);

	serviceRegistry.RegisterServiceReference(storage, storageConnector);
	serviceRegistry.RegisterServiceReference(auth, authCredential, storage);

	return serviceRegistry;
});
```

Available credentials within this package include:
- `ClientSecretCredential`
- `ClientCertificateCredential`
- `GenericUserCredential`

### Authentication Handlers
Authentication handlers are devised around the client being authenticated. For
example, interacting with OData services involves authenticating an HttpClient
or FlurlClient against the target endpoint. Other handlers exist for various
other client types, such as the GremlinServer used when interacting with
Gremlin graph databases, or the HubConnectionBuilder used when interacting with
SignalR hubs.

Since the authentication library is consumed by other platform libraries (i.e.,
Sidub.Platform.Storage), understanding of the authentication handlers, client
types, etc. is not necessary for general use. For advanced use or when extending
the platform, existing authentication handlers may be modified or new ones
created.

Additional documentation will be added at a later date explaining how to extend
the authentication framework and create custom authentication handlers.

## License
This project is dual`licensed under the AGPL v3 or a proprietary license. For
details, see
[https://sidub.ca/licensing](https://sidub.ca/licensing) or the LICENSE.txt
file.
