# ExampleService
## ExampleService.Api
  This project defines our service's client interface and maps it to/from our domain models.  Everything "web" related should go here (encapsulating it from our domain layer).
  * **Controllers**
    * Mapping domain models to our api method signatures
  * **RequestModels**
    * The structure of requests coming into our service
  * **ResponseModels**
    * The structure of responses being returned from our service
## ExampleService.Domain
  This project contains all our service's business logic. It is the cental hub of the service and therefor defines the interfaces for everything it interacts with.
  * **DomainModels**
    * The definition of models, as defined by our service.  These are not dictated by external dependencies nor interfaces to our service's clients.
  * **InfrastructureInterfaces**
    * The definition of external dependencies that our business service relies on.  These are dictated by the domain layer, not the infrastructure layer.
  * **InfrastructureModels**
    * The definition of models to/from our infrastructure service layer. These should not be dictated by the services our infrastructure layer calls - only what our domain layer wants to receive from our infrastructure layer.
## ExampleService.Infrastructure
  This project contains all the logic related to calling external dependencies, including mapping to/from their interfaces.  Anything relating to external dependencies should go here (encapsulating it from our domain layer).
  * **ServiceRequestModels**
    * Any request objects that are necessary to call external services
  * **ServiceResponseModels**
    * Any response objects that are necessary to read responses from external services
    
