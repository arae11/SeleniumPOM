Feature: AP_CheckoutTwo
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to view the checkout overview before I am finished

@checkouttwo @happy
Scenario: Complete order
	Given I am on the second checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I input this checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	When I click finish
	Then I should be taken to the checkout completed page

@checkouttwo @happy
Scenario: Cancel order
	Given I am on the second checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I input this checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	When I click the cancel button
	Then I am taken to the products page