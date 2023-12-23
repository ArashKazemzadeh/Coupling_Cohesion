# Modularization | Coupling and Coheison
***
## Hi there 👋
Niloo Mont Here [About Me](https://www.linkedin.com/in/niloufar-mont/)
I'm a dotnet enthusiast, I'm looking for chances to boost my know-how and abilities.

#### Implemented Coupling Types:
**No-direct coupling** : Modules do not depend on each other, however there is external coupling to ISendNotification
**Data coupling** : Modules share an argument. In my case: ip
**Stamp coupling** : Modules share a structure. In my case: product1
**Control coupling** : Modules pass control information. In my case: isAdmin
**External coupling** : A module depends on an external resource. In my case: Product depends on IShippingService.
**Common coupling** : Modules share an external resource. In my case a file.
**Content coupling** : The content of a module's member memeber is changed by another module. In my case password.

#### Implemented Cohesion Types:
**Functional Cohesion** : ProductManager has everything it needs in its own scope.
**Sequential Cohesion** : getPremiumCustomers get the output of GetAdultCustomers as input.