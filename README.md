# C-Advanced-Topics
Prepare for Technical Interviews

DELEGATES
They are just like a class but not a class. They are reference types. 
1. We create them.
2. We declare them by creating a reference type and then initialize them by assigning to a method of similar signature.
3. Then we invoke them which as a result will invoke all the assigned methods to a delegate.
4. They are used for extension of the class methods without disturbing the existing class and also used for creating events.
5. For extension, we invoke then in a class but assign methods which are also called subscribes, outside the class.

EVENTS
1. They follow a publisher subscriber pattern.
2. It means you can only subscribe or unsubcribe from an event. But you cannot modify it.

PUB SUB
1. Create an EventHandler in Main Class
2. Invoke the event after putting null check for event reference. Invoke it after the method completion, where you want to notify the subscribers.
3. Create reference for that event by assigning method signatures in the object.

