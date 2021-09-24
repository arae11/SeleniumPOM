# Selenium POM Mini Project

## How I set it up

This project involved implementing Selenium, SpecFlow, and NUnit to thoroughly test the following website: https://www.saucedemo.com/. 
The aim of the project was to further develop our ability to utilise these tools in a realistic environment, making use of user stories to create a test suite.
The following packages were used in the Visual Studio IDE to perform the project:

| Package                                   | Version        |
| ----------------------------------------- | -------------- |
| BoDi                                      | 1.5.0          |
| Cucumber.Messages                         | 6.0.1          |
| Gherkin                                   | 19.0.3         |
| Google.Protobuf                           | 3.7.0          |
| NUnit                                     | 3.13.1         |
| NUnit3TestAdapter                         | 4.0.0          |
| Selenium.WebDriver                        | 3.141.0        |
| Selenium.WebDriver.ChromeDriver           | 93.0.4577.6300 |
| SpecFlow                                  | 3.9.22         |
| SpecFlow.Internal.Json                    | 1.0.8          |
| SpecFlow.NUnit                            | 3.9.22         |
| SpecFlow.Plus.LivingDocPlugin             | 3.9.57         |
| SpecFlow.Tools.MsBuild.Generation         | 3.9.22         |
| System.Configuration.ConfigurationManager | 5.0.0          |
| System.Security.AccessControl             | 5.0.0          |
| System.Security.Permissions               | 5.0.0          |
| System.Security.Principal.Windows         | 5.0.0          |
| System.ValueTuple                         | 4.4.0          |

In addition to this, LivingDoc's was used in collaboration with SpecFlow to provide documentation that would allow stakeholders to interact with the Gherkin feature files without the need of developer tool familiarity.



## What I tested

Selenium was used as the web driver to capture and record steps taken in the browser. This automatic tool allowed for the use of NUnit to test the steps taken to create a comprehensive test suite. In addition to this, the project was conducted in a BDD (Behaviour Driven Development) approach utilising SpecFlow. This framework allows you to create Gherkin syntax scripts that can be converted into NUnit tests. Each page on the sauce demo website was tested. This involved implementing a design pattern in Selenium called the Page Object Model. This required separating each page into its own object through the creation of a class page. Each class page contained elements of the website which were interacting with selenium as a result of the Gherkin syntax which was directing the web driver. This created individual tests for each instruction in each scenario.

In order to keep the code dry I implemented a base class called `AP_SharedSteps` which contained all the methods which could occur more than once. Every subsequent step class would inherit this information, reducing the amount of duplicate code. In order to keep the code damp each method was named appropriately.

## User Journeys

As the website being tested on was very basic there were not many user journeys that I could have created. I decided on using the most common one which would be purchasing an item in the store, in this particular journey the item was a backpack.

User Journey:

> As a registered user of the sauce demo website
> I want to be able to purchase a sauce labs backpack
> So that I can waste money

Gherkin Syntax:

> ```c#
> Given that I have logged in
> 	| Username      | Password     |
> 	| standard_user | secret_sauce |
> When I click add to cart on the backpack
> And I click the shopping cart button
> And I click checkout
> And I enter the following checkout information
> 	| FirstName | LastName | PostalCode |
> 	| Alex      | Rae      | SL5        |
> And I click the continue button
> And I click finish
> Then I should be taken to the checkout completed page
> ```

As I had already implemented these scenarios in previous testing, all the code is located in the `SharedSteps` class.



## Class diagram

![class diagram](https://user-images.githubusercontent.com/60930006/134529637-0e40c570-acd4-4747-a27c-55ed0dc86318.png)

## 

## LivingDoc's

![livingdoc](https://user-images.githubusercontent.com/60930006/134525914-f0e5da9e-9498-4394-b318-ef9b9960c5d9.png)



## Retrospective

If I were to do a similar project in the future I would have done a few things differently from the start. Initially, I didn't implement any inheritance which was causing a lot of errors when running the tests in addition to having to rewrite a lot of code. In the future I would implement inheritance from the start to avoid this. Furthermore, I found that every test I ran would create multiple instances of Google Chrome. This made it extremely taxing on my PC and more importantly took a long time to test. To fix this I implemented `[assembly: Parallelizable(ParallelScope.Fixtures)]` and 
`[assembly: LevelOfParallelism(8)]` to my base class. This allowed me to run multiple tests at the same time and fully utilise the threads available on my CPU. Additionally, I found that the `.Quit()` method called `.Dispose()` which was also slowing down the testing process. The addition of the assembly's and removal of `.Dispose()` reduced my testing time by approximately 50%. This would have saved a lot of initial testing time so I will make sure to include this in future projects. 
If I were to carry on with this project I would create some sad path user journeys. As I had already tested them I would only need to implement them, however given the scope of the exercise this is unnecessary.
