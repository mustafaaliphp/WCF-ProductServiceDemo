# WCF-ProductServiceDemo
WCF is a framework, which is used for creating service where you can send the data from one end point to another.
In WCF developer can create one single service that can be consumed by different clients- either they want same protocol or a different protocol.

* WCF consists of:<br/>
1- WCF Service : What is the service and what it is providing.<br/>
2- WCF Service host: Where is the Service hosted.<br/>
3- Service Client: Who is the client of the Service.<br/>

# Why WCF?
* Distributed Application
It means those Applications, which do not run only on single system but can run on multiple systems, which are connected over the network. For example, a Web Service that can consume by different clients.

* Interoperable
It means that an Application can consume or connect with another Application but it does not matter in which platform it is developed.

# Fundamentals of WCF
* Message: is the communication unit, as it is in the form of an envelop. The transmission of the data from the client to Service and Service to client is being done by envelop. The envelop or message has the sections, header and body.
* Endpoint: is a very essential part of WCF Application, as it describes the address of Web Service from where a user can receive and send the message. It also specifies the communication mechanism of how the message will be sent or received.
End point consists of three things:<br/>
Address: is the address of WCF Service, where the Service is hosted? It gives the exact URL of Web Service, where the Service hosts the pattern of URL.
Binding: It describes the way or mechanism by which the user will communicate with Web Service. It constitutes some binding element, which creates the structure of communication such as some transport protocols like HTTP, TCP etc. Message format or security techniques etc.<br/>
Contract: is the third important question. What functionality and operation is being provided by  the service is called contract. It specifies what functionality and operations are need to be exposed to the client. It is the interface name which has all operation that need to be exposed.<br/>
