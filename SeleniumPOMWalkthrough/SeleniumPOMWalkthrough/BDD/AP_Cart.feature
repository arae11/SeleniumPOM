Feature: AP_Cart
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to checkout my items

@cart
Scenario: Valid login
	Given I am on the homepage
	And I enter the following credentials
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I enter these credentials
	And I click the login button
	And I am logged in and sent to the inventory page
	Then 