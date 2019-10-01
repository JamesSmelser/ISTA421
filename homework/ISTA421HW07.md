// Name: ASPNET HW 07
// Author: James Smelser
// Date: September 09, 2019

-------------------------------------------------------------
# ASP.NET Programming Homework 07
## Chapter 07, Pro ASP.NET Core MVC 2
### Homework
#### Readings
##### Read chapter 07, in the Pro ASP.NET Core MVC 2 book.
###### Discussion Questions
1. There are many kinds of tests, including Unit Tests. What is a unit test, and what does it enable you
to do?
- Unit tests are used to validate the behavior of individual components and features in an application.
2. What is the primary benefit of using unit tests?
- Verifies that the result was the one that was expected.
3. What is the purpose of using method GetHashCode() when using Assert.Equal()?
- This method asserts that the result is equal to the expected outcome. To create a hashed value
usually used for comparison to like values.
4. The book states: "The chain of dependencies can make it difficult to understand what causes a test
to fail." Why is this statement true?
- Makes it difficult to figure out whether the test is revealing a problem with the class it is intended to target or a problem with another part of the application.
5. How do unit tests isolate small parts of an application?
- Arrange create objects to be tested, Act test the objects, Assert actual outcome is equal to the expected outcome.
6. According to the book, what is the key to isolating components?
- Creating interfaces.
7. Briefly discuss the nature and purpose of a fake implementation of a class. What does a fake implementation
do that a real implementation cannot do?
- Isolating components effectively requires fake implementations of classes to provide test data or to check
that a component behaves the way it should.
8. What is test driven development? What is the development cycle for test driven development? This is
not in the book.
- Add a test, Run all tests and see if the new one fails, Write some code, Run tests, Refactor code, Repeat.
9. What are parameterized tests and why would we want to use them?
- The data used in a test is removed from the test so that a single method can be used for multiple tests.
10. What is a mocking framework? What is the difference between a fake object and a mock object?
- Creating fake objects gets out of hand, and the best way to get things back under control is to
use a fakes framework, also known as a mocking framework.
11. (Optional) Can you think of one very important drawback to writing unit tests?
- Time. cyclomatic complexity, excessive possible paths to test.
