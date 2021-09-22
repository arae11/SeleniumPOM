Feature: AP_Inventory
	Simple calculator for adding two numbers

@Inventory
Scenario: Go to my cart
	Given that I have logged in with the following credentials
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click the shopping cart button
	Then I am taken to my cart

@Inventory
Scenario: Add item to cart
	Given that I have logged in with the following credentials
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click add to cart on the backpack
	Then the shopping cart number increases
