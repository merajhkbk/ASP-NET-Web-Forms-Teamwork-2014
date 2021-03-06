<p align="center"><a href="http://academy.telerik.com/"><img src="https://raw.github.com/flextry/Telerik-Academy/master/Programming%20with%20C%23/Codes/Other/Telerik.png" /></a></p>

---

# ASP.NET Web Forms <br /> Team Projects – October, 2014

## Contributors:
* Martin Nikolov ([@ flextry](https://github.com/flextry))
* Milan Drumev ([@ drumev](https://github.com/drumev))
* Ivaylo Hristov ([@ Ivaylo1987](https://github.com/Ivaylo1987))
* Plamen Georgiev ([@ plamengeorgiev](https://github.com/plamengeorgiev))

## Diagram:
* [See diagram of the application](https://github.com/Team-Charlotte-Bronte/ASP-NET-Web-Forms-Teamwork-2014/blob/master/Bookie/Readme.md#diagram)

## Project Description

Design and implement a **data-driven ASP.NET Web Forms application**. It can be a discussion forum, blog system, e-commerce site, online gaming site, social network, or any other Web application by your choice. 

The application should have **public part** (accessible without authentication), **private part** (available for registered users) and **administrative part** (available for administrators only).

## General Requirements

Your Web application should use the following technologies, frameworks and development techniques:

*	Your UI should use **server-side Web Forms** UI rendering (ASPX pages and ASCX controls)
  * ASP.NET MVC and JavaScript UI controls are not allowed
*	Use **MS SQL Server** as database back-end
*	Use **Entity Framework** to access your database
*	Use **data-binding** technique by choice. You are free to use data-source controls (like **EntityDataSource** and **ObjectDataSource**), model binding or manual binding in the C# code behind pages.
*	Use at **least two data grids** (table-like data UI components) with **server-side paging** and **sorting**
*	Adapt the **default ASP.NET Web site template** from Visual Studio 2013
  * You may use **Twitter Bootstrap** (http://telerikacademy.com/Courses/Courses/Details/184)
  * You may change the standard theme and modify it to apply own web design and visual styles
*	Use a **Master page** to define the common UI for the public, private and administrative parts
*	Use **Sitemap** and navigational UI controls to implement site navigation
*	Use the standard **ASP.NET Identity System** for managing **users** and **roles**
  * Your registered users should have are least two roles: **user** and **administrator**
*	Use the standard **ASP.NET Web Forms controls** (from **System.Web.UI**)
  * External UI controls from Telerik / Infragistics / DevExpress / etc. are not allowed
*	Use **UpdatePanels** and **AJAX** where applicable to avoid full postbacks
*	Apply **error handling** and **data validation** to avoid crashes when invalid data is entered
*	Handle correctly the **special HTML characters** and tags like **<br />**
*	Use at least **two ASCX user controls** that encapsulate some functionality
*	Use at least one **file upload** form to send files at the server side (e.g. profile photos for your users)
*	Use **caching** of data where it makes sense (e.g. starting page)
