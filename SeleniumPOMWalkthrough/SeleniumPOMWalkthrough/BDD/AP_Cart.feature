Feature: AP_Cart
	Simple calculator for adding two numbers

@cart
Scenario: Go to checkout
	Given I am on the cart page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click checkout
	Then I am taken to the checkout page