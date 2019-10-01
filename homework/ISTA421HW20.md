// Name: C# HW 20
// Author: James Smelser
// Date: September 12, 2019

------------------------------------------------------------------
# Homework, ISTA-421
## Chapter 20, C# Step by Step
### Readings
#### Read chapter 20, pages 439 - 466 in the C# Step by Step book.
##### Discussion Questions
1. What is a delegate? Explain delegates in terms of pointers and reference types.
- A delegate is a type safe object that is assigned a reference to a method or methods.
2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.
- Use the delegate keyword, specify the return type name the delegate and any parameters.
3. How do you create instances of delegates and assign values to the instance? What are the values?
- After you have declared the delegate, you can create an instance and make it refer to a matching
method by using the += compound assignment operator.
4. How do you invoke a method that has been added to a delegate?
- You use the same syntax to invoke a delegate as you use to call a method.
5. What is an event? Why do we have events?
- Events enable a class or object to notify other classes or objects when something of interest occurs.
6. How do you declare events?
- You declare an event in a class intended to act as an event source. An event source is usually a class that
monitors its environment and raises an event when something significant happens. (machine temp class)
7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?
- You subscribe to an event by using += operator. You unsubscribe to an event by using -= operator.
8. How do you raise an event? How do you declare code that raises an event?
- You can raise an event by calling it like a method. When you raise an event, all the attached delegates
are called in sequence.
9. Explain with specificity what happens when an eventfires and that event has been attached to a
delegate.
- All methods that are assigned to the event run.
