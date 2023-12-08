# Making of Dapr With Azure functions

## What is Dapr
<p>It aims to simplify microsercie connectivity.
It is a self hosted open source project that offers extra functionality to cloud native applications through APIs called as building blocks that simplify microservice connectivity.

In very brief it make us able to manage , configure , Observe and Secure the APIs in a more easy fashion as it act as middle layer between the API code and the Infra that is their that is cloud or may be self hosted Kubernetes containers.

It uses Side Car Pattern to integrate the application where the sidecar and the Application COmmunicate using HTPP/gRRC over the local host 
</p>
<img src="https://miro.medium.com/v2/resize:fit:720/format:webp/1*BhaMxzQb6KnsgZnr8POGoA.png"/>

<p>
The Building blocks provide implemnetation for micro services best plactices without much work.

Like

<li>Service Service Incocation :- Provide Reliable and Secure service to service invocation with build in service discovery.

Actors:- Highly Concurrent system we can use the Actor Pattern , which is a lightweight concurrent entities taht communicate with other asynchornously in an event diven manner.

State Management :- It store the save , read and query key/value pair and enable services to be sateful.

Pub SUub :- With each other messaging system . The Pub and Sub modules support dead letter queus nd at least once message delivery to every subscriber.

Binding :- The way to trigger or get triggered by extrenal system such as DB , Quesue and File System Support.

Secret:- A resiliance and secure apu that make them to communicate and get the credentials in a clean and secure way.

Distributed Locks:- Able to easily change the Resources and get update in each of the units easily.</li>

</p>

### Help Focus on Buisness Logic.

<p>As mentioned things are made and managed by dapr it make the APIs be focus on the logics only and that make it beeter to make integartion be responsible and make code free from many SDKs and Libraries to integrate.

Make use of Highly Responsive and Data Cosistent
</p>

### Flexibility 

<p>It make rhe dapr be in a way taht it make it is easy to configure and manage different language apis.</p>

### Observabilitu
<p>It make a integrated logging capabilites.
It enables the API logging with the --enable-API-logging switch.

Enabiling profiling in Dapr wioll create an endpoint , From where we can easily route the Telemetry. </p>

<img src="https://miro.medium.com/v2/resize:fit:640/format:webp/1*vCKJ69hYs0IPfAfhuUJl9A.png"/>