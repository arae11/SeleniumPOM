Feature: AP_Cart
	Simple calculator for adding two numbers

@cart
Scenario: Go to checkout
	Given I am on the cart page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click checkout
	Then I am taken to the checkout page

Scenario: Go to products page
	Given I am on the cart page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click continue shopping
	Then I am taken to the products page