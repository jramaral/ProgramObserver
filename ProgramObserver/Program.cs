// See https://aka.ms/new-console-template for more information

using ProgramObserver.Observable;

//create a subject
Subject subject = new Subject();

//create observers
Observer observer1 = new Observer("Observer 1");
Observer observer2 = new Observer("Observer 2");

//Register observers with the subject
subject.RegisterObserver(observer1);
subject.RegisterObserver(observer2);

//notify observers of a state change
subject.NotifyObservers("state changed!");

//unregister an observer
subject.UnregisterObserver(observer1);

//notify observers again
subject.NotifyObservers("state change again!");


Console.WriteLine("Hello, World!");