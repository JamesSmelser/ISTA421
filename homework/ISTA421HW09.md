// Name: ASPNET HW09
// Author: James Smelser
// Date: September 23, 2019

------------------------------------------------------------------
# ASP.NET Programming Homework 09
## Chapter 09, Pro ASP.NET Core MVC 2
### Homework
#### Readings
##### Read chapter 09, in the Pro ASP.NET Core MVC 2 book.
###### Discussion Questions
1. In the Configure() method of the Startup.csfile, note the four map routes defined in the book. (1)
What is the difference in the definitions of the four routes defined? (2) How are the routes ordered? (3)
Why does it matter that the routes are ordered this way?
- The templates are different and ordered from category to page, so the category can be displayed in the URL.
2. When you define tag helpers, you can specify a prefix for the attribute name. (1) What happens when
you define several attributes with the same prefix? (2) What is the benefit of doing this?
- Decorating a tag helper property with the HtmlAttributeName attribute allows me to specify a prefix
for attribute names on the element, The value of any attribute whose name begins with this prefix will be added to the dictionary that
3. How does using the attribute page-url-category benefit the application? Be specific with your answer
and give an example.
- The current category will be passed to the List action method, and the filtering will be preserved.
4. What is a view component and what purpose do view components have in building a web application?
- A view component is a C# class that provides a small amount of reusable application logic with the ability to select and display Razor partial views.
5. The book notes that you can build a list of categories programmatically or use the more expressive
"Razor syntax" to render the HTML. What do you think that this means?
- one of the benefits of working with view components is they can render Razor partial views. That means I can use the view component to generate the list of components and then use the more expressive Razor syntax to render the HTML that will
display them.
6. What does @await Component.InvokeAsync("InformationSidebar") do?
- Returns a partial view of the InformationSidebar.
7. Describe the functionality of the RouteData property of the ViewComponent class, and give a concrete
example of that functionality.
- One of the properties is called RouteData, which provides information about how the request URL was handled by the routing system. RouteData property accesses the request data in order to get the value for the currently selected category.
8. What is the purpose of session state, and how does the Sports Store application use session state?
- Session state associates data with a session. The store details of a user’s cart using session state, which is data that is stored at the server and associated with a series of requests made by a user.
9. Describe model binding and give a specific example. Explain how model binding relates form elements,
HTTP query requests, variables, and properties.
- Model binding is a mechanism used to create parameter objects defined in controller action methods.
10. What does the RedirectToAction() method do?
- This has the effect of sending an HTTP redirect instruction to the client browser, asking the browser to request a new URL.
