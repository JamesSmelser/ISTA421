// Name: ASPNET HW08
// Author: James Smelser
// Date: September 15, 2019

------------------------------------------------------------
# ASP.NET Programming Homework 08
## Chapter 08, Pro ASP.NET Core MVC 2
### Homework
#### Readings
##### Read chapter 08, in the Pro ASP.NET Core MVC 2 book.
###### Discussion Questions
1. What is the purpose of the Startup class in an MVC application?
- The Startup class is responsible for configuring the ASP.NET Core application.
2. What is the purpose of the ConfigureServices() method?
- The ConfigureServices method is used to set up shared objects that can be used throughout the
application through the dependency injection feature.
3. What is the purpose of the AddMvc() method?
- The AddMvc method that I call in the ConfigureServices method is an extension method that sets up
the shared objects used in MVC applications.
4. What does the book describe as the "heart of an MVC application?" Why do you think that this
"heart" is the starting point of all applications?
- All projects start with the domain model, which is the heart of an MVC application.
5. What is the purpose of the Queryable<T> interface? What does it allow you to do?
- This interface uses IQueryable<T> to allow a caller to obtain a sequence of Product objects.
6. How does the book describe loosely coupled components? Why is this an important principle of software
design?
- which means you can make a change in one part of the application without having to make corresponding changes elsewhere.
7. What, specifically, does the AddTransient() method do?
- The AddTransient method specifies that a new FakeProductRepository object should be created each time the IProductRepository interface is needed.
8. Describe dependency injection? What is the dependency? What does it mean to say that it is injected?
- This is known as dependency injection, and its approach allows the ProductController constructor to
access the application’s repository through the IProductRepository interface without having any need to
know which implementation class has been configured.
9. What is the purpose of a shared layout?
- Shared layouts are a useful way of ensuring that views are consistent and contain important JavaScript files and CSS stylesheets
10. What is a database context class? What purpose does it serve?
- The database context class is the bridge between the application and Entity Framework Core and provides
access to the application’s data using model objects.
11. What function does the EnsurePopulated() method perform?
- The static EnsurePopulated method receives an IApplicationBuilder argument, which is the interface
used in the Configure method of the Startup class to register middleware components to handle HTTP
requests, and this is where I will ensure that the database has content.
12. What is a ViewModel? How does a ViewModel differ from an ordinary model?
- View model class, is used specifically to pass data between a controller and a view.
13. Describe in your own words a composable URL. Note that it is not an answer to this question to say
that it is one that makes sense to a user.
- Composable infrastructures create pools of virtualized resources that are automatically composed in near real time to meet compute needs.
14. What is a partial view? Illustrate the concept of a partial view with an example other than the one
used in the book.
- partial view, which is a fragment of content that you can embed into another view, rather like a template.
