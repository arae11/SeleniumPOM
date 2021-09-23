Feature: AP_CheckoutComplete
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to see confirmation of my order

@checkoutcomplete
Scenario: Go back to the products page from complete checkout
	Given I am on the checkout complete page
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I input this checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	And I click finish
	When I click the back home button
	Then I am taken to the products page
