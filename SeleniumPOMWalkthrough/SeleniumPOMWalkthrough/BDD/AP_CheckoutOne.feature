Feature: AP_CheckoutOne
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to input my checkout information

@mytag
Scenario: Valid checkout fields
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter valid checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	And I click the continue button
	Then I should be taken to the checkout step two page