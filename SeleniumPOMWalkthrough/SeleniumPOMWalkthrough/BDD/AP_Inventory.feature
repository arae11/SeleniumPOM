Feature: AP_Inventory
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to add items to my basket

@inventory
Scenario: Add item to cart
	Given I am on the homepage
	And I enter the following credentials
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I enter these credentials
	And I click the login button
	When I click add to basket 
	Then the shopping cart number increases by 1