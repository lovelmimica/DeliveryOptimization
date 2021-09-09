# Delivery Optimization

Project made on professional internship period at one Croatian IT company. Developed in C# and Windows Forms framework, it optimizes delivery routes for given destinations, vehicles and cargo. 

Application organizes the delivery trip from one warehouse to many customer addresses. 
On the basis of user input which represents collection of locations/addresses and number of delivery vehicles, downloads distances between locations (from Google Maps API) and organizes relativley short trip plan, which "covers" all destinations (using Dijkstra's algorithm). Trip plan is also represented in GUI by .jpg files which are downloaded after the alogrith execution.   
