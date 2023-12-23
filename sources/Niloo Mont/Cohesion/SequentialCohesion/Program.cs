using Dumpify;
using SequentialCohesion;
CustomerManagement customerManagement = new ();

customerManagement.getPremiumCustomers(customerManagement.GetAdultCustomers()).Dump();
