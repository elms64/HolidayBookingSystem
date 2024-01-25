
Holiday Booking System. Group project for the BSc Computing Class of 2024 at University Centre Farnborough.

This is a two part system consisting of a Winforms application to interface with the end user and a .NET Console application that performs back-end functions and maintains communication with the front-end using HTTP. Unfortunately the front-end team were unable to complete their contribution to the project sufficiently. However, the backend team did develop a console based client emulator that can be used to demonstrate the transfer of information between the two programs.

This is an offline system that requires a LAN connection between Program 1 and 2 to operate. The system is designed to run Program 1 and 2 on separate machines but is currently set up to run on one machine. Distributing the system is a matter of network administration and replacing the target IP addresses in code as required. 

The purpose of the project was to develop a distributed system, adhering to certain constraints. Firstly, a recovery mode that triggers in the event of failure and allows transactions to be batch processed. Secondly, the system must consist of two programs that communicate with eachother, one performing backend processing and the other accepting input from the end user. And finally, the system must communicate over a LAN without accessing the web or any modern cloud based solutions. Overall, this was achieved and can be demonstrated through the use of the ClientEmulator application alongside the BookingProcessor application. A demonstration video has been included for reference.



